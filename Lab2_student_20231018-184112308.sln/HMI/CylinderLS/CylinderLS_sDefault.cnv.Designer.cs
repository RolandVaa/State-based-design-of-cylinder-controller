/*
 * Created by nxtSTUDIO.
 * User: Andrei
 * Date: 5/26/2016
 * Time: 7:34 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace HMI.Main.Symbols.CylinderLS
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
			this.FB3 = new HMI.Main.Symbols.CylinderSA.sDefault();
			this.FB1 = new HMI.Main.Symbols.Valve.sDefault();
			this.line1 = new NxtControl.GuiFramework.Line();
			// 
			// FB3
			// 
			this.FB3.BeginInit();
			this.FB3.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 6D, 55D);
			this.FB3.Name = "FB3";
			this.FB3.SecurityToken = ((uint)(4294967295u));
			this.FB3.TagName = "FB3";
			this.FB3.EndInit();
			// 
			// FB1
			// 
			this.FB1.BeginInit();
			this.FB1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 47D, 212D);
			this.FB1.Name = "FB1";
			this.FB1.SecurityToken = ((uint)(4294967295u));
			this.FB1.TagName = "FB1";
			this.FB1.EndInit();
			// 
			// line1
			// 
			this.line1.EndPoint = new NxtControl.Drawing.PointF(165D, 193D);
			this.line1.Name = "line1";
			this.line1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line1.StartPoint = new NxtControl.Drawing.PointF(165D, 213D);
			// 
			// sDefault
			// 
			this.Name = "sDefault";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.FB3,
			this.FB1,
			this.line1});
			this.SymbolSize = new System.Drawing.Size(800, 600);

		}
		private HMI.Main.Symbols.Valve.sDefault FB1;
		private HMI.Main.Symbols.CylinderSA.sDefault FB3;
		private NxtControl.GuiFramework.Line line1;
		#endregion
	}
}
