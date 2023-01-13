# Bug description

When using arrow keys to move window arround, on Windows 11 OS windows is moving in expected direction for 1 pixel at the time. On Linux (Ubuntu Raspbery Pi OS Bullseye),
window movement is not expected.

# Steps to reproduce bug

**Clone git** project and run it with **dotnet run** command. Then use arrow keys to move it arround. On Windows OS window moves as expected, but on Linux it does not.
