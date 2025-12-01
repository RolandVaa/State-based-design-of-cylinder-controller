/*
 * Created by nxtSTUDIO.
 * User: Andrei
 * Date: 5/26/2016
 * Time: 8:11 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;

using NxtControl.GuiFramework;

namespace HMI.Main.Canvases
{
	/// <summary>
	/// Summary description for Canvas1.
	/// </summary>
	partial class Canvas1
	{
		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.polyline1 = new NxtControl.GuiFramework.Polyline();
			this.polyline2 = new NxtControl.GuiFramework.Polyline();
			this.sDefault1 = new HMI.Main.Symbols.Valve.sDefault();
			this.sDefault2 = new HMI.Main.Symbols.CylinderSA.sDefault();
			this.BT = new HMI.Main.Symbols.Button.sDefault();
			// 
			// polyline1
			// 
			this.polyline1.Bounds = new NxtControl.Drawing.RectF(((float)(201D)), ((float)(167D)), ((float)(156D)), ((float)(76D)));
			this.polyline1.Closed = false;
			this.polyline1.Name = "polyline1";
			this.polyline1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 8F, NxtControl.Drawing.DashStyle.Solid);
			this.polyline1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(201D, 243D),
			new NxtControl.Drawing.PointF(201D, 206D),
			new NxtControl.Drawing.PointF(357D, 206D),
			new NxtControl.Drawing.PointF(357D, 167D)});
			// 
			// polyline2
			// 
			this.polyline2.Bounds = new NxtControl.Drawing.RectF(((float)(79D)), ((float)(167D)), ((float)(101D)), ((float)(76D)));
			this.polyline2.Closed = false;
			this.polyline2.Name = "polyline2";
			this.polyline2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 8F, NxtControl.Drawing.DashStyle.Solid);
			this.polyline2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(180D, 243D),
			new NxtControl.Drawing.PointF(180D, 206D),
			new NxtControl.Drawing.PointF(79D, 206D),
			new NxtControl.Drawing.PointF(79D, 167D)});
			// 
			// sDefault1
			// 
			this.sDefault1.BeginInit();
			this.sDefault1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 63D, 239D);
			this.sDefault1.Name = "sDefault1";
			this.sDefault1.SecurityToken = ((uint)(4294967295u));
			this.sDefault1.TagName = "DDBFAD30FE6C199.FB1";
			this.sDefault1.EndInit();
			// 
			// sDefault2
			// 
			this.sDefault2.BeginInit();
			this.sDefault2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 57D, 40D);
			this.sDefault2.Name = "sDefault2";
			this.sDefault2.SecurityToken = ((uint)(4294967295u));
			this.sDefault2.TagName = "DDBFAD30FE6C199.FB3";
			this.sDefault2.EndInit();
			// 
			// BT
			// 
			this.BT.BeginInit();
			this.BT.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 135D, 381D);
			this.BT.Name = "BT";
			this.BT.SecurityToken = ((uint)(4294967295u));
			this.BT.TagName = "125C1126F0D1DBAD";
			this.BT.EndInit();
			// 
			// Canvas1
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(800D)), ((float)(520D)));
			this.Brush = new NxtControl.Drawing.Brush("CanvasBrush");
			this.Name = "Canvas1";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.polyline1,
			this.polyline2,
			this.sDefault1,
			this.sDefault2,
			this.BT});
			this.Size = new System.Drawing.Size(800, 520);

		}
		private NxtControl.GuiFramework.Polyline polyline2;
		private NxtControl.GuiFramework.Polyline polyline1;
		private HMI.Main.Symbols.Valve.sDefault sDefault1;
		private HMI.Main.Symbols.CylinderSA.sDefault sDefault2;
		private HMI.Main.Symbols.Button.sDefault BT;
		#endregion
	}
}
