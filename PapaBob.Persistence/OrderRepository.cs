using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapaBob.Persistence
{
    public class OrderRepository
    {
        public static void CreateOrder(DTO.OrderDTO orderDTO)
        {
            var db = new PapaBobDBEntities();

            var order = ConvertToEntity(orderDTO);


            db.Orders.Add(order);
            db.SaveChanges();

        }

        private static Order ConvertToEntity(DTO.OrderDTO orderDTO)
        {
            var order = new Order();
            order.Id = orderDTO.Id;
            order.Size = orderDTO.Size;
            order.Crust = orderDTO.Crust;
            order.Sausage = orderDTO.Sausage;
            order.Pepperoni = orderDTO.Pepperoni;
            order.Green_Peppers = orderDTO.Green_Peppers;
            order.Onions = orderDTO.Onions;
            order.PaymentType = orderDTO.PaymentType;
            order.Name = orderDTO.Name;
            order.Phone = orderDTO.PhoneNumber;
            order.Address = orderDTO.Address;
            order.Completed = orderDTO.Completed;
            order.Zip = orderDTO.ZipCode;
            order.TotalCost = orderDTO.TotalCost;


            return order;

        }



    }



}
