<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Views.aspx.cs" Inherits="UniversityWebApp.UI.Views" %>

<!DOCTYPE html>

<html>
<head runat="server">
   <meta charset="UTF-8"/>
    <title>Views</title>
    <link href="../Content/bootstrap.css" rel="stylesheet" />
    <link href="../Content/bootstrap-theme.css" rel="stylesheet" />
    <link href="../Content/Style.css" rel="stylesheet" />
</head>
<body>
    <div class="container topmargin">
        <div class="row">
            <div class="col-xs-3">
                <ul>
                    <li><a href="Home.aspx">Home</a></li>
                    <li><a href="DepertmentEntryUI.aspx">Depertment Entry</a></li>
                    <li><a href="StudentEntryUI.aspx">Student Entry</a></li>
                    <li><a href="Views.aspx">Views</a></li>
                </ul>
            </div>
            <div class="col-xs-9">
                <form class="form-horizontal" runat="server" role="form">
                    <asp:DropDownList ID="departmentDropDownList" runat="server" CssClass="form-control" OnSelectedIndexChanged="departmentDropDownList_SelectedIndexChanged" AutoPostBack="True"> </asp:DropDownList>
                    <asp:DropDownList ID="studentDropDownList" runat="server" CssClass="form-control" AutoPostBack="True" OnSelectedIndexChanged="studentDropDownList_SelectedIndexChanged"> </asp:DropDownList>

                    <br />
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>

                </form>
            </div>
          </div>
     </div>
        
    
    
    <script src="../Scripts/bootstrap.js"></script>
    <script src="../Scripts/jquery-1.9.0.js"></script>
</body>
</html>
