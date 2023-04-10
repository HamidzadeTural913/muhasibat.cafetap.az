using System.Linq;
using System.Threading.Tasks;
using CafeTap.Controllers.Base;
using Infrastructure.Contracts.Queries;
using Infrastructure.RestaurantContacts.ViewModels;
using Infrastructure.RestaurantNetworks.Queries;
using Infrastructure.Restaurants.Commands;
using Infrastructure.Restaurants.Queries;
using Infrastructure.Restaurants.ViewModels;
using Infrastructure.RestaurantStatuses.Queries;
using Infrastructure.RestaurantStatuses.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CafeTap.Areas.Panel.Controllers
{
    [Area("Panel")]
    [Route("[area]/[controller]/[action]")]
    [Authorize(policy: "Restaurant")]

    public class RestaurantsController : MyController
    {
        [HttpGet]
        [Route("")]
        [Route("{page:int:min(1)}")]
        public async Task<IActionResult> Index(int page=1)
        {
            var query = new GetAllRestaurantQuery(page, 20);
            return View(await Mediator.Send(query));
        }

        [HttpGet]
        [Route("")]
        [Route("{name}/{page:int:min(1)}")]
        public async Task<IActionResult> SearchByName(string name,int searchOption, int page = 1)
        {
            switch (searchOption)
            {
                case 1:
                    ViewData["name"] = name;
                    var restaurantQuery = new GetAllRestaurantSearchByNameQuery(name, page, 10);
                    var restaurantQueryResult = await Mediator.Send(restaurantQuery);
                    return View(restaurantQueryResult);

                case 2:
                    return RedirectToAction("SearchByName", "Contracts", new { name, page });

                case 3:
                    return RedirectToAction("SearchByCityName", "Contracts", new {name, page});

                default:
                    return View("NotFound");
            }
        }

        [HttpGet]
        [Route("{id:int:min(1)}")]
        public async Task<IActionResult> GetById(int id)
        {
            var query = new GetRestaurantByIdQuery(id);

            var result = await Mediator.Send(query);

            if (result is null)
            {
                return View("NotFound");
            }

            return View(result);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var model = new CreateRestaurantInDetailsVm()
            {
                CreateRestaurantContactVm = new CreateRestaurantContactVm(),
                CreateRestaurantVm = new CreateRestaurantVm(),
            };
            var statusQuery = new GetRestaurantStatusSelectListQuery();
            var selectList = await Mediator.Send(statusQuery);
            var networksQuery = new GetRestaurantNetworkSelectListQuery();
            var networkResult = await Mediator.Send(networksQuery);
            model.CreateRestaurantVm.Networks = networkResult;
            model.CreateRestaurantVm.Status = selectList;
            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> Add(CreateRestaurantInDetailsVm model)
        {
            var statusQuery = new GetRestaurantStatusSelectListQuery();
            var selectList = await Mediator.Send(statusQuery);
            var networksQuery = new GetRestaurantNetworkSelectListQuery();
            var networkResult = await Mediator.Send(networksQuery);
            model.CreateRestaurantVm.Networks = networkResult;
            model.CreateRestaurantVm.Status = selectList;

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var command = new CreateRestaurantCommand(model);
            var result = await Mediator.Send(command);

            if (!result.Success)
            {
                AddError(result.Errors);
                return View(model);
            }

            return RedirectToAction(nameof(Index));
        }


        [HttpGet]
        public async Task<IActionResult> Update(int id, int networkId)
        {
            var query = new GetRestaurantToUpdateQuery(id,networkId);
            var result = await Mediator.Send(query);

            if (result == null)
            {
                return View("NotFound");
            }




            return View(result);
        }

        [HttpPost]
        public async Task<IActionResult> Update(int id, UpdateRestaurantVm model)
        {
            var q = new GetRestaurantToUpdateQuery(model.Id);
            var queryResult = await Mediator.Send(q);
            queryResult.StatusId = model.StatusId;
            queryResult.NetworkId = model.NetworkId;

            if (!ModelState.IsValid)
            {
                ErrorHandler();
                return View(queryResult);
            }
            var command = new UpdateRestaurantCommand(id, model);
            var result = await Mediator.Send(command);
            if (!result.Success)
            {
                ErrorHandler();
                return View(queryResult);
            }


            SuccessMessage("Restaurant edited successfully");
            return RedirectToAction(nameof(Index));
        }


        [HttpGet]
        public async Task<IActionResult> UpdateStatus(int id)
        {
            var query = new GetRestaurantsStatusToUpdateQuery(id);
            var model = await Mediator.Send(query);
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateStatus(UpdateRestaurantStatusVm model)
        {
            var query = new GetRestaurantStatusSelectListQuery(model.StatusId);
            model.Status = await Mediator.Send(query);

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var command = new GetRestaurantToUpdateStatusQuery(model);
            var result = await Mediator.Send(command);

            if (!result.Success)
            {
                AddError(result.Errors);
                return View(model);
            }

            return RedirectToAction(nameof(Index));
        }



        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var command = new DeleteRestaurantCommand(id);
            var result = await Mediator.Send(command);

            if (!result.Success)
            {
                FailMessages(result.Errors);
                return RedirectToAction(nameof(Index));
            }


            SuccessMessage("Restaurant delete was successful");
            return RedirectToAction(nameof(Index));
        }


    }
}
