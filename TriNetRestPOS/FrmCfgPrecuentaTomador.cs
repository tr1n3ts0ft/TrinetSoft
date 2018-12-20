// Decompiled with JetBrains decompiler
// Type: TriNetRestPOS.FrmCfgPrecuentaTomador
// Assembly: TriNetRestPOS, Version=5.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 43377352-E952-4AC1-9BA6-CCBE4AE5F575
// Assembly location: C:\log\TriNetRestPOS.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using TR1_BusinessLogic;

namespace TriNetRestPOS
{
  [DesignerGenerated]
  public class FrmCfgPrecuentaTomador : Form
  {
    private IContainer components;

    public FrmCfgPrecuentaTomador()
    {
      this.Load += new EventHandler(this.FrmCfgPrecuentaTomador_Load);
      this.KeyDown += new KeyEventHandler(this.FrmCfgPrecuentaTomador_KeyDown);
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
      this.Label_SocialReason = new Label();
      this.txtImpresoraNombre = new TextBox();
      this.btnBuscarImpresora = new Button();
      this.btnGuardar = new Button();
      this.txtImpresoraId = new TextBox();
      this.SuspendLayout();
      this.Label_SocialReason.AutoSize = true;
      this.Label_SocialReason.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label_SocialReason.ForeColor = Color.MediumBlue;
      this.Label_SocialReason.Location = new Point(5, 11);
      this.Label_SocialReason.Name = "Label_SocialReason";
      this.Label_SocialReason.Size = new Size(103, 20);
      this.Label_SocialReason.TabIndex = 144;
      this.Label_SocialReason.Text = "Precuentera:";
      this.txtImpresoraNombre.BackColor = Color.FromArgb((int) byte.MaxValue, 240, 144);
      this.txtImpresoraNombre.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtImpresoraNombre.ForeColor = Color.Red;
      this.txtImpresoraNombre.Location = new Point(9, 33);
      this.txtImpresoraNombre.MaxLength = 100;
      this.txtImpresoraNombre.Name = "txtImpresoraNombre";
      this.txtImpresoraNombre.Size = new Size(250, 25);
      this.txtImpresoraNombre.TabIndex = 142;
      this.btnBuscarImpresora.Font = new Font("Trebuchet MS", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnBuscarImpresora.ForeColor = Color.MediumBlue;
      this.btnBuscarImpresora.Image = (Image) TriNetRestPOS.My.Resources.Resources.print_printer_s;
      this.btnBuscarImpresora.Location = new Point(268, 2);
      this.btnBuscarImpresora.Name = "btnBuscarImpresora";
      this.btnBuscarImpresora.Size = new Size(70, 56);
      this.btnBuscarImpresora.TabIndex = 143;
      this.btnBuscarImpresora.TextImageRelation = TextImageRelation.TextAboveImage;
      this.btnBuscarImpresora.UseVisualStyleBackColor = true;
      this.btnGuardar.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnGuardar.ForeColor = Color.MediumBlue;
      this.btnGuardar.Image = (Image) TriNetRestPOS.My.Resources.Resources.i_Ready;
      this.btnGuardar.Location = new Point(101, 64);
      this.btnGuardar.Name = "btnGuardar";
      this.btnGuardar.Size = new Size(140, 70);
      this.btnGuardar.TabIndex = 145;
      this.btnGuardar.Text = "&Grabar";
      this.btnGuardar.TextImageRelation = TextImageRelation.TextAboveImage;
      this.btnGuardar.UseVisualStyleBackColor = true;
      this.txtImpresoraId.BackColor = Color.FromArgb((int) byte.MaxValue, 240, 144);
      this.txtImpresoraId.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtImpresoraId.ForeColor = Color.Red;
      this.txtImpresoraId.Location = new Point(9, 57);
      this.txtImpresoraId.MaxLength = 100;
      this.txtImpresoraId.Name = "txtImpresoraId";
      this.txtImpresoraId.Size = new Size(24, 25);
      this.txtImpresoraId.TabIndex = 146;
      this.txtImpresoraId.Visible = false;
      this.AutoScaleDimensions = new SizeF(9f, 20f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.Window;
      this.ClientSize = new Size(344, 138);
      this.Controls.Add((Control) this.txtImpresoraId);
      this.Controls.Add((Control) this.btnGuardar);
      this.Controls.Add((Control) this.Label_SocialReason);
      this.Controls.Add((Control) this.txtImpresoraNombre);
      this.Controls.Add((Control) this.btnBuscarImpresora);
      this.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.KeyPreview = true;
      this.Margin = new Padding(4, 5, 4, 5);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (FrmCfgPrecuentaTomador);
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Configurar Impresión de Precuentas";
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    internal virtual Label Label_SocialReason { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox txtImpresoraNombre { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button btnBuscarImpresora
    {
      get
      {
        return this._btnBuscarImpresora;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnBuscarImpresora_Click);
        Button btnBuscarImpresora1 = this._btnBuscarImpresora;
        if (btnBuscarImpresora1 != null)
          btnBuscarImpresora1.Click -= eventHandler;
        this._btnBuscarImpresora = value;
        Button btnBuscarImpresora2 = this._btnBuscarImpresora;
        if (btnBuscarImpresora2 == null)
          return;
        btnBuscarImpresora2.Click += eventHandler;
      }
    }

    internal virtual Button btnGuardar
    {
      get
      {
        return this._btnGuardar;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnGuardar_Click);
        Button btnGuardar1 = this._btnGuardar;
        if (btnGuardar1 != null)
          btnGuardar1.Click -= eventHandler;
        this._btnGuardar = value;
        Button btnGuardar2 = this._btnGuardar;
        if (btnGuardar2 == null)
          return;
        btnGuardar2.Click += eventHandler;
      }
    }

    internal virtual TextBox txtImpresoraId { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private void FrmCfgPrecuentaTomador_Load(object sender, EventArgs e)
    {
      this.ObtenerImpPrecuenta();
      this.btnBuscarImpresora.Focus();
    }

    private void FrmCfgPrecuentaTomador_KeyDown(object sender, KeyEventArgs e)
    {
      if (!e.KeyValue.Equals(27))
        return;
      this.Close();
    }

    private void ObtenerImpPrecuenta()
    {
      BL_TR1_PRINTERS blTr1Printers = new BL_TR1_PRINTERS();
      this.txtImpresoraId.Text = Conversions.ToString(ModGeneralVar.g_BE_TR1_CFGVARIABLES.get_PrinterPrecountId());
      this.txtImpresoraNombre.Text = blTr1Printers.ListById(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId(), ModGeneralVar.g_BE_TR1_CFGVARIABLES.get_PrinterPrecountId()).get_PrinterDes();
    }

    private void btnBuscarImpresora_Click(object sender, EventArgs e)
    {
      FrmPrinters frmPrinters = new FrmPrinters();
      frmPrinters._OnlySearch = true;
      frmPrinters._OnlyforDocuments = false;
      int num = (int) frmPrinters.ShowDialog();
      frmPrinters.Dispose();
      if (!ModGeneralVar.g_bol_IsReady)
        return;
      this.txtImpresoraId.Text = ModGeneralVar.g_Str_RecordID;
      this.txtImpresoraNombre.Text = ModGeneralVar.g_Str_RecordDes;
      this.btnGuardar.Focus();
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
      if (ModGeneralFunctions.CadenaToInteger(this.txtImpresoraId.Text) == 0)
      {
        ModGeneralFunctions.MessageOk("¡Seleccione una impresora!");
        this.btnBuscarImpresora.Focus();
      }
      else if (ModGeneralFunctions.MessageMakeAction("¿Desea editar la Configuración?", false))
      {
        BL_TR1_CONFIGURATION tr1Configuration = new BL_TR1_CONFIGURATION();
        string str1 = "";
        string str2 = tr1Configuration.EditarImpPrecuenta(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId(), ModGeneralVar.g_BE_TR1_BOXES.get_BoxId(), ModGeneralFunctions.CadenaToInteger(this.txtImpresoraId.Text));
        if (str2.Equals(StructApp.RESULT_OK))
        {
          ModGeneralVar.g_BE_TR1_CFGVARIABLES.set_PrinterPrecountId(ModGeneralFunctions.CadenaToInteger(this.txtImpresoraId.Text));
          ModGeneralFunctions.MessageOk("¡Configuración editada!");
          this.Close();
        }
        else
          ModGeneralFunctions.MessageError_Large("¡Error al editar - " + str2 + "!", true);
        str1 = (string) null;
      }
    }
  }
}
