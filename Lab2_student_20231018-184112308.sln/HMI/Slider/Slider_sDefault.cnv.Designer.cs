/*
 * Created by nxtSTUDIO.
 * User: Andrei
 * Date: 5/26/2016
 * Time: 11:35 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace HMI.Main.Symbols.Slider
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
			this.Position = new System.HMI.Symbols.Base.TrackerHorizontal<float>();
			// 
			// Position
			// 
			this.Position.BeginInit();
			this.Position.AngleIgnore = false;
			this.Position.Brush = new NxtControl.Drawing.Brush("TrackerBrush");
			this.Position.DesignTransformation = new NxtControl.Drawing.Matrix(1.0933333333333333, 0, 0, 1, 57, 44);
			this.Position.Font = new NxtControl.Drawing.Font("TrackerFont");
			this.Position.Maximum = 100F;
			this.Position.MaximumTag = null;
			this.Position.Minimum = -100F;
			this.Position.MinimumTag = null;
			this.Position.MouseMoveValueThreshold = 0;
			this.Position.Name = "Position";
			this.Position.Pen = new NxtControl.Drawing.Pen("TrackerPen");
			this.Position.Radius = 20;
			this.Position.TagName = "Position";
			this.Position.TickLength = 5;
			this.Position.TrackHandleSize = 28;
			this.Position.TrackLineDisabledBrush = new NxtControl.Drawing.Brush("TrackerLineDisabledBrush");
			this.Position.EndInit();
			// 
			// sDefault
			// 
			this.Name = "sDefault";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
									this.Position});
			this.SymbolSize = new System.Drawing.Size(472, 225);
		}
		private System.HMI.Symbols.Base.TrackerHorizontal<float> Position;
		#endregion
	}
}
