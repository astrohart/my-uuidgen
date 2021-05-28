namespace my_uuidgen
{
    /// <summary>
    /// Translates input values into GUID string-formatting format-specifier codes.
    /// </summary>
    public static class GetGuidFormatSpecifier
    {
        /// <summary>
        /// Determines the format-specifier for the
        /// <see
        ///     cref="M:System.Guid.ToString" />
        /// method, given one of the
        /// <see
        ///     cref="T:my_uuidgen.FormatType" />
        /// values being passed.
        /// </summary>
        /// <param name="type">
        /// (Required.) The <see cref="T:my_uuidgen.FormatType" /> value to be
        /// translated into a format-specifier.
        /// </param>
        /// <returns>
        /// String containing a format-specifier to then be fed to the
        /// <see
        ///     cref="M:System.Guid.ToString" />
        /// method.
        /// </returns>
        public static string ForFormatType(FormatType type)
        {
            var result = "B";

            switch (type)
            {
                case FormatType.DigitsWithHyphens:
                    result = "D";
                    break;

                case FormatType.DigitsHyphensAndParentheses:
                    result = "P";
                    break;

                case FormatType.DigitsHyphensAndBraces:
                    result = "B";
                    break;

                case FormatType.HexGroups:
                    result = "X";
                    break;

                case FormatType.DigitsOnly:
                    result = "N";
                    break;
            }

            return result;
        }
    }
}