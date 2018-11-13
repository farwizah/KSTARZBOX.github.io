using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PayPal.Api;

namespace kstarbox
{
    public partial class purchased : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void cfmPurchase_Click(object sender, EventArgs e)
        {
            var config = ConfigManager.Instance.GetProperties();
            var accessToken = new OAuthTokenCredential("AZ7aMW32u6mj1chETLHm0U4JOMSjiaVjBUjVioHzcEDcyyU029CH5aTNyoQV0asR_Bgu9-_8W99tHzDi", "ELsoyteIU8HKLQoN4aZg3Px_aH6ln_4v7aS4nEIA0xWnqYph3nd-CwN_5Ly9VCJNag2j6xoAA6ZS0ri0").GetAccessToken();

            //Get APIcontext 
            var apiContext = new APIContext(accessToken);
            apiContext.Config = config;

            //retrieve payment ID

            var paymentId = Session["paymentId"].ToString();

            if (!String.IsNullOrEmpty(paymentId))
            {
                //create payment object using payment ID from the session
                var payment = new Payment()
                {
                    id = paymentId
                };


                //retrieve payer ID from query string
                var payerId = Request.QueryString["PayerID"].ToString();
                var paymentExecute = new PaymentExecution() { payer_id = payerId };

                //payment execution
                var executedPayment = payment.Execute(apiContext, paymentExecute);

                //notify buyer
                purchaseLit.Text = "Purchase completed";
                cfmPurchase.Visible = false;
                sure.Visible = false;

            }
        }
    }
}
