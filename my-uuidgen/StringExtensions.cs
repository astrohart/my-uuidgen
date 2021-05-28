using my_uuidgen.Properties;

namespace my_uuidgen
{
    public static class StringExtensions
    {
        public static bool IsFormatTypeArgument(this string value)
            => !string.IsNullOrWhiteSpace(value) &&
               Resources.NoFormatSwitch.Equals(value.ToLowerInvariant()) ||
               Resources.HexGroupsSwitch.Equals(value.ToLowerInvariant()) ||
               Resources.HyphensOnlySwitch.Equals(value.ToLowerInvariant()) ||
               Resources.RegistrySwitch.Equals(value.ToLowerInvariant()) ||
               Resources.ParensSwitch.Equals(value.ToLowerInvariant());
    }
}