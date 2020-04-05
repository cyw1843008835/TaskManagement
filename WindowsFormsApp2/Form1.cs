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

    public partial class Form1 : Form

    {


        public int updateFlg;
        private int upCnt;
        //開始:0,中止:1,終了:2
        private int endFlg;
        public const string STARTTIME = "STARTTIME";
        public const string ENDTIME = "ENDTIME";
        public const string ZENKAI_STARTTM = "ZENKAI_STARTTM";
        public const string ZENKAI_ENDTM = "ZENKAI_ENDTM";
        public const string ZENKAI_KOUSU = "ZENKAI_KOUSU";
        public const string KOUSU = "KOUSU";
        public const string STATUS = "STATUS";


        public Form1()
        {
            InitializeComponent();
            this.Width = 1000;
            this.Height = 540;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;

        }

        private void Form1_Load(object sender, EventArgs e)
        {



            this.loadAll(ReadPropertyFile.getOraConnStr(), OracleSQL.getAll);


        }

        private void button1_Click(object sender, EventArgs e)
        {

            bool ifConnected = OracleHelper.CheckOracleConnect(ReadPropertyFile.getOraConnStr());
            if (ifConnected)
            {
                MessageBox.Show("ok");
            }
            else
            {
                MessageBox.Show("no");
            }
        }

        public void loadAll(string connectionString, string cmdText)
        {
            OracleConnection conn = new OracleConnection(connectionString);
            // 建立OracleDataAdapter对象，用来传输操作的字符串； 
            OracleDataAdapter oda = new OracleDataAdapter(cmdText, conn);
            // 建立DataSet对象，用来存储查找的结果； 
            DataSet ds = new DataSet();
            //用OracleDataAdapter对象的fill方法来填充ds; 
            oda.Fill(ds);
            // 指定DataGridView的数据源； 
            dataGridView1.DataSource = ds.Tables[0];
            // 连接用完后一定要记得关闭； 
            conn.Close();
        }

        private void button2_taskAdd_Click(object sender, EventArgs e)
        {
            updateFlg = 1;
            Form_update fu = new Form_update(updateFlg, null);
            fu.Owner = this;
            fu.ShowDialog();
        }

   
        public string getKousu(DateTime startTime, DateTime endTime)
        {


            System.TimeSpan ND = endTime - startTime;
            string kousu = "";
            int dn = ND.Days;
            int hn = ND.Hours;
            int mn = ND.Minutes;
            if (mn >= 30)
            {
                mn = 5;
            }
            else
            {
                mn = 0;
            }
            int dh = dn * 8 + hn;
            kousu = dh.ToString() + "." + mn.ToString();
            return kousu;

        }

        private void button_update_Click(object sender, EventArgs e)
        {
            int selectedCnt = dataGridView1.SelectedRows.Count;
            if (selectedCnt != 1)
            {
                MessageBox.Show("一行を選択してください");
                return;
            }
            Task task = new Task();
            task.Tasknm = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            task.Prestart_time = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            task.Preend_time = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            task.Taskowner = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            task.Bikou = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            updateFlg = 0;
            Form_update fu = new Form_update(updateFlg, task);
            fu.Owner = this;
            fu.ShowDialog();
        }

        private void button_taskDel_Click(object sender, EventArgs e)
        {
            int selectedCnt = dataGridView1.SelectedRows.Count;
            if (selectedCnt == 0)
            {
                MessageBox.Show("削除したい行を選択してください");
                return;
            }

            DialogResult dr = MessageBox.Show(selectedCnt.ToString() + "件タスクを削除してよろしいですか？", "メッセージ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dr == DialogResult.Cancel)

            {

                return;

            }

            else

            {

                OracleParameter[] param = new OracleParameter[] {
                new OracleParameter(":taskNm", OracleDbType.Varchar2),
                };
                param[0].Value = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                int delCnt = OracleHelper.ExecuteNonQuery(ReadPropertyFile.getOraConnStr(), CommandType.Text, OracleSQL.DeleteTask, param);
                if (delCnt > 0)
                {
                    MessageBox.Show(delCnt.ToString() + "件タスクが削除されました");
                    this.loadAll(ReadPropertyFile.getOraConnStr(), OracleSQL.getAll);
                }
                else
                {
                    MessageBox.Show("タスクが削除が失敗しました");
                }

            }
        }

        private void button_taskStart_Click(object sender, EventArgs e)
        {
            endFlg = 0;
            if (dataGridView1.SelectedRows.Count != 1) {
                MessageBox.Show("タスクを一行選択してください");
                return;
            }
            string startTime = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            string taskNm= dataGridView1.CurrentRow.Cells[0].Value.ToString();
            if (startTime == "" || startTime == null)
            {
                startTime = DateTime.Now.ToString();
                exeUpdate(STARTTIME, startTime, taskNm);
            }
            else { 
                string zenkai_startTime = DateTime.Now.ToString();
                exeUpdate(ZENKAI_STARTTM, zenkai_startTime, taskNm);
            }
           
        }

        private void button_taskPause_Click(object sender, EventArgs e)
        {
            if (endFlg != 0) {
                return;
            }
            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("タスクを一行選択してください");
                return;
            }
           string taskNm = dataGridView1.CurrentRow.Cells[0].Value.ToString();
           string zenkai_endTime = DateTime.Now.ToString();

               // exeUpdate(ZENKAI_ENDTM, zenkai_endTime, ZENKAI_KOUSU,taskNm);
           

        }

        private void exeUpdate(string fieldNm,string fieldValue,string taskNm)
        {
            
            OracleParameter[] param = new OracleParameter[] {
                new OracleParameter(":"+fieldNm, OracleDbType.Varchar2),
                new OracleParameter(":TASKNM", OracleDbType.Varchar2),
             };
            param[0].Value = fieldValue;
            param[1].Value = taskNm;
            upCnt = OracleHelper.ExecuteNonQuery(ReadPropertyFile.getOraConnStr(), CommandType.Text, OracleSQL.upOneField(fieldNm), param);
            if (upCnt > 0) 
            {
                this.loadAll(ReadPropertyFile.getOraConnStr(), OracleSQL.getAll);
            }
        }
        private void exeUpdate(string zkEndTime,string zkEndTm_val,string zkKousu,string zkKousu_val,string taskNm)
        {

            OracleParameter[] param = new OracleParameter[] {
                new OracleParameter(":"+zkEndTime, OracleDbType.Varchar2),
                new OracleParameter(":"+zkKousu, OracleDbType.Varchar2),
                new OracleParameter(":TASKNM", OracleDbType.Varchar2),
             };
            param[0].Value = zkEndTm_val;
            param[1].Value = zkKousu_val;
            param[2].Value = taskNm;
            List<string> taskList = new List<string>();
            taskList.Add(zkEndTime);
            taskList.Add(zkKousu);
            upCnt = OracleHelper.ExecuteNonQuery(ReadPropertyFile.getOraConnStr(), CommandType.Text, OracleSQL.updateTask(taskList), param);
            if (upCnt > 0)
            {
                this.loadAll(ReadPropertyFile.getOraConnStr(), OracleSQL.getAll);
            }
        }
        public void getSelectedTask(string connectionString, string cmdText)
        {
            OracleConnection conn = new OracleConnection(connectionString);
            // 建立OracleDataAdapter对象，用来传输操作的字符串； 
            OracleDataAdapter oda = new OracleDataAdapter(cmdText, conn);
            // 建立DataSet对象，用来存储查找的结果； 
            DataSet ds = new DataSet();
            //用OracleDataAdapter对象的fill方法来填充ds; 
            oda.Fill(ds);
            // 指定DataGridView的数据源； 
            dataGridView1.DataSource = ds.Tables[0];
            // 连接用完后一定要记得关闭； 
            conn.Close();
        }
    }
}
