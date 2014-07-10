NeedleFinder
=========

NeedleFinder is a simple Text Matching Utility.

 - Accepts two strings as input: one string is called "text"
   and the other is called "subtext"
 - Matches the subtext against the text, outputting the character positions of 
   the beginning of each match for the subtext within the text.
 - Allows multiple matches
 - Allows case insensitive matching

Requirements
-----------

NeedleFinder requires Visual Studio 2013 or greater and .NET Framework 4.5.

Usage
-----------

NeedleFinder works both as console application and windows form application.
If you want to run it in visual studio set the "NeedleFinder" project as StartUp Project and press F5.
To run as console just build the solution then open the prompt and execute

    NeedleFinder.exe text subtext

For case insensitive match add -i

    NeedleFinder.exe text subtext -i

If text or subtext contain spaces, just use quotes

    NeedleFinder.exe "sample text" "e t" -i

If not parameters are provided the application launches the windows forms interface.

The Solution
--------------

The solution includes 3 projects

- NeedleFinder: Main application
- NeedleFinder.Utils: Application utilities
- NeedleFinder.UnitTest: Unit test project

Tests
--------------

NeedleFinder tests are implemented with the standard Visual Studio Team Test project.
Just Open the solution with visual studio and run all the test in the solution (Ctrl+R, A)

