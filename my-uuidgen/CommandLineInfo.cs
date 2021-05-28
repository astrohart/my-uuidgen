﻿using my_uuidgen.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace my_uuidgen
{
    public class CommandLineInfo
    {
        /// <summary>
        /// Gets or sets the <see cref="T:my_uuidgen.FormatType" /> value that
        /// specifies how to format the GUID.
        /// </summary>
        public FormatType FormatType { get; set; } =
            FormatType.DigitsHyphensAndBraces;

        /// <summary>
        /// Gets or sets a value indicating whether UUIDs are written to the
        /// standard output with hex digits A-F in UPPERCASE or not.
        /// </summary>
        public bool IsUppercase { get; set; }

        /// <summary>
        /// Gets or sets a value that indicates whether we should not place the
        /// generated GUID text onto the Clipboard after it's been written to
        /// standard output.
        /// </summary>
        public bool ShouldNotCopy { get; set; }

        /// <summary>
        /// Parses the command-line arguments that are passed to this program by
        /// the user and fills the properties of a newly-instantiated instance
        /// of <see cref="T:my_uuidgen.CommandLineInfo" /> accordingly.
        /// </summary>
        /// <param name="args">
        /// Enumerable collection of strings, each of which is a command-line argument.
        /// </param>
        /// <returns>
        /// Reference to an instance of
        /// <see
        ///     cref="T:my_uuidgen.CommandLineInfo" />
        /// , whose properties are
        /// initialized according to the switches passed to this application on
        /// the command line.
        /// </returns>
        public static CommandLineInfo ParseCommandLine(IEnumerable<string> args)
        {
            if (args == null) throw new ArgumentNullException(nameof(args));

            var result = new CommandLineInfo();

            var argsList = new Stack<string>(args);
            if (!argsList.Any())
                return result;

            while(argsList.Any())
            {
                var arg = argsList.Pop();
                if (string.IsNullOrWhiteSpace(arg)) continue;

                result.IsUppercase =
                    Resources.UppercaseSwitch.Equals(arg.ToLowerInvariant());

                result.ShouldNotCopy =
                    Resources.NoCopySwitch.Equals(arg.ToLowerInvariant());

                result.FormatType = GetFormatType.FromSwitch(arg);
            }

            return result;
        }
    }
}