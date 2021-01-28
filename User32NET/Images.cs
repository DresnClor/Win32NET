using System;
using System.Runtime.InteropServices;

namespace User32NET
{
	/// <summary>
	/// 图像类
	/// </summary>
	public class Images
	{

		/// <summary>
		/// 函数说明:该函数从模块的可执行文件中加载指定的位图资源。该函数已经被函数LoadImage替代
		/// 函数原型:HBITMAP LoadBitmap(HINSTANCE hInstance, LPCTSTR lpBitmapName);
		/// </summary>
		/// <param name="hInstance">指向模块实例的句柄。该模块的可执行文件包含了要加载的位图。</param>
		/// <param name="lpBitmapName">要加载的位图资源名称</param>
		/// <return>返回加载的位图资源句柄</return>
		[DllImport("user32.dll")]
		public static extern IntPtr LoadBitmap(IntPtr hInstance, string lpBitmapName);

		/// <summary>
		/// 函数说明:装载图标，光标，或位图。
		/// 函数原型:HANDLE LoadImage(HINSTANCE hinst，LPCTSTR lpszName，UINT uType，int cxDesired，int cyDesired，UINT fuLoad);
		/// </summary>
		/// <param name="hinst">处理包含被装载图像模块的实例。若要装载OEM图像，则设此参数值为0</param>
		/// <param name="lpszName">指向保留在hinst模块中装载的图像资源名称</param>
		/// <param name="uType">指定被装载图像类型</param>
		/// <param name="cxDesired">指定图标或光标的宽度，以像素为单位</param>
		/// <param name="cyDesired">指定图标或光标的高度，以像素为单位</param>
		/// <param name="fuLoad">图像装载方式</param>
		/// <return>如果函数成功，返回相关资源的数据句柄。如果失败，返回NULL</return>
		[DllImport("user32.dll")]
		public static extern IntPt LoadImage(IntPt hinst，string lpszName，uint uType，int cxDesired，int cyDesired，uint fuLoad);

    }
}