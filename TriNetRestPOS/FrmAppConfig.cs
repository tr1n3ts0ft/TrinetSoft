// Decompiled with JetBrains decompiler
// Type: TriNetRestPOS.FrmAppConfig
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

namespace TriNetRestPOS
{
  [DesignerGenerated]
  public class FrmAppConfig : Form
  {
    private IContainer components;

    public FrmAppConfig()
    {
      this.Load += new EventHandler(this.FrmAppConfig_Load);
      this.KeyDown += new KeyEventHandler(this.FrmAppConfig_KeyDown);
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FrmAppConfig));
      this.Label9 = new Label();
      this.Label11 = new Label();
      this.txtMAILCIERRE_DETALLE = new TextBox();
      this.Label4 = new Label();
      this.Label2 = new Label();
      this.btnGuardar = new Button();
      this.btnSalir = new Button();
      this.txtMAILCIERRE_RESUMEN = new TextBox();
      this.txtWS_CONTRATO_NUM = new TextBox();
      this.Label1 = new Label();
      this.Label3 = new Label();
      this.SuspendLayout();
      this.Label9.AutoSize = true;
      this.Label9.ForeColor = Color.MediumBlue;
      this.Label9.Location = new Point(130, 75);
      this.Label9.Name = "Label9";
      this.Label9.Size = new Size(15, 20);
      this.Label9.TabIndex = 431;
      this.Label9.Text = ":";
      this.Label11.AutoSize = true;
      this.Label11.ForeColor = Color.MediumBlue;
      this.Label11.Location = new Point(130, 14);
      this.Label11.Name = "Label11";
      this.Label11.Size = new Size(15, 20);
      this.Label11.TabIndex = 429;
      this.Label11.Text = ":";
      this.txtMAILCIERRE_DETALLE.Location = new Point(152, 72);
      this.txtMAILCIERRE_DETALLE.MaxLength = 100;
      this.txtMAILCIERRE_DETALLE.Multiline = true;
      this.txtMAILCIERRE_DETALLE.Name = "txtMAILCIERRE_DETALLE";
      this.txtMAILCIERRE_DETALLE.Size = new Size(579, 50);
      this.txtMAILCIERRE_DETALLE.TabIndex = 1;
      this.Label4.AutoSize = true;
      this.Label4.ForeColor = Color.MediumBlue;
      this.Label4.Location = new Point(9, 75);
      this.Label4.Name = "Label4";
      this.Label4.Size = new Size(110, 20);
      this.Label4.TabIndex = 3;
      this.Label4.Text = "Correo Detalle";
      this.Label2.AutoSize = true;
      this.Label2.ForeColor = Color.MediumBlue;
      this.Label2.Location = new Point(9, 14);
      this.Label2.Name = "Label2";
      this.Label2.Size = new Size(124, 20);
      this.Label2.TabIndex = 1;
      this.Label2.Text = "Correo Resúmen";
      this.btnGuardar.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnGuardar.ForeColor = Color.MediumBlue;
      this.btnGuardar.Image = (Image) TriNetRestPOS.My.Resources.Resources.i_Ready;
      this.btnGuardar.Location = new Point(545, 168);
      this.btnGuardar.Name = "btnGuardar";
      this.btnGuardar.Size = new Size(100, 60);
      this.btnGuardar.TabIndex = 2;
      this.btnGuardar.Text = "&Guardar";
      this.btnGuardar.TextImageRelation = TextImageRelation.TextAboveImage;
      this.btnGuardar.UseVisualStyleBackColor = true;
      this.btnSalir.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnSalir.ForeColor = Color.MediumBlue;
      this.btnSalir.Image = (Image) TriNetRestPOS.My.Resources.Resources.i_Close;
      this.btnSalir.Location = new Point(649, 168);
      this.btnSalir.Name = "btnSalir";
      this.btnSalir.Size = new Size(83, 60);
      this.btnSalir.TabIndex = 3;
      this.btnSalir.Text = "&Salir";
      this.btnSalir.TextImageRelation = TextImageRelation.TextAboveImage;
      this.btnSalir.UseVisualStyleBackColor = true;
      this.txtMAILCIERRE_RESUMEN.Location = new Point(151, 11);
      this.txtMAILCIERRE_RESUMEN.MaxLength = 100;
      this.txtMAILCIERRE_RESUMEN.Multiline = true;
      this.txtMAILCIERRE_RESUMEN.Name = "txtMAILCIERRE_RESUMEN";
      this.txtMAILCIERRE_RESUMEN.Size = new Size(580, 50);
      this.txtMAILCIERRE_RESUMEN.TabIndex = 0;
      this.txtWS_CONTRATO_NUM.Location = new Point(151, 133);
      this.txtWS_CONTRATO_NUM.MaxLength = 100;
      this.txtWS_CONTRATO_NUM.Name = "txtWS_CONTRATO_NUM";
      this.txtWS_CONTRATO_NUM.Size = new Size(579, 25);
      this.txtWS_CONTRATO_NUM.TabIndex = 432;
      this.Label1.AutoSize = true;
      this.Label1.ForeColor = Color.MediumBlue;
      this.Label1.Location = new Point(9, 136);
      this.Label1.Name = "Label1";
      this.Label1.Size = new Size(121, 20);
      this.Label1.TabIndex = 433;
      this.Label1.Text = "Nro de Contrato";
      this.Label3.AutoSize = true;
      this.Label3.ForeColor = Color.MediumBlue;
      this.Label3.Location = new Point(130, 136);
      this.Label3.Name = "Label3";
      this.Label3.Size = new Size(15, 20);
      this.Label3.TabIndex = 434;
      this.Label3.Text = ":";
      this.AutoScaleDimensions = new SizeF(9f, 20f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.Window;
      this.ClientSize = new Size(744, 237);
      this.Controls.Add((Control) this.txtWS_CONTRATO_NUM);
      this.Controls.Add((Control) this.Label1);
      this.Controls.Add((Control) this.Label3);
      this.Controls.Add((Control) this.btnSalir);
      this.Controls.Add((Control) this.btnGuardar);
      this.Controls.Add((Control) this.txtMAILCIERRE_DETALLE);
      this.Controls.Add((Control) this.Label2);
      this.Controls.Add((Control) this.Label4);
      this.Controls.Add((Control) this.Label11);
      this.Controls.Add((Control) this.Label9);
      this.Controls.Add((Control) this.txtMAILCIERRE_RESUMEN);
      this.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.KeyPreview = true;
      this.Margin = new Padding(4, 5, 4, 5);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (FrmAppConfig);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Configuración";
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox txtMAILCIERRE_DETALLE { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

    internal virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox txtMAILCIERRE_RESUMEN { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox txtWS_CONTRATO_NUM { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private void FrmAppConfig_Load(object sender, EventArgs e)
    {
      this.CargarConfig();
    }

    private void FrmAppConfig_KeyDown(object sender, KeyEventArgs e)
    {
      if (!e.KeyValue.Equals(27))
        return;
      this.Close();
    }

    private void CargarConfig()
    {
      this.txtMAILCIERRE_RESUMEN.Text = Conversions.ToString(ModGeneralFunctions.ObtenerAPPCONFIG("MAILCIERRE_RESUMEN"));
      this.txtMAILCIERRE_DETALLE.Text = Conversions.ToString(ModGeneralFunctions.ObtenerAPPCONFIG("MAILCIERRE_DETALLE"));
      this.txtWS_CONTRATO_NUM.Text = Conversions.ToString(ModGeneralFunctions.ObtenerAPPCONFIG("WS_CONTRATO_NUM"));
    }

    private void GuardarConfig()
    {
      try
      {
        ModGeneralFunctions.EditarAPPCONFIG("MAILCIERRE_RESUMEN", this.txtMAILCIERRE_RESUMEN.Text.ToString());
        ModGeneralFunctions.EditarAPPCONFIG("MAILCIERRE_DETALLE", this.txtMAILCIERRE_DETALLE.Text.ToString());
        ModGeneralFunctions.EditarAPPCONFIG("WS_CONTRATO_NUM", this.txtWS_CONTRATO_NUM.Text.ToString());
        ModGeneralFunctions.MessageOk("Configuración Guardada");
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ModGeneralFunctions.MessageOk("Error - " + ex.Message);
        ProjectData.ClearProjectError();
      }
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
      if (!ModGeneralFunctions.MessageMakeAction("¿Seguro de Guardar?", false))
        return;
      this.GuardarConfig();
    }

    private void btnSalir_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
