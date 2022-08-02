using System;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;

namespace ImGuiNET
{
    public static unsafe partial class ImGuiInternal
    {
        public static void ActivateItem(uint id)
        {
            ImGuiNativeInternal.igActivateItem(id);
        }
        public static uint AddContextHook(IntPtr context, ImGuiContextHookPtr hook)
        {
            ImGuiContextHook* native_hook = hook.NativePtr;
            uint ret = ImGuiNativeInternal.igAddContextHook(context, native_hook);
            return ret;
        }
        public static bool ArrowButtonEx(string str_id, ImGuiDir dir, Vector2 size_arg)
        {
            byte* native_str_id;
            int str_id_byteCount = 0;
            if (str_id != null)
            {
                str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
                if (str_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_str_id = Util.Allocate(str_id_byteCount + 1);
                }
                else
                {
                    byte* native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
                    native_str_id = native_str_id_stackBytes;
                }
                int native_str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            else { native_str_id = null; }
            ImGuiButtonFlags flags = (ImGuiButtonFlags)0;
            byte ret = ImGuiNativeInternal.igArrowButtonEx(native_str_id, dir, size_arg, flags);
            if (str_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_str_id);
            }
            return ret != 0;
        }
        public static bool ArrowButtonEx(string str_id, ImGuiDir dir, Vector2 size_arg, ImGuiButtonFlags flags)
        {
            byte* native_str_id;
            int str_id_byteCount = 0;
            if (str_id != null)
            {
                str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
                if (str_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_str_id = Util.Allocate(str_id_byteCount + 1);
                }
                else
                {
                    byte* native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
                    native_str_id = native_str_id_stackBytes;
                }
                int native_str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            else { native_str_id = null; }
            byte ret = ImGuiNativeInternal.igArrowButtonEx(native_str_id, dir, size_arg, flags);
            if (str_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_str_id);
            }
            return ret != 0;
        }
        public static bool BeginChildEx(string name, uint id, Vector2 size_arg, bool border, ImGuiWindowFlags flags)
        {
            byte* native_name;
            int name_byteCount = 0;
            if (name != null)
            {
                name_byteCount = Encoding.UTF8.GetByteCount(name);
                if (name_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_name = Util.Allocate(name_byteCount + 1);
                }
                else
                {
                    byte* native_name_stackBytes = stackalloc byte[name_byteCount + 1];
                    native_name = native_name_stackBytes;
                }
                int native_name_offset = Util.GetUtf8(name, native_name, name_byteCount);
                native_name[native_name_offset] = 0;
            }
            else { native_name = null; }
            byte native_border = border ? (byte)1 : (byte)0;
            byte ret = ImGuiNativeInternal.igBeginChildEx(native_name, id, size_arg, native_border, flags);
            if (name_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_name);
            }
            return ret != 0;
        }
        public static void BeginColumns(string str_id, int count)
        {
            byte* native_str_id;
            int str_id_byteCount = 0;
            if (str_id != null)
            {
                str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
                if (str_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_str_id = Util.Allocate(str_id_byteCount + 1);
                }
                else
                {
                    byte* native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
                    native_str_id = native_str_id_stackBytes;
                }
                int native_str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            else { native_str_id = null; }
            ImGuiOldColumnFlags flags = (ImGuiOldColumnFlags)0;
            ImGuiNativeInternal.igBeginColumns(native_str_id, count, flags);
            if (str_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_str_id);
            }
        }
        public static void BeginColumns(string str_id, int count, ImGuiOldColumnFlags flags)
        {
            byte* native_str_id;
            int str_id_byteCount = 0;
            if (str_id != null)
            {
                str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
                if (str_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_str_id = Util.Allocate(str_id_byteCount + 1);
                }
                else
                {
                    byte* native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
                    native_str_id = native_str_id_stackBytes;
                }
                int native_str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            else { native_str_id = null; }
            ImGuiNativeInternal.igBeginColumns(native_str_id, count, flags);
            if (str_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_str_id);
            }
        }
        public static bool BeginComboPopup(uint popup_id, ImRect bb, ImGuiComboFlags flags)
        {
            byte ret = ImGuiNativeInternal.igBeginComboPopup(popup_id, bb, flags);
            return ret != 0;
        }
        public static bool BeginComboPreview()
        {
            byte ret = ImGuiNativeInternal.igBeginComboPreview();
            return ret != 0;
        }
        public static void BeginDockableDragDropSource(ImGuiWindowPtr window)
        {
            ImGuiWindow* native_window = window.NativePtr;
            ImGuiNativeInternal.igBeginDockableDragDropSource(native_window);
        }
        public static void BeginDockableDragDropTarget(ImGuiWindowPtr window)
        {
            ImGuiWindow* native_window = window.NativePtr;
            ImGuiNativeInternal.igBeginDockableDragDropTarget(native_window);
        }
        public static void BeginDocked(ImGuiWindowPtr window, ref bool p_open)
        {
            ImGuiWindow* native_window = window.NativePtr;
            byte native_p_open_val = p_open ? (byte)1 : (byte)0;
            byte* native_p_open = &native_p_open_val;
            ImGuiNativeInternal.igBeginDocked(native_window, native_p_open);
            p_open = native_p_open_val != 0;
        }
        public static bool BeginDragDropTargetCustom(ImRect bb, uint id)
        {
            byte ret = ImGuiNativeInternal.igBeginDragDropTargetCustom(bb, id);
            return ret != 0;
        }
        public static bool BeginMenuEx(string label, string icon)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_icon;
            int icon_byteCount = 0;
            if (icon != null)
            {
                icon_byteCount = Encoding.UTF8.GetByteCount(icon);
                if (icon_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_icon = Util.Allocate(icon_byteCount + 1);
                }
                else
                {
                    byte* native_icon_stackBytes = stackalloc byte[icon_byteCount + 1];
                    native_icon = native_icon_stackBytes;
                }
                int native_icon_offset = Util.GetUtf8(icon, native_icon, icon_byteCount);
                native_icon[native_icon_offset] = 0;
            }
            else { native_icon = null; }
            byte enabled = 1;
            byte ret = ImGuiNativeInternal.igBeginMenuEx(native_label, native_icon, enabled);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            if (icon_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_icon);
            }
            return ret != 0;
        }
        public static bool BeginMenuEx(string label, string icon, bool enabled)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_icon;
            int icon_byteCount = 0;
            if (icon != null)
            {
                icon_byteCount = Encoding.UTF8.GetByteCount(icon);
                if (icon_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_icon = Util.Allocate(icon_byteCount + 1);
                }
                else
                {
                    byte* native_icon_stackBytes = stackalloc byte[icon_byteCount + 1];
                    native_icon = native_icon_stackBytes;
                }
                int native_icon_offset = Util.GetUtf8(icon, native_icon, icon_byteCount);
                native_icon[native_icon_offset] = 0;
            }
            else { native_icon = null; }
            byte native_enabled = enabled ? (byte)1 : (byte)0;
            byte ret = ImGuiNativeInternal.igBeginMenuEx(native_label, native_icon, native_enabled);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            if (icon_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_icon);
            }
            return ret != 0;
        }
        public static bool BeginPopupEx(uint id, ImGuiWindowFlags extra_flags)
        {
            byte ret = ImGuiNativeInternal.igBeginPopupEx(id, extra_flags);
            return ret != 0;
        }
        public static bool BeginTabBarEx(ImGuiTabBarPtr tab_bar, ImRect bb, ImGuiTabBarFlags flags, ImGuiDockNodePtr dock_node)
        {
            ImGuiTabBar* native_tab_bar = tab_bar.NativePtr;
            ImGuiDockNode* native_dock_node = dock_node.NativePtr;
            byte ret = ImGuiNativeInternal.igBeginTabBarEx(native_tab_bar, bb, flags, native_dock_node);
            return ret != 0;
        }
        public static bool BeginTableEx(string name, uint id, int columns_count)
        {
            byte* native_name;
            int name_byteCount = 0;
            if (name != null)
            {
                name_byteCount = Encoding.UTF8.GetByteCount(name);
                if (name_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_name = Util.Allocate(name_byteCount + 1);
                }
                else
                {
                    byte* native_name_stackBytes = stackalloc byte[name_byteCount + 1];
                    native_name = native_name_stackBytes;
                }
                int native_name_offset = Util.GetUtf8(name, native_name, name_byteCount);
                native_name[native_name_offset] = 0;
            }
            else { native_name = null; }
            ImGuiTableFlags flags = (ImGuiTableFlags)0;
            Vector2 outer_size = new Vector2();
            float inner_width = 0.0f;
            byte ret = ImGuiNativeInternal.igBeginTableEx(native_name, id, columns_count, flags, outer_size, inner_width);
            if (name_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_name);
            }
            return ret != 0;
        }
        public static bool BeginTableEx(string name, uint id, int columns_count, ImGuiTableFlags flags)
        {
            byte* native_name;
            int name_byteCount = 0;
            if (name != null)
            {
                name_byteCount = Encoding.UTF8.GetByteCount(name);
                if (name_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_name = Util.Allocate(name_byteCount + 1);
                }
                else
                {
                    byte* native_name_stackBytes = stackalloc byte[name_byteCount + 1];
                    native_name = native_name_stackBytes;
                }
                int native_name_offset = Util.GetUtf8(name, native_name, name_byteCount);
                native_name[native_name_offset] = 0;
            }
            else { native_name = null; }
            Vector2 outer_size = new Vector2();
            float inner_width = 0.0f;
            byte ret = ImGuiNativeInternal.igBeginTableEx(native_name, id, columns_count, flags, outer_size, inner_width);
            if (name_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_name);
            }
            return ret != 0;
        }
        public static bool BeginTableEx(string name, uint id, int columns_count, ImGuiTableFlags flags, Vector2 outer_size)
        {
            byte* native_name;
            int name_byteCount = 0;
            if (name != null)
            {
                name_byteCount = Encoding.UTF8.GetByteCount(name);
                if (name_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_name = Util.Allocate(name_byteCount + 1);
                }
                else
                {
                    byte* native_name_stackBytes = stackalloc byte[name_byteCount + 1];
                    native_name = native_name_stackBytes;
                }
                int native_name_offset = Util.GetUtf8(name, native_name, name_byteCount);
                native_name[native_name_offset] = 0;
            }
            else { native_name = null; }
            float inner_width = 0.0f;
            byte ret = ImGuiNativeInternal.igBeginTableEx(native_name, id, columns_count, flags, outer_size, inner_width);
            if (name_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_name);
            }
            return ret != 0;
        }
        public static bool BeginTableEx(string name, uint id, int columns_count, ImGuiTableFlags flags, Vector2 outer_size, float inner_width)
        {
            byte* native_name;
            int name_byteCount = 0;
            if (name != null)
            {
                name_byteCount = Encoding.UTF8.GetByteCount(name);
                if (name_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_name = Util.Allocate(name_byteCount + 1);
                }
                else
                {
                    byte* native_name_stackBytes = stackalloc byte[name_byteCount + 1];
                    native_name = native_name_stackBytes;
                }
                int native_name_offset = Util.GetUtf8(name, native_name, name_byteCount);
                native_name[native_name_offset] = 0;
            }
            else { native_name = null; }
            byte ret = ImGuiNativeInternal.igBeginTableEx(native_name, id, columns_count, flags, outer_size, inner_width);
            if (name_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_name);
            }
            return ret != 0;
        }
        public static void BeginTooltipEx(ImGuiTooltipFlags tooltip_flags, ImGuiWindowFlags extra_window_flags)
        {
            ImGuiNativeInternal.igBeginTooltipEx(tooltip_flags, extra_window_flags);
        }
        public static bool BeginViewportSideBar(string name, ImGuiViewportPtr viewport, ImGuiDir dir, float size, ImGuiWindowFlags window_flags)
        {
            byte* native_name;
            int name_byteCount = 0;
            if (name != null)
            {
                name_byteCount = Encoding.UTF8.GetByteCount(name);
                if (name_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_name = Util.Allocate(name_byteCount + 1);
                }
                else
                {
                    byte* native_name_stackBytes = stackalloc byte[name_byteCount + 1];
                    native_name = native_name_stackBytes;
                }
                int native_name_offset = Util.GetUtf8(name, native_name, name_byteCount);
                native_name[native_name_offset] = 0;
            }
            else { native_name = null; }
            ImGuiViewport* native_viewport = viewport.NativePtr;
            byte ret = ImGuiNativeInternal.igBeginViewportSideBar(native_name, native_viewport, dir, size, window_flags);
            if (name_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_name);
            }
            return ret != 0;
        }
        public static void BringWindowToDisplayBack(ImGuiWindowPtr window)
        {
            ImGuiWindow* native_window = window.NativePtr;
            ImGuiNativeInternal.igBringWindowToDisplayBack(native_window);
        }
        public static void BringWindowToDisplayBehind(ImGuiWindowPtr window, ImGuiWindowPtr above_window)
        {
            ImGuiWindow* native_window = window.NativePtr;
            ImGuiWindow* native_above_window = above_window.NativePtr;
            ImGuiNativeInternal.igBringWindowToDisplayBehind(native_window, native_above_window);
        }
        public static void BringWindowToDisplayFront(ImGuiWindowPtr window)
        {
            ImGuiWindow* native_window = window.NativePtr;
            ImGuiNativeInternal.igBringWindowToDisplayFront(native_window);
        }
        public static void BringWindowToFocusFront(ImGuiWindowPtr window)
        {
            ImGuiWindow* native_window = window.NativePtr;
            ImGuiNativeInternal.igBringWindowToFocusFront(native_window);
        }
        public static bool ButtonBehavior(ImRect bb, uint id, ref bool out_hovered, ref bool out_held)
        {
            byte native_out_hovered_val = out_hovered ? (byte)1 : (byte)0;
            byte* native_out_hovered = &native_out_hovered_val;
            byte native_out_held_val = out_held ? (byte)1 : (byte)0;
            byte* native_out_held = &native_out_held_val;
            ImGuiButtonFlags flags = (ImGuiButtonFlags)0;
            byte ret = ImGuiNativeInternal.igButtonBehavior(bb, id, native_out_hovered, native_out_held, flags);
            out_hovered = native_out_hovered_val != 0;
            out_held = native_out_held_val != 0;
            return ret != 0;
        }
        public static bool ButtonBehavior(ImRect bb, uint id, ref bool out_hovered, ref bool out_held, ImGuiButtonFlags flags)
        {
            byte native_out_hovered_val = out_hovered ? (byte)1 : (byte)0;
            byte* native_out_hovered = &native_out_hovered_val;
            byte native_out_held_val = out_held ? (byte)1 : (byte)0;
            byte* native_out_held = &native_out_held_val;
            byte ret = ImGuiNativeInternal.igButtonBehavior(bb, id, native_out_hovered, native_out_held, flags);
            out_hovered = native_out_hovered_val != 0;
            out_held = native_out_held_val != 0;
            return ret != 0;
        }
        public static bool ButtonEx(string label)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            Vector2 size_arg = new Vector2();
            ImGuiButtonFlags flags = (ImGuiButtonFlags)0;
            byte ret = ImGuiNativeInternal.igButtonEx(native_label, size_arg, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            return ret != 0;
        }
        public static bool ButtonEx(string label, Vector2 size_arg)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            ImGuiButtonFlags flags = (ImGuiButtonFlags)0;
            byte ret = ImGuiNativeInternal.igButtonEx(native_label, size_arg, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            return ret != 0;
        }
        public static bool ButtonEx(string label, Vector2 size_arg, ImGuiButtonFlags flags)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte ret = ImGuiNativeInternal.igButtonEx(native_label, size_arg, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            return ret != 0;
        }
        public static Vector2 CalcItemSize(Vector2 size, float default_w, float default_h)
        {
            Vector2 __retval;
            ImGuiNativeInternal.igCalcItemSize(&__retval, size, default_w, default_h);
            return __retval;
        }
        public static ImDrawFlags CalcRoundingFlagsForRectInRect(ImRect r_in, ImRect r_outer, float threshold)
        {
            ImDrawFlags ret = ImGuiNativeInternal.igCalcRoundingFlagsForRectInRect(r_in, r_outer, threshold);
            return ret;
        }
        public static int CalcTypematicRepeatAmount(float t0, float t1, float repeat_delay, float repeat_rate)
        {
            int ret = ImGuiNativeInternal.igCalcTypematicRepeatAmount(t0, t1, repeat_delay, repeat_rate);
            return ret;
        }
        public static Vector2 CalcWindowNextAutoFitSize(ImGuiWindowPtr window)
        {
            Vector2 __retval;
            ImGuiWindow* native_window = window.NativePtr;
            ImGuiNativeInternal.igCalcWindowNextAutoFitSize(&__retval, native_window);
            return __retval;
        }
        public static float CalcWrapWidthForPos(Vector2 pos, float wrap_pos_x)
        {
            float ret = ImGuiNativeInternal.igCalcWrapWidthForPos(pos, wrap_pos_x);
            return ret;
        }
        public static void CallContextHooks(IntPtr context, ImGuiContextHookType type)
        {
            ImGuiNativeInternal.igCallContextHooks(context, type);
        }
        public static bool CheckboxFlags(string label, ref long flags, long flags_value)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            fixed (long* native_flags = &flags)
            {
                byte ret = ImGuiNativeInternal.igCheckboxFlags_S64Ptr(native_label, native_flags, flags_value);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                return ret != 0;
            }
        }
        public static bool CheckboxFlags(string label, ref ulong flags, ulong flags_value)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            fixed (ulong* native_flags = &flags)
            {
                byte ret = ImGuiNativeInternal.igCheckboxFlags_U64Ptr(native_label, native_flags, flags_value);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                return ret != 0;
            }
        }
        public static void ClearActiveID()
        {
            ImGuiNativeInternal.igClearActiveID();
        }
        public static void ClearDragDrop()
        {
            ImGuiNativeInternal.igClearDragDrop();
        }
        public static void ClearIniSettings()
        {
            ImGuiNativeInternal.igClearIniSettings();
        }
        public static bool CloseButton(uint id, Vector2 pos)
        {
            byte ret = ImGuiNativeInternal.igCloseButton(id, pos);
            return ret != 0;
        }
        public static void ClosePopupsExceptModals()
        {
            ImGuiNativeInternal.igClosePopupsExceptModals();
        }
        public static void ClosePopupsOverWindow(ImGuiWindowPtr ref_window, bool restore_focus_to_window_under_popup)
        {
            ImGuiWindow* native_ref_window = ref_window.NativePtr;
            byte native_restore_focus_to_window_under_popup = restore_focus_to_window_under_popup ? (byte)1 : (byte)0;
            ImGuiNativeInternal.igClosePopupsOverWindow(native_ref_window, native_restore_focus_to_window_under_popup);
        }
        public static void ClosePopupToLevel(int remaining, bool restore_focus_to_window_under_popup)
        {
            byte native_restore_focus_to_window_under_popup = restore_focus_to_window_under_popup ? (byte)1 : (byte)0;
            ImGuiNativeInternal.igClosePopupToLevel(remaining, native_restore_focus_to_window_under_popup);
        }
        public static bool CollapseButton(uint id, Vector2 pos, ImGuiDockNodePtr dock_node)
        {
            ImGuiDockNode* native_dock_node = dock_node.NativePtr;
            byte ret = ImGuiNativeInternal.igCollapseButton(id, pos, native_dock_node);
            return ret != 0;
        }
        public static void ColorEditOptionsPopup(ref float col, ImGuiColorEditFlags flags)
        {
            fixed (float* native_col = &col)
            {
                ImGuiNativeInternal.igColorEditOptionsPopup(native_col, flags);
            }
        }
        public static void ColorPickerOptionsPopup(ref float ref_col, ImGuiColorEditFlags flags)
        {
            fixed (float* native_ref_col = &ref_col)
            {
                ImGuiNativeInternal.igColorPickerOptionsPopup(native_ref_col, flags);
            }
        }
        public static void ColorTooltip(string text, ref float col, ImGuiColorEditFlags flags)
        {
            byte* native_text;
            int text_byteCount = 0;
            if (text != null)
            {
                text_byteCount = Encoding.UTF8.GetByteCount(text);
                if (text_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_text = Util.Allocate(text_byteCount + 1);
                }
                else
                {
                    byte* native_text_stackBytes = stackalloc byte[text_byteCount + 1];
                    native_text = native_text_stackBytes;
                }
                int native_text_offset = Util.GetUtf8(text, native_text, text_byteCount);
                native_text[native_text_offset] = 0;
            }
            else { native_text = null; }
            fixed (float* native_col = &col)
            {
                ImGuiNativeInternal.igColorTooltip(native_text, native_col, flags);
                if (text_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_text);
                }
            }
        }
        public static ImGuiWindowSettingsPtr CreateNewWindowSettings(string name)
        {
            byte* native_name;
            int name_byteCount = 0;
            if (name != null)
            {
                name_byteCount = Encoding.UTF8.GetByteCount(name);
                if (name_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_name = Util.Allocate(name_byteCount + 1);
                }
                else
                {
                    byte* native_name_stackBytes = stackalloc byte[name_byteCount + 1];
                    native_name = native_name_stackBytes;
                }
                int native_name_offset = Util.GetUtf8(name, native_name, name_byteCount);
                native_name[native_name_offset] = 0;
            }
            else { native_name = null; }
            ImGuiWindowSettings* ret = ImGuiNativeInternal.igCreateNewWindowSettings(native_name);
            if (name_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_name);
            }
            return new ImGuiWindowSettingsPtr(ret);
        }
        public static bool DataTypeApplyFromText(string buf, ImGuiDataType data_type, IntPtr p_data, string format)
        {
            byte* native_buf;
            int buf_byteCount = 0;
            if (buf != null)
            {
                buf_byteCount = Encoding.UTF8.GetByteCount(buf);
                if (buf_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_buf = Util.Allocate(buf_byteCount + 1);
                }
                else
                {
                    byte* native_buf_stackBytes = stackalloc byte[buf_byteCount + 1];
                    native_buf = native_buf_stackBytes;
                }
                int native_buf_offset = Util.GetUtf8(buf, native_buf, buf_byteCount);
                native_buf[native_buf_offset] = 0;
            }
            else { native_buf = null; }
            void* native_p_data = (void*)p_data.ToPointer();
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            byte ret = ImGuiNativeInternal.igDataTypeApplyFromText(native_buf, data_type, native_p_data, native_format);
            if (buf_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_buf);
            }
            if (format_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_format);
            }
            return ret != 0;
        }
        public static void DataTypeApplyOp(ImGuiDataType data_type, int op, IntPtr output, IntPtr arg_1, IntPtr arg_2)
        {
            void* native_output = (void*)output.ToPointer();
            void* native_arg_1 = (void*)arg_1.ToPointer();
            void* native_arg_2 = (void*)arg_2.ToPointer();
            ImGuiNativeInternal.igDataTypeApplyOp(data_type, op, native_output, native_arg_1, native_arg_2);
        }
        public static bool DataTypeClamp(ImGuiDataType data_type, IntPtr p_data, IntPtr p_min, IntPtr p_max)
        {
            void* native_p_data = (void*)p_data.ToPointer();
            void* native_p_min = (void*)p_min.ToPointer();
            void* native_p_max = (void*)p_max.ToPointer();
            byte ret = ImGuiNativeInternal.igDataTypeClamp(data_type, native_p_data, native_p_min, native_p_max);
            return ret != 0;
        }
        public static int DataTypeCompare(ImGuiDataType data_type, IntPtr arg_1, IntPtr arg_2)
        {
            void* native_arg_1 = (void*)arg_1.ToPointer();
            void* native_arg_2 = (void*)arg_2.ToPointer();
            int ret = ImGuiNativeInternal.igDataTypeCompare(data_type, native_arg_1, native_arg_2);
            return ret;
        }
        public static int DataTypeFormatString(string buf, int buf_size, ImGuiDataType data_type, IntPtr p_data, string format)
        {
            byte* native_buf;
            int buf_byteCount = 0;
            if (buf != null)
            {
                buf_byteCount = Encoding.UTF8.GetByteCount(buf);
                if (buf_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_buf = Util.Allocate(buf_byteCount + 1);
                }
                else
                {
                    byte* native_buf_stackBytes = stackalloc byte[buf_byteCount + 1];
                    native_buf = native_buf_stackBytes;
                }
                int native_buf_offset = Util.GetUtf8(buf, native_buf, buf_byteCount);
                native_buf[native_buf_offset] = 0;
            }
            else { native_buf = null; }
            void* native_p_data = (void*)p_data.ToPointer();
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            int ret = ImGuiNativeInternal.igDataTypeFormatString(native_buf, buf_size, data_type, native_p_data, native_format);
            if (buf_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_buf);
            }
            if (format_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_format);
            }
            return ret;
        }
        public static ImGuiDataTypeInfoPtr DataTypeGetInfo(ImGuiDataType data_type)
        {
            ImGuiDataTypeInfo* ret = ImGuiNativeInternal.igDataTypeGetInfo(data_type);
            return new ImGuiDataTypeInfoPtr(ret);
        }
        public static void DebugDrawItemRect()
        {
            uint col = 4278190335;
            ImGuiNativeInternal.igDebugDrawItemRect(col);
        }
        public static void DebugDrawItemRect(uint col)
        {
            ImGuiNativeInternal.igDebugDrawItemRect(col);
        }
        public static void DebugNodeColumns(ImGuiOldColumnsPtr columns)
        {
            ImGuiOldColumns* native_columns = columns.NativePtr;
            ImGuiNativeInternal.igDebugNodeColumns(native_columns);
        }
        public static void DebugNodeDockNode(ImGuiDockNodePtr node, string label)
        {
            ImGuiDockNode* native_node = node.NativePtr;
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            ImGuiNativeInternal.igDebugNodeDockNode(native_node, native_label);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
        }
        public static void DebugNodeDrawCmdShowMeshAndBoundingBox(ImDrawListPtr out_draw_list, ImDrawListPtr draw_list, ImDrawCmdPtr draw_cmd, bool show_mesh, bool show_aabb)
        {
            ImDrawList* native_out_draw_list = out_draw_list.NativePtr;
            ImDrawList* native_draw_list = draw_list.NativePtr;
            ImDrawCmd* native_draw_cmd = draw_cmd.NativePtr;
            byte native_show_mesh = show_mesh ? (byte)1 : (byte)0;
            byte native_show_aabb = show_aabb ? (byte)1 : (byte)0;
            ImGuiNativeInternal.igDebugNodeDrawCmdShowMeshAndBoundingBox(native_out_draw_list, native_draw_list, native_draw_cmd, native_show_mesh, native_show_aabb);
        }
        public static void DebugNodeDrawList(ImGuiWindowPtr window, ImGuiViewportPPtr viewport, ImDrawListPtr draw_list, string label)
        {
            ImGuiWindow* native_window = window.NativePtr;
            ImGuiViewportP* native_viewport = viewport.NativePtr;
            ImDrawList* native_draw_list = draw_list.NativePtr;
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            ImGuiNativeInternal.igDebugNodeDrawList(native_window, native_viewport, native_draw_list, native_label);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
        }
        public static void DebugNodeFont(ImFontPtr font)
        {
            ImFont* native_font = font.NativePtr;
            ImGuiNativeInternal.igDebugNodeFont(native_font);
        }
        public static void DebugNodeStorage(ImGuiStoragePtr storage, string label)
        {
            ImGuiStorage* native_storage = storage.NativePtr;
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            ImGuiNativeInternal.igDebugNodeStorage(native_storage, native_label);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
        }
        public static void DebugNodeTabBar(ImGuiTabBarPtr tab_bar, string label)
        {
            ImGuiTabBar* native_tab_bar = tab_bar.NativePtr;
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            ImGuiNativeInternal.igDebugNodeTabBar(native_tab_bar, native_label);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
        }
        public static void DebugNodeTableSettings(ImGuiTableSettingsPtr settings)
        {
            ImGuiTableSettings* native_settings = settings.NativePtr;
            ImGuiNativeInternal.igDebugNodeTableSettings(native_settings);
        }
        public static void DebugNodeViewport(ImGuiViewportPPtr viewport)
        {
            ImGuiViewportP* native_viewport = viewport.NativePtr;
            ImGuiNativeInternal.igDebugNodeViewport(native_viewport);
        }
        public static void DebugNodeWindow(ImGuiWindowPtr window, string label)
        {
            ImGuiWindow* native_window = window.NativePtr;
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            ImGuiNativeInternal.igDebugNodeWindow(native_window, native_label);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
        }
        public static void DebugNodeWindowSettings(ImGuiWindowSettingsPtr settings)
        {
            ImGuiWindowSettings* native_settings = settings.NativePtr;
            ImGuiNativeInternal.igDebugNodeWindowSettings(native_settings);
        }
        public static void DebugNodeWindowsList(ref ImVector windows, string label)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            fixed (ImVector* native_windows = &windows)
            {
                ImGuiNativeInternal.igDebugNodeWindowsList(native_windows, native_label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
            }
        }
        public static void DebugNodeWindowsListByBeginStackParent(ref ImGuiWindow* windows, int windows_size, ImGuiWindowPtr parent_in_begin_stack)
        {
            ImGuiWindow* native_parent_in_begin_stack = parent_in_begin_stack.NativePtr;
            fixed (ImGuiWindow** native_windows = &windows)
            {
                ImGuiNativeInternal.igDebugNodeWindowsListByBeginStackParent(native_windows, windows_size, native_parent_in_begin_stack);
            }
        }
        public static void DebugRenderViewportThumbnail(ImDrawListPtr draw_list, ImGuiViewportPPtr viewport, ImRect bb)
        {
            ImDrawList* native_draw_list = draw_list.NativePtr;
            ImGuiViewportP* native_viewport = viewport.NativePtr;
            ImGuiNativeInternal.igDebugRenderViewportThumbnail(native_draw_list, native_viewport, bb);
        }
        public static void DebugStartItemPicker()
        {
            ImGuiNativeInternal.igDebugStartItemPicker();
        }
        public static void DestroyPlatformWindow(ImGuiViewportPPtr viewport)
        {
            ImGuiViewportP* native_viewport = viewport.NativePtr;
            ImGuiNativeInternal.igDestroyPlatformWindow(native_viewport);
        }
        public static uint DockBuilderAddNode()
        {
            uint node_id = 0;
            ImGuiDockNodeFlags flags = (ImGuiDockNodeFlags)0;
            uint ret = ImGuiNativeInternal.igDockBuilderAddNode(node_id, flags);
            return ret;
        }
        public static uint DockBuilderAddNode(uint node_id)
        {
            ImGuiDockNodeFlags flags = (ImGuiDockNodeFlags)0;
            uint ret = ImGuiNativeInternal.igDockBuilderAddNode(node_id, flags);
            return ret;
        }
        public static uint DockBuilderAddNode(uint node_id, ImGuiDockNodeFlags flags)
        {
            uint ret = ImGuiNativeInternal.igDockBuilderAddNode(node_id, flags);
            return ret;
        }
        public static void DockBuilderCopyDockSpace(uint src_dockspace_id, uint dst_dockspace_id, ref ImVector in_window_remap_pairs)
        {
            fixed (ImVector* native_in_window_remap_pairs = &in_window_remap_pairs)
            {
                ImGuiNativeInternal.igDockBuilderCopyDockSpace(src_dockspace_id, dst_dockspace_id, native_in_window_remap_pairs);
            }
        }
        public static void DockBuilderCopyNode(uint src_node_id, uint dst_node_id, out ImVector out_node_remap_pairs)
        {
            fixed (ImVector* native_out_node_remap_pairs = &out_node_remap_pairs)
            {
                ImGuiNativeInternal.igDockBuilderCopyNode(src_node_id, dst_node_id, native_out_node_remap_pairs);
            }
        }
        public static void DockBuilderCopyWindowSettings(string src_name, string dst_name)
        {
            byte* native_src_name;
            int src_name_byteCount = 0;
            if (src_name != null)
            {
                src_name_byteCount = Encoding.UTF8.GetByteCount(src_name);
                if (src_name_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_src_name = Util.Allocate(src_name_byteCount + 1);
                }
                else
                {
                    byte* native_src_name_stackBytes = stackalloc byte[src_name_byteCount + 1];
                    native_src_name = native_src_name_stackBytes;
                }
                int native_src_name_offset = Util.GetUtf8(src_name, native_src_name, src_name_byteCount);
                native_src_name[native_src_name_offset] = 0;
            }
            else { native_src_name = null; }
            byte* native_dst_name;
            int dst_name_byteCount = 0;
            if (dst_name != null)
            {
                dst_name_byteCount = Encoding.UTF8.GetByteCount(dst_name);
                if (dst_name_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_dst_name = Util.Allocate(dst_name_byteCount + 1);
                }
                else
                {
                    byte* native_dst_name_stackBytes = stackalloc byte[dst_name_byteCount + 1];
                    native_dst_name = native_dst_name_stackBytes;
                }
                int native_dst_name_offset = Util.GetUtf8(dst_name, native_dst_name, dst_name_byteCount);
                native_dst_name[native_dst_name_offset] = 0;
            }
            else { native_dst_name = null; }
            ImGuiNativeInternal.igDockBuilderCopyWindowSettings(native_src_name, native_dst_name);
            if (src_name_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_src_name);
            }
            if (dst_name_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_dst_name);
            }
        }
        public static void DockBuilderDockWindow(string window_name, uint node_id)
        {
            byte* native_window_name;
            int window_name_byteCount = 0;
            if (window_name != null)
            {
                window_name_byteCount = Encoding.UTF8.GetByteCount(window_name);
                if (window_name_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_window_name = Util.Allocate(window_name_byteCount + 1);
                }
                else
                {
                    byte* native_window_name_stackBytes = stackalloc byte[window_name_byteCount + 1];
                    native_window_name = native_window_name_stackBytes;
                }
                int native_window_name_offset = Util.GetUtf8(window_name, native_window_name, window_name_byteCount);
                native_window_name[native_window_name_offset] = 0;
            }
            else { native_window_name = null; }
            ImGuiNativeInternal.igDockBuilderDockWindow(native_window_name, node_id);
            if (window_name_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_window_name);
            }
        }
        public static void DockBuilderFinish(uint node_id)
        {
            ImGuiNativeInternal.igDockBuilderFinish(node_id);
        }
        public static ImGuiDockNodePtr DockBuilderGetCentralNode(uint node_id)
        {
            ImGuiDockNode* ret = ImGuiNativeInternal.igDockBuilderGetCentralNode(node_id);
            return new ImGuiDockNodePtr(ret);
        }
        public static ImGuiDockNodePtr DockBuilderGetNode(uint node_id)
        {
            ImGuiDockNode* ret = ImGuiNativeInternal.igDockBuilderGetNode(node_id);
            return new ImGuiDockNodePtr(ret);
        }
        public static void DockBuilderRemoveNode(uint node_id)
        {
            ImGuiNativeInternal.igDockBuilderRemoveNode(node_id);
        }
        public static void DockBuilderRemoveNodeChildNodes(uint node_id)
        {
            ImGuiNativeInternal.igDockBuilderRemoveNodeChildNodes(node_id);
        }
        public static void DockBuilderRemoveNodeDockedWindows(uint node_id)
        {
            byte clear_settings_refs = 1;
            ImGuiNativeInternal.igDockBuilderRemoveNodeDockedWindows(node_id, clear_settings_refs);
        }
        public static void DockBuilderRemoveNodeDockedWindows(uint node_id, bool clear_settings_refs)
        {
            byte native_clear_settings_refs = clear_settings_refs ? (byte)1 : (byte)0;
            ImGuiNativeInternal.igDockBuilderRemoveNodeDockedWindows(node_id, native_clear_settings_refs);
        }
        public static void DockBuilderSetNodePos(uint node_id, Vector2 pos)
        {
            ImGuiNativeInternal.igDockBuilderSetNodePos(node_id, pos);
        }
        public static void DockBuilderSetNodeSize(uint node_id, Vector2 size)
        {
            ImGuiNativeInternal.igDockBuilderSetNodeSize(node_id, size);
        }
        public static uint DockBuilderSplitNode(uint node_id, ImGuiDir split_dir, float size_ratio_for_node_at_dir, out uint out_id_at_dir, out uint out_id_at_opposite_dir)
        {
            fixed (uint* native_out_id_at_dir = &out_id_at_dir)
            {
                fixed (uint* native_out_id_at_opposite_dir = &out_id_at_opposite_dir)
                {
                    uint ret = ImGuiNativeInternal.igDockBuilderSplitNode(node_id, split_dir, size_ratio_for_node_at_dir, native_out_id_at_dir, native_out_id_at_opposite_dir);
                    return ret;
                }
            }
        }
        public static bool DockContextCalcDropPosForDocking(ImGuiWindowPtr target, ImGuiDockNodePtr target_node, ImGuiWindowPtr payload, ImGuiDir split_dir, bool split_outer, out Vector2 out_pos)
        {
            ImGuiWindow* native_target = target.NativePtr;
            ImGuiDockNode* native_target_node = target_node.NativePtr;
            ImGuiWindow* native_payload = payload.NativePtr;
            byte native_split_outer = split_outer ? (byte)1 : (byte)0;
            fixed (Vector2* native_out_pos = &out_pos)
            {
                byte ret = ImGuiNativeInternal.igDockContextCalcDropPosForDocking(native_target, native_target_node, native_payload, split_dir, native_split_outer, native_out_pos);
                return ret != 0;
            }
        }
        public static void DockContextClearNodes(IntPtr ctx, uint root_id, bool clear_settings_refs)
        {
            byte native_clear_settings_refs = clear_settings_refs ? (byte)1 : (byte)0;
            ImGuiNativeInternal.igDockContextClearNodes(ctx, root_id, native_clear_settings_refs);
        }
        public static void DockContextEndFrame(IntPtr ctx)
        {
            ImGuiNativeInternal.igDockContextEndFrame(ctx);
        }
        public static uint DockContextGenNodeID(IntPtr ctx)
        {
            uint ret = ImGuiNativeInternal.igDockContextGenNodeID(ctx);
            return ret;
        }
        public static void DockContextInitialize(IntPtr ctx)
        {
            ImGuiNativeInternal.igDockContextInitialize(ctx);
        }
        public static void DockContextNewFrameUpdateDocking(IntPtr ctx)
        {
            ImGuiNativeInternal.igDockContextNewFrameUpdateDocking(ctx);
        }
        public static void DockContextNewFrameUpdateUndocking(IntPtr ctx)
        {
            ImGuiNativeInternal.igDockContextNewFrameUpdateUndocking(ctx);
        }
        public static void DockContextQueueDock(IntPtr ctx, ImGuiWindowPtr target, ImGuiDockNodePtr target_node, ImGuiWindowPtr payload, ImGuiDir split_dir, float split_ratio, bool split_outer)
        {
            ImGuiWindow* native_target = target.NativePtr;
            ImGuiDockNode* native_target_node = target_node.NativePtr;
            ImGuiWindow* native_payload = payload.NativePtr;
            byte native_split_outer = split_outer ? (byte)1 : (byte)0;
            ImGuiNativeInternal.igDockContextQueueDock(ctx, native_target, native_target_node, native_payload, split_dir, split_ratio, native_split_outer);
        }
        public static void DockContextQueueUndockNode(IntPtr ctx, ImGuiDockNodePtr node)
        {
            ImGuiDockNode* native_node = node.NativePtr;
            ImGuiNativeInternal.igDockContextQueueUndockNode(ctx, native_node);
        }
        public static void DockContextQueueUndockWindow(IntPtr ctx, ImGuiWindowPtr window)
        {
            ImGuiWindow* native_window = window.NativePtr;
            ImGuiNativeInternal.igDockContextQueueUndockWindow(ctx, native_window);
        }
        public static void DockContextRebuildNodes(IntPtr ctx)
        {
            ImGuiNativeInternal.igDockContextRebuildNodes(ctx);
        }
        public static void DockContextShutdown(IntPtr ctx)
        {
            ImGuiNativeInternal.igDockContextShutdown(ctx);
        }
        public static bool DockNodeBeginAmendTabBar(ImGuiDockNodePtr node)
        {
            ImGuiDockNode* native_node = node.NativePtr;
            byte ret = ImGuiNativeInternal.igDockNodeBeginAmendTabBar(native_node);
            return ret != 0;
        }
        public static void DockNodeEndAmendTabBar()
        {
            ImGuiNativeInternal.igDockNodeEndAmendTabBar();
        }
        public static int DockNodeGetDepth(ImGuiDockNodePtr node)
        {
            ImGuiDockNode* native_node = node.NativePtr;
            int ret = ImGuiNativeInternal.igDockNodeGetDepth(native_node);
            return ret;
        }
        public static ImGuiDockNodePtr DockNodeGetRootNode(ImGuiDockNodePtr node)
        {
            ImGuiDockNode* native_node = node.NativePtr;
            ImGuiDockNode* ret = ImGuiNativeInternal.igDockNodeGetRootNode(native_node);
            return new ImGuiDockNodePtr(ret);
        }
        public static uint DockNodeGetWindowMenuButtonId(ImGuiDockNodePtr node)
        {
            ImGuiDockNode* native_node = node.NativePtr;
            uint ret = ImGuiNativeInternal.igDockNodeGetWindowMenuButtonId(native_node);
            return ret;
        }
        public static bool DockNodeIsInHierarchyOf(ImGuiDockNodePtr node, ImGuiDockNodePtr parent)
        {
            ImGuiDockNode* native_node = node.NativePtr;
            ImGuiDockNode* native_parent = parent.NativePtr;
            byte ret = ImGuiNativeInternal.igDockNodeIsInHierarchyOf(native_node, native_parent);
            return ret != 0;
        }
        public static bool DragBehavior(uint id, ImGuiDataType data_type, IntPtr p_v, float v_speed, IntPtr p_min, IntPtr p_max, string format, ImGuiSliderFlags flags)
        {
            void* native_p_v = (void*)p_v.ToPointer();
            void* native_p_min = (void*)p_min.ToPointer();
            void* native_p_max = (void*)p_max.ToPointer();
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            byte ret = ImGuiNativeInternal.igDragBehavior(id, data_type, native_p_v, v_speed, native_p_min, native_p_max, native_format, flags);
            if (format_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_format);
            }
            return ret != 0;
        }
        public static void EndColumns()
        {
            ImGuiNativeInternal.igEndColumns();
        }
        public static void EndComboPreview()
        {
            ImGuiNativeInternal.igEndComboPreview();
        }
        public static void ErrorCheckEndFrameRecover(IntPtr log_callback)
        {
            void* user_data = null;
            ImGuiNativeInternal.igErrorCheckEndFrameRecover(log_callback, user_data);
        }
        public static void ErrorCheckEndFrameRecover(IntPtr log_callback, IntPtr user_data)
        {
            void* native_user_data = (void*)user_data.ToPointer();
            ImGuiNativeInternal.igErrorCheckEndFrameRecover(log_callback, native_user_data);
        }
        public static void ErrorCheckEndWindowRecover(IntPtr log_callback)
        {
            void* user_data = null;
            ImGuiNativeInternal.igErrorCheckEndWindowRecover(log_callback, user_data);
        }
        public static void ErrorCheckEndWindowRecover(IntPtr log_callback, IntPtr user_data)
        {
            void* native_user_data = (void*)user_data.ToPointer();
            ImGuiNativeInternal.igErrorCheckEndWindowRecover(log_callback, native_user_data);
        }
        public static Vector2 FindBestWindowPosForPopup(ImGuiWindowPtr window)
        {
            Vector2 __retval;
            ImGuiWindow* native_window = window.NativePtr;
            ImGuiNativeInternal.igFindBestWindowPosForPopup(&__retval, native_window);
            return __retval;
        }
        public static Vector2 FindBestWindowPosForPopupEx(Vector2 ref_pos, Vector2 size, ref ImGuiDir last_dir, ImRect r_outer, ImRect r_avoid, ImGuiPopupPositionPolicy policy)
        {
            Vector2 __retval;
            fixed (ImGuiDir* native_last_dir = &last_dir)
            {
                ImGuiNativeInternal.igFindBestWindowPosForPopupEx(&__retval, ref_pos, size, (IntPtr)native_last_dir, r_outer, r_avoid, policy);
                return __retval;
            }
        }
        public static ImGuiWindowPtr FindBottomMostVisibleWindowWithinBeginStack(ImGuiWindowPtr window)
        {
            ImGuiWindow* native_window = window.NativePtr;
            ImGuiWindow* ret = ImGuiNativeInternal.igFindBottomMostVisibleWindowWithinBeginStack(native_window);
            return new ImGuiWindowPtr(ret);
        }
        public static ImGuiViewportPPtr FindHoveredViewportFromPlatformWindowStack(Vector2 mouse_platform_pos)
        {
            ImGuiViewportP* ret = ImGuiNativeInternal.igFindHoveredViewportFromPlatformWindowStack(mouse_platform_pos);
            return new ImGuiViewportPPtr(ret);
        }
        public static ImGuiOldColumnsPtr FindOrCreateColumns(ImGuiWindowPtr window, uint id)
        {
            ImGuiWindow* native_window = window.NativePtr;
            ImGuiOldColumns* ret = ImGuiNativeInternal.igFindOrCreateColumns(native_window, id);
            return new ImGuiOldColumnsPtr(ret);
        }
        public static ImGuiWindowSettingsPtr FindOrCreateWindowSettings(string name)
        {
            byte* native_name;
            int name_byteCount = 0;
            if (name != null)
            {
                name_byteCount = Encoding.UTF8.GetByteCount(name);
                if (name_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_name = Util.Allocate(name_byteCount + 1);
                }
                else
                {
                    byte* native_name_stackBytes = stackalloc byte[name_byteCount + 1];
                    native_name = native_name_stackBytes;
                }
                int native_name_offset = Util.GetUtf8(name, native_name, name_byteCount);
                native_name[native_name_offset] = 0;
            }
            else { native_name = null; }
            ImGuiWindowSettings* ret = ImGuiNativeInternal.igFindOrCreateWindowSettings(native_name);
            if (name_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_name);
            }
            return new ImGuiWindowSettingsPtr(ret);
        }
        public static string FindRenderedTextEnd(string text)
        {
            byte* native_text;
            int text_byteCount = 0;
            if (text != null)
            {
                text_byteCount = Encoding.UTF8.GetByteCount(text);
                if (text_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_text = Util.Allocate(text_byteCount + 1);
                }
                else
                {
                    byte* native_text_stackBytes = stackalloc byte[text_byteCount + 1];
                    native_text = native_text_stackBytes;
                }
                int native_text_offset = Util.GetUtf8(text, native_text, text_byteCount);
                native_text[native_text_offset] = 0;
            }
            else { native_text = null; }
            byte* native_text_end = null;
            byte* ret = ImGuiNativeInternal.igFindRenderedTextEnd(native_text, native_text_end);
            if (text_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_text);
            }
            return Util.StringFromPtr(ret);
        }
        public static ImGuiSettingsHandlerPtr FindSettingsHandler(string type_name)
        {
            byte* native_type_name;
            int type_name_byteCount = 0;
            if (type_name != null)
            {
                type_name_byteCount = Encoding.UTF8.GetByteCount(type_name);
                if (type_name_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_type_name = Util.Allocate(type_name_byteCount + 1);
                }
                else
                {
                    byte* native_type_name_stackBytes = stackalloc byte[type_name_byteCount + 1];
                    native_type_name = native_type_name_stackBytes;
                }
                int native_type_name_offset = Util.GetUtf8(type_name, native_type_name, type_name_byteCount);
                native_type_name[native_type_name_offset] = 0;
            }
            else { native_type_name = null; }
            ImGuiSettingsHandler* ret = ImGuiNativeInternal.igFindSettingsHandler(native_type_name);
            if (type_name_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_type_name);
            }
            return new ImGuiSettingsHandlerPtr(ret);
        }
        public static ImGuiWindowPtr FindWindowByID(uint id)
        {
            ImGuiWindow* ret = ImGuiNativeInternal.igFindWindowByID(id);
            return new ImGuiWindowPtr(ret);
        }
        public static ImGuiWindowPtr FindWindowByName(string name)
        {
            byte* native_name;
            int name_byteCount = 0;
            if (name != null)
            {
                name_byteCount = Encoding.UTF8.GetByteCount(name);
                if (name_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_name = Util.Allocate(name_byteCount + 1);
                }
                else
                {
                    byte* native_name_stackBytes = stackalloc byte[name_byteCount + 1];
                    native_name = native_name_stackBytes;
                }
                int native_name_offset = Util.GetUtf8(name, native_name, name_byteCount);
                native_name[native_name_offset] = 0;
            }
            else { native_name = null; }
            ImGuiWindow* ret = ImGuiNativeInternal.igFindWindowByName(native_name);
            if (name_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_name);
            }
            return new ImGuiWindowPtr(ret);
        }
        public static int FindWindowDisplayIndex(ImGuiWindowPtr window)
        {
            ImGuiWindow* native_window = window.NativePtr;
            int ret = ImGuiNativeInternal.igFindWindowDisplayIndex(native_window);
            return ret;
        }
        public static ImGuiWindowSettingsPtr FindWindowSettings(uint id)
        {
            ImGuiWindowSettings* ret = ImGuiNativeInternal.igFindWindowSettings(id);
            return new ImGuiWindowSettingsPtr(ret);
        }
        public static void FocusTopMostWindowUnderOne(ImGuiWindowPtr under_this_window, ImGuiWindowPtr ignore_window)
        {
            ImGuiWindow* native_under_this_window = under_this_window.NativePtr;
            ImGuiWindow* native_ignore_window = ignore_window.NativePtr;
            ImGuiNativeInternal.igFocusTopMostWindowUnderOne(native_under_this_window, native_ignore_window);
        }
        public static void FocusWindow(ImGuiWindowPtr window)
        {
            ImGuiWindow* native_window = window.NativePtr;
            ImGuiNativeInternal.igFocusWindow(native_window);
        }
        public static void GcAwakeTransientWindowBuffers(ImGuiWindowPtr window)
        {
            ImGuiWindow* native_window = window.NativePtr;
            ImGuiNativeInternal.igGcAwakeTransientWindowBuffers(native_window);
        }
        public static void GcCompactTransientMiscBuffers()
        {
            ImGuiNativeInternal.igGcCompactTransientMiscBuffers();
        }
        public static void GcCompactTransientWindowBuffers(ImGuiWindowPtr window)
        {
            ImGuiWindow* native_window = window.NativePtr;
            ImGuiNativeInternal.igGcCompactTransientWindowBuffers(native_window);
        }
        public static uint GetActiveID()
        {
            uint ret = ImGuiNativeInternal.igGetActiveID();
            return ret;
        }
        public static float GetColumnNormFromOffset(ImGuiOldColumnsPtr columns, float offset)
        {
            ImGuiOldColumns* native_columns = columns.NativePtr;
            float ret = ImGuiNativeInternal.igGetColumnNormFromOffset(native_columns, offset);
            return ret;
        }
        public static float GetColumnOffsetFromNorm(ImGuiOldColumnsPtr columns, float offset_norm)
        {
            ImGuiOldColumns* native_columns = columns.NativePtr;
            float ret = ImGuiNativeInternal.igGetColumnOffsetFromNorm(native_columns, offset_norm);
            return ret;
        }
        public static uint GetColumnsID(string str_id, int count)
        {
            byte* native_str_id;
            int str_id_byteCount = 0;
            if (str_id != null)
            {
                str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
                if (str_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_str_id = Util.Allocate(str_id_byteCount + 1);
                }
                else
                {
                    byte* native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
                    native_str_id = native_str_id_stackBytes;
                }
                int native_str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            else { native_str_id = null; }
            uint ret = ImGuiNativeInternal.igGetColumnsID(native_str_id, count);
            if (str_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_str_id);
            }
            return ret;
        }
        public static Vector2 GetContentRegionMaxAbs()
        {
            Vector2 __retval;
            ImGuiNativeInternal.igGetContentRegionMaxAbs(&__retval);
            return __retval;
        }
        public static ImGuiWindowPtr GetCurrentWindow()
        {
            ImGuiWindow* ret = ImGuiNativeInternal.igGetCurrentWindow();
            return new ImGuiWindowPtr(ret);
        }
        public static ImGuiWindowPtr GetCurrentWindowRead()
        {
            ImGuiWindow* ret = ImGuiNativeInternal.igGetCurrentWindowRead();
            return new ImGuiWindowPtr(ret);
        }
        public static ImFontPtr GetDefaultFont()
        {
            ImFont* ret = ImGuiNativeInternal.igGetDefaultFont();
            return new ImFontPtr(ret);
        }
        public static uint GetFocusedFocusScope()
        {
            uint ret = ImGuiNativeInternal.igGetFocusedFocusScope();
            return ret;
        }
        public static uint GetFocusID()
        {
            uint ret = ImGuiNativeInternal.igGetFocusID();
            return ret;
        }
        public static uint GetFocusScope()
        {
            uint ret = ImGuiNativeInternal.igGetFocusScope();
            return ret;
        }
        public static ImDrawListPtr GetForegroundDrawList(ImGuiWindowPtr window)
        {
            ImGuiWindow* native_window = window.NativePtr;
            ImDrawList* ret = ImGuiNativeInternal.igGetForegroundDrawList_WindowPtr(native_window);
            return new ImDrawListPtr(ret);
        }
        public static uint GetHoveredID()
        {
            uint ret = ImGuiNativeInternal.igGetHoveredID();
            return ret;
        }
        public static ImGuiInputTextStatePtr GetInputTextState(uint id)
        {
            ImGuiInputTextState* ret = ImGuiNativeInternal.igGetInputTextState(id);
            return new ImGuiInputTextStatePtr(ret);
        }
        public static ImGuiItemFlags GetItemFlags()
        {
            ImGuiItemFlags ret = ImGuiNativeInternal.igGetItemFlags();
            return ret;
        }
        public static uint GetItemID()
        {
            uint ret = ImGuiNativeInternal.igGetItemID();
            return ret;
        }
        public static ImGuiItemStatusFlags GetItemStatusFlags()
        {
            ImGuiItemStatusFlags ret = ImGuiNativeInternal.igGetItemStatusFlags();
            return ret;
        }
        public static ImGuiKeyDataPtr GetKeyData(ImGuiKey key)
        {
            ImGuiKeyData* ret = ImGuiNativeInternal.igGetKeyData(key);
            return new ImGuiKeyDataPtr(ret);
        }
        public static ImGuiKeyModFlags GetMergedKeyModFlags()
        {
            ImGuiKeyModFlags ret = ImGuiNativeInternal.igGetMergedKeyModFlags();
            return ret;
        }
        public static float GetNavInputAmount(ImGuiNavInput n, ImGuiInputReadMode mode)
        {
            float ret = ImGuiNativeInternal.igGetNavInputAmount(n, mode);
            return ret;
        }
        public static Vector2 GetNavInputAmount2d(ImGuiNavDirSourceFlags dir_sources, ImGuiInputReadMode mode)
        {
            Vector2 __retval;
            float slow_factor = 0.0f;
            float fast_factor = 0.0f;
            ImGuiNativeInternal.igGetNavInputAmount2d(&__retval, dir_sources, mode, slow_factor, fast_factor);
            return __retval;
        }
        public static Vector2 GetNavInputAmount2d(ImGuiNavDirSourceFlags dir_sources, ImGuiInputReadMode mode, float slow_factor)
        {
            Vector2 __retval;
            float fast_factor = 0.0f;
            ImGuiNativeInternal.igGetNavInputAmount2d(&__retval, dir_sources, mode, slow_factor, fast_factor);
            return __retval;
        }
        public static Vector2 GetNavInputAmount2d(ImGuiNavDirSourceFlags dir_sources, ImGuiInputReadMode mode, float slow_factor, float fast_factor)
        {
            Vector2 __retval;
            ImGuiNativeInternal.igGetNavInputAmount2d(&__retval, dir_sources, mode, slow_factor, fast_factor);
            return __retval;
        }
        public static string GetNavInputName(ImGuiNavInput n)
        {
            byte* ret = ImGuiNativeInternal.igGetNavInputName(n);
            return Util.StringFromPtr(ret);
        }
        public static ImRect GetPopupAllowedExtentRect(ImGuiWindowPtr window)
        {
            ImRect __retval;
            ImGuiWindow* native_window = window.NativePtr;
            ImGuiNativeInternal.igGetPopupAllowedExtentRect(&__retval, native_window);
            return __retval;
        }
        public static ImGuiWindowPtr GetTopMostAndVisiblePopupModal()
        {
            ImGuiWindow* ret = ImGuiNativeInternal.igGetTopMostAndVisiblePopupModal();
            return new ImGuiWindowPtr(ret);
        }
        public static ImGuiWindowPtr GetTopMostPopupModal()
        {
            ImGuiWindow* ret = ImGuiNativeInternal.igGetTopMostPopupModal();
            return new ImGuiWindowPtr(ret);
        }
        public static ImGuiPlatformMonitorPtr GetViewportPlatformMonitor(ImGuiViewportPtr viewport)
        {
            ImGuiViewport* native_viewport = viewport.NativePtr;
            ImGuiPlatformMonitor* ret = ImGuiNativeInternal.igGetViewportPlatformMonitor(native_viewport);
            return new ImGuiPlatformMonitorPtr(ret);
        }
        public static bool GetWindowAlwaysWantOwnTabBar(ImGuiWindowPtr window)
        {
            ImGuiWindow* native_window = window.NativePtr;
            byte ret = ImGuiNativeInternal.igGetWindowAlwaysWantOwnTabBar(native_window);
            return ret != 0;
        }
        public static ImGuiDockNodePtr GetWindowDockNode()
        {
            ImGuiDockNode* ret = ImGuiNativeInternal.igGetWindowDockNode();
            return new ImGuiDockNodePtr(ret);
        }
        public static uint GetWindowResizeBorderID(ImGuiWindowPtr window, ImGuiDir dir)
        {
            ImGuiWindow* native_window = window.NativePtr;
            uint ret = ImGuiNativeInternal.igGetWindowResizeBorderID(native_window, dir);
            return ret;
        }
        public static uint GetWindowResizeCornerID(ImGuiWindowPtr window, int n)
        {
            ImGuiWindow* native_window = window.NativePtr;
            uint ret = ImGuiNativeInternal.igGetWindowResizeCornerID(native_window, n);
            return ret;
        }
        public static uint GetWindowScrollbarID(ImGuiWindowPtr window, ImGuiAxis axis)
        {
            ImGuiWindow* native_window = window.NativePtr;
            uint ret = ImGuiNativeInternal.igGetWindowScrollbarID(native_window, axis);
            return ret;
        }
        public static ImRect GetWindowScrollbarRect(ImGuiWindowPtr window, ImGuiAxis axis)
        {
            ImRect __retval;
            ImGuiWindow* native_window = window.NativePtr;
            ImGuiNativeInternal.igGetWindowScrollbarRect(&__retval, native_window, axis);
            return __retval;
        }
        public static int ImAbs(int x)
        {
            int ret = ImGuiNativeInternal.igImAbs_Int(x);
            return ret;
        }
        public static float ImAbs(float x)
        {
            float ret = ImGuiNativeInternal.igImAbs_Float(x);
            return ret;
        }
        public static double ImAbs(double x)
        {
            double ret = ImGuiNativeInternal.igImAbs_double(x);
            return ret;
        }
        public static bool ImageButtonEx(uint id, IntPtr texture_id, Vector2 size, Vector2 uv0, Vector2 uv1, Vector2 padding, Vector4 bg_col, Vector4 tint_col)
        {
            byte ret = ImGuiNativeInternal.igImageButtonEx(id, texture_id, size, uv0, uv1, padding, bg_col, tint_col);
            return ret != 0;
        }
        public static uint ImAlphaBlendColors(uint col_a, uint col_b)
        {
            uint ret = ImGuiNativeInternal.igImAlphaBlendColors(col_a, col_b);
            return ret;
        }
        public static Vector2 ImBezierCubicCalc(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, float t)
        {
            Vector2 __retval;
            ImGuiNativeInternal.igImBezierCubicCalc(&__retval, p1, p2, p3, p4, t);
            return __retval;
        }
        public static Vector2 ImBezierCubicClosestPoint(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, Vector2 p, int num_segments)
        {
            Vector2 __retval;
            ImGuiNativeInternal.igImBezierCubicClosestPoint(&__retval, p1, p2, p3, p4, p, num_segments);
            return __retval;
        }
        public static Vector2 ImBezierCubicClosestPointCasteljau(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, Vector2 p, float tess_tol)
        {
            Vector2 __retval;
            ImGuiNativeInternal.igImBezierCubicClosestPointCasteljau(&__retval, p1, p2, p3, p4, p, tess_tol);
            return __retval;
        }
        public static Vector2 ImBezierQuadraticCalc(Vector2 p1, Vector2 p2, Vector2 p3, float t)
        {
            Vector2 __retval;
            ImGuiNativeInternal.igImBezierQuadraticCalc(&__retval, p1, p2, p3, t);
            return __retval;
        }
        public static void ImBitArrayClearBit(ref uint arr, int n)
        {
            fixed (uint* native_arr = &arr)
            {
                ImGuiNativeInternal.igImBitArrayClearBit(native_arr, n);
            }
        }
        public static void ImBitArraySetBit(ref uint arr, int n)
        {
            fixed (uint* native_arr = &arr)
            {
                ImGuiNativeInternal.igImBitArraySetBit(native_arr, n);
            }
        }
        public static void ImBitArraySetBitRange(ref uint arr, int n, int n2)
        {
            fixed (uint* native_arr = &arr)
            {
                ImGuiNativeInternal.igImBitArraySetBitRange(native_arr, n, n2);
            }
        }
        public static bool ImBitArrayTestBit(ref uint arr, int n)
        {
            fixed (uint* native_arr = &arr)
            {
                byte ret = ImGuiNativeInternal.igImBitArrayTestBit(native_arr, n);
                return ret != 0;
            }
        }
        public static bool ImCharIsBlankA(byte c)
        {
            byte ret = ImGuiNativeInternal.igImCharIsBlankA(c);
            return ret != 0;
        }
        public static bool ImCharIsBlankW(uint c)
        {
            byte ret = ImGuiNativeInternal.igImCharIsBlankW(c);
            return ret != 0;
        }
        public static Vector2 ImClamp(Vector2 v, Vector2 mn, Vector2 mx)
        {
            Vector2 __retval;
            ImGuiNativeInternal.igImClamp(&__retval, v, mn, mx);
            return __retval;
        }
        public static float ImDot(Vector2 a, Vector2 b)
        {
            float ret = ImGuiNativeInternal.igImDot(a, b);
            return ret;
        }
        public static bool ImFileClose(IntPtr file)
        {
            byte ret = ImGuiNativeInternal.igImFileClose(file);
            return ret != 0;
        }
        public static ulong ImFileGetSize(IntPtr file)
        {
            ulong ret = ImGuiNativeInternal.igImFileGetSize(file);
            return ret;
        }
        public static IntPtr ImFileLoadToMemory(string filename, string mode)
        {
            byte* native_filename;
            int filename_byteCount = 0;
            if (filename != null)
            {
                filename_byteCount = Encoding.UTF8.GetByteCount(filename);
                if (filename_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_filename = Util.Allocate(filename_byteCount + 1);
                }
                else
                {
                    byte* native_filename_stackBytes = stackalloc byte[filename_byteCount + 1];
                    native_filename = native_filename_stackBytes;
                }
                int native_filename_offset = Util.GetUtf8(filename, native_filename, filename_byteCount);
                native_filename[native_filename_offset] = 0;
            }
            else { native_filename = null; }
            byte* native_mode;
            int mode_byteCount = 0;
            if (mode != null)
            {
                mode_byteCount = Encoding.UTF8.GetByteCount(mode);
                if (mode_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_mode = Util.Allocate(mode_byteCount + 1);
                }
                else
                {
                    byte* native_mode_stackBytes = stackalloc byte[mode_byteCount + 1];
                    native_mode = native_mode_stackBytes;
                }
                int native_mode_offset = Util.GetUtf8(mode, native_mode, mode_byteCount);
                native_mode[native_mode_offset] = 0;
            }
            else { native_mode = null; }
            uint* out_file_size = null;
            int padding_bytes = 0;
            void* ret = ImGuiNativeInternal.igImFileLoadToMemory(native_filename, native_mode, out_file_size, padding_bytes);
            if (filename_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_filename);
            }
            if (mode_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_mode);
            }
            return (IntPtr)ret;
        }
        public static IntPtr ImFileLoadToMemory(string filename, string mode, out uint out_file_size)
        {
            byte* native_filename;
            int filename_byteCount = 0;
            if (filename != null)
            {
                filename_byteCount = Encoding.UTF8.GetByteCount(filename);
                if (filename_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_filename = Util.Allocate(filename_byteCount + 1);
                }
                else
                {
                    byte* native_filename_stackBytes = stackalloc byte[filename_byteCount + 1];
                    native_filename = native_filename_stackBytes;
                }
                int native_filename_offset = Util.GetUtf8(filename, native_filename, filename_byteCount);
                native_filename[native_filename_offset] = 0;
            }
            else { native_filename = null; }
            byte* native_mode;
            int mode_byteCount = 0;
            if (mode != null)
            {
                mode_byteCount = Encoding.UTF8.GetByteCount(mode);
                if (mode_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_mode = Util.Allocate(mode_byteCount + 1);
                }
                else
                {
                    byte* native_mode_stackBytes = stackalloc byte[mode_byteCount + 1];
                    native_mode = native_mode_stackBytes;
                }
                int native_mode_offset = Util.GetUtf8(mode, native_mode, mode_byteCount);
                native_mode[native_mode_offset] = 0;
            }
            else { native_mode = null; }
            int padding_bytes = 0;
            fixed (uint* native_out_file_size = &out_file_size)
            {
                void* ret = ImGuiNativeInternal.igImFileLoadToMemory(native_filename, native_mode, native_out_file_size, padding_bytes);
                if (filename_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_filename);
                }
                if (mode_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_mode);
                }
                return (IntPtr)ret;
            }
        }
        public static IntPtr ImFileLoadToMemory(string filename, string mode, out uint out_file_size, int padding_bytes)
        {
            byte* native_filename;
            int filename_byteCount = 0;
            if (filename != null)
            {
                filename_byteCount = Encoding.UTF8.GetByteCount(filename);
                if (filename_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_filename = Util.Allocate(filename_byteCount + 1);
                }
                else
                {
                    byte* native_filename_stackBytes = stackalloc byte[filename_byteCount + 1];
                    native_filename = native_filename_stackBytes;
                }
                int native_filename_offset = Util.GetUtf8(filename, native_filename, filename_byteCount);
                native_filename[native_filename_offset] = 0;
            }
            else { native_filename = null; }
            byte* native_mode;
            int mode_byteCount = 0;
            if (mode != null)
            {
                mode_byteCount = Encoding.UTF8.GetByteCount(mode);
                if (mode_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_mode = Util.Allocate(mode_byteCount + 1);
                }
                else
                {
                    byte* native_mode_stackBytes = stackalloc byte[mode_byteCount + 1];
                    native_mode = native_mode_stackBytes;
                }
                int native_mode_offset = Util.GetUtf8(mode, native_mode, mode_byteCount);
                native_mode[native_mode_offset] = 0;
            }
            else { native_mode = null; }
            fixed (uint* native_out_file_size = &out_file_size)
            {
                void* ret = ImGuiNativeInternal.igImFileLoadToMemory(native_filename, native_mode, native_out_file_size, padding_bytes);
                if (filename_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_filename);
                }
                if (mode_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_mode);
                }
                return (IntPtr)ret;
            }
        }
        public static IntPtr ImFileOpen(string filename, string mode)
        {
            byte* native_filename;
            int filename_byteCount = 0;
            if (filename != null)
            {
                filename_byteCount = Encoding.UTF8.GetByteCount(filename);
                if (filename_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_filename = Util.Allocate(filename_byteCount + 1);
                }
                else
                {
                    byte* native_filename_stackBytes = stackalloc byte[filename_byteCount + 1];
                    native_filename = native_filename_stackBytes;
                }
                int native_filename_offset = Util.GetUtf8(filename, native_filename, filename_byteCount);
                native_filename[native_filename_offset] = 0;
            }
            else { native_filename = null; }
            byte* native_mode;
            int mode_byteCount = 0;
            if (mode != null)
            {
                mode_byteCount = Encoding.UTF8.GetByteCount(mode);
                if (mode_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_mode = Util.Allocate(mode_byteCount + 1);
                }
                else
                {
                    byte* native_mode_stackBytes = stackalloc byte[mode_byteCount + 1];
                    native_mode = native_mode_stackBytes;
                }
                int native_mode_offset = Util.GetUtf8(mode, native_mode, mode_byteCount);
                native_mode[native_mode_offset] = 0;
            }
            else { native_mode = null; }
            IntPtr ret = ImGuiNativeInternal.igImFileOpen(native_filename, native_mode);
            if (filename_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_filename);
            }
            if (mode_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_mode);
            }
            return ret;
        }
        public static ulong ImFileRead(IntPtr data, ulong size, ulong count, IntPtr file)
        {
            void* native_data = (void*)data.ToPointer();
            ulong ret = ImGuiNativeInternal.igImFileRead(native_data, size, count, file);
            return ret;
        }
        public static ulong ImFileWrite(IntPtr data, ulong size, ulong count, IntPtr file)
        {
            void* native_data = (void*)data.ToPointer();
            ulong ret = ImGuiNativeInternal.igImFileWrite(native_data, size, count, file);
            return ret;
        }
        public static float ImFloor(float f)
        {
            float ret = ImGuiNativeInternal.igImFloor_Float(f);
            return ret;
        }
        public static Vector2 ImFloor(Vector2 v)
        {
            Vector2 __retval;
            ImGuiNativeInternal.igImFloor_Vec2(&__retval, v);
            return __retval;
        }
        public static float ImFloorSigned(float f)
        {
            float ret = ImGuiNativeInternal.igImFloorSigned_Float(f);
            return ret;
        }
        public static Vector2 ImFloorSigned(Vector2 v)
        {
            Vector2 __retval;
            ImGuiNativeInternal.igImFloorSigned_Vec2(&__retval, v);
            return __retval;
        }
        public static void ImFontAtlasBuildFinish(ImFontAtlasPtr atlas)
        {
            ImFontAtlas* native_atlas = atlas.NativePtr;
            ImGuiNativeInternal.igImFontAtlasBuildFinish(native_atlas);
        }
        public static void ImFontAtlasBuildInit(ImFontAtlasPtr atlas)
        {
            ImFontAtlas* native_atlas = atlas.NativePtr;
            ImGuiNativeInternal.igImFontAtlasBuildInit(native_atlas);
        }
        public static void ImFontAtlasBuildMultiplyCalcLookupTable(out byte out_table, float in_multiply_factor)
        {
            fixed (byte* native_out_table = &out_table)
            {
                ImGuiNativeInternal.igImFontAtlasBuildMultiplyCalcLookupTable(native_out_table, in_multiply_factor);
            }
        }
        public static void ImFontAtlasBuildMultiplyRectAlpha8(ref byte table, ref byte pixels, int x, int y, int w, int h, int stride)
        {
            fixed (byte* native_table = &table)
            {
                fixed (byte* native_pixels = &pixels)
                {
                    ImGuiNativeInternal.igImFontAtlasBuildMultiplyRectAlpha8(native_table, native_pixels, x, y, w, h, stride);
                }
            }
        }
        public static void ImFontAtlasBuildPackCustomRects(ImFontAtlasPtr atlas, IntPtr stbrp_context_opaque)
        {
            ImFontAtlas* native_atlas = atlas.NativePtr;
            void* native_stbrp_context_opaque = (void*)stbrp_context_opaque.ToPointer();
            ImGuiNativeInternal.igImFontAtlasBuildPackCustomRects(native_atlas, native_stbrp_context_opaque);
        }
        public static void ImFontAtlasBuildRender32bppRectFromString(ImFontAtlasPtr atlas, int x, int y, int w, int h, string in_str, byte in_marker_char, uint in_marker_pixel_value)
        {
            ImFontAtlas* native_atlas = atlas.NativePtr;
            byte* native_in_str;
            int in_str_byteCount = 0;
            if (in_str != null)
            {
                in_str_byteCount = Encoding.UTF8.GetByteCount(in_str);
                if (in_str_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_in_str = Util.Allocate(in_str_byteCount + 1);
                }
                else
                {
                    byte* native_in_str_stackBytes = stackalloc byte[in_str_byteCount + 1];
                    native_in_str = native_in_str_stackBytes;
                }
                int native_in_str_offset = Util.GetUtf8(in_str, native_in_str, in_str_byteCount);
                native_in_str[native_in_str_offset] = 0;
            }
            else { native_in_str = null; }
            ImGuiNativeInternal.igImFontAtlasBuildRender32bppRectFromString(native_atlas, x, y, w, h, native_in_str, in_marker_char, in_marker_pixel_value);
            if (in_str_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_in_str);
            }
        }
        public static void ImFontAtlasBuildRender8bppRectFromString(ImFontAtlasPtr atlas, int x, int y, int w, int h, string in_str, byte in_marker_char, byte in_marker_pixel_value)
        {
            ImFontAtlas* native_atlas = atlas.NativePtr;
            byte* native_in_str;
            int in_str_byteCount = 0;
            if (in_str != null)
            {
                in_str_byteCount = Encoding.UTF8.GetByteCount(in_str);
                if (in_str_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_in_str = Util.Allocate(in_str_byteCount + 1);
                }
                else
                {
                    byte* native_in_str_stackBytes = stackalloc byte[in_str_byteCount + 1];
                    native_in_str = native_in_str_stackBytes;
                }
                int native_in_str_offset = Util.GetUtf8(in_str, native_in_str, in_str_byteCount);
                native_in_str[native_in_str_offset] = 0;
            }
            else { native_in_str = null; }
            ImGuiNativeInternal.igImFontAtlasBuildRender8bppRectFromString(native_atlas, x, y, w, h, native_in_str, in_marker_char, in_marker_pixel_value);
            if (in_str_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_in_str);
            }
        }
        public static void ImFontAtlasBuildSetupFont(ImFontAtlasPtr atlas, ImFontPtr font, ImFontConfigPtr font_config, float ascent, float descent)
        {
            ImFontAtlas* native_atlas = atlas.NativePtr;
            ImFont* native_font = font.NativePtr;
            ImFontConfig* native_font_config = font_config.NativePtr;
            ImGuiNativeInternal.igImFontAtlasBuildSetupFont(native_atlas, native_font, native_font_config, ascent, descent);
        }
        public static IntPtr* ImFontAtlasGetBuilderForStbTruetype()
        {
            IntPtr* ret = ImGuiNativeInternal.igImFontAtlasGetBuilderForStbTruetype();
            return ret;
        }
        public static int ImFormatString(string buf, uint buf_size, string fmt)
        {
            byte* native_buf;
            int buf_byteCount = 0;
            if (buf != null)
            {
                buf_byteCount = Encoding.UTF8.GetByteCount(buf);
                if (buf_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_buf = Util.Allocate(buf_byteCount + 1);
                }
                else
                {
                    byte* native_buf_stackBytes = stackalloc byte[buf_byteCount + 1];
                    native_buf = native_buf_stackBytes;
                }
                int native_buf_offset = Util.GetUtf8(buf, native_buf, buf_byteCount);
                native_buf[native_buf_offset] = 0;
            }
            else { native_buf = null; }
            byte* native_fmt;
            int fmt_byteCount = 0;
            if (fmt != null)
            {
                fmt_byteCount = Encoding.UTF8.GetByteCount(fmt);
                if (fmt_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_fmt = Util.Allocate(fmt_byteCount + 1);
                }
                else
                {
                    byte* native_fmt_stackBytes = stackalloc byte[fmt_byteCount + 1];
                    native_fmt = native_fmt_stackBytes;
                }
                int native_fmt_offset = Util.GetUtf8(fmt, native_fmt, fmt_byteCount);
                native_fmt[native_fmt_offset] = 0;
            }
            else { native_fmt = null; }
            int ret = ImGuiNativeInternal.igImFormatString(native_buf, buf_size, native_fmt);
            if (buf_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_buf);
            }
            if (fmt_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_fmt);
            }
            return ret;
        }
        public static ImGuiDir ImGetDirQuadrantFromDelta(float dx, float dy)
        {
            ImGuiDir ret = ImGuiNativeInternal.igImGetDirQuadrantFromDelta(dx, dy);
            return ret;
        }
        public static uint ImHashData(IntPtr data, uint data_size)
        {
            void* native_data = (void*)data.ToPointer();
            uint seed = 0;
            uint ret = ImGuiNativeInternal.igImHashData(native_data, data_size, seed);
            return ret;
        }
        public static uint ImHashData(IntPtr data, uint data_size, uint seed)
        {
            void* native_data = (void*)data.ToPointer();
            uint ret = ImGuiNativeInternal.igImHashData(native_data, data_size, seed);
            return ret;
        }
        public static uint ImHashStr(string data)
        {
            byte* native_data;
            int data_byteCount = 0;
            if (data != null)
            {
                data_byteCount = Encoding.UTF8.GetByteCount(data);
                if (data_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_data = Util.Allocate(data_byteCount + 1);
                }
                else
                {
                    byte* native_data_stackBytes = stackalloc byte[data_byteCount + 1];
                    native_data = native_data_stackBytes;
                }
                int native_data_offset = Util.GetUtf8(data, native_data, data_byteCount);
                native_data[native_data_offset] = 0;
            }
            else { native_data = null; }
            uint data_size = 0;
            uint seed = 0;
            uint ret = ImGuiNativeInternal.igImHashStr(native_data, data_size, seed);
            if (data_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_data);
            }
            return ret;
        }
        public static uint ImHashStr(string data, uint data_size)
        {
            byte* native_data;
            int data_byteCount = 0;
            if (data != null)
            {
                data_byteCount = Encoding.UTF8.GetByteCount(data);
                if (data_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_data = Util.Allocate(data_byteCount + 1);
                }
                else
                {
                    byte* native_data_stackBytes = stackalloc byte[data_byteCount + 1];
                    native_data = native_data_stackBytes;
                }
                int native_data_offset = Util.GetUtf8(data, native_data, data_byteCount);
                native_data[native_data_offset] = 0;
            }
            else { native_data = null; }
            uint seed = 0;
            uint ret = ImGuiNativeInternal.igImHashStr(native_data, data_size, seed);
            if (data_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_data);
            }
            return ret;
        }
        public static uint ImHashStr(string data, uint data_size, uint seed)
        {
            byte* native_data;
            int data_byteCount = 0;
            if (data != null)
            {
                data_byteCount = Encoding.UTF8.GetByteCount(data);
                if (data_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_data = Util.Allocate(data_byteCount + 1);
                }
                else
                {
                    byte* native_data_stackBytes = stackalloc byte[data_byteCount + 1];
                    native_data = native_data_stackBytes;
                }
                int native_data_offset = Util.GetUtf8(data, native_data, data_byteCount);
                native_data[native_data_offset] = 0;
            }
            else { native_data = null; }
            uint ret = ImGuiNativeInternal.igImHashStr(native_data, data_size, seed);
            if (data_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_data);
            }
            return ret;
        }
        public static float ImInvLength(Vector2 lhs, float fail_value)
        {
            float ret = ImGuiNativeInternal.igImInvLength(lhs, fail_value);
            return ret;
        }
        public static bool ImIsFloatAboveGuaranteedIntegerPrecision(float f)
        {
            byte ret = ImGuiNativeInternal.igImIsFloatAboveGuaranteedIntegerPrecision(f);
            return ret != 0;
        }
        public static bool ImIsPowerOfTwo(int v)
        {
            byte ret = ImGuiNativeInternal.igImIsPowerOfTwo_Int(v);
            return ret != 0;
        }
        public static bool ImIsPowerOfTwo(ulong v)
        {
            byte ret = ImGuiNativeInternal.igImIsPowerOfTwo_U64(v);
            return ret != 0;
        }
        public static float ImLengthSqr(Vector2 lhs)
        {
            float ret = ImGuiNativeInternal.igImLengthSqr_Vec2(lhs);
            return ret;
        }
        public static float ImLengthSqr(Vector4 lhs)
        {
            float ret = ImGuiNativeInternal.igImLengthSqr_Vec4(lhs);
            return ret;
        }
        public static Vector2 ImLerp(Vector2 a, Vector2 b, float t)
        {
            Vector2 __retval;
            ImGuiNativeInternal.igImLerp_Vec2Float(&__retval, a, b, t);
            return __retval;
        }
        public static Vector2 ImLerp(Vector2 a, Vector2 b, Vector2 t)
        {
            Vector2 __retval;
            ImGuiNativeInternal.igImLerp_Vec2Vec2(&__retval, a, b, t);
            return __retval;
        }
        public static Vector4 ImLerp(Vector4 a, Vector4 b, float t)
        {
            Vector4 __retval;
            ImGuiNativeInternal.igImLerp_Vec4(&__retval, a, b, t);
            return __retval;
        }
        public static float ImLinearSweep(float current, float target, float speed)
        {
            float ret = ImGuiNativeInternal.igImLinearSweep(current, target, speed);
            return ret;
        }
        public static Vector2 ImLineClosestPoint(Vector2 a, Vector2 b, Vector2 p)
        {
            Vector2 __retval;
            ImGuiNativeInternal.igImLineClosestPoint(&__retval, a, b, p);
            return __retval;
        }
        public static float ImLog(float x)
        {
            float ret = ImGuiNativeInternal.igImLog_Float(x);
            return ret;
        }
        public static double ImLog(double x)
        {
            double ret = ImGuiNativeInternal.igImLog_double(x);
            return ret;
        }
        public static Vector2 ImMax(Vector2 lhs, Vector2 rhs)
        {
            Vector2 __retval;
            ImGuiNativeInternal.igImMax(&__retval, lhs, rhs);
            return __retval;
        }
        public static Vector2 ImMin(Vector2 lhs, Vector2 rhs)
        {
            Vector2 __retval;
            ImGuiNativeInternal.igImMin(&__retval, lhs, rhs);
            return __retval;
        }
        public static int ImModPositive(int a, int b)
        {
            int ret = ImGuiNativeInternal.igImModPositive(a, b);
            return ret;
        }
        public static Vector2 ImMul(Vector2 lhs, Vector2 rhs)
        {
            Vector2 __retval;
            ImGuiNativeInternal.igImMul(&__retval, lhs, rhs);
            return __retval;
        }
        public static string ImParseFormatFindEnd(string format)
        {
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            byte* ret = ImGuiNativeInternal.igImParseFormatFindEnd(native_format);
            if (format_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_format);
            }
            return Util.StringFromPtr(ret);
        }
        public static string ImParseFormatFindStart(string format)
        {
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            byte* ret = ImGuiNativeInternal.igImParseFormatFindStart(native_format);
            if (format_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_format);
            }
            return Util.StringFromPtr(ret);
        }
        public static int ImParseFormatPrecision(string format, int default_value)
        {
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            int ret = ImGuiNativeInternal.igImParseFormatPrecision(native_format, default_value);
            if (format_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_format);
            }
            return ret;
        }
        public static string ImParseFormatTrimDecorations(string format, string buf, uint buf_size)
        {
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            byte* native_buf;
            int buf_byteCount = 0;
            if (buf != null)
            {
                buf_byteCount = Encoding.UTF8.GetByteCount(buf);
                if (buf_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_buf = Util.Allocate(buf_byteCount + 1);
                }
                else
                {
                    byte* native_buf_stackBytes = stackalloc byte[buf_byteCount + 1];
                    native_buf = native_buf_stackBytes;
                }
                int native_buf_offset = Util.GetUtf8(buf, native_buf, buf_byteCount);
                native_buf[native_buf_offset] = 0;
            }
            else { native_buf = null; }
            byte* ret = ImGuiNativeInternal.igImParseFormatTrimDecorations(native_format, native_buf, buf_size);
            if (format_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_format);
            }
            if (buf_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_buf);
            }
            return Util.StringFromPtr(ret);
        }
        public static float ImPow(float x, float y)
        {
            float ret = ImGuiNativeInternal.igImPow_Float(x, y);
            return ret;
        }
        public static double ImPow(double x, double y)
        {
            double ret = ImGuiNativeInternal.igImPow_double(x, y);
            return ret;
        }
        public static Vector2 ImRotate(Vector2 v, float cos_a, float sin_a)
        {
            Vector2 __retval;
            ImGuiNativeInternal.igImRotate(&__retval, v, cos_a, sin_a);
            return __retval;
        }
        public static float ImRsqrt(float x)
        {
            float ret = ImGuiNativeInternal.igImRsqrt_Float(x);
            return ret;
        }
        public static double ImRsqrt(double x)
        {
            double ret = ImGuiNativeInternal.igImRsqrt_double(x);
            return ret;
        }
        public static float ImSaturate(float f)
        {
            float ret = ImGuiNativeInternal.igImSaturate(f);
            return ret;
        }
        public static float ImSign(float x)
        {
            float ret = ImGuiNativeInternal.igImSign_Float(x);
            return ret;
        }
        public static double ImSign(double x)
        {
            double ret = ImGuiNativeInternal.igImSign_double(x);
            return ret;
        }
        public static string ImStrdup(string str)
        {
            byte* native_str;
            int str_byteCount = 0;
            if (str != null)
            {
                str_byteCount = Encoding.UTF8.GetByteCount(str);
                if (str_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_str = Util.Allocate(str_byteCount + 1);
                }
                else
                {
                    byte* native_str_stackBytes = stackalloc byte[str_byteCount + 1];
                    native_str = native_str_stackBytes;
                }
                int native_str_offset = Util.GetUtf8(str, native_str, str_byteCount);
                native_str[native_str_offset] = 0;
            }
            else { native_str = null; }
            byte* ret = ImGuiNativeInternal.igImStrdup(native_str);
            if (str_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_str);
            }
            return Util.StringFromPtr(ret);
        }
        public static string ImStrdupcpy(string dst, ref uint p_dst_size, string str)
        {
            byte* native_dst;
            int dst_byteCount = 0;
            if (dst != null)
            {
                dst_byteCount = Encoding.UTF8.GetByteCount(dst);
                if (dst_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_dst = Util.Allocate(dst_byteCount + 1);
                }
                else
                {
                    byte* native_dst_stackBytes = stackalloc byte[dst_byteCount + 1];
                    native_dst = native_dst_stackBytes;
                }
                int native_dst_offset = Util.GetUtf8(dst, native_dst, dst_byteCount);
                native_dst[native_dst_offset] = 0;
            }
            else { native_dst = null; }
            byte* native_str;
            int str_byteCount = 0;
            if (str != null)
            {
                str_byteCount = Encoding.UTF8.GetByteCount(str);
                if (str_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_str = Util.Allocate(str_byteCount + 1);
                }
                else
                {
                    byte* native_str_stackBytes = stackalloc byte[str_byteCount + 1];
                    native_str = native_str_stackBytes;
                }
                int native_str_offset = Util.GetUtf8(str, native_str, str_byteCount);
                native_str[native_str_offset] = 0;
            }
            else { native_str = null; }
            fixed (uint* native_p_dst_size = &p_dst_size)
            {
                byte* ret = ImGuiNativeInternal.igImStrdupcpy(native_dst, native_p_dst_size, native_str);
                if (dst_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_dst);
                }
                if (str_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_str);
                }
                return Util.StringFromPtr(ret);
            }
        }
        public static int ImStricmp(string str1, string str2)
        {
            byte* native_str1;
            int str1_byteCount = 0;
            if (str1 != null)
            {
                str1_byteCount = Encoding.UTF8.GetByteCount(str1);
                if (str1_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_str1 = Util.Allocate(str1_byteCount + 1);
                }
                else
                {
                    byte* native_str1_stackBytes = stackalloc byte[str1_byteCount + 1];
                    native_str1 = native_str1_stackBytes;
                }
                int native_str1_offset = Util.GetUtf8(str1, native_str1, str1_byteCount);
                native_str1[native_str1_offset] = 0;
            }
            else { native_str1 = null; }
            byte* native_str2;
            int str2_byteCount = 0;
            if (str2 != null)
            {
                str2_byteCount = Encoding.UTF8.GetByteCount(str2);
                if (str2_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_str2 = Util.Allocate(str2_byteCount + 1);
                }
                else
                {
                    byte* native_str2_stackBytes = stackalloc byte[str2_byteCount + 1];
                    native_str2 = native_str2_stackBytes;
                }
                int native_str2_offset = Util.GetUtf8(str2, native_str2, str2_byteCount);
                native_str2[native_str2_offset] = 0;
            }
            else { native_str2 = null; }
            int ret = ImGuiNativeInternal.igImStricmp(native_str1, native_str2);
            if (str1_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_str1);
            }
            if (str2_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_str2);
            }
            return ret;
        }
        public static int ImStrlenW(IntPtr str)
        {
            ushort* native_str = (ushort*)str.ToPointer();
            int ret = ImGuiNativeInternal.igImStrlenW(native_str);
            return ret;
        }
        public static void ImStrncpy(string dst, string src, uint count)
        {
            byte* native_dst;
            int dst_byteCount = 0;
            if (dst != null)
            {
                dst_byteCount = Encoding.UTF8.GetByteCount(dst);
                if (dst_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_dst = Util.Allocate(dst_byteCount + 1);
                }
                else
                {
                    byte* native_dst_stackBytes = stackalloc byte[dst_byteCount + 1];
                    native_dst = native_dst_stackBytes;
                }
                int native_dst_offset = Util.GetUtf8(dst, native_dst, dst_byteCount);
                native_dst[native_dst_offset] = 0;
            }
            else { native_dst = null; }
            byte* native_src;
            int src_byteCount = 0;
            if (src != null)
            {
                src_byteCount = Encoding.UTF8.GetByteCount(src);
                if (src_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_src = Util.Allocate(src_byteCount + 1);
                }
                else
                {
                    byte* native_src_stackBytes = stackalloc byte[src_byteCount + 1];
                    native_src = native_src_stackBytes;
                }
                int native_src_offset = Util.GetUtf8(src, native_src, src_byteCount);
                native_src[native_src_offset] = 0;
            }
            else { native_src = null; }
            ImGuiNativeInternal.igImStrncpy(native_dst, native_src, count);
            if (dst_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_dst);
            }
            if (src_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_src);
            }
        }
        public static int ImStrnicmp(string str1, string str2, uint count)
        {
            byte* native_str1;
            int str1_byteCount = 0;
            if (str1 != null)
            {
                str1_byteCount = Encoding.UTF8.GetByteCount(str1);
                if (str1_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_str1 = Util.Allocate(str1_byteCount + 1);
                }
                else
                {
                    byte* native_str1_stackBytes = stackalloc byte[str1_byteCount + 1];
                    native_str1 = native_str1_stackBytes;
                }
                int native_str1_offset = Util.GetUtf8(str1, native_str1, str1_byteCount);
                native_str1[native_str1_offset] = 0;
            }
            else { native_str1 = null; }
            byte* native_str2;
            int str2_byteCount = 0;
            if (str2 != null)
            {
                str2_byteCount = Encoding.UTF8.GetByteCount(str2);
                if (str2_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_str2 = Util.Allocate(str2_byteCount + 1);
                }
                else
                {
                    byte* native_str2_stackBytes = stackalloc byte[str2_byteCount + 1];
                    native_str2 = native_str2_stackBytes;
                }
                int native_str2_offset = Util.GetUtf8(str2, native_str2, str2_byteCount);
                native_str2[native_str2_offset] = 0;
            }
            else { native_str2 = null; }
            int ret = ImGuiNativeInternal.igImStrnicmp(native_str1, native_str2, count);
            if (str1_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_str1);
            }
            if (str2_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_str2);
            }
            return ret;
        }
        public static string ImStrSkipBlank(string str)
        {
            byte* native_str;
            int str_byteCount = 0;
            if (str != null)
            {
                str_byteCount = Encoding.UTF8.GetByteCount(str);
                if (str_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_str = Util.Allocate(str_byteCount + 1);
                }
                else
                {
                    byte* native_str_stackBytes = stackalloc byte[str_byteCount + 1];
                    native_str = native_str_stackBytes;
                }
                int native_str_offset = Util.GetUtf8(str, native_str, str_byteCount);
                native_str[native_str_offset] = 0;
            }
            else { native_str = null; }
            byte* ret = ImGuiNativeInternal.igImStrSkipBlank(native_str);
            if (str_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_str);
            }
            return Util.StringFromPtr(ret);
        }
        public static void ImStrTrimBlanks(string str)
        {
            byte* native_str;
            int str_byteCount = 0;
            if (str != null)
            {
                str_byteCount = Encoding.UTF8.GetByteCount(str);
                if (str_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_str = Util.Allocate(str_byteCount + 1);
                }
                else
                {
                    byte* native_str_stackBytes = stackalloc byte[str_byteCount + 1];
                    native_str = native_str_stackBytes;
                }
                int native_str_offset = Util.GetUtf8(str, native_str, str_byteCount);
                native_str[native_str_offset] = 0;
            }
            else { native_str = null; }
            ImGuiNativeInternal.igImStrTrimBlanks(native_str);
            if (str_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_str);
            }
        }
        public static string ImTextCharToUtf8(out byte out_buf, uint c)
        {
            fixed (byte* native_out_buf = &out_buf)
            {
                byte* ret = ImGuiNativeInternal.igImTextCharToUtf8(native_out_buf, c);
                return Util.StringFromPtr(ret);
            }
        }
        public static float ImTriangleArea(Vector2 a, Vector2 b, Vector2 c)
        {
            float ret = ImGuiNativeInternal.igImTriangleArea(a, b, c);
            return ret;
        }
        public static void ImTriangleBarycentricCoords(Vector2 a, Vector2 b, Vector2 c, Vector2 p, out float out_u, out float out_v, out float out_w)
        {
            fixed (float* native_out_u = &out_u)
            {
                fixed (float* native_out_v = &out_v)
                {
                    fixed (float* native_out_w = &out_w)
                    {
                        ImGuiNativeInternal.igImTriangleBarycentricCoords(a, b, c, p, native_out_u, native_out_v, native_out_w);
                    }
                }
            }
        }
        public static Vector2 ImTriangleClosestPoint(Vector2 a, Vector2 b, Vector2 c, Vector2 p)
        {
            Vector2 __retval;
            ImGuiNativeInternal.igImTriangleClosestPoint(&__retval, a, b, c, p);
            return __retval;
        }
        public static bool ImTriangleContainsPoint(Vector2 a, Vector2 b, Vector2 c, Vector2 p)
        {
            byte ret = ImGuiNativeInternal.igImTriangleContainsPoint(a, b, c, p);
            return ret != 0;
        }
        public static int ImUpperPowerOfTwo(int v)
        {
            int ret = ImGuiNativeInternal.igImUpperPowerOfTwo(v);
            return ret;
        }
        public static void Initialize(IntPtr context)
        {
            ImGuiNativeInternal.igInitialize(context);
        }
        public static bool IsActiveIdUsingKey(ImGuiKey key)
        {
            byte ret = ImGuiNativeInternal.igIsActiveIdUsingKey(key);
            return ret != 0;
        }
        public static bool IsActiveIdUsingNavDir(ImGuiDir dir)
        {
            byte ret = ImGuiNativeInternal.igIsActiveIdUsingNavDir(dir);
            return ret != 0;
        }
        public static bool IsActiveIdUsingNavInput(ImGuiNavInput input)
        {
            byte ret = ImGuiNativeInternal.igIsActiveIdUsingNavInput(input);
            return ret != 0;
        }
        public static bool IsClippedEx(ImRect bb, uint id)
        {
            byte ret = ImGuiNativeInternal.igIsClippedEx(bb, id);
            return ret != 0;
        }
        public static bool IsDragDropPayloadBeingAccepted()
        {
            byte ret = ImGuiNativeInternal.igIsDragDropPayloadBeingAccepted();
            return ret != 0;
        }
        public static bool IsGamepadKey(ImGuiKey key)
        {
            byte ret = ImGuiNativeInternal.igIsGamepadKey(key);
            return ret != 0;
        }
        public static bool IsItemToggledSelection()
        {
            byte ret = ImGuiNativeInternal.igIsItemToggledSelection();
            return ret != 0;
        }
        public static bool IsKeyPressedMap(ImGuiKey key)
        {
            byte repeat = 1;
            byte ret = ImGuiNativeInternal.igIsKeyPressedMap(key, repeat);
            return ret != 0;
        }
        public static bool IsKeyPressedMap(ImGuiKey key, bool repeat)
        {
            byte native_repeat = repeat ? (byte)1 : (byte)0;
            byte ret = ImGuiNativeInternal.igIsKeyPressedMap(key, native_repeat);
            return ret != 0;
        }
        public static bool IsLegacyKey(ImGuiKey key)
        {
            byte ret = ImGuiNativeInternal.igIsLegacyKey(key);
            return ret != 0;
        }
        public static bool IsMouseDragPastThreshold(ImGuiMouseButton button)
        {
            float lock_threshold = -1.0f;
            byte ret = ImGuiNativeInternal.igIsMouseDragPastThreshold(button, lock_threshold);
            return ret != 0;
        }
        public static bool IsMouseDragPastThreshold(ImGuiMouseButton button, float lock_threshold)
        {
            byte ret = ImGuiNativeInternal.igIsMouseDragPastThreshold(button, lock_threshold);
            return ret != 0;
        }
        public static bool IsNamedKey(ImGuiKey key)
        {
            byte ret = ImGuiNativeInternal.igIsNamedKey(key);
            return ret != 0;
        }
        public static bool IsNavInputDown(ImGuiNavInput n)
        {
            byte ret = ImGuiNativeInternal.igIsNavInputDown(n);
            return ret != 0;
        }
        public static bool IsNavInputTest(ImGuiNavInput n, ImGuiInputReadMode rm)
        {
            byte ret = ImGuiNativeInternal.igIsNavInputTest(n, rm);
            return ret != 0;
        }
        public static bool IsPopupOpen(uint id, ImGuiPopupFlags popup_flags)
        {
            byte ret = ImGuiNativeInternal.igIsPopupOpen_ID(id, popup_flags);
            return ret != 0;
        }
        public static bool IsWindowAbove(ImGuiWindowPtr potential_above, ImGuiWindowPtr potential_below)
        {
            ImGuiWindow* native_potential_above = potential_above.NativePtr;
            ImGuiWindow* native_potential_below = potential_below.NativePtr;
            byte ret = ImGuiNativeInternal.igIsWindowAbove(native_potential_above, native_potential_below);
            return ret != 0;
        }
        public static bool IsWindowChildOf(ImGuiWindowPtr window, ImGuiWindowPtr potential_parent, bool popup_hierarchy, bool dock_hierarchy)
        {
            ImGuiWindow* native_window = window.NativePtr;
            ImGuiWindow* native_potential_parent = potential_parent.NativePtr;
            byte native_popup_hierarchy = popup_hierarchy ? (byte)1 : (byte)0;
            byte native_dock_hierarchy = dock_hierarchy ? (byte)1 : (byte)0;
            byte ret = ImGuiNativeInternal.igIsWindowChildOf(native_window, native_potential_parent, native_popup_hierarchy, native_dock_hierarchy);
            return ret != 0;
        }
        public static bool IsWindowNavFocusable(ImGuiWindowPtr window)
        {
            ImGuiWindow* native_window = window.NativePtr;
            byte ret = ImGuiNativeInternal.igIsWindowNavFocusable(native_window);
            return ret != 0;
        }
        public static bool IsWindowWithinBeginStackOf(ImGuiWindowPtr window, ImGuiWindowPtr potential_parent)
        {
            ImGuiWindow* native_window = window.NativePtr;
            ImGuiWindow* native_potential_parent = potential_parent.NativePtr;
            byte ret = ImGuiNativeInternal.igIsWindowWithinBeginStackOf(native_window, native_potential_parent);
            return ret != 0;
        }
        public static bool ItemAdd(ImRect bb, uint id)
        {
            ImRect* nav_bb = null;
            ImGuiItemFlags extra_flags = (ImGuiItemFlags)0;
            byte ret = ImGuiNativeInternal.igItemAdd(bb, id, nav_bb, extra_flags);
            return ret != 0;
        }
        public static bool ItemAdd(ImRect bb, uint id, ImRectPtr nav_bb)
        {
            ImRect* native_nav_bb = nav_bb.NativePtr;
            ImGuiItemFlags extra_flags = (ImGuiItemFlags)0;
            byte ret = ImGuiNativeInternal.igItemAdd(bb, id, native_nav_bb, extra_flags);
            return ret != 0;
        }
        public static bool ItemAdd(ImRect bb, uint id, ImRectPtr nav_bb, ImGuiItemFlags extra_flags)
        {
            ImRect* native_nav_bb = nav_bb.NativePtr;
            byte ret = ImGuiNativeInternal.igItemAdd(bb, id, native_nav_bb, extra_flags);
            return ret != 0;
        }
        public static bool ItemHoverable(ImRect bb, uint id)
        {
            byte ret = ImGuiNativeInternal.igItemHoverable(bb, id);
            return ret != 0;
        }
        public static void ItemSize(Vector2 size)
        {
            float text_baseline_y = -1.0f;
            ImGuiNativeInternal.igItemSize_Vec2(size, text_baseline_y);
        }
        public static void ItemSize(Vector2 size, float text_baseline_y)
        {
            ImGuiNativeInternal.igItemSize_Vec2(size, text_baseline_y);
        }
        public static void ItemSize(ImRect bb)
        {
            float text_baseline_y = -1.0f;
            ImGuiNativeInternal.igItemSize_Rect(bb, text_baseline_y);
        }
        public static void ItemSize(ImRect bb, float text_baseline_y)
        {
            ImGuiNativeInternal.igItemSize_Rect(bb, text_baseline_y);
        }
        public static void KeepAliveID(uint id)
        {
            ImGuiNativeInternal.igKeepAliveID(id);
        }
        public static void LogBegin(ImGuiLogType type, int auto_open_depth)
        {
            ImGuiNativeInternal.igLogBegin(type, auto_open_depth);
        }
        public static void LogRenderedText(ref Vector2 ref_pos, string text)
        {
            byte* native_text;
            int text_byteCount = 0;
            if (text != null)
            {
                text_byteCount = Encoding.UTF8.GetByteCount(text);
                if (text_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_text = Util.Allocate(text_byteCount + 1);
                }
                else
                {
                    byte* native_text_stackBytes = stackalloc byte[text_byteCount + 1];
                    native_text = native_text_stackBytes;
                }
                int native_text_offset = Util.GetUtf8(text, native_text, text_byteCount);
                native_text[native_text_offset] = 0;
            }
            else { native_text = null; }
            byte* native_text_end = null;
            fixed (Vector2* native_ref_pos = &ref_pos)
            {
                ImGuiNativeInternal.igLogRenderedText(native_ref_pos, native_text, native_text_end);
                if (text_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_text);
                }
            }
        }
        public static void LogSetNextTextDecoration(string prefix, string suffix)
        {
            byte* native_prefix;
            int prefix_byteCount = 0;
            if (prefix != null)
            {
                prefix_byteCount = Encoding.UTF8.GetByteCount(prefix);
                if (prefix_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_prefix = Util.Allocate(prefix_byteCount + 1);
                }
                else
                {
                    byte* native_prefix_stackBytes = stackalloc byte[prefix_byteCount + 1];
                    native_prefix = native_prefix_stackBytes;
                }
                int native_prefix_offset = Util.GetUtf8(prefix, native_prefix, prefix_byteCount);
                native_prefix[native_prefix_offset] = 0;
            }
            else { native_prefix = null; }
            byte* native_suffix;
            int suffix_byteCount = 0;
            if (suffix != null)
            {
                suffix_byteCount = Encoding.UTF8.GetByteCount(suffix);
                if (suffix_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_suffix = Util.Allocate(suffix_byteCount + 1);
                }
                else
                {
                    byte* native_suffix_stackBytes = stackalloc byte[suffix_byteCount + 1];
                    native_suffix = native_suffix_stackBytes;
                }
                int native_suffix_offset = Util.GetUtf8(suffix, native_suffix, suffix_byteCount);
                native_suffix[native_suffix_offset] = 0;
            }
            else { native_suffix = null; }
            ImGuiNativeInternal.igLogSetNextTextDecoration(native_prefix, native_suffix);
            if (prefix_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_prefix);
            }
            if (suffix_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_suffix);
            }
        }
        public static void LogToBuffer()
        {
            int auto_open_depth = -1;
            ImGuiNativeInternal.igLogToBuffer(auto_open_depth);
        }
        public static void LogToBuffer(int auto_open_depth)
        {
            ImGuiNativeInternal.igLogToBuffer(auto_open_depth);
        }
        public static void MarkIniSettingsDirty()
        {
            ImGuiNativeInternal.igMarkIniSettingsDirty_Nil();
        }
        public static void MarkIniSettingsDirty(ImGuiWindowPtr window)
        {
            ImGuiWindow* native_window = window.NativePtr;
            ImGuiNativeInternal.igMarkIniSettingsDirty_WindowPtr(native_window);
        }
        public static void MarkItemEdited(uint id)
        {
            ImGuiNativeInternal.igMarkItemEdited(id);
        }
        public static bool MenuItemEx(string label, string icon)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_icon;
            int icon_byteCount = 0;
            if (icon != null)
            {
                icon_byteCount = Encoding.UTF8.GetByteCount(icon);
                if (icon_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_icon = Util.Allocate(icon_byteCount + 1);
                }
                else
                {
                    byte* native_icon_stackBytes = stackalloc byte[icon_byteCount + 1];
                    native_icon = native_icon_stackBytes;
                }
                int native_icon_offset = Util.GetUtf8(icon, native_icon, icon_byteCount);
                native_icon[native_icon_offset] = 0;
            }
            else { native_icon = null; }
            byte* native_shortcut = null;
            byte selected = 0;
            byte enabled = 1;
            byte ret = ImGuiNativeInternal.igMenuItemEx(native_label, native_icon, native_shortcut, selected, enabled);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            if (icon_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_icon);
            }
            return ret != 0;
        }
        public static bool MenuItemEx(string label, string icon, string shortcut)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_icon;
            int icon_byteCount = 0;
            if (icon != null)
            {
                icon_byteCount = Encoding.UTF8.GetByteCount(icon);
                if (icon_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_icon = Util.Allocate(icon_byteCount + 1);
                }
                else
                {
                    byte* native_icon_stackBytes = stackalloc byte[icon_byteCount + 1];
                    native_icon = native_icon_stackBytes;
                }
                int native_icon_offset = Util.GetUtf8(icon, native_icon, icon_byteCount);
                native_icon[native_icon_offset] = 0;
            }
            else { native_icon = null; }
            byte* native_shortcut;
            int shortcut_byteCount = 0;
            if (shortcut != null)
            {
                shortcut_byteCount = Encoding.UTF8.GetByteCount(shortcut);
                if (shortcut_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_shortcut = Util.Allocate(shortcut_byteCount + 1);
                }
                else
                {
                    byte* native_shortcut_stackBytes = stackalloc byte[shortcut_byteCount + 1];
                    native_shortcut = native_shortcut_stackBytes;
                }
                int native_shortcut_offset = Util.GetUtf8(shortcut, native_shortcut, shortcut_byteCount);
                native_shortcut[native_shortcut_offset] = 0;
            }
            else { native_shortcut = null; }
            byte selected = 0;
            byte enabled = 1;
            byte ret = ImGuiNativeInternal.igMenuItemEx(native_label, native_icon, native_shortcut, selected, enabled);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            if (icon_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_icon);
            }
            if (shortcut_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_shortcut);
            }
            return ret != 0;
        }
        public static bool MenuItemEx(string label, string icon, string shortcut, bool selected)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_icon;
            int icon_byteCount = 0;
            if (icon != null)
            {
                icon_byteCount = Encoding.UTF8.GetByteCount(icon);
                if (icon_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_icon = Util.Allocate(icon_byteCount + 1);
                }
                else
                {
                    byte* native_icon_stackBytes = stackalloc byte[icon_byteCount + 1];
                    native_icon = native_icon_stackBytes;
                }
                int native_icon_offset = Util.GetUtf8(icon, native_icon, icon_byteCount);
                native_icon[native_icon_offset] = 0;
            }
            else { native_icon = null; }
            byte* native_shortcut;
            int shortcut_byteCount = 0;
            if (shortcut != null)
            {
                shortcut_byteCount = Encoding.UTF8.GetByteCount(shortcut);
                if (shortcut_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_shortcut = Util.Allocate(shortcut_byteCount + 1);
                }
                else
                {
                    byte* native_shortcut_stackBytes = stackalloc byte[shortcut_byteCount + 1];
                    native_shortcut = native_shortcut_stackBytes;
                }
                int native_shortcut_offset = Util.GetUtf8(shortcut, native_shortcut, shortcut_byteCount);
                native_shortcut[native_shortcut_offset] = 0;
            }
            else { native_shortcut = null; }
            byte native_selected = selected ? (byte)1 : (byte)0;
            byte enabled = 1;
            byte ret = ImGuiNativeInternal.igMenuItemEx(native_label, native_icon, native_shortcut, native_selected, enabled);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            if (icon_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_icon);
            }
            if (shortcut_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_shortcut);
            }
            return ret != 0;
        }
        public static bool MenuItemEx(string label, string icon, string shortcut, bool selected, bool enabled)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_icon;
            int icon_byteCount = 0;
            if (icon != null)
            {
                icon_byteCount = Encoding.UTF8.GetByteCount(icon);
                if (icon_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_icon = Util.Allocate(icon_byteCount + 1);
                }
                else
                {
                    byte* native_icon_stackBytes = stackalloc byte[icon_byteCount + 1];
                    native_icon = native_icon_stackBytes;
                }
                int native_icon_offset = Util.GetUtf8(icon, native_icon, icon_byteCount);
                native_icon[native_icon_offset] = 0;
            }
            else { native_icon = null; }
            byte* native_shortcut;
            int shortcut_byteCount = 0;
            if (shortcut != null)
            {
                shortcut_byteCount = Encoding.UTF8.GetByteCount(shortcut);
                if (shortcut_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_shortcut = Util.Allocate(shortcut_byteCount + 1);
                }
                else
                {
                    byte* native_shortcut_stackBytes = stackalloc byte[shortcut_byteCount + 1];
                    native_shortcut = native_shortcut_stackBytes;
                }
                int native_shortcut_offset = Util.GetUtf8(shortcut, native_shortcut, shortcut_byteCount);
                native_shortcut[native_shortcut_offset] = 0;
            }
            else { native_shortcut = null; }
            byte native_selected = selected ? (byte)1 : (byte)0;
            byte native_enabled = enabled ? (byte)1 : (byte)0;
            byte ret = ImGuiNativeInternal.igMenuItemEx(native_label, native_icon, native_shortcut, native_selected, native_enabled);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            if (icon_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_icon);
            }
            if (shortcut_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_shortcut);
            }
            return ret != 0;
        }
        public static void NavInitRequestApplyResult()
        {
            ImGuiNativeInternal.igNavInitRequestApplyResult();
        }
        public static void NavInitWindow(ImGuiWindowPtr window, bool force_reinit)
        {
            ImGuiWindow* native_window = window.NativePtr;
            byte native_force_reinit = force_reinit ? (byte)1 : (byte)0;
            ImGuiNativeInternal.igNavInitWindow(native_window, native_force_reinit);
        }
        public static void NavMoveRequestApplyResult()
        {
            ImGuiNativeInternal.igNavMoveRequestApplyResult();
        }
        public static bool NavMoveRequestButNoResultYet()
        {
            byte ret = ImGuiNativeInternal.igNavMoveRequestButNoResultYet();
            return ret != 0;
        }
        public static void NavMoveRequestCancel()
        {
            ImGuiNativeInternal.igNavMoveRequestCancel();
        }
        public static void NavMoveRequestForward(ImGuiDir move_dir, ImGuiDir clip_dir, ImGuiNavMoveFlags move_flags, ImGuiScrollFlags scroll_flags)
        {
            ImGuiNativeInternal.igNavMoveRequestForward(move_dir, clip_dir, move_flags, scroll_flags);
        }
        public static void NavMoveRequestResolveWithLastItem(ImGuiNavItemDataPtr result)
        {
            ImGuiNavItemData* native_result = result.NativePtr;
            ImGuiNativeInternal.igNavMoveRequestResolveWithLastItem(native_result);
        }
        public static void NavMoveRequestSubmit(ImGuiDir move_dir, ImGuiDir clip_dir, ImGuiNavMoveFlags move_flags, ImGuiScrollFlags scroll_flags)
        {
            ImGuiNativeInternal.igNavMoveRequestSubmit(move_dir, clip_dir, move_flags, scroll_flags);
        }
        public static void NavMoveRequestTryWrapping(ImGuiWindowPtr window, ImGuiNavMoveFlags move_flags)
        {
            ImGuiWindow* native_window = window.NativePtr;
            ImGuiNativeInternal.igNavMoveRequestTryWrapping(native_window, move_flags);
        }
        public static void OpenPopupEx(uint id)
        {
            ImGuiPopupFlags popup_flags = ImGuiPopupFlags.None;
            ImGuiNativeInternal.igOpenPopupEx(id, popup_flags);
        }
        public static void OpenPopupEx(uint id, ImGuiPopupFlags popup_flags)
        {
            ImGuiNativeInternal.igOpenPopupEx(id, popup_flags);
        }
        public static void PopColumnsBackground()
        {
            ImGuiNativeInternal.igPopColumnsBackground();
        }
        public static void PopFocusScope()
        {
            ImGuiNativeInternal.igPopFocusScope();
        }
        public static void PopItemFlag()
        {
            ImGuiNativeInternal.igPopItemFlag();
        }
        public static void PushColumnClipRect(int column_index)
        {
            ImGuiNativeInternal.igPushColumnClipRect(column_index);
        }
        public static void PushColumnsBackground()
        {
            ImGuiNativeInternal.igPushColumnsBackground();
        }
        public static void PushFocusScope(uint id)
        {
            ImGuiNativeInternal.igPushFocusScope(id);
        }
        public static void PushItemFlag(ImGuiItemFlags option, bool enabled)
        {
            byte native_enabled = enabled ? (byte)1 : (byte)0;
            ImGuiNativeInternal.igPushItemFlag(option, native_enabled);
        }
        public static void PushMultiItemsWidths(int components, float width_full)
        {
            ImGuiNativeInternal.igPushMultiItemsWidths(components, width_full);
        }
        public static void PushOverrideID(uint id)
        {
            ImGuiNativeInternal.igPushOverrideID(id);
        }
        public static void RemoveContextHook(IntPtr context, uint hook_to_remove)
        {
            ImGuiNativeInternal.igRemoveContextHook(context, hook_to_remove);
        }
        public static void RenderArrow(ImDrawListPtr draw_list, Vector2 pos, uint col, ImGuiDir dir)
        {
            ImDrawList* native_draw_list = draw_list.NativePtr;
            float scale = 1.0f;
            ImGuiNativeInternal.igRenderArrow(native_draw_list, pos, col, dir, scale);
        }
        public static void RenderArrow(ImDrawListPtr draw_list, Vector2 pos, uint col, ImGuiDir dir, float scale)
        {
            ImDrawList* native_draw_list = draw_list.NativePtr;
            ImGuiNativeInternal.igRenderArrow(native_draw_list, pos, col, dir, scale);
        }
        public static void RenderArrowDockMenu(ImDrawListPtr draw_list, Vector2 p_min, float sz, uint col)
        {
            ImDrawList* native_draw_list = draw_list.NativePtr;
            ImGuiNativeInternal.igRenderArrowDockMenu(native_draw_list, p_min, sz, col);
        }
        public static void RenderArrowPointingAt(ImDrawListPtr draw_list, Vector2 pos, Vector2 half_sz, ImGuiDir direction, uint col)
        {
            ImDrawList* native_draw_list = draw_list.NativePtr;
            ImGuiNativeInternal.igRenderArrowPointingAt(native_draw_list, pos, half_sz, direction, col);
        }
        public static void RenderBullet(ImDrawListPtr draw_list, Vector2 pos, uint col)
        {
            ImDrawList* native_draw_list = draw_list.NativePtr;
            ImGuiNativeInternal.igRenderBullet(native_draw_list, pos, col);
        }
        public static void RenderCheckMark(ImDrawListPtr draw_list, Vector2 pos, uint col, float sz)
        {
            ImDrawList* native_draw_list = draw_list.NativePtr;
            ImGuiNativeInternal.igRenderCheckMark(native_draw_list, pos, col, sz);
        }
        public static void RenderColorRectWithAlphaCheckerboard(ImDrawListPtr draw_list, Vector2 p_min, Vector2 p_max, uint fill_col, float grid_step, Vector2 grid_off)
        {
            ImDrawList* native_draw_list = draw_list.NativePtr;
            float rounding = 0.0f;
            ImDrawFlags flags = (ImDrawFlags)0;
            ImGuiNativeInternal.igRenderColorRectWithAlphaCheckerboard(native_draw_list, p_min, p_max, fill_col, grid_step, grid_off, rounding, flags);
        }
        public static void RenderColorRectWithAlphaCheckerboard(ImDrawListPtr draw_list, Vector2 p_min, Vector2 p_max, uint fill_col, float grid_step, Vector2 grid_off, float rounding)
        {
            ImDrawList* native_draw_list = draw_list.NativePtr;
            ImDrawFlags flags = (ImDrawFlags)0;
            ImGuiNativeInternal.igRenderColorRectWithAlphaCheckerboard(native_draw_list, p_min, p_max, fill_col, grid_step, grid_off, rounding, flags);
        }
        public static void RenderColorRectWithAlphaCheckerboard(ImDrawListPtr draw_list, Vector2 p_min, Vector2 p_max, uint fill_col, float grid_step, Vector2 grid_off, float rounding, ImDrawFlags flags)
        {
            ImDrawList* native_draw_list = draw_list.NativePtr;
            ImGuiNativeInternal.igRenderColorRectWithAlphaCheckerboard(native_draw_list, p_min, p_max, fill_col, grid_step, grid_off, rounding, flags);
        }
        public static void RenderFrame(Vector2 p_min, Vector2 p_max, uint fill_col)
        {
            byte border = 1;
            float rounding = 0.0f;
            ImGuiNativeInternal.igRenderFrame(p_min, p_max, fill_col, border, rounding);
        }
        public static void RenderFrame(Vector2 p_min, Vector2 p_max, uint fill_col, bool border)
        {
            byte native_border = border ? (byte)1 : (byte)0;
            float rounding = 0.0f;
            ImGuiNativeInternal.igRenderFrame(p_min, p_max, fill_col, native_border, rounding);
        }
        public static void RenderFrame(Vector2 p_min, Vector2 p_max, uint fill_col, bool border, float rounding)
        {
            byte native_border = border ? (byte)1 : (byte)0;
            ImGuiNativeInternal.igRenderFrame(p_min, p_max, fill_col, native_border, rounding);
        }
        public static void RenderFrameBorder(Vector2 p_min, Vector2 p_max)
        {
            float rounding = 0.0f;
            ImGuiNativeInternal.igRenderFrameBorder(p_min, p_max, rounding);
        }
        public static void RenderFrameBorder(Vector2 p_min, Vector2 p_max, float rounding)
        {
            ImGuiNativeInternal.igRenderFrameBorder(p_min, p_max, rounding);
        }
        public static void RenderMouseCursor(ImDrawListPtr draw_list, Vector2 pos, float scale, ImGuiMouseCursor mouse_cursor, uint col_fill, uint col_border, uint col_shadow)
        {
            ImDrawList* native_draw_list = draw_list.NativePtr;
            ImGuiNativeInternal.igRenderMouseCursor(native_draw_list, pos, scale, mouse_cursor, col_fill, col_border, col_shadow);
        }
        public static void RenderNavHighlight(ImRect bb, uint id)
        {
            ImGuiNavHighlightFlags flags = ImGuiNavHighlightFlags.TypeDefault;
            ImGuiNativeInternal.igRenderNavHighlight(bb, id, flags);
        }
        public static void RenderNavHighlight(ImRect bb, uint id, ImGuiNavHighlightFlags flags)
        {
            ImGuiNativeInternal.igRenderNavHighlight(bb, id, flags);
        }
        public static void RenderRectFilledRangeH(ImDrawListPtr draw_list, ImRect rect, uint col, float x_start_norm, float x_end_norm, float rounding)
        {
            ImDrawList* native_draw_list = draw_list.NativePtr;
            ImGuiNativeInternal.igRenderRectFilledRangeH(native_draw_list, rect, col, x_start_norm, x_end_norm, rounding);
        }
        public static void RenderRectFilledWithHole(ImDrawListPtr draw_list, ImRect outer, ImRect inner, uint col, float rounding)
        {
            ImDrawList* native_draw_list = draw_list.NativePtr;
            ImGuiNativeInternal.igRenderRectFilledWithHole(native_draw_list, outer, inner, col, rounding);
        }
        public static void RenderText(Vector2 pos, string text)
        {
            byte* native_text;
            int text_byteCount = 0;
            if (text != null)
            {
                text_byteCount = Encoding.UTF8.GetByteCount(text);
                if (text_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_text = Util.Allocate(text_byteCount + 1);
                }
                else
                {
                    byte* native_text_stackBytes = stackalloc byte[text_byteCount + 1];
                    native_text = native_text_stackBytes;
                }
                int native_text_offset = Util.GetUtf8(text, native_text, text_byteCount);
                native_text[native_text_offset] = 0;
            }
            else { native_text = null; }
            byte* native_text_end = null;
            byte hide_text_after_hash = 1;
            ImGuiNativeInternal.igRenderText(pos, native_text, native_text_end, hide_text_after_hash);
            if (text_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_text);
            }
        }
        public static void ScaleWindowsInViewport(ImGuiViewportPPtr viewport, float scale)
        {
            ImGuiViewportP* native_viewport = viewport.NativePtr;
            ImGuiNativeInternal.igScaleWindowsInViewport(native_viewport, scale);
        }
        public static void Scrollbar(ImGuiAxis axis)
        {
            ImGuiNativeInternal.igScrollbar(axis);
        }
        public static bool ScrollbarEx(ImRect bb, uint id, ImGuiAxis axis, ref long p_scroll_v, long avail_v, long contents_v, ImDrawFlags flags)
        {
            fixed (long* native_p_scroll_v = &p_scroll_v)
            {
                byte ret = ImGuiNativeInternal.igScrollbarEx(bb, id, axis, native_p_scroll_v, avail_v, contents_v, flags);
                return ret != 0;
            }
        }
        public static void ScrollToBringRectIntoView(ImGuiWindowPtr window, ImRect rect)
        {
            ImGuiWindow* native_window = window.NativePtr;
            ImGuiNativeInternal.igScrollToBringRectIntoView(native_window, rect);
        }
        public static void ScrollToItem()
        {
            ImGuiScrollFlags flags = (ImGuiScrollFlags)0;
            ImGuiNativeInternal.igScrollToItem(flags);
        }
        public static void ScrollToItem(ImGuiScrollFlags flags)
        {
            ImGuiNativeInternal.igScrollToItem(flags);
        }
        public static void ScrollToRect(ImGuiWindowPtr window, ImRect rect)
        {
            ImGuiWindow* native_window = window.NativePtr;
            ImGuiScrollFlags flags = (ImGuiScrollFlags)0;
            ImGuiNativeInternal.igScrollToRect(native_window, rect, flags);
        }
        public static void ScrollToRect(ImGuiWindowPtr window, ImRect rect, ImGuiScrollFlags flags)
        {
            ImGuiWindow* native_window = window.NativePtr;
            ImGuiNativeInternal.igScrollToRect(native_window, rect, flags);
        }
        public static Vector2 ScrollToRectEx(ImGuiWindowPtr window, ImRect rect)
        {
            Vector2 __retval;
            ImGuiWindow* native_window = window.NativePtr;
            ImGuiScrollFlags flags = (ImGuiScrollFlags)0;
            ImGuiNativeInternal.igScrollToRectEx(&__retval, native_window, rect, flags);
            return __retval;
        }
        public static Vector2 ScrollToRectEx(ImGuiWindowPtr window, ImRect rect, ImGuiScrollFlags flags)
        {
            Vector2 __retval;
            ImGuiWindow* native_window = window.NativePtr;
            ImGuiNativeInternal.igScrollToRectEx(&__retval, native_window, rect, flags);
            return __retval;
        }
        public static void SeparatorEx(ImGuiSeparatorFlags flags)
        {
            ImGuiNativeInternal.igSeparatorEx(flags);
        }
        public static void SetActiveID(uint id, ImGuiWindowPtr window)
        {
            ImGuiWindow* native_window = window.NativePtr;
            ImGuiNativeInternal.igSetActiveID(id, native_window);
        }
        public static void SetActiveIdUsingKey(ImGuiKey key)
        {
            ImGuiNativeInternal.igSetActiveIdUsingKey(key);
        }
        public static void SetActiveIdUsingNavAndKeys()
        {
            ImGuiNativeInternal.igSetActiveIdUsingNavAndKeys();
        }
        public static void SetCurrentFont(ImFontPtr font)
        {
            ImFont* native_font = font.NativePtr;
            ImGuiNativeInternal.igSetCurrentFont(native_font);
        }
        public static void SetCurrentViewport(ImGuiWindowPtr window, ImGuiViewportPPtr viewport)
        {
            ImGuiWindow* native_window = window.NativePtr;
            ImGuiViewportP* native_viewport = viewport.NativePtr;
            ImGuiNativeInternal.igSetCurrentViewport(native_window, native_viewport);
        }
        public static void SetFocusID(uint id, ImGuiWindowPtr window)
        {
            ImGuiWindow* native_window = window.NativePtr;
            ImGuiNativeInternal.igSetFocusID(id, native_window);
        }
        public static void SetHoveredID(uint id)
        {
            ImGuiNativeInternal.igSetHoveredID(id);
        }
        public static void SetItemUsingMouseWheel()
        {
            ImGuiNativeInternal.igSetItemUsingMouseWheel();
        }
        public static void SetLastItemData(uint item_id, ImGuiItemFlags in_flags, ImGuiItemStatusFlags status_flags, ImRect item_rect)
        {
            ImGuiNativeInternal.igSetLastItemData(item_id, in_flags, status_flags, item_rect);
        }
        public static void SetNavID(uint id, ImGuiNavLayer nav_layer, uint focus_scope_id, ImRect rect_rel)
        {
            ImGuiNativeInternal.igSetNavID(id, nav_layer, focus_scope_id, rect_rel);
        }
        public static void SetNextWindowScroll(Vector2 scroll)
        {
            ImGuiNativeInternal.igSetNextWindowScroll(scroll);
        }
        public static void SetScrollFromPosX(ImGuiWindowPtr window, float local_x, float center_x_ratio)
        {
            ImGuiWindow* native_window = window.NativePtr;
            ImGuiNativeInternal.igSetScrollFromPosX_WindowPtr(native_window, local_x, center_x_ratio);
        }
        public static void SetScrollFromPosY(ImGuiWindowPtr window, float local_y, float center_y_ratio)
        {
            ImGuiWindow* native_window = window.NativePtr;
            ImGuiNativeInternal.igSetScrollFromPosY_WindowPtr(native_window, local_y, center_y_ratio);
        }
        public static void SetScrollX(ImGuiWindowPtr window, float scroll_x)
        {
            ImGuiWindow* native_window = window.NativePtr;
            ImGuiNativeInternal.igSetScrollX_WindowPtr(native_window, scroll_x);
        }
        public static void SetScrollY(ImGuiWindowPtr window, float scroll_y)
        {
            ImGuiWindow* native_window = window.NativePtr;
            ImGuiNativeInternal.igSetScrollY_WindowPtr(native_window, scroll_y);
        }
        public static void SetWindowClipRectBeforeSetChannel(ImGuiWindowPtr window, ImRect clip_rect)
        {
            ImGuiWindow* native_window = window.NativePtr;
            ImGuiNativeInternal.igSetWindowClipRectBeforeSetChannel(native_window, clip_rect);
        }
        public static void SetWindowCollapsed(ImGuiWindowPtr window, bool collapsed)
        {
            ImGuiWindow* native_window = window.NativePtr;
            byte native_collapsed = collapsed ? (byte)1 : (byte)0;
            ImGuiCond cond = (ImGuiCond)0;
            ImGuiNativeInternal.igSetWindowCollapsed_WindowPtr(native_window, native_collapsed, cond);
        }
        public static void SetWindowCollapsed(ImGuiWindowPtr window, bool collapsed, ImGuiCond cond)
        {
            ImGuiWindow* native_window = window.NativePtr;
            byte native_collapsed = collapsed ? (byte)1 : (byte)0;
            ImGuiNativeInternal.igSetWindowCollapsed_WindowPtr(native_window, native_collapsed, cond);
        }
        public static void SetWindowDock(ImGuiWindowPtr window, uint dock_id, ImGuiCond cond)
        {
            ImGuiWindow* native_window = window.NativePtr;
            ImGuiNativeInternal.igSetWindowDock(native_window, dock_id, cond);
        }
        public static void SetWindowHitTestHole(ImGuiWindowPtr window, Vector2 pos, Vector2 size)
        {
            ImGuiWindow* native_window = window.NativePtr;
            ImGuiNativeInternal.igSetWindowHitTestHole(native_window, pos, size);
        }
        public static void SetWindowPos(ImGuiWindowPtr window, Vector2 pos)
        {
            ImGuiWindow* native_window = window.NativePtr;
            ImGuiCond cond = (ImGuiCond)0;
            ImGuiNativeInternal.igSetWindowPos_WindowPtr(native_window, pos, cond);
        }
        public static void SetWindowPos(ImGuiWindowPtr window, Vector2 pos, ImGuiCond cond)
        {
            ImGuiWindow* native_window = window.NativePtr;
            ImGuiNativeInternal.igSetWindowPos_WindowPtr(native_window, pos, cond);
        }
        public static void SetWindowSize(ImGuiWindowPtr window, Vector2 size)
        {
            ImGuiWindow* native_window = window.NativePtr;
            ImGuiCond cond = (ImGuiCond)0;
            ImGuiNativeInternal.igSetWindowSize_WindowPtr(native_window, size, cond);
        }
        public static void SetWindowSize(ImGuiWindowPtr window, Vector2 size, ImGuiCond cond)
        {
            ImGuiWindow* native_window = window.NativePtr;
            ImGuiNativeInternal.igSetWindowSize_WindowPtr(native_window, size, cond);
        }
        public static void ShadeVertsLinearColorGradientKeepAlpha(ImDrawListPtr draw_list, int vert_start_idx, int vert_end_idx, Vector2 gradient_p0, Vector2 gradient_p1, uint col0, uint col1)
        {
            ImDrawList* native_draw_list = draw_list.NativePtr;
            ImGuiNativeInternal.igShadeVertsLinearColorGradientKeepAlpha(native_draw_list, vert_start_idx, vert_end_idx, gradient_p0, gradient_p1, col0, col1);
        }
        public static void ShadeVertsLinearUV(ImDrawListPtr draw_list, int vert_start_idx, int vert_end_idx, Vector2 a, Vector2 b, Vector2 uv_a, Vector2 uv_b, bool clamp)
        {
            ImDrawList* native_draw_list = draw_list.NativePtr;
            byte native_clamp = clamp ? (byte)1 : (byte)0;
            ImGuiNativeInternal.igShadeVertsLinearUV(native_draw_list, vert_start_idx, vert_end_idx, a, b, uv_a, uv_b, native_clamp);
        }
        public static void ShowFontAtlas(ImFontAtlasPtr atlas)
        {
            ImFontAtlas* native_atlas = atlas.NativePtr;
            ImGuiNativeInternal.igShowFontAtlas(native_atlas);
        }
        public static void ShrinkWidths(ImGuiShrinkWidthItemPtr items, int count, float width_excess)
        {
            ImGuiShrinkWidthItem* native_items = items.NativePtr;
            ImGuiNativeInternal.igShrinkWidths(native_items, count, width_excess);
        }
        public static void Shutdown(IntPtr context)
        {
            ImGuiNativeInternal.igShutdown(context);
        }
        public static bool SliderBehavior(ImRect bb, uint id, ImGuiDataType data_type, IntPtr p_v, IntPtr p_min, IntPtr p_max, string format, ImGuiSliderFlags flags, ImRectPtr out_grab_bb)
        {
            void* native_p_v = (void*)p_v.ToPointer();
            void* native_p_min = (void*)p_min.ToPointer();
            void* native_p_max = (void*)p_max.ToPointer();
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            ImRect* native_out_grab_bb = out_grab_bb.NativePtr;
            byte ret = ImGuiNativeInternal.igSliderBehavior(bb, id, data_type, native_p_v, native_p_min, native_p_max, native_format, flags, native_out_grab_bb);
            if (format_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_format);
            }
            return ret != 0;
        }
        public static bool SplitterBehavior(ImRect bb, uint id, ImGuiAxis axis, ref float size1, ref float size2, float min_size1, float min_size2)
        {
            float hover_extend = 0.0f;
            float hover_visibility_delay = 0.0f;
            uint bg_col = 0;
            fixed (float* native_size1 = &size1)
            {
                fixed (float* native_size2 = &size2)
                {
                    byte ret = ImGuiNativeInternal.igSplitterBehavior(bb, id, axis, native_size1, native_size2, min_size1, min_size2, hover_extend, hover_visibility_delay, bg_col);
                    return ret != 0;
                }
            }
        }
        public static bool SplitterBehavior(ImRect bb, uint id, ImGuiAxis axis, ref float size1, ref float size2, float min_size1, float min_size2, float hover_extend)
        {
            float hover_visibility_delay = 0.0f;
            uint bg_col = 0;
            fixed (float* native_size1 = &size1)
            {
                fixed (float* native_size2 = &size2)
                {
                    byte ret = ImGuiNativeInternal.igSplitterBehavior(bb, id, axis, native_size1, native_size2, min_size1, min_size2, hover_extend, hover_visibility_delay, bg_col);
                    return ret != 0;
                }
            }
        }
        public static bool SplitterBehavior(ImRect bb, uint id, ImGuiAxis axis, ref float size1, ref float size2, float min_size1, float min_size2, float hover_extend, float hover_visibility_delay)
        {
            uint bg_col = 0;
            fixed (float* native_size1 = &size1)
            {
                fixed (float* native_size2 = &size2)
                {
                    byte ret = ImGuiNativeInternal.igSplitterBehavior(bb, id, axis, native_size1, native_size2, min_size1, min_size2, hover_extend, hover_visibility_delay, bg_col);
                    return ret != 0;
                }
            }
        }
        public static bool SplitterBehavior(ImRect bb, uint id, ImGuiAxis axis, ref float size1, ref float size2, float min_size1, float min_size2, float hover_extend, float hover_visibility_delay, uint bg_col)
        {
            fixed (float* native_size1 = &size1)
            {
                fixed (float* native_size2 = &size2)
                {
                    byte ret = ImGuiNativeInternal.igSplitterBehavior(bb, id, axis, native_size1, native_size2, min_size1, min_size2, hover_extend, hover_visibility_delay, bg_col);
                    return ret != 0;
                }
            }
        }
        public static void StartMouseMovingWindow(ImGuiWindowPtr window)
        {
            ImGuiWindow* native_window = window.NativePtr;
            ImGuiNativeInternal.igStartMouseMovingWindow(native_window);
        }
        public static void StartMouseMovingWindowOrNode(ImGuiWindowPtr window, ImGuiDockNodePtr node, bool undock_floating_node)
        {
            ImGuiWindow* native_window = window.NativePtr;
            ImGuiDockNode* native_node = node.NativePtr;
            byte native_undock_floating_node = undock_floating_node ? (byte)1 : (byte)0;
            ImGuiNativeInternal.igStartMouseMovingWindowOrNode(native_window, native_node, native_undock_floating_node);
        }
        public static void TabBarAddTab(ImGuiTabBarPtr tab_bar, ImGuiTabItemFlags tab_flags, ImGuiWindowPtr window)
        {
            ImGuiTabBar* native_tab_bar = tab_bar.NativePtr;
            ImGuiWindow* native_window = window.NativePtr;
            ImGuiNativeInternal.igTabBarAddTab(native_tab_bar, tab_flags, native_window);
        }
        public static void TabBarCloseTab(ImGuiTabBarPtr tab_bar, ImGuiTabItemPtr tab)
        {
            ImGuiTabBar* native_tab_bar = tab_bar.NativePtr;
            ImGuiTabItem* native_tab = tab.NativePtr;
            ImGuiNativeInternal.igTabBarCloseTab(native_tab_bar, native_tab);
        }
        public static ImGuiTabItemPtr TabBarFindMostRecentlySelectedTabForActiveWindow(ImGuiTabBarPtr tab_bar)
        {
            ImGuiTabBar* native_tab_bar = tab_bar.NativePtr;
            ImGuiTabItem* ret = ImGuiNativeInternal.igTabBarFindMostRecentlySelectedTabForActiveWindow(native_tab_bar);
            return new ImGuiTabItemPtr(ret);
        }
        public static ImGuiTabItemPtr TabBarFindTabByID(ImGuiTabBarPtr tab_bar, uint tab_id)
        {
            ImGuiTabBar* native_tab_bar = tab_bar.NativePtr;
            ImGuiTabItem* ret = ImGuiNativeInternal.igTabBarFindTabByID(native_tab_bar, tab_id);
            return new ImGuiTabItemPtr(ret);
        }
        public static bool TabBarProcessReorder(ImGuiTabBarPtr tab_bar)
        {
            ImGuiTabBar* native_tab_bar = tab_bar.NativePtr;
            byte ret = ImGuiNativeInternal.igTabBarProcessReorder(native_tab_bar);
            return ret != 0;
        }
        public static void TabBarQueueReorder(ImGuiTabBarPtr tab_bar, ImGuiTabItemPtr tab, int offset)
        {
            ImGuiTabBar* native_tab_bar = tab_bar.NativePtr;
            ImGuiTabItem* native_tab = tab.NativePtr;
            ImGuiNativeInternal.igTabBarQueueReorder(native_tab_bar, native_tab, offset);
        }
        public static void TabBarQueueReorderFromMousePos(ImGuiTabBarPtr tab_bar, ImGuiTabItemPtr tab, Vector2 mouse_pos)
        {
            ImGuiTabBar* native_tab_bar = tab_bar.NativePtr;
            ImGuiTabItem* native_tab = tab.NativePtr;
            ImGuiNativeInternal.igTabBarQueueReorderFromMousePos(native_tab_bar, native_tab, mouse_pos);
        }
        public static void TabBarRemoveTab(ImGuiTabBarPtr tab_bar, uint tab_id)
        {
            ImGuiTabBar* native_tab_bar = tab_bar.NativePtr;
            ImGuiNativeInternal.igTabBarRemoveTab(native_tab_bar, tab_id);
        }
        public static void TabItemBackground(ImDrawListPtr draw_list, ImRect bb, ImGuiTabItemFlags flags, uint col)
        {
            ImDrawList* native_draw_list = draw_list.NativePtr;
            ImGuiNativeInternal.igTabItemBackground(native_draw_list, bb, flags, col);
        }
        public static Vector2 TabItemCalcSize(string label, bool has_close_button)
        {
            Vector2 __retval;
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte native_has_close_button = has_close_button ? (byte)1 : (byte)0;
            ImGuiNativeInternal.igTabItemCalcSize(&__retval, native_label, native_has_close_button);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            return __retval;
        }
        public static bool TabItemEx(ImGuiTabBarPtr tab_bar, string label, ref bool p_open, ImGuiTabItemFlags flags, ImGuiWindowPtr docked_window)
        {
            ImGuiTabBar* native_tab_bar = tab_bar.NativePtr;
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte native_p_open_val = p_open ? (byte)1 : (byte)0;
            byte* native_p_open = &native_p_open_val;
            ImGuiWindow* native_docked_window = docked_window.NativePtr;
            byte ret = ImGuiNativeInternal.igTabItemEx(native_tab_bar, native_label, native_p_open, flags, native_docked_window);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            p_open = native_p_open_val != 0;
            return ret != 0;
        }
        public static void TabItemLabelAndCloseButton(ImDrawListPtr draw_list, ImRect bb, ImGuiTabItemFlags flags, Vector2 frame_padding, string label, uint tab_id, uint close_button_id, bool is_contents_visible, ref bool out_just_closed, ref bool out_text_clipped)
        {
            ImDrawList* native_draw_list = draw_list.NativePtr;
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte native_is_contents_visible = is_contents_visible ? (byte)1 : (byte)0;
            byte native_out_just_closed_val = out_just_closed ? (byte)1 : (byte)0;
            byte* native_out_just_closed = &native_out_just_closed_val;
            byte native_out_text_clipped_val = out_text_clipped ? (byte)1 : (byte)0;
            byte* native_out_text_clipped = &native_out_text_clipped_val;
            ImGuiNativeInternal.igTabItemLabelAndCloseButton(native_draw_list, bb, flags, frame_padding, native_label, tab_id, close_button_id, native_is_contents_visible, native_out_just_closed, native_out_text_clipped);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            out_just_closed = native_out_just_closed_val != 0;
            out_text_clipped = native_out_text_clipped_val != 0;
        }
        public static void TableGcCompactSettings()
        {
            ImGuiNativeInternal.igTableGcCompactSettings();
        }
        public static void TableGcCompactTransientBuffers(ImGuiTableTempDataPtr table)
        {
            ImGuiTableTempData* native_table = table.NativePtr;
            ImGuiNativeInternal.igTableGcCompactTransientBuffers_TableTempDataPtr(native_table);
        }
        public static ImGuiSortDirection TableGetColumnNextSortDirection(ImGuiTableColumnPtr column)
        {
            ImGuiTableColumn* native_column = column.NativePtr;
            ImGuiSortDirection ret = ImGuiNativeInternal.igTableGetColumnNextSortDirection(native_column);
            return ret;
        }
        public static float TableGetHeaderRowHeight()
        {
            float ret = ImGuiNativeInternal.igTableGetHeaderRowHeight();
            return ret;
        }
        public static int TableGetHoveredColumn()
        {
            int ret = ImGuiNativeInternal.igTableGetHoveredColumn();
            return ret;
        }
        public static void TableOpenContextMenu()
        {
            int column_n = -1;
            ImGuiNativeInternal.igTableOpenContextMenu(column_n);
        }
        public static void TableOpenContextMenu(int column_n)
        {
            ImGuiNativeInternal.igTableOpenContextMenu(column_n);
        }
        public static void TablePopBackgroundChannel()
        {
            ImGuiNativeInternal.igTablePopBackgroundChannel();
        }
        public static void TablePushBackgroundChannel()
        {
            ImGuiNativeInternal.igTablePushBackgroundChannel();
        }
        public static void TableSetColumnSortDirection(int column_n, ImGuiSortDirection sort_direction, bool append_to_sort_specs)
        {
            byte native_append_to_sort_specs = append_to_sort_specs ? (byte)1 : (byte)0;
            ImGuiNativeInternal.igTableSetColumnSortDirection(column_n, sort_direction, native_append_to_sort_specs);
        }
        public static void TableSetColumnWidth(int column_n, float width)
        {
            ImGuiNativeInternal.igTableSetColumnWidth(column_n, width);
        }
        public static ImGuiTableSettingsPtr TableSettingsCreate(uint id, int columns_count)
        {
            ImGuiTableSettings* ret = ImGuiNativeInternal.igTableSettingsCreate(id, columns_count);
            return new ImGuiTableSettingsPtr(ret);
        }
        public static ImGuiTableSettingsPtr TableSettingsFindByID(uint id)
        {
            ImGuiTableSettings* ret = ImGuiNativeInternal.igTableSettingsFindByID(id);
            return new ImGuiTableSettingsPtr(ret);
        }
        public static void TableSettingsInstallHandler(IntPtr context)
        {
            ImGuiNativeInternal.igTableSettingsInstallHandler(context);
        }
        public static bool TempInputIsActive(uint id)
        {
            byte ret = ImGuiNativeInternal.igTempInputIsActive(id);
            return ret != 0;
        }
        public static bool TempInputScalar(ImRect bb, uint id, string label, ImGuiDataType data_type, IntPtr p_data, string format)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            void* native_p_data = (void*)p_data.ToPointer();
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            void* p_clamp_min = null;
            void* p_clamp_max = null;
            byte ret = ImGuiNativeInternal.igTempInputScalar(bb, id, native_label, data_type, native_p_data, native_format, p_clamp_min, p_clamp_max);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            if (format_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_format);
            }
            return ret != 0;
        }
        public static bool TempInputScalar(ImRect bb, uint id, string label, ImGuiDataType data_type, IntPtr p_data, string format, IntPtr p_clamp_min)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            void* native_p_data = (void*)p_data.ToPointer();
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            void* native_p_clamp_min = (void*)p_clamp_min.ToPointer();
            void* p_clamp_max = null;
            byte ret = ImGuiNativeInternal.igTempInputScalar(bb, id, native_label, data_type, native_p_data, native_format, native_p_clamp_min, p_clamp_max);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            if (format_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_format);
            }
            return ret != 0;
        }
        public static bool TempInputScalar(ImRect bb, uint id, string label, ImGuiDataType data_type, IntPtr p_data, string format, IntPtr p_clamp_min, IntPtr p_clamp_max)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            void* native_p_data = (void*)p_data.ToPointer();
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            void* native_p_clamp_min = (void*)p_clamp_min.ToPointer();
            void* native_p_clamp_max = (void*)p_clamp_max.ToPointer();
            byte ret = ImGuiNativeInternal.igTempInputScalar(bb, id, native_label, data_type, native_p_data, native_format, native_p_clamp_min, native_p_clamp_max);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            if (format_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_format);
            }
            return ret != 0;
        }
        public static bool TempInputText(ImRect bb, uint id, string label, string buf, int buf_size, ImGuiInputTextFlags flags)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_buf;
            int buf_byteCount = 0;
            if (buf != null)
            {
                buf_byteCount = Encoding.UTF8.GetByteCount(buf);
                if (buf_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_buf = Util.Allocate(buf_byteCount + 1);
                }
                else
                {
                    byte* native_buf_stackBytes = stackalloc byte[buf_byteCount + 1];
                    native_buf = native_buf_stackBytes;
                }
                int native_buf_offset = Util.GetUtf8(buf, native_buf, buf_byteCount);
                native_buf[native_buf_offset] = 0;
            }
            else { native_buf = null; }
            byte ret = ImGuiNativeInternal.igTempInputText(bb, id, native_label, native_buf, buf_size, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            if (buf_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_buf);
            }
            return ret != 0;
        }
        public static void TextEx(string text)
        {
            byte* native_text;
            int text_byteCount = 0;
            if (text != null)
            {
                text_byteCount = Encoding.UTF8.GetByteCount(text);
                if (text_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_text = Util.Allocate(text_byteCount + 1);
                }
                else
                {
                    byte* native_text_stackBytes = stackalloc byte[text_byteCount + 1];
                    native_text = native_text_stackBytes;
                }
                int native_text_offset = Util.GetUtf8(text, native_text, text_byteCount);
                native_text[native_text_offset] = 0;
            }
            else { native_text = null; }
            byte* native_text_end = null;
            ImGuiTextFlags flags = (ImGuiTextFlags)0;
            ImGuiNativeInternal.igTextEx(native_text, native_text_end, flags);
            if (text_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_text);
            }
        }
        public static void TranslateWindowsInViewport(ImGuiViewportPPtr viewport, Vector2 old_pos, Vector2 new_pos)
        {
            ImGuiViewportP* native_viewport = viewport.NativePtr;
            ImGuiNativeInternal.igTranslateWindowsInViewport(native_viewport, old_pos, new_pos);
        }
        public static bool TreeNodeBehavior(uint id, ImGuiTreeNodeFlags flags, string label)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_label_end = null;
            byte ret = ImGuiNativeInternal.igTreeNodeBehavior(id, flags, native_label, native_label_end);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            return ret != 0;
        }
        public static bool TreeNodeBehaviorIsOpen(uint id)
        {
            ImGuiTreeNodeFlags flags = (ImGuiTreeNodeFlags)0;
            byte ret = ImGuiNativeInternal.igTreeNodeBehaviorIsOpen(id, flags);
            return ret != 0;
        }
        public static bool TreeNodeBehaviorIsOpen(uint id, ImGuiTreeNodeFlags flags)
        {
            byte ret = ImGuiNativeInternal.igTreeNodeBehaviorIsOpen(id, flags);
            return ret != 0;
        }
        public static void TreePushOverrideID(uint id)
        {
            ImGuiNativeInternal.igTreePushOverrideID(id);
        }
        public static void UpdateHoveredWindowAndCaptureFlags()
        {
            ImGuiNativeInternal.igUpdateHoveredWindowAndCaptureFlags();
        }
        public static void UpdateInputEvents(bool trickle_fast_inputs)
        {
            byte native_trickle_fast_inputs = trickle_fast_inputs ? (byte)1 : (byte)0;
            ImGuiNativeInternal.igUpdateInputEvents(native_trickle_fast_inputs);
        }
        public static void UpdateMouseMovingWindowEndFrame()
        {
            ImGuiNativeInternal.igUpdateMouseMovingWindowEndFrame();
        }
        public static void UpdateMouseMovingWindowNewFrame()
        {
            ImGuiNativeInternal.igUpdateMouseMovingWindowNewFrame();
        }
        public static void UpdateWindowParentAndRootLinks(ImGuiWindowPtr window, ImGuiWindowFlags flags, ImGuiWindowPtr parent_window)
        {
            ImGuiWindow* native_window = window.NativePtr;
            ImGuiWindow* native_parent_window = parent_window.NativePtr;
            ImGuiNativeInternal.igUpdateWindowParentAndRootLinks(native_window, flags, native_parent_window);
        }
        public static ImRect WindowRectAbsToRel(ImGuiWindowPtr window, ImRect r)
        {
            ImRect __retval;
            ImGuiWindow* native_window = window.NativePtr;
            ImGuiNativeInternal.igWindowRectAbsToRel(&__retval, native_window, r);
            return __retval;
        }
        public static ImRect WindowRectRelToAbs(ImGuiWindowPtr window, ImRect r)
        {
            ImRect __retval;
            ImGuiWindow* native_window = window.NativePtr;
            ImGuiNativeInternal.igWindowRectRelToAbs(&__retval, native_window, r);
            return __retval;
        }
    }
}
