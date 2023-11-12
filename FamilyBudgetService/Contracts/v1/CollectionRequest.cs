using System.ComponentModel;

namespace FamilyBudgetService.Api.Contracts.v1
{
    public abstract record CollectionRequest
    {
        [DefaultValue(1)]
        public int Page { get; init; } = 1;

        [DefaultValue(20)]
        public int PageSize { get; init; } = 20;
    }
}
