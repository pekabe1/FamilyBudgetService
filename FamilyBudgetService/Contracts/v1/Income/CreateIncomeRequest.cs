namespace FamilyBudgetService.Api.Contracts.v1.Income;

public record CreateIncomeRequest(int UserId, string Description, decimal Amount, DateTime IncomeDate,int? IncomeCategoryId);