/*
 * Created by nxtSTUDIO.
 * User: Andrei
 * Date: 5/26/2016
 * Time: 4:55 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace HMI.Main.Symbols.Valve
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sDefault));
			this.valve = new NxtControl.GuiFramework.Rectangle();
			this.rectangle2 = new NxtControl.GuiFramework.Rectangle();
			this.Position = new System.HMI.Symbols.Base.Execute<float>();
			this.line1 = new NxtControl.GuiFramework.Line();
			this.line2 = new NxtControl.GuiFramework.Line();
			this.line3 = new NxtControl.GuiFramework.Line();
			this.ellipse1 = new NxtControl.GuiFramework.Ellipse();
			this.ellipse2 = new NxtControl.GuiFramework.Ellipse();
			this.polygon1 = new NxtControl.GuiFramework.Polygon();
			this.polygon2 = new NxtControl.GuiFramework.Polygon();
			this.line4 = new NxtControl.GuiFramework.Line();
			this.line5 = new NxtControl.GuiFramework.Line();
			// 
			// valve
			// 
			this.valve.Bounds = new NxtControl.Drawing.RectF(((float)(70)), ((float)(44)), ((float)(186)), ((float)(45)));
			this.valve.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.valve.ImageStream = ((System.IO.MemoryStream)(resources.GetObject("valve.ImageStream")));
			this.valve.Name = "valve";
			// 
			// rectangle2
			// 
			this.rectangle2.Bounds = new NxtControl.Drawing.RectF(((float)(14)), ((float)(26)), ((float)(251)), ((float)(79)));
			this.rectangle2.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rectangle2.Name = "rectangle2";
			// 
			// Position
			// 
			this.Position.BeginInit();
			this.Position.AngleIgnore = false;
			this.Position.DesignTransformation = new NxtControl.Drawing.Matrix(1, 0, 0, 1, 105, 125);
			this.Position.IsOnlyInput = true;
			this.Position.Name = "Position";
			this.Position.TagName = "Position";
			this.Position.Value = 0F;
			this.Position.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.PositionValueChanged);
			this.Position.EndInit();
			// 
			// line1
			// 
			this.line1.EndPoint = new NxtControl.Drawing.PointF(132, 26);
			this.line1.Name = "line1";
			this.line1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line1.StartPoint = new NxtControl.Drawing.PointF(132, 43);
			// 
			// line2
			// 
			this.line2.EndPoint = new NxtControl.Drawing.PointF(153, 26);
			this.line2.Name = "line2";
			this.line2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line2.StartPoint = new NxtControl.Drawing.PointF(153, 43);
			// 
			// line3
			// 
			this.line3.EndPoint = new NxtControl.Drawing.PointF(142, 105);
			this.line3.Name = "line3";
			this.line3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line3.StartPoint = new NxtControl.Drawing.PointF(142, 89);
			// 
			// ellipse1
			// 
			this.ellipse1.Bounds = new NxtControl.Drawing.RectF(((float)(134)), ((float)(106)), ((float)(16)), ((float)(16)));
			this.ellipse1.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.ellipse1.Name = "ellipse1";
			// 
			// ellipse2
			// 
			this.ellipse2.Bounds = new NxtControl.Drawing.RectF(((float)(138)), ((float)(110)), ((float)(8)), ((float)(8)));
			this.ellipse2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.ellipse2.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.ellipse2.Name = "ellipse2";
			// 
			// polygon1
			// 
			this.polygon1.Bounds = new NxtControl.Drawing.RectF(((float)(127)), ((float)(94)), ((float)(12)), ((float)(8)));
			this.polygon1.Closed = true;
			this.polygon1.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.polygon1.Name = "polygon1";
			this.polygon1.Points.AddRange(new NxtControl.Drawing.PointF[] {
									new NxtControl.Drawing.PointF(139, 94),
									new NxtControl.Drawing.PointF(127, 94),
									new NxtControl.Drawing.PointF(133, 102)});
			// 
			// polygon2
			// 
			this.polygon2.Bounds = new NxtControl.Drawing.RectF(((float)(148)), ((float)(94)), ((float)(12)), ((float)(8)));
			this.polygon2.Closed = true;
			this.polygon2.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.polygon2.Name = "polygon2";
			this.polygon2.Points.AddRange(new NxtControl.Drawing.PointF[] {
									new NxtControl.Drawing.PointF(160, 94),
									new NxtControl.Drawing.PointF(148, 94),
									new NxtControl.Drawing.PointF(154, 102)});
			// 
			// line4
			// 
			this.line4.EndPoint = new NxtControl.Drawing.PointF(133, 90);
			this.line4.Name = "line4";
			this.line4.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line4.StartPoint = new NxtControl.Drawing.PointF(133, 94);
			// 
			// line5
			// 
			this.line5.EndPoint = new NxtControl.Drawing.PointF(154, 90);
			this.line5.Name = "line5";
			this.line5.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line5.StartPoint = new NxtControl.Drawing.PointF(154, 94);
			// 
			// sDefault
			// 
			this.Name = "sDefault";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
									this.rectangle2,
									this.valve,
									this.Position,
									this.line1,
									this.line2,
									this.line3,
									this.ellipse1,
									this.ellipse2,
									this.polygon1,
									this.polygon2,
									this.line4,
									this.line5});
			this.SymbolSize = new System.Drawing.Size(309, 181);
		}
		private NxtControl.GuiFramework.Line line5;
		private NxtControl.GuiFramework.Line line4;
		private NxtControl.GuiFramework.Polygon polygon2;
		private NxtControl.GuiFramework.Polygon polygon1;
		private NxtControl.GuiFramework.Ellipse ellipse2;
		private NxtControl.GuiFramework.Ellipse ellipse1;
		private NxtControl.GuiFramework.Line line3;
		private NxtControl.GuiFramework.Line line2;
		private NxtControl.GuiFramework.Line line1;
		private NxtControl.GuiFramework.Rectangle valve;
		private System.HMI.Symbols.Base.Execute<float> Position;
		private NxtControl.GuiFramework.Rectangle rectangle2;
		#endregion
	}
}
