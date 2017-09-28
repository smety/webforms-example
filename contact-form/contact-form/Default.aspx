<%@ Page Language="C#" Inherits="contactform.Default" %>
<!DOCTYPE html>
<html>
<head runat="server">
	<title>Example contact form</title>
   
	<style>
        body {
            padding: 0;
            margin: 0;
            font-family: Arial, sans-serif;
            font-size: 15px;
        }

        .container {
            margin: 0 auto;
            padding: 40px 0;
            width: 320px;
        }

        input, textarea {
            display: block;
            width: 100%;
            border: 1px solid #DDD;
            padding: 10px;
        }

        textarea {
            height: 250px; 
        }

        input[type="submit"]  {
            background: #999;
            color: #fff;
            margin: 10px 0 0 0;
        }

        label span {
            display: block;
            margin: 10px 0;
        }

	</style>
</head>
<body>
	<div class="container">
    	<form id="form" runat="server">

        <label id="Name">
			<span>Your name</span>
    		<asp:TextBox name="Name" placeholder="Insert your name" id="mame" runat="server" ValidateRequestMode="Enabled"></asp:TextBox>
    	</label>
						
        <label id="Email">
			<span>Your email</span>
            <asp:TextBox name="Email" placeholder="Insert your email" id="email" runat="server" ValidateRequestMode="Enabled"></asp:TextBox>
       </label>
       
        <label id="Message">
			<span>Your message</span>
            <textarea name="Message" placeholder="Insert your message" id="message" runat="server" ValidateRequestMode="Enabled"></textarea>
        </label>

		<label id="TypeMessage">
			<span>Priority message</span>
			<select name="Priority" runat="server">
				<option value="Low">Low</option>
                <option value="Standard">Stanard</option>
				<option value="Hight">High</option>
			</select>
		</label>

    	<asp:Button id="Button" runat="server" Text="Send email" OnClick="ActionSendEmail" />
    	</form>
	 </div>
</body>
</html>
