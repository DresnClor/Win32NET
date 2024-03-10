using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Win32NET
{
	// doc = https://learn.microsoft.com/zh-cn/windows/win32/api/shlobj_core/
	public static partial class Shell32
	{


		/// <summary>
		/// 关闭使用 PifMgr_OpenProperties 打开的应用程序属性
		/// </summary>
		[WinApi("PifMgr_CloseProperties", Win32.Shell32dll, "HANDLE PifMgr_CloseProperties(HANDLE hProps, UINT   flOpt)", "关闭使用 PifMgr_OpenProperties 打开的应用程序属性")]
		[ApiReturn(MarshalType.Ptr, "如果成功，则返回 NULL 。 如果失败，函数会将句柄返回到作为 hProps 传递的应用程序属性")]
		[ApiParam("hProps", MarshalType.Ptr, "应用程序属性的句柄")]
		[ApiParam("flOpt", MarshalType.UInt32, "一个指定函数操作方式的标志")]
		public static extern IntPtr PifMgr_CloseProperties(IntPtr hProps, uint flOpt);

		/// <summary>
		/// 从 .pif 文件返回指定的数据块
		/// </summary>
		[WinApi("PifMgr_GetProperties", Win32.Shell32dll, "int PifMgr_GetProperties(HANDLE hProps, PCSTR  pszGroup, void *lpProps, int cbProps, UINT flOpt)", "从 .pif 文件返回指定的数据块")]
		[ApiReturn(MarshalType.Int32, "如果成功，则返回 NULL 。 如果失败，该函数将返回作为 hProps 传递的应用程序属性的句柄")]
		[ApiParam("hProps", MarshalType.Ptr, "应用程序属性的句柄")]
		[ApiParam("pszGroup", MarshalType.AutoString, "包含属性组名称的以 null 结尾的字符串")]
		[ApiParam("lpProps", MarshalType.Ptr, "当此函数返回时，包含指向 PROPPRG 结构的指针")]
		[ApiParam("cbProps", MarshalType.Int32, "lpProps 指向的缓冲区的大小（以字节为单位）")]
		[ApiParam("flOpt", MarshalType.UInt32, "将此参数设置为GETPROPS_NONE")]
		public static extern int PifMgr_GetProperties(
			IntPtr hProps,
			string pszGroup,
			IntPtr lpProps,
			int cbProps,
			uint flOpt
		);


		/// <summary>
		/// 打开与 Microsoft MS-DOS 应用程序关联的 .pif 文件，并返回应用程序属性的句柄
		/// </summary>
		[WinApi("PifMgr_OpenProperties", Win32.Shell32dll, "HANDLE PifMgr_OpenProperties(PCWSTR pszApp, PCWSTR pszPIF, UINT hInf, UINT flOpt)", "打开与 Microsoft MS-DOS 应用程序关联的 .pif 文件，并返回应用程序属性的句柄")]
		[ApiReturn(MarshalType.Ptr, "返回应用程序属性的句柄")]
		[ApiParam("pszApp", MarshalType.WString, "一个以 null 结尾的 Unicode 字符串，其中包含应用程序的名称")]
		[ApiParam("pszPIF", MarshalType.WString, "一个以 null 结尾的 Unicode 字符串，其中包含 .pif 文件的名称")]
		[ApiParam("hInf", MarshalType.UInt32, "应用程序的 .inf 文件的句柄。 如果没有 .inf 文件，请将此值设置为零。 将此值设置为 -1 以防止处理 .inf 文件")]
		[ApiParam("flOpt", MarshalType.UInt32, "控制函数操作方式的标志")]
		public static extern IntPtr PifMgr_OpenProperties(
			[MarshalAs(UnmanagedType.LPWStr)]
			string pszApp,
			[MarshalAs(UnmanagedType.LPWStr)]
			string pszPIF,
			uint hInf,
			uint flOpt
		);


		/// <summary>
		/// 将值分配给 .pif 文件中的数据块
		/// </summary>
		[WinApi("PifMgr_SetProperties", Win32.Shell32dll, "int PifMgr_SetProperties(HANDLE hProps, PCSTR pszGroup, const void *lpProps, int cbProps, UINT flOpt)", "将值分配给 .pif 文件中的数据块")]
		[ApiReturn(MarshalType.Int32, "返回传输的信息量（以字节为单位）。 如果找不到组或发生错误，则返回零")]
		[ApiParam("hProps", MarshalType.Ptr, "应用程序属性的句柄")]
		[ApiParam("pszGroup", MarshalType.AutoString, "包含属性组名称的以 null 结尾的 ANSI 字符串")]
		[ApiParam("lpProps", MarshalType.Ptr, "保存数据的属性组记录缓冲区")]
		[ApiParam("cbProps", MarshalType.Int32, "lpProps 指向的缓冲区的大小（以字节为单位）")]
		[ApiParam("flOpt", MarshalType.UInt32, "始终SETPROPS_NONE")]
		public static extern int PifMgr_SetProperties(IntPtr hProps,string pszGroup,IntPtr lpProps,int cbProps,uint flOpt);

	}
}
