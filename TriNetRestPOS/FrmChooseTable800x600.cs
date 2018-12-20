// Decompiled with JetBrains decompiler
// Type: TriNetRestPOS.FrmChooseTable800x600
// Assembly: TriNetRestPOS, Version=5.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 43377352-E952-4AC1-9BA6-CCBE4AE5F575
// Assembly location: C:\log\TriNetRestPOS.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MyXPButton;
using MyXPButtonTables;
using System;
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
  public class FrmChooseTable800x600 : Form
  {
    private IContainer components;
    private BECollec_TR1_MASTERTABLE o_BEC_MASTERTABLE;
    private MyXPButtonTables.MyXPButtonTables[] btnTablesButtons;
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
    private MyXPButton.MyXPButton[] btnHallButtons;
    public int int_HallId;
    public string str_HallDes;
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
      this.MyXPButtonTables2 = new MyXPButtonTables.MyXPButtonTables();
      this.mnuReparar = new ToolStripMenuItem();
      this.Label2 = new Label();
      this.GroupBox_Halls = new GroupBox();
      this.Button_Refresh = new Button();
      this.Label1 = new Label();
      this.mnuMesas = new ContextMenuStrip(this.components);
      this.Button_GoOut = new Button();
      this.MyXPButtonTables1 = new MyXPButtonTables.MyXPButtonTables();
      this.MyXPButtonTables_Free = new MyXPButtonTables.MyXPButtonTables();
      this.ToolTip = new ToolTip(this.components);
      this.Label_Free = new Label();
      this.GroupBox_StateTable = new GroupBox();
      this.MyXPButtonTables_Ocup = new MyXPButtonTables.MyXPButtonTables();
      this.Label_Busy = new Label();
      this.mnuMesas.SuspendLayout();
      this.GroupBox_StateTable.SuspendLayout();
      this.SuspendLayout();
      this.MyXPButtonTables2.set_AdjustImageLocation(new Point(0, 0));
      this.MyXPButtonTables2.set_BtnShape((emunType.BtnShape) 1);
      this.MyXPButtonTables2.set_BtnStyle((emunType.XPStyle) 5);
      ((Control) this.MyXPButtonTables2).Location = new Point(269, 49);
      ((Control) this.MyXPButtonTables2).Name = "MyXPButtonTables2";
      ((Control) this.MyXPButtonTables2).Size = new Size(75, 34);
      ((Control) this.MyXPButtonTables2).TabIndex = 9;
      ((ButtonBase) this.MyXPButtonTables2).UseVisualStyleBackColor = true;
      this.mnuReparar.Image = (Image) TriNetRestPOS.My.Resources.Resources.Refresh;
      this.mnuReparar.Name = "mnuReparar";
      this.mnuReparar.Size = new Size(200, 24);
      this.mnuReparar.Text = "Actualizar Estado";
      this.Label2.AutoSize = true;
      this.Label2.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label2.Location = new Point(266, 27);
      this.Label2.Name = "Label2";
      this.Label2.Size = new Size(82, 20);
      this.Label2.TabIndex = 10;
      this.Label2.Text = "Precuenta";
      this.GroupBox_Halls.BackColor = Color.WhiteSmoke;
      this.GroupBox_Halls.Font = new Font("Trebuchet MS", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.GroupBox_Halls.ForeColor = Color.Red;
      this.GroupBox_Halls.Location = new Point(3, -1);
      this.GroupBox_Halls.Name = "GroupBox_Halls";
      this.GroupBox_Halls.Size = new Size(788, 81);
      this.GroupBox_Halls.TabIndex = 181;
      this.GroupBox_Halls.TabStop = false;
      this.GroupBox_Halls.Text = "Salón:";
      this.Button_Refresh.BackColor = Color.WhiteSmoke;
      this.Button_Refresh.Font = new Font("Trebuchet MS", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_Refresh.ForeColor = Color.MediumBlue;
      this.Button_Refresh.Image = (Image) TriNetRestPOS.My.Resources.Resources.i_Refresh;
      this.Button_Refresh.ImageAlign = ContentAlignment.BottomCenter;
      this.Button_Refresh.Location = new Point(561, 500);
      this.Button_Refresh.Name = "Button_Refresh";
      this.Button_Refresh.Size = new Size(114, 70);
      this.Button_Refresh.TabIndex = 182;
      this.Button_Refresh.Text = "&REFRESCAR";
      this.Button_Refresh.TextAlign = ContentAlignment.TopCenter;
      this.Button_Refresh.UseVisualStyleBackColor = false;
      this.Label1.AutoSize = true;
      this.Label1.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label1.Location = new Point(180, 27);
      this.Label1.Name = "Label1";
      this.Label1.Size = new Size(82, 20);
      this.Label1.TabIndex = 8;
      this.Label1.Text = "Reservada";
      this.mnuMesas.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.mnuMesas.Items.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.mnuReparar
      });
      this.mnuMesas.Name = "mnuDesing";
      this.mnuMesas.Size = new Size(201, 28);
      this.Button_GoOut.BackColor = Color.WhiteSmoke;
      this.Button_GoOut.Font = new Font("Trebuchet MS", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_GoOut.ForeColor = Color.MediumBlue;
      this.Button_GoOut.Image = (Image) TriNetRestPOS.My.Resources.Resources.i_Close;
      this.Button_GoOut.ImageAlign = ContentAlignment.BottomCenter;
      this.Button_GoOut.Location = new Point(678, 500);
      this.Button_GoOut.Name = "Button_GoOut";
      this.Button_GoOut.Size = new Size(114, 70);
      this.Button_GoOut.TabIndex = 180;
      this.Button_GoOut.Text = "&SALIR";
      this.Button_GoOut.TextAlign = ContentAlignment.TopCenter;
      this.Button_GoOut.UseVisualStyleBackColor = false;
      this.MyXPButtonTables1.set_AdjustImageLocation(new Point(0, 0));
      this.MyXPButtonTables1.set_BtnShape((emunType.BtnShape) 1);
      this.MyXPButtonTables1.set_BtnStyle((emunType.XPStyle) 3);
      ((Control) this.MyXPButtonTables1).Location = new Point(183, 49);
      ((Control) this.MyXPButtonTables1).Name = "MyXPButtonTables1";
      ((Control) this.MyXPButtonTables1).Size = new Size(75, 34);
      ((Control) this.MyXPButtonTables1).TabIndex = 7;
      ((ButtonBase) this.MyXPButtonTables1).UseVisualStyleBackColor = true;
      this.MyXPButtonTables_Free.set_AdjustImageLocation(new Point(0, 0));
      this.MyXPButtonTables_Free.set_BtnShape((emunType.BtnShape) 1);
      this.MyXPButtonTables_Free.set_BtnStyle((emunType.XPStyle) 1);
      ((Control) this.MyXPButtonTables_Free).Location = new Point(9, 49);
      ((Control) this.MyXPButtonTables_Free).Name = "MyXPButtonTables_Free";
      ((Control) this.MyXPButtonTables_Free).Size = new Size(75, 34);
      ((Control) this.MyXPButtonTables_Free).TabIndex = 5;
      ((ButtonBase) this.MyXPButtonTables_Free).UseVisualStyleBackColor = true;
      this.ToolTip.BackColor = Color.NavajoWhite;
      this.ToolTip.IsBalloon = true;
      this.ToolTip.ShowAlways = true;
      this.ToolTip.ToolTipIcon = ToolTipIcon.Info;
      this.ToolTip.ToolTipTitle = "TriNetRestPOS";
      this.Label_Free.AutoSize = true;
      this.Label_Free.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label_Free.Location = new Point(26, 27);
      this.Label_Free.Name = "Label_Free";
      this.Label_Free.Size = new Size(45, 20);
      this.Label_Free.TabIndex = 2;
      this.Label_Free.Text = "Libre";
      this.GroupBox_StateTable.Controls.Add((Control) this.Label2);
      this.GroupBox_StateTable.Controls.Add((Control) this.MyXPButtonTables2);
      this.GroupBox_StateTable.Controls.Add((Control) this.Label1);
      this.GroupBox_StateTable.Controls.Add((Control) this.MyXPButtonTables1);
      this.GroupBox_StateTable.Controls.Add((Control) this.MyXPButtonTables_Ocup);
      this.GroupBox_StateTable.Controls.Add((Control) this.MyXPButtonTables_Free);
      this.GroupBox_StateTable.Controls.Add((Control) this.Label_Busy);
      this.GroupBox_StateTable.Controls.Add((Control) this.Label_Free);
      this.GroupBox_StateTable.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.GroupBox_StateTable.ForeColor = Color.MediumBlue;
      this.GroupBox_StateTable.Location = new Point(3, 481);
      this.GroupBox_StateTable.Name = "GroupBox_StateTable";
      this.GroupBox_StateTable.Size = new Size(356, 88);
      this.GroupBox_StateTable.TabIndex = 179;
      this.GroupBox_StateTable.TabStop = false;
      this.GroupBox_StateTable.Text = "Estado de Mesas";
      this.MyXPButtonTables_Ocup.set_AdjustImageLocation(new Point(0, 0));
      this.MyXPButtonTables_Ocup.set_BtnShape((emunType.BtnShape) 1);
      this.MyXPButtonTables_Ocup.set_BtnStyle((emunType.XPStyle) 2);
      ((Control) this.MyXPButtonTables_Ocup).Location = new Point(96, 49);
      ((Control) this.MyXPButtonTables_Ocup).Name = "MyXPButtonTables_Ocup";
      ((Control) this.MyXPButtonTables_Ocup).Size = new Size(75, 34);
      ((Control) this.MyXPButtonTables_Ocup).TabIndex = 6;
      ((ButtonBase) this.MyXPButtonTables_Ocup).UseVisualStyleBackColor = true;
      this.Label_Busy.AutoSize = true;
      this.Label_Busy.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label_Busy.Location = new Point(98, 27);
      this.Label_Busy.Name = "Label_Busy";
      this.Label_Busy.Size = new Size(71, 20);
      this.Label_Busy.TabIndex = 4;
      this.Label_Busy.Text = "Ocupada";
      this.AutoScaleDimensions = new SizeF(9f, 20f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.WhiteSmoke;
      this.ClientSize = new Size(794, 572);
      this.Controls.Add((Control) this.GroupBox_Halls);
      this.Controls.Add((Control) this.Button_Refresh);
      this.Controls.Add((Control) this.Button_GoOut);
      this.Controls.Add((Control) this.GroupBox_StateTable);
      this.Font = new Font("Trebuchet MS", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.KeyPreview = true;
      this.Margin = new Padding(4, 5, 4, 5);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (FrmChooseTable800x600);
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Elegir Mesa";
      this.mnuMesas.ResumeLayout(false);
      this.GroupBox_StateTable.ResumeLayout(false);
      this.GroupBox_StateTable.PerformLayout();
      this.ResumeLayout(false);
    }

    internal virtual MyXPButtonTables.MyXPButtonTables MyXPButtonTables2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

    internal virtual GroupBox GroupBox_Halls { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button_Refresh
    {
      get
      {
        return this._Button_Refresh;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_Refresh_Click);
        Button buttonRefresh1 = this._Button_Refresh;
        if (buttonRefresh1 != null)
          buttonRefresh1.Click -= eventHandler;
        this._Button_Refresh = value;
        Button buttonRefresh2 = this._Button_Refresh;
        if (buttonRefresh2 == null)
          return;
        buttonRefresh2.Click += eventHandler;
      }
    }

    internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

    internal virtual Button Button_GoOut
    {
      get
      {
        return this._Button_GoOut;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_GoOut_Click);
        Button buttonGoOut1 = this._Button_GoOut;
        if (buttonGoOut1 != null)
          buttonGoOut1.Click -= eventHandler;
        this._Button_GoOut = value;
        Button buttonGoOut2 = this._Button_GoOut;
        if (buttonGoOut2 == null)
          return;
        buttonGoOut2.Click += eventHandler;
      }
    }

    internal virtual MyXPButtonTables.MyXPButtonTables MyXPButtonTables1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual MyXPButtonTables.MyXPButtonTables MyXPButtonTables_Free { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolTip ToolTip { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label_Free { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual GroupBox GroupBox_StateTable { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual MyXPButtonTables.MyXPButtonTables MyXPButtonTables_Ocup { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label_Busy { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    public FrmChooseTable800x600(int int_HallId)
    {
      this.Load += new EventHandler(this.FrmChooseTable800x600_Load);
      this.Click += new EventHandler(this.Search_Table_By_Hall_Click);
      this.Click += new EventHandler(this.btnTablesButtons_Click);
      this.KeyDown += new KeyEventHandler(this.FrmChooseTable_KeyDown);
      this.IsReservation = false;
      this.IsViewRecepcion = false;
      this.IsImportOrder = false;
      this.bolUbicarMesa = false;
      this.int_HallId = int_HallId;
      this.InitializeComponent();
    }

    private void FrmChooseTable800x600_Load(object sender, EventArgs e)
    {
      this.Resource(ModGeneralFunctions.Get_Language((object) this));
      ModGeneralVar.g_Str_TableID = "";
      if (ModGeneralVar.g_bol_IsChangetable)
      {
        this.CreateButtonSalonesArray();
        this.GroupBox_Halls.Visible = true;
      }
      else
      {
        this.CreateButtonSalonesArray();
        this.GroupBox_Halls.Visible = true;
      }
      short num1 = checked ((short) ((int) this.shtCountHallCollection - 1));
      short num2 = 0;
      while ((int) num2 <= (int) num1)
      {
        if (((Control) this.btnHallButtons[(int) num2]).Tag.Equals((object) this.int_HallId))
          this.btnHallButtons[(int) num2].set_BtnStyle((emunType.XPStyle) 1);
        else
          this.btnHallButtons[(int) num2].set_BtnStyle((emunType.XPStyle) 2);
        checked { ++num2; }
      }
      this.CreateButtonMesasArray();
      this.FillButtonMesasArray(this.int_HallId);
      if (!this.bolUbicarMesa)
        return;
      this.UbicarMesa(this.intTableId);
    }

    private void Resource(ResourceManager Rm)
    {
      this.GroupBox_StateTable.Text = Rm.GetString("Res_StateTable");
      this.Button_GoOut.Text = Strings.UCase(Rm.GetString("Res_Exit"));
      this.Label_Free.Text = Rm.GetString("Res_Free");
      this.Label_Busy.Text = Rm.GetString("Res_busy");
      this.Res_OrderFree = Rm.GetString("Res_OrderFree");
      this.Res_MsgOk_O = Rm.GetString("Res_MsgOk_O");
      this.Res_Title = Rm.GetString("Res_ListMaintenance");
      this.Res_Code = Rm.GetString("Res_Code");
      this.Res_Description = Rm.GetString("Res_Description");
      this.Res_HallDes = Rm.GetString("Res_HallR");
    }

    private void CreateButtonMesasArray()
    {
      short num1 = 0;
      this.shtCountTablesCollection = (short) 70;
      this.btnTablesButtons = new MyXPButtonTables.MyXPButtonTables[checked ((int) this.shtCountTablesCollection + 1)];
      short num2 = !ModGeneralVar.g_bol_IsChangetable ? (short) 82 : (short) 82;
      short num3 = 100;
      short num4 = 78;
      short num5 = checked ((short) ((int) this.shtCountTablesCollection - 1));
      short num6 = 0;
      while ((int) num6 <= (int) num5)
      {
        short num7;
        short num8 = checked ((short) (0 + (int) num7 * ((int) num3 + 2)));
        this.btnTablesButtons[(int) num6] = new MyXPButtonTables.MyXPButtonTables();
        this.btnTablesButtons[(int) num6].set_BtnShape((emunType.BtnShape) 1);
        MyXPButtonTables.MyXPButtonTables btnTablesButton = this.btnTablesButtons[(int) num6];
        ((Control) btnTablesButton).ForeColor = Color.WhiteSmoke;
        ((Control) btnTablesButton).Font = new Font("Tahoma", 16f, FontStyle.Bold);
        ((Control) btnTablesButton).Location = new Point((int) num8, (int) num2);
        ((Control) btnTablesButton).Size = new Size((int) num3, (int) num4);
        ((Control) btnTablesButton).ContextMenuStrip = this.mnuMesas;
        ((Control) btnTablesButton).SendToBack();
        ((Control) btnTablesButton).Click += new EventHandler(this.btnTablesButtons_Click);
        checked { ++num7; }
        if (num7 == (short) 8)
        {
          checked { num2 += unchecked ((short) checked ((int) num4 + 2)); }
          num7 = (short) 0;
        }
        checked { ++num6; }
      }
      this.Controls.AddRange((Control[]) this.btnTablesButtons);
      num1 = (short) 0;
    }

    private void FillButtonMesasArray(int pintSalonId)
    {
      this.o_BECollec_TR1_TABLES = new BL_TR1_TABLES().ListarxSalon(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_EstabliId(), pintSalonId, ModGeneralVar.g_BusinessCode.get_ORDER_PROCESO(), ModGeneralVar.g_BusinessCode.get_TABLE_OCUPADA());
      this.shtCountTablesCollection = (short) 70;
      short num1 = 0;
      if (this.shtCountTablesCollection > (short) 70)
        this.shtCountTablesCollection = (short) 70;
      short num2 = 0;
      short num3 = 0;
      string str1 = "";
      int num4 = 0;
      short num5 = !ModGeneralVar.g_bol_IsChangetable ? (short) 82 : (short) 82;
      short num6 = 100;
      short num7 = 78;
      short num8 = checked ((short) (this.o_BECollec_TR1_TABLES.Count - 1));
      short num9 = 0;
      while ((int) num9 <= (int) num8)
      {
        string tableState = this.o_BECollec_TR1_TABLES[(int) num9].get_TableState();
        int cantidad = this.o_BECollec_TR1_TABLES[(int) num9].get_Cantidad();
        MyXPButtonTables.MyXPButtonTables btnTablesButton = this.btnTablesButtons[(int) num9];
        ((Control) btnTablesButton).Name = this.o_BECollec_TR1_TABLES[(int) num9].get_OrderId();
        ((ButtonBase) btnTablesButton).Text = this.o_BECollec_TR1_TABLES[(int) num9].get_TableDes();
        if (!this.o_BECollec_TR1_TABLES[(int) num9].get_WaiterDesShort().Equals(""))
        {
          MyXPButtonTables.MyXPButtonTables myXpButtonTables;
          string str2 = ((ButtonBase) (myXpButtonTables = btnTablesButton)).Text + " - " + this.o_BECollec_TR1_TABLES[(int) num9].get_WaiterDesShort();
          ((ButtonBase) myXpButtonTables).Text = str2;
        }
        ((Control) btnTablesButton).Tag = (object) this.o_BECollec_TR1_TABLES[(int) num9].get_TableId();
        ((Control) btnTablesButton).Visible = true;
        if (tableState.Equals(ModGeneralVar.g_BusinessCode.get_TABLE_LISTA()))
          btnTablesButton.set_BtnStyle((emunType.XPStyle) 1);
        else if (tableState.Equals(ModGeneralVar.g_BusinessCode.get_TABLE_OCUPADA()) & cantidad == 0)
          btnTablesButton.set_BtnStyle((emunType.XPStyle) 2);
        else if (tableState.Equals(ModGeneralVar.g_BusinessCode.get_TABLE_OCUPADA()) & cantidad > 0)
          btnTablesButton.set_BtnStyle((emunType.XPStyle) 5);
        else if (tableState.Equals(ModGeneralVar.g_BusinessCode.get_TABLE_RESERVADA()))
          btnTablesButton.set_BtnStyle((emunType.XPStyle) 3);
        checked { ++num9; }
      }
      short count = checked ((short) this.o_BECollec_TR1_TABLES.Count);
      while (count <= (short) 69)
      {
        ((Control) this.btnTablesButtons[(int) count]).Visible = false;
        checked { ++count; }
      }
      num1 = (short) 0;
      num2 = (short) 0;
      num5 = (short) 0;
      num3 = (short) 0;
      num6 = (short) 0;
      num7 = (short) 0;
      str1 = (string) null;
      num4 = 0;
    }

    private void CreateButtonSalonesArray()
    {
      List<BE_TR1_HALLS> beTr1HallsList = new BL_TR1_HALLS().ListBasic();
      this.shtCountHallCollection = checked ((short) beTr1HallsList.Count);
      this.btnHallButtons = new MyXPButton.MyXPButton[checked ((int) this.shtCountHallCollection + 1)];
      short num1 = 23;
      short num2 = checked ((short) ((int) this.shtCountHallCollection - 1));
      short num3 = 0;
      while ((int) num3 <= (int) num2)
      {
        short num4;
        short num5 = checked ((short) (5 + (int) num4 * 95));
        this.btnHallButtons[(int) num3] = new MyXPButton.MyXPButton();
        MyXPButton.MyXPButton btnHallButton = this.btnHallButtons[(int) num3];
        if ((int) this.shtCountHallCollection > (int) num3)
        {
          ((ButtonBase) btnHallButton).Text = beTr1HallsList[(int) num3].get_HallDes();
          ((Control) btnHallButton).Tag = (object) beTr1HallsList[(int) num3].get_HallId();
        }
        ((Control) btnHallButton).Font = new Font("Trebuchet MS", 11f, FontStyle.Bold);
        ((Control) btnHallButton).ForeColor = Color.MediumBlue;
        ((Control) btnHallButton).Location = new Point((int) num5, (int) num1);
        ((Control) btnHallButton).Size = new Size(95, 50);
        btnHallButton.set_BtnStyle((emunType.XPStyle) 2);
        ((Control) btnHallButton).Click += new EventHandler(this.Search_Table_By_Hall_Click);
        checked { ++num4; }
        if (num4 == (short) 8)
        {
          checked { num1 += (short) 76; }
          num4 = (short) 0;
        }
        checked { ++num3; }
      }
      this.GroupBox_Halls.Controls.AddRange((Control[]) this.btnHallButtons);
    }

    private void Search_Table_By_Hall_Click(object sender, EventArgs e)
    {
      if ((uint) Operators.CompareString(sender.GetType().FullName, "MyXPButton.MyXPButton", false) > 0U)
        return;
      short num1 = checked ((short) ((int) this.shtCountHallCollection - 1));
      short num2 = 0;
      while ((int) num2 <= (int) num1)
      {
        this.btnHallButtons[(int) num2].set_BtnStyle((emunType.XPStyle) 2);
        checked { ++num2; }
      }
      this.int_HallId = Convert.ToInt32(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(sender, (System.Type) null, "Tag", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)));
      BL_TR1_HALLS blTr1Halls = new BL_TR1_HALLS();
      BE_TR1_HALLS beTr1Halls = new BE_TR1_HALLS();
      blTr1Halls.ListById(this.int_HallId).get_HallDes();
      this.FillButtonMesasArray(this.int_HallId);
      NewLateBinding.LateSet(sender, (System.Type) null, "BtnStyle", new object[1]
      {
        (object) (emunType.XPStyle) 1
      }, (string[]) null, (System.Type[]) null);
      ModGeneralFunctions.EditarAPPCONFIG("SALONID", Conversions.ToString(this.int_HallId));
    }

    private void btnTablesButtons_Click(object sender, EventArgs e)
    {
      ModGeneralVar.g_bol_IsClose = false;
      ModGeneralVar.g_Str_TableID = Conversions.ToString(NewLateBinding.LateGet(sender, (System.Type) null, "tag", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      ModGeneralVar.g_Str_TableDes = Conversions.ToString(NewLateBinding.LateGet(sender, (System.Type) null, "Text", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      int pintCountSubTables = 0;
      if (!this.ShowSubTables(Conversions.ToInteger(ModGeneralVar.g_Str_TableID), ref pintCountSubTables))
        return;
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
          if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, (System.Type) null, "BtnStyle", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) (emunType.XPStyle) 2, false))
          {
            ModGeneralFunctions.MessageOk("¡La Mesa se encuentra Ocupada!");
            return;
          }
          if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, (System.Type) null, "BtnStyle", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) (emunType.XPStyle) 3, false))
          {
            ModGeneralFunctions.MessageOk("¡La Mesa se encuentra Reservada!");
            return;
          }
          ModGeneralVar.g_Str_TableID = Conversions.ToString(NewLateBinding.LateGet(sender, (System.Type) null, "tag", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          ModGeneralVar.g_Str_TableDes = Conversions.ToString(NewLateBinding.LateGet(sender, (System.Type) null, "Text", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          this.Close();
          return;
        }
        if (ModGeneralVar.g_IsDelivery)
        {
          ModGeneralFunctions.MessageOk("¡Por Favor Cambiar el Tipo de Orden!");
          return;
        }
        if ((uint) Operators.CompareString(sender.GetType().FullName, "MyXPButtonTables.MyXPButtonTables", false) > 0U)
          return;
        object obj1 = NewLateBinding.LateGet(sender, (System.Type) null, "BackColor", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null);
        if ((obj1 != null ? (Color) obj1 : new Color()) == ModGeneralVar.color_Reserved)
        {
          ModGeneralFunctions.MessageOk("La Mesa se Encuentra Reservada.");
          return;
        }
        int num1 = ModGeneralVar.g_Type_Operation.Equals(StructApp.ORDER_CREATE) ? 1 : 0;
        object obj2 = NewLateBinding.LateGet(sender, (System.Type) null, "BackColor", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null);
        int num2 = (obj2 != null ? (Color) obj2 : new Color()) == ModGeneralVar.color_BusyTable ? 1 : 0;
        if ((num1 & num2) != 0)
        {
          ModGeneralFunctions.MessageOk("La Mesa se Encuentra Ocupada.");
          return;
        }
        int num3 = ModGeneralVar.g_Type_Operation.Equals(StructApp.ORDER_EDIT) ? 1 : 0;
        object obj3 = NewLateBinding.LateGet(sender, (System.Type) null, "BackColor", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null);
        int num4 = (obj3 != null ? (Color) obj3 : new Color()) == ModGeneralVar.color_FreeTable ? 1 : 0;
        if ((num3 & num4) != 0)
        {
          if (ModGeneralVar.g_RestrictEmptyTable)
          {
            ModGeneralFunctions.MessageOk("No tiene un pedido asignado.");
            return;
          }
          ModGeneralVar.g_bolTableIsEmpty = true;
        }
        if (!ModGeneralVar.g_bol_IsChangetable)
        {
          if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, (System.Type) null, "BtnStyle", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) (emunType.XPStyle) 1, false))
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
                ModGeneralFunctions.MessageOk("¡El Cajero no Tiene un " + ModGeneralVar.g_BE_TR1_VARIABLES_B.get_PersonDes() + " Asignado!");
                return;
              }
              this.Str_WaiterID = Conversions.ToString(ModGeneralVar.g_BE_USERS.get_UserIdLink());
              ModGeneralVar.g_Str_WaiterID = Conversions.ToString(ModGeneralVar.g_BE_USERS.get_UserIdLink());
            }
          }
          if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(sender, (System.Type) null, "BtnStyle", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) (emunType.XPStyle) 2, false), Operators.CompareObjectEqual(NewLateBinding.LateGet(sender, (System.Type) null, "BtnStyle", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) (emunType.XPStyle) 5, false))))
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
              ModGeneralVar.g_Str_OrderID = Conversions.ToString(NewLateBinding.LateGet(sender, (System.Type) null, "Name", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
              this.Close();
            }
            else if (!new BL_TR1_ORDERS().ValidateByBoxbyOrder(Conversions.ToString(NewLateBinding.LateGet(sender, (System.Type) null, "Name", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)), ModGeneralVar.g_BE_TR1_TURNS.get_TurnId()))
            {
              ModGeneralVar.g_Type_Operation = StructApp.ORDER_EDIT;
              ModGeneralVar.g_bol_IsReady = true;
              this.Close();
            }
            else
            {
              ModGeneralFunctions.MessageOk("¡El Pedido Pertenece a otro Turno!");
              ModGeneralVar.g_Str_OrderID = "";
              return;
            }
          }
          if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, (System.Type) null, "BtnStyle", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) (emunType.XPStyle) 3, false))
          {
            ModGeneralFunctions.MessageOk("¡La Mesa se encuentra Reservada!");
            return;
          }
        }
        else if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, (System.Type) null, "BtnStyle", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) (emunType.XPStyle) 1, false))
          ModGeneralVar.g_bolTableIsEmpty = true;
      }
      ModGeneralVar.g_Type_Order = StructApp.ORDER_TABLE;
      ModGeneralVar.g_Str_TableID = Conversions.ToString(NewLateBinding.LateGet(sender, (System.Type) null, "tag", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      ModGeneralVar.g_Str_TableDes = Conversions.ToString(NewLateBinding.LateGet(sender, (System.Type) null, "Text", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      ModGeneralVar.g_int_HallId = this.int_HallId;
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
          this.Button_Refresh_Click((object) null, (EventArgs) null);
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
          ModGeneralFunctions.MessageOk("¡Debe Asignar un " + ModGeneralVar.g_BE_TR1_VARIABLES_B.get_PersonDes() + "!");
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
            ModGeneralFunctions.MessageOk("¡La Mesa se encuentra Ocupada!");
            this.Button_Refresh_Click(RuntimeHelpers.GetObjectValue(sender), (EventArgs) null);
            return;
          }
          if (Operators.CompareString(Left2, ModGeneralVar.g_BusinessCode.get_TABLE_RESERVADA(), false) == 0)
          {
            ModGeneralFunctions.MessageOk("¡La Mesa se encuentra Reservada!");
            this.Button_Refresh_Click(RuntimeHelpers.GetObjectValue(sender), (EventArgs) null);
            return;
          }
        }
        else if (Operators.CompareString(Left1, ModGeneralVar.g_BusinessCode.get_TABLE_RESERVADA(), false) == 0)
        {
          string Left2 = str2;
          if (Operators.CompareString(Left2, ModGeneralVar.g_BusinessCode.get_TABLE_OCUPADA(), false) == 0)
          {
            ModGeneralFunctions.MessageOk("¡La Mesa se encuentra Ocupada!");
            this.Button_Refresh_Click(RuntimeHelpers.GetObjectValue(sender), (EventArgs) null);
            return;
          }
          if (Operators.CompareString(Left2, ModGeneralVar.g_BusinessCode.get_TABLE_RESERVADA(), false) == 0)
          {
            ModGeneralFunctions.MessageOk("¡La Mesa se encuentra Reservada!");
            this.Button_Refresh_Click(RuntimeHelpers.GetObjectValue(sender), (EventArgs) null);
            return;
          }
        }
        BL_TR1_ORDERS blTr1Orders = new BL_TR1_ORDERS();
        BE_TR1_ORDERS beTr1Orders = new BE_TR1_ORDERS();
        beTr1Orders.set_OrderTypeId(ModGeneralVar.g_Str_OrderTypeID_Default);
        beTr1Orders.set_HallId(this.int_HallId);
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
        if (ModGeneralVar.g_Str_OrderID.Length != 10)
          ModGeneralFunctions.MessageError_Large("¡Error - " + ModGeneralVar.g_Str_OrderID + "!", true);
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
        ModGeneralFunctions.MessageOk("Debe Ingresar una Descripción!!!");
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
        ModGeneralFunctions.MessageOk("¡Nº Máximo de Personas es " + Conversions.ToString(ModGeneralVar.g_BE_TR1_VARIABLES_B.get_PersonNum()) + "!");
      else
        this.int_OldPeople = integer;
    }

    private void Button_GoOut_Click(object sender, EventArgs e)
    {
      ModGeneralVar.g_bol_IsClose = true;
      ModGeneralVar.g_bol_IsReady = false;
      this.Close();
    }

    private void Button_Refresh_Click(object sender, EventArgs e)
    {
      short num1 = checked ((short) ((int) this.shtCountHallCollection - 1));
      short num2 = 0;
      while ((int) num2 <= (int) num1)
      {
        if (((Control) this.btnHallButtons[(int) num2]).Tag.Equals((object) this.int_HallId))
          this.btnHallButtons[(int) num2].set_BtnStyle((emunType.XPStyle) 1);
        else
          this.btnHallButtons[(int) num2].set_BtnStyle((emunType.XPStyle) 2);
        checked { ++num2; }
      }
      BL_TR1_HALLS blTr1Halls = new BL_TR1_HALLS();
      BE_TR1_HALLS beTr1Halls = new BE_TR1_HALLS();
      blTr1Halls.ListById(this.int_HallId).get_HallDes();
      this.FillButtonMesasArray(this.int_HallId);
    }

    private void FrmChooseTable_KeyDown(object sender, KeyEventArgs e)
    {
      switch (e.KeyValue)
      {
        case 27:
          ModGeneralVar.g_bol_IsClose = true;
          ModGeneralVar.g_bol_IsReady = false;
          this.Close();
          break;
        case 116:
          this.Button_Refresh_Click((object) null, (EventArgs) null);
          break;
      }
    }

    private void UbicarMesa(int pintTableId)
    {
      int num = checked (this.btnTablesButtons.Length - 1);
      int index = 0;
      while (index <= num)
      {
        if (((Control) this.btnTablesButtons[index]).Tag.Equals((object) pintTableId))
        {
          this.btnTablesButtons_Click((object) this.btnTablesButtons[index], (EventArgs) null);
          break;
        }
        checked { ++index; }
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
        this.Button_Refresh_Click((object) null, (EventArgs) null);
      else
        ModGeneralFunctions.MessageError_Large("¡Error al reparar Mesa - " + str2 + "!", true);
      str1 = (string) null;
    }
  }
}
