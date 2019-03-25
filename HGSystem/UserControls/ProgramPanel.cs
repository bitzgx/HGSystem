using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HGSystem.Model;

namespace HGSystem.UserControls
{
    public partial class ProgramPanel : UserControl
    {
        private HGProgram m_hg_program;
        private IList<ProgramItemRow> m_lst_pirs = new List<ProgramItemRow>();
        public ProgramPanel()
        {
            InitializeComponent();

            SuggestedHeight = 600;

            InitFakePrograms();
        }

        private void InitFakePrograms()
        {
            if (m_hg_program == null)
            {
                m_hg_program = new HGProgram();
            }
            m_hg_program.Programs.Add(new HGProgramItem("2018年3月20日.mp3", 320, "短音频", DateTime.Now, 100000, 100000));
            m_hg_program.Programs.Add(new HGProgramItem("2018年3月20日.mp3", 310, "短音频", DateTime.Now.AddDays(1), 2000, 2000));
            m_hg_program.Programs.Add(new HGProgramItem("2018年3月20日.mp3", 310, "短音频", DateTime.Now.AddDays(1), 2000, 2000));
            m_hg_program.Programs.Add(new HGProgramItem("2018年3月20日.mp3", 310, "短音频", DateTime.Now.AddDays(1), 2000, 2000));
            m_hg_program.Programs.Add(new HGProgramItem("2018年3月20日.mp3", 310, "短音频", DateTime.Now.AddDays(1), 2000, 2000));
            m_hg_program.Programs.Add(new HGProgramItem("2018年3月20日.mp3", 310, "短音频", DateTime.Now.AddDays(1), 2000, 2000));
            m_hg_program.Programs.Add(new HGProgramItem("2018年3月20日.mp3", 310, "短音频", DateTime.Now.AddDays(1), 2000, 2000));
            m_hg_program.Programs.Add(new HGProgramItem("2018年3月20日.mp3", 310, "短音频", DateTime.Now.AddDays(1), 2000, 2000));
            m_hg_program.Programs.Add(new HGProgramItem("2018年3月20日.mp3", 310, "短音频", DateTime.Now.AddDays(1), 2000, 2000));
            m_hg_program.Programs.Add(new HGProgramItem("2018年3月20日.mp3", 310, "短音频", DateTime.Now.AddDays(1), 2000, 2000));
            m_hg_program.Programs.Add(new HGProgramItem("2018年3月20日.mp3", 310, "短音频", DateTime.Now.AddDays(1), 2000, 2000));
        }

        private void m_tbx_programs_Click(object sender, EventArgs e)
        {

        }

        private int m_curr_page = 0;
        private int m_curr_rows_per_page = 0;
        public int SuggestedHeight { get; set; }


        private void LoadPrograms()
        {
            // TODO: 这个判断很重要，因为PagerControl会多次调用PageChange，没有必要我们不要多次调用网络。
            if (m_curr_page == m_pc_programs.CurrentPage && m_curr_rows_per_page == m_pc_programs.RowsPerPage)
            {
                Console.WriteLine("No need to do duplicated operation");
                return;
            }
            m_curr_page = m_pc_programs.CurrentPage;
            m_curr_rows_per_page = m_pc_programs.RowsPerPage;
            m_pir_no1.Hide();
            m_pir_no2.Hide();
            m_pir_no3.Hide();
            m_pir_no4.Hide();
            m_pir_no5.Hide();
            m_lst_pirs.Clear();
            int count = calcProgramCounts();
            for ( int i = 0; i < count; i++ )
            {
                ProgramItemRow pir = new ProgramItemRow();
                pir.Size = new Size(1160, 38);
                pir.Location = new Point(0, 226 + 40 * i);
                m_lst_pirs.Add(pir);
                this.Controls.Add(pir);
            }
            m_lbl_sep4.Location = new Point(0, 226 + 40 * count + 10);
            m_bte_upload.Location = new Point(44, 226 + 40 * count + 25);
            m_pc_programs.Location = new Point(680, 226 + 40 * count + 25);
            SuggestedHeight = 226 + 40 * count + 40 + m_pc_programs.Height;
            /*
            if (SuggestedHeight >= 600)
            {
                m_lbl_sep1.Size = new Size(1160, 3);
                m_lbl_sep2.Size = new Size(1160, 3);
                m_lbl_sep3.Size = new Size(1160, 3);
                m_lbl_sep4.Size = new Size(1160, 3);
            }*/
        }
        private int calcProgramCounts()
        {
            int total_programs = m_hg_program.Programs.Count;
            int rows_per_page = m_curr_rows_per_page;
            if (rows_per_page <= 0)
                return 0;
            int pages = (total_programs - 1) / rows_per_page + 1;
            if (m_curr_page == 0)
                m_curr_page = 1;
            if (m_curr_page == pages)
                return total_programs % rows_per_page;
            return rows_per_page;
        }

        private void ShowPrograms()
        {

        }
        private void ProgramPanel_Load(object sender, EventArgs e)
        {
            if (m_hg_program != null)
            {
                m_pc_programs.RecordCount = m_hg_program.Programs.Count;
                m_pc_programs.RowsPerPage = 5;
                m_pc_programs.CurrentPage = 1;
            }
            LoadPrograms();
        }
    }
}
