using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeChapter7
{
    public class ItemRegistry
    {
        private ItemRegistry peristentStore;

        public ItemRegistry() { }


        public void RegisterItem(Item item)
        {

            if (item != null)
            {

                ItemRegistry registry = peristentStore.getItemRegistry();

                if (registry != null)
                {

                    Item existing = registry.getItem(item.getID());

                    if (existing.getBillingPeriod().HasRetailOwner())
                    {

                        existing.register(item);

                    }

                }

            }

        }

        private ItemRegistry getItemRegistry()
        {
            throw new NotImplementedException();
        }

        private Item getItem(object v)
        {
            throw new NotImplementedException();
        }
    }
}
