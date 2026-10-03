using System;

namespace CaptureGraphicsWin2D.Shared
{
    /// <summary>
    /// An entry in the window drop-down menu: the name displayed to the user and the
    /// window it represents. An entry with a handle value of zero represents 'All Windows'.
    /// </summary>
    public sealed record WindowItem(IntPtr Hwnd, string Name)
    {
        public bool IsAllWindows => Hwnd == IntPtr.Zero;
        public override string ToString() => Name;
    }
}
