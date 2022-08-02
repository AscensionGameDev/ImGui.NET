using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImGuiMenuColumns
    {
        public uint TotalWidth;
        public uint NextTotalWidth;
        public ushort Spacing;
        public ushort OffsetIcon;
        public ushort OffsetLabel;
        public ushort OffsetShortcut;
        public ushort OffsetMark;
        public fixed ushort Widths[4];
    }
    public unsafe partial struct ImGuiMenuColumnsPtr
    {
        public ImGuiMenuColumns* NativePtr { get; }
        public ImGuiMenuColumnsPtr(ImGuiMenuColumns* nativePtr) => NativePtr = nativePtr;
        public ImGuiMenuColumnsPtr(IntPtr nativePtr) => NativePtr = (ImGuiMenuColumns*)nativePtr;
        public static implicit operator ImGuiMenuColumnsPtr(ImGuiMenuColumns* nativePtr) => new ImGuiMenuColumnsPtr(nativePtr);
        public static implicit operator ImGuiMenuColumns* (ImGuiMenuColumnsPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiMenuColumnsPtr(IntPtr nativePtr) => new ImGuiMenuColumnsPtr(nativePtr);
        public ref uint TotalWidth => ref Unsafe.AsRef<uint>(&NativePtr->TotalWidth);
        public ref uint NextTotalWidth => ref Unsafe.AsRef<uint>(&NativePtr->NextTotalWidth);
        public ref ushort Spacing => ref Unsafe.AsRef<ushort>(&NativePtr->Spacing);
        public ref ushort OffsetIcon => ref Unsafe.AsRef<ushort>(&NativePtr->OffsetIcon);
        public ref ushort OffsetLabel => ref Unsafe.AsRef<ushort>(&NativePtr->OffsetLabel);
        public ref ushort OffsetShortcut => ref Unsafe.AsRef<ushort>(&NativePtr->OffsetShortcut);
        public ref ushort OffsetMark => ref Unsafe.AsRef<ushort>(&NativePtr->OffsetMark);
        public RangeAccessor<ushort> Widths => new RangeAccessor<ushort>(NativePtr->Widths, 4);
    }
}
