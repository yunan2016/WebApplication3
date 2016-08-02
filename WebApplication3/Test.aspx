<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="test.aspx.cs" Inherits="WebApplication3.test" EnableEventValidation="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="//ajax.googleapis.com/ajax/libs/jquery/1.11.1/jquery.min.js"></script>
    <script type="text/javascript" src="//cdnjs.cloudflare.com/ajax/libs/semantic-ui/0.16.1/javascript/semantic.min.js"></script>

    <script type="text/javascript">
     
    </script>
</head>
<body>
    <form id="form1" runat="server">
     

        <asp:GridView ID="GridView1" HeaderStyle-BackColor="#3AC0F2" HeaderStyle-ForeColor="White"
            RowStyle-BackColor="#A1DCF2" AlternatingRowStyle-BackColor="White" AlternatingRowStyle-ForeColor="#000"
            runat="server" AutoGenerateColumns="false">

            <Columns>

                <asp:BoundField DataField="Item" HeaderText="Item" />

                <asp:TemplateField HeaderText="Price">

                    <ItemTemplate>

                        <asp:TextBox ID="txtPrice" runat="server" Text='<%# Eval("Price") %>'></asp:TextBox><br />

                        <asp:RequiredFieldValidator ID="rfvPrice" ControlToValidate="txtPrice" runat="server"
                            ErrorMessage="Required" ForeColor="Red"></asp:RequiredFieldValidator>

                    </ItemTemplate>

                </asp:TemplateField>

                <asp:TemplateField HeaderText="Quantity">

                    <ItemTemplate>

                        <asp:TextBox ID="txtQuantity" runat="server" Text='<%# Eval("Quantity") %>'></asp:TextBox><br />

                        <asp:RequiredFieldValidator ID="rfvQuantity" ControlToValidate="txtQuantity" runat="server"
                            ErrorMessage="Required" ForeColor="Red"></asp:RequiredFieldValidator>

                    </ItemTemplate>

                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:DropDownList ID="ddl" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddl_Selected">
                            <asp:ListItem Text="1"> 1</asp:ListItem>
                            <asp:ListItem Text="2"> 2</asp:ListItem>
                            <asp:ListItem Text="3"> 3</asp:ListItem>
                            <asp:ListItem Text="4"> 4</asp:ListItem>
                            <asp:ListItem Text="--Select--" Selected="True">Selected</asp:ListItem>
                        </asp:DropDownList>

                    </ItemTemplate>

                </asp:TemplateField>
                <asp:TemplateField HeaderText="Sample">
                    <ItemTemplate>

                        <asp:ListBox ID="lst" runat="server" Rows="10"></asp:ListBox>
                    </ItemTemplate>
                </asp:TemplateField>

            </Columns>

        </asp:GridView>


    </form>
</body>
</html>

