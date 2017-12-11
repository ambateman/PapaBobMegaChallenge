using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PapaBobMegaChallenge
{
    public partial class OrderManagement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            refreshGridView();
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                int index = Convert.ToInt32(e.CommandArgument);
                var row = GridView1.Rows[index];
                var value = row.Cells[1].Text.ToString();
                var orderID = Guid.Parse(value);
                PapaBob.Domain.OrderManager.CompleteOrder(orderID);
                refreshGridView();
            }
            catch (Exception)
            {
                //eat the error
               
            }


        }


        private void refreshGridView()
        {
            var orders = PapaBob.Domain.OrderManager.GetOrders();
            GridView1.DataSource = orders;
            GridView1.DataBind();
        }
    }
}