using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestaurantManagementSystem
{
    class ProfitDTO
    {
        private int Profit_id;
        private string Profit_date, Profit_earn, Profit_cost, Profit_profit;

        public ProfitDTO(int Prfit_id, string Profit_date)
        {
            this.Profit_id = Profit_id;
            this.Profit_date = Profit_date;
        }
        
        public int PROFIT_ID
        {
            get {return Profit_id; }
            set { Profit_id = value; }
        }

        public string PROFIT_DATE
        {
            get { return Profit_date; }
            set { Profit_date = value; }
        }
        public string PROFIT_EARN
        {
            get { return Profit_earn; }
            set { Profit_earn = value; }
        }
        public string PROFIT_COST
        {
            get { return Profit_cost; }
            set { Profit_cost = value; }
        }
        public string PROFIT_PROFIT
        {
            get { return Profit_profit; }
            set { Profit_profit = value; }
        }
    }
}
