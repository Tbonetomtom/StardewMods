using StardewValley;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyManagementMod
{
    public class Messages
    {
        public int PublicBal { get; set; }
        public int TaxPercentile { get; set; }
        public int TransferAmount { get; set; }
        public string TransferType { get; set; }
        public long PlayerID { get; set; }
        public Farmer Player { get; set; }
    }
}
