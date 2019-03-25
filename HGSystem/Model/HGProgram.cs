using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HGSystem.Model
{
    public class HGProgramItem
    {
        public HGProgramItem(String name, int timeLen, string category, DateTime createdAt, int playAmount, int shareAmount)
        {
            Name = name;
            TimeLen = timeLen;
            Category = category;
            CreatedAt = createdAt;
            PlayAmount = playAmount;
            ShareAmount = shareAmount;
        }
        public String Name { get; set; }
        public int TimeLen { get; set; }
        public String Category { get; set; }
        public DateTime CreatedAt { get; set; }
        public int PlayAmount { get; set; }
        public int ShareAmount { get; set; }
    }

    public class HGProgram
    {
        //public HGProgram(int total, IList<HGProgramItem> programs)
        //{
        //    Total = total;
        //    Programs = programs;
        //}
        public HGProgram()//int total, IList<HGProgramItem> programs)
        {
            // Total = total;
            Programs = new List<HGProgramItem>();
        }
        // public int Total { get; set; }
        public IList<HGProgramItem> Programs { get; set; }
    }
}
