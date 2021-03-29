using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2_2Practice {
    public partial class Default : System.Web.UI.Page {

        protected void Page_Load(object sender, EventArgs e) {
            Random n = new Random();

            int num = n.Next(1, 10000);
            bool a = false;

            if (num % 4 == 0)
            {
                a = true;

                if (num % 100 == 0)
                {
                    if (num % 400 == 0)
                    {
                        a = true;
                    }
                    else
                    {
                        a = false;
                    }
                }
            }
            if (a == true)
            {
                Response.Write("Y");
            }
            else
            {
                Response.Write("N");
            }
        }
    }
}
