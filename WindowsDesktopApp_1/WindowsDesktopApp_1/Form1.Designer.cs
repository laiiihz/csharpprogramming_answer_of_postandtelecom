namespace WindowsDesktopApp_1
{
    partial class Form1
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textbox_psw = new System.Windows.Forms.TextBox();
            this.displaypsw_check = new System.Windows.Forms.CheckBox();
            this.textbox_display = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textbox_display);
            this.panel1.Controls.Add(this.displaypsw_check);
            this.panel1.Controls.Add(this.textbox_psw);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(54, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(696, 327);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(53, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "密码";
            // 
            // textbox_psw
            // 
            this.textbox_psw.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textbox_psw.Location = new System.Drawing.Point(186, 67);
            this.textbox_psw.Multiline = true;
            this.textbox_psw.Name = "textbox_psw";
            this.textbox_psw.PasswordChar = '★';
            this.textbox_psw.Size = new System.Drawing.Size(268, 36);
            this.textbox_psw.TabIndex = 1;
            this.textbox_psw.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // displaypsw_check
            // 
            this.displaypsw_check.AutoSize = true;
            this.displaypsw_check.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.displaypsw_check.Location = new System.Drawing.Point(484, 61);
            this.displaypsw_check.MinimumSize = new System.Drawing.Size(100, 50);
            this.displaypsw_check.Name = "displaypsw_check";
            this.displaypsw_check.Size = new System.Drawing.Size(111, 50);
            this.displaypsw_check.TabIndex = 3;
            this.displaypsw_check.Text = "显示密码";
            this.displaypsw_check.UseVisualStyleBackColor = true;
            this.displaypsw_check.CheckedChanged += new System.EventHandler(this.displaypsw_CheckedChanged);
            // 
            // textbox_display
            // 
            this.textbox_display.Location = new System.Drawing.Point(186, 185);
            this.textbox_display.Multiline = true;
            this.textbox_display.Name = "textbox_display";
            this.textbox_display.ReadOnly = true;
            this.textbox_display.Size = new System.Drawing.Size(268, 37);
            this.textbox_display.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textbox_display;
        private System.Windows.Forms.CheckBox displaypsw_check;
        private System.Windows.Forms.TextBox textbox_psw;
        private System.Windows.Forms.Label label1;
    }
}

