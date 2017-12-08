<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PapaBobMegaChallenge.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class ="container ">
            <div class="page-header">
                <h1>Papa Bob's Pizza </h1><br />
                <p class="lead">Pizza to Code By</p>
            </div>
            <div class="form-group">
                <label>Size: </label>
                <asp:DropDownList ID="listSizes" runat="server" CssClass="form-control" AutoPostBack="true">
                    <asp:ListItem Text="Choose a size ..." Selected="True"></asp:ListItem>
                    <asp:ListItem Text="Small (12 inch - $12)" Value="Small"></asp:ListItem>
                    <asp:ListItem Text="Medium (14 inch - $14)" Value="Medium"></asp:ListItem>
                    <asp:ListItem Text="Large (16 inch $16)" Value="Large"></asp:ListItem>
                </asp:DropDownList>
             </div>
            <div class="form-group">
                <label>Crust: </label>
                <asp:DropDownList ID="listCrusts" runat="server" CssClass="form-control" AutoPostBack="true">
                    <asp:ListItem Text="Choose a crust style ..." Selected="True"></asp:ListItem>
                    <asp:ListItem Text="Thin" Value="Thin"></asp:ListItem>
                    <asp:ListItem Text="Regular" Value="Regular"></asp:ListItem>
                    <asp:ListItem Text="Thick (+ $2)" Value="Thick"></asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="checkbox"><label><asp:CheckBox ID="chkSausage" runat="server"  AutoPostBack="true"/> Sausage </label></div>
                       
            <div class="checkbox"><label><asp:CheckBox ID="chkPepperoni" runat="server"  AutoPostBack="true"/> Pepperoni </label> </div>
            
            <div class="checkbox"><label><asp:CheckBox ID="chkOnions" runat="server"  AutoPostBack="true"/> Onions </label> </div>

            <div class="checkbox"><label><asp:CheckBox ID="chkGreenPeppers" runat="server" AutoPostBack="true" /> Green Peppers </label> </div>
           
            <h3>Deliver To:</h3>

            <div class="form-group">
                <label>Name: </label>
                <asp:TextBox ID="textName" runat="server" CssClass="form-control"></asp:TextBox><br />
            </div>
            <div class="form-group">
                <label>Address: </label>
                <asp:TextBox ID="textAddress" runat="server" CssClass="form-control"></asp:TextBox><br />
            </div>
            <div class="form-group">
                <label>Zip: </label>
                <asp:TextBox ID="textZip" runat="server" CssClass="form-control"></asp:TextBox><br />
            </div>
            <div class="form-group">
                <label>Phone: </label>
                <asp:TextBox ID="textPhone" runat="server" CssClass="form-control"></asp:TextBox><br />
            </div>

           
            <h3>Payment:</h3>
            <div class="radio"><label> <asp:RadioButton ID="radioCash" runat="server" Checked="True" GroupName="PaymentType" /> Cash</label></div>
            <div class="radio"><label> <asp:RadioButton ID="radioCredit" runat="server" GroupName="PaymentType" /> Credit</label></div>
            <p>&nbsp;</p>
            <p>&nbsp;</p>

            <asp:Button ID="btnOrder" runat="server" Text="ORDER" cssclass="btn btn-lg btn-primary" OnClick="btnOrder_Click"/><br />
            <h3>Total Cost: <asp:Label ID="lblTotal" runat="server" Text=""></asp:Label></h3>
        </div>
    </form>
    <script src="Scripts/jquery-3.2.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
</body>
</html>
