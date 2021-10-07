# Creating the iOS binding

## High level plan
* Create an iOS fat library from OpenCV source code (opencv.a)
  * Install tools and source
  * Build
* Use it in an iOS binding project
  * Use xamarin tool "sharpie"
  * Create the binding project

## Details
 
1. Get and install sharpie from this page:
```
https://docs.microsoft.com/en-us/xamarin/cross-platform/macios/binding/objective-sharpie/get-started
```

2. Install cmake tools

I use homebrew:
```
brew install cmake
```

3. Build OpenCV from its sources. XCode must be installed.
```
git clone https://github.com/opencv/opencv.git
python opencv/platforms/ios/build_framework.py ios
```

This will create a universal arch ".a" file renamed to an extensionless file in ios/opencv2.framework/Versions/A/opencv2  
It contains armv7, armv7s, arm64, and iphonesimulator x86 and x64 (32 and 64 bits).  
The executed command is:
```shell
[u'lipo', u'-create', u'ios/build/build-armv7-iphoneos/lib/Release/libopencv_merged.a', u'ios/build/build-armv7s-iphoneos/lib/Release/libopencv_merged.a', u'ios/build/build-arm64-iphoneos/lib/Release/libopencv_merged.a', u'ios/build/build-i386-iphonesimulator/lib/Release/libopencv_merged.a', u'ios/build/build-x86_64-iphonesimulator/lib/Release/libopencv_merged.a', u'-o', u'ios/opencv2.framework/Versions/A/opencv2']
```


4. Create the binding files from the universal .a file

```shell
sharpie bind -framework ios/opencv2.framework -sdk iphoneos15.0
```

This will create 2 files:
ApiDefinitions.cs
StructsAndEnums.cs

And emit this message:

    Binding Analysis:
    Automated binding is complete, but there are a few APIs which have been flagged with [Verify] attributes. While the entire binding should be audited for best API design practices, look more closely at APIs with the following Verify attribute hints:

    ConstantsInterfaceAssociation (1 instance):
        There's no foolproof way to determine with which Objective-C interface an extern variable declaration may be associated. Instances of these are bound as [Field] properties in a partial interface into a nearby concrete interface to produce a more intuitive API,
        possibly eliminating the 'Constants' interface altogether.

    MethodToProperty (525 instances):
        An Objective-C method was bound as a C# property due to convention such as taking no parameters and returning a value (non-void return). Often methods like these should be bound as properties to surface a nicer API, but sometimes false-positives can occur and the
        binding should actually be a method.

    PlatformInvoke (1 instance):
        In general P/Invoke bindings are not as correct or complete as Objective-C bindings (at least currently). You may need to fix up the library name (it defaults to '__Internal') and return/parameter types manually to conform to C calling conventionsfor the target
        platform. You may find you don't even want to expose the C API in your binding, but if you do, you'll probably also want to relocate the definition to a more appropriate class and expose a stronger type-safe wrapper. For P/Invoke guidance, see http://www.mono-
        project.com/docs/advanced/pinvoke/.

    Once you have verified a Verify attribute, you should remove it from the binding source code. The presence of Verify attributes intentionally cause build failures.
    
    For more information about the Verify attribute hints above, consult the Objective Sharpie documentation by running 'sharpie docs' or visiting the following URL:

        http://xmn.io/sharpie-docs


5. Create a xamarin ios binding project

Replace ApiDefinitions.cs and StructsAndEnums.cs by the above ones. You can add a namespace around the codes.  
Copy the file ios/opencv2.framework/Versions/A/opencv2 and rename it opencv2.a  
Add it to the project at its root. Its build action should be automatically set to ObjcBindingNativeLibrary.  

NOTE: the binding project is already created in this git. Just copy the .a file at its root and it's fully setup.
