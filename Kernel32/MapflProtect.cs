using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Win32NET.Kernel32
{
    /// <summary>
    /// CreateFileMapping flProtect参数选项
    /// <para />
    /// 用途：CreateFileMapping
    /// </summary>
    [Flags]
    public enum MapflProtect : uint
    {
        /// <summary>
        /// 以只读方式打开映射
        /// </summary>
        ReadOnly = 0x02,
        /// <summary>
        /// 以可读、可写方式打开映射
        /// </summary>
        ReadWrite = 0x04,
        /// <summary>
        /// 为写操作留下备份
        /// </summary>
        WriteCopy = 0x08,
        /// <summary>
        /// 为文件映射一个小节中的所有页分配内存
        /// </summary>
        Commit = 0x8000000,
        /// <summary>
        /// 文件是个可执行文件
        /// </summary>
        Image = 0x1000000,
        /// <summary>
        /// 无缓存
        /// </summary>
        NoCache = 0x10000000,
        /// <summary>
        /// 为没有分配实际内存的一个小节保留虚拟内存空间
        /// </summary>
        Reserve = 0x4000000,
    }
}
