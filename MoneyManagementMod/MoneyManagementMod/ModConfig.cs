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
        public int TaxPercent { get; set; } = 10;
        public bool RenderHUD { get; set; } = true;
        public bool DistributeShippingBinMoneyEqually { get; set; } = false;
        public KeybindList WithdrawFromPublicAccount { get; set; } = KeybindList.Parse("Down, LeftStick + DPadDown");
        public KeybindList DepositToPublicAccount { get; set; } = KeybindList.Parse("Up, LeftStick + DPadUp");
        public KeybindList IncreaseTransferAmount { get; set; } = KeybindList.Parse("Left, LeftStick + DPadLeft");
        public KeybindList DecreaseTransferAmount { get; set; } = KeybindList.Parse("Right, LeftStick + DPadRight");
    }
}
