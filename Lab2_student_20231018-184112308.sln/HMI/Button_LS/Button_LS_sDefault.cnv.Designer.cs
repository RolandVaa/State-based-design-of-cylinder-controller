/*
 * Created by EcoStruxure Automation Expert.
 * User: Pranay Jhunjhunwala
 * Date: 07/03/2023
 * Time: 12:44 pm
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace HMI.Main.Symbols.Button_LS
{
	/// <summary>
	/// Summary description for sDefault.
	/// </summary>
	partial class sDefault
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary2 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary3 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary1 = new NxtControl.GuiFramework.PropertyDictionary();
			this.Light = new System.HMI.Symbols.Base.Led<bool>();
			this.BName = new System.HMI.Symbols.Base.Label();
			this.Button = new System.HMI.Symbols.Base.Execute<bool>();
			this.checkButton1 = new System.HMI.Symbols.Base.CheckButton();
			// 
			// Light
			// 
			this.Light.BeginInit();
			this.Light.AngleIgnore = false;
			this.Light.ColorFrame = new NxtControl.Drawing.Color("LedFrameColor");
			this.Light.DesignMatrix = new NxtControl.Drawing.Matrix2D(3.25D, 0D, 0D, 3.25D, 83.5D, 91.5D);
			this.Light.FrameSize = 33F;
			this.Light.IsOnlyInput = true;
			this.Light.Name = "Light";
			propertyDictionary2.Add("Color", new NxtControl.Drawing.Color("LedFalseColor"));
			propertyDictionary3.Add("Color", new NxtControl.Drawing.Color("LedTrueColor"));
			this.Light.Ranges.Clear();
			this.Light.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(false, propertyDictionary2));
			this.Light.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(true, propertyDictionary3));
			propertyDictionary1.Add("Color", new NxtControl.Drawing.Color("LedFalseColor"));
			this.Light.Ranges.DefaultPropertyValues = propertyDictionary1;
			this.Light.TagName = "Light";
			this.Light.EndInit();
			// 
			// BName
			// 
			this.BName.BeginInit();
			this.BName.AngleIgnore = false;
			this.BName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.BName.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.90666666666666662D, 0D, 0D, 1D, 16D, 160D);
			this.BName.FontScale = false;
			this.BName.IsOnlyInput = true;
			this.BName.Name = "BName";
			this.BName.Pen = new NxtControl.Drawing.Pen("LabelPen");
			this.BName.TagName = "BName";
			this.BName.EndInit();
			// 
			// Button
			// 
			this.Button.BeginInit();
			this.Button.AngleIgnore = false;
			this.Button.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.Button.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.Button.Name = "Button";
			this.Button.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.Button.TagName = "Button";
			this.Button.Value = false;
			this.Button.EndInit();
			// 
			// checkButton1
			// 
			this.checkButton1.BeginInit();
			this.checkButton1.AngleIgnore = false;
			this.checkButton1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.2999999999999998D, 0D, 0D, 1D, 32D, 120D);
			this.checkButton1.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.checkButton1.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.checkButton1.Name = "checkButton1";
			this.checkButton1.TagName = "Button";
			this.checkButton1.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.checkButton1.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.checkButton1.Value = false;
			this.checkButton1.EndInit();
			// 
			// sDefault
			// 
			this.Name = "sDefault";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.Light,
			this.BName,
			this.Button,
			this.checkButton1});
			this.SymbolSize = new System.Drawing.Size(600, 400);

		}
		private System.HMI.Symbols.Base.Led<bool> Light;
		private System.HMI.Symbols.Base.Label BName;
		private System.HMI.Symbols.Base.Execute<bool> Button;
		private System.HMI.Symbols.Base.CheckButton checkButton1;
		#endregion
	}
}
