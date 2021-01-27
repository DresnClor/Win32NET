using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace User32NET
{
    /// <summary>
    /// 鼠标光标操作类
    /// </summary>
    public class Cursors
    {
        /// <summary>
        /// 加载鼠标光标文件
        /// </summary>
        /// <param name="fileName">.cur文件路径</param>
        /// <returns>如果成功，则返回光标文件句柄</returns>
        [DllImport("user32.dll")]
        public static extern IntPtr LoadCursorFromFile(string fileName);

    }
}
