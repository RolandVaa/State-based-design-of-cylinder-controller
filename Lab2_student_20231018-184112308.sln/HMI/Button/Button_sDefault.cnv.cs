/*
 * Created by nxtSTUDIO.
 * User: Andrei
 * Date: 5/25/2016
 * Time: 9:41 PM
 * 
 */

using System;
using System.Drawing;
using NxtControl.GuiFramework;

namespace HMI.Main.Symbols.Button
{
	/// <summary>
	/// Description of sDefault2.
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
		
		void DrawnButton1Click(object sender, EventArgs e)
		{
		  this.FireEvent_CNF();
		}
		
		
		void LABELValueChanged(object sender, ValueChangedEventArgs e)
		{
		  button1.Text = (string)e.Value;
		}
	}
}
