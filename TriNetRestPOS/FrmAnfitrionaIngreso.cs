// Decompiled with JetBrains decompiler
// Type: TriNetRestPOS.FrmAnfitrionaIngreso
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
  public class FrmAnfitrionaIngreso : Form
  {
    private IContainer components;
    private string strResultado;
    private List<BE_TR1_ANFITRIONA_INGRESO> oLista;

    public FrmAnfitrionaIngreso()
    {
      this.Load += new EventHandler(this.FrmAnfitrionaIngreso_Load);
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
      this.Label1 = new Label();
      this.txtHoraIngreso = new MaskedTextBox();
      this.Button_Ready = new Button();
      this.Label2 = new Label();
      this.Label3 = new Label();
      this.txtMinutosPuntual = new NumericTextBox.NumericTextBox();
      this.txtPorcPuntual = new NumericTextBox.NumericTextBox();
      this.Label4 = new Label();
      this.txtPorcTarde = new NumericTextBox.NumericTextBox();
      this.Label5 = new Label();
      this.txtMinutosTarde = new NumericTextBox.NumericTextBox();
      this.Label6 = new Label();
      this.txtPorcMuyTarde = new NumericTextBox.NumericTextBox();
      this.Label7 = new Label();
      this.txtMinutosMuyTarde = new NumericTextBox.NumericTextBox();
      this.Label8 = new Label();
      this.Label9 = new Label();
      this.txtPorcAmorenLlamas = new NumericTextBox.NumericTextBox();
      this.Label10 = new Label();
      this.Button_CloseTab = new Button();
      this.Button_Save = new Button();
      this.Label11 = new Label();
      this.SuspendLayout();
      this.Label19.AutoSize = true;
      this.Label19.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label19.ForeColor = Color.FromArgb(209, 102, 61);
      this.Label19.Location = new Point(199, 20);
      this.Label19.Name = "Label19";
      this.Label19.Size = new Size(179, 20);
      this.Label19.TabIndex = 254;
      this.Label19.Text = "Cambia Hora Ingreso";
      this.Label1.AutoSize = true;
      this.Label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label1.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label1.Location = new Point(107, 76);
      this.Label1.Name = "Label1";
      this.Label1.Size = new Size(92, 16);
      this.Label1.TabIndex = (int) byte.MaxValue;
      this.Label1.Text = "Hora Ingreso :";
      this.txtHoraIngreso.BorderStyle = BorderStyle.FixedSingle;
      this.txtHoraIngreso.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtHoraIngreso.Location = new Point(239, 71);
      this.txtHoraIngreso.Mask = "00:00:00";
      this.txtHoraIngreso.Name = "txtHoraIngreso";
      this.txtHoraIngreso.Size = new Size(122, 24);
      this.txtHoraIngreso.TabIndex = 256;
      this.txtHoraIngreso.TextAlign = HorizontalAlignment.Right;
      this.Button_Ready.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.boton_guardar;
      this.Button_Ready.FlatStyle = FlatStyle.Flat;
      this.Button_Ready.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button_Ready.ForeColor = Color.WhiteSmoke;
      this.Button_Ready.Image = (Image) TriNetRestPOS.My.Resources.Resources.check_OK;
      this.Button_Ready.ImageAlign = ContentAlignment.TopCenter;
      this.Button_Ready.Location = new Point(408, 41);
      this.Button_Ready.Name = "Button_Ready";
      this.Button_Ready.Padding = new Padding(0, 5, 0, 5);
      this.Button_Ready.Size = new Size(74, 56);
      this.Button_Ready.TabIndex = 257;
      this.Button_Ready.Text = "Grabar";
      this.Button_Ready.TextAlign = ContentAlignment.BottomCenter;
      this.Button_Ready.UseVisualStyleBackColor = true;
      this.Label2.AutoSize = true;
      this.Label2.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label2.ForeColor = Color.FromArgb(209, 102, 61);
      this.Label2.Location = new Point(154, 157);
      this.Label2.Name = "Label2";
      this.Label2.Size = new Size(288, 20);
      this.Label2.TabIndex = 258;
      this.Label2.Text = "Cambia Porcentaje y minutos tarde";
      this.Label3.AutoSize = true;
      this.Label3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label3.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label3.Location = new Point(144, 247);
      this.Label3.Name = "Label3";
      this.Label3.Size = new Size(58, 16);
      this.Label3.TabIndex = 259;
      this.Label3.Text = "Puntual :";
      this.txtMinutosPuntual.set_AllowSpace(false);
      ((TextBoxBase) this.txtMinutosPuntual).BorderStyle = BorderStyle.FixedSingle;
      ((Control) this.txtMinutosPuntual).Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      ((Control) this.txtMinutosPuntual).Location = new Point(212, 239);
      ((TextBoxBase) this.txtMinutosPuntual).MaxLength = 15;
      ((Control) this.txtMinutosPuntual).Name = "txtMinutosPuntual";
      ((TextBoxBase) this.txtMinutosPuntual).ReadOnly = true;
      ((Control) this.txtMinutosPuntual).Size = new Size(63, 24);
      ((Control) this.txtMinutosPuntual).TabIndex = 260;
      ((TextBox) this.txtMinutosPuntual).Text = "0";
      ((TextBox) this.txtMinutosPuntual).TextAlign = HorizontalAlignment.Right;
      this.txtPorcPuntual.set_AllowSpace(false);
      ((TextBoxBase) this.txtPorcPuntual).BorderStyle = BorderStyle.FixedSingle;
      ((Control) this.txtPorcPuntual).Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      ((Control) this.txtPorcPuntual).Location = new Point(351, 239);
      ((TextBoxBase) this.txtPorcPuntual).MaxLength = 15;
      ((Control) this.txtPorcPuntual).Name = "txtPorcPuntual";
      ((Control) this.txtPorcPuntual).Size = new Size(63, 24);
      ((Control) this.txtPorcPuntual).TabIndex = 262;
      ((TextBox) this.txtPorcPuntual).Text = "0";
      ((TextBox) this.txtPorcPuntual).TextAlign = HorizontalAlignment.Right;
      this.Label4.AutoSize = true;
      this.Label4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label4.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label4.Location = new Point(319, 247);
      this.Label4.Name = "Label4";
      this.Label4.Size = new Size(26, 16);
      this.Label4.TabIndex = 261;
      this.Label4.Text = "% :";
      this.txtPorcTarde.set_AllowSpace(false);
      ((TextBoxBase) this.txtPorcTarde).BorderStyle = BorderStyle.FixedSingle;
      ((Control) this.txtPorcTarde).Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      ((Control) this.txtPorcTarde).Location = new Point(351, 284);
      ((TextBoxBase) this.txtPorcTarde).MaxLength = 15;
      ((Control) this.txtPorcTarde).Name = "txtPorcTarde";
      ((Control) this.txtPorcTarde).Size = new Size(63, 24);
      ((Control) this.txtPorcTarde).TabIndex = 266;
      ((TextBox) this.txtPorcTarde).Text = "0";
      ((TextBox) this.txtPorcTarde).TextAlign = HorizontalAlignment.Right;
      this.Label5.AutoSize = true;
      this.Label5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label5.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label5.Location = new Point(319, 292);
      this.Label5.Name = "Label5";
      this.Label5.Size = new Size(26, 16);
      this.Label5.TabIndex = 265;
      this.Label5.Text = "% :";
      this.txtMinutosTarde.set_AllowSpace(false);
      ((TextBoxBase) this.txtMinutosTarde).BorderStyle = BorderStyle.FixedSingle;
      ((Control) this.txtMinutosTarde).Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      ((Control) this.txtMinutosTarde).Location = new Point(212, 284);
      ((TextBoxBase) this.txtMinutosTarde).MaxLength = 15;
      ((Control) this.txtMinutosTarde).Name = "txtMinutosTarde";
      ((Control) this.txtMinutosTarde).Size = new Size(63, 24);
      ((Control) this.txtMinutosTarde).TabIndex = 264;
      ((TextBox) this.txtMinutosTarde).Text = "0";
      ((TextBox) this.txtMinutosTarde).TextAlign = HorizontalAlignment.Right;
      this.Label6.AutoSize = true;
      this.Label6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label6.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label6.Location = new Point(151, 292);
      this.Label6.Name = "Label6";
      this.Label6.Size = new Size(51, 16);
      this.Label6.TabIndex = 263;
      this.Label6.Text = "Tarde :";
      this.txtPorcMuyTarde.set_AllowSpace(false);
      ((TextBoxBase) this.txtPorcMuyTarde).BorderStyle = BorderStyle.FixedSingle;
      ((Control) this.txtPorcMuyTarde).Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      ((Control) this.txtPorcMuyTarde).Location = new Point(351, 326);
      ((TextBoxBase) this.txtPorcMuyTarde).MaxLength = 15;
      ((Control) this.txtPorcMuyTarde).Name = "txtPorcMuyTarde";
      ((Control) this.txtPorcMuyTarde).Size = new Size(63, 24);
      ((Control) this.txtPorcMuyTarde).TabIndex = 270;
      ((TextBox) this.txtPorcMuyTarde).Text = "0";
      ((TextBox) this.txtPorcMuyTarde).TextAlign = HorizontalAlignment.Right;
      this.Label7.AutoSize = true;
      this.Label7.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label7.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label7.Location = new Point(319, 334);
      this.Label7.Name = "Label7";
      this.Label7.Size = new Size(26, 16);
      this.Label7.TabIndex = 269;
      this.Label7.Text = "% :";
      this.txtMinutosMuyTarde.set_AllowSpace(false);
      ((TextBoxBase) this.txtMinutosMuyTarde).BorderStyle = BorderStyle.FixedSingle;
      ((Control) this.txtMinutosMuyTarde).Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      ((Control) this.txtMinutosMuyTarde).Location = new Point(212, 326);
      ((TextBoxBase) this.txtMinutosMuyTarde).MaxLength = 15;
      ((Control) this.txtMinutosMuyTarde).Name = "txtMinutosMuyTarde";
      ((Control) this.txtMinutosMuyTarde).Size = new Size(63, 24);
      ((Control) this.txtMinutosMuyTarde).TabIndex = 268;
      ((TextBox) this.txtMinutosMuyTarde).Text = "0";
      ((TextBox) this.txtMinutosMuyTarde).TextAlign = HorizontalAlignment.Right;
      this.Label8.AutoSize = true;
      this.Label8.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label8.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label8.Location = new Point(123, 334);
      this.Label8.Name = "Label8";
      this.Label8.Size = new Size(79, 16);
      this.Label8.TabIndex = 267;
      this.Label8.Text = "Muy Tarde :";
      this.Label9.AutoSize = true;
      this.Label9.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label9.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label9.Location = new Point(95, 197);
      this.Label9.Name = "Label9";
      this.Label9.Size = new Size(107, 16);
      this.Label9.TabIndex = 271;
      this.Label9.Text = "Amor en llamas :";
      this.txtPorcAmorenLlamas.set_AllowSpace(false);
      ((TextBoxBase) this.txtPorcAmorenLlamas).BorderStyle = BorderStyle.FixedSingle;
      ((Control) this.txtPorcAmorenLlamas).Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      ((Control) this.txtPorcAmorenLlamas).Location = new Point(351, 193);
      ((TextBoxBase) this.txtPorcAmorenLlamas).MaxLength = 15;
      ((Control) this.txtPorcAmorenLlamas).Name = "txtPorcAmorenLlamas";
      ((Control) this.txtPorcAmorenLlamas).Size = new Size(63, 24);
      ((Control) this.txtPorcAmorenLlamas).TabIndex = 273;
      ((TextBox) this.txtPorcAmorenLlamas).Text = "0";
      ((TextBox) this.txtPorcAmorenLlamas).TextAlign = HorizontalAlignment.Right;
      this.Label10.AutoSize = true;
      this.Label10.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label10.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label10.Location = new Point(319, 201);
      this.Label10.Name = "Label10";
      this.Label10.Size = new Size(26, 16);
      this.Label10.TabIndex = 272;
      this.Label10.Text = "% :";
      this.Button_CloseTab.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.BotonRojo;
      this.Button_CloseTab.FlatStyle = FlatStyle.Flat;
      this.Button_CloseTab.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button_CloseTab.ForeColor = Color.WhiteSmoke;
      this.Button_CloseTab.Image = (Image) TriNetRestPOS.My.Resources.Resources.salir;
      this.Button_CloseTab.ImageAlign = ContentAlignment.TopCenter;
      this.Button_CloseTab.Location = new Point(300, 378);
      this.Button_CloseTab.Name = "Button_CloseTab";
      this.Button_CloseTab.Padding = new Padding(0, 5, 0, 5);
      this.Button_CloseTab.Size = new Size(114, 60);
      this.Button_CloseTab.TabIndex = 275;
      this.Button_CloseTab.Text = "Atrás";
      this.Button_CloseTab.TextAlign = ContentAlignment.BottomCenter;
      this.Button_CloseTab.UseVisualStyleBackColor = true;
      this.Button_Save.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.BotonVerde;
      this.Button_Save.FlatStyle = FlatStyle.Flat;
      this.Button_Save.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button_Save.ForeColor = Color.WhiteSmoke;
      this.Button_Save.Image = (Image) TriNetRestPOS.My.Resources.Resources.check_OK;
      this.Button_Save.ImageAlign = ContentAlignment.TopCenter;
      this.Button_Save.Location = new Point(178, 378);
      this.Button_Save.Name = "Button_Save";
      this.Button_Save.Padding = new Padding(0, 5, 0, 5);
      this.Button_Save.Size = new Size(121, 60);
      this.Button_Save.TabIndex = 274;
      this.Button_Save.Text = "Grabar";
      this.Button_Save.TextAlign = ContentAlignment.BottomCenter;
      this.Button_Save.UseVisualStyleBackColor = true;
      this.Label11.AutoSize = true;
      this.Label11.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label11.ForeColor = Color.FromArgb(209, 102, 61);
      this.Label11.Location = new Point(222, 197);
      this.Label11.Name = "Label11";
      this.Label11.Size = new Size(54, 16);
      this.Label11.TabIndex = 276;
      this.Label11.Text = "Minutos";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(611, 458);
      this.Controls.Add((Control) this.Label11);
      this.Controls.Add((Control) this.Button_CloseTab);
      this.Controls.Add((Control) this.Button_Save);
      this.Controls.Add((Control) this.txtPorcAmorenLlamas);
      this.Controls.Add((Control) this.Label10);
      this.Controls.Add((Control) this.Label9);
      this.Controls.Add((Control) this.txtPorcMuyTarde);
      this.Controls.Add((Control) this.Label7);
      this.Controls.Add((Control) this.txtMinutosMuyTarde);
      this.Controls.Add((Control) this.Label8);
      this.Controls.Add((Control) this.txtPorcTarde);
      this.Controls.Add((Control) this.Label5);
      this.Controls.Add((Control) this.txtMinutosTarde);
      this.Controls.Add((Control) this.Label6);
      this.Controls.Add((Control) this.txtPorcPuntual);
      this.Controls.Add((Control) this.Label4);
      this.Controls.Add((Control) this.txtMinutosPuntual);
      this.Controls.Add((Control) this.Label3);
      this.Controls.Add((Control) this.Label2);
      this.Controls.Add((Control) this.Button_Ready);
      this.Controls.Add((Control) this.txtHoraIngreso);
      this.Controls.Add((Control) this.Label1);
      this.Controls.Add((Control) this.Label19);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (FrmAnfitrionaIngreso);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Anfitriona Horario de Ingreso y Porcentajes";
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    internal virtual Label Label19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual MaskedTextBox txtHoraIngreso { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button_Ready
    {
      get
      {
        return this._Button_Ready;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_Ready_Click);
        Button buttonReady1 = this._Button_Ready;
        if (buttonReady1 != null)
          buttonReady1.Click -= eventHandler;
        this._Button_Ready = value;
        Button buttonReady2 = this._Button_Ready;
        if (buttonReady2 == null)
          return;
        buttonReady2.Click += eventHandler;
      }
    }

    internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual NumericTextBox.NumericTextBox txtMinutosPuntual { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual NumericTextBox.NumericTextBox txtPorcPuntual { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual NumericTextBox.NumericTextBox txtPorcTarde { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual NumericTextBox.NumericTextBox txtMinutosTarde { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual NumericTextBox.NumericTextBox txtPorcMuyTarde { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual NumericTextBox.NumericTextBox txtMinutosMuyTarde { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual NumericTextBox.NumericTextBox txtPorcAmorenLlamas { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

    internal virtual Label Label11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    public object Validaciones()
    {
      if (Convert.ToDouble(((TextBox) this.txtPorcAmorenLlamas).Text) > 100.0)
      {
        ModGeneralFunctions.MessageOk1("El máximo porcentaje en amor en llamas es 100");
        ((Control) this.txtPorcAmorenLlamas).Focus();
        return (object) false;
      }
      if (Convert.ToDouble(((TextBox) this.txtPorcPuntual).Text) > 100.0)
      {
        ModGeneralFunctions.MessageOk1("El máximo porcentaje en horario puntial es 100");
        ((Control) this.txtPorcPuntual).Focus();
        return (object) false;
      }
      if (Convert.ToDouble(((TextBox) this.txtPorcTarde).Text) > 100.0)
      {
        ModGeneralFunctions.MessageOk1("El máximo porcentaje en horario tarde es 100");
        ((Control) this.txtPorcTarde).Focus();
        return (object) false;
      }
      if (Convert.ToDouble(((TextBox) this.txtPorcMuyTarde).Text) <= 100.0)
        return (object) true;
      ModGeneralFunctions.MessageOk1("El máximo porcentaje en horario muy tarde es 100");
      ((Control) this.txtPorcMuyTarde).Focus();
      return (object) false;
    }

    private void CargarDatos()
    {
      BL_TR1_ANFITRIONA_INGRESO anfitrionaIngreso = new BL_TR1_ANFITRIONA_INGRESO();
      this.oLista = new List<BE_TR1_ANFITRIONA_INGRESO>();
      this.oLista = anfitrionaIngreso.Lista();
      if (this.oLista != null && this.oLista.Count > 0)
      {
        this.txtHoraIngreso.Text = this.oLista[0].get_HoraIngreso();
        ((TextBox) this.txtPorcAmorenLlamas).Text = this.oLista[0].get_Porcentaje().ToString();
        ((TextBox) this.txtPorcPuntual).Text = this.oLista[1].get_Porcentaje().ToString();
        ((TextBox) this.txtMinutosTarde).Text = this.oLista[2].get_MinutosTarde().ToString();
        ((TextBox) this.txtPorcTarde).Text = this.oLista[2].get_Porcentaje().ToString();
        ((TextBox) this.txtMinutosMuyTarde).Text = this.oLista[3].get_MinutosTarde().ToString();
        ((TextBox) this.txtPorcMuyTarde).Text = this.oLista[3].get_Porcentaje().ToString();
      }
    }

    private void FrmAnfitrionaIngreso_Load(object sender, EventArgs e)
    {
      try
      {
        this.CargarDatos();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ModGeneralFunctions.MessageOk1(ex.Message);
        ProjectData.ClearProjectError();
      }
    }

    private void Button_Ready_Click(object sender, EventArgs e)
    {
      if (this.txtHoraIngreso.Text.Length != 8)
      {
        ModGeneralFunctions.MessageOk1("Debe tener el formato correcto la hora ingresada");
        this.txtHoraIngreso.Focus();
      }
      else if (Convert.ToInt32(this.txtHoraIngreso.Text.Substring(0, 2)) > 23)
      {
        ModGeneralFunctions.MessageOk1("Debe ingresar una hora no mayor a 23 horas");
        this.txtHoraIngreso.Focus();
      }
      else if (Convert.ToInt32(this.txtHoraIngreso.Text.Substring(3, 2)) > 59)
      {
        ModGeneralFunctions.MessageOk1("Debe ingresar una minutero no mayor a 59");
        this.txtHoraIngreso.Focus();
      }
      else if (Convert.ToInt32(this.txtHoraIngreso.Text.Substring(6, 2)) > 59)
      {
        ModGeneralFunctions.MessageOk1("Debe ingresar un segundero no mayor a 59");
        this.txtHoraIngreso.Focus();
      }
      else
      {
        if (!ModGeneralFunctions.MessageMakeAction1("¿Seguro de modificar la hora de ingreso [" + this.txtHoraIngreso.Text + "]?", false))
          return;
        if (new BL_TR1_ANFITRIONA_INGRESO().ActualizarHoraIngreso(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId(), this.txtHoraIngreso.Text).Equals("OK"))
          ModGeneralFunctions.MessageOk1("Se actualizo la hora de ingreso correctamente");
      }
    }

    private void Button_CloseTab_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void Button_Save_Click(object sender, EventArgs e)
    {
      if (Operators.ConditionalCompareObjectEqual(this.Validaciones(), (object) false, false) || !ModGeneralFunctions.MessageMakeAction1("¿Seguro de grabar el porcentaje y mimutos tarde?", false))
        return;
      BE_TR1_ANFITRIONA_INGRESO anfitrionaIngreso = new BE_TR1_ANFITRIONA_INGRESO();
      anfitrionaIngreso.set_LocalId(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId());
      anfitrionaIngreso.set_PorcentajeLlamas(Convert.ToDouble(((TextBox) this.txtPorcAmorenLlamas).Text));
      anfitrionaIngreso.set_PorcentajePuntual(Convert.ToDouble(((TextBox) this.txtPorcPuntual).Text));
      anfitrionaIngreso.set_MinutosTarde(checked ((int) Math.Round(Convert.ToDouble(((TextBox) this.txtMinutosTarde).Text))));
      anfitrionaIngreso.set_PorcentajeTarde(Convert.ToDouble(((TextBox) this.txtPorcTarde).Text));
      anfitrionaIngreso.set_MinutosMuyTarde(Convert.ToDouble(((TextBox) this.txtMinutosMuyTarde).Text));
      anfitrionaIngreso.set_PorcentajeMuyTarde(Convert.ToDouble(((TextBox) this.txtPorcMuyTarde).Text));
      if (new BL_TR1_ANFITRIONA_INGRESO().ActualizarMinutosPorcentajeIngreso(anfitrionaIngreso).Equals("OK"))
        ModGeneralFunctions.MessageOk1("Se actualizo el porcentaje y mimutos tarde");
    }
  }
}
