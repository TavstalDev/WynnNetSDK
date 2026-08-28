using System.Diagnostics.CodeAnalysis;

namespace Tavstal.WynnNetSDK.Http;

public sealed class Result<T, TError>
{
    [MemberNotNullWhen(true, nameof(Value))]
    [MemberNotNullWhen(false, nameof(Error))]
    public bool IsSuccess { get; }

    [MemberNotNullWhen(false, nameof(Value))]
    [MemberNotNullWhen(true, nameof(Error))]
    public bool IsError => !IsSuccess;
    
    public T? Value { get; }
    
    public TError? Error { get; }
    
    private Result(bool isSuccess, T? value, TError? error)
    {
        IsSuccess = isSuccess;
        Value = value;
        Error = error;
    }
    
    public TResult Match<TResult>(Func<T, TResult> onSuccess, Func<TError, TResult> onFailure)
        => IsSuccess ? onSuccess(Value) : onFailure(Error);
    
    public void Switch(Action<T> onSuccess, Action<TError> onFailure)
    {
         if (IsSuccess) 
             onSuccess(Value);
         else 
             onFailure(Error);
    }
    
    public static Result<T, TError> Success(T value)
        => new(true, value, default);
    
    public static Result<T, TError> Failure(TError error)
        => new(false, default, error);
}