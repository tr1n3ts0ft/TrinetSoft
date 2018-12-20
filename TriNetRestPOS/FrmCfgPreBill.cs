// Decompiled with JetBrains decompiler
// Type: TriNetRestPOS.FrmCfgPreBill
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
  public class FrmCfgPreBill : Form
  {
    private IContainer components;
    private BE_TR1_VARPREBILL obeVARPREBILL;
    private BL_TR1_CONFIGURATION oblCONFIGURATION;
    public bool _IsAdvanced;
    public int _BoxId;

    public FrmCfgPreBill()
    {
      this.Load += new EventHandler(this.FrmCfgPreBill_Load);
      this.KeyDown += new KeyEventHandler(this.FrmCfgPreBill_KeyDown);
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FrmCfgPreBill));
      this.HeaderPanel_Configuracion = new HeaderPanel();
      this.CheckBox_ShowPersonNum = new CheckBox();
      this.Button_GoOut = new Button();
      this.Button_Save = new Button();
      this.CheckBox_ShowTypeChange = new CheckBox();
      this.CheckBox_ShowTable = new CheckBox();
      this.CheckBox_ShowWaiter = new CheckBox();
      this.CheckBox_ShowTip = new CheckBox();
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
      ((Control) this.HeaderPanel_Configuracion).Controls.Add((Control) this.CheckBox_ShowPersonNum);
      ((Control) this.HeaderPanel_Configuracion).Controls.Add((Control) this.Button_GoOut);
      ((Control) this.HeaderPanel_Configuracion).Controls.Add((Control) this.Button_Save);
      ((Control) this.HeaderPanel_Configuracion).Controls.Add((Control) this.CheckBox_ShowTypeChange);
      ((Control) this.HeaderPanel_Configuracion).Controls.Add((Control) this.CheckBox_ShowTable);
      ((Control) this.HeaderPanel_Configuracion).Controls.Add((Control) this.CheckBox_ShowWaiter);
      ((Control) this.HeaderPanel_Configuracion).Controls.Add((Control) this.CheckBox_ShowTip);
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
      ((Control) this.HeaderPanel_Configuracion).Location = new Point(-1, 0);
      ((Control) this.HeaderPanel_Configuracion).Name = "HeaderPanel_Configuracion";
      this.HeaderPanel_Configuracion.set_PanelIcon((Icon) null);
      this.HeaderPanel_Configuracion.set_PanelIconVisible(false);
      ((Control) this.HeaderPanel_Configuracion).Size = new Size(677, 671);
      ((Control) this.HeaderPanel_Configuracion).TabIndex = 208;
      this.HeaderPanel_Configuracion.set_TextAntialias(true);
      this.CheckBox_ShowPersonNum.AutoSize = true;
      this.CheckBox_ShowPersonNum.BackColor = Color.Transparent;
      this.CheckBox_ShowPersonNum.Checked = true;
      this.CheckBox_ShowPersonNum.CheckState = CheckState.Checked;
      this.CheckBox_ShowPersonNum.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.CheckBox_ShowPersonNum.ForeColor = Color.MediumBlue;
      this.CheckBox_ShowPersonNum.Location = new Point(529, 239);
      this.CheckBox_ShowPersonNum.Name = "CheckBox_ShowPersonNum";
      this.CheckBox_ShowPersonNum.Size = new Size(110, 24);
      this.CheckBox_ShowPersonNum.TabIndex = 229;
      this.CheckBox_ShowPersonNum.Text = "Nº Personas";
      this.CheckBox_ShowPersonNum.UseVisualStyleBackColor = false;
      this.Button_GoOut.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_GoOut.ForeColor = Color.MediumBlue;
      this.Button_GoOut.Image = (Image) TriNetRestPOS.My.Resources.Resources.i_Close;
      this.Button_GoOut.Location = new Point(564, 573);
      this.Button_GoOut.Name = "Button_GoOut";
      this.Button_GoOut.Size = new Size(106, 64);
      this.Button_GoOut.TabIndex = 223;
      this.Button_GoOut.Text = "&Salir";
      this.Button_GoOut.TextImageRelation = TextImageRelation.TextAboveImage;
      this.Button_GoOut.UseVisualStyleBackColor = true;
      this.Button_Save.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_Save.ForeColor = Color.MediumBlue;
      this.Button_Save.Image = (Image) TriNetRestPOS.My.Resources.Resources.i_Ready;
      this.Button_Save.Location = new Point(422, 574);
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
      this.CheckBox_ShowTypeChange.Location = new Point(-1, 229);
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
      this.CheckBox_ShowTable.Location = new Point(73, 211);
      this.CheckBox_ShowTable.Name = "CheckBox_ShowTable";
      this.CheckBox_ShowTable.Size = new Size(63, 24);
      this.CheckBox_ShowTable.TabIndex = 221;
      this.CheckBox_ShowTable.Text = "Mesa";
      this.CheckBox_ShowTable.UseVisualStyleBackColor = false;
      this.CheckBox_ShowWaiter.AutoSize = true;
      this.CheckBox_ShowWaiter.BackColor = Color.Transparent;
      this.CheckBox_ShowWaiter.CheckAlign = ContentAlignment.MiddleRight;
      this.CheckBox_ShowWaiter.Checked = true;
      this.CheckBox_ShowWaiter.CheckState = CheckState.Checked;
      this.CheckBox_ShowWaiter.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.CheckBox_ShowWaiter.ForeColor = Color.MediumBlue;
      this.CheckBox_ShowWaiter.Location = new Point(72, 192);
      this.CheckBox_ShowWaiter.Name = "CheckBox_ShowWaiter";
      this.CheckBox_ShowWaiter.Size = new Size(64, 24);
      this.CheckBox_ShowWaiter.TabIndex = 220;
      this.CheckBox_ShowWaiter.Text = "Mozo";
      this.CheckBox_ShowWaiter.UseVisualStyleBackColor = false;
      this.CheckBox_ShowTip.AutoSize = true;
      this.CheckBox_ShowTip.BackColor = Color.Transparent;
      this.CheckBox_ShowTip.CheckAlign = ContentAlignment.MiddleRight;
      this.CheckBox_ShowTip.Checked = true;
      this.CheckBox_ShowTip.CheckState = CheckState.Checked;
      this.CheckBox_ShowTip.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.CheckBox_ShowTip.ForeColor = Color.MediumBlue;
      this.CheckBox_ShowTip.Location = new Point(55, 495);
      this.CheckBox_ShowTip.Name = "CheckBox_ShowTip";
      this.CheckBox_ShowTip.Size = new Size(81, 24);
      this.CheckBox_ShowTip.TabIndex = 218;
      this.CheckBox_ShowTip.Text = "Propina";
      this.CheckBox_ShowTip.UseVisualStyleBackColor = false;
      this.CheckBox_ShowClientId.AutoSize = true;
      this.CheckBox_ShowClientId.BackColor = Color.Transparent;
      this.CheckBox_ShowClientId.CheckAlign = ContentAlignment.MiddleRight;
      this.CheckBox_ShowClientId.Checked = true;
      this.CheckBox_ShowClientId.CheckState = CheckState.Checked;
      this.CheckBox_ShowClientId.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.CheckBox_ShowClientId.ForeColor = Color.MediumBlue;
      this.CheckBox_ShowClientId.Location = new Point(7, 465);
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
      this.CheckBox_ShowClientSReason.Location = new Point(3, 435);
      this.CheckBox_ShowClientSReason.Name = "CheckBox_ShowClientSReason";
      this.CheckBox_ShowClientSReason.Size = new Size(133, 24);
      this.CheckBox_ShowClientSReason.TabIndex = 216;
      this.CheckBox_ShowClientSReason.Text = "R. Soc. Cliente";
      this.CheckBox_ShowClientSReason.UseVisualStyleBackColor = false;
      this.CheckBox_ShowNumLetters.AutoSize = true;
      this.CheckBox_ShowNumLetters.BackColor = Color.Transparent;
      this.CheckBox_ShowNumLetters.Checked = true;
      this.CheckBox_ShowNumLetters.CheckState = CheckState.Checked;
      this.CheckBox_ShowNumLetters.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.CheckBox_ShowNumLetters.ForeColor = Color.MediumBlue;
      this.CheckBox_ShowNumLetters.Location = new Point(529, 365);
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
      this.CheckBox_ShowWebPage.Location = new Point(529, 115);
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
      this.CheckBox_ShowPhone.Location = new Point(529, 97);
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
      this.CheckBox_ShowAddress.Location = new Point(42, 84);
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
      this.CheckBox_ShowId.Location = new Point(62, 66);
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
      this.CheckBox_ShowSComertial.Location = new Point(529, 54);
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
      this.CheckBox_ShowSReason.Location = new Point(21, 36);
      this.CheckBox_ShowSReason.Name = "CheckBox_ShowSReason";
      this.CheckBox_ShowSReason.Size = new Size(115, 24);
      this.CheckBox_ShowSReason.TabIndex = 209;
      this.CheckBox_ShowSReason.Text = "Razón Social";
      this.CheckBox_ShowSReason.UseVisualStyleBackColor = false;
      this.RichTextBox_PreBill.BackColor = SystemColors.Window;
      this.RichTextBox_PreBill.BorderStyle = BorderStyle.None;
      this.RichTextBox_PreBill.DetectUrls = false;
      this.RichTextBox_PreBill.Font = new Font("Lucida Console", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.RichTextBox_PreBill.Location = new Point(142, 3);
      this.RichTextBox_PreBill.Name = "RichTextBox_PreBill";
      this.RichTextBox_PreBill.ReadOnly = true;
      this.RichTextBox_PreBill.Size = new Size(384, 584);
      this.RichTextBox_PreBill.TabIndex = 0;
      this.RichTextBox_PreBill.Text = componentResourceManager.GetString("RichTextBox_PreBill.Text");
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(676, 670);
      this.Controls.Add((Control) this.HeaderPanel_Configuracion);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (FrmCfgPreBill);
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Configurar Impresión de Precuenta";
      ((Control) this.HeaderPanel_Configuracion).ResumeLayout(false);
      ((Control) this.HeaderPanel_Configuracion).PerformLayout();
      this.ResumeLayout(false);
    }

    internal virtual HeaderPanel HeaderPanel_Configuracion { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual RichTextBox RichTextBox_PreBill { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBox_ShowWebPage { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBox_ShowPhone { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBox_ShowAddress { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBox_ShowId { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBox_ShowSComertial { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBox_ShowSReason { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBox_ShowTip { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBox_ShowClientId { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBox_ShowClientSReason { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBox_ShowNumLetters { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBox_ShowTypeChange { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBox_ShowTable { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CheckBox_ShowWaiter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

    internal virtual CheckBox CheckBox_ShowPersonNum { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private void FrmCfgPreBill_Load(object sender, EventArgs e)
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
      this.obeVARPREBILL.set_EstabliId(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId());
      this.obeVARPREBILL.set_BoxId(ModGeneralVar.g_BE_TR1_CFGVARIABLES.get_BoxId());
      this.obeVARPREBILL.set_ShowId(this.CheckBox_ShowId.Checked);
      this.obeVARPREBILL.set_ShowSReason(this.CheckBox_ShowSReason.Checked);
      this.obeVARPREBILL.set_ShowSComertial(this.CheckBox_ShowSComertial.Checked);
      this.obeVARPREBILL.set_ShowAddress(this.CheckBox_ShowAddress.Checked);
      this.obeVARPREBILL.set_ShowPhone(this.CheckBox_ShowPhone.Checked);
      this.obeVARPREBILL.set_ShowWebPage(this.CheckBox_ShowWebPage.Checked);
      this.obeVARPREBILL.set_ShowWaiter(this.CheckBox_ShowWaiter.Checked);
      this.obeVARPREBILL.set_ShowTable(this.CheckBox_ShowTable.Checked);
      this.obeVARPREBILL.set_ShowTypeChange(this.CheckBox_ShowTypeChange.Checked);
      this.obeVARPREBILL.set_ShowNumLetters(this.CheckBox_ShowNumLetters.Checked);
      this.obeVARPREBILL.set_ShowClientId(this.CheckBox_ShowClientId.Checked);
      this.obeVARPREBILL.set_ShowClientSReason(this.CheckBox_ShowClientSReason.Checked);
      this.obeVARPREBILL.set_ShowTip(this.CheckBox_ShowTip.Checked);
      this.obeVARPREBILL.set_ShowPersonNum(this.CheckBox_ShowPersonNum.Checked);
      string p_Mensaje = this.oblCONFIGURATION.Edit_CfgPreBill(this.obeVARPREBILL);
      if (!p_Mensaje.Equals(StructApp.RESULT_OK))
      {
        ModGeneralFunctions.MessageOk(p_Mensaje);
      }
      else
      {
        if (!this._IsAdvanced)
          ModGeneralVar.g_BE_TR1_VARPREBILL = this.obeVARPREBILL;
        ModGeneralFunctions.MessageOk("¡Registro guardado!");
        this.Close();
      }
    }

    private void LoadData()
    {
      this.oblCONFIGURATION = new BL_TR1_CONFIGURATION();
      if (this._IsAdvanced)
      {
        this.obeVARPREBILL = new BE_TR1_VARPREBILL();
        this.obeVARPREBILL.set_EstabliId(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId());
        this.obeVARPREBILL.set_BoxId(this._BoxId);
        this.obeVARPREBILL = this.oblCONFIGURATION.Get_CfgPreBill(this.obeVARPREBILL);
      }
      else
        this.obeVARPREBILL = ModGeneralVar.g_BE_TR1_VARPREBILL;
      this.CheckBox_ShowId.Checked = this.obeVARPREBILL.get_ShowId();
      this.CheckBox_ShowSReason.Checked = this.obeVARPREBILL.get_ShowSReason();
      this.CheckBox_ShowSComertial.Checked = this.obeVARPREBILL.get_ShowSComertial();
      this.CheckBox_ShowAddress.Checked = this.obeVARPREBILL.get_ShowAddress();
      this.CheckBox_ShowPhone.Checked = this.obeVARPREBILL.get_ShowPhone();
      this.CheckBox_ShowWebPage.Checked = this.obeVARPREBILL.get_ShowWebPage();
      this.CheckBox_ShowWaiter.Checked = this.obeVARPREBILL.get_ShowWaiter();
      this.CheckBox_ShowTable.Checked = this.obeVARPREBILL.get_ShowTable();
      this.CheckBox_ShowTypeChange.Checked = this.obeVARPREBILL.get_ShowTypeChange();
      this.CheckBox_ShowNumLetters.Checked = this.obeVARPREBILL.get_ShowNumLetters();
      this.CheckBox_ShowClientId.Checked = this.obeVARPREBILL.get_ShowClientId();
      this.CheckBox_ShowClientSReason.Checked = this.obeVARPREBILL.get_ShowClientSReason();
      this.CheckBox_ShowTip.Checked = this.obeVARPREBILL.get_ShowTip();
      this.CheckBox_ShowPersonNum.Checked = this.obeVARPREBILL.get_ShowPersonNum();
    }

    private void FrmCfgPreBill_KeyDown(object sender, KeyEventArgs e)
    {
      if (!e.KeyValue.Equals(27))
        return;
      this.Close();
    }
  }
}
