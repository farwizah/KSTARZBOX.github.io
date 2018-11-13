using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace kstarbox
{
    public partial class product : System.Web.UI.Page
    {
        SqlConnection sqlconnection = new SqlConnection(@"Data Source=SQL2016.FSE.Network;Initial Catalog=db_1624956_kstardb;User ID=user_db_1624956_kstardb;Password=admin1234;MultipleActiveResultSets=True;Application Name=EntityFramework");

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
            sqlconnection.Open();
            SqlCommand sqlcmd = sqlconnection.CreateCommand();
            sqlcmd.CommandType = System.Data.CommandType.Text;
            sqlcmd.CommandText = "select * from prod_table INNER JOIN image_table ON prod_table.prod_name = image_table.imgName";
            sqlcmd.ExecuteNonQuery();

            DataTable dbtable = new DataTable();
            SqlDataAdapter sqladapter = new SqlDataAdapter(sqlcmd);
            sqladapter.Fill(dbtable);
            prodrepeat.DataSource = dbtable;
            prodrepeat.DataBind();
            sqlconnection.Close();
            }
            catch
            {
                Literal1.Text = "connection error";
            }

        }

    }
}