<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MovieMain.aspx.cs" Inherits="MoviePractice.MovieMain" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>역대 흥행 영화 모음집</title>
</head>
<body>
    <form id="form1" runat="server" style="text-align: center; background-image: url('Image/Main3.jpg'); height: 994px;">
        <div style="text-align: center">
            <asp:Label ID="Label1" runat="server" BorderColor="#999999" BorderStyle="Groove" Font-Names="배달의민족 한나체 Pro" Font-Size="XX-Large" Text="역대 흥행 영화 모음집"></asp:Label>
            <br />
            <br />
            <br />
            <asp:Image ID="Image1" runat="server" ImageUrl="~/Image/Main.png" />
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Font-Names="배달의민족 한나체 Pro" Font-Size="Large" Height="49px" Text="역대 흥행 영화 찾아보기" ToolTip="역대 흥행하였던 영화를 찾아보는 사이트로 이동합니다!" Width="188px" OnClick="Button1_Click" PostBackUrl="~/MovieList2.aspx" />
            <br />
            <br />
            <br />
        </div>
&nbsp;<asp:Button ID="Button2" runat="server" Font-Names="배달의민족 한나체 Pro" Font-Size="Large" Height="49px" Text="영화 다시보기 추천" ToolTip="역대 흥행 했던 영화들을 여러분의 알고리즘 분석을 통해 추천해드립니다!" Width="188px" PostBackUrl="~/MovieReview.aspx" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" Font-Names="배달의민족 한나체 Pro" Font-Size="Large" Height="49px" Text="제작자" ToolTip="이 사이트를 제작하는데 큰 기여를 해준 분들입니다!" Width="188px" PostBackUrl="~/MovieMaker.aspx" />
    </form>
</body>
</html>
