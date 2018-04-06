using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustTimber
{
    public class Variables
    {
        public bool Create { get; set; }
        public bool Update { get; set; }
        public JobCardStatus Station { get; set; }
        public static DateTime Now { get; }
    }
    public enum JobCardStatus
    {
        NotStarted,
        Cutting,
        Edging,
        Packing,
        Delivery,
        Done
    }

    public class JobCard
    {
        public string Customer { get; set; }

        public string Id { get; set; }

        public DateTime Arrival { get; set; }

       // public string Tester { get; set; }

        public JobCardStatus Status { get; set; }

        public List<Work> Work { get; private set; }

        public JobCard()
        {
            Work = new List<JustTimber.Work>();
        }

        public void AddWork(DateTime time, string worker)
        {
            Work w = new Work();
            w.Time = time;
            w.Worker = worker;
            Work.Add(w);
        }

        public void RemoveWork(int index)
        {
            Work.RemoveAt(index);
        }

        public void RemoveLast()
        {
            Work.RemoveAt(Work.Count - 1);
        }
    }

    public class Work
    {
        public DateTime Time { get; set; }

        public string Worker { get; set; }
    }
}
