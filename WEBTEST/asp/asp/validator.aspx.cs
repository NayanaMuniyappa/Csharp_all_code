using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace asp
{
    public partial class validator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCheck_Click(object sender, EventArgs e)
        {
            // Retrieve user input from textboxes
            string name = txtName.Text;
            string familyName = txtFamilyName.Text;
            string address = txtAddress.Text;
            string city = txtCity.Text;
            string zipCode = txtZipCode.Text;
            string phone = txtPhone.Text;
            string email = txtEmail.Text;

            // Perform validation or processing here
            // For simplicity, we'll just display a message on the same page
            string resultMessage = $@"Name: {name}<br />
            Family Name: {familyName}<br />
            City: {city}<br />
            Zip Code: {zipCode}<br />
             Phone: {phone}<br />
             Email: {email}<br />";

            // Display the result on the same page
            resultLabel.Text = resultMessage;
        }
    }
}