using Xeptions;

namespace Underdog.Models.Orders.Exceptions;

public class InvalidOrderException : Xeption
{

    public InvalidOrderException(string parameterName, object parameterValue)
        : base(message: $"Invalid order, " +
              $"parameter name: {parameterName}, " +
              $"parameter value: {parameterValue}.")
    { }
    public InvalidOrderException()
        : base(message: "Invalid order") { }
}