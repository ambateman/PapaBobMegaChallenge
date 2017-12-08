using System;
using PapaBob.DTO.Enums;

namespace PapaBobMegaChallenge
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
          /*  Trash test code
        protected void Button1_Click(object sender, EventArgs e)
        {

            var order = new PapaBob.DTO.OrderDTO();
            order.Id = Guid.NewGuid();
            order.Size = PapaBob.DTO.Enums.SizeType.Large;
            order.Crust = PapaBob.DTO.Enums.CrustType.Thick;
            order.Pepperoni = true;
            order.Name = "Ju Da-Ha";
            order.Address = "123 Tayeon Dr";
            order.PhoneNumber = "555-555-5555";
            order.TotalCost = 19.9500m;
            order.Sausage = true;
            order.ZipCode = "12345";
            order.PaymentType = PapaBob.DTO.Enums.PaymentType.Credit;



            PapaBob.Domain.OrderManager.CreateOrder(order);
        }
        */

        protected void btnOrder_Click(object sender, EventArgs e)
        {

            var order = buildOrder();
            PapaBob.Domain.OrderManager.CreateOrder(order);


        }

        private PaymentType determinePaymentType()
        {
            PapaBob.DTO.Enums.PaymentType payment;
            if (radioCash.Checked)
            {
                payment = PapaBob.DTO.Enums.PaymentType.Cash;
            }
            else  //note -- one MUST be selected, to the 
            {
                payment = PapaBob.DTO.Enums.PaymentType.Credit;
            }
            return payment;
        }

        //Bob decided to offload the enum checking to another set of functions. Also catches the wrong value.
        //But since he doesn't use the exception, what do ?

        private PapaBob.DTO.Enums.SizeType determineSize()
        {
            PapaBob.DTO.Enums.SizeType size;
            if (!Enum.TryParse(listSizes.SelectedValue, out size))
            {
                throw new Exception("Could not determine pizza size");
            }
            return size;
        }
        private PapaBob.DTO.Enums.CrustType determineCrust()
        {
            PapaBob.DTO.Enums.CrustType crust;

            if (!Enum.TryParse(listCrusts.SelectedValue, out crust))
            {
                throw new Exception("Could not determine pizza crust type");
            }
            return crust;
        }

        protected void recalculateTotalCost(object Sender, EventArgs e)
        {
            if (listSizes.SelectedValue == String.Empty) return;
            if (listCrusts.SelectedValue == String.Empty) return;
            var order = buildOrder();
            PapaBob.Domain.
            
            
            

        }


        private PapaBob.DTO.OrderDTO buildOrder()
        {
            var order = new PapaBob.DTO.OrderDTO();
            order.Size = determineSize();
            order.Crust = determineCrust();
            order.Pepperoni = chkPepperoni.Checked;
            order.Sausage = chkSausage.Checked;
            order.Onions = chkOnions.Checked;
            order.Green_Peppers = chkGreenPeppers.Checked;
            order.Name = textName.Text.ToString();
            order.Address = textAddress.Text.ToString();
            order.PhoneNumber = textPhone.Text.ToString();
            order.ZipCode = textZip.Text.ToString();
            order.TotalCost = 0m;
            order.PaymentType = determinePaymentType();
            return order;
        }


    }
}