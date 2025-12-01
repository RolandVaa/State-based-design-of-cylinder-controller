/*
 * Created by nxtSTUDIO.
 * User: Andrei
 * Date: 5/26/2016
 * Time: 6:02 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace HMI.Main.Symbols.CylinderSA
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
			this.FB1 = new HMI.Main.Symbols.Cylinder.sDefault();
			this.LeftSensor = new HMI.Main.Symbols.Sensor.sDefault();
			this.RightSensor = new HMI.Main.Symbols.Sensor.sDefault();
			this.LeftSensorPosition = new HMI.Main.Symbols.Slider.sDefault();
			this.RightSensorPosition = new HMI.Main.Symbols.Slider.sDefault();
			this.rectangle1 = new NxtControl.GuiFramework.Rectangle();
			// 
			// FB1
			// 
			this.FB1.BeginInit();
			this.FB1.AngleIgnore = false;
			this.FB1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 14D, 36D);
			this.FB1.Name = "FB1";
			this.FB1.SecurityToken = ((uint)(4294967295u));
			this.FB1.TagName = "FB1";
			this.FB1.EndInit();
			// 
			// LeftSensor
			// 
			this.LeftSensor.BeginInit();
			this.LeftSensor.AngleIgnore = false;
			this.LeftSensor.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 406D, 110D);
			this.LeftSensor.Name = "LeftSensor";
			this.LeftSensor.SecurityToken = ((uint)(4294967295u));
			this.LeftSensor.TagName = "LeftSensor";
			this.LeftSensor.EndInit();
			// 
			// RightSensor
			// 
			this.RightSensor.BeginInit();
			this.RightSensor.AngleIgnore = false;
			this.RightSensor.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 596D, 110D);
			this.RightSensor.Name = "RightSensor";
			this.RightSensor.SecurityToken = ((uint)(4294967295u));
			this.RightSensor.TagName = "RightSensor";
			this.RightSensor.EndInit();
			// 
			// LeftSensorPosition
			// 
			this.LeftSensorPosition.BeginInit();
			this.LeftSensorPosition.AngleIgnore = false;
			this.LeftSensorPosition.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 444D, 287D);
			this.LeftSensorPosition.Name = "LeftSensorPosition";
			this.LeftSensorPosition.SecurityToken = ((uint)(4294967295u));
			this.LeftSensorPosition.TagName = "LeftSensorPosition";
			this.LeftSensorPosition.EndInit();
			// 
			// RightSensorPosition
			// 
			this.RightSensorPosition.BeginInit();
			this.RightSensorPosition.AngleIgnore = false;
			this.RightSensorPosition.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 451D, 399D);
			this.RightSensorPosition.Name = "RightSensorPosition";
			this.RightSensorPosition.SecurityToken = ((uint)(4294967295u));
			this.RightSensorPosition.TagName = "RightSensorPosition";
			this.RightSensorPosition.EndInit();
			// 
			// rectangle1
			// 
			this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(136D)), ((float)(822D)), ((float)(18D)));
			this.rectangle1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(2)), ((byte)(178)), ((byte)(238))));
			this.rectangle1.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rectangle1.Name = "rectangle1";
			// 
			// sDefault
			// 
			this.Name = "sDefault";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.FB1,
			this.LeftSensorPosition,
			this.RightSensorPosition,
			this.rectangle1,
			this.LeftSensor,
			this.RightSensor});
			this.SymbolSize = new System.Drawing.Size(845, 502);

		}
		private NxtControl.GuiFramework.Rectangle rectangle1;
		private HMI.Main.Symbols.Slider.sDefault RightSensorPosition;
		private HMI.Main.Symbols.Slider.sDefault LeftSensorPosition;
		private HMI.Main.Symbols.Sensor.sDefault RightSensor;
		private HMI.Main.Symbols.Sensor.sDefault LeftSensor;
		private HMI.Main.Symbols.Cylinder.sDefault FB1;
		#endregion
	}
}
