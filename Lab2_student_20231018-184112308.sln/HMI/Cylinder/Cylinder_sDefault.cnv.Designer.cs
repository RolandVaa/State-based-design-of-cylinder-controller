/*
 * Created by nxtSTUDIO.
 * User: Andrei
 * Date: 5/25/2016
 * Time: 10:19 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace HMI.Main.Symbols.Cylinder
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
			this.rectangle1 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle2 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle3 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle4 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle5 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle6 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle7 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle8 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle9 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle10 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle11 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle12 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle14 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle13 = new NxtControl.GuiFramework.Rectangle();
			this.roundedRectangle1 = new NxtControl.GuiFramework.RoundedRectangle();
			this.GrpInnerPart = new NxtControl.GuiFramework.Group();
			this.PosChange = new System.HMI.Symbols.Base.Execute<float>();
			// 
			// rectangle1
			// 
			this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(40)), ((float)(40)), ((float)(30)), ((float)(100)));
			this.rectangle1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(130)), ((byte)(130)), ((byte)(130))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.DiagonalRightTop));
			this.rectangle1.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rectangle1.Name = "rectangle1";
			// 
			// rectangle2
			// 
			this.rectangle2.Bounds = new NxtControl.Drawing.RectF(((float)(50)), ((float)(65)), ((float)(20)), ((float)(50)));
			this.rectangle2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(130)), ((byte)(130)), ((byte)(130))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.VerticalCenter));
			this.rectangle2.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rectangle2.Name = "rectangle2";
			// 
			// rectangle3
			// 
			this.rectangle3.Bounds = new NxtControl.Drawing.RectF(((float)(50)), ((float)(115)), ((float)(11)), ((float)(25)));
			this.rectangle3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.HorizontalCenter));
			this.rectangle3.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rectangle3.Name = "rectangle3";
			// 
			// rectangle4
			// 
			this.rectangle4.Bounds = new NxtControl.Drawing.RectF(((float)(70)), ((float)(56)), ((float)(250)), ((float)(70)));
			this.rectangle4.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(114)), ((byte)(114)), ((byte)(114))));
			this.rectangle4.FillDirection = NxtControl.Drawing.FillDirection.RightToLeft;
			this.rectangle4.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rectangle4.Name = "rectangle4";
			// 
			// rectangle5
			// 
			this.rectangle5.Bounds = new NxtControl.Drawing.RectF(((float)(320)), ((float)(40)), ((float)(30)), ((float)(100)));
			this.rectangle5.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(130)), ((byte)(130)), ((byte)(130))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.DiagonalRightTop));
			this.rectangle5.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rectangle5.Name = "rectangle5";
			// 
			// rectangle6
			// 
			this.rectangle6.Bounds = new NxtControl.Drawing.RectF(((float)(320)), ((float)(65)), ((float)(20)), ((float)(50)));
			this.rectangle6.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(130)), ((byte)(130)), ((byte)(130))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.VerticalCenter));
			this.rectangle6.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rectangle6.Name = "rectangle6";
			// 
			// rectangle7
			// 
			this.rectangle7.Bounds = new NxtControl.Drawing.RectF(((float)(330)), ((float)(115)), ((float)(10)), ((float)(25)));
			this.rectangle7.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.HorizontalCenter));
			this.rectangle7.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rectangle7.Name = "rectangle7";
			// 
			// rectangle8
			// 
			this.rectangle8.Bounds = new NxtControl.Drawing.RectF(((float)(70)), ((float)(45)), ((float)(250)), ((float)(4)));
			this.rectangle8.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(210)), ((byte)(210)), ((byte)(210))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.VerticalCenter));
			this.rectangle8.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rectangle8.Name = "rectangle8";
			// 
			// rectangle9
			// 
			this.rectangle9.Bounds = new NxtControl.Drawing.RectF(((float)(70)), ((float)(130)), ((float)(250)), ((float)(4)));
			this.rectangle9.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(210)), ((byte)(210)), ((byte)(210))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.VerticalCenter));
			this.rectangle9.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rectangle9.Name = "rectangle9";
			// 
			// rectangle10
			// 
			this.rectangle10.Bounds = new NxtControl.Drawing.RectF(((float)(70)), ((float)(61)), ((float)(250)), ((float)(60)));
			this.rectangle10.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.VerticalCenter));
			this.rectangle10.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rectangle10.Name = "rectangle10";
			// 
			// rectangle11
			// 
			this.rectangle11.Bounds = new NxtControl.Drawing.RectF(((float)(340)), ((float)(84)), ((float)(10)), ((float)(14)));
			this.rectangle11.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(114)), ((byte)(114)), ((byte)(114))));
			this.rectangle11.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rectangle11.Name = "rectangle11";
			// 
			// rectangle12
			// 
			this.rectangle12.Bounds = new NxtControl.Drawing.RectF(((float)(70)), ((float)(61)), ((float)(10)), ((float)(60)));
			this.rectangle12.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(186)), ((byte)(186)), ((byte)(186))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.VerticalCenter));
			this.rectangle12.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rectangle12.Name = "rectangle12";
			// 
			// rectangle14
			// 
			this.rectangle14.Bounds = new NxtControl.Drawing.RectF(((float)(350)), ((float)(77)), ((float)(25)), ((float)(25)));
			this.rectangle14.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(114)), ((byte)(114)), ((byte)(114))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.DiagonalRightTop));
			this.rectangle14.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rectangle14.Name = "rectangle14";
			// 
			// rectangle13
			// 
			this.rectangle13.Bounds = new NxtControl.Drawing.RectF(((float)(80)), ((float)(86)), ((float)(320)), ((float)(10)));
			this.rectangle13.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(210)), ((byte)(210)), ((byte)(210))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.VerticalCenter));
			this.rectangle13.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rectangle13.Name = "rectangle13";
			// 
			// roundedRectangle1
			// 
			this.roundedRectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(399)), ((float)(77)), ((float)(50)), ((float)(30)));
			this.roundedRectangle1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(254)), ((byte)(186)), ((byte)(10))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.DiagonalRightTop, new NxtControl.Drawing.GradientFillColorBlend(new NxtControl.Drawing.Color[] {
															new NxtControl.Drawing.Color(((byte)(255)), ((byte)(235)), ((byte)(74))),
															new NxtControl.Drawing.Color(((byte)(254)), ((byte)(186)), ((byte)(10)))}, new float[] {
															0F,
															1F})));
			this.roundedRectangle1.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.roundedRectangle1.Name = "roundedRectangle1";
			this.roundedRectangle1.Radius = 20;
			// 
			// GrpInnerPart
			// 
			this.GrpInnerPart.BeginInit();
			this.GrpInnerPart.Name = "GrpInnerPart";
			this.GrpInnerPart.Shapes.AddRange(new System.ComponentModel.IComponent[] {
									this.rectangle12,
									this.rectangle13,
									this.roundedRectangle1});
			this.GrpInnerPart.EndInit();
			// 
			// PosChange
			// 
			this.PosChange.BeginInit();
			this.PosChange.AngleIgnore = false;
			this.PosChange.DesignTransformation = new NxtControl.Drawing.Matrix(1, 0, 0, 1, 142, 137);
			this.PosChange.IsOnlyInput = true;
			this.PosChange.Name = "PosChange";
			this.PosChange.TagName = "POS";
			this.PosChange.Value = 0F;
			this.PosChange.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.PosChangeValueChanged);
			this.PosChange.EndInit();
			// 
			// sDefault
			// 
			this.Name = "sDefault";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
									this.rectangle1,
									this.rectangle2,
									this.rectangle3,
									this.rectangle4,
									this.rectangle5,
									this.rectangle6,
									this.rectangle7,
									this.rectangle8,
									this.rectangle9,
									this.rectangle10,
									this.rectangle11,
									this.rectangle14,
									this.GrpInnerPart,
									this.PosChange});
			this.SymbolSize = new System.Drawing.Size(490, 184);
		}
		private System.HMI.Symbols.Base.Execute<float> PosChange;
		private NxtControl.GuiFramework.Group GrpInnerPart;
		private NxtControl.GuiFramework.RoundedRectangle roundedRectangle1;
		private NxtControl.GuiFramework.Rectangle rectangle13;
		private NxtControl.GuiFramework.Rectangle rectangle14;
		private NxtControl.GuiFramework.Rectangle rectangle12;
		private NxtControl.GuiFramework.Rectangle rectangle11;
		private NxtControl.GuiFramework.Rectangle rectangle10;
		private NxtControl.GuiFramework.Rectangle rectangle9;
		private NxtControl.GuiFramework.Rectangle rectangle8;
		private NxtControl.GuiFramework.Rectangle rectangle7;
		private NxtControl.GuiFramework.Rectangle rectangle6;
		private NxtControl.GuiFramework.Rectangle rectangle5;
		private NxtControl.GuiFramework.Rectangle rectangle4;
		private NxtControl.GuiFramework.Rectangle rectangle3;
		private NxtControl.GuiFramework.Rectangle rectangle2;
		private NxtControl.GuiFramework.Rectangle rectangle1;
		#endregion
	}
}
