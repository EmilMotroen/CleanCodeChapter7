using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeChapter7
{
    public class Item
    {
        private int Id { get; set; }
        private string Name { get; set; }

        private Item BillingPeriod { get; set; }

        private Item retailOwner { get; set; }

        internal Item getBillingPeriod()
        {
            return BillingPeriod;
        }

        internal object getID()
        {
            return Id;
        }

        internal void register(Item item)
        {
            throw new NotImplementedException();
        }

        internal bool HasRetailOwner() {
            if (this == null) return false;

            return true;
        }
    }
}
