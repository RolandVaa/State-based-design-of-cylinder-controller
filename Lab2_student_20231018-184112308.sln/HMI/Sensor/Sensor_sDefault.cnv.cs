/*
 * Created by nxtSTUDIO.
 * User: Andrei
 * Date: 5/26/2016
 * Time: 6:06 PM
 * 
 */

using System;
using System.Drawing;
using NxtControl.GuiFramework;

namespace HMI.Main.Symbols.Sensor
{
	/// <summary>
	/// Description of sDefault.
	/// </summary>
	public partial class sDefault : NxtControl.GuiFramework.HMISymbol
	{
		public sDefault()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
		}
		
		void SensorPositionValueChanged(object sender, ValueChangedEventArgs e)
		{
		  NxtControl.Drawing.PointF newPos = sensor.Location;
		  float position = (float)e.Value;
			newPos.X = position + 170.0d;
			sensor.Location = newPos;
		}
	}
}
