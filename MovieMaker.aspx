<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MovieMaker.aspx.cs" Inherits="MoviePractice.MovieMaker" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>프로젝트 제작자 소개</title>
</head>

<body style="background-image: url('https://localhost:44353/Image/Main3.jpg')">
    <form id="form1" runat="server">
         <div style="text-align: center">
            <asp:Label ID="Label1" runat="server" BorderColor="Black" BorderStyle="Groove" Font-Names="배달의민족 한나체 Pro" Font-Size="XX-Large" Text="제작자 소개" Height="30px"></asp:Label>
        </div>
        <div style="text-align: right;">
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/MovieMain.aspx">메인화면</asp:HyperLink>
&nbsp;&nbsp;&nbsp;
            <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/MovieList2.aspx">역대 흥행 영화 찾아보기</asp:HyperLink>
&nbsp;&nbsp;&nbsp;
            <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/MovieReview.aspx">영화 다시보기 추천</asp:HyperLink>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </div>
         <p style="text-align: center">
             &nbsp;</p>
         <p style="text-align: center">
             &nbsp;</p>
         <p style="text-align: center">
             &nbsp;</p>
         <p style="text-align: center">
             <asp:Label ID="Label3" runat="server" Font-Names="배달의민족 한나체 Pro" Font-Size="X-Large" Text="유한대학교 서버 구축 및 실습 2반 PBL프로젝트"></asp:Label>
         </p>
         <p style="text-align: center">
             <asp:Label ID="Label5" runat="server" Font-Names="배달의민족 한나체 Pro" Font-Size="X-Large" Text=" 프로젝트 주제 : 역대 흥행 영화 찾아보기"></asp:Label>
         </p>
         <p style="text-align: center">
             <asp:Label ID="Label4" runat="server" Font-Names="배달의민족 한나체 Pro" Font-Size="X-Large" Text="조 이름 : 저희 신입생 맞조"></asp:Label>
         </p>
         <p style="text-align: center">
             &nbsp;</p>
         <p style="text-align: center">
             <asp:Label ID="Label6" runat="server" Font-Names="배달의민족 한나체 Pro" Font-Size="X-Large" Text="조원"></asp:Label>
         </p>
         <p style="text-align: center">
             <asp:Label ID="Label7" runat="server" Font-Names="배달의민족 한나체 Pro" Font-Size="X-Large" Text="이은우(조장) [발표/개발/디자인/자료조사/PPT]"></asp:Label>
         </p>
         <p style="text-align: center">
             <asp:Label ID="Label2" runat="server" Font-Names="배달의민족 한나체 Pro" Font-Size="X-Large" Text="권경운(개발, 디자인) "></asp:Label></p>
         <p style="text-align: center">
             <asp:Label ID="Label8" runat="server" Font-Names="배달의민족 한나체 Pro" Font-Size="X-Large" Text="송여빈(자료조사, PPT)"></asp:Label></p>
         <p style="text-align: center">
             <asp:Label ID="Label9" runat="server" Font-Names="배달의민족 한나체 Pro" Font-Size="X-Large" Text="최희유(자료조사, 디자인)"></asp:Label></p>
         <p style="text-align: center">
             &nbsp;</p>
    </form>
    </body>
</html>
