using System;

public static class ErrorHandling
{
    public static void HandleErrorByThrowingException()
    {
        throw new System.Exception();
    }

    public static int? HandleErrorByReturningNullableType(string input)
    {
        if (int.TryParse(input, out int result))
        {
            return result;
        }
        return null;

        //int number;
        //return int.TryParse(input, out number) ? number : (int?) null;
    }

    public static bool HandleErrorWithOutParam(string input, out int result)
    {
        return Int32.TryParse(input, out result);
    }

    public static void DisposableResourcesAreDisposedWhenExceptionIsThrown(IDisposable disposableObject)
    {
        using (disposableObject)
        {
            throw new Exception();
        }
    }
}
