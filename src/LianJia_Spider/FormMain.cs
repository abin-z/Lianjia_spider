using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LianJia_Spider
{
    //主窗体
    public partial class Form_Main : Form
    {
        childForm_running childForm_Running;
        childForm_new childForm_New;
        childForm_completed childForm_Completed;
        childForm_settings childForm_Settings;
        childForm_about childForm_About;
        childForm_home childForm_Home = new childForm_home();


        void f2_TitleChanged(object sender, childForm_new.TitleChangedEventArgs e)
        {
            if (childForm_Running != null)
            {
                childForm_Running.setText(e.Title);
            }
        }

        void f3_Disposed(object sender, EventArgs e)
        {
            childForm_Running = null;
        }



        int panelWidth;
        bool isCollapsed;


        bool childForm_new_on = false;
        bool childForm_running_on = false;
        bool childForm_completed_on = false;
        bool childForm_settings_on = false;
        bool childForm_about_on = false;

        public Form_Main()
        {
            InitializeComponent();
            timerTime.Start();
            panelWidth = panel_menu.Width;
            isCollapsed = false;
            openChildForm(childForm_Home);
        }

        [DllImport("user32.dll")]//拖动无窗体的控件
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;

        private void panel_Bar_MouseDown(object sender, MouseEventArgs e)
        {
            //拖动窗体
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_close_MouseEnter(object sender, EventArgs e)
        {
            btn_close.BackColor = Color.Red;
        }

        private void btn_close_MouseLeave(object sender, EventArgs e)
        {
            btn_close.BackColor = Color.FromArgb(59, 114, 194);
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btn_max_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }
        private void btn_fold_Click(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panel_menu.Width = panel_menu.Width + 149;
                if (panel_menu.Width >= panelWidth)
                {
                    isCollapsed = false;
                }
            }
            else
            {
                panel_menu.Width = panel_menu.Width - 149;
                if (panel_menu.Width <= 66)
                {
                    isCollapsed = true;
                    this.Refresh();
                }
            }
        }

        private void Move_panel_side(Control btn)
        {
            panel_side.Top = btn.Top;
            panel_side.Height = btn.Height;
        }

        private void openChildForm(Form frm)
        {
            //关闭原有的子窗体
            foreach (Control item in this.panel_childForm.Controls)
            {
                if (item is Form)
                {
                    ((Form)item).Hide();
                }
            }
            //设置子窗体为非顶级控件
            frm.TopLevel = false;
            //指定当前子窗体显示的容器
            frm.Parent = this.panel_childForm;
            //设置子窗口的样式，没有上面的标题栏
            frm.FormBorderStyle = FormBorderStyle.None;
            //保证子窗体会随着容器变化
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            Move_panel_side(btn_home);
            openChildForm(childForm_Home);
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            Move_panel_side(btn_new);
            if (!childForm_new_on)
            {
                childForm_New = new childForm_new();
                childForm_new_on = true;
                childForm_New.TitleChanged += f2_TitleChanged;//???????????
            }
            openChildForm(childForm_New);



            if (!childForm_running_on)
            {
                childForm_Running = new childForm_running();
                childForm_running_on = true;
            }
        }

        private void btn_running_Click(object sender, EventArgs e)
        {
            Move_panel_side(btn_running);
            if (!childForm_running_on)
            {
                childForm_Running = new childForm_running();
                childForm_running_on = true;
            }
            openChildForm(childForm_Running);
            childForm_Running.Disposed += f3_Disposed;
        }

        private void btn_completed_Click(object sender, EventArgs e)
        {
            Move_panel_side(btn_completed);
            if (!childForm_completed_on)
            {
                childForm_Completed = new childForm_completed();
                childForm_completed_on = true;
            }
            openChildForm(childForm_Completed);
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            Move_panel_side(btn_settings);
            if (!childForm_settings_on)
            {
                childForm_Settings = new childForm_settings();
                childForm_settings_on = true;
            }
            openChildForm(childForm_Settings);
        }

        private void btn_about_Click(object sender, EventArgs e)
        {
            Move_panel_side(btn_about);
            if (!childForm_about_on)
            {
                childForm_About = new childForm_about();
                childForm_about_on = true;
            }

            openChildForm(childForm_About);
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = System.DateTime.Now;
            label_time.Text = dateTime.ToString("HH:mm:ss");
        }
    }
}
