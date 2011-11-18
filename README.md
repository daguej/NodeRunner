Node Runner
===========

Very simple app to make launching Node scripts easier on Windows.  This app will run Node with a script of the same name as the exe file, passing any arguments along.

Usage
=====

Assuming we've named the exe `app.exe`:

    C:\folder> app arg1 [...]

Is basically the same as:

    C:\folder> "%PROGRAMFILES%\nodejs\node.exe" "app.js" arg1 [...]

This app does assume Node is installed in a folder named `nodejs` in your system's 32-bit Program Files folder.

Download
========

If you're just interested in the exe, <a href="https://github.com/downloads/daguej/NodeRunner/NodeRunner.exe">download here</a>.