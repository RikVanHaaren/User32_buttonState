using System.Runtime.InteropServices;
using User32_buttonState;

// Import P/Invoke
[DllImport("USER32.dll")]
static extern short GetKeyState(VirtualKey nVirtKey);

// KEY_TOGGLED = &H1 (0x1)
// KEY_PRESSED = &H8000 (0x8000)
const int KEY_PRESSED = 0x8000;

while (true) {
    if (IsPressed(VirtualKey.VK_SPACE)) Console.WriteLine("Button Pressed!");
    Thread.Sleep(100);
}

static bool IsPressed(VirtualKey virtualKey) {
    return Convert.ToBoolean(GetKeyState(virtualKey) & KEY_PRESSED);
}