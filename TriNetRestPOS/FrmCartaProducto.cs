// Decompiled with JetBrains decompiler
// Type: TriNetRestPOS.FrmCartaProducto
// Assembly: TriNetRestPOS, Version=5.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 43377352-E952-4AC1-9BA6-CCBE4AE5F575
// Assembly location: C:\log\TriNetRestPOS.exe

using Microsoft.VisualBasic.CompilerServices;
using MyXPButton;
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
  public class FrmCartaProducto : Form
  {
    private IContainer components;
    private MyXPButton.MyXPButton[] btnHallButtons;
    private short shtCountHallCollection;

    public FrmCartaProducto()
    {
      this.KeyDown += new KeyEventHandler(this.FrmCartaProducto_KeyDown);
      this.Load += new EventHandler(this.FrmCartaProducto_Load);
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FrmCartaProducto));
      this.gbSalones = new GroupBox();
      this.gbCarta = new GroupBox();
      this.Label6 = new Label();
      this.Label7 = new Label();
      this.lblSalonNombre = new Label();
      this.Label4 = new Label();
      this.Label5 = new Label();
      this.lblCartaActual = new Label();
      this.Label2 = new Label();
      this.Label1 = new Label();
      this.cboCarta = new ComboBox();
      this.txtCartaId = new TextBox();
      this.txtSalonId = new TextBox();
      this.btnSalir = new Button();
      this.btnGuardar = new Button();
      this.gbCarta.SuspendLayout();
      this.SuspendLayout();
      this.gbSalones.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.gbSalones.ForeColor = Color.Red;
      this.gbSalones.Location = new Point(13, 6);
      this.gbSalones.Name = "gbSalones";
      this.gbSalones.Size = new Size(884, 190);
      this.gbSalones.TabIndex = 21;
      this.gbSalones.TabStop = false;
      this.gbSalones.Text = "SALÓN";
      this.gbCarta.Controls.Add((Control) this.Label6);
      this.gbCarta.Controls.Add((Control) this.Label7);
      this.gbCarta.Controls.Add((Control) this.lblSalonNombre);
      this.gbCarta.Controls.Add((Control) this.Label4);
      this.gbCarta.Controls.Add((Control) this.Label5);
      this.gbCarta.Controls.Add((Control) this.lblCartaActual);
      this.gbCarta.Controls.Add((Control) this.Label2);
      this.gbCarta.Controls.Add((Control) this.Label1);
      this.gbCarta.Controls.Add((Control) this.cboCarta);
      this.gbCarta.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.gbCarta.ForeColor = Color.MediumBlue;
      this.gbCarta.Location = new Point(12, 197);
      this.gbCarta.Name = "gbCarta";
      this.gbCarta.Size = new Size(884, 130);
      this.gbCarta.TabIndex = 22;
      this.gbCarta.TabStop = false;
      this.Label6.AutoSize = true;
      this.Label6.ForeColor = Color.Red;
      this.Label6.Location = new Point(139, 51);
      this.Label6.Name = "Label6";
      this.Label6.Size = new Size(15, 20);
      this.Label6.TabIndex = 8;
      this.Label6.Text = ":";
      this.Label7.AutoSize = true;
      this.Label7.ForeColor = Color.Red;
      this.Label7.Location = new Point(16, 51);
      this.Label7.Name = "Label7";
      this.Label7.Size = new Size(117, 20);
      this.Label7.TabIndex = 7;
      this.Label7.Text = "CARTA ACTUAL";
      this.lblSalonNombre.AutoSize = true;
      this.lblSalonNombre.Font = new Font("Trebuchet MS", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblSalonNombre.ForeColor = Color.Black;
      this.lblSalonNombre.Location = new Point(247, 13);
      this.lblSalonNombre.Name = "lblSalonNombre";
      this.lblSalonNombre.Size = new Size(153, 24);
      this.lblSalonNombre.TabIndex = 6;
      this.lblSalonNombre.Text = "« SELECCIONE »";
      this.Label4.AutoSize = true;
      this.Label4.ForeColor = Color.Red;
      this.Label4.Location = new Point(226, 17);
      this.Label4.Name = "Label4";
      this.Label4.Size = new Size(15, 20);
      this.Label4.TabIndex = 5;
      this.Label4.Text = ":";
      this.Label5.AutoSize = true;
      this.Label5.ForeColor = Color.MediumBlue;
      this.Label5.Location = new Point(139, 91);
      this.Label5.Name = "Label5";
      this.Label5.Size = new Size(15, 20);
      this.Label5.TabIndex = 4;
      this.Label5.Text = ":";
      this.lblCartaActual.BackColor = Color.FromArgb((int) byte.MaxValue, 240, 140);
      this.lblCartaActual.Font = new Font("Trebuchet MS", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblCartaActual.ForeColor = Color.Black;
      this.lblCartaActual.Location = new Point(157, 47);
      this.lblCartaActual.Name = "lblCartaActual";
      this.lblCartaActual.Size = new Size(708, 28);
      this.lblCartaActual.TabIndex = 3;
      this.lblCartaActual.Text = "« SELECCIONE »";
      this.Label2.AutoSize = true;
      this.Label2.ForeColor = Color.Red;
      this.Label2.Location = new Point(169, 17);
      this.Label2.Name = "Label2";
      this.Label2.Size = new Size(56, 20);
      this.Label2.TabIndex = 2;
      this.Label2.Text = "SALÓN";
      this.Label1.AutoSize = true;
      this.Label1.ForeColor = Color.MediumBlue;
      this.Label1.Location = new Point(16, 91);
      this.Label1.Name = "Label1";
      this.Label1.Size = new Size(110, 20);
      this.Label1.TabIndex = 1;
      this.Label1.Text = "ELEGIR CARTA";
      this.cboCarta.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cboCarta.Font = new Font("Trebuchet MS", 18f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cboCarta.FormattingEnabled = true;
      this.cboCarta.Location = new Point(157, 81);
      this.cboCarta.Name = "cboCarta";
      this.cboCarta.Size = new Size(708, 37);
      this.cboCarta.TabIndex = 0;
      this.txtCartaId.BackColor = Color.FromArgb((int) byte.MaxValue, 240, 140);
      this.txtCartaId.Font = new Font("Tahoma", 12.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtCartaId.Location = new Point(590, 351);
      this.txtCartaId.Name = "txtCartaId";
      this.txtCartaId.Size = new Size(15, 28);
      this.txtCartaId.TabIndex = 216;
      this.txtCartaId.Visible = false;
      this.txtSalonId.BackColor = Color.FromArgb((int) byte.MaxValue, 240, 140);
      this.txtSalonId.Font = new Font("Tahoma", 12.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtSalonId.Location = new Point(611, 351);
      this.txtSalonId.Name = "txtSalonId";
      this.txtSalonId.Size = new Size(15, 28);
      this.txtSalonId.TabIndex = 217;
      this.txtSalonId.Visible = false;
      this.btnSalir.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnSalir.ForeColor = Color.MediumBlue;
      this.btnSalir.Image = (Image) TriNetRestPOS.My.Resources.Resources.i_Close;
      this.btnSalir.Location = new Point(473, 335);
      this.btnSalir.Margin = new Padding(4, 5, 4, 5);
      this.btnSalir.Name = "btnSalir";
      this.btnSalir.Size = new Size(100, 60);
      this.btnSalir.TabIndex = 219;
      this.btnSalir.Text = "Salir";
      this.btnSalir.TextImageRelation = TextImageRelation.TextAboveImage;
      this.btnSalir.UseVisualStyleBackColor = true;
      this.btnGuardar.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnGuardar.ForeColor = Color.MediumBlue;
      this.btnGuardar.Image = (Image) TriNetRestPOS.My.Resources.Resources.i_Ready;
      this.btnGuardar.Location = new Point(365, 335);
      this.btnGuardar.Margin = new Padding(4, 5, 4, 5);
      this.btnGuardar.Name = "btnGuardar";
      this.btnGuardar.Size = new Size(100, 60);
      this.btnGuardar.TabIndex = 218;
      this.btnGuardar.Text = "Grabar";
      this.btnGuardar.TextImageRelation = TextImageRelation.TextAboveImage;
      this.btnGuardar.UseVisualStyleBackColor = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.Window;
      this.ClientSize = new Size(909, 402);
      this.ControlBox = false;
      this.Controls.Add((Control) this.btnSalir);
      this.Controls.Add((Control) this.btnGuardar);
      this.Controls.Add((Control) this.txtSalonId);
      this.Controls.Add((Control) this.txtCartaId);
      this.Controls.Add((Control) this.gbCarta);
      this.Controls.Add((Control) this.gbSalones);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (FrmCartaProducto);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Configurar Carta";
      this.gbCarta.ResumeLayout(false);
      this.gbCarta.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    internal virtual GroupBox gbSalones { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual GroupBox gbCarta { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox cboCarta { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label lblCartaActual { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox txtCartaId { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox txtSalonId { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label lblSalonNombre { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

    private void FrmCartaProducto_KeyDown(object sender, KeyEventArgs e)
    {
      if (!e.KeyValue.Equals(27))
        return;
      ModGeneralVar.g_bol_IsReady = false;
      this.Close();
    }

    private void FrmCartaProducto_Load(object sender, EventArgs e)
    {
      this.CreateButtonSalonesArray();
      this.CargarCartasxSalon(0);
    }

    private void CreateButtonSalonesArray()
    {
      List<BE_TR1_HALLS> beTr1HallsList = new BL_TR1_HALLS().ListBasic();
      this.shtCountHallCollection = checked ((short) beTr1HallsList.Count);
      this.btnHallButtons = new MyXPButton.MyXPButton[checked ((int) this.shtCountHallCollection + 1)];
      short num1 = 0;
      short num2 = 25;
      short num3 = checked ((short) ((int) this.shtCountHallCollection - 1));
      short num4 = 0;
      while ((int) num4 <= (int) num3)
      {
        short num5 = checked ((short) (5 + (int) num1 * 109));
        this.btnHallButtons[(int) num4] = new MyXPButton.MyXPButton();
        MyXPButton.MyXPButton btnHallButton = this.btnHallButtons[(int) num4];
        if ((int) this.shtCountHallCollection > (int) num4)
        {
          ((ButtonBase) btnHallButton).Text = beTr1HallsList[(int) num4].get_HallDes();
          ((Control) btnHallButton).Tag = (object) beTr1HallsList[(int) num4].get_HallId();
        }
        ((Control) btnHallButton).Font = new Font("Trebuchet MS", 11f, FontStyle.Bold);
        ((Control) btnHallButton).ForeColor = Color.MediumBlue;
        ((Control) btnHallButton).Location = new Point((int) num5, (int) num2);
        ((Control) btnHallButton).Size = new Size(109, 80);
        btnHallButton.set_BtnStyle((emunType.XPStyle) 2);
        ((Control) btnHallButton).Click += new EventHandler(this.btnSalon_Click);
        checked { ++num1; }
        if (num1 == (short) 8)
        {
          checked { num2 += (short) 80; }
          num1 = (short) 0;
        }
        checked { ++num4; }
      }
      this.gbSalones.Controls.AddRange((Control[]) this.btnHallButtons);
    }

    private void CargarCartasxSalon(int pintSalonId)
    {
      if (pintSalonId == 0)
      {
        this.cboCarta.Items.Add((object) "« SELECCIONE »");
        this.cboCarta.SelectedIndex = 0;
      }
      else
      {
        List<BE_TR1_CARTA> beTr1CartaList = new BL_TR1_CARTA().ListarxSalon(pintSalonId);
        if (beTr1CartaList != null)
          beTr1CartaList.Insert(0, new BE_TR1_CARTA(0, "« SELECCIONE »"));
        this.cboCarta.ValueMember = "CartaId";
        this.cboCarta.DisplayMember = "Nombre";
        this.cboCarta.DataSource = (object) beTr1CartaList;
        this.cboCarta.SelectedIndex = 0;
      }
    }

    private void CargarCartaActualxSalon(int pintSalonId)
    {
      if (pintSalonId == 0)
      {
        this.lblCartaActual.Text = "« SELECCIONE »";
      }
      else
      {
        BE_TR1_CARTA beTr1Carta = new BL_TR1_CARTA().ObtenerxSalon(pintSalonId);
        if (beTr1Carta != null)
        {
          this.txtCartaId.Text = Conversions.ToString(beTr1Carta.get_CartaId());
          this.lblCartaActual.Text = beTr1Carta.get_Nombre();
        }
      }
    }

    private void btnSalon_Click(object sender, EventArgs e)
    {
      int integer = ModGeneralFunctions.CadenaToInteger(Conversions.ToString(NewLateBinding.LateGet(sender, (System.Type) null, "Tag", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)));
      string str = ModGeneralFunctions.CadenaIfNothing(Conversions.ToString(NewLateBinding.LateGet(sender, (System.Type) null, "Text", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)));
      int num = checked (this.btnHallButtons.Length - 2);
      int index = 0;
      while (index <= num)
      {
        this.btnHallButtons[index].set_BtnStyle((emunType.XPStyle) 2);
        checked { ++index; }
      }
      NewLateBinding.LateSet(sender, (System.Type) null, "BtnStyle", new object[1]
      {
        (object) (emunType.XPStyle) 1
      }, (string[]) null, (System.Type[]) null);
      this.txtSalonId.Text = Conversions.ToString(integer);
      this.lblSalonNombre.Text = str;
      this.CargarCartaActualxSalon(integer);
      this.CargarCartasxSalon(integer);
    }

    private void btnSalir_Click(object sender, EventArgs e)
    {
      ModGeneralVar.g_bol_IsReady = false;
      this.Close();
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
      this.GuardarCartaSalon();
    }

    private void GuardarCartaSalon()
    {
      if (this.cboCarta.SelectedIndex == 0)
      {
        ModGeneralFunctions.MessageError("¡Seleccione una Carta!", true);
        this.cboCarta.Focus();
      }
      else if (ModGeneralFunctions.CadenaToInteger(this.txtCartaId.Text) == ModGeneralFunctions.CadenaToInteger(Conversions.ToString(this.cboCarta.SelectedValue)))
      {
        ModGeneralFunctions.MessageError("¡Seleccione una Carta diferente!", true);
        this.cboCarta.Focus();
      }
      else
      {
        if (!ModGeneralFunctions.MessageMakeAction("¿Seguro de guardar la configuración?", false))
          return;
        BL_TR1_CARTA blTr1Carta = new BL_TR1_CARTA();
        BE_TR1_CARTA_SALON_DET tr1CartaSalonDet = new BE_TR1_CARTA_SALON_DET();
        tr1CartaSalonDet.set_LocalId(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId());
        tr1CartaSalonDet.set_CartaId(ModGeneralFunctions.CadenaToInteger(Conversions.ToString(this.cboCarta.SelectedValue)));
        tr1CartaSalonDet.set_SalonId(ModGeneralFunctions.CadenaToInteger(this.txtSalonId.Text));
        if (ModGeneralVar.g_BE_TR1_TURNS != null)
          tr1CartaSalonDet.set_TurnoId(ModGeneralVar.g_BE_TR1_TURNS.get_TurnId());
        else
          tr1CartaSalonDet.set_TurnoId("");
        tr1CartaSalonDet.set_Usuario(ModGeneralVar.g_BE_USERS.get_UserId());
        if (blTr1Carta.InsertarSalonDetalle(tr1CartaSalonDet).Equals(StructApp.RESULT_OK))
        {
          this.CargarCartaActualxSalon(ModGeneralFunctions.CadenaToInteger(this.txtSalonId.Text));
          this.cboCarta.SelectedIndex = 0;
        }
      }
    }
  }
}
