namespace WindowsFormsApp2
{
    partial class Form_update
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1_taskNm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1_preStartTime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1_preEndTime = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1_taskOwner = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "タスク名";
            // 
            // textBox1_taskNm
            // 
            this.textBox1_taskNm.Location = new System.Drawing.Point(237, 80);
            this.textBox1_taskNm.Name = "textBox1_taskNm";
            this.textBox1_taskNm.Size = new System.Drawing.Size(388, 31);
            this.textBox1_taskNm.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "予定開始時間";
            // 
            // dateTimePicker1_preStartTime
            // 
            this.dateTimePicker1_preStartTime.Location = new System.Drawing.Point(237, 168);
            this.dateTimePicker1_preStartTime.Name = "dateTimePicker1_preStartTime";
            this.dateTimePicker1_preStartTime.Size = new System.Drawing.Size(388, 31);
            this.dateTimePicker1_preStartTime.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(723, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "予定終了時間";
            // 
            // dateTimePicker1_preEndTime
            // 
            this.dateTimePicker1_preEndTime.Location = new System.Drawing.Point(916, 170);
            this.dateTimePicker1_preEndTime.Name = "dateTimePicker1_preEndTime";
            this.dateTimePicker1_preEndTime.Size = new System.Drawing.Size(332, 31);
            this.dateTimePicker1_preEndTime.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(723, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "担当者";
            // 
            // textBox1_taskOwner
            // 
            this.textBox1_taskOwner.Location = new System.Drawing.Point(916, 87);
            this.textBox1_taskOwner.Name = "textBox1_taskOwner";
            this.textBox1_taskOwner.Size = new System.Drawing.Size(332, 31);
            this.textBox1_taskOwner.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "備考";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(237, 263);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1011, 219);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // button1_save
            // 
            this.button1_save.Location = new System.Drawing.Point(561, 524);
            this.button1_save.Name = "button1_save";
            this.button1_save.Size = new System.Drawing.Size(216, 47);
            this.button1_save.TabIndex = 10;
            this.button1_save.Text = "保存";
            this.button1_save.UseVisualStyleBackColor = true;
            this.button1_save.Click += new System.EventHandler(this.button1_save_Click);
            // 
            // Form_update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 608);
            this.Controls.Add(this.button1_save);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1_taskOwner);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1_preEndTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1_preStartTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1_taskNm);
            this.Controls.Add(this.label1);
            this.Name = "Form_update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "タスク更新";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1_taskNm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1_preStartTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1_preEndTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1_taskOwner;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1_save;
    }
}