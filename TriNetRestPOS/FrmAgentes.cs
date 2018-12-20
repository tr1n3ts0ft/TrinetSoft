// Decompiled with JetBrains decompiler
// Type: TriNetRestPOS.FrmAgentes
// Assembly: TriNetRestPOS, Version=5.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 43377352-E952-4AC1-9BA6-CCBE4AE5F575
// Assembly location: C:\log\TriNetRestPOS.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace TriNetRestPOS
{
  [DesignerGenerated]
  public class FrmAgentes : Form
  {
    private IContainer components;
    public bool IsWaiter;
    public bool IsDelivery;
    private Control _Control;
    private string Res_Code;
    private string Res_Description;
    private string Res_IsNotDelivery;

    public FrmAgentes()
    {
      this.Load += new EventHandler(this.FrmAgentes_Load);
      this.IsWaiter = false;
      this.IsDelivery = false;
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
      this.Button_Waiters = new Button();
      this.Button_AgentDelivery = new Button();
      this.Button_GoOut = new Button();
      this.SuspendLayout();
      this.Button_Waiters.Font = new Font("Verdana", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_Waiters.ForeColor = Color.MediumBlue;
      this.Button_Waiters.Image = (Image) TriNetRestPOS.My.Resources.Resources.Waiters;
      this.Button_Waiters.Location = new Point(4, 4);
      this.Button_Waiters.Name = "Button_Waiters";
      this.Button_Waiters.Size = new Size(152, 81);
      this.Button_Waiters.TabIndex = 147;
      this.Button_Waiters.Tag = (object) "Res_Waiter";
      this.Button_Waiters.Text = "Mozo";
      this.Button_Waiters.TextImageRelation = TextImageRelation.TextAboveImage;
      this.Button_Waiters.UseVisualStyleBackColor = true;
      this.Button_AgentDelivery.Font = new Font("Verdana", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_AgentDelivery.ForeColor = Color.MediumBlue;
      this.Button_AgentDelivery.Image = (Image) TriNetRestPOS.My.Resources.Resources.Delivery;
      this.Button_AgentDelivery.Location = new Point(4, 86);
      this.Button_AgentDelivery.Name = "Button_AgentDelivery";
      this.Button_AgentDelivery.Size = new Size(152, 81);
      this.Button_AgentDelivery.TabIndex = 148;
      this.Button_AgentDelivery.Tag = (object) "Res_AgentD";
      this.Button_AgentDelivery.Text = "Agente Delivery";
      this.Button_AgentDelivery.TextImageRelation = TextImageRelation.TextAboveImage;
      this.Button_AgentDelivery.UseVisualStyleBackColor = true;
      this.Button_GoOut.Font = new Font("Verdana", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button_GoOut.ForeColor = Color.MediumBlue;
      this.Button_GoOut.Image = (Image) TriNetRestPOS.My.Resources.Resources.i_Close;
      this.Button_GoOut.Location = new Point(29, 173);
      this.Button_GoOut.Name = "Button_GoOut";
      this.Button_GoOut.Size = new Size(100, 72);
      this.Button_GoOut.TabIndex = 163;
      this.Button_GoOut.Tag = (object) "Res_Back";
      this.Button_GoOut.Text = "Salir";
      this.Button_GoOut.TextImageRelation = TextImageRelation.TextAboveImage;
      this.Button_GoOut.UseVisualStyleBackColor = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.ActiveCaptionText;
      this.ClientSize = new Size(161, 248);
      this.ControlBox = false;
      this.Controls.Add((Control) this.Button_GoOut);
      this.Controls.Add((Control) this.Button_Waiters);
      this.Controls.Add((Control) this.Button_AgentDelivery);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.Name = nameof (FrmAgentes);
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Agentes";
      this.ResumeLayout(false);
    }

    internal virtual Button Button_Waiters
    {
      get
      {
        return this._Button_Waiters;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_Waiters_Click);
        Button buttonWaiters1 = this._Button_Waiters;
        if (buttonWaiters1 != null)
          buttonWaiters1.Click -= eventHandler;
        this._Button_Waiters = value;
        Button buttonWaiters2 = this._Button_Waiters;
        if (buttonWaiters2 == null)
          return;
        buttonWaiters2.Click += eventHandler;
      }
    }

    internal virtual Button Button_AgentDelivery
    {
      get
      {
        return this._Button_AgentDelivery;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_AgentDelivery_Click);
        Button buttonAgentDelivery1 = this._Button_AgentDelivery;
        if (buttonAgentDelivery1 != null)
          buttonAgentDelivery1.Click -= eventHandler;
        this._Button_AgentDelivery = value;
        Button buttonAgentDelivery2 = this._Button_AgentDelivery;
        if (buttonAgentDelivery2 == null)
          return;
        buttonAgentDelivery2.Click += eventHandler;
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

    private void FrmAgentes_Load(object sender, EventArgs e)
    {
      this.Resource(ModGeneralFunctions.Get_Language((object) this));
    }

    private void Button_Waiters_Click(object sender, EventArgs e)
    {
      if (!ModGeneralFunctions.Show_SearchWaiter(this.Res_Code, this.Res_Description, false))
        return;
      this.IsWaiter = true;
      this.Close();
    }

    private void Resource(ResourceManager Rm)
    {
      try
      {
        foreach (Control control in this.Controls)
        {
          this._Control = control;
          this._Control.Text = Rm.GetString(Conversions.ToString(this._Control.Tag));
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      this.Res_Code = Rm.GetString("Res_Code");
      this.Res_Description = Rm.GetString("Res_Description");
      this.Res_IsNotDelivery = Rm.GetString("Res_IsNotDelivery");
    }

    private void Button_GoOut_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void Button_AgentDelivery_Click(object sender, EventArgs e)
    {
      if (Operators.CompareString(ModGeneralVar.g_Str_OrderTypeID, ModGeneralVar.g_Str_OrderTypeDelivery, false) == 0)
      {
        FrmAgentDelivery frmAgentDelivery = new FrmAgentDelivery();
        frmAgentDelivery._OnlySearch = true;
        int num = (int) frmAgentDelivery.ShowDialog();
        if (ModGeneralVar.g_bol_IsReady)
        {
          this.IsDelivery = true;
          this.Close();
        }
        frmAgentDelivery.Dispose();
      }
      else
        ModGeneralFunctions.MessageOk(this.Res_IsNotDelivery);
    }
  }
}
