using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapaBob.Domain
{
    class PizzaPriceManager
    {


        public static decimal CalculatePizzaPrice(DTO.OrderDTO order)
        {
            decimal cost = 0.0m;
            var prices = getPizzaPrices();
            cost += calculateSizeCost(order,prices);
            cost += calculatCrustCost(order, prices);
            cost += calculateToppings(order, prices);


            return 0m;
        }

        private static decimal calculateToppings(DTO.OrderDTO order, DTO.PizzaPriceDTO prices)
        {
            decimal cost = 0.00m;
            cost += (order.Sausage) ? prices.sausage : 0m;
            cost += (order.Pepperoni) ? prices.pepperoni : 0m;
            cost += (order.Onions) ? prices.onions : 0m;
            cost += (order.Green_Peppers) ? prices.greenpeppers : 0m;
            return cost;

        }

        private static decimal calculatCrustCost(DTO.OrderDTO order, DTO.PizzaPriceDTO prices)
        {
            decimal cost = 0.00m;

            switch (order.Crust)
            {
                case DTO.Enums.CrustType.Thin:
                    cost = prices.thin;
                    break;
                case DTO.Enums.CrustType.Regular:
                    cost = prices.regular;
                    break;
                case DTO.Enums.CrustType.Thick:
                    cost = prices.thick;
                    break;
                default:
                    break;
            }

            return cost;
        }

        private static decimal calculateSizeCost(DTO.OrderDTO order, DTO.PizzaPriceDTO prices)
        {
            decimal cost = 0.00m;

            switch (order.Size)
            {
                case DTO.Enums.SizeType.Small:
                    cost = prices.small;
                    break;
                case DTO.Enums.SizeType.Medium:
                    cost = prices.medium;
                    break;
                case DTO.Enums.SizeType.Large:
                    cost = prices.large;
                    break;
                default:
                    break;
            }






            return cost;
        }

        private static DTO.PizzaPriceDTO getPizzaPrices()
        {
            var prices = Persistence.PizzaPriceRepository.GetPizzaPrices();
            return prices;

        }




    }
}
