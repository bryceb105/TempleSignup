using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TempleSignup.Models
{
    public class Basket
    {
        public List<BasketLineItem> Items { get; set; } = new List<BasketLineItem>();

        public void AddItem(TempleModel Temp, int qty)
        {
            BasketLineItem line = Items
                .Where(t => t.Temple.id == Temp.id)
                .FirstOrDefault();

            if (line == null)
            {
                Items.Add(new BasketLineItem
                {
                    Temple = Temp,
                    Quantity = qty
                });
            }
            else
            {
                line.Quantity = line.Quantity += qty;
            }
        }
    }

    public class BasketLineItem
    {
        public int LineId { get; set; }
        public TempleModel Temple { get; set; }
        public int Quantity { get; set; }
    }
}
