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
            if (!IsPostBack)
            {
                // Initialize the Dropdown list
                ddlItems.SelectedIndex = 0;
            }

        }

        protected void ddlItems_SelectedIndexChanged(object sender, EventArgs e)
        {

            string selectedItem = ddlItems.SelectedValue;

            if (!string.IsNullOrEmpty(selectedItem))
            {
                string imageUrl = $"Images/{selectedItem}.jpg"; // Assuming images have the same names as item values
                imgDisplay.ImageUrl = imageUrl;

                // You should have a data source for item costs, here is a simplified example:
                string itemCost = GetItemCost(selectedItem);
                lblCost.Text = $"Cost of {selectedItem}: {itemCost}";
            }

            imgDisplay.Visible = true;

        }
        private string GetItemCost(string selectedItem)
        {
            switch (selectedItem)
            {
                case "car":
                    return "$25,000";
                case "bike":
                    return "$500";
                case "truck":
                    return "$50,000";
                default:
                    return "Not available";
            }
        }
    }
}