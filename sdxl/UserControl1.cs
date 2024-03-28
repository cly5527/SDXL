using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sdxl
{
    public partial class UserControl1 : UserControl
    {


        // 声明一个布尔变量来跟踪是否正在处理 TextBox1_TextChanged 事件
        private bool isHandlingTextChangedEvent = false;

        public UserControl1()
        {
            InitializeComponent();
        }

        private void Button01_Click(object sender, EventArgs e)
        {
            
            // 获取 TextBox 中的文本内容
            string textContent = textBox1.Text;
            string filePath = "data.txt";
            StreamWriter writer = new StreamWriter(filePath);
            writer.Write(textContent);
            writer.Close(); // 释放资源

            Controls.Clear();

            BackgroundImage = Properties.Resources.images2;
            BackgroundImageLayout = ImageLayout.Stretch;

            // 创建 label 控件
            Label label11 = new()
            {
                AutoSize = true,
                Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134),
                Location = new Point(29, 273),
                Name = "label1",
                Size = new Size(743, 48),
                TabIndex = 0,
                Text = "你叫" + textContent + "，出生在襄阳城边的小乡村，年十岁，世隶耕。某天你在村口玩耍时，遇一和尚，其身披黄\r\n袍、极高极瘦、身形犹似竹杆一般，脑门微陷，便似一只碟子一般。他自号金轮法王，问你是否想学\r\n                        武功，可将一身所 学传与你。"
            };

            // 
            // button11
            // 
            Button button11 = new()
            {
                AutoSize = true,
                BackColor = SystemColors.Highlight,
                ForeColor = SystemColors.ButtonFace,
                Location = new Point(147, 348),
                Name = "button11",
                //Size = new Size(102, 29),
                TabIndex = 1,
                Text = "立刻拜其为师，并大声喊：“师傅！”",
                UseVisualStyleBackColor = false
            };
            button11.Click += Button11_Click;

            // 
            // button12
            // 

            Button button12 = new()
            {
                AutoSize = true,
                BackColor = SystemColors.Highlight,
                ForeColor = SystemColors.ButtonFace,
                Location = new Point(384, 348),
                Name = "button12",
                //Size = new Size(102, 29),
                TabIndex = 1,
                Text = "拒绝拜师，并声称自己还想娶老婆，不想当和尚。",
                UseVisualStyleBackColor = false
            };

            button12.Click += Button12_Click;

            // 将控件添加到窗体中
            Controls.Add(label11);
            Controls.Add(button11);
            Controls.Add(button12);
        }

        private void Button11_Click(object? sender, EventArgs e)
        {
            Controls.Clear();
            // 创建 label 控件
            Label label12 = new()
            {
                AutoSize = true,
                Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134),
                Location = new Point(29, 273),
                Name = "label12",
                Size = new Size(743, 48),
                TabIndex = 0,
                Text = "老和尚随即一愣，面色阴沉不定，沉默半晌后，忽又哈哈大笑，随即挥出一掌，大喝：“般若龙象，好\r\n了，功夫已经教你。”不待你反应，随即扬长而去。\r\n不日蒙古人攻破襄阳城，并展开大屠杀，连带对周边进行抢杀劫掠，你一家人均死在蒙古人的劫掠中。"
            };
            // 
            // button15
            // 
            Button button15 = new()
            {
                AutoSize = true,
                BackColor = SystemColors.Highlight,
                ForeColor = SystemColors.ButtonFace,
                Location = new Point(300, 348),
                Name = "button15",
                //Size = new Size(102, 29),
                TabIndex = 1,
                Text = "游戏结束！",
                UseVisualStyleBackColor = false
            };
            button15.Click += Button15_Click;

            // 将控件添加到窗体中
            Controls.Add(label12);
            Controls.Add(button15);

        }


        private void Button15_Click(object? sender, EventArgs e)
        {
            // 显示带有消息和确定/取消按钮的消息框
            DialogResult result = MessageBox.Show("你悄悄地走了，就如同你悄悄地来到人世间一般。在这短暂的一生中，你仿佛只是一道匆匆的风景，留下的是平淡而无声的印记，轻轻地，悄然离去。", "是否返回首頁", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            // 如果用户点击了确定按钮
            if (result == DialogResult.OK)
            {
                // 打开或显示首页窗体
                Form1 homePage = new();
                homePage.Show();
            }
        }

        private void Button12_Click(object? sender, EventArgs e)
        {
            Controls.Clear();
            // 创建 label 控件
            Label label13 = new()
            {
                AutoSize = true,
                Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134),
                Location = new Point(29, 273),
                Name = "label13",
                Size = new Size(743, 48),
                TabIndex = 0,
                Text = "老和尚听后哈哈大笑，随即说到：“小施主多虑了，本门乃蒙古密教金刚宗，虽也是和尚，但\r\n不兴中原佛教那一套，既能娶妻，也能喝酒吃肉，你放心把。小施主如何？”。"
            };

            // 
            // button13
            // 
            Button button13 = new()
            {
                AutoSize = true,
                BackColor = SystemColors.Highlight,
                ForeColor = SystemColors.ButtonFace,
                Location = new Point(147, 348),
                Name = "button13",
                //Size = new Size(102, 29),
                TabIndex = 1,
                Text = "“好，既能娶老婆，又能学武功，我拜师。”",
                UseVisualStyleBackColor = false
            };
            button13.Click += Button13_Click;

            // 
            // button14
            // 

            Button button14 = new()
            {
                AutoSize = true,
                BackColor = SystemColors.Highlight,
                ForeColor = SystemColors.ButtonFace,
                Location = new Point(400, 348),
                Name = "button14",
                //Size = new Size(102, 29),
                TabIndex = 1,
                Text = "“这，我得问过父母才能回答你。”",
                UseVisualStyleBackColor = false
            };
            button14.Click += Button14_Click;

            // 将控件添加到窗体中
            Controls.Add(label13);
            Controls.Add(button13);
            Controls.Add(button14);

            // 强制控件进行重绘
            Invalidate();
        }

        private void Button13_Click(object? sender, EventArgs e)
        {
            Controls.Clear();
            // 创建 label 控件
            Label label15 = new()
            {
                AutoSize = true,
                Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134),
                Location = new Point(29, 273),
                Name = "label15",
                Size = new Size(743, 48),
                TabIndex = 0,
                Text = "未完待续。"
            };
            Controls.Add(label15);
        }

        private void Button14_Click(object? sender, EventArgs e)
        {
            Controls.Clear();
            // 创建 label 控件
            Label label14 = new()
            {
                AutoSize = true,
                Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134),
                Location = new Point(29, 273),
                Name = "label14",
                Size = new Size(743, 48),
                TabIndex = 0,
                Text = "老和尚听后说道：“也对，好，贫僧便随你去见你的父母，商讨收徒事宜。”，你父母见此人瘦弱，\r\n又外族人打扮，看着不似好人，故而拒绝了。\r\n不日蒙古人攻破襄阳城，并展开大屠杀，连带对周边进行抢杀劫掠，你一家人均死在蒙古人的劫掠中。"
            };
            // 
            // button16
            // 
            Button button16 = new()
            {
                AutoSize = true,
                BackColor = SystemColors.Highlight,
                ForeColor = SystemColors.ButtonFace,
                Location = new Point(300, 348),
                Name = "button16",
                //Size = new Size(102, 29),
                TabIndex = 1,
                Text = "游戏结束！",
                UseVisualStyleBackColor = false
            };
            button16.Click += Button15_Click;

            // 将控件添加到窗体中
            Controls.Add(label14);
            Controls.Add(button16);

        }



        private void TextBox1_TextChanged(object sender, EventArgs e)
        {


            // 如果正在处理事件，则直接返回，防止重复触发
            if (isHandlingTextChangedEvent)
            {
                return;
            }

            // 设置标志表示正在处理事件
            isHandlingTextChangedEvent = true;

            // 获取文本框中的内容
            string text = textBox1.Text;

            // 计算文本框中汉字的数量
            int chineseCount = CountChineseCharacters(text);

            // 如果不是汉字，清空文本框并提示用户
            if (!IsChineseCharacter(text))
            {
                MessageBox.Show("请输入中文名字！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Text = string.Empty;
                return;
            }

            // 如果汉字数量超过四个，清空文本框并提示用户
            else if (chineseCount > 4)
            {
                MessageBox.Show("名字不应该超过四个字！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Text = string.Empty;
            }
            // 重置标志表示事件处理完毕
            isHandlingTextChangedEvent = false;
        }

        // 计算字符串中汉字的数量
        private static int CountChineseCharacters(string text)
        {
            int count = 0;
            foreach (char c in text)
            {
                // 判断字符是否为汉字
                if (c >= '\u4e00' && c <= '\u9fff')
                {
                    count++;
                }
            }
            return count;
        }

        // 判断字符串中的所有字符是否都是汉字
        private static bool IsChineseCharacter(string text)
        {
            foreach (char c in text)
            {
                // 如果有任何一个字符不是汉字，则返回 false
                if (!(c >= '\u4e00' && c <= '\u9fff'))
                {
                    return false;
                }
            }
            // 所有字符都是汉字，则返回 true
            return true;
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
