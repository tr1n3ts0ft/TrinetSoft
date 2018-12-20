// Decompiled with JetBrains decompiler
// Type: TriNetRestPOS.FrmClienteOpcAvanzada
// Assembly: TriNetRestPOS, Version=5.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 43377352-E952-4AC1-9BA6-CCBE4AE5F575
// Assembly location: C:\log\TriNetRestPOS.exe

using Microsoft.VisualBasic.CompilerServices;
using MyXPButton;
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
  public class FrmClienteOpcAvanzada : Form
  {
    private IContainer components;

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
      this.Label1 = new Label();
      this.chbEsActivo = new CheckBox();
      this.txtPorcentajeDscto = new NumericTextBox.NumericTextBox();
      this.lblExoneradoImp1 = new Label();
      this.chbExoneradoImp1 = new CheckBox();
      this.Label6 = new Label();
      this.btnPorcentajeDscto = new MyXPButton.MyXPButton();
      this.btnSalir = new Button();
      this.btnGuardar = new Button();
      this.Button_Nombre = new MyXPButton.MyXPButton();
      this.txtRazonSocial = new TextBox();
      this.txtClientId = new TextBox();
      this.btnEmail = new MyXPButton.MyXPButton();
      this.TextBox_EmailPersonal = new TextBox();
      this.SuspendLayout();
      this.Label1.AutoSize = true;
      this.Label1.ForeColor = Color.MediumBlue;
      this.Label1.Location = new Point(97, 166);
      this.Label1.Name = "Label1";
      this.Label1.Size = new Size(88, 20);
      this.Label1.TabIndex = 232;
      this.Label1.Text = "¿Es Activo?";
      this.chbEsActivo.Appearance = Appearance.Button;
      this.chbEsActivo.AutoSize = true;
      this.chbEsActivo.Checked = true;
      this.chbEsActivo.CheckState = CheckState.Checked;
      this.chbEsActivo.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.chbEsActivo.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.chbEsActivo.FlatStyle = FlatStyle.Flat;
      this.chbEsActivo.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.chbEsActivo.Image = (Image) TriNetRestPOS.My.Resources.Resources.IsObservated_True;
      this.chbEsActivo.Location = new Point(266, 161);
      this.chbEsActivo.Name = "chbEsActivo";
      this.chbEsActivo.Size = new Size(39, 30);
      this.chbEsActivo.TabIndex = 225;
      this.chbEsActivo.Text = "    ";
      this.chbEsActivo.UseVisualStyleBackColor = true;
      this.txtPorcentajeDscto.set_AllowSpace(false);
      ((Control) this.txtPorcentajeDscto).Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      ((Control) this.txtPorcentajeDscto).Location = new Point(104, 74);
      ((TextBoxBase) this.txtPorcentajeDscto).MaxLength = 4;
      ((Control) this.txtPorcentajeDscto).Name = "txtPorcentajeDscto";
      ((Control) this.txtPorcentajeDscto).Size = new Size(200, 25);
      ((Control) this.txtPorcentajeDscto).TabIndex = 224;
      ((TextBox) this.txtPorcentajeDscto).Text = "0";
      ((TextBox) this.txtPorcentajeDscto).TextAlign = HorizontalAlignment.Center;
      this.lblExoneradoImp1.AutoSize = true;
      this.lblExoneradoImp1.ForeColor = Color.MediumBlue;
      this.lblExoneradoImp1.Location = new Point(97, 195);
      this.lblExoneradoImp1.Name = "lblExoneradoImp1";
      this.lblExoneradoImp1.Size = new Size(166, 20);
      this.lblExoneradoImp1.TabIndex = 231;
      this.lblExoneradoImp1.Text = "¿Exonerado de I.G.V.?";
      this.chbExoneradoImp1.Appearance = Appearance.Button;
      this.chbExoneradoImp1.AutoSize = true;
      this.chbExoneradoImp1.FlatAppearance.CheckedBackColor = Color.NavajoWhite;
      this.chbExoneradoImp1.FlatAppearance.MouseDownBackColor = Color.NavajoWhite;
      this.chbExoneradoImp1.FlatStyle = FlatStyle.Flat;
      this.chbExoneradoImp1.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.chbExoneradoImp1.Image = (Image) TriNetRestPOS.My.Resources.Resources.IsObservated_False;
      this.chbExoneradoImp1.Location = new Point(266, 190);
      this.chbExoneradoImp1.Name = "chbExoneradoImp1";
      this.chbExoneradoImp1.Size = new Size(39, 30);
      this.chbExoneradoImp1.TabIndex = 226;
      this.chbExoneradoImp1.Text = "    ";
      this.chbExoneradoImp1.UseVisualStyleBackColor = true;
      this.Label6.AutoSize = true;
      this.Label6.Font = new Font("Trebuchet MS", 12.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label6.ForeColor = Color.MediumBlue;
      this.Label6.Location = new Point(308, 75);
      this.Label6.Name = "Label6";
      this.Label6.Size = new Size(23, 23);
      this.Label6.TabIndex = 230;
      this.Label6.Tag = (object) "";
      this.Label6.Text = "%";
      this.btnPorcentajeDscto.set_AdjustImageLocation(new Point(0, 0));
      this.btnPorcentajeDscto.set_BtnShape((emunType.BtnShape) 0);
      this.btnPorcentajeDscto.set_BtnStyle((emunType.XPStyle) 3);
      ((Control) this.btnPorcentajeDscto).Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      ((Control) this.btnPorcentajeDscto).ForeColor = Color.MediumBlue;
      ((Control) this.btnPorcentajeDscto).Location = new Point(10, 62);
      ((Control) this.btnPorcentajeDscto).Name = "btnPorcentajeDscto";
      ((Control) this.btnPorcentajeDscto).Size = new Size(91, 47);
      ((Control) this.btnPorcentajeDscto).TabIndex = 229;
      ((ButtonBase) this.btnPorcentajeDscto).Text = "Dscto.";
      ((ButtonBase) this.btnPorcentajeDscto).TextImageRelation = TextImageRelation.TextAboveImage;
      ((ButtonBase) this.btnPorcentajeDscto).UseVisualStyleBackColor = true;
      this.btnSalir.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnSalir.ForeColor = Color.MediumBlue;
      this.btnSalir.Image = (Image) TriNetRestPOS.My.Resources.Resources.i_Close;
      this.btnSalir.Location = new Point(187, 233);
      this.btnSalir.Name = "btnSalir";
      this.btnSalir.Size = new Size(100, 60);
      this.btnSalir.TabIndex = 228;
      this.btnSalir.Text = "&Salir";
      this.btnSalir.TextImageRelation = TextImageRelation.TextAboveImage;
      this.btnSalir.UseVisualStyleBackColor = true;
      this.btnGuardar.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnGuardar.ForeColor = Color.MediumBlue;
      this.btnGuardar.Image = (Image) TriNetRestPOS.My.Resources.Resources.i_Ready;
      this.btnGuardar.Location = new Point(61, 233);
      this.btnGuardar.Name = "btnGuardar";
      this.btnGuardar.Size = new Size((int) sbyte.MaxValue, 60);
      this.btnGuardar.TabIndex = 227;
      this.btnGuardar.Text = "&Grabar [F10]";
      this.btnGuardar.TextImageRelation = TextImageRelation.TextAboveImage;
      this.btnGuardar.UseVisualStyleBackColor = true;
      this.Button_Nombre.set_AdjustImageLocation(new Point(0, 0));
      this.Button_Nombre.set_BtnShape((emunType.BtnShape) 0);
      this.Button_Nombre.set_BtnStyle((emunType.XPStyle) 3);
      ((Control) this.Button_Nombre).Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      ((Control) this.Button_Nombre).ForeColor = Color.MediumBlue;
      ((Control) this.Button_Nombre).Location = new Point(10, 9);
      ((Control) this.Button_Nombre).Name = "Button_Nombre";
      ((Control) this.Button_Nombre).Size = new Size(91, 47);
      ((Control) this.Button_Nombre).TabIndex = 234;
      ((ButtonBase) this.Button_Nombre).Text = "Nombre";
      ((ButtonBase) this.Button_Nombre).TextImageRelation = TextImageRelation.TextAboveImage;
      ((ButtonBase) this.Button_Nombre).UseVisualStyleBackColor = true;
      this.txtRazonSocial.BackColor = Color.FromArgb((int) byte.MaxValue, 240, 144);
      this.txtRazonSocial.Location = new Point(104, 9);
      this.txtRazonSocial.MaxLength = 150;
      this.txtRazonSocial.Multiline = true;
      this.txtRazonSocial.Name = "txtRazonSocial";
      this.txtRazonSocial.ReadOnly = true;
      this.txtRazonSocial.ScrollBars = ScrollBars.Vertical;
      this.txtRazonSocial.Size = new Size(235, 47);
      this.txtRazonSocial.TabIndex = 233;
      this.txtClientId.BackColor = Color.FromArgb((int) byte.MaxValue, 240, 144);
      this.txtClientId.Location = new Point(12, 190);
      this.txtClientId.Name = "txtClientId";
      this.txtClientId.Size = new Size(10, 25);
      this.txtClientId.TabIndex = 235;
      this.txtClientId.Visible = false;
      this.btnEmail.set_AdjustImageLocation(new Point(0, 0));
      this.btnEmail.set_BtnShape((emunType.BtnShape) 0);
      this.btnEmail.set_BtnStyle((emunType.XPStyle) 3);
      ((Control) this.btnEmail).Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      ((Control) this.btnEmail).ForeColor = Color.MediumBlue;
      ((Control) this.btnEmail).Location = new Point(10, 113);
      ((Control) this.btnEmail).Name = "btnEmail";
      ((Control) this.btnEmail).Size = new Size(91, 45);
      ((Control) this.btnEmail).TabIndex = 239;
      ((ButtonBase) this.btnEmail).Text = "Email";
      ((ButtonBase) this.btnEmail).TextImageRelation = TextImageRelation.TextAboveImage;
      ((ButtonBase) this.btnEmail).UseVisualStyleBackColor = true;
      this.TextBox_EmailPersonal.BackColor = Color.White;
      this.TextBox_EmailPersonal.Location = new Point(104, 113);
      this.TextBox_EmailPersonal.MaxLength = 100;
      this.TextBox_EmailPersonal.Multiline = true;
      this.TextBox_EmailPersonal.Name = "TextBox_EmailPersonal";
      this.TextBox_EmailPersonal.Size = new Size(237, 45);
      this.TextBox_EmailPersonal.TabIndex = 238;
      this.AutoScaleDimensions = new SizeF(9f, 20f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.Window;
      this.ClientSize = new Size(349, 294);
      this.ControlBox = false;
      this.Controls.Add((Control) this.btnEmail);
      this.Controls.Add((Control) this.TextBox_EmailPersonal);
      this.Controls.Add((Control) this.txtClientId);
      this.Controls.Add((Control) this.Button_Nombre);
      this.Controls.Add((Control) this.txtRazonSocial);
      this.Controls.Add((Control) this.Label1);
      this.Controls.Add((Control) this.chbEsActivo);
      this.Controls.Add((Control) this.txtPorcentajeDscto);
      this.Controls.Add((Control) this.lblExoneradoImp1);
      this.Controls.Add((Control) this.chbExoneradoImp1);
      this.Controls.Add((Control) this.Label6);
      this.Controls.Add((Control) this.btnPorcentajeDscto);
      this.Controls.Add((Control) this.btnSalir);
      this.Controls.Add((Control) this.btnGuardar);
      this.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.KeyPreview = true;
      this.Margin = new Padding(4, 5, 4, 5);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (FrmClienteOpcAvanzada);
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Cliente - Opciones Avanzadas";
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox chbEsActivo
    {
      get
      {
        return this._chbEsActivo;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chbEsActivo_CheckedChanged);
        CheckBox chbEsActivo1 = this._chbEsActivo;
        if (chbEsActivo1 != null)
          chbEsActivo1.CheckedChanged -= eventHandler;
        this._chbEsActivo = value;
        CheckBox chbEsActivo2 = this._chbEsActivo;
        if (chbEsActivo2 == null)
          return;
        chbEsActivo2.CheckedChanged += eventHandler;
      }
    }

    internal virtual NumericTextBox.NumericTextBox txtPorcentajeDscto { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label lblExoneradoImp1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox chbExoneradoImp1
    {
      get
      {
        return this._chbExoneradoImp1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chbExoneradoImp1_CheckedChanged);
        CheckBox chbExoneradoImp1_1 = this._chbExoneradoImp1;
        if (chbExoneradoImp1_1 != null)
          chbExoneradoImp1_1.CheckedChanged -= eventHandler;
        this._chbExoneradoImp1 = value;
        CheckBox chbExoneradoImp1_2 = this._chbExoneradoImp1;
        if (chbExoneradoImp1_2 == null)
          return;
        chbExoneradoImp1_2.CheckedChanged += eventHandler;
      }
    }

    internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual MyXPButton.MyXPButton btnPorcentajeDscto
    {
      get
      {
        return this._btnPorcentajeDscto;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnPorcentajeDscto_Click);
        MyXPButton.MyXPButton btnPorcentajeDscto1 = this._btnPorcentajeDscto;
        if (btnPorcentajeDscto1 != null)
          ((Control) btnPorcentajeDscto1).Click -= eventHandler;
        this._btnPorcentajeDscto = value;
        MyXPButton.MyXPButton btnPorcentajeDscto2 = this._btnPorcentajeDscto;
        if (btnPorcentajeDscto2 == null)
          return;
        ((Control) btnPorcentajeDscto2).Click += eventHandler;
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

    internal virtual MyXPButton.MyXPButton Button_Nombre { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox txtRazonSocial { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox txtClientId { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual MyXPButton.MyXPButton btnEmail
    {
      get
      {
        return this._btnEmail;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnEmail_Click);
        MyXPButton.MyXPButton btnEmail1 = this._btnEmail;
        if (btnEmail1 != null)
          ((Control) btnEmail1).Click -= eventHandler;
        this._btnEmail = value;
        MyXPButton.MyXPButton btnEmail2 = this._btnEmail;
        if (btnEmail2 == null)
          return;
        ((Control) btnEmail2).Click += eventHandler;
      }
    }

    internal virtual TextBox TextBox_EmailPersonal { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    public FrmClienteOpcAvanzada(BE_TR1_CLIENTS pbeCLIENTS)
    {
      this.Load += new EventHandler(this.FrmClienteOpcAvanzada_Load);
      this.KeyDown += new KeyEventHandler(this.FrmClienteOpcAvanzada_KeyDown);
      this.InitializeComponent();
      this.txtClientId.Text = pbeCLIENTS.get_ClientId();
      this.txtRazonSocial.Text = pbeCLIENTS.get_ClientCompany();
      ((TextBox) this.txtPorcentajeDscto).Text = Conversions.ToString(pbeCLIENTS.get_PerDiscount());
      this.chbEsActivo.Checked = pbeCLIENTS.get_IsActive();
      this.chbExoneradoImp1.Checked = pbeCLIENTS.get_ExoneradoImp1();
      this.TextBox_EmailPersonal.Text = pbeCLIENTS.get_EmailPersonal();
    }

    private void FrmClienteOpcAvanzada_Load(object sender, EventArgs e)
    {
      this.lblExoneradoImp1.Text = "¿Exonerado de " + ModGeneralVar.g_BE_TR1_VARIABLES_B.get_VarTax1() + "?";
      ((Control) this.txtPorcentajeDscto).Focus();
    }

    private void FrmClienteOpcAvanzada_KeyDown(object sender, KeyEventArgs e)
    {
      switch (e.KeyValue)
      {
        case 27:
          ModGeneralVar.g_bol_IsClose = true;
          ModGeneralVar.g_bol_IsReady = false;
          this.Close();
          break;
        case 121:
          this.btnGuardar_Click((object) null, (EventArgs) null);
          break;
      }
    }

    private void chbEsActivo_CheckedChanged(object sender, EventArgs e)
    {
      if (this.chbEsActivo.Checked)
        this.chbEsActivo.Image = (Image) new Bitmap((Image) TriNetRestPOS.My.Resources.Resources.IsObservated_True);
      else
        this.chbEsActivo.Image = (Image) new Bitmap((Image) TriNetRestPOS.My.Resources.Resources.IsObservated_False);
    }

    private void chbExoneradoImp1_CheckedChanged(object sender, EventArgs e)
    {
      if (this.chbExoneradoImp1.Checked)
        this.chbExoneradoImp1.Image = (Image) new Bitmap((Image) TriNetRestPOS.My.Resources.Resources.IsObservated_True);
      else
        this.chbExoneradoImp1.Image = (Image) new Bitmap((Image) TriNetRestPOS.My.Resources.Resources.IsObservated_False);
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
      if (this.ValidarDatos() || !ModGeneralFunctions.MessageMakeAction("¿Seguro de Guardar Conf. Avanzada de Cliente?", false))
        return;
      string _UserId = "";
      if (!ModGeneralFunctions.Validate_Permission(ref _UserId, true, false, "Autorizar Conf. Avanzada de Cliente", false))
      {
        if (ModGeneralVar.g_bol_IsClose)
          return;
        ModGeneralFunctions.MessageOk("¡No Tiene Permiso Válido!");
      }
      else if (ModGeneralFunctions.CadenaToInteger(this.txtClientId.Text) > 0)
      {
        BL_TR1_CLIENTS blTr1Clients = new BL_TR1_CLIENTS();
        BE_TR1_CLIENTS beTr1Clients = new BE_TR1_CLIENTS();
        string str = "";
        beTr1Clients.set_EstabliId(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId());
        beTr1Clients.set_ClientId(this.txtClientId.Text.Trim());
        beTr1Clients.set_PerDiscount(ModGeneralFunctions.CadenaToInteger(((TextBox) this.txtPorcentajeDscto).Text));
        beTr1Clients.set_ExoneradoImp1(this.chbExoneradoImp1.Checked);
        beTr1Clients.set_IsActive(this.chbEsActivo.Checked);
        beTr1Clients.set_UsuMod(ModGeneralVar.g_BE_USERS.get_UserId());
        beTr1Clients.set_UsuAut(_UserId);
        beTr1Clients.set_EmailPersonal(this.TextBox_EmailPersonal.Text);
        string p_Mensaje = blTr1Clients.EditarOpcAvanzadas(beTr1Clients);
        if (p_Mensaje.Equals(StructApp.RESULT_OK))
        {
          ModGeneralFunctions.MessageOk("¡Cliente Editado!");
          ModGeneralVar.g_bol_IsReady = true;
          this.Close();
        }
        else
          ModGeneralFunctions.MessageError_Large(p_Mensaje, true);
        str = (string) null;
      }
      else
      {
        ModGeneralFunctions.MessageOk("¡Cliente Editado!");
        ModGeneralVar.g_bol_IsReady = true;
        this.Close();
      }
    }

    private void btnSalir_Click(object sender, EventArgs e)
    {
      ModGeneralVar.g_bol_IsClose = true;
      ModGeneralVar.g_bol_IsReady = false;
      this.Close();
    }

    private bool ValidarDatos()
    {
      if (this.txtRazonSocial.Text.Trim().Equals(""))
      {
        ModGeneralFunctions.MessageOk("¡Ingrese Razón Social del Cliente!");
        this.txtRazonSocial.Focus();
        return true;
      }
      if (ModGeneralFunctions.CadenaToDouble(((TextBox) this.txtPorcentajeDscto).Text) < 0.0)
      {
        ModGeneralFunctions.MessageOk("¡% Descuento no válido!");
        ((Control) this.txtPorcentajeDscto).Focus();
        return true;
      }
      if (ModGeneralFunctions.CadenaToDouble(((TextBox) this.txtPorcentajeDscto).Text) <= 100.0)
        return false;
      ModGeneralFunctions.MessageOk("¡% Descuento no debe ser mayor a 100!");
      ((TextBox) this.txtPorcentajeDscto).Text = "100";
      ((Control) this.txtPorcentajeDscto).Focus();
      return true;
    }

    internal BE_TR1_CLIENTS ObtenerDatos()
    {
      BE_TR1_CLIENTS beTr1Clients = new BE_TR1_CLIENTS();
      beTr1Clients.set_PerDiscount(checked ((int) Math.Round(ModGeneralFunctions.CadenaToDouble(((TextBox) this.txtPorcentajeDscto).Text))));
      beTr1Clients.set_ExoneradoImp1(this.chbExoneradoImp1.Checked);
      beTr1Clients.set_IsActive(this.chbEsActivo.Checked);
      return beTr1Clients;
    }

    private void btnPorcentajeDscto_Click(object sender, EventArgs e)
    {
      ModGeneralFunctions.NumberKeyBoard("INGRESE % DE DESCUENTO", false);
      if (ModGeneralFunctions.CadenaToDouble(ModGeneralVar.g_str_InputValue) >= 0.0 & ModGeneralFunctions.CadenaToDouble(ModGeneralVar.g_str_InputValue) <= 100.0)
      {
        ((TextBox) this.txtPorcentajeDscto).Text = ModGeneralVar.g_str_InputValue;
      }
      else
      {
        ModGeneralFunctions.MessageOk("¡% Descuento no válido!");
        ((TextBox) this.txtPorcentajeDscto).Text = Conversions.ToString(0);
      }
    }

    private void btnEmail_Click(object sender, EventArgs e)
    {
      TextBox boxEmailPersonal;
      string text = (boxEmailPersonal = this.TextBox_EmailPersonal).Text;
      ModGeneralFunctions.TextKeyBoard("Ingrese Email", ref text);
      boxEmailPersonal.Text = text;
      if (!ModGeneralVar.g_bol_IsReady)
        return;
      this.TextBox_EmailPersonal.Text = ModGeneralVar.g_str_InputValue;
    }
  }
}
