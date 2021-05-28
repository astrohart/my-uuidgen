using my_uuidgen.Properties;
using System;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace my_uuidgen
{
    /// <summary>
    /// Defines the routines for this software
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Gets or sets the <see cref="T:my_uuidgen.FormatType" /> value that
        /// specifies how to format the GUID.
        /// </summary>
        public static FormatType FormatType { get; set; } =
            FormatType.DigitsHyphensAndBraces;

        /// <summary>
        /// Gets or sets a value indicating whether UUIDs are written to the
        /// standard output with hex digits A-F in UPPERCASE or not.
        /// </summary>
        private static bool IsUppercase { get; set; }

        /// <summary>
        /// Gets or sets a value that indicates whether we should not place the
        /// generated GUID text onto the Clipboard after it's been written to
        /// standard output.
        /// </summary>
        private static bool ShouldNotCopy { get; set; }

        /// <summary>
        /// Entry point.
        /// </summary>
        /// <param name="args">
        /// Array of strings containing the command-line arguments passed to the
        /// program by the user.
        /// </param>
        [STAThread]
        public static void Main(string[] args)
        {
            if (args.Any())
            {
                if (Resources.VersionSwitch.Equals(args[0]))
                {
                    Console.WriteLine(
                        Assembly.GetExecutingAssembly()
                                .GetName()
                                .Version
                    );
                    Environment.Exit(0); /* exit code of zero means success */
                }
                else
                {
                    IsUppercase = args.Contains(Resources.UppercaseSwitch);
                    ShouldNotCopy = args.Contains(Resources.NoCopySwitch);
                }
            }

            /* This software has one job in life -- to get a new Globally-Unique Identifier (GUID) and then
             * write it to the standard output and then exit.  This program is meant to replicate the uuidgen.exe
             * utility provided with the Windows SDK, but I wanted to use it in my own batch files, and who the heck
             * wants to download and install the SDK all the time? */

            var newGuid = Guid.NewGuid();

            var guidString = IsUppercase
                ? $"{newGuid.ToString().ToUpperInvariant()}"
                : $"{newGuid}";

            Console.WriteLine(guidString);

            if (!ShouldNotCopy)

                // place the GUID string that we otherwise pump to standard
                // output, also to be on the Clipboard. This way, this app can
                // also be launched, e.g., from the Tools menu on Visual Studio
                // and then the user can just do a paste into whatever file they
                // are working on right off the bat.

                Clipboard.SetText(guidString);

            Environment.Exit(0); /* exit code of zero means success */
        }
    }
}