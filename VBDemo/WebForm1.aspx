<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="VBDemo.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title></title>
    <script src="Scripts/jquery-1.10.2.min.js"></script>
    <script type = "text/javascript">
        function Confirm() {         
            if (confirm("Your confirm value")) {
                $("#HiddenField1").val("YES");
            } else {
                $("#HiddenField1").val("NO");
            }
          
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
      <asp:Button ID="btnConfirm" runat="server" OnClick = "OnConfirm" Text = "Raise Confirm" OnClientClick = "Confirm()"/>
        <asp:HiddenField ID="HiddenField1" runat="server" />
    </form>
</body>
</html>
