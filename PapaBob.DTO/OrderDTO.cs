using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapaBob.DTO
{
    public class OrderDTO
    {
        public System.Guid Id { get; set; }
        public PapaBob.DTO.Enums.SizeType Size { get; set; }
        public PapaBob.DTO.Enums.CrustType Crust { get; set; }
        public bool Sausage { get; set; }
        public bool Pepperoni { get; set; }
        public bool Green_Peppers { get; set; }
        public bool Onions { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public PapaBob.DTO.Enums.PaymentType PaymentType { get; set; }
        public bool Completed { get; set; }
        public decimal TotalCost { get; set; }



    }
}
