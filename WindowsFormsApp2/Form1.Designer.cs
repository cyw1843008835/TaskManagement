namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2_taskAdd = new System.Windows.Forms.Button();
            this.button_taskPause = new System.Windows.Forms.Button();
            this.button_taskDel = new System.Windows.Forms.Button();
            this.button_taskEnd = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_taskStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 429);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1923, 540);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(961, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 67);
            this.button1.TabIndex = 1;
            this.button1.Text = "接続テスト";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2_taskAdd
            // 
            this.button2_taskAdd.Location = new System.Drawing.Point(12, 355);
            this.button2_taskAdd.Name = "button2_taskAdd";
            this.button2_taskAdd.Size = new System.Drawing.Size(140, 67);
            this.button2_taskAdd.TabIndex = 4;
            this.button2_taskAdd.Text = "追加";
            this.button2_taskAdd.UseVisualStyleBackColor = true;
            this.button2_taskAdd.Click += new System.EventHandler(this.button2_taskAdd_Click);
            // 
            // button_taskPause
            // 
            this.button_taskPause.Location = new System.Drawing.Point(651, 356);
            this.button_taskPause.Name = "button_taskPause";
            this.button_taskPause.Size = new System.Drawing.Size(140, 67);
            this.button_taskPause.TabIndex = 5;
            this.button_taskPause.Text = "中止";
            this.button_taskPause.UseVisualStyleBackColor = true;
            this.button_taskPause.Click += new System.EventHandler(this.button_taskPause_Click);
            // 
            // button_taskDel
            // 
            this.button_taskDel.Location = new System.Drawing.Point(304, 356);
            this.button_taskDel.Name = "button_taskDel";
            this.button_taskDel.Size = new System.Drawing.Size(140, 67);
            this.button_taskDel.TabIndex = 6;
            this.button_taskDel.Text = "削除";
            this.button_taskDel.UseVisualStyleBackColor = true;
            this.button_taskDel.Click += new System.EventHandler(this.button_taskDel_Click);
            // 
            // button_taskEnd
            // 
            this.button_taskEnd.Location = new System.Drawing.Point(797, 356);
            this.button_taskEnd.Name = "button_taskEnd";
            this.button_taskEnd.Size = new System.Drawing.Size(149, 67);
            this.button_taskEnd.TabIndex = 7;
            this.button_taskEnd.Text = "終了";
            this.button_taskEnd.UseVisualStyleBackColor = true;
     
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(158, 356);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(140, 67);
            this.button_update.TabIndex = 8;
            this.button_update.Text = "更新";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_taskStart
            // 
            this.button_taskStart.Location = new System.Drawing.Point(505, 356);
            this.button_taskStart.Name = "button_taskStart";
            this.button_taskStart.Size = new System.Drawing.Size(140, 67);
            this.button_taskStart.TabIndex = 9;
            this.button_taskStart.Text = "開始";
            this.button_taskStart.UseVisualStyleBackColor = true;
            this.button_taskStart.Click += new System.EventHandler(this.button_taskStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1923, 969);
            this.Controls.Add(this.button_taskStart);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_taskEnd);
            this.Controls.Add(this.button_taskDel);
            this.Controls.Add(this.button_taskPause);
            this.Controls.Add(this.button2_taskAdd);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "タスク管理システム";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2_taskAdd;
        private System.Windows.Forms.Button button_taskPause;
        private System.Windows.Forms.Button button_taskDel;
        private System.Windows.Forms.Button button_taskEnd;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_taskStart;
    }
}

