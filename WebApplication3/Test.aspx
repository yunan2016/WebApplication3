<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="test.aspx.cs" Inherits="WebApplication3.test" EnableEventValidation="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
<link rel="stylesheet" href="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />
<script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>
<script src="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>


<script type="text/javascript">
    $(function () {
        $("input:checkbox").change(function () {
            var tuisre = $(this).is(":checked");
            if (tuisre) {
                $(this).parent().prev().eq(0).text("close");
                alert("123");
            } else {
                $(this).parent().prev().eq(0).text("open");
            }
        })
    })

</script>
</head>
<body>
    <form id="form1" runat="server">
<div>
       <table id="table1">
            <tr>
                <th>Title</th>
                <th>Priority</th>
                <th>Due Date</th>
                <th>status</th>
                <th>Complete</th>
           </tr>
            <tr>
                <td>DATE</td> 
                <td>DATE</td>
                <td>DATE</td>
                <td>Open</td>
                <td><asp:CheckBox ID="CheckBox2" runat="server" /></td>
           </tr>
            <tr>
                <td>DATE</td> 
                <td>DATE</td>
                <td>DATE</td>
                <td>Open</td>
                <td><asp:CheckBox ID="CheckBox3" runat="server" /></td>
           </tr>
       </table>
    </div>

    </form>
</body>
</html>

