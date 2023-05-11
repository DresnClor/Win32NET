using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Win32NET
{
    public static partial class User32
    {
        /// <summary>
        /// 窗体消息值
        /// WM_*
        /// </summary>
        [Flags]
        [ApiEnumDef(MarshalType.UInt32, "窗体消息值: WM_*")]
        public enum WindowsMessage : uint
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
            /// <summary>
            /// 当光标在某个非激活的窗口中而用户正按着鼠标的某个键发送此消息给当前窗口
            /// </summary>
            MouseActivate = 0X0021,
            /// <summary>
            /// 发送此消息给MDI 子窗口当用户点击此窗口的标题栏，或当窗口被激活，移动，改变大小
            /// </summary>
            ChildActivate = 0X0022,
            /// <summary>
            /// 此消息由基于计算机的训练程序发送，通过WH_JOURNALPALYBACK的hook程序分离出用户输入消息
            /// </summary>
            QueueSync = 0X0023,
            /// <summary>
            /// 此消息发送给窗口当它将要改变大小或位置
            /// </summary>
            GetMinMaxInfo = 0X0024,
            /// <summary>
            /// 发送给最小化窗口当它图标将要被重画
            /// </summary>
            PaintIcon = 0X0026,
            /// <summary>
            /// 此消息发送给某个最小化窗口，仅当它在画图标前它的背景必须被重画
            /// </summary>
            IconEraseBkgnd = 0X0027,
            /// <summary>
            /// 发送此消息给一个对话框程序去更改焦点位置
            /// </summary>
            NextDlgCtl = 0X0028,
            /// <summary>
            /// 每当打印管理列队增加或减少一条作业时发出此消息
            /// </summary>
            SpoolerStatus = 0X002A,
            /// <summary>
            /// 当button，combobox，listbox，menu 的可视外观改变时发送此消息给这些空件的所有者
            /// </summary>
            DrawItem = 0X002B,
            /// <summary>
            /// 当button, combo box, list box, list view control, or menu item 被创建时发送此消息给控件的所有者
            /// </summary>
            MeasureItem = 0X002C,
            /// <summary>
            /// 当the list box 或 combo box 被销毁 或 当 某些项被删除通过LB_DELETESTRING,
            /// LB_RESETCONTENT, CB_DELETESTRING, or CB_RESETCONTENT 消息
            /// </summary>
            DeleteItem = 0X002D,
            /// <summary>
            /// 此消息有一个LBS_WANTKEYBOARDINPUT 风格的发出给它的所有者来响应WM_KEYDOWN 消息
            /// </summary>
            VKeyToItem = 0X002E,
            /// <summary>
            /// 此消息由一个LBS_WANTKEYBOARDINPUT 风格的列表框发送给他的所有者来响应WM_CHAR 消息
            /// </summary>
            CharToItem = 0X002F,
            /// <summary>
            /// 当绘制文本时程序发送此消息得到控件的字体
            /// </summary>
            SetFont = 0X0030,
            /// <summary>
            /// 应用程序发送此消息得到当前控件绘制文本的字体
            /// </summary>
            GetFont = 0X0031,
            /// <summary>
            ///  应用程序发送此消息让一个窗口与一个热键相关连
            /// </summary>
            SetHotkey = 0X0032,
            /// <summary>
            /// 应用程序发送此消息来判断热键与某个窗口是否有关联
            /// </summary>
            GetHotkey = 0X0033,
            /// <summary>
            /// 此消息发送给最小化窗口，当此窗口将要被拖放而它的类中没有定义图标，应用程序能返回一个图标或光标的句柄，
            /// 当用户拖放图标时系统显示这个图标或光标
            /// </summary>
            QueryDragIcon = 0X0037,
            /// <summary>
            /// 发送此消息来判定combobox 或listbox 新增加的项的相对位置
            /// </summary>
            CompareItem = 0X0039,
            /// <summary>
            /// 
            /// </summary>
            GetObject = 0X003D,
            /// <summary>
            /// 显示内存已经很少了
            /// </summary>
            Compacting = 0X0041,
            /// <summary>
            /// 发送此消息给那个窗口的大小和位置将要被改变时，来调用setwindowpos 函数或其它窗口管理函数
            /// </summary>
            WindowPosChanging = 0X0046,
            /// <summary>
            /// 发送此消息给那个窗口的大小和位置已经被改变时，来调用setwindowpos 函数或其它窗口管理函数
            /// </summary>
            WindowPosChanged = 0X0047,
            /// <summary>
            /// 当系统将要进入暂停状态时发送此消息（适用于16 位的windows）
            /// </summary>
            Power = 0X0048,
            /// <summary>
            ///当一个应用程序传递数据给另一个应用程序时发送此消息
            /// </summary>
            CopyData = 0X004A,
            /// <summary>
            /// 当某个用户取消程序日志激活状态，提交此消息给程序
            /// </summary>
            CancelJournal = 0X004B,
            /// <summary>
            /// 当某个控件的某个事件已经发生或这个控件需要得到一些信息时，发送此消息给它的父窗口
            /// </summary>
            Notify = 0X004E,
            /// <summary>
            /// 当用户选择某种输入语言，或输入语言的热键改变
            /// </summary>
            InputLangChangeRequest = 0X0050,
            /// <summary>
            ///  当输入语言已经被改变后发送此消息给受影响的最顶级窗口
            /// </summary>
            InputLangChange = 0X0051,
            /// <summary>
            /// 当程序已经初始化windows 帮助例程时发送此消息给应用程序
            /// </summary>
            Tcard = 0X0052,
            /// <summary>
            /// 此消息显示用户按下了F1，如果某个菜单是激活的，就发送的菜单消息，否则就发送给有焦点的窗口，
            /// 如果当前都没有焦点，就把此消息发送给当前激活的窗口
            /// </summary>
            Help = 0X0053,
            /// <summary>
            /// 当用户已经登入或退出后发送此消息给所有的窗口，当用户登入或退出时系统更新用户的具体设置信息，在用户更新设置时系统马上发送此消息；
            /// </summary>
            UserChanged = 0X0054,
            /// <summary>
            /// 公用控件，自定义控件和他们的父窗口通过此消息来判断控件是使用ANSI 还是UNICODE 结构在WM_NOTIFY 消息，使用此控件能使某个控件与它的父控件之间进行相互通信
            /// </summary>
            NotifyFormat = 0X0055,
            /// <summary>
            /// 当用户某个窗口中点击了一下右键就发送此消息给这个窗口
            /// </summary>
            ContextMenu = 0X007B,
            /// <summary>
            /// 当调用SETWINDOWLONG 函数将要改变一个或多个 窗口的风格时发送此消息给那个窗口
            /// </summary>
            StyleChanging = 0X007C,
            /// <summary>
            /// 当调用SETWINDOWLONG 函数一个或多个 窗口的风格后发送此消息给那个窗口
            /// </summary>
            StyleChanged = 0X007D,
            /// <summary>
            /// 当显示器的分辨率改变后发送此消息给所有的窗口
            /// </summary>
            DisplayChange = 0X007E,
            /// <summary>
            /// 此消息发送给某个窗口来返回与某个窗口有关连的大图标或小图标的句柄；
            /// </summary>
            GetIcon = 0X007F,
            /// <summary>
            /// 程序发送此消息让一个新的大图标或小图标与某个窗口关联；
            /// </summary>
            SetIcon = 0X0080,
            /// <summary>
            /// 当某个窗口第一次被创建时，此消息在WM_CREATE 消息发送前发送；
            /// </summary>
            NcCreate = 0X0081,
            /// <summary>
            /// 此消息通知某个窗口，非客户区正在销毁
            /// </summary>
            NcDestroy = 0X0082,
            /// <summary>
            /// 当某个窗口的客户区域必须被核算时发送此消息
            /// </summary>
            NcCalcsize = 0X0083,
            /// <su移动鼠标，按住或释放鼠标时发生mmary>
            /// 
            /// </summary>
            NcHitTest = 0X0084,
            /// <summary>
            /// 程序发送此消息给某个窗口当它（窗口）的框架必须被绘制时；
            /// </summary>
            NcPaint = 0X0085,
            /// <summary>
            /// 此消息发送给某个窗口 仅当它的非客户区需要被改变来显示是激活还是非激活状态；
            /// </summary>
            NcActivate = 0X0086,
            /// <summary>
            /// 发送此消息给某个与对话框程序关联的控件，widdows 控制方位键和TAB 键使输入进入此控件
            /// 通过响应WM_GETDLGCODE 消息，应用程序可以把他当成一个特殊的输入控件并能处理它
            /// </summary>
            GetDlgCode = 0X0087,
            /// <summary>
            /// 当光标在一个窗口的非客户区内移动时发送此消息给这个窗口 //非客户区为：窗体的标题栏及窗的边框体
            /// </summary>
            NcMouseMove = 0X00A0,
            /// <summary>
            /// 当光标在一个窗口的非客户区同时按下鼠标左键时提交此消息
            /// </summary>
            NcLButtonDown = 0X00A1,
            /// <summary>
            /// 当用户释放鼠标左键同时光标某个窗口在非客户区十发送此消息；
            /// </summary>
            NcLButtonUp = 0X00A2,
            /// <summary>
            /// 当用户双击鼠标左键同时光标某个窗口在非客户区十发送此消息
            /// </summary>
            NcLButtonDblClk = 0X00A3,
            /// <summary>
            /// 当用户按下鼠标右键同时光标又在窗口的非客户区时发送此消息
            /// </summary>
            NcRButtonDown = 0X00A4,
            /// <summary>
            /// 当用户释放鼠标右键同时光标又在窗口的非客户区时发送此消息
            /// </summary>
            NCRBUTTONUP = 0X00A5,
            /// <summary>
            /// 当用户双击鼠标右键同时光标某个窗口在非客户区十发送此消息
            /// </summary>
            NcRButtonDblClk = 0X00A6,
            /// <summary>
            /// 当用户按下鼠标中键同时光标又在窗口的非客户区时发送此消息
            /// </summary>
            NcMButtonDown = 0X00A7,
            /// <summary>
            /// 当用户释放鼠标中键同时光标又在窗口的非客户区时发送此消息
            /// </summary>
            NcMButtonUp = 0X00A8,
            /// <summary>
            /// 当用户双击鼠标中键同时光标又在窗口的非客户区时发送此消息
            /// </summary>
            NcMButtonDblclk = 0X00A9,
            /// <summary>
            /// 键盘消息开始位置，用于判断
            /// </summary>
            KeyFirst = 0X0100,
            /// <summary>
            /// 按下一个键
            /// </summary>
            KeyDown = 0X0100,
            /// <summary>
            /// 释放一个键
            /// </summary>
            KeyUp = 0X0101,
            /// <summary>
            /// 按下某键，并已发出WM_KEYDOWN， WM_KEYUP 消息
            /// </summary>
            Char = 0X0102,
            /// <summary>
            /// 当用translatemessage 函数翻译WM_KEYUP 消息时发送此消息给拥有焦点的窗口
            /// </summary>
            DeadChar = 0X0103,
            /// <summary>
            /// 当用户按住ALT 键同时按下其它键时提交此消息给拥有焦点的窗口；
            /// </summary>
            SysKeyDown = 0X0104,
            /// <summary>
            /// 当用户释放一个键同时ALT 键还按着时提交此消息给拥有焦点的窗口
            /// </summary>
            SysKeyUp = 0X0105,
            /// <summary>
            /// 当WM_SYSKEYDOWN 消息被TRANSLATEMESSAGE 函数翻译后提交此消息给拥有焦点的窗口
            /// </summary>
            SysChar = 0X0106,
            /// <summary>
            /// 当WM_SYSKEYDOWN 消息被TRANSLATEMESSAGE 函数翻译后发送此消息给拥有焦点的窗口
            /// </summary>
            SysDeadChar = 0X0107,
            /// <summary>
            /// 键盘消息结束位置，用于判断
            /// </summary>
            KeyLast = 0X0108,
            /// <summary>
            /// 在一个对话框程序被显示前发送此消息给它，通常用此消息初始化控件和执行其它任务
            /// </summary>
            InitDialog = 0X0110,
            /// <summary>
            /// 当用户选择一条菜单命令项或当某个控件发送一条消息给它的父窗口，一个快捷键被翻译
            /// </summary>
            Command = 0X0111,
            /// <summary>
            /// 当用户选择窗口菜单的一条命令或当用户选择最大化或最小化时那个窗口会收到此消息
            /// </summary>
            SysCommand = 0X0112,
            /// <summary>
            /// 发生了定时器事件
            /// </summary>
            Timer = 0X0113,
            /// <summary>
            /// 当一个窗口标准水平滚动条产生一个滚动事件时发送此消息给那个窗口，也发送给拥有它的控件
            /// </summary> //
            HScrolL = 0X0114,
            /// <summary>
            /// 当一个窗口标准垂直滚动条产生一个滚动事件时发送此消息给那个窗口也，发送给拥有它的控件
            /// </summary>
            VScroll = 0X0115,
            /// <summary>
            /// 当一个菜单将要被激活时发送此消息，它发生在用户菜单条中的某项或按下某个菜单键，它允许程序在显示前更改菜单
            /// </summary>
            InitMenu = 0X0116,
            /// <summary>
            /// 当一个下拉菜单或子菜单将要被激活时发送此消息，它允许程序在它显示前更改菜单，而不要改变全部
            /// </summary>
            InitMenuPopup = 0X0117,
            /// <summary>
            /// 当用户选择一条菜单项时发送此消息给菜单的所有者（一般是窗口）
            /// </summary>
            MenuSelect = 0X011F,
            /// <summary>
            /// 当菜单已被激活用户按下了某个键（不同于加速键），发送此消息给菜单的所有者；
            /// </summary>
            MenuChar = 0X0120,
            /// <summary>
            /// 当一个模态对话框或菜单进入空载状态时发送此消息给它的所有者，一个模态对话框或菜单进入空载状态，
            /// 就是在处理完一条或几条先前的消息后没有消息它的列队中等待
            /// </summary>
            EnterIdle = 0X0121,
            /// <summary>
            /// 
            /// </summary>
            MenuRButtonUp = 0X0122,
            /// <summary>
            /// 
            /// </summary>
            MenuDrag = 0X0123,
            MenuGetObject = 0X0124,
            UninitMenuPopuP = 0X0125,
            MenuCommand = 0X0126,
            ChangeUIState = 0X0127,
            UpdateUIState = 0X0128,
            QueryUIState = 0X0129,
            /// <summary>
            /// 在windows 绘制消息框前发送此消息给消息框的所有者窗口，通过响应这条消息，
            /// 所有者窗口可以通过使用给定的相关显示设备的句柄来设置消息框的文本和背景颜色
            /// </summary>
            CtlColorMsgBox = 0X0132,
            /// <summary>
            /// 当一个编辑型控件将要被绘制时发送此消息给它的父窗口；通过响应这条消息，
            /// 所有者窗口可以通过使用给定的相关显示设备的句柄来设置编辑框的文本和背景颜色
            /// </summary>
            CtlColorEdit = 0X0133,
            /// <summary>
            /// 当一个列表框控件将要被绘制前发送此消息给它的父窗口；通过响应这条消息，
            /// 所有者窗口可以通过使用给定的相关显示设备的句柄来设置列表框的文本和背景颜色
            /// </summary>
            CtlColorListBox = 0X0134,
            /// <summary>
            /// 当一个按钮控件将要被绘制时发送此消息给它的父窗口；通过响应这条消息，
            /// 所有者窗口可以通过使用给定的相关显示设备的句柄来设置按纽的文本和背景颜色
            /// </summary>
            CTLCOLORBTN = 0X0135,
            /// <summary>
            /// 当一个对话框控件将要被绘制前发送此消息给它的父窗口；通过响应这条消息，
            /// 所有者窗口可以通过使用给定的相关显示设备的句柄来设置对话框的文本背景颜色
            /// </summary>
            CtlColorDlg = 0X0136,
            /// <summary>
            /// 当一个滚动条控件将要被绘制时发送此消息给它的父窗口；通过响应这条消息，
            /// 所有者窗口可以通过使用给定的相关显示设备的句柄来设置滚动条的背景颜色
            /// </summary>
            CtlColorScrollBar = 0X0137,
            /// <summary>
            /// 当一个静态控件将要被绘制时发送此消息给它的父窗口；通过响应这条消息，
            /// 所有者窗口可以通过使用给定的相关显示设备的句柄来设置静态控件的文本和背景颜色
            /// </summary>
            CtlColorStatic = 0X0138,
            /// <summary>
            /// 鼠标事件开始位置
            /// </summary>
            MouseFirst = 0X0200,
            /// <summary>
            /// 移动鼠标
            /// </summary>
            MouseMove = 0X0200,
            /// <summary>
            /// 按下鼠标左键
            /// </summary
            LButtonDown = 0X0201,
            /// <summary>
            /// 释放鼠标左键
            /// </summary>
            LButtonUp = 0X0202,
            /// <summary>
            /// 双击鼠标左键
            /// </summary>
            LButtonDblClk = 0X0203,
            /// <summary>
            /// 按下鼠标右键
            /// </summary>
            RButtonDown = 0X0204,
            /// <summary>
            /// 释放鼠标右键
            /// </summary>
            RButtonUp = 0X0205,
            /// <summary>
            /// 双击鼠标右键
            /// </summary>
            RButtonDblClk = 0X0206,
            /// <summary>
            /// 按下鼠标中键
            /// </summary>
            MButtonDown = 0X0207,
            /// <summary>
            /// 释放鼠标中键
            /// </summary>
            MButtonUp = 0X0208,
            /// <summary>
            /// 双击鼠标中键
            /// </summary>
            MButtonDblClk = 0X0209,
            /// <summary>
            /// 当鼠标轮子转动时发送此消息个当前有焦点的控件
            /// </summary>
            MouseWheel = 0X020A,
            /// <summary>
            /// 鼠标事件结束位置
            /// </summary>
            MouseLast = 0X020A,
            /// <summary>
            /// 当MDI 子窗口被创建或被销毁，或用户按了一下鼠标键而光标在子窗口上时发送此消息给它的父窗口
            /// </summary>
            ParentNotify = 0X0210,
            /// <summary>
            /// 发送此消息通知应用程序的主窗口that 已经进入了菜单循环模式
            /// </summary>
            EnterMenuLoop = 0X0211,
            /// <summary>
            /// 发送此消息通知应用程序的主窗口that 已退出了菜单循环模式
            /// </summary>
            ExitMenuLoop = 0X0212,
            /// <summary>
            /// 
            /// </summary>
            NextMenu = 0X0213,
            /// <summary>
            /// 当用户正在调整窗口大小时发送此消息给窗口；通过此消息应用程序可以监视窗口大小和位置也可以修改他们
            /// </summary>
            Sizing = 532,
            /// <summary>
            /// 发送此消息 给窗口当它失去捕获的鼠标时；
            /// </summary>
            CaptureChanged = 533,
            /// <summary>
            /// 当用户在移动窗口时发送此消息，通过此消息应用程序可以监视窗口大小和位置也可以修改他们；
            /// </summary>
            Moving = 534,
            /// <summary>
            /// 此消息发送给应用程序来通知它有关电源管理事件；
            /// </summary>
            PowerBroadCast = 536,
            /// <summary>
            ///当设备的硬件配置改变时发送此消息给应用程序或设备驱动程序 
            /// </summary>
            DeviceChange = 537,
            IMEStartComPosition = 0X010D,
            IMEEndComPosition = 0X010E,
            IMEComPosition = 0X010F,
            IMEKeyLast = 0X010F,
            IMESetContext = 0X0281,
            IMENotify = 0X0282,
            IMEControL = 0X0283,
            IMEComPositionFull = 0X0284,
            IMESelect = 0X0285,
            IMEChar = 0X0286,
            IMERequest = 0X0288,
            IMEKeyDown = 0X0290,
            IMEKeyUp = 0X0291,
            /// <summary>
            /// 应用程序发送此消息给多文档的客户窗口来创建一个MDI 子窗口
            /// </summary>
            MdiCreate = 0X0220,
            /// <summary>
            /// 应用程序发送此消息给多文档的客户窗口来关闭一个MDI 子窗口
            /// </summary>
            MdiDestroy = 0X0221,
            /// <summary>
            /// 应用程序发送此消息给多文档的客户窗口通知客户窗口激活另一个MDI 子窗口，当客户窗口收到此消息后，
            /// 它发出WM_MDIACTIVE 消息给MDI 子窗口（未激活）激活它；
            /// </summary>
            MdiActivate = 0X0222,
            /// <summary>
            /// 程序 发送此消息给MDI 客户窗口让子窗口从最大最小化恢复到原来大小
            /// </summary>
            MdiRestore = 0X0223,
            /// <summary>
            /// 程序 发送此消息给MDI 客户窗口激活下一个或前一个窗口
            /// </summary>
            MdiNext = 0X0224,
            /// <summary>
            /// 程序发送此消息给MDI 客户窗口来最大化一个MDI 子窗口；
            /// </summary>
            MdiMaxiMize = 0X0225,
            /// <summary>
            ///  程序 发送此消息给MDI 客户窗口以平铺方式重新排列所有MDI 子窗口
            /// </summary>
            MdiTile = 0X0226,
            /// <summary>
            /// 程序 发送此消息给MDI 客户窗口以层叠方式重新排列所有MDI 子窗口
            /// </summary>
            MdiCascade = 0X0227,
            /// <summary>
            /// 程序 发送此消息给MDI 客户窗口重新排列所有最小化的MDI 子窗口
            /// </summary>
            MdiIconArrange = 0X0228,
            /// <summary>
            /// 程序 发送此消息给MDI 客户窗口来找到激活的子窗口的句柄
            /// </summary>
            MdiGetActive = 0X0229,
            /// <summary>
            /// 程序 发送此消息给MDI 客户窗口用MDI 菜单代替子窗口的菜单
            /// </summary>
            MdiSetMenu = 0X0230,
            /// <summary>
            /// 
            /// </summary>
            EnterSizeMove = 0X0231,
            ExitSizeMove = 0X0232,
            DropFiles = 0X0233,
            MdiRefResHMenu = 0X0234,
            MouseHover = 0X02A1,
            MouseLeave = 0X02A3,
            /// <summary>
            /// 程序发送此消息给一个编辑框或combobox 来删除当前选择的文本
            /// </summary>
            Cut = 0X0300,
            /// <summary>
            /// 程序发送此消息给一个编辑框或combobox 来复制当前选择的文本到剪贴板
            /// </summary>
            Copy = 0X0301,
            /// <summary>
            /// 程序发送此消息给editcontrol 或combobox 从剪贴板中得到数据
            /// </summary>
            Paste = 0X0302,
            /// <summary>
            /// 程序发送此消息给editcontrol 或combobox 清除当前选择的内容；
            /// </summary>
            Clear = 0X0303,
            /// <summary>
            /// 程序发送此消息给editcontrol 或combobox 撤消最后一次操作
            /// </summary>
            Undo = 0X0304,
            RenderFormat = 0X0305,
            RenderAllFormats = 0X0306,
            /// <summary>
            /// 当调用ENPTYCLIPBOARD 函数时 发送此消息给剪贴板的所有者
            /// </summary>
            DestroyClipBoard = 0X0307,
            /// <summary>
            /// 当剪贴板的内容变化时发送此消息给剪贴板观察链的第一个窗口；它允许用剪贴板观察窗口来显示剪贴板的新内容；
            /// </summary>
            DrawClipBoard = 0X0308,
            /// <summary>
            /// 当剪贴板包含CF_OWNERDIPLAY 格式的数据并且剪贴板观察窗口的客户区需要重画；
            /// </summary>
            PaintClipBoard = 0X0309,
            /// <summary>
            /// 
            /// </summary>
            VScrollClipBoard = 0X030A,
            /// <summary>
            /// 当剪贴板包含CF_OWNERDIPLAY 格式的数据并且剪贴板观察窗口的客户区域的大小
            /// 已经改变是此消息通过剪贴板观察窗口发送给剪贴板的所有者；
            /// </summary>
            SizeClipBoard = 0X030B,
            /// <summary>
            /// 通过剪贴板观察窗口发送此消息给剪贴板的所有者来请求一个CF_OWNERDISPLAY 格式的剪贴板的名字
            /// </summary>
            AskCBFormatName = 0X030C,
            /// <summary>
            /// 当一个窗口从剪贴板观察链中移去时发送此消息给剪贴板观察链的第一个窗口；
            /// </summary>
            ChangeCBChain = 0X030D,
            /// <summary>
            /// 此消息通过一个剪贴板观察窗口发送给剪贴板的所有者 ；
            /// 它发生在当剪贴板包含CFOWNERDISPALY 格式的数据并且有个事件在剪贴板观察窗的水平滚动条上；
            /// 所有者应滚动剪贴板图象并更新滚动条的值；
            /// </summary>
            HScrollClipBoard = 0X030E,
            /// <summary>
            /// 此消息发送给将要收到焦点的窗口，此消息能使窗口在收到焦点时同时有机会实现他的逻辑调色板
            /// </summary>
            QueryNewPalette = 0X030F,
            /// <summary>
            ///  当一个应用程序正要实现它的逻辑调色板时发此消息通知所有的应用程序
            /// </summary>
            PaletteIsChanging = 0X0310,
            /// <summary>
            /// 此消息在一个拥有焦点的窗口实现它的逻辑调色板后发送此消息给所有顶级并重叠的窗口，以此来改变系统调色板
            /// </summary>
            PalettEChanged = 0X0311,
            /// <summary>
            /// 当用户按下由REGISTERHOTKEY 函数注册的热键时提交此消息
            /// </summary>
            HotKey = 0X0312,
            /// <summary>
            /// 应用程序发送此消息仅当WINDOWS 或其它应用程序发出一个请求要求绘制一个应用程序的一部分；
            /// </summary>
            Print = 791,
            /// <summary>
            /// 
            /// </summary>
            PrintClient = 792,
            HandheldFirst = 856,
            HandheldLast = 863,
            PenwinFirst = 0X0380,
            PenwinLast = 0X038F,
            CoalesceFirst = 0X0390,
            CoalesceLast = 0X039F,
            DdeFirst = 0X03E0,
            /// <summary>
            ///  一个DDE 客户程序提交此消息开始一个与服务器程序的会话来响应那个指定的程序和主题名；
            /// </summary>
            DdeInitiate = DdeFirst + 0,
            /// <summary>
            /// 一个DDE 应用程序（无论是客户还是服务器）提交此消息来终止一个会话；
            /// </summary>
            DdeTerminate = DdeFirst + 1,
            /// <summary>
            /// 一个DDE 客户程序提交此消息给一个DDE 服务程序来请求服务器每当数据项改变时更新它
            /// </summary>
            DdeAdvise = DdeFirst + 2,
            /// <summary>
            /// 一个DDE 客户程序通过此消息通知一个DDE 服务程序不更新指定的项或一个特殊的剪贴板格式的项
            /// </summary>
            DdeUnadvise = DdeFirst + 3,
            /// <summary>
            /// 此消息通知一个DDE（动态数据交换）程序已收到并正在处理WM_DDE_POKE,
            /// WM_DDE_EXECUTE, WM_DDE_DATA, WM_DDE_ADVISE,
            /// WM_DDE_UNADVISE, or WM_DDE_INITIAT 消息
            /// </summary>
            DdeAck = DdeFirst + 4,
            /// <summary>
            /// 一个DDE 服务程序提交此消息给DDE 客户程序来传递个一数据项给客户或通知客户的一条可用数据项
            /// </summary>
            DdeData = DdeFirst + 5,
            /// <summary>
            /// 一个DDE 客户程序提交此消息给一个DDE 服务程序来请求一个数据项的值；
            /// </summary>
            DdeRequest = DdeFirst + 6,
            /// <summary>
            /// 一个DDE 客户程序提交此消息给一个DDE 服务程序，客户使用此消息来请求服务器接收一个未经同意的数据项；
            /// 服务器通过答复WM_DDE_ACK 消息提示是否它接收这个数据项；
            /// </summary>
            DdePoke = DdeFirst + 7,
            /// <summary>
            /// 一个DDE 客户程序提交此消息给一个DDE 服务程序来发送一个字符串给服务器
            /// 让它象串行命令一样被处理，服务器通过提交WM_DDE_ACK 消息来作回应；
            /// </summary>
            DdeExecute = DdeFirst + 8,
            /// <summary>
            /// 
            /// </summary>
            DdeLast = DdeFirst + 8,
            /// <summary>
            /// 
            /// </summary>
            App = 0X8000,
            /// <summary>
            /// 此消息能帮助应用程序自定义私有消息；
            /// </summary>
            User = 0X0400,
        }
    }
}
