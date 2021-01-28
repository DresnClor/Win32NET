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
         [DllImport("user32.dll")]
        public static extern int MessageBoxEx(IntPtr hWnd,string lpText, string IpCaption, uint UType, short wLanguageld);

        /// <summary>
        /// 函数说明:创建，显示并操作一个消息框。这个消息框包含程序定义的消息文本和标题，任意图标，还有任意预定义的按钮的组合。 
        /// 函数原型:int MessageBoxIndirect( CONST LPMSGBOXPARAMS lpMsgBoxParams );
        /// </summary>
        /// <param name="lpMsgBoxParams">指向一个MSGBOXPARAMS结构体的指针，包含了显示这个消息框的信息。</param>
        /// <return>如果函数成功，返回一个代表用户选项的ID；如果有取消按钮，用户按下取消按钮或ESC键，将返回IDCANCEL，如果没有取消按钮，按下ESC无效；如果内存不足导致创建失败，则返回0。</return>
        [DllImport("user32.dll")]
		public static extern int MessageBoxIndirect(IntPtr lpMsgBoxParams);

                                                                                                                                            
                                                                                                                                                                                   
                                                        
    }

}
