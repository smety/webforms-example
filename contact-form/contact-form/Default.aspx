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

        <label id="name">
			<span>Your name</span>
    		<asp:TextBox name="name" placeholder="Insert your name" id="mame" ValidateRequestMode="Enabled" runat="server"></asp:TextBox>
    	</label>
						
        <label id="email">
			<span>Your email</span>
            <asp:TextBox name="email" placeholder="Insert your email" id="email" ValidateRequestMode="Enabled" runat="server"></asp:TextBox>
       </label>
       
        <label id="message">
			<span>Your message</span>
            <textarea name="email" placeholder="Insert your email" id="message" ValidateRequestMode="Enabled"></textarea>
        </label>

    	<asp:Button id="button1" runat="server" Text="Send email" OnClick="button1Clicked" />
        		
    	</form>
	 </div>
</body>
</html>
