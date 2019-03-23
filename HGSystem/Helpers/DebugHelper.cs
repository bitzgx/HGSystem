using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HGSystem.Helpers
{    
    public class DebugHelper
    {
        private static DebugHelper m_debug_helper = new DebugHelper();
        private DebugHelper()
        {
            IsServerFail = true;
            FastUserLogin = true;
            FakeNewAlbum = false;
        }

        public static DebugHelper getInstance()
        {
            return m_debug_helper;
        }
        // private static bool isServerFail = true;
        public bool IsServerFail { get; set; }
        public bool FastUserLogin { get; set; }
        public bool FakeNewAlbum { get; set; }
    }
}
