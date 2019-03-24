using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HGSystem.Model
{
    public class ComCategory
    {
        public String Label { get; set; }
        public int Value { get; set; }
    }
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
        // 暂时不考虑缓存Album
        public HGAlbum Album { get; set; }
    }
}
