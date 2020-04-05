using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class OracleSQL
    {
        private static string getAllStr() 
        {
            StringBuilder getAllStr = new StringBuilder();
            getAllStr.Append("TASKNM タスク名,");
            getAllStr.Append("(select statusnm from status where statuscode =task.STATUS) ステータス,");
            getAllStr.Append("PRESTART_TIME 予定開始時間,");
            getAllStr.Append("PREEND_TIME 予定終了時間,");
            getAllStr.Append("TASKOWNER 担当者,");
            getAllStr.Append("STARTTIME 実際開始時間,");
            getAllStr.Append("ENDTIME 実際終了時間,");
            getAllStr.Append("KOUSU 工数,");
            getAllStr.Append("BIKOU 備考");
            return getAllStr.ToString();

        }

        public static string upOneField(string filedNm)
        {
        string upSql = "UPDATE TASK SET "+ filedNm + "=:"+ filedNm + " WHERE TASKNM=:TASKNM";
            return upSql;
    }
        public static string updateTask(List<string> taskList) {
            StringBuilder sb = new StringBuilder();
            sb.Append("UPDATE TASK SET ");
        for(int i=0;i<taskList.Count;i++)
            {
                sb.Append(taskList[i]);
                sb.Append("=:");
                sb.Append(taskList[i]);
            }
            sb.Append(" WHERE TASKNM=:TASKNM");
            return sb.ToString();
        }
          // 查询表数据
        public static string  getAll= "select "+getAllStr()+" from task";
        public static string getTask = "SELECT * FROM TASK WHERE TASKNM=:TASKNM";
        // 模糊查询表数据
        public static string GerWZJPersonLike = "select * from wzj_person where name like :name order by syid";
        //删除数据
        public static string DeleteTask = "DELETE FROM TASK WHERE TASKNM = :TASKNM";
        // 添加数据
        public static string InsertTask = "INSERT INTO TASK(TASKOWNER,PRESTART_TIME, PREEND_TIME,BIKOU,TASKNM) VALUES (:TASKOWNER,:PRESTART_TIME,:PREEND_TIME,:BIKOU,:TASKNM)";
        // 更新数据
        public static string UpdateTask = "UPDATE TASK SET TASKOWNER=:TASKOWNER,PRESTART_TIME=:PRESTART_TIME,PREEND_TIME=:PREEND_TIME,BIKOU=:BIKOU WHERE TASKNM=:TASKNM";
       
    }
}
