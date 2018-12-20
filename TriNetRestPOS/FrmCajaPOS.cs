// Decompiled with JetBrains decompiler
// Type: TriNetRestPOS.FrmCajaPOS
// Assembly: TriNetRestPOS, Version=5.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 43377352-E952-4AC1-9BA6-CCBE4AE5F575
// Assembly location: C:\log\TriNetRestPOS.exe

using CrystalDecisions.CrystalReports.Engine;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using TR1_BusinessEntity;
using TR1_BusinessLogic;
using TR2_BusinessEntity;
using TR2_BusinessLogic;
using TriNetRestPOS.My;

namespace TriNetRestPOS
{
  [DesignerGenerated]
  public class FrmCajaPOS : Form
  {
    private IContainer components;
    private Button[] btnTypeOrders;
    private Button[] btnButtonsGroups;
    private Button[] btnButtonsSubGroups;
    private Button[] btnButtonsProducts;
    private int sht_ArrayCount_SubG;
    private BECollec_TR1_ORDERS o_BECollec_TR1_ORDERS;
    private BL_TR1_ORDERS o_BL_ORDERS;
    private BL_TR1_ORDERDETAILS o_BL_ORDERDETAILS;
    private List<BE_TR1_ORDERDETAILS> oListaORDERDETAILS;
    private string str_GroupID;
    private string str_TypeOrder;
    private short numYPositionGroups;
    private short shtCountTypeOrders;
    private BE_TR1_ORDERDETAILS o_BE_TR1_ORDERDETAILS;
    private bool _IsValidate;
    private string Res_Product;
    private string Res_Price;
    private string Res_Quantity;
    private string Res_Order;
    private string Res_OrderFree;
    private string Res_NotProducts;
    private string Res_MsgNotOrders;
    private string Res_SendCommand;
    private string Res_InputPassword;
    private double dSD_subTotal;
    private string Res_ObservationInput;
    private string str_Discount;
    private double dbl_AmountDiscount;
    private BE_TR1_ORDERS obeORDER;
    private string NroSerie;
    private string Res_Code;
    private string Res_Description;
    private bool bolPressCONTROL;
    private bool bolPressSHIFT;
    private string str_SubGroupID;
    private short intCambioPrecio;
    public bool bolEsTomador;
    public bool bolEsPedidoNuevo;
    private string strCodigoContacto;

    public FrmCajaPOS()
    {
      this.KeyUp += new KeyEventHandler(this.FrmCajaPOS_KeyUp);
      this.Load += new EventHandler(this.FrmFastBox_Load);
      this.KeyDown += new KeyEventHandler(this.FrmFastBox_KeyDown);
      this.KeyPress += new KeyPressEventHandler(this.FrmFastBox_KeyPress);
      this.FormClosing += new FormClosingEventHandler(this.FrmFastBox_FormClosing);
      this.Click += new EventHandler(this.ButtonTypeOrders_Click);
      this.Click += new EventHandler(this.btnButtonsGroups_Click);
      this.Click += new EventHandler(this.btnButtonsSubGroups_Click);
      this.Click += new EventHandler(this.btnButtonsProducts_Click);
      this.o_BECollec_TR1_ORDERS = new BECollec_TR1_ORDERS();
      this.o_BL_ORDERS = new BL_TR1_ORDERS();
      this.o_BL_ORDERDETAILS = new BL_TR1_ORDERDETAILS();
      this.oListaORDERDETAILS = new List<BE_TR1_ORDERDETAILS>();
      this.numYPositionGroups = (short) 35;
      this.dSD_subTotal = 0.0;
      this.obeORDER = new BE_TR1_ORDERS();
      this.NroSerie = "";
      this.intCambioPrecio = (short) 0;
      this.bolEsTomador = false;
      this.bolEsPedidoNuevo = true;
      this.strCodigoContacto = "";
      this.InitializeComponent();
    }

    [DebuggerNonUserCode]
    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      DataGridViewCellStyle gridViewCellStyle1 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle2 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle3 = new DataGridViewCellStyle();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FrmCajaPOS));
      DataGridViewCellStyle gridViewCellStyle4 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle5 = new DataGridViewCellStyle();
      this.StatusStrip_FastBox = new StatusStrip();
      this.Tssl_Box = new ToolStripStatusLabel();
      this.Tssl_Box_Des = new ToolStripStatusLabel();
      this.Tssl_Turn = new ToolStripStatusLabel();
      this.Tssl_Turn_Des = new ToolStripStatusLabel();
      this.Tssl_Order = new ToolStripStatusLabel();
      this.Tssl_Order_Des = new ToolStripStatusLabel();
      this.Tssl_User = new ToolStripStatusLabel();
      this.Tssl_User_Des = new ToolStripStatusLabel();
      this.tsslVentaTickets = new ToolStripStatusLabel();
      this.Tssl_Date = new ToolStripStatusLabel();
      this.l_tsslUserText = new ToolStripStatusLabel();
      this.p_tsslUserText = new ToolStripStatusLabel();
      this.ToolStripStatusLabel2 = new ToolStripStatusLabel();
      this.p_tsslBoxText = new ToolStripStatusLabel();
      this.l_tsslTurnText = new ToolStripStatusLabel();
      this.p_tsslTurnText = new ToolStripStatusLabel();
      this.l_tsslOrderText = new ToolStripStatusLabel();
      this.p_tsslOrderText = new ToolStripStatusLabel();
      this.p_tsslDateText = new ToolStripStatusLabel();
      this.ToolStripStatusLabel_Box = new ToolStripStatusLabel();
      this.ToolStripStatusLabel_BoxDes = new ToolStripStatusLabel();
      this.tsslTurnValue = new ToolStripStatusLabel();
      this.ToolStripStatusLabel_TurnDes = new ToolStripStatusLabel();
      this.ToolStripStatusLabel_WaiterValue = new ToolStripStatusLabel();
      this.ToolStripStatusLabel_UserDes = new ToolStripStatusLabel();
      this.ToolStripStatusLabel1 = new ToolStripStatusLabel();
      this.ToolStripStatusLabel_OrderDes = new ToolStripStatusLabel();
      this.tsslFechaText = new ToolStripStatusLabel();
      this.BottomToolStripPanel = new ToolStripPanel();
      this.TopToolStripPanel = new ToolStripPanel();
      this.RightToolStripPanel = new ToolStripPanel();
      this.LeftToolStripPanel = new ToolStripPanel();
      this.ContentPanel = new ToolStripContentPanel();
      this.Panel1 = new Panel();
      this.MyXpButton_OrderDetails_Text = new Button();
      this.dgrvOrderDetails = new DataGridView();
      this.Button_ReSendCommand = new Button();
      this.Button_SendCommand = new Button();
      this.Button_SearchItem = new Button();
      this.Button_OrdersDetailsN = new Button();
      this.Button_OrdersDetailsL = new Button();
      this.Button_OrdersDetailsF = new Button();
      this.Button_OrdersDetailsB = new Button();
      this.GroupBox_Emissions = new GroupBox();
      this.Button_Precuenta = new Button();
      this.Button_CreateTicket = new Button();
      this.Button_CreateInvoice = new Button();
      this.MyXPButton_Pay = new Button();
      this.GroupBox_OptionOrders = new GroupBox();
      this.Button_ElegirNuevoPedido = new Button();
      this.Button_NewOrder = new Button();
      this.Button_DeleteOrder = new Button();
      this.Button_GoOut = new Button();
      this.Button_SearchOrder = new Button();
      this.TextBox_OrderId = new TextBox();
      this.Panel4 = new Panel();
      this.Button_Disaggregate = new Button();
      this.Button_ChangePrice = new Button();
      this.Button_Quantitytem = new Button();
      this.Button_MoreQuantity = new Button();
      this.Button_LessQuantity = new Button();
      this.Button_DirectProduct = new Button();
      this.Button_DeleteItem = new Button();
      this.Button_ObservationItem = new Button();
      this.Label_Total = new Label();
      this.Panel_Products = new Panel();
      this.Button1 = new Button();
      this.Dgrv_OrderOld = new DataGridView();
      this.Timer_Main = new Timer(this.components);
      this.GroupBox_Options = new GroupBox();
      this.btnProductos = new Button();
      this.Button_Discount = new Button();
      this.Button_Pay = new Button();
      this.Button_ShowSale = new Button();
      this.Button_RefreshOrder = new Button();
      this.Button_BillToPay = new Button();
      this.Button_Calculator = new Button();
      this.Label3 = new Label();
      this.TextBox_TypeOrder = new TextBox();
      this.Label_ClientDes = new Label();
      this.lblTotalPedido = new Label();
      this.Panel2 = new Panel();
      this.btnOfertas = new Button();
      this.TextBoxDiscount = new TextBox();
      this.Label2 = new Label();
      this.Label1 = new Label();
      this.TextBox_ClientDes = new TextBox();
      this.Label4 = new Label();
      this.Label5 = new Label();
      this.Label6 = new Label();
      this.TextBox_AmountDiscount = new TextBox();
      this.TextBox_OrderDate = new TextBox();
      this.Label7 = new Label();
      this.Label8 = new Label();
      this.Button_Waiter = new Button();
      this.Label11 = new Label();
      this.TextBox_WaiterId = new TextBox();
      this.TextBox_WaiterDes = new TextBox();
      this.Label_WaiterDes = new Label();
      this.Button_DivideOrder = new Button();
      this.Button_Anticipe = new Button();
      this.Button_Client = new Button();
      this.menCliente = new ContextMenuStrip(this.components);
      this.meiVerCredito = new ToolStripMenuItem();
      this.meiVerDescuentos = new ToolStripMenuItem();
      this.meiQuitarDescuento = new ToolStripMenuItem();
      this.meiEliminarCliente = new ToolStripMenuItem();
      this.meiEliminarContacto = new ToolStripMenuItem();
      this.meiCambioProducto = new ToolStripMenuItem();
      this.TextBox_ClientId = new TextBox();
      this.TextBox_ClientIdentity = new TextBox();
      this.TextBox_WaiterDes_User = new TextBox();
      this.Button_Credits = new Button();
      this.btnVentaManual = new Button();
      this.Label9 = new Label();
      this.txtBuscarxCodigo = new TextBox();
      this.pnlGrupos = new Panel();
      this.btnGruposBuscar = new Button();
      this.pnlSubGrupos = new Panel();
      this.btnSubGruposBuscar = new Button();
      this.StatusStrip_FastBox.SuspendLayout();
      this.Panel1.SuspendLayout();
      ((ISupportInitialize) this.dgrvOrderDetails).BeginInit();
      this.GroupBox_Emissions.SuspendLayout();
      this.Panel4.SuspendLayout();
      this.Panel_Products.SuspendLayout();
      ((ISupportInitialize) this.Dgrv_OrderOld).BeginInit();
      this.Panel2.SuspendLayout();
      this.menCliente.SuspendLayout();
      this.pnlGrupos.SuspendLayout();
      this.pnlSubGrupos.SuspendLayout();
      this.SuspendLayout();
      this.StatusStrip_FastBox.GripStyle = ToolStripGripStyle.Visible;
      this.StatusStrip_FastBox.Items.AddRange(new ToolStripItem[10]
      {
        (ToolStripItem) this.Tssl_Box,
        (ToolStripItem) this.Tssl_Box_Des,
        (ToolStripItem) this.Tssl_Turn,
        (ToolStripItem) this.Tssl_Turn_Des,
        (ToolStripItem) this.Tssl_Order,
        (ToolStripItem) this.Tssl_Order_Des,
        (ToolStripItem) this.Tssl_User,
        (ToolStripItem) this.Tssl_User_Des,
        (ToolStripItem) this.tsslVentaTickets,
        (ToolStripItem) this.Tssl_Date
      });
      this.StatusStrip_FastBox.Location = new Point(0, 713);
      this.StatusStrip_FastBox.Name = "StatusStrip_FastBox";
      this.StatusStrip_FastBox.Size = new Size(1029, 27);
      this.StatusStrip_FastBox.TabIndex = 116;
      this.StatusStrip_FastBox.Text = "StatusStrip2";
      this.Tssl_Box.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Tssl_Box.ForeColor = Color.FromArgb(209, 102, 61);
      this.Tssl_Box.Name = "Tssl_Box";
      this.Tssl_Box.Size = new Size(42, 22);
      this.Tssl_Box.Text = "Caja:";
      this.Tssl_Box_Des.BorderSides = ToolStripStatusLabelBorderSides.Right;
      this.Tssl_Box_Des.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Tssl_Box_Des.ForeColor = Color.Black;
      this.Tssl_Box_Des.Name = "Tssl_Box_Des";
      this.Tssl_Box_Des.Size = new Size(86, 22);
      this.Tssl_Box_Des.Text = "Sin Asignar";
      this.Tssl_Turn.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Tssl_Turn.ForeColor = Color.FromArgb(209, 102, 61);
      this.Tssl_Turn.Name = "Tssl_Turn";
      this.Tssl_Turn.Size = new Size(51, 22);
      this.Tssl_Turn.Text = "Turno:";
      this.Tssl_Turn_Des.BorderSides = ToolStripStatusLabelBorderSides.Right;
      this.Tssl_Turn_Des.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Tssl_Turn_Des.ForeColor = Color.Black;
      this.Tssl_Turn_Des.Name = "Tssl_Turn_Des";
      this.Tssl_Turn_Des.Size = new Size(86, 22);
      this.Tssl_Turn_Des.Text = "Sin Asignar";
      this.Tssl_Order.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Tssl_Order.ForeColor = Color.FromArgb(209, 102, 61);
      this.Tssl_Order.Name = "Tssl_Order";
      this.Tssl_Order.Size = new Size(62, 22);
      this.Tssl_Order.Text = " Pedido:";
      this.Tssl_Order_Des.BorderSides = ToolStripStatusLabelBorderSides.Right;
      this.Tssl_Order_Des.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Tssl_Order_Des.ForeColor = Color.Black;
      this.Tssl_Order_Des.Name = "Tssl_Order_Des";
      this.Tssl_Order_Des.Size = new Size(94, 22);
      this.Tssl_Order_Des.Text = "Por Generar";
      this.Tssl_User.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Tssl_User.ForeColor = Color.FromArgb(209, 102, 61);
      this.Tssl_User.Name = "Tssl_User";
      this.Tssl_User.Size = new Size(64, 22);
      this.Tssl_User.Text = "Usuario:";
      this.Tssl_User_Des.BorderSides = ToolStripStatusLabelBorderSides.Right;
      this.Tssl_User_Des.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Tssl_User_Des.ForeColor = Color.Black;
      this.Tssl_User_Des.Name = "Tssl_User_Des";
      this.Tssl_User_Des.Size = new Size(86, 22);
      this.Tssl_User_Des.Text = "Sin Asignar";
      this.tsslVentaTickets.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.tsslVentaTickets.ForeColor = Color.FromArgb(209, 102, 61);
      this.tsslVentaTickets.Name = "tsslVentaTickets";
      this.tsslVentaTickets.Size = new Size(82, 22);
      this.tsslVentaTickets.Text = "F1: AYUDA";
      this.Tssl_Date.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Tssl_Date.ForeColor = Color.Black;
      this.Tssl_Date.Name = "Tssl_Date";
      this.Tssl_Date.Size = new Size(361, 22);
      this.Tssl_Date.Spring = true;
      this.Tssl_Date.Text = "Fecha";
      this.Tssl_Date.TextAlign = ContentAlignment.TopRight;
      this.l_tsslUserText.Font = new Font("Verdana", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.l_tsslUserText.ForeColor = Color.MediumBlue;
      this.l_tsslUserText.Name = "l_tsslUserText";
      this.l_tsslUserText.Size = new Size(68, 20);
      this.l_tsslUserText.Text = "Usuario:";
      this.p_tsslUserText.BorderSides = ToolStripStatusLabelBorderSides.Right;
      this.p_tsslUserText.Font = new Font("Verdana", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.p_tsslUserText.ForeColor = Color.Red;
      this.p_tsslUserText.Name = "p_tsslUserText";
      this.p_tsslUserText.Size = new Size(93, 20);
      this.p_tsslUserText.Text = "Sin Asignar";
      this.ToolStripStatusLabel2.Font = new Font("Verdana", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.ToolStripStatusLabel2.ForeColor = Color.MediumBlue;
      this.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2";
      this.ToolStripStatusLabel2.Size = new Size(46, 20);
      this.ToolStripStatusLabel2.Text = "Caja:";
      this.p_tsslBoxText.BorderSides = ToolStripStatusLabelBorderSides.Right;
      this.p_tsslBoxText.Font = new Font("Verdana", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.p_tsslBoxText.ForeColor = Color.Red;
      this.p_tsslBoxText.Name = "p_tsslBoxText";
      this.p_tsslBoxText.Size = new Size(93, 20);
      this.p_tsslBoxText.Text = "Sin Asignar";
      this.l_tsslTurnText.Font = new Font("Verdana", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.l_tsslTurnText.ForeColor = Color.MediumBlue;
      this.l_tsslTurnText.Name = "l_tsslTurnText";
      this.l_tsslTurnText.Size = new Size(54, 20);
      this.l_tsslTurnText.Text = "Turno:";
      this.p_tsslTurnText.BorderSides = ToolStripStatusLabelBorderSides.Right;
      this.p_tsslTurnText.Font = new Font("Verdana", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.p_tsslTurnText.ForeColor = Color.Red;
      this.p_tsslTurnText.Name = "p_tsslTurnText";
      this.p_tsslTurnText.Size = new Size(93, 20);
      this.p_tsslTurnText.Text = "Sin Asignar";
      this.l_tsslOrderText.Font = new Font("Verdana", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.l_tsslOrderText.ForeColor = Color.MediumBlue;
      this.l_tsslOrderText.Name = "l_tsslOrderText";
      this.l_tsslOrderText.Size = new Size(57, 20);
      this.l_tsslOrderText.Text = "Orden:";
      this.p_tsslOrderText.BorderSides = ToolStripStatusLabelBorderSides.Right;
      this.p_tsslOrderText.Font = new Font("Verdana", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.p_tsslOrderText.ForeColor = Color.Red;
      this.p_tsslOrderText.Name = "p_tsslOrderText";
      this.p_tsslOrderText.Size = new Size(93, 20);
      this.p_tsslOrderText.Text = "Sin Asignar";
      this.p_tsslDateText.Font = new Font("Verdana", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.p_tsslDateText.ForeColor = Color.MediumBlue;
      this.p_tsslDateText.Name = "p_tsslDateText";
      this.p_tsslDateText.Size = new Size(410, 20);
      this.p_tsslDateText.Spring = true;
      this.p_tsslDateText.TextAlign = ContentAlignment.MiddleRight;
      this.ToolStripStatusLabel_Box.BorderStyle = Border3DStyle.Etched;
      this.ToolStripStatusLabel_Box.Font = new Font("Verdana", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.ToolStripStatusLabel_Box.ForeColor = Color.Red;
      this.ToolStripStatusLabel_Box.Name = "ToolStripStatusLabel_Box";
      this.ToolStripStatusLabel_Box.Size = new Size(46, 20);
      this.ToolStripStatusLabel_Box.Text = "Caja:";
      this.ToolStripStatusLabel_BoxDes.BorderSides = ToolStripStatusLabelBorderSides.Right;
      this.ToolStripStatusLabel_BoxDes.Font = new Font("Verdana", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.ToolStripStatusLabel_BoxDes.ForeColor = Color.MediumBlue;
      this.ToolStripStatusLabel_BoxDes.Name = "ToolStripStatusLabel_BoxDes";
      this.ToolStripStatusLabel_BoxDes.Size = new Size(78, 20);
      this.ToolStripStatusLabel_BoxDes.Text = "Caja One";
      this.tsslTurnValue.BorderStyle = Border3DStyle.Etched;
      this.tsslTurnValue.Font = new Font("Verdana", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.tsslTurnValue.ForeColor = Color.Red;
      this.tsslTurnValue.Name = "tsslTurnValue";
      this.tsslTurnValue.Size = new Size(54, 20);
      this.tsslTurnValue.Text = "Turno:";
      this.ToolStripStatusLabel_TurnDes.BorderSides = ToolStripStatusLabelBorderSides.Right;
      this.ToolStripStatusLabel_TurnDes.Font = new Font("Verdana", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.ToolStripStatusLabel_TurnDes.ForeColor = Color.MediumBlue;
      this.ToolStripStatusLabel_TurnDes.Name = "ToolStripStatusLabel_TurnDes";
      this.ToolStripStatusLabel_TurnDes.Size = new Size(93, 20);
      this.ToolStripStatusLabel_TurnDes.Text = "000000000";
      this.ToolStripStatusLabel_WaiterValue.Font = new Font("Verdana", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.ToolStripStatusLabel_WaiterValue.ForeColor = Color.Red;
      this.ToolStripStatusLabel_WaiterValue.Name = "ToolStripStatusLabel_WaiterValue";
      this.ToolStripStatusLabel_WaiterValue.Size = new Size(68, 20);
      this.ToolStripStatusLabel_WaiterValue.Text = "Usuario:";
      this.ToolStripStatusLabel_UserDes.BorderSides = ToolStripStatusLabelBorderSides.Right;
      this.ToolStripStatusLabel_UserDes.Font = new Font("Verdana", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.ToolStripStatusLabel_UserDes.ForeColor = Color.MediumBlue;
      this.ToolStripStatusLabel_UserDes.Name = "ToolStripStatusLabel_UserDes";
      this.ToolStripStatusLabel_UserDes.Size = new Size(73, 20);
      this.ToolStripStatusLabel_UserDes.Text = "Cajero 1";
      this.ToolStripStatusLabel1.Font = new Font("Verdana", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.ToolStripStatusLabel1.ForeColor = Color.Red;
      this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
      this.ToolStripStatusLabel1.Size = new Size(57, 20);
      this.ToolStripStatusLabel1.Text = "Orden:";
      this.ToolStripStatusLabel_OrderDes.BorderSides = ToolStripStatusLabelBorderSides.Right;
      this.ToolStripStatusLabel_OrderDes.Font = new Font("Verdana", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.ToolStripStatusLabel_OrderDes.ForeColor = Color.MediumBlue;
      this.ToolStripStatusLabel_OrderDes.Name = "ToolStripStatusLabel_OrderDes";
      this.ToolStripStatusLabel_OrderDes.Size = new Size(89, 20);
      this.ToolStripStatusLabel_OrderDes.Text = "Sr Johaten";
      this.tsslFechaText.Font = new Font("Verdana", 9.75f, FontStyle.Bold);
      this.tsslFechaText.ForeColor = Color.MediumBlue;
      this.tsslFechaText.Name = "tsslFechaText";
      this.tsslFechaText.Size = new Size(449, 20);
      this.tsslFechaText.Spring = true;
      this.tsslFechaText.Text = "Fecha";
      this.tsslFechaText.TextAlign = ContentAlignment.BottomRight;
      this.tsslFechaText.TextImageRelation = TextImageRelation.TextBeforeImage;
      this.BottomToolStripPanel.Location = new Point(0, 0);
      this.BottomToolStripPanel.Name = "BottomToolStripPanel";
      this.BottomToolStripPanel.Orientation = Orientation.Horizontal;
      this.BottomToolStripPanel.RowMargin = new Padding(3, 0, 0, 0);
      this.BottomToolStripPanel.Size = new Size(0, 0);
      this.TopToolStripPanel.Location = new Point(0, 0);
      this.TopToolStripPanel.Name = "TopToolStripPanel";
      this.TopToolStripPanel.Orientation = Orientation.Horizontal;
      this.TopToolStripPanel.RowMargin = new Padding(3, 0, 0, 0);
      this.TopToolStripPanel.Size = new Size(0, 0);
      this.RightToolStripPanel.Location = new Point(0, 0);
      this.RightToolStripPanel.Name = "RightToolStripPanel";
      this.RightToolStripPanel.Orientation = Orientation.Horizontal;
      this.RightToolStripPanel.RowMargin = new Padding(3, 0, 0, 0);
      this.RightToolStripPanel.Size = new Size(0, 0);
      this.LeftToolStripPanel.Location = new Point(0, 0);
      this.LeftToolStripPanel.Name = "LeftToolStripPanel";
      this.LeftToolStripPanel.Orientation = Orientation.Horizontal;
      this.LeftToolStripPanel.RowMargin = new Padding(3, 0, 0, 0);
      this.LeftToolStripPanel.Size = new Size(0, 0);
      this.ContentPanel.Size = new Size(425, 298);
      this.Panel1.Controls.Add((Control) this.MyXpButton_OrderDetails_Text);
      this.Panel1.Controls.Add((Control) this.dgrvOrderDetails);
      this.Panel1.Location = new Point(0, -3);
      this.Panel1.Name = "Panel1";
      this.Panel1.Size = new Size(623, 397);
      this.Panel1.TabIndex = 117;
      this.MyXpButton_OrderDetails_Text.BackColor = Color.FromArgb(209, 102, 61);
      this.MyXpButton_OrderDetails_Text.FlatStyle = FlatStyle.Flat;
      this.MyXpButton_OrderDetails_Text.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.MyXpButton_OrderDetails_Text.ForeColor = Color.WhiteSmoke;
      this.MyXpButton_OrderDetails_Text.Location = new Point(2, 3);
      this.MyXpButton_OrderDetails_Text.Name = "MyXpButton_OrderDetails_Text";
      this.MyXpButton_OrderDetails_Text.Size = new Size(597, 29);
      this.MyXpButton_OrderDetails_Text.TabIndex = 235;
      this.MyXpButton_OrderDetails_Text.Text = "Orden: 090000896434";
      this.MyXpButton_OrderDetails_Text.UseCompatibleTextRendering = true;
      this.MyXpButton_OrderDetails_Text.UseVisualStyleBackColor = false;
      this.dgrvOrderDetails.BackgroundColor = Color.LightGray;
      gridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
      gridViewCellStyle1.BackColor = Color.FromArgb(192, 192, (int) byte.MaxValue);
      gridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      gridViewCellStyle1.ForeColor = SystemColors.WindowText;
      gridViewCellStyle1.NullValue = (object) "johan";
      gridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
      gridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
      gridViewCellStyle1.WrapMode = DataGridViewTriState.True;
      this.dgrvOrderDetails.ColumnHeadersDefaultCellStyle = gridViewCellStyle1;
      this.dgrvOrderDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
      gridViewCellStyle2.BackColor = SystemColors.Window;
      gridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      gridViewCellStyle2.ForeColor = SystemColors.ControlText;
      gridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
      gridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
      gridViewCellStyle2.WrapMode = DataGridViewTriState.False;
      this.dgrvOrderDetails.DefaultCellStyle = gridViewCellStyle2;
      this.dgrvOrderDetails.Location = new Point(1, 31);
      this.dgrvOrderDetails.Name = "dgrvOrderDetails";
      this.dgrvOrderDetails.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
      gridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
      gridViewCellStyle3.BackColor = SystemColors.Control;
      gridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      gridViewCellStyle3.ForeColor = SystemColors.WindowText;
      gridViewCellStyle3.NullValue = (object) "sdds";
      gridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
      gridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
      gridViewCellStyle3.WrapMode = DataGridViewTriState.True;
      this.dgrvOrderDetails.RowHeadersDefaultCellStyle = gridViewCellStyle3;
      this.dgrvOrderDetails.RowHeadersWidth = 10;
      this.dgrvOrderDetails.ScrollBars = ScrollBars.None;
      this.dgrvOrderDetails.Size = new Size(595, 364);
      this.dgrvOrderDetails.TabIndex = 129;
      this.Button_ReSendCommand.BackgroundImage = (Image) componentResourceManager.GetObject("Button_ReSendCommand.BackgroundImage");
      this.Button_ReSendCommand.FlatStyle = FlatStyle.Flat;
      this.Button_ReSendCommand.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button_ReSendCommand.ForeColor = Color.WhiteSmoke;
      this.Button_ReSendCommand.Image = (Image) TriNetRestPOS.My.Resources.Resources.reenv_oc_icono;
      this.Button_ReSendCommand.ImageAlign = ContentAlignment.TopCenter;
      this.Button_ReSendCommand.Location = new Point(0, 330);
      this.Button_ReSendCommand.Name = "Button_ReSendCommand";
      this.Button_ReSendCommand.Padding = new Padding(0, 3, 0, 3);
      this.Button_ReSendCommand.RightToLeft = RightToLeft.Yes;
      this.Button_ReSendCommand.Size = new Size(70, 64);
      this.Button_ReSendCommand.TabIndex = 6;
      this.Button_ReSendCommand.Text = "Re-Env";
      this.Button_ReSendCommand.TextAlign = ContentAlignment.BottomCenter;
      this.Button_ReSendCommand.UseVisualStyleBackColor = true;
      this.Button_SendCommand.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.boto_oc_verde_icono;
      this.Button_SendCommand.FlatStyle = FlatStyle.Flat;
      this.Button_SendCommand.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button_SendCommand.ForeColor = Color.WhiteSmoke;
      this.Button_SendCommand.Image = (Image) TriNetRestPOS.My.Resources.Resources.reenv_oc_icono;
      this.Button_SendCommand.ImageAlign = ContentAlignment.TopCenter;
      this.Button_SendCommand.Location = new Point(0, 263);
      this.Button_SendCommand.Name = "Button_SendCommand";
      this.Button_SendCommand.Padding = new Padding(0, 3, 0, 3);
      this.Button_SendCommand.RightToLeft = RightToLeft.Yes;
      this.Button_SendCommand.Size = new Size(70, 64);
      this.Button_SendCommand.TabIndex = 5;
      this.Button_SendCommand.Tag = (object) "&Enviar C";
      this.Button_SendCommand.Text = "Enviar";
      this.Button_SendCommand.TextAlign = ContentAlignment.BottomCenter;
      this.Button_SendCommand.UseVisualStyleBackColor = true;
      this.Button_SearchItem.BackgroundImage = (Image) componentResourceManager.GetObject("Button_SearchItem.BackgroundImage");
      this.Button_SearchItem.FlatStyle = FlatStyle.Flat;
      this.Button_SearchItem.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button_SearchItem.ForeColor = Color.WhiteSmoke;
      this.Button_SearchItem.Image = (Image) TriNetRestPOS.My.Resources.Resources.observacion_icn;
      this.Button_SearchItem.ImageAlign = ContentAlignment.TopCenter;
      this.Button_SearchItem.Location = new Point(0, 1);
      this.Button_SearchItem.Name = "Button_SearchItem";
      this.Button_SearchItem.Padding = new Padding(0, 1, 0, 3);
      this.Button_SearchItem.Size = new Size(70, 64);
      this.Button_SearchItem.TabIndex = 0;
      this.Button_SearchItem.Text = "Stock";
      this.Button_SearchItem.TextAlign = ContentAlignment.BottomCenter;
      this.Button_SearchItem.UseVisualStyleBackColor = true;
      this.Button_OrdersDetailsN.BackgroundImage = (Image) componentResourceManager.GetObject("Button_OrdersDetailsN.BackgroundImage");
      this.Button_OrdersDetailsN.FlatStyle = FlatStyle.Flat;
      this.Button_OrdersDetailsN.Font = new Font("Verdana", 18f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_OrdersDetailsN.ForeColor = Color.WhiteSmoke;
      this.Button_OrdersDetailsN.Image = (Image) TriNetRestPOS.My.Resources.Resources.flecha_abajo;
      this.Button_OrdersDetailsN.Location = new Point(0, 196);
      this.Button_OrdersDetailsN.Name = "Button_OrdersDetailsN";
      this.Button_OrdersDetailsN.RightToLeft = RightToLeft.Yes;
      this.Button_OrdersDetailsN.Size = new Size(70, 64);
      this.Button_OrdersDetailsN.TabIndex = 3;
      this.Button_OrdersDetailsN.UseVisualStyleBackColor = true;
      this.Button_OrdersDetailsL.Font = new Font("Verdana", 18f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_OrdersDetailsL.Image = (Image) TriNetRestPOS.My.Resources.Resources.fast_forward;
      this.Button_OrdersDetailsL.Location = new Point(0, 239);
      this.Button_OrdersDetailsL.Name = "Button_OrdersDetailsL";
      this.Button_OrdersDetailsL.RightToLeft = RightToLeft.Yes;
      this.Button_OrdersDetailsL.Size = new Size(70, 43);
      this.Button_OrdersDetailsL.TabIndex = 4;
      this.Button_OrdersDetailsL.UseVisualStyleBackColor = true;
      this.Button_OrdersDetailsL.Visible = false;
      this.Button_OrdersDetailsF.Font = new Font("Verdana", 18f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_OrdersDetailsF.Image = (Image) TriNetRestPOS.My.Resources.Resources.Fast_back;
      this.Button_OrdersDetailsF.Location = new Point(0, 113);
      this.Button_OrdersDetailsF.Name = "Button_OrdersDetailsF";
      this.Button_OrdersDetailsF.RightToLeft = RightToLeft.Yes;
      this.Button_OrdersDetailsF.Size = new Size(70, 43);
      this.Button_OrdersDetailsF.TabIndex = 1;
      this.Button_OrdersDetailsF.UseVisualStyleBackColor = true;
      this.Button_OrdersDetailsF.Visible = false;
      this.Button_OrdersDetailsB.BackgroundImage = (Image) componentResourceManager.GetObject("Button_OrdersDetailsB.BackgroundImage");
      this.Button_OrdersDetailsB.FlatStyle = FlatStyle.Flat;
      this.Button_OrdersDetailsB.Font = new Font("Verdana", 18f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_OrdersDetailsB.ForeColor = Color.WhiteSmoke;
      this.Button_OrdersDetailsB.Image = (Image) TriNetRestPOS.My.Resources.Resources.flecha_arriba;
      this.Button_OrdersDetailsB.Location = new Point(0, 131);
      this.Button_OrdersDetailsB.Name = "Button_OrdersDetailsB";
      this.Button_OrdersDetailsB.RightToLeft = RightToLeft.Yes;
      this.Button_OrdersDetailsB.Size = new Size(70, 64);
      this.Button_OrdersDetailsB.TabIndex = 2;
      this.Button_OrdersDetailsB.UseVisualStyleBackColor = true;
      this.GroupBox_Emissions.Controls.Add((Control) this.Button_Precuenta);
      this.GroupBox_Emissions.Controls.Add((Control) this.Button_CreateTicket);
      this.GroupBox_Emissions.Controls.Add((Control) this.Button_CreateInvoice);
      this.GroupBox_Emissions.Controls.Add((Control) this.MyXPButton_Pay);
      this.GroupBox_Emissions.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.GroupBox_Emissions.ForeColor = Color.Red;
      this.GroupBox_Emissions.Location = new Point(667, 383);
      this.GroupBox_Emissions.Name = "GroupBox_Emissions";
      this.GroupBox_Emissions.Size = new Size(362, 69);
      this.GroupBox_Emissions.TabIndex = 22;
      this.GroupBox_Emissions.TabStop = false;
      this.Button_Precuenta.BackColor = Color.FromArgb(96, 96, 96);
      this.Button_Precuenta.FlatAppearance.BorderSize = 0;
      this.Button_Precuenta.FlatStyle = FlatStyle.Flat;
      this.Button_Precuenta.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0, true);
      this.Button_Precuenta.ForeColor = Color.White;
      this.Button_Precuenta.Location = new Point(5, 9);
      this.Button_Precuenta.Name = "Button_Precuenta";
      this.Button_Precuenta.Size = new Size(88, 57);
      this.Button_Precuenta.TabIndex = 238;
      this.Button_Precuenta.Text = "PRE-CUENT\r\nF5";
      this.Button_Precuenta.UseVisualStyleBackColor = false;
      this.Button_CreateTicket.BackColor = Color.FromArgb(96, 96, 96);
      this.Button_CreateTicket.FlatAppearance.BorderSize = 0;
      this.Button_CreateTicket.FlatStyle = FlatStyle.Flat;
      this.Button_CreateTicket.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0, true);
      this.Button_CreateTicket.ForeColor = Color.White;
      this.Button_CreateTicket.Location = new Point(94, 9);
      this.Button_CreateTicket.Name = "Button_CreateTicket";
      this.Button_CreateTicket.Size = new Size(88, 57);
      this.Button_CreateTicket.TabIndex = 237;
      this.Button_CreateTicket.Text = "TICKET\r\nF6";
      this.Button_CreateTicket.UseVisualStyleBackColor = false;
      this.Button_CreateInvoice.BackColor = Color.FromArgb(96, 96, 96);
      this.Button_CreateInvoice.FlatAppearance.BorderSize = 0;
      this.Button_CreateInvoice.FlatStyle = FlatStyle.Flat;
      this.Button_CreateInvoice.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0, true);
      this.Button_CreateInvoice.ForeColor = Color.White;
      this.Button_CreateInvoice.Location = new Point(183, 9);
      this.Button_CreateInvoice.Name = "Button_CreateInvoice";
      this.Button_CreateInvoice.Size = new Size(88, 57);
      this.Button_CreateInvoice.TabIndex = 236;
      this.Button_CreateInvoice.Text = "FACTURA\r\nF7";
      this.Button_CreateInvoice.UseVisualStyleBackColor = false;
      this.MyXPButton_Pay.BackColor = Color.FromArgb(96, 96, 96);
      this.MyXPButton_Pay.FlatAppearance.BorderSize = 0;
      this.MyXPButton_Pay.FlatStyle = FlatStyle.Flat;
      this.MyXPButton_Pay.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0, true);
      this.MyXPButton_Pay.ForeColor = Color.White;
      this.MyXPButton_Pay.Location = new Point(272, 9);
      this.MyXPButton_Pay.Name = "MyXPButton_Pay";
      this.MyXPButton_Pay.Size = new Size(88, 57);
      this.MyXPButton_Pay.TabIndex = 235;
      this.MyXPButton_Pay.Text = "PAGOS\r\nF8";
      this.MyXPButton_Pay.UseVisualStyleBackColor = false;
      this.GroupBox_OptionOrders.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.GroupBox_OptionOrders.ForeColor = Color.Red;
      this.GroupBox_OptionOrders.Location = new Point(993, -3);
      this.GroupBox_OptionOrders.Name = "GroupBox_OptionOrders";
      this.GroupBox_OptionOrders.Size = new Size(36, 24);
      this.GroupBox_OptionOrders.TabIndex = 176;
      this.GroupBox_OptionOrders.TabStop = false;
      this.GroupBox_OptionOrders.Text = "Opciones del Pedido";
      this.GroupBox_OptionOrders.Visible = false;
      this.Button_ElegirNuevoPedido.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.boton_gris4;
      this.Button_ElegirNuevoPedido.FlatStyle = FlatStyle.Flat;
      this.Button_ElegirNuevoPedido.Font = new Font("Trebuchet MS", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button_ElegirNuevoPedido.ForeColor = Color.WhiteSmoke;
      this.Button_ElegirNuevoPedido.Image = (Image) TriNetRestPOS.My.Resources.Resources.observacion_icn;
      this.Button_ElegirNuevoPedido.ImageAlign = ContentAlignment.TopCenter;
      this.Button_ElegirNuevoPedido.Location = new Point(759, 0);
      this.Button_ElegirNuevoPedido.Name = "Button_ElegirNuevoPedido";
      this.Button_ElegirNuevoPedido.Padding = new Padding(0, 3, 0, 3);
      this.Button_ElegirNuevoPedido.Size = new Size(88, 55);
      this.Button_ElegirNuevoPedido.TabIndex = 1;
      this.Button_ElegirNuevoPedido.Text = "Elegir Ped";
      this.Button_ElegirNuevoPedido.TextAlign = ContentAlignment.BottomCenter;
      this.Button_ElegirNuevoPedido.UseVisualStyleBackColor = true;
      this.Button_NewOrder.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.boton_gris4;
      this.Button_NewOrder.FlatStyle = FlatStyle.Flat;
      this.Button_NewOrder.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button_NewOrder.ForeColor = Color.WhiteSmoke;
      this.Button_NewOrder.Image = (Image) TriNetRestPOS.My.Resources.Resources.icono_nuevo;
      this.Button_NewOrder.ImageAlign = ContentAlignment.TopCenter;
      this.Button_NewOrder.Location = new Point(670, 0);
      this.Button_NewOrder.Name = "Button_NewOrder";
      this.Button_NewOrder.Padding = new Padding(0, 3, 0, 3);
      this.Button_NewOrder.Size = new Size(88, 55);
      this.Button_NewOrder.TabIndex = 0;
      this.Button_NewOrder.Text = "Nuevo";
      this.Button_NewOrder.TextAlign = ContentAlignment.BottomCenter;
      this.Button_NewOrder.UseVisualStyleBackColor = true;
      this.Button_DeleteOrder.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.bton_rojo4;
      this.Button_DeleteOrder.FlatStyle = FlatStyle.Flat;
      this.Button_DeleteOrder.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button_DeleteOrder.ForeColor = Color.WhiteSmoke;
      this.Button_DeleteOrder.Image = (Image) TriNetRestPOS.My.Resources.Resources.eliminar_icono;
      this.Button_DeleteOrder.ImageAlign = ContentAlignment.TopCenter;
      this.Button_DeleteOrder.Location = new Point(850, 0);
      this.Button_DeleteOrder.Name = "Button_DeleteOrder";
      this.Button_DeleteOrder.Padding = new Padding(0, 3, 0, 3);
      this.Button_DeleteOrder.RightToLeft = RightToLeft.Yes;
      this.Button_DeleteOrder.Size = new Size(88, 55);
      this.Button_DeleteOrder.TabIndex = 2;
      this.Button_DeleteOrder.Text = "Eliminar";
      this.Button_DeleteOrder.TextAlign = ContentAlignment.BottomCenter;
      this.Button_DeleteOrder.UseVisualStyleBackColor = true;
      this.Button_GoOut.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.bton_rojo4;
      this.Button_GoOut.FlatStyle = FlatStyle.Flat;
      this.Button_GoOut.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button_GoOut.ForeColor = Color.WhiteSmoke;
      this.Button_GoOut.Image = (Image) TriNetRestPOS.My.Resources.Resources.salir;
      this.Button_GoOut.ImageAlign = ContentAlignment.TopCenter;
      this.Button_GoOut.Location = new Point(939, 0);
      this.Button_GoOut.Name = "Button_GoOut";
      this.Button_GoOut.Padding = new Padding(0, 3, 0, 3);
      this.Button_GoOut.Size = new Size(88, 55);
      this.Button_GoOut.TabIndex = 3;
      this.Button_GoOut.Text = "Salir";
      this.Button_GoOut.TextAlign = ContentAlignment.BottomCenter;
      this.Button_GoOut.UseVisualStyleBackColor = true;
      this.Button_SearchOrder.Font = new Font("Verdana", 8.25f, FontStyle.Bold);
      this.Button_SearchOrder.ForeColor = Color.MediumBlue;
      this.Button_SearchOrder.Image = (Image) TriNetRestPOS.My.Resources.Resources.Search_S;
      this.Button_SearchOrder.Location = new Point(941, 8);
      this.Button_SearchOrder.Name = "Button_SearchOrder";
      this.Button_SearchOrder.Size = new Size(31, 16);
      this.Button_SearchOrder.TabIndex = 3;
      this.Button_SearchOrder.Text = "&Buscar";
      this.Button_SearchOrder.TextImageRelation = TextImageRelation.TextAboveImage;
      this.Button_SearchOrder.UseVisualStyleBackColor = true;
      this.Button_SearchOrder.Visible = false;
      this.TextBox_OrderId.BackColor = Color.White;
      this.TextBox_OrderId.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.TextBox_OrderId.Location = new Point(757, 93);
      this.TextBox_OrderId.Multiline = true;
      this.TextBox_OrderId.Name = "TextBox_OrderId";
      this.TextBox_OrderId.ReadOnly = true;
      this.TextBox_OrderId.Size = new Size(181, 25);
      this.TextBox_OrderId.TabIndex = 6;
      this.Panel4.Controls.Add((Control) this.Button_Disaggregate);
      this.Panel4.Controls.Add((Control) this.Button_ChangePrice);
      this.Panel4.Controls.Add((Control) this.Button_Quantitytem);
      this.Panel4.Controls.Add((Control) this.Button_MoreQuantity);
      this.Panel4.Controls.Add((Control) this.Button_LessQuantity);
      this.Panel4.Controls.Add((Control) this.Button_DirectProduct);
      this.Panel4.Controls.Add((Control) this.Button_DeleteItem);
      this.Panel4.Controls.Add((Control) this.Button_ObservationItem);
      this.Panel4.Location = new Point(2, 392);
      this.Panel4.Name = "Panel4";
      this.Panel4.Size = new Size(552, 57);
      this.Panel4.TabIndex = 179;
      this.Button_Disaggregate.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.monto8;
      this.Button_Disaggregate.FlatStyle = FlatStyle.Flat;
      this.Button_Disaggregate.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button_Disaggregate.ForeColor = Color.WhiteSmoke;
      this.Button_Disaggregate.Image = (Image) TriNetRestPOS.My.Resources.Resources.observ_oc_icono;
      this.Button_Disaggregate.ImageAlign = ContentAlignment.TopCenter;
      this.Button_Disaggregate.Location = new Point(-1, 0);
      this.Button_Disaggregate.Name = "Button_Disaggregate";
      this.Button_Disaggregate.Padding = new Padding(0, 3, 0, 3);
      this.Button_Disaggregate.Size = new Size(70, 57);
      this.Button_Disaggregate.TabIndex = 0;
      this.Button_Disaggregate.Text = "Disgre";
      this.Button_Disaggregate.TextAlign = ContentAlignment.BottomCenter;
      this.Button_Disaggregate.UseVisualStyleBackColor = true;
      this.Button_ChangePrice.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.monto8;
      this.Button_ChangePrice.FlatStyle = FlatStyle.Flat;
      this.Button_ChangePrice.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button_ChangePrice.ForeColor = Color.WhiteSmoke;
      this.Button_ChangePrice.Image = (Image) TriNetRestPOS.My.Resources.Resources.dolar_oc_icono;
      this.Button_ChangePrice.ImageAlign = ContentAlignment.TopCenter;
      this.Button_ChangePrice.Location = new Point(68, 0);
      this.Button_ChangePrice.Name = "Button_ChangePrice";
      this.Button_ChangePrice.Padding = new Padding(0, 3, 0, 3);
      this.Button_ChangePrice.Size = new Size(70, 57);
      this.Button_ChangePrice.TabIndex = 1;
      this.Button_ChangePrice.Text = "Precio";
      this.Button_ChangePrice.TextAlign = ContentAlignment.BottomCenter;
      this.Button_ChangePrice.UseVisualStyleBackColor = true;
      this.Button_Quantitytem.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.monto8;
      this.Button_Quantitytem.FlatStyle = FlatStyle.Flat;
      this.Button_Quantitytem.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button_Quantitytem.ForeColor = Color.WhiteSmoke;
      this.Button_Quantitytem.Image = (Image) TriNetRestPOS.My.Resources.Resources.cantidad_oc_icono;
      this.Button_Quantitytem.ImageAlign = ContentAlignment.TopCenter;
      this.Button_Quantitytem.Location = new Point(344, 0);
      this.Button_Quantitytem.Name = "Button_Quantitytem";
      this.Button_Quantitytem.Padding = new Padding(0, 3, 0, 3);
      this.Button_Quantitytem.RightToLeft = RightToLeft.Yes;
      this.Button_Quantitytem.Size = new Size(70, 57);
      this.Button_Quantitytem.TabIndex = 5;
      this.Button_Quantitytem.Text = "&Cantida";
      this.Button_Quantitytem.TextAlign = ContentAlignment.BottomCenter;
      this.Button_Quantitytem.UseVisualStyleBackColor = true;
      this.Button_MoreQuantity.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.guardar8;
      this.Button_MoreQuantity.FlatStyle = FlatStyle.Flat;
      this.Button_MoreQuantity.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button_MoreQuantity.ForeColor = Color.WhiteSmoke;
      this.Button_MoreQuantity.Image = (Image) TriNetRestPOS.My.Resources.Resources.suma_oc_icono;
      this.Button_MoreQuantity.ImageAlign = ContentAlignment.TopCenter;
      this.Button_MoreQuantity.Location = new Point(137, 0);
      this.Button_MoreQuantity.Name = "Button_MoreQuantity";
      this.Button_MoreQuantity.Padding = new Padding(0, 3, 0, 3);
      this.Button_MoreQuantity.RightToLeft = RightToLeft.Yes;
      this.Button_MoreQuantity.Size = new Size(70, 57);
      this.Button_MoreQuantity.TabIndex = 2;
      this.Button_MoreQuantity.Text = "Agrega";
      this.Button_MoreQuantity.TextAlign = ContentAlignment.BottomCenter;
      this.Button_MoreQuantity.UseVisualStyleBackColor = true;
      this.Button_LessQuantity.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.atras8;
      this.Button_LessQuantity.FlatStyle = FlatStyle.Flat;
      this.Button_LessQuantity.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button_LessQuantity.ForeColor = Color.WhiteSmoke;
      this.Button_LessQuantity.Image = (Image) TriNetRestPOS.My.Resources.Resources.resta_oc_icono;
      this.Button_LessQuantity.ImageAlign = ContentAlignment.TopCenter;
      this.Button_LessQuantity.Location = new Point(206, 0);
      this.Button_LessQuantity.Name = "Button_LessQuantity";
      this.Button_LessQuantity.Padding = new Padding(0, 10, 0, 3);
      this.Button_LessQuantity.RightToLeft = RightToLeft.Yes;
      this.Button_LessQuantity.Size = new Size(70, 57);
      this.Button_LessQuantity.TabIndex = 3;
      this.Button_LessQuantity.Text = "Dismin";
      this.Button_LessQuantity.TextAlign = ContentAlignment.BottomCenter;
      this.Button_LessQuantity.UseVisualStyleBackColor = true;
      this.Button_DirectProduct.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.observar8;
      this.Button_DirectProduct.FlatStyle = FlatStyle.Flat;
      this.Button_DirectProduct.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button_DirectProduct.ForeColor = Color.WhiteSmoke;
      this.Button_DirectProduct.Image = (Image) TriNetRestPOS.My.Resources.Resources.product_icon;
      this.Button_DirectProduct.ImageAlign = ContentAlignment.TopCenter;
      this.Button_DirectProduct.Location = new Point(482, 0);
      this.Button_DirectProduct.Name = "Button_DirectProduct";
      this.Button_DirectProduct.Padding = new Padding(0, 3, 0, 3);
      this.Button_DirectProduct.RightToLeft = RightToLeft.Yes;
      this.Button_DirectProduct.Size = new Size(70, 57);
      this.Button_DirectProduct.TabIndex = 7;
      this.Button_DirectProduct.Text = "Produc";
      this.Button_DirectProduct.TextAlign = ContentAlignment.BottomCenter;
      this.Button_DirectProduct.UseVisualStyleBackColor = true;
      this.Button_DeleteItem.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.atras8;
      this.Button_DeleteItem.FlatStyle = FlatStyle.Flat;
      this.Button_DeleteItem.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button_DeleteItem.ForeColor = Color.WhiteSmoke;
      this.Button_DeleteItem.Image = (Image) TriNetRestPOS.My.Resources.Resources.eliminar_icono;
      this.Button_DeleteItem.ImageAlign = ContentAlignment.TopCenter;
      this.Button_DeleteItem.Location = new Point(275, 0);
      this.Button_DeleteItem.Name = "Button_DeleteItem";
      this.Button_DeleteItem.Padding = new Padding(0, 3, 0, 3);
      this.Button_DeleteItem.RightToLeft = RightToLeft.Yes;
      this.Button_DeleteItem.Size = new Size(70, 57);
      this.Button_DeleteItem.TabIndex = 4;
      this.Button_DeleteItem.Text = "Elimina\r\n";
      this.Button_DeleteItem.TextAlign = ContentAlignment.BottomCenter;
      this.Button_DeleteItem.UseVisualStyleBackColor = true;
      this.Button_ObservationItem.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.monto8;
      this.Button_ObservationItem.FlatStyle = FlatStyle.Flat;
      this.Button_ObservationItem.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button_ObservationItem.ForeColor = Color.WhiteSmoke;
      this.Button_ObservationItem.Image = (Image) TriNetRestPOS.My.Resources.Resources.observ_oc_icono;
      this.Button_ObservationItem.ImageAlign = ContentAlignment.TopCenter;
      this.Button_ObservationItem.Location = new Point(413, 0);
      this.Button_ObservationItem.Name = "Button_ObservationItem";
      this.Button_ObservationItem.Padding = new Padding(0, 3, 0, 3);
      this.Button_ObservationItem.RightToLeft = RightToLeft.Yes;
      this.Button_ObservationItem.Size = new Size(70, 57);
      this.Button_ObservationItem.TabIndex = 6;
      this.Button_ObservationItem.Text = "&Obser";
      this.Button_ObservationItem.TextAlign = ContentAlignment.BottomCenter;
      this.Button_ObservationItem.UseVisualStyleBackColor = true;
      this.Label_Total.AutoSize = true;
      this.Label_Total.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label_Total.ForeColor = Color.FromArgb(100, 100, 100);
      this.Label_Total.Location = new Point(556, 394);
      this.Label_Total.Name = "Label_Total";
      this.Label_Total.Size = new Size(45, 18);
      this.Label_Total.TabIndex = 181;
      this.Label_Total.Text = "Total:";
      this.Panel_Products.Controls.Add((Control) this.Button1);
      this.Panel_Products.Controls.Add((Control) this.Button_SearchOrder);
      this.Panel_Products.Controls.Add((Control) this.Dgrv_OrderOld);
      this.Panel_Products.Location = new Point(328, 449);
      this.Panel_Products.Name = "Panel_Products";
      this.Panel_Products.Size = new Size(701, 263);
      this.Panel_Products.TabIndex = 182;
      this.Button1.BackColor = Color.FromArgb(209, 102, 61);
      this.Button1.FlatStyle = FlatStyle.Flat;
      this.Button1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button1.ForeColor = Color.WhiteSmoke;
      this.Button1.Location = new Point(677, 0);
      this.Button1.Name = "Button1";
      this.Button1.Size = new Size(21, 262);
      this.Button1.TabIndex = 186;
      this.Button1.Text = "PRODUCTOS";
      this.Button1.UseCompatibleTextRendering = true;
      this.Button1.UseVisualStyleBackColor = false;
      this.Dgrv_OrderOld.BackgroundColor = Color.LightGray;
      gridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
      gridViewCellStyle4.BackColor = Color.FromArgb(192, 192, (int) byte.MaxValue);
      gridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      gridViewCellStyle4.ForeColor = SystemColors.WindowText;
      gridViewCellStyle4.NullValue = (object) "johan";
      gridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
      gridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
      gridViewCellStyle4.WrapMode = DataGridViewTriState.True;
      this.Dgrv_OrderOld.ColumnHeadersDefaultCellStyle = gridViewCellStyle4;
      this.Dgrv_OrderOld.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.Dgrv_OrderOld.Location = new Point(992, 6);
      this.Dgrv_OrderOld.Name = "Dgrv_OrderOld";
      this.Dgrv_OrderOld.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
      gridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
      gridViewCellStyle5.BackColor = SystemColors.Control;
      gridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      gridViewCellStyle5.ForeColor = SystemColors.WindowText;
      gridViewCellStyle5.NullValue = (object) "sdds";
      gridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
      gridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
      gridViewCellStyle5.WrapMode = DataGridViewTriState.True;
      this.Dgrv_OrderOld.RowHeadersDefaultCellStyle = gridViewCellStyle5;
      this.Dgrv_OrderOld.RowHeadersWidth = 10;
      this.Dgrv_OrderOld.ScrollBars = ScrollBars.None;
      this.Dgrv_OrderOld.Size = new Size(13, 18);
      this.Dgrv_OrderOld.TabIndex = 185;
      this.Dgrv_OrderOld.Visible = false;
      this.Timer_Main.Interval = 1000;
      this.GroupBox_Options.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.GroupBox_Options.ForeColor = Color.Red;
      this.GroupBox_Options.Location = new Point(994, 188);
      this.GroupBox_Options.Name = "GroupBox_Options";
      this.GroupBox_Options.Size = new Size(36, 37);
      this.GroupBox_Options.TabIndex = 183;
      this.GroupBox_Options.TabStop = false;
      this.GroupBox_Options.Text = "Opciones ";
      this.GroupBox_Options.Visible = false;
      this.btnProductos.BackColor = Color.FromArgb(209, 102, 61);
      this.btnProductos.FlatStyle = FlatStyle.Flat;
      this.btnProductos.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnProductos.ForeColor = Color.WhiteSmoke;
      this.btnProductos.Image = (Image) TriNetRestPOS.My.Resources.Resources.maestros_op_icono;
      this.btnProductos.Location = new Point(759, 251);
      this.btnProductos.Name = "btnProductos";
      this.btnProductos.Size = new Size(88, 55);
      this.btnProductos.TabIndex = 15;
      this.btnProductos.Text = "&Productos";
      this.btnProductos.TextAlign = ContentAlignment.BottomCenter;
      this.btnProductos.UseVisualStyleBackColor = false;
      this.Button_Discount.BackColor = Color.FromArgb(209, 102, 61);
      this.Button_Discount.FlatStyle = FlatStyle.Flat;
      this.Button_Discount.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button_Discount.ForeColor = Color.WhiteSmoke;
      this.Button_Discount.Image = (Image) TriNetRestPOS.My.Resources.Resources.descuento_op_icono;
      this.Button_Discount.Location = new Point(937, 195);
      this.Button_Discount.Name = "Button_Discount";
      this.Button_Discount.Size = new Size(88, 55);
      this.Button_Discount.TabIndex = 13;
      this.Button_Discount.Text = "Descuent";
      this.Button_Discount.TextAlign = ContentAlignment.BottomCenter;
      this.Button_Discount.UseVisualStyleBackColor = false;
      this.Button_Pay.BackColor = Color.Gray;
      this.Button_Pay.FlatStyle = FlatStyle.Flat;
      this.Button_Pay.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button_Pay.ForeColor = Color.WhiteSmoke;
      this.Button_Pay.Image = (Image) TriNetRestPOS.My.Resources.Resources.egreso_ov_icono;
      this.Button_Pay.Location = new Point(848, 307);
      this.Button_Pay.Name = "Button_Pay";
      this.Button_Pay.Size = new Size(88, 55);
      this.Button_Pay.TabIndex = 20;
      this.Button_Pay.Text = "Egresos";
      this.Button_Pay.TextAlign = ContentAlignment.BottomCenter;
      this.Button_Pay.UseVisualStyleBackColor = false;
      this.Button_ShowSale.BackColor = Color.Gray;
      this.Button_ShowSale.FlatStyle = FlatStyle.Flat;
      this.Button_ShowSale.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button_ShowSale.ForeColor = Color.WhiteSmoke;
      this.Button_ShowSale.Image = (Image) TriNetRestPOS.My.Resources.Resources.venta_ov_icono;
      this.Button_ShowSale.Location = new Point(670, 307);
      this.Button_ShowSale.Name = "Button_ShowSale";
      this.Button_ShowSale.Size = new Size(88, 55);
      this.Button_ShowSale.TabIndex = 18;
      this.Button_ShowSale.Text = "Venta";
      this.Button_ShowSale.TextAlign = ContentAlignment.BottomCenter;
      this.Button_ShowSale.UseVisualStyleBackColor = false;
      this.Button_RefreshOrder.BackColor = Color.FromArgb(209, 102, 61);
      this.Button_RefreshOrder.FlatStyle = FlatStyle.Flat;
      this.Button_RefreshOrder.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button_RefreshOrder.ForeColor = Color.WhiteSmoke;
      this.Button_RefreshOrder.Image = (Image) TriNetRestPOS.My.Resources.Resources.refresca_op_icono;
      this.Button_RefreshOrder.Location = new Point(670, 195);
      this.Button_RefreshOrder.Name = "Button_RefreshOrder";
      this.Button_RefreshOrder.Size = new Size(88, 55);
      this.Button_RefreshOrder.TabIndex = 10;
      this.Button_RefreshOrder.Text = "Refrescar";
      this.Button_RefreshOrder.TextAlign = ContentAlignment.BottomCenter;
      this.Button_RefreshOrder.UseVisualStyleBackColor = false;
      this.Button_BillToPay.BackColor = Color.FromArgb(209, 102, 61);
      this.Button_BillToPay.FlatStyle = FlatStyle.Flat;
      this.Button_BillToPay.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button_BillToPay.ForeColor = Color.WhiteSmoke;
      this.Button_BillToPay.Image = (Image) TriNetRestPOS.My.Resources.Resources.venta_ov_icono;
      this.Button_BillToPay.Location = new Point(670, 251);
      this.Button_BillToPay.Name = "Button_BillToPay";
      this.Button_BillToPay.Size = new Size(88, 55);
      this.Button_BillToPay.TabIndex = 14;
      this.Button_BillToPay.Text = "Pagos";
      this.Button_BillToPay.TextAlign = ContentAlignment.BottomCenter;
      this.Button_BillToPay.UseVisualStyleBackColor = false;
      this.Button_Calculator.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_Calculator.ForeColor = Color.MediumBlue;
      this.Button_Calculator.Image = (Image) TriNetRestPOS.My.Resources.Resources.Calculator;
      this.Button_Calculator.Location = new Point(849, 225);
      this.Button_Calculator.Name = "Button_Calculator";
      this.Button_Calculator.Size = new Size(90, 62);
      this.Button_Calculator.TabIndex = 186;
      this.Button_Calculator.Text = "Calculador";
      this.Button_Calculator.TextImageRelation = TextImageRelation.TextAboveImage;
      this.Button_Calculator.UseVisualStyleBackColor = true;
      this.Label3.AutoSize = true;
      this.Label3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label3.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label3.Location = new Point(669, 66);
      this.Label3.Name = "Label3";
      this.Label3.Size = new Size(76, 16);
      this.Label3.TabIndex = 203;
      this.Label3.Text = "T. Pedido";
      this.TextBox_TypeOrder.AutoCompleteSource = AutoCompleteSource.FileSystem;
      this.TextBox_TypeOrder.BackColor = Color.White;
      this.TextBox_TypeOrder.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.TextBox_TypeOrder.Location = new Point(757, 63);
      this.TextBox_TypeOrder.Multiline = true;
      this.TextBox_TypeOrder.Name = "TextBox_TypeOrder";
      this.TextBox_TypeOrder.ReadOnly = true;
      this.TextBox_TypeOrder.Size = new Size(138, 25);
      this.TextBox_TypeOrder.TabIndex = 4;
      this.Label_ClientDes.AutoSize = true;
      this.Label_ClientDes.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label_ClientDes.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label_ClientDes.Location = new Point(669, 124);
      this.Label_ClientDes.Name = "Label_ClientDes";
      this.Label_ClientDes.Size = new Size(56, 16);
      this.Label_ClientDes.TabIndex = 200;
      this.Label_ClientDes.Text = "Cliente";
      this.lblTotalPedido.BackColor = Color.Transparent;
      this.lblTotalPedido.Font = new Font("Microsoft Sans Serif", 15f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblTotalPedido.ForeColor = Color.FromArgb(0, 192, 0);
      this.lblTotalPedido.Location = new Point(552, 411);
      this.lblTotalPedido.Name = "lblTotalPedido";
      this.lblTotalPedido.Size = new Size(122, 36);
      this.lblTotalPedido.TabIndex = 206;
      this.lblTotalPedido.Text = "0.00";
      this.lblTotalPedido.TextAlign = ContentAlignment.MiddleRight;
      this.Panel2.Controls.Add((Control) this.Button_OrdersDetailsN);
      this.Panel2.Controls.Add((Control) this.Button_ReSendCommand);
      this.Panel2.Controls.Add((Control) this.btnOfertas);
      this.Panel2.Controls.Add((Control) this.Button_SearchItem);
      this.Panel2.Controls.Add((Control) this.Button_OrdersDetailsB);
      this.Panel2.Controls.Add((Control) this.Button_SendCommand);
      this.Panel2.Controls.Add((Control) this.Button_OrdersDetailsF);
      this.Panel2.Controls.Add((Control) this.Button_OrdersDetailsL);
      this.Panel2.Location = new Point(596, -1);
      this.Panel2.Name = "Panel2";
      this.Panel2.Size = new Size(70, 394);
      this.Panel2.TabIndex = 208;
      this.btnOfertas.BackgroundImage = (Image) componentResourceManager.GetObject("btnOfertas.BackgroundImage");
      this.btnOfertas.FlatStyle = FlatStyle.Flat;
      this.btnOfertas.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnOfertas.ForeColor = Color.WhiteSmoke;
      this.btnOfertas.Image = (Image) TriNetRestPOS.My.Resources.Resources.Ofertas_s;
      this.btnOfertas.ImageAlign = ContentAlignment.TopCenter;
      this.btnOfertas.Location = new Point(0, 66);
      this.btnOfertas.Name = "btnOfertas";
      this.btnOfertas.Size = new Size(70, 64);
      this.btnOfertas.TabIndex = 235;
      this.btnOfertas.TextAlign = ContentAlignment.TopCenter;
      this.btnOfertas.UseVisualStyleBackColor = true;
      this.TextBoxDiscount.BackColor = Color.White;
      this.TextBoxDiscount.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.TextBoxDiscount.Location = new Point(954, 64);
      this.TextBoxDiscount.Multiline = true;
      this.TextBoxDiscount.Name = "TextBoxDiscount";
      this.TextBoxDiscount.ReadOnly = true;
      this.TextBoxDiscount.Size = new Size(60, 25);
      this.TextBoxDiscount.TabIndex = 5;
      this.TextBoxDiscount.TextAlign = HorizontalAlignment.Center;
      this.Label2.AutoSize = true;
      this.Label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label2.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label2.Location = new Point(1012, 64);
      this.Label2.Name = "Label2";
      this.Label2.Size = new Size(21, 16);
      this.Label2.TabIndex = 210;
      this.Label2.Text = "%";
      this.Label1.AutoSize = true;
      this.Label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label1.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label1.Location = new Point(901, 65);
      this.Label1.Name = "Label1";
      this.Label1.Size = new Size(48, 16);
      this.Label1.TabIndex = 209;
      this.Label1.Text = "Dscto";
      this.TextBox_ClientDes.BackColor = Color.White;
      this.TextBox_ClientDes.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.TextBox_ClientDes.Location = new Point(757, 122);
      this.TextBox_ClientDes.Multiline = true;
      this.TextBox_ClientDes.Name = "TextBox_ClientDes";
      this.TextBox_ClientDes.ReadOnly = true;
      this.TextBox_ClientDes.ScrollBars = ScrollBars.Vertical;
      this.TextBox_ClientDes.Size = new Size(270, 40);
      this.TextBox_ClientDes.TabIndex = 8;
      this.TextBox_ClientDes.TextAlign = HorizontalAlignment.Center;
      this.Label4.AutoSize = true;
      this.Label4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label4.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label4.Location = new Point(740, 66);
      this.Label4.Name = "Label4";
      this.Label4.Size = new Size(12, 16);
      this.Label4.TabIndex = 213;
      this.Label4.Text = ":";
      this.Label5.AutoSize = true;
      this.Label5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label5.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label5.Location = new Point(740, 124);
      this.Label5.Name = "Label5";
      this.Label5.Size = new Size(12, 16);
      this.Label5.TabIndex = 214;
      this.Label5.Text = ":";
      this.Label6.AutoSize = true;
      this.Label6.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label6.ForeColor = Color.MediumBlue;
      this.Label6.Location = new Point(941, 66);
      this.Label6.Name = "Label6";
      this.Label6.Size = new Size(15, 20);
      this.Label6.TabIndex = 215;
      this.Label6.Text = ":";
      this.TextBox_AmountDiscount.BackColor = Color.FromArgb((int) byte.MaxValue, 240, 140);
      this.TextBox_AmountDiscount.Font = new Font("Tahoma", 12.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.TextBox_AmountDiscount.Location = new Point(879, 165);
      this.TextBox_AmountDiscount.Name = "TextBox_AmountDiscount";
      this.TextBox_AmountDiscount.ReadOnly = true;
      this.TextBox_AmountDiscount.Size = new Size(10, 28);
      this.TextBox_AmountDiscount.TabIndex = 216;
      this.TextBox_AmountDiscount.TextAlign = HorizontalAlignment.Center;
      this.TextBox_AmountDiscount.Visible = false;
      this.TextBox_OrderDate.AutoCompleteSource = AutoCompleteSource.FileSystem;
      this.TextBox_OrderDate.BackColor = Color.White;
      this.TextBox_OrderDate.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.TextBox_OrderDate.ForeColor = Color.FromArgb(209, 102, 61);
      this.TextBox_OrderDate.Location = new Point(937, 93);
      this.TextBox_OrderDate.Multiline = true;
      this.TextBox_OrderDate.Name = "TextBox_OrderDate";
      this.TextBox_OrderDate.ReadOnly = true;
      this.TextBox_OrderDate.Size = new Size(90, 25);
      this.TextBox_OrderDate.TabIndex = 7;
      this.TextBox_OrderDate.TextAlign = HorizontalAlignment.Center;
      this.Label7.AutoSize = true;
      this.Label7.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label7.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label7.Location = new Point(669, 96);
      this.Label7.Name = "Label7";
      this.Label7.Size = new Size(58, 16);
      this.Label7.TabIndex = 219;
      this.Label7.Text = "Pedido";
      this.Label8.AutoSize = true;
      this.Label8.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label8.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label8.Location = new Point(740, 96);
      this.Label8.Name = "Label8";
      this.Label8.Size = new Size(12, 16);
      this.Label8.TabIndex = 220;
      this.Label8.Text = ":";
      this.Button_Waiter.BackColor = Color.FromArgb(209, 102, 61);
      this.Button_Waiter.FlatStyle = FlatStyle.Flat;
      this.Button_Waiter.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button_Waiter.ForeColor = Color.Lavender;
      this.Button_Waiter.Image = (Image) TriNetRestPOS.My.Resources.Resources.mozo_op_icono;
      this.Button_Waiter.Location = new Point(848, 195);
      this.Button_Waiter.Name = "Button_Waiter";
      this.Button_Waiter.Size = new Size(88, 55);
      this.Button_Waiter.TabIndex = 12;
      this.Button_Waiter.Text = "Vendedor";
      this.Button_Waiter.TextAlign = ContentAlignment.BottomCenter;
      this.Button_Waiter.UseVisualStyleBackColor = false;
      this.Label11.AutoSize = true;
      this.Label11.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label11.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label11.Location = new Point(739, 165);
      this.Label11.Name = "Label11";
      this.Label11.Size = new Size(12, 16);
      this.Label11.TabIndex = 225;
      this.Label11.Text = ":";
      this.TextBox_WaiterId.BackColor = Color.FromArgb((int) byte.MaxValue, 240, 140);
      this.TextBox_WaiterId.Font = new Font("Tahoma", 12.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.TextBox_WaiterId.Location = new Point(673, 147);
      this.TextBox_WaiterId.Name = "TextBox_WaiterId";
      this.TextBox_WaiterId.ReadOnly = true;
      this.TextBox_WaiterId.Size = new Size(6, 28);
      this.TextBox_WaiterId.TabIndex = 224;
      this.TextBox_WaiterId.TextAlign = HorizontalAlignment.Center;
      this.TextBox_WaiterId.Visible = false;
      this.TextBox_WaiterDes.BackColor = Color.White;
      this.TextBox_WaiterDes.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.TextBox_WaiterDes.Location = new Point(757, 165);
      this.TextBox_WaiterDes.Multiline = true;
      this.TextBox_WaiterDes.Name = "TextBox_WaiterDes";
      this.TextBox_WaiterDes.ReadOnly = true;
      this.TextBox_WaiterDes.Size = new Size(270, 28);
      this.TextBox_WaiterDes.TabIndex = 9;
      this.TextBox_WaiterDes.TextAlign = HorizontalAlignment.Center;
      this.Label_WaiterDes.AutoSize = true;
      this.Label_WaiterDes.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label_WaiterDes.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label_WaiterDes.Location = new Point(669, 166);
      this.Label_WaiterDes.Name = "Label_WaiterDes";
      this.Label_WaiterDes.Size = new Size(76, 16);
      this.Label_WaiterDes.TabIndex = 222;
      this.Label_WaiterDes.Text = "Vendedor";
      this.Button_DivideOrder.BackColor = Color.FromArgb(209, 102, 61);
      this.Button_DivideOrder.FlatStyle = FlatStyle.Flat;
      this.Button_DivideOrder.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button_DivideOrder.ForeColor = Color.WhiteSmoke;
      this.Button_DivideOrder.Image = (Image) TriNetRestPOS.My.Resources.Resources.division_cuenta;
      this.Button_DivideOrder.Location = new Point(848, 251);
      this.Button_DivideOrder.Name = "Button_DivideOrder";
      this.Button_DivideOrder.Size = new Size(88, 55);
      this.Button_DivideOrder.TabIndex = 16;
      this.Button_DivideOrder.Text = "Di&v Cta";
      this.Button_DivideOrder.TextAlign = ContentAlignment.BottomCenter;
      this.Button_DivideOrder.UseVisualStyleBackColor = false;
      this.Button_Anticipe.BackColor = Color.Gray;
      this.Button_Anticipe.FlatStyle = FlatStyle.Flat;
      this.Button_Anticipe.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button_Anticipe.ForeColor = Color.WhiteSmoke;
      this.Button_Anticipe.Image = (Image) TriNetRestPOS.My.Resources.Resources.anticipo_ov_icono;
      this.Button_Anticipe.Location = new Point(759, 307);
      this.Button_Anticipe.Name = "Button_Anticipe";
      this.Button_Anticipe.Size = new Size(88, 55);
      this.Button_Anticipe.TabIndex = 19;
      this.Button_Anticipe.Text = "Anticipo";
      this.Button_Anticipe.TextAlign = ContentAlignment.BottomCenter;
      this.Button_Anticipe.UseVisualStyleBackColor = false;
      this.Button_Client.BackColor = Color.FromArgb(209, 102, 61);
      this.Button_Client.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.boton_opciones_pedido;
      this.Button_Client.ContextMenuStrip = this.menCliente;
      this.Button_Client.FlatStyle = FlatStyle.Flat;
      this.Button_Client.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button_Client.ForeColor = Color.WhiteSmoke;
      this.Button_Client.Image = (Image) TriNetRestPOS.My.Resources.Resources.clientes_op_icono;
      this.Button_Client.Location = new Point(759, 195);
      this.Button_Client.Name = "Button_Client";
      this.Button_Client.Size = new Size(88, 55);
      this.Button_Client.TabIndex = 11;
      this.Button_Client.Text = "Cliente";
      this.Button_Client.TextAlign = ContentAlignment.BottomCenter;
      this.Button_Client.UseVisualStyleBackColor = false;
      this.menCliente.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold);
      this.menCliente.Items.AddRange(new ToolStripItem[6]
      {
        (ToolStripItem) this.meiVerCredito,
        (ToolStripItem) this.meiVerDescuentos,
        (ToolStripItem) this.meiQuitarDescuento,
        (ToolStripItem) this.meiEliminarCliente,
        (ToolStripItem) this.meiEliminarContacto,
        (ToolStripItem) this.meiCambioProducto
      });
      this.menCliente.Name = "menCliente";
      this.menCliente.Size = new Size(221, 148);
      this.meiVerCredito.Image = (Image) TriNetRestPOS.My.Resources.Resources.DocumentsToPay;
      this.meiVerCredito.Name = "meiVerCredito";
      this.meiVerCredito.Size = new Size(220, 24);
      this.meiVerCredito.Text = "Ver Crédito";
      this.meiVerDescuentos.Image = (Image) TriNetRestPOS.My.Resources.Resources.icon_buy;
      this.meiVerDescuentos.Name = "meiVerDescuentos";
      this.meiVerDescuentos.Size = new Size(220, 24);
      this.meiVerDescuentos.Text = "Ver Descuentos";
      this.meiQuitarDescuento.Image = (Image) TriNetRestPOS.My.Resources.Resources.PercentageSymbol;
      this.meiQuitarDescuento.Name = "meiQuitarDescuento";
      this.meiQuitarDescuento.Size = new Size(220, 24);
      this.meiQuitarDescuento.Text = "Quitar Descuento";
      this.meiEliminarCliente.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.meiEliminarCliente.Image = (Image) TriNetRestPOS.My.Resources.Resources.Eliminar;
      this.meiEliminarCliente.Name = "meiEliminarCliente";
      this.meiEliminarCliente.Size = new Size(220, 24);
      this.meiEliminarCliente.Text = "Eliminar Cliente";
      this.meiEliminarContacto.Image = (Image) TriNetRestPOS.My.Resources.Resources.Less;
      this.meiEliminarContacto.Name = "meiEliminarContacto";
      this.meiEliminarContacto.Size = new Size(220, 24);
      this.meiEliminarContacto.Text = "Eliminar Contacto";
      this.meiEliminarContacto.Visible = false;
      this.meiCambioProducto.Image = (Image) TriNetRestPOS.My.Resources.Resources.i_Refresh;
      this.meiCambioProducto.Name = "meiCambioProducto";
      this.meiCambioProducto.Size = new Size(220, 24);
      this.meiCambioProducto.Text = "Cambio de Producto";
      this.TextBox_ClientId.BackColor = Color.FromArgb((int) byte.MaxValue, 240, 140);
      this.TextBox_ClientId.Font = new Font("Tahoma", 12.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.TextBox_ClientId.Location = new Point(678, 147);
      this.TextBox_ClientId.Name = "TextBox_ClientId";
      this.TextBox_ClientId.ReadOnly = true;
      this.TextBox_ClientId.Size = new Size(6, 28);
      this.TextBox_ClientId.TabIndex = 229;
      this.TextBox_ClientId.TextAlign = HorizontalAlignment.Center;
      this.TextBox_ClientId.Visible = false;
      this.TextBox_ClientIdentity.BackColor = Color.FromArgb((int) byte.MaxValue, 240, 140);
      this.TextBox_ClientIdentity.Font = new Font("Tahoma", 12.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.TextBox_ClientIdentity.Location = new Point(685, 147);
      this.TextBox_ClientIdentity.Name = "TextBox_ClientIdentity";
      this.TextBox_ClientIdentity.Size = new Size(6, 28);
      this.TextBox_ClientIdentity.TabIndex = 230;
      this.TextBox_ClientIdentity.Visible = false;
      this.TextBox_WaiterDes_User.BackColor = Color.FromArgb((int) byte.MaxValue, 240, 140);
      this.TextBox_WaiterDes_User.Font = new Font("Tahoma", 12.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.TextBox_WaiterDes_User.Location = new Point(690, 147);
      this.TextBox_WaiterDes_User.Name = "TextBox_WaiterDes_User";
      this.TextBox_WaiterDes_User.Size = new Size(6, 28);
      this.TextBox_WaiterDes_User.TabIndex = 231;
      this.TextBox_WaiterDes_User.Visible = false;
      this.Button_Credits.BackColor = Color.FromArgb(209, 102, 61);
      this.Button_Credits.FlatStyle = FlatStyle.Flat;
      this.Button_Credits.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button_Credits.ForeColor = Color.WhiteSmoke;
      this.Button_Credits.Image = (Image) TriNetRestPOS.My.Resources.Resources.creditos_icono;
      this.Button_Credits.Location = new Point(937, 251);
      this.Button_Credits.Name = "Button_Credits";
      this.Button_Credits.Size = new Size(88, 55);
      this.Button_Credits.TabIndex = 17;
      this.Button_Credits.Text = "&Créditos";
      this.Button_Credits.TextAlign = ContentAlignment.BottomCenter;
      this.Button_Credits.UseVisualStyleBackColor = false;
      this.btnVentaManual.BackColor = Color.Gray;
      this.btnVentaManual.FlatStyle = FlatStyle.Flat;
      this.btnVentaManual.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnVentaManual.ForeColor = Color.WhiteSmoke;
      this.btnVentaManual.Image = (Image) TriNetRestPOS.My.Resources.Resources.ventamanual_ov_icono;
      this.btnVentaManual.Location = new Point(937, 307);
      this.btnVentaManual.Name = "btnVentaManual";
      this.btnVentaManual.Size = new Size(88, 55);
      this.btnVentaManual.TabIndex = 21;
      this.btnVentaManual.Text = "Vta. Man";
      this.btnVentaManual.TextAlign = ContentAlignment.BottomCenter;
      this.btnVentaManual.UseVisualStyleBackColor = false;
      this.Label9.AutoSize = true;
      this.Label9.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label9.ForeColor = Color.FromArgb(209, 102, 61);
      this.Label9.Location = new Point(669, 367);
      this.Label9.Name = "Label9";
      this.Label9.Size = new Size(116, 18);
      this.Label9.TabIndex = 232;
      this.Label9.Text = "Ingrese Código :";
      this.txtBuscarxCodigo.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtBuscarxCodigo.Location = new Point(792, 365);
      this.txtBuscarxCodigo.MaxLength = 50;
      this.txtBuscarxCodigo.Name = "txtBuscarxCodigo";
      this.txtBuscarxCodigo.Size = new Size(235, 24);
      this.txtBuscarxCodigo.TabIndex = 0;
      this.txtBuscarxCodigo.TextAlign = HorizontalAlignment.Center;
      this.pnlGrupos.Controls.Add((Control) this.btnGruposBuscar);
      this.pnlGrupos.Location = new Point(0, 448);
      this.pnlGrupos.Name = "pnlGrupos";
      this.pnlGrupos.Size = new Size(116, 264);
      this.pnlGrupos.TabIndex = 233;
      this.btnGruposBuscar.BackColor = Color.FromArgb(209, 102, 61);
      this.btnGruposBuscar.FlatStyle = FlatStyle.Flat;
      this.btnGruposBuscar.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnGruposBuscar.ForeColor = Color.WhiteSmoke;
      this.btnGruposBuscar.Location = new Point(95, 1);
      this.btnGruposBuscar.Name = "btnGruposBuscar";
      this.btnGruposBuscar.Size = new Size(21, 262);
      this.btnGruposBuscar.TabIndex = 184;
      this.btnGruposBuscar.Text = "GRUPOS";
      this.btnGruposBuscar.UseCompatibleTextRendering = true;
      this.btnGruposBuscar.UseVisualStyleBackColor = false;
      this.btnGruposBuscar.Visible = false;
      this.pnlSubGrupos.Controls.Add((Control) this.btnSubGruposBuscar);
      this.pnlSubGrupos.Location = new Point(116, 449);
      this.pnlSubGrupos.Name = "pnlSubGrupos";
      this.pnlSubGrupos.Size = new Size(213, 263);
      this.pnlSubGrupos.TabIndex = 234;
      this.btnSubGruposBuscar.BackColor = Color.FromArgb(209, 102, 61);
      this.btnSubGruposBuscar.FlatStyle = FlatStyle.Flat;
      this.btnSubGruposBuscar.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnSubGruposBuscar.ForeColor = Color.WhiteSmoke;
      this.btnSubGruposBuscar.Location = new Point(191, 0);
      this.btnSubGruposBuscar.Name = "btnSubGruposBuscar";
      this.btnSubGruposBuscar.Size = new Size(21, 262);
      this.btnSubGruposBuscar.TabIndex = 185;
      this.btnSubGruposBuscar.Text = "SUBGRUPOS";
      this.btnSubGruposBuscar.UseCompatibleTextRendering = true;
      this.btnSubGruposBuscar.UseVisualStyleBackColor = false;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.White;
      this.ClientSize = new Size(1029, 740);
      this.Controls.Add((Control) this.Panel_Products);
      this.Controls.Add((Control) this.pnlSubGrupos);
      this.Controls.Add((Control) this.pnlGrupos);
      this.Controls.Add((Control) this.txtBuscarxCodigo);
      this.Controls.Add((Control) this.Label9);
      this.Controls.Add((Control) this.btnVentaManual);
      this.Controls.Add((Control) this.Button_Credits);
      this.Controls.Add((Control) this.TextBox_WaiterDes_User);
      this.Controls.Add((Control) this.TextBox_ClientIdentity);
      this.Controls.Add((Control) this.TextBox_ClientId);
      this.Controls.Add((Control) this.Button_Client);
      this.Controls.Add((Control) this.Button_Anticipe);
      this.Controls.Add((Control) this.Label11);
      this.Controls.Add((Control) this.TextBox_WaiterId);
      this.Controls.Add((Control) this.Button_DivideOrder);
      this.Controls.Add((Control) this.TextBox_WaiterDes);
      this.Controls.Add((Control) this.Label_WaiterDes);
      this.Controls.Add((Control) this.Button_Waiter);
      this.Controls.Add((Control) this.Button_ElegirNuevoPedido);
      this.Controls.Add((Control) this.btnProductos);
      this.Controls.Add((Control) this.Label7);
      this.Controls.Add((Control) this.Button_Discount);
      this.Controls.Add((Control) this.Button_NewOrder);
      this.Controls.Add((Control) this.Button_Pay);
      this.Controls.Add((Control) this.Label8);
      this.Controls.Add((Control) this.Button_ShowSale);
      this.Controls.Add((Control) this.Button_DeleteOrder);
      this.Controls.Add((Control) this.Button_RefreshOrder);
      this.Controls.Add((Control) this.Button_GoOut);
      this.Controls.Add((Control) this.TextBox_OrderDate);
      this.Controls.Add((Control) this.Button_BillToPay);
      this.Controls.Add((Control) this.Button_Calculator);
      this.Controls.Add((Control) this.TextBox_AmountDiscount);
      this.Controls.Add((Control) this.TextBox_OrderId);
      this.Controls.Add((Control) this.TextBox_ClientDes);
      this.Controls.Add((Control) this.TextBoxDiscount);
      this.Controls.Add((Control) this.Label2);
      this.Controls.Add((Control) this.Panel2);
      this.Controls.Add((Control) this.TextBox_TypeOrder);
      this.Controls.Add((Control) this.Label_ClientDes);
      this.Controls.Add((Control) this.GroupBox_Emissions);
      this.Controls.Add((Control) this.Panel4);
      this.Controls.Add((Control) this.GroupBox_OptionOrders);
      this.Controls.Add((Control) this.Panel1);
      this.Controls.Add((Control) this.StatusStrip_FastBox);
      this.Controls.Add((Control) this.GroupBox_Options);
      this.Controls.Add((Control) this.lblTotalPedido);
      this.Controls.Add((Control) this.Label3);
      this.Controls.Add((Control) this.Label_Total);
      this.Controls.Add((Control) this.Label4);
      this.Controls.Add((Control) this.Label5);
      this.Controls.Add((Control) this.Label1);
      this.Controls.Add((Control) this.Label6);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (FrmCajaPOS);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Punto de Venta";
      this.StatusStrip_FastBox.ResumeLayout(false);
      this.StatusStrip_FastBox.PerformLayout();
      this.Panel1.ResumeLayout(false);
      ((ISupportInitialize) this.dgrvOrderDetails).EndInit();
      this.GroupBox_Emissions.ResumeLayout(false);
      this.Panel4.ResumeLayout(false);
      this.Panel_Products.ResumeLayout(false);
      ((ISupportInitialize) this.Dgrv_OrderOld).EndInit();
      this.Panel2.ResumeLayout(false);
      this.menCliente.ResumeLayout(false);
      this.pnlGrupos.ResumeLayout(false);
      this.pnlSubGrupos.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    internal virtual StatusStrip StatusStrip_FastBox { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripStatusLabel ToolStripStatusLabel_Box { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripStatusLabel ToolStripStatusLabel_BoxDes { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripStatusLabel tsslTurnValue { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripStatusLabel ToolStripStatusLabel_TurnDes { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripStatusLabel ToolStripStatusLabel_WaiterValue { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripStatusLabel ToolStripStatusLabel_UserDes { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripStatusLabel tsslFechaText { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual GroupBox GroupBox_Emissions { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual GroupBox GroupBox_OptionOrders { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button_ShowSale
    {
      get
      {
        return this._Button_ShowSale;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_ShowSale_Click);
        Button buttonShowSale1 = this._Button_ShowSale;
        if (buttonShowSale1 != null)
          buttonShowSale1.Click -= eventHandler;
        this._Button_ShowSale = value;
        Button buttonShowSale2 = this._Button_ShowSale;
        if (buttonShowSale2 == null)
          return;
        buttonShowSale2.Click += eventHandler;
      }
    }

    internal virtual Button Button_RefreshOrder
    {
      get
      {
        return this._Button_RefreshOrder;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_RefreshOrder_Click);
        Button buttonRefreshOrder1 = this._Button_RefreshOrder;
        if (buttonRefreshOrder1 != null)
          buttonRefreshOrder1.Click -= eventHandler;
        this._Button_RefreshOrder = value;
        Button buttonRefreshOrder2 = this._Button_RefreshOrder;
        if (buttonRefreshOrder2 == null)
          return;
        buttonRefreshOrder2.Click += eventHandler;
      }
    }

    internal virtual Button Button_BillToPay
    {
      get
      {
        return this._Button_BillToPay;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_BillToPay_Click);
        Button buttonBillToPay1 = this._Button_BillToPay;
        if (buttonBillToPay1 != null)
          buttonBillToPay1.Click -= eventHandler;
        this._Button_BillToPay = value;
        Button buttonBillToPay2 = this._Button_BillToPay;
        if (buttonBillToPay2 == null)
          return;
        buttonBillToPay2.Click += eventHandler;
      }
    }

    internal virtual Button Button_GoOut
    {
      get
      {
        return this._Button_GoOut;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_GoOut_Click);
        Button buttonGoOut1 = this._Button_GoOut;
        if (buttonGoOut1 != null)
          buttonGoOut1.Click -= eventHandler;
        this._Button_GoOut = value;
        Button buttonGoOut2 = this._Button_GoOut;
        if (buttonGoOut2 == null)
          return;
        buttonGoOut2.Click += eventHandler;
      }
    }

    internal virtual Panel Panel4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button_Disaggregate
    {
      get
      {
        return this._Button_Disaggregate;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_Disaggregate_Click);
        Button buttonDisaggregate1 = this._Button_Disaggregate;
        if (buttonDisaggregate1 != null)
          buttonDisaggregate1.Click -= eventHandler;
        this._Button_Disaggregate = value;
        Button buttonDisaggregate2 = this._Button_Disaggregate;
        if (buttonDisaggregate2 == null)
          return;
        buttonDisaggregate2.Click += eventHandler;
      }
    }

    internal virtual Button Button_ChangePrice
    {
      get
      {
        return this._Button_ChangePrice;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_ChangePrice_Click);
        Button buttonChangePrice1 = this._Button_ChangePrice;
        if (buttonChangePrice1 != null)
          buttonChangePrice1.Click -= eventHandler;
        this._Button_ChangePrice = value;
        Button buttonChangePrice2 = this._Button_ChangePrice;
        if (buttonChangePrice2 == null)
          return;
        buttonChangePrice2.Click += eventHandler;
      }
    }

    internal virtual Button Button_Quantitytem
    {
      get
      {
        return this._Button_Quantitytem;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_Quantitytem_Click);
        Button buttonQuantitytem1 = this._Button_Quantitytem;
        if (buttonQuantitytem1 != null)
          buttonQuantitytem1.Click -= eventHandler;
        this._Button_Quantitytem = value;
        Button buttonQuantitytem2 = this._Button_Quantitytem;
        if (buttonQuantitytem2 == null)
          return;
        buttonQuantitytem2.Click += eventHandler;
      }
    }

    internal virtual Button Button_MoreQuantity
    {
      get
      {
        return this._Button_MoreQuantity;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_MoreQuantity_Click);
        Button buttonMoreQuantity1 = this._Button_MoreQuantity;
        if (buttonMoreQuantity1 != null)
          buttonMoreQuantity1.Click -= eventHandler;
        this._Button_MoreQuantity = value;
        Button buttonMoreQuantity2 = this._Button_MoreQuantity;
        if (buttonMoreQuantity2 == null)
          return;
        buttonMoreQuantity2.Click += eventHandler;
      }
    }

    internal virtual Button Button_LessQuantity
    {
      get
      {
        return this._Button_LessQuantity;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_LessQuantity_Click);
        Button buttonLessQuantity1 = this._Button_LessQuantity;
        if (buttonLessQuantity1 != null)
          buttonLessQuantity1.Click -= eventHandler;
        this._Button_LessQuantity = value;
        Button buttonLessQuantity2 = this._Button_LessQuantity;
        if (buttonLessQuantity2 == null)
          return;
        buttonLessQuantity2.Click += eventHandler;
      }
    }

    internal virtual Button Button_DirectProduct
    {
      get
      {
        return this._Button_DirectProduct;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_DirectProduct_Click);
        Button buttonDirectProduct1 = this._Button_DirectProduct;
        if (buttonDirectProduct1 != null)
          buttonDirectProduct1.Click -= eventHandler;
        this._Button_DirectProduct = value;
        Button buttonDirectProduct2 = this._Button_DirectProduct;
        if (buttonDirectProduct2 == null)
          return;
        buttonDirectProduct2.Click += eventHandler;
      }
    }

    internal virtual Button Button_DeleteItem
    {
      get
      {
        return this._Button_DeleteItem;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_DeleteItem_Click);
        Button buttonDeleteItem1 = this._Button_DeleteItem;
        if (buttonDeleteItem1 != null)
          buttonDeleteItem1.Click -= eventHandler;
        this._Button_DeleteItem = value;
        Button buttonDeleteItem2 = this._Button_DeleteItem;
        if (buttonDeleteItem2 == null)
          return;
        buttonDeleteItem2.Click += eventHandler;
      }
    }

    internal virtual Button Button_ObservationItem
    {
      get
      {
        return this._Button_ObservationItem;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_ObservationItem_Click);
        Button buttonObservationItem1 = this._Button_ObservationItem;
        if (buttonObservationItem1 != null)
          buttonObservationItem1.Click -= eventHandler;
        this._Button_ObservationItem = value;
        Button buttonObservationItem2 = this._Button_ObservationItem;
        if (buttonObservationItem2 == null)
          return;
        buttonObservationItem2.Click += eventHandler;
      }
    }

    internal virtual Button Button_SearchItem
    {
      get
      {
        return this._Button_SearchItem;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_SearchItem_Click);
        Button buttonSearchItem1 = this._Button_SearchItem;
        if (buttonSearchItem1 != null)
          buttonSearchItem1.Click -= eventHandler;
        this._Button_SearchItem = value;
        Button buttonSearchItem2 = this._Button_SearchItem;
        if (buttonSearchItem2 == null)
          return;
        buttonSearchItem2.Click += eventHandler;
      }
    }

    internal virtual Button Button_SendCommand
    {
      get
      {
        return this._Button_SendCommand;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_SendCommand_Click);
        Button buttonSendCommand1 = this._Button_SendCommand;
        if (buttonSendCommand1 != null)
          buttonSendCommand1.Click -= eventHandler;
        this._Button_SendCommand = value;
        Button buttonSendCommand2 = this._Button_SendCommand;
        if (buttonSendCommand2 == null)
          return;
        buttonSendCommand2.Click += eventHandler;
      }
    }

    internal virtual Button Button_OrdersDetailsF
    {
      get
      {
        return this._Button_OrdersDetailsF;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_OrdersDetailsF_Click);
        Button buttonOrdersDetailsF1 = this._Button_OrdersDetailsF;
        if (buttonOrdersDetailsF1 != null)
          buttonOrdersDetailsF1.Click -= eventHandler;
        this._Button_OrdersDetailsF = value;
        Button buttonOrdersDetailsF2 = this._Button_OrdersDetailsF;
        if (buttonOrdersDetailsF2 == null)
          return;
        buttonOrdersDetailsF2.Click += eventHandler;
      }
    }

    internal virtual Button Button_OrdersDetailsB
    {
      get
      {
        return this._Button_OrdersDetailsB;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnOrderDetailsB_Click);
        Button buttonOrdersDetailsB1 = this._Button_OrdersDetailsB;
        if (buttonOrdersDetailsB1 != null)
          buttonOrdersDetailsB1.Click -= eventHandler;
        this._Button_OrdersDetailsB = value;
        Button buttonOrdersDetailsB2 = this._Button_OrdersDetailsB;
        if (buttonOrdersDetailsB2 == null)
          return;
        buttonOrdersDetailsB2.Click += eventHandler;
      }
    }

    internal virtual Button Button_OrdersDetailsN
    {
      get
      {
        return this._Button_OrdersDetailsN;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnOrderDetailsN_Click);
        Button buttonOrdersDetailsN1 = this._Button_OrdersDetailsN;
        if (buttonOrdersDetailsN1 != null)
          buttonOrdersDetailsN1.Click -= eventHandler;
        this._Button_OrdersDetailsN = value;
        Button buttonOrdersDetailsN2 = this._Button_OrdersDetailsN;
        if (buttonOrdersDetailsN2 == null)
          return;
        buttonOrdersDetailsN2.Click += eventHandler;
      }
    }

    internal virtual Button Button_OrdersDetailsL
    {
      get
      {
        return this._Button_OrdersDetailsL;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_OrderDetailsL_Click);
        Button buttonOrdersDetailsL1 = this._Button_OrdersDetailsL;
        if (buttonOrdersDetailsL1 != null)
          buttonOrdersDetailsL1.Click -= eventHandler;
        this._Button_OrdersDetailsL = value;
        Button buttonOrdersDetailsL2 = this._Button_OrdersDetailsL;
        if (buttonOrdersDetailsL2 == null)
          return;
        buttonOrdersDetailsL2.Click += eventHandler;
      }
    }

    internal virtual DataGridView dgrvOrderDetails
    {
      get
      {
        return this._dgrvOrderDetails;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DataGridViewCellEventHandler cellEventHandler1 = new DataGridViewCellEventHandler(this.dgrvOrderDetails_CellClick);
        DataGridViewCellEventHandler cellEventHandler2 = new DataGridViewCellEventHandler(this.dgrvOrderDetails_CellContentDoubleClick);
        DataGridViewCellFormattingEventHandler formattingEventHandler = new DataGridViewCellFormattingEventHandler(this.dgrvOrderDetails_CellFormatting);
        EventHandler eventHandler = new EventHandler(this.dgrvOrderDetails_SelectionChanged);
        DataGridView dgrvOrderDetails1 = this._dgrvOrderDetails;
        if (dgrvOrderDetails1 != null)
        {
          dgrvOrderDetails1.CellClick -= cellEventHandler1;
          dgrvOrderDetails1.CellContentDoubleClick -= cellEventHandler2;
          dgrvOrderDetails1.CellFormatting -= formattingEventHandler;
          dgrvOrderDetails1.SelectionChanged -= eventHandler;
        }
        this._dgrvOrderDetails = value;
        DataGridView dgrvOrderDetails2 = this._dgrvOrderDetails;
        if (dgrvOrderDetails2 == null)
          return;
        dgrvOrderDetails2.CellClick += cellEventHandler1;
        dgrvOrderDetails2.CellContentDoubleClick += cellEventHandler2;
        dgrvOrderDetails2.CellFormatting += formattingEventHandler;
        dgrvOrderDetails2.SelectionChanged += eventHandler;
      }
    }

    internal virtual Button Button_NewOrder
    {
      get
      {
        return this._Button_NewOrder;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_NewOrder_Click);
        Button buttonNewOrder1 = this._Button_NewOrder;
        if (buttonNewOrder1 != null)
          buttonNewOrder1.Click -= eventHandler;
        this._Button_NewOrder = value;
        Button buttonNewOrder2 = this._Button_NewOrder;
        if (buttonNewOrder2 == null)
          return;
        buttonNewOrder2.Click += eventHandler;
      }
    }

    internal virtual Button Button_DeleteOrder
    {
      get
      {
        return this._Button_DeleteOrder;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_DeleteOrder_Click);
        Button buttonDeleteOrder1 = this._Button_DeleteOrder;
        if (buttonDeleteOrder1 != null)
          buttonDeleteOrder1.Click -= eventHandler;
        this._Button_DeleteOrder = value;
        Button buttonDeleteOrder2 = this._Button_DeleteOrder;
        if (buttonDeleteOrder2 == null)
          return;
        buttonDeleteOrder2.Click += eventHandler;
      }
    }

    internal virtual Button Button_SearchOrder { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripPanel BottomToolStripPanel { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripPanel TopToolStripPanel { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripPanel RightToolStripPanel { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripPanel LeftToolStripPanel { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripContentPanel ContentPanel { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripStatusLabel ToolStripStatusLabel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripStatusLabel ToolStripStatusLabel_OrderDes { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label_Total { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBox_OrderId { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Panel Panel_Products { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Timer Timer_Main
    {
      get
      {
        return this._Timer_Main;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Timer_Main_Tick);
        Timer timerMain1 = this._Timer_Main;
        if (timerMain1 != null)
          timerMain1.Tick -= eventHandler;
        this._Timer_Main = value;
        Timer timerMain2 = this._Timer_Main;
        if (timerMain2 == null)
          return;
        timerMain2.Tick += eventHandler;
      }
    }

    internal virtual GroupBox GroupBox_Options { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button_ReSendCommand
    {
      get
      {
        return this._Button_ReSendCommand;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_ReSendCommand_Click);
        Button buttonReSendCommand1 = this._Button_ReSendCommand;
        if (buttonReSendCommand1 != null)
          buttonReSendCommand1.Click -= eventHandler;
        this._Button_ReSendCommand = value;
        Button buttonReSendCommand2 = this._Button_ReSendCommand;
        if (buttonReSendCommand2 == null)
          return;
        buttonReSendCommand2.Click += eventHandler;
      }
    }

    internal virtual ToolStripStatusLabel l_tsslUserText { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripStatusLabel p_tsslUserText { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripStatusLabel ToolStripStatusLabel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripStatusLabel p_tsslBoxText { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripStatusLabel l_tsslTurnText { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripStatusLabel p_tsslTurnText { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripStatusLabel l_tsslOrderText { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripStatusLabel p_tsslOrderText { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripStatusLabel p_tsslDateText { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripStatusLabel Tssl_Box { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripStatusLabel Tssl_Box_Des { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripStatusLabel Tssl_Turn { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripStatusLabel Tssl_Turn_Des { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripStatusLabel Tssl_Order { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripStatusLabel Tssl_Order_Des { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripStatusLabel Tssl_User { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripStatusLabel Tssl_User_Des { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripStatusLabel Tssl_Date { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBox_TypeOrder { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label_ClientDes { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label lblTotalPedido { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button_Pay
    {
      get
      {
        return this._Button_Pay;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_Pay_Click);
        Button buttonPay1 = this._Button_Pay;
        if (buttonPay1 != null)
          buttonPay1.Click -= eventHandler;
        this._Button_Pay = value;
        Button buttonPay2 = this._Button_Pay;
        if (buttonPay2 == null)
          return;
        buttonPay2.Click += eventHandler;
      }
    }

    internal virtual Button Button_Discount
    {
      get
      {
        return this._Button_Discount;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_Discount_Click);
        Button buttonDiscount1 = this._Button_Discount;
        if (buttonDiscount1 != null)
          buttonDiscount1.Click -= eventHandler;
        this._Button_Discount = value;
        Button buttonDiscount2 = this._Button_Discount;
        if (buttonDiscount2 == null)
          return;
        buttonDiscount2.Click += eventHandler;
      }
    }

    internal virtual Button Button_Calculator
    {
      get
      {
        return this._Button_Calculator;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_Calculator_Click);
        Button buttonCalculator1 = this._Button_Calculator;
        if (buttonCalculator1 != null)
          buttonCalculator1.Click -= eventHandler;
        this._Button_Calculator = value;
        Button buttonCalculator2 = this._Button_Calculator;
        if (buttonCalculator2 == null)
          return;
        buttonCalculator2.Click += eventHandler;
      }
    }

    internal virtual DataGridView Dgrv_OrderOld { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Panel Panel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBoxDiscount { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBox_ClientDes { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBox_AmountDiscount { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBox_OrderDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button btnProductos
    {
      get
      {
        return this._btnProductos;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnProductos_Click);
        Button btnProductos1 = this._btnProductos;
        if (btnProductos1 != null)
          btnProductos1.Click -= eventHandler;
        this._btnProductos = value;
        Button btnProductos2 = this._btnProductos;
        if (btnProductos2 == null)
          return;
        btnProductos2.Click += eventHandler;
      }
    }

    internal virtual Button Button_ElegirNuevoPedido
    {
      get
      {
        return this._Button_ElegirNuevoPedido;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_ElegirNuevoPedido_Click);
        Button elegirNuevoPedido1 = this._Button_ElegirNuevoPedido;
        if (elegirNuevoPedido1 != null)
          elegirNuevoPedido1.Click -= eventHandler;
        this._Button_ElegirNuevoPedido = value;
        Button elegirNuevoPedido2 = this._Button_ElegirNuevoPedido;
        if (elegirNuevoPedido2 == null)
          return;
        elegirNuevoPedido2.Click += eventHandler;
      }
    }

    internal virtual Button Button_Waiter
    {
      get
      {
        return this._Button_Waiter;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_Waiter_Click);
        Button buttonWaiter1 = this._Button_Waiter;
        if (buttonWaiter1 != null)
          buttonWaiter1.Click -= eventHandler;
        this._Button_Waiter = value;
        Button buttonWaiter2 = this._Button_Waiter;
        if (buttonWaiter2 == null)
          return;
        buttonWaiter2.Click += eventHandler;
      }
    }

    internal virtual Label Label11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBox_WaiterId { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBox_WaiterDes { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label_WaiterDes { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button_DivideOrder
    {
      get
      {
        return this._Button_DivideOrder;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_DivideOrder_Click);
        Button buttonDivideOrder1 = this._Button_DivideOrder;
        if (buttonDivideOrder1 != null)
          buttonDivideOrder1.Click -= eventHandler;
        this._Button_DivideOrder = value;
        Button buttonDivideOrder2 = this._Button_DivideOrder;
        if (buttonDivideOrder2 == null)
          return;
        buttonDivideOrder2.Click += eventHandler;
      }
    }

    internal virtual Button Button_Anticipe
    {
      get
      {
        return this._Button_Anticipe;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_Anticipe_Click);
        Button buttonAnticipe1 = this._Button_Anticipe;
        if (buttonAnticipe1 != null)
          buttonAnticipe1.Click -= eventHandler;
        this._Button_Anticipe = value;
        Button buttonAnticipe2 = this._Button_Anticipe;
        if (buttonAnticipe2 == null)
          return;
        buttonAnticipe2.Click += eventHandler;
      }
    }

    internal virtual Button Button_Client
    {
      get
      {
        return this._Button_Client;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_Client_Click);
        Button buttonClient1 = this._Button_Client;
        if (buttonClient1 != null)
          buttonClient1.Click -= eventHandler;
        this._Button_Client = value;
        Button buttonClient2 = this._Button_Client;
        if (buttonClient2 == null)
          return;
        buttonClient2.Click += eventHandler;
      }
    }

    internal virtual TextBox TextBox_ClientId { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBox_ClientIdentity { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBox_WaiterDes_User { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripStatusLabel tsslVentaTickets { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button_Credits
    {
      get
      {
        return this._Button_Credits;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_Credits_Click);
        Button buttonCredits1 = this._Button_Credits;
        if (buttonCredits1 != null)
          buttonCredits1.Click -= eventHandler;
        this._Button_Credits = value;
        Button buttonCredits2 = this._Button_Credits;
        if (buttonCredits2 == null)
          return;
        buttonCredits2.Click += eventHandler;
      }
    }

    internal virtual Button btnVentaManual
    {
      get
      {
        return this._btnVentaManual;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnVentaManual_Click);
        Button btnVentaManual1 = this._btnVentaManual;
        if (btnVentaManual1 != null)
          btnVentaManual1.Click -= eventHandler;
        this._btnVentaManual = value;
        Button btnVentaManual2 = this._btnVentaManual;
        if (btnVentaManual2 == null)
          return;
        btnVentaManual2.Click += eventHandler;
      }
    }

    internal virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox txtBuscarxCodigo
    {
      get
      {
        return this._txtBuscarxCodigo;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtBuscarxCodigo_TextChanged);
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.txtBuscarxCodigo_KeyPress);
        TextBox txtBuscarxCodigo1 = this._txtBuscarxCodigo;
        if (txtBuscarxCodigo1 != null)
        {
          txtBuscarxCodigo1.TextChanged -= eventHandler;
          txtBuscarxCodigo1.KeyPress -= pressEventHandler;
        }
        this._txtBuscarxCodigo = value;
        TextBox txtBuscarxCodigo2 = this._txtBuscarxCodigo;
        if (txtBuscarxCodigo2 == null)
          return;
        txtBuscarxCodigo2.TextChanged += eventHandler;
        txtBuscarxCodigo2.KeyPress += pressEventHandler;
      }
    }

    internal virtual ContextMenuStrip menCliente { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripMenuItem meiVerCredito
    {
      get
      {
        return this._meiVerCredito;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.meiVerCredito_Click);
        ToolStripMenuItem meiVerCredito1 = this._meiVerCredito;
        if (meiVerCredito1 != null)
          meiVerCredito1.Click -= eventHandler;
        this._meiVerCredito = value;
        ToolStripMenuItem meiVerCredito2 = this._meiVerCredito;
        if (meiVerCredito2 == null)
          return;
        meiVerCredito2.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem meiVerDescuentos
    {
      get
      {
        return this._meiVerDescuentos;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.meiVerDescuentos_Click);
        ToolStripMenuItem meiVerDescuentos1 = this._meiVerDescuentos;
        if (meiVerDescuentos1 != null)
          meiVerDescuentos1.Click -= eventHandler;
        this._meiVerDescuentos = value;
        ToolStripMenuItem meiVerDescuentos2 = this._meiVerDescuentos;
        if (meiVerDescuentos2 == null)
          return;
        meiVerDescuentos2.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem meiQuitarDescuento
    {
      get
      {
        return this._meiQuitarDescuento;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.meiQuitarDescuento_Click);
        ToolStripMenuItem meiQuitarDescuento1 = this._meiQuitarDescuento;
        if (meiQuitarDescuento1 != null)
          meiQuitarDescuento1.Click -= eventHandler;
        this._meiQuitarDescuento = value;
        ToolStripMenuItem meiQuitarDescuento2 = this._meiQuitarDescuento;
        if (meiQuitarDescuento2 == null)
          return;
        meiQuitarDescuento2.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem meiEliminarCliente
    {
      get
      {
        return this._meiEliminarCliente;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.meiEliminarCliente_Click);
        ToolStripMenuItem meiEliminarCliente1 = this._meiEliminarCliente;
        if (meiEliminarCliente1 != null)
          meiEliminarCliente1.Click -= eventHandler;
        this._meiEliminarCliente = value;
        ToolStripMenuItem meiEliminarCliente2 = this._meiEliminarCliente;
        if (meiEliminarCliente2 == null)
          return;
        meiEliminarCliente2.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem meiEliminarContacto
    {
      get
      {
        return this._meiEliminarContacto;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.meiEliminarContacto_Click);
        ToolStripMenuItem eliminarContacto1 = this._meiEliminarContacto;
        if (eliminarContacto1 != null)
          eliminarContacto1.Click -= eventHandler;
        this._meiEliminarContacto = value;
        ToolStripMenuItem eliminarContacto2 = this._meiEliminarContacto;
        if (eliminarContacto2 == null)
          return;
        eliminarContacto2.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem meiCambioProducto
    {
      get
      {
        return this._meiCambioProducto;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.meiCambioProducto_Click);
        ToolStripMenuItem meiCambioProducto1 = this._meiCambioProducto;
        if (meiCambioProducto1 != null)
          meiCambioProducto1.Click -= eventHandler;
        this._meiCambioProducto = value;
        ToolStripMenuItem meiCambioProducto2 = this._meiCambioProducto;
        if (meiCambioProducto2 == null)
          return;
        meiCambioProducto2.Click += eventHandler;
      }
    }

    internal virtual Panel pnlGrupos { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Panel pnlSubGrupos { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button btnOfertas
    {
      get
      {
        return this._btnOfertas;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnPromo_Click);
        Button btnOfertas1 = this._btnOfertas;
        if (btnOfertas1 != null)
          btnOfertas1.Click -= eventHandler;
        this._btnOfertas = value;
        Button btnOfertas2 = this._btnOfertas;
        if (btnOfertas2 == null)
          return;
        btnOfertas2.Click += eventHandler;
      }
    }

    internal virtual Button MyXPButton_Pay
    {
      get
      {
        return this._MyXPButton_Pay;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.MyXPButton_Pay_Click);
        Button xpButtonPay1 = this._MyXPButton_Pay;
        if (xpButtonPay1 != null)
          xpButtonPay1.Click -= eventHandler;
        this._MyXPButton_Pay = value;
        Button xpButtonPay2 = this._MyXPButton_Pay;
        if (xpButtonPay2 == null)
          return;
        xpButtonPay2.Click += eventHandler;
      }
    }

    internal virtual Button Button_CreateInvoice
    {
      get
      {
        return this._Button_CreateInvoice;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_CreateInvoice_Click);
        Button buttonCreateInvoice1 = this._Button_CreateInvoice;
        if (buttonCreateInvoice1 != null)
          buttonCreateInvoice1.Click -= eventHandler;
        this._Button_CreateInvoice = value;
        Button buttonCreateInvoice2 = this._Button_CreateInvoice;
        if (buttonCreateInvoice2 == null)
          return;
        buttonCreateInvoice2.Click += eventHandler;
      }
    }

    internal virtual Button Button_Precuenta
    {
      get
      {
        return this._Button_Precuenta;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_Precuenta_Click);
        Button buttonPrecuenta1 = this._Button_Precuenta;
        if (buttonPrecuenta1 != null)
          buttonPrecuenta1.Click -= eventHandler;
        this._Button_Precuenta = value;
        Button buttonPrecuenta2 = this._Button_Precuenta;
        if (buttonPrecuenta2 == null)
          return;
        buttonPrecuenta2.Click += eventHandler;
      }
    }

    internal virtual Button Button_CreateTicket
    {
      get
      {
        return this._Button_CreateTicket;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_CreateTicket_Click);
        Button buttonCreateTicket1 = this._Button_CreateTicket;
        if (buttonCreateTicket1 != null)
          buttonCreateTicket1.Click -= eventHandler;
        this._Button_CreateTicket = value;
        Button buttonCreateTicket2 = this._Button_CreateTicket;
        if (buttonCreateTicket2 == null)
          return;
        buttonCreateTicket2.Click += eventHandler;
      }
    }

    internal virtual Button btnGruposBuscar { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button btnSubGruposBuscar { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button MyXpButton_OrderDetails_Text { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private void FrmCajaPOS_KeyUp(object sender, KeyEventArgs e)
    {
      switch (e.KeyValue)
      {
        case 16:
          this.bolPressSHIFT = false;
          break;
        case 17:
          this.bolPressCONTROL = false;
          break;
      }
    }

    private void FrmFastBox_Load(object sender, EventArgs e)
    {
      if (ModGeneralVar.g_bol_HideDocumentIntern)
        this.tsslVentaTickets.Visible = false;
      else
        this.tsslVentaTickets.Visible = true;
      ModGeneralVar.g_IsDeliveryDatos = true;
      this.MyXpButton_OrderDetails_Text.Text = "Orden: Por Generar / Items: 0";
      this.CreateButtonGroupsArray();
      this.CreateButtonSubGroupsArray();
      this.CreateButtonProductsArray();
      this.Timer_Main.Start();
      this.Text = ModGeneralVar.g_ApplicationName + " - PUNTO DE VENTA";
      this.Text = this.Text + Strings.Space(50) + ModGeneralVar.g_BE_TR1_VARIABLES_B.get_TributaryId() + " - " + ModGeneralVar.g_BE_TR1_VARIABLES_B.get_SocialReason();
      this.Text = this.Text + Strings.Space(50) + "[F1] - AYUDA";
      this.Tssl_Date.Text = Strings.Format((object) DateTime.Now, "ddd, dd") + " / ";
      ToolStripStatusLabel tsslDate1;
      string str1 = (tsslDate1 = this.Tssl_Date).Text + Strings.Format((object) DateTime.Now, "MMM") + " / ";
      tsslDate1.Text = str1;
      ToolStripStatusLabel tsslDate2;
      string str2 = (tsslDate2 = this.Tssl_Date).Text + Strings.Format((object) DateTime.Now, "yyyy -- hh:mm:ss tt");
      tsslDate2.Text = str2;
      this.Tssl_User_Des.Text = ModGeneralVar.g_BE_USERS.get_UserId();
      this.Tssl_Box_Des.Text = ModGeneralVar.g_BE_TR1_CFGVARIABLES.get_BoxDes();
      this.Tssl_Turn_Des.Text = ModGeneralVar.g_BE_TR1_TURNS.get_TurnId();
      this.Tssl_Order_Des.Text = "Por Generar";
      if (this.btnButtonsGroups.Length > 0)
        this.btnButtonsGroups_Click((object) this.btnButtonsGroups[0], (EventArgs) null);
      this.Resource(ModGeneralFunctions.Get_Language((object) this));
      this.SetUpDataGridView();
      this.SetUpDataGridView_OrderOld();
      this.LimpiarPedido();
      ModGeneralFunctions.MostrarVisor();
      if (Conversions.ToBoolean(ModGeneralFunctions.ObtenerAPPCONFIG("COMPROBANTE_RAZONSOCIAL_SELECCIONAR")))
        this.Button_Disaggregate.Enabled = false;
      if (ModGeneralFunctions.ObtenerAPPCONFIG("CLIENTE").Equals((object) "MENFLO"))
      {
        this.btnProductos.Image = (Image) TriNetRestPOS.My.Resources.Resources.i_ImportIcon;
        this.btnProductos.Text = "Import P";
      }
      if (this.bolEsTomador)
      {
        this.Button_CreateTicket.Enabled = false;
        this.Button_CreateInvoice.Enabled = false;
        this.MyXPButton_Pay.Enabled = false;
        this.Button_BillToPay.Enabled = false;
        this.Button_ShowSale.Enabled = false;
        this.Button_Anticipe.Enabled = false;
        this.Button_Pay.Enabled = false;
        this.btnVentaManual.Enabled = false;
        this.Button_Credits.Enabled = false;
        this.Button_DivideOrder.Enabled = false;
        this.Button_Discount.Enabled = false;
        this.Button_DeleteOrder.Enabled = false;
        this.Button_Client.Enabled = false;
        this.Button_Waiter.Enabled = false;
      }
      this.txtBuscarxCodigo.Focus();
    }

    private void FrmFastBox_KeyDown(object sender, KeyEventArgs e)
    {
      switch (e.KeyValue)
      {
        case 16:
          this.bolPressSHIFT = true;
          break;
        case 17:
          this.bolPressCONTROL = true;
          break;
        case 27:
          this.Close();
          break;
        case 46:
          this.Button_DeleteItem_Click((object) null, (EventArgs) null);
          break;
        case 77:
          if (!(this.bolPressCONTROL & this.bolPressSHIFT & !this.bolEsTomador))
            break;
          this.o_BL_ORDERS.ImprimirparaGaveta(ModGeneralVar.g_BE_TR1_CFGVARIABLES);
          break;
        case 112:
          this.MostrarAyuda();
          ModGeneralFunctions.AbrirAyuda();
          break;
        case 113:
          this.ConsultarStocks();
          break;
        case 114:
          this.txtBuscarxCodigo.Focus();
          break;
        case 115:
          if (this.bolEsTomador)
            break;
          this.Button_Discount_Click((object) null, (EventArgs) null);
          break;
        case 116:
          this.Button_Precuenta_Click((object) null, (EventArgs) null);
          break;
        case 117:
          if (this.bolEsTomador)
            break;
          this.Button_CreateTicket_Click((object) null, (EventArgs) null);
          break;
        case 118:
          if (this.bolEsTomador)
            break;
          this.Button_CreateInvoice_Click((object) null, (EventArgs) null);
          break;
        case 119:
          if (this.bolEsTomador)
            break;
          this.MyXPButton_Pay_Click((object) null, (EventArgs) null);
          break;
        case 120:
          if (this.bolEsTomador)
            break;
          FrmDocumentsIntern frmDocumentsIntern = new FrmDocumentsIntern();
          int num1 = (int) frmDocumentsIntern.ShowDialog();
          frmDocumentsIntern.Dispose();
          break;
        case 121:
          if (ModGeneralFunctions.ObtenerAPPCONFIG("CLIENTE").Equals((object) "IRUN"))
          {
            FrmProforma frmProforma = new FrmProforma();
            int num2 = (int) frmProforma.ShowDialog();
            frmProforma.Dispose();
            break;
          }
          this.OrdenCompra();
          break;
        case 122:
          this.GuiaRemision();
          break;
        case 123:
          if (this.bolEsTomador)
            break;
          this.IncrementarCorrelativo();
          break;
      }
    }

    private void FrmFastBox_KeyPress(object sender, KeyPressEventArgs e)
    {
    }

    private void FrmFastBox_FormClosing(object sender, FormClosingEventArgs e)
    {
      ModGeneralVar.g_Str_OrderID = "";
      ModGeneralFunctions.CerrarVisor();
    }

    private void dgrvOrderDetails_CellClick(object sender, DataGridViewCellEventArgs e)
    {
    }

    private void CargarImagen()
    {
      if (this.dgrvOrderDetails.Rows.Count <= 0)
        return;
      this.o_BE_TR1_ORDERDETAILS = (BE_TR1_ORDERDETAILS) this.dgrvOrderDetails.CurrentRow.DataBoundItem;
      string str = new BL_TR1_PRODUCTS().ObtenerRutaImagen(this.o_BE_TR1_ORDERDETAILS.get_ProductId());
      if (!str.Equals(""))
      {
        FrmVisualizaImagen frmVisualizaImagen = new FrmVisualizaImagen();
        frmVisualizaImagen.str_Ruta = str;
        int num = (int) frmVisualizaImagen.ShowDialog();
        frmVisualizaImagen.Dispose();
      }
    }

    private void dgrvOrderDetails_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      this.Button_MoreQuantity_Click(RuntimeHelpers.GetObjectValue(sender), (EventArgs) null);
    }

    private void LeerCodigo(string pstrCadena)
    {
      if (pstrCadena.Trim().Equals(""))
      {
        this.NroSerie = "";
      }
      else
      {
        try
        {
          BL_TR1_PRODUCTS blTr1Products = new BL_TR1_PRODUCTS();
          if (Strings.Len(pstrCadena) > 0)
            this.NroSerie += pstrCadena;
          if (Strings.Len(this.NroSerie) > 4)
          {
            string StrCodProducto = blTr1Products.ObtenerCodigoProdporNroSerie(this.NroSerie) ?? "";
            if (!StrCodProducto.Equals(""))
            {
              this.GuardarProductoporNroSerie(StrCodProducto);
              this.NroSerie = "";
              this.MyXpButton_OrderDetails_Text.Focus();
            }
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          this.NroSerie = "";
          ProjectData.ClearProjectError();
        }
      }
    }

    private void BuscarxCodigoProducto(string pstrCodigo)
    {
      if (pstrCodigo.Trim().Equals(""))
        return;
      try
      {
        string StrCodProducto = new BL_TR1_PRODUCTS().ObtenerCodigoProdporNroSerie(pstrCodigo) ?? "";
        if (!StrCodProducto.Equals(""))
        {
          this.GuardarProductoporNroSerie(StrCodProducto);
          this.txtBuscarxCodigo.Text = "";
          this.txtBuscarxCodigo.Focus();
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.txtBuscarxCodigo.Focus();
        ProjectData.ClearProjectError();
      }
    }

    private void LimpiarPedido()
    {
      this.TextBox_OrderId.Text = "";
      this.TextBox_ClientDes.Text = "";
      this.TextBox_ClientId.Text = "0000000000";
      this.TextBox_TypeOrder.Text = "";
      this.TextBox_OrderDate.Text = "";
      this.TextBoxDiscount.Text = "";
      this.TextBox_AmountDiscount.Text = "";
      this.TextBox_WaiterDes.Text = "";
      this.TextBox_WaiterId.Text = "";
      this.dgrvOrderDetails.DataSource = (object) null;
    }

    private void SetUpDataGridView_OrderOld()
    {
      ModGeneralFunctions.SetUpDataGridViewBasic(this.Dgrv_OrderOld);
      this.Dgrv_OrderOld.Columns.Add("OrderId", "Nº Orden");
      ModGeneralFunctions.SetUp_TextBoxColumn((DataGridViewTextBoxColumn) this.Dgrv_OrderOld.Columns[0], "OrderId", (short) 100, "", false, DataGridViewContentAlignment.MiddleLeft, true);
      this.Dgrv_OrderOld.Columns.Add("OrderFree", this.Res_OrderFree);
      ModGeneralFunctions.SetUp_TextBoxColumn((DataGridViewTextBoxColumn) this.Dgrv_OrderOld.Columns[1], "OrderFree", (short) 160, "", true, DataGridViewContentAlignment.MiddleLeft, true);
    }

    private void Resource(ResourceManager Rm)
    {
      this.Button_SearchOrder.Text = Rm.GetString("Res_Search");
      this.Button_DeleteItem.Text = Rm.GetString("Res_Delete");
      this.Button_ShowSale.Text = Rm.GetString("Res_Sale");
      this.Button_BillToPay.Text = Rm.GetString("Res_Bill");
      this.Button_ChangePrice.Text = Rm.GetString("Res_Price");
      this.Button_SendCommand.Text = Rm.GetString("Res_Send");
      this.Button_ReSendCommand.Text = Rm.GetString("Res_ReSend");
      this.GroupBox_OptionOrders.Text = Rm.GetString("Res_OrdersOption");
      this.MyXpButton_OrderDetails_Text.Text = Rm.GetString("Res_TitleOrder") + " / Items: " + Conversions.ToString(0);
      this.Button_MoreQuantity.Text = Rm.GetString("Res_More");
      this.Button_LessQuantity.Text = Rm.GetString("Res_Less");
      this.Res_SendCommand = Rm.GetString("Res_SendCommand");
      this.Res_InputPassword = Rm.GetString("Res_InputPassword");
      this.Tssl_Turn.Text = Rm.GetString("Res_Turn");
      this.Tssl_Box.Text = Rm.GetString("Res_Box");
      this.Tssl_Order.Text = Rm.GetString("Res_Order");
      this.Tssl_User.Text = Rm.GetString("Res_User");
      this.Res_Product = Rm.GetString("Res_Product");
      this.Res_Price = Rm.GetString("Res_Price");
      this.Res_Quantity = Rm.GetString("Res_QuantityShort");
      this.Res_Order = Rm.GetString("Res_Order");
      this.Res_OrderFree = Rm.GetString("Res_OrderFree");
      this.Res_NotProducts = Rm.GetString("Res_MsgNotProduct");
      this.Res_MsgNotOrders = Rm.GetString("Res_MsgNotOrder");
      this.Res_Code = Rm.GetString("Res_Code");
      this.Res_Description = Rm.GetString("Res_Description");
    }

    private bool OrderDetailValidated()
    {
      if (this.dgrvOrderDetails.Rows.Count != 0)
        return true;
      ModGeneralFunctions.MessageOk(this.Res_NotProducts);
      return false;
    }

    private void ButtonTypeOrders_Click(object sender, EventArgs e)
    {
      if ((uint) Operators.CompareString(sender.GetType().FullName, "System.Windows.Forms.Button", false) > 0U)
        return;
      short num1 = checked ((short) ((int) this.shtCountTypeOrders - 1));
      short num2 = 0;
      while ((int) num2 <= (int) num1)
      {
        this.btnTypeOrders[(int) num2].BackColor = Color.Transparent;
        checked { ++num2; }
      }
      ModGeneralVar.g_Str_OrderTypeID = Conversions.ToString(NewLateBinding.LateGet(sender, (System.Type) null, "Tag", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      NewLateBinding.LateSet(sender, (System.Type) null, "BackColor", new object[1]
      {
        (object) ModGeneralVar.color_SelectedButton
      }, (string[]) null, (System.Type[]) null);
      ModGeneralVar.g_IsDeliveryDatos = true;
      ModGeneralVar.g_IsDelivery = false;
      if (ModGeneralVar.g_Str_OrderTypeID.Equals(ModGeneralVar.g_Str_OrderTypeDelivery))
      {
        ModGeneralVar.g_IsDeliveryDatos = false;
        ModGeneralVar.g_IsDelivery = true;
        FrmDelivery frmDelivery = new FrmDelivery(true);
        int num3 = (int) frmDelivery.ShowDialog();
        frmDelivery.Dispose();
        this.Button_NewOrder_Click(RuntimeHelpers.GetObjectValue(sender), (EventArgs) null);
      }
      this.str_TypeOrder = ModGeneralVar.g_Str_OrderTypeID;
    }

    private void btnOrderDetailsB_Click(object sender, EventArgs e)
    {
      if (!this.OrderDetailValidated())
        return;
      short num = checked ((short) (this.dgrvOrderDetails.CurrentRow.Index - 1));
      if (this.dgrvOrderDetails.Rows.Count > 0 & num > (short) -1)
        this.dgrvOrderDetails.CurrentCell = this.dgrvOrderDetails[1, (int) num];
    }

    private void Button_OrdersDetailsF_Click(object sender, EventArgs e)
    {
      if (!this.OrderDetailValidated() || this.dgrvOrderDetails.Rows.Count <= 0 || this.dgrvOrderDetails.CurrentRow.Index == 0)
        return;
      this.dgrvOrderDetails.CurrentCell = this.dgrvOrderDetails[1, 0];
    }

    private void btnOrderDetailsN_Click(object sender, EventArgs e)
    {
      if (!this.OrderDetailValidated())
        return;
      short index = checked ((short) this.dgrvOrderDetails.CurrentRow.Index);
      if (this.dgrvOrderDetails.Rows.Count > 0 & (int) index < checked (this.dgrvOrderDetails.Rows.Count - 1))
        this.dgrvOrderDetails.CurrentCell = this.dgrvOrderDetails[1, checked ((int) index + 1)];
    }

    private void Button_OrderDetailsL_Click(object sender, EventArgs e)
    {
      if (!this.OrderDetailValidated() || this.dgrvOrderDetails.Rows.Count <= 0)
        return;
      this.dgrvOrderDetails.CurrentCell = this.dgrvOrderDetails[1, checked (this.dgrvOrderDetails.Rows.Count - 1)];
    }

    private void LLena_GridOrderDetails(string pstrOrderId)
    {
      this.oListaORDERDETAILS = this.o_BL_ORDERDETAILS.ListarxId(pstrOrderId);
      this.Fill_SubTotal(this.oListaORDERDETAILS);
      if (this.dSD_subTotal > 0.0)
      {
        double dSdSubTotal = this.dSD_subTotal;
        if (ModGeneralFunctions.CadenaToDouble(this.TextBoxDiscount.Text) > 0.0)
          this.obeORDER.set_IsDiscount(true);
        else
          this.obeORDER.set_IsDiscount(false);
        this.obeORDER.set_DiscountMount(ModGeneralFunctions.CadenaToDouble(this.TextBox_AmountDiscount.Text));
        this.obeORDER.set_PerDiscount(ModGeneralFunctions.CadenaToDouble(this.TextBoxDiscount.Text));
      }
      this.oListaORDERDETAILS = this.o_BL_ORDERDETAILS.ListarxId(pstrOrderId);
      this.Fill_SubTotal(this.oListaORDERDETAILS);
      this.dgrvOrderDetails.DataSource = (object) this.oListaORDERDETAILS;
    }

    private void LoadData()
    {
      this.LLena_GridOrderDetails(this.TextBox_OrderId.Text);
    }

    private void CreateButtonGroupsArray()
    {
      this.numYPositionGroups = (short) 2;
      List<BE_TR1_GROUPS> beTr1GroupsList = new BL_TR1_GROUPS().ListBasic();
      int count = beTr1GroupsList.Count;
      this.btnButtonsGroups = new Button[checked (count - 1 + 1)];
      short num1 = 94;
      short num2 = 62;
      short numYpositionGroups = this.numYPositionGroups;
      short num3 = checked ((short) (count - 1));
      short num4 = 0;
      while ((int) num4 <= (int) num3)
      {
        short num5;
        short num6 = checked ((short) (1 + (int) (short) unchecked ((int) num5 * (int) checked ((short) unchecked ((int) num1 + (int) num5)))));
        this.btnButtonsGroups[(int) num4] = new Button();
        Button btnButtonsGroup = this.btnButtonsGroups[(int) num4];
        if (ModGeneralVar.g_BE_TR1_CFGVARIABLES.get_VerImagenProdPuntoVenta())
        {
          if (!beTr1GroupsList[(int) num4].get_Imagen().Equals(""))
          {
            btnButtonsGroup.Image = (Image) ModGeneralFunctions.RedimensionarImagen(beTr1GroupsList[(int) num4].get_Imagen());
            if (btnButtonsGroup.Image == null)
              btnButtonsGroup.Text = beTr1GroupsList[(int) num4].get_GroupDesShort();
          }
          else
          {
            btnButtonsGroup.Image = (Image) null;
            btnButtonsGroup.Text = beTr1GroupsList[(int) num4].get_GroupDesShort();
          }
        }
        else
          btnButtonsGroup.Text = beTr1GroupsList[(int) num4].get_GroupDesShort();
        btnButtonsGroup.Tag = (object) beTr1GroupsList[(int) num4].get_GroupId();
        btnButtonsGroup.Font = new Font("Microsoft Sans Serif", 8f, FontStyle.Regular);
        btnButtonsGroup.Location = new Point((int) num6, (int) numYpositionGroups);
        btnButtonsGroup.Size = new Size((int) num1, (int) num2);
        btnButtonsGroup.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.boton_cuadrado_plomo1;
        btnButtonsGroup.ForeColor = Color.White;
        btnButtonsGroup.FlatStyle = FlatStyle.Flat;
        btnButtonsGroup.Click += new EventHandler(this.btnButtonsGroups_Click);
        checked { ++num5; }
        if (num5 == (short) 1)
        {
          checked { numYpositionGroups += num2; }
          num5 = (short) 0;
        }
        this.pnlGrupos.Controls.Add((Control) this.btnButtonsGroups[(int) num4]);
        if (count > 4)
        {
          this.pnlGrupos.AutoScroll = true;
          this.btnGruposBuscar.Visible = false;
        }
        checked { ++num4; }
      }
    }

    private void CreateButtonSubGroupsArray()
    {
      BL_TR1_SUBGROUPS blTr1Subgroups = new BL_TR1_SUBGROUPS();
      List<BE_TR1_SUBGROUPS> beTr1SubgroupsList = !ModGeneralVar.g_BE_TR1_VARIABLES_B.get_SubGroupOrderNum() ? blTr1Subgroups.ListByOrder(false) : blTr1Subgroups.ListByOrder(true);
      short num1 = 0;
      string str1 = ModGeneralFunctions.CadenaIfNothing(Conversions.ToString(ModGeneralFunctions.ObtenerAPPCONFIG("GRUPO")));
      if (!str1.Equals(""))
        beTr1SubgroupsList = blTr1Subgroups.ListBasicByGroup(str1);
      string str2 = ModGeneralFunctions.CadenaIfNothing(Conversions.ToString(ModGeneralFunctions.ObtenerAPPCONFIG("SUBGRUPO")));
      if (!str2.Equals(""))
      {
        while (beTr1SubgroupsList.Count > 1)
        {
          if (!str2.Equals((object) beTr1SubgroupsList[(int) num1].get_SubGroupId()))
          {
            beTr1SubgroupsList.RemoveAt((int) num1);
            num1 = (short) 0;
          }
          else
            checked { ++num1; }
        }
      }
      short num2 = 99;
      short num3 = 65;
      short numYpositionGroups = this.numYPositionGroups;
      this.sht_ArrayCount_SubG = beTr1SubgroupsList.Count;
      this._IsValidate = false;
      this.btnButtonsSubGroups = new Button[checked (this.sht_ArrayCount_SubG - 1 + 1)];
      short num4 = checked ((short) (this.sht_ArrayCount_SubG - 1));
      short num5 = 0;
      while ((int) num5 <= (int) num4)
      {
        short num6;
        short num7 = checked ((short) (1 + (int) num6 * ((int) num2 + 0)));
        this.btnButtonsSubGroups[(int) num5] = new Button();
        Button btnButtonsSubGroup = this.btnButtonsSubGroups[(int) num5];
        btnButtonsSubGroup.Name = Conversions.ToString(beTr1SubgroupsList[(int) num5].get_SubGroupId());
        btnButtonsSubGroup.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.boton_cuadrado_plomo1;
        btnButtonsSubGroup.Text = Strings.UCase(beTr1SubgroupsList[(int) num5].get_SubGroupDes());
        btnButtonsSubGroup.Font = new Font("Tahoma", 8f, FontStyle.Regular);
        btnButtonsSubGroup.Location = new Point((int) num7, (int) numYpositionGroups);
        btnButtonsSubGroup.Size = new Size((int) num2, (int) num3);
        btnButtonsSubGroup.FlatStyle = FlatStyle.Flat;
        btnButtonsSubGroup.ForeColor = Color.White;
        btnButtonsSubGroup.Tag = (object) "C";
        btnButtonsSubGroup.Click += new EventHandler(this.btnButtonsSubGroups_Click);
        checked { ++num6; }
        if (num6 == (short) 2)
        {
          checked { numYpositionGroups += num3; }
          num6 = (short) 0;
        }
        this.pnlSubGrupos.Controls.Add((Control) this.btnButtonsSubGroups[(int) num5]);
        if (this.sht_ArrayCount_SubG > 8)
        {
          this.pnlSubGrupos.AutoScroll = true;
          this.btnSubGruposBuscar.Visible = false;
        }
        checked { ++num5; }
      }
    }

    private void btnButtonsGroups_Click(object sender, EventArgs e)
    {
      if ((uint) Operators.CompareString(sender.GetType().FullName, "System.Windows.Forms.Button", false) > 0U)
        return;
      short num1 = checked ((short) (this.btnButtonsGroups.Length - 1));
      short num2 = 0;
      while ((int) num2 <= (int) num1)
      {
        this.btnButtonsGroups[(int) num2].BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.boton_cuadrado_plomo1;
        checked { ++num2; }
      }
      short num3 = checked ((short) (this.btnButtonsProducts.Length - 2));
      short num4 = 0;
      while ((int) num4 <= (int) num3)
      {
        this.btnButtonsProducts[(int) num4].Text = "";
        this.btnButtonsProducts[(int) num4].Tag = (object) "";
        this.btnButtonsProducts[(int) num4].Name = "";
        checked { ++num4; }
      }
      this.str_GroupID = Conversions.ToString(NewLateBinding.LateGet(sender, (System.Type) null, "Tag", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      short num5 = checked ((short) (this.btnButtonsSubGroups.Length - 1));
      short num6 = 0;
      while ((int) num6 <= (int) num5)
      {
        this.btnButtonsSubGroups[(int) num6].BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.boton_cuadrado_plomo1;
        this.btnButtonsSubGroups[(int) num6].Name = "";
        checked { ++num6; }
      }
      this.FillSubGroups(this.str_GroupID);
      NewLateBinding.LateSet(sender, (System.Type) null, "BackGroundImage", new object[1], (string[]) null, (System.Type[]) null);
      NewLateBinding.LateSet(sender, (System.Type) null, "BackColor", new object[1]
      {
        (object) Color.FromArgb(209, 102, 61)
      }, (string[]) null, (System.Type[]) null);
      if (this.btnButtonsSubGroups.Length > 0)
        this.btnButtonsSubGroups_Click((object) this.btnButtonsSubGroups[0], (EventArgs) null);
    }

    private void btnButtonsSubGroups_Click(object sender, EventArgs e)
    {
      if ((uint) Operators.CompareString(sender.GetType().FullName, "System.Windows.Forms.Button", false) > 0U)
        return;
      short num1 = checked ((short) (this.sht_ArrayCount_SubG - 1));
      short num2 = 0;
      while ((int) num2 <= (int) num1)
      {
        this.btnButtonsSubGroups[(int) num2].BackColor = Color.FromArgb(209, 102, 61);
        checked { ++num2; }
      }
      if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, (System.Type) null, "Name", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "@SEARCH", false))
      {
        ModGeneralFunctions.ShowSearchRecord((object) new BL_TR1_SUBGROUPS(), "Listado de SubGrupos", "", "SubGroupId", "SubGroupDes", this.Res_Code, this.Res_Description, false, true, false, false, false, false, (BECollec_TR1_ORDERS) null, false, false, "", "", true, false, false, false, false);
        if (!ModGeneralVar.g_bol_IsReady)
          return;
        if ((uint) Strings.Len(ModGeneralVar.g_Str_RecordID) > 0U)
          this.str_SubGroupID = ModGeneralVar.g_Str_RecordID;
      }
      else
        this.str_SubGroupID = Conversions.ToString(ModGeneralFunctions.CadenaToInteger(Conversions.ToString(NewLateBinding.LateGet(sender, (System.Type) null, "Name", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))));
      short num3 = checked ((short) (this.btnButtonsSubGroups.Length - 1));
      short num4 = 0;
      while ((int) num4 <= (int) num3)
      {
        this.btnButtonsSubGroups[(int) num4].BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.boton_cuadrado_plomo1;
        checked { ++num4; }
      }
      if (ModGeneralFunctions.CadenaToInteger(this.str_SubGroupID) == 0)
      {
        this.str_SubGroupID = "-1";
      }
      else
      {
        NewLateBinding.LateSet(sender, (System.Type) null, "BackGroundImage", new object[1], (string[]) null, (System.Type[]) null);
        NewLateBinding.LateSet(sender, (System.Type) null, "BackColor", new object[1]
        {
          (object) Color.FromArgb(209, 102, 61)
        }, (string[]) null, (System.Type[]) null);
      }
      this.FillProducts(this.str_SubGroupID);
    }

    private void CreateButtonProductsArray()
    {
      this.btnButtonsProducts = new Button[29];
      short num1 = 97;
      short num2 = 65;
      short num3 = 2;
      short num4 = checked ((short) (this.btnButtonsProducts.Length - 1));
      short num5 = 0;
      while ((int) num5 <= (int) num4)
      {
        short num6;
        short num7 = checked ((short) (2 + (int) num6 * ((int) num1 + 0)));
        this.btnButtonsProducts[(int) num5] = new Button();
        Button btnButtonsProduct = this.btnButtonsProducts[(int) num5];
        btnButtonsProduct.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.boton_cuadrado_plomo1;
        btnButtonsProduct.Font = new Font("Microsoft Sans Serif", 8f, FontStyle.Regular);
        btnButtonsProduct.Location = new Point((int) num7, (int) num3);
        btnButtonsProduct.Size = new Size((int) num1, (int) num2);
        btnButtonsProduct.UseVisualStyleBackColor = true;
        btnButtonsProduct.FlatStyle = FlatStyle.Flat;
        btnButtonsProduct.ForeColor = Color.White;
        btnButtonsProduct.Click += new EventHandler(this.btnButtonsProducts_Click);
        checked { ++num6; }
        if (num6 == (short) 7)
        {
          checked { num3 += num2; }
          num6 = (short) 0;
        }
        if (checked (this.btnButtonsProducts.Length - 1) == (int) num5)
        {
          this.btnButtonsProducts[(int) num5].Name = "@SEARCH";
          this.btnButtonsProducts[(int) num5].Font = new Font("Verdana", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
          this.btnButtonsProducts[(int) num5].ForeColor = Color.MediumBlue;
          this.btnButtonsProducts[(int) num5].Image = (Image) TriNetRestPOS.My.Resources.Resources.box3;
          this.btnButtonsProducts[(int) num5].Text = "&Todos";
          this.btnButtonsProducts[(int) num5].TextImageRelation = TextImageRelation.TextAboveImage;
          this.btnButtonsProducts[(int) num5].UseVisualStyleBackColor = true;
        }
        this.Panel_Products.Controls.Add((Control) this.btnButtonsProducts[(int) num5]);
        checked { ++num5; }
      }
    }

    private void GuardarProductoporNroSerie(string StrCodProducto)
    {
      try
      {
        if (!this.OrderHeadValidated1(false))
          return;
        double pdouQuantity = 1.0;
        BL_TR1_PRODUCTS blTr1Products1 = new BL_TR1_PRODUCTS();
        string str = StrCodProducto;
        string pstrProductDes = blTr1Products1.ObtenerProductDesporCodProducto(str);
        if (Strings.Len(str) == 0)
          return;
        if (!this.OrderHeadValidated())
          return;
        BL_TR1_PRODUCTS_PROGRAM tr1ProductsProgram1 = new BL_TR1_PRODUCTS_PROGRAM();
        BE_TR1_PRODUCTS_PROGRAM tr1ProductsProgram2 = new BE_TR1_PRODUCTS_PROGRAM();
        BE_TR1_PRODUCTS_PROGRAM tr1ProductsProgram3 = tr1ProductsProgram1.ValidateAlert(str);
        if ((uint) Operators.CompareString(tr1ProductsProgram3.get_ProductId(), (string) null, false) > 0U)
        {
          if (tr1ProductsProgram3.get_QuantitySald() == 0.0)
          {
            if (!ModGeneralFunctions.MessageMakeAction("Producto sin Stock ¿Desea Continuar? ", false))
              return;
          }
          else if (tr1ProductsProgram3.get_QuantitySald() <= (double) ModGeneralVar.g_CantProgramAlert & tr1ProductsProgram3.get_QuantitySald() != 0.0)
            ModGeneralFunctions.MessageOk("¡El Producto en Stock(" + Conversions.ToString(tr1ProductsProgram3.get_QuantitySald()) + ")!");
        }
        BL_TR1_PRODUCTS blTr1Products2 = new BL_TR1_PRODUCTS();
        List<BE_TR1_AREA> beTr1AreaList1 = new List<BE_TR1_AREA>();
        List<BE_TR1_AREA> beTr1AreaList2 = blTr1Products2.ListAreasDownload(str);
        BE_TR1_PRODUCTS beTr1Products = new BE_TR1_PRODUCTS();
        BL_TR1_PRODUCTS blTr1Products3 = new BL_TR1_PRODUCTS();
        if (beTr1AreaList2.Count == 1)
        {
          beTr1Products.set_AreaId(beTr1AreaList2[0].get_AreaIdStore());
          beTr1Products.set_AreaDesS(beTr1AreaList2[0].get_AreaDesStore());
          beTr1Products.set_ProductId(str);
          beTr1Products.set_PriceCost(beTr1AreaList2[0].get_ProductPriceCost());
          blTr1Products2.EditProduct_Download(beTr1Products);
        }
        else if (beTr1AreaList2.Count > 1)
        {
          int num = (int) new FrmAreasDownload(str, ModGeneralVar.g_Str_RecordDes).ShowDialog();
        }
        this.Grabar_DetalleProducto(str, pstrProductDes, pdouQuantity, "", 0.0);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void btnButtonsProducts_Click(object sender, EventArgs e)
    {
      double _ValueQuantity = 1.0;
      if ((uint) Operators.CompareString(sender.GetType().FullName, "System.Windows.Forms.Button", false) > 0U)
        return;
      string str1 = Conversions.ToString(NewLateBinding.LateGet(sender, (System.Type) null, "Name", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      string str2 = Conversions.ToString(NewLateBinding.LateGet(sender, (System.Type) null, "text", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      if (Strings.Len(str1) == 0)
        return;
      if (Operators.CompareString(str1, "@OFF", false) == 0)
      {
        short num1 = checked ((short) (this.sht_ArrayCount_SubG - 1));
        short num2 = 0;
        while ((int) num2 <= (int) num1)
        {
          this.btnButtonsSubGroups[(int) num2].BackColor = Color.FromArgb(209, 102, 61);
          checked { ++num2; }
        }
      }
      else
      {
        if (!this.OrderHeadValidated())
          return;
        BL_TR1_PRODUCTS_PROGRAM tr1ProductsProgram1 = new BL_TR1_PRODUCTS_PROGRAM();
        BE_TR1_PRODUCTS_PROGRAM tr1ProductsProgram2 = new BE_TR1_PRODUCTS_PROGRAM();
        if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, (System.Type) null, "Name", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "@SEARCH", false))
        {
          if (!ModGeneralFunctions.ShowFrmSearchProducts(false, false, true, this.str_GroupID, str2, ref _ValueQuantity, ModGeneralVar.g_Str_OrderTypeID, false, false, false, false, false, false) || ModGeneralVar.g_Str_RecordID.Length <= 0)
            return;
          string gStrRecordId = ModGeneralVar.g_Str_RecordID;
          BE_TR1_PRODUCTS_PROGRAM tr1ProductsProgram3 = tr1ProductsProgram1.ValidateAlert(gStrRecordId);
          if ((uint) Operators.CompareString(tr1ProductsProgram3.get_ProductId(), (string) null, false) > 0U)
          {
            if (tr1ProductsProgram3.get_QuantitySald() <= 0.0)
            {
              if (!ModGeneralFunctions.MessageMakeAction("Producto sin Stock ¿Desea Continuar?", false))
                return;
            }
            else if (tr1ProductsProgram3.get_QuantitySald() <= (double) ModGeneralVar.g_CantProgramAlert & tr1ProductsProgram3.get_QuantitySald() != 0.0)
              ModGeneralFunctions.MessageOk("¡Producto en Stock(" + Conversions.ToString(tr1ProductsProgram3.get_QuantitySald()) + ")!");
          }
          this.Grabar_DetalleProducto(gStrRecordId, str2, _ValueQuantity, "", 0.0);
        }
        else
        {
          BE_TR1_PRODUCTS_PROGRAM tr1ProductsProgram3 = tr1ProductsProgram1.ValidateAlert(str1);
          if ((uint) Operators.CompareString(tr1ProductsProgram3.get_ProductId(), (string) null, false) > 0U)
          {
            if (tr1ProductsProgram3.get_QuantitySald() <= 0.0)
            {
              if (!ModGeneralFunctions.MessageMakeAction("Producto sin Stock ¿Desea Continuar?", false))
                return;
            }
            else if (tr1ProductsProgram3.get_QuantitySald() <= (double) ModGeneralVar.g_CantProgramAlert & tr1ProductsProgram3.get_QuantitySald() != 0.0)
              ModGeneralFunctions.MessageOk("¡Producto en Stock(" + Conversions.ToString(tr1ProductsProgram3.get_QuantitySald()) + ")!");
          }
          if (ModGeneralVar.g_BE_TR1_VARIABLES_B.get_WithStore())
          {
            BL_TR1_PRODUCTS blTr1Products1 = new BL_TR1_PRODUCTS();
            List<BE_TR1_AREA> beTr1AreaList1 = new List<BE_TR1_AREA>();
            List<BE_TR1_AREA> beTr1AreaList2 = blTr1Products1.ListAreasDownload(str1);
            BE_TR1_PRODUCTS beTr1Products = new BE_TR1_PRODUCTS();
            BL_TR1_PRODUCTS blTr1Products2 = new BL_TR1_PRODUCTS();
            if (beTr1AreaList2.Count == 1)
            {
              beTr1Products.set_AreaId(beTr1AreaList2[0].get_AreaIdStore());
              beTr1Products.set_AreaDesS(beTr1AreaList2[0].get_AreaDesStore());
              beTr1Products.set_ProductId(str1);
              beTr1Products.set_PriceCost(beTr1AreaList2[0].get_ProductPriceCost());
              blTr1Products1.EditProduct_Download(beTr1Products);
              beTr1Products.set_AreaId(Conversions.ToString(ModGeneralFunctions.ObtenerAPPCONFIG("AREAIDSTORE")));
              blTr1Products1.EditProduct_Download(beTr1Products);
            }
            else if (!NewLateBinding.LateGet(ModGeneralFunctions.ObtenerAPPCONFIG("AREAIDSTORE"), (System.Type) null, "Trim", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null).Equals((object) ""))
            {
              beTr1Products.set_AreaId(Conversions.ToString(ModGeneralFunctions.ObtenerAPPCONFIG("AREAIDSTORE")));
              blTr1Products1.EditProduct_Download(beTr1Products);
            }
            if (beTr1AreaList2.Count > 1)
            {
              ModGeneralVar.g_bol_IsReady = false;
              int num = (int) new FrmAreasDownload(str1, str2).ShowDialog();
              if (!ModGeneralVar.g_bol_IsReady)
                return;
            }
          }
          this.Grabar_DetalleProducto(str1, str2, _ValueQuantity, "", 0.0);
        }
      }
    }

    private void Grabar_DetalleProducto(
      string p_ProductID,
      string pstrProductDes,
      double pdouQuantity,
      string p_ItemId = "",
      double p_PriceCost = 0.0)
    {
      if (ModGeneralFunctions.PosTakeOrder())
      {
        string str = this.o_BL_ORDERS.ObtenerEstado(this.TextBox_OrderId.Text.Trim());
        if (str.Equals(ModGeneralVar.g_BusinessCode.get_ORDER_ACOUNTCORRIENTE()))
        {
          ModGeneralFunctions.MessageOk("¡El Pedido ya fué asignado a Crédito!");
          return;
        }
        if (str.Equals(ModGeneralVar.g_BusinessCode.get_ORDER_ANULADO()))
        {
          ModGeneralFunctions.MessageOk("¡El Pedido ya fué Anulado!");
          return;
        }
        if (str.Equals(ModGeneralVar.g_BusinessCode.get_ORDER_FACTURADO()))
        {
          ModGeneralFunctions.MessageOk("¡El Pedido ya fué Facturado!");
          return;
        }
      }
      if (Conversions.ToBoolean(ModGeneralFunctions.ObtenerAPPCONFIG("COMPROBANTE_RAZONSOCIAL_SELECCIONAR")))
      {
        BL_TR1_PRODUCTS blTr1Products = new BL_TR1_PRODUCTS();
        string str = blTr1Products.ObtenerCodProdAlmacenporCodProd(p_ProductID);
        if (Operators.CompareString(str, "", false) == 0)
          ModGeneralFunctions.MessageOk("¡El Producto no tiene enlace con Almacén!");
        else if (blTr1Products.ListadoStockProdAlmacen(checked ((short) ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId()), str).Count == 0)
        {
          ModGeneralFunctions.MessageOk("¡El Producto no tiene stock en Almacén!");
        }
        else
        {
          FrmSeleccionarAreaDescarga seleccionarAreaDescarga = new FrmSeleccionarAreaDescarga(p_ProductID, pstrProductDes, str, this.obeORDER);
          int num = (int) seleccionarAreaDescarga.ShowDialog();
          List<BE_TR1_PRODUCTS> beTr1ProductsList = seleccionarAreaDescarga.devolverLista();
          seleccionarAreaDescarga.Dispose();
          if (beTr1ProductsList.Count > 0)
          {
            this.CargarDetallePedidoxId(ModGeneralVar.g_Str_OrderID, true);
            this.ObtenerPedidoxId(Conversions.ToBoolean(ModGeneralVar.g_Str_OrderID));
            ModGeneralFunctions.GridIrUltimaFila(this.dgrvOrderDetails);
          }
        }
      }
      else
      {
        BE_TR1_ORDERDETAILS beTr1Orderdetails = new BE_TR1_ORDERDETAILS();
        string str1 = "";
        BL_TR1_PRODUCTS blTr1Products = new BL_TR1_PRODUCTS();
        beTr1Orderdetails.set_OrderId(this.TextBox_OrderId.Text);
        beTr1Orderdetails.set_ProductId(p_ProductID);
        beTr1Orderdetails.set_SubGroupId(0);
        beTr1Orderdetails.set_GroupId(Conversions.ToInteger(this.str_GroupID));
        beTr1Orderdetails.set_Quantity(pdouQuantity);
        beTr1Orderdetails.set_Observation("");
        beTr1Orderdetails.set_CommandNumber(0);
        beTr1Orderdetails.set_Tax1_General(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_Tax1());
        beTr1Orderdetails.set_Tax2_General(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_Tax2());
        beTr1Orderdetails.set_Tax3_General(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_Tax3());
        beTr1Orderdetails.set_WaiterID(Conversions.ToInteger(Interaction.IIf(Conversions.ToDouble(ModGeneralVar.g_Str_WaiterID) == 0.0, (object) this.TextBox_WaiterId.Text, (object) ModGeneralVar.g_Str_WaiterID)));
        beTr1Orderdetails.set_OrderTypeId(this.obeORDER.get_OrderTypeId());
        beTr1Orderdetails.set_TypeChange(ModGeneralVar.g_BE_TR1_TURNS.get_TyChanSale());
        beTr1Orderdetails.set_TypeChangeBuy(ModGeneralVar.g_BE_TR1_TURNS.get_TyChanBuy());
        beTr1Orderdetails.set_ItemIdAggregate(p_ItemId);
        beTr1Orderdetails.set_EstabliId(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId());
        if (!NewLateBinding.LateGet(ModGeneralFunctions.ObtenerAPPCONFIG("AREAIDSTORE"), (System.Type) null, "Trim", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null).Equals((object) ""))
          beTr1Orderdetails.set_AreaIdStore(ModGeneralFunctions.CadenaIfNothing(Conversions.ToString(ModGeneralFunctions.ObtenerAPPCONFIG("AREAIDSTORE"))));
        if (Operators.CompareString(ModGeneralVar.g_BE_USERS.get_UserGroupId(), ModGeneralVar.g_UserGroupBox, false) == 0)
        {
          BE_TR1_USERS userIdbyWaiter = new BL_TR1_USERS().GetUserIdbyWaiter(beTr1Orderdetails.get_WaiterID());
          if (userIdbyWaiter == null)
          {
            ModGeneralFunctions.MessageOk("¡Debe Asignar Usuario al " + ModGeneralVar.g_BE_TR1_VARIABLES_B.get_PersonDes() + "!");
            return;
          }
          beTr1Orderdetails.set_UserIdS(userIdbyWaiter.get_UserId());
        }
        else
          beTr1Orderdetails.set_UserIdS(ModGeneralVar.g_BE_USERS.get_UserId());
        string str2;
        if (!blTr1Products.VerifIsCombo(p_ProductID))
        {
          str2 = this.o_BL_ORDERS.AddOrderDetails(ref beTr1Orderdetails, ModGeneralVar.g_BE_TR1_VARIABLES_B.get_WithStore(), Conversions.ToBoolean(ModGeneralFunctions.ObtenerAPPCONFIG("BOL_PRECIOxCARTA")), Conversions.ToBoolean(ModGeneralFunctions.ObtenerAPPCONFIG("PRECIOS_POR_CANTIDAD")), false);
        }
        else
        {
          if (Operators.ConditionalCompareObjectEqual(ModGeneralFunctions.ObtenerAPPCONFIG("BOL_PRECIOxCARTA"), (object) true, false))
          {
            BL_TR1_ORDERS blTr1Orders = new BL_TR1_ORDERS();
            List<BE_TR1_ORDERDETAILS> beTr1OrderdetailsList1 = new List<BE_TR1_ORDERDETAILS>();
            List<BE_TR1_ORDERDETAILS> beTr1OrderdetailsList2 = blTr1Orders.ObtenerPrecioxCarta(this.TextBox_OrderId.Text, p_ProductID);
            if (beTr1OrderdetailsList2[0].get_PriceSale() == 0.0 | beTr1OrderdetailsList2.Count == 0 | beTr1OrderdetailsList2 == null)
            {
              ModGeneralFunctions.MessageOk("¡El Precio Venta es Cero!");
              return;
            }
          }
          BECollec_TR1_PRODUCTS collecTr1Products1 = new BECollec_TR1_PRODUCTS();
          blTr1Products.ListComboDetail(p_ProductID, collecTr1Products1);
          ModGeneralVar.g_EstadoCombo = (short) 0;
          int num1 = checked (((CollectionBase) collecTr1Products1).Count - 1);
          int num2 = 0;
          while (num2 <= num1)
          {
            if (collecTr1Products1.get_Item(num2).get_IsFlexible())
            {
              BECollec_TR1_PRODUCTS collecTr1Products2 = new BECollec_TR1_PRODUCTS();
              BECollec_TR1_PRODUCTS pCollecPRODUCTS = blTr1Products.ListComboFlexible(p_ProductID, collecTr1Products1.get_Item(num2).get_ProductId());
              if (((CollectionBase) pCollecPRODUCTS).Count > 0)
              {
                ModGeneralVar.g_bol_IsReady = false;
                List<BE_TR1_PRODUCTS> beTr1ProductsList = new List<BE_TR1_PRODUCTS>();
                FrmSelectProductFlex selectProductFlex = new FrmSelectProductFlex(pCollecPRODUCTS, pstrProductDes, collecTr1Products1.get_Item(num2).get_ProductDes(), collecTr1Products1.get_Item(num2).get_Quantity(), pdouQuantity);
                int num3 = (int) selectProductFlex.ShowDialog();
                if (ModGeneralVar.g_EstadoCombo == (short) 1)
                  beTr1ProductsList = selectProductFlex.DevolverLista();
                selectProductFlex.Dispose();
                if (!ModGeneralVar.g_bol_IsReady)
                  return;
                BE_TR1_PRODUCTS beTr1Products1 = new BE_TR1_PRODUCTS();
                if (ModGeneralVar.g_CantidadCombo > 0.0)
                {
                  int num4 = checked (beTr1ProductsList.Count - 1);
                  int index = 0;
                  while (index <= num4)
                  {
                    BE_TR1_PRODUCTS beTr1Products2 = new BE_TR1_PRODUCTS();
                    beTr1Products2.set_ProductId(beTr1ProductsList[index].get_ProductId());
                    beTr1Products2.set_Quantity(beTr1ProductsList[index].get_Quantity());
                    beTr1Products2.set_IsDownload(false);
                    beTr1Products2.set_TypeDownload(beTr1ProductsList[index].get_TypeDownload());
                    beTr1Products2.set_IsRetornable(beTr1ProductsList[index].get_IsRetornable());
                    beTr1Products2.set_ProductIdCombo(collecTr1Products1.get_Item(num2).get_ProductId());
                    collecTr1Products1.Add(beTr1Products2);
                    checked { ++index; }
                  }
                  beTr1ProductsList.Clear();
                }
                else
                {
                  beTr1Products1.set_ProductId(ModGeneralVar.g_Str_RecordID);
                  beTr1Products1.set_Quantity(ModGeneralVar.g_Str_RecordQuantity);
                  beTr1Products1.set_IsDownload(false);
                  beTr1Products1.set_TypeDownload(ModGeneralVar.g_Str_TypeDownload);
                  beTr1Products1.set_IsRetornable(ModGeneralVar.g_bol_IsRetornable);
                  beTr1Products1.set_ProductIdCombo(collecTr1Products1.get_Item(num2).get_ProductId());
                  collecTr1Products1.Add(beTr1Products1);
                }
              }
            }
            checked { ++num2; }
          }
          if (ModGeneralVar.g_CantidadCombo > 0.0)
            beTr1Orderdetails.set_Quantity(ModGeneralVar.g_CantidadCombo);
          str2 = this.o_BL_ORDERS.AddOrderDetailsComboDelivery(ref beTr1Orderdetails, ModGeneralVar.g_BE_TR1_VARIABLES_B.get_WithStore(), collecTr1Products1, "", false);
        }
        if (str2.Equals(StructApp.RESULT_OK))
        {
          if (beTr1Orderdetails.get_PriceSale() == 0.0)
            ModGeneralFunctions.MessageOk("¡El Precio Venta es Cero!");
          this.CargarDetallePedidoxId(ModGeneralVar.g_Str_OrderID, true);
          this.ObtenerPedidoxId(Conversions.ToBoolean(ModGeneralVar.g_Str_OrderID));
          ModGeneralFunctions.GridIrUltimaFila(this.dgrvOrderDetails);
          this.NroSerie = "";
          beTr1Orderdetails = (BE_TR1_ORDERDETAILS) null;
          str1 = (string) null;
        }
        else
          ModGeneralFunctions.MessageError_Large("¡Error agregar Producto - " + str2 + "!", true);
      }
    }

    private void Ubicate_OrderDetail_ByIndex(short Index)
    {
      short count = checked ((short) this.dgrvOrderDetails.Rows.Count);
      if (Index < (short) 0 || (int) Index > checked ((int) count - 1))
        return;
      this.dgrvOrderDetails.CurrentCell = this.dgrvOrderDetails[1, (int) Index];
    }

    private void FillSubGroups(string str_GroupID)
    {
      List<BE_TR1_SUBGROUPS> beTr1SubgroupsList = new BL_TR1_SUBGROUPS().ListBasicByGroup(str_GroupID);
      short num1 = 0;
      string str = ModGeneralFunctions.CadenaIfNothing(Conversions.ToString(ModGeneralFunctions.ObtenerAPPCONFIG("SUBGRUPO")));
      if (!str.Equals(""))
      {
        while (beTr1SubgroupsList.Count > 1)
        {
          if (!str.Equals((object) beTr1SubgroupsList[(int) num1].get_SubGroupId()))
          {
            beTr1SubgroupsList.RemoveAt((int) num1);
            num1 = (short) 0;
          }
          else
            checked { ++num1; }
        }
      }
      short num2 = checked ((short) beTr1SubgroupsList.Count);
      short length = checked ((short) this.btnButtonsSubGroups.Length);
      short num3 = checked ((short) ((int) length - 1));
      short num4 = 0;
      while ((int) num4 <= (int) num3)
      {
        this.btnButtonsSubGroups[(int) num4].Text = "";
        this.btnButtonsSubGroups[(int) num4].Tag = (object) "C";
        this.btnButtonsSubGroups[(int) num4].Image = (Image) null;
        this.btnButtonsSubGroups[(int) num4].Visible = false;
        checked { ++num4; }
      }
      if ((int) length < (int) num2)
      {
        num2 = checked ((short) ((int) length - 1));
        this.btnButtonsSubGroups[checked ((int) length - 1)].Name = "@SEARCH";
        this.btnButtonsSubGroups[checked ((int) length - 1)].Text = "";
        this.btnButtonsSubGroups[checked ((int) length - 1)].Tag = (object) "C";
        this.btnButtonsSubGroups[checked ((int) length - 1)].Image = (Image) TriNetRestPOS.My.Resources.Resources.Finder;
        this.btnButtonsSubGroups[checked ((int) length - 1)].Visible = true;
      }
      short num5 = checked ((short) ((int) num2 - 1));
      short num6 = 0;
      while ((int) num6 <= (int) num5)
      {
        this.btnButtonsSubGroups[(int) num6].Name = Conversions.ToString(beTr1SubgroupsList[(int) num6].get_SubGroupId());
        this.btnButtonsSubGroups[(int) num6].Text = beTr1SubgroupsList[(int) num6].get_SubGroupDes();
        this.btnButtonsSubGroups[(int) num6].Tag = (object) "C";
        this.btnButtonsSubGroups[(int) num6].Visible = true;
        checked { ++num6; }
      }
      if (num2 > (short) 8)
      {
        this.pnlSubGrupos.AutoScroll = true;
        this.btnSubGruposBuscar.Visible = false;
      }
      else
        this.btnSubGruposBuscar.Visible = true;
    }

    private void FillProducts(string str_SubGroupID)
    {
      BECollec_TR1_PRODUCTS collecTr1Products = new BL_TR1_PRODUCTS().ListBySubGroup_All(str_SubGroupID);
      short count = checked ((short) ((CollectionBase) collecTr1Products).Count);
      short length = checked ((short) this.btnButtonsProducts.Length);
      if ((int) count < (int) length)
      {
        short num1 = count;
        short num2 = checked ((short) ((int) length - 2));
        short num3 = num1;
        while ((int) num3 <= (int) num2)
        {
          this.btnButtonsProducts[(int) num3].Text = "";
          this.btnButtonsProducts[(int) num3].Name = "";
          this.btnButtonsProducts[(int) num3].Image = (Image) null;
          checked { ++num3; }
        }
      }
      if (ModGeneralVar.g_BE_TR1_CFGVARIABLES.get_VerImagenProdPuntoVenta())
      {
        short num1 = checked ((short) (((CollectionBase) collecTr1Products).Count - 1));
        short num2 = 0;
        while ((int) num2 <= (int) num1 && (int) num2 != checked (this.btnButtonsProducts.Length - 1))
        {
          this.btnButtonsProducts[(int) num2].Name = collecTr1Products.get_Item((int) num2).get_ProductId();
          if (!collecTr1Products.get_Item((int) num2).get_RutaImagen().Equals(""))
          {
            this.btnButtonsProducts[(int) num2].Image = (Image) ModGeneralFunctions.RedimensionarImagen(collecTr1Products.get_Item((int) num2).get_RutaImagen());
            if (this.btnButtonsProducts[(int) num2].Image == null)
              this.btnButtonsProducts[(int) num2].Text = collecTr1Products.get_Item((int) num2).get_ProductDes();
          }
          else
          {
            this.btnButtonsProducts[(int) num2].Image = (Image) null;
            this.btnButtonsProducts[(int) num2].Text = collecTr1Products.get_Item((int) num2).get_ProductDes();
          }
          checked { ++num2; }
        }
      }
      else
      {
        short num1 = checked ((short) (((CollectionBase) collecTr1Products).Count - 1));
        short num2 = 0;
        while ((int) num2 <= (int) num1 && (int) num2 != checked (this.btnButtonsProducts.Length - 1))
        {
          this.btnButtonsProducts[(int) num2].Name = collecTr1Products.get_Item((int) num2).get_ProductId();
          this.btnButtonsProducts[(int) num2].Text = collecTr1Products.get_Item((int) num2).get_ProductDes();
          checked { ++num2; }
        }
      }
    }

    private void Fill_SubTotal(List<BE_TR1_ORDERDETAILS> pListaORDERDETAILS)
    {
      short num1 = 0;
      if (pListaORDERDETAILS != null)
      {
        short num2 = checked ((short) (pListaORDERDETAILS.Count - 1));
        short num3 = 0;
        while ((int) num3 <= (int) num2)
        {
          checked { ++num1; }
          checked { ++num3; }
        }
      }
      this.dSD_subTotal = this.o_BL_ORDERS.ObtenerTotalPedido(ModGeneralVar.g_Str_OrderID);
      this.MyXpButton_OrderDetails_Text.Text = this.Res_Order + this.TextBox_OrderId.Text + " / Items: " + Conversions.ToString((int) num1);
      double dSdSubTotal = this.dSD_subTotal;
      BE_TR1_ORDERS beTr1Orders1 = new BE_TR1_ORDERS();
      BE_TR1_ORDERS beTr1Orders2 = this.o_BL_ORDERS.ObtenerPedidoxId(this.TextBox_OrderId.Text, false);
      if (beTr1Orders2 == null)
      {
        ModGeneralFunctions.MessageOk("Error al cargar pedido.");
      }
      else
      {
        double perDiscount = beTr1Orders2.get_PerDiscount();
        double discountMount = beTr1Orders2.get_DiscountMount();
        this.lblTotalPedido.Text = Strings.Format((object) dSdSubTotal, "0.00");
        this.TextBoxDiscount.Text = Conversions.ToString(Interaction.IIf(beTr1Orders2.get_DiscountMount() == 0.0, (object) "", (object) perDiscount));
        this.TextBox_AmountDiscount.Text = Conversions.ToString(Interaction.IIf(beTr1Orders2.get_DiscountMount() == 0.0, (object) "", (object) discountMount));
      }
    }

    private void Button_NewOrder_Click(object sender, EventArgs e)
    {
      if (!ModGeneralFunctions.ValidInventoryClose())
      {
        ModGeneralFunctions.MessageOk("¡Se ha cerrado el Inventario, no podrá Generar Pedido Libre!");
      }
      else
      {
        BL_TR1_ORDERS blTr1Orders1 = new BL_TR1_ORDERS();
        if (!ModGeneralFunctions.PosTakeOrder())
          ModGeneralVar.g_Str_WaiterID = Conversions.ToString(0);
        if (ModGeneralVar.g_BE_TR1_CFGVARIABLES.get_ConfirmarPedido() && !ModGeneralFunctions.MessageMakeAction("¿Seguro de Crear Pedido?", false))
          return;
        try
        {
          if (!ModGeneralVar.g_BE_TR1_CFGVARIABLES.get_EsPedidoLibreRapido())
          {
            FrmSearchOrder frmSearchOrder = new FrmSearchOrder(ModGeneralVar.g_BE_TR1_TURNS.get_TurnId(), ModGeneralVar.g_Str_OrderTypeID);
            frmSearchOrder.bol_IsViewOrder = true;
            int num = (int) frmSearchOrder.ShowDialog();
            frmSearchOrder.Dispose();
          }
          else
          {
            string str = "LIBRE " + DateAndTime.Now.ToShortTimeString();
            BL_TR1_ORDERS blTr1Orders2 = new BL_TR1_ORDERS();
            BE_TR1_ORDERS beTr1Orders = new BE_TR1_ORDERS();
            ModGeneralVar.g_Str_OrderTypeID = ModGeneralVar.g_Str_OrderTypeID_Default;
            beTr1Orders.set_OrderTypeId(ModGeneralVar.g_Str_OrderTypeID);
            beTr1Orders.set_OrderStateId(ModGeneralVar.g_BusinessCode.get_ORDER_PROCESO());
            ModGeneralVar.g_Str_OrderTypeID = beTr1Orders.get_OrderTypeId();
            beTr1Orders.set_IsFree(true);
            beTr1Orders.set_OrderFree(str);
            beTr1Orders.set_TurnId(ModGeneralVar.g_BE_TR1_TURNS.get_TurnId());
            beTr1Orders.set_BoxId(ModGeneralVar.g_BE_TR1_CFGVARIABLES.get_BoxIdPos());
            beTr1Orders.set_UserId(ModGeneralVar.g_BE_USERS.get_UserId());
            beTr1Orders.set_WaiterId(ModGeneralFunctions.CadenaToInteger(ModGeneralVar.g_Str_WaiterID));
            beTr1Orders.set_EstabliId(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId());
            beTr1Orders.set_TypeChange(ModGeneralVar.g_BE_TR1_TURNS.get_TyChanSale());
            if (ModGeneralVar.g_BE_USERS.get_UserIdLink() == 0)
            {
              ModGeneralFunctions.MessageOk("¡El Cajero no Tiene un Vendedor Asignado!");
              return;
            }
            ModGeneralVar.g_Str_WaiterID = Conversions.ToString(ModGeneralVar.g_BE_USERS.get_UserIdLink());
            beTr1Orders.set_WaiterId(Conversions.ToInteger(ModGeneralVar.g_Str_WaiterID));
            if (!ModGeneralFunctions.PosTakeOrder())
              beTr1Orders.set_PersonBox(ModGeneralVar.g_BE_USERS.get_UserId());
            ModGeneralVar.g_Str_OrderID = blTr1Orders2.AddOrder(beTr1Orders, ModGeneralVar.g_BusinessCode.get_TABLE_OCUPADA());
          }
          if (!this.bolEsPedidoNuevo)
          {
            if (!ModGeneralVar.g_bol_IsClose)
            {
              this.obeORDER = blTr1Orders1.ObtenerPedidoxId(ModGeneralVar.g_Str_OrderID, false);
              if (!ModGeneralVar.g_bol_IsReady)
                return;
              ModGeneralVar.g_bol_IsClose = false;
              string str = "";
              if (Operators.CompareString(this.obeORDER.get_OrderTypeId(), ModGeneralVar.g_Str_OrderTypeID_Default, false) == 0)
                str = " (Libre) ";
              this.TextBox_TypeOrder.Text = this.obeORDER.get_TypeOrderDes();
              this.TextBox_OrderId.Text = this.obeORDER.get_OrderId();
              this.TextBox_OrderDate.Text = Strings.Format((object) this.obeORDER.get_OrderDate(), "hh:mm tt");
              this.TextBoxDiscount.Text = Conversions.ToString(Interaction.IIf(this.obeORDER.get_DiscountMount() == 0.0, (object) "", (object) this.obeORDER.get_DiscountMount()));
              this.TextBox_ClientId.Text = this.obeORDER.get_ClientId();
              this.TextBox_ClientDes.Text = ModGeneralFunctions.CadenaToInteger(this.obeORDER.get_ClientId()) != 0 ? Strings.UCase(this.obeORDER.get_ClientCompany()) : Strings.UCase(this.obeORDER.get_OrderFree());
              this.TextBox_WaiterId.Text = Conversions.ToString(this.obeORDER.get_WaiterId());
              this.TextBox_WaiterDes.Text = this.obeORDER.get_WaiterDes();
              ModGeneralVar.g_Str_OrderTypeID = this.obeORDER.get_OrderTypeId();
              this.Tssl_Order_Des.Text = ModGeneralVar.g_Str_OrderFreeDes;
              this.Ubicate_Record(checked (this.Dgrv_OrderOld.Rows.Count - 1));
              this.LoadData();
              this.DeshabilitarBotonesxPedido_Proforma(this.obeORDER.get_EstabliId(), ModGeneralVar.g_Str_OrderID);
              if (this.bolEsTomador)
              {
                this.Button_CreateTicket.Enabled = false;
                this.Button_CreateInvoice.Enabled = false;
                this.MyXPButton_Pay.Enabled = false;
              }
            }
          }
          else
          {
            this.obeORDER = blTr1Orders1.ObtenerPedidoxId(ModGeneralVar.g_Str_OrderID, false);
            ModGeneralVar.g_bol_IsReady = true;
            if (!ModGeneralVar.g_bol_IsReady)
              return;
            ModGeneralVar.g_bol_IsClose = false;
            string str = "";
            if (Operators.CompareString(this.obeORDER.get_OrderTypeId(), ModGeneralVar.g_Str_OrderTypeID_Default, false) == 0)
              str = " (Libre) ";
            this.TextBox_TypeOrder.Text = this.obeORDER.get_TypeOrderDes();
            this.TextBox_OrderId.Text = this.obeORDER.get_OrderId();
            this.TextBox_OrderDate.Text = Strings.Format((object) this.obeORDER.get_OrderDate(), "hh:mm tt");
            this.TextBoxDiscount.Text = Conversions.ToString(Interaction.IIf(this.obeORDER.get_DiscountMount() == 0.0, (object) "", (object) this.obeORDER.get_DiscountMount()));
            this.TextBox_ClientId.Text = "0000000000";
            this.TextBox_ClientDes.Text = Strings.UCase(this.obeORDER.get_OrderFree());
            this.TextBox_WaiterId.Text = "";
            this.TextBox_WaiterDes.Text = "";
            ModGeneralVar.g_Str_OrderTypeID = this.obeORDER.get_OrderTypeId();
            this.Tssl_Order_Des.Text = ModGeneralVar.g_Str_OrderFreeDes;
            this.Ubicate_Record(checked (this.Dgrv_OrderOld.Rows.Count - 1));
            this.LoadData();
            this.NroSerie = "";
            this.DeshabilitarBotonesxPedido_Proforma(this.obeORDER.get_EstabliId(), ModGeneralVar.g_Str_OrderID);
            if (this.bolEsTomador)
            {
              this.Button_CreateTicket.Enabled = false;
              this.Button_CreateInvoice.Enabled = false;
              this.MyXPButton_Pay.Enabled = false;
            }
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
      }
    }

    private void Ubicate_Record(int p_Index)
    {
      if (this.Dgrv_OrderOld.RowCount <= 0)
        return;
      this.Dgrv_OrderOld.CurrentCell = this.Dgrv_OrderOld[1, p_Index];
    }

    private void SetUpDataGridView()
    {
      ModGeneralFunctions.SetUpDataGridViewBasicNuevo(this.dgrvOrderDetails);
      this.dgrvOrderDetails.Columns.Add("ItemId", "ItemId");
      ModGeneralFunctions.SetUp_TextBoxColumn1((DataGridViewTextBoxColumn) this.dgrvOrderDetails.Columns[0], "ItemId", (short) 0, "", false, DataGridViewContentAlignment.MiddleLeft, true);
      this.dgrvOrderDetails.Columns.Add("ProductDes", this.Res_Product);
      ModGeneralFunctions.SetUp_TextBoxColumn1((DataGridViewTextBoxColumn) this.dgrvOrderDetails.Columns[1], "ProductDes", (short) 282, "", true, DataGridViewContentAlignment.MiddleLeft, true);
      this.dgrvOrderDetails.Columns.Add("PriceSale", this.Res_Price);
      ModGeneralFunctions.SetUp_TextBoxColumn1((DataGridViewTextBoxColumn) this.dgrvOrderDetails.Columns[2], "PriceSale", (short) 70, "0.00", true, DataGridViewContentAlignment.MiddleRight, true);
      this.dgrvOrderDetails.Columns.Add("Quantity", this.Res_Quantity);
      ModGeneralFunctions.SetUp_TextBoxColumn1((DataGridViewTextBoxColumn) this.dgrvOrderDetails.Columns[3], "Quantity", (short) 75, "0.000", true, DataGridViewContentAlignment.MiddleRight, true);
      this.dgrvOrderDetails.Columns.Add("SaleMount", "Sub-Total");
      ModGeneralFunctions.SetUp_TextBoxColumn1((DataGridViewTextBoxColumn) this.dgrvOrderDetails.Columns[4], "SaleMount", (short) 85, "0.00", true, DataGridViewContentAlignment.MiddleRight, true);
      this.dgrvOrderDetails.Columns.Add((DataGridViewColumn) new DataGridViewImageColumn());
      ModGeneralFunctions.SetUp_ImageColumn1((DataGridViewImageColumn) this.dgrvOrderDetails.Columns[5], "E", (short) 24, "", TriNetRestPOS.My.Resources.Resources.IsPrinted_False, true);
      this.dgrvOrderDetails.Columns.Add((DataGridViewColumn) new DataGridViewImageColumn());
      ModGeneralFunctions.SetUp_ImageColumn1((DataGridViewImageColumn) this.dgrvOrderDetails.Columns[6], "O", (short) 24, "", TriNetRestPOS.My.Resources.Resources.IsObservated_False, true);
      this.dgrvOrderDetails.Columns.Add("", "");
      ModGeneralFunctions.SetUp_TextBoxColumn1((DataGridViewTextBoxColumn) this.dgrvOrderDetails.Columns[7], "", (short) 18, "", true, DataGridViewContentAlignment.MiddleLeft, true);
      this.dgrvOrderDetails.ScrollBars = ScrollBars.Vertical;
    }

    private void Button_GoOut_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void Button_Quantitytem_Click(object sender, EventArgs e)
    {
      if (!this.OrderDetailValidated())
        return;
      this.o_BE_TR1_ORDERDETAILS = (BE_TR1_ORDERDETAILS) this.dgrvOrderDetails.CurrentRow.DataBoundItem;
      if (this.o_BE_TR1_ORDERDETAILS.get_IsPrinted())
      {
        ModGeneralFunctions.MessageOk("NO SE PUEDE CAMBIAR LA CANTIDAD A UN PRODUCTO YA IMPRESO!!!!!!");
      }
      else
      {
        ModGeneralFunctions.NumberKeyBoard("INGRESE CANTIDAD", true);
        if (!ModGeneralVar.g_bol_IsReady)
          return;
        double p_Quantity = Conversions.ToDouble(ModGeneralVar.g_str_InputValue);
        if (p_Quantity == 0.0)
          return;
        this.Save_ChangeQuantity(p_Quantity, true);
        this.Ubicate_OrderDetail(this.o_BE_TR1_ORDERDETAILS.get_ItemId());
      }
    }

    private void Save_ChangeQuantity(double p_Quantity, bool p_QuantityisReplaced = false)
    {
      if (this.dgrvOrderDetails.Rows.Count > 0)
      {
        this.o_BE_TR1_ORDERDETAILS = (BE_TR1_ORDERDETAILS) this.dgrvOrderDetails.CurrentRow.DataBoundItem;
        if (this.o_BE_TR1_ORDERDETAILS.get_IsPrinted())
          ModGeneralFunctions.MessageOk("NO SE PUEDE CAMBIAR LA CANTIDAD A UN PRODUCTO YA IMPRESO!!!!!!");
        else if (p_QuantityisReplaced)
        {
          this.o_BE_TR1_ORDERDETAILS.set_Quantity(p_Quantity);
          this.o_BL_ORDERS.SetQuantity(this.o_BE_TR1_ORDERDETAILS.get_OrderId(), this.o_BE_TR1_ORDERDETAILS.get_ItemId(), this.o_BE_TR1_ORDERDETAILS.get_Quantity());
          if (Conversions.ToBoolean(ModGeneralFunctions.ObtenerAPPCONFIG("PRECIOS_POR_CANTIDAD")))
            this.o_BL_ORDERS.SetearPrecioxCantidad(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId(), this.o_BE_TR1_ORDERDETAILS.get_OrderId(), this.o_BE_TR1_ORDERDETAILS.get_ItemId(), this.o_BE_TR1_ORDERDETAILS.get_Quantity());
          this.LLena_GridOrderDetails(this.o_BE_TR1_ORDERDETAILS.get_OrderId());
        }
        else if (this.o_BE_TR1_ORDERDETAILS.get_Quantity() + p_Quantity == 0.0)
        {
          ModGeneralFunctions.MessageOk("No Puede Eliminar el Item!!!");
        }
        else
        {
          double num = this.o_BE_TR1_ORDERDETAILS.get_Quantity() + p_Quantity;
          this.o_BE_TR1_ORDERDETAILS.set_Quantity(p_Quantity);
          this.o_BL_ORDERS.ModifyQuantity(this.o_BE_TR1_ORDERDETAILS.get_OrderId(), this.o_BE_TR1_ORDERDETAILS.get_ItemId(), this.o_BE_TR1_ORDERDETAILS.get_Quantity());
          if (Conversions.ToBoolean(ModGeneralFunctions.ObtenerAPPCONFIG("PRECIOS_POR_CANTIDAD")))
            this.o_BL_ORDERS.SetearPrecioxCantidad(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId(), this.o_BE_TR1_ORDERDETAILS.get_OrderId(), this.o_BE_TR1_ORDERDETAILS.get_ItemId(), num);
          this.LLena_GridOrderDetails(this.o_BE_TR1_ORDERDETAILS.get_OrderId());
          this.Ubicate_OrderDetail(this.o_BE_TR1_ORDERDETAILS.get_ItemId());
        }
      }
    }

    private void Ubicate_OrderDetail(string ItemId_ToUbicate)
    {
      int num = checked (this.dgrvOrderDetails.Rows.Count - 1);
      int index = 0;
      while (index <= num)
      {
        if (NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgrvOrderDetails.DataSource, new object[1]
        {
          (object) index
        }, (string[]) null), (System.Type) null, "ItemId", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null).Equals((object) ItemId_ToUbicate))
        {
          this.dgrvOrderDetails.CurrentCell = this.dgrvOrderDetails[1, index];
          break;
        }
        checked { ++index; }
      }
    }

    private void Button_LessQuantity_Click(object sender, EventArgs e)
    {
      if (!this.OrderDetailValidated())
        return;
      this.Save_ChangeQuantity(-1.0, false);
    }

    private void Button_MoreQuantity_Click(object sender, EventArgs e)
    {
      if (!this.OrderDetailValidated())
        return;
      this.Save_ChangeQuantity(1.0, false);
    }

    private void Button_DirectProduct_Click(object sender, EventArgs e)
    {
      if (!this.OrderHeadValidated())
        return;
      double _ValueQuantity = 1.0;
      if (ModGeneralFunctions.ShowFrmSearchProducts(true, false, false, "", "", ref _ValueQuantity, ModGeneralVar.g_Str_OrderTypeID, false, false, false, false, false, false) && ModGeneralVar.g_Str_RecordID.Length > 0)
      {
        BL_TR1_PRODUCTS blTr1Products1 = new BL_TR1_PRODUCTS();
        List<BE_TR1_AREA> beTr1AreaList1 = new List<BE_TR1_AREA>();
        List<BE_TR1_AREA> beTr1AreaList2 = blTr1Products1.ListAreasDownload(ModGeneralVar.g_Str_RecordID);
        BE_TR1_PRODUCTS beTr1Products = new BE_TR1_PRODUCTS();
        BL_TR1_PRODUCTS blTr1Products2 = new BL_TR1_PRODUCTS();
        if (!NewLateBinding.LateGet(ModGeneralFunctions.ObtenerAPPCONFIG("AREAIDSTORE"), (System.Type) null, "Trim", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null).Equals((object) ""))
        {
          beTr1Products.set_AreaId(Conversions.ToString(ModGeneralFunctions.ObtenerAPPCONFIG("AREAIDSTORE")));
          blTr1Products1.EditProduct_Download(beTr1Products);
        }
        if (beTr1AreaList2.Count == 1)
        {
          beTr1Products.set_AreaId(beTr1AreaList2[0].get_AreaIdStore());
          beTr1Products.set_AreaDesS(beTr1AreaList2[0].get_AreaDesStore());
          beTr1Products.set_PriceCost(beTr1AreaList2[0].get_ProductPriceCost());
          beTr1Products.set_ProductId(ModGeneralVar.g_Str_RecordID);
          blTr1Products1.EditProduct_Download(beTr1Products);
          if (!NewLateBinding.LateGet(ModGeneralFunctions.ObtenerAPPCONFIG("AREAIDSTORE"), (System.Type) null, "Trim", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null).Equals((object) ""))
          {
            beTr1Products.set_AreaId(Conversions.ToString(ModGeneralFunctions.ObtenerAPPCONFIG("AREAIDSTORE")));
            blTr1Products1.EditProduct_Download(beTr1Products);
          }
        }
        else if (beTr1AreaList2.Count > 1)
        {
          ModGeneralVar.g_bol_IsReady = false;
          int num = (int) new FrmAreasDownload(ModGeneralVar.g_Str_RecordID, ModGeneralVar.g_Str_RecordDes).ShowDialog();
          if (!ModGeneralVar.g_bol_IsReady)
            return;
        }
        else if (!NewLateBinding.LateGet(ModGeneralFunctions.ObtenerAPPCONFIG("AREAIDSTORE"), (System.Type) null, "Trim", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null).Equals((object) ""))
        {
          beTr1Products.set_AreaId(Conversions.ToString(ModGeneralFunctions.ObtenerAPPCONFIG("AREAIDSTORE")));
          blTr1Products1.EditProduct_Download(beTr1Products);
        }
        BL_TR1_PRODUCTS_PROGRAM tr1ProductsProgram1 = new BL_TR1_PRODUCTS_PROGRAM();
        BE_TR1_PRODUCTS_PROGRAM tr1ProductsProgram2 = new BE_TR1_PRODUCTS_PROGRAM();
        BE_TR1_PRODUCTS_PROGRAM tr1ProductsProgram3 = tr1ProductsProgram1.ValidateAlert(ModGeneralVar.g_Str_RecordID);
        if ((uint) Operators.CompareString(tr1ProductsProgram3.get_ProductId(), (string) null, false) > 0U)
        {
          if (tr1ProductsProgram3.get_QuantitySald() <= 0.0)
          {
            if (!ModGeneralFunctions.MessageMakeAction_Large(ModGeneralVar.g_Str_RecordDes + " - sin Stock ¿Desea Continuar?"))
              return;
          }
          else if (tr1ProductsProgram3.get_QuantitySald() <= (double) ModGeneralVar.g_CantProgramAlert & tr1ProductsProgram3.get_QuantitySald() != 0.0)
            ModGeneralFunctions.MessageOk_Large("¡" + ModGeneralVar.g_Str_RecordDes + " en Stock [" + Conversions.ToString(tr1ProductsProgram3.get_QuantitySald()) + "]!", false);
          else if (tr1ProductsProgram3.get_QuantitySald() < _ValueQuantity && !ModGeneralFunctions.MessageMakeAction_Large(ModGeneralVar.g_Str_RecordDes + " - Stock insuficiente [" + Conversions.ToString(tr1ProductsProgram3.get_QuantitySald()) + "] ¿Desea Continuar?"))
            return;
        }
        blTr1Products2 = (BL_TR1_PRODUCTS) null;
        beTr1AreaList1 = (List<BE_TR1_AREA>) null;
        this.Grabar_DetalleProducto(ModGeneralVar.g_Str_RecordID, ModGeneralVar.g_Str_RecordDes, _ValueQuantity, "", 0.0);
      }
    }

    private bool OrderHeadValidated()
    {
      return !this.TextBox_OrderId.Text.Equals("");
    }

    private bool OrderHeadValidated1(bool pbolPregunta)
    {
      if (!this.TextBox_OrderId.Text.Equals(""))
        return true;
      if (pbolPregunta)
      {
        if (!ModGeneralFunctions.MessageMakeAction("¿Desea crear un pedido nuevo?", true))
          return false;
        this.Button_NewOrder_Click((object) null, (EventArgs) null);
        return true;
      }
      this.Button_NewOrder_Click((object) null, (EventArgs) null);
      return true;
    }

    private void Timer_Main_Tick(object sender, EventArgs e)
    {
      this.Tssl_Date.Text = Strings.Format((object) DateTime.Now, "dd/MM/yyyy-hh:mm:ss tt");
    }

    private void Button_ObservationItem_Click(object sender, EventArgs e)
    {
      if (!this.OrderDetailValidated())
        return;
      BE_TR1_ORDERDETAILS beTr1Orderdetails = new BE_TR1_ORDERDETAILS();
      BE_TR1_ORDERDETAILS dataBoundItem = (BE_TR1_ORDERDETAILS) this.dgrvOrderDetails.CurrentRow.DataBoundItem;
      FrmSelectProperties selectProperties = new FrmSelectProperties();
      selectProperties.strSubGroupId = Conversions.ToString(dataBoundItem.get_SubGroupId());
      selectProperties.strObservation = dataBoundItem.get_Observation();
      ModGeneralVar.g_bol_IsReady = false;
      int num = (int) selectProperties.ShowDialog();
      string strObservation = selectProperties.strObservation;
      selectProperties.Dispose();
      if (!ModGeneralVar.g_bol_IsReady)
        return;
      dataBoundItem.set_Observation(strObservation);
      if (strObservation.Length == 0)
        dataBoundItem.set_IsObservated(false);
      else
        dataBoundItem.set_IsObservated(true);
      this.o_BL_ORDERDETAILS.ModifyObservation(dataBoundItem.get_OrderId(), dataBoundItem.get_ItemId(), strObservation, false);
      NewLateBinding.LateIndexSetComplex(this.dgrvOrderDetails.DataSource, new object[2]
      {
        (object) this.dgrvOrderDetails.CurrentRow.Index,
        (object) dataBoundItem
      }, (string[]) null, false, true);
      this.Ubicate_OrderDetail(dataBoundItem.get_ItemId());
      this.dgrvOrderDetails.Refresh();
    }

    private void Button_DeleteItem_Click(object sender, EventArgs e)
    {
      if (!this.OrderDetailValidated())
        return;
      BE_TR1_ORDERDETAILS_D tr1OrderdetailsD = new BE_TR1_ORDERDETAILS_D();
      this.o_BE_TR1_ORDERDETAILS = (BE_TR1_ORDERDETAILS) this.dgrvOrderDetails.CurrentRow.DataBoundItem;
      if (this.o_BE_TR1_ORDERDETAILS.get_IsPrinted())
      {
        if (ModGeneralVar.g_bol_Anulation)
        {
          BE_TR1_ORDERDETAILS beTr1Orderdetails = new BE_TR1_ORDERDETAILS();
          BE_TR1_ORDERDETAILS dataBoundItem = (BE_TR1_ORDERDETAILS) this.dgrvOrderDetails.CurrentRow.DataBoundItem;
          FrmDeleteDetail frmDeleteDetail = new FrmDeleteDetail();
          frmDeleteDetail.bol_Delete = true;
          frmDeleteDetail.str_TableDes = this.TextBox_ClientDes.Text;
          frmDeleteDetail.str_Item = dataBoundItem.get_ItemId();
          int num = (int) frmDeleteDetail.ShowDialog();
          frmDeleteDetail.Dispose();
          this.RefreshOrder();
          this.LLena_GridOrderDetails(dataBoundItem.get_OrderId());
          return;
        }
        string _UserId = "";
        if (!ModGeneralFunctions.Validate_Permission(ref _UserId, true, false, "Autorizar Eliminación", false))
        {
          if (ModGeneralVar.g_bol_IsClose)
            return;
          ModGeneralFunctions.MessageOk("¡No Tiene Permiso Válido!");
          return;
        }
      }
      else if (ModGeneralVar.g_BE_TR1_VARIABLES_B.get_IsDeleteItemNotSend())
      {
        string _UserId = "";
        if (!ModGeneralFunctions.Validate_Permission(ref _UserId, true, false, "Autorizar Eliminación de Producto", false))
        {
          if (ModGeneralVar.g_bol_IsClose)
            return;
          ModGeneralFunctions.MessageOk("¡No Tiene Permiso Válido!");
          return;
        }
      }
      short Index = checked ((short) (this.dgrvOrderDetails.CurrentRow.Index - 1));
      tr1OrderdetailsD.set_EstabliId(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId());
      tr1OrderdetailsD.set_OrderId(this.o_BE_TR1_ORDERDETAILS.get_OrderId());
      tr1OrderdetailsD.set_ItemId(this.o_BE_TR1_ORDERDETAILS.get_ItemId());
      tr1OrderdetailsD.set_ObservationD("");
      tr1OrderdetailsD.set_UserIdD(Conversions.ToString(Interaction.IIf(ModGeneralVar.g_Str_RecordID == null, (object) ModGeneralVar.g_BE_USERS.get_UserId(), (object) ModGeneralVar.g_Str_RecordID)));
      List<BE_TR1_ORDERDETAILS_D> tr1OrderdetailsDList = new List<BE_TR1_ORDERDETAILS_D>();
      tr1OrderdetailsDList.Add(tr1OrderdetailsD);
      this.o_BL_ORDERS.Delete_ORDERDETAILS(tr1OrderdetailsDList, false, false, ModGeneralVar.g_BE_TR1_CFGVARIABLES, ModGeneralVar.g_BE_TR1_VARIABLES_B);
      this.LLena_GridOrderDetails(tr1OrderdetailsD.get_OrderId());
      this.Ubicate_OrderDetail_ByIndex(Index);
    }

    private void Button_ChangePrice_Click(object sender, EventArgs e)
    {
      if (!this.OrderDetailValidated())
        return;
      if (ModGeneralVar.g_BE_TR1_CFGVARIABLES.get_ShowUserChangePrice())
      {
        string _UserId = "";
        if (!ModGeneralFunctions.Validate_Permission(ref _UserId, true, false, "Autorizar Cambio de Precio", false))
        {
          if (ModGeneralVar.g_bol_IsClose)
            return;
          ModGeneralFunctions.MessageOk("¡Usuario no Válido!");
          return;
        }
      }
      short index = checked ((short) this.dgrvOrderDetails.CurrentRow.Index);
      double pdblQuantity = Conversions.ToDouble(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgrvOrderDetails.DataSource, new object[1]
      {
        (object) index
      }, (string[]) null), (System.Type) null, "Quantity", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      double pdblOfficialPrice = Conversions.ToDouble(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgrvOrderDetails.DataSource, new object[1]
      {
        (object) index
      }, (string[]) null), (System.Type) null, "OfficialPrice", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      FrmChangePrice frmChangePrice = new FrmChangePrice(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgrvOrderDetails.DataSource, new object[1]
      {
        (object) index
      }, (string[]) null), (System.Type) null, "ProductDes", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)), pdblOfficialPrice, pdblQuantity);
      int num = (int) frmChangePrice.ShowDialog();
      double dblNewPrice = frmChangePrice.dbl_NewPrice;
      string strObservation = frmChangePrice.str_Observation;
      frmChangePrice.Dispose();
      if (!ModGeneralVar.g_bol_IsReady)
        return;
      ModGeneralVar.g_Str_OrderID = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgrvOrderDetails.DataSource, new object[1]
      {
        (object) index
      }, (string[]) null), (System.Type) null, "OrderId", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      ModGeneralVar.g_Str_ItemID = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgrvOrderDetails.DataSource, new object[1]
      {
        (object) index
      }, (string[]) null), (System.Type) null, "ItemId", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgrvOrderDetails.DataSource, new object[1]
      {
        (object) index
      }, (string[]) null), (System.Type) null, "ProductId", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      ModGeneralVar.g_BE_TR1_VARIABLES_B.get_Tax1();
      this.str_TypeOrder = ModGeneralVar.g_Str_OrderTypeID;
      string p_Mensaje = this.o_BL_ORDERDETAILS.CambiarPrecioxProducto(ModGeneralVar.g_Str_OrderID, ModGeneralVar.g_Str_ItemID, pdblOfficialPrice, dblNewPrice, "", strObservation);
      if (!p_Mensaje.Equals(StructApp.RESULT_OK))
        ModGeneralFunctions.MessageOk(p_Mensaje);
      NewLateBinding.LateSetComplex(NewLateBinding.LateIndexGet(this.dgrvOrderDetails.DataSource, new object[1]
      {
        (object) index
      }, (string[]) null), (System.Type) null, "PriceSale", new object[1]
      {
        (object) dblNewPrice
      }, (string[]) null, (System.Type[]) null, false, true);
      NewLateBinding.LateSetComplex(NewLateBinding.LateIndexGet(this.dgrvOrderDetails.DataSource, new object[1]
      {
        (object) index
      }, (string[]) null), (System.Type) null, "SaleMount", new object[1]
      {
        (object) (dblNewPrice * pdblQuantity)
      }, (string[]) null, (System.Type[]) null, false, true);
      this.dgrvOrderDetails.Refresh();
      this.Fill_SubTotal(this.oListaORDERDETAILS);
    }

    private void Button_Disaggregate_Click(object sender, EventArgs e)
    {
      if (!this.OrderDetailValidated())
        return;
      this.o_BE_TR1_ORDERDETAILS = (BE_TR1_ORDERDETAILS) this.dgrvOrderDetails.CurrentRow.DataBoundItem;
      if (this.o_BE_TR1_ORDERDETAILS.get_IsPrinted())
        ModGeneralFunctions.MessageOk("No Se Puede Disgregar Un Producto Ya Impreso!!!");
      else if (this.o_BE_TR1_ORDERDETAILS.get_Quantity() - 1.0 < 1.0)
      {
        ModGeneralFunctions.MessageOk("No Puede Disgregar el Item!!!");
      }
      else
      {
        this.o_BL_ORDERS.DisaggregateItem(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId(), this.o_BE_TR1_ORDERDETAILS.get_OrderId(), this.o_BE_TR1_ORDERDETAILS.get_ItemId());
        this.LLena_GridOrderDetails(this.o_BE_TR1_ORDERDETAILS.get_OrderId());
        this.Ubicate_OrderDetail(this.o_BE_TR1_ORDERDETAILS.get_ItemId());
      }
    }

    private void Button_SearchItem_Click(object sender, EventArgs e)
    {
      if (ModGeneralVar.g_BE_TR1_VARIABLES_B.get_WithStore())
      {
        if (!this.OrderDetailValidated())
          return;
        BL_TR1_PRODUCTS blTr1Products = new BL_TR1_PRODUCTS();
        string str1 = "";
        string str2 = "";
        this.o_BE_TR1_ORDERDETAILS = (BE_TR1_ORDERDETAILS) this.dgrvOrderDetails.CurrentRow.DataBoundItem;
        string str3 = this.o_BL_ORDERDETAILS.ObtenerCodProdporItemPedido(this.o_BE_TR1_ORDERDETAILS.get_OrderId(), this.o_BE_TR1_ORDERDETAILS.get_ItemId());
        string Left = blTr1Products.ObtenerCodProdAlmacenporCodProd(str3);
        if (Operators.CompareString(Left, "", false) == 0)
        {
          ModGeneralFunctions.MessageOk("¡El Producto no tiene enlazace con Almacén!");
        }
        else
        {
          FrmMostrarStockproductosAlmacen stockproductosAlmacen = new FrmMostrarStockproductosAlmacen();
          MyProject.Forms.FrmMostrarStockproductosAlmacen.str_ProductIdalm = Left;
          int num = (int) MyProject.Forms.FrmMostrarStockproductosAlmacen.ShowDialog();
          MyProject.Forms.FrmMostrarStockproductosAlmacen.Dispose();
        }
        str1 = (string) null;
        str2 = (string) null;
      }
      else
        ModGeneralFunctions.MessageOk("¡El Punto de venta no está enlazado con el Almacén!");
    }

    private void Button_SendCommand_Click(object sender, EventArgs e)
    {
      if (!this.OrderDetailValidated())
        return;
      if (this.AllPrintedItems())
      {
        ModGeneralFunctions.MessageOk("¡Todos los items ya fueron enviados!");
      }
      else
      {
        if (!ModGeneralFunctions.MessageMakeAction(this.Res_SendCommand, false))
          return;
        this.o_BE_TR1_ORDERDETAILS = (BE_TR1_ORDERDETAILS) this.dgrvOrderDetails.CurrentRow.DataBoundItem;
        string p_Mensaje = this.o_BL_ORDERS.ImprimirComanda(this.TextBox_OrderId.Text, false, false, false, "", ModGeneralVar.g_BE_TR1_VARIABLES_B, ModGeneralVar.g_BE_TR1_CFGVARIABLES, true, false);
        if (!p_Mensaje.Equals(StructApp.RESULT_OK))
        {
          ModGeneralFunctions.MessageOk(p_Mensaje);
        }
        else
        {
          this.LLena_GridOrderDetails(this.o_BE_TR1_ORDERDETAILS.get_OrderId());
          this.Ubicate_OrderDetail(this.o_BE_TR1_ORDERDETAILS.get_ItemId());
        }
      }
    }

    public bool AllPrintedItems()
    {
      bool flag = true;
      int num1 = checked (this.dgrvOrderDetails.Rows.Count - 1);
      int num2 = 0;
      while (num2 <= num1)
      {
        object[] objArray;
        bool[] flagArray;
        object Instance = NewLateBinding.LateGet(this.dgrvOrderDetails.DataSource, (System.Type) null, "item", objArray = new object[1]
        {
          (object) num2
        }, (string[]) null, (System.Type[]) null, flagArray = new bool[1]
        {
          true
        });
        if (flagArray[0])
          num2 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray[0]), typeof (int));
        if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(Instance, (System.Type) null, "IsPrinted", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) false, false))
          return false;
        checked { ++num2; }
      }
      return flag;
    }

    private void Button_Calculator_Click(object sender, EventArgs e)
    {
      ModGeneralFunctions.ShowCalculator();
    }

    private void Button_CreateTicket_Click(object sender, EventArgs e)
    {
      this.Button_RefreshOrder_Click((object) null, (EventArgs) null);
      if (!this.OrderHeadValidated() || !this.OrderDetailValidated())
        return;
      if (Conversions.ToBoolean(ModGeneralFunctions.ObtenerAPPCONFIG("COMPROBANTE_RAZONSOCIAL_SELECCIONAR")))
      {
        if (!this.crearPedidoxPedido(ModGeneralVar.g_GeneralCode.get_Docu_Ticket()).Equals(""))
          return;
      }
      if (!ModGeneralFunctions.MessageMakeAction("Generar [" + ModGeneralVar.get_Docu_BoletaOrTicket() + "]?", false))
      {
        this.LoadData();
      }
      else
      {
        string p_Mensaje = "";
        int pintDocumentCode = 0;
        if (ModGeneralVar.g_BE_TR1_CFGVARIABLES.get_IsFirstPay() & !ModGeneralVar.g_Str_OrderTypeID.Equals(ModGeneralVar.g_Str_OrderTypeDelivery))
        {
          if (ModGeneralVar.g_BE_TR1_CFGVARIABLES.get_ShowPay())
          {
            if (ModGeneralFunctions.MessageMakeAction("¿Pagar Atencion [" + this.TextBox_OrderId.Text.Trim() + "]?", false) && ModGeneralFunctions.PagarxAtencion(this.TextBox_OrderId.Text.Trim(), ModGeneralVar.g_GeneralCode.get_Docu_Ticket()))
              p_Mensaje = StructApp.RESULT_OK;
          }
          else if (ModGeneralFunctions.PagarxAtencion(this.TextBox_OrderId.Text.Trim(), ModGeneralVar.g_GeneralCode.get_Docu_Ticket()))
            p_Mensaje = StructApp.RESULT_OK;
        }
        else
        {
          p_Mensaje = ModGeneralFunctions.CrearDocumento(this.TextBox_OrderId.Text.Trim(), ModGeneralVar.g_GeneralCode.get_Docu_Ticket(), ref pintDocumentCode, true, ModGeneralVar.g_IsDelivery, (BE_TR1_DOCUMENTS) null, (BECollec_TR1_DOCUMENTS_PAID) null, false);
          if (!ModGeneralVar.g_Str_OrderTypeID.Equals(ModGeneralVar.g_Str_OrderTypeDelivery))
          {
            if (ModGeneralVar.g_BE_TR1_CFGVARIABLES.get_ShowPay())
            {
              if (ModGeneralFunctions.MessageMakeAction("¿Pagar Atención [" + this.TextBox_OrderId.Text.Trim() + "]?", false) && ModGeneralFunctions.PagarxDocumento(pintDocumentCode, false, false))
                p_Mensaje = StructApp.RESULT_OK;
            }
            else if (ModGeneralFunctions.PagarxDocumento(pintDocumentCode, false, false))
              p_Mensaje = StructApp.RESULT_OK;
          }
        }
        if (p_Mensaje.Equals(StructApp.RESULT_OK))
        {
          ModGeneralVar.g_Str_OrderID = "";
          ModGeneralVar.g_Str_SubTableDes = "";
          this.LimpiarPedido();
        }
        else
        {
          if (p_Mensaje.Equals(""))
            return;
          ModGeneralFunctions.MessageError_Large(p_Mensaje, true);
        }
      }
    }

    private void ClearOrder()
    {
      this.dgrvOrderDetails.DataSource = (object) null;
      this.TextBox_OrderId.Text = "";
      this.MyXpButton_OrderDetails_Text.Text = "Orden: Por Generar / Items: 0";
      this.lblTotalPedido.Text = ModGeneralFunctions.CadenaToDoubleFormateado(Conversions.ToString(0), 2);
      this.ToolStripStatusLabel_OrderDes.Text = "Por Generar";
    }

    private void Button_CreateInvoice_Click(object sender, EventArgs e)
    {
      this.Button_RefreshOrder_Click((object) null, (EventArgs) null);
      if (!this.OrderHeadValidated() || !this.OrderDetailValidated())
        return;
      if (Conversions.ToBoolean(ModGeneralFunctions.ObtenerAPPCONFIG("BOL_ORDENCOMPRA")) && this.obeORDER.get_OrdenCompra().Trim().Equals(""))
        this.OrdenCompra();
      if (Conversions.ToBoolean(ModGeneralFunctions.ObtenerAPPCONFIG("BOL_GUIAREMISION")) && this.obeORDER.get_GuiaRemision().Trim().Equals(""))
        this.GuiaRemision();
      if (ModGeneralFunctions.CadenaToInteger(this.TextBox_ClientId.Text) == 0)
      {
        if (!this.SaveClient())
          return;
        this.TextBox_ClientId.Text = ModGeneralVar.g_Str_RecordID;
      }
      else if (ModGeneralVar.g_BE_TR1_CFGVARIABLES.get_ConfirmarDocumento() && !ModGeneralFunctions.MessageMakeAction("¿Generar [Factura]?", false))
        return;
      if (Conversions.ToBoolean(ModGeneralFunctions.ObtenerAPPCONFIG("COMPROBANTE_RAZONSOCIAL_SELECCIONAR")))
      {
        if (!this.crearPedidoxPedido(ModGeneralVar.g_GeneralCode.get_Docu_Invoice()).Equals(""))
          return;
      }
      string p_Mensaje = "";
      int pintDocumentCode = 0;
      if (ModGeneralVar.g_BE_TR1_CFGVARIABLES.get_IsFirstPay() & !ModGeneralVar.g_Str_OrderTypeID.Equals(ModGeneralVar.g_Str_OrderTypeDelivery))
      {
        if (ModGeneralVar.g_BE_TR1_CFGVARIABLES.get_ShowPay())
        {
          if (ModGeneralFunctions.MessageMakeAction("¿Pagar Atencion [" + this.TextBox_OrderId.Text.Trim() + "]?", false) && ModGeneralFunctions.PagarxAtencion(this.TextBox_OrderId.Text.Trim(), ModGeneralVar.g_GeneralCode.get_Docu_Invoice()))
            p_Mensaje = StructApp.RESULT_OK;
        }
        else if (ModGeneralFunctions.PagarxAtencion(this.TextBox_OrderId.Text.Trim(), ModGeneralVar.g_GeneralCode.get_Docu_Invoice()))
          p_Mensaje = StructApp.RESULT_OK;
      }
      else
      {
        p_Mensaje = ModGeneralFunctions.CrearDocumento(this.TextBox_OrderId.Text.Trim(), ModGeneralVar.g_GeneralCode.get_Docu_Invoice(), ref pintDocumentCode, true, ModGeneralVar.g_IsDelivery, (BE_TR1_DOCUMENTS) null, (BECollec_TR1_DOCUMENTS_PAID) null, false);
        if (!ModGeneralVar.g_Str_OrderTypeID.Equals(ModGeneralVar.g_Str_OrderTypeDelivery))
        {
          if (ModGeneralVar.g_BE_TR1_CFGVARIABLES.get_ShowPay())
          {
            if (ModGeneralFunctions.MessageMakeAction("¿Pagar Atención [" + this.TextBox_OrderId.Text.Trim() + "]?", false) && ModGeneralFunctions.PagarxDocumento(pintDocumentCode, false, false))
              p_Mensaje = StructApp.RESULT_OK;
          }
          else if (ModGeneralFunctions.PagarxDocumento(pintDocumentCode, false, false))
            p_Mensaje = StructApp.RESULT_OK;
        }
      }
      if (p_Mensaje.Equals(StructApp.RESULT_OK))
      {
        ModGeneralVar.g_Str_OrderID = "";
        ModGeneralVar.g_Str_SubTableDes = "";
        this.LimpiarPedido();
      }
      else
      {
        if (p_Mensaje.Equals(""))
          return;
        ModGeneralFunctions.MessageError_Large(p_Mensaje, true);
      }
    }

    private void Button_Precuenta_Click(object sender, EventArgs e)
    {
      if (!this.OrderHeadValidated() || !this.OrderDetailValidated())
        return;
      int num1;
      if (ModGeneralVar.g_BE_TR1_VARIABLES_B.get_ShowOpcPrebill())
      {
        FrmPrecuenta frmPrecuenta = new FrmPrecuenta(ModGeneralVar.g_BE_TR1_CFGVARIABLES.get_PrinterPrecountId());
        int num2 = (int) frmPrecuenta.ShowDialog();
        num1 = frmPrecuenta.ObtenerTicketera();
        frmPrecuenta.Dispose();
        if (ModGeneralVar.g_bol_IsClose)
          return;
      }
      else
      {
        ModGeneralVar.g_bol_PrecountGroup = false;
        num1 = ModGeneralVar.g_BE_TR1_CFGVARIABLES.get_PrinterPrecountId();
      }
      string _UserId = "";
      if (!this.o_BL_ORDERS.ValidarPrecuenta(ModGeneralVar.g_Str_OrderID) && ModGeneralVar.g_BE_TR1_VARIABLES_B.get_PermisoAdminReImpPrecuenta() && !ModGeneralFunctions.Validate_Permission(ref _UserId, true, false, "Autorizar ReImpresión de Precuenta", false))
      {
        if (ModGeneralVar.g_bol_IsClose)
          return;
        ModGeneralFunctions.MessageOk("¡No Tiene Permiso Válido!");
      }
      else
      {
        string p_Mensaje = this.o_BL_ORDERS.ImprimirPrecuenta(this.TextBox_OrderId.Text.Trim(), ModGeneralVar.g_bol_PrecountGroup, ModGeneralVar.g_CompanyNamePWeb, ModGeneralVar.g_CompanyNameNextel, ModGeneralVar.g_BE_TR1_CFGVARIABLES, ModGeneralVar.g_BE_TR1_VARPREBILL, ModGeneralVar.g_BE_TR1_VARIABLES_B, num1, 0, false, "", ModGeneralVar.g_BE_USERS.get_UserId(), _UserId, Conversions.ToString(ModGeneralFunctions.ObtenerAPPCONFIG("PRECUENTAG")), Conversions.ToBoolean(ModGeneralFunctions.ObtenerAPPCONFIG("PRECUENTA_DELIVERY")), ModGeneralVar.g_BE_TR1_AGENTDELIVERY, Conversions.ToBoolean(ModGeneralFunctions.ObtenerAPPCONFIG("MOSTRAR_PRECUENTA_DATOS_FINALES")), Conversions.ToBoolean(ModGeneralFunctions.ObtenerAPPCONFIG("MOSTRAR_RAZONSOCIAL_PRIMERO_DOCUMENTO_TICKET")), Conversions.ToBoolean(ModGeneralFunctions.ObtenerAPPCONFIG("PRECUENTA_MOSTRAROFERTA")), Conversions.ToString(ModGeneralFunctions.ObtenerAPPCONFIG("PRECUENTA_TEXTOTEEMPLAZA")), Conversions.ToString(ModGeneralFunctions.ObtenerAPPCONFIG("PRECUENTA_TEXTOFINALTEEMPLAZA")), false, false);
        if (!p_Mensaje.Equals(StructApp.RESULT_OK))
          ModGeneralFunctions.MessageOk(p_Mensaje);
      }
    }

    private void Button_ShowSale_Click(object sender, EventArgs e)
    {
      if (!(ModGeneralVar.g_BE_USERS.get_UserGroupId().Equals(ModGeneralVar.g_UserGroupGerencia) | ModGeneralVar.g_BE_USERS.get_UserGroupId().Equals(ModGeneralVar.g_UserGroupBoxAdmin)))
      {
        string _UserId = "";
        if (!ModGeneralFunctions.Validate_Permission(ref _UserId, true, false, "Autorizar ver Venta", true))
        {
          if (ModGeneralVar.g_bol_IsClose)
            return;
          ModGeneralFunctions.MessageOk("¡No Tiene Permiso Válido!");
          return;
        }
      }
      FrmCloseTurn frmCloseTurn = new FrmCloseTurn();
      frmCloseTurn.TypeOnlyQuery(true);
      int num = (int) frmCloseTurn.ShowDialog();
      frmCloseTurn.Dispose();
    }

    private void Button_BillToPay_Click(object sender, EventArgs e)
    {
      FrmWorkDocuments frmWorkDocuments = new FrmWorkDocuments(0);
      frmWorkDocuments.bol_AnnulDocument = false;
      if (ModGeneralFunctions.ObtenerAPPCONFIG("CLIENTE").Equals((object) "IRUN"))
      {
        if (Operators.CompareString(new BL_TR1_ORDERS().ValidarPedidodesdeProforma(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId(), ModGeneralVar.g_Str_OrderID), "OK", false) == 0)
          frmWorkDocuments.bol_ProformaFacturada = true;
      }
      int num = (int) frmWorkDocuments.ShowDialog();
      if (frmWorkDocuments.bol_AnnulDocument)
      {
        ModGeneralVar.g_Str_OrderID = "";
        ModGeneralVar.g_Str_SubTableDes = "";
        this.LimpiarPedido();
      }
      frmWorkDocuments.Dispose();
    }

    private void Button_RefreshOrder_Click(object sender, EventArgs e)
    {
      if (!this.OrderHeadValidated())
        return;
      this.LLena_GridOrderDetails(this.TextBox_OrderId.Text);
      this.Ubicate_OrderDetail_ByIndex(checked ((short) (this.dgrvOrderDetails.Rows.Count - 1)));
    }

    private void Button_DeleteOrder_Click(object sender, EventArgs e)
    {
      if (!this.OrderHeadValidated())
        return;
      if (ModGeneralVar.g_BE_TR1_CFGVARIABLES.get_ShowUserDeleteOrder())
      {
        string _UserId = "";
        if (!ModGeneralFunctions.Validate_Permission(ref _UserId, true, false, "Autorizar Eliminación de Pedido", false))
        {
          if (ModGeneralVar.g_bol_IsClose)
            return;
          ModGeneralFunctions.MessageOk("¡No Tiene Permiso Válido!");
          return;
        }
      }
      if (ModGeneralFunctions.MessageMakeAction("¿Seguro de Eliminar Pedido?", false))
      {
        if (ModGeneralVar.g_bol_Anulation)
        {
          string str = "";
          ModGeneralFunctions.TextKeyBoard("Ingrese el Motivo de la Anulación", ref str);
          if (ModGeneralVar.g_bol_IsClose)
            return;
          if (Strings.Len(ModGeneralVar.g_str_InputValue) == 0)
          {
            ModGeneralFunctions.MessageOk("Debe Ingresar el motivo de la Anulación!!!");
            return;
          }
        }
        BE_TR1_ORDERS beTr1Orders = new BE_TR1_ORDERS();
        beTr1Orders.set_OrderId(this.TextBox_OrderId.Text);
        beTr1Orders.set_TurnId(ModGeneralVar.g_BE_TR1_TURNS.get_TurnId());
        beTr1Orders.set_EstabliId(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId());
        beTr1Orders.set_UserId(ModGeneralVar.g_BE_USERS.get_UserId());
        beTr1Orders.set_CancelObservation(ModGeneralVar.g_str_InputValue);
        if (this.o_BL_ORDERS.Delete(beTr1Orders, ModGeneralVar.g_BusinessCode.get_ORDER_ANULADO(), ModGeneralVar.g_BusinessCode.get_TABLE_LISTA(), ModGeneralVar.g_BusinessCode.get_TABLE_OCUPADA()).Equals("OK"))
          this.ClearOrder();
        this.LimpiarPedido();
      }
    }

    private void Button_ReSendCommand_Click(object sender, EventArgs e)
    {
      if (ModGeneralVar.g_BE_TR1_VARIABLES_B.get_PermisoAdmReImpComanda() && !(ModGeneralVar.g_BE_USERS.get_UserGroupId().Equals(ModGeneralVar.g_UserGroupGerencia) | ModGeneralVar.g_BE_USERS.get_UserGroupId().Equals(ModGeneralVar.g_UserGroupBoxAdmin)))
      {
        string _UserId = "";
        if (!ModGeneralFunctions.Validate_Permission(ref _UserId, true, false, "Autorizar ReImpresión Comanda", true))
        {
          if (ModGeneralVar.g_bol_IsClose)
            return;
          ModGeneralFunctions.MessageOk("¡No Tiene Permiso Válido!");
          return;
        }
      }
      if (!this.OrderDetailValidated())
        return;
      if (this.NotPrintedItems())
      {
        ModGeneralFunctions.MessageOk("No Existen Item a Reenviar");
      }
      else
      {
        ModGeneralVar.g_Str_OrderID = this.TextBox_OrderId.Text;
        FrmDeleteDetail frmDeleteDetail = new FrmDeleteDetail();
        frmDeleteDetail.bol_RePrint = true;
        int num = (int) frmDeleteDetail.ShowDialog();
        frmDeleteDetail.Dispose();
      }
    }

    public bool NotPrintedItems()
    {
      bool flag = true;
      int num1 = checked (this.dgrvOrderDetails.Rows.Count - 1);
      int num2 = 0;
      while (num2 <= num1)
      {
        object[] objArray;
        bool[] flagArray;
        object Instance = NewLateBinding.LateGet(this.dgrvOrderDetails.DataSource, (System.Type) null, "item", objArray = new object[1]
        {
          (object) num2
        }, (string[]) null, (System.Type[]) null, flagArray = new bool[1]
        {
          true
        });
        if (flagArray[0])
          num2 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray[0]), typeof (int));
        if (Conversions.ToBoolean(NewLateBinding.LateGet(Instance, (System.Type) null, "IsPrinted", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)))
          return false;
        checked { ++num2; }
      }
      return flag;
    }

    private void RefreshOrder()
    {
      ModGeneralVar.g_Str_OrderID = this.TextBox_OrderId.Text;
      this.TextBox_OrderId.Text = this.obeORDER.get_OrderId();
      this.LoadData();
    }

    private void Button_Pay_Click(object sender, EventArgs e)
    {
      FrmDebits frmDebits = new FrmDebits();
      int num = (int) frmDebits.ShowDialog();
      frmDebits.Dispose();
    }

    private void Button_Discount_Click(object sender, EventArgs e)
    {
      this.Button_RefreshOrder_Click((object) null, (EventArgs) null);
      if (!this.OrderHeadValidated() || !this.OrderDetailValidated())
        return;
      string str1 = this.obeORDER.get_DiscountObser();
      if (ModGeneralVar.g_BE_TR1_CFGVARIABLES.get_ShowUserChangePrice() & str1.Equals(""))
      {
        FrmSelectProperties selectProperties = new FrmSelectProperties();
        selectProperties.bol_IsDelete = true;
        selectProperties.bol_IsDeleteOrder = true;
        selectProperties.strObservation = str1;
        ModGeneralVar.g_bol_IsReady = false;
        int num = (int) selectProperties.ShowDialog();
        str1 = selectProperties.strObservation;
        selectProperties.Dispose();
        if (!ModGeneralVar.g_bol_IsReady)
          return;
      }
      ModGeneralVar.g_Str_RecordID = "";
      FrmDiscount frmDiscount = new FrmDiscount();
      MyProject.Forms.FrmDiscount.Is_Discount = true;
      MyProject.Forms.FrmDiscount.str_Title = "Aplicar Descuento";
      MyProject.Forms.FrmDiscount.str_OrderId = this.TextBox_OrderId.Text;
      MyProject.Forms.FrmDiscount.str_ClientId = "0000000000";
      MyProject.Forms.FrmDiscount.str_ClientDes = this.TextBox_ClientDes.Text;
      MyProject.Forms.FrmDiscount.TotalAmount = this.dSD_subTotal;
      MyProject.Forms.FrmDiscount.str_Observation = str1;
      int num1 = (int) MyProject.Forms.FrmDiscount.ShowDialog();
      if (!ModGeneralVar.g_bol_EliminarDescuento)
      {
        if (ModGeneralVar.g_bol_IsReady)
        {
          if (ModGeneralVar.g_BE_TR1_CFGVARIABLES.get_ShowUserChangePrice())
          {
            string _UserId = "";
            if (!ModGeneralFunctions.Validate_Permission(ref _UserId, true, false, "Autorizar Generación de Descuento", false))
            {
              if (ModGeneralVar.g_bol_IsClose)
                return;
              ModGeneralFunctions.MessageOk("¡No Tiene Permiso Válido!");
              return;
            }
          }
          string text = MyProject.Forms.FrmDiscount.TextBox_ClientId.Text;
          this.ModificarCliente(MyProject.Forms.FrmDiscount.TextBox_ClientId.Text, "", "", this.obeORDER.get_OrderFree());
          this.AplicarDescuento(ModGeneralFunctions.CadenaToDouble(((TextBox) MyProject.Forms.FrmDiscount.TextBox_PercentDis).Text), ModGeneralFunctions.CadenaToDouble(((TextBox) MyProject.Forms.FrmDiscount.TextBox_PercentTotal).Text), MyProject.Forms.FrmDiscount.str_Observation, ModGeneralFunctions.CadenaToDouble(((TextBox) MyProject.Forms.FrmDiscount.TextBox_AmountPay).Text));
          this.CargarDetallePedidoxId(ModGeneralVar.g_Str_OrderID, false);
          this.intCambioPrecio = ModGeneralFunctions.CadenaToDouble(this.lblTotalPedido.Text) >= this.dSD_subTotal ? (short) 0 : (short) 1;
        }
      }
      else
      {
        if (ModGeneralVar.g_BE_TR1_CFGVARIABLES.get_ShowUserChangePrice())
        {
          string _UserId = "";
          if (!ModGeneralFunctions.Validate_Permission(ref _UserId, true, false, "Autorizar Eliminar de Descuento", false))
          {
            if (ModGeneralVar.g_bol_IsClose)
              return;
            ModGeneralFunctions.MessageOk("¡No Tiene Permiso Válido!");
            return;
          }
        }
        string str2 = this.o_BL_ORDERS.EliminarDescuentoMesa(this.TextBox_OrderId.Text, "");
        if (ModGeneralVar.g_BE_TR1_VARIABLES_B.get_IsDiscountClients())
        {
          BE_TR1_CLIENTS beTr1Clients = new BE_TR1_CLIENTS();
          ModGeneralVar.g_Str_RecordQuantity = (double) new BL_TR1_CLIENTS().ObtenerxId(this.TextBox_ClientId.Text).get_PerDiscount();
          if (ModGeneralFunctions.CadenaToInteger(Conversions.ToString(ModGeneralVar.g_Str_RecordQuantity)) > 0)
          {
            if (ModGeneralFunctions.MessageMakeAction("¿Desea Aplicar Dscto - " + Conversions.ToString(ModGeneralVar.g_Str_RecordQuantity) + "%?", false))
            {
              double num2 = Conversions.ToDouble(ModGeneralFunctions.CadenaToDoubleFormateado(Conversions.ToString(Convert.ToDouble(ModGeneralVar.g_Str_RecordQuantity) / 100.0 * this.dSD_subTotal), 2));
              this.TextBoxDiscount.Text = Conversions.ToString(ModGeneralVar.g_Str_RecordQuantity);
              this.TextBox_AmountDiscount.Text = Conversions.ToString(num2);
              this.lblTotalPedido.Text = ModGeneralFunctions.CadenaToDoubleFormateado(Conversions.ToString(Convert.ToDouble(this.dSD_subTotal) - num2), 2);
              this.obeORDER.set_IsDiscount(true);
              this.obeORDER.set_DiscountMount(ModGeneralFunctions.CadenaToDouble(Conversions.ToString(num2)));
              this.obeORDER.set_PerDiscount(ModGeneralFunctions.CadenaToDouble(Conversions.ToString(ModGeneralVar.g_Str_RecordQuantity)));
              if (this.obeORDER.get_PerDiscount() > 0.0)
              {
                str2 = this.o_BL_ORDERS.ModifyDiscountxCliente(this.TextBox_OrderId.Text, this.obeORDER.get_PerDiscount(), this.obeORDER.get_DiscountMount(), "Dscto. Programado x Cliente;", 0.0);
                this.CargarDetallePedidoxId(this.TextBox_OrderId.Text, true);
              }
            }
            else
            {
              this.obeORDER.set_IsDiscount(true);
              this.obeORDER.set_DiscountMount(0.0);
              this.obeORDER.set_PerDiscount(0.0);
              this.CargarDetallePedidoxId(this.TextBox_OrderId.Text, true);
            }
          }
          this.ObtenerPedidoxId(Conversions.ToBoolean(ModGeneralVar.g_Str_OrderID));
          beTr1Clients = (BE_TR1_CLIENTS) null;
        }
      }
      MyProject.Forms.FrmDiscount.Dispose();
    }

    private void SetOrder(string pstrOrderId, double pdblImporteDescuento)
    {
      this.o_BL_ORDERS.ModifyDiscountDetail(this.TextBox_OrderId.Text, pdblImporteDescuento);
      this.oListaORDERDETAILS = this.o_BL_ORDERDETAILS.ListarxId(pstrOrderId);
      this.Fill_SubTotal(this.oListaORDERDETAILS);
      this.dgrvOrderDetails.DataSource = (object) this.oListaORDERDETAILS;
    }

    private void dgrvOrderDetails_CellFormatting(
      object sender,
      DataGridViewCellFormattingEventArgs e)
    {
      if (e.ColumnIndex == 5)
      {
        if (Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgrvOrderDetails.DataSource, new object[1]
        {
          (object) e.RowIndex
        }, (string[]) null), (System.Type) null, "IsPrinted", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)))
          e.Value = (object) TriNetRestPOS.My.Resources.Resources._True;
        else
          e.Value = (object) TriNetRestPOS.My.Resources.Resources._False;
      }
      if (e.ColumnIndex != 6)
        return;
      if (Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgrvOrderDetails.DataSource, new object[1]
      {
        (object) e.RowIndex
      }, (string[]) null), (System.Type) null, "IsObservated", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)))
        e.Value = (object) TriNetRestPOS.My.Resources.Resources._True;
      else
        e.Value = (object) TriNetRestPOS.My.Resources.Resources._False;
    }

    private void Button_Options_Click(object sender, EventArgs e)
    {
    }

    private void MyXPButton_Pay_Click(object sender, EventArgs e)
    {
      if (!ModGeneralFunctions.ValidInventoryClose())
      {
        ModGeneralFunctions.MessageOk("¡Se ha cerrado el Inventario, no podrá Generar Pagos!");
      }
      else
      {
        this.Button_RefreshOrder_Click((object) null, (EventArgs) null);
        if (!this.OrderHeadValidated() || !this.OrderDetailValidated())
          return;
        if (ModGeneralVar.g_BE_TR1_CFGVARIABLES.get_ShowCommand() && !this.AllPrintedItems())
        {
          ModGeneralFunctions.MessageOk("¡Falta Enviar Comanda!");
        }
        else
        {
          FrmOpcionPagos frmOpcionPagos = new FrmOpcionPagos();
          int num1 = (int) frmOpcionPagos.ShowDialog();
          frmOpcionPagos.Dispose();
          if (ModGeneralVar.g_bol_IsClose)
            return;
          if (ModGeneralVar.g_bol_PrintCourtesy)
            this.CreateCourtesy();
          else if (ModGeneralVar.g_bol_PrintAnticipe)
          {
            if (ModGeneralFunctions.CadenaToInteger(this.TextBox_ClientId.Text.Trim()) <= 0)
            {
              ModGeneralFunctions.MessageOk("¡Debe seleccionar un Cliente!");
              this.SaveClient();
              if (!ModGeneralVar.g_bol_IsReady)
                return;
            }
            FrmAnticipePay frmAnticipePay = new FrmAnticipePay();
            frmAnticipePay.strClientDes = this.TextBox_ClientDes.Text;
            frmAnticipePay.strClientId = this.TextBox_ClientId.Text.Trim();
            frmAnticipePay.dblTotalVenta = ModGeneralFunctions.CadenaToDouble(this.lblTotalPedido.Text);
            frmAnticipePay.obeORDER = this.obeORDER;
            frmAnticipePay.oListaORDERDETAILS = this.oListaORDERDETAILS;
            int num2 = (int) frmAnticipePay.ShowDialog();
            frmAnticipePay.Dispose();
            if (ModGeneralVar.g_bol_IsClose)
              return;
            this.LimpiarPedido();
          }
          else
          {
            if (!ModGeneralVar.g_bol_PrintDocuIntern)
              return;
            if (ModGeneralVar.g_BE_TR1_CFGVARIABLES.get_ShowUserDocuIntern())
            {
              string _UserId = "";
              if (!ModGeneralFunctions.Validate_Permission(ref _UserId, true, false, "Autorizar Generación Documento Interno", false))
              {
                if (ModGeneralVar.g_bol_IsClose)
                  return;
                ModGeneralFunctions.MessageOk("¡No Tiene Permiso Válido!");
                return;
              }
            }
            FrmSelectProperties selectProperties = new FrmSelectProperties();
            selectProperties._IsDocIntern = true;
            int num2 = (int) selectProperties.ShowDialog();
            string strObservation = selectProperties.strObservation;
            if (!ModGeneralVar.g_bol_IsReady)
              return;
            BE_TR1_DOCUMENTS beTr1Documents = new BE_TR1_DOCUMENTS();
            beTr1Documents.set_EstabliId(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId());
            beTr1Documents.set_EmpresaId(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EmpresaId());
            beTr1Documents.set_BoxId(ModGeneralVar.g_BE_TR1_CFGVARIABLES.get_BoxId());
            beTr1Documents.set_TurnId(ModGeneralVar.g_BE_TR1_TURNS.get_TurnId());
            beTr1Documents.set_OrderId(this.TextBox_OrderId.Text);
            beTr1Documents.set_DocumentType(ModGeneralVar.g_GeneralCode.get_Docu_Intern());
            beTr1Documents.set_AmountDis(this.obeORDER.get_DiscountMount());
            beTr1Documents.set_DocumentState(ModGeneralVar.g_BusinessCode.get_DOCU_PAYLESS());
            beTr1Documents.set_TypeChange(ModGeneralVar.g_BE_TR1_TURNS.get_TyChanSale());
            beTr1Documents.set_ClientId("0000000000");
            beTr1Documents.set_NumeroSerie(ModGeneralFunctions.ObtenerNumeroSerie(beTr1Documents.get_DocumentType(), beTr1Documents.get_ClientId()));
            beTr1Documents.set_Observation(strObservation);
            beTr1Documents.set_IsPayable(false);
            beTr1Documents.set_UserId(ModGeneralVar.g_BE_USERS.get_UserId());
            BE_TR1_ORDERS beTr1Orders = new BE_TR1_ORDERS();
            List<BE_TR1_ORDERS> beTr1OrdersList = new List<BE_TR1_ORDERS>();
            ReportDocument reportDocument = new ReportDocument();
            this.o_BL_ORDERS.o_BE_TR1_VARIABLES_B = (__Null) ModGeneralVar.g_BE_TR1_VARIABLES_B;
            if ((!ModGeneralVar.g_BE_TR1_CFGVARIABLES.get_IsPrinterMatricial() ? this.o_BL_ORDERS.CrearDocumento(beTr1Documents, this.oListaORDERDETAILS, ModGeneralVar.g_BusinessCode.get_ORDER_FACTURADO(), ModGeneralVar.g_BE_ORDER_OPTIONS, ModGeneralVar.g_BusinessCode.get_TABLE_LISTA(), ModGeneralVar.g_BusinessCode.get_TABLE_OCUPADA(), ModGeneralVar.g_BE_TR1_VARIABLES_B, false) : this.o_BL_ORDERS.CrearDocumentoMatricial(beTr1Documents, this.oListaORDERDETAILS, ModGeneralVar.g_BusinessCode.get_ORDER_FACTURADO(), ModGeneralVar.g_BE_ORDER_OPTIONS, ModGeneralVar.g_BusinessCode.get_TABLE_LISTA(), ModGeneralVar.g_BusinessCode.get_TABLE_OCUPADA(), ModGeneralVar.g_BE_TR1_VARIABLES_B, false)).Equals(StructApp.RESULT_OK))
            {
              ModGeneralFunctions.MessageOk("¡Se Generó Correctamente el Documento!");
              this.ClearOrder();
              this.LimpiarPedido();
            }
            else
              ModGeneralFunctions.MessageOk("¡Error al Generar el Documento!");
          }
        }
      }
    }

    private void CreateCourtesy()
    {
      string _UserId = "";
      if (ModGeneralVar.g_BE_TR1_CFGVARIABLES.get_IsTakeOrder() && !ModGeneralFunctions.Validate_Permission(ref _UserId, true, false, "Autorizar Generar Cortesía", false))
      {
        ModGeneralFunctions.MessageOk("¡No Tiene Permiso Válido!");
      }
      else
      {
        FrmKeyBoardAlphaN frmKeyBoardAlphaN = new FrmKeyBoardAlphaN();
        int num1 = (int) frmKeyBoardAlphaN.ShowDialog();
        if (!ModGeneralVar.g_bol_IsReady)
          return;
        string gStrInputValue = ModGeneralVar.g_str_InputValue;
        frmKeyBoardAlphaN.Dispose();
        string str1 = "";
        FrmChooseTD frmChooseTd = new FrmChooseTD();
        int num2 = (int) frmChooseTd.ShowDialog();
        string strTipoDocumento = frmChooseTd.str_TipoDocumento;
        frmChooseTd.Dispose();
        if (!ModGeneralVar.g_bol_IsReady)
          return;
        if (strTipoDocumento.Equals(ModGeneralVar.g_GeneralCode.get_Docu_Invoice()) | strTipoDocumento.Equals(ModGeneralVar.g_GeneralCode.get_Docu_Ticket()))
        {
          if (!ModGeneralFunctions.Show_SearchClient())
            return;
          str1 = ModGeneralVar.g_Str_RecordID;
        }
        BE_TR1_DOCUMENTS beTr1Documents = new BE_TR1_DOCUMENTS();
        if (ModGeneralVar.g_BE_TR1_CFGVARIABLES.get_ShowPorConsumo() && ModGeneralFunctions.MessageMakeAction("¿ Por Consumo ?", false))
          beTr1Documents.set_IsByConsumption(true);
        beTr1Documents.set_EstabliId(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId());
        beTr1Documents.set_EmpresaId(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EmpresaId());
        beTr1Documents.set_BoxId(ModGeneralVar.g_BE_TR1_CFGVARIABLES.get_BoxId());
        beTr1Documents.set_TurnId(ModGeneralVar.g_BE_TR1_TURNS.get_TurnId());
        beTr1Documents.set_OrderId(this.TextBox_OrderId.Text);
        beTr1Documents.set_DocumentType(strTipoDocumento);
        beTr1Documents.set_ClientId(str1);
        beTr1Documents.set_NumeroSerie(ModGeneralFunctions.ObtenerNumeroSerie(beTr1Documents.get_DocumentType(), beTr1Documents.get_ClientId()));
        beTr1Documents.set_DocumentState(ModGeneralVar.g_BusinessCode.get_DOCU_EXONERATED());
        beTr1Documents.set_Observation(gStrInputValue);
        beTr1Documents.set_TypeChange(ModGeneralVar.g_BE_TR1_TURNS.get_TyChanSale());
        beTr1Documents.set_IsCourtesy(true);
        beTr1Documents.set_UserId(ModGeneralVar.g_BE_USERS.get_UserId());
        BL_TR1_PRINTERS blTr1Printers = new BL_TR1_PRINTERS();
        BE_TR1_PRINTERS beTr1Printers = new BE_TR1_PRINTERS();
        if (strTipoDocumento.Equals(ModGeneralVar.g_GeneralCode.get_Docu_Invoice()))
          beTr1Printers = blTr1Printers.ListById(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId(), ModGeneralVar.g_BE_TR1_CFGVARIABLES.get_PrinterInvoiceId());
        else if (strTipoDocumento.Equals(ModGeneralVar.g_GeneralCode.get_Docu_Ticket()))
          beTr1Printers = blTr1Printers.ListById(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId(), ModGeneralVar.g_BE_TR1_CFGVARIABLES.get_PrinterTicketId());
        string str2 = "";
        BE_TR1_ORDERS beTr1Orders = new BE_TR1_ORDERS();
        List<BE_TR1_ORDERS> beTr1OrdersList = new List<BE_TR1_ORDERS>();
        ReportDocument p_ReportDocument = new ReportDocument();
        this.o_BL_ORDERS.o_BE_TR1_VARIABLES_B = (__Null) ModGeneralVar.g_BE_TR1_VARIABLES_B;
        string p_Mensaje;
        if (ModGeneralVar.g_BE_TR1_CFGVARIABLES.get_IsPrinterMatricial())
        {
          str2 = this.o_BL_ORDERS.CrearDocumentoMatricial(beTr1Documents, this.oListaORDERDETAILS, ModGeneralVar.g_BusinessCode.get_ORDER_FACTURADO(), ModGeneralVar.g_BE_ORDER_OPTIONS, ModGeneralVar.g_BusinessCode.get_TABLE_LISTA(), ModGeneralVar.g_BusinessCode.get_TABLE_OCUPADA(), (BE_TR1_VARIABLES_B) null, false);
          BE_TR1_ORDERS printerMatricial = this.o_BL_ORDERS.GetListPrinterMatricial(beTr1Documents.get_EstabliId(), beTr1Documents.get_DocumentCode(), beTr1Documents.get_IsByConsumption());
          beTr1OrdersList.Add(printerMatricial);
          if (Operators.CompareString(printerMatricial.get_p_IMP2(), "0.00", false) == 0)
            ModGeneralFunctions.SetUp_Report_Initial_Matricial(ref p_ReportDocument, "TR1_REPORT\\rpt_PrintDocumentMatricial.rpt", "", "", "");
          else
            ModGeneralFunctions.SetUp_Report_Initial_Matricial(ref p_ReportDocument, "TR1_REPORT\\rpt_PrintDocumentMatricialBig.rpt", "", "", "");
          p_ReportDocument.Database.Tables[0].SetDataSource((IEnumerable) beTr1OrdersList);
          ModGeneralFunctions.SetUp_Report_Final(ref p_ReportDocument, false, "Impresión de Factura");
          p_Mensaje = StructApp.RESULT_OK;
        }
        else
        {
          p_Mensaje = this.o_BL_ORDERS.CrearDocumento(beTr1Documents, this.oListaORDERDETAILS, ModGeneralVar.g_BusinessCode.get_ORDER_FACTURADO(), ModGeneralVar.g_BE_ORDER_OPTIONS, ModGeneralVar.g_BusinessCode.get_TABLE_LISTA(), ModGeneralVar.g_BusinessCode.get_TABLE_OCUPADA(), ModGeneralVar.g_BE_TR1_VARIABLES_B, Conversions.ToBoolean(ModGeneralFunctions.ObtenerAPPCONFIG("ACTIVAR_GRABAR_FACTURA_ELECTRONICA")));
          if (p_Mensaje.Equals(StructApp.RESULT_OK))
            p_Mensaje = this.o_BL_ORDERS.ImprimirDocumentos(beTr1Documents.get_EstabliId(), beTr1Documents.get_DocumentCode(), false, beTr1Documents.get_IsByConsumption(), ModGeneralVar.g_IsDelivery, ModGeneralVar.g_BE_TR1_AGENTDELIVERY, ModGeneralVar.g_BE_TR1_CFGVARIABLES, ModGeneralVar.g_BE_TR1_VARDOCUMENT, ModGeneralVar.g_BE_TR1_VARIABLES_B, Conversions.ToBoolean(ModGeneralFunctions.ObtenerAPPCONFIG("COMPROBANTE_COMBO")), false, true, false, true, false, false, false, false, false);
        }
        if (!p_Mensaje.Equals(StructApp.RESULT_OK))
        {
          ModGeneralFunctions.MessageOk(p_Mensaje);
        }
        else
        {
          this.ClearOrder();
          this.LimpiarPedido();
        }
      }
    }

    private void Button_ElegirNuevoPedido_Click(object sender, EventArgs e)
    {
      if (!ModGeneralFunctions.ValidInventoryClose())
      {
        ModGeneralFunctions.MessageOk("¡Se ha cerrado el Inventario, no podrá Generar Pedido Libre!");
      }
      else
      {
        BL_TR1_ORDERS blTr1Orders = new BL_TR1_ORDERS();
        if (!ModGeneralFunctions.PosTakeOrder())
          ModGeneralVar.g_Str_WaiterID = Conversions.ToString(0);
        try
        {
          FrmSearchOrder frmSearchOrder = new FrmSearchOrder(ModGeneralVar.g_BE_TR1_TURNS.get_TurnId(), ModGeneralVar.g_Str_OrderTypeID);
          frmSearchOrder.bolElegirPedido = true;
          frmSearchOrder.bol_IsViewOrder = true;
          frmSearchOrder.bol_OnlySearch = true;
          int num = (int) frmSearchOrder.ShowDialog();
          frmSearchOrder.Dispose();
          if (!ModGeneralVar.g_bol_IsClose)
          {
            this.obeORDER = blTr1Orders.ObtenerPedidoxId(ModGeneralVar.g_Str_OrderID, false);
            if (!ModGeneralVar.g_bol_IsReady)
              return;
            ModGeneralVar.g_bol_IsClose = false;
            string str = "";
            if (Operators.CompareString(this.obeORDER.get_OrderTypeId(), ModGeneralVar.g_Str_OrderTypeID_Default, false) == 0)
              str = " (Libre) ";
            this.TextBox_TypeOrder.Text = this.obeORDER.get_TypeOrderDes();
            this.TextBox_OrderId.Text = this.obeORDER.get_OrderId();
            this.TextBox_OrderDate.Text = Strings.Format((object) this.obeORDER.get_OrderDate(), "hh:mm tt");
            this.TextBoxDiscount.Text = Conversions.ToString(Interaction.IIf(this.obeORDER.get_DiscountMount() == 0.0, (object) "", (object) this.obeORDER.get_DiscountMount()));
            this.TextBox_ClientId.Text = this.obeORDER.get_ClientId();
            this.TextBox_ClientDes.Text = ModGeneralFunctions.CadenaToInteger(this.obeORDER.get_ClientId()) != 0 ? Strings.UCase(this.obeORDER.get_ClientCompany()) : Strings.UCase(this.obeORDER.get_OrderFree());
            this.TextBox_WaiterId.Text = Conversions.ToString(this.obeORDER.get_WaiterId());
            this.TextBox_WaiterDes.Text = this.obeORDER.get_WaiterDes();
            ModGeneralVar.g_Str_OrderTypeID = this.obeORDER.get_OrderTypeId();
            this.Tssl_Order_Des.Text = ModGeneralVar.g_Str_OrderFreeDes;
            this.Ubicate_Record(checked (this.Dgrv_OrderOld.Rows.Count - 1));
            this.LoadData();
            this.DeshabilitarBotonesxPedido_Proforma(this.obeORDER.get_EstabliId(), ModGeneralVar.g_Str_OrderID);
            if (this.bolEsTomador)
            {
              this.Button_CreateTicket.Enabled = false;
              this.Button_CreateInvoice.Enabled = false;
              this.MyXPButton_Pay.Enabled = false;
            }
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
      }
    }

    private void Button_Waiter_Click(object sender, EventArgs e)
    {
      if (!this.OrderHeadValidated() || !ModGeneralFunctions.Show_SearchWaiter(this.Res_Code, this.Res_Description, false))
        return;
      this.TextBox_WaiterId.Text = ModGeneralVar.g_Str_RecordID;
      this.TextBox_WaiterDes.Text = ModGeneralVar.g_Str_RecordDes;
      ModGeneralVar.g_Str_WaiterID = ModGeneralVar.g_Str_RecordID;
      this.o_BL_ORDERS.ModifyWaiter(this.TextBox_OrderId.Text, ModGeneralVar.g_Str_RecordID);
    }

    private void Button_DivideOrder_Click(object sender, EventArgs e)
    {
      if (!ModGeneralFunctions.ValidInventoryClose())
      {
        ModGeneralFunctions.MessageOk("¡Se ha cerrado el Inventario, no podrá Generar Documentos!");
      }
      else
      {
        this.Button_RefreshOrder_Click((object) null, (EventArgs) null);
        if (!this.OrderHeadValidated() || !this.OrderDetailValidated() || !this.ValidIsAmountMin())
          return;
        ModGeneralFunctions.NumberKeyBoard("DIVIDIR CUENTA ENTRE N°:", false);
        if (!ModGeneralVar.g_bol_IsReady)
          return;
        int integer = ModGeneralFunctions.CadenaToInteger(ModGeneralVar.g_str_InputValue);
        if (integer <= 1)
          ModGeneralFunctions.MessageOk("¡No se puede Dividir Cta. entre " + ModGeneralVar.g_str_InputValue + " Cuentas!");
        else if (ModGeneralVar.g_BE_TR1_VARIABLES_B.get_IsDivCtaNum() & integer > ModGeneralVar.g_BE_TR1_VARIABLES_B.get_DivCtaNum())
        {
          ModGeneralFunctions.MessageOk("¡Nº Máximo de Ctas. es " + Conversions.ToString(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_DivCtaNum()) + "!");
        }
        else
        {
          if (this.obeORDER == null)
          {
            ModGeneralVar.g_Str_OrderID = "";
            ModGeneralVar.g_Str_SubTableDes = "";
          }
          else
            ModGeneralVar.g_Str_OrderID = this.TextBox_OrderId.Text;
          ModGeneralVar.g_bol_IsReady = false;
          FrmDivideOrder frmDivideOrder = new FrmDivideOrder(FrmDivideOrder.Operacion.DIVISION_CUENTAS, "0000000000", "PÚBLICO EN GENERAL");
          frmDivideOrder.int_Size_NewDocuments = integer;
          frmDivideOrder.dbl_TotalAmount = Conversions.ToDouble(this.lblTotalPedido.Text);
          int num = (int) frmDivideOrder.ShowDialog();
          frmDivideOrder.Dispose();
          if (ModGeneralVar.g_bol_IsReady)
          {
            ModGeneralVar.g_Str_OrderID = "";
            ModGeneralVar.g_Str_SubTableDes = "";
            this.LimpiarPedido();
          }
        }
      }
    }

    private bool ValidIsAmountMin()
    {
      if (ModGeneralVar.g_BE_TR1_CFGVARIABLES.get_IsAmountMin())
      {
        int num1 = 1;
        double num2 = ModGeneralVar.g_BE_TR1_CFGVARIABLES.get_AmountMin() * (double) num1;
        double num3 = Convert.ToDouble(this.lblTotalPedido.Text);
        if (num3 < num2)
        {
          ModGeneralFunctions.MessageOk("¡ Faltan: " + Strings.FormatCurrency((object) (num2 - num3), 2, TriState.UseDefault, TriState.UseDefault, TriState.UseDefault) + " !\r\nMonto Mínimo de Consumo x Persona: " + Strings.FormatCurrency((object) ModGeneralVar.g_BE_TR1_CFGVARIABLES.get_AmountMin(), 2, TriState.UseDefault, TriState.UseDefault, TriState.UseDefault));
          return false;
        }
      }
      return true;
    }

    private void Button_Anticipe_Click(object sender, EventArgs e)
    {
      try
      {
        FrmDocumentAnticipe documentAnticipe = new FrmDocumentAnticipe();
        int num = (int) documentAnticipe.ShowDialog();
        documentAnticipe.Dispose();
        if (ModGeneralVar.g_bol_IsClose)
          ;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ModGeneralFunctions.MessageError_Large("Error al cargar Anticipo - " + ex.Message, true);
        ProjectData.ClearProjectError();
      }
    }

    private void Button_Client_Click(object sender, EventArgs e)
    {
      if (!this.OrderHeadValidated())
        return;
      this.SaveClient();
    }

    private bool SaveClient()
    {
      ModGeneralVar.g_Str_RecordID = "";
      FrmSearchClient frmSearchClient = new FrmSearchClient();
      frmSearchClient._OnlySearch = true;
      frmSearchClient._IsClientByInvoice = true;
      int num = (int) frmSearchClient.ShowDialog();
      frmSearchClient.Dispose();
      if (!ModGeneralVar.g_bol_IsReady)
        return false;
      if (Strings.Len(ModGeneralVar.g_Str_RecordID.Length) > 0 & !ModGeneralVar.g_bol_IsClose)
      {
        this.BuscarCodigoContacto(ModGeneralVar.g_Str_RecordValue);
        this.ModificarCliente(ModGeneralVar.g_Str_RecordID, ModGeneralVar.g_Str_RecordDes, ModGeneralVar.g_Str_RecordValue, ModGeneralVar.g_Str_RecordDes);
        if (ModGeneralVar.g_BE_TR1_VARIABLES_B.get_IsDiscountClients() && ModGeneralFunctions.CadenaToInteger(Conversions.ToString(ModGeneralVar.g_Str_RecordQuantity)) > 0)
        {
          if (ModGeneralFunctions.MessageMakeAction("¿Desea Aplicar Dscto - " + Conversions.ToString(ModGeneralVar.g_Str_RecordQuantity) + "%?", false))
          {
            new BL_TR1_ORDERS().RegresarPrecioOriginales(this.TextBox_OrderId.Text);
            double pdblImporte = Conversions.ToDouble(ModGeneralFunctions.CadenaToDoubleFormateado(Conversions.ToString(Convert.ToDouble(ModGeneralVar.g_Str_RecordQuantity) / 100.0 * this.dSD_subTotal), 2));
            this.TextBoxDiscount.Text = Conversions.ToString(ModGeneralVar.g_Str_RecordQuantity);
            this.TextBox_AmountDiscount.Text = Conversions.ToString(pdblImporte);
            this.lblTotalPedido.Text = ModGeneralFunctions.CadenaToDoubleFormateado(Conversions.ToString(Convert.ToDouble(this.dSD_subTotal) - pdblImporte), 2);
            this.obeORDER.set_IsDiscount(true);
            this.obeORDER.set_DiscountMount(ModGeneralFunctions.CadenaToDouble(Conversions.ToString(pdblImporte)));
            this.obeORDER.set_PerDiscount(ModGeneralFunctions.CadenaToDouble(Conversions.ToString(ModGeneralVar.g_Str_RecordQuantity)));
            this.AplicarDescuento(ModGeneralVar.g_Str_RecordQuantity, pdblImporte, "Dscto. Programado x Cliente;", 0.0);
            this.CargarDetallePedidoxId(this.TextBox_OrderId.Text, true);
          }
          else
          {
            this.obeORDER.set_IsDiscount(true);
            this.obeORDER.set_DiscountMount(0.0);
            this.obeORDER.set_PerDiscount(0.0);
            this.o_BL_ORDERS.ModifyDiscount(this.TextBox_OrderId.Text, 0.0, 0.0, "", 0.0);
            this.CargarDetallePedidoxId(this.TextBox_OrderId.Text, true);
          }
        }
      }
      return true;
    }

    private void DeshabilitarBotonesxPedido_Proforma(int EstabliId, string PedidoId)
    {
      if (ModGeneralFunctions.ObtenerAPPCONFIG("CLIENTE").Equals((object) "IRUN"))
      {
        string Left = new BL_TR1_ORDERS().ValidarPedidodesdeProforma(EstabliId, PedidoId);
        List<BE_TR1_PROFORMA> beTr1ProformaList1 = new List<BE_TR1_PROFORMA>();
        BL_TR1_PROFORMA blTr1Proforma = new BL_TR1_PROFORMA();
        if (Operators.CompareString(Left, "OK", false) == 0)
        {
          this.Button_DirectProduct.Enabled = false;
          this.Button_ChangePrice.Enabled = false;
          this.Button_MoreQuantity.Enabled = false;
          this.Button_LessQuantity.Enabled = false;
          this.Button_DeleteItem.Enabled = false;
          this.dgrvOrderDetails.Enabled = false;
          this.Button_Quantitytem.Enabled = false;
          this.Panel_Products.Enabled = false;
          this.Button_SearchItem.Enabled = false;
          this.MyXPButton_Pay.Enabled = false;
          this.Button_Precuenta.Enabled = false;
          this.btnProductos.Text = "Orden";
          List<BE_TR1_PROFORMA> beTr1ProformaList2 = blTr1Proforma.Mostrar_Proforma_x_PedidoId(EstabliId, PedidoId);
          if (!(beTr1ProformaList2 != null & beTr1ProformaList2.Count > 0))
            return;
          if (beTr1ProformaList2[0].get_TipoProformaId().Equals("01"))
          {
            this.Button_CreateTicket.Enabled = true;
            this.Button_CreateInvoice.Enabled = false;
          }
          if (beTr1ProformaList2[0].get_TipoProformaId().Equals("02"))
          {
            this.Button_CreateTicket.Enabled = false;
            this.Button_CreateInvoice.Enabled = true;
          }
        }
        else
        {
          this.Button_DirectProduct.Enabled = true;
          this.Button_ChangePrice.Enabled = true;
          this.Button_MoreQuantity.Enabled = true;
          this.Button_LessQuantity.Enabled = true;
          this.Button_DeleteItem.Enabled = true;
          this.Button_Quantitytem.Enabled = true;
          this.Panel_Products.Enabled = true;
          this.dgrvOrderDetails.Enabled = true;
          this.btnProductos.Enabled = true;
          this.btnProductos.Text = "Productos";
          this.Button_CreateTicket.Enabled = true;
          this.Button_CreateInvoice.Enabled = true;
          this.Button_SearchItem.Enabled = true;
          this.MyXPButton_Pay.Enabled = true;
          this.Button_Precuenta.Enabled = true;
        }
      }
      else
      {
        this.Button_DirectProduct.Enabled = true;
        this.Button_ChangePrice.Enabled = true;
        this.Button_MoreQuantity.Enabled = true;
        this.Button_LessQuantity.Enabled = true;
        this.Button_DeleteItem.Enabled = true;
        this.Button_Quantitytem.Enabled = true;
        this.Panel_Products.Enabled = true;
        this.dgrvOrderDetails.Enabled = true;
        this.btnProductos.Enabled = true;
        this.btnProductos.Text = "Productos";
        this.Button_CreateTicket.Enabled = true;
        this.Button_CreateInvoice.Enabled = true;
        this.Button_SearchItem.Enabled = true;
        this.MyXPButton_Pay.Enabled = true;
        this.Button_Precuenta.Enabled = true;
      }
    }

    private void BuscarCodigoContacto(string pstrCodigo)
    {
      if (!this.OrderHeadValidated())
        return;
      if (pstrCodigo.Trim().Equals(""))
      {
        this.strCodigoContacto = "";
      }
      else
      {
        try
        {
          BL_TR1_CONTACTS blTr1Contacts = new BL_TR1_CONTACTS();
          BL_TR1_CLIENTS blTr1Clients = new BL_TR1_CLIENTS();
          string str = "";
          this.Cursor = Cursors.WaitCursor;
          string pstrContactoId = blTr1Contacts.ObtenerIdxDNI(pstrCodigo) ?? "";
          List<BE_TR1_CLIENTS> beTr1ClientsList;
          if (!pstrContactoId.Equals(""))
          {
            beTr1ClientsList = blTr1Clients.ListarxContacto(pstrContactoId);
          }
          else
          {
            beTr1ClientsList = blTr1Clients.ListarxNombre("", pstrCodigo, "", "");
            if (beTr1ClientsList != null)
            {
              if (beTr1ClientsList.Count == 0)
              {
                beTr1ClientsList = blTr1Clients.ListarxNombre("", "", "", pstrCodigo);
                if (beTr1ClientsList != null && beTr1ClientsList.Count > 0)
                  str = beTr1ClientsList[0].get_ClientId();
              }
              else
                str = beTr1ClientsList[0].get_ClientId();
            }
          }
          this.Cursor = Cursors.Default;
          if (pstrContactoId == null)
            pstrContactoId = "";
          if (str == null)
            str = "";
          if (!pstrContactoId.Equals(""))
          {
            this.ActualizarContacto(ModGeneralVar.g_Str_OrderID, pstrContactoId);
            this.strCodigoContacto = "";
          }
          if (!str.Equals(""))
          {
            if (beTr1ClientsList != null)
              this.ActualizarContacto(ModGeneralVar.g_Str_OrderID, "");
            this.strCodigoContacto = "";
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          this.strCodigoContacto = "";
          ProjectData.ClearProjectError();
        }
      }
    }

    private void ModificarCliente(
      string pstrClienteId,
      string pstrClienteNombre,
      string pstrClienteDocumento,
      string pstrPedidoLibre)
    {
      string str1 = "";
      this.TextBox_ClientId.Text = pstrClienteId;
      this.TextBox_ClientDes.Text = pstrClienteNombre;
      this.TextBox_ClientIdentity.Text = pstrClienteDocumento;
      string str2 = this.o_BL_ORDERS.ModifyClient(this.TextBox_OrderId.Text, pstrClienteId, pstrPedidoLibre);
      if (!str2.Equals(StructApp.RESULT_OK))
        ModGeneralFunctions.MessageOk("¡Error al modificar Cliente - " + str2 + "!");
      str1 = (string) null;
    }

    private void CargarDetallePedidoxId(string pstrOrderId, bool pbolAplicarDscto = true)
    {
      if (this.obeORDER.get_IsDiscount() & pbolAplicarDscto)
        ModGeneralFunctions.CalcularPorcentaje(ModGeneralFunctions.CadenaToDouble(this.TextBoxDiscount.Text), this.o_BL_ORDERS.ObtenerTotalPedido(ModGeneralVar.g_Str_OrderID));
      this.oListaORDERDETAILS = this.o_BL_ORDERDETAILS.ListarxId(pstrOrderId);
      if (this.oListaORDERDETAILS != null)
      {
        this.dgrvOrderDetails.DataSource = (object) this.oListaORDERDETAILS;
        if (this.obeORDER.get_IsFree())
        {
          this.MyXpButton_OrderDetails_Text.Text = "LIBRE: [  ] / N° PROD: [ " + Conversions.ToString(this.oListaORDERDETAILS.Count) + " ]";
        }
        else
        {
          string str = "";
          if (!str.Equals(""))
            str = " - " + Strings.Trim(str.Replace("[", "").Replace("]", ""));
          this.MyXpButton_OrderDetails_Text.Text = "MESA: [ " + str + " ] / N° PROD: [ " + Conversions.ToString(this.oListaORDERDETAILS.Count) + " ]";
        }
        this.CalcularTotalaPagar();
      }
      else
        ModGeneralFunctions.MessageOk("¡Error al cargar Detalle de Pedido!");
    }

    private void AplicarDescuento(
      double pdblPorcentaje,
      double pdblImporte,
      string pstrObservacion,
      double pdblMontoaPagar = 0.0)
    {
      string str1 = "";
      string str2 = this.o_BL_ORDERS.ModifyDiscount(this.TextBox_OrderId.Text, pdblPorcentaje, pdblImporte, pstrObservacion, pdblMontoaPagar);
      if (str2.Equals(StructApp.RESULT_OK))
      {
        this.ObtenerPedidoxId(false);
        this.AplicarDescuentoDetalle(pdblPorcentaje);
        str1 = (string) null;
      }
      else
        ModGeneralFunctions.MessageOk("¡Error al aplicar Dscto. - " + str2 + "!");
    }

    private void CalcularTotalaPagar()
    {
      this.dSD_subTotal = this.o_BL_ORDERS.ObtenerTotalPedido(ModGeneralVar.g_Str_OrderID);
      this.lblTotalPedido.Text = ModGeneralFunctions.CadenaToDoubleFormateado(Conversions.ToString(this.dSD_subTotal), 2);
    }

    private void ObtenerPedidoxId(bool pbolTodo = true)
    {
      this.TextBox_OrderId.Text = ModGeneralVar.g_Str_OrderID;
      this.obeORDER = this.o_BL_ORDERS.ObtenerPedidoxId(ModGeneralVar.g_Str_OrderID, false);
      if (this.obeORDER == null)
        this.obeORDER = new BE_TR1_ORDERS();
      this.TextBox_TypeOrder.Text = this.obeORDER.get_TypeOrderDes();
      this.TextBox_OrderDate.Text = Conversions.ToString(Interaction.IIf(DateTime.Compare(this.obeORDER.get_OrderDate(), DateTime.MinValue) == 0, (object) "", (object) Strings.Format((object) this.obeORDER.get_OrderDate(), "hh:mm tt")));
      this.TextBox_OrderId.Text = this.obeORDER.get_OrderId();
      ModGeneralVar.g_Str_TableID = Conversions.ToString(this.obeORDER.get_TableId());
      this.TextBox_WaiterId.Text = Conversions.ToString(this.obeORDER.get_WaiterId());
      this.TextBox_WaiterDes.Text = this.obeORDER.get_WaiterDes();
      this.TextBox_ClientId.Text = this.obeORDER.get_ClientId();
      this.TextBox_ClientDes.Text = this.obeORDER.get_ClientCompany();
      this.TextBox_ClientIdentity.Text = this.obeORDER.get_ClientIdentity();
      this.TextBoxDiscount.Text = Conversions.ToString(Interaction.IIf(this.obeORDER.get_PerDiscount() == 0.0, (object) "", (object) this.obeORDER.get_PerDiscount()));
      this.TextBox_AmountDiscount.Text = Conversions.ToString(Interaction.IIf(this.obeORDER.get_DiscountMount() == 0.0, (object) "", (object) this.obeORDER.get_DiscountMount()));
      if (this.obeORDER.get_IsFree())
      {
        this.TextBox_TypeOrder.Text = this.obeORDER.get_TypeOrderDes() + " (Libre) ";
        if (this.obeORDER.get_OrderTypeId().Equals(ModGeneralVar.g_Str_OrderTypeDelivery))
        {
          ModGeneralVar.g_BE_TR1_AGENTDELIVERY = new BE_TR1_AGENT_DELIVERY();
          ModGeneralVar.g_AgentDeliveryId = this.obeORDER.get_DeliAgentId();
          ModGeneralVar.g_BE_TR1_AGENTDELIVERY.set_AgentId(this.obeORDER.get_DeliAgentId());
          ModGeneralVar.g_BE_TR1_AGENTDELIVERY.set_AgentDes(this.obeORDER.get_AgentDes());
          ModGeneralVar.g_IsDelivery = true;
          this.Label_WaiterDes.Text = "Agente";
          this.TextBox_WaiterDes.Text = this.obeORDER.get_AgentDes();
        }
      }
      else
      {
        ModGeneralVar.g_IsDelivery = false;
        this.Label_WaiterDes.Text = "Vendedor";
      }
      ModGeneralVar.g_Str_OrderTypeID = this.obeORDER.get_OrderTypeId();
      if (!pbolTodo)
        return;
      this.CargarDetallePedidoxId(ModGeneralVar.g_Str_OrderID, true);
    }

    private void AplicarDescuentoDetalle(double pdblImporte)
    {
      string str1 = "";
      string str2 = this.o_BL_ORDERS.ModifyDiscountDetail(this.TextBox_OrderId.Text.Trim(), pdblImporte);
      if (!str2.Equals(StructApp.RESULT_OK))
        ModGeneralFunctions.MessageOk("¡Error al aplicar Dscto. al Detalle - " + str2 + "!");
      else
        str1 = (string) null;
    }

    private void dgrvOrderDetails_SelectionChanged(object sender, EventArgs e)
    {
    }

    private void ConsultarStocks()
    {
      FrmProgramaProductos programaProductos = new FrmProgramaProductos();
      int num = (int) programaProductos.ShowDialog();
      programaProductos.Dispose();
    }

    private void btnProductos_Click(object sender, EventArgs e)
    {
      if (ModGeneralFunctions.ObtenerAPPCONFIG("CLIENTE").Equals((object) "IRUN"))
      {
        FrmProforma frmProforma = new FrmProforma();
        int num = (int) frmProforma.ShowDialog();
        frmProforma.Dispose();
      }
      else if (ModGeneralFunctions.ObtenerAPPCONFIG("CLIENTE").Equals((object) "MENFLO"))
      {
        BL_TR1_ORDERS blTr1Orders = new BL_TR1_ORDERS();
        if (!ModGeneralFunctions.PosTakeOrder())
          ModGeneralVar.g_Str_WaiterID = Conversions.ToString(0);
        try
        {
          FrmSearchOrder frmSearchOrder = new FrmSearchOrder(ModGeneralVar.g_BE_TR1_TURNS.get_TurnId(), ModGeneralVar.g_Str_OrderTypeID);
          frmSearchOrder.bolElegirPedido = false;
          frmSearchOrder.bol_IsViewOrder = true;
          frmSearchOrder.bol_OnlySearch = true;
          int num = (int) frmSearchOrder.ShowDialog();
          frmSearchOrder.Dispose();
          if (ModGeneralVar.g_bol_IsClose)
            return;
          this.obeORDER = blTr1Orders.ObtenerPedidoxId(ModGeneralVar.g_Str_OrderID, false);
          if (!ModGeneralVar.g_bol_IsReady)
            return;
          ModGeneralVar.g_bol_IsClose = false;
          string str1 = "";
          if (Operators.CompareString(this.obeORDER.get_OrderTypeId(), ModGeneralVar.g_Str_OrderTypeID_Default, false) == 0)
            str1 = " (Libre) ";
          this.TextBox_TypeOrder.Text = this.obeORDER.get_TypeOrderDes();
          this.TextBox_OrderId.Text = this.obeORDER.get_OrderId();
          this.TextBox_OrderDate.Text = Strings.Format((object) this.obeORDER.get_OrderDate(), "hh:mm tt");
          this.TextBoxDiscount.Text = Conversions.ToString(Interaction.IIf(this.obeORDER.get_DiscountMount() == 0.0, (object) "", (object) this.obeORDER.get_DiscountMount()));
          this.TextBox_ClientId.Text = this.obeORDER.get_ClientId();
          this.TextBox_ClientDes.Text = ModGeneralFunctions.CadenaToInteger(this.obeORDER.get_ClientId()) != 0 ? Strings.UCase(this.obeORDER.get_ClientCompany()) : Strings.UCase(this.obeORDER.get_OrderFree());
          this.TextBox_WaiterId.Text = Conversions.ToString(this.obeORDER.get_WaiterId());
          this.TextBox_WaiterDes.Text = this.obeORDER.get_WaiterDes();
          ModGeneralVar.g_Str_OrderTypeID = this.obeORDER.get_OrderTypeId();
          this.Tssl_Order_Des.Text = ModGeneralVar.g_Str_OrderFreeDes;
          this.Ubicate_Record(checked (this.Dgrv_OrderOld.Rows.Count - 1));
          this.LoadData();
          string str2 = "";
          str2 = this.o_BL_ORDERS.Change_Turn(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId(), ModGeneralVar.g_Str_OrderID, Conversions.ToString(ModGeneralVar.g_BE_TR1_CFGVARIABLES.get_BoxIdPos()), ModGeneralVar.g_BE_TR1_TURNS.get_TurnId());
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
      }
      else
      {
        FrmProductosPOS frmProductosPos = new FrmProductosPOS();
        frmProductosPos._OnlySearch = true;
        int num1 = (int) frmProductosPos.ShowDialog();
        frmProductosPos.Dispose();
        if (ModGeneralVar.g_bol_IsReady && this.OrderHeadValidated1(false) && ModGeneralVar.g_Str_RecordID.Length > 0)
        {
          BL_TR1_PRODUCTS blTr1Products1 = new BL_TR1_PRODUCTS();
          List<BE_TR1_AREA> beTr1AreaList1 = new List<BE_TR1_AREA>();
          List<BE_TR1_AREA> beTr1AreaList2 = blTr1Products1.ListAreasDownload(ModGeneralVar.g_Str_RecordID);
          if (beTr1AreaList2.Count == 1)
          {
            BE_TR1_PRODUCTS beTr1Products = new BE_TR1_PRODUCTS();
            BL_TR1_PRODUCTS blTr1Products2 = new BL_TR1_PRODUCTS();
            beTr1Products.set_AreaId(beTr1AreaList2[0].get_AreaIdStore());
            beTr1Products.set_AreaDesS(beTr1AreaList2[0].get_AreaDesStore());
            beTr1Products.set_PriceCost(beTr1AreaList2[0].get_ProductPriceCost());
            beTr1Products.set_ProductId(ModGeneralVar.g_Str_RecordID);
            blTr1Products1.EditProduct_Download(beTr1Products);
            blTr1Products2 = (BL_TR1_PRODUCTS) null;
          }
          else if (beTr1AreaList2.Count > 1)
          {
            ModGeneralVar.g_bol_IsReady = false;
            int num2 = (int) new FrmAreasDownload(ModGeneralVar.g_Str_RecordID, ModGeneralVar.g_Str_RecordDes).ShowDialog();
            if (!ModGeneralVar.g_bol_IsReady)
              return;
          }
          beTr1AreaList1 = (List<BE_TR1_AREA>) null;
          BL_TR1_PRODUCTS_PROGRAM tr1ProductsProgram1 = new BL_TR1_PRODUCTS_PROGRAM();
          BE_TR1_PRODUCTS_PROGRAM tr1ProductsProgram2 = new BE_TR1_PRODUCTS_PROGRAM();
          BE_TR1_PRODUCTS_PROGRAM tr1ProductsProgram3 = tr1ProductsProgram1.ValidateAlert(ModGeneralVar.g_Str_RecordID);
          if ((uint) Operators.CompareString(tr1ProductsProgram3.get_ProductId(), (string) null, false) > 0U)
          {
            if (tr1ProductsProgram3.get_QuantitySald() <= 0.0)
            {
              if (!ModGeneralFunctions.MessageMakeAction("Producto Sin Sotck ¡Desea Continuar!", false))
                return;
            }
            else if (tr1ProductsProgram3.get_QuantitySald() <= (double) ModGeneralVar.g_CantProgramAlert & tr1ProductsProgram3.get_QuantitySald() != 0.0)
              ModGeneralFunctions.MessageOk("¡Producto en Stock(" + Conversions.ToString(tr1ProductsProgram3.get_QuantitySald()) + ")!");
          }
          this.Grabar_DetalleProducto(ModGeneralVar.g_Str_RecordID, ModGeneralVar.g_Str_RecordDes, 1.0, "", 0.0);
        }
      }
    }

    private void Button_Credits_Click(object sender, EventArgs e)
    {
      this.Button_RefreshOrder_Click((object) null, (EventArgs) null);
      if (!this.OrderHeadValidated() || !this.OrderDetailValidated() || !this.ValidIsAmountMin())
        return;
      ModGeneralVar.g_Str_RecordID = "";
      string pstrClienteId = this.TextBox_ClientId.Text;
      if (pstrClienteId.Trim().Equals("") | pstrClienteId.Trim().Equals("0000000000"))
      {
        FrmSearchClient frmSearchClient = new FrmSearchClient();
        frmSearchClient._OnlyCredit = true;
        frmSearchClient._OnlySearch = true;
        if (this.dgrvOrderDetails.Rows.Count > 0)
        {
          frmSearchClient._GenerateCredit = true;
          frmSearchClient._AmountCredit = ModGeneralFunctions.CadenaToDouble(this.lblTotalPedido.Text);
        }
        ModGeneralVar.g_Str_OrderID = this.TextBox_OrderId.Text;
        string gStrClienteId = ModGeneralVar.g_Str_ClienteID;
        int num = (int) frmSearchClient.ShowDialog();
        frmSearchClient.Dispose();
        pstrClienteId = ModGeneralVar.g_Str_RecordID;
        if (!ModGeneralVar.g_bol_IsReady)
          return;
      }
      else
        ModGeneralVar.g_Str_RecordID = pstrClienteId;
      if (Strings.Len(pstrClienteId.Length) > 0 & !ModGeneralVar.g_bol_IsClose)
      {
        this.BuscarCodigoContacto(ModGeneralVar.g_Str_RecordValue);
        this.ModificarCliente(pstrClienteId, ModGeneralVar.g_Str_RecordDes, ModGeneralVar.g_Str_RecordValue, ModGeneralVar.g_Str_RecordDes);
        if (ModGeneralVar.g_BE_TR1_VARIABLES_B.get_IsDiscountClients() && ModGeneralFunctions.CadenaToInteger(Conversions.ToString(ModGeneralVar.g_Str_RecordQuantity)) > 0)
        {
          if (ModGeneralFunctions.MessageMakeAction("¿Desea Aplicar Dscto - " + Conversions.ToString(ModGeneralVar.g_Str_RecordQuantity) + "%?", false))
          {
            new BL_TR1_ORDERS().RegresarPrecioOriginales(this.TextBox_OrderId.Text);
            double pdblImporte = Conversions.ToDouble(ModGeneralFunctions.CadenaToDoubleFormateado(Conversions.ToString(Convert.ToDouble(ModGeneralVar.g_Str_RecordQuantity) / 100.0 * this.dSD_subTotal), 2));
            this.TextBoxDiscount.Text = Conversions.ToString(ModGeneralVar.g_Str_RecordQuantity);
            this.TextBox_AmountDiscount.Text = Conversions.ToString(pdblImporte);
            this.lblTotalPedido.Text = ModGeneralFunctions.CadenaToDoubleFormateado(Conversions.ToString(Convert.ToDouble(this.dSD_subTotal) - pdblImporte), 2);
            this.obeORDER.set_IsDiscount(true);
            this.obeORDER.set_DiscountMount(ModGeneralFunctions.CadenaToDouble(Conversions.ToString(pdblImporte)));
            this.obeORDER.set_PerDiscount(ModGeneralFunctions.CadenaToDouble(Conversions.ToString(ModGeneralVar.g_Str_RecordQuantity)));
            this.AplicarDescuento(ModGeneralVar.g_Str_RecordQuantity, pdblImporte, "Dscto. Programado x Cliente;", 0.0);
            this.CargarDetallePedidoxId(this.TextBox_OrderId.Text, true);
          }
          else
          {
            this.obeORDER.set_IsDiscount(true);
            this.obeORDER.set_DiscountMount(0.0);
            this.obeORDER.set_PerDiscount(0.0);
            this.o_BL_ORDERS.ModifyDiscount(this.TextBox_OrderId.Text, 0.0, 0.0, "", 0.0);
            this.CargarDetallePedidoxId(this.TextBox_OrderId.Text, true);
          }
        }
      }
      string str = "";
      if (Strings.Len(ModGeneralVar.g_Str_RecordID.Length) > 0)
      {
        str = this.o_BL_ORDERS.GenerarCredito(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId(), this.TextBox_OrderId.Text.Trim(), ModGeneralVar.g_BusinessCode.get_ORDER_ACOUNTCORRIENTE(), pstrClienteId, ModGeneralFunctions.CadenaToDouble(this.lblTotalPedido.Text), ModGeneralFunctions.CadenaToDouble(this.lblTotalPedido.Text), ModGeneralVar.g_BusinessCode.get_TABLE_LISTA(), ModGeneralVar.g_BusinessCode.get_TABLE_OCUPADA(), ModGeneralVar.g_BE_USERS.get_UserId(), true);
        BL_TR1_CREDITO_CAB blTr1CreditoCab = new BL_TR1_CREDITO_CAB();
        BE_TR1_CREDITO_CAB beTr1CreditoCab = new BE_TR1_CREDITO_CAB();
        List<BE_TR1_CREDITO_DET> beTr1CreditoDetList = new List<BE_TR1_CREDITO_DET>();
        BE_TR1_CREDITO_DET beTr1CreditoDet1 = new BE_TR1_CREDITO_DET();
        this.oListaORDERDETAILS = this.o_BL_ORDERDETAILS.ListarxId(this.TextBox_OrderId.Text.Trim());
        int num1 = checked (this.oListaORDERDETAILS.Count - 1);
        int index = 0;
        while (index <= num1)
        {
          BE_TR1_CREDITO_DET beTr1CreditoDet2 = new BE_TR1_CREDITO_DET();
          beTr1CreditoDet2.set_ProductoId(this.oListaORDERDETAILS[index].get_ProductId());
          beTr1CreditoDet2.set_GrupoId(this.oListaORDERDETAILS[index].get_GroupId());
          beTr1CreditoDet2.set_SubGrupoId(this.oListaORDERDETAILS[index].get_SubGroupId());
          beTr1CreditoDet2.set_PrecioCosto(this.oListaORDERDETAILS[index].get_PriceCost());
          beTr1CreditoDet2.set_PrecioNeto(this.oListaORDERDETAILS[index].get_PriceNeto());
          beTr1CreditoDet2.set_PrecioTax1(this.oListaORDERDETAILS[index].get_PriceTax1());
          beTr1CreditoDet2.set_PrecioTax2(this.oListaORDERDETAILS[index].get_PriceTax2());
          beTr1CreditoDet2.set_PrecioTax3(this.oListaORDERDETAILS[index].get_PriceTax3());
          beTr1CreditoDet2.set_PrecioVenta(this.oListaORDERDETAILS[index].get_PriceSale());
          beTr1CreditoDet2.set_Incremento(this.oListaORDERDETAILS[index].get_Surcharge());
          beTr1CreditoDet2.set_Descuento(this.oListaORDERDETAILS[index].get_Discount());
          beTr1CreditoDet2.set_PrecioOficial(this.oListaORDERDETAILS[index].get_OfficialPrice());
          beTr1CreditoDet2.set_Cantidad(this.oListaORDERDETAILS[index].get_Quantity());
          beTr1CreditoDet2.set_Tax1(this.oListaORDERDETAILS[index].get_Tax1());
          beTr1CreditoDet2.set_Tax2(this.oListaORDERDETAILS[index].get_Tax2());
          beTr1CreditoDet2.set_Tax3(this.oListaORDERDETAILS[index].get_Tax3());
          beTr1CreditoDet2.set_TotalVenta(this.oListaORDERDETAILS[index].get_SaleMount());
          beTr1CreditoDet2.set_Observacion(this.oListaORDERDETAILS[index].get_Observation());
          beTr1CreditoDet2.set_EsImpreso(this.oListaORDERDETAILS[index].get_IsPrinted());
          beTr1CreditoDet2.set_WaiterId(this.oListaORDERDETAILS[index].get_WaiterID());
          beTr1CreditoDet2.set_ProductoTipoId(Conversions.ToString(this.oListaORDERDETAILS[index].get_ProductTypeId()));
          beTr1CreditoDet2.set_UsuCreacion(ModGeneralVar.g_BE_USERS.get_UserId());
          beTr1CreditoDetList.Add(beTr1CreditoDet2);
          checked { ++index; }
        }
        this.obeORDER = this.o_BL_ORDERS.ObtenerPedidoxId(this.TextBox_OrderId.Text.Trim(), false);
        beTr1CreditoCab.set_LocalId(this.obeORDER.get_EstabliId());
        beTr1CreditoCab.set_CreditoId(0);
        beTr1CreditoCab.set_CreditoEstadoId(ModGeneralVar.g_BusinessCode.get_CREDITO_CREADO());
        beTr1CreditoCab.set_BoxId(this.obeORDER.get_BoxId());
        beTr1CreditoCab.set_TurnoId(this.obeORDER.get_TurnId());
        beTr1CreditoCab.set_PedidoId(this.obeORDER.get_OrderId());
        beTr1CreditoCab.set_Observacion(this.obeORDER.get_Observation());
        beTr1CreditoCab.set_ClienteId(this.obeORDER.get_ClientId());
        beTr1CreditoCab.set_ContactoId(this.obeORDER.get_ContactId());
        beTr1CreditoCab.set_TableId(this.obeORDER.get_TableId());
        beTr1CreditoCab.set_SubTableId(this.obeORDER.get_SubTableId());
        beTr1CreditoCab.set_Total(ModGeneralFunctions.CadenaToDouble(this.lblTotalPedido.Text));
        beTr1CreditoCab.set_UsuCreacion(ModGeneralVar.g_BE_USERS.get_UserId());
        string p_Mensaje = blTr1CreditoCab.CrearCredito(ref beTr1CreditoCab, beTr1CreditoDetList);
        beTr1CreditoDet1 = (BE_TR1_CREDITO_DET) null;
        if (p_Mensaje.Equals(StructApp.RESULT_OK))
        {
          ModGeneralFunctions.MessageOk("¡Crédito Emitido!");
          ModGeneralVar.g_Str_OrderID = "";
          ModGeneralVar.g_Str_SubTableDes = "";
          this.LimpiarPedido();
          FrmOrdersToPay frmOrdersToPay = new FrmOrdersToPay();
          frmOrdersToPay.str_ClienId = ModGeneralVar.g_Str_RecordID;
          frmOrdersToPay.str_ClientDes = ModGeneralFunctions.CadenaIfNothing(ModGeneralVar.g_Str_RecordDes);
          int num2 = (int) frmOrdersToPay.ShowDialog();
          frmOrdersToPay.Dispose();
        }
        else
          ModGeneralFunctions.MessageOk(p_Mensaje);
      }
    }

    private void EliminarClientePedido()
    {
      if (!this.OrderHeadValidated() || ModGeneralFunctions.CadenaToInteger(this.TextBox_ClientId.Text) == 0)
        return;
      string str = this.o_BL_ORDERS.ModifyClient(this.TextBox_OrderId.Text, "0000000000", "");
      if (str.Equals(StructApp.RESULT_OK))
      {
        this.TextBox_ClientId.Text = "0000000000";
        this.TextBox_ClientDes.Text = this.obeORDER.get_OrderFree();
        this.TextBox_ClientIdentity.Text = "";
      }
      else
        ModGeneralFunctions.MessageOk("¡Error al Eliminar Cliente del Pedido - " + str + "!");
    }

    private void btnVentaManual_Click(object sender, EventArgs e)
    {
      if (!ModGeneralFunctions.ValidInventoryClose())
      {
        ModGeneralFunctions.MessageOk("¡Se ha cerrado el Inventario, no podrá Generar Facturas!");
      }
      else
      {
        this.Button_RefreshOrder_Click((object) null, (EventArgs) null);
        if (!this.OrderHeadValidated() || !this.OrderDetailValidated() || !this.ValidIsAmountMin())
          return;
        DateTime now = DateTime.Now;
        FrmVentaManual frmVentaManual = new FrmVentaManual(this.TextBox_OrderId.Text, ModGeneralFunctions.CadenaToDouble(this.lblTotalPedido.Text));
        int num = (int) frmVentaManual.ShowDialog();
        string strTipoDocumento = frmVentaManual.strTipoDocumento;
        string strNumeroDocumento = frmVentaManual.strNumeroDocumento;
        DateTime datFechaDocumento = frmVentaManual.datFechaDocumento;
        frmVentaManual.Dispose();
        if (ModGeneralVar.g_bol_IsReady)
        {
          if (strTipoDocumento.Equals(ModGeneralVar.g_GeneralCode.get_Docu_Boleta()))
          {
            if (!ModGeneralFunctions.MessageMakeAction("¿Generar [Boleta Manual]?", false))
              return;
          }
          else
          {
            if (!strTipoDocumento.Equals(ModGeneralVar.g_GeneralCode.get_Docu_Factura()))
              return;
            if (ModGeneralFunctions.CadenaToInteger(this.TextBox_ClientId.Text) == 0)
            {
              if (!this.SaveClient())
                return;
              this.TextBox_ClientId.Text = ModGeneralVar.g_Str_RecordID;
            }
            else if (!ModGeneralFunctions.MessageMakeAction("¿Generar [Factura Manual]?", false))
              return;
          }
          BE_TR1_DOCUMENTS beTr1Documents = new BE_TR1_DOCUMENTS();
          beTr1Documents.set_EstabliId(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId());
          beTr1Documents.set_EmpresaId(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EmpresaId());
          beTr1Documents.set_BoxId(ModGeneralVar.g_BE_TR1_CFGVARIABLES.get_BoxId());
          beTr1Documents.set_TurnId(ModGeneralVar.g_BE_TR1_TURNS.get_TurnId());
          beTr1Documents.set_OrderId(this.TextBox_OrderId.Text);
          beTr1Documents.set_DocumentId(strNumeroDocumento);
          beTr1Documents.set_DocumentType(strTipoDocumento);
          beTr1Documents.set_DateSaved(datFechaDocumento);
          beTr1Documents.set_ClientId(this.TextBox_ClientId.Text.Trim());
          beTr1Documents.set_AmountDis(this.obeORDER.get_DiscountMount());
          beTr1Documents.set_DocumentState(ModGeneralVar.g_BusinessCode.get_DOCU_PAYLESS());
          beTr1Documents.set_TypeChange(ModGeneralVar.g_BE_TR1_TURNS.get_TyChanSale());
          beTr1Documents.set_UserId(ModGeneralVar.g_BE_USERS.get_UserId());
          this.o_BL_ORDERS.o_BE_TR1_VARIABLES_B = (__Null) ModGeneralVar.g_BE_TR1_VARIABLES_B;
          string str = "";
          string p_Mensaje = this.o_BL_ORDERS.CrearDocumentoManual(beTr1Documents, this.oListaORDERDETAILS, ModGeneralVar.g_BusinessCode.get_ORDER_FACTURADO(), ModGeneralVar.g_BE_ORDER_OPTIONS, ModGeneralVar.g_BusinessCode.get_TABLE_LISTA(), ModGeneralVar.g_BusinessCode.get_TABLE_OCUPADA(), ModGeneralVar.g_BE_TR1_VARIABLES_B);
          if (p_Mensaje.Equals(StructApp.RESULT_OK))
          {
            if (ModGeneralVar.g_BE_TR1_CFGVARIABLES.get_ShowPay())
            {
              if (ModGeneralFunctions.MessageMakeAction("¿Pagar Documento [" + beTr1Documents.get_DocumentId() + "]?", false) && ModGeneralFunctions.PagarxDocumento(beTr1Documents.get_DocumentCode(), false, false) && ModGeneralVar.g_BE_TR1_CFGVARIABLES.get_IsPrinterMatricial())
                str = ModGeneralFunctions.SetearReporteMatricial(beTr1Documents.get_EstabliId(), beTr1Documents.get_DocumentCode(), false, false, false);
            }
            else if (ModGeneralFunctions.PagarxDocumento(beTr1Documents.get_DocumentCode(), false, false) && ModGeneralVar.g_BE_TR1_CFGVARIABLES.get_IsPrinterMatricial())
              str = ModGeneralFunctions.SetearReporteMatricial(beTr1Documents.get_EstabliId(), beTr1Documents.get_DocumentCode(), false, false, false);
            ModGeneralVar.g_Str_OrderID = "";
            ModGeneralVar.g_Str_SubTableDes = "";
            this.LimpiarPedido();
          }
          else
            ModGeneralFunctions.MessageError_Large(p_Mensaje, true);
        }
      }
    }

    private void IncrementarCorrelativo()
    {
      FrmIncrementarCorrelativo incrementarCorrelativo = new FrmIncrementarCorrelativo();
      int num = (int) incrementarCorrelativo.ShowDialog();
      incrementarCorrelativo.Dispose();
    }

    private void OrdenCompra()
    {
      if (!this.OrderHeadValidated())
        return;
      BL_TR1_ORDERS blTr1Orders = new BL_TR1_ORDERS();
      this.obeORDER.set_OrdenCompra(Interaction.InputBox("Ingrese Nº de Orden de Compra:", ModGeneralVar.g_ApplicationName, this.obeORDER.get_OrdenCompra(), -1, -1));
      blTr1Orders.Editar_OCompra_GRemision(this.obeORDER.get_OrderId(), this.obeORDER.get_OrdenCompra(), this.obeORDER.get_GuiaRemision());
    }

    private void GuiaRemision()
    {
      if (!this.OrderHeadValidated())
        return;
      BL_TR1_ORDERS blTr1Orders = new BL_TR1_ORDERS();
      this.obeORDER.set_GuiaRemision(Interaction.InputBox("Ingrese Nº de Guia de Remision:", ModGeneralVar.g_ApplicationName, this.obeORDER.get_GuiaRemision(), -1, -1));
      blTr1Orders.Editar_OCompra_GRemision(this.obeORDER.get_OrderId(), this.obeORDER.get_OrdenCompra(), this.obeORDER.get_GuiaRemision());
    }

    private void txtBuscarxCodigo_TextChanged(object sender, EventArgs e)
    {
      this.BuscarxCodigoProducto(this.txtBuscarxCodigo.Text.Trim());
    }

    private void txtBuscarxCodigo_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!ModGeneralFunctions.Question_Made_Enter(e))
        return;
      this.BuscarxCodigoProducto(this.txtBuscarxCodigo.Text.Trim());
    }

    private void MostrarAyuda()
    {
      int num = (int) MessageBox.Show("" + "F1  - AYUDA\r\n" + "F2  - CONSULTAR STOCKS PROGRAMADOS\r\n" + "F3  - BUSCAR PRODUCTO POR CODIGO\r\n" + "F4  - DESCUENTO\r\n" + "F5  - PRE-CUENTA\r\n" + "F6  - TICKET BOLETA\r\n" + "F7  - TICKET FACTURA\r\n" + "F8  - OPCIONES DE PAGO\r\n" + "F9  - VER DOCUMENTOS INTERNOS\r\n" + "F10 - ORDEN COMPRA\r\n" + "F11 - GUIA REMISIÓN\r\n" + "F12 - INCREMENTAR CORRELATIVO DE COMPROBANTES MANUALES\r\n" + "DEL - ELIMINAR ITEM\r\n" + "M   - ABRIR GAVETA\r\n" + "ESC - SALIR", ModGeneralVar.g_ApplicationName + " - Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }

    private void meiVerCredito_Click(object sender, EventArgs e)
    {
      if (ModGeneralFunctions.CadenaToInteger(this.TextBox_ClientId.Text) == 0)
      {
        FrmSearchClient frmSearchClient = new FrmSearchClient();
        frmSearchClient._OnlyCredit = true;
        frmSearchClient._OnlySearch = false;
        int num = (int) frmSearchClient.ShowDialog();
        frmSearchClient.Dispose();
      }
      else
      {
        FrmOrdersToPay frmOrdersToPay = new FrmOrdersToPay();
        frmOrdersToPay.str_ClienId = this.TextBox_ClientId.Text.Trim();
        frmOrdersToPay.str_ClientDes = ModGeneralFunctions.CadenaIfNothing(this.TextBox_ClientDes.Text);
        int num = (int) frmOrdersToPay.ShowDialog();
        frmOrdersToPay.Dispose();
      }
    }

    private void meiVerDescuentos_Click(object sender, EventArgs e)
    {
      if ((uint) ModGeneralFunctions.CadenaToInteger(this.TextBox_ClientId.Text) <= 0U)
        return;
      this.BuscarClientexDescuento(this.TextBox_ClientId.Text);
    }

    private void meiQuitarDescuento_Click(object sender, EventArgs e)
    {
      this.AplicarDescuento(0.0, 0.0, "", 0.0);
      this.AplicarDescuentoDetalle(0.0);
      this.ObtenerPedidoxId(true);
    }

    private void meiEliminarCliente_Click(object sender, EventArgs e)
    {
      this.EliminarClientePedido();
    }

    private void meiEliminarContacto_Click(object sender, EventArgs e)
    {
      this.ActualizarContacto(ModGeneralVar.g_Str_OrderID, "");
      this.strCodigoContacto = "";
    }

    private void meiCambioProducto_Click(object sender, EventArgs e)
    {
      FrmCambioProducto frmCambioProducto = new FrmCambioProducto();
      int num = (int) frmCambioProducto.ShowDialog();
      frmCambioProducto.Dispose();
    }

    private void BuscarClientexDescuento(string pstrClientId)
    {
      ModGeneralVar.g_Str_RecordID = "";
      FrmVerCliente frmVerCliente = new FrmVerCliente(pstrClientId, this.TextBox_OrderId.Text);
      int num = (int) frmVerCliente.ShowDialog();
      frmVerCliente.Dispose();
      if (!ModGeneralVar.g_bol_IsReady || !this.OrderHeadValidated() || !(Strings.Len(ModGeneralVar.g_Str_RecordID.Length) > 0 & !ModGeneralVar.g_bol_IsClose))
        return;
      this.ModificarCliente(ModGeneralVar.g_Str_RecordID, ModGeneralVar.g_Str_RecordDes, ModGeneralVar.g_Str_RecordValue, this.obeORDER.get_OrderFree());
      if (ModGeneralFunctions.CadenaToInteger(Conversions.ToString(ModGeneralVar.g_Str_RecordQuantity)) > 0)
      {
        new BL_TR1_DESCUENTO().AplicarDsctoxPromocion(ModGeneralVar.g_Str_DescuentoId, this.TextBox_OrderId.Text.Trim(), "DSCTO. PROGRAMADO");
        this.ObtenerPedidoxId(true);
      }
    }

    private string ActualizarContacto(string pstrPedidoId, string pstrContactoId)
    {
      if (!this.OrderHeadValidated())
        return "";
      this.Cursor = Cursors.WaitCursor;
      BL_TR1_ORDERS blTr1Orders = new BL_TR1_ORDERS();
      BL_TR1_CONTACTS blTr1Contacts = new BL_TR1_CONTACTS();
      string str1;
      try
      {
        string str2 = blTr1Orders.ActualizarxContacto(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId(), pstrPedidoId, pstrContactoId);
        if (str2.Equals(StructApp.RESULT_OK))
        {
          if (!pstrContactoId.Equals(""))
          {
            BE_TR1_CONTACTS beTr1Contacts = new BE_TR1_CONTACTS();
            beTr1Contacts = blTr1Contacts.ObtenerxId(pstrContactoId);
            beTr1Contacts = (BE_TR1_CONTACTS) null;
          }
        }
        else
          ModGeneralFunctions.MessageError("¡No se Grabó el Contacto, " + str2 + "!", true);
        str1 = (string) null;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        str1 = ex.Message.ToString();
        ProjectData.ClearProjectError();
      }
      finally
      {
        str1 = (string) null;
      }
      this.Cursor = Cursors.Default;
      return str1;
    }

    private void CargarEmpresas(int pintLocalId)
    {
      BL_TR1_CONFIGURATION tr1Configuration = new BL_TR1_CONFIGURATION();
      List<BE_TR1_VARIABLES_B> beTr1VariablesBList1 = new List<BE_TR1_VARIABLES_B>();
      List<BE_TR1_VARIABLES_B> beTr1VariablesBList2 = tr1Configuration.ListarEmpresas(pintLocalId);
      if (beTr1VariablesBList2 == null || beTr1VariablesBList2.Count == 0)
        return;
      beTr1VariablesBList1 = (List<BE_TR1_VARIABLES_B>) null;
    }

    private string crearPedidoxPedido(string ptipoDocumento)
    {
      List<BE_TR1_VARIABLES_B> plista = new BL_TR1_VARIABLES_B().ListarEmpresasxPedido(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId(), this.TextBox_OrderId.Text.Trim());
      if (plista.Count == 0)
      {
        ModGeneralFunctions.MessageError("No hay razon social para facturar.", true);
        return "";
      }
      if (plista.Count > 1)
      {
        int num = checked (plista.Count - 1);
        int index = 0;
        while (index <= num)
        {
          if (plista[index].get_EmpresaId() == ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EmpresaId())
          {
            plista.RemoveAt(index);
            break;
          }
          checked { ++index; }
        }
      }
      bool flag = false;
      if (plista.Count == 1)
      {
        flag = true;
        if (plista[0].get_EmpresaId() == ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EmpresaId())
          return "";
      }
      int pempresaId;
      string str1;
      int pcajaId;
      if (flag)
      {
        pempresaId = plista[0].get_EmpresaId();
        str1 = plista[0].get_AreaIdStore();
        pcajaId = plista[0].get_BoxId();
      }
      else
      {
        ModGeneralVar.g_bol_IsReady = false;
        int num = (int) new FrmSeleccionarEmpresa(plista).ShowDialog();
        if (!ModGeneralVar.g_bol_IsReady)
          return "Seleccionar razón social.";
        pempresaId = Conversions.ToInteger(ModGeneralVar.g_Str_RecordID);
        str1 = ModGeneralVar.g_Str_RecordValue;
        pcajaId = checked ((int) Math.Round(ModGeneralVar.g_Str_RecordQuantity));
      }
      BL_TR1_TURNS blTr1Turns = new BL_TR1_TURNS();
      BE_TR1_TURNS beTr1Turns = ModGeneralVar.g_BE_TR1_TURNS;
      if (beTr1Turns == null)
      {
        BE_TR1_TURNS pentidadTURNS = new BE_TR1_TURNS();
        pentidadTURNS.set_EstabliId(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId());
        pentidadTURNS.set_EmpresaId(pempresaId);
        pentidadTURNS.set_BoxId(pcajaId);
        FrmOpenTurn frmOpenTurn = new FrmOpenTurn(pentidadTURNS);
        int num = (int) frmOpenTurn.ShowDialog();
        beTr1Turns = frmOpenTurn.devolverTurno();
        frmOpenTurn.Dispose();
      }
      string pstrAtencionId = new BL_TR1_ORDERS().crearPedidoxPedido(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId(), pempresaId, beTr1Turns.get_BoxId(), beTr1Turns.get_TurnId(), this.TextBox_OrderId.Text.Trim(), str1);
      if (pstrAtencionId.Length == 10)
      {
        string str2 = "";
        if (pstrAtencionId.Equals(this.TextBox_OrderId.Text.Trim()) & ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EmpresaId() == pempresaId)
        {
          if (!ModGeneralFunctions.PagarxAtencion(pstrAtencionId, ptipoDocumento))
            return "No se cobro el pedido";
          str2 = StructApp.RESULT_OK;
          this.LimpiarPedido();
          return StructApp.RESULT_OK;
        }
        BE_TR1_VARIABLES_B gBeTr1VariablesB = ModGeneralVar.g_BE_TR1_VARIABLES_B;
        BE_TR1_CFGVARIABLES beTr1Cfgvariables = ModGeneralVar.g_BE_TR1_CFGVARIABLES;
        BE_TR1_TURNS gBeTr1Turns = ModGeneralVar.g_BE_TR1_TURNS;
        BE_TR1_BOXES gBeTr1Boxes = ModGeneralVar.g_BE_TR1_BOXES;
        BE_TR1_VARPREBILL gBeTr1Varprebill = ModGeneralVar.g_BE_TR1_VARPREBILL;
        BE_TR1_VARDOCUMENT beTr1Vardocument = ModGeneralVar.g_BE_TR1_VARDOCUMENT;
        int num = 0;
        this.obtenerVARIABLES_B(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId(), pempresaId);
        this.obtenerCFGVALIABLES(pcajaId);
        ModGeneralVar.g_BE_TR1_TURNS = beTr1Turns;
        if (pcajaId > 0)
        {
          num = ModGeneralVar.g_BE_TR1_TURNS.get_BoxId();
          ModGeneralVar.g_BE_TR1_TURNS.set_BoxId(pcajaId);
          ModGeneralVar.g_BE_TR1_CFGVARIABLES.set_BoxId(pcajaId);
          ModGeneralVar.g_BE_TR1_CFGVARIABLES.set_BoxIdPos(pcajaId);
        }
        if (ModGeneralFunctions.PagarxAtencion(pstrAtencionId, ptipoDocumento))
        {
          str2 = StructApp.RESULT_OK;
          ModGeneralVar.g_BE_TR1_VARIABLES_B = gBeTr1VariablesB;
          ModGeneralVar.g_BE_TR1_CFGVARIABLES = beTr1Cfgvariables;
          ModGeneralVar.g_BE_TR1_TURNS = gBeTr1Turns;
          ModGeneralVar.g_BE_TR1_BOXES = gBeTr1Boxes;
          ModGeneralVar.g_BE_TR1_VARPREBILL = gBeTr1Varprebill;
          ModGeneralVar.g_BE_TR1_VARDOCUMENT = beTr1Vardocument;
          ModGeneralVar.g_BE_TR1_TURNS.set_BoxId(num);
          ModGeneralVar.g_BE_TR1_CFGVARIABLES.set_BoxId(num);
          ModGeneralVar.g_BE_TR1_CFGVARIABLES.set_BoxIdPos(num);
          this.Button_RefreshOrder_Click((object) null, (EventArgs) null);
          return StructApp.RESULT_OK;
        }
        ModGeneralVar.g_BE_TR1_VARIABLES_B = gBeTr1VariablesB;
        ModGeneralVar.g_BE_TR1_CFGVARIABLES = beTr1Cfgvariables;
        ModGeneralVar.g_BE_TR1_TURNS = gBeTr1Turns;
        ModGeneralVar.g_BE_TR1_BOXES = gBeTr1Boxes;
        ModGeneralVar.g_BE_TR1_VARPREBILL = gBeTr1Varprebill;
        ModGeneralVar.g_BE_TR1_VARDOCUMENT = beTr1Vardocument;
        ModGeneralVar.g_BE_TR1_TURNS.set_BoxId(num);
        ModGeneralVar.g_BE_TR1_CFGVARIABLES.set_BoxId(num);
        ModGeneralVar.g_BE_TR1_CFGVARIABLES.set_BoxIdPos(num);
        this.Button_RefreshOrder_Click((object) null, (EventArgs) null);
        return "No se cobro el pedido";
      }
      ModGeneralFunctions.MessageError_Large("Error - " + pstrAtencionId, true);
      return "Error - " + pstrAtencionId;
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    private void obtenerVARIABLES_B(int plocalId, int pempresaId)
    {
      BL_TR1_CONFIGURATION tr1Configuration = new BL_TR1_CONFIGURATION();
      try
      {
        ModGeneralVar.g_BE_TR1_VARIABLES_B = tr1Configuration.List_VARIABLES_B(plocalId, pempresaId);
        if (ModGeneralVar.g_BE_TR1_VARIABLES_B == null)
        {
          ModGeneralFunctions.MessageOk_Large("Error al cargar variables del sistema.", false);
          ProjectData.EndApp();
        }
        else
        {
          ModGeneralVar.g_BE_TR1_VARIABLES_B.set_BoletaTicket(ModGeneralVar.get_Docu_BoletaOrTicket());
          if (ModGeneralVar.g_BE_TR1_VARIABLES_B.get_WithStore())
            ModGeneralVar.g_TR2BusinessCode = new BL_TR2_CONFIGURATION().List_BusinessCode();
          if (ModGeneralVar.g_TR2BusinessCode == null)
            ModGeneralVar.g_TR2BusinessCode = new BE_TR2_BusinessCode();
          ModGeneralVar.g_BE_TR1_REPORTS = new BE_TR1_REPORTS();
          ModGeneralVar.g_BE_ORDER_OPTIONS = new BE_ORDER_OPTIONS();
          ModGeneralVar.g_BE_TR1_REPORTS.set_ApplicationDes(Application.ProductName);
          ModGeneralVar.g_BE_TR1_REPORTS.set_ClientDes(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_SocialReason());
          ModGeneralVar.g_BE_TR1_REPORTS.set_CompanyDes(Application.CompanyName);
          ModGeneralVar.g_BE_ORDER_OPTIONS.set_WithStore(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_WithStore());
          ModGeneralVar.g_BE_ORDER_OPTIONS.set_DownloadOnline(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_Unload_ProductDirect());
          ModGeneralVar.g_BE_ORDER_OPTIONS.set_ProcesosAutomaticos(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_ProcesosAutomaticos());
          ModGeneralVar.g_BE_ORDER_OPTIONS.set_Move_StateIdP(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_Move_StateIdP());
          ModGeneralVar.g_BE_ORDER_OPTIONS.set_Move_StateIdC(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_Move_StateIdC());
          ModGeneralVar.g_BE_ORDER_OPTIONS.set_Store_DocuTId(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_Store_DocuTId());
          if (ModGeneralVar.g_BE_TR2_PRODUCTS == null)
            ModGeneralVar.g_BE_TR2_PRODUCTS = new BE_TR2_PRODUCTS();
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ModGeneralFunctions.MessageOk_Large("obtenerVARIABLES_B-" + ex.Message, false);
        ProjectData.EndApp();
        ProjectData.ClearProjectError();
      }
      finally
      {
      }
    }

    private void obtenerCFGVALIABLES(int pcajaId)
    {
      BL_TR1_CONFIGURATION tr1Configuration = new BL_TR1_CONFIGURATION();
      string str = "";
      ModGeneralVar.g_BE_TR1_CFGVARIABLES = new BE_TR1_CFGVARIABLES();
      int boxId = ModGeneralVar.g_BE_TR1_BOXES.get_BoxId();
      int empresaId = ModGeneralVar.g_BE_TR1_BOXES.get_EmpresaId();
      ModGeneralVar.g_BE_TR1_BOXES = new BE_TR1_BOXES();
      ModGeneralVar.g_BE_TR1_BOXES.set_EstabliId(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId());
      ModGeneralVar.g_BE_TR1_BOXES.set_EmpresaId(empresaId);
      if ((!ModGeneralFunctions.ObtenerAPPCONFIG("CLIENTE").Equals((object) "MENFLO") ? tr1Configuration.ValidateBoxID(Conversions.ToString(pcajaId), ref ModGeneralVar.g_BE_TR1_BOXES) : tr1Configuration.ValidateBoxID(Conversions.ToString(boxId), ref ModGeneralVar.g_BE_TR1_BOXES)).Equals(StructApp.RESULT_OK) || !ModGeneralFunctions.MessageMakeAction("¡Caja No Registrada en BD!\r\n¿Desea Registrar la Caja?", false))
        ;
      ModGeneralVar.g_BE_TR1_CFGVARIABLES.set_EstabliId(ModGeneralVar.g_BE_TR1_BOXES.get_EstabliId());
      ModGeneralVar.g_BE_TR1_CFGVARIABLES.set_EmpresaId(ModGeneralVar.g_BE_TR1_BOXES.get_EmpresaId());
      ModGeneralVar.g_BE_TR1_CFGVARIABLES.set_BoxId(ModGeneralVar.g_BE_TR1_BOXES.get_BoxId());
      ModGeneralVar.g_BE_TR1_CFGVARIABLES.set_BoxIdPos(ModGeneralVar.g_BE_TR1_BOXES.get_BoxIdPos());
      if ((double) ModGeneralVar.g_BE_TR1_CFGVARIABLES.get_BoxId() == Conversions.ToDouble("0"))
        this.Close();
      tr1Configuration.List(ref ModGeneralVar.g_BE_TR1_CFGVARIABLES);
      ModGeneralVar.g_BE_TR1_CFGVARIABLES.set_IsTakeOrder(ModGeneralVar.g_BE_TR1_BOXES.get_IsTakeOrder());
      ModGeneralVar.g_BE_TR1_CFGVARIABLES.set_PrinterPrecountId(tr1Configuration.ObtenerImpPrecuenta(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId(), ModGeneralVar.g_BE_TR1_BOXES.get_BoxId()));
      ModGeneralVar.g_CantProgramAlert = Conversions.ToInteger(ModGeneralVar.g_BE_TR1_CFGVARIABLES.get_CantAlertProgram());
      ModGeneralVar.g_IsTakeOrder = ModGeneralVar.g_BE_TR1_CFGVARIABLES.get_IsTakeOrder();
      ModGeneralVar.g_BE_TR1_CFGVARIABLES.set_TurnDelivery(Conversions.ToString(ModGeneralFunctions.ObtenerAPPCONFIG("STR_TURN_DELIVERY")));
      ModGeneralVar.g_BE_TR1_CFGVARIABLES.set_CantidadNumDecimales(Conversions.ToInteger(ModGeneralFunctions.ObtenerAPPCONFIG("CantidadNumDecimales")));
      ModGeneralVar.g_BE_TR1_CFGVARIABLES.set_ComprobanteAgrupado(Conversions.ToBoolean(ModGeneralFunctions.ObtenerAPPCONFIG("COMPROBANTE_AGRUPADO")));
      ModGeneralVar.g_BE_TR1_CFGVARIABLES.set_Texto_Propina(Conversions.ToString(ModGeneralFunctions.ObtenerAPPCONFIG("TEXTO_PROPINA")));
      ModGeneralVar.g_BE_TR1_CFGVARIABLES.set_Texto_MesaArriba(Conversions.ToBoolean(ModGeneralFunctions.ObtenerAPPCONFIG("TEXTO_MESAARRIBA")));
      ModGeneralVar.g_bol_HideDocumentIntern = Conversions.ToBoolean(ModGeneralFunctions.ObtenerAPPCONFIG("HideDocumentIntern"));
      this.setearCFGVARIABLES(ref ModGeneralVar.g_BE_TR1_CFGVARIABLES);
      tr1Configuration.RegistrarVersion(ModGeneralVar.g_ApplicationName, MyProject.Application.Info.Version.ToString());
      str = (string) null;
    }

    private void setearCFGVARIABLES(ref BE_TR1_CFGVARIABLES pbeCFGVARIABLES)
    {
      BL_TR1_CONFIGURATION tr1Configuration = new BL_TR1_CONFIGURATION();
      BE_TR1_CFGVARIABLES beTr1Cfgvariables = new BE_TR1_CFGVARIABLES();
      string str = "";
      try
      {
        beTr1Cfgvariables.set_EstabliId(ModGeneralVar.g_BE_TR1_BOXES.get_EstabliId());
        beTr1Cfgvariables.set_EmpresaId(ModGeneralVar.g_BE_TR1_BOXES.get_EmpresaId());
        beTr1Cfgvariables.set_BoxId(ModGeneralVar.g_BE_TR1_BOXES.get_BoxId());
        beTr1Cfgvariables.set_BoxIdPos(ModGeneralVar.g_BE_TR1_BOXES.get_BoxId());
        if (!tr1Configuration.List(ref beTr1Cfgvariables).Equals(StructApp.RESULT_OK))
          return;
        pbeCFGVARIABLES.set_EsMonitor(beTr1Cfgvariables.get_EsMonitor());
        pbeCFGVARIABLES.set_TiempoAlertaMonitor(beTr1Cfgvariables.get_TiempoAlertaMonitor());
        pbeCFGVARIABLES.set_TiempoEsperaMonitor(beTr1Cfgvariables.get_TiempoEsperaMonitor());
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ModGeneralFunctions.MessageOk(ex.Message);
        ProjectData.ClearProjectError();
      }
      finally
      {
        str = (string) null;
      }
    }

    private void obtenerVARIABLESPRECUENTA()
    {
      BE_TR1_VARPREBILL beTr1Varprebill = new BE_TR1_VARPREBILL();
      BL_TR1_CONFIGURATION tr1Configuration = new BL_TR1_CONFIGURATION();
      beTr1Varprebill.set_EstabliId(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId());
      beTr1Varprebill.set_BoxId(ModGeneralVar.g_BE_TR1_CFGVARIABLES.get_BoxIdPos());
      try
      {
        ModGeneralVar.g_BE_TR1_VARPREBILL = tr1Configuration.Get_CfgPreBill(beTr1Varprebill);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ModGeneralFunctions.MessageOk_Large("obtenerVariablesPrecuenta-" + ex.Message, false);
        ProjectData.ClearProjectError();
      }
      finally
      {
      }
    }

    private void obtenerVARIABLESCOMPROBANTE()
    {
      BE_TR1_VARDOCUMENT beTr1Vardocument = new BE_TR1_VARDOCUMENT();
      BL_TR1_CONFIGURATION tr1Configuration = new BL_TR1_CONFIGURATION();
      beTr1Vardocument.set_EstabliId(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId());
      beTr1Vardocument.set_BoxId(ModGeneralVar.g_BE_TR1_CFGVARIABLES.get_BoxIdPos());
      try
      {
        ModGeneralVar.g_BE_TR1_VARDOCUMENT = tr1Configuration.Get_CfgDocument(beTr1Vardocument);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ModGeneralFunctions.MessageOk_Large("obtenerVariablesComprobante-" + ex.Message, false);
        ProjectData.ClearProjectError();
      }
      finally
      {
      }
    }

    private void btnPromo_Click(object sender, EventArgs e)
    {
      if (!this.OrderDetailValidated())
        return;
      FrmPromoNxN frmPromoNxN = new FrmPromoNxN(this.TextBox_OrderId.Text, (List<BE_TR1_ORDERDETAILS>) this.dgrvOrderDetails.DataSource);
      int num = (int) frmPromoNxN.ShowDialog();
      string str = frmPromoNxN.devolverResultado();
      frmPromoNxN.Dispose();
      if (str.Equals(StructApp.RESULT_OK))
        this.Button_RefreshOrder_Click((object) null, (EventArgs) null);
    }
  }
}
