using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KiWoomOpenAPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btn_Login.Click += Button_click;

            btn_codeSearch.Click += Button_click;
            axKHOpenAPI1.OnEventConnect += onEventConnect;
            axKHOpenAPI1.OnReceiveTrData += onReceiveTrData;
        }

        public void Button_click(object sender, EventArgs e)
        {
            if (sender.Equals(this.btn_Login))
            {
                axKHOpenAPI1.CommConnect();
            }else if (sender.Equals(btn_codeSearch))
            {
                axKHOpenAPI1.SetInputValue("종목코드", this.textBox_codeSearch.Text.Trim());
                int nRet = axKHOpenAPI1.CommRqData("주식기본정보", "OPT10001", 0,"1001");

                if (nRet == 0)
                    listBox_info.Items.Add("조회 성공 !");
                else
                    listBox_info.Items.Add("조회 실패 !");
            }
            
        }
        public void onEventConnect(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnEventConnectEvent e)
        {
            if (e.nErrCode == 0)
            {
                string account = axKHOpenAPI1.GetLoginInfo("ACCLIST").Trim();
                string[] accList = account.Split(';');
                                                
                for (int i = 0; i < accList.Length; i++)
                {
                    if (accList[i].Length == 0) continue;
                    comboBox_getAccList.Items.Add(accList[i]);
                }
                string userId = axKHOpenAPI1.GetLoginInfo("USER_ID");
                string userNm = axKHOpenAPI1.GetLoginInfo("USER_NAME");
                string servercheck = axKHOpenAPI1.GetLoginInfo("GetServerGubun");

                label_getID.Text = userId;
                lebel_getName.Text = userNm;
                if (servercheck.Length == 1)
                    label_getServer.Text = "모의 투자";
                else
                    label_getServer.Text = "투자";
            }
        }

        public void onReceiveTrData(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveTrDataEvent e)
        {
            if(e.sRQName == "주식기본정보")
            {
                int nCnt = axKHOpenAPI1.GetRepeatCnt(e.sTrCode, e.sRQName);

                listBox_info.Items.Add("종목코드\t\t\t" + axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "종목코드"));
                listBox_info.Items.Add("종목명\t" + axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "종목명"));
                listBox_info.Items.Add("거래량\t\t\t" + axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "거래량"));
                listBox_info.Items.Add("시가\t\t\t" + axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "시가"));
                listBox_info.Items.Add("고가\t\t\t" + axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "고가"));
                listBox_info.Items.Add("저가\t\t\t" + axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "저가"));
                listBox_info.Items.Add("현재가\t\t\t" + axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "현재가"));
                listBox_info.Items.Add("등락율\t\t\t" + axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "등락율"));
                
            }
        }
    }
}