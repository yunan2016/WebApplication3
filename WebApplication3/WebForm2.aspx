<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication3.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:RadioButtonList runat="server" ID="loanTypeCheck" CssClass="pull-right" RepeatDirection="Horizontal">
                <asp:ListItem Value="Cash" Text="&nbsp;&nbsp;Cash&nbsp;&nbsp;" />
                <asp:ListItem Value="Non-Cash" Text="&nbsp;&nbsp;Non-Cash&nbsp;&nbsp;" />
                <asp:ListItem Value="Dharauti" Text="&nbsp;&nbsp;Dharauti&nbsp;&nbsp;" />

            </asp:RadioButtonList>

            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
