using System.Diagnostics.CodeAnalysis;

namespace Tavstal.WynnNetSDK.Http;

/// <summary>
/// Represents the outcome of an operation. It holds either a value on success or an error on failure.
/// </summary>
/// <typeparam name="T">The type of the value returned on success.</typeparam>
/// <typeparam name="TError">The type of the error returned on failure.</typeparam>
public sealed class Result<T, TError>
{
    /// <summary>
    /// True when the operation succeeded.
    /// </summary>
    [MemberNotNullWhen(true, nameof(Value))]
    [MemberNotNullWhen(false, nameof(Error))]
    public bool IsSuccess { get; }

    /// <summary>
    /// True when the operation failed.
    /// </summary>
    [MemberNotNullWhen(false, nameof(Value))]
    [MemberNotNullWhen(true, nameof(Error))]
    public bool IsError => !IsSuccess;
    
    /// <summary>
    /// The value returned on success. Null when the operation failed.
    /// </summary>
    public T? Value { get; }
    
    /// <summary>
    /// The error returned on failure. Null when the operation succeeded.
    /// </summary>
    public TError? Error { get; }
    
    private Result(bool isSuccess, T? value, TError? error)
    {
        IsSuccess = isSuccess;
        Value = value;
        Error = error;
    }
    
    /// <summary>
    /// Returns a value based on whether the result is a success or a failure.
    /// </summary>
    /// <typeparam name="TResult">The type of the value to return.</typeparam>
    /// <param name="onSuccess">A function called with the value when the result is a success.</param>
    /// <param name="onFailure">A function called with the error when the result is a failure.</param>
    /// <returns>The value produced by the matching function.</returns>
    public TResult Match<TResult>(Func<T, TResult> onSuccess, Func<TError, TResult> onFailure)
        => IsSuccess ? onSuccess(Value) : onFailure(Error);
    
    /// <summary>
    /// Runs one of two actions depending on whether the result is a success or a failure.
    /// </summary>
    /// <param name="onSuccess">An action called with the value when the result is a success.</param>
    /// <param name="onFailure">An action called with the error when the result is a failure.</param>
    public void Switch(Action<T> onSuccess, Action<TError> onFailure)
    {
         if (IsSuccess) 
             onSuccess(Value);
         else 
             onFailure(Error);
    }
    
    /// <summary>
    /// Creates a successful result with the given value.
    /// </summary>
    /// <param name="value">The value to return on success.</param>
    /// <returns>A new successful result.</returns>
    public static Result<T, TError> Success(T value)
        => new(true, value, default);
    
    /// <summary>
    /// Creates a failed result with the given error.
    /// </summary>
    /// <param name="error">The error to return on failure.</param>
    /// <returns>A new failed result.</returns>
    public static Result<T, TError> Failure(TError error)
        => new(false, default, error);
}