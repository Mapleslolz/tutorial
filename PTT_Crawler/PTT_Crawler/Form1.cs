using MySql.Data.MySqlClient;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTT_Crawler
{
    public partial class Form1 : Form
    {
        DB db;
        public Form1()
        {
            InitializeComponent();
            db = new DB("localhost", "root", "", "ptt-crawler-db");
            db.open();
        }

        private void insertData_Click(object sender, EventArgs e)
        {
            db.insertData("test", "test", "您按了輸入資料");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("你是否確定要離開?", "警告", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                db.close();
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void crawPTT_Click(object sender, EventArgs e)
        {
            IWebDriver driver = new ChromeDriver("C:\\");
            for (int U = 540; U <= 541; U++)
            {
                driver.Navigate().GoToUrl("https://www.ptt.cc/bbs/NBA/index"+U+".html");
                for (int i = 1; i <= 20; i++)
                {
                    try
                    {
                        string Text;
                        var title = driver.FindElement(By.XPath("/html/body/div[@id='main-container']/div[@class='r-list-container action-bar-margin bbs-screen']/div[@class='r-ent'][" + i + "]/div[@class='title']/a"));
                        Text = title.GetAttribute("innerHTML").ToString();
                        string replace = Text.Replace("'", "");
                        db.insertData("test", "test", replace);
                    }
                    catch(Exception ex)
                    {

                    }
                }
            }
            driver.Quit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}