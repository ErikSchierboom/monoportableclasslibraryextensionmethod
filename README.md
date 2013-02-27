Mono portable class library extension method
============================================

This solution is used to show that the combination of a portable class library and extensions methods does not run on Mono 3.0.5. To verify that it does not work, you need to have an environment where Mono 3.0.5 has been installed. If this is done, execute the following steps to see that Mono 3.0.5 does not handle portable class libraries with extension methods in them well:

 1. Build the **ConsoleApplicationWithExtensionMethod** project
 2. Run the console application under Mono 3.0.5 as follows:
    `mono ./ConsoleApplicationWithExtensionMethod.exe`

This will result in a error that looks like this:
```
Missing method .ctor in assembly /var/www/sites/erik/monoconsole/PortableClassLibraryWithExtensionMethod.dll, type System.Runtime.CompilerServices.ExtensionAttribute
Can't find custom attr constructor image: /var/www/sites/erik/monoconsole/PortableClassLibraryWithExtensionMethod.dll mtoken: 0x0a000010

Unhandled Exception:
System.IO.FileNotFoundException: Could not load file or assembly 'System.Core, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e, Retargetable=Yes' or one of its dependencies.
File name: 'System.Core, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e, Retargetable=Yes'
  at ConsoleApplicationWithExtensionMethod.Program.<Main>b__0 (System.Type t) [0x00000] in <filename unknown>:0
  at System.Linq.Enumerable+<CreateWhereIterator>c__Iterator28`1[System.Type].MoveNext () [0x00000] in <filename unknown>:0
  at System.Linq.Enumerable.Count[Type] (IEnumerable`1 source) [0x00000] in <filename unknown>:0
  at ConsoleApplicationWithExtensionMethod.Program.Main () [0x00000] in <filename unknown>:0
[ERROR] FATAL UNHANDLED EXCEPTION: System.IO.FileNotFoundException: Could not load file or assembly 'System.Core, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e, Retargetable=Yes' or one of its dependencies.
File name: 'System.Core, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e, Retargetable=Yes'
  at ConsoleApplicationWithExtensionMethod.Program.<Main>b__0 (System.Type t) [0x00000] in <filename unknown>:0
  at System.Linq.Enumerable+<CreateWhereIterator>c__Iterator28`1[System.Type].MoveNext () [0x00000] in <filename unknown>:0
  at System.Linq.Enumerable.Count[Type] (IEnumerable`1 source) [0x00000] in <filename unknown>:0
  at ConsoleApplicationWithExtensionMethod.Program.Main () [0x00000] in <filename unknown>:0
```

Now we can verify that the problem lies with the combination of portable class library and extension methods by running the **ConsoleApplicationWithoutExtensionMethod** console application. This application uses a second class library that is functionally equivalent to the one used before, with one difference: it does not use extension methods. To verify that this project does work, follows these steps:

 1. Build the **ConsoleApplicationWithoutExtensionMethod** project
 2. Run the console application under Mono 3.0.5 as follows:
    `mono ./ConsoleApplicationWithoutExtensionMethod.exe`

This console application executes successfully, thereby demonstrating that the problem lies with extension methods.
