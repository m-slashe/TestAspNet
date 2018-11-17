using System;
using System.Web;
using System.Web.UI;

namespace Teste
{

    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            button1.Text = "Funcionou!!!";
        }

        public void button1Clicked(object sender, EventArgs args)
        {
            button1.Text = "You clicked me";
        }
    }
}
