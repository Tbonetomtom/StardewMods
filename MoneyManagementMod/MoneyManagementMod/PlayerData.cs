using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyManagementMod
{
    public class PlayerData
    {
        public int PreviousMoney { get; set; }
        public int CurrentMoney { get; set; }
        public int TransferAmount { get; set; }
        public bool CanTax { get; set; }
        public bool DrawHUD { get; set; }
        public PlayerData()
        {
            PreviousMoney = -101;
            CurrentMoney = 0;
            TransferAmount = 10;
            CanTax = false;
            DrawHUD = true;
        }
    }
}
