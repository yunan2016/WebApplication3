<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
<script src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js" type="text/javascript"></script>
<script type = "text/javascript">

    function test()
    {
        var str ="@#letterDate#@, @#name#@";
        var b= str.replace("@#letterDate#@", "aaa"); 
    }
function GetUserName() {
    $.ajax({
        type: "POST",
        url: "WebForm1.aspx/GetUsername",
        data: '{name: "' + $("#<%=txtUserName.ClientID%>")[0].value + '" }',
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: OnSuccess,
        failure: function(response) {
            alert(response.d);
        }
    });
}

    function OnSuccess(response) {
        alert(response.d);
    };


</script>
</head>
<body>
    <form id="form1" runat="server">
        <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
     <input id="btnGetTime" type="button" value="Get user name"
    onclick = "test()" />

        #@CreditCardNumber@#
    </form>
</body>
</html>
