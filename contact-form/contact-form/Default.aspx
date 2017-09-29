<%@ Page Language="C#" Inherits="ContactForm.Default" %>
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

        span {
            display: block;
            margin: 10px 0;
        }

	</style>
</head>
<body>
	<div class="container">
    	<form id="form" runat="server">
				
        <label id="Name">
			<span class="label-span">Your name</span>
  
		    <asp:RequiredFieldValidator runat="server" ControlToValidate="Name"> 
				Name is required *
            </asp:RequiredFieldValidator>
	    
    		<asp:TextBox name="Name" placeholder="Insert your name" id="Name" runat="server" ValidateRequestMode="Enabled"></asp:TextBox>
    	</label>
						
        <label id="Email">
			<span class="label-span">Your email</span>

           <asp:RequiredFieldValidator runat="server" ControlToValidate="Email"> 
                Email is required *
            </asp:RequiredFieldValidator>
          
            <asp:TextBox name="Email" placeholder="Insert your email" id="Email" runat="server" ValidateRequestMode="Enabled"></asp:TextBox>
       </label>
       
        <label id="Message">
			<span class="label-span">Your message</span>

		   <asp:RequiredFieldValidator runat="server" ControlToValidate="Message"> 
                Message is required *
            </asp:RequiredFieldValidator>
					
            <textarea name="Message" placeholder="Insert your message" id="Message" runat="server" ValidateRequestMode="Enabled"></textarea>
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
