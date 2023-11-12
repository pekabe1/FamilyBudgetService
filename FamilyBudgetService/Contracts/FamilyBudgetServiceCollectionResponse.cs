namespace FamilyBudgetService.Api.Contracts;

public record FamilyBudgetServiceCollectionResponse<T>(IEnumerable<T> Data, Pagining Pagining);