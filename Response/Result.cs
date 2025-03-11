namespace IvyPay.PI.Dict.Domain.Response
{
    public class Result<TSuccess, TError>
     where TSuccess : struct
     where TError : struct
    {
        public TSuccess? Success { get; }
        public TError? Error { get; }
        public bool IsSuccess { get; }

        private Result(TSuccess? success, TError? error, bool isSuccess)
        {
            Success = success;
            Error = error;
            IsSuccess = isSuccess;
        }

        public static Result<TSuccess, TError> SuccessResult(TSuccess success)
        {
            return new Result<TSuccess, TError>(success, null, true);
        }

        public static Result<TSuccess, TError> ErrorResult(TError error)
        {
            return new Result<TSuccess, TError>(null, error, false);
        }
    }
}
