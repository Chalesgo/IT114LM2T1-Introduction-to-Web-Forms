using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Module1Exercise1
{
    public partial class Exercise3 : System.Web.UI.Page
    {
        protected void DisplayGrade(object sender, EventArgs e)
        {
            double grade = int.Parse(percentageGrade.Text);
            if (grade <= 60)
            {
                grade = 5.00;
            }
            else if (grade >= 61 && grade <= 70)
            {
                grade = 3.00;
            }
            finalGrade.Text = grade.ToString();
        }
    }
}
