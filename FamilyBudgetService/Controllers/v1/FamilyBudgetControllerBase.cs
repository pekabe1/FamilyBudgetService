using FamilyBudgetService.Api.Contracts;
using FamilyBudgetService.Api.Errors;
using Microsoft.AspNetCore.Mvc;

namespace FamilyBudgetService.Api.Controllers.v1
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
                new FamilyBudgetServiceCollectionResponse<T>(
                    Data: paginatedList,
                    Pagining: new Pagining(paginatedList.Page,
                    paginatedList.PageSize,
                    paginatedList.TotalCount,
                    paginatedList.TotalPages)));
        }

        protected IActionResult HandleResultError(FamilyBudgetServiceError error) 
        {
            return error.ErrorType switch
            {
                ErrorType.ValidationFailed => BadRequest(error),// TODO: createClass for error mapping
                ErrorType.EntityNotFound => NotFound(error),
                _ => Problem(statusCode: StatusCodes.Status500InternalServerError, title: "Unexpected error")
            };
        }
    }
}
