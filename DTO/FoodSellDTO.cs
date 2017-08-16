using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestaurantManagementSystem
{
    class FoodSellDTO
    {
        private int Sell_id;
        private string Sell_amount;

        public FoodSellDTO(int Sell_id, string Sell_amount)
        {
            this.Sell_id = Sell_id;
            this.Sell_amount = Sell_amount;

        }

        public int SELL_ID
        {
            get { return Sell_id; }
            set { Sell_id = value; }
        }

        public string SELL_AMOUNT
        {
            get { return Sell_amount; }
            set { Sell_amount = value; }
        }
    }
}
