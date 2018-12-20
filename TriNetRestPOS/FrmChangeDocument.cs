// Decompiled with JetBrains decompiler
// Type: TriNetRestPOS.FrmChangeDocument
// Assembly: TriNetRestPOS, Version=5.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 43377352-E952-4AC1-9BA6-CCBE4AE5F575
// Assembly location: C:\log\TriNetRestPOS.exe

using KIS.Controls;
using KIS.Controls.Windows;
using Microsoft.VisualBasic.CompilerServices;
using MyXPButton;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using TR1_BusinessEntity;
using TR1_BusinessLogic;

namespace TriNetRestPOS
{
  [DesignerGenerated]
  public class FrmChangeDocument : Form
  {
    private IContainer components;
    public int intDocumentCode;
    public string strDocumentType;
    public string strDocumentTypeId;
    public string strDocumentId;
    public string strOrderId;
    public string strClientId;
    public string strClientDes;
    public double dblAmoutnTotal;
    public double dblAmoutnDis;
    public double dblAmoutnSur;
    private List<BE_TR1_ORDERDETAILS> oListaORDERDETAILS;

    public FrmChangeDocument()
    {
      this.KeyDown += new KeyEventHandler(this.FrmChangeDocument_KeyDown);
      this.Load += new EventHandler(this.FrmChangeDocument_Load);
      this.oListaORDERDETAILS = new List<BE_TR1_ORDERDETAILS>();
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
      this.TextBox_ClientId = new TextBox();
      this.Label_ClienteDes = new Label();
      this.Label_Name = new Label();
      this.HeaderPanel2 = new HeaderPanel();
      this.txtDocumentCode = new TextBox();
      this.TextBox_DocumentTypeId = new TextBox();
      this.TextBox_OrderId = new TextBox();
      this.TextBox_AmountSurchar = new TextBox();
      this.TextBox_AmountDis = new TextBox();
      this.Label_AmountTotal = new Label();
      this.Label6 = new Label();
      this.Label_DocumentId = new Label();
      this.Label4 = new Label();
      this.Label_DocumentType = new Label();
      this.Label2 = new Label();
      this.Button_CreateTicket = new MyXPButton.MyXPButton();
      this.Button_CreateInvoice = new MyXPButton.MyXPButton();
      this.HeaderPanel1 = new HeaderPanel();
      this.Button_GoOut = new Button();
      ((Control) this.HeaderPanel2).SuspendLayout();
      ((Control) this.HeaderPanel1).SuspendLayout();
      this.SuspendLayout();
      this.TextBox_ClientId.BackColor = Color.FromArgb((int) byte.MaxValue, 240, 140);
      this.TextBox_ClientId.Font = new Font("Tahoma", 12.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.TextBox_ClientId.Location = new Point(409, 85);
      this.TextBox_ClientId.Name = "TextBox_ClientId";
      this.TextBox_ClientId.ReadOnly = true;
      this.TextBox_ClientId.Size = new Size(16, 28);
      this.TextBox_ClientId.TabIndex = 225;
      this.TextBox_ClientId.TextAlign = HorizontalAlignment.Center;
      this.TextBox_ClientId.Visible = false;
      this.Label_ClienteDes.BackColor = Color.FromArgb((int) byte.MaxValue, 240, 140);
      this.Label_ClienteDes.BorderStyle = BorderStyle.FixedSingle;
      this.Label_ClienteDes.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label_ClienteDes.ForeColor = Color.FromArgb(0, 0, 64);
      this.Label_ClienteDes.Location = new Point(74, 50);
      this.Label_ClienteDes.Name = "Label_ClienteDes";
      this.Label_ClienteDes.Size = new Size(381, 28);
      this.Label_ClienteDes.TabIndex = 224;
      this.Label_Name.AutoSize = true;
      this.Label_Name.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label_Name.ForeColor = Color.MediumBlue;
      this.Label_Name.Location = new Point(7, 51);
      this.Label_Name.Name = "Label_Name";
      this.Label_Name.Size = new Size(65, 20);
      this.Label_Name.TabIndex = 223;
      this.Label_Name.Text = "Cliente:";
      ((Control) this.HeaderPanel2).BackColor = Color.Transparent;
      this.HeaderPanel2.set_BorderColor(SystemColors.ActiveCaption);
      this.HeaderPanel2.set_BorderStyle((BorderStyles) 0);
      this.HeaderPanel2.set_CaptionBeginColor(Color.FromArgb(240, 190, 70));
      this.HeaderPanel2.set_CaptionEndColor(Color.FromArgb((int) byte.MaxValue, 224, 192));
      this.HeaderPanel2.set_CaptionGradientDirection(LinearGradientMode.Vertical);
      this.HeaderPanel2.set_CaptionHeight(26);
      this.HeaderPanel2.set_CaptionPosition((CaptionPositions) 0);
      this.HeaderPanel2.set_CaptionText("Documento Original");
      this.HeaderPanel2.set_CaptionVisible(true);
      ((Control) this.HeaderPanel2).Controls.Add((Control) this.txtDocumentCode);
      ((Control) this.HeaderPanel2).Controls.Add((Control) this.TextBox_DocumentTypeId);
      ((Control) this.HeaderPanel2).Controls.Add((Control) this.TextBox_OrderId);
      ((Control) this.HeaderPanel2).Controls.Add((Control) this.TextBox_AmountSurchar);
      ((Control) this.HeaderPanel2).Controls.Add((Control) this.TextBox_AmountDis);
      ((Control) this.HeaderPanel2).Controls.Add((Control) this.Label_AmountTotal);
      ((Control) this.HeaderPanel2).Controls.Add((Control) this.Label6);
      ((Control) this.HeaderPanel2).Controls.Add((Control) this.Label_DocumentId);
      ((Control) this.HeaderPanel2).Controls.Add((Control) this.Label4);
      ((Control) this.HeaderPanel2).Controls.Add((Control) this.Label_DocumentType);
      ((Control) this.HeaderPanel2).Controls.Add((Control) this.Label2);
      ((Control) this.HeaderPanel2).Controls.Add((Control) this.TextBox_ClientId);
      ((Control) this.HeaderPanel2).Controls.Add((Control) this.Label_ClienteDes);
      ((Control) this.HeaderPanel2).Controls.Add((Control) this.Label_Name);
      this.HeaderPanel2.set_Font(new Font("Trebuchet MS", 9.75f, FontStyle.Bold));
      this.HeaderPanel2.set_GradientDirection(LinearGradientMode.Vertical);
      this.HeaderPanel2.set_GradientEnd(SystemColors.Window);
      this.HeaderPanel2.set_GradientStart(Color.WhiteSmoke);
      ((Control) this.HeaderPanel2).Location = new Point(0, 0);
      ((Control) this.HeaderPanel2).Name = "HeaderPanel2";
      this.HeaderPanel2.set_PanelIcon((Icon) null);
      this.HeaderPanel2.set_PanelIconVisible(false);
      ((Control) this.HeaderPanel2).Size = new Size(469, 151);
      ((Control) this.HeaderPanel2).TabIndex = 226;
      this.HeaderPanel2.set_TextAntialias(true);
      this.txtDocumentCode.BackColor = Color.FromArgb((int) byte.MaxValue, 240, 140);
      this.txtDocumentCode.Font = new Font("Tahoma", 12.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtDocumentCode.Location = new Point(329, 85);
      this.txtDocumentCode.Name = "txtDocumentCode";
      this.txtDocumentCode.ReadOnly = true;
      this.txtDocumentCode.Size = new Size(16, 28);
      this.txtDocumentCode.TabIndex = 236;
      this.txtDocumentCode.TextAlign = HorizontalAlignment.Center;
      this.txtDocumentCode.Visible = false;
      this.TextBox_DocumentTypeId.BackColor = Color.FromArgb((int) byte.MaxValue, 240, 140);
      this.TextBox_DocumentTypeId.Font = new Font("Tahoma", 12.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.TextBox_DocumentTypeId.Location = new Point(345, 85);
      this.TextBox_DocumentTypeId.Name = "TextBox_DocumentTypeId";
      this.TextBox_DocumentTypeId.ReadOnly = true;
      this.TextBox_DocumentTypeId.Size = new Size(16, 28);
      this.TextBox_DocumentTypeId.TabIndex = 235;
      this.TextBox_DocumentTypeId.TextAlign = HorizontalAlignment.Center;
      this.TextBox_DocumentTypeId.Visible = false;
      this.TextBox_OrderId.BackColor = Color.FromArgb((int) byte.MaxValue, 240, 140);
      this.TextBox_OrderId.Font = new Font("Tahoma", 12.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.TextBox_OrderId.Location = new Point(361, 85);
      this.TextBox_OrderId.Name = "TextBox_OrderId";
      this.TextBox_OrderId.ReadOnly = true;
      this.TextBox_OrderId.Size = new Size(16, 28);
      this.TextBox_OrderId.TabIndex = 234;
      this.TextBox_OrderId.TextAlign = HorizontalAlignment.Center;
      this.TextBox_OrderId.Visible = false;
      this.TextBox_AmountSurchar.BackColor = Color.FromArgb((int) byte.MaxValue, 240, 140);
      this.TextBox_AmountSurchar.Font = new Font("Tahoma", 12.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.TextBox_AmountSurchar.Location = new Point(393, 85);
      this.TextBox_AmountSurchar.Name = "TextBox_AmountSurchar";
      this.TextBox_AmountSurchar.ReadOnly = true;
      this.TextBox_AmountSurchar.Size = new Size(16, 28);
      this.TextBox_AmountSurchar.TabIndex = 233;
      this.TextBox_AmountSurchar.TextAlign = HorizontalAlignment.Center;
      this.TextBox_AmountSurchar.Visible = false;
      this.TextBox_AmountDis.BackColor = Color.FromArgb((int) byte.MaxValue, 240, 140);
      this.TextBox_AmountDis.Font = new Font("Tahoma", 12.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.TextBox_AmountDis.Location = new Point(377, 85);
      this.TextBox_AmountDis.Name = "TextBox_AmountDis";
      this.TextBox_AmountDis.ReadOnly = true;
      this.TextBox_AmountDis.Size = new Size(16, 28);
      this.TextBox_AmountDis.TabIndex = 232;
      this.TextBox_AmountDis.TextAlign = HorizontalAlignment.Center;
      this.TextBox_AmountDis.Visible = false;
      this.Label_AmountTotal.BackColor = Color.FromArgb((int) byte.MaxValue, 240, 140);
      this.Label_AmountTotal.BorderStyle = BorderStyle.FixedSingle;
      this.Label_AmountTotal.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label_AmountTotal.ForeColor = Color.FromArgb(0, 0, 64);
      this.Label_AmountTotal.Location = new Point(74, 88);
      this.Label_AmountTotal.Name = "Label_AmountTotal";
      this.Label_AmountTotal.Size = new Size(150, 28);
      this.Label_AmountTotal.TabIndex = 231;
      this.Label_AmountTotal.TextAlign = ContentAlignment.MiddleRight;
      this.Label6.AutoSize = true;
      this.Label6.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label6.ForeColor = Color.MediumBlue;
      this.Label6.Location = new Point(7, 89);
      this.Label6.Name = "Label6";
      this.Label6.Size = new Size(50, 20);
      this.Label6.TabIndex = 230;
      this.Label6.Text = "Total:";
      this.Label_DocumentId.BackColor = Color.FromArgb((int) byte.MaxValue, 240, 140);
      this.Label_DocumentId.BorderStyle = BorderStyle.FixedSingle;
      this.Label_DocumentId.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label_DocumentId.ForeColor = Color.FromArgb(0, 0, 64);
      this.Label_DocumentId.Location = new Point(305, 10);
      this.Label_DocumentId.Name = "Label_DocumentId";
      this.Label_DocumentId.Size = new Size(150, 28);
      this.Label_DocumentId.TabIndex = 229;
      this.Label4.AutoSize = true;
      this.Label4.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label4.ForeColor = Color.MediumBlue;
      this.Label4.Location = new Point(234, 11);
      this.Label4.Name = "Label4";
      this.Label4.Size = new Size(70, 20);
      this.Label4.TabIndex = 228;
      this.Label4.Text = "Número:";
      this.Label_DocumentType.BackColor = Color.FromArgb((int) byte.MaxValue, 240, 140);
      this.Label_DocumentType.BorderStyle = BorderStyle.FixedSingle;
      this.Label_DocumentType.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label_DocumentType.ForeColor = Color.FromArgb(0, 0, 64);
      this.Label_DocumentType.Location = new Point(74, 10);
      this.Label_DocumentType.Name = "Label_DocumentType";
      this.Label_DocumentType.Size = new Size(150, 28);
      this.Label_DocumentType.TabIndex = 227;
      this.Label2.AutoSize = true;
      this.Label2.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label2.ForeColor = Color.MediumBlue;
      this.Label2.Location = new Point(7, 11);
      this.Label2.Name = "Label2";
      this.Label2.Size = new Size(45, 20);
      this.Label2.TabIndex = 226;
      this.Label2.Text = "Tipo:";
      this.Button_CreateTicket.set_AdjustImageLocation(new Point(0, 0));
      this.Button_CreateTicket.set_BtnShape((emunType.BtnShape) 0);
      this.Button_CreateTicket.set_BtnStyle((emunType.XPStyle) 1);
      ((Control) this.Button_CreateTicket).Font = new Font("Trebuchet MS", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      ((Control) this.Button_CreateTicket).ForeColor = Color.MediumBlue;
      ((Control) this.Button_CreateTicket).Location = new Point(125, 12);
      ((Control) this.Button_CreateTicket).Name = "Button_CreateTicket";
      ((Control) this.Button_CreateTicket).Size = new Size(99, 57);
      ((Control) this.Button_CreateTicket).TabIndex = 0;
      ((ButtonBase) this.Button_CreateTicket).Text = "BOLETA";
      ((ButtonBase) this.Button_CreateTicket).UseVisualStyleBackColor = true;
      this.Button_CreateInvoice.set_AdjustImageLocation(new Point(0, 0));
      this.Button_CreateInvoice.set_BtnShape((emunType.BtnShape) 0);
      this.Button_CreateInvoice.set_BtnStyle((emunType.XPStyle) 1);
      ((Control) this.Button_CreateInvoice).Font = new Font("Trebuchet MS", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      ((Control) this.Button_CreateInvoice).ForeColor = Color.MediumBlue;
      ((Control) this.Button_CreateInvoice).Location = new Point(238, 12);
      ((Control) this.Button_CreateInvoice).Name = "Button_CreateInvoice";
      ((Control) this.Button_CreateInvoice).Size = new Size(99, 57);
      ((Control) this.Button_CreateInvoice).TabIndex = 1;
      ((ButtonBase) this.Button_CreateInvoice).Text = "FACTURA";
      ((ButtonBase) this.Button_CreateInvoice).UseVisualStyleBackColor = true;
      ((Control) this.HeaderPanel1).BackColor = Color.Transparent;
      this.HeaderPanel1.set_BorderColor(SystemColors.ActiveCaption);
      this.HeaderPanel1.set_BorderStyle((BorderStyles) 0);
      this.HeaderPanel1.set_CaptionBeginColor(Color.FromArgb(240, 190, 70));
      this.HeaderPanel1.set_CaptionEndColor(Color.FromArgb((int) byte.MaxValue, 224, 192));
      this.HeaderPanel1.set_CaptionGradientDirection(LinearGradientMode.Vertical);
      this.HeaderPanel1.set_CaptionHeight(26);
      this.HeaderPanel1.set_CaptionPosition((CaptionPositions) 0);
      this.HeaderPanel1.set_CaptionText("Documento Nuevo");
      this.HeaderPanel1.set_CaptionVisible(true);
      ((Control) this.HeaderPanel1).Controls.Add((Control) this.Button_GoOut);
      ((Control) this.HeaderPanel1).Controls.Add((Control) this.Button_CreateTicket);
      ((Control) this.HeaderPanel1).Controls.Add((Control) this.Button_CreateInvoice);
      this.HeaderPanel1.set_Font(new Font("Trebuchet MS", 9.75f, FontStyle.Bold));
      this.HeaderPanel1.set_GradientDirection(LinearGradientMode.Vertical);
      this.HeaderPanel1.set_GradientEnd(SystemColors.Window);
      this.HeaderPanel1.set_GradientStart(Color.WhiteSmoke);
      ((Control) this.HeaderPanel1).Location = new Point(0, 151);
      ((Control) this.HeaderPanel1).Name = "HeaderPanel1";
      this.HeaderPanel1.set_PanelIcon((Icon) null);
      this.HeaderPanel1.set_PanelIconVisible(false);
      ((Control) this.HeaderPanel1).Size = new Size(469, 108);
      ((Control) this.HeaderPanel1).TabIndex = 227;
      this.HeaderPanel1.set_TextAntialias(true);
      this.Button_GoOut.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_GoOut.ForeColor = Color.MediumBlue;
      this.Button_GoOut.Image = (Image) TriNetRestPOS.My.Resources.Resources.i_Close;
      this.Button_GoOut.Location = new Point(377, 12);
      this.Button_GoOut.Name = "Button_GoOut";
      this.Button_GoOut.Size = new Size(80, 57);
      this.Button_GoOut.TabIndex = 2;
      this.Button_GoOut.Tag = (object) "Res_Back";
      this.Button_GoOut.Text = "&Atrás";
      this.Button_GoOut.TextImageRelation = TextImageRelation.TextAboveImage;
      this.Button_GoOut.UseVisualStyleBackColor = true;
      this.AutoScaleDimensions = new SizeF(7f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.ActiveCaptionText;
      this.ClientSize = new Size(469, 259);
      this.ControlBox = false;
      this.Controls.Add((Control) this.HeaderPanel1);
      this.Controls.Add((Control) this.HeaderPanel2);
      this.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (FrmChangeDocument);
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Cambio de Documento";
      ((Control) this.HeaderPanel2).ResumeLayout(false);
      ((Control) this.HeaderPanel2).PerformLayout();
      ((Control) this.HeaderPanel1).ResumeLayout(false);
      this.ResumeLayout(false);
    }

    internal virtual TextBox TextBox_ClientId { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label_ClienteDes { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label_Name { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual HeaderPanel HeaderPanel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual MyXPButton.MyXPButton Button_CreateTicket
    {
      get
      {
        return this._Button_CreateTicket;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_CreateTicket_Click);
        MyXPButton.MyXPButton buttonCreateTicket1 = this._Button_CreateTicket;
        if (buttonCreateTicket1 != null)
          ((Control) buttonCreateTicket1).Click -= eventHandler;
        this._Button_CreateTicket = value;
        MyXPButton.MyXPButton buttonCreateTicket2 = this._Button_CreateTicket;
        if (buttonCreateTicket2 == null)
          return;
        ((Control) buttonCreateTicket2).Click += eventHandler;
      }
    }

    internal virtual MyXPButton.MyXPButton Button_CreateInvoice
    {
      get
      {
        return this._Button_CreateInvoice;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_CreateInvoice_Click);
        MyXPButton.MyXPButton buttonCreateInvoice1 = this._Button_CreateInvoice;
        if (buttonCreateInvoice1 != null)
          ((Control) buttonCreateInvoice1).Click -= eventHandler;
        this._Button_CreateInvoice = value;
        MyXPButton.MyXPButton buttonCreateInvoice2 = this._Button_CreateInvoice;
        if (buttonCreateInvoice2 == null)
          return;
        ((Control) buttonCreateInvoice2).Click += eventHandler;
      }
    }

    internal virtual Label Label_DocumentType { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label_DocumentId { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label_AmountTotal { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual HeaderPanel HeaderPanel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

    internal virtual TextBox TextBox_AmountSurchar { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBox_AmountDis { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBox_OrderId { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBox_DocumentTypeId { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox txtDocumentCode { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private void FrmChangeDocument_KeyDown(object sender, KeyEventArgs e)
    {
      switch (e.KeyValue)
      {
        case 27:
          ModGeneralVar.g_bol_IsReady = false;
          this.Close();
          break;
        case 118:
          this.Button_CreateTicket_Click((object) null, (EventArgs) null);
          break;
        case 119:
          this.Button_CreateInvoice_Click((object) null, (EventArgs) null);
          break;
      }
    }

    private void FrmChangeDocument_Load(object sender, EventArgs e)
    {
      this.Resource(ModGeneralFunctions.Get_Language((object) this));
      this.txtDocumentCode.Text = Conversions.ToString(this.intDocumentCode);
      this.Label_DocumentType.Text = this.strDocumentType;
      this.TextBox_DocumentTypeId.Text = this.strDocumentTypeId;
      this.Label_DocumentId.Text = this.strDocumentId;
      this.TextBox_OrderId.Text = this.strOrderId;
      this.TextBox_ClientId.Text = this.strClientId;
      this.Label_ClienteDes.Text = this.strClientDes;
      this.Label_AmountTotal.Text = ModGeneralFunctions.FormatMoney(this.dblAmoutnTotal);
      this.TextBox_AmountDis.Text = ModGeneralFunctions.FormatMoney(this.dblAmoutnDis);
      this.TextBox_AmountSurchar.Text = ModGeneralFunctions.FormatMoney(this.dblAmoutnSur);
      if (this.strDocumentTypeId.Equals(ModGeneralVar.g_GeneralCode.get_Docu_Ticket()))
        ((Control) this.Button_CreateTicket).Enabled = false;
      if (!Conversions.ToBoolean(ModGeneralFunctions.ObtenerAPPCONFIG("ACTIVAR_CONFIGURACION_ECUADOR")))
        return;
      ((Control) this.Button_CreateTicket).Enabled = false;
    }

    private void Button_GoOut_Click(object sender, EventArgs e)
    {
      ModGeneralVar.g_bol_IsReady = false;
      this.Close();
    }

    private void Button_CreateInvoice_Click(object sender, EventArgs e)
    {
      if (!ModGeneralFunctions.ValidInventoryClose())
      {
        ModGeneralFunctions.MessageOk_Large("¡Se ha cerrado el Inventario, no podrá Generar Facturas!", false);
      }
      else
      {
        if (!ModGeneralFunctions.MessageMakeAction("¿Generar [Factura]?", false))
          return;
        if (ModGeneralFunctions.CadenaToInteger(this.TextBox_ClientId.Text) == 0 | this.TextBox_DocumentTypeId.Text.Equals(ModGeneralVar.g_GeneralCode.get_Docu_Invoice()) | this.TextBox_DocumentTypeId.Text.Equals(ModGeneralVar.g_GeneralCode.get_Docu_Factura()))
        {
          if (!ModGeneralFunctions.Show_SearchClient())
            return;
          if (this.TextBox_ClientId.Text.Equals(ModGeneralVar.g_Str_RecordID))
          {
            ModGeneralFunctions.MessageOk("¡Seleccione otro Cliente!");
            return;
          }
          this.TextBox_ClientId.Text = ModGeneralVar.g_Str_RecordID;
          this.Label_ClienteDes.Text = ModGeneralVar.g_Str_RecordDes;
        }
        BE_TR1_DOCUMENTS beTr1Documents = new BE_TR1_DOCUMENTS();
        string p_Mensaje = "";
        int integer = ModGeneralFunctions.CadenaToInteger(this.txtDocumentCode.Text);
        if (ModGeneralVar.g_BE_TR1_CFGVARIABLES.get_IsFirstPay())
        {
          if (ModGeneralVar.g_BE_TR1_CFGVARIABLES.get_ShowPay())
          {
            if (ModGeneralFunctions.MessageMakeAction("¿Pagar Atención [" + this.TextBox_OrderId.Text.Trim() + "]?", false) && ModGeneralFunctions.PagarxCanje(integer, ModGeneralVar.g_GeneralCode.get_Docu_Invoice(), this.TextBox_ClientId.Text))
              p_Mensaje = StructApp.RESULT_OK;
          }
          else if (ModGeneralFunctions.PagarxCanje(integer, ModGeneralVar.g_GeneralCode.get_Docu_Invoice(), this.TextBox_ClientId.Text))
            p_Mensaje = StructApp.RESULT_OK;
        }
        else
        {
          p_Mensaje = ModGeneralFunctions.CrearDocumentoxCanje_Cliente(this.TextBox_OrderId.Text.Trim(), ModGeneralVar.g_GeneralCode.get_Docu_Invoice(), ref integer, false, this.TextBox_ClientId.Text, (BE_TR1_DOCUMENTS) null, (BECollec_TR1_DOCUMENTS_PAID) null);
          if (!ModGeneralVar.g_Str_OrderTypeID.Equals(ModGeneralVar.g_Str_OrderTypeDelivery))
          {
            if (ModGeneralVar.g_BE_TR1_CFGVARIABLES.get_ShowPay())
            {
              if (ModGeneralFunctions.MessageMakeAction("¿Pagar Atención [" + this.TextBox_OrderId.Text.Trim() + "]?", false) && ModGeneralFunctions.PagarxDocumento(integer, false, false))
                p_Mensaje = StructApp.RESULT_OK;
            }
            else if (ModGeneralFunctions.PagarxDocumento(integer, false, false))
              p_Mensaje = StructApp.RESULT_OK;
          }
        }
        if (p_Mensaje.Equals(StructApp.RESULT_OK))
        {
          BL_TR1_CAMBIO_DOCUMENTO tr1CambioDocumento1 = new BL_TR1_CAMBIO_DOCUMENTO();
          BE_TR1_CAMBIO_DOCUMENTO tr1CambioDocumento2 = new BE_TR1_CAMBIO_DOCUMENTO();
          tr1CambioDocumento2.set_LocalId(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId());
          tr1CambioDocumento2.set_CambioId(ModGeneralVar.g_intCambioId);
          tr1CambioDocumento2.set_DocumentCodeOrigen(integer);
          tr1CambioDocumento2.set_UsuarioOrigen(ModGeneralVar.g_BE_USERS.get_UserId());
          tr1CambioDocumento1.ActualizarCambioDocumento(ref tr1CambioDocumento2);
          ModGeneralVar.g_Str_OrderID = "";
          ModGeneralVar.g_Str_SubTableID = "";
          ModGeneralVar.g_bol_IsReady = true;
          tr1CambioDocumento2 = (BE_TR1_CAMBIO_DOCUMENTO) null;
          this.Close();
        }
        else
        {
          if (p_Mensaje.Equals(""))
            return;
          ModGeneralFunctions.MessageError_Large(p_Mensaje, true);
        }
      }
    }

    private void Button_CreateTicket_Click(object sender, EventArgs e)
    {
      if (!ModGeneralFunctions.ValidInventoryClose())
      {
        ModGeneralFunctions.MessageOk_Large("¡Se ha cerrado el Inventario, no podrá Generar Boletas!", false);
      }
      else
      {
        if (!ModGeneralFunctions.MessageMakeAction("¿Generar [" + ModGeneralVar.get_Docu_BoletaOrTicket() + "]?", false))
          return;
        BE_TR1_DOCUMENTS beTr1Documents = new BE_TR1_DOCUMENTS();
        string p_Mensaje = "";
        int integer = ModGeneralFunctions.CadenaToInteger(this.txtDocumentCode.Text);
        if (ModGeneralVar.g_BE_TR1_CFGVARIABLES.get_IsFirstPay())
        {
          if (ModGeneralVar.g_BE_TR1_CFGVARIABLES.get_ShowPay())
          {
            if (ModGeneralFunctions.MessageMakeAction("¿Pagar Atención [" + this.TextBox_OrderId.Text.Trim() + "]?", false) && ModGeneralFunctions.PagarxCanje(integer, ModGeneralVar.g_GeneralCode.get_Docu_Ticket(), this.TextBox_ClientId.Text))
              p_Mensaje = StructApp.RESULT_OK;
          }
          else if (ModGeneralFunctions.PagarxCanje(integer, ModGeneralVar.g_GeneralCode.get_Docu_Ticket(), this.TextBox_ClientId.Text))
            p_Mensaje = StructApp.RESULT_OK;
        }
        else
        {
          p_Mensaje = ModGeneralFunctions.CrearDocumentoxCanje_Cliente(this.TextBox_OrderId.Text.Trim(), ModGeneralVar.g_GeneralCode.get_Docu_Ticket(), ref integer, false, this.TextBox_ClientId.Text, (BE_TR1_DOCUMENTS) null, (BECollec_TR1_DOCUMENTS_PAID) null);
          if (!ModGeneralVar.g_Str_OrderTypeID.Equals(ModGeneralVar.g_Str_OrderTypeDelivery))
          {
            if (ModGeneralVar.g_BE_TR1_CFGVARIABLES.get_ShowPay())
            {
              if (ModGeneralFunctions.MessageMakeAction("¿Pagar Atención [" + this.TextBox_OrderId.Text.Trim() + "]?", false) && ModGeneralFunctions.PagarxDocumento(integer, false, false))
                p_Mensaje = StructApp.RESULT_OK;
            }
            else if (ModGeneralFunctions.PagarxDocumento(integer, false, false))
              p_Mensaje = StructApp.RESULT_OK;
          }
        }
        if (p_Mensaje.Equals(StructApp.RESULT_OK))
        {
          BL_TR1_CAMBIO_DOCUMENTO tr1CambioDocumento1 = new BL_TR1_CAMBIO_DOCUMENTO();
          BE_TR1_CAMBIO_DOCUMENTO tr1CambioDocumento2 = new BE_TR1_CAMBIO_DOCUMENTO();
          tr1CambioDocumento2.set_LocalId(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId());
          tr1CambioDocumento2.set_CambioId(ModGeneralVar.g_intCambioId);
          tr1CambioDocumento2.set_DocumentCodeOrigen(integer);
          tr1CambioDocumento2.set_UsuarioOrigen(ModGeneralVar.g_BE_USERS.get_UserId());
          tr1CambioDocumento1.ActualizarCambioDocumento(ref tr1CambioDocumento2);
          ModGeneralVar.g_Str_OrderID = "";
          ModGeneralVar.g_Str_SubTableID = "";
          ModGeneralVar.g_bol_IsReady = true;
          tr1CambioDocumento2 = (BE_TR1_CAMBIO_DOCUMENTO) null;
          this.Close();
        }
        else
        {
          if (p_Mensaje.Equals(""))
            return;
          ModGeneralFunctions.MessageError_Large(p_Mensaje, true);
        }
      }
    }

    private List<BE_TR1_ORDERDETAILS> getOrderDetail(
      int pintLocalId,
      int pintEmpresaId,
      int pintDocumentCode,
      string pstrOrderId)
    {
      this.oListaORDERDETAILS = new BL_TR1_ORDERDETAILS().ListarxDocumentCode(pintLocalId, pintEmpresaId, pintDocumentCode, pstrOrderId);
      return this.oListaORDERDETAILS;
    }

    private void Resource(ResourceManager Rm)
    {
      ((ButtonBase) this.Button_CreateTicket).Text = Rm.GetString("Res_Ticket") + " [F7]";
      ((ButtonBase) this.Button_CreateInvoice).Text = Rm.GetString("Res_Invoice") + " [F8]";
    }
  }
}
