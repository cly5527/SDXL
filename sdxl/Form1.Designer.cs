using System.Windows.Forms;

namespace sdxl
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            button1.ForeColor = SystemColors.ControlLight;
            button1.Location = new Point(583, 195);
            button1.Name = "button1";
            button1.Size = new Size(88, 36);
            button1.TabIndex = 2;
            button1.Text = "开始游戏";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Highlight;
            button2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            button2.ForeColor = SystemColors.ControlLight;
            button2.Location = new Point(583, 254);
            button2.Name = "button2";
            button2.Size = new Size(88, 36);
            button2.TabIndex = 3;
            button2.Text = "旧的回忆";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Highlight;
            button3.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            button3.ForeColor = SystemColors.ControlLight;
            button3.Location = new Point(583, 312);
            button3.Name = "button3";
            button3.Size = new Size(88, 36);
            button3.TabIndex = 4;
            button3.Text = "开发团队";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.Highlight;
            button4.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            button4.ForeColor = SystemColors.ControlLight;
            button4.Location = new Point(583, 364);
            button4.Name = "button4";
            button4.Size = new Size(88, 36);
            button4.TabIndex = 5;
            button4.Text = "退出游戏";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.images;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "欢迎来到神雕侠侣";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
