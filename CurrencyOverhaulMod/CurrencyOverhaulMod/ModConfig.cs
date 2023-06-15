using StardewModdingAPI.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyManagementMod
{
    public sealed class ModConfig
    {
        public int TaxPercentile { get; set; } = 10;
        public bool RenderHUD { get; set; } = true;
        public KeybindList TransferFromPublic { get; set; } = KeybindList.Parse("Down, LeftStick + DPadDown");
        public KeybindList TransferToPublic { get; set; } = KeybindList.Parse("Up, LeftStick + DPadUp");
        public KeybindList RaiseAmount { get; set; } = KeybindList.Parse("Left, LeftStick + DPadLeft");
        public KeybindList LowerAmount { get; set; } = KeybindList.Parse("Right, LeftStick + DPadRight");
    }
}
