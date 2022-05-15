namespace Geometry.App.Validation;

internal static class InputValidator
{
    internal static bool IsValidTriangleSide(string side)
    {
        if (string.IsNullOrEmpty(side))
        {
            return false;
        }

        var canParse = uint.TryParse(side, out var sideValue);

        if (sideValue == 0)
        {
            return false;
        }

        return canParse;
    }
}