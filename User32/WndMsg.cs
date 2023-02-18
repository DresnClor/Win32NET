using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Win32NET.User32
{
    /// <summary>
    /// 窗体消息值
    /// WM_*
    /// </summary>
    [Flags]
    public enum WndMsg : uint
    {
        /// <summary>
        /// 空消息
        /// </summary>
        Null = 0X0000,
        /// <summary>
        /// 创建窗口
        /// </summary>
        Create = 0X0001,
        /// <summary>
        /// 窗口被销毁
        /// </summary>
        Destroy = 0X0002,
        /// <summary>
        ///移动窗口 
        /// </summary>
        Move = 0X0003,
        /// <summary>
        /// 改变窗口的大小
        /// </summary>
        Size = 0X0005,
        /// <summary>
        /// 窗口被激活或失去激活状态
        /// </summary>
        Activate = 0X0006,
        /// <summary>
        /// 获得焦点后
        /// </summary>
        SetFocus = 0X0007,
        /// <summary>
        /// 失去焦点
        /// </summary>
        KillFocus = 0X0008,
        /// <summary>
        /// 改变enable状态
        /// </summary>
        Enable = 0X000A,
        /// <summary>
        /// 设置窗口是否能重画
        /// </summary>
        SetRedraw = 0X0000B,
        /// <summary>
        /// 设置一个窗口的文本
        /// </summary>
        SetText = 0X0000C,
        /// <summary>
        /// 复制对应窗口的文本到缓冲区
        /// </summary>
        GetText = 0X0000D,
        /// <summary>
        /// 得到与一个窗口有关的文本的长度（不包含空字符）
        /// </summary>
        GetTextLength = 0X0000E,
        /// <summary>
        /// 窗口重画
        /// </summary>
        Paint = 0X0000F,
        /// <summary>
        /// 当一个窗口或应用程序要关闭时发送一个信号
        /// </summary>
        Close = 0X00010,
        /// <summary>
        /// 当用户选择结束对话框或程序自己调用 ExitWindows 函数
        /// </summary>
        QueryEndSessioN = 0X00011,
        /// <summary>
        /// 用来结束程序运行或当程序调用 postquitmessage 函数
        /// </summary>
        Quit = 0X00012,
        /// <summary>
        /// 当用户窗口恢复以前的大小位置时，把此消息发送给某个图标
        /// </summary>
        QueryOpen = 0X00013,
        /// <summary>
        /// 当窗口背景必须被擦除时（例在窗口改变大小时）
        /// </summary>
        EraseBkgnd = 0X00014,
        /// <summary>
        /// 当系统颜色改变时，发送此消息给所有顶级窗口
        /// </summary>
        SysColorChange = 0X00015,
        /// <summary>
        /// 当系统进程发出WM_QUERYENDSESSION 消息后，此消息发送给应用程序，通知它对话是否结束
        /// </summary>
        EndSession = 0X00016,
        /// <summary>
        /// 
        /// </summary>
        SystemError = 0X00017,
        /// <summary>
        /// 当隐藏或显示窗口时发送此消息给这个窗口
        /// </summary>
        ShowWindow = 0X00018,
        /// <summary>
        /// 发此消息给应用程序哪个窗口是激活的，哪个是非激活的；
        /// </summary>
        ActivateApp = 0X0001C,
        /// <summary>
        /// 当系统的字体资源库变化时发送此消息给所有顶级窗口
        /// </summary>
        FontChange = 0X0001D,
        /// <summary>
        /// 当系统的时间变化时发送此消息给所有顶级窗口
        /// </summary>
        TimeChange = 0X0001E,
        /// <summary>
        /// 发送此消息来取消某种正在进行的摸态（操作）
        /// </summary>
        CancelMode = 0X0001F,
        /// <summary>
        /// 如果鼠标引起光标在某个窗口中移动且鼠标输入没有被捕获时，就发消息给某个窗口
        /// </summary>
        SetCursor = 0X00020,
        /*
        WM_MOUSEACTIVATE = $0021;
        当光标在某个非激活的窗口中而用户正按着鼠标的某个键发送此消息给当前窗口
WM_CHILDACTIVATE = $0022;
        发送此消息给MDI 子窗口当用户点击此窗口的标题栏，或当窗口被激活，移动，
改变大小
WM_QUEUESYNC = $0023;
        此消息由基于计算机的训练程序发送，通过WH_JOURNALPALYBACK 的hook
程序
分离出用户输入消息
WM_GETMINMAXINFO = $0024;
        此消息发送给窗口当它将要改变大小或位置；
WM_PAINTICON = $0026;
        发送给最小化窗口当它图标将要被重画
WM_ICONERASEBKGND = $0027;
        此消息发送给某个最小化窗口，仅当它在画图标前它的背景必须被重画
WM_NEXTDLGCTL = $0028;
        发送此消息给一个对话框程序去更改焦点位置
WM_SPOOLERSTATUS = $002A;
        每当打印管理列队增加或减少一条作业时发出此消息
WM_DRAWITEM = $002B;
        当button，combobox，listbox，menu 的可视外观改变时发送
此消息给这些空件的所有者
WM_MEASUREITEM = $002C;
        当button, combo box, list box, list view control, or menu item 被创建时
发送此消息给控件的所有者
WM_DELETEITEM = $002D;
        当the list box 或 combo box 被销毁 或 当 某些项被删除通过LB_DELETESTRING,
        LB_RESETCONTENT, CB_DELETESTRING, or CB_RESETCONTENT 消息
WM_VKEYTOITEM = $002E;
        此消息有一个LBS_WANTKEYBOARDINPUT 风格的发出给它的所有者来响应
WM_KEYDOWN 消息
WM_CHARTOITEM = $002F;
        此消息由一个LBS_WANTKEYBOARDINPUT 风格的列表框发送给他的所有者来
响应WM_CHAR 消息
WM_SETFONT = $0030;
        当绘制文本时程序发送此消息得到控件要用的颜色
WM_GETFONT = $0031;
        应用程序发送此消息得到当前控件绘制文本的字体
WM_SETHOTKEY = $0032;
        应用程序发送此消息让一个窗口与一个热键相关连
WM_GETHOTKEY = $0033;
        应用程序发送此消息来判断热键与某个窗口是否有关联
WM_QUERYDRAGICON = $0037;
        此消息发送给最小化窗口，当此窗口将要被拖放而它的类中没有定义图标，应用程
序能返回一个图标或光标的句柄，当用户拖放图标时系统显示这个图标或光标
WM_COMPAREITEM = $0039;
        发送此消息来判定combobox 或listbox 新增加的项的相对位置
WM_GETOBJECT = $003D;
        WM_COMPACTING = $0041;
        显示内存已经很少了
WM_WINDOWPOSCHANGING = $0046;
        发送此消息给那个窗口的大小和位置将要被改变时，来调用setwindowpos 函数或
其它窗口管理函数
WM_WINDOWPOSCHANGED = $0047;
        发送此消息给那个窗口的大小和位置已经被改变时，来调用setwindowpos 函数或
其它窗口管理函数
WM_POWER = $0048;（适用于16 位的windows）
当系统将要进入暂停状态时发送此消息
WM_COPYDATA = $004A;
        当一个应用程序传递数据给另一个应用程序时发送此消息
WM_CANCELJOURNAL = $004B;
        当某个用户取消程序日志激活状态，提交此消息给程序
WM_NOTIFY = $004E;
        当某个控件的某个事件已经发生或这个控件需要得到一些信息时，发送此消息给它
的父窗口
WM_INPUTLANGCHANGEREQUEST = $0050;
        当用户选择某种输入语言，或输入语言的热键改变
WM_INPUTLANGCHANGE = $0051;
        当平台现场已经被改变后发送此消息给受影响的最顶级窗口
WM_TCARD = $0052;
        当程序已经初始化windows 帮助例程时发送此消息给应用程序
WM_HELP = $0053;
        此消息显示用户按下了F1，如果某个菜单是激活的，就发送此消息个此窗口关联
的菜单，否则就
发送给有焦点的窗口，如果当前都没有焦点，就把此消息发送给当前激活的窗口
WM_USERCHANGED = $0054;
        当用户已经登入或退出后发送此消息给所有的窗口，当用户登入或退出时系统更新
用户的具体
设置信息，在用户更新设置时系统马上发送此消息；
WM_NOTIFYFORMAT = $0055;
        公用控件，自定义控件和他们的父窗口通过此消息来判断控件是使用ANSI 还是
UNICODE 结构
在WM_NOTIFY 消息，使用此控件能使某个控件与它的父控件之间进行相互通信
WM_CONTEXTMENU = $007B;
        当用户某个窗口中点击了一下右键就发送此消息给这个窗口
WM_STYLECHANGING = $007C;
        当调用SETWINDOWLONG 函数将要改变一个或多个 窗口的风格时发送此消息给
那个窗口
WM_STYLECHANGED = $007D;
        当调用SETWINDOWLONG 函数一个或多个 窗口的风格后发送此消息给那个窗口
WM_DISPLAYCHANGE = $007E;
        当显示器的分辨率改变后发送此消息给所有的窗口
WM_GETICON = $007F;
        此消息发送给某个窗口来返回与某个窗口有关连的大图标或小图标的句柄；
WM_SETICON = $0080;
        程序发送此消息让一个新的大图标或小图标与某个窗口关联；
WM_NCCREATE = $0081;
        当某个窗口第一次被创建时，此消息在WM_CREATE 消息发送前发送；
WM_NCDESTROY = $0082;
        此消息通知某个窗口，非客户区正在销毁
WM_NCCALCSIZE = $0083;
        当某个窗口的客户区域必须被核算时发送此消息
WM_NCHITTEST = $0084;//移动鼠标，按住或释放鼠标时发生
        WM_NCPAINT = $0085;
        程序发送此消息给某个窗口当它（窗口）的框架必须被绘制时；
WM_NCACTIVATE = $0086;
        此消息发送给某个窗口 仅当它的非客户区需要被改变来显示是激活还是非激活状
态；
WM_GETDLGCODE = $0087;
        发送此消息给某个与对话框程序关联的控件，widdows 控制方位键和TAB 键使输
入进入此控件
通过响应WM_GETDLGCODE 消息，应用程序可以把他当成一个特殊的输入控件
并能处理它
WM_NCMOUSEMOVE = $00A0;
        当光标在一个窗口的非客户区内移动时发送此消息给这个窗口 //非客户区为：窗体
的标题栏及窗
的边框体
WM_NCLBUTTONDOWN = $00A1;
        当光标在一个窗口的非客户区同时按下鼠标左键时提交此消息
WM_NCLBUTTONUP = $00A2;
        当用户释放鼠标左键同时光标某个窗口在非客户区十发送此消息；
WM_NCLBUTTONDBLCLK = $00A3;
        当用户双击鼠标左键同时光标某个窗口在非客户区十发送此消息
WM_NCRBUTTONDOWN = $00A4;
        当用户按下鼠标右键同时光标又在窗口的非客户区时发送此消息
WM_NCRBUTTONUP = $00A5;
        当用户释放鼠标右键同时光标又在窗口的非客户区时发送此消息
WM_NCRBUTTONDBLCLK = $00A6;
        当用户双击鼠标右键同时光标某个窗口在非客户区十发送此消息
WM_NCMBUTTONDOWN = $00A7;
        当用户按下鼠标中键同时光标又在窗口的非客户区时发送此消息
WM_NCMBUTTONUP = $00A8;
        当用户释放鼠标中键同时光标又在窗口的非客户区时发送此消息
WM_NCMBUTTONDBLCLK = $00A9;
        当用户双击鼠标中键同时光标又在窗口的非客户区时发送此消息
WM_KEYFIRST = $0100;
        WM_KEYDOWN = $0100;
        //按下一个键
        WM_KEYUP = $0101;
        //释放一个键
        WM_CHAR = $0102;
        //按下某键，并已发出WM_KEYDOWN， WM_KEYUP 消息
        WM_DEADCHAR = $0103;
        当用translatemessage 函数翻译WM_KEYUP 消息时发送此消息给拥有焦点的窗口
WM_SYSKEYDOWN = $0104;
        当用户按住ALT 键同时按下其它键时提交此消息给拥有焦点的窗口；
WM_SYSKEYUP = $0105;
        当用户释放一个键同时ALT 键还按着时提交此消息给拥有焦点的窗口
WM_SYSCHAR = $0106;
        当WM_SYSKEYDOWN 消息被TRANSLATEMESSAGE 函数翻译后提交此消息给
拥有焦点的窗口
WM_SYSDEADCHAR = $0107;
        当WM_SYSKEYDOWN 消息被TRANSLATEMESSAGE 函数翻译后发送此消息给
拥有焦点的窗口
WM_KEYLAST = $0108;
        WM_INITDIALOG = $0110;
        在一个对话框程序被显示前发送此消息给它，通常用此消息初始化控件和执行其它
任务
WM_COMMAND = $0111;
        当用户选择一条菜单命令项或当某个控件发送一条消息给它的父窗口，一个快捷键
被翻译
WM_SYSCOMMAND = $0112;
        当用户选择窗口菜单的一条命令或当用户选择最大化或最小化时那个窗口会收到此
消息
WM_TIMER = $0113; //发生了定时器事件
        WM_HSCROLL = $0114;
        当一个窗口标准水平滚动条产生一个滚动事件时发送此消息给那个窗口，也发送给
拥有它的控件
WM_VSCROLL = $0115;
        当一个窗口标准垂直滚动条产生一个滚动事件时发送此消息给那个窗口也，发送给
拥有它的控件 WM_INITMENU = $0116;
        当一个菜单将要被激活时发送此消息，它发生在用户菜单条中的某项或按下某个菜
单键，它允许程序在显示前更改菜单
WM_INITMENUPOPUP = $0117;
        当一个下拉菜单或子菜单将要被激活时发送此消息，它允许程序在它显示前更改菜
单，而不要改变全部
WM_MENUSELECT = $011F;
        当用户选择一条菜单项时发送此消息给菜单的所有者（一般是窗口）
WM_MENUCHAR = $0120;
        当菜单已被激活用户按下了某个键（不同于加速键），发送此消息给菜单的所有
者；
WM_ENTERIDLE = $0121;
        当一个模态对话框或菜单进入空载状态时发送此消息给它的所有者，一个模态对话
框或菜单进入空载状态就是在处理完一条或几条先前的消息后没有消息它的列队中
等待
WM_MENURBUTTONUP = $0122;
        WM_MENUDRAG = $0123;
        WM_MENUGETOBJECT = $0124;
        WM_UNINITMENUPOPUP = $0125;
        WM_MENUCOMMAND = $0126;
        WM_CHANGEUISTATE = $0127;
        WM_UPDATEUISTATE = $0128;
        WM_QUERYUISTATE = $0129;
        WM_CTLCOLORMSGBOX = $0132;
        在windows 绘制消息框前发送此消息给消息框的所有者窗口，通过响应这条消
息，所有者窗口可以通过使用给定的相关显示设备的句柄来设置消息框的文本和背
景颜色
WM_CTLCOLOREDIT = $0133;
        当一个编辑型控件将要被绘制时发送此消息给它的父窗口；通过响应这条消息，所
有者窗口可以通过使用给定的相关显示设备的句柄来设置编辑框的文本和背景颜色
WM_CTLCOLORLISTBOX = $0134;
        当一个列表框控件将要被绘制前发送此消息给它的父窗口；通过响应这条消息，所
有者窗口可以通过使用给定的相关显示设备的句柄来设置列表框的文本和背景颜色
WM_CTLCOLORBTN = $0135;
        当一个按钮控件将要被绘制时发送此消息给它的父窗口；通过响应这条消息，所有
者窗口可以通过使用给定的相关显示设备的句柄来设置按纽的文本和背景颜色
WM_CTLCOLORDLG = $0136;
        当一个对话框控件将要被绘制前发送此消息给它的父窗口；通过响应这条消息，所
有者窗口可以通过使用给定的相关显示设备的句柄来设置对话框的文本背景颜色
WM_CTLCOLORSCROLLBAR = $0137;
        当一个滚动条控件将要被绘制时发送此消息给它的父窗口；通过响应这条消息，所
有者窗口可以通过使用给定的相关显示设备的句柄来设置滚动条的背景颜色
WM_CTLCOLORSTATIC = $0138;
        当一个静态控件将要被绘制时发送此消息给它的父窗口；通过响应这条消息，所有
者窗口可以通过使用给定的相关显示设备的句柄来设置静态控件的文本和背景颜色
WM_MOUSEFIRST = $0200;
        WM_MOUSEMOVE = $0200;
        // 移动鼠标
        // 移动鼠标
        WM_LBUTTONDOWN = $0201;
        //按下鼠标左键
        WM_LBUTTONUP = $0202;
        //释放鼠标左键
        WM_LBUTTONDBLCLK = $0203;
        //双击鼠标左键
        WM_RBUTTONDOWN = $0204;
        //按下鼠标右键
        WM_RBUTTONUP = $0205;
        //释放鼠标右键
        WM_RBUTTONDBLCLK = $0206;
        //双击鼠标右键
        WM_MBUTTONDOWN = $0207;
        //按下鼠标中键
        WM_MBUTTONUP = $0208;
        //释放鼠标中键
        WM_MBUTTONDBLCLK = $0209;
        //双击鼠标中键
        WM_MOUSEWHEEL = $020A;
        当鼠标轮子转动时发送此消息个当前有焦点的控件
WM_MOUSELAST = $020A;
        WM_PARENTNOTIFY = $0210;
        当MDI 子窗口被创建或被销毁，或用户按了一下鼠标键而光标在子窗口上时发送
此消息给它的父窗口
WM_ENTERMENULOOP = $0211;
        发送此消息通知应用程序的主窗口that 已经进入了菜单循环模式
WM_EXITMENULOOP = $0212;
        发送此消息通知应用程序的主窗口that 已退出了菜单循环模式
WM_NEXTMENU = $0213;
        WM_SIZING = 532;
        当用户正在调整窗口大小时发送此消息给窗口；通过此消息应用程序可以监视窗口
大小和位置也可以修改他们
WM_CAPTURECHANGED = 533;
        发送此消息 给窗口当它失去捕获的鼠标时；
WM_MOVING = 534;
        当用户在移动窗口时发送此消息，通过此消息应用程序可以监视窗口大小和位置也
可以修改他们；
WM_POWERBROADCAST = 536;
        此消息发送给应用程序来通知它有关电源管理事件；
WM_DEVICECHANGE = 537;
        当设备的硬件配置改变时发送此消息给应用程序或设备驱动程序
WM_IME_STARTCOMPOSITION = $010D;
        WM_IME_ENDCOMPOSITION = $010E;
        WM_IME_COMPOSITION = $010F;
        WM_IME_KEYLAST = $010F;
        WM_IME_SETCONTEXT = $0281;
        WM_IME_NOTIFY = $0282;
        WM_IME_CONTROL = $0283;
        WM_IME_COMPOSITIONFULL = $0284;
        WM_IME_SELECT = $0285;
        WM_IME_CHAR = $0286;
        WM_IME_REQUEST = $0288;
        WM_IME_KEYDOWN = $0290;
        WM_IME_KEYUP = $0291;
        WM_MDICREATE = $0220;
        应用程序发送此消息给多文档的客户窗口来创建一个MDI 子窗口
WM_MDIDESTROY = $0221;
        应用程序发送此消息给多文档的客户窗口来关闭一个MDI 子窗口
WM_MDIACTIVATE = $0222;
应用程序发送此消息给多文档的客户窗口通知客户窗口激活另一个MDI 子窗口，
当客户窗口收到此消息后，它发出WM_MDIACTIVE 消息给MDI 子窗口（未激
活）激活它；
WM_MDIRESTORE = $0223;
程序 发送此消息给MDI 客户窗口让子窗口从最大最小化恢复到原来大小
WM_MDINEXT = $0224;
程序 发送此消息给MDI 客户窗口激活下一个或前一个窗口
WM_MDIMAXIMIZE = $0225;
程序发送此消息给MDI 客户窗口来最大化一个MDI 子窗口；
WM_MDITILE = $0226;
程序 发送此消息给MDI 客户窗口以平铺方式重新排列所有MDI 子窗口
WM_MDICASCADE = $0227;
程序 发送此消息给MDI 客户窗口以层叠方式重新排列所有MDI 子窗口
WM_MDIICONARRANGE = $0228;
程序 发送此消息给MDI 客户窗口重新排列所有最小化的MDI 子窗口
WM_MDIGETACTIVE = $0229;
程序 发送此消息给MDI 客户窗口来找到激活的子窗口的句柄
WM_MDISETMENU = $0230;
程序 发送此消息给MDI 客户窗口用MDI 菜单代替子窗口的菜单
WM_ENTERSIZEMOVE = $0231;
WM_EXITSIZEMOVE = $0232;
WM_DROPFILES = $0233;
WM_MDIREFRESHMENU = $0234;
WM_MOUSEHOVER = $02A1;
WM_MOUSELEAVE = $02A3;
WM_CUT = $0300;
程序发送此消息给一个编辑框或combobox 来删除当前选择的文本
WM_COPY = $0301;
程序发送此消息给一个编辑框或combobox 来复制当前选择的文本到剪贴板
WM_PASTE = $0302;
程序发送此消息给editcontrol 或combobox 从剪贴板中得到数据
WM_CLEAR = $0303;
程序发送此消息给editcontrol 或combobox 清除当前选择的内容；
WM_UNDO = $0304;
程序发送此消息给editcontrol 或combobox 撤消最后一次操作
WM_RENDERFORMAT = $0305；
WM_RENDERALLFORMATS = $0306;
WM_DESTROYCLIPBOARD = $0307;
当调用ENPTYCLIPBOARD 函数时 发送此消息给剪贴板的所有者
WM_DRAWCLIPBOARD = $0308;
当剪贴板的内容变化时发送此消息给剪贴板观察链的第一个窗口；它允许用剪贴板
观察窗口来
显示剪贴板的新内容；
WM_PAINTCLIPBOARD = $0309;
当剪贴板包含CF_OWNERDIPLAY 格式的数据并且剪贴板观察窗口的客户区需要
重画；
WM_VSCROLLCLIPBOARD = $030A;
WM_SIZECLIPBOARD = $030B;
当剪贴板包含CF_OWNERDIPLAY 格式的数据并且剪贴板观察窗口的客户区域的
大小已经改变是此消息通过剪贴板观察窗口发送给剪贴板的所有者；
WM_ASKCBFORMATNAME = $030C;
通过剪贴板观察窗口发送此消息给剪贴板的所有者来请求一个
CF_OWNERDISPLAY 格式的剪贴板的名字
WM_CHANGECBCHAIN = $030D;
当一个窗口从剪贴板观察链中移去时发送此消息给剪贴板观察链的第一个窗口；
WM_HSCROLLCLIPBOARD = $030E;
此消息通过一个剪贴板观察窗口发送给剪贴板的所有者 ；它发生在当剪贴板包含
CFOWNERDISPALY 格式的数据并且有个事件在剪贴板观察窗的水平滚动条上；
所有者应滚动剪贴板图象并更新滚动条的值；
WM_QUERYNEWPALETTE = $030F;
此消息发送给将要收到焦点的窗口，此消息能使窗口在收到焦点时同时有机会实现
他的逻辑调色板
WM_PALETTEISCHANGING= $0310;
当一个应用程序正要实现它的逻辑调色板时发此消息通知所有的应用程序
WM_PALETTECHANGED = $0311;
此消息在一个拥有焦点的窗口实现它的逻辑调色板后发送此消息给所有顶级并重叠
的窗口，以此来改变系统调色板
WM_HOTKEY = $0312;
当用户按下由REGISTERHOTKEY 函数注册的热键时提交此消息
WM_PRINT = 791;
应用程序发送此消息仅当WINDOWS 或其它应用程序发出一个请求要求绘制一个
应用程序的一部分；
WM_PRINTCLIENT = 792;
WM_HANDHELDFIRST = 856;
WM_HANDHELDLAST = 863;
WM_PENWINFIRST = $0380;
WM_PENWINLAST = $038F;
WM_COALESCE_FIRST = $0390;
WM_COALESCE_LAST = $039F;
WM_DDE_FIRST = $03E0;
WM_DDE_INITIATE = WM_DDE_FIRST + 0;
一个DDE 客户程序提交此消息开始一个与服务器程序的会话来响应那个指定的程
序和主题名；
WM_DDE_TERMINATE = WM_DDE_FIRST + 1;
一个DDE 应用程序（无论是客户还是服务器）提交此消息来终止一个会话；
WM_DDE_ADVISE = WM_DDE_FIRST + 2;
一个DDE 客户程序提交此消息给一个DDE 服务程序来请求服务器每当数据项改
变时更新它
WM_DDE_UNADVISE = WM_DDE_FIRST + 3;
一个DDE 客户程序通过此消息通知一个DDE 服务程序不更新指定的项或一个特
殊的剪贴板格式的项
WM_DDE_ACK = WM_DDE_FIRST + 4;
此消息通知一个DDE（动态数据交换）程序已收到并正在处理WM_DDE_POKE,
WM_DDE_EXECUTE, WM_DDE_DATA, WM_DDE_ADVISE,
WM_DDE_UNADVISE, or WM_DDE_INITIAT 消息
WM_DDE_DATA = WM_DDE_FIRST + 5;
一个DDE 服务程序提交此消息给DDE 客户程序来传递个一数据项给客户或通知
客户的一条可用数据项
WM_DDE_REQUEST = WM_DDE_FIRST + 6;
一个DDE 客户程序提交此消息给一个DDE 服务程序来请求一个数据项的值；
WM_DDE_POKE = WM_DDE_FIRST + 7;
一个DDE 客户程序提交此消息给一个DDE 服务程序，客户使用此消息来请求服
务器接收一个未经同意的数据项；服务器通过答复WM_DDE_ACK 消息提示是否
它接收这个数据项；
WM_DDE_EXECUTE = WM_DDE_FIRST + 8;
一个DDE 客户程序提交此消息给一个DDE 服务程序来发送一个字符串给服务器
让它象串行命令一样被处理，服务器通过提交WM_DDE_ACK 消息来作回应；
WM_DDE_LAST = WM_DDE_FIRST + 8;
WM_APP = $8000;
WM_USER = $0400;
此消息能帮助应用程序自定义私有消息；*/
    }
}
