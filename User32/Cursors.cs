using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Win32NET.User32
{
    /// <summary>
    /// 鼠标光标类
    /// </summary>
    public class Cursors
    {
        /// <summary>
        /// 从指定文件中加载光标
        /// <para />
        /// 函数原型:
        /// </summary>
        /// <param name="fileName">.cur文件路径</param>
        /// <returns>如果成功，则返回光标文件句柄</returns>
        [DllImport(Win32.User32dll)]
        public static extern IntPtr LoadCursorFromFile(string fileName);

        /// <summary>
        /// 创建具有指定大小、位模式和热点的光标
        /// <para />
        /// 函数原型:HCURSOR CreateCursor(HINSTANCE  hInst,int xHotSpot,int yHotSpot,int nWidth,int nHeight,const VOID *pvANDPlane,const VOID *pvXORPlane);
        /// </summary>
        /// <param name="hInst">创建光标的应用程序的当前实例的句柄</param>
        /// <param name="xHotSpot">光标热点的水平位置</param>
        /// <param name="yHotSpot">光标热点的垂直位置</param>
        /// <param name="nWidth">光标的宽度（以像素为单位）</param>
        /// <param name="nHeight">光标的高度（以像素为单位）</param>
        /// <param name="pvANDPlane">一个字节数组，其中包含光标 AND 掩码的位值，就像在设备依赖的单色位图中一样</param>
        /// <param name="pvXORPlane">一个字节数组，其中包含光标的 XOR 掩码的位值，就像在设备依赖的单色位图中一样</param>
        /// <returns>如果函数成功，则返回值是光标的句柄。如果函数失败，则返回值为 <see cref="IntPtr.Zero"/></returns>
        [DllImport(Win32.User32dll)]
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
