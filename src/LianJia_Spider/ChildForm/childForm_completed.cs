using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LianJia_Spider
{
    public partial class childForm_completed : Form
    {
        public childForm_completed()
        {
            InitializeComponent();
        }

        private void childForm_completed_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                if (GlobalData.taskArray[i, 8] == "3")
                {
                    string tasknametemp = "【 " + GlobalData.taskArray[i, 1] + " 】" + GlobalData.taskArray[i, 2] + GlobalData.taskArray[i, 4] + " [" + GlobalData.taskArray[i, 0] + "页]#" + GlobalData.taskArray[i, 7] + "# 已采集完毕";
                    checkedListBox_doneList.Items.Add(tasknametemp);
                }
            }
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {

            checkedListBox_doneList.Items.Clear();
            for (int i = 0; i < 20; i++)
            {
                if (GlobalData.taskArray[i, 8] == "3")
                {
                    string tasknametemp = "【 " + GlobalData.taskArray[i, 1] + " 】" + GlobalData.taskArray[i, 2] + GlobalData.taskArray[i, 4] + " [" + GlobalData.taskArray[i, 0] + "页]#" + GlobalData.taskArray[i, 7] + "# 已采集完毕";
                    checkedListBox_doneList.Items.Add(tasknametemp);
                }
            }
        }

        private void btn_viewData_Click(object sender, EventArgs e)
        {
            string selecteditems = string.Empty;
            for (int i = 0; i < checkedListBox_doneList.CheckedItems.Count; i++)
            {
                selecteditems = checkedListBox_doneList.SelectedItem.ToString(); //注意是SelectedItem不是CheckedItems
            }
            if (selecteditems == string.Empty)
            {
                MessageBox.Show("您还没有选择任务呢！选一个任务吧！");
                return;
            }

            string[] runArray = selecteditems.Split('#');
            string index01 = runArray[1];
            int index1 = Convert.ToInt32(index01);


            ProcessStartInfo pcsinfo = new ProcessStartInfo(@"F:\SpiderData/" + GlobalData.taskArray[index1, 1] + ".csv");
            Process pcs = new Process();
            pcs.StartInfo = pcsinfo;
            pcs.Start();
        }

        private void btn_loadData_Click(object sender, EventArgs e)
        {
            string selecteditems = string.Empty;
            for (int i = 0; i < checkedListBox_doneList.CheckedItems.Count; i++)
            {
                selecteditems = checkedListBox_doneList.SelectedItem.ToString(); //注意是SelectedItem不是CheckedItems
            }
            if (selecteditems == string.Empty)
            {
                MessageBox.Show("亲，您还没有选择任务呢！");
                return;
            }

            string[] runArray = selecteditems.Split('#');
            string index01 = runArray[1];
            int index1 = Convert.ToInt32(index01);

            string taskname = GlobalData.taskArray[index1, 1];
            TabPage Page = new TabPage();
            Page.Text = "【" + taskname + "】[加载完成]";
            tabControl1.Controls.Add(Page);
            tabControl1.SelectedTab = Page;

            Panel panel = new Panel();
            
            Page.Controls.Add(panel);
            panel.BackColor = Color.White;
            panel.Dock = DockStyle.Fill;

            DataGridView dataGridView = new DataGridView();
            panel.Controls.Add(dataGridView);
            dataGridView.Dock = DockStyle.Fill;


            //连接数据库
            string mysql_con = "server=127.0.0.1; user=root; password=mysql; database=spiderdata; port=3306; charset=utf8;";
            MySqlConnection mySqlConnection = new MySqlConnection(mysql_con);
            mySqlConnection.Open();

            DataSet dataSet = new DataSet();
            MySqlDataAdapter mySqlDataAdapter;
            string select_sqlstr = "select * from " + taskname + ";";
            mySqlDataAdapter = new MySqlDataAdapter(select_sqlstr, mysql_con);
            mySqlDataAdapter.Fill(dataSet, taskname);
            dataGridView.DataSource = dataSet.Tables[taskname];
            dataGridView.AutoResizeColumns();
            dataGridView.AutoResizeRows();
            dataGridView.AutoResizeColumnHeadersHeight();
            mySqlConnection.Close();
        }
    }
}
