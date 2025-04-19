using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MoviePractice
{
    public partial class MovieReview : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Random randomGenerator = new Random(DateTime.Now.Millisecond);
            int ran = randomGenerator.Next(4);
            Genre.Text = GList.SelectedValue;

            if (GList.SelectedIndex == 0)
            {
                switch (ran)
                {
                    case 0:
                        Image1.ImageUrl = "~/Image/다시보기/액션/1.png";
                        Image2.ImageUrl = "~/Image/다시보기/액션/2.png";
                        Image3.ImageUrl = "~/Image/다시보기/액션/3.png";
                        Image4.ImageUrl = "~/Image/다시보기/액션/4.png";
                        Image5.ImageUrl = "~/Image/다시보기/액션/5.png";
                        Image6.ImageUrl = "~/Image/다시보기/액션/6.png";
                        break;
                    case 1:
                        Image1.ImageUrl = "~/Image/다시보기/액션/7.png";
                        Image2.ImageUrl = "~/Image/다시보기/액션/8.png";
                        Image3.ImageUrl = "~/Image/다시보기/액션/9.png";
                        Image4.ImageUrl = "~/Image/다시보기/액션/10.png";
                        Image5.ImageUrl = "~/Image/다시보기/액션/11.png";
                        Image6.ImageUrl = "~/Image/다시보기/액션/12.png";
                        break;
                    case 2:
                        Image1.ImageUrl = "~/Image/다시보기/액션/13.png";
                        Image2.ImageUrl = "~/Image/다시보기/액션/14.png";
                        Image3.ImageUrl = "~/Image/다시보기/액션/15.png";
                        Image4.ImageUrl = "~/Image/다시보기/액션/16.png";
                        Image5.ImageUrl = "~/Image/다시보기/액션/17.png";
                        Image6.ImageUrl = "~/Image/다시보기/액션/18.png";
                        break;
                    case 3:
                        Image1.ImageUrl = "~/Image/다시보기/액션/19.png";
                        Image2.ImageUrl = "~/Image/다시보기/액션/20.png";
                        Image3.ImageUrl = "~/Image/다시보기/액션/21.png";
                        Image4.ImageUrl = "~/Image/다시보기/액션/22.png";
                        Image5.ImageUrl = "~/Image/다시보기/액션/23.png";
                        Image6.ImageUrl = "~/Image/다시보기/액션/24.png";
                        break;
                }
            }

            if (GList.SelectedIndex == 1)
            {
                switch (ran)
                {
                    case 0:
                        Image1.ImageUrl = "~/Image/다시보기/로맨스/1.png";
                        Image2.ImageUrl = "~/Image/다시보기/로맨스/2.png";
                        Image3.ImageUrl = "~/Image/다시보기/로맨스/3.png";
                        Image4.ImageUrl = "~/Image/다시보기/로맨스/4.png";
                        Image5.ImageUrl = "~/Image/다시보기/로맨스/5.png";
                        Image6.ImageUrl = "~/Image/다시보기/로맨스/6.png";
                        break;
                    case 1:
                        Image1.ImageUrl = "~/Image/다시보기/로맨스/7.png";
                        Image2.ImageUrl = "~/Image/다시보기/로맨스/8.png";
                        Image3.ImageUrl = "~/Image/다시보기/로맨스/9.png";
                        Image4.ImageUrl = "~/Image/다시보기/로맨스/10.png";
                        Image5.ImageUrl = "~/Image/다시보기/로맨스/11.png";
                        Image6.ImageUrl = "~/Image/다시보기/로맨스/12.png";
                        break;
                    case 2:
                        Image1.ImageUrl = "~/Image/다시보기/로맨스/13.png";
                        Image2.ImageUrl = "~/Image/다시보기/로맨스/14.png";
                        Image3.ImageUrl = "~/Image/다시보기/로맨스/15.png";
                        Image4.ImageUrl = "~/Image/다시보기/로맨스/16.png";
                        Image5.ImageUrl = "~/Image/다시보기/로맨스/17.png";
                        Image6.ImageUrl = "~/Image/다시보기/로맨스/18.png";
                        break;
                    case 3:
                        Image1.ImageUrl = "~/Image/다시보기/로맨스/19.png";
                        Image2.ImageUrl = "~/Image/다시보기/로맨스/20.png";
                        Image3.ImageUrl = "~/Image/다시보기/로맨스/21.png";
                        Image4.ImageUrl = "~/Image/다시보기/로맨스/22.png";
                        Image5.ImageUrl = "~/Image/다시보기/로맨스/23.png";
                        Image6.ImageUrl = "~/Image/다시보기/로맨스/24.png";
                        break;
                }
            }

            if (GList.SelectedIndex == 2)
            {
                switch (ran)
                {
                    case 0:
                        Image1.ImageUrl = "~/Image/다시보기/드라마/1.png";
                        Image2.ImageUrl = "~/Image/다시보기/드라마/2.png";
                        Image3.ImageUrl = "~/Image/다시보기/드라마/3.png";
                        Image4.ImageUrl = "~/Image/다시보기/드라마/4.png";
                        Image5.ImageUrl = "~/Image/다시보기/드라마/5.png";
                        Image6.ImageUrl = "~/Image/다시보기/드라마/6.png";
                        break;
                    case 1:
                        Image1.ImageUrl = "~/Image/다시보기/드라마/7.png";
                        Image2.ImageUrl = "~/Image/다시보기/드라마/8.png";
                        Image3.ImageUrl = "~/Image/다시보기/드라마/9.png";
                        Image4.ImageUrl = "~/Image/다시보기/드라마/10.png";
                        Image5.ImageUrl = "~/Image/다시보기/드라마/11.png";
                        Image6.ImageUrl = "~/Image/다시보기/드라마/12.png";
                        break;
                    case 2:
                        Image1.ImageUrl = "~/Image/다시보기/드라마/13.png";
                        Image2.ImageUrl = "~/Image/다시보기/드라마/14.png";
                        Image3.ImageUrl = "~/Image/다시보기/드라마/15.png";
                        Image4.ImageUrl = "~/Image/다시보기/드라마/16.png";
                        Image5.ImageUrl = "~/Image/다시보기/드라마/17.png";
                        Image6.ImageUrl = "~/Image/다시보기/드라마/18.png";
                        break;
                    case 3:
                        Image1.ImageUrl = "~/Image/다시보기/드라마/19.png";
                        Image2.ImageUrl = "~/Image/다시보기/드라마/20.png";
                        Image3.ImageUrl = "~/Image/다시보기/드라마/21.png";
                        Image4.ImageUrl = "~/Image/다시보기/드라마/22.png";
                        Image5.ImageUrl = "~/Image/다시보기/드라마/23.png";
                        Image6.ImageUrl = "~/Image/다시보기/드라마/24.png";
                        break;
                }
            }

            if (GList.SelectedIndex == 3)
            {
                switch (ran)
                {
                    case 0:
                        Image1.ImageUrl = "~/Image/다시보기/스릴러/1.png";
                        Image2.ImageUrl = "~/Image/다시보기/스릴러/2.png";
                        Image3.ImageUrl = "~/Image/다시보기/스릴러/3.png";
                        Image4.ImageUrl = "~/Image/다시보기/스릴러/4.png";
                        Image5.ImageUrl = "~/Image/다시보기/스릴러/5.png";
                        Image6.ImageUrl = "~/Image/다시보기/스릴러/6.png";
                        break;
                    case 1:
                        Image1.ImageUrl = "~/Image/다시보기/스릴러/7.png";
                        Image2.ImageUrl = "~/Image/다시보기/스릴러/8.png";
                        Image3.ImageUrl = "~/Image/다시보기/스릴러/9.png";
                        Image4.ImageUrl = "~/Image/다시보기/스릴러/10.png";
                        Image5.ImageUrl = "~/Image/다시보기/스릴러/11.png";
                        Image6.ImageUrl = "~/Image/다시보기/스릴러/12.png";
                        break;
                    case 2:
                        Image1.ImageUrl = "~/Image/다시보기/스릴러/13.png";
                        Image2.ImageUrl = "~/Image/다시보기/스릴러/14.png";
                        Image3.ImageUrl = "~/Image/다시보기/스릴러/15.png";
                        Image4.ImageUrl = "~/Image/다시보기/스릴러/16.png";
                        Image5.ImageUrl = "~/Image/다시보기/스릴러/17.png";
                        Image6.ImageUrl = "~/Image/다시보기/스릴러/18.png";
                        break;
                    case 3:
                        Image1.ImageUrl = "~/Image/다시보기/스릴러/19.png";
                        Image2.ImageUrl = "~/Image/다시보기/스릴러/20.png";
                        Image3.ImageUrl = "~/Image/다시보기/스릴러/21.png";
                        Image4.ImageUrl = "~/Image/다시보기/스릴러/22.png";
                        Image5.ImageUrl = "~/Image/다시보기/스릴러/23.png";
                        Image6.ImageUrl = "~/Image/다시보기/스릴러/24.png";
                        break;
                }
            }

            if (GList.SelectedIndex == 4)
            {
                switch (ran)
                {
                    case 0:
                        Image1.ImageUrl = "~/Image/다시보기/공포/1.png";
                        Image2.ImageUrl = "~/Image/다시보기/공포/2.png";
                        Image3.ImageUrl = "~/Image/다시보기/공포/3.png";
                        Image4.ImageUrl = "~/Image/다시보기/공포/4.png";
                        Image5.ImageUrl = "~/Image/다시보기/공포/5.png";
                        Image6.ImageUrl = "~/Image/다시보기/공포/6.png";
                        break;
                    case 1:
                        Image1.ImageUrl = "~/Image/다시보기/공포/7.png";
                        Image2.ImageUrl = "~/Image/다시보기/공포/8.png";
                        Image3.ImageUrl = "~/Image/다시보기/공포/9.png";
                        Image4.ImageUrl = "~/Image/다시보기/공포/10.png";
                        Image5.ImageUrl = "~/Image/다시보기/공포/11.png";
                        Image6.ImageUrl = "~/Image/다시보기/공포/12.png";
                        break;
                    case 2:
                        Image1.ImageUrl = "~/Image/다시보기/공포/13.png";
                        Image2.ImageUrl = "~/Image/다시보기/공포/14.png";
                        Image3.ImageUrl = "~/Image/다시보기/공포/15.png";
                        Image4.ImageUrl = "~/Image/다시보기/공포/16.png";
                        Image5.ImageUrl = "~/Image/다시보기/공포/17.png";
                        Image6.ImageUrl = "~/Image/다시보기/공포/18.png";
                        break;
                    case 3:
                        Image1.ImageUrl = "~/Image/다시보기/공포/19.png";
                        Image2.ImageUrl = "~/Image/다시보기/공포/20.png";
                        Image3.ImageUrl = "~/Image/다시보기/공포/21.png";
                        Image4.ImageUrl = "~/Image/다시보기/공포/22.png";
                        Image5.ImageUrl = "~/Image/다시보기/공포/23.png";
                        Image6.ImageUrl = "~/Image/다시보기/공포/24.png";
                        break;
                }
            }

            if (GList.SelectedIndex == 5)
            {
                switch (ran)
                {
                    case 0:
                        Image1.ImageUrl = "~/Image/다시보기/코미디/1.png";
                        Image2.ImageUrl = "~/Image/다시보기/코미디/2.png";
                        Image3.ImageUrl = "~/Image/다시보기/코미디/3.png";
                        Image4.ImageUrl = "~/Image/다시보기/코미디/4.png";
                        Image5.ImageUrl = "~/Image/다시보기/코미디/5.png";
                        Image6.ImageUrl = "~/Image/다시보기/코미디/6.png";
                        break;
                    case 1:
                        Image1.ImageUrl = "~/Image/다시보기/코미디/7.png";
                        Image2.ImageUrl = "~/Image/다시보기/코미디/8.png";
                        Image3.ImageUrl = "~/Image/다시보기/코미디/9.png";
                        Image4.ImageUrl = "~/Image/다시보기/코미디/10.png";
                        Image5.ImageUrl = "~/Image/다시보기/코미디/11.png";
                        Image6.ImageUrl = "~/Image/다시보기/코미디/12.png";
                        break;
                    case 2:
                        Image1.ImageUrl = "~/Image/다시보기/코미디/13.png";
                        Image2.ImageUrl = "~/Image/다시보기/코미디/14.png";
                        Image3.ImageUrl = "~/Image/다시보기/코미디/15.png";
                        Image4.ImageUrl = "~/Image/다시보기/코미디/16.png";
                        Image5.ImageUrl = "~/Image/다시보기/코미디/17.png";
                        Image6.ImageUrl = "~/Image/다시보기/코미디/18.png";
                        break;
                    case 3:
                        Image1.ImageUrl = "~/Image/다시보기/코미디/19.png";
                        Image2.ImageUrl = "~/Image/다시보기/코미디/20.png";
                        Image3.ImageUrl = "~/Image/다시보기/코미디/21.png";
                        Image4.ImageUrl = "~/Image/다시보기/코미디/22.png";
                        Image5.ImageUrl = "~/Image/다시보기/코미디/23.png";
                        Image6.ImageUrl = "~/Image/다시보기/코미디/24.png";
                        break;
                }
            }

            if (GList.SelectedIndex == 6)
            {
                switch (ran)
                {
                    case 0:
                        Image1.ImageUrl = "~/Image/다시보기/모험/1.png";
                        Image2.ImageUrl = "~/Image/다시보기/모험/2.png";
                        Image3.ImageUrl = "~/Image/다시보기/모험/3.png";
                        Image4.ImageUrl = "~/Image/다시보기/모험/4.png";
                        Image5.ImageUrl = "~/Image/다시보기/모험/5.png";
                        Image6.ImageUrl = "~/Image/다시보기/모험/6.png";
                        break;
                    case 1:
                        Image1.ImageUrl = "~/Image/다시보기/모험/7.png";
                        Image2.ImageUrl = "~/Image/다시보기/모험/8.png";
                        Image3.ImageUrl = "~/Image/다시보기/모험/9.png";
                        Image4.ImageUrl = "~/Image/다시보기/모험/10.png";
                        Image5.ImageUrl = "~/Image/다시보기/모험/11.png";
                        Image6.ImageUrl = "~/Image/다시보기/모험/12.png";
                        break;
                    case 2:
                        Image1.ImageUrl = "~/Image/다시보기/모험/13.png";
                        Image2.ImageUrl = "~/Image/다시보기/모험/14.png";
                        Image3.ImageUrl = "~/Image/다시보기/모험/15.png";
                        Image4.ImageUrl = "~/Image/다시보기/모험/16.png";
                        Image5.ImageUrl = "~/Image/다시보기/모험/17.png";
                        Image6.ImageUrl = "~/Image/다시보기/모험/18.png";
                        break;
                    case 3:
                        Image1.ImageUrl = "~/Image/다시보기/모험/19.png";
                        Image2.ImageUrl = "~/Image/다시보기/모험/20.png";
                        Image3.ImageUrl = "~/Image/다시보기/모험/21.png";
                        Image4.ImageUrl = "~/Image/다시보기/모험/22.png";
                        Image5.ImageUrl = "~/Image/다시보기/모험/23.png";
                        Image6.ImageUrl = "~/Image/다시보기/모험/24.png";
                        break;
                }
            }

            if (GList.SelectedIndex == 7)
            {
                switch (ran)
                {
                    case 0:
                        Image1.ImageUrl = "~/Image/다시보기/판타지/1.png";
                        Image2.ImageUrl = "~/Image/다시보기/판타지/2.png";
                        Image3.ImageUrl = "~/Image/다시보기/판타지/3.png";
                        Image4.ImageUrl = "~/Image/다시보기/판타지/4.png";
                        Image5.ImageUrl = "~/Image/다시보기/판타지/5.png";
                        Image6.ImageUrl = "~/Image/다시보기/판타지/6.png";
                        break;
                    case 1:
                        Image1.ImageUrl = "~/Image/다시보기/판타지/7.png";
                        Image2.ImageUrl = "~/Image/다시보기/판타지/8.png";
                        Image3.ImageUrl = "~/Image/다시보기/판타지/9.png";
                        Image4.ImageUrl = "~/Image/다시보기/판타지/10.png";
                        Image5.ImageUrl = "~/Image/다시보기/판타지/11.png";
                        Image6.ImageUrl = "~/Image/다시보기/판타지/12.png";
                        break;
                    case 2:
                        Image1.ImageUrl = "~/Image/다시보기/판타지/13.png";
                        Image2.ImageUrl = "~/Image/다시보기/판타지/14.png";
                        Image3.ImageUrl = "~/Image/다시보기/판타지/15.png";
                        Image4.ImageUrl = "~/Image/다시보기/판타지/16.png";
                        Image5.ImageUrl = "~/Image/다시보기/판타지/17.png";
                        Image6.ImageUrl = "~/Image/다시보기/판타지/18.png";
                        break;
                    case 3:
                        Image1.ImageUrl = "~/Image/다시보기/판타지/19.png";
                        Image2.ImageUrl = "~/Image/다시보기/판타지/20.png";
                        Image3.ImageUrl = "~/Image/다시보기/판타지/21.png";
                        Image4.ImageUrl = "~/Image/다시보기/판타지/22.png";
                        Image5.ImageUrl = "~/Image/다시보기/판타지/23.png";
                        Image6.ImageUrl = "~/Image/다시보기/판타지/24.png";
                        break;
                }
            }

            if (GList.SelectedIndex == 8)
            {
                switch (ran)
                {
                    case 0:
                        Image1.ImageUrl = "~/Image/다시보기/재난/1.png";
                        Image2.ImageUrl = "~/Image/다시보기/재난/2.png";
                        Image3.ImageUrl = "~/Image/다시보기/재난/3.png";
                        Image4.ImageUrl = "~/Image/다시보기/재난/4.png";
                        Image5.ImageUrl = "~/Image/다시보기/재난/5.png";
                        Image6.ImageUrl = "~/Image/다시보기/재난/6.png";
                        break;
                    case 1:
                        Image1.ImageUrl = "~/Image/다시보기/재난/7.png";
                        Image2.ImageUrl = "~/Image/다시보기/재난/8.png";
                        Image3.ImageUrl = "~/Image/다시보기/재난/9.png";
                        Image4.ImageUrl = "~/Image/다시보기/재난/10.png";
                        Image5.ImageUrl = "~/Image/다시보기/재난/11.png";
                        Image6.ImageUrl = "~/Image/다시보기/재난/12.png";
                        break;
                    case 2:
                        Image1.ImageUrl = "~/Image/다시보기/재난/13.png";
                        Image2.ImageUrl = "~/Image/다시보기/재난/14.png";
                        Image3.ImageUrl = "~/Image/다시보기/재난/15.png";
                        Image4.ImageUrl = "~/Image/다시보기/재난/16.png";
                        Image5.ImageUrl = "~/Image/다시보기/재난/17.png";
                        Image6.ImageUrl = "~/Image/다시보기/재난/18.png";
                        break;
                    case 3:
                        Image1.ImageUrl = "~/Image/다시보기/재난/19.png";
                        Image2.ImageUrl = "~/Image/다시보기/재난/20.png";
                        Image3.ImageUrl = "~/Image/다시보기/재난/21.png";
                        Image4.ImageUrl = "~/Image/다시보기/재난/22.png";
                        Image5.ImageUrl = "~/Image/다시보기/재난/23.png";
                        Image6.ImageUrl = "~/Image/다시보기/재난/24.png";
                        break;
                }
            }

            if (GList.SelectedIndex == 9)
            {
                switch (ran)
                {
                    case 0:
                        Image1.ImageUrl = "~/Image/다시보기/뮤지컬/1.png";
                        Image2.ImageUrl = "~/Image/다시보기/뮤지컬/2.png";
                        Image3.ImageUrl = "~/Image/다시보기/뮤지컬/3.png";
                        Image4.ImageUrl = "~/Image/다시보기/뮤지컬/4.png";
                        Image5.ImageUrl = "~/Image/다시보기/뮤지컬/5.png";
                        Image6.ImageUrl = "~/Image/다시보기/뮤지컬/6.png";
                        break;
                    case 1:
                        Image1.ImageUrl = "~/Image/다시보기/뮤지컬/7.png";
                        Image2.ImageUrl = "~/Image/다시보기/뮤지컬/8.png";
                        Image3.ImageUrl = "~/Image/다시보기/뮤지컬/9.png";
                        Image4.ImageUrl = "~/Image/다시보기/뮤지컬/10.png";
                        Image5.ImageUrl = "~/Image/다시보기/뮤지컬/11.png";
                        Image6.ImageUrl = "~/Image/다시보기/뮤지컬/12.png";
                        break;
                    case 2:
                        Image1.ImageUrl = "~/Image/다시보기/뮤지컬/13.png";
                        Image2.ImageUrl = "~/Image/다시보기/뮤지컬/14.png";
                        Image3.ImageUrl = "~/Image/다시보기/뮤지컬/15.png";
                        Image4.ImageUrl = "~/Image/다시보기/뮤지컬/16.png";
                        Image5.ImageUrl = "~/Image/다시보기/뮤지컬/17.png";
                        Image6.ImageUrl = "~/Image/다시보기/뮤지컬/18.png";
                        break;
                    case 3:
                        Image1.ImageUrl = "~/Image/다시보기/뮤지컬/19.png";
                        Image2.ImageUrl = "~/Image/다시보기/뮤지컬/20.png";
                        Image3.ImageUrl = "~/Image/다시보기/뮤지컬/21.png";
                        Image4.ImageUrl = "~/Image/다시보기/뮤지컬/22.png";
                        Image5.ImageUrl = "~/Image/다시보기/뮤지컬/23.png";
                        Image6.ImageUrl = "~/Image/다시보기/뮤지컬/24.png";
                        break;
                }
            }

            if (GList.SelectedIndex == 10)
            {
                switch (ran)
                {
                    case 0:
                        Image1.ImageUrl = "~/Image/다시보기/추리/1.png";
                        Image2.ImageUrl = "~/Image/다시보기/추리/2.png";
                        Image3.ImageUrl = "~/Image/다시보기/추리/3.png";
                        Image4.ImageUrl = "~/Image/다시보기/추리/4.png";
                        Image5.ImageUrl = "~/Image/다시보기/추리/5.png";
                        Image6.ImageUrl = "~/Image/다시보기/추리/6.png";
                        break;
                }
            }

            if (GList.SelectedIndex == 11)
            {
                switch (ran)
                {
                    case 0:
                        Image1.ImageUrl = "~/Image/다시보기/범죄/1.png";
                        Image2.ImageUrl = "~/Image/다시보기/범죄/2.png";
                        Image3.ImageUrl = "~/Image/다시보기/범죄/3.png";
                        Image4.ImageUrl = "~/Image/다시보기/범죄/4.png";
                        Image5.ImageUrl = "~/Image/다시보기/범죄/5.png";
                        Image6.ImageUrl = "~/Image/다시보기/범죄/6.png";
                        break;
                    case 1:
                        Image1.ImageUrl = "~/Image/다시보기/범죄/7.png";
                        Image2.ImageUrl = "~/Image/다시보기/범죄/8.png";
                        Image3.ImageUrl = "~/Image/다시보기/범죄/9.png";
                        Image4.ImageUrl = "~/Image/다시보기/범죄/10.png";
                        Image5.ImageUrl = "~/Image/다시보기/범죄/11.png";
                        Image6.ImageUrl = "~/Image/다시보기/범죄/12.png";
                        break;
                    case 2:
                        Image1.ImageUrl = "~/Image/다시보기/범죄/13.png";
                        Image2.ImageUrl = "~/Image/다시보기/범죄/14.png";
                        Image3.ImageUrl = "~/Image/다시보기/범죄/15.png";
                        Image4.ImageUrl = "~/Image/다시보기/범죄/16.png";
                        Image5.ImageUrl = "~/Image/다시보기/범죄/17.png";
                        Image6.ImageUrl = "~/Image/다시보기/범죄/18.png";
                        break;
                    case 3:
                        Image1.ImageUrl = "~/Image/다시보기/범죄/19.png";
                        Image2.ImageUrl = "~/Image/다시보기/범죄/20.png";
                        Image3.ImageUrl = "~/Image/다시보기/범죄/21.png";
                        Image4.ImageUrl = "~/Image/다시보기/범죄/22.png";
                        Image5.ImageUrl = "~/Image/다시보기/범죄/23.png";
                        Image6.ImageUrl = "~/Image/다시보기/범죄/24.png";
                        break;
                }
            }

            if (GList.SelectedIndex == 12)
            {
                switch (ran)
                {
                    case 0:
                        Image1.ImageUrl = "~/Image/다시보기/애니메이션/1.png";
                        Image2.ImageUrl = "~/Image/다시보기/애니메이션/2.png";
                        Image3.ImageUrl = "~/Image/다시보기/애니메이션/3.png";
                        Image4.ImageUrl = "~/Image/다시보기/애니메이션/4.png";
                        Image5.ImageUrl = "~/Image/다시보기/애니메이션/5.png";
                        Image6.ImageUrl = "~/Image/다시보기/애니메이션/6.png";
                        break;
                    case 1:
                        Image1.ImageUrl = "~/Image/다시보기/애니메이션/7.png";
                        Image2.ImageUrl = "~/Image/다시보기/애니메이션/8.png";
                        Image3.ImageUrl = "~/Image/다시보기/애니메이션/9.png";
                        Image4.ImageUrl = "~/Image/다시보기/애니메이션/10.png";
                        Image5.ImageUrl = "~/Image/다시보기/애니메이션/11.png";
                        Image6.ImageUrl = "~/Image/다시보기/애니메이션/12.png";
                        break;
                    case 2:
                        Image1.ImageUrl = "~/Image/다시보기/애니메이션/13.png";
                        Image2.ImageUrl = "~/Image/다시보기/애니메이션/14.png";
                        Image3.ImageUrl = "~/Image/다시보기/애니메이션/15.png";
                        Image4.ImageUrl = "~/Image/다시보기/애니메이션/16.png";
                        Image5.ImageUrl = "~/Image/다시보기/애니메이션/17.png";
                        Image6.ImageUrl = "~/Image/다시보기/애니메이션/18.png";
                        break;
                    case 3:
                        Image1.ImageUrl = "~/Image/다시보기/애니메이션/19.png";
                        Image2.ImageUrl = "~/Image/다시보기/애니메이션/20.png";
                        Image3.ImageUrl = "~/Image/다시보기/애니메이션/21.png";
                        Image4.ImageUrl = "~/Image/다시보기/애니메이션/22.png";
                        Image5.ImageUrl = "~/Image/다시보기/애니메이션/23.png";
                        Image6.ImageUrl = "~/Image/다시보기/애니메이션/24.png";
                        break;
                }
            }

            if (GList.SelectedIndex == 13)
            {
                switch (ran)
                {
                    case 0:
                        Image1.ImageUrl = "~/Image/다시보기/SF/1.png";
                        Image2.ImageUrl = "~/Image/다시보기/SF/2.png";
                        Image3.ImageUrl = "~/Image/다시보기/SF/3.png";
                        Image4.ImageUrl = "~/Image/다시보기/SF/4.png";
                        Image5.ImageUrl = "~/Image/다시보기/SF/5.png";
                        Image6.ImageUrl = "~/Image/다시보기/SF/6.png";
                        break;
                    case 1:
                        Image1.ImageUrl = "~/Image/다시보기/SF/7.png";
                        Image2.ImageUrl = "~/Image/다시보기/SF/8.png";
                        Image3.ImageUrl = "~/Image/다시보기/SF/9.png";
                        Image4.ImageUrl = "~/Image/다시보기/SF/10.png";
                        Image5.ImageUrl = "~/Image/다시보기/SF/11.png";
                        Image6.ImageUrl = "~/Image/다시보기/SF/12.png";
                        break;
                    case 2:
                        Image1.ImageUrl = "~/Image/다시보기/SF/13.png";
                        Image2.ImageUrl = "~/Image/다시보기/SF/14.png";
                        Image3.ImageUrl = "~/Image/다시보기/SF/15.png";
                        Image4.ImageUrl = "~/Image/다시보기/SF/16.png";
                        Image5.ImageUrl = "~/Image/다시보기/SF/17.png";
                        Image6.ImageUrl = "~/Image/다시보기/SF/18.png";
                        break;
                    case 3:
                        Image1.ImageUrl = "~/Image/다시보기/SF/19.png";
                        Image2.ImageUrl = "~/Image/다시보기/SF/20.png";
                        Image3.ImageUrl = "~/Image/다시보기/SF/21.png";
                        Image4.ImageUrl = "~/Image/다시보기/SF/22.png";
                        Image5.ImageUrl = "~/Image/다시보기/SF/23.png";
                        Image6.ImageUrl = "~/Image/다시보기/SF/24.png";
                        break;
                }
            }

            if (GList.SelectedIndex == 14)
            {
                switch (ran)
                {
                    case 0:
                        Image1.ImageUrl = "~/Image/다시보기/음악/1.png";
                        Image2.ImageUrl = "~/Image/다시보기/음악/2.png";
                        Image3.ImageUrl = "~/Image/다시보기/음악/3.png";
                        Image4.ImageUrl = "~/Image/다시보기/음악/4.png";
                        Image5.ImageUrl = "~/Image/다시보기/음악/5.png";
                        Image6.ImageUrl = "~/Image/다시보기/음악/6.png";
                        break;
                    case 1:
                        Image1.ImageUrl = "~/Image/다시보기/음악/7.png";
                        Image2.ImageUrl = "~/Image/다시보기/음악/8.png";
                        Image3.ImageUrl = "~/Image/다시보기/음악/9.png";
                        Image4.ImageUrl = "~/Image/다시보기/음악/10.png";
                        Image5.ImageUrl = "~/Image/다시보기/음악/11.png";
                        Image6.ImageUrl = "~/Image/다시보기/음악/12.png";
                        break;
                    case 2:
                        Image1.ImageUrl = "~/Image/다시보기/음악/13.png";
                        Image2.ImageUrl = "~/Image/다시보기/음악/14.png";
                        Image3.ImageUrl = "~/Image/다시보기/음악/15.png";
                        Image4.ImageUrl = "~/Image/다시보기/음악/16.png";
                        Image5.ImageUrl = "~/Image/다시보기/음악/17.png";
                        Image6.ImageUrl = "~/Image/다시보기/음악/18.png";
                        break;
                    case 3:
                        Image1.ImageUrl = "~/Image/다시보기/음악/19.png";
                        Image2.ImageUrl = "~/Image/다시보기/음악/20.png";
                        Image3.ImageUrl = "~/Image/다시보기/음악/21.png";
                        Image4.ImageUrl = "~/Image/다시보기/음악/22.png";
                        Image5.ImageUrl = "~/Image/다시보기/음악/23.png";
                        Image6.ImageUrl = "~/Image/다시보기/음악/24.png";
                        break;
                }
            }

            if (GList.SelectedIndex == 15)
            {
                switch (ran)
                {
                    case 0:
                        Image1.ImageUrl = "~/Image/다시보기/전쟁/1.png";
                        Image2.ImageUrl = "~/Image/다시보기/전쟁/2.png";
                        Image3.ImageUrl = "~/Image/다시보기/전쟁/3.png";
                        Image4.ImageUrl = "~/Image/다시보기/전쟁/4.png";
                        Image5.ImageUrl = "~/Image/다시보기/전쟁/5.png";
                        Image6.ImageUrl = "~/Image/다시보기/전쟁/6.png";
                        break;
                    case 1:
                        Image1.ImageUrl = "~/Image/다시보기/전쟁/7.png";
                        Image2.ImageUrl = "~/Image/다시보기/전쟁/8.png";
                        Image3.ImageUrl = "~/Image/다시보기/전쟁/9.png";
                        Image4.ImageUrl = "~/Image/다시보기/전쟁/10.png";
                        Image5.ImageUrl = "~/Image/다시보기/전쟁/11.png";
                        Image6.ImageUrl = "~/Image/다시보기/전쟁/12.png";
                        break;
                    case 2:
                        Image1.ImageUrl = "~/Image/다시보기/전쟁/13.png";
                        Image2.ImageUrl = "~/Image/다시보기/전쟁/14.png";
                        Image3.ImageUrl = "~/Image/다시보기/전쟁/15.png";
                        Image4.ImageUrl = "~/Image/다시보기/전쟁/16.png";
                        Image5.ImageUrl = "~/Image/다시보기/전쟁/17.png";
                        Image6.ImageUrl = "~/Image/다시보기/전쟁/18.png";
                        break;
                    case 3:
                        Image1.ImageUrl = "~/Image/다시보기/전쟁/19.png";
                        Image2.ImageUrl = "~/Image/다시보기/전쟁/20.png";
                        Image3.ImageUrl = "~/Image/다시보기/전쟁/21.png";
                        Image4.ImageUrl = "~/Image/다시보기/전쟁/22.png";
                        Image5.ImageUrl = "~/Image/다시보기/전쟁/23.png";
                        Image6.ImageUrl = "~/Image/다시보기/전쟁/24.png";
                        break;
                }
            }
        }
    }
}