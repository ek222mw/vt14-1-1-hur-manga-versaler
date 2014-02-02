using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Labb_1_Rakna_Versaler.Model;
namespace Labb_1_Rakna_Versaler
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CountButton_Click(object sender, EventArgs e)
        {
            
            var count = Labb_1_Rakna_Versaler.Model.Math.getNumber(VersalTextBox.Text);
            VersalLabel.Text = "Antal Versaler: " + count.ToString();
            VersalTextBox.Enabled = false;

        }
    }
}