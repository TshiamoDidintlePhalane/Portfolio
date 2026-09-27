public static class LogLine
{
    public static string Message(string logLine)
    {
        int colonPosition = logLine.IndexOf(':');

        return logLine.Substring(colonPosition + 1).Trim();
    }

    public static string LogLevel(string logLine)
    {
        int colonPosition = logLine.IndexOf(':');

        return logLine.Substring(1, colonPosition - 2).ToLower();
    }

    public static string Reformat(string logLine)
    {
        string message = Message(logLine);
        string level = LogLevel(logLine);

        return $"{message} ({level})";
    }
}
