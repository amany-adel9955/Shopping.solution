using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.Bl.Dtos
{
    public class CartItemQuantityEditDto
    {
        public int CartItemId { get; set; }

        public int Qty { get; set; }
    }
}
