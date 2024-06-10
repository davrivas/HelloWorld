namespace HelloWorld.Helpers;

public static class ConsoleHelpers
{
    public static string GetString(string? message = null)
    {
        ShowMessage(message);
        return Console.ReadLine() ?? string.Empty;
    }

    public static int GetInt(string? message = null)
    {
        ShowMessage(message);
        return int.TryParse(Console.ReadLine(), out int value)
            ? value : default;
    }

    public static double GetDouble(string? message = null)
    {
        ShowMessage(message);
        return double.TryParse(Console.ReadLine(), out double value)
            ? value : default;
    }

    private static void ShowMessage(string? message = null)
    {
        if (!string.IsNullOrWhiteSpace(message))
        {
            Console.WriteLine(message);
        }
    }
}