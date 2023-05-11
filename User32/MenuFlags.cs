using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Win32NET
{
    public static partial class User32
    {
        /// <summary>
        /// 菜单标志
        /// </summary>
        [ApiEnumDef(MarshalType.UInt32, "菜单标志")]
        public enum MenuFlags : uint
        {
            /// <summary>
            /// 插入
            /// </summary>
            Insert = 0x00000000,
            /// <summary>
            /// 改变
            /// </summary>
            Change = 0x00000080,
            /// <summary>
            /// 添加
            /// </summary>
            Append = 0x00000100,
            /// <summary>
            /// 删除
            /// </summary>
            Delete = 0x00000200,
            /// <summary>
            /// 移除
            /// </summary>
            Remove = 0x00001000,
            /// <summary>
            /// 菜单项的标识符
            /// </summary>
            ByCommand = 0x00000000,
            /// <summary>
            /// 菜单项相对于零的位置
            /// </summary>
            ByPosition = 0x00000400,
            /// <summary>
            /// 画一条水平区分线。此标志只被下拉式菜单、子菜单或快捷菜单使用。
            /// 此区分线不能被变灰、无效或加亮。参数IpNewltem和uIDNewltem无用
            /// </summary>
            Separator = 0x00000800,
            /// <summary>
            /// 使菜单项有效，使该项能被选择，并使其从变灰的状态恢复
            /// </summary>
            Enabled = 0x00000000,
            /// <summary>
            /// 使菜单项无效并变灰，使其不能被选择
            /// </summary>
            Grayed = 0x00000001,
            /// <summary>
            /// 使菜单项无效，使该项不能被选择，但不使菜单项变灰
            /// </summary>
            Disabled = 0x00000002,
            /// <summary>
            /// 不放置选取标记在菜单项旁边（缺省）。
            /// 如果应用程序提供一个选取标记位图（参见SetMenultemBitmaps），则将选取标记位图放置在菜单项旁边
            /// </summary>
            Unchecked = 0x00000000,
            /// <summary>
            /// 在菜单项旁边放置一个选取标记。
            /// 如果应用程序提供一个选取标记，位图（参见SetMenultemBitmaps），则将选取标记位图放置在菜单项旁边
            /// </summary>
            Checked = 0x00000008,
            /// <summary>
            /// 放置选取标记在菜单项旁边
            /// </summary>
            UseCheckBitmaps = 0x00000200,
            /// <summary>
            /// 指定菜单项是一个正文字符串；参数lpNewltem指向该字符串
            /// </summary>
            String = 0x00000000,
            /// <summary>
            /// 将一个位图用作菜单项。参数lpNewltem里含有该位图的句柄
            /// </summary>
            Bitmap = 0x00000004,
            /// <summary>
            /// 指定该菜单项为自绘制菜单项。
            /// 菜单第一次显示前，拥有菜单的窗口接收一个WM_MEASUREITEM消息来得到菜单项的宽和高。
            /// 然后，只要菜单项被修改，都将发送WM_DRAWITEM消息给菜单拥有者的窗口程序。
            /// </summary>
            OwnerDraw = 0x00000100,
            /// <summary>
            /// 突出显示菜单项。 如果未指定此标志，则会从项中删除突出显示
            /// </summary>
            Hilite = 0x00000080,
            /// <summary>
            /// 从菜单项中删除突出显示
            /// </summary>
            Unhilite = 0x00000000,
        }
    }
}
