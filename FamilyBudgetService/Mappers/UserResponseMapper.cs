using DataAccess.Models;
using FamilyBudgetService.Api.Contracts.v1.User;

namespace FamilyBudgetService.Api.Mappers
{
    public static class UserResponseMapper
    {
        public static UserResponse MapToResponse(this User user)
        {
            return new UserResponse(user.UserId, user.UserName);

        }
    }
}
