// Decompiled with JetBrains decompiler
// Type: TriNetRestPOS.FrmChooseTD
// Assembly: TriNetRestPOS, Version=5.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 43377352-E952-4AC1-9BA6-CCBE4AE5F575
// Assembly location: C:\log\TriNetRestPOS.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace TriNetRestPOS
{
  [DesignerGenerated]
  public sealed class FrmChooseTD : Form
  {
    private IContainer components;
    public string str_TipoDocumento;
    public bool bol_DocumentoInterno;

    public FrmChooseTD()
    {
      this.Load += new EventHandler(this.FrmChooseTD_Load);
      this.KeyDown += new KeyEventHandler(this.FrmChooseTD_KeyDown);
      this.str_TipoDocumento = "";
      this.bol_DocumentoInterno = true;
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
      this.btnClose = new Button();
      this.btnDocumentoInterno = new Button();
      this.Button_Factura = new Button();
      this.Button_Ticket = new Button();
      this.SuspendLayout();
      this.btnClose.BackColor = Color.FromArgb(214, 60, 54);
      this.btnClose.FlatStyle = FlatStyle.Flat;
      this.btnClose.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnClose.ForeColor = Color.WhiteSmoke;
      this.btnClose.Location = new Point(1, 211);
      this.btnClose.Margin = new Padding(0);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new Size(154, 70);
      this.btnClose.TabIndex = 177;
      this.btnClose.Text = "SALIR\r\n";
      this.btnClose.UseVisualStyleBackColor = false;
      this.btnDocumentoInterno.BackColor = Color.FromArgb(93, 93, 93);
      this.btnDocumentoInterno.FlatStyle = FlatStyle.Flat;
      this.btnDocumentoInterno.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnDocumentoInterno.ForeColor = Color.WhiteSmoke;
      this.btnDocumentoInterno.Location = new Point(1, 141);
      this.btnDocumentoInterno.Margin = new Padding(0);
      this.btnDocumentoInterno.Name = "btnDocumentoInterno";
      this.btnDocumentoInterno.Size = new Size(154, 70);
      this.btnDocumentoInterno.TabIndex = 178;
      this.btnDocumentoInterno.Text = "DOCUMENTO INTERNO";
      this.btnDocumentoInterno.UseVisualStyleBackColor = false;
      this.Button_Factura.BackColor = Color.FromArgb(93, 93, 93);
      this.Button_Factura.FlatStyle = FlatStyle.Flat;
      this.Button_Factura.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button_Factura.ForeColor = Color.WhiteSmoke;
      this.Button_Factura.Location = new Point(1, 71);
      this.Button_Factura.Margin = new Padding(0);
      this.Button_Factura.Name = "Button_Factura";
      this.Button_Factura.Size = new Size(154, 70);
      this.Button_Factura.TabIndex = 179;
      this.Button_Factura.Text = "FACTURA";
      this.Button_Factura.UseVisualStyleBackColor = false;
      this.Button_Ticket.BackColor = Color.FromArgb(93, 93, 93);
      this.Button_Ticket.FlatStyle = FlatStyle.Flat;
      this.Button_Ticket.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button_Ticket.ForeColor = Color.WhiteSmoke;
      this.Button_Ticket.Location = new Point(1, 1);
      this.Button_Ticket.Margin = new Padding(0);
      this.Button_Ticket.Name = "Button_Ticket";
      this.Button_Ticket.Size = new Size(154, 70);
      this.Button_Ticket.TabIndex = 180;
      this.Button_Ticket.Text = "BOLETA";
      this.Button_Ticket.UseVisualStyleBackColor = false;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.White;
      this.ClientSize = new Size(157, 281);
      this.ControlBox = false;
      this.Controls.Add((Control) this.Button_Ticket);
      this.Controls.Add((Control) this.Button_Factura);
      this.Controls.Add((Control) this.btnDocumentoInterno);
      this.Controls.Add((Control) this.btnClose);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (FrmChooseTD);
      this.Padding = new Padding(9);
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "DOCUMENTO";
      this.ResumeLayout(false);
    }

    internal virtual Button btnClose
    {
      get
      {
        return this._btnClose;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnClose_Click);
        Button btnClose1 = this._btnClose;
        if (btnClose1 != null)
          btnClose1.Click -= eventHandler;
        this._btnClose = value;
        Button btnClose2 = this._btnClose;
        if (btnClose2 == null)
          return;
        btnClose2.Click += eventHandler;
      }
    }

    internal virtual Button btnDocumentoInterno
    {
      get
      {
        return this._btnDocumentoInterno;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnDocumentoInterno_Click);
        Button documentoInterno1 = this._btnDocumentoInterno;
        if (documentoInterno1 != null)
          documentoInterno1.Click -= eventHandler;
        this._btnDocumentoInterno = value;
        Button documentoInterno2 = this._btnDocumentoInterno;
        if (documentoInterno2 == null)
          return;
        documentoInterno2.Click += eventHandler;
      }
    }

    internal virtual Button Button_Factura
    {
      get
      {
        return this._Button_Factura;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_Factura_Click);
        Button buttonFactura1 = this._Button_Factura;
        if (buttonFactura1 != null)
          buttonFactura1.Click -= eventHandler;
        this._Button_Factura = value;
        Button buttonFactura2 = this._Button_Factura;
        if (buttonFactura2 == null)
          return;
        buttonFactura2.Click += eventHandler;
      }
    }

    internal virtual Button Button_Ticket
    {
      get
      {
        return this._Button_Ticket;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_Ticket_Click);
        Button buttonTicket1 = this._Button_Ticket;
        if (buttonTicket1 != null)
          buttonTicket1.Click -= eventHandler;
        this._Button_Ticket = value;
        Button buttonTicket2 = this._Button_Ticket;
        if (buttonTicket2 == null)
          return;
        buttonTicket2.Click += eventHandler;
      }
    }

    private void Button_Ticket_Click(object sender, EventArgs e)
    {
      this.str_TipoDocumento = !ModGeneralVar.g_BE_TR1_CFGVARIABLES.get_IsPrinterMatricial() ? ModGeneralVar.g_GeneralCode.get_Docu_Ticket() : ModGeneralVar.g_GeneralCode.get_Docu_Boleta();
      ModGeneralVar.g_bol_IsReady = true;
      this.Close();
    }

    private void Button_Factura_Click(object sender, EventArgs e)
    {
      this.str_TipoDocumento = !ModGeneralVar.g_BE_TR1_CFGVARIABLES.get_IsPrinterMatricial() ? ModGeneralVar.g_GeneralCode.get_Docu_Invoice() : ModGeneralVar.g_GeneralCode.get_Docu_Factura();
      ModGeneralVar.g_bol_IsReady = true;
      this.Close();
    }

    private void btnDocumentoInterno_Click(object sender, EventArgs e)
    {
      this.str_TipoDocumento = ModGeneralVar.g_GeneralCode.get_Docu_Intern();
      ModGeneralVar.g_bol_IsReady = true;
      this.Close();
    }

    private void FrmChooseTD_Load(object sender, EventArgs e)
    {
      this.Resource(ModGeneralFunctions.Get_Language((object) this));
      if (ModGeneralVar.g_bol_HideDocumentIntern | !this.bol_DocumentoInterno)
      {
        this.btnDocumentoInterno.Visible = false;
        this.btnClose.Location = new Point((Size) this.btnDocumentoInterno.Location);
        this.Size = new Size(this.Width, checked (this.Height - this.btnDocumentoInterno.Height));
      }
      if (!Conversions.ToBoolean(ModGeneralFunctions.ObtenerAPPCONFIG("ACTIVAR_CONFIGURACION_ECUADOR")))
        return;
      this.Button_Ticket.Enabled = false;
      this.btnDocumentoInterno.Enabled = false;
    }

    private void Resource(ResourceManager Rm)
    {
      this.Button_Factura.Text = Strings.UCase(Rm.GetString("Res_Invoice"));
      this.Button_Ticket.Text = Strings.UCase(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_BoletaTicket());
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
      ModGeneralVar.g_bol_IsReady = false;
      this.Close();
    }

    private void FrmChooseTD_KeyDown(object sender, KeyEventArgs e)
    {
      if (!e.KeyValue.Equals(27))
        return;
      ModGeneralVar.g_bol_IsReady = false;
      this.Close();
    }
  }
}
