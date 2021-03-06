﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HGSystem.Model;
using HGSystem.UI;

namespace HGSystem.UserControls
{
    public partial class ProgramPanel : UserControl
    {
        private HGProgram m_hg_program;
        private IList<ProgramItemRow> m_lst_pirs = new List<ProgramItemRow>();
        private HGAlbumItem m_hgai;
        public HGAlbumItem HGAI { get { return m_hgai; } set { m_hgai = value; SetupPanel(); } }
        public ProgramPanel(HGAlbumItem hgai)
        {
            InitializeComponent();

            HGAI = hgai;
            SuggestedHeight = 600;
            // SetupPanel();
            // InitFakePrograms();
        }

        private void SetupPanel()
        {
            if (m_hgai == null)
                return;
            m_lbl_albumname.Text = String.IsNullOrEmpty(m_hgai.AlbumName) ? "未知编辑" : m_hgai.AlbumName;
            m_lbl_albumlabel.Text = "标签：";// TODO: + m_hgai.AlbumName ?
            m_lbl_cat.Text = "分类：" + m_hgai.AlbumCategoryName;
            m_lbl_albumintro.Text = "简介："; // TODO: + m_hgai.Al
            //TODO: 
            if ((ContentPublishPanel.AlbumType)m_hgai.AlbumType == ContentPublishPanel.AlbumType.AudioAlbum)
                m_bte_upload.Text = "上传音频";
            else
                m_bte_upload.Text = "上传视频";

            // TODO: hgpp's isCheck and materialRecycleStatus doens't make sence and can't be retreived by m_hgai
            HGProgramParams hgpp = new HGProgramParams(m_hgai.AlbumId, 2, 1, 5, 1);
            if (Helpers.DebugHelper.getInstance().SamplePrograms)
                hgpp = new HGProgramParams("190323013156596558242", 2, 1, 5, 1);
            m_hg_program = HGRestfulAPI.getInstance().getHGProgram(hgpp);
            LoadPrograms(true);
        }

        private void InitFakePrograms()
        {
            if (m_hg_program == null)
            {
                m_hg_program = new HGProgram();
            }
            /*
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
             */
        }

        private void m_tbx_programs_Click(object sender, EventArgs e)
        {

        }

        private int m_curr_page = 0;
        private int m_curr_rows_per_page = 0;
        public int SuggestedHeight { get; set; }
        public ContentPublishPanel.SubControlHeightChagned HeightChanged { get; set; }

        private void LoadPrograms(bool force_reload = false)
        {
            // TODO: 这个判断很重要，因为PagerControl会多次调用PageChange，没有必要我们不要多次调用网络。
            if (!force_reload && m_curr_page == m_pc_programs.CurrentPage && m_curr_rows_per_page == m_pc_programs.RowsPerPage)
            {
                Console.WriteLine("No need to do duplicated operation");
                return;
            }
            m_curr_page = m_pc_programs.CurrentPage;
            m_curr_rows_per_page = m_pc_programs.RowsPerPage;

            foreach (ProgramItemRow pir in m_lst_pirs)
                this.Controls.Remove(pir);
            m_lst_pirs.Clear();
            int count = calcProgramCounts();
            for ( int i = 0; i < count; i++ )
            {
                int index = (m_curr_page - 1) * m_curr_rows_per_page + i + 1;
                ProgramItemRow pir = new ProgramItemRow(index, m_hg_program.Data[index - 1]);
                pir.Size = new Size(1160, 38);
                pir.Location = new Point(0, 226 + 40 * i);
                m_lst_pirs.Add(pir);
                this.Controls.Add(pir);
            }
            m_lbl_sep4.Location = new Point(0, 226 + 40 * count + 10);
            m_bte_upload.Location = new Point(44, 226 + 40 * count + 25);
            m_pc_programs.Location = new Point(680, 226 + 40 * count + 25);
            SuggestedHeight = 226 + 40 * count + 40 + m_pc_programs.Height;
            if (HeightChanged != null)
                HeightChanged(this, SuggestedHeight);
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
            int total_programs = m_hg_program.Data.Length;
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
                m_pc_programs.RecordCount = m_hg_program.Data.Length;
                m_pc_programs.RowsPerPage = 5;
                m_pc_programs.CurrentPage = 1;
            }
            LoadPrograms();
        }

        private void m_bte_upload_Click(object sender, EventArgs e)
        {            
            if ((ContentPublishPanel.AlbumType)m_hgai.AlbumType == ContentPublishPanel.AlbumType.AudioAlbum)
            {
                UploadAudioForm uaf = new UploadAudioForm();
                uaf.ShowDialog();
            }
            else
            {
                UploadVideoForm uvf = new UploadVideoForm();
                uvf.ShowDialog();
            }
        }

        private void m_pc_programs_PageChange()
        {
            LoadPrograms();
        }
    }
}
