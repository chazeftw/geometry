namespace Geometry.App.Utility
{
    internal static class InputValidator
    {
        internal static bool IsValidTriangleSide(string side)
        {
            if (string.IsNullOrEmpty(side))
            {
                return false;
            }

            return uint.TryParse(side, out _);
        }
    }
}
