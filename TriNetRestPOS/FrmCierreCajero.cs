// Decompiled with JetBrains decompiler
// Type: TriNetRestPOS.FrmCierreCajero
// Assembly: TriNetRestPOS, Version=5.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 43377352-E952-4AC1-9BA6-CCBE4AE5F575
// Assembly location: C:\log\TriNetRestPOS.exe

using Microsoft.VisualBasic.CompilerServices;
using MyXPButton;
using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using TR1_BusinessEntity;
using TR1_BusinessLogic;

namespace TriNetRestPOS
{
  [DesignerGenerated]
  public class FrmCierreCajero : Form
  {
    private IContainer components;
    public BE_TR1_TURNS _BE_TURNS;
    private BL_TR1_TURNS o_CL_TURNS;
    private BE_TR1_TURNS o_BE_TR1_TURNS;
    private BECollec_TR1_CREDITCARDS o_BEC_CREDITCARDS;
    private double txt_CardAmount;
    private double txt_CardTip;
    private double txt_CashInitialIconN;
    private double txt_CashInitialIconE;
    private double txt_CashSaleIconN;
    private double txt_CashSaleIconE;
    private double txt_CashPaymentIconN;
    private double txt_CashPaymentIconE;
    private double txt_TipPayN;
    private double txt_TipPayE;
    private double txt_ReturnMoneyPaidIN;
    private double txt_CashBoxIconN;
    private double txt_CashBoxIconE;
    private double txt_TotalCardIconN;
    private double txt_TotalCardIconE;
    private double txt_TotalSaleIconN;
    private double txt_TotalSaleIconE;
    private double NumericText_TotalSaleIN;
    private double NumericText_TotalSaleIE;
    private double NumericTextBox_TotalSale;
    private double NumericTextBox_TotalSaleMoreCreditCard;

    public FrmCierreCajero()
    {
      this.Load += new EventHandler(this.FrmCierreCajero_Load);
      this.KeyDown += new KeyEventHandler(this.FrmCierreCajero_KeyDown);
      this.InitializeComponent();
    }

