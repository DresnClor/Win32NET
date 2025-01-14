﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Win32NET
{
    /// <summary>
    /// 鼠标光标类
    /// </summary>
    public static partial class User32
    {
        /// <summary>
        /// 从指定文件中加载光标
        /// </summary>
        [DllImport(Win32.User32dll)]
        [WinApi("LoadCursorFromFile", Win32.User32dll, "", "从指定文件中加载光标")]
        [ApiReturn(MarshalType.Ptr, "如果成功，则返回光标文件句柄")]
        [ApiParam("fileName", MarshalType.AutoString, ".cur文件路径")]
        public static extern IntPtr LoadCursorFromFile(string fileName);

        /// <summary>
        /// 创建具有指定大小、位模式和热点的光标
        /// </summary>
        [DllImport(Win32.User32dll)]
        [WinApi("CreateCursor", Win32.User32dll, "HCURSOR CreateCursor(HINSTANCE  hInst, int xHotSpot, int yHotSpot, int nWidth, int nHeight, VOID *pvANDPlane, VOID *pvXORPlane)", "创建具有指定大小、位模式和热点的光标")]
        [ApiReturn(MarshalType.Ptr, "如果函数成功，则返回值是光标的句柄。如果函数失败，则返回值为IntPtr.Zero")]
        [ApiParam("hInst", MarshalType.Ptr, "创建光标的应用程序的当前实例的句柄")]
        [ApiParam("xHotSpot", MarshalType.Int32, "光标热点的水平位置")]
        [ApiParam("yHotSpot", MarshalType.Int32, "光标热点的垂直位置")]
        [ApiParam("nWidth", MarshalType.Int32, "光标的宽度（以像素为单位）")]
        [ApiParam("nHeight", MarshalType.Int32, "光标的高度（以像素为单位）")]
        [ApiParam("pvANDPlane", MarshalType.Ptr, "一个字节数组，其中包含光标 AND 掩码的位值，就像在设备依赖的单色位图中一样")]
        [ApiParam("pvXORPlane", MarshalType.Ptr, "一个字节数组，其中包含光标的 XOR 掩码的位值，就像在设备依赖的单色位图中一样")]
        public static extern IntPtr CreateCursor(
            IntPtr hInst,
            int xHotSpot,
            int yHotSpot,
            int nWidth,
            int nHeight,
            IntPtr pvANDPlane,
            IntPtr pvXORPlane
            );
        /*
        /// <summary>
        /// 
        /// <para />
        /// 函数原型:
        /// </summary>
       
        */
    }
}
