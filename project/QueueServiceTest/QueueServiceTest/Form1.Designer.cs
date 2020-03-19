namespace QueueServiceTest
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
            this.btn_addScreen = new System.Windows.Forms.Button();
            this.btn_removeScreen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_patientID = new System.Windows.Forms.TextBox();
            this.tb_counterID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_patientName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_reponse = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_addScreen
            // 
            this.btn_addScreen.Location = new System.Drawing.Point(62, 254);
            this.btn_addScreen.Name = "btn_addScreen";
            this.btn_addScreen.Size = new System.Drawing.Size(75, 23);
            this.btn_addScreen.TabIndex = 0;
            this.btn_addScreen.Text = "上屏";
            this.btn_addScreen.UseVisualStyleBackColor = true;
            // 
            // btn_removeScreen
            // 
            this.btn_removeScreen.Location = new System.Drawing.Point(183, 254);
            this.btn_removeScreen.Name = "btn_removeScreen";
            this.btn_removeScreen.Size = new System.Drawing.Size(75, 23);
            this.btn_removeScreen.TabIndex = 1;
            this.btn_removeScreen.Text = "下屏";
            this.btn_removeScreen.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "病人ID：";
            // 
            // tb_patientID
            // 
            this.tb_patientID.Location = new System.Drawing.Point(158, 78);
            this.tb_patientID.Name = "tb_patientID";
            this.tb_patientID.Size = new System.Drawing.Size(100, 21);
            this.tb_patientID.TabIndex = 3;
            this.tb_patientID.Text = "001";
            // 
            // tb_counterID
            // 
            this.tb_counterID.Location = new System.Drawing.Point(158, 174);
            this.tb_counterID.Name = "tb_counterID";
            this.tb_counterID.Size = new System.Drawing.Size(100, 21);
            this.tb_counterID.TabIndex = 5;
            this.tb_counterID.Text = "3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "取药窗口：";
            // 
            // tb_patientName
            // 
            this.tb_patientName.Location = new System.Drawing.Point(158, 129);
            this.tb_patientName.Name = "tb_patientName";
            this.tb_patientName.Size = new System.Drawing.Size(100, 21);
            this.tb_patientName.TabIndex = 7;
            this.tb_patientName.Text = "张三";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "病人姓名：";
            // 
            // tb_reponse
            // 
            this.tb_reponse.Location = new System.Drawing.Point(158, 212);
            this.tb_reponse.Name = "tb_reponse";
            this.tb_reponse.Size = new System.Drawing.Size(100, 21);
            this.tb_reponse.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(40, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 14);
            this.label4.TabIndex = 9;
            this.label4.Text = "reponse value：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 327);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_reponse);
            this.Controls.Add(this.tb_patientName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_counterID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_patientID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_removeScreen);
            this.Controls.Add(this.btn_addScreen);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_addScreen;
        private System.Windows.Forms.Button btn_removeScreen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_patientID;
        private System.Windows.Forms.TextBox tb_counterID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_patientName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_reponse;
        private System.Windows.Forms.Label label4;
    }
}

