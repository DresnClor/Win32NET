using System;
using System.Runtime.InteropServices;

namespace User32NET
{
	/// <summary>
	/// 信息框类
	/// </summary>
	public class Msgbox
	{
        /// <summary>
        /// 函数说明:显示一个模态对话框，其中包含一个系统图标、 一组按钮和一个简短的特定于应用程序消息，如状态或错误的信息
        /// 函数原型:int WINAPI MessageBox(HWND hWnd,LPCTSTR lpText,LPCTSTR lpCaption,UINT uType);
        /// </summary>
        /// <param name="hWnd">父窗口句柄，如为空，则为IntPtr.Zero</param>
        /// <param name="lpText">信息内容</param>
        /// <param name="lpCaption">标题</param>
        /// <param name="uType">要显示的按钮和图标</param>
        /// <return>返回点击的按钮ID</return>
        [DllImport("user32.dll")]
		public static extern int MessageBox(IntPtr hWnd, string lpText, string lpCaption, uint uType);
       
       /// <summary>
        /// 函数说明:创建、显示并操作一个消息框，并可用参数指定预定义按扭采用的语言资源集合 
        /// 函数原型:int MessageBoxEx (HWND hWnd，LPCTSTR lpText, LPCTSTR IpCaption, UINT UType, WORD wLanguageld);
        /// </summary>
        /// <param name="hWnd">父窗口句柄，如为空，则为IntPtr.Zero</param>
        /// <param name="lpText">信息内容</param>
        /// <param name="lpCaption">标题</param>
        /// <param name="uType">要显示的按钮和图标</param>
        /// <param name="wLanguageld">指定哪一个语言资源集被用于预定义的下推按钮</param>
        /// <return>返回点击的按钮ID</return>
        public static extern int MessageBoxEx(IntPtr hWnd，string lpText, string IpCaption, uint UType, short wLanguageld);
                                                   
                                                        
    }

}
