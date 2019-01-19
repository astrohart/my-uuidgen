using my_uuidgen.Properties;
using System;
using System.Reflection;
using System.Runtime.Versioning;

namespace my_uuidgen
{
    /// <summary>
    /// Defines the routines for this software
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Gets or sets a value indicating whether UUIDs are written to the standard output with hex digits A-F in UPPERCASE or not.
        /// </summary>
        public static bool IsUppercase { get; set; }

        public static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                if (Resources.VersionSwitch.Equals(args[0]))
                {
                    Console.WriteLine(Assembly.GetExecutingAssembly().GetName().Version);
                    Environment.Exit(0); /* exit code of zero means success */
                }
                else
                    IsUppercase = Resources.UppercaseSwitch.Equals(args[0]);    /* is the '--uppercase' flag applied? */
            }

            /* This software has one job in life -- to get a new Globally-Unique Identifier (GUID) and then
             * write it to the standard output and then exit.  This program is meant to replicate the uuidgen.exe
             * utility provided with the Windows SDK, but I wanted to use it in my own batch files, and who the heck
             * wants to download and install the SDK all the time? */
            Console.WriteLine(IsUppercase ? $"{Guid.NewGuid().ToString().ToUpperInvariant()}" : $"{Guid.NewGuid()}");
            Environment.Exit(0);    /* exit code of zero means success */
        }
    }
}