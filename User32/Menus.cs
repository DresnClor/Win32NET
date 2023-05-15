using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace Win32NET
{
    /// <summary>
    /// 菜单相关
    /// </summary>
    public static partial class User32
    {
        /// <summary>
        /// 在指定的菜单里添加一个菜单项
        /// </summary>
        [DllImport(Win32.User32dll)]
        [WinApi("AppendMenu", Win32.User32dll, "BOOL AppendMenu（hMenu hMenu，UINT uFlags，UINT uIDNewltem，LPCTSTR lpNewltem）", "在指定的菜单里添加一个菜单项")]
        [ApiReturn(MarshalType.Bool, "")]
        [ApiParam("hMenu", MarshalType.Ptr, "将被修改的菜单条、下拉式菜单、子菜单、或快捷菜单的句柄")]
        [ApiParam("uFlags", MarshalType.Enum, "控制新菜单项的外观和性能的标志")]
        [ApiParam("uIDNewltem", MarshalType.UInt32, "指定新菜单项的标识符，或者当uFlags设置为MF_POPUP时，表示下拉式菜单或子菜单的句柄")]
        [ApiParam("lpNewltem", MarshalType.AutoString, "指定新菜单项的内容。此参数的含义取决于参数uFlags是否包含MF_BITMAP, MF_OWNERDRAW或MF_STRING标志")]
        public static extern bool AppendMenu(
            IntPtr hMenu,
            [MarshalAs(UnmanagedType.U4)]
            MenuFlags uFlags,
            uint uIDNewltem,
            [MarshalAs(UnmanagedType.LPStr)]
            string lpNewltem);

        /// <summary>
        /// 复选或撤消复选指定的菜单条目
        /// </summary>
        [DllImport(Win32.User32dll)]
        [WinApi("CheckMenuItem", Win32.User32dll, "DWORD CheckMenuItem(HMENU hmenu, UINT uIDCheckItem, UINT uCheck)", "复选或撤消复选指定的菜单条目")]
        [ApiReturn(MarshalType.Int32, "如果指定的项不存在，返回值是OXFFFFFFFF；如果菜单项打开了一个子菜单，则返回值的低位含有与菜单相联系的菜单标志，高位含有子菜单的项数。否则，返回值是莱单标志的掩码（布尔OR）")]
        [ApiParam("hMenu", MarshalType.Ptr, "含有其菜单项的标志将被提取得的菜单的句柄")]
        [ApiParam("uIDCheckltem", MarshalType.UInt32, "其某单标志将被取得的菜单项，此参数含义由参数uCheck决定")]
        [ApiParam("uCheck", MarshalType.Enum, "用于指定参数uld的含义的值")]
        public static extern int CheckMenuItem(
            IntPtr hMenu,
            uint uIDCheckltem,
            [MarshalAs(UnmanagedType.U4)]
            MenuFlags uCheck);

        /// <summary>
        /// 指定一个菜单条目被复选成”单选”项目 
        /// </summary>
        [DllImport(Win32.User32dll)]
        [WinApi("CheckMenuRadioItem", Win32.User32dll, "BOOL CheckMenuRadioItem(HMEN hMENU,UINT idFirst,UINT idLast,UINT idCheck,UINT uFlags)", "指定一个菜单条目被复选成”单选”项目 ")]
        [ApiReturn(MarshalType.Bool, "")]
        [ApiParam("hMenu", MarshalType.Ptr, "包含一组菜单项的菜单的句柄")]
        [ApiParam("idFirst", MarshalType.UInt32, "菜单组里第一个菜单项的标识符或位置")]
        [ApiParam("idLast", MarshalType.UInt32, "菜单组里最后一个菜单项的标识符或位置")]
        [ApiParam("idCheck", MarshalType.UInt32, "要校核的菜单项的标识符或位置")]
        [ApiParam("uFlags", MarshalType.Enum, "指定idFirst，idLast，idCheck含义的值。如果此参数为MF_BYCOMMAND,则其他参数指定菜单项标识符。如果此参数为MF_BYPOSITION，则其他参数指定菜单项位置")]
        public static extern bool CheckMenuRadioItem(
            IntPtr hMenu,
            uint idFirst,
            uint idLast,
            uint idCheck,
            [MarshalAs(UnmanagedType.U4)]
            MenuFlags uFlags);

        /// <summary>
        /// 创建新菜单
        /// </summary>
        [DllImport(Win32.User32dll)]
        [WinApi("CreateMenu", Win32.User32dll, "HMENU CreateMenu()", "创建新菜单")]
        [ApiReturn(MarshalType.Ptr, "如果函数调用成功，返回值是新创建菜单的句柄；否则返回IntPtr.Zero")]
        public static extern IntPtr CreateMenu();

        /// <summary>
        /// 创建一个空的弹出式菜单
        /// <para />
        /// 函数原型:HMENU CreatePopupMenu();
        /// </summary>
        /// <returns>如果函数调用成功，返回值是新创建菜单的句柄；否则返回 <see cref="IntPtr.Zero"/></returns>
        [DllImport(Win32.User32dll)]
        [WinApi("CreatePopupMenu", Win32.User32dll, "HMENU CreatePopupMenu()", "创建一个空的弹出式菜单")]
        [ApiReturn(MarshalType.Ptr, "如果函数调用成功，返回值是新创建菜单的句柄；否则返回IntPtr.Zero")]
        public static extern IntPtr CreatePopupMenu();

        /// <summary>
        /// 删除指定的菜单条目
        /// </summary>
        [DllImport(Win32.User32dll)]
        [WinApi("DeleteMenu", Win32.User32dll, "BOOL DeleteMenu(HMENU hMenu, UINT uPosition, UINT uFlags)", "删除指定的菜单条目")]
        [ApiReturn(MarshalType.Bool, "")]
        [ApiParam("hMenu", MarshalType.Ptr, "菜单句柄")]
        [ApiParam("uPosition", MarshalType.UInt32, "欲删除菜单条目的标识符。如在wFlags中设置了MF_BYCOMMAND标志，这个参数就代表要改变的菜单条目的命令ID。如设置了MF_BYPOSITION标志，这个参数就代表条目在菜单中的位置（头一个条目肯定是零）")]
        [ApiParam("uFlags", MarshalType.Enum, "MF_BYPOSITION(0x400)或，具体由nPosition参数决定")]
        public static extern bool DeleteMenu(
            IntPtr hMenu,
            uint uPosition,
            [MarshalAs(UnmanagedType.U4)]
            MenuFlags uFlags);

        /// <summary>
        /// 销毁指定的菜单，并释放此菜单占用的内存
        /// </summary>
        [DllImport(Win32.User32dll)]
        [WinApi("DestroyMenu", Win32.User32dll, "BOOL DestroyMenu（HMENU hMenu）", "销毁指定的菜单，并释放此菜单占用的内存")]
        [ApiReturn(MarshalType.Bool, "")]
        [ApiParam("hMenu", MarshalType.Ptr, "要销毁的菜单的句柄")]
        public static extern bool DestroyMenu(IntPtr hMenu);

        /// <summary>
        /// 为指定的窗口重画菜单
        /// </summary>
        [DllImport(Win32.User32dll)]
        [WinApi("DrawMenuBar", Win32.User32dll, "BOOL DrawMenuBar（HWND hWnd）", "为指定的窗口重画菜单")]
        [ApiReturn(MarshalType.Bool, "")]
        [ApiParam("hWnd", MarshalType.Ptr, "其菜单条需要被重画的窗口句柄")]
        public static extern bool DrawMenuBar(IntPtr hWnd);

        /// <summary>
        /// 允许或禁止指定的菜单条目
        /// <para />
        /// 函数原型:BOOL EnableMenuItem(HMENU hMenu,UINT uIDEnableItem,UINT wEnable);
        /// </summary>
        /// <param name="hMenu">菜单句柄</param>
        /// <param name="uIDEnableItem">欲允许或禁止的一个菜单条目的标识符。如果在wEnable参数中设置了MF_BYCOMMAND标志，这个参数就代表欲改变菜单条目的命令ID。如设置的是MF_BYPOSITION，则这个参数代表菜单条目在菜单中的位置（第一个条目肯定是零）</param>
        /// <param name="wEnable">参考ModifyMenu函数中的菜单常数标志定义表，其中列出了允许使用的所有常数。对于这个函数，只能指定下述常数：MF_BYCOMMAND，MF_BYPOSITION，MF_ENABLED，MF_DISABLED以及MF_GRAYED</param>
        /// <returns></returns>
        [DllImport(Win32.User32dll)]
        [WinApi("", Win32.User32dll, "", "")]
        [ApiReturn(MarshalType.Bool, "")]
        [ApiParam("", MarshalType.Ptr, "")]
        public static extern bool EnableMenuItem(
            IntPtr hMenu,
            uint uIDEnableItem,
            [MarshalAs(UnmanagedType.U4)]
            MenuFlags wEnable);

        /// <summary>
        /// 取得窗口中一个菜单的句柄
        /// <para />
        /// 函数原型:HMENU GetMenu（HWND hWnd）；
        /// </summary>
        /// <param name="hWnd">窗口句柄</param>
        /// <returns>返回值是菜单的句柄。如果给定的窗口没有菜单，则返回 <see cref="IntPtr.Zero"/></returns>
        [DllImport(Win32.User32dll)]
        [WinApi("", Win32.User32dll, "", "")]
        [ApiReturn(MarshalType.Bool, "")]
        [ApiParam("", MarshalType.Ptr, "")]
        public static extern IntPtr GetMenu(IntPtr hWnd);

        /// <summary>
        /// 返回缺省选取标记位图的尺寸
        /// 系统在选取的菜单项旁边显示该位图。
        /// 调用SetMenultemBitmaPs为菜单项放置选取标记为图前，应用程序必须调用GetMenuCheckMarkDimensions来确定恰当的位图大小
        /// <para />
        /// 函数原型:LONG GetMenuCheckMarkDimensions（VOID）
        /// </summary>
        /// <returns>返回值指定缺省选取标记位图的高度和宽度（按像素）。高位字包含高度，低位字包含宽度</returns>
        [DllImport(Win32.User32dll)]
        [WinApi("", Win32.User32dll, "", "")]
        [ApiReturn(MarshalType.Bool, "")]
        [ApiParam("", MarshalType.Ptr, "")]
        public static extern int GetMenuCheckMarkDimensions();

        /// <summary>
        /// 取得用SetMenuContextHelpId函数分配给一个菜单的帮助场景ID
        /// <para />
        /// 函数原型:LONG GetMenuContextHelpId(HMENU hMenu);
        /// </summary>
        /// <param name="hMenu">菜单句柄</param>
        /// <returns>如果存在，就返回帮助场景ID；否则返回零</returns>
        [DllImport(Win32.User32dll)]
        [WinApi("", Win32.User32dll, "", "")]
        [ApiReturn(MarshalType.Bool, "")]
        [ApiParam("", MarshalType.Ptr, "")]
        public static extern int GetMenuContextHelpId(IntPtr hMenu);

        /// <summary>
        /// 判断菜单中的哪个条目是默认条目
        /// <para />
        /// 函数原型:UINT GetMenuDefaultItem(HMENU hMenu, UINT fByPos, UINT gmdiFlags);
        /// </summary>
        /// <param name="hMenu">要为其检索默认菜单项的菜单的句柄</param>
        /// <param name="fByPos">指示是检索菜单项的标识符还是检索其位置。 如果此参数为false，则返回标识符。 否则，返回位置</param>
        /// <param name="gmdiFlags">指示函数应如何搜索菜单项。 此参数可以是以下值的零个或多个:GMDI_GOINTOPOPUPS=0x0002L</param>
        /// <returns></returns>
        [DllImport(Win32.User32dll)]
        [WinApi("", Win32.User32dll, "", "")]
        [ApiReturn(MarshalType.Bool, "")]
        [ApiParam("", MarshalType.Ptr, "")]
        public static extern uint GetMenuDefaultItem(
            IntPtr hMenu, 
            bool fByPos, 
            uint gmdiFlags);

        /// <summary>
        ///  菜单中菜单项的数量
        /// <para />
        /// 函数原型:int GetMenuItemCount(HMENU hMenu);
        /// </summary>
        /// <param name="hMenu">菜单句柄</param>
        /// <returns>返回菜单中条目（菜单项）的数量</returns>
        [DllImport(Win32.User32dll)]
        [WinApi("", Win32.User32dll, "", "")]
        [ApiReturn(MarshalType.Bool, "")]
        [ApiParam("", MarshalType.Ptr, "")]
        public static extern int GetMenuItemCount(IntPtr hMenu);

        /// <summary>
        /// 检索位于菜单中指定位置的菜单项的菜单项标识符
        /// <para />
        /// 函数原型:UINT GetMenuItemID(HMENU hMenu,int nPos);
        /// </summary>
        /// <param name="hMenu">菜单句柄</param>
        /// <param name="nPos">要检索其标识符的菜单项的从零开始的相对位置</param>
        /// <returns>返回位于菜单中指定位置处的条目的菜单ID</returns>
        [DllImport(Win32.User32dll)]
        [WinApi("", Win32.User32dll, "", "")]
        [ApiReturn(MarshalType.Bool, "")]
        [ApiParam("", MarshalType.Ptr, "")]
        public static extern uint GetMenuItemID(IntPtr hMenu, int nPos);

        /// <summary>
        /// 取得（接收）与一个菜单条目有关的特定信息 
        /// <para />
        /// 函数原型:BOOL GetMenuItemInfo(HMENU hmenu,UINT item,BOOL fByPosition,LPMENUITEMINFO lpmii);
        /// </summary>
        /// <param name="hMenu">菜单句柄</param>
        /// <param name="item">要获取相关信息的菜单项的标识符或位置。 此参数的含义取决于 fByPosition 的值</param>
        /// <param name="fByPosition">uItem 的含义。 如果此参数为 false， 则 item 是菜单项标识符。 否则，它是菜单项位置</param>
        /// <param name="lpmii">指向 MENUITEMINFO 结构的指针，该结构指定要检索和接收有关菜单项的信息。 请注意，在调用此函数之前，必须将 cbSize 成员设置为 sizeof(MENUITEMINFO) 该成员</param>
        /// <returns></returns>
        [DllImport(Win32.User32dll)]
        [WinApi("", Win32.User32dll, "", "")]
        [ApiReturn(MarshalType.Bool, "")]
        [ApiParam("", MarshalType.Ptr, "")]
        public static extern bool GetMenuItemInfo(
            IntPtr hMenu, 
            uint item, 
            bool fByPosition, 
            IntPtr lpmii);

        /// <summary>
        /// 在一个矩形中装载指定菜单条目的屏幕坐标信息
        /// <para />
        /// 函数原型:BOOL GetMenuItemRect(HWND hWnd,HMENU hMenu,UINT uItem,LPRECT lprcItem);
        /// </summary>
        /// <param name="hWnd">包含菜单的窗口的句柄。如果此值为 NULL ， 并且 hMenu 参数表示弹出菜单，则该函数将找到菜单窗口</param>
        /// <param name="hMenu">菜单的句柄</param>
        /// <param name="uItem">菜单项的从零开始的位置</param>
        /// <param name="lprcItem">指向 RECT 结构的指针，该结构接收以屏幕坐标表示的指定菜单项的边界矩形</param>
        /// <returns></returns>
        [DllImport(Win32.User32dll)]
        [WinApi("", Win32.User32dll, "", "")]
        [ApiReturn(MarshalType.Bool, "")]
        [ApiParam("", MarshalType.Ptr, "")]
        public static extern bool GetMenuItemRect(
            IntPtr hWnd,
            IntPtr hMenu, 
            uint uItem, 
            IntPtr lprcItem);

        /// <summary>
        /// 取得与指定菜单条目状态有关的信息
        /// <para />
        /// 函数原型:UINT GetMenuState(HMENU hMenu,UINT uId,UINT uFlags);
        /// </summary>
        /// <param name="hMenu">包含要检索其标志的菜单项的菜单的句柄</param>
        /// <param name="uId">要检索菜单标志的菜单项，由 uFlags 参数确定</param>
        /// <param name="uFlags">指示 如何解释 uId 参数。 此参数的取值可为下列值之一:MF_BYCOMMAND, MF_BYPOSITION</param>
        /// <returns>如果指定的项不存在，则返回值为 -1。如果菜单项打开一个子菜单，则返回值的低序字节包含与该项关联的菜单标志，而高顺序字节包含项目打开的子菜单中的项数。否则，返回值为菜单标志 (按位或) 掩码</returns>
        [DllImport(Win32.User32dll)]
        [WinApi("", Win32.User32dll, "", "")]
        [ApiReturn(MarshalType.Bool, "")]
        [ApiParam("", MarshalType.Ptr, "")]
        public static extern uint GetMenuState(
            IntPtr hMenu, 
            uint uId,
            [MarshalAs(UnmanagedType.U4)]
            MenuFlags uFlags);

        /// <summary>
        /// 取得指定菜单条目的字串
        /// <para />
        /// 函数原型:int GetMenuStringA(HMENU hMenu,UINT uIDItem,LPSTR lpString,int cchMax,UINT flags);
        /// </summary>
        /// <param name="hMenu">菜单的句柄</param>
        /// <param name="uIDItem">要更改的菜单项，由 uFlag 参数确定</param>
        /// <param name="lpString">接收 null 终止字符串的缓冲区。 如果字符串长或长于 lpString，则会截断字符串，并添加终止 null 字符。 如果 lpString 为 NULL，则该函数将返回菜单字符串的长度</param>
        /// <param name="cchMax">要复制的字符串的最大长度（以字符为单位）。 如果字符串的长度超过 nMaxCount 参数中指定的最大值，则会截断额外的字符。 如果 nMaxCount 为 0，则函数返回菜单字符串的长度</param>
        /// <param name="flags">指示 如何解释 uIDItem 参数。 此参数必须是下列值之一:MF_BYCOMMAND, MF_BYPOSITION</param>
        /// <returns>如果函数成功，则返回值将指定复制到缓冲区的字符数，不包括终止 null 字符。如果函数失败，则返回值为零。</returns>
        [DllImport(Win32.User32dll)]
        [WinApi("", Win32.User32dll, "", "")]
        [ApiReturn(MarshalType.Bool, "")]
        [ApiParam("", MarshalType.Ptr, "")]
        public static extern int GetMenuString(
            IntPtr hMenu, 
            uint uIDItem, 
            IntPtr lpString, 
            int cchMax,
            [MarshalAs(UnmanagedType.U4)]
            MenuFlags flags);

        /// <summary>
        /// 取得一个弹出式菜单的句柄，它位于菜单中指定的位置
        /// <para />
        /// 函数原型:HMENU GetSubMenu(HMENU hMenu,int nPos);
        /// </summary>
        /// <param name="hMenu">菜单的句柄</param>
        /// <param name="nPos">激活下拉菜单或子菜单的项的指定菜单中的从零开始的相对位置</param>
        /// <returns>如果函数成功，则返回值是菜单项激活的下拉菜单或子菜单的句柄。如果菜单项未激活下拉菜单或子菜单，则返回值为 <see cref="IntPtr.Zero"/></returns>
        [DllImport(Win32.User32dll)]
        [WinApi("", Win32.User32dll, "", "")]
        [ApiReturn(MarshalType.Bool, "")]
        [ApiParam("", MarshalType.Ptr, "")]
        public static extern IntPtr GetSubMenu(IntPtr hMenu, int nPos);

        /// <summary>
        /// 取得指定窗口的系统菜单的句柄
        /// <para />
        /// 函数原型:HMENU GetSystemMenu(HWND hWnd,BOOL bRevert);
        /// </summary>
        /// <param name="hWnd">将拥有窗口菜单副本的窗口的句柄</param>
        /// <param name="bRevert">要执行的操作。 如果此参数为 FALSE， GetSystemMenu 将返回当前正在使用的窗口菜单副本的句柄。 副本最初与窗口菜单相同，但可以对其进行修改。 如果此参数为 TRUE， GetSystemMenu 会将窗口菜单重置回默认状态。 上一个窗口菜单（如果有）将被销毁</param>
        /// <returns>如果 bRevert 参数为 FALSE，则返回值是窗口菜单副本的句柄。 如果 bRevert 参数为 TRUE，则返回值为 <see cref="IntPtr.Zero"/></returns>
        [DllImport(Win32.User32dll)]
        [WinApi("", Win32.User32dll, "", "")]
        [ApiReturn(MarshalType.Bool, "")]
        [ApiParam("", MarshalType.Ptr, "")]
        public static extern IntPtr GetSystemMenu(IntPtr hWnd,bool bRevert);

        /// <summary>
        /// 在菜单栏中的项中添加或删除突出显示
        /// <para />
        /// 函数原型:BOOL HiliteMenuItem(HWND hWnd,HMENU hMenu,UINT uIDHiliteItem,UINT uHilite);
        /// </summary>
        /// <param name="hWnd">包含菜单的窗口的句柄</param>
        /// <param name="hMenu">包含项的菜单栏的句柄</param>
        /// <param name="uIDHiliteItem">菜单项。 此参数是菜单项的标识符或菜单栏中菜单项的偏移量，具体取决于 uHilite 参数的值</param>
        /// <param name="uHilite">控制 uItemHilite 参数的解释，并指示是否突出显示菜单项。 此参数必须是MF_BYCOMMAND或MF_BYPOSITION和MF_HILITE或MF_UNHILITE的组合</param>
        /// <returns>如果菜单项设置为指定的突出显示状态，则返回值为非零。如果未将菜单项设置为指定的突出显示状态，则返回值为零</returns>
        [DllImport(Win32.User32dll)]
        [WinApi("", Win32.User32dll, "", "")]
        [ApiReturn(MarshalType.Bool, "")]
        [ApiParam("", MarshalType.Ptr, "")]
        public static extern bool HiliteMenuItem(
            IntPtr hWnd, 
            IntPtr hMenu, 
            uint uIDHiliteItem,
            [MarshalAs(UnmanagedType.U4)]
            MenuFlags uHilite);

        /// <summary>
        /// 在菜单的指定位置处插入一个菜单条目，并根据需要将其他条目向下移动 
        /// <para />
        /// 函数原型:BOOL InsertMenu(HMENU hMenu,UINT uPosition,UINT uFlags,UINT uIDNewltem,LPCTSTR lpNewltem);
        /// </summary>
        /// <param name="hMenu">将被修改的菜单的句柄</param>
        /// <param name="uPosition">指定新菜单项将被插入其前面的菜单项，其含义由参数uFlagS决定</param>
        /// <param name="uFlags">指定控制参数uPosition的解释的标志、新菜单项的内容、外观和性能</param>
        /// <param name="uIDNewltem">指定新菜单项的标识符，或者当参数uFlags设置为MF_POPUP时，指定下拉式菜单或子菜单的句柄</param>
        /// <param name="lpNewltem">指定新菜单项的内容。其含义依赖于参数UFlags是否包含标志MF_BITMAP,MF_OWNERDRAW或MF_STRING</param>
        /// <returns></returns>
        [DllImport(Win32.User32dll)]
        [WinApi("", Win32.User32dll, "", "")]
        [ApiReturn(MarshalType.Bool, "")]
        [ApiParam("", MarshalType.Ptr, "")]
        public static extern bool InsertMenu(
            IntPtr hMenu, 
            uint uPosition,
            [MarshalAs(UnmanagedType.U4)]
            MenuFlags uFlags,
            uint uIDNewltem,
            [MarshalAs(UnmanagedType.LPStr)]
            string lpNewltem);

        /// <summary>
        /// 插入一个新菜单条目
        /// <para />
        /// 函数原型:BOOL InsertMenuItem(HMENU hmenu, UINT item, BOOL fByPosition, LPCMENUITEMINFO lpmi);
        /// </summary>
        /// <param name="hMenu">插入新菜单项的菜单句柄</param>
        /// <param name="item">在其之前插入新项目的菜单项的标识符或位置。此参数的含义取决于fByPosition的值</param>
        /// <param name="fByPosition">控制uItem的含义。如果此参数为FALSE，则uItem是菜单项标识符。否则，它是菜单项的位置</param>
        /// <param name="lpmi">指向MENUITEMINFO结构的指针，该结构包含有关新菜单项的信息</param>
        /// <returns></returns>
        [DllImport(Win32.User32dll)]
        [WinApi("", Win32.User32dll, "", "")]
        [ApiReturn(MarshalType.Bool, "")]
        [ApiParam("", MarshalType.Ptr, "")]
        public static extern bool InsertMenuItem(
            IntPtr hMenu, 
            uint item, 
            bool fByPosition, 
            IntPtr lpmi);

        /// <summary>
        /// 判断指定的句柄是否为一个菜单的句柄
        /// <para />
        /// 函数原型:BOOL lsMenu（HMENU hMenu）；
        /// </summary>
        /// <param name="hMenu">菜单的句柄</param>
        /// <returns>如果hMenu是一个菜单句柄，返回true</returns>
        [DllImport(Win32.User32dll)]
        [WinApi("", Win32.User32dll, "", "")]
        [ApiReturn(MarshalType.Bool, "")]
        [ApiParam("", MarshalType.Ptr, "")]
        public static extern bool IsMenu(IntPtr hMenu);

        /// <summary>
        /// 从指定的模块或应用程序实例中载入一个菜单 
        /// <para />
        /// 函数原型:HMENU LoadMenu（HINSTANCE hlnstance，LPCTSTR lpMenuName）；
        /// </summary>
        /// <param name="hlnstance">含有被加载菜单资源的实例模块的句柄。若此参数为NULL，则从当前实例中加载菜单</param>
        /// <param name="lpMenuName">指向含有菜单资源名的以空结束的字符串的指针。同时，此参数可由低位字上的资源标识符和高位字上的零组成。要创建此值，用MAKEINTRESOURCE宏。注意，菜单ID（所有资源ID类同）也可以直接由字符串构造，如ID值为"IDM_MYMENU"(ID值含引号）</param>
        /// <returns>如果函数调用成功，返回值是菜单资源句柄；如果函数调用失败，返回值是 <see cref="IntPtr.Zero"/></returns>
        [DllImport(Win32.User32dll)]
        [WinApi("", Win32.User32dll, "", "")]
        [ApiReturn(MarshalType.Bool, "")]
        [ApiParam("", MarshalType.Ptr, "")]
        public static extern IntPtr LoadMenu(
            IntPtr hlnstance,
            [MarshalAs(UnmanagedType.LPStr)]
            string lpMenuName);

        /// <summary>
        /// 判断哪个菜单条目包含了屏幕上一个指定的点 
        /// <para />
        /// 函数原型:int MenuItemFromPoint(HWND  hWnd,HMENU hMenu,POINT ptScreen);
        /// </summary>
        /// <param name="hWnd">包含菜单的窗口的句柄。 如果此值为 NULL ， 并且 hMenu 参数表示弹出菜单，则该函数将找到菜单窗口</param>
        /// <param name="hMenu">包含要命中测试的菜单项的菜单的句柄</param>
        /// <param name="ptScreen">指定要测试的位置的结构。 如果 hMenu 指定菜单栏，则此参数位于窗口坐标中。 否则，它位于客户端坐标中</param>
        /// <returns>返回菜单项在指定位置的从零开始的位置;如果没有菜单项位于指定位置，则返回 -1</returns>
        [DllImport(Win32.User32dll)]
        [WinApi("", Win32.User32dll, "", "")]
        [ApiReturn(MarshalType.Bool, "")]
        [ApiParam("", MarshalType.Ptr, "")]
        public static extern int MenuItemFromPoint(
            IntPtr hWnd, 
            IntPtr hMenu, 
            IntPtr ptScreen);

        /// <summary>
        /// 改变菜单条目
        /// <para />
        /// 函数原型:BOOL ModifyMenu(HMENU hMnu,UINT uPosition,UINT uFlags,UINT uIDNewltem,LPCTSTR IpNewltem);
        /// </summary>
        /// <param name="hMenu">将被修改的菜单的句柄</param>
        /// <param name="uPosition">指定将被修改的菜单项，其含义由参数UFlags决定</param>
        /// <param name="uFlags">指定控制参数uPosition的解释的标志、菜单项的内容、外观和性能</param>
        /// <param name="uIDNewltem">指定被修改菜单项的标识符，或者当参数uFlags设置为MF_POPUP时，指定下拉式菜单或子菜单的句柄</param>
        /// <param name="IpNewltem">指定被修改菜单项的内容。其含义依赖于参数UFlags是否包含标志MF_BITMAP,MF_OWNERDRAW或MF_STRING</param>
        /// <returns></returns>
        [DllImport(Win32.User32dll)]
        [WinApi("", Win32.User32dll, "", "")]
        [ApiReturn(MarshalType.Bool, "")]
        [ApiParam("", MarshalType.Ptr, "")]
        public static extern bool ModifyMenu(
            IntPtr hMenu, 
            uint uPosition,
            [MarshalAs(UnmanagedType.U4)]
            MenuFlags uFlags, 
            uint uIDNewltem,
            [MarshalAs(UnmanagedType.LPStr)]
            string IpNewltem);

        /// <summary>
        /// 删除指定的菜单条目
        /// <para />
        /// 函数原型:BOOL RemoveMenu (HMENU hMen,UINT uPosition,UINT uFlags);
        /// </summary>
        /// <param name="hMenu">将被修改的菜单的句柄</param>
        /// <param name="uPosition">指定将被删除的菜单项，其含义由参数uFlags决定</param>
        /// <param name="uFlags">指定参数uPosition如何解释</param>
        /// <returns></returns>
        [DllImport(Win32.User32dll)]
        [WinApi("", Win32.User32dll, "", "")]
        [ApiReturn(MarshalType.Bool, "")]
        [ApiParam("", MarshalType.Ptr, "")]
        public static extern bool RemoveMenu(
            IntPtr hMenu,
            uint uPosition,
            [MarshalAs(UnmanagedType.U4)]
            MenuFlags uFlags);

        /// <summary>
        /// 设置窗口菜单
        /// <para />
        /// 函数原型:BOOL SetMenu（HWND hWnd，HMENU hMenu）；
        /// </summary>
        /// <param name="hWnd">菜单被分配到其中的窗口的句柄</param>
        /// <param name="hMenu">新菜单的句柄。如果菜单参数为NULL，则窗口的当前菜单被删除</param>
        /// <returns></returns>
        [DllImport(Win32.User32dll)]
        [WinApi("", Win32.User32dll, "", "")]
        [ApiReturn(MarshalType.Bool, "")]
        [ApiParam("", MarshalType.Ptr, "")]
        public static extern bool SetMenu(IntPtr hWnd, IntPtr hMenu);

        /// <summary>
        /// 将一个菜单条目设为默认条目
        /// <para />
        /// 函数原型:BOOL SetMenuDefaultItem(HMENU hMenu,UINT  uItem,UINT  fByPos);
        /// </summary>
        /// <param name="hMenu">要为其设置默认项的菜单句柄</param>
        /// <param name="uItem">没有默认项的新默认菜单项的标识符或位置，或 -1。 此参数的含义取决于 fByPos 的值</param>
        /// <param name="fByPos">如果此参数为 false， 则 uItem 是菜单项标识符。 否则，它是菜单项位置</param>
        /// <returns></returns>
        [DllImport(Win32.User32dll)]
        [WinApi("", Win32.User32dll, "", "")]
        [ApiReturn(MarshalType.Bool, "")]
        [ApiParam("", MarshalType.Ptr, "")]
        public static extern bool SetMenuDefaultItem(
            IntPtr hMenu, 
            uint uItem, 
            bool fByPos);

        /// <summary>
        /// 设置一幅特定位图，令其在指定的菜单条目中使用，代替标准的复选符号（√）
        /// <para />
        /// 函数原型:BOOL SetMenuItemBitmaps(HMENU hMenu,UINT uPosition,UINT uFlags,HBITMAP hBitmapUnchecked,HBITMAP hBitmapChecked);
        /// </summary>
        /// <param name="hMenu">包含要接收新复选标记位图的项的菜单的句柄</param>
        /// <param name="uPosition">要更改的菜单项，由 uFlags 参数确定</param>
        /// <param name="uFlags">指定 如何解释 uPosition 参数</param>
        /// <param name="hBitmapUnchecked">未选择菜单项时显示的位图句柄</param>
        /// <param name="hBitmapChecked">选择菜单项时显示的位图的句柄</param>
        /// <returns></returns>
        [DllImport(Win32.User32dll)]
        [WinApi("", Win32.User32dll, "", "")]
        [ApiReturn(MarshalType.Bool, "")]
        [ApiParam("", MarshalType.Ptr, "")]
        public static extern bool SetMenuItemBitmaps(
            IntPtr hMenu, 
            uint uPosition,
            [MarshalAs(UnmanagedType.U4)]
            MenuFlags uFlags, 
            IntPtr hBitmapUnchecked, 
            IntPtr hBitmapChecked);

        /// <summary>
        /// 为一个菜单条目设置指定的信息
        /// <para />
        /// 函数原型:BOOL SetMenultemlnfo（HMENU hMenu，UINT uitem，BOOL fByPosition，LPMENUITEMINFO lpmii）;
        /// </summary>
        /// <param name="hMenu">包含菜单项的菜单的句柄</param>
        /// <param name="uitem">将被修改的菜单项的标识符或位置。此参数的含义由参数fByPosition确定</param>
        /// <param name="fByPosition">用于指定参数ultem的含义的值。如果此参数值为false，则参数ultem是菜单项的标识符，否则，表示菜单项的位置</param>
        /// <param name="lpmii">指向结构MENUITEMINFO的指针。该结构含有菜单项的信息，并且．指定将被修改的菜单项的属性</param>
        /// <returns></returns>
        [DllImport(Win32.User32dll)]
        [WinApi("", Win32.User32dll, "", "")]
        [ApiReturn(MarshalType.Bool, "")]
        [ApiParam("", MarshalType.Ptr, "")]
        public static extern bool SetMenuItemInfo(
            IntPtr hMenu, 
            uint uitem,
            bool fByPosition,
            IntPtr lpmii);

        /// <summary>
        /// 在屏幕的任意地方显示一个弹出式菜单
        /// <para />
        /// 函数原型:BOOL TrackPopupMenu(HMENU hMenu,UINT uFlags,int x,int y,int nReserved,HWND hWnd,const RECT *prcRect);
        /// </summary>
        /// <param name="hMenu">要显示的快捷菜单的句柄。 可以通过调用 CreatePopupMenu 来创建新的快捷菜单，或通过调用 GetSubMenu 检索与现有菜单项关联的子菜单的句柄来获取句柄</param>
        /// <param name="uFlags">使用更多这些标志中的零来指定函数选项</param>
        /// <param name="x">快捷菜单的水平位置，以屏幕坐标为单位</param>
        /// <param name="y">快捷菜单的垂直位置，以屏幕坐标为单位</param>
        /// <param name="nReserved">保留;必须为零</param>
        /// <param name="hWnd">拥有快捷菜单的窗口的句柄。 此窗口从菜单中接收所有消息。 在函数返回之前，该窗口不会从菜单中收到 WM_COMMAND 消息。 如果在 uFlags 参数中指定TPM_NONOTIFY，函数不会将消息发送到 hWnd 标识的窗口。 但是，仍必须在 hWnd 中传递窗口句柄。 它可以是应用程序的任何窗口句柄</param>
        /// <param name="prcRect">已忽略</param>
        /// <returns></returns>
        [DllImport(Win32.User32dll)]
        [WinApi("", Win32.User32dll, "", "")]
        [ApiReturn(MarshalType.Bool, "")]
        [ApiParam("", MarshalType.Ptr, "")]
        public static extern bool TrackPopupMenu(
            IntPtr hMenu,
            [MarshalAs(UnmanagedType.U4)]
            MenuFlags uFlags, 
            int x, 
            int y, 
            int nReserved, 
            IntPtr hWnd,
            IntPtr prcRect);

        /// <summary>
        /// 与TrackPopupMenu相似，只是它提供了额外的功能
        /// <para />
        /// 函数原型:BOOL TrackPopupMenu(HMENU hMenu,UINT uFlags,int x,int y,int nReserved,HWND hWnd,LPTPMPARAMS lptpm);
        /// </summary>
        /// <param name="hMenu">要显示的快捷菜单的句柄。 可以通过调用 CreatePopupMenu 来创建新的快捷菜单，或通过调用 GetSubMenu 检索与现有菜单项关联的子菜单的句柄来获取句柄</param>
        /// <param name="uFlags">使用更多这些标志中的零来指定函数选项</param>
        /// <param name="x">快捷菜单的水平位置，以屏幕坐标为单位</param>
        /// <param name="y">快捷菜单的垂直位置，以屏幕坐标为单位</param>
        /// <param name="nReserved">保留;必须为零</param>
        /// <param name="hWnd">拥有快捷菜单的窗口的句柄。 此窗口从菜单中接收所有消息。 在函数返回之前，该窗口不会从菜单中收到 WM_COMMAND 消息。 如果在 uFlags 参数中指定TPM_NONOTIFY，函数不会将消息发送到 hWnd 标识的窗口。 但是，仍必须在 hWnd 中传递窗口句柄。 它可以是应用程序的任何窗口句柄</param>
        /// <param name="lptpm">指向 TPMPARAMS 结构的指针，该结构指定菜单不应重叠的屏幕区域。 此参数可以为 NULL</param>
        /// <returns></returns>
        [DllImport(Win32.User32dll)]
        [WinApi("", Win32.User32dll, "", "")]
        [ApiReturn(MarshalType.Bool, "")]
        [ApiParam("", MarshalType.Ptr, "")]
        public static extern bool TrackPopupMenuEx(
            IntPtr hMenu,
            [MarshalAs(UnmanagedType.U4)]
            MenuFlags uFlags, 
            int x, 
            int y, 
            int nReserved, 
            IntPtr hWnd,
            IntPtr lptpm);
    }
}
