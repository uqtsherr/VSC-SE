#region Prelude
using System;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.Generic;

using VRageMath;
using VRage.Game;
using VRage.Collections;
using Sandbox.ModAPI.Ingame;
using VRage.Game.Components;
using VRage.Game.ModAPI.Ingame;
using Sandbox.ModAPI.Interfaces;
using Sandbox.Game.EntityComponents;
using SpaceEngineers.Game.ModAPI.Ingame;
using VRage.Game.ObjectBuilders.Definitions;

// Change this namespace for each script you create.
namespace SpaceEngineers.UWBlockPrograms.AutoDriller {
    public sealed class Program : MyGridProgram {
    // Your code goes between the next #endregion and #region
#endregion

public Program() {
}

public void Main(string args) {
  // block declarations
  string ERR_TXT = "";
  List<IMyTerminalBlock> BlockList = new List<IMyTerminalBlock>();
  IMyPistonBase ExtentionPiston = null;
  GridTerminalSystem.GetBlocksOfType<IMyPistonBase> BlockList, filterThis);
  if BlockList.Count == 0) {
    ERR_TXT += "no Piston blocks found\n";
  }
  else {
    for(int i = 0; i < BlockList.Count; i++) {
      if BlockList[i].CustomName == "Piston") {
     ExtentionPiston = (IMyPistonBase BlockList[i];
        break;
      }
    }
    if ExtentionPiston == null) {
      ERR_TXT += "no Piston block named Piston found\n";
    }
  }
  
  // display errors
  if(ERR_TXT != "") {
    Echo("Script Errors:\n"+ERR_TXT+"(make sure block ownership is set correctly)");
    return;
  }
  else {Echo("");}
  
  // logic
 ExtentionPiston.Enabled = true;
 ExtentionPiston.Velocity = (float)0.01;
 ExtentionPiston.MinLimit = (float)0;
 ExtentionPiston.MaxLimit = (float)0;
#region PreludeFooter
    }
}
#endregion