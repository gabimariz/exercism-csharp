using System;

public static class LogAnalysis 
{
    // TODO: define the 'SubstringAfter()' extension method on the `string` type
    public static string SubstringAfter(this string str, string strValue)
      => str[(str.IndexOf(strValue, StringComparison.Ordinal) + strValue.Length)..];

    // TODO: define the 'SubstringBetween()' extension method on the `string` type
    public static string SubstringBetween(this string str, string firstDelimiter, string secondDelimiter)
    {
      var removeSecondDelimiterInString = str[1..str.IndexOf(secondDelimiter, StringComparison.Ordinal)];

      return removeSecondDelimiterInString.SubstringAfter(firstDelimiter);
    }
    
    // TODO: define the 'Message()' extension method on the `string` type
    public static string Message(this string str) => str.SubstringAfter(": ");

    // TODO: define the 'LogLevel()' extension method on the `string` type
    public static string LogLevel(this string str) => str.SubstringBetween("[", "]");
}
