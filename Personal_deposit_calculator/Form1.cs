using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_deposit_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 币种
        String[] bi_zhong = { "人民币", "美元", "港币", "欧元", "英镑", "澳大利亚元", "日元", "加拿大元", "瑞士法郎", "新加坡元 " };

        // 存款期限
        // 整存整取
        String[] zheng_zheng = { "一个月", "三个月", "六个月", "一年", "二年", "三年", "五年" };

        // 零存整取
        String[] ling_zheng = { "一年", "三年", "五年" };

        // 存本取息
        String[] cun_ben = { "一年", "三年", "五年" };
        String[] zhi_qu = { "一个月", "三个月", "六个月" };

        // 整存零取
        String[] zheng_ling = { "一年", "三年", "五年" };

        // 定活两便
        //String[] 

        // 通知存款
        String[] tong_zhi = { "一天", "七天" };

        // 教育储蓄
        String[] jiao_yu = { "一年", "三年", "六年" };

        
        private void Form1_Load(object sender, EventArgs e)
        {
            this.comboBox1.SelectedIndex = 0;
           
        }

        // 1.存款类型 事件
        private void ComboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            int cun_kuan_index = comboBox1.SelectedIndex;

            // 全部控件初始化可见
            foreach (Control x in this.tableLayoutPanel1.Controls)
                x.Visible = true;
            label15.Hide();
            textBox7.Hide();
            foreach (Control x in this.tableLayoutPanel2.Controls)
                if(x.GetType() == typeof(TextBox))
                x.Text = "";

            //请选择
            if (cun_kuan_index == 0)
            {
                // 币种
                comboBox2.Items.Clear();
                comboBox2.SelectedIndex = -1;

                // 存款期限
                comboBox3.Items.Clear();
                comboBox3.SelectedIndex = -1;

                //初始存入日期
                dateTimePicker1.Value = DateTime.Today;

                //支取频次
                comboBox4.Items.Clear();
                comboBox4.SelectedIndex = -1;

                //初始存款金额
                textBox1.Text = "";

                //年利率
                textBox2.Text = "";

                //月存入金额
                textBox3.Text = "";

                //提取日期
                dateTimePicker2.Value = DateTime.Today.AddYears(1);

            }

            // 活期初始化
            if (cun_kuan_index==1)
            {
                // 币种
                comboBox2.Items.Clear();
                foreach (var x in bi_zhong)
                    comboBox2.Items.Add(x);
                comboBox2.SelectedIndex = 0;

                // 存款期限
                comboBox3.Visible = false;

                //初始存入日期
                dateTimePicker1.Value = DateTime.Today;

                //支取频次
                comboBox4.Visible = false;

                //初始存款金额
                textBox1.Text = "";

                //年利率
                textBox2.Text = "0.3";

                //月存入金额
                textBox3.Visible = false;

                //提取日期
                dateTimePicker2.Value = DateTime.Today.AddYears(1);

            }

            //整存整取
            if (cun_kuan_index == 2)
            {
                // 币种
                comboBox2.Items.Clear();
                foreach (var x in bi_zhong)
                    comboBox2.Items.Add(x);
                comboBox2.SelectedIndex = 0;

                // 存款期限
                comboBox3.Items.Clear();
                foreach (var x in zheng_zheng)
                {
                    if(x!="一个月")
                    comboBox3.Items.Add(x);

                }
                comboBox3.SelectedIndex = 0;
                //初始存入日期
                dateTimePicker1.Visible = false;

                //支取频次
                comboBox4.Visible = false;

                //初始存款金额
                textBox1.Text = "";

                //年利率
                textBox2.Text = "1.35";

                //月存入金额
                textBox3.Visible = false;

                //提取日期
                dateTimePicker2.Visible = false;

            }

            //零存整取
            if (cun_kuan_index == 3)
            {
                // 币种
                comboBox2.Items.Clear();
                //foreach (var x in bi_zhong)
                comboBox2.Items.Add("人民币");
                comboBox2.SelectedIndex = 0;

                // 存款期限
                comboBox3.Items.Clear();
                foreach (var x in ling_zheng)
                {
                    //if (x != "一个月")
                        comboBox3.Items.Add(x);

                }
                comboBox3.SelectedIndex = 0;

                //初始存入日期
                dateTimePicker1.Visible = false;

                //支取频次
                comboBox4.Visible = false;

                //初始存款金额
                textBox1.Text = "";

                //年利率
                textBox2.Text = "1.35";

                //月存入金额
                textBox3.Text = "";

                //textBox2.Visible = false;

                //提取日期
                dateTimePicker2.Visible = false;

            }

            //存本取息
            if (cun_kuan_index == 4)
            {
                // 币种
                comboBox2.Items.Clear();
                comboBox2.Items.Add("人民币");
                comboBox2.SelectedIndex = 0;

                // 存款期限
                comboBox3.Items.Clear();
                foreach (var x in cun_ben)
                {
                    //if (x != "一个月")
                        comboBox3.Items.Add(x);

                }
                comboBox3.SelectedIndex = 0;

                //初始存入日期
                dateTimePicker1.Visible = false;

                //支取频次
                comboBox4.Items.Clear();
                foreach (var x in zhi_qu)
                {
                    //if (x != "一个月")
                    comboBox4.Items.Add(x);

                }
                comboBox4.SelectedIndex = 0;

                //comboBox4.Visible = false;


                //初始存款金额
                textBox1.Text = "";

                //年利率
                textBox2.Text = "1.35";

                //月存入金额
                textBox3.Visible = false;

                //textBox2.Visible = false;

                //提取日期
                dateTimePicker2.Visible = false;

                //每次支取金额
                label15.Visible = true;
                textBox7.Visible = true;

            }

            //整存零取
            if (cun_kuan_index == 5)
            {
                // 币种
                comboBox2.Items.Clear();
                comboBox2.Items.Add("人民币");
                comboBox2.SelectedIndex = 0;

                // 存款期限
                comboBox3.Items.Clear();
                foreach (var x in cun_ben)
                {
                    //if (x != "一个月")
                    comboBox3.Items.Add(x);

                }
                comboBox3.SelectedIndex = 0;

                //初始存入日期
                dateTimePicker1.Visible = false;

                //支取频次
                comboBox4.Items.Clear();
                foreach (var x in zhi_qu)
                {
                    //if (x != "一个月")
                    comboBox4.Items.Add(x);

                }
                comboBox4.SelectedIndex = 0;

                //comboBox4.Visible = false;

                //初始存款金额
                textBox1.Text = "";


                //年利率
                textBox2.Text = "1.35";

                //月存入金额
                textBox3.Visible = false;

                //textBox2.Visible = false;

                //提取日期
                dateTimePicker2.Visible = false;

                //每次支取金额
                label15.Visible = true;
                textBox7.Visible = true;

            }

            //定活两便
            if (cun_kuan_index == 6)
            {
                // 币种
                comboBox2.Items.Clear();
                //foreach (var x in bi_zhong)
                //    comboBox2.Items.Add(x);
                comboBox2.Items.Add("人民币");
                comboBox2.SelectedIndex = 0;

                // 存款期限
                comboBox3.Visible = false;

                //初始存入日期
                dateTimePicker1.Value = DateTime.Today;

                //支取频次
                comboBox4.Visible = false;

                //初始存款金额
                textBox1.Text = "";

                //年利率
                textBox2.Text = "1.05";

                //月存入金额
                textBox3.Visible = false;

                //提取日期
                dateTimePicker2.Value = DateTime.Today.AddYears(1);

            }

            //通知存款
            if (cun_kuan_index == 7)
            {
                // 币种
                comboBox2.Items.Clear();
                //foreach (var x in bi_zhong)
                //    comboBox2.Items.Add(x);
                comboBox2.Items.Add("人民币");
                comboBox2.SelectedIndex = 0;

                // 存款期限
                comboBox3.Items.Clear();
                foreach (var x in tong_zhi)
                {
                    //if (x != "一个月")
                    comboBox3.Items.Add(x);

                }
                comboBox3.SelectedIndex = 0;


                //初始存入日期
                dateTimePicker1.Value = DateTime.Today;

                //支取频次
                comboBox4.Visible = false;

                //初始存款金额
                textBox1.Text = "";

                //年利率
                textBox2.Text = "0.55";

                //月存入金额
                textBox3.Visible = false;

                //提取日期
                dateTimePicker2.Value = DateTime.Today.AddYears(1);

            }

            //教育储蓄
            if (cun_kuan_index == 8)
            {
                // 币种
                comboBox2.Items.Clear();
                //foreach (var x in bi_zhong)
                comboBox2.Items.Add("人民币");
                comboBox2.SelectedIndex = 0;

                // 存款期限
                comboBox3.Items.Clear();
                foreach (var x in jiao_yu)
                {
                    //if (x != "一个月")
                        comboBox3.Items.Add(x);

                }
                comboBox3.SelectedIndex = 0;

                //初始存入日期
                dateTimePicker1.Visible = false;

                //支取频次
                comboBox4.Visible = false;

                //初始存款金额
                textBox1.Text = "";

                //年利率
                textBox2.Text = "1.75";

                //月存入金额
                textBox3.Text = "";

                //提取日期
                dateTimePicker2.Visible = false;

            }

        }

        //全部利率
        //外币活期利率
        double[] wai_bi = {0.3, 0.0500, 0.0500, 0.0050, 0.0001, 0.0100, 0.0100, 0.0001, 0.2375, 0.0001 };
        //外币整存整取
        double[,] wai_bi_zheng ={{0.1000  ,0.1000,    0.0300, 0.0100, 0.1000, 0.0100, 0.0100, 1.2400, 0.0100},{
0.2500, 0.1000, 0.0500, 0.0100, 0.2500, 0.0500, 0.0100, 1.3125, 0.0100},{
0.5000, 0.1000, 0.1500, 0.0100, 0.5000, 0.3000, 0.0100, 1.3250, 0.0100},{
0.7000, 0.1000, 0.2000, 0.0100, 0.7000, 0.4000, 0.0100, 1.3750, 0.0100},{
0.7000, 0.1000, 0.2500, 0.0100, 0.7000, 0.4000, 0.0100, 1.4000, 0.0100}};

        //2.币种 事件
        private void ComboBox2_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            int bi_zhong_index = comboBox2.SelectedIndex;
            int cun_kuan_index = comboBox1.SelectedIndex;

            //人民币
            //textBox2.Text = "" + ren_min_bi[(string)cun_kuan_index];
            //if(comboBox2.Visible==true)
            //活期
            if (bi_zhong_index == 0 || cun_kuan_index == 1)
                textBox2.Text = "0.3";
            //整存整取 
            if (bi_zhong_index == 0 || cun_kuan_index == 2)
            {
                textBox2.Text = "1.35";

                comboBox3.Items.Clear();
                foreach (var x in zheng_zheng)
                {
                    if(x != "一个月")
                    comboBox3.Items.Add(x);

                }
                comboBox3.SelectedIndex = 0;

            }

            //外币
            //活期
            if (bi_zhong_index != 0 && cun_kuan_index == 1)
                textBox2.Text = "" + wai_bi[bi_zhong_index];
            //整存整取
            if (bi_zhong_index != 0 && cun_kuan_index == 2)
            {
                //MessageBox.Show("" + bi_zhong_index+" "+wai_bi_zheng.Rank+" "+wai_bi_zheng.Length);
                textBox2.Text = "" + wai_bi_zheng[0,bi_zhong_index - 1];
                comboBox3.Items.Clear();
                foreach (var x in zheng_zheng)
                {
                    if (x != "三年"&&x!="五年")
                        comboBox3.Items.Add(x);

                }
                comboBox3.SelectedIndex = 0;
            }


        }

        //其他整取
        double[] qi_ta_zheng = { 1.3500, 1.5500, 1.5500 };

        //通知 期限
        double[] tong_zhi_interest = { 0.5500, 1.1000 };

        //教育 期限
        double[] jiao_yu_interest = { 1.75, 2.75, 2.75 };

        //人民币 整取
        double[] ren_min_bi = { 1.3500, 1.5500, 1.7500, 2.2500, 2.7500 };

        //3.存款期限 事件
        private void ComboBox3_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            int qi_xian_index = comboBox3.SelectedIndex;
            int bi_zhong_index = comboBox2.SelectedIndex;
            int cun_kuan_index = comboBox1.SelectedIndex;

            //人民币 整取
            if (bi_zhong_index == 0 && cun_kuan_index == 2)
                textBox2.Text = "" + ren_min_bi[qi_xian_index];


            //整存整取 外币
            if (bi_zhong_index != 0 && cun_kuan_index == 2)
                textBox2.Text = "" + wai_bi_zheng[qi_xian_index, bi_zhong_index - 1];
            //整存之外其他 人民币
            if (2 < cun_kuan_index && cun_kuan_index < 6 )
                textBox2.Text = "" + qi_ta_zheng[qi_xian_index];
            //通知存款
            if (cun_kuan_index == 7)
                textBox2.Text = "" + tong_zhi_interest[qi_xian_index];
            //教育储蓄
            if (cun_kuan_index == 8)
                textBox2.Text = "" + jiao_yu_interest[qi_xian_index];
        }

        //期限对应年数
        Dictionary<string, double> years = new Dictionary<string, double> { { "一个月",0.083333}, { "三个月",0.25 }, { "六个月",0.5 }, { "一年",1 }, { "二年",2 }, { "三年",3 }, { "五年",5 } };
        
        //4.提交
        private void button1_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox2.Text, out double interest))
                MessageBox.Show("请填入正确的年利率值！");

            if (!double.TryParse(textBox1.Text, out double deposit))
                MessageBox.Show("请填入正确的初始存款金额！");

            if (!double.TryParse(textBox3.Text, out double month_deposit) && textBox3.Visible)
                MessageBox.Show("请填入正确的月存入金额！");

            DateTime date_1 = dateTimePicker1.Value;
            DateTime date_2 = dateTimePicker2.Value;
            if (dateTimePicker2.Visible && DateTime.Compare(dateTimePicker1.Value, dateTimePicker2.Value) > 0)
                MessageBox.Show("提取日期必须大于存入日期！");

            textBox5.Text = "0";
            double li_xi = 0;

            int year = date_1.Year - date_2.Year;
            int month = date_1.Month - date_2.Month;
            int day = date_1.Day - date_2.Day;

            double cun_kuan_time = 0;

            if((string)comboBox3.SelectedItem!=""&& comboBox1.SelectedIndex != 7)
            cun_kuan_time = years[(string)comboBox3.SelectedItem];

            //活期
            if (comboBox1.SelectedIndex==1)
            {
                li_xi = -0.01*(360 * year + month * 30 + day) / 360 * deposit * interest;
            }

            //整存整取
            if (comboBox1.SelectedIndex == 2)
            {
                li_xi = 0.01 * cun_kuan_time * interest * deposit;
            }

            //零存整取
            if (comboBox1.SelectedIndex == 3)
            {
                li_xi = 0.01 * cun_kuan_time * interest * month_deposit * (0.5 + 6 * cun_kuan_time) ;
                deposit = cun_kuan_time * 12 * month_deposit;
            }

            //存本取息
            if (comboBox1.SelectedIndex == 4)
            {
                li_xi = 0.01 * cun_kuan_time * interest * deposit;
                textBox7.Text = "" + li_xi / (years[(string)comboBox3.SelectedItem] / years[(string)comboBox4.SelectedItem]);
                MessageBox.Show((string)comboBox3.SelectedItem+years[(string)comboBox4.SelectedItem]);
            }

            //整存零取
            if (comboBox1.SelectedIndex == 5)
            {
                textBox7.Text = "" + deposit / (years[(string)comboBox3.SelectedItem] / years[(string)comboBox4.SelectedItem]);
                li_xi = 0.01 * (deposit + deposit / (years[(string)comboBox3.SelectedItem] / years[(string)comboBox4.SelectedItem])) / 2 * (years[(string)comboBox3.SelectedItem] / years[(string)comboBox4.SelectedItem]) * years[(string)comboBox4.SelectedItem] * interest;
            }

            //定活两便
            if (comboBox1.SelectedIndex == 6)
            {
                li_xi = -0.01 * (360 * year + month * 30 + day) / 360 * deposit * interest;
            }

            //通知存款
            if (comboBox1.SelectedIndex == 7)
            {
                li_xi = -0.01 * (360 * year + month * 30 + day) / 360 * deposit * interest;
            }

            //教育储蓄
            if (comboBox1.SelectedIndex == 8)
            {
                li_xi = 0.01 * cun_kuan_time * interest * month_deposit * (0.5 + 6 * cun_kuan_time) ;
                deposit= cun_kuan_time * 12 * month_deposit;
            }
            textBox4.Text = "" + li_xi;
            textBox6.Text = "" + (li_xi + deposit);

        }

        //5.定活两便 年利率
        private void dateTimePicker2_value_changed(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 6)
            if (DateTime.Compare(dateTimePicker1.Value.AddYears(1), dateTimePicker2.Value) <= 0)
                textBox2.Text = "" + 1.05;

            else if (DateTime.Compare(dateTimePicker1.Value.AddMonths(6), dateTimePicker2.Value) <= 0)
                textBox2.Text = "0.93";

            else if (DateTime.Compare(dateTimePicker1.Value.AddMonths(3), dateTimePicker2.Value) <= 0)
                textBox2.Text = "0.81";

            else if (DateTime.Compare(dateTimePicker1.Value, dateTimePicker2.Value) <= 0)
                textBox2.Text = "0.3";

            else textBox2.Text = "";
        }
    }
}
