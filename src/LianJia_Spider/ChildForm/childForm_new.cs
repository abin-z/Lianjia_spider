using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LianJia_Spider
{
    //新建任务窗体
    public partial class childForm_new : Form
    {
        public childForm_new()
        {
            InitializeComponent();
        }

        public class TitleChangedEventArgs : EventArgs // 事件参数类
        {
            private string title = "";
            public string Title
            {
                get { return title; }
                set { title = value; }
            }
        }
        // 声明委托
        public delegate void TitleChangedEventHandler(object sender, TitleChangedEventArgs e);
        // 定义事件
        public event TitleChangedEventHandler TitleChanged;


        // 触发事件的方法
        protected virtual void OnTitleChanged(TitleChangedEventArgs e)
        {
            TitleChanged?.Invoke(this, e);
        }


        private string taskname;
        private string shengfen;
        private string city;
        private string URL_city;
        private string URL_type;
        private string pageNum;
        int n = 0;
        private string str;
        int fanYuanLeiXing;


        private void comboBox_province_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_province.SelectedIndex == 0)
            {
                List<string> listCB01_0 = new List<string>();
                listCB01_0.AddRange(new string[] { "安庆", "滁州", "合肥", "马鞍山", "芜湖" });
                comboBox_city.DataSource = listCB01_0;
            }
            else if (comboBox_province.SelectedIndex == 1)
            {
                List<string> listCB01_1 = new List<string>();
                listCB01_1.AddRange(new string[] { "北京" });
                comboBox_city.DataSource = listCB01_1;
            }

            else if (comboBox_province.SelectedIndex == 2)
            {
                List<string> listCB01_2 = new List<string>();
                listCB01_2.AddRange(new string[] { "重庆" });
                comboBox_city.DataSource = listCB01_2;
            }
            else if (comboBox_province.SelectedIndex == 3)
            {
                List<string> listCB01_3 = new List<string>();
                listCB01_3.AddRange(new string[] { "福州", "泉州", "厦门", "漳州" });
                comboBox_city.DataSource = listCB01_3;
            }
            else if (comboBox_province.SelectedIndex == 4)
            {
                List<string> listCB01_4 = new List<string>();
                listCB01_4.AddRange(new string[] { "东莞", "佛山", "广州", "惠州", "江门", "清远", "深圳", "珠海", "湛江", "中山" });
                comboBox_city.DataSource = listCB01_4;
            }
            else if (comboBox_province.SelectedIndex == 5)
            {
                List<string> listCB01_5 = new List<string>();
                listCB01_5.AddRange(new string[] { "贵阳" });
                comboBox_city.DataSource = listCB01_5;
            }
            else if (comboBox_province.SelectedIndex == 6)
            {
                List<string> listCB01_6 = new List<string>();
                listCB01_6.AddRange(new string[] { "北海", "防城港", "桂林", "柳州", "南宁" });
                comboBox_city.DataSource = listCB01_6;
            }
            else if (comboBox_province.SelectedIndex == 7)
            {
                List<string> listCB01_7 = new List<string>();
                listCB01_7.AddRange(new string[] { "兰州" });
                comboBox_city.DataSource = listCB01_7;
            }
            else if (comboBox_province.SelectedIndex == 8)
            {
                List<string> listCB01_2 = new List<string>();
                listCB01_2.AddRange(new string[] { "鄂州", "黄石", "武汉", "襄阳", "宜昌" });
                comboBox_city.DataSource = listCB01_2;
            }
            else if (comboBox_province.SelectedIndex == 9)
            {
                List<string> listCB01_2 = new List<string>();
                listCB01_2.AddRange(new string[] { "长沙", "常德", "岳阳", "株洲" });
                comboBox_city.DataSource = listCB01_2;
            }
            else if (comboBox_province.SelectedIndex == 10)
            {
                List<string> listCB01_2 = new List<string>();
                listCB01_2.AddRange(new string[] { "保定", "廊坊", "秦皇岛", "石家庄", "唐山", "张家口" });
                comboBox_city.DataSource = listCB01_2;
            }
            else if (comboBox_province.SelectedIndex == 11)
            {
                List<string> listCB01_2 = new List<string>();
                listCB01_2.AddRange(new string[] { "保亭", "澄迈", "儋州", "海口", "临高", "乐东", "陵水", "琼海", "三亚", "五指山", "文昌", "万宁" });
                comboBox_city.DataSource = listCB01_2;
            }
            else if (comboBox_province.SelectedIndex == 12)
            {
                List<string> listCB01_2 = new List<string>();
                listCB01_2.AddRange(new string[] { "开封", "洛阳", "三门峡", "新乡", "许昌", "郑州", "周口", "驻马店" });
                comboBox_city.DataSource = listCB01_2;
            }
            else if (comboBox_province.SelectedIndex == 13)
            {
                List<string> listCB01_2 = new List<string>();
                listCB01_2.AddRange(new string[] { "哈尔滨" });
                comboBox_city.DataSource = listCB01_2;
            }
            else if (comboBox_province.SelectedIndex == 14)
            {
                List<string> listCB01_2 = new List<string>();
                listCB01_2.AddRange(new string[] { "常州", "海门", "淮安", "江阴", "昆山", "南京", "南通", "苏州", "无锡", "徐州", "盐城", "镇江" });
                comboBox_city.DataSource = listCB01_2;
            }
            else if (comboBox_province.SelectedIndex == 15)
            {
                List<string> listCB01_2 = new List<string>();
                listCB01_2.AddRange(new string[] { "长春", "吉林" });
                comboBox_city.DataSource = listCB01_2;
            }
            else if (comboBox_province.SelectedIndex == 16)
            {
                List<string> listCB01_2 = new List<string>();
                listCB01_2.AddRange(new string[] { "赣州", "九江", "吉安", "南昌", "上饶" });
                comboBox_city.DataSource = listCB01_2;
            }
            else if (comboBox_province.SelectedIndex == 17)
            {
                List<string> listCB01_2 = new List<string>();
                listCB01_2.AddRange(new string[] { "大连", "丹东", "沈阳" });
                comboBox_city.DataSource = listCB01_2;
            }
            else if (comboBox_province.SelectedIndex == 18)
            {
                List<string> listCB01_2 = new List<string>();
                listCB01_2.AddRange(new string[] { "包头", "赤峰", "呼和浩特" });
                comboBox_city.DataSource = listCB01_2;
            }
            else if (comboBox_province.SelectedIndex == 19)
            {
                List<string> listCB01_2 = new List<string>();
                listCB01_2.AddRange(new string[] { "银川" });
                comboBox_city.DataSource = listCB01_2;
            }
            else if (comboBox_province.SelectedIndex == 20)
            {
                List<string> listCB01_2 = new List<string>();
                listCB01_2.AddRange(new string[] { "上海" });
                comboBox_city.DataSource = listCB01_2;
            }
            else if (comboBox_province.SelectedIndex == 21)
            {
                List<string> listCB01_2 = new List<string>();
                listCB01_2.AddRange(new string[] { "巴中", "成都", "德阳", "达州", "乐山", "凉山", "绵阳", "眉山", "南充", "遂宁", "宜宾" });
                comboBox_city.DataSource = listCB01_2;
            }
            else if (comboBox_province.SelectedIndex == 22)
            {
                List<string> listCB01_2 = new List<string>();
                listCB01_2.AddRange(new string[] { "菏泽", "济南", "济宁", "临沂", "青岛", "泰安", "潍坊", "威海", "烟台", "淄博" });
                comboBox_city.DataSource = listCB01_2;
            }
            else if (comboBox_province.SelectedIndex == 23)
            {
                List<string> listCB01_2 = new List<string>();
                listCB01_2.AddRange(new string[] { "宝鸡", "汉中", "西安", "咸阳" });
                comboBox_city.DataSource = listCB01_2;
            }
            else if (comboBox_province.SelectedIndex == 24)
            {
                List<string> listCB01_2 = new List<string>();
                listCB01_2.AddRange(new string[] { "晋中", "太原" });
                comboBox_city.DataSource = listCB01_2;
            }
            else if (comboBox_province.SelectedIndex == 25)
            {
                List<string> listCB01_2 = new List<string>();
                listCB01_2.AddRange(new string[] { "天津" });
                comboBox_city.DataSource = listCB01_2;
            }
            else if (comboBox_province.SelectedIndex == 26)
            {
                List<string> listCB01_2 = new List<string>();
                listCB01_2.AddRange(new string[] { "大理", "昆明", "西双版纳" });
                comboBox_city.DataSource = listCB01_2;
            }
            else if (comboBox_province.SelectedIndex == 27)
            {
                List<string> listCB01_2 = new List<string>();
                listCB01_2.AddRange(new string[] { "杭州", "湖州", "嘉兴", "金华", "宁波", "衢州", "绍兴", "台州", "温州", "义乌" });
                comboBox_city.DataSource = listCB01_2;
            }
            shengfen = comboBox_province.Text;
        }

        private void comboBox_city_SelectedIndexChanged(object sender, EventArgs e)
        {
            city = comboBox_city.Text;
        }

        private void button_done_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(city))
            {
                MessageBox.Show("请在本选项卡中选择相应的城市", "出错啦", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            string rootURL = "https://www.lianjia.com/city/";
            string rootSourceCode = GetSourceCode.DownloadCode(rootURL);
            string stringRegex = @"<li><a\s+href=""(?<shiURL>.*?)"">(?<shiName>\w{2,4})</a></li>$";
            Regex regex = new Regex(stringRegex, RegexOptions.Singleline | RegexOptions.Multiline | RegexOptions.Compiled);

            //将符合正则表达式match全部提取出来
            var matches = regex.Matches(rootSourceCode);

            //将符合正则表达式提取一个match出来
            //var match = regex.Match(stringWebSource);

            foreach (Match match in matches)
            {
                if (comboBox_city.Text == match.Groups["shiName"].ToString())
                {
                    //获取城市的URL
                    URL_city = match.Groups["shiURL"].ToString();
                    //MessageBox.Show(URL_city);
                    break;
                }
            }
            if (shengfen != city)
            {
                label_selectedCity.Text = shengfen + city;
            }
            else
            {
                label_selectedCity.Text = city;
            }
        }



        /// <summary>
        /// 二手房
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_secondHand_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(label_selectedCity.Text) || label_selectedCity.Text == "*无")
            {
                MessageBox.Show("请在左边选项卡中选择相应的城市", "出错啦", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string getTypeSourceCode = GetSourceCode.DownloadCode(URL_city);
            string stringRegex = @"<li\s+class=""CLICKDATA""data-click-evtid=""20599""data-click-event=""WebClick""data-action=""click_name=(?<leiXingName>\w+?)&click_location=\d""><a\s+class=""""\s+href=""(?<leixingURL>.+?)""\s+>\w+?</a></li>";
            Regex regex = new Regex(stringRegex, RegexOptions.Singleline | RegexOptions.Multiline | RegexOptions.Compiled);
            var matches = regex.Matches(getTypeSourceCode);
            bool Nodata = true;
            foreach (Match match in matches)
            {
                if ("二手房" == match.Groups["leiXingName"].ToString())
                {
                    URL_type = match.Groups["leixingURL"].ToString();
                    //MessageBox.Show(URL_type);
                    fanYuanLeiXing = 1;//fanYuanLeiXing = 1  表示房源类型为二手房
                    label_selectedType.Text = "二手房";
                    Nodata = false;
                    break;
                }
            }
            if (Nodata)
            {
                MessageBox.Show("很抱歉！" + label_selectedCity.Text + " 没有二手房的数据");
                return;
            }
        }


        /// <summary>
        /// 租房
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_rental_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(label_selectedCity.Text) || label_selectedCity.Text == "*无")
            {
                MessageBox.Show("请在左边选项卡中选择相应的城市", "出错啦", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string getTypeSourceCode = GetSourceCode.DownloadCode(URL_city);
            string stringRegex = @"<li\s+class=""CLICKDATA""data-click-evtid=""20599""data-click-event=""WebClick""data-action=""click_name=(?<leiXingName>\w+?)&click_location=\d""><a\s+class=""""\s+href=""(?<leixingURL>.+?)""\s+>\w+?</a></li>";
            Regex regex = new Regex(stringRegex, RegexOptions.Singleline | RegexOptions.Multiline | RegexOptions.Compiled);
            var matches = regex.Matches(getTypeSourceCode);
            bool Nodata = true;
            foreach (Match match in matches)
            {
                if ("租房" == match.Groups["leiXingName"].ToString())
                {
                    URL_type = match.Groups["leixingURL"].ToString();
                    //MessageBox.Show(URL_type);
                    fanYuanLeiXing = 2;//fanYuanLeiXing = 2  表示房源类型为租房
                    label_selectedType.Text = "租房";
                    Nodata = false;
                    break;
                }
            }
            if (Nodata)
            {
                MessageBox.Show("很抱歉！" + label_selectedCity.Text + " 没有租房的数据");
                return;
            }
        }


        /// <summary>
        /// 新房
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_newHouse_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(label_selectedCity.Text) || label_selectedCity.Text == "*无")
            {
                MessageBox.Show("请在左边选项卡中选择相应的城市", "出错啦", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string getTypeSourceCode = GetSourceCode.DownloadCode(URL_city);
            string stringRegex = @"<li\s+class=""CLICKDATA""data-click-evtid=""20599""data-click-event=""WebClick""data-action=""click_name=(?<leiXingName>\w+?)&click_location=\d""><a\s+class=""""\s+href=""(?<leixingURL>.+?)""\s+>\w+?</a></li>";
            Regex regex = new Regex(stringRegex, RegexOptions.Singleline | RegexOptions.Multiline | RegexOptions.Compiled);
            var matches = regex.Matches(getTypeSourceCode);

            bool Nodata = true;
            foreach (Match match in matches)
            {
                if ("新房" == match.Groups["leiXingName"].ToString())
                {
                    URL_type = match.Groups["leixingURL"].ToString();
                    //MessageBox.Show(URL_type);
                    fanYuanLeiXing = 3;//fanYuanLeiXing = 3  表示房源类型为新房
                    label_selectedType.Text = "新房";
                    Nodata = false;
                    break;
                }
            }
            if (Nodata)
            {
                MessageBox.Show("很抱歉！" + label_selectedCity.Text + " 没有新房的数据");
                return;
            }
        }

        private void button_send_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(label_selectedCity.Text) || label_selectedCity.Text == "*无")
            {
                MessageBox.Show("请选择相应的城市", "出错啦", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (String.IsNullOrEmpty(label_selectedType.Text) || label_selectedType.Text == "*无")
            {
                MessageBox.Show("请选择相应的房源类型", "出错啦", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (String.IsNullOrEmpty(textBox_taskName.Text))
            {
                MessageBox.Show("请输入任务名称！", "出错啦", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            pageNum = numericUpDown_pageNum.Text.ToString();
            taskname = textBox_taskName.Text;
            string taskAll = pageNum + "!" + taskname + "!" + label_selectedCity.Text + "!" + URL_city + "!" + label_selectedType.Text + "!" + URL_type + "!" + fanYuanLeiXing;


            string[] city = new string[2];
            Match match = Regex.Match(taskAll, @"https://(?<city>\w+?)\.");
            for (int i = 0; i < 3; i++)
            {
                if (match.Success)
                {
                    //Console.WriteLine(match.Value);
                    city[i] = match.Value;
                    match = match.NextMatch();
                }
            }
            if (city[0] != city[1])
            {
                MessageBox.Show("地址不匹配！请按顺序操作!(步骤1->步骤2->步骤3)", "出错啦", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (n == 0)
            {
                str = taskAll;
                TitleChangedEventArgs e1 = new TitleChangedEventArgs();
                e1.Title = taskAll;
                OnTitleChanged(e1);// 触发事件

            }
            if (n == 1)
            {
                if (str == taskAll)
                {
                    MessageBox.Show("该任务已创建，不能重复创建任务");
                }
                else
                {
                    str = taskAll;
                    TitleChangedEventArgs e1 = new TitleChangedEventArgs();
                    e1.Title = taskAll;
                    OnTitleChanged(e1);// 触发事件
                }
            }
            n = 1;
            //TitleChangedEventArgs e1 = new TitleChangedEventArgs();
            //e1.Title = taskAll;
            //OnTitleChanged(e1);// 触发事件

        }
    }
}
