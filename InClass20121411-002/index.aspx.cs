using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InClass20121411_002
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)    //Only run this code if its not a post back
            {
                //How can we run this only one time?
                //This method runs when the page is loaded into a browser window
                // Add a pizza company to the list box 
                lbPizzaCompanies.Items.Add("LaRosa's");
                //Add a few more items to the listbox 
                lbPizzaCompanies.Items.Add("Papa John's");
                lbPizzaCompanies.Items.Add("Jet's Pizza");

                cblIngredients.Items.Add("Cheese");
                cblIngredients.Items.Add("Sauce");
                cblIngredients.Items.Add("Sausage");
                cblIngredients.Items.Add("Dough");
            }
        }

        protected void cmdSelectPizzaCompany_Click1(object sender, EventArgs e)
        {
            //We call this an "event handler"
            //This code runs when the cmdSelectPizzaCompany button is clicked
            //Write the currently selected pizza company in the list box into the label
            lblSelectedPizzaCompany.Text = lbPizzaCompanies.Text;
        }
    }
}