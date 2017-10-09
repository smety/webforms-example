﻿<%@ Page Title="Contact" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="contactform.Contact"  ResponseEncoding="utf-8"  %>


<asp:Content ID="content" ContentPlaceHolderID="content" runat="server">
    <h2>This is contact page </h2>

	
        <form id="form" runat="server">                          <label id="Name">          <span class="label-span">Your name</span>               <asp:RequiredFieldValidator runat="server" ControlToValidate="Name">                Name is required *             </asp:RequiredFieldValidator>                    <asp:TextBox name="Name" placeholder="Insert your name" id="Name" runat="server" ValidateRequestMode="Enabled"></asp:TextBox>       </label>                                 <label id="Email">             <span class="label-span">Your email</span>             <asp:RequiredFieldValidator runat="server" ControlToValidate="Email">                  Email is required *             </asp:RequiredFieldValidator>                        <asp:TextBox name="Email" placeholder="Insert your email" id="Email" runat="server" ValidateRequestMode="Enabled"></asp:TextBox>        </label>                 <label id="Message">            <span class="label-span">Your message</span>           <asp:RequiredFieldValidator runat="server" ControlToValidate="Message">                  Message is required *             </asp:RequiredFieldValidator>                                  <textarea name="Message" placeholder="Insert your message" id="Message" runat="server" ValidateRequestMode="Enabled"></textarea>         </label>          <label id="TypeMessage">            <span>Priority message</span>                               <select name="Priority" runat="server">                 <option value="Low">Low</option>                 <option value="Standard">Stanard</option>              <option value="Hight">High</option>             </select>       </label>                        <asp:Button id="Button" runat="server" Text="Send email" OnClick="ActionSendEmail" />       </form> 
</asp:Content>