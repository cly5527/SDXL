namespace sdxl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            // 创建一个新的 UserControl1 对象
            UserControl1 userControl1 = new UserControl1();

            // 添加 UserControl1 到窗体的控件集合中
            Controls.Add(userControl1);

            // 设置 UserControl1 的位置和大小
            userControl1.Location = new Point(0, 1); // 可根据需要设置位置
            userControl1.Size = this.ClientSize; // 设置大小为窗体大小


        }

        private void button2_Click(object sender, EventArgs e)
        {
           MessageBox.Show("功能尚未完善，请稍后", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            // 创建 label 控件
            Label label05 = new()
            {
                AutoSize = true,
                Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134),
                Location = new Point(260, 273),
                Name = "label05",
                Size = new Size(743, 48),
                TabIndex = 0,
                Text = "作者：Rich\r\n协助：暂无\r\n时间：2024-03-27"
            };

            // 
            // button05
            // 
            Button button05 = new()
            {
                AutoSize = true,
                BackColor = SystemColors.Highlight,
                ForeColor = SystemColors.ButtonFace,
                Location = new Point(300, 348),
                Name = "button05",
                //Size = new Size(102, 29),
                TabIndex = 1,
                Text = "返回",
                UseVisualStyleBackColor = false
            };
            button05.Click += Button05_Click;

            Controls.Add(label05);
            Controls.Add(button05);
        }

        private void Button05_Click(object? sender, EventArgs e)
        {

            // 清空当前窗体的控件集合
            Controls.Clear();

            // 创建 Form1 对象（即首页）
            Form1 homePage = new();

            // 将首页添加到窗体的控件集合中
            homePage.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // 提示用户是否确定退出
            DialogResult result = MessageBox.Show("确定退出游戏吗？", "确认退出", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            // 如果用户点击确定，则退出程序
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }
    }
}
