# my-uuidgen
Generates a Universally-Unique Identifier (UUID) and writes it to the standard output.  Replicates the equivalent tool in the Windows SDK.  Meant to be a portable EXE.

## Introduction
Over the years, generating UUIDs has been a staple of Microsoft-based programming.  The identifiers come in handy, and they have a variety of applications.

With the Windows SDK ships a handy-dandy command-line tool called ``uuidgen.exe``.  However, if you want to use this functionality in your own programs or installers, and do not want to necessarily bother with downloading and installing the bulky Windows SDK just to get one tool, then ```my-uuidgen``` might just be the solution you need.

## Usage
Prints a Universally-Unique Identifier, or UUID, to the standard output on a line by itself.  Supports two command-line arguments:
```
my-uuidgen --version
```
The **--version** switch specifies that ```my-uuidgen``` should print its version number to the standard output on a line by itself, and then terminate.
```
my-uuidgen --uppercase
```
The **--uppercase** switch specifies that any of the hexadecimal digits A-F in the outputted UUID should be printed in uppercase.  Lowercase is the default.

**NOTE:** Only one argument may be passed on the command line at any given time.
