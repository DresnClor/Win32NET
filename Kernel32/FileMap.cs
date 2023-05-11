using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Win32NET
{
    public static partial class Kernel32
    {
        /// <summary>
        /// 内存映射文件保护类型
        /// </summary>
        [Flags]
        [ApiEnumDef(MarshalType.UInt32, "内存映射文件保护类型")]
        public enum FileMap : uint
        {
            /// <summary>
            /// 拷贝
            /// </summary>
            Copy = 0x0001,
            /// <summary>
            /// 只写
            /// </summary>
            Write = 0x0002,
            /// <summary>
            /// 只读
            /// </summary>
            Read = 0x0004,
            /// <summary>
            /// 全部权限
            /// </summary>
            AllAccess = Write | Read,
        }
    }
}
