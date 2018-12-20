// Decompiled with JetBrains decompiler
// Type: TriNetRestPOS.FrmCfgCaja
// Assembly: TriNetRestPOS, Version=5.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 43377352-E952-4AC1-9BA6-CCBE4AE5F575
// Assembly location: C:\log\TriNetRestPOS.exe

using KIS.Controls;
using KIS.Controls.Windows;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MyXPButtonTables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using TR1_BusinessEntity;
using TR1_BusinessLogic;

namespace TriNetRestPOS
{
  [DesignerGenerated]
  public class FrmCfgCaja : Form
  {
    private IContainer components;
    private BE_TR1_CFGVARIABLES o_BE_TR1_CFGVARIABLES;
    private BE_TR1_BOXES o_BE_TR1_BOXES;
    private BL_TR1_CONFIGURATION o_CL_CFGVARIABLES;
    private string str_Result;
    private bool _Isload;
    public bool _IsAdvanced;
    public string _MachineId;
    public int _BoxId;

    public FrmCfgCaja()
    {
      this.Load += new EventHandler(this.FrmCfgSystem_Load);
      this.KeyDown += new KeyEventHandler(this.FrmCfgSystem_KeyDown);
      this._Isload = true;
      this._IsAdvanced = false;
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FrmCfgCaja));
      this.HeaderPanel_Variables = new HeaderPanel();
      this.btnDeliveryEnLinea = new MyXPButtonTables.MyXPButtonTables();
      this.Label33 = new Label();
      this.cboTiposPedido = new ComboBox();
      this.Label35 = new Label();
      this.lblSegundosEsperaDelivery = new Label();
      this.btnEliminarSerieBoleta = new Button();
      this.btnEliminarSerieFactura = new Button();
      this.btnTiempoEsperaDelivery = new Button();
      this.dgvNumeroSerieBoleta = new DataGridView();
      this.dgvNumeroSerieFactura = new DataGridView();
      this.txtTiempoEsperaDelivery = new TextBox();
      this.Button_CfgDocument = new Button();
      this.tbcVariables = new TabControl();
      this.tpgPrincipal = new TabPage();
      this.CheckBox_IsNotAmountMin = new CheckBox();
      this.CheckBox_IsAmountMin = new CheckBox();
      this.chbNoSeleccionarMesaxDiseno = new CheckBox();
      this.chbSeleccionarMesaxDiseno = new CheckBox();
      this.Label34 = new Label();
      this.chbNoMozoObservaPrecios = new CheckBox();
      this.chbMozoObservaPrecios = new CheckBox();
      this.Label32 = new Label();
      this.chbNoEsPedidoLibreRapido = new CheckBox();
      this.chbEsPedidoLibreRapido = new CheckBox();
      this.Label26 = new Label();
      this.Label24 = new Label();
      this.RadioButton_Yes = new RadioButton();
      this.ComboBox_CantPrintCommand = new ComboBox();
      this.CheckBox_ShowGroupNot = new CheckBox();
      this.CheckBox_IsNotWaiterShowSale = new CheckBox();
      this.CheckBox_IsPeoppleNot = new CheckBox();
      this.CheckBox_IsWaiterShowSale = new CheckBox();
      this.Label_ShowGroup = new Label();
      this.Label21 = new Label();
      this.CheckBox_ShowGroup = new CheckBox();
      this.CheckBox_IsNotDobleCommand = new CheckBox();
      this.CheckBox_ShowPay = new CheckBox();
      this.CheckBox_IsDobleCommand = new CheckBox();
      this.CheckBox_IsPeople = new CheckBox();
      this.Label2 = new Label();
      this.Button_AmountMin = new Button();
      this.Label_ShowPay = new Label();
      this.TextBox_AmountMin = new TextBox();
      this.CheckBox_IsNotFirstPay = new CheckBox();
      this.Label20 = new Label();
      this.Label_IsPeople = new Label();
      this.CheckBox_IsFirstPay = new CheckBox();
      this.CheckBox_ShowNotPay = new CheckBox();
      this.Label16 = new Label();
      this.Label3 = new Label();
      this.CheckBox_IsNotPrintDeleteItem = new CheckBox();
      this.CheckBox_NotBoxWaiter = new CheckBox();
      this.RadioButton_Not = new RadioButton();
      this.CheckBox_BoxWaiter = new CheckBox();
      this.CheckBox_IsPrintDeleteItem = new CheckBox();
      this.Label6 = new Label();
      this.CheckBox_NotMatricial = new CheckBox();
      this.Label19 = new Label();
      this.CheckBox_Matricial = new CheckBox();
      this.Label18 = new Label();
      this.CheckBoxShowConsume = new CheckBox();
      this.CheckBox_NotBarCode = new CheckBox();
      this.Label7 = new Label();
      this.CheckBox_IsBarCode = new CheckBox();
      this.CheckBoxShowNotConsume = new CheckBox();
      this.Label14 = new Label();
      this.Label8 = new Label();
      this.CheckBox_NotShowCommand = new CheckBox();
      this.CheckBox_ShowCommand = new CheckBox();
      this.tpgConfirmacion = new TabPage();
      this.chbNoConfirmarComanda = new CheckBox();
      this.Label25 = new Label();
      this.chbConfirmarComanda = new CheckBox();
      this.chbConfirmarDivCuentas = new CheckBox();
      this.Label27 = new Label();
      this.chbNoConfirmarDocumento = new CheckBox();
      this.chbConfirmarDocumento = new CheckBox();
      this.chbNoConfirmarDivCuentas = new CheckBox();
      this.Label28 = new Label();
      this.chbConfirmarTransfMesas = new CheckBox();
      this.chbNoConfirmarPago = new CheckBox();
      this.Label29 = new Label();
      this.chbConfirmarPago = new CheckBox();
      this.chbNoConfirmarTransfMesas = new CheckBox();
      this.Label30 = new Label();
      this.Label31 = new Label();
      this.chbNoConfirmarPedido = new CheckBox();
      this.chbConfirmarPedido = new CheckBox();
      this.tpgSeguridad = new TabPage();
      this.Label43 = new Label();
      this.CheckBox_ImprimirPrecuenta = new CheckBox();
      this.CheckBox_NoImprimirPrecuenta = new CheckBox();
      this.CheckBox_DeleteOrder = new CheckBox();
      this.CheckBox_DeleteItem = new CheckBox();
      this.CheckBox_NotDeleteOrder = new CheckBox();
      this.Label9 = new Label();
      this.Label17 = new Label();
      this.CheckBox_NotDeleteItem = new CheckBox();
      this.CheckBox_DocuIntern = new CheckBox();
      this.Label10 = new Label();
      this.CheckBox_NotDocuIntern = new CheckBox();
      this.CheckBox_NotDeleteDocument = new CheckBox();
      this.Label15 = new Label();
      this.CheckBox_DeleteDocument = new CheckBox();
      this.CheckBox_ChangePrice = new CheckBox();
      this.Label11 = new Label();
      this.CheckBox_NotChangePrice = new CheckBox();
      this.tpgMensajes = new TabPage();
      this.Label37 = new Label();
      this.CheckBox_MensajeTNS_True = new CheckBox();
      this.CheckBox_MensajeTNS_False = new CheckBox();
      this.TextBox_MensajePrecuenta = new TextBox();
      this.Label36 = new Label();
      this.tpgMonitor = new TabPage();
      this.Label39 = new Label();
      this.txtTiempoAlertaMonitor = new NumericTextBox.NumericTextBox();
      this.Label40 = new Label();
      this.Label42 = new Label();
      this.Label47 = new Label();
      this.txtTiempoEsperaMonitor = new NumericTextBox.NumericTextBox();
      this.Label44 = new Label();
      this.Label41 = new Label();
      this.chbEsMonitorNo = new CheckBox();
      this.chbEsMonitor = new CheckBox();
      this.Label38 = new Label();
      this.lblTiempoEsperaDelivery = new Label();
      this.TextBox_PrinterTicketId = new TextBox();
      this.Button_CantLineComFooter = new Button();
      this.Button_CfgPreBill = new Button();
      this.TextBox_PrinterInvoiceId = new TextBox();
      this.Button_GoOut = new Button();
      this.TextBox_CantLineComFooter = new TextBox();
      this.Button_Save = new Button();
      this.Label23 = new Label();
      this.TextBox_PrinterPrecountId = new TextBox();
      this.Button_CantLineComHeader = new Button();
      this.TextBox_CantLineComHeader = new TextBox();
      this.Label22 = new Label();
      this.Label13 = new Label();
      this.TextBox_ForTicket = new TextBox();
      this.Button_PrinterForTicket = new Button();
      this.btnAgregarSerieBoleta = new Button();
      this.Label12 = new Label();
      this.Label5 = new Label();
      this.Button_Quantity = new Button();
      this.TextBox_QuantitytAlert = new TextBox();
      this.Label4 = new Label();
      this.btnAgregarSerieFactura = new Button();
      this.Label_SocialReason = new Label();
      this.Label_CommercialReason = new Label();
      this.Label1 = new Label();
      this.TextBox_ForDocument = new TextBox();
      this.Button_TimeW = new Button();
      this.TextBox_Printer = new TextBox();
      this.TextBox_Minutes = new TextBox();
      this.Button_SearchPrinters = new Button();
      this.Label_TimeW = new Label();
      this.Button_PrinterForDocu = new Button();
      ((Control) this.HeaderPanel_Variables).SuspendLayout();
      ((ISupportInitialize) this.dgvNumeroSerieBoleta).BeginInit();
      ((ISupportInitialize) this.dgvNumeroSerieFactura).BeginInit();
      this.tbcVariables.SuspendLayout();
      this.tpgPrincipal.SuspendLayout();
      this.tpgConfirmacion.SuspendLayout();
      this.tpgSeguridad.SuspendLayout();
      this.tpgMensajes.SuspendLayout();
      this.tpgMonitor.SuspendLayout();
      this.SuspendLayout();
      this.HeaderPanel_Variables.set_BorderColor(SystemColors.ActiveCaption);
      this.HeaderPanel_Variables.set_BorderStyle((BorderStyles) 1);
      this.HeaderPanel_Variables.set_CaptionBeginColor(Color.FromArgb(209, 102, 61));
      this.HeaderPanel_Variables.set_CaptionEndColor(Color.FromArgb(209, 102, 61));
      this.HeaderPanel_Variables.set_CaptionGradientDirection(LinearGradientMode.Vertical);
      this.HeaderPanel_Variables.set_CaptionHeight(26);
      this.HeaderPanel_Variables.set_CaptionPosition((CaptionPositions) 0);
      this.HeaderPanel_Variables.set_CaptionText("Variables de Caja");
      this.HeaderPanel_Variables.set_CaptionVisible(true);
      ((Control) this.HeaderPanel_Variables).Controls.Add((Control) this.btnDeliveryEnLinea);
      ((Control) this.HeaderPanel_Variables).Controls.Add((Control) this.Label33);
      ((Control) this.HeaderPanel_Variables).Controls.Add((Control) this.cboTiposPedido);
      ((Control) this.HeaderPanel_Variables).Controls.Add((Control) this.Label35);
      ((Control) this.HeaderPanel_Variables).Controls.Add((Control) this.lblSegundosEsperaDelivery);
      ((Control) this.HeaderPanel_Variables).Controls.Add((Control) this.btnEliminarSerieBoleta);
      ((Control) this.HeaderPanel_Variables).Controls.Add((Control) this.btnEliminarSerieFactura);
      ((Control) this.HeaderPanel_Variables).Controls.Add((Control) this.btnTiempoEsperaDelivery);
      ((Control) this.HeaderPanel_Variables).Controls.Add((Control) this.dgvNumeroSerieBoleta);
      ((Control) this.HeaderPanel_Variables).Controls.Add((Control) this.dgvNumeroSerieFactura);
      ((Control) this.HeaderPanel_Variables).Controls.Add((Control) this.txtTiempoEsperaDelivery);
      ((Control) this.HeaderPanel_Variables).Controls.Add((Control) this.Button_CfgDocument);
      ((Control) this.HeaderPanel_Variables).Controls.Add((Control) this.tbcVariables);
      ((Control) this.HeaderPanel_Variables).Controls.Add((Control) this.lblTiempoEsperaDelivery);
      ((Control) this.HeaderPanel_Variables).Controls.Add((Control) this.TextBox_PrinterTicketId);
      ((Control) this.HeaderPanel_Variables).Controls.Add((Control) this.Button_CantLineComFooter);
      ((Control) this.HeaderPanel_Variables).Controls.Add((Control) this.Button_CfgPreBill);
      ((Control) this.HeaderPanel_Variables).Controls.Add((Control) this.TextBox_PrinterInvoiceId);
      ((Control) this.HeaderPanel_Variables).Controls.Add((Control) this.Button_GoOut);
      ((Control) this.HeaderPanel_Variables).Controls.Add((Control) this.TextBox_CantLineComFooter);
      ((Control) this.HeaderPanel_Variables).Controls.Add((Control) this.Button_Save);
      ((Control) this.HeaderPanel_Variables).Controls.Add((Control) this.Label23);
      ((Control) this.HeaderPanel_Variables).Controls.Add((Control) this.TextBox_PrinterPrecountId);
      ((Control) this.HeaderPanel_Variables).Controls.Add((Control) this.Button_CantLineComHeader);
      ((Control) this.HeaderPanel_Variables).Controls.Add((Control) this.TextBox_CantLineComHeader);
      ((Control) this.HeaderPanel_Variables).Controls.Add((Control) this.Label22);
      ((Control) this.HeaderPanel_Variables).Controls.Add((Control) this.Label13);
      ((Control) this.HeaderPanel_Variables).Controls.Add((Control) this.TextBox_ForTicket);
      ((Control) this.HeaderPanel_Variables).Controls.Add((Control) this.Button_PrinterForTicket);
      ((Control) this.HeaderPanel_Variables).Controls.Add((Control) this.btnAgregarSerieBoleta);
      ((Control) this.HeaderPanel_Variables).Controls.Add((Control) this.Label12);
      ((Control) this.HeaderPanel_Variables).Controls.Add((Control) this.Label5);
      ((Control) this.HeaderPanel_Variables).Controls.Add((Control) this.Button_Quantity);
      ((Control) this.HeaderPanel_Variables).Controls.Add((Control) this.TextBox_QuantitytAlert);
      ((Control) this.HeaderPanel_Variables).Controls.Add((Control) this.Label4);
      ((Control) this.HeaderPanel_Variables).Controls.Add((Control) this.btnAgregarSerieFactura);
      ((Control) this.HeaderPanel_Variables).Controls.Add((Control) this.Label_SocialReason);
      ((Control) this.HeaderPanel_Variables).Controls.Add((Control) this.Label_CommercialReason);
      ((Control) this.HeaderPanel_Variables).Controls.Add((Control) this.Label1);
      ((Control) this.HeaderPanel_Variables).Controls.Add((Control) this.TextBox_ForDocument);
      ((Control) this.HeaderPanel_Variables).Controls.Add((Control) this.Button_TimeW);
      ((Control) this.HeaderPanel_Variables).Controls.Add((Control) this.TextBox_Printer);
      ((Control) this.HeaderPanel_Variables).Controls.Add((Control) this.TextBox_Minutes);
      ((Control) this.HeaderPanel_Variables).Controls.Add((Control) this.Button_SearchPrinters);
      ((Control) this.HeaderPanel_Variables).Controls.Add((Control) this.Label_TimeW);
      ((Control) this.HeaderPanel_Variables).Controls.Add((Control) this.Button_PrinterForDocu);
      this.HeaderPanel_Variables.set_Font(new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0));
      ((Control) this.HeaderPanel_Variables).ForeColor = Color.WhiteSmoke;
      this.HeaderPanel_Variables.set_GradientDirection(LinearGradientMode.Vertical);
      this.HeaderPanel_Variables.set_GradientEnd(SystemColors.Window);
      this.HeaderPanel_Variables.set_GradientStart(SystemColors.Window);
      ((Control) this.HeaderPanel_Variables).Location = new Point(-1, 0);
      ((Control) this.HeaderPanel_Variables).Name = "HeaderPanel_Variables";
      this.HeaderPanel_Variables.set_PanelIcon((Icon) null);
      this.HeaderPanel_Variables.set_PanelIconVisible(false);
      ((Control) this.HeaderPanel_Variables).Size = new Size(1011, 748);
      ((Control) this.HeaderPanel_Variables).TabIndex = 188;
      this.HeaderPanel_Variables.set_TextAntialias(true);
      this.btnDeliveryEnLinea.set_AdjustImageLocation(new Point(0, 0));
      this.btnDeliveryEnLinea.set_BtnShape((emunType.BtnShape) 1);
      this.btnDeliveryEnLinea.set_BtnStyle((emunType.XPStyle) 2);
      ((Control) this.btnDeliveryEnLinea).Location = new Point(406, 640);
      ((Control) this.btnDeliveryEnLinea).Name = "btnDeliveryEnLinea";
      ((Control) this.btnDeliveryEnLinea).Size = new Size(25, 25);
      ((Control) this.btnDeliveryEnLinea).TabIndex = 503;
      ((ButtonBase) this.btnDeliveryEnLinea).UseVisualStyleBackColor = true;
      this.Label33.AutoSize = true;
      this.Label33.BackColor = Color.Transparent;
      this.Label33.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label33.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label33.Location = new Point(351, 617);
      this.Label33.Name = "Label33";
      this.Label33.Size = new Size(112, 16);
      this.Label33.TabIndex = 502;
      this.Label33.Text = "Delivery en Linea";
      this.cboTiposPedido.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cboTiposPedido.FormattingEnabled = true;
      this.cboTiposPedido.Location = new Point(355, 584);
      this.cboTiposPedido.Name = "cboTiposPedido";
      this.cboTiposPedido.Size = new Size(301, 24);
      this.cboTiposPedido.TabIndex = 490;
      this.Label35.AutoSize = true;
      this.Label35.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label35.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label35.Location = new Point(351, 564);
      this.Label35.Name = "Label35";
      this.Label35.Size = new Size(154, 16);
      this.Label35.TabIndex = 489;
      this.Label35.Text = "Opción libre por defecto:";
      this.lblSegundosEsperaDelivery.AutoSize = true;
      this.lblSegundosEsperaDelivery.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblSegundosEsperaDelivery.ForeColor = Color.FromArgb(209, 102, 61);
      this.lblSegundosEsperaDelivery.Location = new Point(778, 589);
      this.lblSegundosEsperaDelivery.Name = "lblSegundosEsperaDelivery";
      this.lblSegundosEsperaDelivery.Size = new Size(70, 16);
      this.lblSegundosEsperaDelivery.TabIndex = 488;
      this.lblSegundosEsperaDelivery.Text = "Segundos";
      this.btnEliminarSerieBoleta.BackgroundImage = (Image) componentResourceManager.GetObject("btnEliminarSerieBoleta.BackgroundImage");
      this.btnEliminarSerieBoleta.FlatStyle = FlatStyle.Flat;
      this.btnEliminarSerieBoleta.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnEliminarSerieBoleta.ForeColor = Color.WhiteSmoke;
      this.btnEliminarSerieBoleta.Image = (Image) componentResourceManager.GetObject("btnEliminarSerieBoleta.Image");
      this.btnEliminarSerieBoleta.Location = new Point(269, 390);
      this.btnEliminarSerieBoleta.Name = "btnEliminarSerieBoleta";
      this.btnEliminarSerieBoleta.Size = new Size(72, 65);
      this.btnEliminarSerieBoleta.TabIndex = 484;
      this.btnEliminarSerieBoleta.Text = "Elimina";
      this.btnEliminarSerieBoleta.TextAlign = ContentAlignment.BottomCenter;
      this.btnEliminarSerieBoleta.UseVisualStyleBackColor = true;
      this.btnEliminarSerieFactura.BackgroundImage = (Image) componentResourceManager.GetObject("btnEliminarSerieFactura.BackgroundImage");
      this.btnEliminarSerieFactura.FlatStyle = FlatStyle.Flat;
      this.btnEliminarSerieFactura.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnEliminarSerieFactura.ForeColor = Color.WhiteSmoke;
      this.btnEliminarSerieFactura.Image = (Image) componentResourceManager.GetObject("btnEliminarSerieFactura.Image");
      this.btnEliminarSerieFactura.Location = new Point(269, 250);
      this.btnEliminarSerieFactura.Name = "btnEliminarSerieFactura";
      this.btnEliminarSerieFactura.Size = new Size(72, 65);
      this.btnEliminarSerieFactura.TabIndex = 483;
      this.btnEliminarSerieFactura.Text = "Elimina";
      this.btnEliminarSerieFactura.TextAlign = ContentAlignment.BottomCenter;
      this.btnEliminarSerieFactura.UseVisualStyleBackColor = true;
      this.btnTiempoEsperaDelivery.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.teclado_nueral;
      this.btnTiempoEsperaDelivery.FlatStyle = FlatStyle.Flat;
      this.btnTiempoEsperaDelivery.Font = new Font("Trebuchet MS", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnTiempoEsperaDelivery.ForeColor = Color.WhiteSmoke;
      this.btnTiempoEsperaDelivery.Location = new Point(925, 555);
      this.btnTiempoEsperaDelivery.Name = "btnTiempoEsperaDelivery";
      this.btnTiempoEsperaDelivery.RightToLeft = RightToLeft.Yes;
      this.btnTiempoEsperaDelivery.Size = new Size(62, 52);
      this.btnTiempoEsperaDelivery.TabIndex = 487;
      this.btnTiempoEsperaDelivery.TextAlign = ContentAlignment.TopCenter;
      this.btnTiempoEsperaDelivery.TextImageRelation = TextImageRelation.TextAboveImage;
      this.btnTiempoEsperaDelivery.UseVisualStyleBackColor = true;
      this.dgvNumeroSerieBoleta.BorderStyle = BorderStyle.Fixed3D;
      this.dgvNumeroSerieBoleta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvNumeroSerieBoleta.Location = new Point(10, 342);
      this.dgvNumeroSerieBoleta.MultiSelect = false;
      this.dgvNumeroSerieBoleta.Name = "dgvNumeroSerieBoleta";
      this.dgvNumeroSerieBoleta.ScrollBars = ScrollBars.None;
      this.dgvNumeroSerieBoleta.Size = new Size((int) byte.MaxValue, 113);
      this.dgvNumeroSerieBoleta.TabIndex = 482;
      this.dgvNumeroSerieFactura.BorderStyle = BorderStyle.Fixed3D;
      this.dgvNumeroSerieFactura.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvNumeroSerieFactura.Location = new Point(10, 202);
      this.dgvNumeroSerieFactura.MultiSelect = false;
      this.dgvNumeroSerieFactura.Name = "dgvNumeroSerieFactura";
      this.dgvNumeroSerieFactura.ScrollBars = ScrollBars.None;
      this.dgvNumeroSerieFactura.Size = new Size((int) byte.MaxValue, 113);
      this.dgvNumeroSerieFactura.TabIndex = 481;
      this.txtTiempoEsperaDelivery.AcceptsTab = true;
      this.txtTiempoEsperaDelivery.BackColor = Color.White;
      this.txtTiempoEsperaDelivery.BorderStyle = BorderStyle.FixedSingle;
      this.txtTiempoEsperaDelivery.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtTiempoEsperaDelivery.ForeColor = Color.FromArgb(150, 150, 150);
      this.txtTiempoEsperaDelivery.Location = new Point(666, 586);
      this.txtTiempoEsperaDelivery.MaxLength = 10;
      this.txtTiempoEsperaDelivery.Multiline = true;
      this.txtTiempoEsperaDelivery.Name = "txtTiempoEsperaDelivery";
      this.txtTiempoEsperaDelivery.Size = new Size(97, 20);
      this.txtTiempoEsperaDelivery.TabIndex = 486;
      this.txtTiempoEsperaDelivery.TextAlign = HorizontalAlignment.Center;
      this.Button_CfgDocument.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.conf_boton;
      this.Button_CfgDocument.FlatStyle = FlatStyle.Flat;
      this.Button_CfgDocument.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button_CfgDocument.ForeColor = Color.WhiteSmoke;
      this.Button_CfgDocument.Image = (Image) TriNetRestPOS.My.Resources.Resources.diseñar_icon;
      this.Button_CfgDocument.ImageAlign = ContentAlignment.TopCenter;
      this.Button_CfgDocument.Location = new Point(624, 617);
      this.Button_CfgDocument.Name = "Button_CfgDocument";
      this.Button_CfgDocument.Padding = new Padding(0, 5, 0, 5);
      this.Button_CfgDocument.Size = new Size(102, 66);
      this.Button_CfgDocument.TabIndex = 440;
      this.Button_CfgDocument.Text = "Conf. Docum";
      this.Button_CfgDocument.TextAlign = ContentAlignment.BottomCenter;
      this.Button_CfgDocument.UseVisualStyleBackColor = true;
      this.tbcVariables.Controls.Add((Control) this.tpgPrincipal);
      this.tbcVariables.Controls.Add((Control) this.tpgConfirmacion);
      this.tbcVariables.Controls.Add((Control) this.tpgSeguridad);
      this.tbcVariables.Controls.Add((Control) this.tpgMensajes);
      this.tbcVariables.Controls.Add((Control) this.tpgMonitor);
      this.tbcVariables.Location = new Point(345, 2);
      this.tbcVariables.Name = "tbcVariables";
      this.tbcVariables.SelectedIndex = 0;
      this.tbcVariables.Size = new Size(665, 545);
      this.tbcVariables.TabIndex = 480;
      this.tpgPrincipal.BackColor = Color.White;
      this.tpgPrincipal.Controls.Add((Control) this.CheckBox_IsNotAmountMin);
      this.tpgPrincipal.Controls.Add((Control) this.CheckBox_IsAmountMin);
      this.tpgPrincipal.Controls.Add((Control) this.chbNoSeleccionarMesaxDiseno);
      this.tpgPrincipal.Controls.Add((Control) this.chbSeleccionarMesaxDiseno);
      this.tpgPrincipal.Controls.Add((Control) this.Label34);
      this.tpgPrincipal.Controls.Add((Control) this.chbNoMozoObservaPrecios);
      this.tpgPrincipal.Controls.Add((Control) this.chbMozoObservaPrecios);
      this.tpgPrincipal.Controls.Add((Control) this.Label32);
      this.tpgPrincipal.Controls.Add((Control) this.chbNoEsPedidoLibreRapido);
      this.tpgPrincipal.Controls.Add((Control) this.chbEsPedidoLibreRapido);
      this.tpgPrincipal.Controls.Add((Control) this.Label26);
      this.tpgPrincipal.Controls.Add((Control) this.Label24);
      this.tpgPrincipal.Controls.Add((Control) this.RadioButton_Yes);
      this.tpgPrincipal.Controls.Add((Control) this.ComboBox_CantPrintCommand);
      this.tpgPrincipal.Controls.Add((Control) this.CheckBox_ShowGroupNot);
      this.tpgPrincipal.Controls.Add((Control) this.CheckBox_IsNotWaiterShowSale);
      this.tpgPrincipal.Controls.Add((Control) this.CheckBox_IsPeoppleNot);
      this.tpgPrincipal.Controls.Add((Control) this.CheckBox_IsWaiterShowSale);
      this.tpgPrincipal.Controls.Add((Control) this.Label_ShowGroup);
      this.tpgPrincipal.Controls.Add((Control) this.Label21);
      this.tpgPrincipal.Controls.Add((Control) this.CheckBox_ShowGroup);
      this.tpgPrincipal.Controls.Add((Control) this.CheckBox_IsNotDobleCommand);
      this.tpgPrincipal.Controls.Add((Control) this.CheckBox_ShowPay);
      this.tpgPrincipal.Controls.Add((Control) this.CheckBox_IsDobleCommand);
      this.tpgPrincipal.Controls.Add((Control) this.CheckBox_IsPeople);
      this.tpgPrincipal.Controls.Add((Control) this.Label2);
      this.tpgPrincipal.Controls.Add((Control) this.Button_AmountMin);
      this.tpgPrincipal.Controls.Add((Control) this.Label_ShowPay);
      this.tpgPrincipal.Controls.Add((Control) this.TextBox_AmountMin);
      this.tpgPrincipal.Controls.Add((Control) this.CheckBox_IsNotFirstPay);
      this.tpgPrincipal.Controls.Add((Control) this.Label20);
      this.tpgPrincipal.Controls.Add((Control) this.Label_IsPeople);
      this.tpgPrincipal.Controls.Add((Control) this.CheckBox_IsFirstPay);
      this.tpgPrincipal.Controls.Add((Control) this.CheckBox_ShowNotPay);
      this.tpgPrincipal.Controls.Add((Control) this.Label16);
      this.tpgPrincipal.Controls.Add((Control) this.Label3);
      this.tpgPrincipal.Controls.Add((Control) this.CheckBox_IsNotPrintDeleteItem);
      this.tpgPrincipal.Controls.Add((Control) this.CheckBox_NotBoxWaiter);
      this.tpgPrincipal.Controls.Add((Control) this.RadioButton_Not);
      this.tpgPrincipal.Controls.Add((Control) this.CheckBox_BoxWaiter);
      this.tpgPrincipal.Controls.Add((Control) this.CheckBox_IsPrintDeleteItem);
      this.tpgPrincipal.Controls.Add((Control) this.Label6);
      this.tpgPrincipal.Controls.Add((Control) this.CheckBox_NotMatricial);
      this.tpgPrincipal.Controls.Add((Control) this.Label19);
      this.tpgPrincipal.Controls.Add((Control) this.CheckBox_Matricial);
      this.tpgPrincipal.Controls.Add((Control) this.Label18);
      this.tpgPrincipal.Controls.Add((Control) this.CheckBoxShowConsume);
      this.tpgPrincipal.Controls.Add((Control) this.CheckBox_NotBarCode);
      this.tpgPrincipal.Controls.Add((Control) this.Label7);
      this.tpgPrincipal.Controls.Add((Control) this.CheckBox_IsBarCode);
      this.tpgPrincipal.Controls.Add((Control) this.CheckBoxShowNotConsume);
      this.tpgPrincipal.Controls.Add((Control) this.Label14);
      this.tpgPrincipal.Controls.Add((Control) this.Label8);
      this.tpgPrincipal.Controls.Add((Control) this.CheckBox_NotShowCommand);
      this.tpgPrincipal.Controls.Add((Control) this.CheckBox_ShowCommand);
      this.tpgPrincipal.Location = new Point(4, 25);
      this.tpgPrincipal.Name = "tpgPrincipal";
      this.tpgPrincipal.Padding = new Padding(3);
      this.tpgPrincipal.Size = new Size(657, 516);
      this.tpgPrincipal.TabIndex = 0;
      this.tpgPrincipal.Text = "Principal";
      this.tpgPrincipal.UseVisualStyleBackColor = true;
      this.CheckBox_IsNotAmountMin.Appearance = Appearance.Button;
      this.CheckBox_IsNotAmountMin.AutoSize = true;
      this.CheckBox_IsNotAmountMin.BackgroundImageLayout = ImageLayout.None;
      this.CheckBox_IsNotAmountMin.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.CheckBox_IsNotAmountMin.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.CheckBox_IsNotAmountMin.FlatStyle = FlatStyle.Flat;
      this.CheckBox_IsNotAmountMin.Image = (Image) componentResourceManager.GetObject("CheckBox_IsNotAmountMin.Image");
      this.CheckBox_IsNotAmountMin.Location = new Point(49, 93);
      this.CheckBox_IsNotAmountMin.Name = "CheckBox_IsNotAmountMin";
      this.CheckBox_IsNotAmountMin.Size = new Size(33, 33);
      this.CheckBox_IsNotAmountMin.TabIndex = 506;
      this.CheckBox_IsNotAmountMin.Text = "     ";
      this.CheckBox_IsNotAmountMin.UseVisualStyleBackColor = false;
      this.CheckBox_IsAmountMin.Appearance = Appearance.Button;
      this.CheckBox_IsAmountMin.AutoSize = true;
      this.CheckBox_IsAmountMin.BackgroundImageLayout = ImageLayout.None;
      this.CheckBox_IsAmountMin.Checked = true;
      this.CheckBox_IsAmountMin.CheckState = CheckState.Checked;
      this.CheckBox_IsAmountMin.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.CheckBox_IsAmountMin.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.CheckBox_IsAmountMin.FlatStyle = FlatStyle.Flat;
      this.CheckBox_IsAmountMin.Image = (Image) componentResourceManager.GetObject("CheckBox_IsAmountMin.Image");
      this.CheckBox_IsAmountMin.Location = new Point(6, 93);
      this.CheckBox_IsAmountMin.Name = "CheckBox_IsAmountMin";
      this.CheckBox_IsAmountMin.Size = new Size(33, 33);
      this.CheckBox_IsAmountMin.TabIndex = 505;
      this.CheckBox_IsAmountMin.Text = "     ";
      this.CheckBox_IsAmountMin.UseVisualStyleBackColor = true;
      this.chbNoSeleccionarMesaxDiseno.Appearance = Appearance.Button;
      this.chbNoSeleccionarMesaxDiseno.AutoSize = true;
      this.chbNoSeleccionarMesaxDiseno.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.chbNoSeleccionarMesaxDiseno.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.chbNoSeleccionarMesaxDiseno.FlatStyle = FlatStyle.Flat;
      this.chbNoSeleccionarMesaxDiseno.Image = (Image) componentResourceManager.GetObject("chbNoSeleccionarMesaxDiseno.Image");
      this.chbNoSeleccionarMesaxDiseno.Location = new Point(49, 470);
      this.chbNoSeleccionarMesaxDiseno.Name = "chbNoSeleccionarMesaxDiseno";
      this.chbNoSeleccionarMesaxDiseno.Size = new Size(33, 33);
      this.chbNoSeleccionarMesaxDiseno.TabIndex = 504;
      this.chbNoSeleccionarMesaxDiseno.Text = "     ";
      this.chbNoSeleccionarMesaxDiseno.UseVisualStyleBackColor = true;
      this.chbSeleccionarMesaxDiseno.Appearance = Appearance.Button;
      this.chbSeleccionarMesaxDiseno.AutoSize = true;
      this.chbSeleccionarMesaxDiseno.Checked = true;
      this.chbSeleccionarMesaxDiseno.CheckState = CheckState.Checked;
      this.chbSeleccionarMesaxDiseno.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.chbSeleccionarMesaxDiseno.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.chbSeleccionarMesaxDiseno.FlatStyle = FlatStyle.Flat;
      this.chbSeleccionarMesaxDiseno.Image = (Image) componentResourceManager.GetObject("chbSeleccionarMesaxDiseno.Image");
      this.chbSeleccionarMesaxDiseno.Location = new Point(6, 470);
      this.chbSeleccionarMesaxDiseno.Name = "chbSeleccionarMesaxDiseno";
      this.chbSeleccionarMesaxDiseno.Size = new Size(33, 33);
      this.chbSeleccionarMesaxDiseno.TabIndex = 503;
      this.chbSeleccionarMesaxDiseno.Text = "     ";
      this.chbSeleccionarMesaxDiseno.UseVisualStyleBackColor = true;
      this.Label34.AutoSize = true;
      this.Label34.BackColor = Color.Transparent;
      this.Label34.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label34.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label34.Location = new Point(96, 473);
      this.Label34.Name = "Label34";
      this.Label34.Size = new Size(264, 16);
      this.Label34.TabIndex = 502;
      this.Label34.Text = "¿Tomar pedidos desde diseño de Mesas?";
      this.chbNoMozoObservaPrecios.Appearance = Appearance.Button;
      this.chbNoMozoObservaPrecios.AutoSize = true;
      this.chbNoMozoObservaPrecios.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.chbNoMozoObservaPrecios.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.chbNoMozoObservaPrecios.FlatStyle = FlatStyle.Flat;
      this.chbNoMozoObservaPrecios.Image = (Image) componentResourceManager.GetObject("chbNoMozoObservaPrecios.Image");
      this.chbNoMozoObservaPrecios.Location = new Point(49, 412);
      this.chbNoMozoObservaPrecios.Name = "chbNoMozoObservaPrecios";
      this.chbNoMozoObservaPrecios.Size = new Size(33, 33);
      this.chbNoMozoObservaPrecios.TabIndex = 501;
      this.chbNoMozoObservaPrecios.Text = "     ";
      this.chbNoMozoObservaPrecios.UseVisualStyleBackColor = true;
      this.chbMozoObservaPrecios.Appearance = Appearance.Button;
      this.chbMozoObservaPrecios.AutoSize = true;
      this.chbMozoObservaPrecios.Checked = true;
      this.chbMozoObservaPrecios.CheckState = CheckState.Checked;
      this.chbMozoObservaPrecios.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.chbMozoObservaPrecios.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.chbMozoObservaPrecios.FlatStyle = FlatStyle.Flat;
      this.chbMozoObservaPrecios.Image = (Image) componentResourceManager.GetObject("chbMozoObservaPrecios.Image");
      this.chbMozoObservaPrecios.Location = new Point(6, 412);
      this.chbMozoObservaPrecios.Name = "chbMozoObservaPrecios";
      this.chbMozoObservaPrecios.Size = new Size(33, 33);
      this.chbMozoObservaPrecios.TabIndex = 500;
      this.chbMozoObservaPrecios.Text = "     ";
      this.chbMozoObservaPrecios.UseVisualStyleBackColor = true;
      this.Label32.AutoSize = true;
      this.Label32.BackColor = Color.Transparent;
      this.Label32.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label32.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label32.Location = new Point(96, 415);
      this.Label32.Name = "Label32";
      this.Label32.Size = new Size(262, 16);
      this.Label32.TabIndex = 499;
      this.Label32.Text = "¿Vendedor Consulta Precio de Productos?";
      this.chbNoEsPedidoLibreRapido.Appearance = Appearance.Button;
      this.chbNoEsPedidoLibreRapido.AutoSize = true;
      this.chbNoEsPedidoLibreRapido.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.chbNoEsPedidoLibreRapido.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.chbNoEsPedidoLibreRapido.FlatStyle = FlatStyle.Flat;
      this.chbNoEsPedidoLibreRapido.Image = (Image) componentResourceManager.GetObject("chbNoEsPedidoLibreRapido.Image");
      this.chbNoEsPedidoLibreRapido.Location = new Point(49, 35);
      this.chbNoEsPedidoLibreRapido.Name = "chbNoEsPedidoLibreRapido";
      this.chbNoEsPedidoLibreRapido.Size = new Size(33, 33);
      this.chbNoEsPedidoLibreRapido.TabIndex = 498;
      this.chbNoEsPedidoLibreRapido.Text = "     ";
      this.chbNoEsPedidoLibreRapido.UseVisualStyleBackColor = true;
      this.chbEsPedidoLibreRapido.Appearance = Appearance.Button;
      this.chbEsPedidoLibreRapido.AutoSize = true;
      this.chbEsPedidoLibreRapido.Checked = true;
      this.chbEsPedidoLibreRapido.CheckState = CheckState.Checked;
      this.chbEsPedidoLibreRapido.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.chbEsPedidoLibreRapido.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.chbEsPedidoLibreRapido.FlatStyle = FlatStyle.Flat;
      this.chbEsPedidoLibreRapido.Image = (Image) componentResourceManager.GetObject("chbEsPedidoLibreRapido.Image");
      this.chbEsPedidoLibreRapido.Location = new Point(6, 35);
      this.chbEsPedidoLibreRapido.Name = "chbEsPedidoLibreRapido";
      this.chbEsPedidoLibreRapido.Size = new Size(33, 33);
      this.chbEsPedidoLibreRapido.TabIndex = 497;
      this.chbEsPedidoLibreRapido.Text = "     ";
      this.chbEsPedidoLibreRapido.UseVisualStyleBackColor = true;
      this.Label26.AutoSize = true;
      this.Label26.BackColor = Color.Transparent;
      this.Label26.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label26.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label26.Location = new Point(96, 38);
      this.Label26.Name = "Label26";
      this.Label26.Size = new Size(166, 16);
      this.Label26.TabIndex = 496;
      this.Label26.Text = "¿Es Pedido Libre Rápido?";
      this.Label24.AutoSize = true;
      this.Label24.BackColor = Color.Transparent;
      this.Label24.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label24.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label24.Location = new Point(235, 154);
      this.Label24.Name = "Label24";
      this.Label24.Size = new Size(81, 16);
      this.Label24.TabIndex = 479;
      this.Label24.Text = "Comandas?";
      this.RadioButton_Yes.Appearance = Appearance.Button;
      this.RadioButton_Yes.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.RadioButton_Yes.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.RadioButton_Yes.FlatStyle = FlatStyle.Flat;
      this.RadioButton_Yes.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.RadioButton_Yes.Image = (Image) TriNetRestPOS.My.Resources.Resources.check_2;
      this.RadioButton_Yes.Location = new Point(6, 6);
      this.RadioButton_Yes.Name = "RadioButton_Yes";
      this.RadioButton_Yes.Size = new Size(37, 30);
      this.RadioButton_Yes.TabIndex = 476;
      this.RadioButton_Yes.Text = "     ";
      this.RadioButton_Yes.UseVisualStyleBackColor = true;
      this.ComboBox_CantPrintCommand.DropDownStyle = ComboBoxStyle.DropDownList;
      this.ComboBox_CantPrintCommand.ForeColor = Color.Red;
      this.ComboBox_CantPrintCommand.FormattingEnabled = true;
      this.ComboBox_CantPrintCommand.Items.AddRange(new object[9]
      {
        (object) "2",
        (object) "3",
        (object) "4",
        (object) "5",
        (object) "6",
        (object) "7",
        (object) "8",
        (object) "9",
        (object) "10"
      });
      this.ComboBox_CantPrintCommand.Location = new Point(175, 147);
      this.ComboBox_CantPrintCommand.MaxDropDownItems = 9;
      this.ComboBox_CantPrintCommand.Name = "ComboBox_CantPrintCommand";
      this.ComboBox_CantPrintCommand.Size = new Size(55, 24);
      this.ComboBox_CantPrintCommand.TabIndex = 478;
      this.CheckBox_ShowGroupNot.Appearance = Appearance.Button;
      this.CheckBox_ShowGroupNot.AutoSize = true;
      this.CheckBox_ShowGroupNot.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.CheckBox_ShowGroupNot.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.CheckBox_ShowGroupNot.FlatStyle = FlatStyle.Flat;
      this.CheckBox_ShowGroupNot.Image = (Image) componentResourceManager.GetObject("CheckBox_ShowGroupNot.Image");
      this.CheckBox_ShowGroupNot.Location = new Point(49, 238);
      this.CheckBox_ShowGroupNot.Name = "CheckBox_ShowGroupNot";
      this.CheckBox_ShowGroupNot.Size = new Size(33, 33);
      this.CheckBox_ShowGroupNot.TabIndex = 444;
      this.CheckBox_ShowGroupNot.Text = "     ";
      this.CheckBox_ShowGroupNot.UseVisualStyleBackColor = true;
      this.CheckBox_IsNotWaiterShowSale.Appearance = Appearance.Button;
      this.CheckBox_IsNotWaiterShowSale.AutoSize = true;
      this.CheckBox_IsNotWaiterShowSale.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.CheckBox_IsNotWaiterShowSale.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.CheckBox_IsNotWaiterShowSale.FlatStyle = FlatStyle.Flat;
      this.CheckBox_IsNotWaiterShowSale.Image = (Image) componentResourceManager.GetObject("CheckBox_IsNotWaiterShowSale.Image");
      this.CheckBox_IsNotWaiterShowSale.Location = new Point(49, 441);
      this.CheckBox_IsNotWaiterShowSale.Name = "CheckBox_IsNotWaiterShowSale";
      this.CheckBox_IsNotWaiterShowSale.Size = new Size(33, 33);
      this.CheckBox_IsNotWaiterShowSale.TabIndex = 474;
      this.CheckBox_IsNotWaiterShowSale.Text = "     ";
      this.CheckBox_IsNotWaiterShowSale.UseVisualStyleBackColor = true;
      this.CheckBox_IsPeoppleNot.Appearance = Appearance.Button;
      this.CheckBox_IsPeoppleNot.AutoSize = true;
      this.CheckBox_IsPeoppleNot.BackgroundImageLayout = ImageLayout.None;
      this.CheckBox_IsPeoppleNot.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.CheckBox_IsPeoppleNot.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.CheckBox_IsPeoppleNot.FlatStyle = FlatStyle.Flat;
      this.CheckBox_IsPeoppleNot.Image = (Image) componentResourceManager.GetObject("CheckBox_IsPeoppleNot.Image");
      this.CheckBox_IsPeoppleNot.Location = new Point(49, 122);
      this.CheckBox_IsPeoppleNot.Name = "CheckBox_IsPeoppleNot";
      this.CheckBox_IsPeoppleNot.Size = new Size(33, 33);
      this.CheckBox_IsPeoppleNot.TabIndex = 443;
      this.CheckBox_IsPeoppleNot.Text = "     ";
      this.CheckBox_IsPeoppleNot.UseVisualStyleBackColor = false;
      this.CheckBox_IsWaiterShowSale.Appearance = Appearance.Button;
      this.CheckBox_IsWaiterShowSale.AutoSize = true;
      this.CheckBox_IsWaiterShowSale.Checked = true;
      this.CheckBox_IsWaiterShowSale.CheckState = CheckState.Checked;
      this.CheckBox_IsWaiterShowSale.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.CheckBox_IsWaiterShowSale.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.CheckBox_IsWaiterShowSale.FlatStyle = FlatStyle.Flat;
      this.CheckBox_IsWaiterShowSale.Image = (Image) componentResourceManager.GetObject("CheckBox_IsWaiterShowSale.Image");
      this.CheckBox_IsWaiterShowSale.Location = new Point(6, 441);
      this.CheckBox_IsWaiterShowSale.Name = "CheckBox_IsWaiterShowSale";
      this.CheckBox_IsWaiterShowSale.Size = new Size(33, 33);
      this.CheckBox_IsWaiterShowSale.TabIndex = 473;
      this.CheckBox_IsWaiterShowSale.Text = "     ";
      this.CheckBox_IsWaiterShowSale.UseVisualStyleBackColor = true;
      this.Label_ShowGroup.AutoSize = true;
      this.Label_ShowGroup.BackColor = Color.Transparent;
      this.Label_ShowGroup.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label_ShowGroup.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label_ShowGroup.Location = new Point(96, 241);
      this.Label_ShowGroup.Name = "Label_ShowGroup";
      this.Label_ShowGroup.Size = new Size(114, 16);
      this.Label_ShowGroup.TabIndex = 442;
      this.Label_ShowGroup.Text = "¿Mostrar Grupos?";
      this.Label21.AutoSize = true;
      this.Label21.BackColor = Color.Transparent;
      this.Label21.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label21.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label21.Location = new Point(96, 444);
      this.Label21.Name = "Label21";
      this.Label21.Size = new Size(260, 16);
      this.Label21.TabIndex = 472;
      this.Label21.Text = "¿Vendedor Consulta su Resúmen Ventas?";
      this.CheckBox_ShowGroup.Appearance = Appearance.Button;
      this.CheckBox_ShowGroup.AutoSize = true;
      this.CheckBox_ShowGroup.Checked = true;
      this.CheckBox_ShowGroup.CheckState = CheckState.Checked;
      this.CheckBox_ShowGroup.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.CheckBox_ShowGroup.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.CheckBox_ShowGroup.FlatStyle = FlatStyle.Flat;
      this.CheckBox_ShowGroup.Image = (Image) componentResourceManager.GetObject("CheckBox_ShowGroup.Image");
      this.CheckBox_ShowGroup.Location = new Point(6, 238);
      this.CheckBox_ShowGroup.Name = "CheckBox_ShowGroup";
      this.CheckBox_ShowGroup.Size = new Size(33, 33);
      this.CheckBox_ShowGroup.TabIndex = 441;
      this.CheckBox_ShowGroup.Text = "     ";
      this.CheckBox_ShowGroup.UseVisualStyleBackColor = true;
      this.CheckBox_IsNotDobleCommand.Appearance = Appearance.Button;
      this.CheckBox_IsNotDobleCommand.AutoSize = true;
      this.CheckBox_IsNotDobleCommand.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.CheckBox_IsNotDobleCommand.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.CheckBox_IsNotDobleCommand.FlatStyle = FlatStyle.Flat;
      this.CheckBox_IsNotDobleCommand.Image = (Image) componentResourceManager.GetObject("CheckBox_IsNotDobleCommand.Image");
      this.CheckBox_IsNotDobleCommand.Location = new Point(49, 151);
      this.CheckBox_IsNotDobleCommand.Name = "CheckBox_IsNotDobleCommand";
      this.CheckBox_IsNotDobleCommand.Size = new Size(33, 33);
      this.CheckBox_IsNotDobleCommand.TabIndex = 471;
      this.CheckBox_IsNotDobleCommand.Text = "     ";
      this.CheckBox_IsNotDobleCommand.UseVisualStyleBackColor = true;
      this.CheckBox_ShowPay.Appearance = Appearance.Button;
      this.CheckBox_ShowPay.AutoSize = true;
      this.CheckBox_ShowPay.Checked = true;
      this.CheckBox_ShowPay.CheckState = CheckState.Checked;
      this.CheckBox_ShowPay.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.CheckBox_ShowPay.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.CheckBox_ShowPay.FlatStyle = FlatStyle.Flat;
      this.CheckBox_ShowPay.Image = (Image) componentResourceManager.GetObject("CheckBox_ShowPay.Image");
      this.CheckBox_ShowPay.Location = new Point(6, 267);
      this.CheckBox_ShowPay.Name = "CheckBox_ShowPay";
      this.CheckBox_ShowPay.Size = new Size(33, 33);
      this.CheckBox_ShowPay.TabIndex = 445;
      this.CheckBox_ShowPay.Text = "     ";
      this.CheckBox_ShowPay.UseVisualStyleBackColor = true;
      this.CheckBox_IsDobleCommand.Appearance = Appearance.Button;
      this.CheckBox_IsDobleCommand.AutoSize = true;
      this.CheckBox_IsDobleCommand.Checked = true;
      this.CheckBox_IsDobleCommand.CheckState = CheckState.Checked;
      this.CheckBox_IsDobleCommand.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.CheckBox_IsDobleCommand.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.CheckBox_IsDobleCommand.FlatStyle = FlatStyle.Flat;
      this.CheckBox_IsDobleCommand.Image = (Image) componentResourceManager.GetObject("CheckBox_IsDobleCommand.Image");
      this.CheckBox_IsDobleCommand.Location = new Point(6, 151);
      this.CheckBox_IsDobleCommand.Name = "CheckBox_IsDobleCommand";
      this.CheckBox_IsDobleCommand.Size = new Size(33, 33);
      this.CheckBox_IsDobleCommand.TabIndex = 470;
      this.CheckBox_IsDobleCommand.Text = "     ";
      this.CheckBox_IsDobleCommand.UseVisualStyleBackColor = true;
      this.CheckBox_IsPeople.Appearance = Appearance.Button;
      this.CheckBox_IsPeople.AutoSize = true;
      this.CheckBox_IsPeople.BackgroundImageLayout = ImageLayout.None;
      this.CheckBox_IsPeople.Checked = true;
      this.CheckBox_IsPeople.CheckState = CheckState.Checked;
      this.CheckBox_IsPeople.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.CheckBox_IsPeople.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.CheckBox_IsPeople.FlatStyle = FlatStyle.Flat;
      this.CheckBox_IsPeople.Image = (Image) componentResourceManager.GetObject("CheckBox_IsPeople.Image");
      this.CheckBox_IsPeople.Location = new Point(6, 122);
      this.CheckBox_IsPeople.Name = "CheckBox_IsPeople";
      this.CheckBox_IsPeople.Size = new Size(33, 33);
      this.CheckBox_IsPeople.TabIndex = 439;
      this.CheckBox_IsPeople.Text = "     ";
      this.CheckBox_IsPeople.UseVisualStyleBackColor = true;
      this.Label2.AutoSize = true;
      this.Label2.BackColor = Color.Transparent;
      this.Label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label2.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label2.Location = new Point(96, 154);
      this.Label2.Name = "Label2";
      this.Label2.Size = new Size(65, 16);
      this.Label2.TabIndex = 469;
      this.Label2.Text = "¿Imprimir ";
      this.Button_AmountMin.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.teclado_nueral;
      this.Button_AmountMin.FlatStyle = FlatStyle.Flat;
      this.Button_AmountMin.Font = new Font("Trebuchet MS", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_AmountMin.ForeColor = Color.WhiteSmoke;
      this.Button_AmountMin.Location = new Point(468, 70);
      this.Button_AmountMin.Name = "Button_AmountMin";
      this.Button_AmountMin.Size = new Size(62, 52);
      this.Button_AmountMin.TabIndex = 438;
      this.Button_AmountMin.TextImageRelation = TextImageRelation.TextAboveImage;
      this.Button_AmountMin.UseVisualStyleBackColor = true;
      this.Label_ShowPay.AutoSize = true;
      this.Label_ShowPay.BackColor = Color.Transparent;
      this.Label_ShowPay.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label_ShowPay.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label_ShowPay.Location = new Point(96, 270);
      this.Label_ShowPay.Name = "Label_ShowPay";
      this.Label_ShowPay.Size = new Size(278, 16);
      this.Label_ShowPay.TabIndex = 446;
      this.Label_ShowPay.Text = "¿Mostrar Pregunta de Confirmación al Pagar?";
      this.TextBox_AmountMin.BackColor = Color.White;
      this.TextBox_AmountMin.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.TextBox_AmountMin.ForeColor = Color.FromArgb(209, 102, 61);
      this.TextBox_AmountMin.Location = new Point(382, 94);
      this.TextBox_AmountMin.MaxLength = 10;
      this.TextBox_AmountMin.Name = "TextBox_AmountMin";
      this.TextBox_AmountMin.Size = new Size(80, 22);
      this.TextBox_AmountMin.TabIndex = 437;
      this.TextBox_AmountMin.Text = "0.00";
      this.TextBox_AmountMin.TextAlign = HorizontalAlignment.Right;
      this.CheckBox_IsNotFirstPay.Appearance = Appearance.Button;
      this.CheckBox_IsNotFirstPay.AutoSize = true;
      this.CheckBox_IsNotFirstPay.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.CheckBox_IsNotFirstPay.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.CheckBox_IsNotFirstPay.FlatStyle = FlatStyle.Flat;
      this.CheckBox_IsNotFirstPay.Image = (Image) componentResourceManager.GetObject("CheckBox_IsNotFirstPay.Image");
      this.CheckBox_IsNotFirstPay.Location = new Point(49, 325);
      this.CheckBox_IsNotFirstPay.Name = "CheckBox_IsNotFirstPay";
      this.CheckBox_IsNotFirstPay.Size = new Size(33, 33);
      this.CheckBox_IsNotFirstPay.TabIndex = 468;
      this.CheckBox_IsNotFirstPay.Text = "     ";
      this.CheckBox_IsNotFirstPay.UseVisualStyleBackColor = true;
      this.Label20.AutoSize = true;
      this.Label20.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label20.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label20.Location = new Point(96, 97);
      this.Label20.Name = "Label20";
      this.Label20.Size = new Size(239, 16);
      this.Label20.TabIndex = 439;
      this.Label20.Text = "¿Exigir Monto Mínimo de Consumo S/.?";
      this.Label_IsPeople.AutoSize = true;
      this.Label_IsPeople.BackColor = Color.Transparent;
      this.Label_IsPeople.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label_IsPeople.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label_IsPeople.Location = new Point(96, 125);
      this.Label_IsPeople.Name = "Label_IsPeople";
      this.Label_IsPeople.Size = new Size(153, 16);
      this.Label_IsPeople.TabIndex = 440;
      this.Label_IsPeople.Text = "¿Exigir Nº de Personas?";
      this.CheckBox_IsFirstPay.Appearance = Appearance.Button;
      this.CheckBox_IsFirstPay.AutoSize = true;
      this.CheckBox_IsFirstPay.Checked = true;
      this.CheckBox_IsFirstPay.CheckState = CheckState.Checked;
      this.CheckBox_IsFirstPay.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.CheckBox_IsFirstPay.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.CheckBox_IsFirstPay.FlatStyle = FlatStyle.Flat;
      this.CheckBox_IsFirstPay.Image = (Image) componentResourceManager.GetObject("CheckBox_IsFirstPay.Image");
      this.CheckBox_IsFirstPay.Location = new Point(6, 325);
      this.CheckBox_IsFirstPay.Name = "CheckBox_IsFirstPay";
      this.CheckBox_IsFirstPay.Size = new Size(33, 33);
      this.CheckBox_IsFirstPay.TabIndex = 467;
      this.CheckBox_IsFirstPay.Text = "     ";
      this.CheckBox_IsFirstPay.UseVisualStyleBackColor = true;
      this.CheckBox_ShowNotPay.Appearance = Appearance.Button;
      this.CheckBox_ShowNotPay.AutoSize = true;
      this.CheckBox_ShowNotPay.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.CheckBox_ShowNotPay.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.CheckBox_ShowNotPay.FlatStyle = FlatStyle.Flat;
      this.CheckBox_ShowNotPay.Image = (Image) componentResourceManager.GetObject("CheckBox_ShowNotPay.Image");
      this.CheckBox_ShowNotPay.Location = new Point(49, 267);
      this.CheckBox_ShowNotPay.Name = "CheckBox_ShowNotPay";
      this.CheckBox_ShowNotPay.Size = new Size(33, 33);
      this.CheckBox_ShowNotPay.TabIndex = 447;
      this.CheckBox_ShowNotPay.Text = "     ";
      this.CheckBox_ShowNotPay.UseVisualStyleBackColor = true;
      this.Label16.AutoSize = true;
      this.Label16.BackColor = Color.Transparent;
      this.Label16.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label16.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label16.Location = new Point(96, 328);
      this.Label16.Name = "Label16";
      this.Label16.Size = new Size(278, 16);
      this.Label16.TabIndex = 466;
      this.Label16.Text = "¿Primero Pagar y luego Imprimir Documento?";
      this.Label3.AutoSize = true;
      this.Label3.BackColor = Color.Transparent;
      this.Label3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label3.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label3.Location = new Point(96, 67);
      this.Label3.Name = "Label3";
      this.Label3.Size = new Size(209, 16);
      this.Label3.TabIndex = 448;
      this.Label3.Text = "¿El Cajero tambien es Vendedor?";
      this.CheckBox_IsNotPrintDeleteItem.Appearance = Appearance.Button;
      this.CheckBox_IsNotPrintDeleteItem.AutoSize = true;
      this.CheckBox_IsNotPrintDeleteItem.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.CheckBox_IsNotPrintDeleteItem.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.CheckBox_IsNotPrintDeleteItem.FlatStyle = FlatStyle.Flat;
      this.CheckBox_IsNotPrintDeleteItem.Image = (Image) componentResourceManager.GetObject("CheckBox_IsNotPrintDeleteItem.Image");
      this.CheckBox_IsNotPrintDeleteItem.Location = new Point(49, 180);
      this.CheckBox_IsNotPrintDeleteItem.Name = "CheckBox_IsNotPrintDeleteItem";
      this.CheckBox_IsNotPrintDeleteItem.Size = new Size(33, 33);
      this.CheckBox_IsNotPrintDeleteItem.TabIndex = 465;
      this.CheckBox_IsNotPrintDeleteItem.Text = "     ";
      this.CheckBox_IsNotPrintDeleteItem.UseVisualStyleBackColor = true;
      this.CheckBox_NotBoxWaiter.Appearance = Appearance.Button;
      this.CheckBox_NotBoxWaiter.AutoSize = true;
      this.CheckBox_NotBoxWaiter.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.CheckBox_NotBoxWaiter.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.CheckBox_NotBoxWaiter.FlatStyle = FlatStyle.Flat;
      this.CheckBox_NotBoxWaiter.Image = (Image) componentResourceManager.GetObject("CheckBox_NotBoxWaiter.Image");
      this.CheckBox_NotBoxWaiter.Location = new Point(49, 64);
      this.CheckBox_NotBoxWaiter.Name = "CheckBox_NotBoxWaiter";
      this.CheckBox_NotBoxWaiter.Size = new Size(33, 33);
      this.CheckBox_NotBoxWaiter.TabIndex = 449;
      this.CheckBox_NotBoxWaiter.Text = "     ";
      this.CheckBox_NotBoxWaiter.UseVisualStyleBackColor = true;
      this.RadioButton_Not.Appearance = Appearance.Button;
      this.RadioButton_Not.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.RadioButton_Not.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.RadioButton_Not.FlatStyle = FlatStyle.Flat;
      this.RadioButton_Not.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.RadioButton_Not.Image = (Image) TriNetRestPOS.My.Resources.Resources.check_3;
      this.RadioButton_Not.Location = new Point(45, 6);
      this.RadioButton_Not.Name = "RadioButton_Not";
      this.RadioButton_Not.Size = new Size(44, 30);
      this.RadioButton_Not.TabIndex = 477;
      this.RadioButton_Not.Text = "    ";
      this.RadioButton_Not.UseVisualStyleBackColor = true;
      this.CheckBox_BoxWaiter.Appearance = Appearance.Button;
      this.CheckBox_BoxWaiter.AutoSize = true;
      this.CheckBox_BoxWaiter.Checked = true;
      this.CheckBox_BoxWaiter.CheckState = CheckState.Checked;
      this.CheckBox_BoxWaiter.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.CheckBox_BoxWaiter.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.CheckBox_BoxWaiter.FlatStyle = FlatStyle.Flat;
      this.CheckBox_BoxWaiter.Image = (Image) componentResourceManager.GetObject("CheckBox_BoxWaiter.Image");
      this.CheckBox_BoxWaiter.Location = new Point(6, 64);
      this.CheckBox_BoxWaiter.Name = "CheckBox_BoxWaiter";
      this.CheckBox_BoxWaiter.Size = new Size(33, 33);
      this.CheckBox_BoxWaiter.TabIndex = 450;
      this.CheckBox_BoxWaiter.Text = "     ";
      this.CheckBox_BoxWaiter.UseVisualStyleBackColor = true;
      this.CheckBox_IsPrintDeleteItem.Appearance = Appearance.Button;
      this.CheckBox_IsPrintDeleteItem.AutoSize = true;
      this.CheckBox_IsPrintDeleteItem.Checked = true;
      this.CheckBox_IsPrintDeleteItem.CheckState = CheckState.Checked;
      this.CheckBox_IsPrintDeleteItem.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.CheckBox_IsPrintDeleteItem.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.CheckBox_IsPrintDeleteItem.FlatStyle = FlatStyle.Flat;
      this.CheckBox_IsPrintDeleteItem.Image = (Image) componentResourceManager.GetObject("CheckBox_IsPrintDeleteItem.Image");
      this.CheckBox_IsPrintDeleteItem.Location = new Point(6, 180);
      this.CheckBox_IsPrintDeleteItem.Name = "CheckBox_IsPrintDeleteItem";
      this.CheckBox_IsPrintDeleteItem.Size = new Size(33, 33);
      this.CheckBox_IsPrintDeleteItem.TabIndex = 464;
      this.CheckBox_IsPrintDeleteItem.Text = "     ";
      this.CheckBox_IsPrintDeleteItem.UseVisualStyleBackColor = true;
      this.Label6.AutoSize = true;
      this.Label6.BackColor = Color.Transparent;
      this.Label6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label6.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label6.Location = new Point(96, 212);
      this.Label6.Name = "Label6";
      this.Label6.Size = new Size(216, 16);
      this.Label6.TabIndex = 451;
      this.Label6.Text = "¿Imprimir Factura Grande o Ticket?";
      this.CheckBox_NotMatricial.Appearance = Appearance.Button;
      this.CheckBox_NotMatricial.AutoSize = true;
      this.CheckBox_NotMatricial.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.CheckBox_NotMatricial.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.CheckBox_NotMatricial.FlatStyle = FlatStyle.Flat;
      this.CheckBox_NotMatricial.Image = (Image) componentResourceManager.GetObject("CheckBox_NotMatricial.Image");
      this.CheckBox_NotMatricial.Location = new Point(49, 209);
      this.CheckBox_NotMatricial.Name = "CheckBox_NotMatricial";
      this.CheckBox_NotMatricial.Size = new Size(33, 33);
      this.CheckBox_NotMatricial.TabIndex = 452;
      this.CheckBox_NotMatricial.Text = "     ";
      this.CheckBox_NotMatricial.UseVisualStyleBackColor = true;
      this.Label19.AutoSize = true;
      this.Label19.BackColor = Color.Transparent;
      this.Label19.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label19.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label19.Location = new Point(96, 12);
      this.Label19.Name = "Label19";
      this.Label19.Size = new Size(218, 16);
      this.Label19.TabIndex = 475;
      this.Label19.Text = "¿Punto de Venta es Touch Screen?";
      this.CheckBox_Matricial.Appearance = Appearance.Button;
      this.CheckBox_Matricial.AutoSize = true;
      this.CheckBox_Matricial.Checked = true;
      this.CheckBox_Matricial.CheckState = CheckState.Checked;
      this.CheckBox_Matricial.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.CheckBox_Matricial.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.CheckBox_Matricial.FlatStyle = FlatStyle.Flat;
      this.CheckBox_Matricial.Image = (Image) TriNetRestPOS.My.Resources.Resources.check_2;
      this.CheckBox_Matricial.Location = new Point(6, 209);
      this.CheckBox_Matricial.Name = "CheckBox_Matricial";
      this.CheckBox_Matricial.Size = new Size(33, 33);
      this.CheckBox_Matricial.TabIndex = 453;
      this.CheckBox_Matricial.Text = "     ";
      this.CheckBox_Matricial.UseVisualStyleBackColor = true;
      this.Label18.AutoSize = true;
      this.Label18.BackColor = Color.Transparent;
      this.Label18.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label18.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label18.Location = new Point(96, 183);
      this.Label18.Name = "Label18";
      this.Label18.Size = new Size(290, 16);
      this.Label18.TabIndex = 463;
      this.Label18.Text = "¿Imprimir Comanda al Eliminar Item de Pedido?";
      this.CheckBoxShowConsume.Appearance = Appearance.Button;
      this.CheckBoxShowConsume.AutoSize = true;
      this.CheckBoxShowConsume.Checked = true;
      this.CheckBoxShowConsume.CheckState = CheckState.Checked;
      this.CheckBoxShowConsume.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.CheckBoxShowConsume.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.CheckBoxShowConsume.FlatStyle = FlatStyle.Flat;
      this.CheckBoxShowConsume.Image = (Image) componentResourceManager.GetObject("CheckBoxShowConsume.Image");
      this.CheckBoxShowConsume.Location = new Point(6, 296);
      this.CheckBoxShowConsume.Name = "CheckBoxShowConsume";
      this.CheckBoxShowConsume.Size = new Size(33, 33);
      this.CheckBoxShowConsume.TabIndex = 454;
      this.CheckBoxShowConsume.Text = "     ";
      this.CheckBoxShowConsume.UseVisualStyleBackColor = true;
      this.CheckBox_NotBarCode.Appearance = Appearance.Button;
      this.CheckBox_NotBarCode.AutoSize = true;
      this.CheckBox_NotBarCode.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.CheckBox_NotBarCode.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.CheckBox_NotBarCode.FlatStyle = FlatStyle.Flat;
      this.CheckBox_NotBarCode.Image = (Image) componentResourceManager.GetObject("CheckBox_NotBarCode.Image");
      this.CheckBox_NotBarCode.Location = new Point(49, 354);
      this.CheckBox_NotBarCode.Name = "CheckBox_NotBarCode";
      this.CheckBox_NotBarCode.Size = new Size(33, 33);
      this.CheckBox_NotBarCode.TabIndex = 462;
      this.CheckBox_NotBarCode.Text = "     ";
      this.CheckBox_NotBarCode.UseVisualStyleBackColor = true;
      this.Label7.AutoSize = true;
      this.Label7.BackColor = Color.Transparent;
      this.Label7.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label7.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label7.Location = new Point(96, 299);
      this.Label7.Name = "Label7";
      this.Label7.Size = new Size(174, 16);
      this.Label7.TabIndex = 455;
      this.Label7.Text = "¿Preguntar \"Por Consumo\"?";
      this.CheckBox_IsBarCode.Appearance = Appearance.Button;
      this.CheckBox_IsBarCode.AutoSize = true;
      this.CheckBox_IsBarCode.Checked = true;
      this.CheckBox_IsBarCode.CheckState = CheckState.Checked;
      this.CheckBox_IsBarCode.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.CheckBox_IsBarCode.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.CheckBox_IsBarCode.FlatStyle = FlatStyle.Flat;
      this.CheckBox_IsBarCode.Image = (Image) componentResourceManager.GetObject("CheckBox_IsBarCode.Image");
      this.CheckBox_IsBarCode.Location = new Point(6, 354);
      this.CheckBox_IsBarCode.Name = "CheckBox_IsBarCode";
      this.CheckBox_IsBarCode.Size = new Size(33, 33);
      this.CheckBox_IsBarCode.TabIndex = 461;
      this.CheckBox_IsBarCode.Text = "     ";
      this.CheckBox_IsBarCode.UseVisualStyleBackColor = true;
      this.CheckBoxShowNotConsume.Appearance = Appearance.Button;
      this.CheckBoxShowNotConsume.AutoSize = true;
      this.CheckBoxShowNotConsume.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.CheckBoxShowNotConsume.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.CheckBoxShowNotConsume.FlatStyle = FlatStyle.Flat;
      this.CheckBoxShowNotConsume.Image = (Image) componentResourceManager.GetObject("CheckBoxShowNotConsume.Image");
      this.CheckBoxShowNotConsume.Location = new Point(49, 296);
      this.CheckBoxShowNotConsume.Name = "CheckBoxShowNotConsume";
      this.CheckBoxShowNotConsume.Size = new Size(33, 33);
      this.CheckBoxShowNotConsume.TabIndex = 456;
      this.CheckBoxShowNotConsume.Text = "     ";
      this.CheckBoxShowNotConsume.UseVisualStyleBackColor = true;
      this.Label14.AutoSize = true;
      this.Label14.BackColor = Color.Transparent;
      this.Label14.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label14.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label14.Location = new Point(96, 357);
      this.Label14.Name = "Label14";
      this.Label14.Size = new Size(215, 16);
      this.Label14.TabIndex = 460;
      this.Label14.Text = "¿Usa Lector de Código de Barras?";
      this.Label8.AutoSize = true;
      this.Label8.BackColor = Color.Transparent;
      this.Label8.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label8.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label8.Location = new Point(96, 387);
      this.Label8.Name = "Label8";
      this.Label8.Size = new Size(200, 16);
      this.Label8.TabIndex = 457;
      this.Label8.Text = "¿Venta Simple / Sin Comandas?";
      this.CheckBox_NotShowCommand.Appearance = Appearance.Button;
      this.CheckBox_NotShowCommand.AutoSize = true;
      this.CheckBox_NotShowCommand.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.CheckBox_NotShowCommand.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.CheckBox_NotShowCommand.FlatStyle = FlatStyle.Flat;
      this.CheckBox_NotShowCommand.Image = (Image) componentResourceManager.GetObject("CheckBox_NotShowCommand.Image");
      this.CheckBox_NotShowCommand.Location = new Point(49, 383);
      this.CheckBox_NotShowCommand.Name = "CheckBox_NotShowCommand";
      this.CheckBox_NotShowCommand.Size = new Size(33, 33);
      this.CheckBox_NotShowCommand.TabIndex = 459;
      this.CheckBox_NotShowCommand.Text = "     ";
      this.CheckBox_NotShowCommand.UseVisualStyleBackColor = true;
      this.CheckBox_ShowCommand.Appearance = Appearance.Button;
      this.CheckBox_ShowCommand.AutoSize = true;
      this.CheckBox_ShowCommand.Checked = true;
      this.CheckBox_ShowCommand.CheckState = CheckState.Checked;
      this.CheckBox_ShowCommand.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.CheckBox_ShowCommand.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.CheckBox_ShowCommand.FlatStyle = FlatStyle.Flat;
      this.CheckBox_ShowCommand.Image = (Image) componentResourceManager.GetObject("CheckBox_ShowCommand.Image");
      this.CheckBox_ShowCommand.Location = new Point(6, 383);
      this.CheckBox_ShowCommand.Name = "CheckBox_ShowCommand";
      this.CheckBox_ShowCommand.Size = new Size(33, 33);
      this.CheckBox_ShowCommand.TabIndex = 458;
      this.CheckBox_ShowCommand.Text = "     ";
      this.CheckBox_ShowCommand.UseVisualStyleBackColor = true;
      this.tpgConfirmacion.Controls.Add((Control) this.chbNoConfirmarComanda);
      this.tpgConfirmacion.Controls.Add((Control) this.Label25);
      this.tpgConfirmacion.Controls.Add((Control) this.chbConfirmarComanda);
      this.tpgConfirmacion.Controls.Add((Control) this.chbConfirmarDivCuentas);
      this.tpgConfirmacion.Controls.Add((Control) this.Label27);
      this.tpgConfirmacion.Controls.Add((Control) this.chbNoConfirmarDocumento);
      this.tpgConfirmacion.Controls.Add((Control) this.chbConfirmarDocumento);
      this.tpgConfirmacion.Controls.Add((Control) this.chbNoConfirmarDivCuentas);
      this.tpgConfirmacion.Controls.Add((Control) this.Label28);
      this.tpgConfirmacion.Controls.Add((Control) this.chbConfirmarTransfMesas);
      this.tpgConfirmacion.Controls.Add((Control) this.chbNoConfirmarPago);
      this.tpgConfirmacion.Controls.Add((Control) this.Label29);
      this.tpgConfirmacion.Controls.Add((Control) this.chbConfirmarPago);
      this.tpgConfirmacion.Controls.Add((Control) this.chbNoConfirmarTransfMesas);
      this.tpgConfirmacion.Controls.Add((Control) this.Label30);
      this.tpgConfirmacion.Controls.Add((Control) this.Label31);
      this.tpgConfirmacion.Controls.Add((Control) this.chbNoConfirmarPedido);
      this.tpgConfirmacion.Controls.Add((Control) this.chbConfirmarPedido);
      this.tpgConfirmacion.Location = new Point(4, 25);
      this.tpgConfirmacion.Name = "tpgConfirmacion";
      this.tpgConfirmacion.Size = new Size(657, 516);
      this.tpgConfirmacion.TabIndex = 2;
      this.tpgConfirmacion.Text = "Confirmaciones";
      this.tpgConfirmacion.UseVisualStyleBackColor = true;
      this.chbNoConfirmarComanda.Appearance = Appearance.Button;
      this.chbNoConfirmarComanda.AutoSize = true;
      this.chbNoConfirmarComanda.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.chbNoConfirmarComanda.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.chbNoConfirmarComanda.FlatStyle = FlatStyle.Flat;
      this.chbNoConfirmarComanda.Image = (Image) componentResourceManager.GetObject("chbNoConfirmarComanda.Image");
      this.chbNoConfirmarComanda.Location = new Point(49, 6);
      this.chbNoConfirmarComanda.Name = "chbNoConfirmarComanda";
      this.chbNoConfirmarComanda.Size = new Size(33, 33);
      this.chbNoConfirmarComanda.TabIndex = 477;
      this.chbNoConfirmarComanda.Text = "     ";
      this.chbNoConfirmarComanda.UseVisualStyleBackColor = true;
      this.Label25.AutoSize = true;
      this.Label25.BackColor = Color.Transparent;
      this.Label25.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label25.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label25.Location = new Point(95, 18);
      this.Label25.Name = "Label25";
      this.Label25.Size = new Size(218, 16);
      this.Label25.TabIndex = 476;
      this.Label25.Text = "¿Confirmar el Envío de Comandas?";
      this.chbConfirmarComanda.Appearance = Appearance.Button;
      this.chbConfirmarComanda.AutoSize = true;
      this.chbConfirmarComanda.Checked = true;
      this.chbConfirmarComanda.CheckState = CheckState.Checked;
      this.chbConfirmarComanda.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.chbConfirmarComanda.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.chbConfirmarComanda.FlatStyle = FlatStyle.Flat;
      this.chbConfirmarComanda.Image = (Image) componentResourceManager.GetObject("chbConfirmarComanda.Image");
      this.chbConfirmarComanda.Location = new Point(6, 6);
      this.chbConfirmarComanda.Name = "chbConfirmarComanda";
      this.chbConfirmarComanda.Size = new Size(33, 33);
      this.chbConfirmarComanda.TabIndex = 475;
      this.chbConfirmarComanda.Text = "     ";
      this.chbConfirmarComanda.UseVisualStyleBackColor = true;
      this.chbConfirmarDivCuentas.Appearance = Appearance.Button;
      this.chbConfirmarDivCuentas.AutoSize = true;
      this.chbConfirmarDivCuentas.Checked = true;
      this.chbConfirmarDivCuentas.CheckState = CheckState.Checked;
      this.chbConfirmarDivCuentas.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.chbConfirmarDivCuentas.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.chbConfirmarDivCuentas.FlatStyle = FlatStyle.Flat;
      this.chbConfirmarDivCuentas.Image = (Image) componentResourceManager.GetObject("chbConfirmarDivCuentas.Image");
      this.chbConfirmarDivCuentas.Location = new Point(6, 35);
      this.chbConfirmarDivCuentas.Name = "chbConfirmarDivCuentas";
      this.chbConfirmarDivCuentas.Size = new Size(33, 33);
      this.chbConfirmarDivCuentas.TabIndex = 478;
      this.chbConfirmarDivCuentas.Text = "     ";
      this.chbConfirmarDivCuentas.UseVisualStyleBackColor = true;
      this.Label27.AutoSize = true;
      this.Label27.BackColor = Color.Transparent;
      this.Label27.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label27.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label27.Location = new Point(95, 47);
      this.Label27.Name = "Label27";
      this.Label27.Size = new Size(215, 16);
      this.Label27.TabIndex = 479;
      this.Label27.Text = "¿Confirmar la División de Cuentas?";
      this.chbNoConfirmarDocumento.Appearance = Appearance.Button;
      this.chbNoConfirmarDocumento.AutoSize = true;
      this.chbNoConfirmarDocumento.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.chbNoConfirmarDocumento.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.chbNoConfirmarDocumento.FlatStyle = FlatStyle.Flat;
      this.chbNoConfirmarDocumento.Image = (Image) componentResourceManager.GetObject("chbNoConfirmarDocumento.Image");
      this.chbNoConfirmarDocumento.Location = new Point(49, 64);
      this.chbNoConfirmarDocumento.Name = "chbNoConfirmarDocumento";
      this.chbNoConfirmarDocumento.Size = new Size(33, 33);
      this.chbNoConfirmarDocumento.TabIndex = 492;
      this.chbNoConfirmarDocumento.Text = "     ";
      this.chbNoConfirmarDocumento.UseVisualStyleBackColor = true;
      this.chbConfirmarDocumento.Appearance = Appearance.Button;
      this.chbConfirmarDocumento.AutoSize = true;
      this.chbConfirmarDocumento.Checked = true;
      this.chbConfirmarDocumento.CheckState = CheckState.Checked;
      this.chbConfirmarDocumento.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.chbConfirmarDocumento.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.chbConfirmarDocumento.FlatStyle = FlatStyle.Flat;
      this.chbConfirmarDocumento.Image = (Image) componentResourceManager.GetObject("chbConfirmarDocumento.Image");
      this.chbConfirmarDocumento.Location = new Point(6, 64);
      this.chbConfirmarDocumento.Name = "chbConfirmarDocumento";
      this.chbConfirmarDocumento.Size = new Size(33, 33);
      this.chbConfirmarDocumento.TabIndex = 491;
      this.chbConfirmarDocumento.Text = "     ";
      this.chbConfirmarDocumento.UseVisualStyleBackColor = true;
      this.chbNoConfirmarDivCuentas.Appearance = Appearance.Button;
      this.chbNoConfirmarDivCuentas.AutoSize = true;
      this.chbNoConfirmarDivCuentas.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.chbNoConfirmarDivCuentas.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.chbNoConfirmarDivCuentas.FlatStyle = FlatStyle.Flat;
      this.chbNoConfirmarDivCuentas.Image = (Image) componentResourceManager.GetObject("chbNoConfirmarDivCuentas.Image");
      this.chbNoConfirmarDivCuentas.Location = new Point(49, 35);
      this.chbNoConfirmarDivCuentas.Name = "chbNoConfirmarDivCuentas";
      this.chbNoConfirmarDivCuentas.Size = new Size(33, 33);
      this.chbNoConfirmarDivCuentas.TabIndex = 480;
      this.chbNoConfirmarDivCuentas.Text = "     ";
      this.chbNoConfirmarDivCuentas.UseVisualStyleBackColor = true;
      this.Label28.AutoSize = true;
      this.Label28.BackColor = Color.Transparent;
      this.Label28.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label28.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label28.Location = new Point(95, 76);
      this.Label28.Name = "Label28";
      this.Label28.Size = new Size(248, 16);
      this.Label28.TabIndex = 490;
      this.Label28.Text = "¿Confirmar la Creación de Documentos?";
      this.chbConfirmarTransfMesas.Appearance = Appearance.Button;
      this.chbConfirmarTransfMesas.AutoSize = true;
      this.chbConfirmarTransfMesas.Checked = true;
      this.chbConfirmarTransfMesas.CheckState = CheckState.Checked;
      this.chbConfirmarTransfMesas.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.chbConfirmarTransfMesas.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.chbConfirmarTransfMesas.FlatStyle = FlatStyle.Flat;
      this.chbConfirmarTransfMesas.Image = (Image) componentResourceManager.GetObject("chbConfirmarTransfMesas.Image");
      this.chbConfirmarTransfMesas.Location = new Point(6, 151);
      this.chbConfirmarTransfMesas.Name = "chbConfirmarTransfMesas";
      this.chbConfirmarTransfMesas.Size = new Size(33, 33);
      this.chbConfirmarTransfMesas.TabIndex = 481;
      this.chbConfirmarTransfMesas.Text = "     ";
      this.chbConfirmarTransfMesas.UseVisualStyleBackColor = true;
      this.chbNoConfirmarPago.Appearance = Appearance.Button;
      this.chbNoConfirmarPago.AutoSize = true;
      this.chbNoConfirmarPago.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.chbNoConfirmarPago.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.chbNoConfirmarPago.FlatStyle = FlatStyle.Flat;
      this.chbNoConfirmarPago.Image = (Image) componentResourceManager.GetObject("chbNoConfirmarPago.Image");
      this.chbNoConfirmarPago.Location = new Point(49, 93);
      this.chbNoConfirmarPago.Name = "chbNoConfirmarPago";
      this.chbNoConfirmarPago.Size = new Size(33, 33);
      this.chbNoConfirmarPago.TabIndex = 489;
      this.chbNoConfirmarPago.Text = "     ";
      this.chbNoConfirmarPago.UseVisualStyleBackColor = true;
      this.Label29.AutoSize = true;
      this.Label29.BackColor = Color.Transparent;
      this.Label29.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label29.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label29.Location = new Point(95, 163);
      this.Label29.Name = "Label29";
      this.Label29.Size = new Size(242, 16);
      this.Label29.TabIndex = 482;
      this.Label29.Text = "¿Confirmar la Transferencia de Mesas?";
      this.chbConfirmarPago.Appearance = Appearance.Button;
      this.chbConfirmarPago.AutoSize = true;
      this.chbConfirmarPago.Checked = true;
      this.chbConfirmarPago.CheckState = CheckState.Checked;
      this.chbConfirmarPago.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.chbConfirmarPago.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.chbConfirmarPago.FlatStyle = FlatStyle.Flat;
      this.chbConfirmarPago.Image = (Image) componentResourceManager.GetObject("chbConfirmarPago.Image");
      this.chbConfirmarPago.Location = new Point(6, 93);
      this.chbConfirmarPago.Name = "chbConfirmarPago";
      this.chbConfirmarPago.Size = new Size(33, 33);
      this.chbConfirmarPago.TabIndex = 488;
      this.chbConfirmarPago.Text = "     ";
      this.chbConfirmarPago.UseVisualStyleBackColor = true;
      this.chbNoConfirmarTransfMesas.Appearance = Appearance.Button;
      this.chbNoConfirmarTransfMesas.AutoSize = true;
      this.chbNoConfirmarTransfMesas.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.chbNoConfirmarTransfMesas.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.chbNoConfirmarTransfMesas.FlatStyle = FlatStyle.Flat;
      this.chbNoConfirmarTransfMesas.Image = (Image) componentResourceManager.GetObject("chbNoConfirmarTransfMesas.Image");
      this.chbNoConfirmarTransfMesas.Location = new Point(49, 151);
      this.chbNoConfirmarTransfMesas.Name = "chbNoConfirmarTransfMesas";
      this.chbNoConfirmarTransfMesas.Size = new Size(33, 33);
      this.chbNoConfirmarTransfMesas.TabIndex = 483;
      this.chbNoConfirmarTransfMesas.Text = "     ";
      this.chbNoConfirmarTransfMesas.UseVisualStyleBackColor = true;
      this.Label30.AutoSize = true;
      this.Label30.BackColor = Color.Transparent;
      this.Label30.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label30.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label30.Location = new Point(95, 105);
      this.Label30.Name = "Label30";
      this.Label30.Size = new Size(228, 16);
      this.Label30.TabIndex = 487;
      this.Label30.Text = "¿Confirmar la Generación de Pagos?";
      this.Label31.AutoSize = true;
      this.Label31.BackColor = Color.Transparent;
      this.Label31.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label31.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label31.Location = new Point(95, 135);
      this.Label31.Name = "Label31";
      this.Label31.Size = new Size(209, 16);
      this.Label31.TabIndex = 484;
      this.Label31.Text = "¿Confirmar Creación de Pedidos?";
      this.chbNoConfirmarPedido.Appearance = Appearance.Button;
      this.chbNoConfirmarPedido.AutoSize = true;
      this.chbNoConfirmarPedido.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.chbNoConfirmarPedido.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.chbNoConfirmarPedido.FlatStyle = FlatStyle.Flat;
      this.chbNoConfirmarPedido.Image = (Image) componentResourceManager.GetObject("chbNoConfirmarPedido.Image");
      this.chbNoConfirmarPedido.Location = new Point(49, 122);
      this.chbNoConfirmarPedido.Name = "chbNoConfirmarPedido";
      this.chbNoConfirmarPedido.Size = new Size(33, 33);
      this.chbNoConfirmarPedido.TabIndex = 486;
      this.chbNoConfirmarPedido.Text = "     ";
      this.chbNoConfirmarPedido.UseVisualStyleBackColor = true;
      this.chbConfirmarPedido.Appearance = Appearance.Button;
      this.chbConfirmarPedido.AutoSize = true;
      this.chbConfirmarPedido.Checked = true;
      this.chbConfirmarPedido.CheckState = CheckState.Checked;
      this.chbConfirmarPedido.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.chbConfirmarPedido.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.chbConfirmarPedido.FlatStyle = FlatStyle.Flat;
      this.chbConfirmarPedido.Image = (Image) componentResourceManager.GetObject("chbConfirmarPedido.Image");
      this.chbConfirmarPedido.Location = new Point(6, 122);
      this.chbConfirmarPedido.Name = "chbConfirmarPedido";
      this.chbConfirmarPedido.Size = new Size(33, 33);
      this.chbConfirmarPedido.TabIndex = 485;
      this.chbConfirmarPedido.Text = "     ";
      this.chbConfirmarPedido.UseVisualStyleBackColor = true;
      this.tpgSeguridad.BackColor = Color.White;
      this.tpgSeguridad.Controls.Add((Control) this.Label43);
      this.tpgSeguridad.Controls.Add((Control) this.CheckBox_ImprimirPrecuenta);
      this.tpgSeguridad.Controls.Add((Control) this.CheckBox_NoImprimirPrecuenta);
      this.tpgSeguridad.Controls.Add((Control) this.CheckBox_DeleteOrder);
      this.tpgSeguridad.Controls.Add((Control) this.CheckBox_DeleteItem);
      this.tpgSeguridad.Controls.Add((Control) this.CheckBox_NotDeleteOrder);
      this.tpgSeguridad.Controls.Add((Control) this.Label9);
      this.tpgSeguridad.Controls.Add((Control) this.Label17);
      this.tpgSeguridad.Controls.Add((Control) this.CheckBox_NotDeleteItem);
      this.tpgSeguridad.Controls.Add((Control) this.CheckBox_DocuIntern);
      this.tpgSeguridad.Controls.Add((Control) this.Label10);
      this.tpgSeguridad.Controls.Add((Control) this.CheckBox_NotDocuIntern);
      this.tpgSeguridad.Controls.Add((Control) this.CheckBox_NotDeleteDocument);
      this.tpgSeguridad.Controls.Add((Control) this.Label15);
      this.tpgSeguridad.Controls.Add((Control) this.CheckBox_DeleteDocument);
      this.tpgSeguridad.Controls.Add((Control) this.CheckBox_ChangePrice);
      this.tpgSeguridad.Controls.Add((Control) this.Label11);
      this.tpgSeguridad.Controls.Add((Control) this.CheckBox_NotChangePrice);
      this.tpgSeguridad.Location = new Point(4, 25);
      this.tpgSeguridad.Name = "tpgSeguridad";
      this.tpgSeguridad.Padding = new Padding(3);
      this.tpgSeguridad.Size = new Size(657, 516);
      this.tpgSeguridad.TabIndex = 1;
      this.tpgSeguridad.Text = "Seguridad";
      this.tpgSeguridad.UseVisualStyleBackColor = true;
      this.Label43.AutoSize = true;
      this.Label43.BackColor = Color.Transparent;
      this.Label43.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label43.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label43.Location = new Point(95, 160);
      this.Label43.Name = "Label43";
      this.Label43.Size = new Size(233, 16);
      this.Label43.TabIndex = 227;
      this.Label43.Text = "¿Exigir Usuario al Imprimir Precuenta?";
      this.CheckBox_ImprimirPrecuenta.Appearance = Appearance.Button;
      this.CheckBox_ImprimirPrecuenta.AutoSize = true;
      this.CheckBox_ImprimirPrecuenta.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.CheckBox_ImprimirPrecuenta.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.CheckBox_ImprimirPrecuenta.FlatStyle = FlatStyle.Flat;
      this.CheckBox_ImprimirPrecuenta.Image = (Image) componentResourceManager.GetObject("CheckBox_ImprimirPrecuenta.Image");
      this.CheckBox_ImprimirPrecuenta.Location = new Point(6, 150);
      this.CheckBox_ImprimirPrecuenta.Name = "CheckBox_ImprimirPrecuenta";
      this.CheckBox_ImprimirPrecuenta.Size = new Size(33, 33);
      this.CheckBox_ImprimirPrecuenta.TabIndex = 226;
      this.CheckBox_ImprimirPrecuenta.Text = "     ";
      this.CheckBox_ImprimirPrecuenta.UseVisualStyleBackColor = true;
      this.CheckBox_NoImprimirPrecuenta.Appearance = Appearance.Button;
      this.CheckBox_NoImprimirPrecuenta.AutoSize = true;
      this.CheckBox_NoImprimirPrecuenta.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.CheckBox_NoImprimirPrecuenta.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.CheckBox_NoImprimirPrecuenta.FlatStyle = FlatStyle.Flat;
      this.CheckBox_NoImprimirPrecuenta.Image = (Image) componentResourceManager.GetObject("CheckBox_NoImprimirPrecuenta.Image");
      this.CheckBox_NoImprimirPrecuenta.Location = new Point(49, 150);
      this.CheckBox_NoImprimirPrecuenta.Name = "CheckBox_NoImprimirPrecuenta";
      this.CheckBox_NoImprimirPrecuenta.Size = new Size(33, 33);
      this.CheckBox_NoImprimirPrecuenta.TabIndex = 225;
      this.CheckBox_NoImprimirPrecuenta.Text = "     ";
      this.CheckBox_NoImprimirPrecuenta.UseVisualStyleBackColor = true;
      this.CheckBox_DeleteOrder.Appearance = Appearance.Button;
      this.CheckBox_DeleteOrder.AutoSize = true;
      this.CheckBox_DeleteOrder.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.CheckBox_DeleteOrder.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.CheckBox_DeleteOrder.FlatStyle = FlatStyle.Flat;
      this.CheckBox_DeleteOrder.Image = (Image) componentResourceManager.GetObject("CheckBox_DeleteOrder.Image");
      this.CheckBox_DeleteOrder.Location = new Point(6, 122);
      this.CheckBox_DeleteOrder.Name = "CheckBox_DeleteOrder";
      this.CheckBox_DeleteOrder.Size = new Size(33, 33);
      this.CheckBox_DeleteOrder.TabIndex = 224;
      this.CheckBox_DeleteOrder.Text = "     ";
      this.CheckBox_DeleteOrder.UseVisualStyleBackColor = true;
      this.CheckBox_DeleteItem.Appearance = Appearance.Button;
      this.CheckBox_DeleteItem.AutoSize = true;
      this.CheckBox_DeleteItem.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.CheckBox_DeleteItem.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.CheckBox_DeleteItem.FlatStyle = FlatStyle.Flat;
      this.CheckBox_DeleteItem.Image = (Image) componentResourceManager.GetObject("CheckBox_DeleteItem.Image");
      this.CheckBox_DeleteItem.Location = new Point(6, 6);
      this.CheckBox_DeleteItem.Name = "CheckBox_DeleteItem";
      this.CheckBox_DeleteItem.Size = new Size(33, 33);
      this.CheckBox_DeleteItem.TabIndex = 212;
      this.CheckBox_DeleteItem.Text = "     ";
      this.CheckBox_DeleteItem.UseVisualStyleBackColor = true;
      this.CheckBox_NotDeleteOrder.Appearance = Appearance.Button;
      this.CheckBox_NotDeleteOrder.AutoSize = true;
      this.CheckBox_NotDeleteOrder.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.CheckBox_NotDeleteOrder.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.CheckBox_NotDeleteOrder.FlatStyle = FlatStyle.Flat;
      this.CheckBox_NotDeleteOrder.Image = (Image) componentResourceManager.GetObject("CheckBox_NotDeleteOrder.Image");
      this.CheckBox_NotDeleteOrder.Location = new Point(49, 122);
      this.CheckBox_NotDeleteOrder.Name = "CheckBox_NotDeleteOrder";
      this.CheckBox_NotDeleteOrder.Size = new Size(33, 33);
      this.CheckBox_NotDeleteOrder.TabIndex = 223;
      this.CheckBox_NotDeleteOrder.Text = "     ";
      this.CheckBox_NotDeleteOrder.UseVisualStyleBackColor = true;
      this.Label9.AutoSize = true;
      this.Label9.BackColor = Color.Transparent;
      this.Label9.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label9.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label9.Location = new Point(96, 15);
      this.Label9.Name = "Label9";
      this.Label9.Size = new Size(228, 16);
      this.Label9.TabIndex = 210;
      this.Label9.Text = "¿Exigir Observación al Eliminar Item?";
      this.Label17.AutoSize = true;
      this.Label17.BackColor = Color.Transparent;
      this.Label17.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label17.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label17.Location = new Point(96, 131);
      this.Label17.Name = "Label17";
      this.Label17.Size = new Size(217, 16);
      this.Label17.TabIndex = 222;
      this.Label17.Text = "¿Exigir Usuario al Eliminar Pedido?";
      this.CheckBox_NotDeleteItem.Appearance = Appearance.Button;
      this.CheckBox_NotDeleteItem.AutoSize = true;
      this.CheckBox_NotDeleteItem.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.CheckBox_NotDeleteItem.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.CheckBox_NotDeleteItem.FlatStyle = FlatStyle.Flat;
      this.CheckBox_NotDeleteItem.Image = (Image) componentResourceManager.GetObject("CheckBox_NotDeleteItem.Image");
      this.CheckBox_NotDeleteItem.Location = new Point(49, 6);
      this.CheckBox_NotDeleteItem.Name = "CheckBox_NotDeleteItem";
      this.CheckBox_NotDeleteItem.Size = new Size(33, 33);
      this.CheckBox_NotDeleteItem.TabIndex = 211;
      this.CheckBox_NotDeleteItem.Text = "     ";
      this.CheckBox_NotDeleteItem.UseVisualStyleBackColor = true;
      this.CheckBox_DocuIntern.Appearance = Appearance.Button;
      this.CheckBox_DocuIntern.AutoSize = true;
      this.CheckBox_DocuIntern.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.CheckBox_DocuIntern.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.CheckBox_DocuIntern.FlatStyle = FlatStyle.Flat;
      this.CheckBox_DocuIntern.Image = (Image) componentResourceManager.GetObject("CheckBox_DocuIntern.Image");
      this.CheckBox_DocuIntern.Location = new Point(6, 93);
      this.CheckBox_DocuIntern.Name = "CheckBox_DocuIntern";
      this.CheckBox_DocuIntern.Size = new Size(33, 33);
      this.CheckBox_DocuIntern.TabIndex = 221;
      this.CheckBox_DocuIntern.Text = "     ";
      this.CheckBox_DocuIntern.UseVisualStyleBackColor = true;
      this.Label10.AutoSize = true;
      this.Label10.BackColor = Color.Transparent;
      this.Label10.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label10.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label10.Location = new Point(96, 43);
      this.Label10.Name = "Label10";
      this.Label10.Size = new Size(242, 16);
      this.Label10.TabIndex = 213;
      this.Label10.Text = "¿Exigir Usuario al Eliminar Documento?";
      this.CheckBox_NotDocuIntern.Appearance = Appearance.Button;
      this.CheckBox_NotDocuIntern.AutoSize = true;
      this.CheckBox_NotDocuIntern.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.CheckBox_NotDocuIntern.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.CheckBox_NotDocuIntern.FlatStyle = FlatStyle.Flat;
      this.CheckBox_NotDocuIntern.Image = (Image) componentResourceManager.GetObject("CheckBox_NotDocuIntern.Image");
      this.CheckBox_NotDocuIntern.Location = new Point(49, 93);
      this.CheckBox_NotDocuIntern.Name = "CheckBox_NotDocuIntern";
      this.CheckBox_NotDocuIntern.Size = new Size(33, 33);
      this.CheckBox_NotDocuIntern.TabIndex = 220;
      this.CheckBox_NotDocuIntern.Text = "     ";
      this.CheckBox_NotDocuIntern.UseVisualStyleBackColor = true;
      this.CheckBox_NotDeleteDocument.Appearance = Appearance.Button;
      this.CheckBox_NotDeleteDocument.AutoSize = true;
      this.CheckBox_NotDeleteDocument.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.CheckBox_NotDeleteDocument.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.CheckBox_NotDeleteDocument.FlatStyle = FlatStyle.Flat;
      this.CheckBox_NotDeleteDocument.Image = (Image) componentResourceManager.GetObject("CheckBox_NotDeleteDocument.Image");
      this.CheckBox_NotDeleteDocument.Location = new Point(49, 35);
      this.CheckBox_NotDeleteDocument.Name = "CheckBox_NotDeleteDocument";
      this.CheckBox_NotDeleteDocument.Size = new Size(33, 33);
      this.CheckBox_NotDeleteDocument.TabIndex = 214;
      this.CheckBox_NotDeleteDocument.Text = "     ";
      this.CheckBox_NotDeleteDocument.UseVisualStyleBackColor = true;
      this.Label15.AutoSize = true;
      this.Label15.BackColor = Color.Transparent;
      this.Label15.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label15.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label15.Location = new Point(96, 102);
      this.Label15.Name = "Label15";
      this.Label15.Size = new Size(245, 16);
      this.Label15.TabIndex = 219;
      this.Label15.Text = "¿Exigir Usuario al Generar Doc. Interno?";
      this.CheckBox_DeleteDocument.Appearance = Appearance.Button;
      this.CheckBox_DeleteDocument.AutoSize = true;
      this.CheckBox_DeleteDocument.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.CheckBox_DeleteDocument.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.CheckBox_DeleteDocument.FlatStyle = FlatStyle.Flat;
      this.CheckBox_DeleteDocument.Image = (Image) componentResourceManager.GetObject("CheckBox_DeleteDocument.Image");
      this.CheckBox_DeleteDocument.Location = new Point(6, 35);
      this.CheckBox_DeleteDocument.Name = "CheckBox_DeleteDocument";
      this.CheckBox_DeleteDocument.Size = new Size(33, 33);
      this.CheckBox_DeleteDocument.TabIndex = 215;
      this.CheckBox_DeleteDocument.Text = "     ";
      this.CheckBox_DeleteDocument.UseVisualStyleBackColor = true;
      this.CheckBox_ChangePrice.Appearance = Appearance.Button;
      this.CheckBox_ChangePrice.AutoSize = true;
      this.CheckBox_ChangePrice.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.CheckBox_ChangePrice.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.CheckBox_ChangePrice.FlatStyle = FlatStyle.Flat;
      this.CheckBox_ChangePrice.Image = (Image) componentResourceManager.GetObject("CheckBox_ChangePrice.Image");
      this.CheckBox_ChangePrice.Location = new Point(6, 64);
      this.CheckBox_ChangePrice.Name = "CheckBox_ChangePrice";
      this.CheckBox_ChangePrice.Size = new Size(33, 33);
      this.CheckBox_ChangePrice.TabIndex = 218;
      this.CheckBox_ChangePrice.Text = "     ";
      this.CheckBox_ChangePrice.UseVisualStyleBackColor = true;
      this.Label11.AutoSize = true;
      this.Label11.BackColor = Color.Transparent;
      this.Label11.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label11.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label11.Location = new Point(96, 72);
      this.Label11.Name = "Label11";
      this.Label11.Size = new Size(332, 16);
      this.Label11.TabIndex = 216;
      this.Label11.Text = "¿Exigir Usuario al Cambiar Precio, Dscto. y Recargos?";
      this.CheckBox_NotChangePrice.Appearance = Appearance.Button;
      this.CheckBox_NotChangePrice.AutoSize = true;
      this.CheckBox_NotChangePrice.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.CheckBox_NotChangePrice.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.CheckBox_NotChangePrice.FlatStyle = FlatStyle.Flat;
      this.CheckBox_NotChangePrice.Image = (Image) componentResourceManager.GetObject("CheckBox_NotChangePrice.Image");
      this.CheckBox_NotChangePrice.Location = new Point(49, 64);
      this.CheckBox_NotChangePrice.Name = "CheckBox_NotChangePrice";
      this.CheckBox_NotChangePrice.Size = new Size(33, 33);
      this.CheckBox_NotChangePrice.TabIndex = 217;
      this.CheckBox_NotChangePrice.Text = "     ";
      this.CheckBox_NotChangePrice.UseVisualStyleBackColor = true;
      this.tpgMensajes.Controls.Add((Control) this.Label37);
      this.tpgMensajes.Controls.Add((Control) this.CheckBox_MensajeTNS_True);
      this.tpgMensajes.Controls.Add((Control) this.CheckBox_MensajeTNS_False);
      this.tpgMensajes.Controls.Add((Control) this.TextBox_MensajePrecuenta);
      this.tpgMensajes.Controls.Add((Control) this.Label36);
      this.tpgMensajes.Location = new Point(4, 25);
      this.tpgMensajes.Name = "tpgMensajes";
      this.tpgMensajes.Size = new Size(657, 516);
      this.tpgMensajes.TabIndex = 3;
      this.tpgMensajes.Text = "Mensajes";
      this.tpgMensajes.UseVisualStyleBackColor = true;
      this.Label37.AutoSize = true;
      this.Label37.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label37.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label37.Location = new Point(102, 84);
      this.Label37.Name = "Label37";
      this.Label37.Size = new Size(139, 16);
      this.Label37.TabIndex = 491;
      this.Label37.Text = "Mostrar Mensaje TNS";
      this.CheckBox_MensajeTNS_True.Appearance = Appearance.Button;
      this.CheckBox_MensajeTNS_True.AutoSize = true;
      this.CheckBox_MensajeTNS_True.Checked = true;
      this.CheckBox_MensajeTNS_True.CheckState = CheckState.Checked;
      this.CheckBox_MensajeTNS_True.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.CheckBox_MensajeTNS_True.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.CheckBox_MensajeTNS_True.FlatStyle = FlatStyle.Flat;
      this.CheckBox_MensajeTNS_True.Image = (Image) TriNetRestPOS.My.Resources.Resources.check_2;
      this.CheckBox_MensajeTNS_True.Location = new Point(5, 76);
      this.CheckBox_MensajeTNS_True.Name = "CheckBox_MensajeTNS_True";
      this.CheckBox_MensajeTNS_True.Size = new Size(33, 33);
      this.CheckBox_MensajeTNS_True.TabIndex = 490;
      this.CheckBox_MensajeTNS_True.Text = "     ";
      this.CheckBox_MensajeTNS_True.UseVisualStyleBackColor = true;
      this.CheckBox_MensajeTNS_False.Appearance = Appearance.Button;
      this.CheckBox_MensajeTNS_False.AutoSize = true;
      this.CheckBox_MensajeTNS_False.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.CheckBox_MensajeTNS_False.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.CheckBox_MensajeTNS_False.FlatStyle = FlatStyle.Flat;
      this.CheckBox_MensajeTNS_False.Image = (Image) TriNetRestPOS.My.Resources.Resources.check_3;
      this.CheckBox_MensajeTNS_False.Location = new Point(48, 76);
      this.CheckBox_MensajeTNS_False.Name = "CheckBox_MensajeTNS_False";
      this.CheckBox_MensajeTNS_False.Size = new Size(33, 33);
      this.CheckBox_MensajeTNS_False.TabIndex = 489;
      this.CheckBox_MensajeTNS_False.Text = "     ";
      this.CheckBox_MensajeTNS_False.UseVisualStyleBackColor = true;
      this.TextBox_MensajePrecuenta.AcceptsTab = true;
      this.TextBox_MensajePrecuenta.BackColor = Color.White;
      this.TextBox_MensajePrecuenta.BorderStyle = BorderStyle.FixedSingle;
      this.TextBox_MensajePrecuenta.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.TextBox_MensajePrecuenta.ForeColor = Color.FromArgb(150, 150, 150);
      this.TextBox_MensajePrecuenta.Location = new Point(284, 13);
      this.TextBox_MensajePrecuenta.MaxLength = 50;
      this.TextBox_MensajePrecuenta.Multiline = true;
      this.TextBox_MensajePrecuenta.Name = "TextBox_MensajePrecuenta";
      this.TextBox_MensajePrecuenta.Size = new Size(339, 48);
      this.TextBox_MensajePrecuenta.TabIndex = 488;
      this.TextBox_MensajePrecuenta.TextAlign = HorizontalAlignment.Center;
      this.Label36.AutoSize = true;
      this.Label36.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label36.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label36.Location = new Point(103, 17);
      this.Label36.Name = "Label36";
      this.Label36.Size = new Size(145, 16);
      this.Label36.TabIndex = 487;
      this.Label36.Text = "Mensaje en Precuenta:";
      this.tpgMonitor.Controls.Add((Control) this.Label39);
      this.tpgMonitor.Controls.Add((Control) this.txtTiempoAlertaMonitor);
      this.tpgMonitor.Controls.Add((Control) this.Label40);
      this.tpgMonitor.Controls.Add((Control) this.Label42);
      this.tpgMonitor.Controls.Add((Control) this.Label47);
      this.tpgMonitor.Controls.Add((Control) this.txtTiempoEsperaMonitor);
      this.tpgMonitor.Controls.Add((Control) this.Label44);
      this.tpgMonitor.Controls.Add((Control) this.Label41);
      this.tpgMonitor.Controls.Add((Control) this.chbEsMonitorNo);
      this.tpgMonitor.Controls.Add((Control) this.chbEsMonitor);
      this.tpgMonitor.Controls.Add((Control) this.Label38);
      this.tpgMonitor.Location = new Point(4, 25);
      this.tpgMonitor.Name = "tpgMonitor";
      this.tpgMonitor.Size = new Size(657, 516);
      this.tpgMonitor.TabIndex = 4;
      this.tpgMonitor.Text = "Monitor";
      this.tpgMonitor.UseVisualStyleBackColor = true;
      this.Label39.AutoSize = true;
      this.Label39.BackColor = Color.Transparent;
      this.Label39.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label39.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label39.Location = new Point(252, 79);
      this.Label39.Name = "Label39";
      this.Label39.Size = new Size(47, 16);
      this.Label39.TabIndex = 509;
      this.Label39.Text = "min(s).";
      this.txtTiempoAlertaMonitor.set_AllowSpace(false);
      ((TextBoxBase) this.txtTiempoAlertaMonitor).BackColor = SystemColors.Window;
      ((TextBoxBase) this.txtTiempoAlertaMonitor).BorderStyle = BorderStyle.FixedSingle;
      ((Control) this.txtTiempoAlertaMonitor).Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      ((TextBoxBase) this.txtTiempoAlertaMonitor).ForeColor = Color.Black;
      ((Control) this.txtTiempoAlertaMonitor).Location = new Point(144, 76);
      ((Control) this.txtTiempoAlertaMonitor).Name = "txtTiempoAlertaMonitor";
      ((Control) this.txtTiempoAlertaMonitor).Size = new Size(100, 22);
      ((Control) this.txtTiempoAlertaMonitor).TabIndex = 3;
      ((TextBox) this.txtTiempoAlertaMonitor).Text = "0";
      ((TextBox) this.txtTiempoAlertaMonitor).TextAlign = HorizontalAlignment.Center;
      this.Label40.AutoSize = true;
      this.Label40.BackColor = Color.Transparent;
      this.Label40.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label40.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label40.Location = new Point(122, 79);
      this.Label40.Name = "Label40";
      this.Label40.Size = new Size(11, 16);
      this.Label40.TabIndex = 508;
      this.Label40.Text = ":";
      this.Label42.AutoSize = true;
      this.Label42.BackColor = Color.Transparent;
      this.Label42.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label42.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label42.Location = new Point(3, 79);
      this.Label42.Name = "Label42";
      this.Label42.Size = new Size(101, 16);
      this.Label42.TabIndex = 507;
      this.Label42.Text = "Alerta roja a los";
      this.Label47.AutoSize = true;
      this.Label47.BackColor = Color.Transparent;
      this.Label47.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label47.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label47.Location = new Point(252, 44);
      this.Label47.Name = "Label47";
      this.Label47.Size = new Size(49, 16);
      this.Label47.TabIndex = 505;
      this.Label47.Text = "seg(s).";
      this.txtTiempoEsperaMonitor.set_AllowSpace(false);
      ((TextBoxBase) this.txtTiempoEsperaMonitor).BackColor = SystemColors.Window;
      ((TextBoxBase) this.txtTiempoEsperaMonitor).BorderStyle = BorderStyle.FixedSingle;
      ((Control) this.txtTiempoEsperaMonitor).Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      ((TextBoxBase) this.txtTiempoEsperaMonitor).ForeColor = Color.Black;
      ((Control) this.txtTiempoEsperaMonitor).Location = new Point(144, 41);
      ((Control) this.txtTiempoEsperaMonitor).Name = "txtTiempoEsperaMonitor";
      ((Control) this.txtTiempoEsperaMonitor).Size = new Size(100, 22);
      ((Control) this.txtTiempoEsperaMonitor).TabIndex = 2;
      ((TextBox) this.txtTiempoEsperaMonitor).Text = "0";
      ((TextBox) this.txtTiempoEsperaMonitor).TextAlign = HorizontalAlignment.Center;
      this.Label44.AutoSize = true;
      this.Label44.BackColor = Color.Transparent;
      this.Label44.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label44.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label44.Location = new Point(122, 44);
      this.Label44.Name = "Label44";
      this.Label44.Size = new Size(11, 16);
      this.Label44.TabIndex = 504;
      this.Label44.Text = ":";
      this.Label41.AutoSize = true;
      this.Label41.BackColor = Color.Transparent;
      this.Label41.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label41.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label41.Location = new Point(3, 44);
      this.Label41.Name = "Label41";
      this.Label41.Size = new Size(100, 16);
      this.Label41.TabIndex = 503;
      this.Label41.Text = "Actualizar cada";
      this.chbEsMonitorNo.Appearance = Appearance.Button;
      this.chbEsMonitorNo.AutoSize = true;
      this.chbEsMonitorNo.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.chbEsMonitorNo.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.chbEsMonitorNo.FlatStyle = FlatStyle.Flat;
      this.chbEsMonitorNo.Image = (Image) TriNetRestPOS.My.Resources.Resources.check_3;
      this.chbEsMonitorNo.Location = new Point(49, 6);
      this.chbEsMonitorNo.Name = "chbEsMonitorNo";
      this.chbEsMonitorNo.Size = new Size(33, 33);
      this.chbEsMonitorNo.TabIndex = 1;
      this.chbEsMonitorNo.Text = "     ";
      this.chbEsMonitorNo.UseVisualStyleBackColor = true;
      this.chbEsMonitor.Appearance = Appearance.Button;
      this.chbEsMonitor.AutoSize = true;
      this.chbEsMonitor.Checked = true;
      this.chbEsMonitor.CheckState = CheckState.Checked;
      this.chbEsMonitor.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.chbEsMonitor.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.chbEsMonitor.FlatStyle = FlatStyle.Flat;
      this.chbEsMonitor.Image = (Image) TriNetRestPOS.My.Resources.Resources.check_2;
      this.chbEsMonitor.Location = new Point(6, 6);
      this.chbEsMonitor.Name = "chbEsMonitor";
      this.chbEsMonitor.Size = new Size(33, 33);
      this.chbEsMonitor.TabIndex = 0;
      this.chbEsMonitor.Text = "     ";
      this.chbEsMonitor.UseVisualStyleBackColor = true;
      this.Label38.AutoSize = true;
      this.Label38.BackColor = Color.Transparent;
      this.Label38.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label38.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label38.Location = new Point(96, 9);
      this.Label38.Name = "Label38";
      this.Label38.Size = new Size(85, 16);
      this.Label38.TabIndex = 499;
      this.Label38.Text = "¿Es Monitor?";
      this.lblTiempoEsperaDelivery.AutoSize = true;
      this.lblTiempoEsperaDelivery.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblTiempoEsperaDelivery.ForeColor = Color.FromArgb(150, 150, 150);
      this.lblTiempoEsperaDelivery.Location = new Point(662, 564);
      this.lblTiempoEsperaDelivery.Name = "lblTiempoEsperaDelivery";
      this.lblTiempoEsperaDelivery.Size = new Size(199, 16);
      this.lblTiempoEsperaDelivery.TabIndex = 485;
      this.lblTiempoEsperaDelivery.Text = "Tiempo para Alerta de Delivery:";
      this.TextBox_PrinterTicketId.BackColor = Color.FromArgb((int) byte.MaxValue, 240, 144);
      this.TextBox_PrinterTicketId.Font = new Font("Verdana", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.TextBox_PrinterTicketId.ForeColor = Color.Red;
      this.TextBox_PrinterTicketId.Location = new Point(456, 665);
      this.TextBox_PrinterTicketId.Name = "TextBox_PrinterTicketId";
      this.TextBox_PrinterTicketId.Size = new Size(14, 22);
      this.TextBox_PrinterTicketId.TabIndex = 439;
      this.TextBox_PrinterTicketId.Visible = false;
      this.Button_CantLineComFooter.BackgroundImage = (Image) componentResourceManager.GetObject("Button_CantLineComFooter.BackgroundImage");
      this.Button_CantLineComFooter.FlatStyle = FlatStyle.Flat;
      this.Button_CantLineComFooter.Font = new Font("Trebuchet MS", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_CantLineComFooter.ForeColor = Color.WhiteSmoke;
      this.Button_CantLineComFooter.Location = new Point(269, 627);
      this.Button_CantLineComFooter.Name = "Button_CantLineComFooter";
      this.Button_CantLineComFooter.RightToLeft = RightToLeft.Yes;
      this.Button_CantLineComFooter.Size = new Size(62, 52);
      this.Button_CantLineComFooter.TabIndex = 448;
      this.Button_CantLineComFooter.TextAlign = ContentAlignment.TopCenter;
      this.Button_CantLineComFooter.TextImageRelation = TextImageRelation.TextAboveImage;
      this.Button_CantLineComFooter.UseVisualStyleBackColor = true;
      this.Button_CfgPreBill.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.conf_boton;
      this.Button_CfgPreBill.FlatStyle = FlatStyle.Flat;
      this.Button_CfgPreBill.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button_CfgPreBill.ForeColor = Color.WhiteSmoke;
      this.Button_CfgPreBill.Image = (Image) TriNetRestPOS.My.Resources.Resources.precuenta_icono;
      this.Button_CfgPreBill.ImageAlign = ContentAlignment.TopCenter;
      this.Button_CfgPreBill.Location = new Point(517, 617);
      this.Button_CfgPreBill.Name = "Button_CfgPreBill";
      this.Button_CfgPreBill.Padding = new Padding(0, 5, 0, 5);
      this.Button_CfgPreBill.Size = new Size(102, 66);
      this.Button_CfgPreBill.TabIndex = 191;
      this.Button_CfgPreBill.Text = "Conf. Precue";
      this.Button_CfgPreBill.TextAlign = ContentAlignment.BottomCenter;
      this.Button_CfgPreBill.UseVisualStyleBackColor = true;
      this.TextBox_PrinterInvoiceId.BackColor = Color.FromArgb((int) byte.MaxValue, 240, 144);
      this.TextBox_PrinterInvoiceId.Font = new Font("Verdana", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.TextBox_PrinterInvoiceId.ForeColor = Color.Red;
      this.TextBox_PrinterInvoiceId.Location = new Point(442, 665);
      this.TextBox_PrinterInvoiceId.Name = "TextBox_PrinterInvoiceId";
      this.TextBox_PrinterInvoiceId.Size = new Size(14, 22);
      this.TextBox_PrinterInvoiceId.TabIndex = 438;
      this.TextBox_PrinterInvoiceId.Visible = false;
      this.Button_GoOut.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.BotonRojo;
      this.Button_GoOut.FlatStyle = FlatStyle.Flat;
      this.Button_GoOut.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button_GoOut.ForeColor = Color.WhiteSmoke;
      this.Button_GoOut.Image = (Image) TriNetRestPOS.My.Resources.Resources.salir;
      this.Button_GoOut.ImageAlign = ContentAlignment.TopCenter;
      this.Button_GoOut.Location = new Point(889, 617);
      this.Button_GoOut.Name = "Button_GoOut";
      this.Button_GoOut.Padding = new Padding(0, 5, 0, 5);
      this.Button_GoOut.Size = new Size(114, 60);
      this.Button_GoOut.TabIndex = 189;
      this.Button_GoOut.Text = "Salir";
      this.Button_GoOut.TextAlign = ContentAlignment.BottomCenter;
      this.Button_GoOut.UseVisualStyleBackColor = true;
      this.TextBox_CantLineComFooter.AcceptsTab = true;
      this.TextBox_CantLineComFooter.BackColor = Color.LightGray;
      this.TextBox_CantLineComFooter.BorderStyle = BorderStyle.FixedSingle;
      this.TextBox_CantLineComFooter.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.TextBox_CantLineComFooter.ForeColor = Color.FromArgb(150, 150, 150);
      this.TextBox_CantLineComFooter.Location = new Point(10, 658);
      this.TextBox_CantLineComFooter.MaxLength = 10;
      this.TextBox_CantLineComFooter.Multiline = true;
      this.TextBox_CantLineComFooter.Name = "TextBox_CantLineComFooter";
      this.TextBox_CantLineComFooter.Size = new Size(97, 20);
      this.TextBox_CantLineComFooter.TabIndex = 447;
      this.TextBox_CantLineComFooter.TextAlign = HorizontalAlignment.Center;
      this.Button_Save.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.BotonVerde;
      this.Button_Save.FlatStyle = FlatStyle.Flat;
      this.Button_Save.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button_Save.ForeColor = Color.WhiteSmoke;
      this.Button_Save.Image = (Image) TriNetRestPOS.My.Resources.Resources.check_OK;
      this.Button_Save.ImageAlign = ContentAlignment.TopCenter;
      this.Button_Save.Location = new Point(769, 617);
      this.Button_Save.Name = "Button_Save";
      this.Button_Save.Padding = new Padding(0, 5, 0, 5);
      this.Button_Save.Size = new Size(119, 60);
      this.Button_Save.TabIndex = 1;
      this.Button_Save.Text = "Grabar";
      this.Button_Save.TextAlign = ContentAlignment.BottomCenter;
      this.Button_Save.UseVisualStyleBackColor = true;
      this.Label23.AutoSize = true;
      this.Label23.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label23.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label23.Location = new Point(6, 636);
      this.Label23.Name = "Label23";
      this.Label23.Size = new Size(176, 16);
      this.Label23.TabIndex = 446;
      this.Label23.Text = "Cant. Lineas - Pie Impresión:";
      this.TextBox_PrinterPrecountId.BackColor = Color.FromArgb((int) byte.MaxValue, 240, 144);
      this.TextBox_PrinterPrecountId.Font = new Font("Verdana", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.TextBox_PrinterPrecountId.ForeColor = Color.Red;
      this.TextBox_PrinterPrecountId.Location = new Point(428, 665);
      this.TextBox_PrinterPrecountId.Name = "TextBox_PrinterPrecountId";
      this.TextBox_PrinterPrecountId.Size = new Size(14, 22);
      this.TextBox_PrinterPrecountId.TabIndex = 437;
      this.TextBox_PrinterPrecountId.Visible = false;
      this.Button_CantLineComHeader.BackgroundImage = (Image) componentResourceManager.GetObject("Button_CantLineComHeader.BackgroundImage");
      this.Button_CantLineComHeader.FlatStyle = FlatStyle.Flat;
      this.Button_CantLineComHeader.Font = new Font("Trebuchet MS", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_CantLineComHeader.ForeColor = Color.WhiteSmoke;
      this.Button_CantLineComHeader.Location = new Point(269, 570);
      this.Button_CantLineComHeader.Name = "Button_CantLineComHeader";
      this.Button_CantLineComHeader.RightToLeft = RightToLeft.Yes;
      this.Button_CantLineComHeader.Size = new Size(62, 52);
      this.Button_CantLineComHeader.TabIndex = 445;
      this.Button_CantLineComHeader.TextAlign = ContentAlignment.TopCenter;
      this.Button_CantLineComHeader.TextImageRelation = TextImageRelation.TextAboveImage;
      this.Button_CantLineComHeader.UseVisualStyleBackColor = true;
      this.TextBox_CantLineComHeader.AcceptsTab = true;
      this.TextBox_CantLineComHeader.BackColor = Color.LightGray;
      this.TextBox_CantLineComHeader.BorderStyle = BorderStyle.FixedSingle;
      this.TextBox_CantLineComHeader.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.TextBox_CantLineComHeader.ForeColor = Color.FromArgb(150, 150, 150);
      this.TextBox_CantLineComHeader.Location = new Point(10, 601);
      this.TextBox_CantLineComHeader.MaxLength = 10;
      this.TextBox_CantLineComHeader.Multiline = true;
      this.TextBox_CantLineComHeader.Name = "TextBox_CantLineComHeader";
      this.TextBox_CantLineComHeader.Size = new Size(97, 20);
      this.TextBox_CantLineComHeader.TabIndex = 444;
      this.TextBox_CantLineComHeader.TextAlign = HorizontalAlignment.Center;
      this.Label22.AutoSize = true;
      this.Label22.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label22.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label22.Location = new Point(6, 579);
      this.Label22.Name = "Label22";
      this.Label22.Size = new Size(216, 16);
      this.Label22.TabIndex = 443;
      this.Label22.Text = "Cant. Lineas - Cabecera Impresión:";
      this.Label13.AutoSize = true;
      this.Label13.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label13.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label13.Location = new Point(6, 125);
      this.Label13.Name = "Label13";
      this.Label13.Size = new Size(174, 16);
      this.Label13.TabIndex = 433;
      this.Label13.Text = "Emite Documentos [Boleta]:";
      this.TextBox_ForTicket.BackColor = Color.LightGray;
      this.TextBox_ForTicket.BorderStyle = BorderStyle.FixedSingle;
      this.TextBox_ForTicket.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.TextBox_ForTicket.ForeColor = Color.FromArgb(150, 150, 150);
      this.TextBox_ForTicket.Location = new Point(10, 147);
      this.TextBox_ForTicket.MaxLength = 100;
      this.TextBox_ForTicket.Multiline = true;
      this.TextBox_ForTicket.Name = "TextBox_ForTicket";
      this.TextBox_ForTicket.Size = new Size(250, 20);
      this.TextBox_ForTicket.TabIndex = 431;
      this.Button_PrinterForTicket.BackgroundImage = (Image) componentResourceManager.GetObject("Button_PrinterForTicket.BackgroundImage");
      this.Button_PrinterForTicket.FlatStyle = FlatStyle.Flat;
      this.Button_PrinterForTicket.Font = new Font("Trebuchet MS", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_PrinterForTicket.ForeColor = Color.WhiteSmoke;
      this.Button_PrinterForTicket.Image = (Image) componentResourceManager.GetObject("Button_PrinterForTicket.Image");
      this.Button_PrinterForTicket.Location = new Point(269, 133);
      this.Button_PrinterForTicket.Name = "Button_PrinterForTicket";
      this.Button_PrinterForTicket.Size = new Size(72, 65);
      this.Button_PrinterForTicket.TabIndex = 432;
      this.Button_PrinterForTicket.TextImageRelation = TextImageRelation.TextAboveImage;
      this.Button_PrinterForTicket.UseVisualStyleBackColor = true;
      this.btnAgregarSerieBoleta.BackgroundImage = (Image) componentResourceManager.GetObject("btnAgregarSerieBoleta.BackgroundImage");
      this.btnAgregarSerieBoleta.FlatStyle = FlatStyle.Flat;
      this.btnAgregarSerieBoleta.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnAgregarSerieBoleta.ForeColor = Color.WhiteSmoke;
      this.btnAgregarSerieBoleta.Location = new Point(269, 342);
      this.btnAgregarSerieBoleta.Name = "btnAgregarSerieBoleta";
      this.btnAgregarSerieBoleta.Size = new Size(45, 28);
      this.btnAgregarSerieBoleta.TabIndex = 429;
      this.btnAgregarSerieBoleta.TextImageRelation = TextImageRelation.TextAboveImage;
      this.btnAgregarSerieBoleta.UseVisualStyleBackColor = true;
      this.Label12.AutoSize = true;
      this.Label12.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label12.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label12.Location = new Point(6, 319);
      this.Label12.Name = "Label12";
      this.Label12.Size = new Size(110, 16);
      this.Label12.TabIndex = 430;
      this.Label12.Text = "Nro Serie Boleta:";
      this.Label5.AutoSize = true;
      this.Label5.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label5.ForeColor = Color.FromArgb(209, 102, 61);
      this.Label5.Location = new Point(122, 490);
      this.Label5.Name = "Label5";
      this.Label5.Size = new Size(63, 20);
      this.Label5.TabIndex = 427;
      this.Label5.Text = "Minutos";
      this.Button_Quantity.BackgroundImage = (Image) componentResourceManager.GetObject("Button_Quantity.BackgroundImage");
      this.Button_Quantity.FlatStyle = FlatStyle.Flat;
      this.Button_Quantity.Font = new Font("Trebuchet MS", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_Quantity.ForeColor = Color.WhiteSmoke;
      this.Button_Quantity.Location = new Point(269, 513);
      this.Button_Quantity.Name = "Button_Quantity";
      this.Button_Quantity.RightToLeft = RightToLeft.Yes;
      this.Button_Quantity.Size = new Size(62, 52);
      this.Button_Quantity.TabIndex = 426;
      this.Button_Quantity.TextAlign = ContentAlignment.TopCenter;
      this.Button_Quantity.TextImageRelation = TextImageRelation.TextAboveImage;
      this.Button_Quantity.UseVisualStyleBackColor = true;
      this.TextBox_QuantitytAlert.AcceptsTab = true;
      this.TextBox_QuantitytAlert.BackColor = Color.LightGray;
      this.TextBox_QuantitytAlert.BorderStyle = BorderStyle.FixedSingle;
      this.TextBox_QuantitytAlert.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.TextBox_QuantitytAlert.ForeColor = Color.FromArgb(150, 150, 150);
      this.TextBox_QuantitytAlert.Location = new Point(10, 544);
      this.TextBox_QuantitytAlert.MaxLength = 10;
      this.TextBox_QuantitytAlert.Multiline = true;
      this.TextBox_QuantitytAlert.Name = "TextBox_QuantitytAlert";
      this.TextBox_QuantitytAlert.Size = new Size(97, 20);
      this.TextBox_QuantitytAlert.TabIndex = 187;
      this.TextBox_QuantitytAlert.TextAlign = HorizontalAlignment.Center;
      this.Label4.AutoSize = true;
      this.Label4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label4.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label4.Location = new Point(6, 522);
      this.Label4.Name = "Label4";
      this.Label4.Size = new Size(213, 16);
      this.Label4.TabIndex = 186;
      this.Label4.Text = "Cant. Progra. para Alerta de Stock:";
      this.btnAgregarSerieFactura.BackgroundImage = (Image) componentResourceManager.GetObject("btnAgregarSerieFactura.BackgroundImage");
      this.btnAgregarSerieFactura.FlatStyle = FlatStyle.Flat;
      this.btnAgregarSerieFactura.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnAgregarSerieFactura.ForeColor = Color.WhiteSmoke;
      this.btnAgregarSerieFactura.Location = new Point(269, 202);
      this.btnAgregarSerieFactura.Name = "btnAgregarSerieFactura";
      this.btnAgregarSerieFactura.Size = new Size(45, 28);
      this.btnAgregarSerieFactura.TabIndex = 184;
      this.btnAgregarSerieFactura.TextImageRelation = TextImageRelation.TextAboveImage;
      this.btnAgregarSerieFactura.UseVisualStyleBackColor = true;
      this.Label_SocialReason.AutoSize = true;
      this.Label_SocialReason.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label_SocialReason.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label_SocialReason.Location = new Point(6, 11);
      this.Label_SocialReason.Name = "Label_SocialReason";
      this.Label_SocialReason.Size = new Size(84, 16);
      this.Label_SocialReason.TabIndex = 141;
      this.Label_SocialReason.Text = "Precuentera:";
      this.Label_CommercialReason.AutoSize = true;
      this.Label_CommercialReason.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label_CommercialReason.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label_CommercialReason.Location = new Point(6, 68);
      this.Label_CommercialReason.Name = "Label_CommercialReason";
      this.Label_CommercialReason.Size = new Size(180, 16);
      this.Label_CommercialReason.TabIndex = 143;
      this.Label_CommercialReason.Text = "Emite Documentos [Factura]:";
      this.Label1.AutoSize = true;
      this.Label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label1.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label1.Location = new Point(6, 179);
      this.Label1.Name = "Label1";
      this.Label1.Size = new Size(116, 16);
      this.Label1.TabIndex = 185;
      this.Label1.Text = "Nro Serie Factura:";
      this.TextBox_ForDocument.BackColor = Color.LightGray;
      this.TextBox_ForDocument.BorderStyle = BorderStyle.FixedSingle;
      this.TextBox_ForDocument.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.TextBox_ForDocument.ForeColor = Color.FromArgb(150, 150, 150);
      this.TextBox_ForDocument.Location = new Point(10, 90);
      this.TextBox_ForDocument.MaxLength = 100;
      this.TextBox_ForDocument.Multiline = true;
      this.TextBox_ForDocument.Name = "TextBox_ForDocument";
      this.TextBox_ForDocument.Size = new Size(250, 20);
      this.TextBox_ForDocument.TabIndex = 2;
      this.Button_TimeW.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.teclado_nueral;
      this.Button_TimeW.FlatStyle = FlatStyle.Flat;
      this.Button_TimeW.Font = new Font("Trebuchet MS", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_TimeW.ForeColor = Color.WhiteSmoke;
      this.Button_TimeW.Location = new Point(269, 458);
      this.Button_TimeW.Name = "Button_TimeW";
      this.Button_TimeW.Size = new Size(62, 52);
      this.Button_TimeW.TabIndex = 5;
      this.Button_TimeW.TextImageRelation = TextImageRelation.TextAboveImage;
      this.Button_TimeW.UseVisualStyleBackColor = true;
      this.TextBox_Printer.BackColor = Color.LightGray;
      this.TextBox_Printer.BorderStyle = BorderStyle.FixedSingle;
      this.TextBox_Printer.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.TextBox_Printer.ForeColor = Color.FromArgb(150, 150, 150);
      this.TextBox_Printer.Location = new Point(10, 33);
      this.TextBox_Printer.MaxLength = 100;
      this.TextBox_Printer.Multiline = true;
      this.TextBox_Printer.Name = "TextBox_Printer";
      this.TextBox_Printer.Size = new Size(250, 20);
      this.TextBox_Printer.TabIndex = 0;
      this.TextBox_Minutes.BackColor = Color.LightGray;
      this.TextBox_Minutes.BorderStyle = BorderStyle.FixedSingle;
      this.TextBox_Minutes.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.TextBox_Minutes.ForeColor = Color.FromArgb(150, 150, 150);
      this.TextBox_Minutes.Location = new Point(10, 487);
      this.TextBox_Minutes.MaxLength = 10;
      this.TextBox_Minutes.Multiline = true;
      this.TextBox_Minutes.Name = "TextBox_Minutes";
      this.TextBox_Minutes.Size = new Size(97, 20);
      this.TextBox_Minutes.TabIndex = 4;
      this.TextBox_Minutes.TextAlign = HorizontalAlignment.Center;
      this.Button_SearchPrinters.BackgroundImage = (Image) componentResourceManager.GetObject("Button_SearchPrinters.BackgroundImage");
      this.Button_SearchPrinters.FlatStyle = FlatStyle.Flat;
      this.Button_SearchPrinters.Font = new Font("Trebuchet MS", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_SearchPrinters.ForeColor = Color.WhiteSmoke;
      this.Button_SearchPrinters.Image = (Image) componentResourceManager.GetObject("Button_SearchPrinters.Image");
      this.Button_SearchPrinters.Location = new Point(269, 2);
      this.Button_SearchPrinters.Name = "Button_SearchPrinters";
      this.Button_SearchPrinters.Size = new Size(72, 65);
      this.Button_SearchPrinters.TabIndex = 1;
      this.Button_SearchPrinters.TextImageRelation = TextImageRelation.TextAboveImage;
      this.Button_SearchPrinters.UseVisualStyleBackColor = true;
      this.Label_TimeW.AutoSize = true;
      this.Label_TimeW.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label_TimeW.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label_TimeW.Location = new Point(6, 465);
      this.Label_TimeW.Name = "Label_TimeW";
      this.Label_TimeW.Size = new Size(208, 16);
      this.Label_TimeW.TabIndex = 182;
      this.Label_TimeW.Text = "Tiempo para Alerta de Reservas:";
      this.Button_PrinterForDocu.BackgroundImage = (Image) componentResourceManager.GetObject("Button_PrinterForDocu.BackgroundImage");
      this.Button_PrinterForDocu.FlatStyle = FlatStyle.Flat;
      this.Button_PrinterForDocu.Font = new Font("Trebuchet MS", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_PrinterForDocu.ForeColor = Color.WhiteSmoke;
      this.Button_PrinterForDocu.Image = (Image) componentResourceManager.GetObject("Button_PrinterForDocu.Image");
      this.Button_PrinterForDocu.Location = new Point(269, 66);
      this.Button_PrinterForDocu.Name = "Button_PrinterForDocu";
      this.Button_PrinterForDocu.Size = new Size(72, 65);
      this.Button_PrinterForDocu.TabIndex = 3;
      this.Button_PrinterForDocu.TextImageRelation = TextImageRelation.TextAboveImage;
      this.Button_PrinterForDocu.UseVisualStyleBackColor = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.Window;
      this.ClientSize = new Size(1010, 718);
      this.Controls.Add((Control) this.HeaderPanel_Variables);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (FrmCfgCaja);
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Configuración de Caja";
      ((Control) this.HeaderPanel_Variables).ResumeLayout(false);
      ((Control) this.HeaderPanel_Variables).PerformLayout();
      ((ISupportInitialize) this.dgvNumeroSerieBoleta).EndInit();
      ((ISupportInitialize) this.dgvNumeroSerieFactura).EndInit();
      this.tbcVariables.ResumeLayout(false);
      this.tpgPrincipal.ResumeLayout(false);
      this.tpgPrincipal.PerformLayout();
      this.tpgConfirmacion.ResumeLayout(false);
      this.tpgConfirmacion.PerformLayout();
      this.tpgSeguridad.ResumeLayout(false);
      this.tpgSeguridad.PerformLayout();
      this.tpgMensajes.ResumeLayout(false);
      this.tpgMensajes.PerformLayout();
      this.tpgMonitor.ResumeLayout(false);
      this.tpgMonitor.PerformLayout();
      this.ResumeLayout(false);
    }

    internal virtual Button Button_TimeW
    {
      get
      {
        return this._Button_TimeW;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_TimeW_Click);
        Button buttonTimeW1 = this._Button_TimeW;
        if (buttonTimeW1 != null)
          buttonTimeW1.Click -= eventHandler;
        this._Button_TimeW = value;
        Button buttonTimeW2 = this._Button_TimeW;
        if (buttonTimeW2 == null)
          return;
        buttonTimeW2.Click += eventHandler;
      }
    }

    internal virtual TextBox TextBox_Minutes { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label_TimeW { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button_PrinterForDocu
    {
      get
      {
        return this._Button_PrinterForDocu;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_PrinterForDocu_Click);
        Button buttonPrinterForDocu1 = this._Button_PrinterForDocu;
        if (buttonPrinterForDocu1 != null)
          buttonPrinterForDocu1.Click -= eventHandler;
        this._Button_PrinterForDocu = value;
        Button buttonPrinterForDocu2 = this._Button_PrinterForDocu;
        if (buttonPrinterForDocu2 == null)
          return;
        buttonPrinterForDocu2.Click += eventHandler;
      }
    }

    internal virtual Button Button_SearchPrinters
    {
      get
      {
        return this._Button_SearchPrinters;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_SearchPrinters_Click);
        Button buttonSearchPrinters1 = this._Button_SearchPrinters;
        if (buttonSearchPrinters1 != null)
          buttonSearchPrinters1.Click -= eventHandler;
        this._Button_SearchPrinters = value;
        Button buttonSearchPrinters2 = this._Button_SearchPrinters;
        if (buttonSearchPrinters2 == null)
          return;
        buttonSearchPrinters2.Click += eventHandler;
      }
    }

    internal virtual Label Label_SocialReason { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBox_Printer { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBox_ForDocument { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label_CommercialReason { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button btnAgregarSerieFactura
    {
      get
      {
        return this._btnAgregarSerieFactura;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnAgregarSerieFactura_Click);
        Button agregarSerieFactura1 = this._btnAgregarSerieFactura;
        if (agregarSerieFactura1 != null)
          agregarSerieFactura1.Click -= eventHandler;
        this._btnAgregarSerieFactura = value;
        Button agregarSerieFactura2 = this._btnAgregarSerieFactura;
        if (agregarSerieFactura2 == null)
          return;
        agregarSerieFactura2.Click += eventHandler;
      }
    }

    internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button_Save
    {
      get
      {
        return this._Button_Save;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_Save_Click);
        Button buttonSave1 = this._Button_Save;
        if (buttonSave1 != null)
          buttonSave1.Click -= eventHandler;
        this._Button_Save = value;
        Button buttonSave2 = this._Button_Save;
        if (buttonSave2 == null)
          return;
        buttonSave2.Click += eventHandler;
      }
    }

    internal virtual HeaderPanel HeaderPanel_Variables { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBox_QuantitytAlert { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button_Quantity
    {
      get
      {
        return this._Button_Quantity;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_Quantity_Click);
        Button buttonQuantity1 = this._Button_Quantity;
        if (buttonQuantity1 != null)
          buttonQuantity1.Click -= eventHandler;
        this._Button_Quantity = value;
        Button buttonQuantity2 = this._Button_Quantity;
        if (buttonQuantity2 == null)
          return;
        buttonQuantity2.Click += eventHandler;
      }
    }

    internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

    internal virtual CheckBox CheckBox_DeleteItem
    {
      get
      {
        return this._CheckBox_DeleteItem;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBox_DeleteItem_CheckedChanged);
        CheckBox checkBoxDeleteItem1 = this._CheckBox_DeleteItem;
        if (checkBoxDeleteItem1 != null)
          checkBoxDeleteItem1.CheckedChanged -= eventHandler;
        this._CheckBox_DeleteItem = value;
        CheckBox checkBoxDeleteItem2 = this._CheckBox_DeleteItem;
        if (checkBoxDeleteItem2 == null)
          return;
        checkBoxDeleteItem2.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox CheckBox_NotDeleteItem
    {
      get
      {
        return this._CheckBox_NotDeleteItem;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBox_NotDeleteItem_CheckedChanged);
        CheckBox boxNotDeleteItem1 = this._CheckBox_NotDeleteItem;
        if (boxNotDeleteItem1 != null)
          boxNotDeleteItem1.CheckedChanged -= eventHandler;
        this._CheckBox_NotDeleteItem = value;
        CheckBox boxNotDeleteItem2 = this._CheckBox_NotDeleteItem;
        if (boxNotDeleteItem2 == null)
          return;
        boxNotDeleteItem2.CheckedChanged += eventHandler;
      }
    }

    internal virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBox_DeleteDocument
    {
      get
      {
        return this._CheckBox_DeleteDocument;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBox_DeleteDocument_CheckedChanged);
        CheckBox boxDeleteDocument1 = this._CheckBox_DeleteDocument;
        if (boxDeleteDocument1 != null)
          boxDeleteDocument1.CheckedChanged -= eventHandler;
        this._CheckBox_DeleteDocument = value;
        CheckBox boxDeleteDocument2 = this._CheckBox_DeleteDocument;
        if (boxDeleteDocument2 == null)
          return;
        boxDeleteDocument2.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox CheckBox_NotDeleteDocument
    {
      get
      {
        return this._CheckBox_NotDeleteDocument;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBox_NotDeleteDocument_CheckedChanged);
        CheckBox notDeleteDocument1 = this._CheckBox_NotDeleteDocument;
        if (notDeleteDocument1 != null)
          notDeleteDocument1.CheckedChanged -= eventHandler;
        this._CheckBox_NotDeleteDocument = value;
        CheckBox notDeleteDocument2 = this._CheckBox_NotDeleteDocument;
        if (notDeleteDocument2 == null)
          return;
        notDeleteDocument2.CheckedChanged += eventHandler;
      }
    }

    internal virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBox_ChangePrice
    {
      get
      {
        return this._CheckBox_ChangePrice;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBox_ChangePrice_CheckedChanged);
        CheckBox checkBoxChangePrice1 = this._CheckBox_ChangePrice;
        if (checkBoxChangePrice1 != null)
          checkBoxChangePrice1.CheckedChanged -= eventHandler;
        this._CheckBox_ChangePrice = value;
        CheckBox checkBoxChangePrice2 = this._CheckBox_ChangePrice;
        if (checkBoxChangePrice2 == null)
          return;
        checkBoxChangePrice2.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox CheckBox_NotChangePrice
    {
      get
      {
        return this._CheckBox_NotChangePrice;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBox_NotChangePrice_CheckedChanged);
        CheckBox boxNotChangePrice1 = this._CheckBox_NotChangePrice;
        if (boxNotChangePrice1 != null)
          boxNotChangePrice1.CheckedChanged -= eventHandler;
        this._CheckBox_NotChangePrice = value;
        CheckBox boxNotChangePrice2 = this._CheckBox_NotChangePrice;
        if (boxNotChangePrice2 == null)
          return;
        boxNotChangePrice2.CheckedChanged += eventHandler;
      }
    }

    internal virtual Button btnAgregarSerieBoleta
    {
      get
      {
        return this._btnAgregarSerieBoleta;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnAgregarSerieBoleta_Click);
        Button agregarSerieBoleta1 = this._btnAgregarSerieBoleta;
        if (agregarSerieBoleta1 != null)
          agregarSerieBoleta1.Click -= eventHandler;
        this._btnAgregarSerieBoleta = value;
        Button agregarSerieBoleta2 = this._btnAgregarSerieBoleta;
        if (agregarSerieBoleta2 == null)
          return;
        agregarSerieBoleta2.Click += eventHandler;
      }
    }

    internal virtual Label Label12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBox_ForTicket { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button_PrinterForTicket
    {
      get
      {
        return this._Button_PrinterForTicket;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_PrinterForTicket_Click);
        Button printerForTicket1 = this._Button_PrinterForTicket;
        if (printerForTicket1 != null)
          printerForTicket1.Click -= eventHandler;
        this._Button_PrinterForTicket = value;
        Button printerForTicket2 = this._Button_PrinterForTicket;
        if (printerForTicket2 == null)
          return;
        printerForTicket2.Click += eventHandler;
      }
    }

    internal virtual CheckBox CheckBox_DocuIntern
    {
      get
      {
        return this._CheckBox_DocuIntern;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBox_DocuIntern_CheckedChanged);
        CheckBox checkBoxDocuIntern1 = this._CheckBox_DocuIntern;
        if (checkBoxDocuIntern1 != null)
          checkBoxDocuIntern1.CheckedChanged -= eventHandler;
        this._CheckBox_DocuIntern = value;
        CheckBox checkBoxDocuIntern2 = this._CheckBox_DocuIntern;
        if (checkBoxDocuIntern2 == null)
          return;
        checkBoxDocuIntern2.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox CheckBox_NotDocuIntern
    {
      get
      {
        return this._CheckBox_NotDocuIntern;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBox_NotDocuIntern_CheckedChanged);
        CheckBox boxNotDocuIntern1 = this._CheckBox_NotDocuIntern;
        if (boxNotDocuIntern1 != null)
          boxNotDocuIntern1.CheckedChanged -= eventHandler;
        this._CheckBox_NotDocuIntern = value;
        CheckBox boxNotDocuIntern2 = this._CheckBox_NotDocuIntern;
        if (boxNotDocuIntern2 == null)
          return;
        boxNotDocuIntern2.CheckedChanged += eventHandler;
      }
    }

    internal virtual Label Label15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBox_DeleteOrder
    {
      get
      {
        return this._CheckBox_DeleteOrder;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBox_DeleteOrder_CheckedChanged);
        CheckBox checkBoxDeleteOrder1 = this._CheckBox_DeleteOrder;
        if (checkBoxDeleteOrder1 != null)
          checkBoxDeleteOrder1.CheckedChanged -= eventHandler;
        this._CheckBox_DeleteOrder = value;
        CheckBox checkBoxDeleteOrder2 = this._CheckBox_DeleteOrder;
        if (checkBoxDeleteOrder2 == null)
          return;
        checkBoxDeleteOrder2.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox CheckBox_NotDeleteOrder
    {
      get
      {
        return this._CheckBox_NotDeleteOrder;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBox_NotDeleteOrder_CheckedChanged);
        CheckBox boxNotDeleteOrder1 = this._CheckBox_NotDeleteOrder;
        if (boxNotDeleteOrder1 != null)
          boxNotDeleteOrder1.CheckedChanged -= eventHandler;
        this._CheckBox_NotDeleteOrder = value;
        CheckBox boxNotDeleteOrder2 = this._CheckBox_NotDeleteOrder;
        if (boxNotDeleteOrder2 == null)
          return;
        boxNotDeleteOrder2.CheckedChanged += eventHandler;
      }
    }

    internal virtual Label Label17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button_CfgPreBill
    {
      get
      {
        return this._Button_CfgPreBill;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_CfgPreBill_Click);
        Button buttonCfgPreBill1 = this._Button_CfgPreBill;
        if (buttonCfgPreBill1 != null)
          buttonCfgPreBill1.Click -= eventHandler;
        this._Button_CfgPreBill = value;
        Button buttonCfgPreBill2 = this._Button_CfgPreBill;
        if (buttonCfgPreBill2 == null)
          return;
        buttonCfgPreBill2.Click += eventHandler;
      }
    }

    internal virtual TextBox TextBox_PrinterPrecountId { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBox_PrinterInvoiceId { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBox_PrinterTicketId { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button_CfgDocument
    {
      get
      {
        return this._Button_CfgDocument;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_CfgDocument_Click);
        Button buttonCfgDocument1 = this._Button_CfgDocument;
        if (buttonCfgDocument1 != null)
          buttonCfgDocument1.Click -= eventHandler;
        this._Button_CfgDocument = value;
        Button buttonCfgDocument2 = this._Button_CfgDocument;
        if (buttonCfgDocument2 == null)
          return;
        buttonCfgDocument2.Click += eventHandler;
      }
    }

    internal virtual Button Button_AmountMin
    {
      get
      {
        return this._Button_AmountMin;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_AmountMin_Click);
        Button buttonAmountMin1 = this._Button_AmountMin;
        if (buttonAmountMin1 != null)
          buttonAmountMin1.Click -= eventHandler;
        this._Button_AmountMin = value;
        Button buttonAmountMin2 = this._Button_AmountMin;
        if (buttonAmountMin2 == null)
          return;
        buttonAmountMin2.Click += eventHandler;
      }
    }

    internal virtual TextBox TextBox_AmountMin { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label20 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button_CantLineComFooter
    {
      get
      {
        return this._Button_CantLineComFooter;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_CantLineComFooter_Click);
        Button cantLineComFooter1 = this._Button_CantLineComFooter;
        if (cantLineComFooter1 != null)
          cantLineComFooter1.Click -= eventHandler;
        this._Button_CantLineComFooter = value;
        Button cantLineComFooter2 = this._Button_CantLineComFooter;
        if (cantLineComFooter2 == null)
          return;
        cantLineComFooter2.Click += eventHandler;
      }
    }

    internal virtual TextBox TextBox_CantLineComFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label23 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button_CantLineComHeader
    {
      get
      {
        return this._Button_CantLineComHeader;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_CantLineComHeader_Click);
        Button cantLineComHeader1 = this._Button_CantLineComHeader;
        if (cantLineComHeader1 != null)
          cantLineComHeader1.Click -= eventHandler;
        this._Button_CantLineComHeader = value;
        Button cantLineComHeader2 = this._Button_CantLineComHeader;
        if (cantLineComHeader2 == null)
          return;
        cantLineComHeader2.Click += eventHandler;
      }
    }

    internal virtual TextBox TextBox_CantLineComHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label22 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label24 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox ComboBox_CantPrintCommand { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBox_IsNotWaiterShowSale
    {
      get
      {
        return this._CheckBox_IsNotWaiterShowSale;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBox_IsNotWaiterShowSale_CheckedChanged);
        CheckBox notWaiterShowSale1 = this._CheckBox_IsNotWaiterShowSale;
        if (notWaiterShowSale1 != null)
          notWaiterShowSale1.CheckedChanged -= eventHandler;
        this._CheckBox_IsNotWaiterShowSale = value;
        CheckBox notWaiterShowSale2 = this._CheckBox_IsNotWaiterShowSale;
        if (notWaiterShowSale2 == null)
          return;
        notWaiterShowSale2.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox CheckBox_IsWaiterShowSale
    {
      get
      {
        return this._CheckBox_IsWaiterShowSale;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBox_IsWaiterShowSale_CheckedChanged);
        CheckBox isWaiterShowSale1 = this._CheckBox_IsWaiterShowSale;
        if (isWaiterShowSale1 != null)
          isWaiterShowSale1.CheckedChanged -= eventHandler;
        this._CheckBox_IsWaiterShowSale = value;
        CheckBox isWaiterShowSale2 = this._CheckBox_IsWaiterShowSale;
        if (isWaiterShowSale2 == null)
          return;
        isWaiterShowSale2.CheckedChanged += eventHandler;
      }
    }

    internal virtual Label Label21 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBox_IsNotDobleCommand
    {
      get
      {
        return this._CheckBox_IsNotDobleCommand;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBox_IsNotDobleCommand_CheckedChanged);
        CheckBox isNotDobleCommand1 = this._CheckBox_IsNotDobleCommand;
        if (isNotDobleCommand1 != null)
          isNotDobleCommand1.CheckedChanged -= eventHandler;
        this._CheckBox_IsNotDobleCommand = value;
        CheckBox isNotDobleCommand2 = this._CheckBox_IsNotDobleCommand;
        if (isNotDobleCommand2 == null)
          return;
        isNotDobleCommand2.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox CheckBox_IsDobleCommand
    {
      get
      {
        return this._CheckBox_IsDobleCommand;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBox_IsDobleCommand_CheckedChanged);
        CheckBox boxIsDobleCommand1 = this._CheckBox_IsDobleCommand;
        if (boxIsDobleCommand1 != null)
          boxIsDobleCommand1.CheckedChanged -= eventHandler;
        this._CheckBox_IsDobleCommand = value;
        CheckBox boxIsDobleCommand2 = this._CheckBox_IsDobleCommand;
        if (boxIsDobleCommand2 == null)
          return;
        boxIsDobleCommand2.CheckedChanged += eventHandler;
      }
    }

    internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBox_IsNotFirstPay
    {
      get
      {
        return this._CheckBox_IsNotFirstPay;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBox_IsNotFirstPay_CheckedChanged);
        CheckBox boxIsNotFirstPay1 = this._CheckBox_IsNotFirstPay;
        if (boxIsNotFirstPay1 != null)
          boxIsNotFirstPay1.CheckedChanged -= eventHandler;
        this._CheckBox_IsNotFirstPay = value;
        CheckBox boxIsNotFirstPay2 = this._CheckBox_IsNotFirstPay;
        if (boxIsNotFirstPay2 == null)
          return;
        boxIsNotFirstPay2.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox CheckBox_IsFirstPay
    {
      get
      {
        return this._CheckBox_IsFirstPay;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBox_IsFirstPay_CheckedChanged);
        CheckBox checkBoxIsFirstPay1 = this._CheckBox_IsFirstPay;
        if (checkBoxIsFirstPay1 != null)
          checkBoxIsFirstPay1.CheckedChanged -= eventHandler;
        this._CheckBox_IsFirstPay = value;
        CheckBox checkBoxIsFirstPay2 = this._CheckBox_IsFirstPay;
        if (checkBoxIsFirstPay2 == null)
          return;
        checkBoxIsFirstPay2.CheckedChanged += eventHandler;
      }
    }

    internal virtual Label Label16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBox_IsNotPrintDeleteItem
    {
      get
      {
        return this._CheckBox_IsNotPrintDeleteItem;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBox_IsNotPrintDeleteItem_CheckedChanged);
        CheckBox notPrintDeleteItem1 = this._CheckBox_IsNotPrintDeleteItem;
        if (notPrintDeleteItem1 != null)
          notPrintDeleteItem1.CheckedChanged -= eventHandler;
        this._CheckBox_IsNotPrintDeleteItem = value;
        CheckBox notPrintDeleteItem2 = this._CheckBox_IsNotPrintDeleteItem;
        if (notPrintDeleteItem2 == null)
          return;
        notPrintDeleteItem2.CheckedChanged += eventHandler;
      }
    }

    internal virtual RadioButton RadioButton_Not { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBox_IsPrintDeleteItem
    {
      get
      {
        return this._CheckBox_IsPrintDeleteItem;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBox_IsPrintDeleteItem_CheckedChanged);
        CheckBox isPrintDeleteItem1 = this._CheckBox_IsPrintDeleteItem;
        if (isPrintDeleteItem1 != null)
          isPrintDeleteItem1.CheckedChanged -= eventHandler;
        this._CheckBox_IsPrintDeleteItem = value;
        CheckBox isPrintDeleteItem2 = this._CheckBox_IsPrintDeleteItem;
        if (isPrintDeleteItem2 == null)
          return;
        isPrintDeleteItem2.CheckedChanged += eventHandler;
      }
    }

    internal virtual RadioButton RadioButton_Yes { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBox_NotBarCode
    {
      get
      {
        return this._CheckBox_NotBarCode;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBox_NotBarCode_CheckedChanged);
        CheckBox checkBoxNotBarCode1 = this._CheckBox_NotBarCode;
        if (checkBoxNotBarCode1 != null)
          checkBoxNotBarCode1.CheckedChanged -= eventHandler;
        this._CheckBox_NotBarCode = value;
        CheckBox checkBoxNotBarCode2 = this._CheckBox_NotBarCode;
        if (checkBoxNotBarCode2 == null)
          return;
        checkBoxNotBarCode2.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox CheckBox_IsBarCode
    {
      get
      {
        return this._CheckBox_IsBarCode;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBox_IsBarCode_CheckedChanged);
        CheckBox checkBoxIsBarCode1 = this._CheckBox_IsBarCode;
        if (checkBoxIsBarCode1 != null)
          checkBoxIsBarCode1.CheckedChanged -= eventHandler;
        this._CheckBox_IsBarCode = value;
        CheckBox checkBoxIsBarCode2 = this._CheckBox_IsBarCode;
        if (checkBoxIsBarCode2 == null)
          return;
        checkBoxIsBarCode2.CheckedChanged += eventHandler;
      }
    }

    internal virtual Label Label14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBox_NotShowCommand
    {
      get
      {
        return this._CheckBox_NotShowCommand;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBox_ShowCommand_CheckedChanged);
        CheckBox boxNotShowCommand1 = this._CheckBox_NotShowCommand;
        if (boxNotShowCommand1 != null)
          boxNotShowCommand1.CheckedChanged -= eventHandler;
        this._CheckBox_NotShowCommand = value;
        CheckBox boxNotShowCommand2 = this._CheckBox_NotShowCommand;
        if (boxNotShowCommand2 == null)
          return;
        boxNotShowCommand2.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox CheckBox_ShowCommand
    {
      get
      {
        return this._CheckBox_ShowCommand;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBox_NotShowCommand_CheckedChanged);
        CheckBox checkBoxShowCommand1 = this._CheckBox_ShowCommand;
        if (checkBoxShowCommand1 != null)
          checkBoxShowCommand1.CheckedChanged -= eventHandler;
        this._CheckBox_ShowCommand = value;
        CheckBox checkBoxShowCommand2 = this._CheckBox_ShowCommand;
        if (checkBoxShowCommand2 == null)
          return;
        checkBoxShowCommand2.CheckedChanged += eventHandler;
      }
    }

    internal virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBoxShowNotConsume
    {
      get
      {
        return this._CheckBoxShowNotConsume;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBoxShowNotConsume_CheckedChanged);
        CheckBox boxShowNotConsume1 = this._CheckBoxShowNotConsume;
        if (boxShowNotConsume1 != null)
          boxShowNotConsume1.CheckedChanged -= eventHandler;
        this._CheckBoxShowNotConsume = value;
        CheckBox boxShowNotConsume2 = this._CheckBoxShowNotConsume;
        if (boxShowNotConsume2 == null)
          return;
        boxShowNotConsume2.CheckedChanged += eventHandler;
      }
    }

    internal virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBoxShowConsume
    {
      get
      {
        return this._CheckBoxShowConsume;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBoxShowConsume_CheckedChanged);
        CheckBox checkBoxShowConsume1 = this._CheckBoxShowConsume;
        if (checkBoxShowConsume1 != null)
          checkBoxShowConsume1.CheckedChanged -= eventHandler;
        this._CheckBoxShowConsume = value;
        CheckBox checkBoxShowConsume2 = this._CheckBoxShowConsume;
        if (checkBoxShowConsume2 == null)
          return;
        checkBoxShowConsume2.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox CheckBox_Matricial
    {
      get
      {
        return this._CheckBox_Matricial;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBox_Matricial_CheckedChanged);
        CheckBox checkBoxMatricial1 = this._CheckBox_Matricial;
        if (checkBoxMatricial1 != null)
          checkBoxMatricial1.CheckedChanged -= eventHandler;
        this._CheckBox_Matricial = value;
        CheckBox checkBoxMatricial2 = this._CheckBox_Matricial;
        if (checkBoxMatricial2 == null)
          return;
        checkBoxMatricial2.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox CheckBox_NotMatricial
    {
      get
      {
        return this._CheckBox_NotMatricial;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBox_NotMatricial_CheckedChanged);
        CheckBox checkBoxNotMatricial1 = this._CheckBox_NotMatricial;
        if (checkBoxNotMatricial1 != null)
          checkBoxNotMatricial1.CheckedChanged -= eventHandler;
        this._CheckBox_NotMatricial = value;
        CheckBox checkBoxNotMatricial2 = this._CheckBox_NotMatricial;
        if (checkBoxNotMatricial2 == null)
          return;
        checkBoxNotMatricial2.CheckedChanged += eventHandler;
      }
    }

    internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBox_BoxWaiter
    {
      get
      {
        return this._CheckBox_BoxWaiter;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBox_BoxWaiter_CheckedChanged);
        CheckBox checkBoxBoxWaiter1 = this._CheckBox_BoxWaiter;
        if (checkBoxBoxWaiter1 != null)
          checkBoxBoxWaiter1.CheckedChanged -= eventHandler;
        this._CheckBox_BoxWaiter = value;
        CheckBox checkBoxBoxWaiter2 = this._CheckBox_BoxWaiter;
        if (checkBoxBoxWaiter2 == null)
          return;
        checkBoxBoxWaiter2.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox CheckBox_NotBoxWaiter
    {
      get
      {
        return this._CheckBox_NotBoxWaiter;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBox_NotBoxWaiter_CheckedChanged);
        CheckBox checkBoxNotBoxWaiter1 = this._CheckBox_NotBoxWaiter;
        if (checkBoxNotBoxWaiter1 != null)
          checkBoxNotBoxWaiter1.CheckedChanged -= eventHandler;
        this._CheckBox_NotBoxWaiter = value;
        CheckBox checkBoxNotBoxWaiter2 = this._CheckBox_NotBoxWaiter;
        if (checkBoxNotBoxWaiter2 == null)
          return;
        checkBoxNotBoxWaiter2.CheckedChanged += eventHandler;
      }
    }

    internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBox_ShowNotPay
    {
      get
      {
        return this._CheckBox_ShowNotPay;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBox_ShowNotPay_CheckedChanged);
        CheckBox checkBoxShowNotPay1 = this._CheckBox_ShowNotPay;
        if (checkBoxShowNotPay1 != null)
          checkBoxShowNotPay1.CheckedChanged -= eventHandler;
        this._CheckBox_ShowNotPay = value;
        CheckBox checkBoxShowNotPay2 = this._CheckBox_ShowNotPay;
        if (checkBoxShowNotPay2 == null)
          return;
        checkBoxShowNotPay2.CheckedChanged += eventHandler;
      }
    }

    internal virtual Label Label_IsPeople { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label_ShowPay { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBox_IsPeople
    {
      get
      {
        return this._CheckBox_IsPeople;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBox_IsPeople_CheckedChanged);
        CheckBox checkBoxIsPeople1 = this._CheckBox_IsPeople;
        if (checkBoxIsPeople1 != null)
          checkBoxIsPeople1.CheckedChanged -= eventHandler;
        this._CheckBox_IsPeople = value;
        CheckBox checkBoxIsPeople2 = this._CheckBox_IsPeople;
        if (checkBoxIsPeople2 == null)
          return;
        checkBoxIsPeople2.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox CheckBox_ShowPay
    {
      get
      {
        return this._CheckBox_ShowPay;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBox_ShowPay_CheckedChanged);
        CheckBox checkBoxShowPay1 = this._CheckBox_ShowPay;
        if (checkBoxShowPay1 != null)
          checkBoxShowPay1.CheckedChanged -= eventHandler;
        this._CheckBox_ShowPay = value;
        CheckBox checkBoxShowPay2 = this._CheckBox_ShowPay;
        if (checkBoxShowPay2 == null)
          return;
        checkBoxShowPay2.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox CheckBox_ShowGroup
    {
      get
      {
        return this._CheckBox_ShowGroup;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBox_ShowGroup_CheckedChanged);
        CheckBox checkBoxShowGroup1 = this._CheckBox_ShowGroup;
        if (checkBoxShowGroup1 != null)
          checkBoxShowGroup1.CheckedChanged -= eventHandler;
        this._CheckBox_ShowGroup = value;
        CheckBox checkBoxShowGroup2 = this._CheckBox_ShowGroup;
        if (checkBoxShowGroup2 == null)
          return;
        checkBoxShowGroup2.CheckedChanged += eventHandler;
      }
    }

    internal virtual Label Label_ShowGroup { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBox_IsPeoppleNot
    {
      get
      {
        return this._CheckBox_IsPeoppleNot;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBox_IsPeoppleNot_CheckedChanged);
        CheckBox checkBoxIsPeoppleNot1 = this._CheckBox_IsPeoppleNot;
        if (checkBoxIsPeoppleNot1 != null)
          checkBoxIsPeoppleNot1.CheckedChanged -= eventHandler;
        this._CheckBox_IsPeoppleNot = value;
        CheckBox checkBoxIsPeoppleNot2 = this._CheckBox_IsPeoppleNot;
        if (checkBoxIsPeoppleNot2 == null)
          return;
        checkBoxIsPeoppleNot2.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox CheckBox_ShowGroupNot
    {
      get
      {
        return this._CheckBox_ShowGroupNot;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBox_ShowGroupNot_CheckedChanged);
        CheckBox checkBoxShowGroupNot1 = this._CheckBox_ShowGroupNot;
        if (checkBoxShowGroupNot1 != null)
          checkBoxShowGroupNot1.CheckedChanged -= eventHandler;
        this._CheckBox_ShowGroupNot = value;
        CheckBox checkBoxShowGroupNot2 = this._CheckBox_ShowGroupNot;
        if (checkBoxShowGroupNot2 == null)
          return;
        checkBoxShowGroupNot2.CheckedChanged += eventHandler;
      }
    }

    internal virtual TabControl tbcVariables { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TabPage tpgPrincipal { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TabPage tpgSeguridad { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button btnEliminarSerieFactura
    {
      get
      {
        return this._btnEliminarSerieFactura;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnEliminarSerieFactura_Click);
        Button eliminarSerieFactura1 = this._btnEliminarSerieFactura;
        if (eliminarSerieFactura1 != null)
          eliminarSerieFactura1.Click -= eventHandler;
        this._btnEliminarSerieFactura = value;
        Button eliminarSerieFactura2 = this._btnEliminarSerieFactura;
        if (eliminarSerieFactura2 == null)
          return;
        eliminarSerieFactura2.Click += eventHandler;
      }
    }

    internal virtual DataGridView dgvNumeroSerieBoleta
    {
      get
      {
        return this._dgvNumeroSerieBoleta;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DataGridViewCellEventHandler cellEventHandler = new DataGridViewCellEventHandler(this.dgvNumeroSerieBoleta_CellDoubleClick);
        DataGridView numeroSerieBoleta1 = this._dgvNumeroSerieBoleta;
        if (numeroSerieBoleta1 != null)
          numeroSerieBoleta1.CellDoubleClick -= cellEventHandler;
        this._dgvNumeroSerieBoleta = value;
        DataGridView numeroSerieBoleta2 = this._dgvNumeroSerieBoleta;
        if (numeroSerieBoleta2 == null)
          return;
        numeroSerieBoleta2.CellDoubleClick += cellEventHandler;
      }
    }

    internal virtual DataGridView dgvNumeroSerieFactura
    {
      get
      {
        return this._dgvNumeroSerieFactura;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DataGridViewCellEventHandler cellEventHandler = new DataGridViewCellEventHandler(this.dgvNumeroSerieFactura_CellDoubleClick);
        DataGridView numeroSerieFactura1 = this._dgvNumeroSerieFactura;
        if (numeroSerieFactura1 != null)
          numeroSerieFactura1.CellDoubleClick -= cellEventHandler;
        this._dgvNumeroSerieFactura = value;
        DataGridView numeroSerieFactura2 = this._dgvNumeroSerieFactura;
        if (numeroSerieFactura2 == null)
          return;
        numeroSerieFactura2.CellDoubleClick += cellEventHandler;
      }
    }

    internal virtual Button btnEliminarSerieBoleta
    {
      get
      {
        return this._btnEliminarSerieBoleta;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnEliminarSerieBoleta_Click);
        Button eliminarSerieBoleta1 = this._btnEliminarSerieBoleta;
        if (eliminarSerieBoleta1 != null)
          eliminarSerieBoleta1.Click -= eventHandler;
        this._btnEliminarSerieBoleta = value;
        Button eliminarSerieBoleta2 = this._btnEliminarSerieBoleta;
        if (eliminarSerieBoleta2 == null)
          return;
        eliminarSerieBoleta2.Click += eventHandler;
      }
    }

    internal virtual TabPage tpgConfirmacion { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox chbNoConfirmarComanda
    {
      get
      {
        return this._chbNoConfirmarComanda;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chbNoConfirmarComanda_CheckedChanged);
        CheckBox confirmarComanda1 = this._chbNoConfirmarComanda;
        if (confirmarComanda1 != null)
          confirmarComanda1.CheckedChanged -= eventHandler;
        this._chbNoConfirmarComanda = value;
        CheckBox confirmarComanda2 = this._chbNoConfirmarComanda;
        if (confirmarComanda2 == null)
          return;
        confirmarComanda2.CheckedChanged += eventHandler;
      }
    }

    internal virtual Label Label25 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox chbConfirmarComanda
    {
      get
      {
        return this._chbConfirmarComanda;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chbConfirmarComanda_CheckedChanged);
        CheckBox confirmarComanda1 = this._chbConfirmarComanda;
        if (confirmarComanda1 != null)
          confirmarComanda1.CheckedChanged -= eventHandler;
        this._chbConfirmarComanda = value;
        CheckBox confirmarComanda2 = this._chbConfirmarComanda;
        if (confirmarComanda2 == null)
          return;
        confirmarComanda2.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox chbConfirmarDivCuentas
    {
      get
      {
        return this._chbConfirmarDivCuentas;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chbConfirmarDivCuentas_CheckedChanged);
        CheckBox confirmarDivCuentas1 = this._chbConfirmarDivCuentas;
        if (confirmarDivCuentas1 != null)
          confirmarDivCuentas1.CheckedChanged -= eventHandler;
        this._chbConfirmarDivCuentas = value;
        CheckBox confirmarDivCuentas2 = this._chbConfirmarDivCuentas;
        if (confirmarDivCuentas2 == null)
          return;
        confirmarDivCuentas2.CheckedChanged += eventHandler;
      }
    }

    internal virtual Label Label27 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox chbNoConfirmarDocumento
    {
      get
      {
        return this._chbNoConfirmarDocumento;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chbNoConfirmarDocumento_CheckedChanged);
        CheckBox confirmarDocumento1 = this._chbNoConfirmarDocumento;
        if (confirmarDocumento1 != null)
          confirmarDocumento1.CheckedChanged -= eventHandler;
        this._chbNoConfirmarDocumento = value;
        CheckBox confirmarDocumento2 = this._chbNoConfirmarDocumento;
        if (confirmarDocumento2 == null)
          return;
        confirmarDocumento2.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox chbConfirmarDocumento
    {
      get
      {
        return this._chbConfirmarDocumento;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chbConfirmarDocumento_CheckedChanged);
        CheckBox confirmarDocumento1 = this._chbConfirmarDocumento;
        if (confirmarDocumento1 != null)
          confirmarDocumento1.CheckedChanged -= eventHandler;
        this._chbConfirmarDocumento = value;
        CheckBox confirmarDocumento2 = this._chbConfirmarDocumento;
        if (confirmarDocumento2 == null)
          return;
        confirmarDocumento2.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox chbNoConfirmarDivCuentas
    {
      get
      {
        return this._chbNoConfirmarDivCuentas;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chbNoConfirmarDivCuentas_CheckedChanged);
        CheckBox confirmarDivCuentas1 = this._chbNoConfirmarDivCuentas;
        if (confirmarDivCuentas1 != null)
          confirmarDivCuentas1.CheckedChanged -= eventHandler;
        this._chbNoConfirmarDivCuentas = value;
        CheckBox confirmarDivCuentas2 = this._chbNoConfirmarDivCuentas;
        if (confirmarDivCuentas2 == null)
          return;
        confirmarDivCuentas2.CheckedChanged += eventHandler;
      }
    }

    internal virtual Label Label28 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox chbConfirmarTransfMesas
    {
      get
      {
        return this._chbConfirmarTransfMesas;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chbConfirmarTransfMesas_CheckedChanged);
        CheckBox confirmarTransfMesas1 = this._chbConfirmarTransfMesas;
        if (confirmarTransfMesas1 != null)
          confirmarTransfMesas1.CheckedChanged -= eventHandler;
        this._chbConfirmarTransfMesas = value;
        CheckBox confirmarTransfMesas2 = this._chbConfirmarTransfMesas;
        if (confirmarTransfMesas2 == null)
          return;
        confirmarTransfMesas2.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox chbNoConfirmarPago
    {
      get
      {
        return this._chbNoConfirmarPago;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chbNoConfirmarPago_CheckedChanged);
        CheckBox chbNoConfirmarPago1 = this._chbNoConfirmarPago;
        if (chbNoConfirmarPago1 != null)
          chbNoConfirmarPago1.CheckedChanged -= eventHandler;
        this._chbNoConfirmarPago = value;
        CheckBox chbNoConfirmarPago2 = this._chbNoConfirmarPago;
        if (chbNoConfirmarPago2 == null)
          return;
        chbNoConfirmarPago2.CheckedChanged += eventHandler;
      }
    }

    internal virtual Label Label29 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox chbConfirmarPago
    {
      get
      {
        return this._chbConfirmarPago;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chbConfirmarPago_CheckedChanged);
        CheckBox chbConfirmarPago1 = this._chbConfirmarPago;
        if (chbConfirmarPago1 != null)
          chbConfirmarPago1.CheckedChanged -= eventHandler;
        this._chbConfirmarPago = value;
        CheckBox chbConfirmarPago2 = this._chbConfirmarPago;
        if (chbConfirmarPago2 == null)
          return;
        chbConfirmarPago2.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox chbNoConfirmarTransfMesas
    {
      get
      {
        return this._chbNoConfirmarTransfMesas;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chbNoConfirmarTransfMesas_CheckedChanged);
        CheckBox confirmarTransfMesas1 = this._chbNoConfirmarTransfMesas;
        if (confirmarTransfMesas1 != null)
          confirmarTransfMesas1.CheckedChanged -= eventHandler;
        this._chbNoConfirmarTransfMesas = value;
        CheckBox confirmarTransfMesas2 = this._chbNoConfirmarTransfMesas;
        if (confirmarTransfMesas2 == null)
          return;
        confirmarTransfMesas2.CheckedChanged += eventHandler;
      }
    }

    internal virtual Label Label30 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label31 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox chbNoConfirmarPedido
    {
      get
      {
        return this._chbNoConfirmarPedido;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chbNoConfirmarPedido_CheckedChanged);
        CheckBox noConfirmarPedido1 = this._chbNoConfirmarPedido;
        if (noConfirmarPedido1 != null)
          noConfirmarPedido1.CheckedChanged -= eventHandler;
        this._chbNoConfirmarPedido = value;
        CheckBox noConfirmarPedido2 = this._chbNoConfirmarPedido;
        if (noConfirmarPedido2 == null)
          return;
        noConfirmarPedido2.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox chbConfirmarPedido
    {
      get
      {
        return this._chbConfirmarPedido;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chbConfirmarPedido_CheckedChanged);
        CheckBox chbConfirmarPedido1 = this._chbConfirmarPedido;
        if (chbConfirmarPedido1 != null)
          chbConfirmarPedido1.CheckedChanged -= eventHandler;
        this._chbConfirmarPedido = value;
        CheckBox chbConfirmarPedido2 = this._chbConfirmarPedido;
        if (chbConfirmarPedido2 == null)
          return;
        chbConfirmarPedido2.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox chbNoEsPedidoLibreRapido
    {
      get
      {
        return this._chbNoEsPedidoLibreRapido;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chbNoEsPedidoLibreRapido_CheckedChanged);
        CheckBox pedidoLibreRapido1 = this._chbNoEsPedidoLibreRapido;
        if (pedidoLibreRapido1 != null)
          pedidoLibreRapido1.CheckedChanged -= eventHandler;
        this._chbNoEsPedidoLibreRapido = value;
        CheckBox pedidoLibreRapido2 = this._chbNoEsPedidoLibreRapido;
        if (pedidoLibreRapido2 == null)
          return;
        pedidoLibreRapido2.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox chbEsPedidoLibreRapido
    {
      get
      {
        return this._chbEsPedidoLibreRapido;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chbEsPedidoLibreRapido_CheckedChanged);
        CheckBox pedidoLibreRapido1 = this._chbEsPedidoLibreRapido;
        if (pedidoLibreRapido1 != null)
          pedidoLibreRapido1.CheckedChanged -= eventHandler;
        this._chbEsPedidoLibreRapido = value;
        CheckBox pedidoLibreRapido2 = this._chbEsPedidoLibreRapido;
        if (pedidoLibreRapido2 == null)
          return;
        pedidoLibreRapido2.CheckedChanged += eventHandler;
      }
    }

    internal virtual Label Label26 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox chbNoMozoObservaPrecios
    {
      get
      {
        return this._chbNoMozoObservaPrecios;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chbNoMozoObservaPrecios_CheckedChanged);
        CheckBox mozoObservaPrecios1 = this._chbNoMozoObservaPrecios;
        if (mozoObservaPrecios1 != null)
          mozoObservaPrecios1.CheckedChanged -= eventHandler;
        this._chbNoMozoObservaPrecios = value;
        CheckBox mozoObservaPrecios2 = this._chbNoMozoObservaPrecios;
        if (mozoObservaPrecios2 == null)
          return;
        mozoObservaPrecios2.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox chbMozoObservaPrecios
    {
      get
      {
        return this._chbMozoObservaPrecios;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chbMozoObservaPrecios_CheckedChanged);
        CheckBox mozoObservaPrecios1 = this._chbMozoObservaPrecios;
        if (mozoObservaPrecios1 != null)
          mozoObservaPrecios1.CheckedChanged -= eventHandler;
        this._chbMozoObservaPrecios = value;
        CheckBox mozoObservaPrecios2 = this._chbMozoObservaPrecios;
        if (mozoObservaPrecios2 == null)
          return;
        mozoObservaPrecios2.CheckedChanged += eventHandler;
      }
    }

    internal virtual Label Label32 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button btnTiempoEsperaDelivery
    {
      get
      {
        return this._btnTiempoEsperaDelivery;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnTiempoEsperaDelivery_Click);
        Button tiempoEsperaDelivery1 = this._btnTiempoEsperaDelivery;
        if (tiempoEsperaDelivery1 != null)
          tiempoEsperaDelivery1.Click -= eventHandler;
        this._btnTiempoEsperaDelivery = value;
        Button tiempoEsperaDelivery2 = this._btnTiempoEsperaDelivery;
        if (tiempoEsperaDelivery2 == null)
          return;
        tiempoEsperaDelivery2.Click += eventHandler;
      }
    }

    internal virtual TextBox txtTiempoEsperaDelivery { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label lblTiempoEsperaDelivery { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label lblSegundosEsperaDelivery { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label35 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox cboTiposPedido
    {
      get
      {
        return this._cboTiposPedido;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cboTiposPedido_SelectedIndexChanged);
        ComboBox cboTiposPedido1 = this._cboTiposPedido;
        if (cboTiposPedido1 != null)
          cboTiposPedido1.SelectedIndexChanged -= eventHandler;
        this._cboTiposPedido = value;
        ComboBox cboTiposPedido2 = this._cboTiposPedido;
        if (cboTiposPedido2 == null)
          return;
        cboTiposPedido2.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual Label Label33 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual MyXPButtonTables.MyXPButtonTables btnDeliveryEnLinea { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox chbNoSeleccionarMesaxDiseno
    {
      get
      {
        return this._chbNoSeleccionarMesaxDiseno;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chbNoSeleccionarMesaxDiseno_CheckedChanged);
        CheckBox seleccionarMesaxDiseno1 = this._chbNoSeleccionarMesaxDiseno;
        if (seleccionarMesaxDiseno1 != null)
          seleccionarMesaxDiseno1.CheckedChanged -= eventHandler;
        this._chbNoSeleccionarMesaxDiseno = value;
        CheckBox seleccionarMesaxDiseno2 = this._chbNoSeleccionarMesaxDiseno;
        if (seleccionarMesaxDiseno2 == null)
          return;
        seleccionarMesaxDiseno2.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox chbSeleccionarMesaxDiseno
    {
      get
      {
        return this._chbSeleccionarMesaxDiseno;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chbSeleccionarMesaxDiseno_CheckedChanged);
        CheckBox seleccionarMesaxDiseno1 = this._chbSeleccionarMesaxDiseno;
        if (seleccionarMesaxDiseno1 != null)
          seleccionarMesaxDiseno1.CheckedChanged -= eventHandler;
        this._chbSeleccionarMesaxDiseno = value;
        CheckBox seleccionarMesaxDiseno2 = this._chbSeleccionarMesaxDiseno;
        if (seleccionarMesaxDiseno2 == null)
          return;
        seleccionarMesaxDiseno2.CheckedChanged += eventHandler;
      }
    }

    internal virtual Label Label34 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBox_IsNotAmountMin
    {
      get
      {
        return this._CheckBox_IsNotAmountMin;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBox_IsNotAmountMin_CheckedChanged);
        CheckBox boxIsNotAmountMin1 = this._CheckBox_IsNotAmountMin;
        if (boxIsNotAmountMin1 != null)
          boxIsNotAmountMin1.CheckedChanged -= eventHandler;
        this._CheckBox_IsNotAmountMin = value;
        CheckBox boxIsNotAmountMin2 = this._CheckBox_IsNotAmountMin;
        if (boxIsNotAmountMin2 == null)
          return;
        boxIsNotAmountMin2.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox CheckBox_IsAmountMin
    {
      get
      {
        return this._CheckBox_IsAmountMin;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBox_IsAmountMin_CheckedChanged);
        CheckBox checkBoxIsAmountMin1 = this._CheckBox_IsAmountMin;
        if (checkBoxIsAmountMin1 != null)
          checkBoxIsAmountMin1.CheckedChanged -= eventHandler;
        this._CheckBox_IsAmountMin = value;
        CheckBox checkBoxIsAmountMin2 = this._CheckBox_IsAmountMin;
        if (checkBoxIsAmountMin2 == null)
          return;
        checkBoxIsAmountMin2.CheckedChanged += eventHandler;
      }
    }

    internal virtual TabPage tpgMensajes { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBox_MensajePrecuenta { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label36 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label37 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBox_MensajeTNS_True
    {
      get
      {
        return this._CheckBox_MensajeTNS_True;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBox_MensajeTNS_True_CheckedChanged);
        CheckBox boxMensajeTnsTrue1 = this._CheckBox_MensajeTNS_True;
        if (boxMensajeTnsTrue1 != null)
          boxMensajeTnsTrue1.CheckedChanged -= eventHandler;
        this._CheckBox_MensajeTNS_True = value;
        CheckBox boxMensajeTnsTrue2 = this._CheckBox_MensajeTNS_True;
        if (boxMensajeTnsTrue2 == null)
          return;
        boxMensajeTnsTrue2.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox CheckBox_MensajeTNS_False
    {
      get
      {
        return this._CheckBox_MensajeTNS_False;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBox_MensajeTNS_False_CheckedChanged);
        CheckBox boxMensajeTnsFalse1 = this._CheckBox_MensajeTNS_False;
        if (boxMensajeTnsFalse1 != null)
          boxMensajeTnsFalse1.CheckedChanged -= eventHandler;
        this._CheckBox_MensajeTNS_False = value;
        CheckBox boxMensajeTnsFalse2 = this._CheckBox_MensajeTNS_False;
        if (boxMensajeTnsFalse2 == null)
          return;
        boxMensajeTnsFalse2.CheckedChanged += eventHandler;
      }
    }

    internal virtual TabPage tpgMonitor { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox chbEsMonitorNo
    {
      get
      {
        return this._chbEsMonitorNo;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chbEsMonitorNo_CheckedChanged);
        CheckBox chbEsMonitorNo1 = this._chbEsMonitorNo;
        if (chbEsMonitorNo1 != null)
          chbEsMonitorNo1.CheckedChanged -= eventHandler;
        this._chbEsMonitorNo = value;
        CheckBox chbEsMonitorNo2 = this._chbEsMonitorNo;
        if (chbEsMonitorNo2 == null)
          return;
        chbEsMonitorNo2.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox chbEsMonitor
    {
      get
      {
        return this._chbEsMonitor;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chbEsMonitor_CheckedChanged);
        CheckBox chbEsMonitor1 = this._chbEsMonitor;
        if (chbEsMonitor1 != null)
          chbEsMonitor1.CheckedChanged -= eventHandler;
        this._chbEsMonitor = value;
        CheckBox chbEsMonitor2 = this._chbEsMonitor;
        if (chbEsMonitor2 == null)
          return;
        chbEsMonitor2.CheckedChanged += eventHandler;
      }
    }

    internal virtual Label Label38 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label47 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual NumericTextBox.NumericTextBox txtTiempoEsperaMonitor { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label44 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label41 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label39 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual NumericTextBox.NumericTextBox txtTiempoAlertaMonitor { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label40 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label42 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBox_ImprimirPrecuenta
    {
      get
      {
        return this._CheckBox_ImprimirPrecuenta;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBox_ImprimirPrecuenta_CheckedChanged);
        CheckBox imprimirPrecuenta1 = this._CheckBox_ImprimirPrecuenta;
        if (imprimirPrecuenta1 != null)
          imprimirPrecuenta1.CheckedChanged -= eventHandler;
        this._CheckBox_ImprimirPrecuenta = value;
        CheckBox imprimirPrecuenta2 = this._CheckBox_ImprimirPrecuenta;
        if (imprimirPrecuenta2 == null)
          return;
        imprimirPrecuenta2.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox CheckBox_NoImprimirPrecuenta
    {
      get
      {
        return this._CheckBox_NoImprimirPrecuenta;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBox_NoImprimirPrecuenta_CheckedChanged);
        CheckBox imprimirPrecuenta1 = this._CheckBox_NoImprimirPrecuenta;
        if (imprimirPrecuenta1 != null)
          imprimirPrecuenta1.CheckedChanged -= eventHandler;
        this._CheckBox_NoImprimirPrecuenta = value;
        CheckBox imprimirPrecuenta2 = this._CheckBox_NoImprimirPrecuenta;
        if (imprimirPrecuenta2 == null)
          return;
        imprimirPrecuenta2.CheckedChanged += eventHandler;
      }
    }

    internal virtual Label Label43 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private void FrmCfgSystem_Load(object sender, EventArgs e)
    {
      this.VerificarModulo();
      this.ComboBox_CantPrintCommand.SelectedIndex = 0;
      this.CargarTiposPedido();
      this.LoadData();
      this.SetearGridFactura();
      this.SetearGridBoleta();
      this.CargarNumeroSerieFactura();
      this.CargarNumeroSerieBoleta();
    }

    private void LoadData()
    {
      this.o_CL_CFGVARIABLES = new BL_TR1_CONFIGURATION();
      if (this._IsAdvanced)
      {
        this.o_BE_TR1_CFGVARIABLES = new BE_TR1_CFGVARIABLES();
        this.o_BE_TR1_BOXES = new BE_TR1_BOXES();
        this.o_CL_CFGVARIABLES.ValidateBoxID(this._MachineId, ref this.o_BE_TR1_BOXES);
        this.o_BE_TR1_CFGVARIABLES.set_EstabliId(this.o_BE_TR1_BOXES.get_EstabliId());
        this.o_BE_TR1_CFGVARIABLES.set_BoxId(this.o_BE_TR1_BOXES.get_BoxId());
        this.o_CL_CFGVARIABLES.List(ref this.o_BE_TR1_CFGVARIABLES);
        this.Text = this.Text + " : " + this.o_BE_TR1_BOXES.get_BoxDes();
      }
      else
      {
        this.o_BE_TR1_CFGVARIABLES = ModGeneralVar.g_BE_TR1_CFGVARIABLES;
        this.o_BE_TR1_BOXES = ModGeneralVar.g_BE_TR1_BOXES;
      }
      BL_TR1_PRINTERS blTr1Printers = new BL_TR1_PRINTERS();
      BE_TR1_PRINTERS beTr1Printers1 = new BE_TR1_PRINTERS();
      BE_TR1_PRINTERS beTr1Printers2 = blTr1Printers.ListById(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId(), this.o_BE_TR1_CFGVARIABLES.get_PrinterPrecountId());
      this.TextBox_Printer.Text = beTr1Printers2.get_PrinterDes();
      this.TextBox_PrinterPrecountId.Text = Conversions.ToString(beTr1Printers2.get_PrinterId());
      BE_TR1_PRINTERS beTr1Printers3 = blTr1Printers.ListById(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId(), this.o_BE_TR1_CFGVARIABLES.get_PrinterTicketId());
      this.TextBox_ForTicket.Text = beTr1Printers3.get_PrinterDes();
      this.TextBox_PrinterTicketId.Text = Conversions.ToString(beTr1Printers3.get_PrinterId());
      BE_TR1_PRINTERS beTr1Printers4 = blTr1Printers.ListById(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId(), this.o_BE_TR1_CFGVARIABLES.get_PrinterInvoiceId());
      this.TextBox_ForDocument.Text = beTr1Printers4.get_PrinterDes();
      this.TextBox_PrinterInvoiceId.Text = Conversions.ToString(beTr1Printers4.get_PrinterId());
      this.TextBox_Minutes.Text = Conversions.ToString(this.o_BE_TR1_CFGVARIABLES.get_TimeW());
      this.TextBox_QuantitytAlert.Text = this.o_BE_TR1_CFGVARIABLES.get_CantAlertProgram();
      this.CheckBox_IsPeople.Checked = this.o_BE_TR1_CFGVARIABLES.get_ShowPeople();
      this.CheckBox_NotBoxWaiter.Checked = this.o_BE_TR1_CFGVARIABLES.get_IsBoxWaiter();
      this.CheckBox_Matricial.Checked = this.o_BE_TR1_CFGVARIABLES.get_IsPrinterMatricial();
      this.CheckBox_NotShowCommand.Checked = this.o_BE_TR1_CFGVARIABLES.get_ShowCommand();
      this.CheckBoxShowConsume.Checked = this.o_BE_TR1_CFGVARIABLES.get_ShowPorConsumo();
      this.CheckBox_DeleteItem.Checked = this.o_BE_TR1_CFGVARIABLES.get_DeleteItem();
      this.CheckBox_DeleteDocument.Checked = this.o_BE_TR1_CFGVARIABLES.get_ShowUserDeleteDocument();
      this.CheckBox_ChangePrice.Checked = this.o_BE_TR1_CFGVARIABLES.get_ShowUserChangePrice();
      this.CheckBox_DocuIntern.Checked = this.o_BE_TR1_CFGVARIABLES.get_ShowUserDocuIntern();
      this.CheckBox_IsBarCode.Checked = this.o_BE_TR1_CFGVARIABLES.get_IsBarCode();
      this.CheckBox_DeleteOrder.Checked = this.o_BE_TR1_CFGVARIABLES.get_ShowUserDeleteOrder();
      this.RadioButton_Yes.Checked = this.o_BE_TR1_CFGVARIABLES.get_IsTouchScreen();
      this.CheckBox_IsPrintDeleteItem.Checked = this.o_BE_TR1_CFGVARIABLES.get_IsPrintDeleteItem();
      this.CheckBox_IsFirstPay.Checked = this.o_BE_TR1_CFGVARIABLES.get_IsFirstPay();
      this.CheckBox_IsDobleCommand.Checked = this.o_BE_TR1_CFGVARIABLES.get_IsDobleCommand();
      this.CheckBox_IsAmountMin.Checked = this.o_BE_TR1_CFGVARIABLES.get_IsAmountMin();
      this.TextBox_AmountMin.Text = ModGeneralFunctions.CadenaToDoubleFormateado(Conversions.ToString(this.o_BE_TR1_CFGVARIABLES.get_AmountMin()), 2);
      this.CheckBox_IsWaiterShowSale.Checked = this.o_BE_TR1_CFGVARIABLES.get_IsWaiterShowSale();
      this.TextBox_CantLineComHeader.Text = Conversions.ToString(this.o_BE_TR1_CFGVARIABLES.get_CantLineComHeader());
      this.TextBox_CantLineComFooter.Text = Conversions.ToString(this.o_BE_TR1_CFGVARIABLES.get_CantLineComFooter());
      this.ComboBox_CantPrintCommand.Text = Conversions.ToString(this.o_BE_TR1_CFGVARIABLES.get_CantPrintCommand());
      this.CheckBox_ImprimirPrecuenta.Checked = this.o_BE_TR1_CFGVARIABLES.get_MostrarUsuarioPrecuenta();
      this.chbEsPedidoLibreRapido.Checked = this.o_BE_TR1_CFGVARIABLES.get_EsPedidoLibreRapido();
      this.chbConfirmarComanda.Checked = this.o_BE_TR1_CFGVARIABLES.get_ConfirmarComanda();
      this.chbConfirmarDivCuentas.Checked = this.o_BE_TR1_CFGVARIABLES.get_ConfirmarDivCuentas();
      this.chbConfirmarTransfMesas.Checked = this.o_BE_TR1_CFGVARIABLES.get_ConfirmarTransfMesas();
      this.chbConfirmarDocumento.Checked = this.o_BE_TR1_CFGVARIABLES.get_ConfirmarDocumento();
      this.chbConfirmarPago.Checked = this.o_BE_TR1_CFGVARIABLES.get_ConfirmarPago();
      this.chbConfirmarPedido.Checked = this.o_BE_TR1_CFGVARIABLES.get_ConfirmarPedido();
      this.chbMozoObservaPrecios.Checked = this.o_BE_TR1_CFGVARIABLES.get_MozoObservaPrecios();
      this.cboTiposPedido.SelectedValue = (object) this.o_BE_TR1_CFGVARIABLES.get_TipoPedidoDefecto();
      this.txtTiempoEsperaDelivery.Text = Conversions.ToString(this.o_BE_TR1_CFGVARIABLES.get_TiempoEsperaDelivery());
      this.chbSeleccionarMesaxDiseno.Checked = this.o_BE_TR1_CFGVARIABLES.get_SeleccionarMesaxDiseno();
      this.chbEsMonitor.Checked = this.o_BE_TR1_CFGVARIABLES.get_EsMonitor();
      ((TextBox) this.txtTiempoEsperaMonitor).Text = Conversions.ToString(this.o_BE_TR1_CFGVARIABLES.get_TiempoEsperaMonitor());
      ((TextBox) this.txtTiempoAlertaMonitor).Text = Conversions.ToString(this.o_BE_TR1_CFGVARIABLES.get_TiempoAlertaMonitor());
      if (this.o_BE_TR1_CFGVARIABLES.get_DeliveryOnLine())
        this.btnDeliveryEnLinea.set_BtnStyle((emunType.XPStyle) 1);
      else
        this.btnDeliveryEnLinea.set_BtnStyle((emunType.XPStyle) 2);
      if (!this.o_BE_TR1_CFGVARIABLES.get_ShowPeople())
        this.CheckBox_IsPeoppleNot.Checked = true;
      this.CheckBox_ShowGroup.Checked = this.o_BE_TR1_CFGVARIABLES.get_ShowGroup();
      if (!this.o_BE_TR1_CFGVARIABLES.get_ShowGroup())
        this.CheckBox_ShowGroupNot.Checked = true;
      this.CheckBox_ShowPay.Checked = this.o_BE_TR1_CFGVARIABLES.get_ShowPay();
      if (!this.o_BE_TR1_CFGVARIABLES.get_ShowPay())
        this.CheckBox_ShowNotPay.Checked = true;
      if (!this.o_BE_TR1_CFGVARIABLES.get_IsBoxWaiter())
        this.CheckBox_BoxWaiter.Checked = true;
      if (!this.o_BE_TR1_CFGVARIABLES.get_IsPrinterMatricial())
        this.CheckBox_NotMatricial.Checked = true;
      if (!this.o_BE_TR1_CFGVARIABLES.get_ShowCommand())
        this.CheckBox_NotShowCommand.Checked = false;
      if (!this.o_BE_TR1_CFGVARIABLES.get_ShowPorConsumo())
        this.CheckBoxShowNotConsume.Checked = true;
      if (!this.o_BE_TR1_CFGVARIABLES.get_DeleteItem())
        this.CheckBox_NotDeleteItem.Checked = true;
      if (!this.o_BE_TR1_CFGVARIABLES.get_ShowUserDeleteDocument())
        this.CheckBox_NotDeleteDocument.Checked = true;
      if (!this.o_BE_TR1_CFGVARIABLES.get_ShowUserChangePrice())
        this.CheckBox_NotChangePrice.Checked = true;
      if (!this.o_BE_TR1_CFGVARIABLES.get_IsBarCode())
        this.CheckBox_NotBarCode.Checked = true;
      if (!this.o_BE_TR1_CFGVARIABLES.get_ShowUserDocuIntern())
        this.CheckBox_NotDocuIntern.Checked = true;
      if (!this.o_BE_TR1_CFGVARIABLES.get_ShowUserDeleteOrder())
        this.CheckBox_NotDeleteOrder.Checked = true;
      if (!this.o_BE_TR1_CFGVARIABLES.get_IsTouchScreen())
        this.RadioButton_Not.Checked = true;
      if (!this.o_BE_TR1_CFGVARIABLES.get_IsPrintDeleteItem())
        this.CheckBox_IsNotPrintDeleteItem.Checked = true;
      if (!this.o_BE_TR1_CFGVARIABLES.get_IsFirstPay())
        this.CheckBox_IsNotFirstPay.Checked = true;
      if (!this.o_BE_TR1_CFGVARIABLES.get_IsDobleCommand())
      {
        this.CheckBox_IsNotDobleCommand.Checked = true;
        this.ComboBox_CantPrintCommand.Enabled = false;
      }
      if (!this.o_BE_TR1_CFGVARIABLES.get_IsAmountMin())
        this.CheckBox_IsNotAmountMin.Checked = true;
      if (!this.o_BE_TR1_CFGVARIABLES.get_IsWaiterShowSale())
        this.CheckBox_IsNotWaiterShowSale.Checked = true;
      if (!this.o_BE_TR1_CFGVARIABLES.get_EsPedidoLibreRapido())
        this.chbNoEsPedidoLibreRapido.Checked = true;
      if (!this.o_BE_TR1_CFGVARIABLES.get_ConfirmarComanda())
        this.chbNoConfirmarComanda.Checked = true;
      if (!this.o_BE_TR1_CFGVARIABLES.get_ConfirmarDivCuentas())
        this.chbNoConfirmarDivCuentas.Checked = true;
      if (!this.o_BE_TR1_CFGVARIABLES.get_ConfirmarTransfMesas())
        this.chbNoConfirmarTransfMesas.Checked = true;
      if (!this.o_BE_TR1_CFGVARIABLES.get_ConfirmarDocumento())
        this.chbNoConfirmarDocumento.Checked = true;
      if (!this.o_BE_TR1_CFGVARIABLES.get_ConfirmarPago())
        this.chbNoConfirmarPago.Checked = true;
      if (!this.o_BE_TR1_CFGVARIABLES.get_ConfirmarPedido())
        this.chbNoConfirmarPedido.Checked = true;
      if (!this.o_BE_TR1_CFGVARIABLES.get_MozoObservaPrecios())
        this.chbNoMozoObservaPrecios.Checked = true;
      if (!this.o_BE_TR1_CFGVARIABLES.get_SeleccionarMesaxDiseno())
        this.chbNoSeleccionarMesaxDiseno.Checked = true;
      if (!this.o_BE_TR1_CFGVARIABLES.get_MostrarMensajeTNS())
        this.CheckBox_MensajeTNS_False.Checked = true;
      if (!this.o_BE_TR1_CFGVARIABLES.get_EsMonitor())
        this.chbEsMonitorNo.Checked = true;
      if (!this.o_BE_TR1_CFGVARIABLES.get_MostrarUsuarioPrecuenta())
        this.CheckBox_NoImprimirPrecuenta.Checked = true;
      this.TextBox_MensajePrecuenta.Text = this.o_BE_TR1_CFGVARIABLES.get_MensajePersonalizado();
      this._Isload = false;
    }

    private void SetearGridFactura()
    {
      ModGeneralFunctions.SetUpDataGridViewBasicNuevo(this.dgvNumeroSerieFactura);
      this.dgvNumeroSerieFactura.Columns.Add("NumeroSerie", "Nº Serie");
      ModGeneralFunctions.SetUp_TextBoxColumn1((DataGridViewTextBoxColumn) this.dgvNumeroSerieFactura.Columns[0], "NumeroSerie", (short) 75, "", true, DataGridViewContentAlignment.MiddleCenter, true);
      string varTax1 = ModGeneralVar.g_BE_TR1_VARIABLES_B.get_VarTax1();
      this.dgvNumeroSerieFactura.Columns.Add((DataGridViewColumn) new DataGridViewCheckBoxColumn());
      ModGeneralFunctions.SetUp_CheckBoxColumn1((DataGridViewCheckBoxColumn) this.dgvNumeroSerieFactura.Columns[1], "Exone " + varTax1, "ExoneradoImp1", (short) 95, "", true);
      this.dgvNumeroSerieFactura.Columns.Add((DataGridViewColumn) new DataGridViewCheckBoxColumn());
      ModGeneralFunctions.SetUp_CheckBoxColumn1((DataGridViewCheckBoxColumn) this.dgvNumeroSerieFactura.Columns[2], "Activo", "EsActivo", (short) 55, "", true);
      this.dgvNumeroSerieFactura.ScrollBars = ScrollBars.Vertical;
    }

    private void SetearGridBoleta()
    {
      ModGeneralFunctions.SetUpDataGridViewBasicNuevo(this.dgvNumeroSerieBoleta);
      this.dgvNumeroSerieBoleta.Columns.Add("NumeroSerie", "Nº Serie");
      ModGeneralFunctions.SetUp_TextBoxColumn1((DataGridViewTextBoxColumn) this.dgvNumeroSerieBoleta.Columns[0], "NumeroSerie", (short) 75, "", true, DataGridViewContentAlignment.MiddleCenter, true);
      string varTax1 = ModGeneralVar.g_BE_TR1_VARIABLES_B.get_VarTax1();
      this.dgvNumeroSerieBoleta.Columns.Add((DataGridViewColumn) new DataGridViewCheckBoxColumn());
      ModGeneralFunctions.SetUp_CheckBoxColumn1((DataGridViewCheckBoxColumn) this.dgvNumeroSerieBoleta.Columns[1], "Exone " + varTax1, "ExoneradoImp1", (short) 95, "", true);
      this.dgvNumeroSerieBoleta.Columns.Add((DataGridViewColumn) new DataGridViewCheckBoxColumn());
      ModGeneralFunctions.SetUp_CheckBoxColumn1((DataGridViewCheckBoxColumn) this.dgvNumeroSerieBoleta.Columns[2], "Activo", "EsActivo", (short) 55, "", true);
      this.dgvNumeroSerieBoleta.ScrollBars = ScrollBars.Vertical;
    }

    private void CargarNumeroSerieFactura()
    {
      this.dgvNumeroSerieFactura.DataSource = (object) new BL_TR1_CONFIGURATION().ListarNumeroSerie(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId(), ModGeneralVar.g_BE_TR1_CFGVARIABLES.get_BoxIdPos(), ModGeneralVar.g_GeneralCode.get_Docu_Invoice());
    }

    private void CargarNumeroSerieBoleta()
    {
      this.dgvNumeroSerieBoleta.DataSource = (object) new BL_TR1_CONFIGURATION().ListarNumeroSerie(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId(), ModGeneralVar.g_BE_TR1_CFGVARIABLES.get_BoxIdPos(), ModGeneralVar.g_GeneralCode.get_Docu_Ticket());
    }

    private void Control_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!ModGeneralFunctions.Question_Made_Enter(e))
        return;
      e.Handled = true;
      SendKeys.Send("{TAB}");
    }

    private void Button_SearchPrinters_Click(object sender, EventArgs e)
    {
      FrmPrinters frmPrinters = new FrmPrinters();
      frmPrinters._OnlySearch = true;
      frmPrinters._OnlyforDocuments = false;
      frmPrinters._BoxId = !this._IsAdvanced ? ModGeneralVar.g_BE_TR1_CFGVARIABLES.get_BoxIdPos() : this._BoxId;
      int num = (int) frmPrinters.ShowDialog();
      frmPrinters.Dispose();
      if (!ModGeneralVar.g_bol_IsReady)
        return;
      this.TextBox_PrinterPrecountId.Text = ModGeneralVar.g_Str_RecordID;
      this.TextBox_Printer.Text = ModGeneralVar.g_Str_RecordDes;
      this.TextBox_ForDocument.Focus();
    }

    private void Button_PrinterForDocu_Click(object sender, EventArgs e)
    {
      FrmPrinters frmPrinters = new FrmPrinters();
      frmPrinters._OnlySearch = true;
      frmPrinters._OnlyforDocuments = true;
      frmPrinters._BoxId = !this._IsAdvanced ? ModGeneralVar.g_BE_TR1_CFGVARIABLES.get_BoxIdPos() : this._BoxId;
      int num = (int) frmPrinters.ShowDialog();
      frmPrinters.Dispose();
      if (!ModGeneralVar.g_bol_IsReady)
        return;
      this.TextBox_PrinterInvoiceId.Text = ModGeneralVar.g_Str_RecordID;
      this.TextBox_ForDocument.Text = ModGeneralVar.g_Str_RecordDes;
      this.TextBox_ForTicket.Focus();
    }

    private void Button_TimeW_Click(object sender, EventArgs e)
    {
      ModGeneralFunctions.NumberKeyBoard("Ingrese Tiempo de Alerta de Reservas", false);
      if (!ModGeneralVar.g_bol_IsReady)
        return;
      this.TextBox_Minutes.Text = Conversions.ToString(ModGeneralFunctions.CadenaToInteger(ModGeneralVar.g_str_InputValue));
      this.TextBox_QuantitytAlert.Focus();
    }

    private void Button_Save_Click(object sender, EventArgs e)
    {
      if (!this.ValidData() || !ModGeneralFunctions.MessageMakeAction("¿Desea Guardar la Configuración?", false))
        return;
      this.o_BE_TR1_CFGVARIABLES.set_PrinterPrecountId(Conversions.ToInteger(this.TextBox_PrinterPrecountId.Text));
      this.o_BE_TR1_CFGVARIABLES.set_PrinterInvoiceId(Conversions.ToInteger(this.TextBox_PrinterInvoiceId.Text));
      this.o_BE_TR1_CFGVARIABLES.set_PrinterTicketId(Conversions.ToInteger(this.TextBox_PrinterTicketId.Text));
      this.o_BE_TR1_CFGVARIABLES.set_ShowPeople(this.CheckBox_IsPeople.Checked);
      this.o_BE_TR1_CFGVARIABLES.set_ShowGroup(this.CheckBox_ShowGroup.Checked);
      this.o_BE_TR1_CFGVARIABLES.set_ShowPay(this.CheckBox_ShowPay.Checked);
      this.o_BE_TR1_CFGVARIABLES.set_ShowPorConsumo(this.CheckBoxShowConsume.Checked);
      this.o_BE_TR1_CFGVARIABLES.set_IsBoxWaiter(this.CheckBox_NotBoxWaiter.Checked);
      this.o_BE_TR1_CFGVARIABLES.set_TimeW((long) ModGeneralFunctions.CadenaToInteger(this.TextBox_Minutes.Text));
      this.o_BE_TR1_CFGVARIABLES.set_CantAlertProgram(Conversions.ToString(Conversion.Val(this.TextBox_QuantitytAlert.Text)));
      this.o_BE_TR1_CFGVARIABLES.set_IsPrinterMatricial(this.CheckBox_Matricial.Checked);
      this.o_BE_TR1_CFGVARIABLES.set_ShowCommand(this.CheckBox_NotShowCommand.Checked);
      this.o_BE_TR1_CFGVARIABLES.set_DeleteItem(this.CheckBox_DeleteItem.Checked);
      this.o_BE_TR1_CFGVARIABLES.set_ShowUserDeleteDocument(this.CheckBox_DeleteDocument.Checked);
      this.o_BE_TR1_CFGVARIABLES.set_ShowUserChangePrice(this.CheckBox_ChangePrice.Checked);
      this.o_BE_TR1_CFGVARIABLES.set_IsBarCode(this.CheckBox_IsBarCode.Checked);
      this.o_BE_TR1_CFGVARIABLES.set_ShowUserDocuIntern(this.CheckBox_DocuIntern.Checked);
      this.o_BE_TR1_CFGVARIABLES.set_ShowUserDeleteOrder(this.CheckBox_DeleteOrder.Checked);
      this.o_BE_TR1_CFGVARIABLES.set_IsTouchScreen(this.RadioButton_Yes.Checked);
      this.o_BE_TR1_CFGVARIABLES.set_IsPrintDeleteItem(this.CheckBox_IsPrintDeleteItem.Checked);
      this.o_BE_TR1_CFGVARIABLES.set_IsFirstPay(this.CheckBox_IsFirstPay.Checked);
      this.o_BE_TR1_CFGVARIABLES.set_IsDobleCommand(this.CheckBox_IsDobleCommand.Checked);
      this.o_BE_TR1_CFGVARIABLES.set_IsAmountMin(this.CheckBox_IsAmountMin.Checked);
      this.o_BE_TR1_CFGVARIABLES.set_AmountMin(ModGeneralFunctions.CadenaToDouble(this.TextBox_AmountMin.Text));
      this.o_BE_TR1_CFGVARIABLES.set_IsWaiterShowSale(this.CheckBox_IsWaiterShowSale.Checked);
      this.o_BE_TR1_CFGVARIABLES.set_CantLineComHeader(ModGeneralFunctions.CadenaToInteger(this.TextBox_CantLineComHeader.Text));
      this.o_BE_TR1_CFGVARIABLES.set_CantLineComFooter(ModGeneralFunctions.CadenaToInteger(this.TextBox_CantLineComFooter.Text));
      this.o_BE_TR1_CFGVARIABLES.set_CantPrintCommand(ModGeneralFunctions.CadenaToInteger(this.ComboBox_CantPrintCommand.Text));
      this.o_BE_TR1_CFGVARIABLES.set_MostrarUsuarioPrecuenta(this.CheckBox_ImprimirPrecuenta.Checked);
      this.o_BE_TR1_CFGVARIABLES.set_EsPedidoLibreRapido(this.chbEsPedidoLibreRapido.Checked);
      this.o_BE_TR1_CFGVARIABLES.set_ConfirmarComanda(this.chbConfirmarComanda.Checked);
      this.o_BE_TR1_CFGVARIABLES.set_ConfirmarDivCuentas(this.chbConfirmarDivCuentas.Checked);
      this.o_BE_TR1_CFGVARIABLES.set_ConfirmarTransfMesas(this.chbConfirmarTransfMesas.Checked);
      this.o_BE_TR1_CFGVARIABLES.set_ConfirmarDocumento(this.chbConfirmarDocumento.Checked);
      this.o_BE_TR1_CFGVARIABLES.set_ConfirmarPago(this.chbConfirmarPago.Checked);
      this.o_BE_TR1_CFGVARIABLES.set_ConfirmarPedido(this.chbConfirmarPedido.Checked);
      this.o_BE_TR1_CFGVARIABLES.set_MozoObservaPrecios(this.chbMozoObservaPrecios.Checked);
      this.o_BE_TR1_CFGVARIABLES.set_TipoPedidoDefecto(Conversions.ToString(this.cboTiposPedido.SelectedValue));
      this.o_BE_TR1_CFGVARIABLES.set_TiempoEsperaDelivery(ModGeneralFunctions.CadenaToInteger(this.txtTiempoEsperaDelivery.Text));
      this.o_BE_TR1_CFGVARIABLES.set_SeleccionarMesaxDiseno(this.chbSeleccionarMesaxDiseno.Checked);
      if (this.o_BE_TR1_CFGVARIABLES.get_TiempoEsperaDelivery() == 0)
        ModGeneralFunctions.ActualizarDeliveryOnLine(false);
      this.o_BE_TR1_CFGVARIABLES.set_MostrarMensajeTNS(this.CheckBox_MensajeTNS_True.Checked);
      this.o_BE_TR1_CFGVARIABLES.set_EsMonitor(this.chbEsMonitor.Checked);
      this.o_BE_TR1_CFGVARIABLES.set_TiempoEsperaMonitor(ModGeneralFunctions.CadenaToInteger(((TextBox) this.txtTiempoEsperaMonitor).Text));
      this.o_BE_TR1_CFGVARIABLES.set_TiempoAlertaMonitor(ModGeneralFunctions.CadenaToInteger(((TextBox) this.txtTiempoAlertaMonitor).Text));
      this.str_Result = this.o_CL_CFGVARIABLES.EditMensaje(ref this.o_BE_TR1_CFGVARIABLES, ref this.o_BE_TR1_BOXES, this.TextBox_MensajePrecuenta.Text.Trim());
      if (!this.str_Result.Equals(StructApp.RESULT_OK))
      {
        ModGeneralFunctions.MessageOk(this.str_Result);
      }
      else
      {
        if (!this._IsAdvanced)
        {
          ModGeneralVar.g_BE_TR1_CFGVARIABLES = this.o_BE_TR1_CFGVARIABLES;
          ModGeneralVar.g_BE_TR1_BOXES = this.o_BE_TR1_BOXES;
        }
        ModGeneralVar.g_BE_TR1_VARPREBILL.set_MensajePersonalizado(this.TextBox_MensajePrecuenta.Text.Trim());
        this.o_BE_TR1_CFGVARIABLES.set_MensajePersonalizado(this.TextBox_MensajePrecuenta.Text.Trim());
        ModGeneralFunctions.MessageOk("¡Conf. Caja Actualizada!");
        ModGeneralVar.g_TimerCounter = 0L;
        this.Close();
      }
      ModGeneralVar.g_CantProgramAlert = Conversions.ToInteger(ModGeneralVar.g_BE_TR1_CFGVARIABLES.get_CantAlertProgram());
    }

    private bool ValidData()
    {
      if (ModGeneralFunctions.CadenaToInteger(this.TextBox_PrinterPrecountId.Text) == 0)
      {
        ModGeneralFunctions.MessageOk("¡Seleccionar Impresora para Precuentas!");
        this.Button_SearchPrinters.Focus();
        return false;
      }
      if (ModGeneralFunctions.CadenaToInteger(this.TextBox_PrinterInvoiceId.Text) == 0)
      {
        ModGeneralFunctions.MessageOk("¡Seleccionar Impresora para Facturas!");
        this.Button_PrinterForDocu.Focus();
        return false;
      }
      if (ModGeneralFunctions.CadenaToInteger(this.TextBox_PrinterTicketId.Text) == 0)
      {
        ModGeneralFunctions.MessageOk("¡Seleccionar Impresora para Boletas!");
        this.Button_PrinterForTicket.Focus();
        return false;
      }
      if (!ModGeneralVar.g_BE_TR1_VARIABLES_B.get_IsPrintCentral() && !this.ValidarNumeroSerie())
        return false;
      if (!(this.chbEsMonitor.Checked & ModGeneralFunctions.CadenaToInteger(((TextBox) this.txtTiempoEsperaMonitor).Text) <= 0))
        return true;
      ModGeneralFunctions.MessageOk("¡Ingrese Tiempo de espera de Monitor!");
      this.tbcVariables.SelectedIndex = 4;
      ((Control) this.txtTiempoEsperaMonitor).Focus();
      return false;
    }

    private bool ValidarNumeroSerie()
    {
      string p_Mensaje = this.o_CL_CFGVARIABLES.ValidarNumeroSerie(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId(), this.o_BE_TR1_CFGVARIABLES.get_BoxId(), "", "");
      if (p_Mensaje.Equals(""))
        return true;
      ModGeneralFunctions.MessageOk(p_Mensaje);
      return false;
    }

    private void CheckBox_IsPeople_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckBox_IsPeople.Checked)
        this.CheckBox_IsPeoppleNot.CheckState = CheckState.Unchecked;
      else
        this.CheckBox_IsPeoppleNot.CheckState = CheckState.Checked;
    }

    private void CheckBox_ShowGroup_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckBox_ShowGroup.Checked)
        this.CheckBox_ShowGroupNot.CheckState = CheckState.Unchecked;
      else
        this.CheckBox_ShowGroupNot.CheckState = CheckState.Checked;
    }

    private void CheckBox_IsPeoppleNot_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckBox_IsPeoppleNot.Checked)
        this.CheckBox_IsPeople.CheckState = CheckState.Unchecked;
      else
        this.CheckBox_IsPeople.CheckState = CheckState.Checked;
    }

    private void CheckBox_ShowGroupNot_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckBox_ShowGroupNot.Checked)
        this.CheckBox_ShowGroup.CheckState = CheckState.Unchecked;
      else
        this.CheckBox_ShowGroup.CheckState = CheckState.Checked;
    }

    private void CheckBox_ShowPay_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckBox_ShowPay.Checked)
        this.CheckBox_ShowNotPay.CheckState = CheckState.Unchecked;
      else
        this.CheckBox_ShowNotPay.CheckState = CheckState.Checked;
    }

    private void CheckBox_ShowNotPay_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckBox_ShowNotPay.Checked)
        this.CheckBox_ShowPay.CheckState = CheckState.Unchecked;
      else
        this.CheckBox_ShowPay.CheckState = CheckState.Checked;
    }

    private void CheckBox_NotBoxWaiter_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckBox_NotBoxWaiter.Checked)
        this.CheckBox_BoxWaiter.CheckState = CheckState.Unchecked;
      else
        this.CheckBox_BoxWaiter.CheckState = CheckState.Checked;
    }

    private void CheckBox_BoxWaiter_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckBox_BoxWaiter.Checked)
        this.CheckBox_NotBoxWaiter.CheckState = CheckState.Unchecked;
      else
        this.CheckBox_NotBoxWaiter.CheckState = CheckState.Checked;
    }

    private void Button_Quantity_Click(object sender, EventArgs e)
    {
      ModGeneralFunctions.NumberKeyBoard("Ingrese Cant. Progra. para Alerta de Stock", false);
      if (!ModGeneralVar.g_bol_IsReady)
        return;
      this.TextBox_QuantitytAlert.Text = ModGeneralVar.g_str_InputValue;
      this.TextBox_CantLineComHeader.Focus();
    }

    private void CheckBox_Matricial_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckBox_Matricial.Checked)
        this.CheckBox_NotMatricial.CheckState = CheckState.Unchecked;
      else
        this.CheckBox_NotMatricial.CheckState = CheckState.Checked;
    }

    private void CheckBox_NotMatricial_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckBox_NotMatricial.Checked)
        this.CheckBox_Matricial.CheckState = CheckState.Unchecked;
      else
        this.CheckBox_Matricial.CheckState = CheckState.Checked;
    }

    private void CheckBoxShowConsume_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckBoxShowConsume.Checked)
        this.CheckBoxShowNotConsume.CheckState = CheckState.Unchecked;
      else
        this.CheckBoxShowNotConsume.CheckState = CheckState.Checked;
    }

    private void CheckBoxShowNotConsume_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckBoxShowNotConsume.Checked)
        this.CheckBoxShowConsume.CheckState = CheckState.Unchecked;
      else
        this.CheckBoxShowConsume.CheckState = CheckState.Checked;
    }

    private void CheckBox_ShowCommand_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckBox_NotShowCommand.Checked)
        this.CheckBox_ShowCommand.CheckState = CheckState.Unchecked;
      else
        this.CheckBox_ShowCommand.CheckState = CheckState.Checked;
    }

    private void CheckBox_NotShowCommand_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckBox_ShowCommand.Checked)
        this.CheckBox_NotShowCommand.CheckState = CheckState.Unchecked;
      else
        this.CheckBox_NotShowCommand.CheckState = CheckState.Checked;
    }

    private void Button_GoOut_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void CheckBox_DeleteItem_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckBox_DeleteItem.Checked)
        this.CheckBox_NotDeleteItem.CheckState = CheckState.Unchecked;
      else
        this.CheckBox_NotDeleteItem.CheckState = CheckState.Checked;
    }

    private void CheckBox_NotDeleteItem_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckBox_NotDeleteItem.Checked)
        this.CheckBox_DeleteItem.CheckState = CheckState.Unchecked;
      else
        this.CheckBox_DeleteItem.CheckState = CheckState.Checked;
    }

    private void CheckBox_DeleteDocument_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckBox_DeleteDocument.Checked)
        this.CheckBox_NotDeleteDocument.CheckState = CheckState.Unchecked;
      else
        this.CheckBox_NotDeleteDocument.CheckState = CheckState.Checked;
    }

    private void CheckBox_NotDeleteDocument_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckBox_NotDeleteDocument.Checked)
        this.CheckBox_DeleteDocument.CheckState = CheckState.Unchecked;
      else
        this.CheckBox_DeleteDocument.CheckState = CheckState.Checked;
    }

    private void CheckBox_ChangePrice_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckBox_ChangePrice.Checked)
        this.CheckBox_NotChangePrice.CheckState = CheckState.Unchecked;
      else
        this.CheckBox_NotChangePrice.CheckState = CheckState.Checked;
    }

    private void CheckBox_NotChangePrice_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckBox_NotChangePrice.Checked)
        this.CheckBox_ChangePrice.CheckState = CheckState.Unchecked;
      else
        this.CheckBox_ChangePrice.CheckState = CheckState.Checked;
    }

    private void Button_PrinterForTicket_Click(object sender, EventArgs e)
    {
      FrmPrinters frmPrinters = new FrmPrinters()
      {
        _OnlySearch = true,
        _OnlyforDocuments = true
      };
      frmPrinters._OnlySearch = true;
      frmPrinters._BoxId = !this._IsAdvanced ? ModGeneralVar.g_BE_TR1_CFGVARIABLES.get_BoxIdPos() : this._BoxId;
      int num = (int) frmPrinters.ShowDialog();
      frmPrinters.Dispose();
      if (!ModGeneralVar.g_bol_IsReady)
        return;
      this.TextBox_PrinterTicketId.Text = ModGeneralVar.g_Str_RecordID;
      this.TextBox_ForTicket.Text = ModGeneralVar.g_Str_RecordDes;
      this.btnAgregarSerieFactura.Focus();
    }

    private void CheckBox_IsBarCode_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckBox_IsBarCode.Checked)
        this.CheckBox_NotBarCode.CheckState = CheckState.Unchecked;
      else
        this.CheckBox_NotBarCode.CheckState = CheckState.Checked;
    }

    private void CheckBox_NotBarCode_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckBox_NotBarCode.Checked)
        this.CheckBox_IsBarCode.CheckState = CheckState.Unchecked;
      else
        this.CheckBox_IsBarCode.CheckState = CheckState.Checked;
    }

    private void CheckBox_DocuIntern_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckBox_DocuIntern.Checked)
        this.CheckBox_NotDocuIntern.CheckState = CheckState.Unchecked;
      else
        this.CheckBox_NotDocuIntern.CheckState = CheckState.Checked;
    }

    private void CheckBox_NotDocuIntern_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckBox_NotDocuIntern.Checked)
        this.CheckBox_DocuIntern.CheckState = CheckState.Unchecked;
      else
        this.CheckBox_DocuIntern.CheckState = CheckState.Checked;
    }

    private void CheckBox_DeleteOrder_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckBox_DeleteOrder.Checked)
        this.CheckBox_NotDeleteOrder.CheckState = CheckState.Unchecked;
      else
        this.CheckBox_NotDeleteOrder.CheckState = CheckState.Checked;
    }

    private void CheckBox_NotDeleteOrder_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckBox_NotDeleteOrder.Checked)
        this.CheckBox_DeleteOrder.CheckState = CheckState.Unchecked;
      else
        this.CheckBox_DeleteOrder.CheckState = CheckState.Checked;
    }

    private void FrmCfgSystem_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyValue != 27)
        return;
      this.Close();
    }

    private void CheckBox_IsPrintDeleteItem_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckBox_IsPrintDeleteItem.Checked)
        this.CheckBox_IsNotPrintDeleteItem.CheckState = CheckState.Unchecked;
      else
        this.CheckBox_IsNotPrintDeleteItem.CheckState = CheckState.Checked;
    }

    private void CheckBox_IsNotPrintDeleteItem_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckBox_IsNotPrintDeleteItem.Checked)
        this.CheckBox_IsPrintDeleteItem.CheckState = CheckState.Unchecked;
      else
        this.CheckBox_IsPrintDeleteItem.CheckState = CheckState.Checked;
    }

    private void Button_CfgPreBill_Click(object sender, EventArgs e)
    {
      FrmCfgPreBill frmCfgPreBill = new FrmCfgPreBill();
      frmCfgPreBill._IsAdvanced = this._IsAdvanced;
      frmCfgPreBill._BoxId = this.o_BE_TR1_BOXES.get_BoxId();
      int num = (int) frmCfgPreBill.ShowDialog();
      frmCfgPreBill.Dispose();
    }

    private void Button_CfgDocument_Click(object sender, EventArgs e)
    {
      FrmCfgDocument frmCfgDocument = new FrmCfgDocument();
      frmCfgDocument._IsAdvanced = this._IsAdvanced;
      frmCfgDocument._BoxId = this.o_BE_TR1_BOXES.get_BoxId();
      int num = (int) frmCfgDocument.ShowDialog();
      frmCfgDocument.Dispose();
    }

    private void CheckBox_IsDobleCommand_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckBox_IsDobleCommand.Checked)
      {
        this.CheckBox_IsNotDobleCommand.CheckState = CheckState.Unchecked;
        this.ComboBox_CantPrintCommand.Enabled = true;
      }
      else
      {
        this.CheckBox_IsNotDobleCommand.CheckState = CheckState.Checked;
        this.ComboBox_CantPrintCommand.Enabled = true;
      }
    }

    private void CheckBox_IsNotDobleCommand_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckBox_IsNotDobleCommand.Checked)
      {
        this.CheckBox_IsDobleCommand.CheckState = CheckState.Unchecked;
        this.ComboBox_CantPrintCommand.Enabled = false;
      }
      else
      {
        this.CheckBox_IsDobleCommand.CheckState = CheckState.Checked;
        this.ComboBox_CantPrintCommand.Enabled = true;
      }
    }

    private void CheckBox_IsFirstPay_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckBox_IsFirstPay.Checked)
        this.CheckBox_IsNotFirstPay.CheckState = CheckState.Unchecked;
      else
        this.CheckBox_IsNotFirstPay.CheckState = CheckState.Checked;
    }

    private void CheckBox_IsNotFirstPay_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckBox_IsNotFirstPay.Checked)
        this.CheckBox_IsFirstPay.CheckState = CheckState.Unchecked;
      else
        this.CheckBox_IsFirstPay.CheckState = CheckState.Checked;
    }

    private void CheckBox_IsWaiterShowSale_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckBox_IsWaiterShowSale.Checked)
        this.CheckBox_IsNotWaiterShowSale.CheckState = CheckState.Unchecked;
      else
        this.CheckBox_IsNotWaiterShowSale.CheckState = CheckState.Checked;
    }

    private void CheckBox_IsNotWaiterShowSale_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckBox_IsNotWaiterShowSale.Checked)
        this.CheckBox_IsWaiterShowSale.CheckState = CheckState.Unchecked;
      else
        this.CheckBox_IsWaiterShowSale.CheckState = CheckState.Checked;
    }

    private void Button_AmountMin_Click(object sender, EventArgs e)
    {
      ModGeneralFunctions.NumberKeyBoard("Ingrese Monto Mínimo", true);
      if (!ModGeneralVar.g_bol_IsReady)
        return;
      this.TextBox_AmountMin.Text = Strings.FormatNumber((object) ModGeneralVar.g_str_InputValue, 2, TriState.UseDefault, TriState.UseDefault, TriState.UseDefault);
      this.Button_Save.Focus();
    }

    private void Button_CantLineComHeader_Click(object sender, EventArgs e)
    {
      ModGeneralFunctions.NumberKeyBoard("Ingrese Cant. Lineas - Cabecera Impresión", false);
      if (!ModGeneralVar.g_bol_IsReady)
        return;
      this.TextBox_CantLineComHeader.Text = ModGeneralVar.g_str_InputValue;
      this.TextBox_CantLineComHeader.Focus();
    }

    private void Button_CantLineComFooter_Click(object sender, EventArgs e)
    {
      ModGeneralFunctions.NumberKeyBoard("Ingrese Cant. Lineas - Pie Impresión", false);
      if (!ModGeneralVar.g_bol_IsReady)
        return;
      this.TextBox_CantLineComFooter.Text = ModGeneralVar.g_str_InputValue;
      this.TextBox_AmountMin.Focus();
    }

    private void btnAgregarSerieFactura_Click(object sender, EventArgs e)
    {
      this.InsertarNumeroSerie(ModGeneralVar.g_GeneralCode.get_Docu_Invoice());
    }

    private void btnEliminarSerieFactura_Click(object sender, EventArgs e)
    {
      if (!ModGeneralFunctions.DataGrid_Validated(this.dgvNumeroSerieFactura))
        return;
      this.EliminarNumeroSerie(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgvNumeroSerieFactura.DataSource, new object[1]
      {
        (object) this.dgvNumeroSerieFactura.CurrentRow.Index
      }, (string[]) null), (System.Type) null, "NumeroSerie", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)), ModGeneralVar.g_GeneralCode.get_Docu_Invoice(), (Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgvNumeroSerieFactura.DataSource, new object[1]
      {
        (object) this.dgvNumeroSerieFactura.CurrentRow.Index
      }, (string[]) null), (System.Type) null, "ExoneradoImp1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)) ? 1 : 0) != 0);
    }

    private void dgvNumeroSerieFactura_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (!ModGeneralFunctions.DataGrid_Validated(this.dgvNumeroSerieFactura))
        return;
      this.ActualizarNumeroSerie(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgvNumeroSerieFactura.DataSource, new object[1]
      {
        (object) this.dgvNumeroSerieFactura.CurrentRow.Index
      }, (string[]) null), (System.Type) null, "NumeroSerie", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)), ModGeneralVar.g_GeneralCode.get_Docu_Invoice(), (Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgvNumeroSerieFactura.DataSource, new object[1]
      {
        (object) this.dgvNumeroSerieFactura.CurrentRow.Index
      }, (string[]) null), (System.Type) null, "ExoneradoImp1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)) ? 1 : 0) != 0);
    }

    private void btnAgregarSerieBoleta_Click(object sender, EventArgs e)
    {
      this.InsertarNumeroSerie(ModGeneralVar.g_GeneralCode.get_Docu_Ticket());
    }

    private void btnEliminarSerieBoleta_Click(object sender, EventArgs e)
    {
      if (!ModGeneralFunctions.DataGrid_Validated(this.dgvNumeroSerieBoleta))
        return;
      this.EliminarNumeroSerie(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgvNumeroSerieBoleta.DataSource, new object[1]
      {
        (object) this.dgvNumeroSerieBoleta.CurrentRow.Index
      }, (string[]) null), (System.Type) null, "NumeroSerie", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)), ModGeneralVar.g_GeneralCode.get_Docu_Ticket(), (Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgvNumeroSerieBoleta.DataSource, new object[1]
      {
        (object) this.dgvNumeroSerieBoleta.CurrentRow.Index
      }, (string[]) null), (System.Type) null, "ExoneradoImp1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)) ? 1 : 0) != 0);
    }

    private void dgvNumeroSerieBoleta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (!ModGeneralFunctions.DataGrid_Validated(this.dgvNumeroSerieBoleta))
        return;
      this.ActualizarNumeroSerie(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgvNumeroSerieBoleta.DataSource, new object[1]
      {
        (object) this.dgvNumeroSerieBoleta.CurrentRow.Index
      }, (string[]) null), (System.Type) null, "NumeroSerie", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)), ModGeneralVar.g_GeneralCode.get_Docu_Ticket(), (Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgvNumeroSerieBoleta.DataSource, new object[1]
      {
        (object) this.dgvNumeroSerieBoleta.CurrentRow.Index
      }, (string[]) null), (System.Type) null, "ExoneradoImp1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)) ? 1 : 0) != 0);
    }

    private void InsertarNumeroSerie(string pstrTipoDocumentoId)
    {
      string str1 = "";
      string str2 = "";
      ModGeneralFunctions.TextKeyBoard("INGRESE NUMERO DE SERIE", ref str2);
      if (!ModGeneralVar.g_bol_IsReady)
        return;
      if (ModGeneralFunctions.CadenaToInteger(ModGeneralVar.g_str_InputValue) > 0 | ModGeneralFunctions.CadenaToInteger(ModGeneralVar.g_str_InputValue) < 1000)
      {
        string str3 = "000" + ModGeneralVar.g_str_InputValue;
        str1 = str3.Substring(checked (str3.Length - 3));
      }
      else
      {
        ModGeneralFunctions.MessageOk("¡El Numero de Serie no es válido!");
        this.InsertarNumeroSerie(pstrTipoDocumentoId);
      }
      BL_TR1_CONFIGURATION tr1Configuration = new BL_TR1_CONFIGURATION();
      BE_TR1_GENERALCODE beTr1Generalcode = new BE_TR1_GENERALCODE();
      string varTax1 = ModGeneralVar.g_BE_TR1_VARIABLES_B.get_VarTax1();
      bool flag = ModGeneralFunctions.MessageMakeAction("¿Nº de Serie " + str1 + ", Exonerada de " + varTax1 + "?", false);
      beTr1Generalcode.set_EstabliId(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId());
      beTr1Generalcode.set_BoxId(ModGeneralVar.g_BE_TR1_CFGVARIABLES.get_BoxIdPos());
      beTr1Generalcode.set_CodeId(pstrTipoDocumentoId);
      beTr1Generalcode.set_NumeroSerie(str1);
      beTr1Generalcode.set_ExoneradoImp1(flag);
      string p_Mensaje = tr1Configuration.InsertarNumeroSerie(beTr1Generalcode);
      if (p_Mensaje.Equals(StructApp.RESULT_OK))
      {
        if (pstrTipoDocumentoId.Equals(ModGeneralVar.g_GeneralCode.get_Docu_Ticket()))
          this.CargarNumeroSerieBoleta();
        else if (pstrTipoDocumentoId.Equals(ModGeneralVar.g_GeneralCode.get_Docu_Invoice()))
          this.CargarNumeroSerieFactura();
      }
      else
        ModGeneralFunctions.MessageOk(p_Mensaje);
    }

    private void ActualizarNumeroSerie(
      string pstrNumeroSerie,
      string pstrTipoDocumentoId,
      bool pbolExoneradoImp1)
    {
      string str1 = "";
      string str2 = "";
      ModGeneralFunctions.TextKeyBoard("INGRESE NUEVO NUMERO DE SERIE", ref str2);
      if (!ModGeneralVar.g_bol_IsReady)
        return;
      if (ModGeneralFunctions.CadenaToInteger(ModGeneralVar.g_str_InputValue) > 0 | ModGeneralFunctions.CadenaToInteger(ModGeneralVar.g_str_InputValue) < 1000)
      {
        string str3 = "000" + ModGeneralVar.g_str_InputValue;
        str1 = str3.Substring(checked (str3.Length - 3));
      }
      else
      {
        ModGeneralFunctions.MessageOk("¡El Número de Serie no es válido!");
        this.InsertarNumeroSerie(pstrTipoDocumentoId);
      }
      BL_TR1_CONFIGURATION tr1Configuration = new BL_TR1_CONFIGURATION();
      BE_TR1_GENERALCODE beTr1Generalcode = new BE_TR1_GENERALCODE();
      string varTax1 = ModGeneralVar.g_BE_TR1_VARIABLES_B.get_VarTax1();
      bool flag1 = ModGeneralFunctions.MessageMakeAction("¿Nº de Serie " + str1 + ", Exonerada de " + varTax1 + "?", false);
      bool flag2 = ModGeneralFunctions.MessageMakeAction("¿Nº de Serie " + str1 + ", Activo?", false);
      beTr1Generalcode.set_EstabliId(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId());
      beTr1Generalcode.set_BoxId(ModGeneralVar.g_BE_TR1_CFGVARIABLES.get_BoxIdPos());
      beTr1Generalcode.set_CodeId(pstrTipoDocumentoId);
      beTr1Generalcode.set_NumeroSerie(pstrNumeroSerie);
      beTr1Generalcode.set_NumeroSerieNuevo(str1);
      beTr1Generalcode.set_ExoneradoImp1(pbolExoneradoImp1);
      beTr1Generalcode.set_ExoneradoImp1Nuevo(flag1);
      beTr1Generalcode.set_EsActivo(flag2);
      string p_Mensaje = tr1Configuration.ActualizarNumeroSerie(beTr1Generalcode);
      if (p_Mensaje.Equals(StructApp.RESULT_OK))
      {
        if (pstrTipoDocumentoId.Equals(ModGeneralVar.g_GeneralCode.get_Docu_Ticket()))
          this.CargarNumeroSerieBoleta();
        else if (pstrTipoDocumentoId.Equals(ModGeneralVar.g_GeneralCode.get_Docu_Invoice()))
          this.CargarNumeroSerieFactura();
      }
      else
      {
        if (pstrTipoDocumentoId.Equals(ModGeneralVar.g_GeneralCode.get_Docu_Ticket()))
          this.CargarNumeroSerieBoleta();
        else if (pstrTipoDocumentoId.Equals(ModGeneralVar.g_GeneralCode.get_Docu_Invoice()))
          this.CargarNumeroSerieFactura();
        ModGeneralFunctions.MessageError_Large(p_Mensaje, true);
      }
    }

    private void EliminarNumeroSerie(
      string pstrNumeroSerie,
      string pstrTipoDocumentoId,
      bool pbolExoneradoImp1)
    {
      if (!ModGeneralFunctions.MessageMakeAction("¿Seguro de Eliminar la Serie " + pstrNumeroSerie + "?", false))
        return;
      BL_TR1_CONFIGURATION tr1Configuration = new BL_TR1_CONFIGURATION();
      BE_TR1_GENERALCODE beTr1Generalcode = new BE_TR1_GENERALCODE();
      beTr1Generalcode.set_EstabliId(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId());
      beTr1Generalcode.set_BoxId(ModGeneralVar.g_BE_TR1_CFGVARIABLES.get_BoxIdPos());
      beTr1Generalcode.set_CodeId(pstrTipoDocumentoId);
      beTr1Generalcode.set_NumeroSerie(pstrNumeroSerie);
      beTr1Generalcode.set_ExoneradoImp1(pbolExoneradoImp1);
      string p_Mensaje = tr1Configuration.EliminarNumeroSerie(beTr1Generalcode);
      if (p_Mensaje.Equals(StructApp.RESULT_OK))
      {
        if (pstrTipoDocumentoId.Equals(ModGeneralVar.g_GeneralCode.get_Docu_Ticket()))
        {
          this.CargarNumeroSerieBoleta();
        }
        else
        {
          if (!pstrTipoDocumentoId.Equals(ModGeneralVar.g_GeneralCode.get_Docu_Invoice()))
            return;
          this.CargarNumeroSerieFactura();
        }
      }
      else
        ModGeneralFunctions.MessageError_Large(p_Mensaje, true);
    }

    private void chbEsPedidoLibreRapido_CheckedChanged(object sender, EventArgs e)
    {
      if (this.chbEsPedidoLibreRapido.Checked)
        this.chbNoEsPedidoLibreRapido.CheckState = CheckState.Unchecked;
      else
        this.chbNoEsPedidoLibreRapido.CheckState = CheckState.Checked;
    }

    private void chbNoEsPedidoLibreRapido_CheckedChanged(object sender, EventArgs e)
    {
      if (this.chbNoEsPedidoLibreRapido.Checked)
        this.chbEsPedidoLibreRapido.CheckState = CheckState.Unchecked;
      else
        this.chbEsPedidoLibreRapido.CheckState = CheckState.Checked;
    }

    private void chbConfirmarComanda_CheckedChanged(object sender, EventArgs e)
    {
      if (this.chbConfirmarComanda.Checked)
        this.chbNoConfirmarComanda.CheckState = CheckState.Unchecked;
      else
        this.chbNoConfirmarComanda.CheckState = CheckState.Checked;
    }

    private void chbNoConfirmarComanda_CheckedChanged(object sender, EventArgs e)
    {
      if (this.chbNoConfirmarComanda.Checked)
        this.chbConfirmarComanda.CheckState = CheckState.Unchecked;
      else
        this.chbConfirmarComanda.CheckState = CheckState.Checked;
    }

    private void chbConfirmarDivCuentas_CheckedChanged(object sender, EventArgs e)
    {
      if (this.chbConfirmarDivCuentas.Checked)
        this.chbNoConfirmarDivCuentas.CheckState = CheckState.Unchecked;
      else
        this.chbNoConfirmarDivCuentas.CheckState = CheckState.Checked;
    }

    private void chbNoConfirmarDivCuentas_CheckedChanged(object sender, EventArgs e)
    {
      if (this.chbNoConfirmarDivCuentas.Checked)
        this.chbConfirmarDivCuentas.CheckState = CheckState.Unchecked;
      else
        this.chbConfirmarDivCuentas.CheckState = CheckState.Checked;
    }

    private void chbConfirmarTransfMesas_CheckedChanged(object sender, EventArgs e)
    {
      if (this.chbConfirmarTransfMesas.Checked)
        this.chbNoConfirmarTransfMesas.CheckState = CheckState.Unchecked;
      else
        this.chbNoConfirmarTransfMesas.CheckState = CheckState.Checked;
    }

    private void chbNoConfirmarTransfMesas_CheckedChanged(object sender, EventArgs e)
    {
      if (this.chbNoConfirmarTransfMesas.Checked)
        this.chbConfirmarTransfMesas.CheckState = CheckState.Unchecked;
      else
        this.chbConfirmarTransfMesas.CheckState = CheckState.Checked;
    }

    private void chbConfirmarDocumento_CheckedChanged(object sender, EventArgs e)
    {
      if (this.chbConfirmarDocumento.Checked)
        this.chbNoConfirmarDocumento.CheckState = CheckState.Unchecked;
      else
        this.chbNoConfirmarDocumento.CheckState = CheckState.Checked;
    }

    private void chbNoConfirmarDocumento_CheckedChanged(object sender, EventArgs e)
    {
      if (this.chbNoConfirmarDocumento.Checked)
        this.chbConfirmarDocumento.CheckState = CheckState.Unchecked;
      else
        this.chbConfirmarDocumento.CheckState = CheckState.Checked;
    }

    private void chbConfirmarPago_CheckedChanged(object sender, EventArgs e)
    {
      if (this.chbConfirmarPago.Checked)
        this.chbNoConfirmarPago.CheckState = CheckState.Unchecked;
      else
        this.chbNoConfirmarPago.CheckState = CheckState.Checked;
    }

    private void chbNoConfirmarPago_CheckedChanged(object sender, EventArgs e)
    {
      if (this.chbNoConfirmarPago.Checked)
        this.chbConfirmarPago.CheckState = CheckState.Unchecked;
      else
        this.chbConfirmarPago.CheckState = CheckState.Checked;
    }

    private void chbConfirmarPedido_CheckedChanged(object sender, EventArgs e)
    {
      if (this.chbConfirmarPedido.Checked)
        this.chbNoConfirmarPedido.CheckState = CheckState.Unchecked;
      else
        this.chbNoConfirmarPedido.CheckState = CheckState.Checked;
    }

    private void chbNoConfirmarPedido_CheckedChanged(object sender, EventArgs e)
    {
      if (this.chbNoConfirmarPedido.Checked)
        this.chbConfirmarPedido.CheckState = CheckState.Unchecked;
      else
        this.chbConfirmarPedido.CheckState = CheckState.Checked;
    }

    private void chbMozoObservaPrecios_CheckedChanged(object sender, EventArgs e)
    {
      if (this.chbMozoObservaPrecios.Checked)
        this.chbNoMozoObservaPrecios.CheckState = CheckState.Unchecked;
      else
        this.chbNoMozoObservaPrecios.CheckState = CheckState.Checked;
    }

    private void chbNoMozoObservaPrecios_CheckedChanged(object sender, EventArgs e)
    {
      if (this.chbNoMozoObservaPrecios.Checked)
        this.chbMozoObservaPrecios.CheckState = CheckState.Unchecked;
      else
        this.chbMozoObservaPrecios.CheckState = CheckState.Checked;
    }

    private void CargarTiposPedido()
    {
      List<BE_TR1_ORDER_TYPE> beTr1OrderTypeList = new BL_TR1_ORDER_TYPE().ListbyAll() ?? new List<BE_TR1_ORDER_TYPE>();
      beTr1OrderTypeList.Insert(0, new BE_TR1_ORDER_TYPE("", "«Seleccione»"));
      this.cboTiposPedido.ValueMember = "TypeOrderId";
      this.cboTiposPedido.DisplayMember = "TypeOrderDes";
      this.cboTiposPedido.DataSource = (object) beTr1OrderTypeList;
    }

    private void cboTiposPedido_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.cboTiposPedido.SelectedValue.Equals((object) ModGeneralVar.g_Str_OrderTypeDelivery))
        this.HabilitarTiempoEsperaDelivery(true);
      else
        this.HabilitarTiempoEsperaDelivery(false);
    }

    private void HabilitarTiempoEsperaDelivery(bool pbolHabilitar)
    {
      this.txtTiempoEsperaDelivery.Enabled = pbolHabilitar;
      this.lblTiempoEsperaDelivery.Enabled = pbolHabilitar;
      this.lblSegundosEsperaDelivery.Enabled = pbolHabilitar;
    }

    private void btnTiempoEsperaDelivery_Click(object sender, EventArgs e)
    {
      ModGeneralFunctions.NumberKeyBoard("Ingrese Cant. Segundos - Delivery", false);
      if (!ModGeneralVar.g_bol_IsReady)
        return;
      this.txtTiempoEsperaDelivery.Text = ModGeneralVar.g_str_InputValue;
      this.Button_Save.Focus();
    }

    private void chbSeleccionarMesaxDiseno_CheckedChanged(object sender, EventArgs e)
    {
      if (this.chbSeleccionarMesaxDiseno.Checked)
        this.chbNoSeleccionarMesaxDiseno.CheckState = CheckState.Unchecked;
      else
        this.chbNoSeleccionarMesaxDiseno.CheckState = CheckState.Checked;
    }

    private void chbNoSeleccionarMesaxDiseno_CheckedChanged(object sender, EventArgs e)
    {
      if (this.chbNoSeleccionarMesaxDiseno.Checked)
        this.chbSeleccionarMesaxDiseno.CheckState = CheckState.Unchecked;
      else
        this.chbSeleccionarMesaxDiseno.CheckState = CheckState.Checked;
    }

    private void CheckBox_IsAmountMin_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckBox_IsAmountMin.Checked)
      {
        this.CheckBox_IsNotAmountMin.CheckState = CheckState.Unchecked;
        this.TextBox_AmountMin.Enabled = true;
        this.Button_AmountMin.Enabled = true;
      }
      else
      {
        this.CheckBox_IsNotAmountMin.CheckState = CheckState.Checked;
        this.TextBox_AmountMin.Enabled = false;
        this.Button_AmountMin.Enabled = false;
      }
    }

    private void CheckBox_IsNotAmountMin_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckBox_IsNotAmountMin.Checked)
        this.CheckBox_IsAmountMin.CheckState = CheckState.Unchecked;
      else
        this.CheckBox_IsAmountMin.CheckState = CheckState.Checked;
    }

    private void CheckBox_MensajeTNS_True_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckBox_MensajeTNS_True.Checked)
        this.CheckBox_MensajeTNS_False.CheckState = CheckState.Unchecked;
      else
        this.CheckBox_MensajeTNS_False.CheckState = CheckState.Checked;
    }

    private void CheckBox_MensajeTNS_False_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckBox_MensajeTNS_False.Checked)
        this.CheckBox_MensajeTNS_True.CheckState = CheckState.Unchecked;
      else
        this.CheckBox_MensajeTNS_True.CheckState = CheckState.Checked;
    }

    private void chbEsMonitor_CheckedChanged(object sender, EventArgs e)
    {
      if (this.chbEsMonitor.Checked)
        this.chbEsMonitorNo.CheckState = CheckState.Unchecked;
      else
        this.chbEsMonitorNo.CheckState = CheckState.Checked;
    }

    private void chbEsMonitorNo_CheckedChanged(object sender, EventArgs e)
    {
      if (this.chbEsMonitorNo.Checked)
        this.chbEsMonitor.CheckState = CheckState.Unchecked;
      else
        this.chbEsMonitor.CheckState = CheckState.Checked;
    }

    private void VerificarModulo()
    {
      if (!ModGeneralFunctions.ObtenerAPPCONFIG("MODULO").Equals((object) "POS"))
        return;
      this.Label_TimeW.Visible = false;
      this.TextBox_Minutes.Visible = false;
      this.Label5.Visible = false;
      this.Button_TimeW.Visible = false;
      this.CheckBox_IsWaiterShowSale.Visible = false;
      this.CheckBox_IsNotWaiterShowSale.Visible = false;
      this.Label21.Visible = false;
      this.chbSeleccionarMesaxDiseno.Visible = false;
      this.chbNoSeleccionarMesaxDiseno.Visible = false;
      this.Label34.Visible = false;
      this.chbConfirmarTransfMesas.Visible = false;
      this.chbNoConfirmarTransfMesas.Visible = false;
      this.Label29.Visible = false;
      this.tbcVariables.TabPages.Remove(this.tpgMonitor);
    }

    private void CheckBox_ImprimirPrecuenta_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckBox_ImprimirPrecuenta.Checked)
        this.CheckBox_NoImprimirPrecuenta.CheckState = CheckState.Unchecked;
      else
        this.CheckBox_NoImprimirPrecuenta.CheckState = CheckState.Checked;
    }

    private void CheckBox_NoImprimirPrecuenta_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CheckBox_NoImprimirPrecuenta.Checked)
        this.CheckBox_ImprimirPrecuenta.CheckState = CheckState.Unchecked;
      else
        this.CheckBox_ImprimirPrecuenta.CheckState = CheckState.Checked;
    }
  }
}
