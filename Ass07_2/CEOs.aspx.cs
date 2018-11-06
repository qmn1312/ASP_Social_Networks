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
    public partial class CEOs : System.Web.UI.Page
    {
        protected void loadGridView(String sqlStatement)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\SocialNetworks.mdf;Integrated Security=True");

            SqlCommand cmd = new SqlCommand(sqlStatement, con);

            con.Open();

            SqlDataReader wan = cmd.ExecuteReader();

            CEOsView.DataSource = wan;

            CEOsView.DataBind();

            con.Close();
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            /*
            String sqlStatement = "select Id AS 'Order', CEOName AS CEO, CompanyName AS 'Company Name', Age, Asset AS 'Asset (million dollars)', ";
            sqlStatement += " CONVERT(VARCHAR(10), DoB, 103) AS 'Date of birth (DD/MM/YYYY)' from CEOs ";

            loadGridView(sqlStatement);
            */

            CEOsView.DataSource = null;
            CEOsView.DataBind();
        }

        protected void CEORangeButton_Click(object sender, EventArgs e)
        {
            String selectedAttr = CEORangeList.SelectedValue;
            if (!selectedAttr.Equals("Please Select An Attribute"))
            {
                if (!CEOFromValue.Text.Equals("") && !CEOToValue.Text.Equals(""))
                {
                    double from, to;
                    bool isFromNumeric = double.TryParse(CEOFromValue.Text, out from);
                    bool isToNumeric = double.TryParse(CEOToValue.Text, out to);

                    if (isFromNumeric && isToNumeric)
                    {
                        if (selectedAttr.Equals("Order"))
                        {
                            selectedAttr = "Id";
                        }

                        String sqlStatement = "select Id AS 'Order', CEOName AS CEO, CompanyName AS 'Company Name', Age, Asset AS 'Asset (million dollars)', ";
                        sqlStatement += " CONVERT(VARCHAR(10), DoB, 103) AS 'Date of birth (DD/MM/YYYY)' from CEOs ";
                        sqlStatement += "where " + selectedAttr + " between " + from + " and " + to + " order by " + selectedAttr;

                        loadGridView(sqlStatement);
                    }
                }
            }
        }

        protected void CEOKeywordButton_Click(object sender, EventArgs e)
        {
            String[] keywords = CEOKeyword.Text.Split(' ');

            int numOfKeywords = 0;

            String sqlStatement = "select Id AS 'Order', CEOName AS CEO, CompanyName AS 'Company Name', Age, Asset AS 'Asset (million dollars)', ";
            sqlStatement += " CONVERT(VARCHAR(10), DoB, 103) AS 'Date of birth (DD/MM/YYYY)' from CEOs ";

            String query = "";

            foreach (String keyword in keywords)
            {
                if (!keyword.Equals(""))
                {
                    numOfKeywords++;

                    String smallquery = sqlStatement + " where CEOName like '%" + keyword + "%' ";
                    smallquery += " OR CompanyName like '%" + keyword + "%'";

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

        protected void CEODateButton_Click(object sender, EventArgs e)
        {
            String from = CEOFromDate.Text;
            String to = CEOToDate.Text;

            DateTime fromDate;
            bool fromIsDate = DateTime.TryParseExact(from, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.NoCurrentDateDefault, out fromDate);
            DateTime toDate;
            bool toIsDate = DateTime.TryParseExact(to, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.NoCurrentDateDefault, out toDate);


            if (fromIsDate && toIsDate)
            {
                String fromStr = fromDate.ToString("yyyy-MM-dd");
                String toStr = toDate.ToString("yyyy-MM-dd");

                String sqlStatement = "select Id AS 'Order', CEOName AS CEO, CompanyName AS 'Company Name', Age, Asset AS 'Asset (million dollars)', ";
                sqlStatement += " CONVERT(VARCHAR(10), DoB, 103) AS 'Date of birth (DD/MM/YYYY)' from CEOs ";

                sqlStatement += "where DoB between '" + fromStr + "' " + " and '" + toStr + "' order by DoB";

                loadGridView(sqlStatement);
            }
        }

        protected void CEOTopKButton_Click(object sender, EventArgs e)
        {
            String selectedAttr = CEOTopKList.SelectedValue;
            if (!selectedAttr.Equals("Please Select An Attribute"))
            {
                if (!CEOnumberK.Text.Equals(""))
                {
                    int k = -1;
                    bool isKNumeric = int.TryParse(CEOnumberK.Text, out k);

                    if (isKNumeric && k > 0)
                    {
                        if (selectedAttr.Equals("Order"))
                        {
                            selectedAttr = "Id";
                        }

                        String sqlStatement = "select TOP " + k + " Id AS 'Order', CEOName AS CEO, CompanyName AS 'Company Name', Age, Asset AS 'Asset (million dollars)', ";
                        sqlStatement += " CONVERT(VARCHAR(10), DoB, 103) AS 'Date of birth (DD/MM/YYYY)' from CEOs ";

                        String selectedOrder = CEOTopKOrder.SelectedValue;
                        sqlStatement += "order by " + selectedAttr + " " + selectedOrder;

                        loadGridView(sqlStatement);
                    }
                }
            }
        }

        protected void CEOWholeDatabaseButton_Click(object sender, EventArgs e)
        {
            String sqlStatement = "select Id AS 'Order', CEOName AS CEO, CompanyName AS 'Company Name', Age, Asset AS 'Asset (million dollars)', ";
            sqlStatement += " CONVERT(VARCHAR(10), DoB, 103) AS 'Date of birth (DD/MM/YYYY)' from CEOs ";

            loadGridView(sqlStatement);
        }
    }
}