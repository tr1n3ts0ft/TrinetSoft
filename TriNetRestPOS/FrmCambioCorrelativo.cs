// Decompiled with JetBrains decompiler
// Type: TriNetRestPOS.FrmCambioCorrelativo
// Assembly: TriNetRestPOS, Version=5.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 43377352-E952-4AC1-9BA6-CCBE4AE5F575
// Assembly location: C:\log\TriNetRestPOS.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
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
  public class FrmCambioCorrelativo : Form
  {
    private IContainer components;
    public int TamañoCorrelativo;
    public double CorrelativoInicial;

    public FrmCambioCorrelativo()
    {
      this.Load += new EventHandler(this.FrmCambioCorrelativo_Load);
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
      this.Button_Aceptar = new Button();
      this.Button_Cancelar = new Button();
      this.TextBox_Document = new TextBox();
      this.Label_Document = new Label();
      this.Label13 = new Label();
      this.Label1 = new Label();
      this.Label2 = new Label();
      this.Label3 = new Label();
      this.SuspendLayout();
      this.Button_Aceptar.BackColor = Color.PapayaWhip;
      this.Button_Aceptar.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_Aceptar.ForeColor = Color.MediumBlue;
      this.Button_Aceptar.Image = (Image) TriNetRestPOS.My.Resources.Resources.imgOkS;
      this.Button_Aceptar.Location = new Point(23, 198);
      this.Button_Aceptar.Margin = new Padding(4, 5, 4, 5);
      this.Button_Aceptar.Name = "Button_Aceptar";
      this.Button_Aceptar.Size = new Size(220, 70);
      this.Button_Aceptar.TabIndex = 8;
      this.Button_Aceptar.Text = "Aceptar";
      this.Button_Aceptar.TextAlign = ContentAlignment.MiddleRight;
      this.Button_Aceptar.TextImageRelation = TextImageRelation.ImageBeforeText;
      this.Button_Aceptar.UseVisualStyleBackColor = false;
      this.Button_Cancelar.BackColor = Color.PapayaWhip;
      this.Button_Cancelar.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_Cancelar.ForeColor = Color.MediumBlue;
      this.Button_Cancelar.Image = (Image) TriNetRestPOS.My.Resources.Resources.imgErrorS;
      this.Button_Cancelar.Location = new Point(251, 198);
      this.Button_Cancelar.Margin = new Padding(4, 5, 4, 5);
      this.Button_Cancelar.Name = "Button_Cancelar";
      this.Button_Cancelar.Size = new Size(237, 70);
      this.Button_Cancelar.TabIndex = 9;
      this.Button_Cancelar.Text = "Cancelar";
      this.Button_Cancelar.TextAlign = ContentAlignment.MiddleRight;
      this.Button_Cancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
      this.Button_Cancelar.UseVisualStyleBackColor = false;
      this.TextBox_Document.Font = new Font("Trebuchet MS", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.TextBox_Document.Location = new Point(251, 104);
      this.TextBox_Document.Margin = new Padding(4, 5, 4, 5);
      this.TextBox_Document.Name = "TextBox_Document";
      this.TextBox_Document.Size = new Size(237, 26);
      this.TextBox_Document.TabIndex = 421;
      this.Label_Document.AutoSize = true;
      this.Label_Document.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label_Document.ForeColor = Color.MediumBlue;
      this.Label_Document.Location = new Point(52, 106);
      this.Label_Document.Margin = new Padding(4, 0, 4, 0);
      this.Label_Document.Name = "Label_Document";
      this.Label_Document.Size = new Size(180, 20);
      this.Label_Document.TabIndex = 420;
      this.Label_Document.Text = "Correlativo de FACTURA";
      this.Label13.AutoSize = true;
      this.Label13.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label13.ForeColor = Color.MediumBlue;
      this.Label13.Location = new Point(228, 106);
      this.Label13.Margin = new Padding(4, 0, 4, 0);
      this.Label13.Name = "Label13";
      this.Label13.Size = new Size(15, 20);
      this.Label13.TabIndex = 422;
      this.Label13.Text = ":";
      this.Label1.AutoSize = true;
      this.Label1.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label1.ForeColor = Color.MediumBlue;
      this.Label1.Location = new Point(80, 131);
      this.Label1.Margin = new Padding(4, 0, 4, 0);
      this.Label1.Name = "Label1";
      this.Label1.Size = new Size(137, 20);
      this.Label1.TabIndex = 423;
      this.Label1.Text = "(Último generado)";
      this.Label2.AutoSize = true;
      this.Label2.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label2.ForeColor = Color.Red;
      this.Label2.Location = new Point(149, 18);
      this.Label2.Margin = new Padding(4, 0, 4, 0);
      this.Label2.Name = "Label2";
      this.Label2.Size = new Size(202, 20);
      this.Label2.TabIndex = 424;
      this.Label2.Text = "CORRELATIVO DE FACTURA";
      this.Label3.AutoSize = true;
      this.Label3.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label3.ForeColor = Color.Red;
      this.Label3.Location = new Point(42, 45);
      this.Label3.Margin = new Padding(4, 0, 4, 0);
      this.Label3.Name = "Label3";
      this.Label3.Size = new Size(425, 20);
      this.Label3.TabIndex = 425;
      this.Label3.Text = "Tener cuidado con el cambio de correlativo de documento";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.White;
      this.ClientSize = new Size(501, 282);
      this.Controls.Add((Control) this.Label3);
      this.Controls.Add((Control) this.Label2);
      this.Controls.Add((Control) this.Label1);
      this.Controls.Add((Control) this.TextBox_Document);
      this.Controls.Add((Control) this.Label_Document);
      this.Controls.Add((Control) this.Label13);
      this.Controls.Add((Control) this.Button_Cancelar);
      this.Controls.Add((Control) this.Button_Aceptar);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (FrmCambioCorrelativo);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Cambio de Correlativo";
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    internal virtual Button Button_Aceptar
    {
      get
      {
        return this._Button_Aceptar;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_Aceptar_Click);
        Button buttonAceptar1 = this._Button_Aceptar;
        if (buttonAceptar1 != null)
          buttonAceptar1.Click -= eventHandler;
        this._Button_Aceptar = value;
        Button buttonAceptar2 = this._Button_Aceptar;
        if (buttonAceptar2 == null)
          return;
        buttonAceptar2.Click += eventHandler;
      }
    }

    internal virtual Button Button_Cancelar
    {
      get
      {
        return this._Button_Cancelar;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_Cancelar_Click);
        Button buttonCancelar1 = this._Button_Cancelar;
        if (buttonCancelar1 != null)
          buttonCancelar1.Click -= eventHandler;
        this._Button_Cancelar = value;
        Button buttonCancelar2 = this._Button_Cancelar;
        if (buttonCancelar2 == null)
          return;
        buttonCancelar2.Click += eventHandler;
      }
    }

    internal virtual TextBox TextBox_Document { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label_Document { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private void FrmCambioCorrelativo_Load(object sender, EventArgs e)
    {
      BE_TR1_DOCUMENTS beTr1Documents = new BE_TR1_DOCUMENTS();
      BL_TR1_ORDERS blTr1Orders = new BL_TR1_ORDERS();
      beTr1Documents.set_EstabliId(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId());
      beTr1Documents.set_BoxId(ModGeneralVar.g_BE_TR1_CFGVARIABLES.get_BoxId());
      beTr1Documents.set_DocumentType(ModGeneralVar.g_GeneralCode.get_Docu_Invoice());
      beTr1Documents.set_ClientId("0000000000");
      beTr1Documents.set_NumeroSerie(ModGeneralFunctions.ObtenerNumeroSerie(beTr1Documents.get_DocumentType(), beTr1Documents.get_ClientId()));
      this.TextBox_Document.Text = blTr1Orders.ObtenerNumeroCorrelativo(beTr1Documents);
      string text = this.TextBox_Document.Text;
      this.TamañoCorrelativo = Strings.Len(text.Substring(checked (text.IndexOf("-") + 1)));
      this.CorrelativoInicial = ModGeneralFunctions.CadenaToDouble(text.Substring(checked (text.IndexOf("-") + 1), this.TamañoCorrelativo));
    }

    private void Button_Cancelar_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void Button_Aceptar_Click(object sender, EventArgs e)
    {
      string text = this.TextBox_Document.Text;
      if (text.IndexOf("-") < 1)
      {
        ModGeneralFunctions.MessageSuccessful("¡Debe tener un caracter - !");
      }
      else
      {
        string str = text.Substring(checked (text.IndexOf("-") + 1), this.TamañoCorrelativo);
        if (Operators.ConditionalCompareObjectLessEqual((object) ModGeneralFunctions.CadenaToDouble(str), (object) this.CorrelativoInicial, false))
          ModGeneralFunctions.MessageOk_Large("¡El correlativo inicial no puede ser menor correlativo ingresado!", false);
        else if (Strings.Len(str) != this.TamañoCorrelativo)
        {
          ModGeneralFunctions.MessageOk_Large("¡El correlativo debe tener " + this.TamañoCorrelativo.ToString() + " caracteres!", false);
        }
        else
        {
          if (!ModGeneralFunctions.MessageMakeAction_Large("¿Seguro de cambiar el correlativo, el mal cambio de correlativo puede traer Errores?"))
            return;
          BE_TR1_GENERALCODE beTr1Generalcode = new BE_TR1_GENERALCODE();
          BL_TR1_CONFIGURATION tr1Configuration = new BL_TR1_CONFIGURATION();
          beTr1Generalcode.set_EstabliId(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId());
          beTr1Generalcode.set_BoxId(ModGeneralVar.g_BE_TR1_CFGVARIABLES.get_BoxId());
          beTr1Generalcode.set_CodeId(ModGeneralVar.g_GeneralCode.get_Docu_Invoice());
          beTr1Generalcode.set_NumeroSerie(ModGeneralFunctions.ObtenerNumeroSerie(ModGeneralVar.g_GeneralCode.get_Docu_Invoice(), "0000000000"));
          beTr1Generalcode.set_NumeroSerieNuevo(text);
          if (tr1Configuration.ActualizarCorrelativo(beTr1Generalcode).Equals("OK"))
            ModGeneralFunctions.MessageOk("Se cambió el correlativo satisfactoriamente");
        }
      }
    }
  }
}
