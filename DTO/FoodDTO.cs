using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestaurantManagementSystem
{
    class FoodDTO
    {
        private int Food_id, Food_amount,Food_price;
        private string Food_name;

        public FoodDTO(int Food_id, string Food_name, int Food_price)
        {
            this.Food_id = Food_id;
            this.Food_name = Food_name;
            this.Food_price = Food_price;
        }
        
        public int FOOD_ID
        {
            get {return Food_id; }
            set { Food_id = value; }
        }

        public string FOOD_NAME
        {
            get { return Food_name; }
            set { Food_name = value; }
        }
        public int FOOD_PRICE
        {
            get { return Food_price; }
            set { Food_price = value; }
        }
    }
    
}
