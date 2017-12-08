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

            dto.small = pizzaPrice.Small;
            dto.medium = pizzaPrice.Medium;
            dto.large = pizzaPrice.Large;
            dto.thin = pizzaPrice.Thin;
            dto.regular = pizzaPrice.Regular;
            dto.thick = pizzaPrice.Thick;
            dto.sausage = pizzaPrice.Sausage;
            dto.pepperoni = pizzaPrice.Pepperoni;
            dto.onions = pizzaPrice.Onions;
            dto.greenpeppers = pizzaPrice.GreenPeppers;

            return dto;

        }

    }
}
