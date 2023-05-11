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
        /// <para />
        /// 函数原型:BOOL WINAPI FreeLibrary( _In_ HMODULE hModule);
        /// </summary>
        /// <param name="module">模块句柄</param>
        /// <returns>成功返回真</returns>
        [DllImport(Win32.Kernel32dll, CharSet = CharSet.Auto)]
        public static extern bool FreeLibrary(IntPtr module);

        /// <summary>
        /// 查找dll函数
        /// <para />
        /// 函数原型:FARPROC GetProcAddress(HMODULE hModule, LPCSTR lpProcName);
        /// </summary>
        /// <param name="hModule">dll模块句柄</param>
        /// <param name="lpProcName">函数名称</param>
        /// <returns></returns>
        [DllImport(Win32.Kernel32dll, CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
        public static extern IntPtr GetProcAddress(
            IntPtr hModule,
            [MarshalAs(UnmanagedType.LPStr)]
            string lpProcName);

        /// <summary>
        /// 设置dll查找目录
        /// <para />
        /// 函数原型:BOOL SetDllDirectoryA(LPCSTR lpPathName);
        /// </summary>
        /// <param name="lpPathName">路径</param>
        /// <returns></returns>
        [DllImport(Win32.Kernel32dll, CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetDllDirectory(string lpPathName);

        /// <summary>
        /// 关闭包括文件、文件映射、进程、线程、安全和同步对象等
        /// <para />
        /// 函数原型:BOOL CloseHandle(HANDLE hObject);
        /// </summary>
        /// <param name="handle">代表一个已打开对象handle</param>
        /// <returns></returns>
        [DllImport(Win32.Kernel32dll, CharSet = CharSet.Auto)]
        public static extern bool CloseHandle(IntPtr handle);

    }
}
