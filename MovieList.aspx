<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MovieList.aspx.cs" Inherits="MoviePractice.MovieList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>역대 흥행 영화 찾아보기</title>
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
        <div>

            <asp:Label ID="Label2" runat="server" Text="사용법" ToolTip="밑에 보이는 카테고리를 클릭시 해당하는 기준(대상을 받은 영화인가, 박스오피스에서 집계하여 나온 흥행한 영화인가)과 지역(해외/국내), 년도(2016~2020년)에 해당하는 부분을 불러와 흥행했던 영화를 TOP10까지 나타냅니다! " BackColor="#CCCCFF" BorderColor="Black" Font-Names="배달의민족 한나체 Pro" Font-Size="Large"></asp:Label>
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>기준</asp:ListItem>
                <asp:ListItem>박스오피스</asp:ListItem>
                <asp:ListItem>아카데미</asp:ListItem>
            </asp:DropDownList>
&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList2" runat="server">
                <asp:ListItem>지역</asp:ListItem>
                <asp:ListItem>전체</asp:ListItem>
                <asp:ListItem>해외</asp:ListItem>
                <asp:ListItem>국내</asp:ListItem>
            </asp:DropDownList>
&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList3" runat="server" Height="16px">
                <asp:ListItem>년도</asp:ListItem>
                <asp:ListItem>2016년도</asp:ListItem>
                <asp:ListItem>2017년도</asp:ListItem>
                <asp:ListItem>2018년도</asp:ListItem>
                <asp:ListItem>2019년도</asp:ListItem>
                <asp:ListItem>2020년도</asp:ListItem>
            </asp:DropDownList>
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" Text="불러오기" OnClick="Button1_Click" />
            <br />
            <br />
            <br />
            <br />
        </div>
        <div style="text-align: center">
            <asp:ImageButton ID="ImageButton1" runat="server" Height="300px" OnClick="ImageButton1_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:ImageButton ID="ImageButton2" runat="server" Height="300px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:ImageButton ID="ImageButton3" runat="server" Height="300px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:ImageButton ID="ImageButton4" runat="server" Height="300px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:ImageButton ID="ImageButton5" runat="server" Height="300px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:ImageButton ID="ImageButton6" runat="server" Height="300px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:ImageButton ID="ImageButton7" runat="server" Height="300px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:ImageButton ID="ImageButton8" runat="server" Height="300px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:ImageButton ID="ImageButton9" runat="server" Height="300px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:ImageButton ID="ImageButton10" runat="server" Height="300px" />
        </div>
    </form>
</body>
</html>
