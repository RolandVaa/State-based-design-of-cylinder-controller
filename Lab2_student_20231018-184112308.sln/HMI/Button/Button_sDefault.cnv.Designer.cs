/*
 * Created by nxtSTUDIO.
 * User: Andrei
 * Date: 5/25/2016
 * Time: 9:41 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace HMI.Main.Symbols.Button
{
	/// <summary>
	/// Summary description for sDefault2.
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
			this.button1 = new NxtControl.GuiFramework.DrawnButton();
			this.LABEL = new System.HMI.Symbols.Base.Execute<string>();
			this.Light = new System.HMI.Symbols.Base.Led<bool>();
			// 
			// button1
			// 
			this.button1.Bounds = new NxtControl.Drawing.RectF(((float)(19D)), ((float)(83D)), ((float)(114D)), ((float)(37D)));
			this.button1.Brush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.button1.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.button1.InnerBorderColor = new NxtControl.Drawing.Color("ButtonInnerBorderColor");
			this.button1.Name = "button1";
			this.button1.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.button1.Radius = 4D;
			this.button1.Text = "Button";
			this.button1.TextColor = new NxtControl.Drawing.Color("ButtonTextColor");
			this.button1.TextColorMouseDown = new NxtControl.Drawing.Color("ButtonTextColorMouseDown");
			this.button1.Click += new System.EventHandler(this.DrawnButton1Click);
			// 
			// LABEL
			// 
			this.LABEL.BeginInit();
			this.LABEL.AngleIgnore = false;
			this.LABEL.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 90D, 258D);
			this.LABEL.IsOnlyInput = true;
			this.LABEL.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.LABEL.Name = "LABEL";
			this.LABEL.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.LABEL.TagName = "LABEL";
			this.LABEL.Value = null;
			this.LABEL.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.LABELValueChanged);
			this.LABEL.EndInit();
			// 
			// Light
			// 
			this.Light.BeginInit();
			this.Light.AngleIgnore = false;
			this.Light.ColorFrame = new NxtControl.Drawing.Color("LedFrameColor");
			this.Light.DesignMatrix = new NxtControl.Drawing.Matrix2D(3.25D, 0D, 0D, 3.4166666666666665D, 74.5D, 46.499999999999986D);
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
			// sDefault
			// 
			this.Name = "sDefault2";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.button1,
			this.LABEL,
			this.Light});
			this.SymbolSize = new System.Drawing.Size(200, 200);

		}
		private System.HMI.Symbols.Base.Execute<string> LABEL;
		private NxtControl.GuiFramework.DrawnButton button1;
		private System.HMI.Symbols.Base.Led<bool> Light;
		#endregion
	}
}
