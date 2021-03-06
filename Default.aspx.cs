﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace kstarbox.aspxWebpages
{

    public partial class index : System.Web.UI.Page

    {
        //SqlConnection sqlconnection = new SqlConnection(@"Data Source=SQL2016.FSE.Network;Initial Catalog=db_1624968_co5027_asg;User ID=user_db_1624968_co5027_asg;Password=Co5027-asg;MultipleActiveResultSets=True;Application Name=EntityFramework");
        SqlConnection sqlconnection = new SqlConnection(@"Data Source=SQL2016.FSE.Network;Initial Catalog=db_1624956_kstardb;User ID=user_db_1624956_kstardb;Password=admin1234;MultipleActiveResultSets=True;Application Name=EntityFramework");
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                sqlconnection.Open();
                //sql query to get data for items that are on sale
                SqlCommand sale = sqlconnection.CreateCommand();
                sale.CommandType = System.Data.CommandType.Text;
                sale.CommandText = "select * from prod_table INNER JOIN image_table ON prod_table.prod_name = image_table.imgName where onFeatured = 'yes' AND prod_quantity > 0 ";
                sale.ExecuteNonQuery();

                //sql query to get data for new items
                SqlCommand newprod = sqlconnection.CreateCommand();
                newprod.CommandType = System.Data.CommandType.Text;
                newprod.CommandText = "SELECT TOP 5 * FROM prod_table INNER JOIN image_table ON prod_table.prod_name = image_table.imgName order by id DESC";
                newprod.ExecuteNonQuery();

                //to display items that are on sale
                DataTable dtsale = new DataTable();
                SqlDataAdapter dasale = new SqlDataAdapter(sale);
                dasale.Fill(dtsale);
                prodrepeat.DataSource = dtsale;
                prodrepeat.DataBind();

                //to display items that are new
                DataTable dtnew = new DataTable();
                SqlDataAdapter danew = new SqlDataAdapter(newprod);
                danew.Fill(dtnew);
                Repeater1.DataSource = dtnew;
                Repeater1.DataBind();
                sqlconnection.Close();
            }

            catch
            {
                Literal1.Text = "  Connection error, please refresh page";
                Literal2.Text = "  Connection error, please refresh page";
            }
           
        }
    }

    
}