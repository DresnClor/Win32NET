using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Win32NET
{
	/// <summary>
	/// 窗体类
	/// </summary>
	public static partial class User32
	{
		/// <summary>
		/// 该函数获取窗口客户区的坐标。客户区坐标指定客户区的左上角和右下角。由于客户区坐标是相对子窗口客户区的左上角而言的，因此左上角坐标为（0，0）
		/// </summary>
		[DllImport(Win32.User32dll)]
		[WinApi("GetClientRect", Win32.User32dll, "BOOL GetClientRect（HWND hWnd，LPRECT lpRect）", "函数获取窗口客户区的坐标。客户区坐标指定客户区的左上角和右下角。由于客户区坐标是相对子窗口客户区的左上角而言的，因此左上角坐标为（0，0）")]
		[ApiReturn(MarshalType.Bool)]
		[ApiParam("hWnd", MarshalType.Ptr, "")]
		[ApiParam("lpRect", MarshalType.Ptr, "")]
		public static extern bool GetClientRect(IntPtr hWnd, IntPtr lpRect);

		/// <summary>
		/// 桌面窗口覆盖整个屏幕。桌面窗口是一个要在其上绘制所有的图标和其他窗口的区域。
		/// </summary>
		[DllImport(Win32.User32dll)]
		[WinApi("GetDesktopWindow", Win32.User32dll, "HWND GetDesktopWindow(VOID)", "桌面窗口覆盖整个屏幕。桌面窗口是一个要在其上绘制所有的图标和其他窗口的区域")]
		[ApiReturn(MarshalType.Ptr, "返回桌面窗口的句柄")]
		public static extern IntPtr GetDesktopWindow();

		/// <summary>
		/// 系统分配给产生前台窗口的线程一个稍高一点的优先级。
		/// </summary>
		[DllImport(Win32.User32dll)]
		[WinApi("GetForegroundwindow", Win32.User32dll, "HWND GetForegroundwindow(VOID)", "系统分配给产生前台窗口的线程一个稍高一点的优先级")]
		[ApiReturn(MarshalType.Ptr, "返回前台窗口（用户当前工作的窗口）")]
		public static extern IntPtr GetForegroundwindow();

		/// <summary>
		/// 该函数确定指定窗口中的哪一个弹出式窗口是最近活动的窗口。
		/// </summary>
		[DllImport(Win32.User32dll)]
		[WinApi("GetLastActivePopup", Win32.User32dll, "HWND GetLastActivePopup（HWND hWnd）", "该函数确定指定窗口中的哪一个弹出式窗口是最近活动的窗口")]
		[ApiReturn(MarshalType.Ptr, "返回最近活动的窗口句柄")]
		[ApiParam("hWnd", MarshalType.Ptr, "所有者窗口句柄")]
		public static extern IntPtr GetLastActivePopup(IntPtr hWnd);

		/// <summary>
		/// 下一窗口在指定窗口的下面，前一窗口则在上面。
		/// 如果指定的窗口是顶端窗口，该函数返回下一个（或前一个）顶端窗口的句柄。
		/// 如果指定的窗口是顶层窗口，函数返回下一个（或前一个）顶层窗口的句柄。
		/// 如果函数是子窗口，则函数搜索下一个或前一个子窗口的句柄
		/// </summary>
		[DllImport(Win32.User32dll)]
		[WinApi("GetNextWindow", Win32.User32dll, "HWND GetNextWindow（HWND hWnd，UNIT wCmd）", "下一窗口在指定窗口的下面，前一窗口则在上面")]
		[ApiReturn(MarshalType.Ptr, "返回z序中的前一个或后一个窗口的句柄")]
		[ApiParam("hWnd", MarshalType.Ptr, "一个窗口的句柄。窗口句柄在wCmd参数的基础上获得的相对于这个窗口的句柄")]
		[ApiParam("wCmd", MarshalType.Int32, "指明窗口返回的是前一窗口的句柄还是后一窗口的句柄")]
		public static extern IntPtr GetNextWindow(IntPtr hWnd, int wCmd);

		/// <summary>
		/// 该函数获得一个指定子窗口的父窗口句柄。
		/// </summary>
		[DllImport(Win32.User32dll)]
		[WinApi("GetParent", Win32.User32dll, "HWND GetParent（HWND hWnd）", "该函数获得一个指定子窗口的父窗口句柄")]
		[ApiReturn(MarshalType.Ptr, "如果函数成功，返回值为父窗口句柄。如果窗口无父窗口，则函数返回NULL")]
		[ApiParam("hWnd", MarshalType.Ptr, "子窗口句柄，函数要获得该子窗口的父窗口句柄")]
		public static extern IntPtr GetParent(IntPtr hWnd);

		/// <summary>
		/// 应用程序可以使用SetParent函数来设置弹出式窗口，层叠窗口或子窗口的父窗口，新的窗口与窗口必须属于同一应用程序。
		/// </summary>
		[DllImport(Win32.User32dll, EntryPoint = "SetParent")]
		[WinApi("SetParent", Win32.User32dll, "HWND SetParent(HWND hWndChild,HWND hWndNewParent)", "应用程序可以使用SetParent函数来设置弹出式窗口，层叠窗口或子窗口的父窗口，新的窗口与窗口必须属于同一应用程序")]
		[ApiReturn(MarshalType.Ptr, "")]
		[ApiParam("hWndChild", MarshalType.Ptr, "")]
		[ApiParam("hWndNewParent", MarshalType.Ptr, "")]
		public static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

		/// <summary>
		/// 该函数设置指定窗口的显示状态
		/// </summary>
		[DllImport(Win32.User32dll, EntryPoint = "ShowWindow")]
		[WinApi("ShowWindow", Win32.User32dll, "BOOL ShowWindow(HWND hWnd, int nCmdShow)", "该函数设置指定窗口的显示状态")]
		[ApiReturn(MarshalType.Int32, "")]
		[ApiParam("hwnd", MarshalType.Ptr, "窗口句柄")]
		[ApiParam("nCmdShow", MarshalType.Enum, "指定窗口如何显示")]
		public static extern int ShowWindow(IntPtr hwnd, WndCmdShow nCmdShow);

		/// <summary>
		/// 改变一个子窗口，弹出式窗口或顶层窗口的尺寸，位置和Z序。
		/// 子窗口，弹出式窗口，及顶层窗口根据它们在屏幕上出现的顺序排序、顶层窗口设置的级别最高，并且被设置为Z序的第一个窗口。
		/// </summary>
		[DllImport(Win32.User32dll)]
		[WinApi("SetWindowPos", Win32.User32dll, "WINUSERAPI BOOL WINAPI SetWindowPos(HWND hWnd,HWND hWndInsertAfter,int X,int Y,int cx, int cy, UINT uFlags)", "改变一个子窗口，弹出式窗口或顶层窗口的尺寸，位置和Z序")]
		[ApiReturn(MarshalType.Bool, "如果函数成功，返回值为非零；如果函数失败，返回值为零")]
		[ApiParam("hWnd", MarshalType.Ptr, "在z序中的位于被置位的窗口前的窗口句柄。该参数必须为一个窗口句柄")]
		[ApiParam("hWndlnsertAfter", MarshalType.Enum, "用于标识在z-顺序的此 CWnd 对象之前的 CWnd 对象。如果uFlags参数中设置了SWP_NOZORDER标记则本参数将被忽略")]
		[ApiParam("X", MarshalType.Int32, "以客户坐标指定窗口新位置的左边界")]
		[ApiParam("Y", MarshalType.Int32, "以客户坐标指定窗口新位置的顶边界")]
		[ApiParam("cx", MarshalType.Int32, "以像素指定窗口的新的宽度")]
		[ApiParam("cy", MarshalType.Int32, "以像素指定窗口的新的高度")]
		[ApiParam("flags", MarshalType.Enum, "窗口尺寸和定位的标志")]
		public static extern bool SetWindowPos(
			IntPtr hWnd,
			WndlnsertAfter hWndlnsertAfter,
			int X,
			int Y,
			int cx,
			int cy,
			WindowPosSWP flags);

		/// <summary>
		/// 显示一个模态对话框，其中包含一个系统图标、 一组按钮和一个简短的特定于应用程序消息，如状态或错误的信息
		/// </summary>
		[DllImport(Win32.User32dll)]
		[WinApi("MessageBox", Win32.User32dll, "int WINAPI MessageBox(HWND hWnd,LPCTSTR lpText,LPCTSTR lpCaption,UINT uType)", "显示一个模态对话框，其中包含一个系统图标、 一组按钮和一个简短的特定于应用程序消息，如状态或错误的信息")]
		[ApiReturn(MarshalType.Int32, "返回点击的按钮ID")]
		[ApiParam("hWnd", MarshalType.Ptr, "父窗口句柄，如为空，则为IntPtr.Zero")]
		[ApiParam("lpText", MarshalType.AutoString, "信息内容")]
		[ApiParam("lpCaption", MarshalType.AutoString, "标题")]
		[ApiParam("uType", MarshalType.UInt32, "要显示的按钮和图标")]
		public static extern int MessageBox(
			IntPtr hWnd,
			string lpText,
			string lpCaption,
			uint uType);

		/// <summary>
		/// 创建、显示并操作一个消息框，并可用参数指定预定义按扭采用的语言资源集合
		/// </summary>
		[DllImport(Win32.User32dll)]
		[WinApi("MessageBoxEx", Win32.User32dll, "int MessageBoxEx (HWND hWnd，LPCTSTR lpText, LPCTSTR IpCaption, UINT UType, WORD wLanguageld)", "创建、显示并操作一个消息框，并可用参数指定预定义按扭采用的语言资源集合 ")]
		[ApiReturn(MarshalType.Int32, "返回点击的按钮ID")]
		[ApiParam("hWnd", MarshalType.Ptr, "父窗口句柄，如为空，则为IntPtr.Zero")]
		[ApiParam("lpText", MarshalType.AutoString, "信息内容")]
		[ApiParam("lpCaption", MarshalType.AutoString, "标题")]
		[ApiParam("uType", MarshalType.UInt32, "要显示的按钮和图标")]
		[ApiParam("wLanguageld", MarshalType.Int16, "指定哪一个语言资源集被用于预定义的下推按钮")]
		public static extern int MessageBoxEx(
			IntPtr hWnd,
			string lpText,
			string lpCaption,
			uint uType,
			short wLanguageld);

		/// <summary>
		/// 创建，显示并操作一个消息框，这个消息框包含程序定义的消息文本和标题，任意图标，还有任意预定义的按钮的组合。 
		/// </summary>
		[DllImport(Win32.User32dll)]
		[WinApi("MessageBoxIndirect", Win32.User32dll, "int MessageBoxIndirect( CONST LPMSGBOXPARAMS lpMsgBoxParams )", "创建，显示并操作一个消息框")]
		[ApiReturn(MarshalType.Int32, "如果函数成功，返回一个代表用户选项的ID，如果内存不足导致创建失败，则返回0")]
		[ApiParam("lpMsgBoxParams", MarshalType.Ptr, "指向一个MSGBOXPARAMS结构体的指针，包含了显示这个消息框的信息")]
		public static extern int MessageBoxIndirect(IntPtr lpMsgBoxParams);

		/// <summary>
		/// .NET消息值封装枚举版；
		///  将一个消息寄送到一个线程的消息队列后就立即返回
		/// </summary>
		[DllImport(Win32.User32dll, EntryPoint = "SendMessage")]
		[WinApi("SendMessageE", Win32.User32dll, "LRESULT SendMessage（HWND hWnd，UINT Msg，WPARAM wParam，LPARAM lParam）", ".NET消息值封装枚举版")]
		[ApiReturn(MarshalType.Ptr, "返回值指定消息处理的结果，依赖于所发送的消息")]
		[ApiParam("hWnd", MarshalType.Ptr, "指定要接收消息的窗口的句柄")]
		[ApiParam("Msg", MarshalType.Enum, "指定被发送的消息")]
		[ApiParam("wParam", MarshalType.Ptr, "指定附加的消息特定信息")]
		[ApiParam("lParam", MarshalType.Ptr, "指定附加的消息特定信息")]
		public static extern IntPtr SendMessage(
			IntPtr hWnd,
			[MarshalAs(UnmanagedType.U4)]
			WindowsMessage Msg,
			IntPtr wParam,
			IntPtr lParam);

		/// <summary>
		///  将一个消息寄送到一个线程的消息队列后就立即返回
		/// </summary>
		[DllImport(Win32.User32dll, EntryPoint = "SendMessage")]
		[WinApi("SendMessage", Win32.User32dll, "LRESULT SendMessage（HWND hWnd，UINT Msg，WPARAM wParam，LPARAM lParam）", "将一个消息寄送到一个线程的消息队列后就立即返回")]
		[ApiReturn(MarshalType.Ptr, "返回值指定消息处理的结果，依赖于所发送的消息")]
		[ApiParam("hWnd", MarshalType.Ptr, "指定要接收消息的窗口的句柄")]
		[ApiParam("Msg", MarshalType.UInt32, "指定被发送的消息")]
		[ApiParam("wParam", MarshalType.Ptr, "指定附加的消息特定信息")]
		[ApiParam("lParam", MarshalType.Ptr, "指定附加的消息特定信息")]
		public static extern IntPtr SendMessage(
			IntPtr hWnd,
			uint Msg,
			IntPtr wParam,
			IntPtr lParam);

		/// <summary>
		/// 发送消息，字符串参数版本
		/// </summary>
		/// <param name="hWnd"></param>
		/// <param name="Msg"></param>
		/// <param name="wParam"></param>
		/// <param name="lParam"></param>
		/// <returns></returns>
		public static IntPtr SendMessageEx(
			IntPtr hWnd,
			WindowsMessage Msg,
			string wParam,
			string lParam)
		{
			IntPtr wp = IntPtr.Zero;
			IntPtr lp = IntPtr.Zero;
			if (wParam != null)
				wp = Marshal.StringToHGlobalAnsi(wParam);
			if (lParam != null)
				lp = Marshal.StringToHGlobalAnsi(lParam);
			return SendMessage(hWnd, Msg, wp, lp);

		}

	}
}
