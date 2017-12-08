using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapaBob.Persistence
{
    public class PizzaPriceRepository
    {
        public static  DTO.PizzaPriceDTO GetPizzaPrices()
        {
            var db = new PapaBobDBEntities();
            var prices = db.PizzaPrices.First();
            var dto = ConvertToDTO(prices);
            return dto;
        }

        private static DTO.PizzaPriceDTO  ConvertToDTO(PizzaPrice pizzaPrice)
        {
            var dto = new DTO.PizzaPriceDTO();

            dto.Small = pizzaPrice.Small;
            dto.Medium = pizzaPrice.Medium;
            dto.Large = pizzaPrice.Large;
            dto.Thin = pizzaPrice.Thin;
            dto.Regular = pizzaPrice.Regular;
            dto.Thick = pizzaPrice.Thick;
            dto.Sausage = pizzaPrice.Sausage;
            dto.Pepperoni = pizzaPrice.Pepperoni;
            dto.Onions = pizzaPrice.Onions;
            dto.GreenPeppers = pizzaPrice.GreenPeppers;

            return dto;

        }

    }
}
