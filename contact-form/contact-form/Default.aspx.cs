﻿using System;
using System.Web;
using System.Web.UI;

namespace contactform
{

    public partial class Default : System.Web.UI.Page
    {
		public string Name { get; set; }
		public string Email { get; set; }
		public string Message { get; set; }
        public string Priority { get; set; }

        public void ActionSendEmail(object sender, EventArgs args)
        {
			Button.Text = "Message send";

            // TODO send message at email
        }
    }
}
