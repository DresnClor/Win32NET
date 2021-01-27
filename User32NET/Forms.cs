using System;
using System.Runtime.InteropServices;

namespace User32NET
{
	/// <summary>
	/// 窗体操作类
	/// </summary>
	public class Forms
	{
		/// <summary>
		/// 该函数获取窗口客户区的坐标。客户区坐标指定客户区的左上角和右下角。由于客户区坐标是相对子窗口客户区的左上角而言的，因此左上角坐标为（0，0）
		/// 函数原型：BOOL GetClientRect（HWND hWnd，LPRECT lpRect）；
		/// </summary>
		/// <param name="hWnd"></param>
		/// <param name="lpRect"></param>
		/// <returns></returns>
		[DllImport("user32.dll")]
		public static extern bool GetClientRect(IntPtr hWnd, IntPtr lpRect);

		/// <summary>
		/// 桌面窗口覆盖整个屏幕。桌面窗口是一个要在其上绘制所有的图标和其他窗口的区域。
		/// 函数原型：HWND GetDesktopWindow（VOID）
		/// </summary>
		/// <returns>返回桌面窗口的句柄</returns>
		[DllImport("user32.dll")]
		public static extern IntPtr GetDesktopWindow();

		/// <summary>
		/// 系统分配给产生前台窗口的线程一个稍高一点的优先级。
		/// 函数原型：HWND GetForegroundwindow（VOID）
		/// </summary>
		/// <returns>返回前台窗口（用户当前工作的窗口）</returns>
		[DllImport("user32.dll")]
		public static extern IntPtr GetForegroundwindow();

		/// <summary>
		/// 该函数确定指定窗口中的哪一个弹出式窗口是最近活动的窗口。
		/// 函数原型：HWND GetLastActivePopup（HWND hWnd）；
		/// </summary>
		/// <param name="hWnd">所有者窗口句柄</param>
		/// <returns></returns>
		[DllImport("user32.dll")]
		public static extern IntPtr GetLastActivePopup(IntPtr hWnd);

		/// <summary>
		/// 该函数返回z序中的前一个或后一个窗口的句柄。下一窗口在指定窗口的下面，前一窗口则在上面。如果指定的窗口是顶端窗口，该函数返回下一个（或前一个）顶端窗口的句柄。如果指定的窗口是顶层窗口，函数返回下一个（或前一个）顶层窗口的句柄。如果函数是子窗口，则函数搜索下一个或前一个子窗口的句柄
		/// 函数原型：HWND GetNextWindow（HWND hWnd，UNIT wCmd）；
		/// </summary>
		/// <param name="hWnd">一个窗口的句柄。窗口句柄在wCmd参数的基础上获得的相对于这个窗口的句柄</param>
		/// <param name="wCmd">指明窗口返回的是前一窗口的句柄还是后一窗口的句柄。该参数可以是下列两个值之一</param>
		/// <returns></returns>
		[DllImport("user32.dll")]
		public static extern IntPtr GetNextWindow(IntPtr hWnd, IntPtr wCmd);

		/// <summary>
		/// 该函数获得一个指定子窗口的父窗口句柄。
		/// 函数原型：HWND GetParent（HWND hWnd）；
		/// </summary>
		/// <param name="hWnd">子窗口句柄，函数要获得该子窗口的父窗口句柄。</param>
		/// <returns>如果函数成功，返回值为父窗口句柄。如果窗口无父窗口，则函数返回NULL</returns>
		[DllImport("user32.dll")]
		public static extern IntPtr GetParent(IntPtr hWnd);
	}
}
