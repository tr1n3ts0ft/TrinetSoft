// Decompiled with JetBrains decompiler
// Type: TriNetRestPOS.FrmAtenderDelivery
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
  public class FrmAtenderDelivery : Form
  {
    private IContainer components;

    public FrmAtenderDelivery()
    {
      this.Load += new EventHandler(this.FrmAtenderDelivery_Load);
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
      this.Panel1 = new Panel();
      this.btnNinguno = new Button();
      this.btnTodos = new Button();
      this.btnIrPrimero = new Button();
      this.btnIrAnterior = new Button();
      this.btnIrSiguiente = new Button();
      this.btnIrUltimo = new Button();
      this.Panel2 = new Panel();
      this.txtAgenteNombre = new TextBox();
      this.Label1 = new Label();
      this.Panel3 = new Panel();
      this.dgvListaPedidos = new DataGridView();
      this.btnSalir = new Button();
      this.btnPagar = new Button();
      this.Panel4 = new Panel();
      this.Label2 = new Label();
      this.txtTotalaPagar = new TextBox();
      this.Panel1.SuspendLayout();
      this.Panel2.SuspendLayout();
      this.Panel3.SuspendLayout();
      ((ISupportInitialize) this.dgvListaPedidos).BeginInit();
      this.Panel4.SuspendLayout();
      this.SuspendLayout();
      this.Panel1.Controls.Add((Control) this.btnNinguno);
      this.Panel1.Controls.Add((Control) this.btnTodos);
      this.Panel1.Controls.Add((Control) this.btnIrPrimero);
      this.Panel1.Controls.Add((Control) this.btnIrAnterior);
      this.Panel1.Controls.Add((Control) this.btnIrSiguiente);
      this.Panel1.Controls.Add((Control) this.btnIrUltimo);
      this.Panel1.Dock = DockStyle.Right;
      this.Panel1.Location = new Point(945, 41);
      this.Panel1.Name = "Panel1";
      this.Panel1.Size = new Size(85, 463);
      this.Panel1.TabIndex = 0;
      this.btnNinguno.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnNinguno.ForeColor = Color.MediumBlue;
      this.btnNinguno.Image = (Image) TriNetRestPOS.My.Resources.Resources.Eliminar;
      this.btnNinguno.Location = new Point(1, (int) sbyte.MaxValue);
      this.btnNinguno.Name = "btnNinguno";
      this.btnNinguno.RightToLeft = RightToLeft.Yes;
      this.btnNinguno.Size = new Size(83, 60);
      this.btnNinguno.TabIndex = 34;
      this.btnNinguno.Text = "Ninguno";
      this.btnNinguno.TextAlign = ContentAlignment.TopCenter;
      this.btnNinguno.TextImageRelation = TextImageRelation.TextAboveImage;
      this.btnNinguno.UseVisualStyleBackColor = true;
      this.btnTodos.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnTodos.ForeColor = Color.MediumBlue;
      this.btnTodos.Image = (Image) TriNetRestPOS.My.Resources.Resources.i_Ready;
      this.btnTodos.Location = new Point(1, 68);
      this.btnTodos.Name = "btnTodos";
      this.btnTodos.RightToLeft = RightToLeft.Yes;
      this.btnTodos.Size = new Size(83, 60);
      this.btnTodos.TabIndex = 33;
      this.btnTodos.Text = "T&odos";
      this.btnTodos.TextAlign = ContentAlignment.TopCenter;
      this.btnTodos.TextImageRelation = TextImageRelation.TextAboveImage;
      this.btnTodos.UseVisualStyleBackColor = true;
      this.btnIrPrimero.Font = new Font("Verdana", 18f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnIrPrimero.Image = (Image) TriNetRestPOS.My.Resources.Resources.Fast_back;
      this.btnIrPrimero.Location = new Point(1, 186);
      this.btnIrPrimero.Name = "btnIrPrimero";
      this.btnIrPrimero.RightToLeft = RightToLeft.Yes;
      this.btnIrPrimero.Size = new Size(83, 60);
      this.btnIrPrimero.TabIndex = 7;
      this.btnIrPrimero.UseVisualStyleBackColor = true;
      this.btnIrAnterior.Font = new Font("Verdana", 18f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnIrAnterior.Image = (Image) TriNetRestPOS.My.Resources.Resources.go_back;
      this.btnIrAnterior.Location = new Point(1, 245);
      this.btnIrAnterior.Name = "btnIrAnterior";
      this.btnIrAnterior.RightToLeft = RightToLeft.Yes;
      this.btnIrAnterior.Size = new Size(83, 60);
      this.btnIrAnterior.TabIndex = 8;
      this.btnIrAnterior.UseVisualStyleBackColor = true;
      this.btnIrSiguiente.Font = new Font("Verdana", 18f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnIrSiguiente.Image = (Image) TriNetRestPOS.My.Resources.Resources.go_forward;
      this.btnIrSiguiente.Location = new Point(1, 304);
      this.btnIrSiguiente.Name = "btnIrSiguiente";
      this.btnIrSiguiente.RightToLeft = RightToLeft.Yes;
      this.btnIrSiguiente.Size = new Size(83, 60);
      this.btnIrSiguiente.TabIndex = 9;
      this.btnIrSiguiente.UseVisualStyleBackColor = true;
      this.btnIrUltimo.Font = new Font("Verdana", 18f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnIrUltimo.Image = (Image) TriNetRestPOS.My.Resources.Resources.fast_forward;
      this.btnIrUltimo.Location = new Point(1, 363);
      this.btnIrUltimo.Name = "btnIrUltimo";
      this.btnIrUltimo.RightToLeft = RightToLeft.Yes;
      this.btnIrUltimo.Size = new Size(83, 60);
      this.btnIrUltimo.TabIndex = 10;
      this.btnIrUltimo.UseVisualStyleBackColor = true;
      this.Panel2.Controls.Add((Control) this.txtAgenteNombre);
      this.Panel2.Controls.Add((Control) this.Label1);
      this.Panel2.Dock = DockStyle.Top;
      this.Panel2.Location = new Point(0, 0);
      this.Panel2.Name = "Panel2";
      this.Panel2.Size = new Size(1030, 41);
      this.Panel2.TabIndex = 1;
      this.txtAgenteNombre.Location = new Point(129, 8);
      this.txtAgenteNombre.MaxLength = 150;
      this.txtAgenteNombre.Name = "txtAgenteNombre";
      this.txtAgenteNombre.Size = new Size(817, 25);
      this.txtAgenteNombre.TabIndex = 0;
      this.Label1.AutoSize = true;
      this.Label1.ForeColor = Color.MediumBlue;
      this.Label1.Location = new Point(8, 11);
      this.Label1.Name = "Label1";
      this.Label1.Size = new Size(115, 20);
      this.Label1.TabIndex = 156;
      this.Label1.Text = "Buscar Driver :";
      this.Panel3.Controls.Add((Control) this.dgvListaPedidos);
      this.Panel3.Dock = DockStyle.Fill;
      this.Panel3.Location = new Point(0, 41);
      this.Panel3.Name = "Panel3";
      this.Panel3.Size = new Size(1030, 527);
      this.Panel3.TabIndex = 2;
      this.dgvListaPedidos.BorderStyle = BorderStyle.Fixed3D;
      this.dgvListaPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvListaPedidos.Dock = DockStyle.Fill;
      this.dgvListaPedidos.Location = new Point(0, 0);
      this.dgvListaPedidos.MultiSelect = false;
      this.dgvListaPedidos.Name = "dgvListaPedidos";
      this.dgvListaPedidos.ScrollBars = ScrollBars.None;
      this.dgvListaPedidos.Size = new Size(1030, 527);
      this.dgvListaPedidos.TabIndex = 14;
      this.btnSalir.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnSalir.ForeColor = Color.MediumBlue;
      this.btnSalir.Image = (Image) TriNetRestPOS.My.Resources.Resources.i_Close;
      this.btnSalir.Location = new Point(946, 2);
      this.btnSalir.Name = "btnSalir";
      this.btnSalir.Size = new Size(83, 60);
      this.btnSalir.TabIndex = 11;
      this.btnSalir.Text = "&Salir";
      this.btnSalir.TextImageRelation = TextImageRelation.TextAboveImage;
      this.btnSalir.UseVisualStyleBackColor = true;
      this.btnPagar.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnPagar.ForeColor = Color.MediumBlue;
      this.btnPagar.Image = (Image) TriNetRestPOS.My.Resources.Resources.i_Ready;
      this.btnPagar.Location = new Point(796, 2);
      this.btnPagar.Name = "btnPagar";
      this.btnPagar.Size = new Size(150, 60);
      this.btnPagar.TabIndex = 12;
      this.btnPagar.Text = "&Pagar";
      this.btnPagar.TextImageRelation = TextImageRelation.TextAboveImage;
      this.btnPagar.UseVisualStyleBackColor = true;
      this.Panel4.Controls.Add((Control) this.Label2);
      this.Panel4.Controls.Add((Control) this.txtTotalaPagar);
      this.Panel4.Controls.Add((Control) this.btnSalir);
      this.Panel4.Controls.Add((Control) this.btnPagar);
      this.Panel4.Dock = DockStyle.Bottom;
      this.Panel4.Location = new Point(0, 504);
      this.Panel4.Name = "Panel4";
      this.Panel4.Size = new Size(1030, 64);
      this.Panel4.TabIndex = 3;
      this.Label2.AutoSize = true;
      this.Label2.ForeColor = Color.Red;
      this.Label2.Location = new Point(492, 20);
      this.Label2.Name = "Label2";
      this.Label2.Size = new Size(135, 20);
      this.Label2.TabIndex = 197;
      this.Label2.Text = "TOTAL A PAGAR :";
      this.txtTotalaPagar.BackColor = Color.FromArgb((int) byte.MaxValue, 240, 140);
      this.txtTotalaPagar.Font = new Font("Trebuchet MS", 20.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtTotalaPagar.Location = new Point(632, 12);
      this.txtTotalaPagar.Name = "txtTotalaPagar";
      this.txtTotalaPagar.ReadOnly = true;
      this.txtTotalaPagar.Size = new Size(160, 39);
      this.txtTotalaPagar.TabIndex = 196;
      this.txtTotalaPagar.Text = "0.00";
      this.txtTotalaPagar.TextAlign = HorizontalAlignment.Right;
      this.AutoScaleDimensions = new SizeF(9f, 20f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.White;
      this.ClientSize = new Size(1030, 568);
      this.Controls.Add((Control) this.Panel1);
      this.Controls.Add((Control) this.Panel4);
      this.Controls.Add((Control) this.Panel3);
      this.Controls.Add((Control) this.Panel2);
      this.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.Margin = new Padding(4, 5, 4, 5);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (FrmAtenderDelivery);
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Pagar Pedidos Delivery";
      this.Panel1.ResumeLayout(false);
      this.Panel2.ResumeLayout(false);
      this.Panel2.PerformLayout();
      this.Panel3.ResumeLayout(false);
      ((ISupportInitialize) this.dgvListaPedidos).EndInit();
      this.Panel4.ResumeLayout(false);
      this.Panel4.PerformLayout();
      this.ResumeLayout(false);
    }

    internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Panel Panel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Panel Panel3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DataGridView dgvListaPedidos
    {
      get
      {
        return this._dgvListaPedidos;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DataGridViewCellFormattingEventHandler formattingEventHandler = new DataGridViewCellFormattingEventHandler(this.dgvListaPedidos_CellFormatting);
        DataGridViewCellMouseEventHandler mouseEventHandler = new DataGridViewCellMouseEventHandler(this.dgvListaPedidos_CellMouseClick);
        DataGridView dgvListaPedidos1 = this._dgvListaPedidos;
        if (dgvListaPedidos1 != null)
        {
          dgvListaPedidos1.CellFormatting -= formattingEventHandler;
          dgvListaPedidos1.CellMouseClick -= mouseEventHandler;
        }
        this._dgvListaPedidos = value;
        DataGridView dgvListaPedidos2 = this._dgvListaPedidos;
        if (dgvListaPedidos2 == null)
          return;
        dgvListaPedidos2.CellFormatting += formattingEventHandler;
        dgvListaPedidos2.CellMouseClick += mouseEventHandler;
      }
    }

    internal virtual Button btnIrPrimero
    {
      get
      {
        return this._btnIrPrimero;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnIrPrimero_Click);
        Button btnIrPrimero1 = this._btnIrPrimero;
        if (btnIrPrimero1 != null)
          btnIrPrimero1.Click -= eventHandler;
        this._btnIrPrimero = value;
        Button btnIrPrimero2 = this._btnIrPrimero;
        if (btnIrPrimero2 == null)
          return;
        btnIrPrimero2.Click += eventHandler;
      }
    }

    internal virtual Button btnIrAnterior
    {
      get
      {
        return this._btnIrAnterior;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnIrAnterior_Click);
        Button btnIrAnterior1 = this._btnIrAnterior;
        if (btnIrAnterior1 != null)
          btnIrAnterior1.Click -= eventHandler;
        this._btnIrAnterior = value;
        Button btnIrAnterior2 = this._btnIrAnterior;
        if (btnIrAnterior2 == null)
          return;
        btnIrAnterior2.Click += eventHandler;
      }
    }

    internal virtual Button btnIrSiguiente
    {
      get
      {
        return this._btnIrSiguiente;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnIrSiguiente_Click);
        Button btnIrSiguiente1 = this._btnIrSiguiente;
        if (btnIrSiguiente1 != null)
          btnIrSiguiente1.Click -= eventHandler;
        this._btnIrSiguiente = value;
        Button btnIrSiguiente2 = this._btnIrSiguiente;
        if (btnIrSiguiente2 == null)
          return;
        btnIrSiguiente2.Click += eventHandler;
      }
    }

    internal virtual Button btnIrUltimo
    {
      get
      {
        return this._btnIrUltimo;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnIrUltimo_Click);
        Button btnIrUltimo1 = this._btnIrUltimo;
        if (btnIrUltimo1 != null)
          btnIrUltimo1.Click -= eventHandler;
        this._btnIrUltimo = value;
        Button btnIrUltimo2 = this._btnIrUltimo;
        if (btnIrUltimo2 == null)
          return;
        btnIrUltimo2.Click += eventHandler;
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

    internal virtual Button btnPagar
    {
      get
      {
        return this._btnPagar;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnPagar_Click);
        Button btnPagar1 = this._btnPagar;
        if (btnPagar1 != null)
          btnPagar1.Click -= eventHandler;
        this._btnPagar = value;
        Button btnPagar2 = this._btnPagar;
        if (btnPagar2 == null)
          return;
        btnPagar2.Click += eventHandler;
      }
    }

    internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Panel Panel4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button btnTodos
    {
      get
      {
        return this._btnTodos;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnTodos_Click);
        Button btnTodos1 = this._btnTodos;
        if (btnTodos1 != null)
          btnTodos1.Click -= eventHandler;
        this._btnTodos = value;
        Button btnTodos2 = this._btnTodos;
        if (btnTodos2 == null)
          return;
        btnTodos2.Click += eventHandler;
      }
    }

    internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox txtTotalaPagar { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button btnNinguno
    {
      get
      {
        return this._btnNinguno;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnNinguno_Click);
        Button btnNinguno1 = this._btnNinguno;
        if (btnNinguno1 != null)
          btnNinguno1.Click -= eventHandler;
        this._btnNinguno = value;
        Button btnNinguno2 = this._btnNinguno;
        if (btnNinguno2 == null)
          return;
        btnNinguno2.Click += eventHandler;
      }
    }

    internal virtual TextBox txtAgenteNombre
    {
      get
      {
        return this._txtAgenteNombre;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtAgenteNombre_TextChanged);
        TextBox txtAgenteNombre1 = this._txtAgenteNombre;
        if (txtAgenteNombre1 != null)
          txtAgenteNombre1.TextChanged -= eventHandler;
        this._txtAgenteNombre = value;
        TextBox txtAgenteNombre2 = this._txtAgenteNombre;
        if (txtAgenteNombre2 == null)
          return;
        txtAgenteNombre2.TextChanged += eventHandler;
      }
    }

    private void FrmAtenderDelivery_Load(object sender, EventArgs e)
    {
      this.SetearGrid();
      this.CargarPedidos();
      this.txtAgenteNombre.Focus();
    }

    private void txtAgenteNombre_TextChanged(object sender, EventArgs e)
    {
      this.CargarPedidos();
    }

    private void dgvListaPedidos_CellFormatting(
      object sender,
      DataGridViewCellFormattingEventArgs e)
    {
      if (e.ColumnIndex != 6)
        return;
      if (Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(this.dgvListaPedidos.DataSource, new object[1]
      {
        (object) e.RowIndex
      }, (string[]) null), (System.Type) null, "Seleccionado", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)))
        e.Value = (object) TriNetRestPOS.My.Resources.Resources.IsPrinted_True;
      else
        e.Value = (object) TriNetRestPOS.My.Resources.Resources.IsPrinted_False;
    }

    private void dgvListaPedidos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
    {
      BE_TR1_ORDERS beTr1Orders = new BE_TR1_ORDERS();
      if (this.dgvListaPedidos.Rows.Count > 0)
      {
        BE_TR1_ORDERS dataBoundItem = (BE_TR1_ORDERS) this.dgvListaPedidos.CurrentRow.DataBoundItem;
        if (dataBoundItem.get_Seleccionado())
          dataBoundItem.set_Seleccionado(false);
        else
          dataBoundItem.set_Seleccionado(true);
        NewLateBinding.LateSetComplex(this.dgvListaPedidos.DataSource, (System.Type) null, "item", new object[2]
        {
          (object) this.dgvListaPedidos.CurrentRow.Index,
          (object) dataBoundItem
        }, (string[]) null, (System.Type[]) null, false, true);
        this.dgvListaPedidos.Refresh();
        this.CalcularTotalaPagar();
      }
      beTr1Orders = (BE_TR1_ORDERS) null;
    }

    private void btnTodos_Click(object sender, EventArgs e)
    {
      this.SeleccionarTodos();
    }

    private void btnIrPrimero_Click(object sender, EventArgs e)
    {
      ModGeneralFunctions.GridIrPrimeraFila(this.dgvListaPedidos);
    }

    private void btnIrAnterior_Click(object sender, EventArgs e)
    {
      ModGeneralFunctions.GridIrAnteriorFila(this.dgvListaPedidos);
    }

    private void btnIrSiguiente_Click(object sender, EventArgs e)
    {
      ModGeneralFunctions.GridIrSiguienteFila(this.dgvListaPedidos);
    }

    private void btnIrUltimo_Click(object sender, EventArgs e)
    {
      ModGeneralFunctions.GridIrUltimaFila(this.dgvListaPedidos);
    }

    private void btnPagar_Click(object sender, EventArgs e)
    {
      if (!ModGeneralFunctions.MessageMakeAction("¿Seguro de Pagar Pedido(s)?", false))
        return;
      this.Pagar();
    }

    private void btnSalir_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void SetearGrid()
    {
      ModGeneralFunctions.SetUpDataGridViewBasic(this.dgvListaPedidos);
      this.dgvListaPedidos.Columns.Add("AgentDes", "Driver");
      ModGeneralFunctions.SetUp_TextBoxColumn((DataGridViewTextBoxColumn) this.dgvListaPedidos.Columns[0], "AgentDes", (short) 200, "", true, DataGridViewContentAlignment.MiddleLeft, true);
      this.dgvListaPedidos.Columns.Add("DocumentTypeDes", "T.D.");
      ModGeneralFunctions.SetUp_TextBoxColumn((DataGridViewTextBoxColumn) this.dgvListaPedidos.Columns[1], "DocumentTypeDes", (short) 40, "", true, DataGridViewContentAlignment.MiddleLeft, true);
      this.dgvListaPedidos.Columns.Add("DocumentId", "Nº Documento");
      ModGeneralFunctions.SetUp_TextBoxColumn((DataGridViewTextBoxColumn) this.dgvListaPedidos.Columns[2], "DocumentId", (short) 110, "", true, DataGridViewContentAlignment.MiddleCenter, true);
      this.dgvListaPedidos.Columns.Add("ContactName", "Cliente");
      ModGeneralFunctions.SetUp_TextBoxColumn((DataGridViewTextBoxColumn) this.dgvListaPedidos.Columns[3], "ContactName", (short) 218, "", true, DataGridViewContentAlignment.MiddleLeft, true);
      this.dgvListaPedidos.Columns.Add("AmountSale", "Total a Pagar");
      ModGeneralFunctions.SetUp_TextBoxColumn((DataGridViewTextBoxColumn) this.dgvListaPedidos.Columns[4], "AmountSale", (short) 120, "0.00", true, DataGridViewContentAlignment.MiddleRight, true);
      this.dgvListaPedidos.Columns.Add("DateSaved", "Fecha / Hora");
      ModGeneralFunctions.SetUp_TextBoxColumn((DataGridViewTextBoxColumn) this.dgvListaPedidos.Columns[5], "DateSaved", (short) 160, "dd/MM/yyyy dd:mm tt", true, DataGridViewContentAlignment.MiddleLeft, true);
      this.dgvListaPedidos.Columns.Add((DataGridViewColumn) new DataGridViewImageColumn());
      ModGeneralFunctions.SetUp_ImageColumn((DataGridViewImageColumn) this.dgvListaPedidos.Columns[6], "Elegir", (short) 80, "", TriNetRestPOS.My.Resources.Resources.IsPrinted_False, true);
    }

    private void CargarPedidos()
    {
      this.dgvListaPedidos.DataSource = (object) new BL_TR1_ORDERS().ListarxPagarDelivery(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId(), ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EmpresaId(), ModGeneralVar.g_BE_TR1_TURNS.get_TurnId(), ModGeneralVar.g_BusinessCode.get_DOCU_PROCESSED(), this.txtAgenteNombre.Text.Trim());
    }

    private void SeleccionarTodos()
    {
      if (!ModGeneralFunctions.DataGrid_Validated(this.dgvListaPedidos))
        return;
      List<BE_TR1_ORDERS> dataSource = (List<BE_TR1_ORDERS>) this.dgvListaPedidos.DataSource;
      int num = checked (dataSource.Count - 1);
      int index = 0;
      while (index <= num)
      {
        dataSource[index].set_Seleccionado(true);
        checked { ++index; }
      }
      this.dgvListaPedidos.DataSource = (object) dataSource;
      this.dgvListaPedidos.Refresh();
      this.CalcularTotalaPagar();
    }

    private void SeleccionarNinguno()
    {
      if (!ModGeneralFunctions.DataGrid_Validated(this.dgvListaPedidos))
        return;
      List<BE_TR1_ORDERS> dataSource = (List<BE_TR1_ORDERS>) this.dgvListaPedidos.DataSource;
      int num = checked (dataSource.Count - 1);
      int index = 0;
      while (index <= num)
      {
        dataSource[index].set_Seleccionado(false);
        checked { ++index; }
      }
      this.dgvListaPedidos.DataSource = (object) dataSource;
      this.dgvListaPedidos.Refresh();
      this.CalcularTotalaPagar();
    }

    private void CalcularTotalaPagar()
    {
      if (!ModGeneralFunctions.DataGrid_Validated(this.dgvListaPedidos))
        return;
      double num1 = 0.0;
      int num2 = checked (this.dgvListaPedidos.RowCount - 1);
      int num3 = 0;
      while (num3 <= num2)
      {
        object[] objArray;
        bool[] flagArray;
        object obj = NewLateBinding.LateGet(this.dgvListaPedidos.DataSource, (System.Type) null, "item", objArray = new object[1]
        {
          (object) num3
        }, (string[]) null, (System.Type[]) null, flagArray = new bool[1]
        {
          true
        });
        if (flagArray[0])
          num3 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray[0]), typeof (int));
        BE_TR1_ORDERS beTr1Orders = (BE_TR1_ORDERS) obj;
        if (beTr1Orders.get_Seleccionado())
          num1 += beTr1Orders.get_AmountSale();
        checked { ++num3; }
      }
      this.txtTotalaPagar.Text = ModGeneralFunctions.CadenaToDoubleFormateado(Conversions.ToString(num1), 2);
    }

    private void Pagar()
    {
      if (!ModGeneralFunctions.DataGrid_Validated(this.dgvListaPedidos))
        return;
      BL_TR1_ORDERS blTr1Orders = new BL_TR1_ORDERS();
      string str = "";
      int num1 = checked (this.dgvListaPedidos.RowCount - 1);
      int num2 = 0;
      while (num2 <= num1)
      {
        object[] objArray;
        bool[] flagArray;
        object obj = NewLateBinding.LateGet(this.dgvListaPedidos.DataSource, (System.Type) null, "item", objArray = new object[1]
        {
          (object) num2
        }, (string[]) null, (System.Type[]) null, flagArray = new bool[1]
        {
          true
        });
        if (flagArray[0])
          num2 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray[0]), typeof (int));
        BE_TR1_ORDERS beTr1Orders = (BE_TR1_ORDERS) obj;
        if (beTr1Orders.get_Seleccionado())
        {
          BE_TR1_PEDIDO_INCIDENCIAS pedidoIncidencias = new BE_TR1_PEDIDO_INCIDENCIAS();
          pedidoIncidencias.set_LocalId(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId());
          pedidoIncidencias.set_PedidoId(beTr1Orders.get_OrderId());
          pedidoIncidencias.set_EstadoId(ModGeneralVar.g_BusinessCode.get_DELIVERY_PAGADO());
          pedidoIncidencias.set_Observacion("PAGÓ: " + Conversions.ToString(beTr1Orders.get_AmountSale()));
          pedidoIncidencias.set_Usuario(ModGeneralVar.g_BE_USERS.get_UserId());
          str = blTr1Orders.ActualizarEstadoxDelivery(pedidoIncidencias);
          if (!str.Equals(StructApp.RESULT_OK))
            ModGeneralFunctions.MessageError_Large("¡Error al actualizar Pedido Delivery - " + str + "!", true);
        }
        checked { ++num2; }
      }
      if (str.Equals(StructApp.RESULT_OK))
      {
        this.CargarPedidos();
        this.txtTotalaPagar.Text = ModGeneralFunctions.CadenaToDoubleFormateado("0", 2);
      }
    }

    private void btnNinguno_Click(object sender, EventArgs e)
    {
      this.SeleccionarNinguno();
    }
  }
}
