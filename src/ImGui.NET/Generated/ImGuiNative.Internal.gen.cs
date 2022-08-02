using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace ImGuiNET
{
    public static unsafe partial class ImGuiNativeInternal
    {
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igActivateItem(uint id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igAddContextHook(IntPtr context, ImGuiContextHook* hook);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igArrowButtonEx(byte* str_id, ImGuiDir dir, Vector2 size_arg, ImGuiButtonFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginChildEx(byte* name, uint id, Vector2 size_arg, byte border, ImGuiWindowFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igBeginColumns(byte* str_id, int count, ImGuiOldColumnFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginComboPopup(uint popup_id, ImRect bb, ImGuiComboFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginComboPreview();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igBeginDockableDragDropSource(ImGuiWindow* window);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igBeginDockableDragDropTarget(ImGuiWindow* window);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igBeginDocked(ImGuiWindow* window, byte* p_open);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginDragDropTargetCustom(ImRect bb, uint id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginMenuEx(byte* label, byte* icon, byte enabled);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginPopupEx(uint id, ImGuiWindowFlags extra_flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginTabBarEx(ImGuiTabBar* tab_bar, ImRect bb, ImGuiTabBarFlags flags, ImGuiDockNode* dock_node);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginTableEx(byte* name, uint id, int columns_count, ImGuiTableFlags flags, Vector2 outer_size, float inner_width);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igBeginTooltipEx(ImGuiTooltipFlags tooltip_flags, ImGuiWindowFlags extra_window_flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginViewportSideBar(byte* name, ImGuiViewport* viewport, ImGuiDir dir, float size, ImGuiWindowFlags window_flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igBringWindowToDisplayBack(ImGuiWindow* window);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igBringWindowToDisplayBehind(ImGuiWindow* window, ImGuiWindow* above_window);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igBringWindowToDisplayFront(ImGuiWindow* window);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igBringWindowToFocusFront(ImGuiWindow* window);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igButtonBehavior(ImRect bb, uint id, byte* out_hovered, byte* out_held, ImGuiButtonFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igButtonEx(byte* label, Vector2 size_arg, ImGuiButtonFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igCalcItemSize(Vector2* pOut, Vector2 size, float default_w, float default_h);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImDrawFlags igCalcRoundingFlagsForRectInRect(ImRect r_in, ImRect r_outer, float threshold);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igCalcTypematicRepeatAmount(float t0, float t1, float repeat_delay, float repeat_rate);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igCalcWindowNextAutoFitSize(Vector2* pOut, ImGuiWindow* window);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igCalcWrapWidthForPos(Vector2 pos, float wrap_pos_x);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igCallContextHooks(IntPtr context, ImGuiContextHookType type);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igCheckboxFlags_S64Ptr(byte* label, long* flags, long flags_value);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igCheckboxFlags_U64Ptr(byte* label, ulong* flags, ulong flags_value);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igClearActiveID();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igClearDragDrop();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igClearIniSettings();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igCloseButton(uint id, Vector2 pos);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igClosePopupsExceptModals();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igClosePopupsOverWindow(ImGuiWindow* ref_window, byte restore_focus_to_window_under_popup);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igClosePopupToLevel(int remaining, byte restore_focus_to_window_under_popup);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igCollapseButton(uint id, Vector2 pos, ImGuiDockNode* dock_node);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igColorEditOptionsPopup(float* col, ImGuiColorEditFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igColorPickerOptionsPopup(float* ref_col, ImGuiColorEditFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igColorTooltip(byte* text, float* col, ImGuiColorEditFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiWindowSettings* igCreateNewWindowSettings(byte* name);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igDataTypeApplyFromText(byte* buf, ImGuiDataType data_type, void* p_data, byte* format);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDataTypeApplyOp(ImGuiDataType data_type, int op, void* output, void* arg_1, void* arg_2);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igDataTypeClamp(ImGuiDataType data_type, void* p_data, void* p_min, void* p_max);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igDataTypeCompare(ImGuiDataType data_type, void* arg_1, void* arg_2);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igDataTypeFormatString(byte* buf, int buf_size, ImGuiDataType data_type, void* p_data, byte* format);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiDataTypeInfo* igDataTypeGetInfo(ImGuiDataType data_type);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDebugDrawItemRect(uint col);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDebugHookIdInfo(uint id, ImGuiDataType data_type, void* data_id, void* data_id_end);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDebugNodeColumns(ImGuiOldColumns* columns);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDebugNodeDockNode(ImGuiDockNode* node, byte* label);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDebugNodeDrawCmdShowMeshAndBoundingBox(ImDrawList* out_draw_list, ImDrawList* draw_list, ImDrawCmd* draw_cmd, byte show_mesh, byte show_aabb);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDebugNodeDrawList(ImGuiWindow* window, ImGuiViewportP* viewport, ImDrawList* draw_list, byte* label);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDebugNodeFont(ImFont* font);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDebugNodeStorage(ImGuiStorage* storage, byte* label);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDebugNodeTabBar(ImGuiTabBar* tab_bar, byte* label);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDebugNodeTableSettings(ImGuiTableSettings* settings);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDebugNodeViewport(ImGuiViewportP* viewport);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDebugNodeWindow(ImGuiWindow* window, byte* label);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDebugNodeWindowSettings(ImGuiWindowSettings* settings);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDebugNodeWindowsList(ImVector* windows, byte* label);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDebugNodeWindowsListByBeginStackParent(ImGuiWindow** windows, int windows_size, ImGuiWindow* parent_in_begin_stack);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDebugRenderViewportThumbnail(ImDrawList* draw_list, ImGuiViewportP* viewport, ImRect bb);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDebugStartItemPicker();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDestroyPlatformWindow(ImGuiViewportP* viewport);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igDockBuilderAddNode(uint node_id, ImGuiDockNodeFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDockBuilderCopyDockSpace(uint src_dockspace_id, uint dst_dockspace_id, ImVector* in_window_remap_pairs);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDockBuilderCopyNode(uint src_node_id, uint dst_node_id, ImVector* out_node_remap_pairs);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDockBuilderCopyWindowSettings(byte* src_name, byte* dst_name);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDockBuilderDockWindow(byte* window_name, uint node_id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDockBuilderFinish(uint node_id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiDockNode* igDockBuilderGetCentralNode(uint node_id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiDockNode* igDockBuilderGetNode(uint node_id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDockBuilderRemoveNode(uint node_id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDockBuilderRemoveNodeChildNodes(uint node_id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDockBuilderRemoveNodeDockedWindows(uint node_id, byte clear_settings_refs);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDockBuilderSetNodePos(uint node_id, Vector2 pos);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDockBuilderSetNodeSize(uint node_id, Vector2 size);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igDockBuilderSplitNode(uint node_id, ImGuiDir split_dir, float size_ratio_for_node_at_dir, uint* out_id_at_dir, uint* out_id_at_opposite_dir);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igDockContextCalcDropPosForDocking(ImGuiWindow* target, ImGuiDockNode* target_node, ImGuiWindow* payload, ImGuiDir split_dir, byte split_outer, Vector2* out_pos);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDockContextClearNodes(IntPtr ctx, uint root_id, byte clear_settings_refs);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDockContextEndFrame(IntPtr ctx);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igDockContextGenNodeID(IntPtr ctx);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDockContextInitialize(IntPtr ctx);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDockContextNewFrameUpdateDocking(IntPtr ctx);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDockContextNewFrameUpdateUndocking(IntPtr ctx);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDockContextQueueDock(IntPtr ctx, ImGuiWindow* target, ImGuiDockNode* target_node, ImGuiWindow* payload, ImGuiDir split_dir, float split_ratio, byte split_outer);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDockContextQueueUndockNode(IntPtr ctx, ImGuiDockNode* node);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDockContextQueueUndockWindow(IntPtr ctx, ImGuiWindow* window);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDockContextRebuildNodes(IntPtr ctx);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDockContextShutdown(IntPtr ctx);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igDockNodeBeginAmendTabBar(ImGuiDockNode* node);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDockNodeEndAmendTabBar();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igDockNodeGetDepth(ImGuiDockNode* node);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiDockNode* igDockNodeGetRootNode(ImGuiDockNode* node);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igDockNodeGetWindowMenuButtonId(ImGuiDockNode* node);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igDockNodeIsInHierarchyOf(ImGuiDockNode* node, ImGuiDockNode* parent);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igDragBehavior(uint id, ImGuiDataType data_type, void* p_v, float v_speed, void* p_min, void* p_max, byte* format, ImGuiSliderFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igEndColumns();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igEndComboPreview();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igErrorCheckEndFrameRecover(IntPtr log_callback, void* user_data);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igErrorCheckEndWindowRecover(IntPtr log_callback, void* user_data);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igFindBestWindowPosForPopup(Vector2* pOut, ImGuiWindow* window);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igFindBestWindowPosForPopupEx(Vector2* pOut, Vector2 ref_pos, Vector2 size, IntPtr last_dir, ImRect r_outer, ImRect r_avoid, ImGuiPopupPositionPolicy policy);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiWindow* igFindBottomMostVisibleWindowWithinBeginStack(ImGuiWindow* window);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiViewportP* igFindHoveredViewportFromPlatformWindowStack(Vector2 mouse_platform_pos);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiOldColumns* igFindOrCreateColumns(ImGuiWindow* window, uint id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiWindowSettings* igFindOrCreateWindowSettings(byte* name);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* igFindRenderedTextEnd(byte* text, byte* text_end);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiSettingsHandler* igFindSettingsHandler(byte* type_name);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiWindow* igFindWindowByID(uint id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiWindow* igFindWindowByName(byte* name);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igFindWindowDisplayIndex(ImGuiWindow* window);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiWindowSettings* igFindWindowSettings(uint id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igFocusTopMostWindowUnderOne(ImGuiWindow* under_this_window, ImGuiWindow* ignore_window);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igFocusWindow(ImGuiWindow* window);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGcAwakeTransientWindowBuffers(ImGuiWindow* window);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGcCompactTransientMiscBuffers();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGcCompactTransientWindowBuffers(ImGuiWindow* window);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igGetActiveID();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetColumnNormFromOffset(ImGuiOldColumns* columns, float offset);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetColumnOffsetFromNorm(ImGuiOldColumns* columns, float offset_norm);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igGetColumnsID(byte* str_id, int count);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetContentRegionMaxAbs(Vector2* pOut);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiWindow* igGetCurrentWindow();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiWindow* igGetCurrentWindowRead();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFont* igGetDefaultFont();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igGetFocusedFocusScope();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igGetFocusID();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igGetFocusScope();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImDrawList* igGetForegroundDrawList_WindowPtr(ImGuiWindow* window);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igGetHoveredID();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igGetIDWithSeed(byte* str_id_begin, byte* str_id_end, uint seed);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiInputTextState* igGetInputTextState(uint id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiItemFlags igGetItemFlags();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igGetItemID();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiItemStatusFlags igGetItemStatusFlags();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiKeyData* igGetKeyData(ImGuiKey key);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiKeyModFlags igGetMergedKeyModFlags();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetNavInputAmount(ImGuiNavInput n, ImGuiInputReadMode mode);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetNavInputAmount2d(Vector2* pOut, ImGuiNavDirSourceFlags dir_sources, ImGuiInputReadMode mode, float slow_factor, float fast_factor);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* igGetNavInputName(ImGuiNavInput n);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetPopupAllowedExtentRect(ImRect* pOut, ImGuiWindow* window);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiWindow* igGetTopMostAndVisiblePopupModal();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiWindow* igGetTopMostPopupModal();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiPlatformMonitor* igGetViewportPlatformMonitor(ImGuiViewport* viewport);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igGetWindowAlwaysWantOwnTabBar(ImGuiWindow* window);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiDockNode* igGetWindowDockNode();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igGetWindowResizeBorderID(ImGuiWindow* window, ImGuiDir dir);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igGetWindowResizeCornerID(ImGuiWindow* window, int n);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igGetWindowScrollbarID(ImGuiWindow* window, ImGuiAxis axis);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetWindowScrollbarRect(ImRect* pOut, ImGuiWindow* window, ImGuiAxis axis);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igImAbs_Int(int x);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igImAbs_Float(float x);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern double igImAbs_double(double x);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igImageButtonEx(uint id, IntPtr texture_id, Vector2 size, Vector2 uv0, Vector2 uv1, Vector2 padding, Vector4 bg_col, Vector4 tint_col);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igImAlphaBlendColors(uint col_a, uint col_b);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImBezierCubicCalc(Vector2* pOut, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, float t);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImBezierCubicClosestPoint(Vector2* pOut, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, Vector2 p, int num_segments);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImBezierCubicClosestPointCasteljau(Vector2* pOut, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, Vector2 p, float tess_tol);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImBezierQuadraticCalc(Vector2* pOut, Vector2 p1, Vector2 p2, Vector2 p3, float t);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImBitArrayClearBit(uint* arr, int n);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImBitArraySetBit(uint* arr, int n);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImBitArraySetBitRange(uint* arr, int n, int n2);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igImBitArrayTestBit(uint* arr, int n);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igImCharIsBlankA(byte c);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igImCharIsBlankW(uint c);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImClamp(Vector2* pOut, Vector2 v, Vector2 mn, Vector2 mx);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igImDot(Vector2 a, Vector2 b);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igImFileClose(IntPtr file);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ulong igImFileGetSize(IntPtr file);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void* igImFileLoadToMemory(byte* filename, byte* mode, uint* out_file_size, int padding_bytes);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr igImFileOpen(byte* filename, byte* mode);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ulong igImFileRead(void* data, ulong size, ulong count, IntPtr file);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ulong igImFileWrite(void* data, ulong size, ulong count, IntPtr file);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igImFloor_Float(float f);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImFloor_Vec2(Vector2* pOut, Vector2 v);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igImFloorSigned_Float(float f);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImFloorSigned_Vec2(Vector2* pOut, Vector2 v);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImFontAtlasBuildFinish(ImFontAtlas* atlas);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImFontAtlasBuildInit(ImFontAtlas* atlas);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImFontAtlasBuildMultiplyCalcLookupTable(byte* out_table, float in_multiply_factor);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImFontAtlasBuildMultiplyRectAlpha8(byte* table, byte* pixels, int x, int y, int w, int h, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImFontAtlasBuildPackCustomRects(ImFontAtlas* atlas, void* stbrp_context_opaque);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImFontAtlasBuildRender32bppRectFromString(ImFontAtlas* atlas, int x, int y, int w, int h, byte* in_str, byte in_marker_char, uint in_marker_pixel_value);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImFontAtlasBuildRender8bppRectFromString(ImFontAtlas* atlas, int x, int y, int w, int h, byte* in_str, byte in_marker_char, byte in_marker_pixel_value);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImFontAtlasBuildSetupFont(ImFontAtlas* atlas, ImFont* font, ImFontConfig* font_config, float ascent, float descent);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr* igImFontAtlasGetBuilderForStbTruetype();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igImFormatString(byte* buf, uint buf_size, byte* fmt);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiDir igImGetDirQuadrantFromDelta(float dx, float dy);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igImHashData(void* data, uint data_size, uint seed);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igImHashStr(byte* data, uint data_size, uint seed);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igImInvLength(Vector2 lhs, float fail_value);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igImIsFloatAboveGuaranteedIntegerPrecision(float f);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igImIsPowerOfTwo_Int(int v);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igImIsPowerOfTwo_U64(ulong v);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igImLengthSqr_Vec2(Vector2 lhs);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igImLengthSqr_Vec4(Vector4 lhs);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImLerp_Vec2Float(Vector2* pOut, Vector2 a, Vector2 b, float t);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImLerp_Vec2Vec2(Vector2* pOut, Vector2 a, Vector2 b, Vector2 t);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImLerp_Vec4(Vector4* pOut, Vector4 a, Vector4 b, float t);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igImLinearSweep(float current, float target, float speed);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImLineClosestPoint(Vector2* pOut, Vector2 a, Vector2 b, Vector2 p);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igImLog_Float(float x);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern double igImLog_double(double x);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImMax(Vector2* pOut, Vector2 lhs, Vector2 rhs);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImMin(Vector2* pOut, Vector2 lhs, Vector2 rhs);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igImModPositive(int a, int b);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImMul(Vector2* pOut, Vector2 lhs, Vector2 rhs);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* igImParseFormatFindEnd(byte* format);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* igImParseFormatFindStart(byte* format);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igImParseFormatPrecision(byte* format, int default_value);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* igImParseFormatTrimDecorations(byte* format, byte* buf, uint buf_size);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igImPow_Float(float x, float y);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern double igImPow_double(double x, double y);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImRotate(Vector2* pOut, Vector2 v, float cos_a, float sin_a);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igImRsqrt_Float(float x);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern double igImRsqrt_double(double x);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igImSaturate(float f);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igImSign_Float(float x);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern double igImSign_double(double x);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort* igImStrbolW(ushort* buf_mid_line, ushort* buf_begin);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* igImStrchrRange(byte* str_begin, byte* str_end, byte c);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* igImStrdup(byte* str);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* igImStrdupcpy(byte* dst, uint* p_dst_size, byte* str);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* igImStreolRange(byte* str, byte* str_end);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igImStricmp(byte* str1, byte* str2);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* igImStristr(byte* haystack, byte* haystack_end, byte* needle, byte* needle_end);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igImStrlenW(ushort* str);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImStrncpy(byte* dst, byte* src, uint count);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igImStrnicmp(byte* str1, byte* str2, uint count);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* igImStrSkipBlank(byte* str);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImStrTrimBlanks(byte* str);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igImTextCharFromUtf8(uint* out_char, byte* in_text, byte* in_text_end);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* igImTextCharToUtf8(byte* out_buf, uint c);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igImTextCountCharsFromUtf8(byte* in_text, byte* in_text_end);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igImTextCountUtf8BytesFromChar(byte* in_text, byte* in_text_end);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igImTextCountUtf8BytesFromStr(ushort* in_text, ushort* in_text_end);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igImTextStrFromUtf8(ushort* out_buf, int out_buf_size, byte* in_text, byte* in_text_end, byte** in_remaining);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igImTextStrToUtf8(byte* out_buf, int out_buf_size, ushort* in_text, ushort* in_text_end);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igImTriangleArea(Vector2 a, Vector2 b, Vector2 c);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImTriangleBarycentricCoords(Vector2 a, Vector2 b, Vector2 c, Vector2 p, float* out_u, float* out_v, float* out_w);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImTriangleClosestPoint(Vector2* pOut, Vector2 a, Vector2 b, Vector2 c, Vector2 p);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igImTriangleContainsPoint(Vector2 a, Vector2 b, Vector2 c, Vector2 p);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igImUpperPowerOfTwo(int v);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igInitialize(IntPtr context);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsActiveIdUsingKey(ImGuiKey key);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsActiveIdUsingNavDir(ImGuiDir dir);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsActiveIdUsingNavInput(ImGuiNavInput input);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsClippedEx(ImRect bb, uint id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsDragDropPayloadBeingAccepted();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsGamepadKey(ImGuiKey key);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsItemToggledSelection();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsKeyPressedMap(ImGuiKey key, byte repeat);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsLegacyKey(ImGuiKey key);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsMouseDragPastThreshold(ImGuiMouseButton button, float lock_threshold);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsNamedKey(ImGuiKey key);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsNavInputDown(ImGuiNavInput n);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsNavInputTest(ImGuiNavInput n, ImGuiInputReadMode rm);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsPopupOpen_ID(uint id, ImGuiPopupFlags popup_flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsWindowAbove(ImGuiWindow* potential_above, ImGuiWindow* potential_below);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsWindowChildOf(ImGuiWindow* window, ImGuiWindow* potential_parent, byte popup_hierarchy, byte dock_hierarchy);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsWindowNavFocusable(ImGuiWindow* window);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsWindowWithinBeginStackOf(ImGuiWindow* window, ImGuiWindow* potential_parent);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igItemAdd(ImRect bb, uint id, ImRect* nav_bb, ImGuiItemFlags extra_flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igItemHoverable(ImRect bb, uint id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igItemSize_Vec2(Vector2 size, float text_baseline_y);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igItemSize_Rect(ImRect bb, float text_baseline_y);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igKeepAliveID(uint id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igLogBegin(ImGuiLogType type, int auto_open_depth);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igLogRenderedText(Vector2* ref_pos, byte* text, byte* text_end);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igLogSetNextTextDecoration(byte* prefix, byte* suffix);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igLogToBuffer(int auto_open_depth);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igMarkIniSettingsDirty_Nil();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igMarkIniSettingsDirty_WindowPtr(ImGuiWindow* window);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igMarkItemEdited(uint id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igMenuItemEx(byte* label, byte* icon, byte* shortcut, byte selected, byte enabled);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igNavInitRequestApplyResult();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igNavInitWindow(ImGuiWindow* window, byte force_reinit);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igNavMoveRequestApplyResult();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igNavMoveRequestButNoResultYet();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igNavMoveRequestCancel();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igNavMoveRequestForward(ImGuiDir move_dir, ImGuiDir clip_dir, ImGuiNavMoveFlags move_flags, ImGuiScrollFlags scroll_flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igNavMoveRequestResolveWithLastItem(ImGuiNavItemData* result);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igNavMoveRequestSubmit(ImGuiDir move_dir, ImGuiDir clip_dir, ImGuiNavMoveFlags move_flags, ImGuiScrollFlags scroll_flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igNavMoveRequestTryWrapping(ImGuiWindow* window, ImGuiNavMoveFlags move_flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igOpenPopupEx(uint id, ImGuiPopupFlags popup_flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPopColumnsBackground();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPopFocusScope();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPopItemFlag();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushColumnClipRect(int column_index);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushColumnsBackground();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushFocusScope(uint id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushItemFlag(ImGuiItemFlags option, byte enabled);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushMultiItemsWidths(int components, float width_full);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushOverrideID(uint id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRemoveContextHook(IntPtr context, uint hook_to_remove);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRenderArrow(ImDrawList* draw_list, Vector2 pos, uint col, ImGuiDir dir, float scale);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRenderArrowDockMenu(ImDrawList* draw_list, Vector2 p_min, float sz, uint col);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRenderArrowPointingAt(ImDrawList* draw_list, Vector2 pos, Vector2 half_sz, ImGuiDir direction, uint col);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRenderBullet(ImDrawList* draw_list, Vector2 pos, uint col);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRenderCheckMark(ImDrawList* draw_list, Vector2 pos, uint col, float sz);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRenderColorRectWithAlphaCheckerboard(ImDrawList* draw_list, Vector2 p_min, Vector2 p_max, uint fill_col, float grid_step, Vector2 grid_off, float rounding, ImDrawFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRenderFrame(Vector2 p_min, Vector2 p_max, uint fill_col, byte border, float rounding);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRenderFrameBorder(Vector2 p_min, Vector2 p_max, float rounding);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRenderMouseCursor(ImDrawList* draw_list, Vector2 pos, float scale, ImGuiMouseCursor mouse_cursor, uint col_fill, uint col_border, uint col_shadow);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRenderNavHighlight(ImRect bb, uint id, ImGuiNavHighlightFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRenderRectFilledRangeH(ImDrawList* draw_list, ImRect rect, uint col, float x_start_norm, float x_end_norm, float rounding);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRenderRectFilledWithHole(ImDrawList* draw_list, ImRect outer, ImRect inner, uint col, float rounding);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRenderText(Vector2 pos, byte* text, byte* text_end, byte hide_text_after_hash);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRenderTextClipped(Vector2 pos_min, Vector2 pos_max, byte* text, byte* text_end, Vector2* text_size_if_known, Vector2 align, ImRect* clip_rect);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRenderTextClippedEx(ImDrawList* draw_list, Vector2 pos_min, Vector2 pos_max, byte* text, byte* text_end, Vector2* text_size_if_known, Vector2 align, ImRect* clip_rect);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRenderTextEllipsis(ImDrawList* draw_list, Vector2 pos_min, Vector2 pos_max, float clip_max_x, float ellipsis_max_x, byte* text, byte* text_end, Vector2* text_size_if_known);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRenderTextWrapped(Vector2 pos, byte* text, byte* text_end, float wrap_width);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igScaleWindowsInViewport(ImGuiViewportP* viewport, float scale);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igScrollbar(ImGuiAxis axis);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igScrollbarEx(ImRect bb, uint id, ImGuiAxis axis, long* p_scroll_v, long avail_v, long contents_v, ImDrawFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igScrollToBringRectIntoView(ImGuiWindow* window, ImRect rect);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igScrollToItem(ImGuiScrollFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igScrollToRect(ImGuiWindow* window, ImRect rect, ImGuiScrollFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igScrollToRectEx(Vector2* pOut, ImGuiWindow* window, ImRect rect, ImGuiScrollFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSeparatorEx(ImGuiSeparatorFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetActiveID(uint id, ImGuiWindow* window);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetActiveIdUsingKey(ImGuiKey key);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetActiveIdUsingNavAndKeys();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetCurrentFont(ImFont* font);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetCurrentViewport(ImGuiWindow* window, ImGuiViewportP* viewport);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetFocusID(uint id, ImGuiWindow* window);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetHoveredID(uint id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetItemUsingMouseWheel();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetLastItemData(uint item_id, ImGuiItemFlags in_flags, ImGuiItemStatusFlags status_flags, ImRect item_rect);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetNavID(uint id, ImGuiNavLayer nav_layer, uint focus_scope_id, ImRect rect_rel);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetNextWindowScroll(Vector2 scroll);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetScrollFromPosX_WindowPtr(ImGuiWindow* window, float local_x, float center_x_ratio);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetScrollFromPosY_WindowPtr(ImGuiWindow* window, float local_y, float center_y_ratio);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetScrollX_WindowPtr(ImGuiWindow* window, float scroll_x);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetScrollY_WindowPtr(ImGuiWindow* window, float scroll_y);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetWindowClipRectBeforeSetChannel(ImGuiWindow* window, ImRect clip_rect);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetWindowCollapsed_WindowPtr(ImGuiWindow* window, byte collapsed, ImGuiCond cond);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetWindowDock(ImGuiWindow* window, uint dock_id, ImGuiCond cond);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetWindowHitTestHole(ImGuiWindow* window, Vector2 pos, Vector2 size);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetWindowPos_WindowPtr(ImGuiWindow* window, Vector2 pos, ImGuiCond cond);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetWindowSize_WindowPtr(ImGuiWindow* window, Vector2 size, ImGuiCond cond);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igShadeVertsLinearColorGradientKeepAlpha(ImDrawList* draw_list, int vert_start_idx, int vert_end_idx, Vector2 gradient_p0, Vector2 gradient_p1, uint col0, uint col1);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igShadeVertsLinearUV(ImDrawList* draw_list, int vert_start_idx, int vert_end_idx, Vector2 a, Vector2 b, Vector2 uv_a, Vector2 uv_b, byte clamp);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igShowFontAtlas(ImFontAtlas* atlas);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igShrinkWidths(ImGuiShrinkWidthItem* items, int count, float width_excess);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igShutdown(IntPtr context);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igSliderBehavior(ImRect bb, uint id, ImGuiDataType data_type, void* p_v, void* p_min, void* p_max, byte* format, ImGuiSliderFlags flags, ImRect* out_grab_bb);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igSplitterBehavior(ImRect bb, uint id, ImGuiAxis axis, float* size1, float* size2, float min_size1, float min_size2, float hover_extend, float hover_visibility_delay, uint bg_col);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igStartMouseMovingWindow(ImGuiWindow* window);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igStartMouseMovingWindowOrNode(ImGuiWindow* window, ImGuiDockNode* node, byte undock_floating_node);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTabBarAddTab(ImGuiTabBar* tab_bar, ImGuiTabItemFlags tab_flags, ImGuiWindow* window);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTabBarCloseTab(ImGuiTabBar* tab_bar, ImGuiTabItem* tab);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTabItem* igTabBarFindMostRecentlySelectedTabForActiveWindow(ImGuiTabBar* tab_bar);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTabItem* igTabBarFindTabByID(ImGuiTabBar* tab_bar, uint tab_id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igTabBarProcessReorder(ImGuiTabBar* tab_bar);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTabBarQueueReorder(ImGuiTabBar* tab_bar, ImGuiTabItem* tab, int offset);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTabBarQueueReorderFromMousePos(ImGuiTabBar* tab_bar, ImGuiTabItem* tab, Vector2 mouse_pos);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTabBarRemoveTab(ImGuiTabBar* tab_bar, uint tab_id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTabItemBackground(ImDrawList* draw_list, ImRect bb, ImGuiTabItemFlags flags, uint col);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTabItemCalcSize(Vector2* pOut, byte* label, byte has_close_button);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igTabItemEx(ImGuiTabBar* tab_bar, byte* label, byte* p_open, ImGuiTabItemFlags flags, ImGuiWindow* docked_window);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTabItemLabelAndCloseButton(ImDrawList* draw_list, ImRect bb, ImGuiTabItemFlags flags, Vector2 frame_padding, byte* label, uint tab_id, uint close_button_id, byte is_contents_visible, byte* out_just_closed, byte* out_text_clipped);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableGcCompactSettings();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableGcCompactTransientBuffers_TableTempDataPtr(ImGuiTableTempData* table);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiSortDirection igTableGetColumnNextSortDirection(ImGuiTableColumn* column);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igTableGetHeaderRowHeight();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igTableGetHoveredColumn();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableOpenContextMenu(int column_n);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTablePopBackgroundChannel();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTablePushBackgroundChannel();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableSetColumnSortDirection(int column_n, ImGuiSortDirection sort_direction, byte append_to_sort_specs);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableSetColumnWidth(int column_n, float width);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTableSettings* igTableSettingsCreate(uint id, int columns_count);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTableSettings* igTableSettingsFindByID(uint id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableSettingsInstallHandler(IntPtr context);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igTempInputIsActive(uint id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igTempInputScalar(ImRect bb, uint id, byte* label, ImGuiDataType data_type, void* p_data, byte* format, void* p_clamp_min, void* p_clamp_max);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igTempInputText(ImRect bb, uint id, byte* label, byte* buf, int buf_size, ImGuiInputTextFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTextEx(byte* text, byte* text_end, ImGuiTextFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTranslateWindowsInViewport(ImGuiViewportP* viewport, Vector2 old_pos, Vector2 new_pos);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igTreeNodeBehavior(uint id, ImGuiTreeNodeFlags flags, byte* label, byte* label_end);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igTreeNodeBehaviorIsOpen(uint id, ImGuiTreeNodeFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTreePushOverrideID(uint id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igUpdateHoveredWindowAndCaptureFlags();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igUpdateInputEvents(byte trickle_fast_inputs);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igUpdateMouseMovingWindowEndFrame();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igUpdateMouseMovingWindowNewFrame();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igUpdateWindowParentAndRootLinks(ImGuiWindow* window, ImGuiWindowFlags flags, ImGuiWindow* parent_window);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igWindowRectAbsToRel(ImRect* pOut, ImGuiWindow* window, ImRect r);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igWindowRectRelToAbs(ImRect* pOut, ImGuiWindow* window, ImRect r);
    }
}
