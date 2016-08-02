<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="VBDemo.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
       <asp:TextBox ID="Textboxval" runat="server" Enabled="false" VISIBLE="FALSE"/>
    <asp:TextBox ID="textbox1" runat="server" /> <asp:TextBox ID="textbox2" runat="server" /><asp:Button ID="button1" runat="server" autopostback="true" Text="View Log" OnClick="button1_Click" /> <asp:Button ID="button2" runat="server" autopostback="true" Text="Add a Log" onclick="button3_Click" /><asp:Label ID="errormsg" runat="server" Text="Please Enter Authorisation Code" visible="false"/>
         <asp:Button ID="button3" Text="123" runat="server" autopostback="true" Visible="false" onclick="button3_Click"/>
        <asp:GridView ID="gridview1" runat="server"  autogeneratecolumns="false" CssClass="auto-style1" Width="1025px" >
           <Columns>
               <asp:BoundField HeaderText="Date" Datafield="TimeDate"  />
               <asp:BoundField HeaderText="Logged By" DataField="Enteredby" />
                <asp:BoundField HeaderText="Contacted" DataField="Contacted" />
                <asp:BoundField HeaderText="Action" DataField="Action" />
                <asp:BoundField HeaderText="Outcome" DataField="Outcome" />
                <asp:BoundField HeaderText="By Whom" DataField="Bywhom" />
                <asp:BoundField HeaderText="By When" DataField="DueDate" />

           </Columns>
        </asp:GridView>
       
        <table class="Grid" >
            <tr>
                 <td>    <asp:Label ID="label3" runat="server" Text="Date" Visible="false" Font-Bold="true" ></asp:Label></td><td> <asp:Label ID="label4" runat="server" Text="Logged By" Visible="false"  Font-Bold="true"/></td><td> <asp:Label ID="label5" runat="server" Text="Contacted" Visible="false"  Font-Bold="true"/></td><td><asp:Label ID="Label6" runat="server" Text="Action" Visible="false"  Font-Bold="true"/></td><td><asp:Label ID="Label10" runat="server" Text="Outcome" Visible="false"  Font-Bold= "true"/></td><td><asp:Label ID="Label11" runat="server" Text="By Whom" Visible="false"  Font-Bold="true" /></td><td><asp:Label ID="Label12" runat="server" Text="By When" Visible="false"  Font-Bold="true"/></td>
            </tr>
            <tr>
           <td>    <asp:Label ID="label1" runat="server" Text="" Visible="false"></asp:Label></td><td> <asp:Label ID="label2" runat="server" Text="" Visible="false" /></td><td> <asp:TextBox ID="TextBox3" runat="server" Text="" Visible="false"/></td><td><asp:TextBox ID="TextBox4" runat="server" Text="" Visible="false"/></td><td><asp:TextBox ID="TextBox5" runat="server" Text="" Visible="false"/></td><td><asp:TextBox ID="TextBox6" runat="server" Text="" Visible="false" /></td><td><asp:TextBox ID="TextBox7" runat="server" Text="" Visible="false"/></td><td></td>
            </tr>
        </table>
      
    </div>


         
    </form>
    <style >
        .Grid {background-color: #fff; margin: 5px 0 10px 0; border: solid 1px #525252; border-collapse:collapse; font-family:Calibri; color: #474747; width: 201px;} 
        .Grid td {
      padding: 2px;
      border: solid 1px #c1c1c1;}

        .auto-style1 {
            background-color: #fff;
            margin: 5px 0 10px 0;
            border: solid 1px #525252;
            border-collapse: collapse;
            font-family: Calibri;
            color: #474747;
        }

    </style>
</body>
</html>
