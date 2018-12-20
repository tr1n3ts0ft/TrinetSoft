// Decompiled with JetBrains decompiler
// Type: TriNetRestPOS.FrmBuscarMesaDiseno
// Assembly: TriNetRestPOS, Version=5.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 43377352-E952-4AC1-9BA6-CCBE4AE5F575
// Assembly location: C:\log\TriNetRestPOS.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MyXPButtonTables;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using TR1_BusinessEntity;
using TR1_BusinessLogic;

namespace TriNetRestPOS
{
  [DesignerGenerated]
  public class FrmBuscarMesaDiseno : Form
  {
    private IContainer components;
    private BECollec_TR1_MASTERTABLE o_BEC_MASTERTABLE;
    private Button[] btnTablesButtons;
    private List<BE_TR1_TABLES> o_BECollec_TR1_TABLES;
    private short shtCountHallCollection;
    private short shtCountTypeOrders;
    private short shtCountTablesCollection;
    private int int_OldPeople;
    private BL_TR1_MASTERTABLE o_BL_MASTERTABLE;
    private string Res_OrderFree;
    private string Res_MsgOk_O;
    private string Res_Title;
    private string Res_Code;
    private string Res_Description;
    private string Res_HallDes;
    private Button[] btnHallButtons;
    public int int_PisoId;
    public int int_SalonId;
    public string str_PisoNombre;
    public string Str_WaiterID;
    public bool IsReservation;
    public bool IsViewRecepcion;
    public bool IsImportOrder;
    public int intTableId;
    public bool bolUbicarMesa;

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
      this.components = (IContainer) new Container();
      this.gbFloor = new GroupBox();
      this.btnSalir = new Button();
      this.btnActualizar = new Button();
      this.GroupBox_StateTable = new GroupBox();
      this.Label2 = new Label();
      this.Label1 = new Label();
      this.Label_Busy = new Label();
      this.Label_Free = new Label();
      this.mnuMesas = new ContextMenuStrip(this.components);
      this.mnuReparar = new ToolStripMenuItem();
      this.Button2 = new Button();
      this.MyXPButtonTables11 = new Button();
      this.MyXPButtonTables_Ocup1 = new Button();
      this.MyXPButtonTables_Free1 = new Button();
      this.GroupBox_StateTable.SuspendLayout();
      this.mnuMesas.SuspendLayout();
      this.SuspendLayout();
      this.gbFloor.BackColor = Color.WhiteSmoke;
      this.gbFloor.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.gbFloor.ForeColor = Color.FromArgb(150, 150, 150);
      this.gbFloor.Location = new Point(5, -2);
      this.gbFloor.Name = "gbFloor";
      this.gbFloor.Size = new Size(426, 81);
      this.gbFloor.TabIndex = 184;
      this.gbFloor.TabStop = false;
      this.gbFloor.Text = "Piso:";
      this.btnSalir.BackColor = Color.WhiteSmoke;
      this.btnSalir.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.BotonRojo;
      this.btnSalir.FlatStyle = FlatStyle.Flat;
      this.btnSalir.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnSalir.ForeColor = Color.WhiteSmoke;
      this.btnSalir.Image = (Image) TriNetRestPOS.My.Resources.Resources.salir;
      this.btnSalir.ImageAlign = ContentAlignment.TopCenter;
      this.btnSalir.Location = new Point(914, 8);
      this.btnSalir.Name = "btnSalir";
      this.btnSalir.Padding = new Padding(0, 5, 0, 5);
      this.btnSalir.Size = new Size(114, 60);
      this.btnSalir.TabIndex = 185;
      this.btnSalir.Text = "SALIR";
      this.btnSalir.TextAlign = ContentAlignment.BottomCenter;
      this.btnSalir.UseVisualStyleBackColor = false;
      this.btnActualizar.BackColor = Color.WhiteSmoke;
      this.btnActualizar.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.boton_refrescar;
      this.btnActualizar.FlatStyle = FlatStyle.Flat;
      this.btnActualizar.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnActualizar.ForeColor = Color.WhiteSmoke;
      this.btnActualizar.Image = (Image) TriNetRestPOS.My.Resources.Resources.refrescar;
      this.btnActualizar.ImageAlign = ContentAlignment.TopCenter;
      this.btnActualizar.Location = new Point(794, 8);
      this.btnActualizar.Name = "btnActualizar";
      this.btnActualizar.Padding = new Padding(0, 5, 0, 5);
      this.btnActualizar.Size = new Size(119, 60);
      this.btnActualizar.TabIndex = 186;
      this.btnActualizar.Text = "REFRESCAR";
      this.btnActualizar.TextAlign = ContentAlignment.BottomCenter;
      this.btnActualizar.UseVisualStyleBackColor = false;
      this.GroupBox_StateTable.Controls.Add((Control) this.Button2);
      this.GroupBox_StateTable.Controls.Add((Control) this.MyXPButtonTables11);
      this.GroupBox_StateTable.Controls.Add((Control) this.MyXPButtonTables_Ocup1);
      this.GroupBox_StateTable.Controls.Add((Control) this.MyXPButtonTables_Free1);
      this.GroupBox_StateTable.Controls.Add((Control) this.Label2);
      this.GroupBox_StateTable.Controls.Add((Control) this.Label1);
      this.GroupBox_StateTable.Controls.Add((Control) this.Label_Busy);
      this.GroupBox_StateTable.Controls.Add((Control) this.Label_Free);
      this.GroupBox_StateTable.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.GroupBox_StateTable.ForeColor = Color.FromArgb(150, 150, 150);
      this.GroupBox_StateTable.Location = new Point(443, 0);
      this.GroupBox_StateTable.Name = "GroupBox_StateTable";
      this.GroupBox_StateTable.Size = new Size(345, 79);
      this.GroupBox_StateTable.TabIndex = 187;
      this.GroupBox_StateTable.TabStop = false;
      this.GroupBox_StateTable.Text = "Estado de Mesas";
      this.Label2.AutoSize = true;
      this.Label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label2.Location = new Point(235, 19);
      this.Label2.Name = "Label2";
      this.Label2.Size = new Size(78, 16);
      this.Label2.TabIndex = 10;
      this.Label2.Text = "Precuenta";
      this.Label1.AutoSize = true;
      this.Label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label1.Location = new Point(157, 19);
      this.Label1.Name = "Label1";
      this.Label1.Size = new Size(85, 16);
      this.Label1.TabIndex = 8;
      this.Label1.Text = "Reservada";
      this.Label_Busy.AutoSize = true;
      this.Label_Busy.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label_Busy.Location = new Point(86, 19);
      this.Label_Busy.Name = "Label_Busy";
      this.Label_Busy.Size = new Size(71, 16);
      this.Label_Busy.TabIndex = 4;
      this.Label_Busy.Text = "Ocupada";
      this.Label_Free.AutoSize = true;
      this.Label_Free.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label_Free.Location = new Point(10, 19);
      this.Label_Free.Name = "Label_Free";
      this.Label_Free.Size = new Size(43, 16);
      this.Label_Free.TabIndex = 2;
      this.Label_Free.Text = "Libre";
      this.mnuMesas.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.mnuMesas.Items.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.mnuReparar
      });
      this.mnuMesas.Name = "mnuDesing";
      this.mnuMesas.Size = new Size(201, 28);
      this.mnuReparar.Image = (Image) TriNetRestPOS.My.Resources.Resources.Refresh;
      this.mnuReparar.Name = "mnuReparar";
      this.mnuReparar.Size = new Size(200, 24);
      this.mnuReparar.Text = "Actualizar Estado";
      this.Button2.BackColor = Color.White;
      this.Button2.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.precuenta;
      this.Button2.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
      this.Button2.FlatAppearance.BorderSize = 0;
      this.Button2.FlatStyle = FlatStyle.Flat;
      this.Button2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button2.ForeColor = Color.White;
      this.Button2.Location = new Point(237, 38);
      this.Button2.Name = "Button2";
      this.Button2.Size = new Size(75, 35);
      this.Button2.TabIndex = 230;
      this.Button2.UseVisualStyleBackColor = false;
      this.MyXPButtonTables11.BackColor = Color.White;
      this.MyXPButtonTables11.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.reservado;
      this.MyXPButtonTables11.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
      this.MyXPButtonTables11.FlatAppearance.BorderSize = 0;
      this.MyXPButtonTables11.FlatStyle = FlatStyle.Flat;
      this.MyXPButtonTables11.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.MyXPButtonTables11.ForeColor = Color.White;
      this.MyXPButtonTables11.Location = new Point(160, 38);
      this.MyXPButtonTables11.Name = "MyXPButtonTables11";
      this.MyXPButtonTables11.Size = new Size(75, 35);
      this.MyXPButtonTables11.TabIndex = 229;
      this.MyXPButtonTables11.UseVisualStyleBackColor = false;
      this.MyXPButtonTables_Ocup1.BackColor = Color.White;
      this.MyXPButtonTables_Ocup1.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.ocupado;
      this.MyXPButtonTables_Ocup1.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
      this.MyXPButtonTables_Ocup1.FlatAppearance.BorderSize = 0;
      this.MyXPButtonTables_Ocup1.FlatStyle = FlatStyle.Flat;
      this.MyXPButtonTables_Ocup1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.MyXPButtonTables_Ocup1.ForeColor = Color.White;
      this.MyXPButtonTables_Ocup1.Location = new Point(83, 38);
      this.MyXPButtonTables_Ocup1.Name = "MyXPButtonTables_Ocup1";
      this.MyXPButtonTables_Ocup1.Size = new Size(75, 35);
      this.MyXPButtonTables_Ocup1.TabIndex = 228;
      this.MyXPButtonTables_Ocup1.UseVisualStyleBackColor = false;
      this.MyXPButtonTables_Free1.BackColor = Color.White;
      this.MyXPButtonTables_Free1.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.libre;
      this.MyXPButtonTables_Free1.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
      this.MyXPButtonTables_Free1.FlatAppearance.BorderSize = 0;
      this.MyXPButtonTables_Free1.FlatStyle = FlatStyle.Flat;
      this.MyXPButtonTables_Free1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.MyXPButtonTables_Free1.ForeColor = Color.White;
      this.MyXPButtonTables_Free1.Location = new Point(6, 38);
      this.MyXPButtonTables_Free1.Name = "MyXPButtonTables_Free1";
      this.MyXPButtonTables_Free1.Size = new Size(75, 35);
      this.MyXPButtonTables_Free1.TabIndex = 227;
      this.MyXPButtonTables_Free1.UseVisualStyleBackColor = false;
      this.AutoScaleDimensions = new SizeF(9f, 20f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.WhiteSmoke;
      this.ClientSize = new Size(1030, 738);
      this.Controls.Add((Control) this.GroupBox_StateTable);
      this.Controls.Add((Control) this.btnActualizar);
      this.Controls.Add((Control) this.btnSalir);
      this.Controls.Add((Control) this.gbFloor);
      this.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.KeyPreview = true;
      this.Margin = new Padding(4, 5, 4, 5);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (FrmBuscarMesaDiseno);
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Buscar Mesa";
      this.GroupBox_StateTable.ResumeLayout(false);
      this.GroupBox_StateTable.PerformLayout();
      this.mnuMesas.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    internal virtual GroupBox gbFloor { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

    internal virtual Button btnActualizar
    {
      get
      {
        return this._btnActualizar;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnActualizar_Click);
        Button btnActualizar1 = this._btnActualizar;
        if (btnActualizar1 != null)
          btnActualizar1.Click -= eventHandler;
        this._btnActualizar = value;
        Button btnActualizar2 = this._btnActualizar;
        if (btnActualizar2 == null)
          return;
        btnActualizar2.Click += eventHandler;
      }
    }

    internal virtual GroupBox GroupBox_StateTable { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label_Busy { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label_Free { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ContextMenuStrip mnuMesas
    {
      get
      {
        return this._mnuMesas;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.mnuMesas_Opened);
        ContextMenuStrip mnuMesas1 = this._mnuMesas;
        if (mnuMesas1 != null)
          mnuMesas1.Opened -= eventHandler;
        this._mnuMesas = value;
        ContextMenuStrip mnuMesas2 = this._mnuMesas;
        if (mnuMesas2 == null)
          return;
        mnuMesas2.Opened += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem mnuReparar
    {
      get
      {
        return this._mnuReparar;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.mnuReparar_Click);
        ToolStripMenuItem mnuReparar1 = this._mnuReparar;
        if (mnuReparar1 != null)
          mnuReparar1.Click -= eventHandler;
        this._mnuReparar = value;
        ToolStripMenuItem mnuReparar2 = this._mnuReparar;
        if (mnuReparar2 == null)
          return;
        mnuReparar2.Click += eventHandler;
      }
    }

    internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button MyXPButtonTables11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button MyXPButtonTables_Ocup1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button MyXPButtonTables_Free1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    public FrmBuscarMesaDiseno(int pint_PisoId)
    {
      this.Load += new EventHandler(this.FrmBuscarMesaDiseno_Load);
      this.KeyDown += new KeyEventHandler(this.FrmBuscarMesaDiseno_KeyDown);
      this.Click += new EventHandler(this.Search_Table_By_Hall_Click);
      this.Click += new EventHandler(this.btnTablesButtons_Click);
      this.KeyDown += new KeyEventHandler(this.FrmChooseTable_KeyDown);
      this.IsReservation = false;
      this.IsViewRecepcion = false;
      this.IsImportOrder = false;
      this.bolUbicarMesa = false;
      this.InitializeComponent();
      this.int_PisoId = pint_PisoId;
    }

    private void FrmBuscarMesaDiseno_Load(object sender, EventArgs e)
    {
      this.Resource(ModGeneralFunctions.Get_Language((object) this));
      this.CreateButtonSalonesArray();
      this.gbFloor.Visible = true;
      short num1 = checked ((short) ((int) this.shtCountHallCollection - 1));
      short num2 = 0;
      while ((int) num2 <= (int) num1)
      {
        if (this.btnHallButtons[(int) num2].Tag.Equals((object) this.int_PisoId))
          this.btnHallButtons[(int) num2].BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.boton_piso;
        else
          this.btnHallButtons[(int) num2].BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.boton_piso_libre;
        checked { ++num2; }
      }
      this.CreateButtonMesasArray();
      this.FillButtonMesasArray(this.int_PisoId);
      this.CargarObjetos(this.int_PisoId);
      if (!this.bolUbicarMesa)
        return;
      this.UbicarMesa(this.intTableId);
    }

    private void FrmBuscarMesaDiseno_KeyDown(object sender, KeyEventArgs e)
    {
      switch (e.KeyValue)
      {
        case 27:
          this.Btn_GoOut_Click((object) null, (EventArgs) null);
          break;
        case 116:
          this.btnActualizar_Click((object) null, (EventArgs) null);
          break;
      }
    }

    private void Resource(ResourceManager Rm)
    {
      this.btnSalir.Text = Strings.UCase(Rm.GetString("Res_Exit"));
      this.Res_OrderFree = Rm.GetString("Res_OrderFree");
      this.Res_MsgOk_O = Rm.GetString("Res_MsgOk_O");
      this.Res_Title = Rm.GetString("Res_ListMaintenance");
      this.Res_Code = Rm.GetString("Res_Code");
      this.Res_Description = Rm.GetString("Res_Description");
      this.Res_HallDes = Rm.GetString("Res_HallR");
    }

    private void CreateButtonMesasArray()
    {
      this.shtCountTablesCollection = (short) 200;
      this.btnTablesButtons = new Button[checked ((int) this.shtCountTablesCollection + 1)];
      short num1 = 82;
      short num2 = 58;
      short num3 = 58;
      short num4 = checked ((short) ((int) this.shtCountTablesCollection - 1));
      short num5 = 0;
      while ((int) num5 <= (int) num4)
      {
        short num6;
        short num7 = checked ((short) (2 + (int) num6 * ((int) num2 + 2)));
        this.btnTablesButtons[(int) num5] = new Button();
        this.btnTablesButtons[(int) num5].BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.libre_pax;
        Button btnTablesButton = this.btnTablesButtons[(int) num5];
        btnTablesButton.ForeColor = Color.WhiteSmoke;
        btnTablesButton.Font = new Font("Tahoma", 13f, FontStyle.Bold);
        btnTablesButton.Location = new Point((int) num7, (int) num1);
        btnTablesButton.Size = new Size((int) num2, (int) num3);
        btnTablesButton.ForeColor = Color.FromArgb(150, 150, 150);
        btnTablesButton.FlatStyle = FlatStyle.Popup;
        btnTablesButton.ImageAlign = ContentAlignment.BottomLeft;
        btnTablesButton.TextImageRelation = TextImageRelation.TextBeforeImage;
        btnTablesButton.ContextMenuStrip = this.mnuMesas;
        btnTablesButton.SendToBack();
        btnTablesButton.Click += new EventHandler(this.btnTablesButtons_Click);
        checked { ++num6; }
        if (num6 == (short) 17)
        {
          checked { num1 += unchecked ((short) checked ((int) num3 + 2)); }
          num6 = (short) 0;
        }
        checked { ++num5; }
      }
      this.Controls.AddRange((Control[]) this.btnTablesButtons);
    }

    private void FillButtonMesasArray(int pintPisoId)
    {
      this.o_BECollec_TR1_TABLES = new BL_TR1_TABLES().ListarxPisoPedido(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId(), pintPisoId, ModGeneralVar.g_BusinessCode.get_ORDER_PROCESO(), ModGeneralVar.g_BusinessCode.get_TABLE_OCUPADA());
      this.shtCountTablesCollection = (short) 200;
      if (this.shtCountTablesCollection > (short) 200)
        this.shtCountTablesCollection = (short) 200;
      short num1 = checked ((short) (this.o_BECollec_TR1_TABLES.Count - 1));
      short num2 = 0;
      while ((int) num2 <= (int) num1)
      {
        string tableState = this.o_BECollec_TR1_TABLES[(int) num2].get_TableState();
        int cantidad = this.o_BECollec_TR1_TABLES[(int) num2].get_Cantidad();
        Button btnTablesButton = this.btnTablesButtons[(int) num2];
        btnTablesButton.Name = this.o_BECollec_TR1_TABLES[(int) num2].get_OrderId();
        btnTablesButton.Text = this.o_BECollec_TR1_TABLES[(int) num2].get_TableDes();
        btnTablesButton.Tag = (object) this.o_BECollec_TR1_TABLES[(int) num2].get_TableId();
        btnTablesButton.TabIndex = this.o_BECollec_TR1_TABLES[(int) num2].get_HallId();
        if (this.o_BECollec_TR1_TABLES[(int) num2].get_PosX() > 0)
          btnTablesButton.Location = new Point(this.o_BECollec_TR1_TABLES[(int) num2].get_PosX(), this.o_BECollec_TR1_TABLES[(int) num2].get_PosY());
        if (this.o_BECollec_TR1_TABLES[(int) num2].get_Width() > 0)
          btnTablesButton.Size = new Size(this.o_BECollec_TR1_TABLES[(int) num2].get_Width(), this.o_BECollec_TR1_TABLES[(int) num2].get_Height());
        btnTablesButton.Visible = true;
        if (tableState.Equals(ModGeneralVar.g_BusinessCode.get_TABLE_LISTA()))
          btnTablesButton.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.libre_pax;
        else if (tableState.Equals(ModGeneralVar.g_BusinessCode.get_TABLE_OCUPADA()) & cantidad == 0)
          btnTablesButton.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.ocupado_pax;
        else if (tableState.Equals(ModGeneralVar.g_BusinessCode.get_TABLE_OCUPADA()) & cantidad > 0)
          btnTablesButton.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.precuenta_pax;
        else if (tableState.Equals(ModGeneralVar.g_BusinessCode.get_TABLE_RESERVADA()))
          btnTablesButton.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.reservado_pax;
        checked { ++num2; }
      }
      short count = checked ((short) this.o_BECollec_TR1_TABLES.Count);
      while (count <= (short) 199)
      {
        this.btnTablesButtons[(int) count].Visible = false;
        checked { ++count; }
      }
    }

    private void CreateButtonSalonesArray()
    {
      List<BE_TR1_FLOOR> beTr1FloorList = new BL_TR1_FLOOR().ListBasic(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId());
      this.shtCountHallCollection = checked ((short) beTr1FloorList.Count);
      this.btnHallButtons = new Button[checked ((int) this.shtCountHallCollection + 1)];
      short num1 = 23;
      short num2 = checked ((short) ((int) this.shtCountHallCollection - 1));
      short num3 = 0;
      while ((int) num3 <= (int) num2)
      {
        short num4;
        short num5 = checked ((short) (5 + (int) num4 * 95));
        this.btnHallButtons[(int) num3] = new Button();
        Button btnHallButton = this.btnHallButtons[(int) num3];
        if ((int) this.shtCountHallCollection > (int) num3)
        {
          btnHallButton.Text = beTr1FloorList[(int) num3].get_FloorDes();
          btnHallButton.Tag = (object) beTr1FloorList[(int) num3].get_FloorId();
        }
        btnHallButton.Font = new Font("Trebuchet MS", 11f, FontStyle.Bold);
        btnHallButton.ForeColor = Color.White;
        btnHallButton.Location = new Point((int) num5, (int) num1);
        btnHallButton.Size = new Size(95, 50);
        btnHallButton.BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.boton_piso;
        btnHallButton.FlatStyle = FlatStyle.Flat;
        btnHallButton.TextAlign = ContentAlignment.MiddleCenter;
        btnHallButton.Click += new EventHandler(this.Search_Table_By_Hall_Click);
        checked { ++num4; }
        if (num4 == (short) 10)
        {
          checked { num1 += (short) 76; }
          num4 = (short) 0;
        }
        checked { ++num3; }
      }
      this.gbFloor.Controls.AddRange((Control[]) this.btnHallButtons);
    }

    private void Search_Table_By_Hall_Click(object sender, EventArgs e)
    {
      if ((uint) Operators.CompareString(sender.GetType().FullName, "System.Windows.Forms.Button", false) > 0U)
        return;
      short num1 = checked ((short) ((int) this.shtCountHallCollection - 1));
      short num2 = 0;
      while ((int) num2 <= (int) num1)
      {
        this.btnHallButtons[(int) num2].BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.boton_piso_libre;
        checked { ++num2; }
      }
      this.int_PisoId = ModGeneralFunctions.CadenaToInteger(Conversions.ToString(NewLateBinding.LateGet(sender, (System.Type) null, "Tag", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)));
      BL_TR1_HALLS blTr1Halls = new BL_TR1_HALLS();
      BE_TR1_HALLS beTr1Halls = new BE_TR1_HALLS();
      blTr1Halls.ListById(this.int_PisoId).get_HallDes();
      this.FillButtonMesasArray(this.int_PisoId);
      this.CargarObjetos(this.int_PisoId);
      NewLateBinding.LateSet(sender, (System.Type) null, "BackgroundImage", new object[1]
      {
        (object) TriNetRestPOS.My.Resources.Resources.mesa_precuenta
      }, (string[]) null, (System.Type[]) null);
    }

    private void btnTablesButtons_Click(object sender, EventArgs e)
    {
      ModGeneralVar.g_bol_IsClose = false;
      ModGeneralVar.g_Str_TableID = Conversions.ToString(NewLateBinding.LateGet(sender, (System.Type) null, "tag", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      ModGeneralVar.g_Str_TableDes = Conversions.ToString(NewLateBinding.LateGet(sender, (System.Type) null, "Text", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      int pintCountSubTables = 0;
      if (!this.ShowSubTables(Conversions.ToInteger(ModGeneralVar.g_Str_TableID), ref pintCountSubTables))
        return;
      BL_TR1_TABLES blTr1Tables = new BL_TR1_TABLES();
      BE_TR1_TABLES beTr1Tables1 = new BE_TR1_TABLES();
      object Left = (object) 0;
      BE_TR1_TABLES beTr1Tables2 = blTr1Tables.ListById(Conversions.ToString(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId()), ModGeneralVar.g_Str_TableID);
      if (beTr1Tables2.get_TableState().Equals(ModGeneralVar.g_BusinessCode.get_TABLE_LISTA()))
        NewLateBinding.LateSet(sender, (System.Type) null, "BackgroundImage", new object[1]
        {
          (object) TriNetRestPOS.My.Resources.Resources.libre_pax
        }, (string[]) null, (System.Type[]) null);
      else if (Conversions.ToBoolean(Operators.AndObject((object) beTr1Tables2.get_TableState().Equals(ModGeneralVar.g_BusinessCode.get_TABLE_OCUPADA()), Operators.CompareObjectEqual(Left, (object) 0, false))))
        NewLateBinding.LateSet(sender, (System.Type) null, "BackgroundImage", new object[1]
        {
          (object) TriNetRestPOS.My.Resources.Resources.ocupado_pax
        }, (string[]) null, (System.Type[]) null);
      else if (Conversions.ToBoolean(Operators.AndObject((object) beTr1Tables2.get_TableState().Equals(ModGeneralVar.g_BusinessCode.get_TABLE_OCUPADA()), Operators.CompareObjectGreater(Left, (object) 0, false))))
        NewLateBinding.LateSet(sender, (System.Type) null, "BackgroundImage", new object[1]
        {
          (object) TriNetRestPOS.My.Resources.Resources.precuenta_pax
        }, (string[]) null, (System.Type[]) null);
      else if (beTr1Tables2.get_TableState().Equals(ModGeneralVar.g_BusinessCode.get_TABLE_RESERVADA()))
        NewLateBinding.LateSet(sender, (System.Type) null, "BackgroundImage", new object[1]
        {
          (object) TriNetRestPOS.My.Resources.Resources.reservado_pax
        }, (string[]) null, (System.Type[]) null);
      if (pintCountSubTables == 1)
      {
        if (this.IsViewRecepcion)
        {
          try
          {
            if (!Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, (System.Type) null, "BtnStyle", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) (emunType.XPStyle) 3, false))
              return;
            BL_TR1_RESERVES blTr1Reserves = new BL_TR1_RESERVES();
            BE_TR1_RESERVES beTr1Reserves = new BE_TR1_RESERVES();
            int num = (int) new FrmReserDetail(blTr1Reserves.ListByStateByTable(ModGeneralVar.g_BusinessCode.get_RESERVE_GENERADO(), Conversions.ToInteger(NewLateBinding.LateGet(sender, (System.Type) null, "tag", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)))).ShowDialog();
            return;
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
        }
        if (this.IsReservation)
        {
          if (beTr1Tables2.get_TableState().Equals(ModGeneralVar.g_BusinessCode.get_TABLE_OCUPADA()))
          {
            ModGeneralFunctions.MessageOk1("¡La Mesa se encuentra Ocupada!");
            return;
          }
          if (beTr1Tables2.get_TableState().Equals(ModGeneralVar.g_BusinessCode.get_TABLE_RESERVADA()))
          {
            ModGeneralFunctions.MessageOk1("¡La Mesa se encuentra Reservada!");
            return;
          }
          ModGeneralVar.g_Str_TableID = Conversions.ToString(NewLateBinding.LateGet(sender, (System.Type) null, "tag", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          ModGeneralVar.g_Str_TableDes = Conversions.ToString(NewLateBinding.LateGet(sender, (System.Type) null, "Text", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          this.Close();
          return;
        }
        if (ModGeneralVar.g_IsDelivery)
        {
          ModGeneralFunctions.MessageOk1("¡Por Favor Cambiar el Tipo de Orden!");
          return;
        }
        if ((uint) Operators.CompareString(sender.GetType().FullName, "System.Windows.Forms.Button", false) > 0U)
          return;
        object obj1 = NewLateBinding.LateGet(sender, (System.Type) null, "BackColor", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null);
        if ((obj1 != null ? (Color) obj1 : new Color()) == ModGeneralVar.color_Reserved)
        {
          ModGeneralFunctions.MessageOk1("La Mesa se Encuentra Reservada.");
          return;
        }
        int num1 = ModGeneralVar.g_Type_Operation.Equals(StructApp.ORDER_CREATE) ? 1 : 0;
        object obj2 = NewLateBinding.LateGet(sender, (System.Type) null, "BackColor", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null);
        int num2 = (obj2 != null ? (Color) obj2 : new Color()) == ModGeneralVar.color_BusyTable ? 1 : 0;
        if ((num1 & num2) != 0)
        {
          ModGeneralFunctions.MessageOk1("La Mesa se Encuentra Ocupada.");
          return;
        }
        int num3 = ModGeneralVar.g_Type_Operation.Equals(StructApp.ORDER_EDIT) ? 1 : 0;
        object obj3 = NewLateBinding.LateGet(sender, (System.Type) null, "BackColor", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null);
        int num4 = (obj3 != null ? (Color) obj3 : new Color()) == ModGeneralVar.color_FreeTable ? 1 : 0;
        if ((num3 & num4) != 0)
        {
          if (ModGeneralVar.g_RestrictEmptyTable)
          {
            ModGeneralFunctions.MessageOk1("No tiene un pedido asignado.");
            return;
          }
          ModGeneralVar.g_bolTableIsEmpty = true;
        }
        if (!ModGeneralVar.g_bol_IsChangetable)
        {
          if (beTr1Tables2.get_TableState().Equals(ModGeneralVar.g_BusinessCode.get_TABLE_LISTA()))
          {
            ModGeneralVar.g_Type_Operation = StructApp.ORDER_CREATE;
            ModGeneralVar.g_bol_IsReady = true;
            if (ModGeneralFunctions.PosTakeOrder())
            {
              if (ModGeneralVar.g_BE_TR1_CFGVARIABLES.get_ConfirmarPedido() && !ModGeneralFunctions.MessageMakeAction(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object) "¿Generar Pedido en la Mesa ", NewLateBinding.LateGet(sender, (System.Type) null, "text", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)), (object) "?")), false))
                return;
              ModGeneralVar.g_Str_RecordID = Conversions.ToString(ModGeneralVar.g_BE_USERS.get_UserIdLink());
            }
            else if (ModGeneralVar.g_BE_TR1_CFGVARIABLES.get_IsBoxWaiter())
            {
              BL_TR1_WAITER blTr1Waiter = new BL_TR1_WAITER();
              ModGeneralVar.g_Str_RecordID = "";
              ModGeneralFunctions.ShowSearchRecord((object) blTr1Waiter, this.Res_Title + ModGeneralVar.g_BE_TR1_VARIABLES_B.get_PersonDes() + ModGeneralFunctions.GetVocales(), "WAITER", "WaiterId", "WaiterDesShort", this.Res_Code, this.Res_Description, false, true, false, false, false, false, (BECollec_TR1_ORDERS) null, false, false, "", "", true, false, false, false, false);
              if (!ModGeneralVar.g_bol_IsReady)
                return;
              this.Str_WaiterID = ModGeneralVar.g_Str_RecordID;
              ModGeneralVar.g_Str_WaiterID = ModGeneralVar.g_Str_RecordID;
            }
            else
            {
              if (ModGeneralVar.g_BE_USERS.get_UserIdLink() == 0)
              {
                ModGeneralFunctions.MessageOk1("¡El Cajero no Tiene un " + ModGeneralVar.g_BE_TR1_VARIABLES_B.get_PersonDes() + " Asignado!");
                return;
              }
              this.Str_WaiterID = Conversions.ToString(ModGeneralVar.g_BE_USERS.get_UserIdLink());
              ModGeneralVar.g_Str_WaiterID = Conversions.ToString(ModGeneralVar.g_BE_USERS.get_UserIdLink());
            }
          }
          if (beTr1Tables2.get_TableState().Equals(ModGeneralVar.g_BusinessCode.get_TABLE_OCUPADA()) | beTr1Tables2.get_TableState().Equals(ModGeneralVar.g_BusinessCode.get_TABLE_RESERVADA()))
          {
            if (ModGeneralFunctions.PosTakeOrder())
            {
              BL_TR1_ORDERS blTr1Orders = new BL_TR1_ORDERS();
              string str = "";
              if (!new BL_TR1_USERS().Validate_Admin(ModGeneralVar.g_BE_USERS.get_UserId()) && !blTr1Orders.ValidateByWaiterbyOrder(Conversions.ToString(NewLateBinding.LateGet(sender, (System.Type) null, "Name", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)), ModGeneralVar.g_BE_USERS.get_UserIdLink(), Conversions.ToInteger(NewLateBinding.LateGet(sender, (System.Type) null, "tag", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)), ref str))
              {
                ModGeneralFunctions.MessageOk_Large("El Pedido Pertenece al " + ModGeneralVar.g_BE_TR1_VARIABLES_B.get_PersonDes() + ": " + str + " !!!", false);
                ModGeneralVar.g_Str_OrderID = "";
                return;
              }
              ModGeneralVar.g_Type_Operation = StructApp.ORDER_EDIT;
              ModGeneralVar.g_bol_IsReady = true;
              this.Close();
            }
            else if (!new BL_TR1_ORDERS().ValidateByBoxbyOrder(Conversions.ToString(NewLateBinding.LateGet(sender, (System.Type) null, "Name", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)), ModGeneralVar.g_BE_TR1_TURNS.get_TurnId()))
            {
              ModGeneralVar.g_Type_Operation = StructApp.ORDER_EDIT;
              ModGeneralVar.g_bol_IsReady = true;
              ModGeneralVar.g_Str_OrderID = Conversions.ToString(NewLateBinding.LateGet(sender, (System.Type) null, "Name", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
              this.Close();
            }
            else
            {
              ModGeneralFunctions.MessageOk1("¡El Pedido Pertenece a otro Turno!");
              ModGeneralVar.g_Str_OrderID = "";
              return;
            }
          }
          if (beTr1Tables2.get_TableState().Equals(ModGeneralVar.g_BusinessCode.get_TABLE_RESERVADA()))
          {
            ModGeneralFunctions.MessageOk("¡La Mesa se encuentra Reservada!");
            return;
          }
        }
        else if (beTr1Tables2.get_TableState().Equals(ModGeneralVar.g_BusinessCode.get_TABLE_LISTA()))
          ModGeneralVar.g_bolTableIsEmpty = true;
      }
      ModGeneralVar.g_Type_Order = StructApp.ORDER_TABLE;
      ModGeneralVar.g_Str_TableID = Conversions.ToString(NewLateBinding.LateGet(sender, (System.Type) null, "tag", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      ModGeneralVar.g_Str_TableDes = Conversions.ToString(NewLateBinding.LateGet(sender, (System.Type) null, "Text", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      ModGeneralVar.g_int_PisoId = this.int_PisoId;
      this.int_SalonId = ModGeneralFunctions.CadenaToInteger(Conversions.ToString(NewLateBinding.LateGet(sender, (System.Type) null, "TabIndex", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)));
      ModGeneralVar.g_bol_IsReady = true;
      if (pintCountSubTables == 1)
        ModGeneralVar.g_Str_OrderID = Conversions.ToString(NewLateBinding.LateGet(sender, (System.Type) null, "Name", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      if (ModGeneralVar.g_bol_IsReady)
        this.btnAccept_Click((object) this, (EventArgs) null);
    }

    private bool ShowSubTables(int pintTableId, ref int pintCountSubTables)
    {
      bool flag;
      try
      {
        BL_TR1_SUBTABLES blTr1Subtables = new BL_TR1_SUBTABLES();
        List<BE_TR1_SUBTABLES> beTr1SubtablesList = new List<BE_TR1_SUBTABLES>();
        int num1 = 0;
        List<BE_TR1_SUBTABLES> pListSUBTABLES = blTr1Subtables.ListByTableId(pintTableId, ModGeneralVar.g_BusinessCode.get_ORDER_PROCESO());
        if (this.IsReservation)
        {
          int num2 = checked (pListSUBTABLES.Count - 1);
          int index = 0;
          while (index <= num2)
          {
            if (pListSUBTABLES[index].get_SubTableState().Equals(ModGeneralVar.g_BusinessCode.get_TABLE_OCUPADA()) | pListSUBTABLES[index].get_SubTableState().Equals(ModGeneralVar.g_BusinessCode.get_TABLE_RESERVADA()))
              checked { ++num1; }
            checked { ++index; }
          }
        }
        else if (ModGeneralVar.g_bol_IsChangetable)
        {
          int num2 = checked (pListSUBTABLES.Count - 1);
          int index = 0;
          while (index <= num2)
          {
            if (pListSUBTABLES[index].get_SubTableState().Equals(ModGeneralVar.g_BusinessCode.get_TABLE_OCUPADA()) | pListSUBTABLES[index].get_SubTableState().Equals(ModGeneralVar.g_BusinessCode.get_TABLE_RESERVADA()))
              checked { ++num1; }
            checked { ++index; }
          }
        }
        else
        {
          int num2 = checked (pListSUBTABLES.Count - 1);
          int index = 0;
          while (index <= num2)
          {
            if (pListSUBTABLES[index].get_SubTableState().Equals(ModGeneralVar.g_BusinessCode.get_TABLE_OCUPADA()) | pListSUBTABLES[index].get_SubTableState().Equals(ModGeneralVar.g_BusinessCode.get_TABLE_RESERVADA()))
              checked { ++num1; }
            checked { ++index; }
          }
        }
        if (num1 > 1)
        {
          FrmSelectSubTable frmSelectSubTable = new FrmSelectSubTable(ModGeneralVar.g_Str_TableDes, pListSUBTABLES);
          frmSelectSubTable.IsImportOrder = this.IsImportOrder;
          int num2 = (int) frmSelectSubTable.ShowDialog();
          this.Str_WaiterID = frmSelectSubTable.Str_WaiterID;
          frmSelectSubTable.Dispose();
          this.btnActualizar_Click((object) null, (EventArgs) null);
          if (!ModGeneralVar.g_bol_IsReady)
          {
            flag = false;
            goto label_25;
          }
          else
            pintCountSubTables = pListSUBTABLES.Count;
        }
        else
        {
          ModGeneralVar.g_Str_SubTableID = Conversions.ToString(pListSUBTABLES[0].get_SubTableId());
          ModGeneralVar.g_Str_SubTableDes = "";
          ModGeneralVar.g_Str_OrderID = pListSUBTABLES[0].get_OrderId();
          pintCountSubTables = 1;
        }
        flag = true;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        flag = false;
        ProjectData.ClearProjectError();
      }
label_25:
      return flag;
    }

    private void btnActualizar_Click(object sender, EventArgs e)
    {
      BL_TR1_TABLES blTr1Tables = new BL_TR1_TABLES();
      string str = "";
      int num1 = checked ((int) this.shtCountTablesCollection - 1);
      int num2 = 0;
      while (num2 <= num1)
      {
        str = blTr1Tables.RepararxId(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId(), num2, ModGeneralVar.g_BusinessCode.get_ORDER_PROCESO(), ModGeneralVar.g_BusinessCode.get_TABLE_LISTA(), ModGeneralVar.g_BusinessCode.get_TABLE_OCUPADA());
        checked { ++num2; }
      }
      if (str.Equals(StructApp.RESULT_OK))
      {
        short num3 = checked ((short) ((int) this.shtCountHallCollection - 1));
        short num4 = 0;
        while ((int) num4 <= (int) num3)
        {
          if (this.btnHallButtons[(int) num4].Tag.Equals((object) this.int_PisoId))
            this.btnHallButtons[(int) num4].BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.boton_piso;
          else
            this.btnHallButtons[(int) num4].BackgroundImage = (Image) TriNetRestPOS.My.Resources.Resources.boton_piso_libre;
          checked { ++num4; }
        }
        BL_TR1_HALLS blTr1Halls = new BL_TR1_HALLS();
        BE_TR1_HALLS beTr1Halls = new BE_TR1_HALLS();
        blTr1Halls.ListById(this.int_PisoId).get_HallDes();
        this.FillButtonMesasArray(this.int_PisoId);
      }
      else
        ModGeneralFunctions.MessageError_Large("¡Error al reparar Mesa - " + str + "!", true);
    }

    private void btnWaiter_Click(object sender, EventArgs e)
    {
      BL_TR1_WAITER blTr1Waiter = new BL_TR1_WAITER();
      ModGeneralVar.g_Str_RecordID = "";
      ModGeneralFunctions.ShowSearchRecord((object) blTr1Waiter, this.Res_Title + ModGeneralVar.g_BE_TR1_VARIABLES_B.get_PersonDes(), "WAITER", "WaiterId", "WaiterDes", this.Res_Code, this.Res_Description, false, true, false, false, false, false, (BECollec_TR1_ORDERS) null, false, false, "", "", true, false, false, false, false);
      this.Str_WaiterID = ModGeneralVar.g_Str_RecordID;
    }

    public void btnAccept_Click(object sender, EventArgs e)
    {
      if (!this.IsImportOrder && ModGeneralVar.g_Type_Operation.Equals(StructApp.ORDER_CREATE) & this.int_OldPeople == 0 & ModGeneralVar.g_BE_TR1_VARIABLES_B.get_WithPeopleN() && (!ModGeneralVar.g_IsDelivery && ModGeneralVar.g_BE_TR1_CFGVARIABLES.get_ShowPeople()))
      {
        this.btnPeople_Click((object) this, (EventArgs) null);
        if (this.int_OldPeople == 0)
          return;
      }
      if (ModGeneralVar.g_Type_Operation.Equals(StructApp.ORDER_CREATE))
      {
        if (ModGeneralFunctions.PosTakeOrder())
          this.Str_WaiterID = ModGeneralVar.g_Str_WaiterID;
        if (!ModGeneralVar.g_IsDelivery && !ModGeneralVar.g_bol_IsReady | Strings.Len(RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.CompareString(this.Str_WaiterID, "", false) == 0, (object) ModGeneralVar.g_BE_USERS.get_WaiterId(), (object) this.Str_WaiterID))) == 0)
        {
          ModGeneralFunctions.MessageOk1("¡Debe Asignar un " + ModGeneralVar.g_BE_TR1_VARIABLES_B.get_PersonDes() + "!");
          return;
        }
        BL_TR1_TABLES blTr1Tables = new BL_TR1_TABLES();
        BL_TR1_SUBTABLES blTr1Subtables = new BL_TR1_SUBTABLES();
        string str1 = blTr1Tables.VerifState(checked ((int) Math.Round(ModGeneralFunctions.CadenaToDouble(ModGeneralVar.g_Str_TableID))));
        string str2 = blTr1Subtables.VerifState(checked ((int) Math.Round(ModGeneralFunctions.CadenaToDouble(ModGeneralVar.g_Str_SubTableID))));
        string Left1 = str1;
        if (Operators.CompareString(Left1, ModGeneralVar.g_BusinessCode.get_TABLE_OCUPADA(), false) == 0)
        {
          string Left2 = str2;
          if (Operators.CompareString(Left2, ModGeneralVar.g_BusinessCode.get_TABLE_OCUPADA(), false) == 0)
          {
            ModGeneralFunctions.MessageOk1("¡La Mesa se encuentra Ocupada!");
            this.btnActualizar_Click(RuntimeHelpers.GetObjectValue(sender), (EventArgs) null);
            return;
          }
          if (Operators.CompareString(Left2, ModGeneralVar.g_BusinessCode.get_TABLE_RESERVADA(), false) == 0)
          {
            ModGeneralFunctions.MessageOk1("¡La Mesa se encuentra Reservada!");
            this.btnActualizar_Click(RuntimeHelpers.GetObjectValue(sender), (EventArgs) null);
            return;
          }
        }
        else if (Operators.CompareString(Left1, ModGeneralVar.g_BusinessCode.get_TABLE_RESERVADA(), false) == 0)
        {
          string Left2 = str2;
          if (Operators.CompareString(Left2, ModGeneralVar.g_BusinessCode.get_TABLE_OCUPADA(), false) == 0)
          {
            ModGeneralFunctions.MessageOk1("¡La Mesa se encuentra Ocupada!");
            this.btnActualizar_Click(RuntimeHelpers.GetObjectValue(sender), (EventArgs) null);
            return;
          }
          if (Operators.CompareString(Left2, ModGeneralVar.g_BusinessCode.get_TABLE_RESERVADA(), false) == 0)
          {
            ModGeneralFunctions.MessageOk1("¡La Mesa se encuentra Reservada!");
            this.btnActualizar_Click(RuntimeHelpers.GetObjectValue(sender), (EventArgs) null);
            return;
          }
        }
        BL_TR1_ORDERS blTr1Orders = new BL_TR1_ORDERS();
        BE_TR1_ORDERS beTr1Orders = new BE_TR1_ORDERS();
        beTr1Orders.set_OrderTypeId(ModGeneralVar.g_Str_OrderTypeID_Default);
        beTr1Orders.set_HallId(this.int_SalonId);
        beTr1Orders.set_TableId(ModGeneralFunctions.CadenaToInteger(ModGeneralVar.g_Str_TableID));
        beTr1Orders.set_SubTableId(ModGeneralFunctions.CadenaToInteger(ModGeneralVar.g_Str_SubTableID));
        beTr1Orders.set_TurnId(ModGeneralVar.g_BE_TR1_TURNS.get_TurnId());
        beTr1Orders.set_BoxId(ModGeneralVar.g_BE_TR1_CFGVARIABLES.get_BoxIdPos());
        beTr1Orders.set_UserId(ModGeneralVar.g_BE_USERS.get_UserId());
        beTr1Orders.set_TypeChange(ModGeneralVar.g_BE_TR1_TURNS.get_TyChanSale());
        if (!ModGeneralFunctions.PosTakeOrder())
          beTr1Orders.set_PersonBox(ModGeneralVar.g_BE_USERS.get_UserId());
        if (ModGeneralVar.g_IsDelivery)
        {
          beTr1Orders.set_OrderTypeId(ModGeneralVar.g_Str_OrderTypeDelivery);
          beTr1Orders.set_DeliAgentId(ModGeneralVar.g_BE_TR1_AGENTDELIVERY.get_AgentId());
          beTr1Orders.set_OrderFree("Delivery");
        }
        else
        {
          beTr1Orders.set_WaiterId(Conversions.ToInteger(this.Str_WaiterID));
          beTr1Orders.set_OrderFree("");
          beTr1Orders.set_OldPeople(this.int_OldPeople);
          beTr1Orders.set_IsFree(false);
          beTr1Orders.set_IsDiscount(false);
          beTr1Orders.set_PerDiscount(0.0);
        }
        beTr1Orders.set_EstabliId(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId());
        beTr1Orders.set_OrderStateId(ModGeneralVar.g_BusinessCode.get_ORDER_PROCESO());
        ModGeneralVar.g_Str_OrderID = blTr1Orders.AddOrder(beTr1Orders, ModGeneralVar.g_BusinessCode.get_TABLE_OCUPADA());
      }
      ModGeneralVar.g_Str_OrderTypeID = ModGeneralVar.g_Str_OrderTypeID_Default;
      ModGeneralVar.g_bol_IsReady = true;
      this.Close();
    }

    private void btnNewFreeOrder_Click(object sender, EventArgs e)
    {
      ModGeneralVar.g_bol_IsReady = false;
      string Expression = "";
      if (!ModGeneralFunctions.TextKeyBoard("Motivo de Anunlación", ref Expression))
        return;
      if (Strings.Len(Expression) == 0)
      {
        ModGeneralFunctions.MessageOk1("Debe Ingresar una Descripción!!!");
      }
      else
      {
        BL_TR1_ORDERS blTr1Orders = new BL_TR1_ORDERS();
        BE_TR1_ORDERS beTr1Orders = new BE_TR1_ORDERS();
        beTr1Orders.set_IsFree(true);
        beTr1Orders.set_OrderFree(Expression);
        beTr1Orders.set_TurnId(ModGeneralVar.g_BE_TR1_TURNS.get_TurnId());
        beTr1Orders.set_BoxId(ModGeneralVar.g_BE_TR1_TURNS.get_BoxId());
        beTr1Orders.set_UserId(ModGeneralVar.g_BE_USERS.get_UserId());
        ModGeneralVar.g_Str_OrderID = blTr1Orders.AddOrder(beTr1Orders, ModGeneralVar.g_BusinessCode.get_TABLE_OCUPADA());
        this.Close();
      }
    }

    private void Btn_GoOut_Click(object sender, EventArgs e)
    {
      ModGeneralVar.g_bol_IsReady = false;
      this.Close();
    }

    private void btnPeople_Click(object sender, EventArgs e)
    {
      ModGeneralFunctions.NumberKeyBoard("INGRESE EL Nº DE PERSONAS", false);
      if (!ModGeneralVar.g_bol_IsReady)
        return;
      int integer = ModGeneralFunctions.CadenaToInteger(ModGeneralVar.g_str_InputValue);
      if (integer == 0)
        return;
      if (ModGeneralVar.g_BE_TR1_VARIABLES_B.get_IsPersonNum() & integer > ModGeneralVar.g_BE_TR1_VARIABLES_B.get_PersonNum())
        ModGeneralFunctions.MessageOk1("¡Nº Máximo de Personas es " + Conversions.ToString(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_PersonNum()) + "!");
      else
        this.int_OldPeople = integer;
    }

    private void btnSalir_Click(object sender, EventArgs e)
    {
      ModGeneralVar.g_bol_IsClose = true;
      ModGeneralVar.g_bol_IsReady = false;
      this.Close();
    }

    private void FrmChooseTable_KeyDown(object sender, KeyEventArgs e)
    {
      switch (e.KeyValue)
      {
        case 27:
          this.btnSalir_Click((object) null, (EventArgs) null);
          break;
        case 116:
          this.btnActualizar_Click((object) null, (EventArgs) null);
          break;
      }
    }

    private void UbicarMesa(int pintTableId)
    {
      int num = checked (this.btnTablesButtons.Length - 1);
      int index = 0;
      while (index <= num)
      {
        if (this.btnTablesButtons[index].Tag.Equals((object) pintTableId))
        {
          this.btnTablesButtons_Click((object) this.btnTablesButtons[index], (EventArgs) null);
          break;
        }
        checked { ++index; }
      }
    }

    private void CargarObjetos(int pintPisoId)
    {
      this.EliminarObjetos();
      BL_TR1_FLOOR_DET blTr1FloorDet = new BL_TR1_FLOOR_DET();
      List<BE_TR1_FLOOR_DET> beTr1FloorDetList1 = new List<BE_TR1_FLOOR_DET>();
      List<BE_TR1_FLOOR_DET> beTr1FloorDetList2 = blTr1FloorDet.ListarxPiso(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId(), pintPisoId);
      Button[] buttonArray = new Button[checked (beTr1FloorDetList2.Count - 1 + 1)];
      int num = checked (beTr1FloorDetList2.Count - 1);
      int index = 0;
      while (index <= num)
      {
        buttonArray[index] = new Button();
        Button button = buttonArray[index];
        button.Font = new Font("Trebuchet MS", 11f, FontStyle.Bold);
        button.BackColor = Color.FromArgb(100, 100, 100);
        button.ForeColor = Color.FromArgb(100, 100, 100);
        button.FlatStyle = FlatStyle.Flat;
        button.Size = new Size(beTr1FloorDetList2[index].get_Width(), beTr1FloorDetList2[index].get_Height());
        button.Location = new Point(beTr1FloorDetList2[index].get_PosX(), beTr1FloorDetList2[index].get_PosY());
        button.BringToFront();
        checked { ++index; }
      }
      this.Controls.AddRange((Control[]) buttonArray);
    }

    private void EliminarObjetos()
    {
      try
      {
        foreach (Control control in this.Controls)
        {
          if (Operators.CompareString(control.GetType().Name, "MyXPButton", false) == 0)
            control.Visible = false;
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }

    private void mnuMesas_Opened(object sender, EventArgs e)
    {
      this.mnuMesas.Tag = RuntimeHelpers.GetObjectValue(((ContextMenuStrip) sender).SourceControl.Tag);
    }

    private void mnuReparar_Click(object sender, EventArgs e)
    {
      this.RepararxMesa(ModGeneralFunctions.CadenaToInteger(Conversions.ToString(this.mnuMesas.Tag)));
    }

    private void RepararxMesa(int pintMesaId)
    {
      BL_TR1_TABLES blTr1Tables = new BL_TR1_TABLES();
      string str1 = "";
      string str2 = blTr1Tables.RepararxId(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId(), pintMesaId, ModGeneralVar.g_BusinessCode.get_ORDER_PROCESO(), ModGeneralVar.g_BusinessCode.get_TABLE_LISTA(), ModGeneralVar.g_BusinessCode.get_TABLE_OCUPADA());
      if (str2.Equals(StructApp.RESULT_OK))
        this.btnActualizar_Click((object) null, (EventArgs) null);
      else
        ModGeneralFunctions.MessageError_Large("¡Error al reparar Mesa - " + str2 + "!", true);
      str1 = (string) null;
    }
  }
}
