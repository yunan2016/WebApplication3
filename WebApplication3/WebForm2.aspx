<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication3.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
    function change(value)
    {
      
        if (value.innerHTML == "Detail") value.innerHTML = "Back";
        else value.innerHTML = "Detail";
    }
</script>
</head>
<body>


         <div>
            <button id="apply" class="active" onclick="change(this)">Detail</button>
        </div>
    <form id="form1" runat="server">
         <div height="240" width="320" controls>
            <video>
                <source src="@Url.Content("~/Uploads/Wildlife.wmv")" type='video/x-ms-wmv'  />
            </video>
        </div>
    </form>
</body>
</html>
