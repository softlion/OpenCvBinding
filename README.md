# OpenCv Bindings for iOS and Android

## About the Android binding

For Android, the jar file is already included.  

Status: working.

## About the iOS binding

For iOS, the .a file is 400MB and can't be checked it.  
You have to rebuild it by following the guide in `CreateBindingIos.md`

Status: builds ok. Not working (for some reason none of the bound class are recognized in an iOS app project where this lib is referenced).

## Building the nuget

A nuget (.nupkg file) containing both the android and iOS bindings can be built by executing `nuget/pack.ps1` in a powershell7 prompt.  
As this nuget will be huge (500MB) it can't be pushed to nuget.org.

An idea would be to split the ios fat .a file into each arch .a file, and create a "child" nuget for each arch.
