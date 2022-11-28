using System;

public class NotSufficientFundsException : Exception
{
	public NotSufficientFundsException(string message) : base(string.Format("Not sufficient funds for this operation: {0}", message))
	{
	}
}
