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
**NOTE:** If the ```--version``` switch is passed, it must be the first switch on the command line, and if it is used, then any other switches will be ignored.  The version number is not copied onto the Clipboard.
```
my-uuidgen --uppercase
```
The **--uppercase** switch specifies that any of the hexadecimal digits A-F in the outputted UUID should be printed in uppercase.  Lowercase is the default.
```
my-uuidgen --no-copy
```
By default, ```my-uuidgen``` places the UUID it generates onto the Clipboard upon execution.  The **--no-copy** switch suppresses this behavior.
## Changelog
(a) The restriction about putting only one command-line argument at a time has been removed.
(b) However, the ```--version``` switch will only work if it is specified first.
(c) If the ```--version``` switch is passed, all other switches are ignored.
(d) By default, all generated UUIDs are placed on the Clipboard.
(e) Use the ```--no-copy``` switch to prevent the placement of a generated UUID onto the Clipboard.
