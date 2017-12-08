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
    }
}
