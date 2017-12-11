using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

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

        public static List<DTO.OrderDTO> GetOrders()
        {
            var db = new PapaBobDBEntities();
            var orders = db.Orders;
            var ordersDTO = convertToDTO(orders);
            return ordersDTO;
        }

        private static List<DTO.OrderDTO> convertToDTO(DbSet<Order> orders)
        {
            var ordersDTO = new List<DTO.OrderDTO>();
            
            foreach(var order in orders)
            {
                if (order.Completed == false)
                {
                    var orderDTO = new DTO.OrderDTO();
                    orderDTO.Id = order.Id;
                    orderDTO.Name = order.Name;
                    orderDTO.Address = order.Address;
                    orderDTO.ZipCode = order.Zip;
                    orderDTO.PhoneNumber = order.Phone;
                    orderDTO.Onions = order.Onions;
                    orderDTO.Pepperoni = order.Pepperoni;
                    orderDTO.Sausage = order.Sausage;
                    orderDTO.Green_Peppers = order.Green_Peppers;
                    orderDTO.PaymentType = order.PaymentType;
                    order.TotalCost = order.TotalCost;
                    orderDTO.Completed = order.Completed;
                    orderDTO.Size = order.Size;
                    orderDTO.Crust = order.Crust;
                    ordersDTO.Add(orderDTO);
                }
            }

            return ordersDTO;
        }
    }



}
