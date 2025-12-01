/*
 * Created by nxtSTUDIO.
 * User: Andrei
 * Date: 5/26/2016
 * Time: 7:34 PM
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #CylinderLS_HMI;

namespace HMI.Main.Symbols.CylinderLS
{

  public class CNFEventArgs : System.EventArgs
  {
    public CNFEventArgs()
    {
    }
    private System.Single? Position_field = null;
    public System.Single? Position
    {
       get { return Position_field; }
       set { Position_field = value; }
    }

  }

}

namespace HMI.Main.Symbols.CylinderLS
{
  partial class sDefault
  {
    public bool FireEvent_CNF(System.Single Position)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {Position});
    }
    public bool FireEvent_CNF(HMI.Main.Symbols.CylinderLS.CNFEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Position.HasValue) _values_[0] = ea.Position.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF(System.Single Position, bool ignore_Position)
    {
      object[] _values_ = new object[1];
      if (!ignore_Position) _values_[0] = Position;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }

  }
}
#endregion #CylinderLS_HMI;

#endregion Definitions;
