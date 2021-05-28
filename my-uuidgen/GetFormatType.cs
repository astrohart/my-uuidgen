using my_uuidgen.Properties;

namespace my_uuidgen
{
    /// <summary>
    /// Gets <see cref="T:my_uuidgen.FormatType" /> values from command-line arguments.
    /// </summary>
    public static class GetFormatType
    {
        /// <summary>
        /// Gets the <see cref="T:my_uuidgen.FormatType" /> value that
        /// corresponds to the command-line <paramref name="argument" /> passed
        /// to this method.
        /// </summary>
        /// <param name="argument">
        /// (Required.) String containing the current command-line argument to
        /// be checked.
        /// </param>
        /// <returns>
        /// The <see cref="T:my_uuidgen.FormatType" /> value that corresponds to
        /// the command-line argument provided.
        /// </returns>
        public static FormatType FromSwitch(string argument)
        {
            var result = FormatType.DigitsHyphensAndBraces;

            if (Resources.RegistrySwitch.Equals(argument.ToLowerInvariant()))
                result = FormatType.DigitsHyphensAndBraces;
            else if (Resources.ParensSwitch.Equals(argument.ToLowerInvariant()))
                result = FormatType.DigitsHyphensAndParentheses;
            else if (Resources.HyphensOnlySwitch.Equals(
                argument.ToLowerInvariant()
            ))
                result = FormatType.DigitsWithHyphens;
            else if (Resources.NoFormatSwitch.Equals(
                argument.ToLowerInvariant()
            ))
                result = FormatType.DigitsOnly;
            else if (Resources.HexGroupsSwitch.Equals(
                argument.ToLowerInvariant()
            ))
                result = FormatType.HexGroups;

            return result;
        }
    }
}