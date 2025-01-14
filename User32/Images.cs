﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Win32NET
{
    /// <summary>
    /// 图像处理类
    /// </summary>
    public static partial class User32
    {
        /// <summary>
        /// 该函数从模块的可执行文件中加载指定的位图资源。该函数已经被函数LoadImage替代
        /// </summary>
        [DllImport(Win32.User32dll)]
        [WinApi("LoadBitmap", Win32.User32dll, "HBITMAP LoadBitmap(HINSTANCE hInstance, LPCTSTR lpBitmapName)", "该函数从模块的可执行文件中加载指定的位图资源。该函数已经被函数LoadImage替代")]
        [ApiReturn(MarshalType.Ptr, "返回加载的位图资源句柄")]
        [ApiParam("hInstance", MarshalType.Ptr, "指向模块实例的句柄。该模块的可执行文件包含了要加载的位图")]
        [ApiParam("lpBitmapName", MarshalType.AutoString, "要加载的位图资源名称")]
        public static extern IntPtr LoadBitmap(
            IntPtr hInstance, 
            string lpBitmapName);

        /// <summary>
        /// 装载图标，光标，或位图。
        /// </summary>
        [DllImport(Win32.User32dll)]
        [WinApi("LoadImage", Win32.User32dll, "HANDLE LoadImage(HINSTANCE hinst,LPCTSTR lpszName,UINT uType,int cxDesired,int cyDesired,UINT fuLoad)", "装载图标，光标，或位图")]
        [ApiReturn(MarshalType.Ptr, "如果函数成功，返回相关资源的数据句柄。如果失败，返回NULL")]
        [ApiParam("hinst", MarshalType.Ptr, "处理包含被装载图像模块的实例。若要装载OEM图像，则设此参数值为0")]
        [ApiParam("lpszName", MarshalType.AutoString, "指向保留在hinst模块中装载的图像资源名称")]
        [ApiParam("uType", MarshalType.UInt32, "指定被装载图像类型")]
        [ApiParam("cxDesired", MarshalType.Int32, "指定图标或光标的宽度，以像素为单位")]
        [ApiParam("cyDesired", MarshalType.Int32, "指定图标或光标的高度，以像素为单位")]
        [ApiParam("fuLoad", MarshalType.UInt32, "图像装载方式")]
        public static extern IntPtr LoadImage(
            IntPtr hinst, 
            string lpszName, 
            uint uType, 
            int cxDesired, 
            int cyDesired, 
            uint fuLoad);

    }
}
