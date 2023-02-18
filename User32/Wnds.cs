using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Win32NET.User32
{
    /// <summary>
    /// 窗体类
    /// </summary>
    public static class Wnds
    {
        /// <summary>
        /// 该函数获取窗口客户区的坐标。客户区坐标指定客户区的左上角和右下角。由于客户区坐标是相对子窗口客户区的左上角而言的，因此左上角坐标为（0，0）
        /// <para />
        /// 函数原型：BOOL GetClientRect（HWND hWnd，LPRECT lpRect）；
        /// </summary>
        /// <param name="hWnd"></param>
        /// <param name="lpRect"></param>
        /// <returns></returns>
        [DllImport(Win32.User32dll)]
        public static extern bool GetClientRect(IntPtr hWnd, IntPtr lpRect);

        /// <summary>
        /// 桌面窗口覆盖整个屏幕。桌面窗口是一个要在其上绘制所有的图标和其他窗口的区域。
        /// <para />
        /// 函数原型：HWND GetDesktopWindow（VOID）
        /// </summary>
        /// <returns>返回桌面窗口的句柄</returns>
        [DllImport(Win32.User32dll)]
        public static extern IntPtr GetDesktopWindow();

        /// <summary>
        /// 系统分配给产生前台窗口的线程一个稍高一点的优先级。
        /// <para />
        /// 函数原型：HWND GetForegroundwindow（VOID）
        /// </summary>
        /// <returns>返回前台窗口（用户当前工作的窗口）</returns>
        [DllImport(Win32.User32dll)]
        public static extern IntPtr GetForegroundwindow();

        /// <summary>
        /// 该函数确定指定窗口中的哪一个弹出式窗口是最近活动的窗口。
        /// <para />
        /// 函数原型：HWND GetLastActivePopup（HWND hWnd）；
        /// </summary>
        /// <param name="hWnd">所有者窗口句柄</param>
        /// <returns>返回最近活动的窗口句柄</returns>
        [DllImport(Win32.User32dll)]
        public static extern IntPtr GetLastActivePopup(IntPtr hWnd);

        /// <summary>
        /// 下一窗口在指定窗口的下面，前一窗口则在上面。
        /// 如果指定的窗口是顶端窗口，该函数返回下一个（或前一个）顶端窗口的句柄。
        /// 如果指定的窗口是顶层窗口，函数返回下一个（或前一个）顶层窗口的句柄。
        /// 如果函数是子窗口，则函数搜索下一个或前一个子窗口的句柄
        /// <para />
        /// 函数原型：HWND GetNextWindow（HWND hWnd，UNIT wCmd）；
        /// </summary>
        /// <param name="hWnd">一个窗口的句柄。窗口句柄在wCmd参数的基础上获得的相对于这个窗口的句柄</param>
        /// <param name="wCmd">指明窗口返回的是前一窗口的句柄还是后一窗口的句柄。该参数可以是下列两个值之一</param>
        /// <returns>返回z序中的前一个或后一个窗口的句柄</returns>
        [DllImport(Win32.User32dll)]
        public static extern IntPtr GetNextWindow(IntPtr hWnd, IntPtr wCmd);

        /// <summary>
        /// 该函数获得一个指定子窗口的父窗口句柄。
        /// <para />
        /// 函数原型：HWND GetParent（HWND hWnd）；
        /// </summary>
        /// <param name="hWnd">子窗口句柄，函数要获得该子窗口的父窗口句柄。</param>
        /// <returns>如果函数成功，返回值为父窗口句柄。如果窗口无父窗口，则函数返回NULL</returns>
        [DllImport(Win32.User32dll)]
        public static extern IntPtr GetParent(IntPtr hWnd);

        /// <summary>
        /// 应用程序可以使用SetParent函数来设置弹出式窗口，层叠窗口或子窗口的父窗口。
        /// 新的窗口与窗口必须属于同一应用程序。
        /// <para />
        /// 函数原型：HWND SetParent(HWND hWndChild,HWND hWndNewParent);
        /// </summary>
        /// <param name="hWndChild"></param>
        /// <param name="hWndNewParent"></param>
        /// <returns></returns>
        [DllImport(Win32.User32dll, EntryPoint = "SetParent")]
        public static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        /// <summary>
        /// 该函数设置指定窗口的显示状态。
        /// <para />
        /// 函数原型：BOOL ShowWindow(HWND hWnd, int nCmdShow);
        /// </summary>
        /// <param name="hwnd">窗口句柄。</param>
        /// <param name="nCmdShow">指定窗口如何显示。</param>
        /// <returns></returns>
        [DllImport(Win32.User32dll, EntryPoint = "ShowWindow")]
        public static extern int ShowWindow(IntPtr hwnd, WndCmdShow nCmdShow);

        /// <summary>
        /// 改变一个子窗口，弹出式窗口或顶层窗口的尺寸，位置和Z序。
        /// 子窗口，弹出式窗口，及顶层窗口根据它们在屏幕上出现的顺序排序、顶层窗口设置的级别最高，并且被设置为Z序的第一个窗口。
        /// <para />
        /// 函数原型：WINUSERAPI BOOL WINAPI SetWindowPos(HWND hWnd,HWND hWndInsertAfter,int X,int Y,int cx, int cy, UINT uFlags);
        /// </summary>
        /// <param name="hWnd">在z序中的位于被置位的窗口前的窗口句柄。该参数必须为一个窗口句柄</param>
        /// <param name="hWndlnsertAfter">用于标识在z-顺序的此 CWnd 对象之前的 CWnd 对象。如果uFlags参数中设置了SWP_NOZORDER标记则本参数将被忽略。</param>
        /// <param name="X">以客户坐标指定窗口新位置的左边界。</param>
        /// <param name="Y">以客户坐标指定窗口新位置的顶边界。</param>
        /// <param name="cx">以像素指定窗口的新的宽度。</param>
        /// <param name="cy">以像素指定窗口的新的高度。</param>
        /// <param name="Flags">窗口尺寸和定位的标志。</param>
        /// <returns>如果函数成功，返回值为非零；如果函数失败，返回值为零。</returns>
        [DllImport(Win32.User32dll)]
        public static extern bool SetWindowPos(
            IntPtr hWnd, 
            WndlnsertAfter 
            hWndlnsertAfter, 
            int X, 
            int Y, 
            int cx, 
            int cy, 
            WindowPosSWP 
            flags);

        /// <summary>
        /// 函数说明:显示一个模态对话框，其中包含一个系统图标、 一组按钮和一个简短的特定于应用程序消息，如状态或错误的信息
        /// <para />
        /// 函数原型:int WINAPI MessageBox(HWND hWnd,LPCTSTR lpText,LPCTSTR lpCaption,UINT uType);
        /// </summary>
        /// <param name="hWnd">父窗口句柄，如为空，则为IntPtr.Zero</param>
        /// <param name="lpText">信息内容</param>
        /// <param name="lpCaption">标题</param>
        /// <param name="uType">要显示的按钮和图标</param>
        /// <return>返回点击的按钮ID</return>
        [DllImport(Win32.User32dll)]
        public static extern int MessageBox(
            IntPtr hWnd, 
            string lpText, 
            string lpCaption, 
            uint uType);

        /// <summary>
        /// 函数说明:创建、显示并操作一个消息框，并可用参数指定预定义按扭采用的语言资源集合 
        /// <para />
        /// 函数原型:int MessageBoxEx (HWND hWnd，LPCTSTR lpText, LPCTSTR IpCaption, UINT UType, WORD wLanguageld);
        /// </summary>
        /// <param name="hWnd">父窗口句柄，如为空，则为IntPtr.Zero</param>
        /// <param name="lpText">信息内容</param>
        /// <param name="lpCaption">标题</param>
        /// <param name="uType">要显示的按钮和图标</param>
        /// <param name="wLanguageld">指定哪一个语言资源集被用于预定义的下推按钮</param>
        /// <return>返回点击的按钮ID</return>
        [DllImport(Win32.User32dll)]
        public static extern int MessageBoxEx(
            IntPtr hWnd, 
            string lpText, 
            string lpCaption, 
            uint uType, 
            short wLanguageld);

        /// <summary>
        /// 函数说明:创建，显示并操作一个消息框。
        /// 这个消息框包含程序定义的消息文本和标题，任意图标，还有任意预定义的按钮的组合。 
        /// <para />
        /// 函数原型:int MessageBoxIndirect( CONST LPMSGBOXPARAMS lpMsgBoxParams );
        /// </summary>
        /// <param name="lpMsgBoxParams">指向一个MSGBOXPARAMS结构体的指针，包含了显示这个消息框的信息。</param>
        /// <return>如果函数成功，返回一个代表用户选项的ID；
        /// 如果有取消按钮，用户按下取消按钮或ESC键，将返回IDCANCEL，如果没有取消按钮，按下ESC无效；
        /// 如果内存不足导致创建失败，则返回0。</return>
        [DllImport(Win32.User32dll)]
        public static extern int MessageBoxIndirect(IntPtr lpMsgBoxParams);

        /// <summary>
        /// .NET消息值封装枚举版；
        ///  将一个消息寄送到一个线程的消息队列后就立即返回
        /// <para />
        /// 函数原型:LRESULT SendMessage（HWND hWnd，UINT Msg，WPARAM wParam，LPARAM lParam）
        /// </summary>
        /// <param name="hWnd">指定要接收消息的窗口的句柄。如果此参数为HWND_BROADCAST，则消息将被发送到系统中所有顶层窗口，包括无效或不可见的非自身拥有的窗口、被覆盖的窗口和弹出式窗口，但消息不被发送到子窗口</param>
        /// <param name="Msg">指定被发送的消息</param>
        /// <param name="wParam">指定附加的消息特定信息</param>
        /// <param name="lParam">指定附加的消息特定信息</param>
        /// <returns>返回值指定消息处理的结果，依赖于所发送的消息</returns>
        [DllImport(Win32.User32dll, EntryPoint = "SendMessage")]
        public static extern IntPtr SendMessageE(
            IntPtr hWnd,
            [MarshalAs(UnmanagedType.U4)]
            WndMsg Msg,
            IntPtr wParam,
            IntPtr lParam);

        /// <summary>
        ///  将一个消息寄送到一个线程的消息队列后就立即返回
        /// <para />
        /// 函数原型:LRESULT SendMessage（HWND hWnd，UINT Msg，WPARAM wParam，LPARAM lParam）
        /// </summary>
        /// <param name="hWnd">指定要接收消息的窗口的句柄。如果此参数为HWND_BROADCAST，则消息将被发送到系统中所有顶层窗口，包括无效或不可见的非自身拥有的窗口、被覆盖的窗口和弹出式窗口，但消息不被发送到子窗口</param>
        /// <param name="Msg">指定被发送的消息</param>
        /// <param name="wParam">指定附加的消息特定信息</param>
        /// <param name="lParam">指定附加的消息特定信息</param>
        /// <returns>返回值指定消息处理的结果，依赖于所发送的消息</returns>
        [DllImport(Win32.User32dll, EntryPoint = "SendMessage")]
        public static extern IntPtr SendMessage(
            IntPtr hWnd,
            uint Msg,
            IntPtr wParam,
            IntPtr lParam);

    }
}