    [DebuggerNonUserCode]
    protected override void Dispose(bool disposing)
    {
      try
      {
        if (!disposing || this.components == null)
          return;
        this.components.Dispose();
      }
      finally
      {
        base.Dispose(disposing);
      }
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.Label_IconE = new Label();
      this.Label_IconN = new Label();
      this.txtImporteSoles = new NumericTextBox.NumericTextBox();
      this.GroupBox_MakeClose = new GroupBox();
      this.btnCerrarZeta = new Button();
      this.btnImprimirLiquidacion = new Button();
      this.btnSalir = new Button();
      this.btnCerrarTurno = new Button();
      this.txtImporteDolares = new NumericTextBox.NumericTextBox();
      this.MyXPButton9 = new MyXPButton.MyXPButton();
      this.lbl_TurnText = new Label();
      this.NumericTextBox1 = new NumericTextBox.NumericTextBox();
      this.NumericTextBox2 = new NumericTextBox.NumericTextBox();
      this.MyXPButton1 = new MyXPButton.MyXPButton();
      this.NumericTextBox3 = new NumericTextBox.NumericTextBox();
      this.MyXPButton2 = new MyXPButton.MyXPButton();
      this.NumericTextBox5 = new NumericTextBox.NumericTextBox();
      this.MyXPButton3 = new MyXPButton.MyXPButton();
      this.GroupBox_MakeClose.SuspendLayout();
      this.SuspendLayout();
      this.Label_IconE.AutoSize = true;
      this.Label_IconE.BackColor = Color.Transparent;
      this.Label_IconE.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label_IconE.ForeColor = Color.Red;
      this.Label_IconE.Location = new Point(311, 37);
      this.Label_IconE.Name = "Label_IconE";
      this.Label_IconE.Size = new Size(74, 20);
      this.Label_IconE.TabIndex = 75;
      this.Label_IconE.Text = "Label MN";
      this.Label_IconN.AutoSize = true;
      this.Label_IconN.BackColor = Color.Transparent;
      this.Label_IconN.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label_IconN.ForeColor = Color.Red;
      this.Label_IconN.Location = new Point(173, 37);
      this.Label_IconN.Name = "Label_IconN";
      this.Label_IconN.Size = new Size(74, 20);
      this.Label_IconN.TabIndex = 74;
      this.Label_IconN.Text = "Label MN";
      this.txtImporteSoles.set_AllowSpace(false);
      ((TextBoxBase) this.txtImporteSoles).BackColor = Color.White;
      ((Control) this.txtImporteSoles).Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      ((TextBoxBase) this.txtImporteSoles).ForeColor = Color.Black;
      ((Control) this.txtImporteSoles).Location = new Point(173, 60);
      ((Control) this.txtImporteSoles).Name = "txtImporteSoles";
      ((TextBoxBase) this.txtImporteSoles).ReadOnly = true;
      ((Control) this.txtImporteSoles).Size = new Size(129, 25);
      ((Control) this.txtImporteSoles).TabIndex = 72;
      ((TextBox) this.txtImporteSoles).TextAlign = HorizontalAlignment.Right;
      this.GroupBox_MakeClose.BackColor = Color.Transparent;
      this.GroupBox_MakeClose.Controls.Add((Control) this.btnCerrarZeta);
      this.GroupBox_MakeClose.Controls.Add((Control) this.btnImprimirLiquidacion);
      this.GroupBox_MakeClose.Controls.Add((Control) this.btnSalir);
      this.GroupBox_MakeClose.Controls.Add((Control) this.btnCerrarTurno);
      this.GroupBox_MakeClose.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.GroupBox_MakeClose.ForeColor = Color.MediumBlue;
      this.GroupBox_MakeClose.Location = new Point(12, 191);
      this.GroupBox_MakeClose.Name = "GroupBox_MakeClose";
      this.GroupBox_MakeClose.Size = new Size(441, 91);
      this.GroupBox_MakeClose.TabIndex = 68;
      this.GroupBox_MakeClose.TabStop = false;
      this.GroupBox_MakeClose.Text = "Cierre Turno";
      this.btnCerrarZeta.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnCerrarZeta.Image = (Image) TriNetRestPOS.My.Resources.Resources.i_Ready;
      this.btnCerrarZeta.Location = new Point(136, 22);
      this.btnCerrarZeta.Name = "btnCerrarZeta";
      this.btnCerrarZeta.Size = new Size(100, 62);
      this.btnCerrarZeta.TabIndex = 130;
      this.btnCerrarZeta.Tag = (object) "Res_";
      this.btnCerrarZeta.Text = "Cierre &Z";
      this.btnCerrarZeta.TextImageRelation = TextImageRelation.TextAboveImage;
      this.btnCerrarZeta.UseVisualStyleBackColor = true;
      this.btnImprimirLiquidacion.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnImprimirLiquidacion.ForeColor = Color.MediumBlue;
      this.btnImprimirLiquidacion.Image = (Image) TriNetRestPOS.My.Resources.Resources.print_printer_s;
      this.btnImprimirLiquidacion.Location = new Point(236, 22);
      this.btnImprimirLiquidacion.Name = "btnImprimirLiquidacion";
      this.btnImprimirLiquidacion.Size = new Size(100, 62);
      this.btnImprimirLiquidacion.TabIndex = 128;
      this.btnImprimirLiquidacion.Tag = (object) "Res_Print";
      this.btnImprimirLiquidacion.Text = "&Imprimir";
      this.btnImprimirLiquidacion.TextImageRelation = TextImageRelation.TextAboveImage;
      this.btnImprimirLiquidacion.UseVisualStyleBackColor = true;
      this.btnSalir.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnSalir.Image = (Image) TriNetRestPOS.My.Resources.Resources.i_Close;
      this.btnSalir.Location = new Point(336, 22);
      this.btnSalir.Name = "btnSalir";
      this.btnSalir.Size = new Size(100, 62);
      this.btnSalir.TabIndex = (int) sbyte.MaxValue;
      this.btnSalir.Tag = (object) "Res_Back";
      this.btnSalir.Text = "&Salir";
      this.btnSalir.TextImageRelation = TextImageRelation.TextAboveImage;
      this.btnSalir.UseVisualStyleBackColor = true;
      this.btnCerrarTurno.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnCerrarTurno.Image = (Image) TriNetRestPOS.My.Resources.Resources.i_Ready;
      this.btnCerrarTurno.Location = new Point(6, 22);
      this.btnCerrarTurno.Name = "btnCerrarTurno";
      this.btnCerrarTurno.Size = new Size(130, 62);
      this.btnCerrarTurno.TabIndex = 126;
      this.btnCerrarTurno.Tag = (object) "Res_";
      this.btnCerrarTurno.Text = "&Cerrar Turno";
      this.btnCerrarTurno.TextImageRelation = TextImageRelation.TextAboveImage;
      this.btnCerrarTurno.UseVisualStyleBackColor = true;
      this.txtImporteDolares.set_AllowSpace(false);
      ((TextBoxBase) this.txtImporteDolares).BackColor = Color.White;
      ((Control) this.txtImporteDolares).Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      ((TextBoxBase) this.txtImporteDolares).ForeColor = Color.Black;
      ((Control) this.txtImporteDolares).Location = new Point(314, 60);
      ((Control) this.txtImporteDolares).Name = "txtImporteDolares";
      ((TextBoxBase) this.txtImporteDolares).ReadOnly = true;
      ((Control) this.txtImporteDolares).Size = new Size(129, 25);
      ((Control) this.txtImporteDolares).TabIndex = 73;
      ((TextBox) this.txtImporteDolares).TextAlign = HorizontalAlignment.Right;
      this.MyXPButton9.set_AdjustImageLocation(new Point(0, 0));
      this.MyXPButton9.set_BtnShape((emunType.BtnShape) 0);
      this.MyXPButton9.set_BtnStyle((emunType.XPStyle) 1);
      ((Control) this.MyXPButton9).Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      ((Control) this.MyXPButton9).Location = new Point(12, 59);
      ((Control) this.MyXPButton9).Name = "MyXPButton9";
      ((Control) this.MyXPButton9).Size = new Size(150, 26);
      ((Control) this.MyXPButton9).TabIndex = 69;
      ((ButtonBase) this.MyXPButton9).Text = "Total Efectivo";
      ((ButtonBase) this.MyXPButton9).UseVisualStyleBackColor = true;
      this.lbl_TurnText.AutoSize = true;
      this.lbl_TurnText.BackColor = Color.Transparent;
      this.lbl_TurnText.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lbl_TurnText.ForeColor = Color.Red;
      this.lbl_TurnText.Location = new Point(8, 9);
      this.lbl_TurnText.Name = "lbl_TurnText";
      this.lbl_TurnText.Size = new Size(56, 20);
      this.lbl_TurnText.TabIndex = 76;
      this.lbl_TurnText.Text = "Turno:";
      this.NumericTextBox1.set_AllowSpace(false);
      ((TextBoxBase) this.NumericTextBox1).BackColor = Color.White;
      ((Control) this.NumericTextBox1).Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      ((TextBoxBase) this.NumericTextBox1).ForeColor = Color.Black;
      ((Control) this.NumericTextBox1).Location = new Point(173, 92);
      ((Control) this.NumericTextBox1).Name = "NumericTextBox1";
      ((TextBoxBase) this.NumericTextBox1).ReadOnly = true;
      ((Control) this.NumericTextBox1).Size = new Size(129, 25);
      ((Control) this.NumericTextBox1).TabIndex = 78;
      ((TextBox) this.NumericTextBox1).TextAlign = HorizontalAlignment.Right;
      this.NumericTextBox2.set_AllowSpace(false);
      ((TextBoxBase) this.NumericTextBox2).BackColor = Color.White;
      ((Control) this.NumericTextBox2).Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      ((TextBoxBase) this.NumericTextBox2).ForeColor = Color.Black;
      ((Control) this.NumericTextBox2).Location = new Point(314, 92);
      ((Control) this.NumericTextBox2).Name = "NumericTextBox2";
      ((TextBoxBase) this.NumericTextBox2).ReadOnly = true;
      ((Control) this.NumericTextBox2).Size = new Size(129, 25);
      ((Control) this.NumericTextBox2).TabIndex = 79;
      ((TextBox) this.NumericTextBox2).TextAlign = HorizontalAlignment.Right;
      this.MyXPButton1.set_AdjustImageLocation(new Point(0, 0));
      this.MyXPButton1.set_BtnShape((emunType.BtnShape) 0);
      this.MyXPButton1.set_BtnStyle((emunType.XPStyle) 1);
      ((Control) this.MyXPButton1).Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      ((Control) this.MyXPButton1).Location = new Point(12, 91);
      ((Control) this.MyXPButton1).Name = "MyXPButton1";
      ((Control) this.MyXPButton1).Size = new Size(150, 26);
      ((Control) this.MyXPButton1).TabIndex = 77;
      ((ButtonBase) this.MyXPButton1).Text = "Total Propina";
      ((ButtonBase) this.MyXPButton1).UseVisualStyleBackColor = true;
      this.NumericTextBox3.set_AllowSpace(false);
      ((TextBoxBase) this.NumericTextBox3).BackColor = Color.White;
      ((Control) this.NumericTextBox3).Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      ((TextBoxBase) this.NumericTextBox3).ForeColor = Color.Black;
      ((Control) this.NumericTextBox3).Location = new Point(173, 124);
      ((Control) this.NumericTextBox3).Name = "NumericTextBox3";
      ((TextBoxBase) this.NumericTextBox3).ReadOnly = true;
      ((Control) this.NumericTextBox3).Size = new Size(129, 25);
      ((Control) this.NumericTextBox3).TabIndex = 81;
      ((TextBox) this.NumericTextBox3).TextAlign = HorizontalAlignment.Right;
      this.MyXPButton2.set_AdjustImageLocation(new Point(0, 0));
      this.MyXPButton2.set_BtnShape((emunType.BtnShape) 0);
      this.MyXPButton2.set_BtnStyle((emunType.XPStyle) 1);
      ((Control) this.MyXPButton2).Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      ((Control) this.MyXPButton2).Location = new Point(12, 123);
      ((Control) this.MyXPButton2).Name = "MyXPButton2";
      ((Control) this.MyXPButton2).Size = new Size(150, 26);
      ((Control) this.MyXPButton2).TabIndex = 80;
      ((ButtonBase) this.MyXPButton2).Text = "Total Tarjetas";
      ((ButtonBase) this.MyXPButton2).UseVisualStyleBackColor = true;
      this.NumericTextBox5.set_AllowSpace(false);
      ((TextBoxBase) this.NumericTextBox5).BackColor = Color.White;
      ((Control) this.NumericTextBox5).Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      ((TextBoxBase) this.NumericTextBox5).ForeColor = Color.Black;
      ((Control) this.NumericTextBox5).Location = new Point(173, 156);
      ((Control) this.NumericTextBox5).Name = "NumericTextBox5";
      ((TextBoxBase) this.NumericTextBox5).ReadOnly = true;
      ((Control) this.NumericTextBox5).Size = new Size(129, 25);
      ((Control) this.NumericTextBox5).TabIndex = 84;
      ((TextBox) this.NumericTextBox5).TextAlign = HorizontalAlignment.Right;
      this.MyXPButton3.set_AdjustImageLocation(new Point(0, 0));
      this.MyXPButton3.set_BtnShape((emunType.BtnShape) 0);
      this.MyXPButton3.set_BtnStyle((emunType.XPStyle) 1);
      ((Control) this.MyXPButton3).Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      ((Control) this.MyXPButton3).Location = new Point(12, 155);
      ((Control) this.MyXPButton3).Name = "MyXPButton3";
      ((Control) this.MyXPButton3).Size = new Size(150, 26);
      ((Control) this.MyXPButton3).TabIndex = 83;
      ((ButtonBase) this.MyXPButton3).Text = "Propina Tarjetas";
      ((ButtonBase) this.MyXPButton3).UseVisualStyleBackColor = true;
      this.AutoScaleDimensions = new SizeF(9f, 20f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.White;
      this.ClientSize = new Size(464, 288);
      this.Controls.Add((Control) this.NumericTextBox5);
      this.Controls.Add((Control) this.MyXPButton3);
      this.Controls.Add((Control) this.NumericTextBox3);
      this.Controls.Add((Control) this.MyXPButton2);
      this.Controls.Add((Control) this.NumericTextBox1);
      this.Controls.Add((Control) this.NumericTextBox2);
      this.Controls.Add((Control) this.MyXPButton1);
      this.Controls.Add((Control) this.lbl_TurnText);
      this.Controls.Add((Control) this.Label_IconE);
      this.Controls.Add((Control) this.Label_IconN);
      this.Controls.Add((Control) this.txtImporteSoles);
      this.Controls.Add((Control) this.GroupBox_MakeClose);
      this.Controls.Add((Control) this.txtImporteDolares);
      this.Controls.Add((Control) this.MyXPButton9);
      this.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.KeyPreview = true;
      this.Margin = new Padding(4, 5, 4, 5);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (FrmCierreCajero);
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Cierre de Caja";
      this.GroupBox_MakeClose.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    internal virtual Label Label_IconE { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label_IconN { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual NumericTextBox.NumericTextBox txtImporteSoles { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual GroupBox GroupBox_MakeClose { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button btnCerrarZeta
    {
      get
      {
        return this._btnCerrarZeta;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnCerrarZeta_Click);
        Button btnCerrarZeta1 = this._btnCerrarZeta;
        if (btnCerrarZeta1 != null)
          btnCerrarZeta1.Click -= eventHandler;
        this._btnCerrarZeta = value;
        Button btnCerrarZeta2 = this._btnCerrarZeta;
        if (btnCerrarZeta2 == null)
          return;
        btnCerrarZeta2.Click += eventHandler;
      }
    }

    internal virtual Button btnImprimirLiquidacion
    {
      get
      {
        return this._btnImprimirLiquidacion;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnImprimirLiquidacion_Click);
        Button imprimirLiquidacion1 = this._btnImprimirLiquidacion;
        if (imprimirLiquidacion1 != null)
          imprimirLiquidacion1.Click -= eventHandler;
        this._btnImprimirLiquidacion = value;
        Button imprimirLiquidacion2 = this._btnImprimirLiquidacion;
        if (imprimirLiquidacion2 == null)
          return;
        imprimirLiquidacion2.Click += eventHandler;
      }
    }

    internal virtual Button btnSalir
    {
      get
      {
        return this._btnSalir;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnSalir_Click);
        Button btnSalir1 = this._btnSalir;
        if (btnSalir1 != null)
          btnSalir1.Click -= eventHandler;
        this._btnSalir = value;
        Button btnSalir2 = this._btnSalir;
        if (btnSalir2 == null)
          return;
        btnSalir2.Click += eventHandler;
      }
    }

    internal virtual Button btnCerrarTurno
    {
      get
      {
        return this._btnCerrarTurno;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnCerrarTurno_Click);
        Button btnCerrarTurno1 = this._btnCerrarTurno;
        if (btnCerrarTurno1 != null)
          btnCerrarTurno1.Click -= eventHandler;
        this._btnCerrarTurno = value;
        Button btnCerrarTurno2 = this._btnCerrarTurno;
        if (btnCerrarTurno2 == null)
          return;
        btnCerrarTurno2.Click += eventHandler;
      }
    }

    internal virtual NumericTextBox.NumericTextBox txtImporteDolares { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual MyXPButton.MyXPButton MyXPButton9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label lbl_TurnText { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual NumericTextBox.NumericTextBox NumericTextBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual NumericTextBox.NumericTextBox NumericTextBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual MyXPButton.MyXPButton MyXPButton1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual NumericTextBox.NumericTextBox NumericTextBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual MyXPButton.MyXPButton MyXPButton2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual NumericTextBox.NumericTextBox NumericTextBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual MyXPButton.MyXPButton MyXPButton3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private void FrmCierreCajero_Load(object sender, EventArgs e)
    {
      if (ModGeneralVar.g_BE_TR1_TURNS != null)
      {
        ModGeneralVar.g_BE_TR1_TURNS.set_UserId(ModGeneralVar.g_BE_USERS.get_UserId());
        this.Load_DataTurn(ModGeneralVar.g_BE_TR1_TURNS);
      }
      else if (this._BE_TURNS != null)
      {
        this.Load_DataTurn(this._BE_TURNS);
      }
      else
      {
        this.btnCerrarTurno.Visible = false;
        this.btnImprimirLiquidacion.Visible = false;
      }
    }

    private void FrmCierreCajero_KeyDown(object sender, KeyEventArgs e)
    {
      if (!e.KeyValue.Equals(27))
        return;
      this.btnSalir_Click((object) null, (EventArgs) null);
    }

    private void btnCerrarTurno_Click(object sender, EventArgs e)
    {
      ModGeneralVar.g_bol_IsReady = true;
      int num = this.o_CL_TURNS.DocumentsForPay(ModGeneralVar.g_BE_TR1_TURNS.get_TurnId(), ModGeneralVar.g_BusinessCode.get_DOCU_PAYLESS());
      if (num > 0)
        ModGeneralFunctions.MessageOk("¡Existen " + Conversions.ToString(num) + " Documento(s) por Cancelar!");
      else if (ModGeneralFunctions.MessageMakeAction("¿Seguro de Cerrar el Turno?", false))
      {
        ModGeneralVar.g_BE_TR1_TURNS.set_EstabliId(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId());
        ModGeneralVar.g_BE_TR1_TURNS.set_UserId_UP(ModGeneralVar.g_BE_USERS.get_UserId());
        ModGeneralVar.g_BE_TR1_TURNS.set_AmountCashSaleIN(this.txt_CashSaleIconN);
        ModGeneralVar.g_BE_TR1_TURNS.set_AmountCashSaleIE(this.txt_CashSaleIconE);
        ModGeneralVar.g_BE_TR1_TURNS.set_AmountCashTipIN(this.txt_TipPayN);
        ModGeneralVar.g_BE_TR1_TURNS.set_AmountCashTipIE(this.txt_TipPayE);
        ModGeneralVar.g_BE_TR1_TURNS.set_AmountDebitIN(this.txt_CashPaymentIconN);
        ModGeneralVar.g_BE_TR1_TURNS.set_AmountDebitIE(this.txt_CashPaymentIconE);
        ModGeneralVar.g_BE_TR1_TURNS.set_AmountCardSaleIN(this.txt_CardAmount);
        ModGeneralVar.g_BE_TR1_TURNS.set_AmountCardTipIN(this.txt_CardTip);
        ModGeneralVar.g_BE_TR1_TURNS.set_AmountTotalBoxIN(this.txt_CashBoxIconN);
        ModGeneralVar.g_BE_TR1_TURNS.set_AmountTotalSaleIN(this.NumericText_TotalSaleIN);
        ModGeneralVar.g_BE_TR1_TURNS.set_ReturnedPaidIN(this.txt_ReturnMoneyPaidIN);
        if (this.o_CL_TURNS.CloseTurn(ModGeneralVar.g_BE_TR1_TURNS, this.o_BEC_CREDITCARDS).Equals(StructApp.RESULT_OK))
        {
          if (ModGeneralFunctions.MessageMakeAction("¿Imprimir Liquidación?", false))
            this.ImprimirLiquidacion();
          ModGeneralFunctions.MessageOk("¡TURNO CERRADO CORRECTAMENTE!");
          ModGeneralVar.g_BE_TR1_TURNS = (BE_TR1_TURNS) null;
          ModGeneralVar.g_OpenTurnId = false;
          this.btnCerrarTurno.Enabled = false;
          this.btnCerrarZeta.Focus();
          this.btnImprimirLiquidacion.Enabled = false;
        }
      }
    }

    private void btnCerrarZeta_Click(object sender, EventArgs e)
    {
      if (ModGeneralVar.g_BE_TR1_TURNS == null)
      {
        if (!ModGeneralFunctions.MessageMakeAction("¿Seguro de Generar Cierre Z?", false))
          return;
        BL_TR1_TURN_GENERAL blTr1TurnGeneral = new BL_TR1_TURN_GENERAL();
        BE_TR1_TURN_GENERAL beTr1TurnGeneral = new BE_TR1_TURN_GENERAL();
        beTr1TurnGeneral.set_TurnGId(ModGeneralVar.g_TurnGId);
        beTr1TurnGeneral.set_BoxId(ModGeneralVar.g_BE_TR1_CFGVARIABLES.get_BoxIdPos());
        beTr1TurnGeneral.set_UserClose(ModGeneralVar.g_BE_USERS.get_UserId());
        beTr1TurnGeneral.set_CodeIdTicket(ModGeneralVar.g_GeneralCode.get_Docu_Ticket());
        beTr1TurnGeneral.set_CodeIdInvoice(ModGeneralVar.g_GeneralCode.get_Docu_Invoice());
        beTr1TurnGeneral.set_DocumentStateProcessed(ModGeneralVar.g_BusinessCode.get_DOCU_PROCESSED());
        beTr1TurnGeneral.set_DocumentStateAnnulled(ModGeneralVar.g_BusinessCode.get_DOCU_ANNULLED());
        string str = blTr1TurnGeneral.Edit(beTr1TurnGeneral);
        if (str.Equals(StructApp.RESULT_OK))
        {
          ModGeneralFunctions.MessageOk("¡CIERRE Z GENERADO CORRECTAMENTE!");
          ModGeneralVar.g_TurnGId = 0;
          this.Close();
        }
        else
          ModGeneralFunctions.MessageError_Large("¡Error al Generar Cierre Z " + str + "!", true);
      }
      else
      {
        ModGeneralFunctions.MessageOk("¡Debe cerrar el Turno!");
        this.btnCerrarTurno_Click((object) null, (EventArgs) null);
      }
    }

    private void btnImprimirLiquidacion_Click(object sender, EventArgs e)
    {
      this.ImprimirLiquidacion();
    }

    private void btnSalir_Click(object sender, EventArgs e)
    {
      ModGeneralVar.g_bol_IsReady = false;
      this.Close();
    }

    public void Load_DataTurn(BE_TR1_TURNS g_BE_TR1_All_TURNS)
    {
      try
      {
        this.Label_IconN.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(ModGeneralFunctions.ObtenerAPPCONFIG("TYPEMONEYDES_IN"), (object) " "), ModGeneralFunctions.ObtenerAPPCONFIG("TYPEMONEYDESSHORT_IN")));
        this.Label_IconE.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(ModGeneralFunctions.ObtenerAPPCONFIG("TYPEMONEYDES_IE"), (object) " "), ModGeneralFunctions.ObtenerAPPCONFIG("TYPEMONEYDESSHORT_IE")));
        this.CreateButtonCardsArray(g_BE_TR1_All_TURNS);
        try
        {
          this.lbl_TurnText.Text = "Turno: " + this._BE_TURNS.get_TurnId() + " -- Usuario: " + this._BE_TURNS.get_UserId();
          this.btnImprimirLiquidacion.Visible = true;
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ModGeneralFunctions.MessageOk("¡Debe Aperturar Turno!");
          ProjectData.ClearProjectError();
          return;
        }
        this.o_CL_TURNS = new BL_TR1_TURNS();
        try
        {
          this.o_BE_TR1_TURNS = this.o_CL_TURNS.GetTurnToClose(this._BE_TURNS.get_TurnId(), ModGeneralVar.g_GeneralCode.get_Docu_Ticket(), ModGeneralVar.g_GeneralCode.get_Docu_Invoice(), ModGeneralVar.g_BusinessCode.get_DOCU_PAID(), ModGeneralVar.g_BusinessCode.get_DOCU_ANNULLED());
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        this.txt_CashInitialIconN = Conversions.ToDouble(ModGeneralFunctions.CadenaToDoubleFormateado(Conversions.ToString(this.o_BE_TR1_TURNS.get_AmountContriIN()), 2));
        this.txt_CashInitialIconE = Conversions.ToDouble(ModGeneralFunctions.CadenaToDoubleFormateado(Conversions.ToString(this.o_BE_TR1_TURNS.get_AmountContriIE()), 2));
        this.txt_CashSaleIconN = Conversions.ToDouble(ModGeneralFunctions.CadenaToDoubleFormateado(Conversions.ToString(this.o_BE_TR1_TURNS.get_AmountCashSaleIN()), 2));
        this.txt_CashSaleIconE = Conversions.ToDouble(ModGeneralFunctions.CadenaToDoubleFormateado(Conversions.ToString(this.o_BE_TR1_TURNS.get_AmountCashSaleIE()), 2));
        this.txt_CashPaymentIconN = Conversions.ToDouble(ModGeneralFunctions.CadenaToDoubleFormateado(Conversions.ToString(this.o_BE_TR1_TURNS.get_AmountDebitIN()), 2));
        this.txt_CashPaymentIconE = Conversions.ToDouble(ModGeneralFunctions.CadenaToDoubleFormateado(Conversions.ToString(this.o_BE_TR1_TURNS.get_AmountDebitIE()), 2));
        this.txt_TipPayN = Conversions.ToDouble(ModGeneralFunctions.CadenaToDoubleFormateado(Conversions.ToString(this.o_BE_TR1_TURNS.get_AmountCashTipIN()), 2));
        this.txt_TipPayE = Conversions.ToDouble(ModGeneralFunctions.CadenaToDoubleFormateado(Conversions.ToString(this.o_BE_TR1_TURNS.get_AmountCashTipIE()), 2));
        this.txt_ReturnMoneyPaidIN = Conversions.ToDouble(ModGeneralFunctions.CadenaToDoubleFormateado(Conversions.ToString(this.o_BE_TR1_TURNS.get_ReturnedPaidIE()), 2));
        this.txt_CashBoxIconN = Conversions.ToDouble(ModGeneralFunctions.CadenaToDoubleFormateado(Conversions.ToString(this.o_BE_TR1_TURNS.get_AmountContriIN() + this.o_BE_TR1_TURNS.get_AmountCashSaleIN() + this.o_BE_TR1_TURNS.get_AmountCashTipIN() - this.o_BE_TR1_TURNS.get_AmountDebitIN() - this.o_BE_TR1_TURNS.get_ReturnedPaidIE()), 2));
        this.txt_CashBoxIconE = Conversions.ToDouble(ModGeneralFunctions.CadenaToDoubleFormateado(Conversions.ToString(this.o_BE_TR1_TURNS.get_AmountContriIE() + this.o_BE_TR1_TURNS.get_AmountCashSaleIE() + this.o_BE_TR1_TURNS.get_AmountCashTipIE() - this.o_BE_TR1_TURNS.get_AmountDebitIE()), 2));
        this.txt_TotalCardIconN = Conversions.ToDouble(ModGeneralFunctions.CadenaToDoubleFormateado(Conversions.ToString(this.txt_CardAmount), 2));
        this.txt_TotalCardIconE = Conversions.ToDouble(ModGeneralFunctions.CadenaToDoubleFormateado(Conversions.ToString(0), 2));
        this.txt_TotalSaleIconN = Conversions.ToDouble(ModGeneralFunctions.CadenaToDoubleFormateado(Conversions.ToString(this.txt_CashBoxIconN + this.txt_CashBoxIconE * ModGeneralVar.g_BE_TR1_TURNS.get_TyChanSale()), 2));
        this.txt_TotalSaleIconE = Conversions.ToDouble(ModGeneralFunctions.CadenaToDoubleFormateado(Conversions.ToString(0), 2));
        this.NumericText_TotalSaleIN = Conversions.ToDouble(ModGeneralFunctions.CadenaToDoubleFormateado(Conversions.ToString(ModGeneralFunctions.CadenaToDouble(Conversions.ToString(this.txt_TotalCardIconN)) + ModGeneralFunctions.CadenaToDouble(Conversions.ToString(this.txt_TotalSaleIconN))), 2));
        this.NumericText_TotalSaleIE = Conversions.ToDouble(ModGeneralFunctions.CadenaToDoubleFormateado(Conversions.ToString(ModGeneralFunctions.CadenaToDouble(Conversions.ToString(this.txt_TotalCardIconE)) + ModGeneralFunctions.CadenaToDouble(Conversions.ToString(this.txt_TotalSaleIconE))), 2));
        this.NumericTextBox_TotalSale = Conversions.ToDouble(ModGeneralFunctions.CadenaToDoubleFormateado(Conversions.ToString(this.txt_CashSaleIconE * g_BE_TR1_All_TURNS.get_TyChanSale() + this.txt_CashSaleIconN - (this.txt_CashPaymentIconN + this.txt_ReturnMoneyPaidIN)), 2));
        this.NumericTextBox_TotalSaleMoreCreditCard = Conversions.ToDouble(ModGeneralFunctions.CadenaToDoubleFormateado(Conversions.ToString(this.NumericTextBox_TotalSale + this.txt_TotalCardIconN), 2));
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void CreateButtonCardsArray(BE_TR1_TURNS g_BE_TR1_All_TURNS)
    {
      this.o_BEC_CREDITCARDS = new BL_TR1_CREDITCARDS().ListWithPayments(g_BE_TR1_All_TURNS.get_TurnId());
      double num1 = 0.0;
      double num2 = 0.0;
      short num3 = checked ((short) (((CollectionBase) this.o_BEC_CREDITCARDS).Count - 1));
      short num4 = 0;
      while ((int) num4 <= (int) num3)
      {
        num1 += this.o_BEC_CREDITCARDS.get_Item((int) num4).get_PayAmount();
        num2 += this.o_BEC_CREDITCARDS.get_Item((int) num4).get_PayTip();
        checked { ++num4; }
      }
      this.txt_CardAmount = Conversions.ToDouble(ModGeneralFunctions.CadenaToDoubleFormateado(Conversions.ToString(num1), 2));
      this.txt_CardTip = Conversions.ToDouble(ModGeneralFunctions.CadenaToDoubleFormateado(Conversions.ToString(num2), 2));
    }

    private void ImprimirLiquidacion()
    {
      bool flag = false;
      if (ModGeneralFunctions.MessageMakeAction("¿Imprimir Liquidación Resumida?", false))
        flag = true;
      BL_TR1_ORDERS blTr1Orders = new BL_TR1_ORDERS();
      string[] strArray = new string[3];
      strArray.SetValue((object) ModGeneralFunctions.ObtenerAPPCONFIG("TYPEMONEYDESSHORT_IN").ToString(), 0);
      strArray.SetValue((object) ModGeneralFunctions.ObtenerAPPCONFIG("TYPEMONEYDESSHORT_IE").ToString(), 1);
      BL_TR1_PRINTERS blTr1Printers = new BL_TR1_PRINTERS();
      BE_TR1_PRINTERS beTr1Printers1 = new BE_TR1_PRINTERS();
      BE_TR1_PRINTERS beTr1Printers2 = blTr1Printers.ListById(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId(), ModGeneralVar.g_BE_TR1_CFGVARIABLES.get_PrinterPrecountId());
      string str = blTr1Orders.ImprimirCierreTurno(ModGeneralVar.g_BE_TR1_TURNS.get_TurnId(), ModGeneralVar.g_BE_USERS.get_UserId() + " - " + ModGeneralVar.g_BE_USERS.get_Name(), beTr1Printers2.get_PrinterValue(), strArray, flag, ModGeneralVar.g_BusinessCode.get_DOCU_ANNULLED(), ModGeneralVar.g_BusinessCode.get_DOCU_PAID(), ModGeneralVar.g_GeneralCode.get_Docu_Ticket(), ModGeneralVar.g_GeneralCode.get_Docu_Invoice(), ModGeneralVar.g_BE_TR1_VARIABLES_B, ModGeneralVar.g_BE_TR1_CFGVARIABLES, Conversions.ToString(ModGeneralFunctions.ObtenerAPPCONFIG("PRECUENTAG")), true, ModGeneralFunctions.LC_ValidarContrato(), false, false);
      if (!str.Equals(StructApp.RESULT_OK))
        ModGeneralFunctions.MessageError_Large("Error al Imprimir - " + str + " ", true);
    }
  }
}
