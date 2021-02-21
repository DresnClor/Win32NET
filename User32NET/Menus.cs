using System;
using System.Runtime.InteropServices;

namespace User32NET
{
	/// <summary>
	/// 菜单类
	/// </summary>
	public class Menus
	{
        /// <summary>
		/// 创建一个弹出式菜单。此菜单最初是空的，但可用函数InsertMenuItem，AppendMenu，和InsertMenu来填入菜单项。
		/// 函数原型：HMENU CreateMenu（VOID）
		/// </summary>
		/// <returns>返回新创建菜单的句柄</returns>
        [DllImport("user32.dll")]
        public static extern IntPtr CreateMenu();
    }
}