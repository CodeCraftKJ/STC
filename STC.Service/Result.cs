using FluentValidationResults = FluentValidation.Results;
using System.Collections.Generic;
using System.Linq;

namespace STC.Service
{
    public class Error
    {
        public Error(string propertyName, string message)
        {
            PropertyName = propertyName;
            Message = message;
        }
        public string PropertyName { get; }
        public string Message { get; }
    }

    public class Result
    {
        private Result(string message, bool isFailure, bool isSuccess, IEnumerable<Error> errors)
        {
            Message = message;
            IsFailure = isFailure;
            IsSuccess = isSuccess;
            Errors = errors;
        }

        public string Message { get; }

        public bool IsFailure { get; }

        public bool IsSuccess { get; }

        public IEnumerable<Error> Errors { get; }

        public static Result Fail(string message)
        {
            return new Result(message, isFailure: true, isSuccess: false, Enumerable.Empty<Error>());
        }

        public static Result Fail(FluentValidationResults.ValidationResult validationResult)
        {
            var errors = validationResult.Errors
                .Select(x => new Error(x.PropertyName, x.ErrorMessage));
            return new Result("Validation failed", isFailure: true, isSuccess: false, errors);
        }

        public static Result OK(string message)
        {
            return new Result(message, isFailure: false, isSuccess: true, Enumerable.Empty<Error>());
        }

        public static Result OK()
        {
            return new Result(string.Empty, isFailure: false, isSuccess: true, Enumerable.Empty<Error>());
        }
    }
}
