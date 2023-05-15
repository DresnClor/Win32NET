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
        /// </summary>
        [DllImport(Win32.Kernel32dll, CharSet=CharSet.Auto)]
        [WinApi("CreateFileMapping", Win32.Kernel32dll, "HANDLE WINAPI CreateFileMapping(HANDLE hFile, LPSECURITY_ATTRIBUTES lpAttributes, DWORD flProtect, DWORD dwMaximumSizeHigh, DWORD dwMaximumSizeLow, LPCTSTR lpName)", "用于创建一个文件映射内核对象")]
        [ApiReturn(MarshalType.Ptr, "")]
        [ApiParam("hFile", MarshalType.Int32, "指定欲在其中创建映射的一个文件句柄。0xFFFFFFFF（-1，即INVALID_HANDLE_VALUE）表示在页面文件中创建一个可共享的文件映射")]
        [ApiParam("lpAttributes", MarshalType.Ptr, "SECURITY_ATTRIBUTES，它指明返回的句柄是否可以被子进程所继承，指定一个安全对象，在创建文件映射时使用。如果为NULL（传递0），表示使用默认安全对象")]
        [ApiParam("flProtect", MarshalType.Enum , "映射保护模式")]
        [ApiParam("dwMaxSizeHigh", MarshalType.UInt32, "文件映射的最大长度的高32位")]
        [ApiParam("dwMaxSizeLow", MarshalType.UInt32, "文件映射的最大长度的低32位。如这个参数和dwMaximumSizeHigh都是零，就用磁盘文件的实际长度")]
        [ApiParam("lpName", MarshalType.AutoString, "指定文件映射对象的名字。如存在这个名字的一个映射，函数就会打开它。传nullString可以创建一个无名的文件映射")]
        public static extern IntPtr CreateFileMapping(
            int hFile, 
            IntPtr lpAttributes,
            MapflProtect flProtect, 
            uint dwMaxSizeHigh, 
            uint dwMaxSizeLow,
            string lpName);

        /// <summary>
        /// 打开一个现成的文件映射对象
        /// </summary>
        [DllImport(Win32.Kernel32dll, CharSet = CharSet.Auto)]
        [WinApi("OpenFileMapping", Win32.Kernel32dll, "HANDLE WINAPI OpenFileMapping(int dwDesiredAccess, int bInheritHandle, LPCTSTR lpName)", "打开一个现成的文件映射对象")]
        [ApiReturn(MarshalType.Ptr, "文件映射对象句柄")]
        [ApiParam("dwDesiredAccess", MarshalType.Enum, "指定保护类型")]
        [ApiParam("bInheritHandle", MarshalType.Bool, "如这个函数返回的句柄能由当前进程启动的新进程继承，则这个参数为TRUE")]
        [ApiParam("lpName", MarshalType.AutoString, "指定要打开的文件映射对象名称")]
        public static extern IntPtr OpenFileMapping(
           FileMap dwDesiredAccess, 
            [MarshalAs(UnmanagedType.Bool)] 
            bool bInheritHandle, 
            string lpName);

        /// <summary>
        /// 将一个文件映射对象映射到当前应用程序的地址空间
        /// </summary>
        [DllImport(Win32.Kernel32dll, CharSet = CharSet.Auto)]
        [WinApi("MapViewOfFile", Win32.Kernel32dll, "LPVOID WINAPI MapViewOfFile(HANDLE hFileMappingObject, DWORD dwDesiredAccess, DWORD dwFileOffsetHigh, DWORD dwFileOffsetLow, SIZE_T dwNumberOfBytesToMap)", "将一个文件映射对象映射到当前应用程序的地址空间")]
        [ApiReturn(MarshalType.Ptr, "如果成功,则返回映射文件的开始地址")]
        [ApiParam("hFileMapping", MarshalType.Ptr, "为CreateFileMapping()或OpenFileMapping()返回的文件映像对象句柄")]
        [ApiParam("dwDesiredAccess", MarshalType.Enum, "映射对象的文件数据的访问方式，而且同样要与CreateFileMapping()函数所设置的保护属性相匹配")]
        [ApiParam("dwFileOffsetHigh", MarshalType.UInt32, "表示文件映射起始偏移的高32位")]
        [ApiParam("dwFileOffsetLow", MarshalType.UInt32, "表示文件映射起始偏移的低32位.(64KB对齐不是必须的)")]
        [ApiParam("dwNumberOfBytesToMap", MarshalType.UInt32, "指定映射文件的字节数")]
        public static extern IntPtr MapViewOfFile(
            IntPtr hFileMapping,
            FileMap dwDesiredAccess, 
            uint dwFileOffsetHigh, 
            uint dwFileOffsetLow, 
            uint dwNumberOfBytesToMap);

        /// <summary>
        /// 停止当前程序的一个内存映射
        /// </summary>
        [DllImport(Win32.Kernel32dll, CharSet = CharSet.Auto)]
        [WinApi("UnmapViewOfFile", Win32.Kernel32dll, "BOOL WINAPI UnmapViewOfFile(_In_LPCVOID lpBaseAddress)", "停止当前程序的一个内存映射")]
        [ApiReturn(MarshalType.Bool, "true表示成功，false表示失败")]
        [ApiParam("pvBaseAddress", MarshalType.Ptr, "指定要解除映射的一个文件映射的基准地址。这个地址是早先用MapViewOfFile函数获得的")]
        public static extern bool UnmapViewOfFile(IntPtr pvBaseAddress);

    }
}
