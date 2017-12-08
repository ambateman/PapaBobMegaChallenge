using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapaBob.Domain
{
    public class OrderManager
    {
        public static void CreateOrder(DTO.OrderDTO orderDTO)
        {
            /*
            var order = new DTO.OrderDTO();
            order.Id = Guid.NewGuid();
            order.Size = DTO.Enums.SizeType.Large;
            order.Crust = DTO.Enums.CrustType.Thick;
            order.Pepperoni = true;
            order.Name = "Ju Da-Ha";
            order.Address = "123 Tayeon Dr";
            order.PhoneNumber = "555-555-5555";
            order.TotalCost = 19.9500m;
            order.Sausage = true;
            order.ZipCode = "12345";
            order.PaymentType = DTO.Enums.PaymentType.Credit;*/
            orderDTO.Id = Guid.NewGuid();
            orderDTO.TotalCost = PizzaPriceManager.CalculatePizzaPrice(orderDTO);
            Persistence.OrderRepository.CreateOrder(orderDTO);
        }



        private static DTO.PizzaPriceDTO getPizzaPrices()
        {
            var prices = Persistence.PizzaPriceRepository.GetPizzaPrices();
            return prices;
        }

        public static decimal CalculatePizzaPrice(DTO.OrderDTO order)
        {
            decimal cost = 0.0m;
            var prices = getPizzaPrices();
            cost += calculateSizeCost(order, prices);
            cost += calculatCrustCost(order, prices);
            cost += calculateToppings(order, prices);
            return cost;
        }

        private static decimal calculateToppings(DTO.OrderDTO order, DTO.PizzaPriceDTO prices)
        {
            decimal cost = 0.00m;
            cost += (order.Sausage) ? prices.Sausage : 0m;
            cost += (order.Pepperoni) ? prices.Pepperoni : 0m;
            cost += (order.Onions) ? prices.Onions : 0m;
            cost += (order.Green_Peppers) ? prices.GreenPeppers : 0m;
            return cost;

        }

        private static decimal calculatCrustCost(DTO.OrderDTO order, DTO.PizzaPriceDTO prices)
        {
            decimal cost = 0.00m;

            switch (order.Crust)
            {
                case DTO.Enums.CrustType.Thin:
                    cost = prices.Thin;
                    break;
                case DTO.Enums.CrustType.Regular:
                    cost = prices.Regular;
                    break;
                case DTO.Enums.CrustType.Thick:
                    cost = prices.Thick;
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
                    cost = prices.Small;
                    break;
                case DTO.Enums.SizeType.Medium:
                    cost = prices.Medium;
                    break;
                case DTO.Enums.SizeType.Large:
                    cost = prices.Large;
                    break;
                default:
                    break;
            }
            return cost;


        }

    }
}
