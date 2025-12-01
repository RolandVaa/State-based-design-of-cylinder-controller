/*
 * Created by nxtSTUDIO.
 * User: Andrei
 * Date: 5/26/2016
 * Time: 6:06 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace HMI.Main.Symbols.Sensor
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
			this.rectangle2 = new NxtControl.GuiFramework.Rectangle();
			this.SensorPosition = new System.HMI.Symbols.Base.Execute<float>();
			this.SensorRear = new System.HMI.Symbols.Base.Led<bool>();
			this.sensor = new NxtControl.GuiFramework.Group();
			// 
			// rectangle2
			// 
			this.rectangle2.Bounds = new NxtControl.Drawing.RectF(((float)(170)), ((float)(25)), ((float)(31)), ((float)(73)));
			this.rectangle2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.HorizontalCenter));
			this.rectangle2.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rectangle2.Name = "rectangle2";
			// 
			// SensorPosition
			// 
			this.SensorPosition.BeginInit();
			this.SensorPosition.AngleIgnore = false;
			this.SensorPosition.DesignTransformation = new NxtControl.Drawing.Matrix(1, 0, 0, 1, 140, 127);
			this.SensorPosition.IsOnlyInput = true;
			this.SensorPosition.Name = "SensorPosition";
			this.SensorPosition.TagName = "SensorPosition";
			this.SensorPosition.Value = 0F;
			this.SensorPosition.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.SensorPositionValueChanged);
			this.SensorPosition.EndInit();
			// 
			// SensorRear
			// 
			this.SensorRear.BeginInit();
			this.SensorRear.AngleIgnore = false;
			this.SensorRear.ColorFrame = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.SensorRear.DesignTransformation = new NxtControl.Drawing.Matrix(2, 0, 0, 2, 186, 82);
			this.SensorRear.Name = "SensorRear";
			propertyDictionary2.Add("Color", new NxtControl.Drawing.Color(((byte)(86)), ((byte)(34)), ((byte)(30))));
			propertyDictionary3.Add("Color", new NxtControl.Drawing.Color(((byte)(234)), ((byte)(22)), ((byte)(30))));
			this.SensorRear.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(false, propertyDictionary2));
			this.SensorRear.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(true, propertyDictionary3));
			propertyDictionary1.Add("Color", new NxtControl.Drawing.Color(((byte)(234)), ((byte)(22)), ((byte)(30))));
			this.SensorRear.Ranges.DefaultPropertyValues = propertyDictionary1;
			this.SensorRear.Shape = System.HMI.Symbols.Base.LedShape.Rectangle;
			this.SensorRear.TagName = "SensorRear";
			this.SensorRear.EndInit();
			// 
			// sensor
			// 
			this.sensor.BeginInit();
			this.sensor.Name = "sensor";
			this.sensor.Shapes.AddRange(new System.ComponentModel.IComponent[] {
									this.rectangle2,
									this.SensorRear});
			this.sensor.EndInit();
			// 
			// sDefault
			// 
			this.Name = "sDefault";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
									this.SensorPosition,
									this.sensor});
			this.SymbolSize = new System.Drawing.Size(441, 333);
		}
		private NxtControl.GuiFramework.Group sensor;
		private System.HMI.Symbols.Base.Led<bool> SensorRear;
		private System.HMI.Symbols.Base.Execute<float> SensorPosition;
		private NxtControl.GuiFramework.Rectangle rectangle2;
		#endregion
	}
}
