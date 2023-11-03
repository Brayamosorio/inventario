internal static class Form1HelpersHelpers1
{
    public static object GetGetDebuggerDisplay1(object? getDebuggerDisplay)
    {
#pragma warning disable CS8603 // Posible tipo de valor devuelto de referencia nulo
        return getDebuggerDisplay;
#pragma warning restore CS8603 // Posible tipo de valor devuelto de referencia nulo
    }

    public static object? GetDebuggerDisplay { get; private set; }
}