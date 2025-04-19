<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MovieReview.aspx.cs" Inherits="MoviePractice.MovieReview" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>영화 다시보기 추천</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align: center">
            <asp:Label ID="Label1" runat="server" BorderColor="Black" BorderStyle="Groove" Font-Names="배달의민족 한나체 Pro" Font-Size="XX-Large" Text="영화 다시보기 추천"></asp:Label>
        </div>
        <div style="text-align: right;">
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/MovieMain.aspx">메인화면</asp:HyperLink>
&nbsp;&nbsp;&nbsp;
            <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/MovieList2.aspx">역대 흥행 영화 찾아보기</asp:HyperLink>
&nbsp;&nbsp;&nbsp;
            <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/MovieMaker.aspx">제작자</asp:HyperLink>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </div>

        <asp:Label ID="Label2" runat="server" BackColor="#CCCCFF" BorderColor="Black" Font-Names="배달의민족 한나체 Pro" Font-Size="Large" Text="사용법" ToolTip="여러분이 원하는 영화의 장르들을 분석하여 킬링타임용으로 다시볼 영화를 추천해 드립니다! 문항에 해당하는 내용에 체크해 주세요! [한가지만 선택가능!]"></asp:Label>
        <br />
        <br />

        <div style="font-family: '배달의민족 한나체 Pro'; font-size: large">

            <asp:TextBox ID="Genre" runat="server" Font-Names="배달의민족 한나체 Pro" Font-Size="Large" Width="238px" MaxLength="50" Rows="50" Height="19px"></asp:TextBox>
            장르들로 영화들을 추천해드렸습니다!<br />
            <br />
            <asp:Image ID="Image1" runat="server" Height="250px" />
&nbsp;&nbsp;&nbsp;
            <asp:Image ID="Image2" runat="server" Height="250px" />
&nbsp;&nbsp;&nbsp;
            <asp:Image ID="Image3" runat="server" Height="250px" />
&nbsp;&nbsp;&nbsp;
            <asp:Image ID="Image4" runat="server" Height="250px" />
&nbsp;&nbsp;&nbsp;
            <asp:Image ID="Image5" runat="server" Height="250px" />
&nbsp;&nbsp;&nbsp;
            <asp:Image ID="Image6" runat="server" Height="250px" />
&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;
            <br />
        </div>
        <div>

            <br />
            <asp:Label ID="Qu2" runat="server" Font-Names="배달의민족 한나체 Pro" Font-Size="Large" Text="보고싶은 영화의 장르를 선택해주세요!"></asp:Label>
            <asp:RadioButtonList ID="GList" runat="server">
                <asp:ListItem>액션</asp:ListItem>
                <asp:ListItem>로맨스</asp:ListItem>
                <asp:ListItem>드라마</asp:ListItem>
                <asp:ListItem>스릴러</asp:ListItem>
                <asp:ListItem>공포</asp:ListItem>
                <asp:ListItem>코미디</asp:ListItem>
                <asp:ListItem>모험</asp:ListItem>
                <asp:ListItem>판타지</asp:ListItem>
                <asp:ListItem>재난</asp:ListItem>
                <asp:ListItem>뮤지컬</asp:ListItem>
                <asp:ListItem>추리</asp:ListItem>
                <asp:ListItem>범죄</asp:ListItem>
                <asp:ListItem>애니메이션</asp:ListItem>
                <asp:ListItem>SF</asp:ListItem>
                <asp:ListItem>음악</asp:ListItem>
                <asp:ListItem>전쟁</asp:ListItem>
            </asp:RadioButtonList>
            <br />
        </div>
        <div style="text-align: center">

            <asp:Button ID="Button1" runat="server" BackColor="#FFFF66" BorderColor="Black" BorderStyle="Groove" Font-Names="배달의민족 한나체 Pro" Font-Overline="False" Font-Size="X-Large" OnClick="Button1_Click" Text="불러오기!" />

        </div>
    </form>
</body>
</html>
