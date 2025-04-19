<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MovieList2.aspx.cs" Inherits="MoviePractice.MovieList2" %>

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

            <asp:Label ID="Label2" runat="server" Text="사용법" ToolTip="밑에 보이는 카테고리를 클릭시 해당하는 기준과 지역(해외/국내), 년도(2016~2020년)에 해당하는 부분을 불러와 (대한민국을 기준으로)흥행했던 영화를 내림차순으로 TOP10까지 나타냅니다! " BackColor="#CCCCFF" BorderColor="Black" Font-Names="배달의민족 한나체 Pro" Font-Size="X-Large"></asp:Label>
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>기준</asp:ListItem>
                <asp:ListItem>박스오피스</asp:ListItem>
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
        </div>
        <div style="text-align: center">
            <asp:Image ID="Image1" runat="server" Height="403px" Width="320px" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" Height="397px" Width="648px" BorderColor="Black" Font-Names="배달의민족 한나체 Pro" Font-Size="X-Large" TextMode="MultiLine" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Image ID="Image2" runat="server" Height="403px" Width="320px" />
            &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server" Height="397px" Width="648px" BorderColor="Black" Font-Names="배달의민족 한나체 Pro" Font-Size="X-Large" TextMode="MultiLine" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Image ID="Image3" runat="server" Height="403px" Width="320px" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox3" runat="server" Height="397px" Width="648px" BorderColor="Black" Font-Names="배달의민족 한나체 Pro" Font-Size="X-Large" TextMode="MultiLine" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Image ID="Image4" runat="server" Height="403px" Width="320px" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox4" runat="server" Height="397px" Width="648px" BorderColor="Black" Font-Names="배달의민족 한나체 Pro" Font-Size="X-Large" TextMode="MultiLine" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Image ID="Image5" runat="server" Height="403px" Width="320px" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox5" runat="server" Height="397px" Width="648px" BorderColor="Black" Font-Names="배달의민족 한나체 Pro" Font-Size="X-Large" TextMode="MultiLine" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Image ID="Image6" runat="server" Height="403px" Width="320px" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox6" runat="server" Height="397px" Width="648px" BorderColor="Black" Font-Names="배달의민족 한나체 Pro" Font-Size="X-Large" TextMode="MultiLine" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Image ID="Image7" runat="server" Height="403px" Width="320px" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox7" runat="server" Height="397px" Width="648px" BorderColor="Black" Font-Names="배달의민족 한나체 Pro" Font-Size="X-Large" TextMode="MultiLine" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Image ID="Image8" runat="server" Height="403px" Width="320px" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox8" runat="server" Height="397px" Width="648px" BorderColor="Black" Font-Names="배달의민족 한나체 Pro" Font-Size="X-Large" TextMode="MultiLine" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Image ID="Image9" runat="server" Height="403px" Width="320px" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox9" runat="server" Height="397px" Width="648px" BorderColor="Black" Font-Names="배달의민족 한나체 Pro" Font-Size="X-Large" TextMode="MultiLine" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Image ID="Image10" runat="server" Height="403px" Width="320px" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox10" runat="server" Height="397px" Width="648px" BorderColor="Black" Font-Names="배달의민족 한나체 Pro" Font-Size="X-Large" TextMode="MultiLine" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
