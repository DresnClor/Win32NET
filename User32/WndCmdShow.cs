using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Win32NET
{
    public static partial class User32
    {
        /// <summary>
        /// ShowWindow nCmdShow参数选项
        /// <para />
        /// 用途：ShowWindow
        /// </summary>
        [ApiEnumDef(MarshalType.Int32, "ShowWindow nCmdShow参数选项")]
        public enum WndCmdShow : int
        {
            /// <summary>
            /// SW_HIDE
            /// 隐藏窗口并激活其他窗口
            /// </summary>
            Hide = 0,
            /// <summary>
            /// SW_SHOWNORMAL
            /// 激活并显示一个窗口。如果窗口被最小化或最大化，系统将其恢复到原来的尺寸和大小。
            /// 应用程序在第一次显示窗口的时候应该指定此标志
            /// </summary>
            ShowNormal = 1,
            /// <summary>
            /// SW_SHOWMINIMIZED
            /// 激活窗口并将其最小化
            /// </summary>
            ShowMinimized = 2,
            /// <summary>
            /// SHOWMAXIMIZED
            /// 激活窗口并将其最大化
            /// </summary>
            ShowMaximized = 3,
            /// <summary>
            /// SW_SHOWNOACTIVATE
            /// 以窗口最近一次的大小和状态显示窗口。激活窗口仍然维持激活状态
            /// </summary>
            ShowNoActivate = 4,
            /// <summary>
            /// SW_SHOW
            /// 在窗口原来的位置以原来的尺寸激活和显示窗口。
            /// </summary>
            Show = 5,
            /// <summary>
            /// SW_MINIMIZE
            /// 最小化指定的窗口并且激活在Z序中的下一个顶层窗口
            /// </summary>
            Minimize = 6,
            /// <summary>
            /// SW_SHOWMINNOACTIVE
            /// 窗口最小化，激活窗口仍然维持激活状态
            /// </summary>
            ShowMinNoActive = 7,
            /// <summary>
            /// SW_SHOWNA
            /// 以窗口原来的状态显示窗口。激活窗口仍然维持激活状态
            /// </summary>
            Showna = 8,
            /// <summary>
            /// SW_RESTORE
            /// 激活并显示窗口。
            /// 如果窗口最小化或最大化，则系统将窗口恢复到原来的尺寸和位置。
            /// 在恢复最小化窗口时，应用程序应该指定这个标志
            /// </summary>
            Restore = 9,
            /// <summary>
            /// SW_SHOWDEFAULT
            /// 依据在STARTUPINFO结构中指定的SW_FLAG标志设定显示状态，STARTUPINFO 结构是由启动应用程序的程序传递给CreateProcess函数的
            /// </summary>
            ShowDefault = 10,
            /// <summary>
            /// SW_FORCEMINIMIZE
            /// 在WindowNT5.0中最小化窗口，即使拥有窗口的线程被挂起也会最小化。
            /// 在从其他线程最小化窗口时才使用这个参数
            /// </summary>
            ForceMinimize = 11,
        }
    }
}
