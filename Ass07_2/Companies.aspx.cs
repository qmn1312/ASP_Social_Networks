using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Globalization;

namespace Ass07_2
{
    public partial class Companies : System.Web.UI.Page
    {
        protected void loadGridView(String sqlStatement)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\SocialNetworks.mdf;Integrated Security=True");

            SqlCommand cmd = new SqlCommand(sqlStatement, con);

            con.Open();

            SqlDataReader wan = cmd.ExecuteReader();

            CompaniesView.DataSource = wan;

            CompaniesView.DataBind();

            con.Close();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            /*
            String sqlStatement = "select Id AS 'Company Order', CompanyName AS 'Company Name', HttpAddress AS 'URL', ";
            sqlStatement += "NumberOfUser AS 'Number Of User' , CompanyValue AS 'Company Value (million dollars)', ";
            sqlStatement += "CONVERT(VARCHAR(10), LaunchedDate, 103) AS 'Launched Date (DD/MM/YYYY)' from Companies ";
            sqlStatement += "order by Id";

            loadGridView(sqlStatement);
            */

            CompaniesView.DataSource = null;

            CompaniesView.DataBind();

        }

        protected void RangeButton_Click(object sender, EventArgs e)
        {
            String selectedAttr = RangeList.SelectedValue;
            if (!selectedAttr.Equals("Please Select An Attribute"))
            {
                if (!FromValue.Text.Equals("") && !ToValue.Text.Equals(""))
                {
                    double from, to;
                    bool isFromNumeric = double.TryParse(FromValue.Text, out from);
                    bool isToNumeric = double.TryParse(ToValue.Text, out to);

                    if (isFromNumeric && isToNumeric)
                    {
                        if (selectedAttr.Equals("Company Order"))
                        {
                            selectedAttr = "Id";
                        }

                        if (selectedAttr.Equals("Number of users"))
                        {
                            selectedAttr = "NumberOfUser";
                        }

                        if (selectedAttr.Equals("Company Value"))
                        {
                            selectedAttr = "CompanyValue";
                        }

                        String sqlStatement = "select Id AS 'Company Order', CompanyName AS 'Company Name', HttpAddress AS 'URL', ";
                        sqlStatement += "NumberOfUser AS 'Number Of User' , CompanyValue AS 'Company Value (million dollars)', ";
                        sqlStatement += "CONVERT(VARCHAR(10), LaunchedDate, 103) AS 'Launched Date (DD/MM/YYYY)' from Companies ";
                        sqlStatement += "where " + selectedAttr + " between " + from + " and " + to + " order by " + selectedAttr;

                        loadGridView(sqlStatement);
                    }
                }
            }
        }

        protected void KeywordButton_Click(object sender, EventArgs e)
        {
            String[] keywords = Keyword.Text.Split(' ');

            int numOfKeywords = 0;

            String sqlStatement = "select Id AS 'Company Order', CompanyName AS 'Company Name', HttpAddress AS 'URL', ";
            sqlStatement += "NumberOfUser AS 'Number Of User' , CompanyValue AS 'Company Value (million dollars)', ";
            sqlStatement += "CONVERT(VARCHAR(10), LaunchedDate, 103) AS 'Launched Date (DD/MM/YYYY)' from Companies ";

            String query = "";

            foreach (String keyword in keywords)
            {
                if (!keyword.Equals(""))
                {
                    numOfKeywords++;

                    String smallquery = sqlStatement + " where CompanyName like '%" + keyword + "%' ";
                    smallquery += " OR HttpAddress like '%" + keyword + "%'";

                    if (numOfKeywords > 1)
                        query += " UNION ";

                    query += smallquery;
                }
            }

            if (numOfKeywords != 0)
            {
                loadGridView(query);
            }

          
        }

       

        protected void DateButton_Click(object sender, EventArgs e)
        {
            String from = FromDate.Text;
            String to = ToDate.Text;
      
            DateTime fromDate;
            bool fromIsDate = DateTime.TryParseExact(from, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.NoCurrentDateDefault, out fromDate);
            DateTime toDate;
            bool toIsDate = DateTime.TryParseExact(to, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.NoCurrentDateDefault, out toDate);


            if (fromIsDate && toIsDate)
            {
                String fromStr = fromDate.ToString("yyyy-MM-dd");
                String toStr = toDate.ToString("yyyy-MM-dd");

                String sqlStatement = "select Id AS 'Company Order', CompanyName AS 'Company Name', HttpAddress AS 'URL', ";
                sqlStatement += "NumberOfUser AS 'Number Of User' , CompanyValue AS 'Company Value (million dollars)', ";
                sqlStatement += "CONVERT(VARCHAR(10), LaunchedDate, 103) AS 'Launched Date (DD/MM/YYYY)' from Companies ";

                sqlStatement += "where LaunchedDate between '" + fromStr + "' " + " and '" + toStr + "' order by LaunchedDate";

                loadGridView(sqlStatement);
            }
            
        }

        protected void TopKButton_Click(object sender, EventArgs e)
        {
            String selectedAttr = TopKList.SelectedValue;
            if (!selectedAttr.Equals("Please Select An Attribute"))
            {
                if (!numberK.Text.Equals(""))
                {
                    int k = -1;
                    bool isKNumeric = int.TryParse(numberK.Text, out k);

                    if (isKNumeric && k > 0)
                    {
                        if (selectedAttr.Equals("Company Order"))
                        {
                            selectedAttr = "Id";
                        }

                        if (selectedAttr.Equals("Number of users"))
                        {
                            selectedAttr = "NumberOfUser";
                        }

                        if (selectedAttr.Equals("Company Value"))
                        {
                            selectedAttr = "CompanyValue";
                        }

                        String sqlStatement = "select TOP "+ k +" Id AS 'Company Order', CompanyName AS 'Company Name', HttpAddress AS 'URL', ";
                        sqlStatement += "NumberOfUser AS 'Number Of User' , CompanyValue AS 'Company Value (million dollars)', ";
                        sqlStatement += "CONVERT(VARCHAR(10), LaunchedDate, 103) AS 'Launched Date (DD/MM/YYYY)' from Companies ";

                        String selectedOrder = TopKOrder.SelectedValue;
                        sqlStatement += "order by " + selectedAttr + " " + selectedOrder;

                        loadGridView(sqlStatement);
                    }
                }
            }
        }

        protected void WholeDatabaseButton_Click(object sender, EventArgs e)
        {
            String sqlStatement = "select Id AS 'Company Order', CompanyName AS 'Company Name', HttpAddress AS 'URL', ";
            sqlStatement += "NumberOfUser AS 'Number Of User' , CompanyValue AS 'Company Value (million dollars)', ";
            sqlStatement += "CONVERT(VARCHAR(10), LaunchedDate, 103) AS 'Launched Date (DD/MM/YYYY)' from Companies ";
            sqlStatement += "order by Id";

            loadGridView(sqlStatement);
        }
    }
}