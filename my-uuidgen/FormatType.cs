namespace my_uuidgen
{
    /// <summary>
    /// Specifies the format of the outputted GUID.
    /// </summary>
    public enum FormatType
    {
        /// <summary>
        /// Returns 32 hex digits only.
        /// </summary>
        DigitsOnly,

        /// <summary>
        /// Returns 32 hex digits broken into GUID groups using hyphens.
        /// </summary>
        DigitsWithHyphens,

        /// <summary>
        /// Returns 32 hex digits broken into GUID groups using hyphens,
        /// surrounded by braces (Registry format).
        /// </summary>
        DigitsHyphensAndBraces,

        /// <summary>
        /// Returns 32 hex digits broken into GUID groups using hyphens,
        /// surrounded by parentheses.
        /// </summary>
        DigitsHyphensAndParentheses,

        /// <summary>
        /// Four hexadecimal values enclosed in braces, where the fourth value
        /// is a subset of eight hexadecimal values that is also enclosed in braces.
        /// </summary>
        HexGroups
    }
}