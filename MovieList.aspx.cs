using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MoviePractice
{
    public partial class MovieList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedIndex == 1)
            {
                if (DropDownList2.SelectedIndex == 1)
                {
                    if (DropDownList3.SelectedIndex == 5)
                    {
                        ImageButton1.ImageUrl = "~/Image/연도별/전체/2020/1.png";
                        ImageButton1.PostBackUrl = "~/List/2020/Top1(all).aspx";
                        ImageButton2.ImageUrl = "~/Image/연도별/전체/2020/2.png";
                        ImageButton2.PostBackUrl = "~/List/2020/Top2(all).aspx";
                        ImageButton3.ImageUrl = "~/Image/연도별/전체/2020/3.png";
                        ImageButton3.PostBackUrl = "~/List/2020/Top3(all).aspx";
                        ImageButton4.ImageUrl = "~/Image/연도별/전체/2020/4.png";
                        ImageButton4.PostBackUrl = "~/List/2020/Top4(all).aspx";
                        ImageButton5.ImageUrl = "~/Image/연도별/전체/2020/5.png";
                        ImageButton5.PostBackUrl = "~/List/2020/Top5(all).aspx";
                        ImageButton6.ImageUrl = "~/Image/연도별/전체/2020/6.png";
                        ImageButton6.PostBackUrl = "~/List/2020/Top6(all).aspx";
                        ImageButton7.ImageUrl = "~/Image/연도별/전체/2020/7.png";
                        ImageButton7.PostBackUrl = "~/List/2020/Top7(all).aspx";
                        ImageButton8.ImageUrl = "~/Image/연도별/전체/2020/8.png";
                        ImageButton8.PostBackUrl = "~/List/2020/Top8(all).aspx";
                        ImageButton9.ImageUrl = "~/Image/연도별/전체/2020/9.png";
                        ImageButton9.PostBackUrl = "~/List/2020/Top9(all).aspx";
                        ImageButton10.ImageUrl = "~/Image/연도별/전체/2020/10.png";
                        ImageButton10.PostBackUrl = "~/List/2020/Top10(all).aspx";
                    }
                }
            }
            if (DropDownList1.SelectedIndex == 1)
            {
                if(DropDownList2.SelectedIndex == 1)
                {
                    if(DropDownList3.SelectedIndex == 4)
                    {
                        ImageButton1.ImageUrl = "~/Image/연도별/전체/2019/1.png";
                        ImageButton1.PostBackUrl = "~/List/2019/Top1.aspx";
                        ImageButton2.ImageUrl = "~/Image/연도별/전체/2019/2.png";
                        ImageButton2.PostBackUrl = "~/List/2019/Top2.aspx";
                        ImageButton3.ImageUrl = "~/Image/연도별/전체/2019/3.png";
                        ImageButton3.PostBackUrl = "~/List/2019/Top3.aspx";
                        ImageButton4.ImageUrl = "~/Image/연도별/전체/2019/4.png";
                        ImageButton4.PostBackUrl = "~/List/2019/Top4.aspx";
                        ImageButton5.ImageUrl = "~/Image/연도별/전체/2019/5.png";
                        ImageButton5.PostBackUrl = "~/List/2019/Top5.aspx";
                        ImageButton6.ImageUrl = "~/Image/연도별/전체/2019/6.png";
                        ImageButton6.PostBackUrl = "~/List/2019/Top6.aspx";
                        ImageButton7.ImageUrl = "~/Image/연도별/전체/2019/7.png";
                        ImageButton7.PostBackUrl = "~/List/2019/Top7.aspx";
                        ImageButton8.ImageUrl = "~/Image/연도별/전체/2019/8.png";
                        ImageButton8.PostBackUrl = "~/List/2019/Top8.aspx";
                        ImageButton9.ImageUrl = "~/Image/연도별/전체/2019/9.png";
                        ImageButton9.PostBackUrl = "~/List/2019/Top9.aspx";
                        ImageButton10.ImageUrl = "~/Image/연도별/전체/2019/10.png";
                        ImageButton10.PostBackUrl = "~/List/2019/Top10.aspx";

                    }
                }
            }
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {

        }
    }
}