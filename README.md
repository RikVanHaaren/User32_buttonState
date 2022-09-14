# User32_buttonState
.NET 6.0 console application, button state via user32.dll


## Problem
I had the issue that my application needed to check how long an button was held by the user. First I tried the `Console.ReadKey();` but this function lets the program wait for a key press.


## Solution
With P/Invoke we can acces the structs, callbacks and functions in the unmanaged libraries from our managed code. This is how we can acces the *user32.dll* to get the virtual key stroke states.


## Usages
### Import user32.dll
**C# signature:**
```
using System.Runtime.InteropServices;
[DllImport("USER32.dll")]
```
*OR*
```
[System.Runtime.InteropServices.DllImport("USER32.dll")]
```


## Resoures
[Virtual-key Codes](https://docs.microsoft.com/en-us/windows/win32/inputdev/virtual-key-codes) •
[Platform Invoke](https://docs.microsoft.com/en-us/dotnet/standard/native-interop/pinvoke)
