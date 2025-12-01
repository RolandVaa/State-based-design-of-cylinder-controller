/*
 * Created by nxtSTUDIO.
 * User: Andrei
 * Date: 5/26/2016
 * Time: 4:55 PM
 * 
 */

using System;
using System.Drawing;
using NxtControl.GuiFramework;

namespace HMI.Main.Symbols.Valve
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
		
		void PositionValueChanged(object sender, ValueChangedEventArgs e)
		{
			NxtControl.Drawing.PointF newPos = valve.Location;
		  float position = - (float)e.Value;
		  double relpos = position + 70.0d;
			newPos.X = relpos;
			valve.Location = newPos;
		}
	}
}
