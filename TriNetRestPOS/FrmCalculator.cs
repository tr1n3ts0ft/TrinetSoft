// Decompiled with JetBrains decompiler
// Type: TriNetRestPOS.FrmCalculator
// Assembly: TriNetRestPOS, Version=5.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 43377352-E952-4AC1-9BA6-CCBE4AE5F575
// Assembly location: C:\log\TriNetRestPOS.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MyXPButton;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace TriNetRestPOS
{
  [DesignerGenerated]
  public class FrmCalculator : Form
  {
    private IContainer components;
    private double memory;
    private float first;
    private float second;
    private double answer;
    private int math;
    private bool used;
    private const int plus = 0;
    private const int minus = 1;
    private const int multiply = 2;
    private const int divide = 3;
    private const int decimalpoint = 4;
    private const int equal = 5;

    public FrmCalculator()
    {
      this.KeyPress += new KeyPressEventHandler(this.FrmCalculator_KeyPress);
      this.Load += new EventHandler(this.FrmCalculator_Load);
      this.KeyDown += new KeyEventHandler(this.FrmCalculator_KeyDown);
      this.InitializeComponent();
    }

    [DebuggerNonUserCode]
    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.Button_GoOut = new MyXPButton.MyXPButton();
      this.Button_Number9 = new MyXPButton.MyXPButton();
      this.Button_Clear = new MyXPButton.MyXPButton();
      this.Button_Number8 = new MyXPButton.MyXPButton();
      this.Button_Number7 = new MyXPButton.MyXPButton();
      this.Button_Number6 = new MyXPButton.MyXPButton();
      this.Button_Number5 = new MyXPButton.MyXPButton();
      this.Button_Number4 = new MyXPButton.MyXPButton();
      this.Button_Number3 = new MyXPButton.MyXPButton();
      this.Button_Number2 = new MyXPButton.MyXPButton();
      this.Button_Number1 = new MyXPButton.MyXPButton();
      this.Button_Number0 = new MyXPButton.MyXPButton();
      this.Button_Dot = new MyXPButton.MyXPButton();
      this.Button_Add = new MyXPButton.MyXPButton();
      this.Button_Subtract = new MyXPButton.MyXPButton();
      this.Button_Equals = new MyXPButton.MyXPButton();
      this.Button_Divide = new MyXPButton.MyXPButton();
      this.Button_Times = new MyXPButton.MyXPButton();
      this.TextBox_Display = new NumericTextBox.NumericTextBox();
      this.SuspendLayout();
      this.Button_GoOut.set_AdjustImageLocation(new Point(0, 0));
      this.Button_GoOut.set_BtnShape((emunType.BtnShape) 0);
      this.Button_GoOut.set_BtnStyle((emunType.XPStyle) 3);
      ((Control) this.Button_GoOut).Font = new Font("Verdana", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      ((Control) this.Button_GoOut).ForeColor = Color.MediumBlue;
      ((ButtonBase) this.Button_GoOut).Image = (Image) TriNetRestPOS.My.Resources.Resources.Close;
      ((Control) this.Button_GoOut).Location = new Point(109, 289);
      ((Control) this.Button_GoOut).Name = "Button_GoOut";
      ((Control) this.Button_GoOut).Size = new Size(123, 60);
      ((Control) this.Button_GoOut).TabIndex = 17;
      ((ButtonBase) this.Button_GoOut).Text = "Salir";
      ((ButtonBase) this.Button_GoOut).TextImageRelation = TextImageRelation.TextAboveImage;
      ((ButtonBase) this.Button_GoOut).UseVisualStyleBackColor = true;
      this.Button_Number9.set_AdjustImageLocation(new Point(0, 0));
      this.Button_Number9.set_BtnShape((emunType.BtnShape) 0);
      this.Button_Number9.set_BtnStyle((emunType.XPStyle) 3);
      ((Control) this.Button_Number9).Font = new Font("Verdana", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      ((Control) this.Button_Number9).ForeColor = Color.MediumBlue;
      ((Control) this.Button_Number9).Location = new Point(154, 171);
      ((Control) this.Button_Number9).Name = "Button_Number9";
      ((Control) this.Button_Number9).Size = new Size(78, 60);
      ((Control) this.Button_Number9).TabIndex = 9;
      ((ButtonBase) this.Button_Number9).Text = "9";
      ((ButtonBase) this.Button_Number9).TextImageRelation = TextImageRelation.TextAboveImage;
      ((ButtonBase) this.Button_Number9).UseVisualStyleBackColor = true;
      this.Button_Clear.set_AdjustImageLocation(new Point(0, 0));
      this.Button_Clear.set_BtnShape((emunType.BtnShape) 0);
      this.Button_Clear.set_BtnStyle((emunType.XPStyle) 3);
      ((Control) this.Button_Clear).Font = new Font("Verdana", 8.25f, FontStyle.Bold);
      ((Control) this.Button_Clear).ForeColor = Color.MediumBlue;
      ((ButtonBase) this.Button_Clear).Image = (Image) TriNetRestPOS.My.Resources.Resources.Eraser;
      ((Control) this.Button_Clear).Location = new Point(0, 289);
      ((Control) this.Button_Clear).Name = "Button_Clear";
      ((Control) this.Button_Clear).Size = new Size(110, 60);
      ((Control) this.Button_Clear).TabIndex = 16;
      ((ButtonBase) this.Button_Clear).Text = "Borrar";
      ((ButtonBase) this.Button_Clear).TextImageRelation = TextImageRelation.TextAboveImage;
      ((ButtonBase) this.Button_Clear).UseVisualStyleBackColor = true;
      this.Button_Number8.set_AdjustImageLocation(new Point(0, 0));
      this.Button_Number8.set_BtnShape((emunType.BtnShape) 0);
      this.Button_Number8.set_BtnStyle((emunType.XPStyle) 3);
      ((Control) this.Button_Number8).Font = new Font("Verdana", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      ((Control) this.Button_Number8).ForeColor = Color.MediumBlue;
      ((Control) this.Button_Number8).Location = new Point(77, 171);
      ((Control) this.Button_Number8).Name = "Button_Number8";
      ((Control) this.Button_Number8).Size = new Size(78, 60);
      ((Control) this.Button_Number8).TabIndex = 8;
      ((ButtonBase) this.Button_Number8).Text = "8";
      ((ButtonBase) this.Button_Number8).TextImageRelation = TextImageRelation.TextAboveImage;
      ((ButtonBase) this.Button_Number8).UseVisualStyleBackColor = true;
      this.Button_Number7.set_AdjustImageLocation(new Point(0, 0));
      this.Button_Number7.set_BtnShape((emunType.BtnShape) 0);
      this.Button_Number7.set_BtnStyle((emunType.XPStyle) 3);
      ((Control) this.Button_Number7).Font = new Font("Verdana", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      ((Control) this.Button_Number7).ForeColor = Color.MediumBlue;
      ((Control) this.Button_Number7).Location = new Point(0, 171);
      ((Control) this.Button_Number7).Name = "Button_Number7";
      ((Control) this.Button_Number7).Size = new Size(78, 60);
      ((Control) this.Button_Number7).TabIndex = 7;
      ((ButtonBase) this.Button_Number7).Text = "7";
      ((ButtonBase) this.Button_Number7).TextImageRelation = TextImageRelation.TextAboveImage;
      ((ButtonBase) this.Button_Number7).UseVisualStyleBackColor = true;
      this.Button_Number6.set_AdjustImageLocation(new Point(0, 0));
      this.Button_Number6.set_BtnShape((emunType.BtnShape) 0);
      this.Button_Number6.set_BtnStyle((emunType.XPStyle) 3);
      ((Control) this.Button_Number6).Font = new Font("Verdana", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      ((Control) this.Button_Number6).ForeColor = Color.MediumBlue;
      ((Control) this.Button_Number6).Location = new Point(154, 112);
      ((Control) this.Button_Number6).Name = "Button_Number6";
      ((Control) this.Button_Number6).Size = new Size(78, 60);
      ((Control) this.Button_Number6).TabIndex = 6;
      ((ButtonBase) this.Button_Number6).Text = "6";
      ((ButtonBase) this.Button_Number6).TextImageRelation = TextImageRelation.TextAboveImage;
      ((ButtonBase) this.Button_Number6).UseVisualStyleBackColor = true;
      this.Button_Number5.set_AdjustImageLocation(new Point(0, 0));
      this.Button_Number5.set_BtnShape((emunType.BtnShape) 0);
      this.Button_Number5.set_BtnStyle((emunType.XPStyle) 3);
      ((Control) this.Button_Number5).Font = new Font("Verdana", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      ((Control) this.Button_Number5).ForeColor = Color.MediumBlue;
      ((Control) this.Button_Number5).Location = new Point(77, 112);
      ((Control) this.Button_Number5).Name = "Button_Number5";
      ((Control) this.Button_Number5).Size = new Size(78, 60);
      ((Control) this.Button_Number5).TabIndex = 5;
      ((ButtonBase) this.Button_Number5).Text = "5";
      ((ButtonBase) this.Button_Number5).TextImageRelation = TextImageRelation.TextAboveImage;
      ((ButtonBase) this.Button_Number5).UseVisualStyleBackColor = true;
      this.Button_Number4.set_AdjustImageLocation(new Point(0, 0));
      this.Button_Number4.set_BtnShape((emunType.BtnShape) 0);
      this.Button_Number4.set_BtnStyle((emunType.XPStyle) 3);
      ((Control) this.Button_Number4).Font = new Font("Verdana", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      ((Control) this.Button_Number4).ForeColor = Color.MediumBlue;
      ((Control) this.Button_Number4).Location = new Point(0, 112);
      ((Control) this.Button_Number4).Name = "Button_Number4";
      ((Control) this.Button_Number4).Size = new Size(78, 60);
      ((Control) this.Button_Number4).TabIndex = 4;
      ((ButtonBase) this.Button_Number4).Text = "4";
      ((ButtonBase) this.Button_Number4).TextImageRelation = TextImageRelation.TextAboveImage;
      ((ButtonBase) this.Button_Number4).UseVisualStyleBackColor = true;
      this.Button_Number3.set_AdjustImageLocation(new Point(0, 0));
      this.Button_Number3.set_BtnShape((emunType.BtnShape) 0);
      this.Button_Number3.set_BtnStyle((emunType.XPStyle) 3);
      ((Control) this.Button_Number3).Font = new Font("Verdana", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      ((Control) this.Button_Number3).ForeColor = Color.MediumBlue;
      ((Control) this.Button_Number3).Location = new Point(154, 53);
      ((Control) this.Button_Number3).Name = "Button_Number3";
      ((Control) this.Button_Number3).Size = new Size(78, 60);
      ((Control) this.Button_Number3).TabIndex = 3;
      ((ButtonBase) this.Button_Number3).Text = "3";
      ((ButtonBase) this.Button_Number3).TextImageRelation = TextImageRelation.TextAboveImage;
      ((ButtonBase) this.Button_Number3).UseVisualStyleBackColor = true;
      this.Button_Number2.set_AdjustImageLocation(new Point(0, 0));
      this.Button_Number2.set_BtnShape((emunType.BtnShape) 0);
      this.Button_Number2.set_BtnStyle((emunType.XPStyle) 3);
      ((Control) this.Button_Number2).Font = new Font("Verdana", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      ((Control) this.Button_Number2).ForeColor = Color.MediumBlue;
      ((Control) this.Button_Number2).Location = new Point(77, 53);
      ((Control) this.Button_Number2).Name = "Button_Number2";
      ((Control) this.Button_Number2).Size = new Size(78, 60);
      ((Control) this.Button_Number2).TabIndex = 2;
      ((ButtonBase) this.Button_Number2).Text = "2";
      ((ButtonBase) this.Button_Number2).TextImageRelation = TextImageRelation.TextAboveImage;
      ((ButtonBase) this.Button_Number2).UseVisualStyleBackColor = true;
      this.Button_Number1.set_AdjustImageLocation(new Point(0, 0));
      this.Button_Number1.set_BtnShape((emunType.BtnShape) 0);
      this.Button_Number1.set_BtnStyle((emunType.XPStyle) 3);
      ((Control) this.Button_Number1).Font = new Font("Verdana", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      ((Control) this.Button_Number1).ForeColor = Color.MediumBlue;
      ((Control) this.Button_Number1).Location = new Point(0, 53);
      ((Control) this.Button_Number1).Name = "Button_Number1";
      ((Control) this.Button_Number1).Size = new Size(78, 60);
      ((Control) this.Button_Number1).TabIndex = 1;
      ((ButtonBase) this.Button_Number1).Text = "1";
      ((ButtonBase) this.Button_Number1).TextImageRelation = TextImageRelation.TextAboveImage;
      ((ButtonBase) this.Button_Number1).UseVisualStyleBackColor = true;
      this.Button_Number0.set_AdjustImageLocation(new Point(0, 0));
      this.Button_Number0.set_BtnShape((emunType.BtnShape) 0);
      this.Button_Number0.set_BtnStyle((emunType.XPStyle) 3);
      ((Control) this.Button_Number0).Font = new Font("Verdana", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      ((Control) this.Button_Number0).ForeColor = Color.MediumBlue;
      ((Control) this.Button_Number0).Location = new Point(77, 230);
      ((Control) this.Button_Number0).Name = "Button_Number0";
      ((Control) this.Button_Number0).Size = new Size(78, 60);
      ((Control) this.Button_Number0).TabIndex = 11;
      ((ButtonBase) this.Button_Number0).Text = "0";
      ((ButtonBase) this.Button_Number0).TextImageRelation = TextImageRelation.TextAboveImage;
      ((ButtonBase) this.Button_Number0).UseVisualStyleBackColor = true;
      this.Button_Dot.set_AdjustImageLocation(new Point(0, 0));
      this.Button_Dot.set_BtnShape((emunType.BtnShape) 0);
      this.Button_Dot.set_BtnStyle((emunType.XPStyle) 3);
      ((Control) this.Button_Dot).Font = new Font("Verdana", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      ((Control) this.Button_Dot).ForeColor = Color.MediumBlue;
      ((Control) this.Button_Dot).Location = new Point(0, 230);
      ((Control) this.Button_Dot).Name = "Button_Dot";
      ((Control) this.Button_Dot).Size = new Size(78, 60);
      ((Control) this.Button_Dot).TabIndex = 10;
      ((ButtonBase) this.Button_Dot).Text = ".";
      ((ButtonBase) this.Button_Dot).TextImageRelation = TextImageRelation.TextAboveImage;
      ((ButtonBase) this.Button_Dot).UseVisualStyleBackColor = true;
      this.Button_Add.set_AdjustImageLocation(new Point(0, 0));
      this.Button_Add.set_BtnShape((emunType.BtnShape) 0);
      this.Button_Add.set_BtnStyle((emunType.XPStyle) 3);
      ((Control) this.Button_Add).Font = new Font("Trebuchet MS", 36f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      ((Control) this.Button_Add).ForeColor = Color.Red;
      ((Control) this.Button_Add).Location = new Point(231, 112);
      ((Control) this.Button_Add).Name = "Button_Add";
      ((Control) this.Button_Add).Size = new Size(78, 60);
      ((Control) this.Button_Add).TabIndex = 12;
      ((ButtonBase) this.Button_Add).Text = "+";
      ((ButtonBase) this.Button_Add).TextImageRelation = TextImageRelation.TextAboveImage;
      ((ButtonBase) this.Button_Add).UseVisualStyleBackColor = true;
      this.Button_Subtract.set_AdjustImageLocation(new Point(0, 0));
      this.Button_Subtract.set_BtnShape((emunType.BtnShape) 0);
      this.Button_Subtract.set_BtnStyle((emunType.XPStyle) 3);
      ((Control) this.Button_Subtract).Font = new Font("Trebuchet MS", 48f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      ((Control) this.Button_Subtract).ForeColor = Color.Red;
      ((Control) this.Button_Subtract).Location = new Point(231, 53);
      ((Control) this.Button_Subtract).Name = "Button_Subtract";
      ((Control) this.Button_Subtract).Size = new Size(78, 60);
      ((Control) this.Button_Subtract).TabIndex = 13;
      ((ButtonBase) this.Button_Subtract).Text = "-";
      ((ButtonBase) this.Button_Subtract).TextImageRelation = TextImageRelation.ImageAboveText;
      ((ButtonBase) this.Button_Subtract).UseVisualStyleBackColor = true;
      this.Button_Equals.set_AdjustImageLocation(new Point(0, 0));
      this.Button_Equals.set_BtnShape((emunType.BtnShape) 0);
      this.Button_Equals.set_BtnStyle((emunType.XPStyle) 3);
      ((Control) this.Button_Equals).Font = new Font("Trebuchet MS", 27.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      ((Control) this.Button_Equals).ForeColor = Color.Red;
      ((Control) this.Button_Equals).Location = new Point(231, 230);
      ((Control) this.Button_Equals).Name = "Button_Equals";
      ((Control) this.Button_Equals).Size = new Size(78, 119);
      ((Control) this.Button_Equals).TabIndex = 14;
      ((ButtonBase) this.Button_Equals).Text = "=";
      ((ButtonBase) this.Button_Equals).TextImageRelation = TextImageRelation.TextAboveImage;
      ((ButtonBase) this.Button_Equals).UseVisualStyleBackColor = true;
      this.Button_Divide.set_AdjustImageLocation(new Point(0, 0));
      this.Button_Divide.set_BtnShape((emunType.BtnShape) 0);
      this.Button_Divide.set_BtnStyle((emunType.XPStyle) 3);
      ((Control) this.Button_Divide).Font = new Font("Trebuchet MS", 27.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      ((Control) this.Button_Divide).ForeColor = Color.Red;
      ((Control) this.Button_Divide).Location = new Point(154, 230);
      ((Control) this.Button_Divide).Name = "Button_Divide";
      ((Control) this.Button_Divide).Size = new Size(78, 60);
      ((Control) this.Button_Divide).TabIndex = 18;
      ((ButtonBase) this.Button_Divide).Text = "÷";
      ((ButtonBase) this.Button_Divide).TextImageRelation = TextImageRelation.TextAboveImage;
      ((ButtonBase) this.Button_Divide).UseVisualStyleBackColor = true;
      this.Button_Times.set_AdjustImageLocation(new Point(0, 0));
      this.Button_Times.set_BtnShape((emunType.BtnShape) 0);
      this.Button_Times.set_BtnStyle((emunType.XPStyle) 3);
      ((Control) this.Button_Times).Font = new Font("Trebuchet MS", 27.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      ((Control) this.Button_Times).ForeColor = Color.Red;
      ((Control) this.Button_Times).Location = new Point(231, 171);
      ((Control) this.Button_Times).Name = "Button_Times";
      ((Control) this.Button_Times).Size = new Size(78, 60);
      ((Control) this.Button_Times).TabIndex = 15;
      ((ButtonBase) this.Button_Times).Text = "x";
      ((ButtonBase) this.Button_Times).TextImageRelation = TextImageRelation.TextAboveImage;
      ((ButtonBase) this.Button_Times).UseVisualStyleBackColor = true;
      this.TextBox_Display.set_AllowSpace(false);
      ((Control) this.TextBox_Display).Font = new Font("Verdana", 21.75f, FontStyle.Bold);
      ((TextBoxBase) this.TextBox_Display).ForeColor = Color.MediumBlue;
      ((Control) this.TextBox_Display).Location = new Point(1, 1);
      ((TextBoxBase) this.TextBox_Display).MaxLength = 9;
      ((TextBox) this.TextBox_Display).Multiline = true;
      ((Control) this.TextBox_Display).Name = "TextBox_Display";
      ((Control) this.TextBox_Display).Size = new Size(307, 52);
      ((Control) this.TextBox_Display).TabIndex = 0;
      ((TextBox) this.TextBox_Display).Text = "0";
      ((TextBox) this.TextBox_Display).TextAlign = HorizontalAlignment.Right;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.White;
      this.ClientSize = new Size(309, 349);
      this.ControlBox = false;
      this.Controls.Add((Control) this.TextBox_Display);
      this.Controls.Add((Control) this.Button_Add);
      this.Controls.Add((Control) this.Button_Subtract);
      this.Controls.Add((Control) this.Button_Equals);
      this.Controls.Add((Control) this.Button_Divide);
      this.Controls.Add((Control) this.Button_Times);
      this.Controls.Add((Control) this.Button_Number9);
      this.Controls.Add((Control) this.Button_Clear);
      this.Controls.Add((Control) this.Button_Number8);
      this.Controls.Add((Control) this.Button_Number7);
      this.Controls.Add((Control) this.Button_Number6);
      this.Controls.Add((Control) this.Button_Number5);
      this.Controls.Add((Control) this.Button_Number4);
      this.Controls.Add((Control) this.Button_Number3);
      this.Controls.Add((Control) this.Button_Number2);
      this.Controls.Add((Control) this.Button_Number1);
      this.Controls.Add((Control) this.Button_Number0);
      this.Controls.Add((Control) this.Button_Dot);
      this.Controls.Add((Control) this.Button_GoOut);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (FrmCalculator);
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Calculadora";
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    internal virtual MyXPButton.MyXPButton Button_GoOut
    {
      get
      {
        return this._Button_GoOut;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_GoOut_Click);
        MyXPButton.MyXPButton buttonGoOut1 = this._Button_GoOut;
        if (buttonGoOut1 != null)
          ((Control) buttonGoOut1).Click -= eventHandler;
        this._Button_GoOut = value;
        MyXPButton.MyXPButton buttonGoOut2 = this._Button_GoOut;
        if (buttonGoOut2 == null)
          return;
        ((Control) buttonGoOut2).Click += eventHandler;
      }
    }

    internal virtual MyXPButton.MyXPButton Button_Number9
    {
      get
      {
        return this._Button_Number9;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_Number9_Click);
        MyXPButton.MyXPButton buttonNumber9_1 = this._Button_Number9;
        if (buttonNumber9_1 != null)
          ((Control) buttonNumber9_1).Click -= eventHandler;
        this._Button_Number9 = value;
        MyXPButton.MyXPButton buttonNumber9_2 = this._Button_Number9;
        if (buttonNumber9_2 == null)
          return;
        ((Control) buttonNumber9_2).Click += eventHandler;
      }
    }

    internal virtual MyXPButton.MyXPButton Button_Clear
    {
      get
      {
        return this._Button_Clear;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnClear_Click);
        MyXPButton.MyXPButton buttonClear1 = this._Button_Clear;
        if (buttonClear1 != null)
          ((Control) buttonClear1).Click -= eventHandler;
        this._Button_Clear = value;
        MyXPButton.MyXPButton buttonClear2 = this._Button_Clear;
        if (buttonClear2 == null)
          return;
        ((Control) buttonClear2).Click += eventHandler;
      }
    }

    internal virtual MyXPButton.MyXPButton Button_Number8
    {
      get
      {
        return this._Button_Number8;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_Number8_Click);
        MyXPButton.MyXPButton buttonNumber8_1 = this._Button_Number8;
        if (buttonNumber8_1 != null)
          ((Control) buttonNumber8_1).Click -= eventHandler;
        this._Button_Number8 = value;
        MyXPButton.MyXPButton buttonNumber8_2 = this._Button_Number8;
        if (buttonNumber8_2 == null)
          return;
        ((Control) buttonNumber8_2).Click += eventHandler;
      }
    }

    internal virtual MyXPButton.MyXPButton Button_Number7
    {
      get
      {
        return this._Button_Number7;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_Number7_Click);
        MyXPButton.MyXPButton buttonNumber7_1 = this._Button_Number7;
        if (buttonNumber7_1 != null)
          ((Control) buttonNumber7_1).Click -= eventHandler;
        this._Button_Number7 = value;
        MyXPButton.MyXPButton buttonNumber7_2 = this._Button_Number7;
        if (buttonNumber7_2 == null)
          return;
        ((Control) buttonNumber7_2).Click += eventHandler;
      }
    }

    internal virtual MyXPButton.MyXPButton Button_Number6
    {
      get
      {
        return this._Button_Number6;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_Number6_Click);
        MyXPButton.MyXPButton buttonNumber6_1 = this._Button_Number6;
        if (buttonNumber6_1 != null)
          ((Control) buttonNumber6_1).Click -= eventHandler;
        this._Button_Number6 = value;
        MyXPButton.MyXPButton buttonNumber6_2 = this._Button_Number6;
        if (buttonNumber6_2 == null)
          return;
        ((Control) buttonNumber6_2).Click += eventHandler;
      }
    }

    internal virtual MyXPButton.MyXPButton Button_Number5
    {
      get
      {
        return this._Button_Number5;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_Number5_Click);
        MyXPButton.MyXPButton buttonNumber5_1 = this._Button_Number5;
        if (buttonNumber5_1 != null)
          ((Control) buttonNumber5_1).Click -= eventHandler;
        this._Button_Number5 = value;
        MyXPButton.MyXPButton buttonNumber5_2 = this._Button_Number5;
        if (buttonNumber5_2 == null)
          return;
        ((Control) buttonNumber5_2).Click += eventHandler;
      }
    }

    internal virtual MyXPButton.MyXPButton Button_Number4
    {
      get
      {
        return this._Button_Number4;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_Number4_Click);
        MyXPButton.MyXPButton buttonNumber4_1 = this._Button_Number4;
        if (buttonNumber4_1 != null)
          ((Control) buttonNumber4_1).Click -= eventHandler;
        this._Button_Number4 = value;
        MyXPButton.MyXPButton buttonNumber4_2 = this._Button_Number4;
        if (buttonNumber4_2 == null)
          return;
        ((Control) buttonNumber4_2).Click += eventHandler;
      }
    }

    internal virtual MyXPButton.MyXPButton Button_Number3
    {
      get
      {
        return this._Button_Number3;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_Number3_Click);
        MyXPButton.MyXPButton buttonNumber3_1 = this._Button_Number3;
        if (buttonNumber3_1 != null)
          ((Control) buttonNumber3_1).Click -= eventHandler;
        this._Button_Number3 = value;
        MyXPButton.MyXPButton buttonNumber3_2 = this._Button_Number3;
        if (buttonNumber3_2 == null)
          return;
        ((Control) buttonNumber3_2).Click += eventHandler;
      }
    }

    internal virtual MyXPButton.MyXPButton Button_Number2
    {
      get
      {
        return this._Button_Number2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_Number2_Click);
        MyXPButton.MyXPButton buttonNumber2_1 = this._Button_Number2;
        if (buttonNumber2_1 != null)
          ((Control) buttonNumber2_1).Click -= eventHandler;
        this._Button_Number2 = value;
        MyXPButton.MyXPButton buttonNumber2_2 = this._Button_Number2;
        if (buttonNumber2_2 == null)
          return;
        ((Control) buttonNumber2_2).Click += eventHandler;
      }
    }

    internal virtual MyXPButton.MyXPButton Button_Number1
    {
      get
      {
        return this._Button_Number1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_Number1_Click);
        MyXPButton.MyXPButton buttonNumber1_1 = this._Button_Number1;
        if (buttonNumber1_1 != null)
          ((Control) buttonNumber1_1).Click -= eventHandler;
        this._Button_Number1 = value;
        MyXPButton.MyXPButton buttonNumber1_2 = this._Button_Number1;
        if (buttonNumber1_2 == null)
          return;
        ((Control) buttonNumber1_2).Click += eventHandler;
      }
    }

    internal virtual MyXPButton.MyXPButton Button_Number0
    {
      get
      {
        return this._Button_Number0;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_Number0_Click);
        MyXPButton.MyXPButton buttonNumber0_1 = this._Button_Number0;
        if (buttonNumber0_1 != null)
          ((Control) buttonNumber0_1).Click -= eventHandler;
        this._Button_Number0 = value;
        MyXPButton.MyXPButton buttonNumber0_2 = this._Button_Number0;
        if (buttonNumber0_2 == null)
          return;
        ((Control) buttonNumber0_2).Click += eventHandler;
      }
    }

    internal virtual MyXPButton.MyXPButton Button_Dot
    {
      get
      {
        return this._Button_Dot;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnDot_Click);
        MyXPButton.MyXPButton buttonDot1 = this._Button_Dot;
        if (buttonDot1 != null)
          ((Control) buttonDot1).Click -= eventHandler;
        this._Button_Dot = value;
        MyXPButton.MyXPButton buttonDot2 = this._Button_Dot;
        if (buttonDot2 == null)
          return;
        ((Control) buttonDot2).Click += eventHandler;
      }
    }

    internal virtual MyXPButton.MyXPButton Button_Add
    {
      get
      {
        return this._Button_Add;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_Add_Click);
        MyXPButton.MyXPButton buttonAdd1 = this._Button_Add;
        if (buttonAdd1 != null)
          ((Control) buttonAdd1).Click -= eventHandler;
        this._Button_Add = value;
        MyXPButton.MyXPButton buttonAdd2 = this._Button_Add;
        if (buttonAdd2 == null)
          return;
        ((Control) buttonAdd2).Click += eventHandler;
      }
    }

    internal virtual MyXPButton.MyXPButton Button_Subtract
    {
      get
      {
        return this._Button_Subtract;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnSubtract_Click);
        MyXPButton.MyXPButton buttonSubtract1 = this._Button_Subtract;
        if (buttonSubtract1 != null)
          ((Control) buttonSubtract1).Click -= eventHandler;
        this._Button_Subtract = value;
        MyXPButton.MyXPButton buttonSubtract2 = this._Button_Subtract;
        if (buttonSubtract2 == null)
          return;
        ((Control) buttonSubtract2).Click += eventHandler;
      }
    }

    internal virtual MyXPButton.MyXPButton Button_Equals
    {
      get
      {
        return this._Button_Equals;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnEquals_Click);
        MyXPButton.MyXPButton buttonEquals1 = this._Button_Equals;
        if (buttonEquals1 != null)
          ((Control) buttonEquals1).Click -= eventHandler;
        this._Button_Equals = value;
        MyXPButton.MyXPButton buttonEquals2 = this._Button_Equals;
        if (buttonEquals2 == null)
          return;
        ((Control) buttonEquals2).Click += eventHandler;
      }
    }

    internal virtual MyXPButton.MyXPButton Button_Divide
    {
      get
      {
        return this._Button_Divide;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnDivide_Click);
        MyXPButton.MyXPButton buttonDivide1 = this._Button_Divide;
        if (buttonDivide1 != null)
          ((Control) buttonDivide1).Click -= eventHandler;
        this._Button_Divide = value;
        MyXPButton.MyXPButton buttonDivide2 = this._Button_Divide;
        if (buttonDivide2 == null)
          return;
        ((Control) buttonDivide2).Click += eventHandler;
      }
    }

    internal virtual MyXPButton.MyXPButton Button_Times
    {
      get
      {
        return this._Button_Times;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnTimes_Click);
        MyXPButton.MyXPButton buttonTimes1 = this._Button_Times;
        if (buttonTimes1 != null)
          ((Control) buttonTimes1).Click -= eventHandler;
        this._Button_Times = value;
        MyXPButton.MyXPButton buttonTimes2 = this._Button_Times;
        if (buttonTimes2 == null)
          return;
        ((Control) buttonTimes2).Click += eventHandler;
      }
    }

    internal virtual NumericTextBox.NumericTextBox TextBox_Display
    {
      get
      {
        return this._TextBox_Display;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.TextBox_Display_TextChanged);
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.TextBox_Display_KeyPress);
        NumericTextBox.NumericTextBox textBoxDisplay1 = this._TextBox_Display;
        if (textBoxDisplay1 != null)
        {
          ((Control) textBoxDisplay1).TextChanged -= eventHandler;
          ((Control) textBoxDisplay1).KeyPress -= pressEventHandler;
        }
        this._TextBox_Display = value;
        NumericTextBox.NumericTextBox textBoxDisplay2 = this._TextBox_Display;
        if (textBoxDisplay2 == null)
          return;
        ((Control) textBoxDisplay2).TextChanged += eventHandler;
        ((Control) textBoxDisplay2).KeyPress += pressEventHandler;
      }
    }

    private void FrmCalculator_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (char.IsNumber(e.KeyChar))
      {
        if (Strings.Asc(e.KeyChar) == 48)
          this.Button_Number0_Click((object) e, (EventArgs) null);
        else if (Strings.Asc(e.KeyChar) == 49)
          this.Button_Number1_Click((object) e, (EventArgs) null);
        else if (Strings.Asc(e.KeyChar) == 50)
          this.Button_Number2_Click((object) e, (EventArgs) null);
        else if (Strings.Asc(e.KeyChar) == 51)
          this.Button_Number3_Click((object) e, (EventArgs) null);
        else if (Strings.Asc(e.KeyChar) == 52)
          this.Button_Number4_Click((object) e, (EventArgs) null);
        else if (Strings.Asc(e.KeyChar) == 53)
          this.Button_Number5_Click((object) e, (EventArgs) null);
        else if (Strings.Asc(e.KeyChar) == 54)
          this.Button_Number6_Click((object) e, (EventArgs) null);
        else if (Strings.Asc(e.KeyChar) == 55)
          this.Button_Number7_Click((object) e, (EventArgs) null);
        else if (Strings.Asc(e.KeyChar) == 56)
          this.Button_Number8_Click((object) e, (EventArgs) null);
        else if (Strings.Asc(e.KeyChar) == 57)
          this.Button_Number9_Click((object) e, (EventArgs) null);
        else if (Strings.Asc(e.KeyChar) == 187)
          this.Button_Number9_Click((object) e, (EventArgs) null);
        else
          e.Handled = false;
        e.Handled = true;
      }
      if (char.IsSymbol(e.KeyChar))
      {
        if (Strings.Asc(e.KeyChar) == 43)
          this.Button_Add_Click((object) e, (EventArgs) null);
        if (Strings.Asc(e.KeyChar) == 61)
          this.btnEquals_Click((object) e, (EventArgs) null);
        if (Strings.Asc(e.KeyChar) == 45)
          this.btnSubtract_Click((object) e, (EventArgs) null);
      }
      if (!char.IsPunctuation(e.KeyChar))
        return;
      if (Strings.Asc(e.KeyChar) == 45)
        this.btnSubtract_Click((object) e, (EventArgs) null);
      if (Strings.Asc(e.KeyChar) == 47)
        this.btnDivide_Click((object) e, (EventArgs) null);
      if (Strings.Asc(e.KeyChar) == 42)
        this.btnTimes_Click((object) e, (EventArgs) null);
    }

    private void FrmCalculator_Load(object sender, EventArgs e)
    {
      this.used = false;
      this.memory = 0.0;
    }

    private void Button_Number2_Click(object sender, EventArgs e)
    {
      if (this.used)
      {
        this.used = false;
        ((TextBox) this.TextBox_Display).Text = "0";
      }
      if (Operators.CompareString(((TextBox) this.TextBox_Display).Text, "0", false) == 0)
        ((TextBox) this.TextBox_Display).Text = "";
      ((TextBox) this.TextBox_Display).Text = ((TextBox) this.TextBox_Display).Text + "2";
    }

    private void Button_Number3_Click(object sender, EventArgs e)
    {
      if (this.used)
      {
        this.used = false;
        ((TextBox) this.TextBox_Display).Text = "0";
      }
      if (Operators.CompareString(((TextBox) this.TextBox_Display).Text, "0", false) == 0)
        ((TextBox) this.TextBox_Display).Text = "";
      ((TextBox) this.TextBox_Display).Text = ((TextBox) this.TextBox_Display).Text + "3";
    }

    private void Button_Number4_Click(object sender, EventArgs e)
    {
      if (this.used)
      {
        this.used = false;
        ((TextBox) this.TextBox_Display).Text = "0";
      }
      if (Operators.CompareString(((TextBox) this.TextBox_Display).Text, "0", false) == 0)
        ((TextBox) this.TextBox_Display).Text = "";
      ((TextBox) this.TextBox_Display).Text = ((TextBox) this.TextBox_Display).Text + "4";
    }

    private void Button_Number5_Click(object sender, EventArgs e)
    {
      if (this.used)
      {
        this.used = false;
        ((TextBox) this.TextBox_Display).Text = "0";
      }
      if (Operators.CompareString(((TextBox) this.TextBox_Display).Text, "0", false) == 0)
        ((TextBox) this.TextBox_Display).Text = "";
      ((TextBox) this.TextBox_Display).Text = ((TextBox) this.TextBox_Display).Text + "5";
    }

    private void Button_Number6_Click(object sender, EventArgs e)
    {
      if (this.used)
      {
        this.used = false;
        ((TextBox) this.TextBox_Display).Text = "0";
      }
      if (Operators.CompareString(((TextBox) this.TextBox_Display).Text, "0", false) == 0)
        ((TextBox) this.TextBox_Display).Text = "";
      ((TextBox) this.TextBox_Display).Text = ((TextBox) this.TextBox_Display).Text + "6";
    }

    private void Button_Number7_Click(object sender, EventArgs e)
    {
      if (this.used)
      {
        this.used = false;
        ((TextBox) this.TextBox_Display).Text = "0";
      }
      if (Operators.CompareString(((TextBox) this.TextBox_Display).Text, "0", false) == 0)
        ((TextBox) this.TextBox_Display).Text = "";
      ((TextBox) this.TextBox_Display).Text = ((TextBox) this.TextBox_Display).Text + "7";
    }

    private void Button_Number8_Click(object sender, EventArgs e)
    {
      if (this.used)
      {
        this.used = false;
        ((TextBox) this.TextBox_Display).Text = "0";
      }
      if (Operators.CompareString(((TextBox) this.TextBox_Display).Text, "0", false) == 0)
        ((TextBox) this.TextBox_Display).Text = "";
      ((TextBox) this.TextBox_Display).Text = ((TextBox) this.TextBox_Display).Text + "8";
    }

    private void Button_Number9_Click(object sender, EventArgs e)
    {
      if (this.used)
      {
        this.used = false;
        ((TextBox) this.TextBox_Display).Text = "0";
      }
      if (Operators.CompareString(((TextBox) this.TextBox_Display).Text, "0", false) == 0)
        ((TextBox) this.TextBox_Display).Text = "";
      ((TextBox) this.TextBox_Display).Text = ((TextBox) this.TextBox_Display).Text + "9";
    }

    private void Button_Number0_Click(object sender, EventArgs e)
    {
      if (this.used)
      {
        this.used = false;
        ((TextBox) this.TextBox_Display).Text = "0";
      }
      if (Operators.CompareString(((TextBox) this.TextBox_Display).Text, "0", false) == 0)
        ((TextBox) this.TextBox_Display).Text = "";
      ((TextBox) this.TextBox_Display).Text = ((TextBox) this.TextBox_Display).Text + "0";
    }

    private void btnDot_Click(object sender, EventArgs e)
    {
      if (this.used)
      {
        this.used = false;
        ((TextBox) this.TextBox_Display).Text = "0";
      }
      if (Operators.CompareString(((TextBox) this.TextBox_Display).Text, "0", false) == 0)
        ((TextBox) this.TextBox_Display).Text = "";
      ((TextBox) this.TextBox_Display).Text = ((TextBox) this.TextBox_Display).Text + ".";
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
      ((TextBox) this.TextBox_Display).Text = "0";
    }

    private void Button_Add_Click(object sender, EventArgs e)
    {
      this.first = (float) Conversion.Val(((TextBox) this.TextBox_Display).Text);
      ((TextBox) this.TextBox_Display).Text = "0";
      this.math = 0;
    }

    private void btnSubtract_Click(object sender, EventArgs e)
    {
      this.first = (float) Conversion.Val(((TextBox) this.TextBox_Display).Text);
      ((TextBox) this.TextBox_Display).Text = "0";
      this.math = 1;
    }

    private void btnTimes_Click(object sender, EventArgs e)
    {
      this.first = (float) Conversion.Val(((TextBox) this.TextBox_Display).Text);
      ((TextBox) this.TextBox_Display).Text = "0";
      this.math = 2;
    }

    private void btnDivide_Click(object sender, EventArgs e)
    {
      this.first = (float) Conversion.Val(((TextBox) this.TextBox_Display).Text);
      ((TextBox) this.TextBox_Display).Text = "0";
      this.math = 3;
    }

    private void btnEquals_Click(object sender, EventArgs e)
    {
      this.second = (float) Conversion.Val(((TextBox) this.TextBox_Display).Text);
      this.used = true;
      this.perform_math_function();
    }

    public void perform_math_function()
    {
      switch (this.math)
      {
        case 0:
          this.answer = (double) this.first + (double) this.second;
          ((TextBox) this.TextBox_Display).Text = Conversions.ToString(this.answer);
          break;
        case 1:
          this.answer = (double) this.first - (double) this.second;
          ((TextBox) this.TextBox_Display).Text = Conversions.ToString(this.answer);
          break;
        case 2:
          this.answer = (double) this.first * (double) this.second;
          ((TextBox) this.TextBox_Display).Text = Conversions.ToString(this.answer);
          break;
        case 3:
          this.answer = (double) this.first / (double) this.second;
          ((TextBox) this.TextBox_Display).Text = Conversions.ToString(this.answer);
          break;
      }
    }

    private void Button_Number1_Click(object sender, EventArgs e)
    {
      if (this.used)
      {
        this.used = false;
        ((TextBox) this.TextBox_Display).Text = "0";
      }
      if (Operators.CompareString(((TextBox) this.TextBox_Display).Text, "0", false) == 0)
        ((TextBox) this.TextBox_Display).Text = "";
      ((TextBox) this.TextBox_Display).Text = ((TextBox) this.TextBox_Display).Text + "1";
    }

    private void Button_GoOut_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void TextBox_Display_TextChanged(object sender, EventArgs e)
    {
      TextBox textBoxDisplay = (TextBox) this.TextBox_Display;
      ModGeneralFunctions.TextBox_ValidateTwoDecimalsOnly(ref textBoxDisplay);
      this.TextBox_Display = (NumericTextBox.NumericTextBox) textBoxDisplay;
    }

    private void TextBox_Display_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (Strings.Asc(e.KeyChar) != 46)
        return;
      this.btnDot_Click((object) e, (EventArgs) null);
    }

    private void FrmCalculator_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyValue != 27)
        return;
      this.Close();
    }
  }
}
