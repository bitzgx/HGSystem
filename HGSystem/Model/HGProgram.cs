using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HGSystem.Model
{
    public class HGProgramParams
    {
        public HGProgramParams(string ai, int ic, int pn, int ps, int mrs)
        {
            albumId = ai;
            isCheck = ic;
            sliceParams = new SliceParams();
            sliceParams.pageNum = pn;
            sliceParams.pageSize = ps;
            materialRecycleStatus = mrs;
        }

        public String albumId { get; set; }
        public int isCheck { get; set; }
        public SliceParams sliceParams { get; set; }
        public int materialRecycleStatus { get; set; }
    }
    public class HGProgramItem
    {
        public int MaterialSort { get; set; }
        public String MaterialPublisher { get; set; }
        public String MateriaAlbumId { get; set; }
        public String MaterialArea { get; set; }
        public String MaterialAuthor { get; set; }
        public String LikeCount { get; set; }
        public int SelectedStatus { get; set; }
        public String ShowRange { get; set; }
        public int MaterialTranscodingStatus { get; set; }
        public String ShowRangeId { get; set; }
        public String FileUrl1 { get; set; }
        public String MaterialCreater { get; set; }
        public String TableAutoUptime { get; set; }
        public int Id { get; set; }
        public String MaterialOpenPersoncount { get; set; }
        public String MaterialAlbumName { get; set; }
        public int MaterialIscheck { get; set; }
        public String MaterialFileId1 { get; set; }
        public String MaterialMaterialCollectcount { get; set; }
        public String MaterialId { get; set; }
        public String MaterialOpencount { get; set; }
        public String MaterialAlbumCategoryName { get; set; }
        public long MaterialUtime { get; set; }
        public String MaterialName { get; set; }
        public String ProvinceName { get; set; }
        public int MaterialCreaterType { get; set; }
        public long MaterialCtime { get; set; }
        public int MaterialStatus { get; set; }
        public String CityCode { get; set; }
        public String MaterialFileId { get; set; }
        public String OrderWeight { get; set; }
        public String MaterialChecktime { get; set; }
        public String MaterialPublisherName { get; set; }
        public String CityName { get; set; }
        public String MaterialPublisherOrgName { get; set; }
        public String MaterialCheckDesc { get; set; }
        public String FileUrl { get; set; }
        public String NowBelongId { get; set; }
        public String MaterialUserId { get; set; }
        public String MaterialAlbumIntro { get; set; }
        public String CountyName { get; set; }
        public String MaterialLabel { get; set; }
        public String ShowRangeType { get; set; }
        public String NowBelongType { get; set; }
        public String ProvinceCode { get; set; }
        public int MaterialType { get; set; }
        public int MaterialRecycleStatus { get; set; }
        public String MaterialPublisherOrg { get; set; }
        public int MaterialDuration { get; set; }
        public String CountyCode { get; set; }
        public long MaterialOtime { get; set; }
        public String MaterialPushcount { get; set; }
        public int MaterialPublisherType { get; set; }
    }
    // depreated
    public class HGProgramItem2
    {
        public HGProgramItem2(String name, int timeLen, string category, DateTime createdAt, int playAmount, int shareAmount)
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
        //public HGProgram()//int total, IList<HGProgramItem> programs)
        //{
        //    // Total = total;
        //    Programs = new List<HGProgramItem>();
        //}
        public int Total { get; set; }
        public HGProgramItem[] Programs { get; set; }
    }
}
