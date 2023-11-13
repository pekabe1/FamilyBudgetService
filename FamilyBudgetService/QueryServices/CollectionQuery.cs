using System.ComponentModel;

namespace FamilyBudgetService.Api.QueryServices;

public abstract record CollectionQuery
{
    [DefaultValue(1)]
    public int Page { get; init; } = 1;
    
    [DefaultValue(20)]
    public int PageSize { get; init; } = 20;
}
