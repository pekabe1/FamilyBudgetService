namespace FamilyBudgetService.Api.QueryServices;

public abstract record CollectionQuery
{
    public int Page { get; init; }
    public int PageSize { get; init; }
}
