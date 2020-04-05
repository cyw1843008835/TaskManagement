using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Oracle.ManagedDataAccess.Client;
using System.IO;

namespace WindowsFormsApp2
{
    public partial class Form_update : Form
    {
        private static int fpUpdateFlg;
        private static Task fuTask;

        public Form_update(int updateFlg,Task task)
        {
            InitializeComponent();
            this.Width = 700;
            this.Height = 350;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            fpUpdateFlg = updateFlg;
            if (fpUpdateFlg != 1)
            {
                textBox1_taskNm.ReadOnly = true;
            }
            fuTask = task;
            if (task != null)
            {
                textBox1_taskNm.Text = task.Tasknm;
                textBox1_taskOwner.Text = task.Taskowner;
                dateTimePicker1_preStartTime.Value = DateTime.ParseExact(task.Prestart_time, "yyyy/MM/dd", System.Globalization.CultureInfo.CurrentCulture);
                dateTimePicker1_preEndTime.Value = DateTime.ParseExact(task.Prestart_time, "yyyy/MM/dd", System.Globalization.CultureInfo.CurrentCulture);
                richTextBox1.Text = task.Bikou;

            }
        }

        private void button1_save_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (!saveCheck(textBox1_taskNm.Text, dateTimePicker1_preStartTime.Value, dateTimePicker1_preEndTime.Value, textBox1_taskOwner.Text))
                {
                return;
            }

            OracleParameter[] param = new OracleParameter[] {
                new OracleParameter(":taskOwner", OracleDbType.Varchar2),
                new OracleParameter(":preStartTime", OracleDbType.Varchar2),
                new OracleParameter(":preEndTime", OracleDbType.Varchar2),
                new OracleParameter(":bikou", OracleDbType.Varchar2),
                new OracleParameter(":taskNm", OracleDbType.Varchar2),

            };
            param[0].Value = textBox1_taskOwner.Text;
            param[1].Value = dateTimePicker1_preStartTime.Value.ToString("yyyy/MM/dd");
            param[2].Value = dateTimePicker1_preEndTime.Value.ToString("yyyy/MM/dd");
            param[3].Value = richTextBox1.Text;
            param[4].Value = textBox1_taskNm.Text;

            if (fpUpdateFlg == 1)
            {
                 // 插入数据库表
                i = OracleHelper.ExecuteNonQuery(ReadPropertyFile.getOraConnStr(), CommandType.Text, OracleSQL.InsertTask, param);
             }
            else 
            {
               
                i= OracleHelper.ExecuteNonQuery(ReadPropertyFile.getOraConnStr(), CommandType.Text, OracleSQL.UpdateTask,param);

            }
            if (i == 1)
            {
                MessageBox.Show("保存成功");
                Form1 f1;
                f1 = (Form1)this.Owner;
                f1.loadAll(ReadPropertyFile.getOraConnStr(), OracleSQL.getAll);
                this.Close();
            }
            else
            {
                MessageBox.Show("保存失敗");
            }


        }
        private static Boolean saveCheck(string taskNm, DateTime preStartDate, DateTime preEndDate, string taskOwner) {
            Boolean saveCheckFlg = true;

            if (taskNm =="" || taskNm == null)
            {
                MessageBox.Show("タスク名を入力してください");
                saveCheckFlg = false;


            }
            if (preStartDate.ToString() == "" || preStartDate == null)
            {
                MessageBox.Show("予定開始時間を入力してください");
                saveCheckFlg = false;
            }
            if (preEndDate.ToString() == "" || preEndDate == null)
            {
                MessageBox.Show("予定終了時間を入力してください");
                saveCheckFlg = false;
            }
            if (taskOwner == "" || taskOwner == null)
            {
                MessageBox.Show("担当者を入力してください");
                saveCheckFlg = false;
            }
            if (preStartDate< preEndDate)
            {
                MessageBox.Show("予定時間不正");
                saveCheckFlg = false;
            }
            return saveCheckFlg;
        }
    }
}
