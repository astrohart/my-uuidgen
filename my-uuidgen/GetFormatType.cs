using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace my_uuidgen
{
    /// <summary>
    /// Gets <see cref="T:my_uuidgen.FormatType"/> values from command-line arguments.
    /// </summary>
    public static class GetFormatType
    {
        public static FormatType FromSwitch(string argument)
        {
            var result = FormatType.DigitsHyphensAndBraces;

            switch (argument)
            {
                case "--registry":
                    return result;

                case "--parens":
                    result = FormatType.DigitsHyphensAndParentheses;
                    break;

                case "--hyphensonly":
                    result = FormatType.DigitsWithHyphens;
                    break;

                case "--noformat":
                    result = FormatType.DigitsOnly;
                    break;

                case "--hexgroups":
                    result = FormatType.HexGroups;
                    break;
            }
            
            return result;
        }
    }
}
