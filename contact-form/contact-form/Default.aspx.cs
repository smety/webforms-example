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

		public DateTime FirstLoadTimeVS
		{
			get { return (DateTime)this.ViewState["FirstLoadTimeVS"]; }
			set { this.ViewState["FirstLoadTimeVS"] = value; }
		}

        public void ActionSendEmail(object sender, EventArgs args)
        {
			// MailMessage message = new MailMessage(this.Name, this.Email, Default.SUBJECT_MESSAGE, this.Message);

            FirstLoadTimeVS = DateTime.Now;

			if (!this.Page.IsPostBack)
			{
				// Jedná se o první dotaz, ne o postback
                 

           //     writer.Write("<p>Toto je první dotaz.</p>");

                Button.Text = "Message send {this.FirstLoadTimeVS}";

			}

			//Button.Text = "Message send";
            Console.WriteLine("Test");
            Console.WriteLine(FirstLoadTimeVS);
		}
    }
}