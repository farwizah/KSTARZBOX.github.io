using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace kstarbox
{
    public partial class contact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void sendButton_Click(object sender, EventArgs e)
        {
          //if all of the fields are empty
           if (string.IsNullOrWhiteSpace(nametxt.Text) &&
                string.IsNullOrWhiteSpace(emailtxt.Text) &&
                string.IsNullOrWhiteSpace(subjecttxt.Text) &&
                string.IsNullOrWhiteSpace(messagetxt.Text))
            {
                nametxtError.Text = "Fill in your name";
                emailtxtError.Text = "Enter your email here";
                subjttxtError.Text = "Subject for your message";
                msgtxtError.Text = "Your Message";
            }

        /*   //name field is empty
            else if (string.IsNullOrWhiteSpace(nametxt.Text) &&
                (!string.IsNullOrWhiteSpace(emailtxt.Text)) &&
                (!string.IsNullOrWhiteSpace(subjecttxt.Text)) &&
                (!string.IsNullOrWhiteSpace(messagetxt.Text)))
            {
                nametxtError.Text = "Please fill in name";
                emailtxtError.Text = "";
                subjttxtError.Text = "";
                msgtxtError.Text = "";
            }

            //email field is empty
            else if ((!string.IsNullOrWhiteSpace(nametxt.Text)) &&
                 string.IsNullOrWhiteSpace(emailtxt.Text) &&
                 (!string.IsNullOrWhiteSpace(subjecttxt.Text)) &&
                 (!string.IsNullOrWhiteSpace(messagetxt.Text)))
            {
                nametxtError.Text = "";
                emailtxtError.Text = "Enter your email here.";
                subjttxtError.Text = "";
                msgtxtError.Text = "";
            }

            //subject field is empty
            else if ((!string.IsNullOrWhiteSpace(nametxt.Text)) &&
                (!string.IsNullOrWhiteSpace(emailtxt.Text) &&
                string.IsNullOrWhiteSpace(subjecttxt.Text)) &&
                (!string.IsNullOrWhiteSpace(messagetxt.Text)))
            {
                nametxtError.Text = "";
                emailtxtError.Text = "";
                subjttxtError.Text = "Give a subject for your message";
                msgtxtError.Text = "";
            }

            //message field is empty
            else if ((!string.IsNullOrWhiteSpace(nametxt.Text)) &&
                  (!string.IsNullOrWhiteSpace(emailtxt.Text) &&
                  (!string.IsNullOrWhiteSpace(subjecttxt.Text))) &&
                  string.IsNullOrWhiteSpace(messagetxt.Text))
            {
                nametxtError.Text = "";
                emailtxtError.Text = "";
                subjttxtError.Text = "";
                msgtxtError.Text = "Enter your message here.";
            }

            //if name and email fields are empty
            else if (string.IsNullOrWhiteSpace(nametxt.Text) &&
                string.IsNullOrWhiteSpace(emailtxt.Text) &&
                (!string.IsNullOrWhiteSpace(subjecttxt.Text)) &&
                (!string.IsNullOrWhiteSpace(messagetxt.Text)))
            {
                nametxtError.Text = "Fill in your name";
                emailtxtError.Text = "Enter your email here";
                subjttxtError.Text = "";
                msgtxtError.Text = "";
            }

            //subject and message are empty
            else if ((!string.IsNullOrWhiteSpace(nametxt.Text)) &&
                (!string.IsNullOrWhiteSpace(emailtxt.Text)) &&
                string.IsNullOrWhiteSpace(subjecttxt.Text) &&
                string.IsNullOrWhiteSpace(messagetxt.Text))
            {
                nametxtError.Text = "";
                emailtxtError.Text = "";
                subjttxtError.Text = "Give your message a subject";
                msgtxtError.Text = "Type what you want to tell us here.";
            }

            //name and subject fields are empty
            else if (string.IsNullOrWhiteSpace(nametxt.Text) &&
                (!string.IsNullOrWhiteSpace(emailtxt.Text)) &&
                string.IsNullOrWhiteSpace(subjecttxt.Text) &&
                (!string.IsNullOrWhiteSpace(messagetxt.Text)))
            {
                nametxtError.Text = "Fill in your name";
                emailtxtError.Text = "";
                subjttxtError.Text = "Subject for your message";
                msgtxtError.Text = "";
            }

            //if name and message fields are empty
            else if (string.IsNullOrWhiteSpace(nametxt.Text) &&
                (!string.IsNullOrWhiteSpace(emailtxt.Text)) &&
                (!string.IsNullOrWhiteSpace(subjecttxt.Text)) &&
                string.IsNullOrWhiteSpace(messagetxt.Text))
            {
                nametxtError.Text = "Fill in your name";
                emailtxtError.Text = "";
                subjttxtError.Text = "";
                msgtxtError.Text = "Your Message";
            }

            //email and message are empty
            else if ((!string.IsNullOrWhiteSpace(nametxt.Text)) &&
                string.IsNullOrWhiteSpace(emailtxt.Text) &&
                (!string.IsNullOrWhiteSpace(subjecttxt.Text)) &&
                string.IsNullOrWhiteSpace(messagetxt.Text))
            {
                nametxtError.Text = "";
                emailtxtError.Text = "Please enter your email here";
                subjttxtError.Text = "";
                msgtxtError.Text = "Type what you want to tell us here.";
            }

            //email and subject are empty
            else if ((!string.IsNullOrWhiteSpace(nametxt.Text)) &&
                string.IsNullOrWhiteSpace(emailtxt.Text) &&
                string.IsNullOrWhiteSpace(subjecttxt.Text) &&
                (!string.IsNullOrWhiteSpace(messagetxt.Text)))
            {
                nametxtError.Text = "";
                emailtxtError.Text = "Please enter your email here";
                subjttxtError.Text = "Give your message a subject";
                msgtxtError.Text = "";
            }

            //name, email and subject fields are empty
            else if (string.IsNullOrWhiteSpace(nametxt.Text) &&
                string.IsNullOrWhiteSpace(emailtxt.Text) &&
                string.IsNullOrWhiteSpace(subjecttxt.Text) &&
                (!string.IsNullOrWhiteSpace(messagetxt.Text)))
            {
                nametxtError.Text = "Fill in your name";
                emailtxtError.Text = "Enter your email here";
                subjttxtError.Text = "Subject for your message";
                msgtxtError.Text = "";
            }

            //name, email and message fields are empty
            else if (string.IsNullOrWhiteSpace(nametxt.Text) &&
                string.IsNullOrWhiteSpace(emailtxt.Text) &&
                (!string.IsNullOrWhiteSpace(subjecttxt.Text)) &&
                string.IsNullOrWhiteSpace(messagetxt.Text))
            {
                nametxtError.Text = "Fill in your name";
                emailtxtError.Text = "Enter your email here";
                subjttxtError.Text = "";
                msgtxtError.Text = "Your Message";
            }

            //name, subject and message are empty
            else if (string.IsNullOrWhiteSpace(nametxt.Text) &&
                (!string.IsNullOrWhiteSpace(emailtxt.Text)) &&
                string.IsNullOrWhiteSpace(subjecttxt.Text) &&
                string.IsNullOrWhiteSpace(messagetxt.Text))
            {
                nametxtError.Text = "Please fill in name";
                emailtxtError.Text = "";
                subjttxtError.Text = "Give your message a subject";
                msgtxtError.Text = "Type what you want to tell us here.";
            }

            //email, subject and message are empty
            else if ((!string.IsNullOrWhiteSpace(nametxt.Text)) &&
                string.IsNullOrWhiteSpace(emailtxt.Text) &&
                string.IsNullOrWhiteSpace(subjecttxt.Text) &&
                (string.IsNullOrWhiteSpace(messagetxt.Text)))
            {
                nametxtError.Text = "";
                emailtxtError.Text = "Please enter your email here";
                subjttxtError.Text = "Give your message a subject";
                msgtxtError.Text = "Type what you want to tell us here.";
            }

        /*   //test email
            else if ((!string.IsNullOrWhiteSpace(nametxt.Text)) &&
                 (!string.IsNullOrWhiteSpace(subjecttxt.Text)) &&
                 (!string.IsNullOrWhiteSpace(messagetxt.Text)) &&
                 (!string.IsNullOrWhiteSpace(emailtxt.Text)) &&
                 (!Regex.IsMatch(emailtxt.Text,
                @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250))))
            {
                nametxtError.Text = "";
                emailtxtError.Text = "Invalid email format";
                subjttxtError.Text = "";
                msgtxtError.Text = "";
            } 

            //all fields are filled in correctly
            else
            {
                nametxtError.Text = "";
                emailtxtError.Text = "";
                subjttxtError.Text = "";
                msgtxtError.Text = ""; */

                else { 
                SmtpClient client = new SmtpClient();
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.EnableSsl = true;
                client.Host = "smtp.gmail.com";
                client.Port = 587;

                // Smtp authentication
                System.Net.NetworkCredential userpass = new System.Net.NetworkCredential("kstrazbox.bn@gmail.com", "kst@rbox");
                client.UseDefaultCredentials = false;
                client.Credentials = userpass;

                MailMessage msg = new MailMessage();
                msg.From = new MailAddress(emailtxt.Text);
                msg.To.Add(new MailAddress("kstrazbox.bn@gmail.com"));

                msg.Subject = subjecttxt.Text;
                msg.IsBodyHtml = true;
                msg.Body = string.Format("From: " + nametxt.Text + ",   Email: " + emailtxt.Text + ",   Message: " + messagetxt.Text);

                try
                {
                    client.Send(msg);
                    literalError.Text = "Your message sent!";
                }
                catch (Exception ex)
                {
                    literalError.Text = "Your message unsuccessful send." + ex.Message;
                }

                nametxt.Text = "";
                emailtxt.Text = "";
                subjecttxt.Text = "";
                messagetxt.Text = "";


            }

        }
    }
}


