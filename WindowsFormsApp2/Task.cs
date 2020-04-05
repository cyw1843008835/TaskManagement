using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Task
    {
        private string tasknm;
        private string status;
        private string prestart_time;
        private string preend_time;
        private string taskowner;
        private string starttime;
        private string endtime;
        private string zenkai_starttm;
        private string zenkai_endtm;
        private string zenkai_kousu;
        private string kousu;
        private string bikou;
        private string updated_time;


        public string Tasknm { get => tasknm; set => tasknm = value; }
        public string Status { get => status; set => status = value; }
        public string Prestart_time { get => prestart_time; set => prestart_time = value; }
        public string Preend_time { get => preend_time; set => preend_time = value; }
        public string Taskowner { get => taskowner; set => taskowner = value; }
        public string Starttime { get => starttime; set => starttime = value; }
        public string Endtime { get => endtime; set => endtime = value; }
        public string Zenkai_starttm { get => zenkai_starttm; set => zenkai_starttm = value; }
        public string Zenkai_endtm { get => zenkai_endtm; set => zenkai_endtm = value; }
        public string Zenkai_kousu { get => zenkai_kousu; set => zenkai_kousu = value; }
        public string Kousu { get => kousu; set => kousu = value; }
        public string Bikou { get => bikou; set => bikou = value; }
        public string Updated_time { get => updated_time; set => updated_time = value; }

    }
}
