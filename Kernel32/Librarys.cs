using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Win32NET
{
    /// <summary>
    /// Kernel32.dll库相关API
    /// </summary>
    public static partial class Kernel32
    {
        /// <summary>
        /// 加载动态库
        /// </summary>
        [DllImport(Win32.Kernel32dll, SetLastError = true)]
        [WinApi("LoadLibrary", Win32.Kernel32dll, "HMODULE LoadLibrary(LPCTSTR lpFileName)", "加载动态库")]
        [ApiReturn(MarshalType.Ptr, "加载后的库文件句柄")]
        [ApiParam("lpFileName", MarshalType.Ptr, "库文件路径")]
        public static extern IntPtr LoadLibrary(
            [MarshalAs(UnmanagedType.LPStr)]
            string lpFileName);

        /// <summary>
        /// 释放动态库
        /// </summary>
        [DllImport(Win32.Kernel32dll, CharSet = CharSet.Auto)]
        [WinApi("FreeLibrary", Win32.Kernel32dll, "BOOL WINAPI FreeLibrary( _In_ HMODULE hModule)", "释放动态库")]
        [ApiReturn(MarshalType.Bool, "成功返回真")]
        [ApiParam("module", MarshalType.Ptr, "模块句柄")]
        public static extern bool FreeLibrary(IntPtr module);

        /// <summary>
        /// 查找dll内的函数
        /// </summary>
        [DllImport(Win32.Kernel32dll, CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
        [WinApi("", Win32.Kernel32dll, "FARPROC GetProcAddress(HMODULE hModule, LPCSTR lpProcName)", "查找dll内的函数")]
        [ApiReturn(MarshalType.Ptr, "找到函数返回地址，未找到返回空指针")]
        [ApiParam("hModule", MarshalType.Ptr, "dll模块句柄")]
        [ApiParam("lpProcName", MarshalType.CString, "函数名称")]
        public static extern IntPtr GetProcAddress(
            IntPtr hModule,
            [MarshalAs(UnmanagedType.LPStr)]
            string lpProcName);

        /// <summary>
        /// 设置dll查找目录
        /// </summary>
        [DllImport(Win32.Kernel32dll, CharSet = CharSet.Auto, SetLastError = true)]
        [WinApi("SetDllDirectory", Win32.Kernel32dll, "BOOL SetDllDirectoryA(LPCSTR lpPathName)", "设置dll查找目录")]
        [ApiReturn(MarshalType.Bool)]
        [ApiParam("lpPathName", MarshalType.AutoString, "dll查找路径")]
        public static extern bool SetDllDirectory(string lpPathName);

        /// <summary>
        /// 关闭包括文件、文件映射、进程、线程、安全和同步对象等
        /// </summary>
        [DllImport(Win32.Kernel32dll, CharSet = CharSet.Auto)]
        [WinApi("CloseHandle", Win32.Kernel32dll, "BOOL CloseHandle(HANDLE hObject)", "关闭包括文件、文件映射、进程、线程、安全和同步对象等")]
        [ApiReturn(MarshalType.Bool)]
        [ApiParam("handle", MarshalType.Ptr, "代表一个已打开对象handle")]
        public static extern bool CloseHandle(IntPtr handle);

    }
}
