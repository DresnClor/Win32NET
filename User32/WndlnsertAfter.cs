using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Win32NET.User32
{
    /// <summary>
    /// 用于标识在z-顺序的此 CWnd 对象之前的 CWnd 对象
    /// <para />
    /// 用途：SetWindowPos
    /// </summary>
    [Flags]
    public enum WndlnsertAfter
    {
        /// <summary>
        /// HWND_NOTOPMOST 
        /// 将窗口置于所有非顶层窗口之上（即在所有顶层窗口之后）。如果窗口已经是非顶层窗口则该标志不起作用。
        /// </summary>
        NoTopMost = -2,
        /// <summary>
        /// HWND_TOPMOST
        /// 将窗口置于所有非顶层窗口之上。即使窗口未被激活窗口也将保持顶级位置。
        /// </summary>
        TopMost = -1,
        /// <summary>
        /// HWND_TOP 将窗口置于Z序的顶部。
        /// </summary>
        Top = 0,
        /// <summary>
        /// HWND_BOTTOM
        /// 将窗口置于Z序的底部。如果参数hWnd标识了一个顶层窗口，则窗口失去顶级位置，并且被置在其他窗口的底部。
        /// </summary>
        Bottom = 1,
    }

    /// <summary>
    /// SetWindowPos flags参数选项
    /// <para />
    /// 用途：SetWindowPos
    /// </summary>
    [Flags]
    public enum WindowPosSWP : uint
    {
        /// <summary>
        /// SWP_NOSIZE
        /// 忽略 cx、cy, 保持大小
        /// </summary>
        NoSize = 0x1u,
        /// <summary>
        /// SWP_NOMOVE
        /// 忽略 X、Y, 不改变位置
        /// </summary>
        NoMove = 0x2u,
        /// <summary>
        /// SWP_NOZORDER
        /// 忽略 hWndInsertAfter, 保持 Z 顺序
        /// </summary>
        NoZOrder = 0x4u,
        /// <summary>
        /// SWP_NOREDRAW
        /// 不重绘
        /// </summary>
        NoRedraw = 0x8u,
        /// <summary>
        /// SWP_NOACTIVATE
        /// 不激活
        /// </summary>
        NoActivate = 0x10u,
        /// <summary>
        /// SWP_FRAMECHANGED
        ///  强制发送 WM_NCCALCSIZE 消息, 一般只是在改变大小时才发送此消息
        /// </summary>
        FrameChanged = 0x20u,
        /// <summary>
        /// SWP_SHOWWINDOW
        /// 显示窗口
        /// </summary>
        ShowWindow = 0x40u,
        /// <summary>
        /// SWP_HIDEWINDOW
        /// 隐藏窗口
        /// </summary>
        HideWindow = 0x80u,
        /// <summary>
        /// SWP_NOCOPYBITS
        /// 丢弃客户区
        /// </summary>
        NoCopyBits = 0x100u,
        /// <summary>
        /// SWP_NOOWNERZORDER
        /// 忽略 hWndInsertAfter, 不改变 Z 序列的所有者
        /// </summary>
        NoOwnerZorder = 0x200u,
        /// <summary>
        /// SWP_NOSENDCHANGING
        /// 不发出 WM_WINDOWPOSCHANGING 消息
        /// </summary>
        NoSendChanging = 0x400u,
        /// <summary>
        /// SWP_DRAWFRAME
        /// 画边框
        /// </summary>
        DrawFrame = FrameChanged,
        /// <summary>
        /// SWP_NOREPOSITION
        /// </summary>
        NorePosition = NoOwnerZorder,
        /// <summary>
        /// SWP_DEFERERASE
        /// 防止产生 WM_SYNCPAINT 消息
        /// </summary>
        DeferErase = 0x2000u,
        /// <summary>
        /// SWP_ASYNCWINDOWPOS
        /// 若调用进程不拥有窗口, 系统会向拥有窗口的线程发出需求
        /// </summary>
        AsyncWindowPos = 0x4000u,
    }

}
