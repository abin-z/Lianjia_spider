using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LianJia_Spider
{
    //正在运行窗体
    public partial class childForm_running : Form
    {
        private string taskstr;
        private int textBoxIndex = 1;

        public childForm_running()
        {
            InitializeComponent();
        }
        int n = 0;
        public void setText(string s)
        {
            taskstr = s;
            string[] sArray = taskstr.Split('!');
            for (int i = 0; i <= 6; i++)
            {
                GlobalData.taskArray[n, i] = sArray[i];
            }
            GlobalData.taskArray[n, 7] = n.ToString();   //保存当前任务的index 
            GlobalData.taskArray[n, 8] = "1";     //1表示该任务已经创建但未执行 2表示任务正在运行中 3表示任务已经执行完成
            //添加到checkedListBox中
            string tasknametemp = "【 " + GlobalData.taskArray[n, 1] + " 】" + GlobalData.taskArray[n, 2] + GlobalData.taskArray[n, 4] + " [" + GlobalData.taskArray[n, 0] + "页]#" + GlobalData.taskArray[n, 7];
            checkedListBox_taskList.Items.Add(tasknametemp);

            MessageBox.Show("任务创建成功！");
            Console.WriteLine(n++);                 //n++不能少
            //Console.WriteLine("采集页数:" + sArray[0]);
            //Console.WriteLine("任务名:" + sArray[1]);
            //Console.WriteLine("城市:" + sArray[2]);
            //Console.WriteLine("cityURL:" + sArray[3]);
            //Console.WriteLine("房源类型:" + sArray[4]);
            //Console.WriteLine("StartURL:" + sArray[5]);
            //Console.WriteLine("房源类型代号:" + sArray[6]);
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox_taskList.Items.Count; i++)
            {
                if (checkedListBox_taskList.GetItemChecked(i))
                {
                    checkedListBox_taskList.Items.RemoveAt(i);
                    i--;                                    //*当删除一个item后索引值也在减少，所以i--
                }
            }
        }

        private void btn_run01_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(taskstr))
            {
                MessageBox.Show("请先创建任务", "出错啦", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string selecteditems = string.Empty;
            for (int i = 0; i < checkedListBox_taskList.CheckedItems.Count; i++)
            {
                selecteditems = checkedListBox_taskList.SelectedItem.ToString(); //注意是SelectedItem不是CheckedItems
            }
            if (selecteditems == string.Empty)
            {
                MessageBox.Show("请勾选你要运行的一个任务！");
                return;
            }

            string[] runArray = selecteditems.Split('#');
            string index01 = runArray[1];
            int index1 = Convert.ToInt32(index01);


            if (GlobalData.taskArray[index1, 8] != "1")
            {
                if (GlobalData.taskArray[index1, 8] == "2")
                    MessageBox.Show("该任务已在运行中，请勿重复执行任务！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (GlobalData.taskArray[index1, 8] == "3")
                    MessageBox.Show("该任务已在运行完成，请勿重复执行任务！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string taskname = GlobalData.taskArray[index1, 1];
            TabPage Page = new TabPage();
            Page.Name = "Page" + textBoxIndex.ToString();
            Page.Text = "【" + taskname + "】[运行中]";
            tabControl1.Controls.Add(Page);
            tabControl1.SelectedTab = Page;

            TextBox txt = new TextBox();
            txt.Multiline = true;
            txt.Text = "";
            txt.Name = "textBox_runing" + textBoxIndex.ToString();
            txt.Parent = Page;
            txt.Dock = DockStyle.Fill;
            txt.BorderStyle = BorderStyle.None;
            txt.ScrollBars = ScrollBars.Both;
            txt.WordWrap = false;
            txt.Font = new Font("苹方-简", 9, txt.Font.Style);
            Page.Controls.Add(txt);
            textBoxIndex++;

            string DateDirectory = "/SpiderData";
            try
            {
                if (!Directory.Exists(DateDirectory))
                {
                    // Create the directory it does not exist.
                    Directory.CreateDirectory(DateDirectory);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            Task.Run(() => CollectionData(index1, txt, Page));//开启线程执行任务
            GlobalData.taskArray[index1, 8] = "2"; //表示该任务正在执行
        }

        private void CollectionData(int index, TextBox textBox, TabPage tabPage)
        {
            string startURL = GlobalData.taskArray[index, 5];
            string URL_city = GlobalData.taskArray[index, 3];
            int pageNum = Convert.ToInt32(GlobalData.taskArray[index, 0]);
            int fanYuanLeiXing = Convert.ToInt32(GlobalData.taskArray[index, 6]);
            string final_URL;
            string strListSourceCode = "";
            string strFinalSourceCode = "";

            int count = 0;
            string startURL_copy = startURL;
            textBox.Clear();
            string taskname = GlobalData.taskArray[index, 1];
            string savePath = "/SpiderData/" + taskname + ".csv";
            if (File.Exists(savePath))
            {
                MessageBox.Show("文件:" + taskname + " 已存在，换个名字吧！");
                tabControl1.TabPages.Remove(tabPage);
                return;
            }

            //连接数据库
            string mysql_con = "server=127.0.0.1; user=root; password=mysql; database=spiderdata; port=3306; charset=utf8;";
            MySqlConnection mySqlConnection = new MySqlConnection(mysql_con);
            mySqlConnection.Open();

            ///二手房采集模块
            if (fanYuanLeiXing == 1)//采集二手房信息
            {
                string createtable_sqlstr = @"CREATE TABLE `" + GlobalData.taskArray[index, 1] + @"` (
  `introduce` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL COMMENT '房源介绍',
  `tatalPrice` decimal(10,2) DEFAULT NULL COMMENT '总价',
  `unitPrice` decimal(10,0) DEFAULT NULL COMMENT '单价',
  `houseType` varchar(64) DEFAULT NULL COMMENT '房屋户型',
  `louceng` varchar(64) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL COMMENT '楼层',
  `jianzhuArea` varchar(64) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL COMMENT '建筑面积',
  `Web_URL` varchar(128) DEFAULT NULL COMMENT '网址'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;";
                MySqlCommand mySqlCommand = new MySqlCommand(createtable_sqlstr, mySqlConnection);
                mySqlCommand.ExecuteNonQuery();

                textBox.AppendText("任务开始运行\r\n正在初始化二手房模块，请稍等……\r\n二手房模块初始化成功，开始数据采集……\r\n\r\n正在下载并分析网址：" + startURL + "\r\n\r\n");
                try
                {
                    //StreamWriter writer = File.CreateText(savePath);
                    StreamWriter writer = new StreamWriter(savePath, true, Encoding.UTF8);

                    writer.WriteLine("二手房介绍,总价（万元）,单价（元/平米）,房屋户型, 所在楼层, 建筑面积, 户型结构, 套内面积, 建筑类型, 房屋朝向, 建筑结构, 装修情况, 梯户比例, 供暖方式, 配备电梯, Web-URL");
                    for (int pg = 1; pg <= pageNum; pg++)
                    {
                        startURL = startURL_copy + "/pg" + pg.ToString() + "/#contentList";
                        strListSourceCode = GetSourceCode.DownloadCode(startURL);
                        /////////

                        //抓取二手房列表地址的正则表达式
                        string stringRegex = @"<div\s+class=""price""><span>.+?</span>万</div></a><a\s+class=""title""\s+href=""(?<finalURL>.+?)""\s+target=""_blank""";
                        Regex regex = new Regex(stringRegex, RegexOptions.Singleline | RegexOptions.Multiline | RegexOptions.Compiled);

                        //将符合正则表达式match全部提取出来
                        var matches = regex.Matches(strListSourceCode);

                        foreach (Match match in matches)
                        {
                            count++;
                            final_URL = match.Groups["finalURL"].ToString();
                            Match match01;
                            Match match02;
                            MatchCollection matches03;

                            strFinalSourceCode = GetSourceCode.DownloadCode(final_URL);

                            //List<Task> tasklist_regex = new List<Task>();
                            //tasklist_regex.Add(Task.Run(() =>
                            //{

                            //正则表达式(获取二手房源的介绍title)
                            string stringRegex01 = @"data-video=""false""\s+alt=""(?<title>.+?)""><span></span>(</div>)?<div";
                            Regex regex01 = new Regex(stringRegex01, RegexOptions.Singleline | RegexOptions.Multiline | RegexOptions.Compiled);
                            //将符合正则表达式提取一个match出来
                            match01 = regex01.Match(strFinalSourceCode);
                            //}));

                            //tasklist_regex.Add(Task.Run(() =>
                            //{

                            //正则表达式(获取二手房源的总价和单价)
                            string stringRegex02 = @"<div\s+class=""price\s+""><span\s+class=""total"">(?<totalPrice>.*?)</span><span\s+class=""unit""><span>万</span></span><div\s+class=""text""><div\s+class=""unitPrice""><span\s+class=""unitPriceValue"">(?<unitPriceValue>\d+?)<i>元/平米</i></span>";
                            Regex regex02 = new Regex(stringRegex02, RegexOptions.Singleline | RegexOptions.Multiline | RegexOptions.Compiled);
                            match02 = regex02.Match(strFinalSourceCode);
                            //}));

                            //tasklist_regex.Add(Task.Run(() =>
                            //{

                            //正则表达式(获取二手房源的基本属性)
                            string stringRegex03 = @"<li><span\s+class=""label"">(?<jbsxLeixing>.*?)</span>(?<jbsxValue>.*?)</li>";
                            Regex regex03 = new Regex(stringRegex03, RegexOptions.Singleline | RegexOptions.Multiline | RegexOptions.Compiled);
                            //将符合正则表达式match全部提取出来
                            matches03 = regex03.Matches(strFinalSourceCode);
                            //}));

                            //Task.WaitAll(tasklist_regex.ToArray());

                            List<Task> tasklist = new List<Task>();

                            //打印日志
                            tasklist.Add(Task.Run(() =>
                            {
                                textBox.AppendText("\r\n" + "第" + count.ToString() + "套房" + ":" + "\r\n");
                                textBox.AppendText(match01.Groups["title"].ToString() + "\r\n");
                                textBox.AppendText("总价：" + match02.Groups["totalPrice"].ToString() + "万元" + "\t" + "单价：" + match02.Groups["unitPriceValue"].ToString() + "元/平米" + "\r\n");
                                foreach (Match match03 in matches03)
                                {
                                    textBox.AppendText(match03.Groups["jbsxLeixing"].ToString() + ":" + match03.Groups["jbsxValue"].ToString() + "\r\n");
                                }
                                textBox.AppendText("Web-URL: " + final_URL + "\r\n");
                            }));
                            //写文件
                            tasklist.Add(Task.Run(() =>
                            {
                                writer.WriteLine();
                                writer.Write(match01.Groups["title"].ToString() + "," + match02.Groups["totalPrice"].ToString() + "," + match02.Groups["unitPriceValue"].ToString());
                                foreach (Match match03 in matches03)
                                {
                                    writer.Write("," + match03.Groups["jbsxValue"].ToString());
                                }
                                writer.Write("," + final_URL);
                            }));
                            //写数据库 
                            tasklist.Add(Task.Run(() =>
                            {
                                string tempstr = "";
                                foreach (Match match03 in matches03)
                                {
                                    tempstr += match03.Groups["jbsxValue"] + "￥";
                                }
                                string[] tempArray = tempstr.Split('￥');
                                string insert_sqlstr = "insert into " + GlobalData.taskArray[index, 1] + "(introduce,tatalPrice,unitPrice,houseType,louceng,jianzhuArea,Web_URL) values('" + match01.Groups["title"].ToString() + "','" + match02.Groups["totalPrice"].ToString() + "','" + match02.Groups["unitPriceValue"].ToString() + "','" + tempArray[0] + "','" + tempArray[1] + "','" + tempArray[2] + "','" + final_URL + "'); ";
                                MySqlCommand mySqlCommand_insert = new MySqlCommand(insert_sqlstr, mySqlConnection);
                                mySqlCommand_insert.ExecuteNonQuery();
                            }));

                            //TaskFactory taskFactory = new TaskFactory();  
                            //taskFactory.ContinueWhenAll(tasklist.ToArray(),t=> {            不能使用ContinueWhenAll
                            //    textBox.AppendText("该房源已成功采集并更新到数据库！"  + "\r\n");
                            //});

                            Task.WaitAll(tasklist.ToArray());                           //这里须要阻塞父线程
                            textBox.AppendText("该二手房信息已成功采集并更新到数据库！" + "\r\n");
                        }
                    }
                    tabPage.Text = "【" + GlobalData.taskArray[index, 1] + "】[已完成]";
                    GlobalData.taskArray[index, 8] = "3"; //表示该任务已经执行完毕
                    writer.Close();
                    mySqlConnection.Close();
                    MessageBox.Show("任务：【" + GlobalData.taskArray[index, 1] + "】 采集完毕！");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }

            ///租房采集模块
            else if (fanYuanLeiXing == 2)//采集租房信息
            {
                string createtable_sqlstr = @"CREATE TABLE `" + GlobalData.taskArray[index, 1] + @"` (
  `jieshao` varchar(255) DEFAULT NULL,
  `zujin` decimal(10,0) DEFAULT NULL,
  `mianji` varchar(64) DEFAULT NULL,
  `chaoxiang` varchar(64) DEFAULT NULL,
  `weihu` varchar(64) DEFAULT NULL,
  `ruzhu` varchar(64) DEFAULT NULL,
  `louceng` varchar(64) DEFAULT NULL,
  `dianti` varchar(64) DEFAULT NULL,
  `chewei` varchar(64) DEFAULT NULL,
  `yongshui` varchar(64) DEFAULT NULL,
  `yongdian` varchar(64) DEFAULT NULL,
  `ranqi` varchar(64) DEFAULT NULL,
  `cainuan` varchar(64) DEFAULT NULL,
  `zuqi` varchar(64) DEFAULT NULL,
  `kanfang` varchar(64) DEFAULT NULL,
  `Web_URL` varchar(128) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;";
                MySqlCommand mySqlCommand = new MySqlCommand(createtable_sqlstr, mySqlConnection);
                mySqlCommand.ExecuteNonQuery();

                textBox.AppendText("任务开始运行\r\n正在初始化租房模块，请稍等……\r\n租房模块初始化成功，开始数据采集……\r\n\r\n正在下载并分析网址：" + startURL + "\r\n\r\n");
                try
                {
                    StreamWriter writer = new StreamWriter(savePath, true, Encoding.UTF8);
                    writer.WriteLine("租房介绍,租金（元/月）,面积, 朝向, 维护, 入住, 楼层, 电梯, 车位, 用水, 用电, 燃气, 采暖, 租期,看房, Web-URL");

                    for (int pg = 1; pg <= pageNum; pg++)
                    {
                        startURL = startURL_copy + "/pg" + pg.ToString() + "/#contentList";
                        //textBox.AppendText(startURL +"\r\n");

                        strListSourceCode = GetSourceCode.DownloadCode(startURL);

                        //抓取租房列表地址的正则表达式
                        string stringRegex = @"<a\s+class=""twoline""\s+target=""_blank""\s+href=""/(?<zufangURL>.+?)"">";
                        Regex regex = new Regex(stringRegex, RegexOptions.Singleline | RegexOptions.Multiline | RegexOptions.Compiled);

                        //将符合正则表达式match全部提取出来
                        var matches = regex.Matches(strListSourceCode);

                        foreach (Match match in matches)
                        {
                            count++;

                            final_URL = URL_city + match.Groups["zufangURL"].ToString();

                            strFinalSourceCode = GetSourceCode.DownloadCode(final_URL);

                            //正则表达式(获取租房房源的介绍title)
                            string stringRegex01 = @"<!--\s+房源标题\s+-->[\s\S]+?<p\s+class=""content__title"">(?<zuFangTitle>.+?)</p>";
                            Regex regex01 = new Regex(stringRegex01, RegexOptions.Singleline | RegexOptions.Multiline | RegexOptions.Compiled);

                            //正则表达式(获取租房房源的租金及支付方式)
                            string stringRegex02 = @"<!--\s+租金及支付方式\s+-->[\s\S]+?<div\s+class=""content__aside--title"">[\s\S]+?<span>(?<zuJinPrice>\d+?)</span>(?<zuJinUnit>.*?)\s+<div";
                            Regex regex02 = new Regex(stringRegex02, RegexOptions.Singleline | RegexOptions.Multiline | RegexOptions.Compiled);

                            //正则表达式(获取租房房源的基本信息)
                            string stringRegex03 = @"\s<li\s+class=""fl\s+oneline"">(?<zuFang_jbxx>\w{2,4}：.*?)</li>";
                            Regex regex03 = new Regex(stringRegex03, RegexOptions.Singleline | RegexOptions.Multiline | RegexOptions.Compiled);


                            //将符合正则表达式提取一个match出来
                            var match01 = regex01.Match(strFinalSourceCode);
                            var match02 = regex02.Match(strFinalSourceCode);
                            //将符合正则表达式match全部提取出来
                            var matches03 = regex03.Matches(strFinalSourceCode);

                            //List<Task> tasklist = new List<Task>();

                            //打印日志
                            //tasklist.Add(Task.Run(() =>
                            //{
                                textBox.AppendText("\r\n" + "第" + count.ToString() + "套房" + ":" + "\r\n");
                                textBox.AppendText(match01.Groups["zuFangTitle"].ToString() + "\r\n");
                                textBox.AppendText("租金：" + match02.Groups["zuJinPrice"].ToString() + match02.Groups["zuJinUnit"].ToString() + "\r\n");
                                foreach (Match match03 in matches03)
                                {
                                    textBox.AppendText(match03.Groups["zuFang_jbxx"].ToString() + "\r\n");
                                }
                                textBox.AppendText("Web-URL: " + final_URL + "\r\n");
                            //}));

                            //写文件
                            //tasklist.Add(Task.Run(() =>
                            //{
                                writer.WriteLine();
                                writer.Write(match01.Groups["zuFangTitle"].ToString() + "," + match02.Groups["zuJinPrice"].ToString());
                                foreach (Match match03 in matches03)
                                {
                                    writer.Write("," + match03.Groups["zuFang_jbxx"].ToString());
                                }
                                writer.Write("," + final_URL);
                            //}));

                            //写数据库
                            //tasklist.Add(Task.Run(() =>
                            //{
                            string insert_sqlstr = "insert into " + GlobalData.taskArray[index, 1] + " values('" + match01.Groups["zuFangTitle"].ToString() + "','" + match02.Groups["zuJinPrice"].ToString();

                            foreach (Match match03 in matches03)
                            {
                                insert_sqlstr += ("','" + match03.Groups["zuFang_jbxx"]);
                            }
                            insert_sqlstr += "','" + final_URL + "');";
                            //textBox.AppendText("\r\n" + insert_sqlstr + "\r\n");
                            MySqlCommand mySqlCommand_insert = new MySqlCommand(insert_sqlstr, mySqlConnection);
                            mySqlCommand_insert.ExecuteNonQuery();
                            //}));

                            //Task.WaitAll(tasklist.ToArray());
                            textBox.AppendText("该租房信息已成功采集并更新到数据库！" + "\r\n");
                        }
                    }
                    tabPage.Text = "【" + GlobalData.taskArray[index, 1] + "】[已完成]";
                    GlobalData.taskArray[index, 8] = "3"; //表示该任务已经执行完毕
                    writer.Close();
                    mySqlConnection.Close();
                    MessageBox.Show("任务：【" + GlobalData.taskArray[index, 1] + "】 采集完毕！");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }

            ///新房采集模块
            else if (fanYuanLeiXing == 3)
            {
                string createtable_sqlstr = @"CREATE TABLE `"+ GlobalData.taskArray[index, 1] + @"` (
  `loupanname` varchar(255) DEFAULT NULL,
  `danjia` varchar(64) DEFAULT NULL,
  `zongjia` varchar(64) DEFAULT NULL,
  `dizhi` varchar(64) DEFAULT NULL,
  `shijian` varchar(64) DEFAULT NULL,
  `huxin` varchar(64) DEFAULT NULL,
  `Web_URL` varchar(64) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;";
                MySqlCommand mySqlCommand = new MySqlCommand(createtable_sqlstr, mySqlConnection);
                mySqlCommand.ExecuteNonQuery();
                textBox.AppendText("任务开始运行\r\n正在初始化新房模块，请稍等……\r\n新房模块初始化成功，开始数据采集……\r\n\r\n正在下载并分析网址：" + startURL + "\r\n\r\n");
                try
                {
                    StreamWriter writer = new StreamWriter(savePath, true, Encoding.UTF8);
                    writer.WriteLine("楼盘名称,参考均单价（元/平）,参考均总价（万/套）, 项目地址, 最新开盘时间, 楼盘户型, Web-URL");

                    for (int pg = 1; pg <= pageNum; pg++)
                    {
                        startURL = startURL_copy + "loupan/" + "pg" + pg.ToString() + "/#contentList";

                        strListSourceCode = GetSourceCode.DownloadCode(startURL);

                        //抓取租房列表地址的正则表达式
                        string stringRegex = @"<div\s+class=""resblock-name"">\s+<a\s+href=""/loupan/(?<louPanURL>.+?)""\s+class=""name\s+""\s+target";
                        Regex regex = new Regex(stringRegex, RegexOptions.Singleline | RegexOptions.Multiline | RegexOptions.Compiled);

                        //将符合正则表达式match全部提取出来
                        var matches = regex.Matches(strListSourceCode);

                        //将符合正则表达式提取一个match出来

                        foreach (Match match in matches)
                        {
                            count++;
                            //textBox.AppendText(match.Groups["louPanURL"].ToString() + "\r\n");

                            final_URL = URL_city + "loupan/" + match.Groups["louPanURL"].ToString();

                            strFinalSourceCode = GetSourceCode.DownloadCode(final_URL);

                            //正则表达式(获取新房的介绍title)
                            string stringRegex01 = "project_name=\".*?\">(?<louPanTitle>.+?)</h2>";
                            Regex regex01 = new Regex(stringRegex01, RegexOptions.Singleline | RegexOptions.Multiline | RegexOptions.Compiled);

                            //正则表达式(获取租房房源的租金及支付方式)
                            string stringRegex02 = @"class=""price-number"">(?<unitPrice>.+?)</span><span\s+class=""price-unit"">元/平\(单价\)\s+</span><span\s+class=""price-number""\s+style=""margin-left:16px;"">(?<totalPrice>.+?)</span>";
                            Regex regex02 = new Regex(stringRegex02, RegexOptions.Singleline | RegexOptions.Multiline | RegexOptions.Compiled);

                            ////正则表达式(获取租房房源的基本信息)
                            string stringRegex03 = @"<span\s+class=""title"">项目地址</span><span\s+class=""content"">(?<address>.+?)</span>";
                            Regex regex_03 = new Regex(stringRegex03, RegexOptions.Singleline | RegexOptions.Multiline | RegexOptions.Compiled);

                            string stringRegex04 = @"<span\s+class=""title"">最新开盘</span>\s+<span\s+class=""content"">(?<open_time>.+?)</span>";
                            Regex regex_04 = new Regex(stringRegex04, RegexOptions.Singleline | RegexOptions.Multiline | RegexOptions.Compiled);

                            string stringRegex05 = @"class=""house-type-item"">(?<house_type>.+?)\)";
                            Regex regex_05 = new Regex(stringRegex05, RegexOptions.Singleline | RegexOptions.Multiline | RegexOptions.Compiled);

                            //将符合正则表达式提取一个match出来
                            var match01 = regex01.Match(strFinalSourceCode);
                            var match02 = regex02.Match(strFinalSourceCode);
                            var match03 = regex_03.Match(strFinalSourceCode);
                            var match04 = regex_04.Match(strFinalSourceCode);
                            ////将符合正则表达式match全部提取出来
                            var matches_type = regex_05.Matches(strFinalSourceCode);


                            textBox.AppendText("\r\n\r\n" + "楼盘" + count.ToString() + ":" + "\r\n");
                            textBox.AppendText("楼盘名称：" + match01.Groups["louPanTitle"].ToString() + "\r\n");
                            textBox.AppendText("参考均价：" + match02.Groups["unitPrice"].ToString() + "元/平(单价)" + "\t" + match02.Groups["totalPrice"].ToString() + "万/套(总价)" + "\r\n");
                            textBox.AppendText("项目地址：" + match03.Groups["address"].ToString() + "\r\n");
                            textBox.AppendText("最新开盘：" + match04.Groups["open_time"].ToString() + "\r\n");
                            textBox.AppendText("楼盘户型：");
                            int m = 1;
                            foreach (Match match0 in matches_type)
                            {
                                if (m <= matches_type.Count / 2)
                                {
                                    textBox.AppendText(match0.Groups["house_type"].ToString() + ")\t");
                                    m++;
                                }
                            }
                            textBox.AppendText("\r\nWeb-URL: " + final_URL);

                            writer.WriteLine();
                            writer.Write(match01.Groups["louPanTitle"].ToString() + "," + match02.Groups["unitPrice"].ToString() + "," + match02.Groups["totalPrice"].ToString() + "," + match03.Groups["address"].ToString() + "," + match04.Groups["open_time"].ToString() + ",");
                            foreach (Match match0 in matches_type)
                            {
                                writer.Write(match0.Groups["house_type"].ToString() + "   ");
                            }
                            writer.Write("," + final_URL);



                            string tempstr = "";
                            foreach (Match match0 in matches_type)
                            {
                                tempstr += match0.Groups["house_type"] + "  ";
                            }
                            string insert_sqlstr = "insert into " + GlobalData.taskArray[index, 1] + " values('" + match01.Groups["louPanTitle"].ToString() + "','" + match02.Groups["unitPrice"].ToString() + "','" + match02.Groups["totalPrice"].ToString() + "','" + match03.Groups["address"].ToString() + "','" + match04.Groups["open_time"].ToString() + "','" + tempstr + "','" + final_URL + "'); ";
                            MySqlCommand mySqlCommand_insert = new MySqlCommand(insert_sqlstr, mySqlConnection);
                            mySqlCommand_insert.ExecuteNonQuery();
                        }
                    }
                    tabPage.Text = "【" + GlobalData.taskArray[index, 1] + "】[已完成]";
                    GlobalData.taskArray[index, 8] = "3"; //表示该任务已经执行完毕
                    MessageBox.Show("任务：【" + GlobalData.taskArray[index, 1] + "】 采集完毕！");
                    writer.Close();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
        }

        private void childForm_running_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }
    }
}
