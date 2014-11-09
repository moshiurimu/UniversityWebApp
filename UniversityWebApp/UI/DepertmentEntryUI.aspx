<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DepertmentEntryUI.aspx.cs" Inherits="UniversityWebApp.UI.DepertmentEntryUI" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <meta charset="UTF-8"/>
    <title>Depertment Entry</title>
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
            
                  <div class="form-group">
                    <label for="regNo">Reg No</label>
                    <input type="text" class="form-control" id="regNoTextBox" placeholder="Reg No">
                  </div>
                  <div class="form-group">
                    <label for="name">Name</label>
                  <input type="text" class="form-control" id="nameTextBox" placeholder="name">
                  </div>
                  <button type="submit" class="btn btn-default">Submit</button>

                </form>
            </div>
        </div>
    </div>
        
    
    
    <script src="../Scripts/bootstrap.js"></script>
    <script src="../Scripts/jquery-1.9.0.js"></script>
</body>
</html>
