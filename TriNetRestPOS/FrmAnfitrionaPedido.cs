// Decompiled with JetBrains decompiler
// Type: TriNetRestPOS.FrmAnfitrionaPedido
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
  public class FrmAnfitrionaPedido : Form
  {
    private IContainer components;
    private short TipoOperacion;
    private string str_Result;
    private List<BE_TR1_ANFITRIONA_PEDIDO> oLista;
    private string _AnfitrionaIdEdita;

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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FrmAnfitrionaPedido));
      this.dgrvData = new DataGridView();
      this.txtAnfitrionaId = new TextBox();
      this.txtAnfitrionaDes = new TextBox();
      this.btnBuscarAnfitriona = new Button();
      this.Label18 = new Label();
      this.Label19 = new Label();
      this.Label1 = new Label();
      this.Label2 = new Label();
      this.lblTotalPedido = new Label();
      this.Button_Delete = new Button();
      this.Button_Update = new Button();
      this.Button_New = new Button();
      this.Button_Agregar = new Button();
      this.Button_CloseTab = new Button();
      this.TextBox_PedidoId = new TextBox();
      ((ISupportInitialize) this.dgrvData).BeginInit();
      this.SuspendLayout();
      this.dgrvData.BorderStyle = BorderStyle.Fixed3D;
      this.dgrvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgrvData.Location = new Point(-1, 87);
      this.dgrvData.MultiSelect = false;
      this.dgrvData.Name = "dgrvData";
      this.dgrvData.ScrollBars = ScrollBars.None;
      this.dgrvData.ShowRowErrors = false;
      this.dgrvData.Size = new Size(419, 257);
      this.dgrvData.TabIndex = 2;
      this.txtAnfitrionaId.BackColor = Color.FromArgb((int) byte.MaxValue, 240, 144);
      this.txtAnfitrionaId.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtAnfitrionaId.Location = new Point(42, 35);
      this.txtAnfitrionaId.Name = "txtAnfitrionaId";
      this.txtAnfitrionaId.ReadOnly = true;
      this.txtAnfitrionaId.Size = new Size(50, 25);
      this.txtAnfitrionaId.TabIndex = 252;
      this.txtAnfitrionaId.TextAlign = HorizontalAlignment.Center;
      this.txtAnfitrionaId.Visible = false;
      this.txtAnfitrionaDes.BackColor = Color.LightGray;
      this.txtAnfitrionaDes.BorderStyle = BorderStyle.FixedSingle;
      this.txtAnfitrionaDes.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtAnfitrionaDes.Location = new Point(102, 19);
      this.txtAnfitrionaDes.Multiline = true;
      this.txtAnfitrionaDes.Name = "txtAnfitrionaDes";
      this.txtAnfitrionaDes.ReadOnly = true;
      this.txtAnfitrionaDes.Size = new Size(314, 25);
      this.txtAnfitrionaDes.TabIndex = 250;
      this.btnBuscarAnfitriona.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.boto_oc_azul_icono;
      this.btnBuscarAnfitriona.FlatStyle = FlatStyle.Flat;
      this.btnBuscarAnfitriona.ForeColor = Color.WhiteSmoke;
      this.btnBuscarAnfitriona.Image = (Image) TriNetRestPOS.My.Resources.Resources.cliente_icon;
      this.btnBuscarAnfitriona.Location = new Point(422, 0);
      this.btnBuscarAnfitriona.Name = "btnBuscarAnfitriona";
      this.btnBuscarAnfitriona.Size = new Size(70, 65);
      this.btnBuscarAnfitriona.TabIndex = 251;
      this.btnBuscarAnfitriona.UseVisualStyleBackColor = true;
      this.Label18.AutoSize = true;
      this.Label18.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label18.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label18.Location = new Point(81, 22);
      this.Label18.Name = "Label18";
      this.Label18.Size = new Size(11, 16);
      this.Label18.TabIndex = 254;
      this.Label18.Text = ":";
      this.Label19.AutoSize = true;
      this.Label19.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label19.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label19.Location = new Point(12, 22);
      this.Label19.Name = "Label19";
      this.Label19.Size = new Size(63, 16);
      this.Label19.TabIndex = 253;
      this.Label19.Text = "Anfitriona";
      this.Label1.AutoSize = true;
      this.Label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label1.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label1.Location = new Point(305, 59);
      this.Label1.Name = "Label1";
      this.Label1.Size = new Size(11, 16);
      this.Label1.TabIndex = 256;
      this.Label1.Text = ":";
      this.Label2.AutoSize = true;
      this.Label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label2.ForeColor = Color.FromArgb(150, 150, 150);
      this.Label2.Location = new Point(265, 59);
      this.Label2.Name = "Label2";
      this.Label2.Size = new Size(39, 16);
      this.Label2.TabIndex = (int) byte.MaxValue;
      this.Label2.Text = "Total";
      this.lblTotalPedido.BackColor = Color.Transparent;
      this.lblTotalPedido.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblTotalPedido.ForeColor = Color.FromArgb(0, 192, 0);
      this.lblTotalPedido.Location = new Point(315, 48);
      this.lblTotalPedido.Name = "lblTotalPedido";
      this.lblTotalPedido.Size = new Size(101, 34);
      this.lblTotalPedido.TabIndex = 257;
      this.lblTotalPedido.Text = "0.00";
      this.lblTotalPedido.TextAlign = ContentAlignment.MiddleRight;
      this.Button_Delete.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.boton_cuadrado_rojo;
      this.Button_Delete.FlatStyle = FlatStyle.Flat;
      this.Button_Delete.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button_Delete.ForeColor = Color.WhiteSmoke;
      this.Button_Delete.Image = (Image) TriNetRestPOS.My.Resources.Resources.eliminar_icono;
      this.Button_Delete.ImageAlign = ContentAlignment.TopCenter;
      this.Button_Delete.Location = new Point(422, 278);
      this.Button_Delete.Name = "Button_Delete";
      this.Button_Delete.Padding = new Padding(0, 5, 0, 5);
      this.Button_Delete.RightToLeft = RightToLeft.Yes;
      this.Button_Delete.Size = new Size(69, 65);
      this.Button_Delete.TabIndex = 260;
      this.Button_Delete.Text = "Eliminar";
      this.Button_Delete.TextAlign = ContentAlignment.BottomCenter;
      this.Button_Delete.UseVisualStyleBackColor = true;
      this.Button_Update.BackgroundImage = (Image) componentResourceManager.GetObject("Button_Update.BackgroundImage");
      this.Button_Update.FlatStyle = FlatStyle.Flat;
      this.Button_Update.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button_Update.ForeColor = Color.WhiteSmoke;
      this.Button_Update.Image = (Image) TriNetRestPOS.My.Resources.Resources.icono_editar;
      this.Button_Update.ImageAlign = ContentAlignment.TopCenter;
      this.Button_Update.Location = new Point(422, 149);
      this.Button_Update.Name = "Button_Update";
      this.Button_Update.Padding = new Padding(0, 5, 0, 5);
      this.Button_Update.Size = new Size(69, 65);
      this.Button_Update.TabIndex = 259;
      this.Button_Update.Text = "&Editar";
      this.Button_Update.TextAlign = ContentAlignment.BottomCenter;
      this.Button_Update.UseVisualStyleBackColor = true;
      this.Button_New.BackgroundImage = (Image) componentResourceManager.GetObject("Button_New.BackgroundImage");
      this.Button_New.FlatStyle = FlatStyle.Flat;
      this.Button_New.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button_New.ForeColor = Color.WhiteSmoke;
      this.Button_New.Image = (Image) TriNetRestPOS.My.Resources.Resources.icono_nuevo;
      this.Button_New.ImageAlign = ContentAlignment.TopCenter;
      this.Button_New.Location = new Point(422, 85);
      this.Button_New.Name = "Button_New";
      this.Button_New.Padding = new Padding(0, 5, 0, 5);
      this.Button_New.Size = new Size(69, 65);
      this.Button_New.TabIndex = 258;
      this.Button_New.Text = "&Nuevo";
      this.Button_New.TextAlign = ContentAlignment.BottomCenter;
      this.Button_New.UseVisualStyleBackColor = true;
      this.Button_Agregar.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.boto_oc_verde_icono;
      this.Button_Agregar.FlatStyle = FlatStyle.Flat;
      this.Button_Agregar.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button_Agregar.ForeColor = Color.WhiteSmoke;
      this.Button_Agregar.Image = (Image) TriNetRestPOS.My.Resources.Resources.suma_oc_icono;
      this.Button_Agregar.ImageAlign = ContentAlignment.TopCenter;
      this.Button_Agregar.Location = new Point(422, 213);
      this.Button_Agregar.Name = "Button_Agregar";
      this.Button_Agregar.Padding = new Padding(0, 7, 0, 5);
      this.Button_Agregar.RightToLeft = RightToLeft.Yes;
      this.Button_Agregar.Size = new Size(69, 65);
      this.Button_Agregar.TabIndex = 261;
      this.Button_Agregar.Text = "Agregar";
      this.Button_Agregar.TextAlign = ContentAlignment.BottomCenter;
      this.Button_Agregar.UseVisualStyleBackColor = true;
      this.Button_CloseTab.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.BotonRojo;
      this.Button_CloseTab.FlatStyle = FlatStyle.Flat;
      this.Button_CloseTab.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button_CloseTab.ForeColor = Color.WhiteSmoke;
      this.Button_CloseTab.Image = (Image) TriNetRestPOS.My.Resources.Resources.salir;
      this.Button_CloseTab.ImageAlign = ContentAlignment.TopCenter;
      this.Button_CloseTab.Location = new Point(190, 346);
      this.Button_CloseTab.Name = "Button_CloseTab";
      this.Button_CloseTab.Padding = new Padding(0, 5, 0, 5);
      this.Button_CloseTab.Size = new Size(114, 60);
      this.Button_CloseTab.TabIndex = 262;
      this.Button_CloseTab.Text = "Atrás";
      this.Button_CloseTab.TextAlign = ContentAlignment.BottomCenter;
      this.Button_CloseTab.UseVisualStyleBackColor = true;
      this.TextBox_PedidoId.BackColor = Color.FromArgb((int) byte.MaxValue, 240, 144);
      this.TextBox_PedidoId.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.TextBox_PedidoId.Location = new Point(102, 59);
      this.TextBox_PedidoId.Name = "TextBox_PedidoId";
      this.TextBox_PedidoId.ReadOnly = true;
      this.TextBox_PedidoId.Size = new Size(50, 25);
      this.TextBox_PedidoId.TabIndex = 263;
      this.TextBox_PedidoId.TextAlign = HorizontalAlignment.Center;
      this.TextBox_PedidoId.Visible = false;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(494, 407);
      this.Controls.Add((Control) this.TextBox_PedidoId);
      this.Controls.Add((Control) this.Button_CloseTab);
      this.Controls.Add((Control) this.Button_Agregar);
      this.Controls.Add((Control) this.Button_Delete);
      this.Controls.Add((Control) this.Button_New);
      this.Controls.Add((Control) this.lblTotalPedido);
      this.Controls.Add((Control) this.Label1);
      this.Controls.Add((Control) this.Label2);
      this.Controls.Add((Control) this.txtAnfitrionaId);
      this.Controls.Add((Control) this.txtAnfitrionaDes);
      this.Controls.Add((Control) this.btnBuscarAnfitriona);
      this.Controls.Add((Control) this.Label18);
      this.Controls.Add((Control) this.Label19);
      this.Controls.Add((Control) this.dgrvData);
      this.Controls.Add((Control) this.Button_Update);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (FrmAnfitrionaPedido);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Selecciona Anfitriona x Pedido";
      ((ISupportInitialize) this.dgrvData).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    internal virtual DataGridView dgrvData
    {
      get
      {
        return this._dgrvData;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DataGridViewCellEventHandler cellEventHandler1 = new DataGridViewCellEventHandler(this.dgrvData_CellDoubleClick);
        DataGridViewCellEventHandler cellEventHandler2 = new DataGridViewCellEventHandler(this.dgrvData_CellClick);
        DataGridView dgrvData1 = this._dgrvData;
        if (dgrvData1 != null)
        {
          dgrvData1.CellDoubleClick -= cellEventHandler1;
          dgrvData1.CellClick -= cellEventHandler2;
        }
        this._dgrvData = value;
        DataGridView dgrvData2 = this._dgrvData;
        if (dgrvData2 == null)
          return;
        dgrvData2.CellDoubleClick += cellEventHandler1;
        dgrvData2.CellClick += cellEventHandler2;
      }
    }

    internal virtual TextBox txtAnfitrionaId { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox txtAnfitrionaDes { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button btnBuscarAnfitriona
    {
      get
      {
        return this._btnBuscarAnfitriona;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnBuscarProducto_Click);
        Button buscarAnfitriona1 = this._btnBuscarAnfitriona;
        if (buscarAnfitriona1 != null)
          buscarAnfitriona1.Click -= eventHandler;
        this._btnBuscarAnfitriona = value;
        Button buscarAnfitriona2 = this._btnBuscarAnfitriona;
        if (buscarAnfitriona2 == null)
          return;
        buscarAnfitriona2.Click += eventHandler;
      }
    }

    internal virtual Label Label18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label lblTotalPedido { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button_Delete
    {
      get
      {
        return this._Button_Delete;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_Delete_Click);
        Button buttonDelete1 = this._Button_Delete;
        if (buttonDelete1 != null)
          buttonDelete1.Click -= eventHandler;
        this._Button_Delete = value;
        Button buttonDelete2 = this._Button_Delete;
        if (buttonDelete2 == null)
          return;
        buttonDelete2.Click += eventHandler;
      }
    }

    internal virtual Button Button_Update
    {
      get
      {
        return this._Button_Update;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_Update_Click);
        Button buttonUpdate1 = this._Button_Update;
        if (buttonUpdate1 != null)
          buttonUpdate1.Click -= eventHandler;
        this._Button_Update = value;
        Button buttonUpdate2 = this._Button_Update;
        if (buttonUpdate2 == null)
          return;
        buttonUpdate2.Click += eventHandler;
      }
    }

    internal virtual Button Button_New
    {
      get
      {
        return this._Button_New;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_New_Click);
        Button buttonNew1 = this._Button_New;
        if (buttonNew1 != null)
          buttonNew1.Click -= eventHandler;
        this._Button_New = value;
        Button buttonNew2 = this._Button_New;
        if (buttonNew2 == null)
          return;
        buttonNew2.Click += eventHandler;
      }
    }

    internal virtual Button Button_Agregar
    {
      get
      {
        return this._Button_Agregar;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_Agregar_Click);
        Button buttonAgregar1 = this._Button_Agregar;
        if (buttonAgregar1 != null)
          buttonAgregar1.Click -= eventHandler;
        this._Button_Agregar = value;
        Button buttonAgregar2 = this._Button_Agregar;
        if (buttonAgregar2 == null)
          return;
        buttonAgregar2.Click += eventHandler;
      }
    }

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

    internal virtual TextBox TextBox_PedidoId { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    public FrmAnfitrionaPedido(string pstrPedidoId, double pdblTotal)
    {
      this.Load += new EventHandler(this.FrmAnfitrionaPedido_Load);
      this._AnfitrionaIdEdita = "";
      this.InitializeComponent();
      this.lblTotalPedido.Text = ModGeneralFunctions.CadenaToDoubleFormateado(Conversions.ToString(pdblTotal), 2);
      this.TextBox_PedidoId.Text = pstrPedidoId;
    }

    private void Limpiar()
    {
      this.txtAnfitrionaId.Text = "";
      this.txtAnfitrionaDes.Text = "";
    }

    private void SetUpDataGridView()
    {
      ModGeneralFunctions.SetUpDataGridViewBasicNuevo(this.dgrvData);
      this.dgrvData.Columns.Add("AnfitrionaId", "Código");
      ModGeneralFunctions.SetUp_TextBoxColumn1((DataGridViewTextBoxColumn) this.dgrvData.Columns[0], "AnfitrionaId", (short) 70, "", false, DataGridViewContentAlignment.MiddleLeft, true);
      this.dgrvData.Columns.Add("AnfitrionaDes", "Anfitriona");
      ModGeneralFunctions.SetUp_TextBoxColumn1((DataGridViewTextBoxColumn) this.dgrvData.Columns[1], "AnfitrionaDes", (short) 380, "", true, DataGridViewContentAlignment.MiddleLeft, true);
      this.dgrvData.Columns.Add("PedidoId", "PedidoId");
      ModGeneralFunctions.SetUp_TextBoxColumn1((DataGridViewTextBoxColumn) this.dgrvData.Columns[2], "PedidoId", (short) 180, "", false, DataGridViewContentAlignment.MiddleLeft, true);
    }

    private void LoadData(string ptsrPedidoId)
    {
      BL_TR1_ANFITRIONA_PEDIDO anfitrionaPedido = new BL_TR1_ANFITRIONA_PEDIDO();
      this.oLista = new List<BE_TR1_ANFITRIONA_PEDIDO>();
      this.oLista = anfitrionaPedido.ListaxPedido(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId(), ptsrPedidoId);
      this.dgrvData.DataSource = (object) this.oLista;
    }

    private bool ValidateData()
    {
      if (Operators.CompareString(this.txtAnfitrionaId.Text, "", false) != 0)
        return true;
      ModGeneralFunctions.MessageOk1("Ingrese Anfitriona");
      this.btnBuscarAnfitriona.Focus();
      return false;
    }

    private void MakeOperation()
    {
      BL_TR1_ANFITRIONA_PEDIDO anfitrionaPedido1 = new BL_TR1_ANFITRIONA_PEDIDO();
      BE_TR1_ANFITRIONA_PEDIDO anfitrionaPedido2;
      if (this.TipoOperacion == (short) 1)
      {
        if (!this.ValidateData())
          return;
        int num = checked (this.oLista.Count - 1);
        int index = 0;
        while (index <= num)
        {
          if ((double) this.oLista[index].get_AnfitrionaId() == Conversions.ToDouble(this.txtAnfitrionaId.Text))
          {
            ModGeneralFunctions.MessageOk1("Anfitriona ya fue Asignada!!");
            return;
          }
          checked { ++index; }
        }
        BE_TR1_ANFITRIONA_CANTIDAD anfitrionaCantidad1 = new BE_TR1_ANFITRIONA_CANTIDAD();
        BE_TR1_ANFITRIONA_CANTIDAD anfitrionaCantidad2 = new BL_TR1_ANFITRIONA_CANTIDAD().DatosxMonto(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId(), ModGeneralFunctions.CadenaToDouble(this.lblTotalPedido.Text));
        short rowCount = checked ((short) this.dgrvData.RowCount);
        if (anfitrionaCantidad2 != null && (int) rowCount >= anfitrionaCantidad2.get_CantAnfitriona())
        {
          ModGeneralFunctions.MessageOk1("No se puede agregar Anfitrionas, llego a su limite!!");
          return;
        }
        if (ModGeneralFunctions.MessageMakeAction1("¿Esta Seguro de Grabar el Registro?", false))
        {
          BE_TR1_ANFITRIONA_PEDIDO anfitrionaPedido3 = new BE_TR1_ANFITRIONA_PEDIDO();
          anfitrionaPedido3.set_LocalId(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId());
          anfitrionaPedido3.set_AnfPedidoId(0);
          anfitrionaPedido3.set_AnfitrionaId(Conversions.ToInteger(this.txtAnfitrionaId.Text));
          anfitrionaPedido3.set_PedidoId(this.TextBox_PedidoId.Text);
          anfitrionaPedido3.set_UsuReg(ModGeneralVar.g_BE_USERS.get_UserId());
          this.str_Result = anfitrionaPedido1.Insertar(anfitrionaPedido3);
          if (this.str_Result.Equals(StructApp.RESULT_OK))
          {
            this.LoadData(this.TextBox_PedidoId.Text);
            this.Limpiar();
            this.TipoOperacion = (short) 1;
          }
          else
            ModGeneralFunctions.MessageError_Large(this.str_Result, true);
          anfitrionaPedido2 = (BE_TR1_ANFITRIONA_PEDIDO) null;
        }
        anfitrionaCantidad1 = (BE_TR1_ANFITRIONA_CANTIDAD) null;
      }
      else if (this.TipoOperacion == (short) 2)
      {
        if (!this.ValidateData())
          return;
        if (ModGeneralFunctions.MessageMakeAction1("¿Esta Seguro de Editar el Registro?", false))
        {
          BE_TR1_ANFITRIONA_PEDIDO anfitrionaPedido3 = new BE_TR1_ANFITRIONA_PEDIDO();
          anfitrionaPedido3.set_LocalId(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId());
          anfitrionaPedido3.set_AnfPedidoId(0);
          anfitrionaPedido3.set_AnfitrionaId(Conversions.ToInteger(this._AnfitrionaIdEdita));
          anfitrionaPedido3.set_PedidoId(this.TextBox_PedidoId.Text);
          anfitrionaPedido3.set_UsuReg(ModGeneralVar.g_BE_USERS.get_UserId());
          this.str_Result = anfitrionaPedido1.Eliminar(anfitrionaPedido3);
          anfitrionaPedido3.set_AnfitrionaId(Conversions.ToInteger(this.txtAnfitrionaId.Text));
          this.str_Result = anfitrionaPedido1.Insertar(anfitrionaPedido3);
          if (this.str_Result.Equals(StructApp.RESULT_OK))
          {
            this.LoadData(this.TextBox_PedidoId.Text);
            this.Limpiar();
            this.TipoOperacion = (short) 1;
          }
          else
            ModGeneralFunctions.MessageError_Large(this.str_Result, true);
          anfitrionaPedido2 = (BE_TR1_ANFITRIONA_PEDIDO) null;
        }
      }
      else if (this.TipoOperacion == (short) 3 && ModGeneralFunctions.MessageMakeAction_Large("¿Seguro de Eliminar a la anfitriona : -" + this.txtAnfitrionaDes.Text + "- ?"))
      {
        BE_TR1_ANFITRIONA_PEDIDO anfitrionaPedido3 = new BE_TR1_ANFITRIONA_PEDIDO();
        anfitrionaPedido3.set_LocalId(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId());
        anfitrionaPedido3.set_AnfPedidoId(0);
        anfitrionaPedido3.set_AnfitrionaId(Conversions.ToInteger(this.txtAnfitrionaId.Text));
        anfitrionaPedido3.set_PedidoId(this.TextBox_PedidoId.Text);
        this.str_Result = anfitrionaPedido1.Eliminar(anfitrionaPedido3);
        if (this.str_Result.Equals(StructApp.RESULT_OK))
        {
          this.LoadData(this.TextBox_PedidoId.Text);
          this.Limpiar();
          this.TipoOperacion = (short) 1;
        }
        else
          ModGeneralFunctions.MessageError_Large(this.str_Result, true);
      }
      anfitrionaPedido2 = (BE_TR1_ANFITRIONA_PEDIDO) null;
    }

    public bool DataGV_Validated()
    {
      return this.dgrvData.Rows.Count > 0;
    }

    private void btnBuscarProducto_Click(object sender, EventArgs e)
    {
      FrmAnfitriona frmAnfitriona = new FrmAnfitriona();
      frmAnfitriona._OnlySearch = true;
      int num = (int) frmAnfitriona.ShowDialog();
      frmAnfitriona.Dispose();
      if (!ModGeneralVar.g_bol_IsReady)
        return;
      this.txtAnfitrionaId.Text = ModGeneralVar.g_Str_RecordID;
      this.txtAnfitrionaDes.Text = ModGeneralVar.g_Str_RecordDes;
    }

    private void Button_CloseTab_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void FrmAnfitrionaPedido_Load(object sender, EventArgs e)
    {
      this.TipoOperacion = (short) 1;
      this.SetUpDataGridView();
      this.Limpiar();
      this.LoadData(this.TextBox_PedidoId.Text);
    }

    private void Button_New_Click(object sender, EventArgs e)
    {
      this.TipoOperacion = (short) 1;
      this.Limpiar();
    }

    private void Button_Agregar_Click(object sender, EventArgs e)
    {
      this.MakeOperation();
    }

    private void Button_Update_Click(object sender, EventArgs e)
    {
      this.txtAnfitrionaId.Text = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgrvData.DataSource, new object[1]
      {
        (object) this.dgrvData.CurrentRow.Index
      }, (string[]) null), (System.Type) null, "AnfitrionaId", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      this.txtAnfitrionaDes.Text = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgrvData.DataSource, new object[1]
      {
        (object) this.dgrvData.CurrentRow.Index
      }, (string[]) null), (System.Type) null, "AnfitrionaDes", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      this._AnfitrionaIdEdita = this.txtAnfitrionaId.Text;
      this.TipoOperacion = (short) 2;
    }

    private void Button_Delete_Click(object sender, EventArgs e)
    {
      if (!this.DataGV_Validated())
        return;
      this.TipoOperacion = (short) 3;
      this.txtAnfitrionaId.Text = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgrvData.DataSource, new object[1]
      {
        (object) this.dgrvData.CurrentRow.Index
      }, (string[]) null), (System.Type) null, "AnfitrionaId", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      this.txtAnfitrionaDes.Text = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgrvData.DataSource, new object[1]
      {
        (object) this.dgrvData.CurrentRow.Index
      }, (string[]) null), (System.Type) null, "AnfitrionaDes", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      this.MakeOperation();
    }

    private void dgrvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (!this.DataGV_Validated())
        return;
      this.Button_Update_Click(RuntimeHelpers.GetObjectValue(sender), (EventArgs) e);
    }

    private void dgrvData_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (!this.DataGV_Validated())
        return;
      this.SelectITem();
    }

    private void SelectITem()
    {
      ModGeneralVar.g_Str_RecordID = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgrvData.DataSource, new object[1]
      {
        (object) this.dgrvData.CurrentRow.Index
      }, (string[]) null), (System.Type) null, "AnfitrionaId", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      ModGeneralVar.g_Str_RecordDes = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgrvData.DataSource, new object[1]
      {
        (object) this.dgrvData.CurrentRow.Index
      }, (string[]) null), (System.Type) null, "AnfitrionaDes", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
    }
  }
}
