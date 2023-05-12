using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Win32NET
{
    /// <summary>
    /// Win32API描述特性
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
    public class WinApiAttribute : Attribute
    {
        public WinApiAttribute(string funcName, string dllname, CallingConvention calling = CallingConvention.Winapi, string des = "")
        {
            this.DllName = dllname;
            this.Name = funcName;
            this.Descripton = des;
            this.CallingConvention = calling;
            this.Prototype = "";
        }

        public WinApiAttribute(string funcName, string dllname, string proto, string des = "")
        {
            this.DllName = dllname;
            this.Name = funcName;
            this.Descripton = des;
            this.CallingConvention = CallingConvention.Winapi;
            this.Prototype = proto;
        }

        public WinApiAttribute(string funcName, string dllname, string proto, CallingConvention calling, string des = "")
        {
            this.DllName = dllname;
            this.Name = funcName;
            this.Descripton = des;
            this.CallingConvention = calling;
            this.Prototype = proto;
        }


        public WinApiAttribute(string funcName, string dllname, string des = "")
        {
            this.DllName = dllname;
            this.Name = funcName;
            this.Descripton = des;
            this.CallingConvention = CallingConvention.Winapi;
            this.Prototype = "";
        }

        /// <summary>
        /// 原型声明
        /// </summary>
        public string Prototype
        {
            get; private set;

        }

        /// <summary>
        /// dll名称
        /// </summary>
        public string DllName { get; private set; }

        /// <summary>
        /// 调用方式
        /// </summary>
        public CallingConvention CallingConvention { get; private set; }

        /// <summary>
        /// 函数名称
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// 说明信息
        /// </summary>
        public string Descripton { get; private set; }
    }

    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
    public class ApiReturnAttribute : Attribute
    {
        public ApiReturnAttribute(MarshalType type, string des = "")
        {
            this.Type = type;
            this.Descripton = des;
        }

        /// <summary>
        /// 本地交互类型
        /// </summary>
        public MarshalType Type { get; private set; }

        /// <summary>
        /// 说明信息
        /// </summary>
        public string Descripton { get; private set; }
    }

    /// <summary>
    /// 参数特性标记
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
    public class ApiParamAttribute : Attribute
    {
        public ApiParamAttribute(string name, MarshalType type, string des = "")
        {
            this.Name = name;
            this.Type = type;
            this.Descripton = des;
        }

        /// <summary>
        /// 本地交互类型
        /// </summary>
        public MarshalType Type { get; private set; }


        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// 说明信息
        /// </summary>
        public string Descripton { get; private set; }
    }

    /// <summary>
    /// 本地交互枚举类型描述
    /// </summary>
    [AttributeUsage(AttributeTargets.Enum)]
    public class ApiEnumDefAttribute : Attribute
    {
        public ApiEnumDefAttribute(MarshalType type, string des = "")
        {
            this.Type = type;
            this.Descripton = des;
        }

        /// <summary>
        /// 本地交互类型
        /// </summary>
        public MarshalType Type { get; private set; }

        /// <summary>
        /// 说明信息
        /// </summary>
        public string Descripton { get; private set; }
    }

    /// <summary>
    /// 本地交互类型
    /// </summary>
    public enum MarshalType
    {
        /// <summary>
        /// 空类型 引用定义 <see cref="void"/> 类型
        /// </summary>
        Void,
        /// <summary>
        /// 32位有符号整数型 引用定义 <see cref="sbyte"/> 类型
        /// </summary>
        Int8,
        /// <summary>
        /// 32位有符号整数型 引用定义 <see cref="short"/> 类型
        /// </summary>
        Int16,
        /// <summary>
        /// 32位有符号整数型 引用定义 <see cref="int"/> 类型
        /// </summary>
        Int32,
        /// <summary>
        /// 32位有符号整数型 引用定义 <see cref="long"/> 类型
        /// </summary>
        Int64,
        /// <summary>
        /// 8位无符号整数型 引用定义 <see cref="byte"/> 类型
        /// </summary>
        UInt8,
        /// <summary>
        /// 16位无符号整数型 引用定义 <see cref="ushort"/> 类型
        /// </summary>
        UInt16,
        /// <summary>
        /// 32位无符号整数型 引用定义 <see cref="uint"/> 类型
        /// </summary>
        UInt32,
        /// <summary>
        /// 64位无符号整数型 引用定义 <see cref="ulong"/> 类型
        /// </summary>
        UInt64,
        /// <summary>
        /// C#字符串 引用定义 <see cref="string"/> 类型,标记 <see cref="MarshalAsAttribute"/> 参数为 <see cref="UnmanagedType.LPWStr"/>
        /// </summary>
        WString,
        /// <summary>
        /// C字符串 引用定义 <see cref="string"/> 类型,标记 <see cref="MarshalAsAttribute"/> 参数为 <see cref="UnmanagedType.LPStr"/>
        /// </summary>
        CString,
        AutoString,
        /// <summary>
        /// 指针型 引用定义 <see cref="IntPtr"/> 类型
        /// </summary>
        Ptr,
        /// <summary>
        /// 32位浮点型 引用定义 <see cref="float"/> 类型
        /// </summary>
        Float32,
        /// <summary>
        /// 64位浮点型 引用定义 <see cref="double"/> 类型
        /// </summary>
        Float64,
        /// <summary>
        /// 逻辑类型 引用定义 <see cref="bool"/> 类型
        /// </summary>
        Bool,
        /// <summary>
        /// C#内定义枚举类型 引用默认定义 <see cref="int"/> 类型,标记 <see cref="MarshalAsAttribute"/> 参数指定详细类型
        /// </summary>
        Enum,
        Array,
        Struct,
    }

}
