<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Top10(all).aspx.cs" Inherits="MoviePractice.Movielist.Top10_all_" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
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
    </form>
</body>
</html>
