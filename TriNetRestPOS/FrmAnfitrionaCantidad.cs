// Decompiled with JetBrains decompiler
// Type: TriNetRestPOS.FrmAnfitrionaCantidad
// Assembly: TriNetRestPOS, Version=5.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 43377352-E952-4AC1-9BA6-CCBE4AE5F575
// Assembly location: C:\log\TriNetRestPOS.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
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
  public class FrmAnfitrionaCantidad : Form
  {
    private IContainer components;
    private string strResultado;
    private List<BE_TR1_ANFITRIONA_CANTIDAD> oLista;

    public FrmAnfitrionaCantidad()
    {
      this.Load += new EventHandler(this.FrmAnfitrionaCantidad_Load);
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
      this.Label19 = new Label();
      this.Button_CloseTab = new Button();
      this.Button_Save = new Button();
      this.txtCantidadSegundo = new NumericTextBox.NumericTextBox();
      this.Label7 = new Label();
      this.txtMontoSegundo = new NumericTextBox.NumericTextBox();
      this.Label8 = new Label();
      this.txtCantidadPrimero = new NumericTextBox.NumericTextBox();
      this.Label5 = new Label();
      this.txtMontoPrimero = new NumericTextBox.NumericTextBox();
      this.Label6 = new Label();
      this.txtCantidadTercero = new NumericTextBox.NumericTextBox();
      this.Label1 = new Label();
      this.txtMontoTercero = new NumericTextBox.NumericTextBox();
      this.Label2 = new Label();
      this.Label11 = new Label();
      this.Label3 = new Label();
      this.SuspendLayout();
      this.Label19.AutoSize = true;
      this.Label19.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label19.ForeColor = Color.FromArgb(209, 102, 61);
      this.Label19.Location = new Point(92, 23);
      this.Label19.Name = "Label19";
      this.Label19.Size = new Size(306, 20);
      this.Label19.TabIndex = (int) byte.MaxValue;
      this.Label19.Text = "Cambia Cantidad Anfitrionas x Monto";
      this.Button_CloseTab.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.BotonRojo;
      this.Button_CloseTab.FlatStyle = FlatStyle.Flat;
      this.Button_CloseTab.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button_CloseTab.ForeColor = Color.WhiteSmoke;
      this.Button_CloseTab.Image = (Image) TriNetRestPOS.My.Resources.Resources.salir;
      this.Button_CloseTab.ImageAlign = ContentAlignment.TopCenter;
      this.Button_CloseTab.Location = new Point(244, 213);
      this.Button_CloseTab.Name = "Button_CloseTab";
      this.Button_CloseTab.Padding = new Padding(0, 5, 0, 5);
      this.Button_CloseTab.Size = new Size(114, 60);
      this.Button_CloseTab.TabIndex = 285;
      this.Button_CloseTab.Text = "Atrás";
      this.Button_CloseTab.TextAlign = ContentAlignment.BottomCenter;
      this.Button_CloseTab.UseVisualStyleBackColor = true;
      this.Button_Save.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.BotonVerde;
      this.Button_Save.FlatStyle = FlatStyle.Flat;
      this.Button_Save.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button_Save.ForeColor = Color.WhiteSmoke;
      this.Button_Save.Image = (Image) TriNetRestPOS.My.Resources.Resources.check_OK;
      this.Button_Save.ImageAlign = ContentAlignment.TopCenter;
      this.Button_Save.Location = new Point(122, 213);
      this.Button_Save.Name = "Button_Save";
      this.Button_Save.Padding = new Padding(0, 5, 0, 5);
      this.Button_Save.Size = new Size(121, 60);
      this.Button_Save.TabIndex = 284;
      this.Button_Save.Text = "Grabar";
      this.Button_Save.TextAlign = ContentAlignment.BottomCenter;
      this.Button_Save.UseVisualStyleBackColor = true;
      this.txtCantidadSegundo.set_AllowSpace(false);
      ((TextBoxBase) this.txtCantidadSegundo).BorderStyle = BorderStyle.FixedSingle;
      ((Control) this.txtCantidadSegundo).Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      ((Control) this.txtCantidadSegundo).Location = new Point(295, 126);
      ((TextBoxBase) this.txtCantidadSegundo).MaxLength = 15;
      ((Control) this.txtCantidadSegundo).Name = "txtCantidadSegundo";
      ((Control) this.txtCantidadSegundo).Size = new Size(63, 24);
      ((Control) this.txtCantidadSegundo).TabIndex = 283;
      ((TextBox) this.txtCantidadSegundo).Text = "0";
      ((TextBox) this.txtCantidadSegundo).TextAlign = HorizontalAlignment.Right;
      this.Label7.AutoSize = true;
      this.Label7.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label7.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label7.Location = new Point(249, 130);
      this.Label7.Name = "Label7";
      this.Label7.Size = new Size(27, 16);
      this.Label7.TabIndex = 282;
      this.Label7.Text = "--->";
      this.txtMontoSegundo.set_AllowSpace(false);
      ((TextBoxBase) this.txtMontoSegundo).BorderStyle = BorderStyle.FixedSingle;
      ((Control) this.txtMontoSegundo).Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      ((Control) this.txtMontoSegundo).Location = new Point(156, 126);
      ((TextBoxBase) this.txtMontoSegundo).MaxLength = 15;
      ((Control) this.txtMontoSegundo).Name = "txtMontoSegundo";
      ((Control) this.txtMontoSegundo).Size = new Size(63, 24);
      ((Control) this.txtMontoSegundo).TabIndex = 281;
      ((TextBox) this.txtMontoSegundo).Text = "0";
      ((TextBox) this.txtMontoSegundo).TextAlign = HorizontalAlignment.Right;
      this.Label8.AutoSize = true;
      this.Label8.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label8.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label8.Location = new Point(81, 130);
      this.Label8.Name = "Label8";
      this.Label8.Size = new Size(69, 16);
      this.Label8.TabIndex = 280;
      this.Label8.Text = "Segundo :";
      this.txtCantidadPrimero.set_AllowSpace(false);
      ((TextBoxBase) this.txtCantidadPrimero).BorderStyle = BorderStyle.FixedSingle;
      ((Control) this.txtCantidadPrimero).Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      ((Control) this.txtCantidadPrimero).Location = new Point(295, 84);
      ((TextBoxBase) this.txtCantidadPrimero).MaxLength = 15;
      ((Control) this.txtCantidadPrimero).Name = "txtCantidadPrimero";
      ((Control) this.txtCantidadPrimero).Size = new Size(63, 24);
      ((Control) this.txtCantidadPrimero).TabIndex = 279;
      ((TextBox) this.txtCantidadPrimero).Text = "0";
      ((TextBox) this.txtCantidadPrimero).TextAlign = HorizontalAlignment.Right;
      this.Label5.AutoSize = true;
      this.Label5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label5.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label5.Location = new Point(252, 92);
      this.Label5.Name = "Label5";
      this.Label5.Size = new Size(27, 16);
      this.Label5.TabIndex = 278;
      this.Label5.Text = "--->";
      this.txtMontoPrimero.set_AllowSpace(false);
      ((TextBoxBase) this.txtMontoPrimero).BorderStyle = BorderStyle.FixedSingle;
      ((Control) this.txtMontoPrimero).Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      ((Control) this.txtMontoPrimero).Location = new Point(156, 84);
      ((TextBoxBase) this.txtMontoPrimero).MaxLength = 15;
      ((Control) this.txtMontoPrimero).Name = "txtMontoPrimero";
      ((Control) this.txtMontoPrimero).Size = new Size(63, 24);
      ((Control) this.txtMontoPrimero).TabIndex = 277;
      ((TextBox) this.txtMontoPrimero).Text = "0";
      ((TextBox) this.txtMontoPrimero).TextAlign = HorizontalAlignment.Right;
      this.Label6.AutoSize = true;
      this.Label6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label6.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label6.Location = new Point(89, 92);
      this.Label6.Name = "Label6";
      this.Label6.Size = new Size(61, 16);
      this.Label6.TabIndex = 276;
      this.Label6.Text = "Primero :";
      this.txtCantidadTercero.set_AllowSpace(false);
      ((TextBoxBase) this.txtCantidadTercero).BorderStyle = BorderStyle.FixedSingle;
      ((Control) this.txtCantidadTercero).Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      ((Control) this.txtCantidadTercero).Location = new Point(295, 165);
      ((TextBoxBase) this.txtCantidadTercero).MaxLength = 15;
      ((Control) this.txtCantidadTercero).Name = "txtCantidadTercero";
      ((Control) this.txtCantidadTercero).Size = new Size(63, 24);
      ((Control) this.txtCantidadTercero).TabIndex = 289;
      ((TextBox) this.txtCantidadTercero).Text = "0";
      ((TextBox) this.txtCantidadTercero).TextAlign = HorizontalAlignment.Right;
      this.Label1.AutoSize = true;
      this.Label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label1.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label1.Location = new Point(249, 173);
      this.Label1.Name = "Label1";
      this.Label1.Size = new Size(27, 16);
      this.Label1.TabIndex = 288;
      this.Label1.Text = "--->";
      this.txtMontoTercero.set_AllowSpace(false);
      ((TextBoxBase) this.txtMontoTercero).BorderStyle = BorderStyle.FixedSingle;
      ((Control) this.txtMontoTercero).Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      ((Control) this.txtMontoTercero).Location = new Point(156, 165);
      ((TextBoxBase) this.txtMontoTercero).MaxLength = 15;
      ((Control) this.txtMontoTercero).Name = "txtMontoTercero";
      ((Control) this.txtMontoTercero).Size = new Size(63, 24);
      ((Control) this.txtMontoTercero).TabIndex = 287;
      ((TextBox) this.txtMontoTercero).Text = "0";
      ((TextBox) this.txtMontoTercero).TextAlign = HorizontalAlignment.Right;
      this.Label2.AutoSize = true;
      this.Label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label2.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label2.Location = new Point(88, 169);
      this.Label2.Name = "Label2";
      this.Label2.Size = new Size(62, 16);
      this.Label2.TabIndex = 286;
      this.Label2.Text = "Tercero :";
      this.Label11.AutoSize = true;
      this.Label11.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label11.ForeColor = Color.FromArgb(209, 102, 61);
      this.Label11.Location = new Point(165, 61);
      this.Label11.Name = "Label11";
      this.Label11.Size = new Size(45, 16);
      this.Label11.TabIndex = 290;
      this.Label11.Text = "Monto";
      this.Label3.AutoSize = true;
      this.Label3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label3.ForeColor = Color.FromArgb(209, 102, 61);
      this.Label3.Location = new Point(299, 61);
      this.Label3.Name = "Label3";
      this.Label3.Size = new Size(62, 16);
      this.Label3.TabIndex = 291;
      this.Label3.Text = "Cantidad";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(485, 290);
      this.Controls.Add((Control) this.Label3);
      this.Controls.Add((Control) this.Label11);
      this.Controls.Add((Control) this.txtCantidadTercero);
      this.Controls.Add((Control) this.Label1);
      this.Controls.Add((Control) this.txtMontoTercero);
      this.Controls.Add((Control) this.Label2);
      this.Controls.Add((Control) this.Button_CloseTab);
      this.Controls.Add((Control) this.Button_Save);
      this.Controls.Add((Control) this.txtCantidadSegundo);
      this.Controls.Add((Control) this.Label7);
      this.Controls.Add((Control) this.txtMontoSegundo);
      this.Controls.Add((Control) this.Label8);
      this.Controls.Add((Control) this.txtCantidadPrimero);
      this.Controls.Add((Control) this.Label5);
      this.Controls.Add((Control) this.txtMontoPrimero);
      this.Controls.Add((Control) this.Label6);
      this.Controls.Add((Control) this.Label19);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (FrmAnfitrionaCantidad);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Anfitriona Cantidad";
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    internal virtual Label Label19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button_CloseTab
    {
      get
      {
        return this._Button_CloseTab;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_CloseTab_Click);
        Button buttonCloseTab1 = this._Button_CloseTab;
        if (buttonCloseTab1 != null)
          buttonCloseTab1.Click -= eventHandler;
        this._Button_CloseTab = value;
        Button buttonCloseTab2 = this._Button_CloseTab;
        if (buttonCloseTab2 == null)
          return;
        buttonCloseTab2.Click += eventHandler;
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

    internal virtual NumericTextBox.NumericTextBox txtCantidadSegundo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual NumericTextBox.NumericTextBox txtMontoSegundo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual NumericTextBox.NumericTextBox txtCantidadPrimero { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual NumericTextBox.NumericTextBox txtMontoPrimero { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual NumericTextBox.NumericTextBox txtCantidadTercero { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual NumericTextBox.NumericTextBox txtMontoTercero { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private void Button_CloseTab_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void CargarDatos()
    {
      BL_TR1_ANFITRIONA_CANTIDAD anfitrionaCantidad = new BL_TR1_ANFITRIONA_CANTIDAD();
      this.oLista = new List<BE_TR1_ANFITRIONA_CANTIDAD>();
      this.oLista = anfitrionaCantidad.Listado(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId());
      if (this.oLista != null && this.oLista.Count > 0)
      {
        ((TextBox) this.txtMontoPrimero).Text = this.oLista[0].get_Monto().ToString();
        ((TextBox) this.txtCantidadPrimero).Text = this.oLista[0].get_CantAnfitriona().ToString();
        ((TextBox) this.txtMontoSegundo).Text = this.oLista[1].get_Monto().ToString();
        ((TextBox) this.txtCantidadSegundo).Text = this.oLista[1].get_CantAnfitriona().ToString();
        ((TextBox) this.txtMontoTercero).Text = this.oLista[2].get_Monto().ToString();
        ((TextBox) this.txtCantidadTercero).Text = this.oLista[2].get_CantAnfitriona().ToString();
      }
    }

    public object Validaciones()
    {
      if (ModGeneralFunctions.CadenaToDouble(((TextBox) this.txtCantidadPrimero).Text) % 1.0 != 0.0)
      {
        ModGeneralFunctions.MessageOk1("Cantidad Primero no es un entero");
        return (object) false;
      }
      if (ModGeneralFunctions.CadenaToDouble(((TextBox) this.txtCantidadSegundo).Text) % 1.0 != 0.0)
      {
        ModGeneralFunctions.MessageOk1("Cantidad Segundo no es un entero");
        return (object) false;
      }
      if (ModGeneralFunctions.CadenaToDouble(((TextBox) this.txtCantidadTercero).Text) % 1.0 != 0.0)
      {
        ModGeneralFunctions.MessageOk1("Cantidad Tercero no es un entero");
        return (object) false;
      }
      if (ModGeneralFunctions.CadenaToInteger(((TextBox) this.txtCantidadPrimero).Text) < 1)
      {
        ModGeneralFunctions.MessageOk1("Cantidad Primero no puede ser menor a 1");
        return (object) false;
      }
      if (ModGeneralFunctions.CadenaToInteger(((TextBox) this.txtCantidadPrimero).Text) > ModGeneralFunctions.CadenaToInteger(((TextBox) this.txtCantidadSegundo).Text))
      {
        ModGeneralFunctions.MessageOk1("Cantidad Primero no puede ser mayor a la cantidad segunda");
        return (object) false;
      }
      if (ModGeneralFunctions.CadenaToInteger(((TextBox) this.txtCantidadSegundo).Text) > ModGeneralFunctions.CadenaToInteger(((TextBox) this.txtCantidadTercero).Text))
      {
        ModGeneralFunctions.MessageOk1("Cantidad Segunda no puede ser mayor a la cantidad tercera");
        return (object) false;
      }
      if (ModGeneralFunctions.CadenaToInteger(((TextBox) this.txtMontoPrimero).Text) <= 0)
      {
        ModGeneralFunctions.MessageOk1("Monto Primero no puede ser menor o igual a 0");
        return (object) false;
      }
      if (ModGeneralFunctions.CadenaToInteger(((TextBox) this.txtMontoPrimero).Text) > ModGeneralFunctions.CadenaToInteger(((TextBox) this.txtMontoSegundo).Text))
      {
        ModGeneralFunctions.MessageOk1("Monto Primero no puede ser mayor al monto Segundo");
        return (object) false;
      }
      if (ModGeneralFunctions.CadenaToInteger(((TextBox) this.txtMontoSegundo).Text) <= ModGeneralFunctions.CadenaToInteger(((TextBox) this.txtMontoTercero).Text))
        return (object) true;
      ModGeneralFunctions.MessageOk1("Monto Segundo no puede ser mayor al monto tercero");
      return (object) false;
    }

    private void FrmAnfitrionaCantidad_Load(object sender, EventArgs e)
    {
      this.CargarDatos();
    }

    private void Button_Save_Click(object sender, EventArgs e)
    {
      if (Operators.ConditionalCompareObjectEqual(this.Validaciones(), (object) false, false) || !ModGeneralFunctions.MessageMakeAction1("¿Seguro de grabar el Monto y Cantidad?", false) || !new BL_TR1_ANFITRIONA_CANTIDAD().ActualizarMontoyCantidad(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId(), ModGeneralFunctions.CadenaToDouble(((TextBox) this.txtMontoPrimero).Text), ModGeneralFunctions.CadenaToInteger(((TextBox) this.txtCantidadPrimero).Text), ModGeneralFunctions.CadenaToDouble(((TextBox) this.txtMontoSegundo).Text), ModGeneralFunctions.CadenaToInteger(((TextBox) this.txtCantidadSegundo).Text), ModGeneralFunctions.CadenaToDouble(((TextBox) this.txtMontoTercero).Text), ModGeneralFunctions.CadenaToInteger(((TextBox) this.txtCantidadTercero).Text), ModGeneralVar.g_BE_USERS.get_UserId()).Equals("OK"))
        return;
      ModGeneralFunctions.MessageOk1("Se actualizo el monto y cantidad");
    }
  }
}
