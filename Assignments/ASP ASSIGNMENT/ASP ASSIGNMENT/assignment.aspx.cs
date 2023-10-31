using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_ASSIGNMENT
{
    public partial class assignment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                // Populate the dropdown list with items
                ddlItems.Items.Add(new ListItem("Bike", "bike.jpeg"));
                ddlItems.Items.Add(new ListItem("car", "car.jpeg"));
                ddlItems.Items.Add(new ListItem("Truck", "truck.jpeg"));
            }

        }

        protected void ddlItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Set the image URL based on the selected item
            string selectedImageUrl = ddlItems.SelectedItem.Value;
            imgItem.ImageUrl = $"Images/{selectedImageUrl}";
        }

        protected void btnShowCost_Click(object sender, EventArgs e)
        {
            // Get the cost of the selected item (You can replace this with your actual cost logic)
            string selectedItem = ddlItems.SelectedItem.Text;
            string cost = GetItemCost(selectedItem);

            lblCost.Text = $"Cost of {selectedItem}: {cost}";
        }

        // You can implement your own cost retrieval logic here
        private string GetItemCost(string item)
        {
            // Replace this with your cost retrieval logic
            switch (item)
            {
                case "Bike":
                    return "Rs 20000";
                case "car":
                    return "Rs 500000";
                case "Truck":
                    return "Rs 1000000";
               
                default:
                    return "N/A";
            }
        }
    }
}