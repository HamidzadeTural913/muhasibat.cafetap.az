using System;
using Infrastructure.Common;

namespace Infrastructure.Statistics.SqlQueries
{
    public static class SqlQuery
    {
        public static string InComePerMonthQuery(DateTime start, DateTime finish)
        {
            var startDate = start.GetSqlDateTimeFormat();
            var finishDate = finish.GetSqlDateTimeFormat();
            var query =
                $"declare @startDate datetime ;declare @endDate datetime; set @startDate = '{startDate}'; set @endDate = '{finishDate}' ; with monthlyRange (startMonth, startNextMonth) as (select dateadd (m, datediff (m, 0, @startDate), 0),dateadd (m, datediff (m, 0, @startDate) + 1, 0) union all select dateadd (m, 1, startMonth), dateadd (m, 1, startNextMonth) from monthlyRange where startNextMonth <= dateadd (m, datediff (m, 0, @endDate), 0)) SELECT Year(monthlyRange.startMonth) Year, Month(monthlyRange.startMonth) Month, ISNULL(SUM(ContractPayments.Amount),0) Total FROM monthlyRange left join ContractPayments on monthlyRange.startMonth <= ContractPayments.PaidAt and monthlyRange.startNextMonth > ContractPayments.PaidAt GROUP BY Year(monthlyRange.startMonth), Month(monthlyRange.startMonth) order by 1, 2";


            return query;
        }


        public static string SpendPerMonthQuery(DateTime start, DateTime finish)
        {

            var startTime = start.GetSqlDateTimeFormat();
            var finishTime = finish.GetSqlDateTimeFormat();
            var query =
                $"declare @startDate datetime; declare @endDate datetime; set @startDate = '{startTime}'; set @endDate = '{finishTime}'; with monthlyRange (startMonth, startNextMonth) as (select dateadd (m, datediff (m, 0, @startDate), 0),dateadd (m, datediff (m, 0, @startDate) + 1, 0) union all select dateadd (m, 1, startMonth), dateadd (m, 1, startNextMonth) from monthlyRange where startNextMonth <= dateadd (m, datediff (m, 0, @endDate), 0))SELECT Year(monthlyRange.startMonth) Year, Month(monthlyRange.startMonth) Month, ISNULL(SUM(Spends.Amount),0) Total FROM monthlyRange  left join Spends on monthlyRange.startMonth <= Spends.SpentAt and monthlyRange.startNextMonth > Spends.SpentAt GROUP BY Year(monthlyRange.startMonth), Month(monthlyRange.startMonth) order by 1, 2";

            return query;
        }

        public static string IncomeThatEmployeeMadePerMonth(DateTime startTime, DateTime endTime, int employeeId)
        {
            var start = startTime.ToAzDateTime().GetSqlDateTimeFormat();
            var end = endTime.ToAzDateTime().GetSqlDateTimeFormat();
            var query =
                $"declare @startDate datetime; declare @endDate datetime; set @startDate = '{start}'; set @endDate = '{end}'; with monthlyRange(startMonth, startNextMonth) as (select dateadd (m, datediff(m, 0, @startDate), 0),dateadd(m, datediff(m, 0, @startDate) + 1, 0) union all select dateadd(m, 1, startMonth), dateadd(m, 1, startNextMonth) from monthlyRange where startNextMonth <= dateadd(m, datediff(m, 0, @endDate), 0)) SELECT Year(monthlyRange.startMonth) Year, Month(monthlyRange.startMonth) Month, ISNULL(SUM(cp.Amount), 0) Total FROM monthlyRange left join(select EmployeeId, ContractId, Amount, PaidAt from Contracts as c inner join ContractPayments cpp on c.Id = cpp.ContractId) as cp  on monthlyRange.startMonth <= cp.PaidAt and monthlyRange.startNextMonth > cp.PaidAt and cp.EmployeeId = {employeeId} GROUP BY Year(monthlyRange.startMonth), Month(monthlyRange.startMonth) order by 1, 2;";

            return query;
        }

        public static string InComePerYearAndContractType(DateTime startTime, DateTime endTime, int contractType)
        {
            startTime = startTime.ToAzDateTime();
            endTime = endTime.ToAzDateTime();
            
            var query =
                $"declare @startDate datetime;declare @endDate datetime;set @startDate = '{startTime}';set @endDate = '{endTime}';declare @contractType int;;set @contractType = {contractType}; ; with yearlyRange (startYear, startNextYear) as (select dateadd (YEAR ,datediff (YEAR, 0, @startDate), 0), dateadd (YEAR, datediff (YEAR, 0, @startDate) + 1, 0) union all select dateadd (YEAR, 1, startYear), dateadd (YEAR, 1, startNextYear) from yearlyRange where startNextYear <= dateadd (YEAR, datediff (YEAR, 0, @endDate), 0)) SELECT Year(yearlyRange.startYear) Year, ISNULL(SUM(cp.Amount),0) Total, ISNULL(cp.ContractType, @contractType) as ContractType FROM yearlyRange left join (select EmployeeId, ContractId, Amount, PaidAt, ContractType from Contracts as c inner join ContractPayments cpp on c.Id = cpp.ContractId) as cp on yearlyRange.startYear <= cp.PaidAt and yearlyRange.startNextYear > cp.PaidAt and cp.ContractType = @contractType GROUP BY Year(yearlyRange.startYear),cp.ContractType order by 1, 2;";

            return query;
        }

        public static string IncomePerMonthByDateAndContractType(DateTime startAt, DateTime endsAt, int contractType)
        {
            var start = startAt.ToAzDateTime().GetSqlDateTimeFormat();
            var end = endsAt.ToAzDateTime().GetSqlDateTimeFormat();

            var query =
                $"declare @startDate datetime;declare @endDate datetime;declare @contractType int;set @startDate = '{start}' set @endDate = '{end}'; set @contractType = {contractType}; ; with monthlyRange (startMonth, startNextMonth) as (select dateadd (m, datediff (m, 0, @startDate), 0), dateadd (m, datediff (m, 0, @startDate) + 1, 0) union all select dateadd (m, 1, startMonth), dateadd (m, 1, startNextMonth) from monthlyRange where startNextMonth <= dateadd (m, datediff (m, 0, @endDate), 0)) SELECT Year(monthlyRange.startMonth) Year, Month(monthlyRange.startMonth) Month,ISNULL(SUM(cp.Amount), 0) Total FROM monthlyRange left join (select EmployeeId, ContractId, Amount, PaidAt, ContractType from Contracts as c inner join ContractPayments cpp on c.Id = cpp.ContractId) as cp on monthlyRange.startMonth <= cp.PaidAt and monthlyRange.startNextMonth > cp.PaidAt and cp.ContractType = @contractType GROUP BY Year(monthlyRange.startMonth), Month(monthlyRange.startMonth) order by 1, 2";

            return query;
        }
    }
}
