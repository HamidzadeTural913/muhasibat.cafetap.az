using System.Threading.Tasks;
using CafeTap.Controllers.Base;
using Infrastructure.EmployeeFaults.Commands;
using Infrastructure.EmployeeFaults.Queries;
using Infrastructure.EmployeeFaults.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CafeTap.Areas.Panel.Controllers
{
    [Area("Panel")]
    [Route("[area]/[controller]/[action]")]
    public class EmployeeFaultsController : MyController
    {

        [HttpGet]
        [Route("")]
        [Route("{id:int:min(1)}/{page:int:min(1)}")]
        public async Task<IActionResult> EmployeeFaults(int id, int page = 1)
        {
            var query = new GetFaultsOfEmployeeQuery(id, page, 20);
            var result = await Mediator.Send(query);

            return View(result);
        }

        [HttpGet]
        public IActionResult Add(int id)
        {
            var model = new CreateEmployeeFaultVm()
            {
                EmployeeId = id
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(CreateEmployeeFaultVm model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var command = new CreateEmployeeFaultCommand(model);
            var result = await Mediator.Send(command);

            if (!result.Success)
            {
                AddError(result.Errors);
                return View(model);
            }

            return RedirectToAction(nameof(EmployeeFaults), new { id = result.Entity });
        }


        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var query = new GetEmployeeFaultToUpdateQuery(id);
            var model = await Mediator.Send(query);

            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> Update(UpdateEmployeeFaultVm model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var command = new UpdateEmployeeFaultCommand(model);
            var result = await Mediator.Send(command);

            if (!result.Success)
            {
                AddError(result.Errors);
                return View(model);
            }

            return RedirectToAction(nameof(EmployeeFaults), new { id = result.Entity });
        }


        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var command = new DeleteEmployeeFaultCommand(id);
            var result = await Mediator.Send(command);

            if (!result.Success)
            {
                AddError(result.Errors);
                return RedirectToAction(nameof(EmployeeFaults), new { id = result.Entity });
            }

            return RedirectToAction(nameof(EmployeeFaults), new { id = result.Entity });
        }

    }
}
