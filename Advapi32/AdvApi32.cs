using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Win32NET
{
    public static partial class AdvApi32
    {

        /// <summary>
        /// 中止系统关机,可停止已启动的系统关机
        /// </summary>
        [DllImport(Win32.Advapi32dll)]
        [WinApi("AbortSystemShutdown", Win32.Advapi32dll, "中止系统关机,可停止已启动的系统关机")]
        [ApiReturn(MarshalType.Bool)]
        [ApiParam("lpMachineName", MarshalType.AutoString)]
        static extern bool AbortSystemShutdown(string lpMachineName);

        /// <summary>
        /// 确定安全描述符是否向由访问令牌标识的客户端授予一组指定的访问权限。通常，服务器应用程序使用此函数来检查对私有对象的访问
        /// </summary>
        [DllImport(Win32.Advapi32dll, SetLastError = true)]
        [WinApi("AccessCheck", Win32.Advapi32dll, "确定安全描述符是否向由访问令牌标识的客户端授予一组指定的访问权限。通常，服务器应用程序使用此函数来检查对私有对象的访问")]
        [ApiReturn(MarshalType.Bool)]
        [ApiParam("pSecurityDescriptor", MarshalType.Array)]
        [ApiParam("ClientToken", MarshalType.Ptr)]
        [ApiParam("DesiredAccess", MarshalType.UInt32)]
        [ApiParam("GenericMapping", MarshalType.Struct)]
        [ApiParam("PrivilegeSet", MarshalType.Ptr)]
        [ApiParam("PrivilegeSetLength", MarshalType.UInt32)]
        [ApiParam("GrantedAccess", MarshalType.UInt32)]
        [ApiParam("AccessStatus", MarshalType.Bool)]
        static extern bool AccessCheck(
            [MarshalAs(UnmanagedType.LPArray)]
            byte [] pSecurityDescriptor,
            IntPtr ClientToken,
            uint DesiredAccess,
            [In] ref GENERIC_MAPPING GenericMapping,
            IntPtr PrivilegeSet,
            ref uint PrivilegeSetLength,
            out uint GrantedAccess,
            out bool AccessStatus);







        /// <summary>
        /// 通用访问权限与对象特定和标准访问权限的映射。当客户端应用程序请求对对象的通用访问权限时，该请求将映射到此结构中定义的访问权限
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        struct GENERIC_MAPPING
        {
            uint GenericRead;
            uint GenericWrite;
            uint GenericExecute;
            uint GenericAll;
        }

    }
}
