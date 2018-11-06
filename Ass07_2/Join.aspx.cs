using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ass07_2
{
    public partial class Join : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void loadGridView(String sqlStatement)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\SocialNetworks.mdf;Integrated Security=True");

            SqlCommand cmd = new SqlCommand(sqlStatement, con);

            con.Open();

            SqlDataReader wan = cmd.ExecuteReader();

            JoinGridView.DataSource = wan;

            JoinGridView.DataBind();

            con.Close();
        }

        protected void JoinButton_Click(object sender, EventArgs e)
        {
            String sqlStatement = "select CEOs.CompanyName AS 'Company Name', CEOName AS CEO, HttpAddress AS 'URL', NumberOfUser AS 'Number Of User', ";
            sqlStatement += " CompanyValue AS 'Company Value (million)', CONVERT(VARCHAR(10), LaunchedDate, 103) AS 'Launched Date', ";
            sqlStatement += " Age AS 'CEO Age', Asset AS 'CEO Asset', CONVERT(VARCHAR(10), DoB, 103) AS 'CEO Date of birth' ";

            sqlStatement += " from CEOs join Companies ";
            sqlStatement += " on CEOs.CompanyName = Companies.CompanyName";

            loadGridView(sqlStatement);
        }
    }
}