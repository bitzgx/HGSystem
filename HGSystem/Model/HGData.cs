using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HGSystem.Model
{
    public class HGData
    {
        private static HGData m_hg_data = new HGData();

        private HGData() { }
        public static HGData getInstance()
        {
            return m_hg_data;
        }
        public HGComCategory[] ComCategory { get; set; }
        public HGUser User { get; set; }
    }
}
