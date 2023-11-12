using FamilyBudgetService.Api.Errors;

namespace FamilyBudgetService.Api
{
    public class Result<TValue>
    {
        private Result(TValue value)
        {
            IsError = false;
            Value = value;
            Error = default;
        }

        private Result(FamilyBudgetServiceError error)
        {
            IsError = true;
            Value = default!;
            Error = error;
        }

        public bool IsError { get; }
        public TValue Value { get; }
        public FamilyBudgetServiceError? Error { get; }

        public static implicit operator Result<TValue>(TValue value) => new(value);

        public TResult Match<TResult>(
            Func<TValue, TResult> success,
            Func<FamilyBudgetServiceError, TResult> failure) =>
            !IsError ? success(Value) : failure(Error!);
    }
}
