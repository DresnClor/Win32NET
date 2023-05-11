using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Win32NET
{
    /// <summary>
    /// 内存映射文件相关
    /// </summary>
    public static partial class Kernel32
    {
        /// <summary>
        /// 用于创建一个文件映射内核对象
        /// <para />
        /// 函数原型：HANDLE WINAPI CreateFileMapping(_In_HANDLE hFile, _In_opt_LPSECURITY_ATTRIBUTES lpAttributes, _In_DWORD flProtect, _In_DWORD dwMaximumSizeHigh, _In_DWORD dwMaximumSizeLow, _In_opt_LPCTSTR lpName);
        /// </summary>
        /// <param name="hFile">指定欲在其中创建映射的一个文件句柄。0xFFFFFFFF（-1，即INVALID_HANDLE_VALUE）表示在页面文件中创建一个可共享的文件映射</param>
        /// <param name="lpAttributes">SECURITY_ATTRIBUTES，它指明返回的句柄是否可以被子进程所继承，指定一个安全对象，在创建文件映射时使用。如果为NULL（传递0），表示使用默认安全对象</param>
        /// <param name="flProtect">映射保护模式</param>
        /// <param name="dwMaxSizeHigh">文件映射的最大长度的高32位</param>
        /// <param name="dwMaxSizeLow">文件映射的最大长度的低32位。如这个参数和dwMaximumSizeHigh都是零，就用磁盘文件的实际长度</param>
        /// <param name="lpName">指定文件映射对象的名字。如存在这个名字的一个映射，函数就会打开它。传nullString可以创建一个无名的文件映射</param>
        /// <returns></returns>
        [DllImport(Win32.Kernel32dll, CharSet=CharSet.Auto)]
        public static extern IntPtr CreateFileMapping(
            int hFile, 
            IntPtr lpAttributes,
            MapflProtect flProtect, 
            uint dwMaxSizeHigh, 
            uint dwMaxSizeLow,
            [MarshalAs(UnmanagedType.LPTStr)]
            string lpName);

        /// <summary>
        /// 打开一个现成的文件映射对象
        /// <para />
        /// 函数原型:HANDLE WINAPI OpenFileMapping(int dwDesiredAccess, int bInheritHandle, LPCTSTR lpName);
        /// </summary>
        /// <param name="dwDesiredAccess">指定保护类型</param>
        /// <param name="bInheritHandle">如这个函数返回的句柄能由当前进程启动的新进程继承，则这个参数为TRUE</param>
        /// <param name="lpName">指定要打开的文件映射对象名称</param>
        /// <returns>文件映射对象句柄</returns>
        [DllImport(Win32.Kernel32dll, CharSet = CharSet.Auto)]
        public static extern IntPtr OpenFileMapping(
           FileMap dwDesiredAccess, 
            [MarshalAs(UnmanagedType.Bool)] 
            bool bInheritHandle, 
            string lpName);

        /// <summary>
        /// 将一个文件映射对象映射到当前应用程序的地址空间
        /// <para />
        /// 函数原型：LPVOID WINAPI MapViewOfFile(__in HANDLE hFileMappingObject, __in DWORD dwDesiredAccess, __in DWORD dwFileOffsetHigh, __in DWORD dwFileOffsetLow, __in SIZE_T dwNumberOfBytesToMap);
        /// </summary>
        /// <param name="hFileMapping">为CreateFileMapping()或OpenFileMapping()返回的文件映像对象句柄</param>
        /// <param name="dwDesiredAccess">映射对象的文件数据的访问方式，而且同样要与CreateFileMapping()函数所设置的保护属性相匹配</param>
        /// <param name="dwFileOffsetHigh">表示文件映射起始偏移的高32位</param>
        /// <param name="dwFileOffsetLow">表示文件映射起始偏移的低32位.(64KB对齐不是必须的)</param>
        /// <param name="dwNumberOfBytesToMap">指定映射文件的字节数</param>
        /// <returns>如果成功,则返回映射文件的开始地址</returns>
        [DllImport(Win32.Kernel32dll, CharSet = CharSet.Auto)]
        public static extern IntPtr MapViewOfFile(
            IntPtr hFileMapping,
            FileMap dwDesiredAccess, 
            uint dwFileOffsetHigh, 
            uint dwFileOffsetLow, 
            uint dwNumberOfBytesToMap);

        /// <summary>
        /// 停止当前程序的一个内存映射
        /// <para />
        /// 函数原型：BOOL WINAPI UnmapViewOfFile(_In_LPCVOID lpBaseAddress);
        /// </summary>
        /// <param name="pvBaseAddress">指定要解除映射的一个文件映射的基准地址。这个地址是早先用MapViewOfFile函数获得的</param>
        /// <returns>true表示成功，false表示失败</returns>
        [DllImport(Win32.Kernel32dll, CharSet = CharSet.Auto)]
        public static extern bool UnmapViewOfFile(IntPtr pvBaseAddress);

    }
}
