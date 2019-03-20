using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// using System.Threading.Tasks;

namespace HGSystem.Model
{
    public class HGAlbumItem
    {
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
    }
    public class HGAlbum
    {
        private int total;
        private HGAlbumItem[] data;

        public int Total { get; set; }
        public HGAlbumItem[] Data { get; set; }
    }
}
