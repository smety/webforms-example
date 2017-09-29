using System;
using System.Web.UI;
using System.Net.Mail;


namespace ContactForm
{
   
    public partial class Default : Page
    {
        const string SUBJECT_MESSAGE = "Message from contact from";
		public string Name { get; set; }
		public string Email { get; set; }
		public string Message { get; set; }
        public string Priority { get; set; }


        public void ActionSendEmail(object sender, EventArgs args)
        {	
            MailMessage message = new MailMessage(this.Name, this.Email, Default.SUBJECT_MESSAGE, this.Message);
			Button.Text = "Message send";
     
		}
    }
}
