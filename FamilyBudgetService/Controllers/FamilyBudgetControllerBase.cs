using FamilyBudgetService.Api.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace FamilyBudgetService.Api.Controllers
{
    public class FamilyBudgetControllerBase : ControllerBase
    {
        /// <summary>
        /// Wraps the value and return it the <see cref="OkObjectResult">
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        protected OkObjectResult Ok<T>(T value)
        {
            return base.Ok(new FamilyBudgetServiceObjectResponse<T>(value));
        }

        protected OkObjectResult Ok<T>(PaginatedList<T> paginatedList)
        {
            return base.Ok(
                new familybi )
        }
    }
}
