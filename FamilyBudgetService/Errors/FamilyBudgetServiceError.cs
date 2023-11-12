namespace FamilyBudgetService.Api.Errors;

public class FamilyBudgetServiceError
{
    public FamilyBudgetServiceError(ErrorType errorType)
    {
        ErrorType = errorType;
    }

    public ErrorType ErrorType { get; }
}

