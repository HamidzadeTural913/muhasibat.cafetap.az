﻿using DataAccess.Pagination;
using Domain.Models;
using MediatR;

namespace Infrastructure.PrePayments.Queries
{
    public class GetAllPrePaymentsQuery:IRequest<PaginatedList<PrePayment>>
    {
        public GetAllPrePaymentsQuery(int page, int size)
        {
            Page = page;
            Size = size;
        }

        public int Page { get; set; }
        public int Size { get; set; }
    }
}
