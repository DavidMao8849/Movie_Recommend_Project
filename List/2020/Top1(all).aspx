<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Top1(all).aspx.cs" Inherits="MoviePractice.Movielist.Top1_all_" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server" style="text-align: center">
        <div style="text-align: center">
            <asp:Label ID="Label1" runat="server" BorderColor="Black" BorderStyle="Groove" Font-Names="배달의민족 한나체 Pro" Font-Size="XX-Large" Text="역대 흥행 영화 찾아보기"></asp:Label>
        </div>
        <div style="text-align: right;">
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/MovieMain.aspx">메인화면</asp:HyperLink>
&nbsp;&nbsp;&nbsp;
            <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/MovieMaker.aspx">제작자</asp:HyperLink>
&nbsp;&nbsp;&nbsp;
            <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/MovieReview.aspx">영화 다시보기</asp:HyperLink>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </div>
        <asp:Image ID="Image1" runat="server" Height="400px" ImageUrl="~/Image/연도별/전체/2020/1.png" />
        <br />
        <br />
        <asp:Image ID="Image2" runat="server" ImageUrl="~/Image/연도별/전체/2020/11.png" />
        <br />
        <br />
    </form>
</body>
</html>
