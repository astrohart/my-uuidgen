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
        /// Entry point.
        /// </summary>
        /// <param name="args">
        /// Array of strings containing the command-line arguments passed to the
        /// program by the user.
        /// </param>
        [STAThread]
        public static void Main(string[] args)
        {
            var cmdInfo = CommandLineInfo.ParseCommandLine(args);

            if (args.Any())
                if (Resources.VersionSwitch.Equals(args[0]))
                {
                    Console.WriteLine(
                        Assembly.GetExecutingAssembly()
                                .GetName()
                                .Version
                    );
                    Environment.Exit(0); /* exit code of zero means success */
                }

            /* This software has one job in life -- to get a new Globally-Unique Identifier (GUID) and then
             * write it to the standard output and then exit.  This program is meant to replicate the uuidgen.exe
             * utility provided with the Windows SDK, but I wanted to use it in my own batch files, and who the heck
             * wants to download and install the SDK all the time? */

            var newGuidString = Guid.NewGuid()
                              .ToString(
                                  GetGuidFormatSpecifier.ForFormatType(
                                      cmdInfo.FormatType
                                  )
                              );

            var guidString = cmdInfo.IsUppercase
                ? newGuidString.ToUpperInvariant()
                : newGuidString.ToLowerInvariant();

            Console.WriteLine(guidString);

            if (!cmdInfo.ShouldNotCopy)

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