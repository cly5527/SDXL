


namespace sdxl
{
    partial class UserControl1
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            button01 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label1.Location = new Point(305, 112);
            label1.Name = "label1";
            label1.Size = new Size(151, 16);
            label1.TabIndex = 0;
            label1.Text = "请输入您的游戏昵称";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("宋体", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            textBox1.Location = new Point(301, 141);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(155, 23);
            textBox1.TabIndex = 1;
            textBox1.Text = "杨过";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += TextBox1_TextChanged;
            // 
            // button01
            // 
            button01.Location = new Point(339, 179);
            button01.Name = "button01";
            button01.Size = new Size(75, 23);
            button01.TabIndex = 2;
            button01.Text = "确定";
            button01.UseVisualStyleBackColor = true;
            button01.Click += Button01_Click;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.images5;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(button01);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "UserControl1";
            Size = new Size(800, 450);
            Load += UserControl1_Load;
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button01;
    }
}
