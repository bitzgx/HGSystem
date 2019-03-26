using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// using System.Threading.Tasks;

namespace HGSystem.Model
{
    public class SliceParams
    {
        public int pageNum { get; set; }
        public int pageSize { get; set; }
    } 
    // 搜索专辑的参数
    public class HGAlbumSearchParams
    {
        public HGAlbumSearchParams(String on, int[] ac, String ai, String an, String abs, String ctbt, String ctet, int pn, int ps, String dir, String ob)
        {
            orgName = on;
            albumCategory = ac;
            albumId = ai;
            albumName = an;
            albumStatus = abs;
            createTimeBeginTime = ctbt;
            createTimeEndTime = ctet;
            sliceParams = new SliceParams();
            sliceParams.pageNum = pn;
            sliceParams.pageSize = ps;
            direction = dir;
            orderBy = ob;
        }
        
        public HGAlbumSearchParams( int pn, int ps, String ai = null, String an = null):
            this(pn, ps, ai, an, new int[0])
        {
        }

        public HGAlbumSearchParams(int pn, int ps, String ai, String an, int[] ac, String on = null, String abs = null, String ctbt = null, String ctet = null, String dir = null, String ob = null) :
            this(on, ac, ai, an, abs, ctbt, ctet, pn, ps, dir, ob)
        {
        }

        public String orgName {get; set;}
        public int[] albumCategory {get; set;}
        public String albumId {get; set;}
        public String albumName {get; set;}
        public String albumStatus {get; set;}
        public String createTimeBeginTime {get; set;}
        public String createTimeEndTime {get; set;}
        public SliceParams sliceParams {get; set;}
        public String direction {get; set;}
        public String orderBy {get; set;}
        /*"{\"orgName\": \"\",\"albumCategory\": [],\"albumId\": null,\"albumName\": null,\"albumStatus\": null
        ,\"createTimeBeginTime\": null,\"createTimeEndTime\": null,\"sliceParams\": {\"pageNum\": 1,\"pageSize\": 10},\"direction\": null,\"orderBy\": null}";*/
    }

    // 新建专辑的参数
    public class HGAlbumParams
    {
        public HGAlbumParams(String albumName, int albumType, String albumIntro, String fileUrl, String albumFileId, String albumLabel, int albumCategoryIdL1, int albumCategoryIdL2, int albumCategoryIdL3)
        {
            this.albumName = albumName;
            this.albumType = albumType;
            this.albumIntro = albumIntro;
            this.fileUrl = fileUrl;
            this.albumFileId = albumFileId;
            this.albumLabel = albumLabel;
            this.albumCategoryId = new int[3];
            this.albumCategoryId[0] = albumCategoryIdL1;
            this.albumCategoryId[1] = albumCategoryIdL2;
            this.albumCategoryId[2] = albumCategoryIdL3;
        }
        public String albumName { get; set; }
        public int albumType { get; set; }
        public String albumIntro { get; set; }
        public String fileUrl { get; set; }
        public String albumFileId { get; set; }
        public String albumLabel { get; set; }
        public int[] albumCategoryId { get; set; }
    }

    public class HGAlbumItem
    {
        /*
        private int albumId;
        private String albumName;
        private String albumLabel;
        private int albumType;
        private int albumPersonId;
        private int albumPersonType;
        private String albumIntro;
        private String albumFileId;
        private String albumAuthor;
        private String albumAuthorType;
        private String albumUpcount;
        private int albumIsup;
        private String albumCollectciunt;
        private String albumBrowsecount;
        private String albumBrowsePersoncount;
        private String albumOpencount;
        private String albumPersoncount;
        private String albumDowncount;
        private String albumPaytype;
        private String albumPrice;
        private String albumPaycount;
        private String albumOperater;
        private String albumUserId;
        private String albumChecktime;
        private long albumUtime;
        private long albumCtime;
        private String albumProvince;
        private String albumCity;
        private String albumCounty;
        private String albumVillages;
        private String albumStatus;
         */

        /* doc V1.0
        public int AlbumId { get; set; }
        public String AlbumName { get; set; }
        public String AlbumLabel { get; set; }
        public int AlbumType { get; set; }
        public int AlbumPersonId { get; set; }
        public int AlbumPersonType { get; set; }
        public String AlbumIntro { get; set; }
        public String AlbumFileId { get; set; }
        public String AlbumAuthor { get; set; }
        public String AlbumAuthorType { get; set; }
        public String AlbumUpcount { get; set; }
        public int AlbumIsup { get; set; }
        public String AlbumCollectciunt { get; set; }
        public String AlbumBrowsecount { get; set; }
        public String AlbumBrowsePersoncount { get; set; }
        public String AlbumOpencount { get; set; }
        public String AlbumPersoncount { get; set; }
        public String AlbumDowncount { get; set; }
        public String AlbumPaytype { get; set; }
        public String AlbumPrice { get; set; }
        public String AlbumPaycount { get; set; }
        public String AlbumOperater { get; set; }
        public String AlbumUserId { get; set; }
        public String AlbumChecktime { get; set; }
        public long AlbumUtime { get; set; }
        public long AlbumCtime { get; set; }
        public String AlbumProvince { get; set; }
        public String AlbumCity { get; set; }
        public String AlbumCounty { get; set; }
        public String AlbumVillages { get; set; }
        public String AlbumStatus { get; set; }
         */
 
        public String AlbumName { get; set; }
        public String AlbumUpcount { get; set; }
        public long AlbumCreateTime { get; set; }
        public String AlbumCategoryName { get; set; }
        public String AlbumId { get; set; }
        public int AlbumIsup { get; set; }
        public int AlbumCategoryId { get; set; }
        public int AlbumType { get; set; }
        public int AlbumOpencount { get; set; }
        public String FileUrl { get; set; }
        public long AlbumUpdateTime { get; set; }        
        public String FileId { get; set; }
    }
    public class HGAlbum
    {
        /*
        private int total;
        private HGAlbumItem[] data;
         */

        public int Total { get; set; }
        public HGAlbumItem[] Data { get; set; }
    }
}
