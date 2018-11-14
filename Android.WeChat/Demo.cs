using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Android.WeChat
{
    public partial class Demo : Form
    {
        public Demo()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            var postData = $"username={txt_loginUserName.Text}";
            postData += $"&password={txt_loginPassword.Text}";
            string res = Http.Post(App.HostUrl+ "Login", postData);
            txt_outPut.Text = res;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string res = Http.Post(App.HostUrl + "Init");
            txt_outPut.Text = res;
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            string res = Http.Post(App.HostUrl + "NewInit");
            txt_outPut.Text = res;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string res = Http.Post(App.HostUrl + "GetContactList");
            txt_outPut.Text = res;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string res = Http.Post(App.HostUrl + "GetChatroomList");
            txt_outPut.Text = res;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string res = Http.Post(App.HostUrl + "GetGZHList");
            txt_outPut.Text = res;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string res = Http.Post(App.HostUrl + "GetBlackList");
            txt_outPut.Text = res;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string res = Http.Post(App.HostUrl + "GetDelContactList");
            txt_outPut.Text = res;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string res = Http.Post(App.HostUrl + "NewSync");
            txt_outPut.Text = res;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var postData = $"wxid={txt_contactSyncWxid.Text}";
            string res = Http.Post(App.HostUrl + "ContactSync", postData);
            txt_outPut.Text = res;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var postData = $"code={txt_verCode.Text}";
            postData += $"&wxid={txt_verWxid.Text}";
            postData += $"&v1={txt_verV1.Text}";
            postData += $"&ticket={txt_verTicket.Text}";
            postData += $"&antiticket={txt_verAnticket.Text}";
            postData += $"&content={txt_verContent.Text}";
            string res = Http.Post(App.HostUrl + "VerifyFriend", postData);
            txt_outPut.Text = res;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            var postData = $"wxid={txt_msgWxid.Text}";
            postData += $"&content={txt_msgContext.Text}";
            string res = Http.Post(App.HostUrl + "SendMsgText", postData);
            txt_outPut.Text = res;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string str = unicodeToString(txt_unicode.Text);
            txt_Str.Text = str;
        }

        private string unicodeToString(string sIn)
        {
            //string sIn = "\\u4fc4\\u7f57\\u65af\\u536b\\u56fd\\u6218\\u4e89\\u9898\\u6750MV\\u300a\\u6700\\u7231";//转换前
            string sOut = "";//转换后
            string[] arr = sIn.Split(new string[] { "\\u" }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string s in arr)
            {
                sOut += (char)Convert.ToInt32(s.Substring(0, 4), 16) + s.Substring(4);
            }
            return sOut;
        }
    }
}
