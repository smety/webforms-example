﻿using System;
using System.Web;
using System.Web.UI;


namespace contactform
{
    public partial class Contact : Page
    {

		const string SUBJECT_MESSAGE = "Message from contact from";

		public string Name { get; set; }
		public string Email { get; set; }
		public string Message { get; set; }
		public string Priority { get; set; }

		public void ActionSendEmail(object sender, EventArgs args)
		{
			if (this.Page.IsPostBack)
			{
				Button.Text = "Message send";
			}

			Console.WriteLine(this.Name);
			Console.WriteLine(this.Name);
			Console.WriteLine(this.Name);
		}
    }
}
