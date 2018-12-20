// Decompiled with JetBrains decompiler
// Type: TriNetRestPOS.FrmCfgDocument
// Assembly: TriNetRestPOS, Version=5.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 43377352-E952-4AC1-9BA6-CCBE4AE5F575
// Assembly location: C:\log\TriNetRestPOS.exe

using KIS.Controls;
using KIS.Controls.Windows;
using Microsoft.VisualBasic.CompilerServices;
using System;
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
  public class FrmCfgDocument : Form
  {
    private IContainer components;
    private BE_TR1_VARDOCUMENT obeVARDOCUMENT;
    private BL_TR1_CONFIGURATION oblCONFIGURATION;
    public bool _IsAdvanced;
    public int _BoxId;

    public FrmCfgDocument()
    {
      this.Load += new EventHandler(this.FrmCfgDocument_Load);
      this.KeyDown += new KeyEventHandler(this.FrmCfgDocument_KeyDown);
      this._IsAdvanced = false;
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FrmCfgDocument));
      this.HeaderPanel_Configuracion = new HeaderPanel();
      this.chbVerClienteDireccion = new CheckBox();
      this.TextBox_Message = new TextBox();
      this.CheckBox_ShowPersonNum = new CheckBox();
      this.CheckBox_ShowSerieNum = new CheckBox();
      this.CheckBox_ShowAutorizaNum = new CheckBox();
      this.CheckBox_ShowOrderNum = new CheckBox();
      this.CheckBox_ShowBox = new CheckBox();
      this.Button_GoOut = new Button();
      this.Button_Save = new Button();
      this.CheckBox_ShowTypeChange = new CheckBox();
      this.CheckBox_ShowTable = new CheckBox();
      this.CheckBox_ShowBoxUser = new CheckBox();
      this.CheckBox_ShowMessage = new CheckBox();
      this.CheckBox_ShowClientId = new CheckBox();
      this.CheckBox_ShowClientSReason = new CheckBox();
      this.CheckBox_ShowNumLetters = new CheckBox();
      this.CheckBox_ShowWebPage = new CheckBox();
      this.CheckBox_ShowPhone = new CheckBox();
      this.CheckBox_ShowAddress = new CheckBox();
      this.CheckBox_ShowId = new CheckBox();
      this.CheckBox_ShowSComertial = new CheckBox();
      this.CheckBox_ShowSReason = new CheckBox();
      this.RichTextBox_PreBill = new RichTextBox();
      ((Control) this.HeaderPanel_Configuracion).SuspendLayout();
      this.SuspendLayout();
      this.HeaderPanel_Configuracion.set_BorderColor(SystemColors.ActiveCaption);
      this.HeaderPanel_Configuracion.set_BorderStyle((BorderStyles) 1);
      this.HeaderPanel_Configuracion.set_CaptionBeginColor(Color.FromArgb(240, 190, 70));
      this.HeaderPanel_Configuracion.set_CaptionEndColor(Color.Moccasin);
      this.HeaderPanel_Configuracion.set_CaptionGradientDirection(LinearGradientMode.Vertical);
      this.HeaderPanel_Configuracion.set_CaptionHeight(26);
      this.HeaderPanel_Configuracion.set_CaptionPosition((CaptionPositions) 0);
      this.HeaderPanel_Configuracion.set_CaptionText("Seleccione Áreas a Imprimir");
      this.HeaderPanel_Configuracion.set_CaptionVisible(true);
      ((Control) this.HeaderPanel_Configuracion).Controls.Add((Control) this.chbVerClienteDireccion);
      ((Control) this.HeaderPanel_Configuracion).Controls.Add((Control) this.TextBox_Message);
      ((Control) this.HeaderPanel_Configuracion).Controls.Add((Control) this.CheckBox_ShowPersonNum);
      ((Control) this.HeaderPanel_Configuracion).Controls.Add((Control) this.CheckBox_ShowSerieNum);
      ((Control) this.HeaderPanel_Configuracion).Controls.Add((Control) this.CheckBox_ShowAutorizaNum);
      ((Control) this.HeaderPanel_Configuracion).Controls.Add((Control) this.CheckBox_ShowOrderNum);
      ((Control) this.HeaderPanel_Configuracion).Controls.Add((Control) this.CheckBox_ShowBox);
      ((Control) this.HeaderPanel_Configuracion).Controls.Add((Control) this.Button_GoOut);
      ((Control) this.HeaderPanel_Configuracion).Controls.Add((Control) this.Button_Save);
      ((Control) this.HeaderPanel_Configuracion).Controls.Add((Control) this.CheckBox_ShowTypeChange);
      ((Control) this.HeaderPanel_Configuracion).Controls.Add((Control) this.CheckBox_ShowTable);
      ((Control) this.HeaderPanel_Configuracion).Controls.Add((Control) this.CheckBox_ShowBoxUser);
      ((Control) this.HeaderPanel_Configuracion).Controls.Add((Control) this.CheckBox_ShowMessage);
      ((Control) this.HeaderPanel_Configuracion).Controls.Add((Control) this.CheckBox_ShowClientId);
      ((Control) this.HeaderPanel_Configuracion).Controls.Add((Control) this.CheckBox_ShowClientSReason);
      ((Control) this.HeaderPanel_Configuracion).Controls.Add((Control) this.CheckBox_ShowNumLetters);
      ((Control) this.HeaderPanel_Configuracion).Controls.Add((Control) this.CheckBox_ShowWebPage);
      ((Control) this.HeaderPanel_Configuracion).Controls.Add((Control) this.CheckBox_ShowPhone);
      ((Control) this.HeaderPanel_Configuracion).Controls.Add((Control) this.CheckBox_ShowAddress);
      ((Control) this.HeaderPanel_Configuracion).Controls.Add((Control) this.CheckBox_ShowId);
      ((Control) this.HeaderPanel_Configuracion).Controls.Add((Control) this.CheckBox_ShowSComertial);
      ((Control) this.HeaderPanel_Configuracion).Controls.Add((Control) this.CheckBox_ShowSReason);
      ((Control) this.HeaderPanel_Configuracion).Controls.Add((Control) this.RichTextBox_PreBill);
      this.HeaderPanel_Configuracion.set_Font(new Font("Trebuchet MS", 9.75f, FontStyle.Bold));
      this.HeaderPanel_Configuracion.set_GradientDirection(LinearGradientMode.Vertical);
      this.HeaderPanel_Configuracion.set_GradientEnd(SystemColors.Window);
      this.HeaderPanel_Configuracion.set_GradientStart(SystemColors.Window);
      ((Control) this.HeaderPanel_Configuracion).Location = new Point(-1, -1);
      ((Control) this.HeaderPanel_Configuracion).Name = "HeaderPanel_Configuracion";
      this.HeaderPanel_Configuracion.set_PanelIcon((Icon) null);
      this.HeaderPanel_Configuracion.set_PanelIconVisible(false);
      ((Control) this.HeaderPanel_Configuracion).Size = new Size(620, 694);
      ((Control) this.HeaderPanel_Configuracion).TabIndex = 209;
      this.HeaderPanel_Configuracion.set_TextAntialias(true);
      this.chbVerClienteDireccion.AutoSize = true;
      this.chbVerClienteDireccion.BackColor = Color.Transparent;
      this.chbVerClienteDireccion.CheckAlign = ContentAlignment.MiddleRight;
      this.chbVerClienteDireccion.Checked = true;
      this.chbVerClienteDireccion.CheckState = CheckState.Checked;
      this.chbVerClienteDireccion.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.chbVerClienteDireccion.ForeColor = Color.MediumBlue;
      this.chbVerClienteDireccion.Location = new Point(26, 586);
      this.chbVerClienteDireccion.Name = "chbVerClienteDireccion";
      this.chbVerClienteDireccion.Size = new Size(109, 24);
      this.chbVerClienteDireccion.TabIndex = 230;
      this.chbVerClienteDireccion.Text = "Dir. Cliente";
      this.chbVerClienteDireccion.UseVisualStyleBackColor = false;
      this.TextBox_Message.Font = new Font("Lucida Console", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.TextBox_Message.Location = new Point(142, 617);
      this.TextBox_Message.MaxLength = 500;
      this.TextBox_Message.Multiline = true;
      this.TextBox_Message.Name = "TextBox_Message";
      this.TextBox_Message.Size = new Size(319, 42);
      this.TextBox_Message.TabIndex = 229;
      this.TextBox_Message.TextAlign = HorizontalAlignment.Center;
      this.CheckBox_ShowPersonNum.AutoSize = true;
      this.CheckBox_ShowPersonNum.BackColor = Color.Transparent;
      this.CheckBox_ShowPersonNum.Checked = true;
      this.CheckBox_ShowPersonNum.CheckState = CheckState.Checked;
      this.CheckBox_ShowPersonNum.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.CheckBox_ShowPersonNum.ForeColor = Color.MediumBlue;
      this.CheckBox_ShowPersonNum.Location = new Point(467, 237);
      this.CheckBox_ShowPersonNum.Name = "CheckBox_ShowPersonNum";
      this.CheckBox_ShowPersonNum.Size = new Size(110, 24);
      this.CheckBox_ShowPersonNum.TabIndex = 228;
      this.CheckBox_ShowPersonNum.Text = "Nº Personas";
      this.CheckBox_ShowPersonNum.UseVisualStyleBackColor = false;
      this.CheckBox_ShowSerieNum.AutoSize = true;
      this.CheckBox_ShowSerieNum.BackColor = Color.Transparent;
      this.CheckBox_ShowSerieNum.Checked = true;
      this.CheckBox_ShowSerieNum.CheckState = CheckState.Checked;
      this.CheckBox_ShowSerieNum.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.CheckBox_ShowSerieNum.ForeColor = Color.MediumBlue;
      this.CheckBox_ShowSerieNum.Location = new Point(467, 256);
      this.CheckBox_ShowSerieNum.Name = "CheckBox_ShowSerieNum";
      this.CheckBox_ShowSerieNum.Size = new Size(85, 24);
      this.CheckBox_ShowSerieNum.TabIndex = 227;
      this.CheckBox_ShowSerieNum.Text = "Nº Serie";
      this.CheckBox_ShowSerieNum.UseVisualStyleBackColor = false;
      this.CheckBox_ShowAutorizaNum.AutoSize = true;
      this.CheckBox_ShowAutorizaNum.BackColor = Color.Transparent;
      this.CheckBox_ShowAutorizaNum.Checked = true;
      this.CheckBox_ShowAutorizaNum.CheckState = CheckState.Checked;
      this.CheckBox_ShowAutorizaNum.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.CheckBox_ShowAutorizaNum.ForeColor = Color.MediumBlue;
      this.CheckBox_ShowAutorizaNum.Location = new Point(467, 275);
      this.CheckBox_ShowAutorizaNum.Name = "CheckBox_ShowAutorizaNum";
      this.CheckBox_ShowAutorizaNum.Size = new Size(137, 24);
      this.CheckBox_ShowAutorizaNum.TabIndex = 226;
      this.CheckBox_ShowAutorizaNum.Text = "Nº Autorización";
      this.CheckBox_ShowAutorizaNum.UseVisualStyleBackColor = false;
      this.CheckBox_ShowOrderNum.AutoSize = true;
      this.CheckBox_ShowOrderNum.BackColor = Color.Transparent;
      this.CheckBox_ShowOrderNum.Checked = true;
      this.CheckBox_ShowOrderNum.CheckState = CheckState.Checked;
      this.CheckBox_ShowOrderNum.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.CheckBox_ShowOrderNum.ForeColor = Color.MediumBlue;
      this.CheckBox_ShowOrderNum.Location = new Point(467, 180);
      this.CheckBox_ShowOrderNum.Name = "CheckBox_ShowOrderNum";
      this.CheckBox_ShowOrderNum.Size = new Size(97, 24);
      this.CheckBox_ShowOrderNum.TabIndex = 225;
      this.CheckBox_ShowOrderNum.Text = "Nº Pedido";
      this.CheckBox_ShowOrderNum.UseVisualStyleBackColor = false;
      this.CheckBox_ShowBox.AutoSize = true;
      this.CheckBox_ShowBox.BackColor = Color.Transparent;
      this.CheckBox_ShowBox.CheckAlign = ContentAlignment.MiddleRight;
      this.CheckBox_ShowBox.Checked = true;
      this.CheckBox_ShowBox.CheckState = CheckState.Checked;
      this.CheckBox_ShowBox.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.CheckBox_ShowBox.ForeColor = Color.MediumBlue;
      this.CheckBox_ShowBox.Location = new Point(77, 176);
      this.CheckBox_ShowBox.Name = "CheckBox_ShowBox";
      this.CheckBox_ShowBox.Size = new Size(59, 24);
      this.CheckBox_ShowBox.TabIndex = 224;
      this.CheckBox_ShowBox.Text = "Caja";
      this.CheckBox_ShowBox.UseVisualStyleBackColor = false;
      this.Button_GoOut.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_GoOut.ForeColor = Color.MediumBlue;
      this.Button_GoOut.Image = (Image) TriNetRestPOS.My.Resources.Resources.i_Close;
      this.Button_GoOut.Location = new Point(477, 459);
      this.Button_GoOut.Name = "Button_GoOut";
      this.Button_GoOut.Size = new Size(138, 64);
      this.Button_GoOut.TabIndex = 223;
      this.Button_GoOut.Text = "&Salir";
      this.Button_GoOut.TextImageRelation = TextImageRelation.TextAboveImage;
      this.Button_GoOut.UseVisualStyleBackColor = true;
      this.Button_Save.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_Save.ForeColor = Color.MediumBlue;
      this.Button_Save.Image = (Image) TriNetRestPOS.My.Resources.Resources.i_Ready;
      this.Button_Save.Location = new Point(477, 524);
      this.Button_Save.Name = "Button_Save";
      this.Button_Save.Size = new Size(139, 62);
      this.Button_Save.TabIndex = 209;
      this.Button_Save.Text = "&Guardar";
      this.Button_Save.TextImageRelation = TextImageRelation.TextAboveImage;
      this.Button_Save.UseVisualStyleBackColor = true;
      this.CheckBox_ShowTypeChange.AutoSize = true;
      this.CheckBox_ShowTypeChange.BackColor = Color.Transparent;
      this.CheckBox_ShowTypeChange.CheckAlign = ContentAlignment.MiddleRight;
      this.CheckBox_ShowTypeChange.Checked = true;
      this.CheckBox_ShowTypeChange.CheckState = CheckState.Checked;
      this.CheckBox_ShowTypeChange.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.CheckBox_ShowTypeChange.ForeColor = Color.MediumBlue;
      this.CheckBox_ShowTypeChange.Location = new Point(-1, 232);
      this.CheckBox_ShowTypeChange.Name = "CheckBox_ShowTypeChange";
      this.CheckBox_ShowTypeChange.Size = new Size(137, 24);
      this.CheckBox_ShowTypeChange.TabIndex = 222;
      this.CheckBox_ShowTypeChange.Text = "Tipo de Cambio";
      this.CheckBox_ShowTypeChange.UseVisualStyleBackColor = false;
      this.CheckBox_ShowTable.AutoSize = true;
      this.CheckBox_ShowTable.BackColor = Color.Transparent;
      this.CheckBox_ShowTable.CheckAlign = ContentAlignment.MiddleRight;
      this.CheckBox_ShowTable.Checked = true;
      this.CheckBox_ShowTable.CheckState = CheckState.Checked;
      this.CheckBox_ShowTable.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.CheckBox_ShowTable.ForeColor = Color.MediumBlue;
      this.CheckBox_ShowTable.Location = new Point(-2, 214);
      this.CheckBox_ShowTable.Name = "CheckBox_ShowTable";
      this.CheckBox_ShowTable.Size = new Size(138, 24);
      this.CheckBox_ShowTable.TabIndex = 221;
      this.CheckBox_ShowTable.Text = "Mesa/Cliente L.";
      this.CheckBox_ShowTable.UseVisualStyleBackColor = false;
      this.CheckBox_ShowBoxUser.AutoSize = true;
      this.CheckBox_ShowBoxUser.BackColor = Color.Transparent;
      this.CheckBox_ShowBoxUser.CheckAlign = ContentAlignment.MiddleRight;
      this.CheckBox_ShowBoxUser.Checked = true;
      this.CheckBox_ShowBoxUser.CheckState = CheckState.Checked;
      this.CheckBox_ShowBoxUser.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.CheckBox_ShowBoxUser.ForeColor = Color.MediumBlue;
      this.CheckBox_ShowBoxUser.Location = new Point(62, 195);
      this.CheckBox_ShowBoxUser.Name = "CheckBox_ShowBoxUser";
      this.CheckBox_ShowBoxUser.Size = new Size(74, 24);
      this.CheckBox_ShowBoxUser.TabIndex = 220;
      this.CheckBox_ShowBoxUser.Text = "Cajero";
      this.CheckBox_ShowBoxUser.UseVisualStyleBackColor = false;
      this.CheckBox_ShowMessage.AutoSize = true;
      this.CheckBox_ShowMessage.BackColor = Color.Transparent;
      this.CheckBox_ShowMessage.CheckAlign = ContentAlignment.MiddleRight;
      this.CheckBox_ShowMessage.Checked = true;
      this.CheckBox_ShowMessage.CheckState = CheckState.Checked;
      this.CheckBox_ShowMessage.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.CheckBox_ShowMessage.ForeColor = Color.MediumBlue;
      this.CheckBox_ShowMessage.Location = new Point(48, 615);
      this.CheckBox_ShowMessage.Name = "CheckBox_ShowMessage";
      this.CheckBox_ShowMessage.Size = new Size(87, 24);
      this.CheckBox_ShowMessage.TabIndex = 218;
      this.CheckBox_ShowMessage.Text = "Mensaje";
      this.CheckBox_ShowMessage.UseVisualStyleBackColor = false;
      this.CheckBox_ShowClientId.AutoSize = true;
      this.CheckBox_ShowClientId.BackColor = Color.Transparent;
      this.CheckBox_ShowClientId.CheckAlign = ContentAlignment.MiddleRight;
      this.CheckBox_ShowClientId.Checked = true;
      this.CheckBox_ShowClientId.CheckState = CheckState.Checked;
      this.CheckBox_ShowClientId.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.CheckBox_ShowClientId.ForeColor = Color.MediumBlue;
      this.CheckBox_ShowClientId.Location = new Point(7, 557);
      this.CheckBox_ShowClientId.Name = "CheckBox_ShowClientId";
      this.CheckBox_ShowClientId.Size = new Size(129, 24);
      this.CheckBox_ShowClientId.TabIndex = 217;
      this.CheckBox_ShowClientId.Text = "R.U.C. Cliente";
      this.CheckBox_ShowClientId.UseVisualStyleBackColor = false;
      this.CheckBox_ShowClientSReason.AutoSize = true;
      this.CheckBox_ShowClientSReason.BackColor = Color.Transparent;
      this.CheckBox_ShowClientSReason.CheckAlign = ContentAlignment.MiddleRight;
      this.CheckBox_ShowClientSReason.Checked = true;
      this.CheckBox_ShowClientSReason.CheckState = CheckState.Checked;
      this.CheckBox_ShowClientSReason.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.CheckBox_ShowClientSReason.ForeColor = Color.MediumBlue;
      this.CheckBox_ShowClientSReason.Location = new Point(3, 512);
      this.CheckBox_ShowClientSReason.Name = "CheckBox_ShowClientSReason";
      this.CheckBox_ShowClientSReason.Size = new Size(133, 24);
      this.CheckBox_ShowClientSReason.TabIndex = 216;
      this.CheckBox_ShowClientSReason.Text = "R. Soc. Cliente";
      this.CheckBox_ShowClientSReason.UseVisualStyleBackColor = false;
      this.CheckBox_ShowNumLetters.AutoSize = true;
      this.CheckBox_ShowNumLetters.BackColor = Color.Transparent;
      this.CheckBox_ShowNumLetters.CheckAlign = ContentAlignment.MiddleRight;
      this.CheckBox_ShowNumLetters.Checked = true;
      this.CheckBox_ShowNumLetters.CheckState = CheckState.Checked;
      this.CheckBox_ShowNumLetters.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.CheckBox_ShowNumLetters.ForeColor = Color.MediumBlue;
      this.CheckBox_ShowNumLetters.Location = new Point(2, 467);
      this.CheckBox_ShowNumLetters.Name = "CheckBox_ShowNumLetters";
      this.CheckBox_ShowNumLetters.Size = new Size(134, 24);
      this.CheckBox_ShowNumLetters.TabIndex = 215;
      this.CheckBox_ShowNumLetters.Text = "Total en Letras";
      this.CheckBox_ShowNumLetters.UseVisualStyleBackColor = false;
      this.CheckBox_ShowWebPage.AutoSize = true;
      this.CheckBox_ShowWebPage.BackColor = Color.Transparent;
      this.CheckBox_ShowWebPage.Checked = true;
      this.CheckBox_ShowWebPage.CheckState = CheckState.Checked;
      this.CheckBox_ShowWebPage.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.CheckBox_ShowWebPage.ForeColor = Color.MediumBlue;
      this.CheckBox_ShowWebPage.Location = new Point(467, 96);
      this.CheckBox_ShowWebPage.Name = "CheckBox_ShowWebPage";
      this.CheckBox_ShowWebPage.Size = new Size(95, 24);
      this.CheckBox_ShowWebPage.TabIndex = 214;
      this.CheckBox_ShowWebPage.Text = "Pág. Web";
      this.CheckBox_ShowWebPage.UseVisualStyleBackColor = false;
      this.CheckBox_ShowPhone.AutoSize = true;
      this.CheckBox_ShowPhone.BackColor = Color.Transparent;
      this.CheckBox_ShowPhone.Checked = true;
      this.CheckBox_ShowPhone.CheckState = CheckState.Checked;
      this.CheckBox_ShowPhone.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.CheckBox_ShowPhone.ForeColor = Color.MediumBlue;
      this.CheckBox_ShowPhone.Location = new Point(467, 78);
      this.CheckBox_ShowPhone.Name = "CheckBox_ShowPhone";
      this.CheckBox_ShowPhone.Size = new Size(90, 24);
      this.CheckBox_ShowPhone.TabIndex = 213;
      this.CheckBox_ShowPhone.Text = "Teléfono";
      this.CheckBox_ShowPhone.UseVisualStyleBackColor = false;
      this.CheckBox_ShowAddress.AutoSize = true;
      this.CheckBox_ShowAddress.BackColor = Color.Transparent;
      this.CheckBox_ShowAddress.CheckAlign = ContentAlignment.MiddleRight;
      this.CheckBox_ShowAddress.Checked = true;
      this.CheckBox_ShowAddress.CheckState = CheckState.Checked;
      this.CheckBox_ShowAddress.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.CheckBox_ShowAddress.ForeColor = Color.MediumBlue;
      this.CheckBox_ShowAddress.Location = new Point(42, 62);
      this.CheckBox_ShowAddress.Name = "CheckBox_ShowAddress";
      this.CheckBox_ShowAddress.Size = new Size(94, 24);
      this.CheckBox_ShowAddress.TabIndex = 212;
      this.CheckBox_ShowAddress.Text = "Dirección";
      this.CheckBox_ShowAddress.UseVisualStyleBackColor = false;
      this.CheckBox_ShowId.AutoSize = true;
      this.CheckBox_ShowId.BackColor = Color.Transparent;
      this.CheckBox_ShowId.CheckAlign = ContentAlignment.MiddleRight;
      this.CheckBox_ShowId.Checked = true;
      this.CheckBox_ShowId.CheckState = CheckState.Checked;
      this.CheckBox_ShowId.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.CheckBox_ShowId.ForeColor = Color.MediumBlue;
      this.CheckBox_ShowId.Location = new Point(62, 122);
      this.CheckBox_ShowId.Name = "CheckBox_ShowId";
      this.CheckBox_ShowId.Size = new Size(74, 24);
      this.CheckBox_ShowId.TabIndex = 211;
      this.CheckBox_ShowId.Text = "R.U.C.";
      this.CheckBox_ShowId.UseVisualStyleBackColor = false;
      this.CheckBox_ShowSComertial.AutoSize = true;
      this.CheckBox_ShowSComertial.BackColor = Color.Transparent;
      this.CheckBox_ShowSComertial.Checked = true;
      this.CheckBox_ShowSComertial.CheckState = CheckState.Checked;
      this.CheckBox_ShowSComertial.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.CheckBox_ShowSComertial.ForeColor = Color.MediumBlue;
      this.CheckBox_ShowSComertial.Location = new Point(467, 48);
      this.CheckBox_ShowSComertial.Name = "CheckBox_ShowSComertial";
      this.CheckBox_ShowSComertial.Size = new Size(144, 24);
      this.CheckBox_ShowSComertial.TabIndex = 210;
      this.CheckBox_ShowSComertial.Text = "Razón Comercial";
      this.CheckBox_ShowSComertial.UseVisualStyleBackColor = false;
      this.CheckBox_ShowSReason.AutoSize = true;
      this.CheckBox_ShowSReason.BackColor = Color.Transparent;
      this.CheckBox_ShowSReason.CheckAlign = ContentAlignment.MiddleRight;
      this.CheckBox_ShowSReason.Checked = true;
      this.CheckBox_ShowSReason.CheckState = CheckState.Checked;
      this.CheckBox_ShowSReason.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.CheckBox_ShowSReason.ForeColor = Color.MediumBlue;
      this.CheckBox_ShowSReason.Location = new Point(21, 31);
      this.CheckBox_ShowSReason.Name = "CheckBox_ShowSReason";
      this.CheckBox_ShowSReason.Size = new Size(115, 24);
      this.CheckBox_ShowSReason.TabIndex = 209;
      this.CheckBox_ShowSReason.Text = "Razón Social";
      this.CheckBox_ShowSReason.UseVisualStyleBackColor = false;
      this.RichTextBox_PreBill.BackColor = SystemColors.Window;
      this.RichTextBox_PreBill.BorderStyle = BorderStyle.None;
      this.RichTextBox_PreBill.DetectUrls = false;
      this.RichTextBox_PreBill.Font = new Font("Lucida Console", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.RichTextBox_PreBill.Location = new Point(142, 6);
      this.RichTextBox_PreBill.Name = "RichTextBox_PreBill";
      this.RichTextBox_PreBill.ReadOnly = true;
      this.RichTextBox_PreBill.Size = new Size(384, 615);
      this.RichTextBox_PreBill.TabIndex = 0;
      this.RichTextBox_PreBill.Text = componentResourceManager.GetString("RichTextBox_PreBill.Text");
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(617, 692);
      this.Controls.Add((Control) this.HeaderPanel_Configuracion);
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (FrmCfgDocument);
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Configurar Impresión de Documento";
      ((Control) this.HeaderPanel_Configuracion).ResumeLayout(false);
      ((Control) this.HeaderPanel_Configuracion).PerformLayout();
      this.ResumeLayout(false);
    }

    internal virtual HeaderPanel HeaderPanel_Configuracion { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

    internal virtual CheckBox CheckBox_ShowTypeChange { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBox_ShowTable { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBox_ShowBoxUser { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBox_ShowMessage
    {
      get
      {
        return this._CheckBox_ShowMessage;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBox_ShowMessage_CheckedChanged);
        CheckBox checkBoxShowMessage1 = this._CheckBox_ShowMessage;
        if (checkBoxShowMessage1 != null)
          checkBoxShowMessage1.CheckedChanged -= eventHandler;
        this._CheckBox_ShowMessage = value;
        CheckBox checkBoxShowMessage2 = this._CheckBox_ShowMessage;
        if (checkBoxShowMessage2 == null)
          return;
        checkBoxShowMessage2.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox CheckBox_ShowClientId { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBox_ShowClientSReason { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBox_ShowNumLetters { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBox_ShowWebPage { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBox_ShowPhone { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBox_ShowAddress { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBox_ShowId { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBox_ShowSComertial { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBox_ShowSReason { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual RichTextBox RichTextBox_PreBill { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBox_ShowBox { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBox_ShowOrderNum { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBox_ShowSerieNum { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBox_ShowAutorizaNum { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBox_ShowPersonNum { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBox_Message { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox chbVerClienteDireccion { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private void FrmCfgDocument_Load(object sender, EventArgs e)
    {
      this.LoadData();
    }

    private void Button_GoOut_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void Button_Save_Click(object sender, EventArgs e)
    {
      if (!ModGeneralFunctions.MessageMakeAction("¿Desea Guardar los Cambios?", false))
        return;
      this.obeVARDOCUMENT.set_EstabliId(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId());
      this.obeVARDOCUMENT.set_BoxId(ModGeneralVar.g_BE_TR1_CFGVARIABLES.get_BoxId());
      this.obeVARDOCUMENT.set_ShowId(this.CheckBox_ShowId.Checked);
      this.obeVARDOCUMENT.set_ShowSReason(this.CheckBox_ShowSReason.Checked);
      this.obeVARDOCUMENT.set_ShowSComertial(this.CheckBox_ShowSComertial.Checked);
      this.obeVARDOCUMENT.set_ShowAddress(this.CheckBox_ShowAddress.Checked);
      this.obeVARDOCUMENT.set_ShowPhone(this.CheckBox_ShowPhone.Checked);
      this.obeVARDOCUMENT.set_ShowWebPage(this.CheckBox_ShowWebPage.Checked);
      this.obeVARDOCUMENT.set_ShowOrderNum(this.CheckBox_ShowOrderNum.Checked);
      this.obeVARDOCUMENT.set_ShowBox(this.CheckBox_ShowBox.Checked);
      this.obeVARDOCUMENT.set_ShowBoxUser(this.CheckBox_ShowBoxUser.Checked);
      this.obeVARDOCUMENT.set_ShowTable(this.CheckBox_ShowTable.Checked);
      this.obeVARDOCUMENT.set_ShowTypeChange(this.CheckBox_ShowTypeChange.Checked);
      this.obeVARDOCUMENT.set_ShowSerieNum(this.CheckBox_ShowSerieNum.Checked);
      this.obeVARDOCUMENT.set_ShowAutorizaNum(this.CheckBox_ShowAutorizaNum.Checked);
      this.obeVARDOCUMENT.set_ShowNumLetters(this.CheckBox_ShowNumLetters.Checked);
      this.obeVARDOCUMENT.set_ShowClientId(this.CheckBox_ShowClientId.Checked);
      this.obeVARDOCUMENT.set_ShowClientSReason(this.CheckBox_ShowClientSReason.Checked);
      this.obeVARDOCUMENT.set_ShowMessage(this.CheckBox_ShowMessage.Checked);
      this.obeVARDOCUMENT.set_Message(this.TextBox_Message.Text);
      this.obeVARDOCUMENT.set_ShowPersonNum(this.CheckBox_ShowPersonNum.Checked);
      this.obeVARDOCUMENT.set_VerClienteDireccion(Conversions.ToString(this.chbVerClienteDireccion.Checked));
      string p_Mensaje = this.oblCONFIGURATION.Edit_CfgDocument(this.obeVARDOCUMENT);
      if (!p_Mensaje.Equals(StructApp.RESULT_OK))
      {
        ModGeneralFunctions.MessageOk(p_Mensaje);
      }
      else
      {
        if (!this._IsAdvanced)
          ModGeneralVar.g_BE_TR1_VARDOCUMENT = this.obeVARDOCUMENT;
        ModGeneralFunctions.MessageOk("¡Registro guardado!");
        this.Close();
      }
    }

    private void LoadData()
    {
      this.oblCONFIGURATION = new BL_TR1_CONFIGURATION();
      if (this._IsAdvanced)
      {
        this.obeVARDOCUMENT = new BE_TR1_VARDOCUMENT();
        this.obeVARDOCUMENT.set_EstabliId(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId());
        this.obeVARDOCUMENT.set_BoxId(this._BoxId);
        this.obeVARDOCUMENT = this.oblCONFIGURATION.Get_CfgDocument(this.obeVARDOCUMENT);
      }
      else
        this.obeVARDOCUMENT = ModGeneralVar.g_BE_TR1_VARDOCUMENT;
      this.CheckBox_ShowId.Checked = this.obeVARDOCUMENT.get_ShowId();
      this.CheckBox_ShowSReason.Checked = this.obeVARDOCUMENT.get_ShowSReason();
      this.CheckBox_ShowSComertial.Checked = this.obeVARDOCUMENT.get_ShowSComertial();
      this.CheckBox_ShowAddress.Checked = this.obeVARDOCUMENT.get_ShowAddress();
      this.CheckBox_ShowPhone.Checked = this.obeVARDOCUMENT.get_ShowPhone();
      this.CheckBox_ShowWebPage.Checked = this.obeVARDOCUMENT.get_ShowWebPage();
      this.CheckBox_ShowOrderNum.Checked = this.obeVARDOCUMENT.get_ShowOrderNum();
      this.CheckBox_ShowBox.Checked = this.obeVARDOCUMENT.get_ShowBox();
      this.CheckBox_ShowBoxUser.Checked = this.obeVARDOCUMENT.get_ShowBoxUser();
      this.CheckBox_ShowTable.Checked = this.obeVARDOCUMENT.get_ShowTable();
      this.CheckBox_ShowTypeChange.Checked = this.obeVARDOCUMENT.get_ShowTypeChange();
      this.CheckBox_ShowSerieNum.Checked = this.obeVARDOCUMENT.get_ShowSerieNum();
      this.CheckBox_ShowAutorizaNum.Checked = this.obeVARDOCUMENT.get_ShowAutorizaNum();
      this.CheckBox_ShowNumLetters.Checked = this.obeVARDOCUMENT.get_ShowNumLetters();
      this.CheckBox_ShowClientId.Checked = this.obeVARDOCUMENT.get_ShowClientId();
      this.CheckBox_ShowClientSReason.Checked = this.obeVARDOCUMENT.get_ShowClientSReason();
      this.CheckBox_ShowMessage.Checked = this.obeVARDOCUMENT.get_ShowMessage();
      this.TextBox_Message.Text = this.obeVARDOCUMENT.get_Message();
      this.CheckBox_ShowPersonNum.Checked = this.obeVARDOCUMENT.get_ShowPersonNum();
      this.chbVerClienteDireccion.Checked = Conversions.ToBoolean(this.obeVARDOCUMENT.get_VerClienteDireccion());
    }

    private void CheckBox_ShowMessage_CheckedChanged(object sender, EventArgs e)
    {
      this.TextBox_Message.Enabled = this.CheckBox_ShowMessage.Checked;
    }

    private void FrmCfgDocument_KeyDown(object sender, KeyEventArgs e)
    {
      if (!e.KeyValue.Equals(27))
        return;
      this.Close();
    }
  }
}
