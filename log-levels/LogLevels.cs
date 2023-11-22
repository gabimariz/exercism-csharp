using System;
using System.Text.RegularExpressions;

static class LogLine
{
  public static string Message(string logLine) 
    => Regex.Replace(
      logLine, 
      @"(\s*\[+[A-Z]+\]:\s*)|(\t|\r|\n|\s{2})", 
      "");

  public static string LogLevel(string logLine)
    => logLine = Regex.Replace(
      logLine, 
      "[^ERROR|WARNNING|INFO]", 
      "").ToLower();

  public static string Reformat(string logLine)
    => $"{Message(logLine)} ({LogLevel(logLine)})";
}
