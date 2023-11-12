namespace FamilyBudgetService.Api.Contracts;

public record   Pagining(int Page, int PageSize, int TotalItems, int TotalPages);