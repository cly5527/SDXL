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
            // ����һ���µ� UserControl1 ����
            UserControl1 userControl1 = new UserControl1();

            // ��� UserControl1 ������Ŀؼ�������
            Controls.Add(userControl1);

            // ���� UserControl1 ��λ�úʹ�С
            userControl1.Location = new Point(0, 1); // �ɸ�����Ҫ����λ��
            userControl1.Size = this.ClientSize; // ���ô�СΪ�����С


        }

        private void button2_Click(object sender, EventArgs e)
        {
           MessageBox.Show("������δ���ƣ����Ժ�", "��Ϣ��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            // ���� label �ؼ�
            Label label05 = new()
            {
                AutoSize = true,
                Font = new Font("����", 12F, FontStyle.Regular, GraphicsUnit.Point, 134),
                Location = new Point(260, 273),
                Name = "label05",
                Size = new Size(743, 48),
                TabIndex = 0,
                Text = "���ߣ�Rich\r\nЭ��������\r\nʱ�䣺2024-03-27"
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
                Text = "����",
                UseVisualStyleBackColor = false
            };
            button05.Click += Button05_Click;

            Controls.Add(label05);
            Controls.Add(button05);
        }

        private void Button05_Click(object? sender, EventArgs e)
        {

            // ��յ�ǰ����Ŀؼ�����
            Controls.Clear();

            // ���� Form1 ���󣨼���ҳ��
            Form1 homePage = new();

            // ����ҳ��ӵ�����Ŀؼ�������
            homePage.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // ��ʾ�û��Ƿ�ȷ���˳�
            DialogResult result = MessageBox.Show("ȷ���˳���Ϸ��", "ȷ���˳�", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            // ����û����ȷ�������˳�����
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
