using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// using System.Threading.Tasks;
// using Newtonsoft.Json.Linq; // This is also OK

namespace HGSystem.Model
{
    public class OrgId
    {
        private String orgName;
        private String orgid;
        public String OrgName { get; set; }
        public String Orgid { get; set; }
    }
    public class HGUser
    {
        private String id;
        private String userType;
        private String userid;
        private String orgType;
        private String status;
        private String orgIntro;
        private String orgName;
        private String name;
        private String fileUrl;
        private String fileId;
        private String token;
        private String orgNames;
        // private JArray orgIds; // This is also OK
        private OrgId[] orgIds;
        public String Id { get; set; }
        public String UserType { get; set; }
        public String Userid { get; set; }
        public String OrgType { get; set; }
        public String Status { get; set; }
        public String OrgIntro { get; set; }
        public String OrgName { get; set; }
        public String Name { get; set; }
        public String FileUrl { get; set; }
        public String FileId { get; set; }
        public String Token { get; set; }
        public String OrgNames { get; set; }
        // public JArray OrgIds { get; set; } // This is also OK
        public OrgId[] OrgIds {get; set;}
        /*
         {
        "id": "180919101033025850632",
        "userType": "2",
        "orgid": "18091910104183120964",
        "orgType": "2",
        "status": "1",
        "orgIntro": "中少红卡（北京）教育科技有限公司是一家记录1.3亿少年儿童成长足迹的大数据平台，下设内容公司、硬件公司、大数据公司、成长激励体系公司、基金公司等二级分公司。具体包括中少之声（北京）教育科技有限公司、中少成长（北京）教育科技有限公司、中少物联（北京）教育科技有限公司等。\n目前我们红卡之家APP覆盖人群已超过 100万少年儿童，未来我们将覆盖1.3亿少年儿童，成为全国智慧校园规模最大的公司；全国校内外德育教育第一品牌；全国儿童智能穿戴千万级产品，市场占有率第一。目前我们红卡之家APP覆盖人群已超过 100万少年儿童，未来我们将覆盖1.3亿少年儿童，成为全国智慧校园规模最大的公司；全国校内外德育教育第一品牌；全国儿童智能穿戴千万级产品，市场占有率第一。目前我们红卡之家APP覆盖人群已超过 100万少年儿童，未来我们将覆盖1.3亿少年儿童，成为全国智慧校园规模最大的公司；全国校内外德育教育第一品牌；全国儿童智能穿戴千万级产品，市场占有率第一。目前我们红卡之家APP覆盖人群已超过 100万少年儿童，未来我们将覆盖1.3亿少年儿童，",
        "orgName": "红广小学",
        "name": "静静",
        "fileUrl": "/s1/d1/hongkaFiles/2018/1227/10/1545876078388.png",
        "fileId": "100146356",
        "token": "678a6c6f-6a99-432f-8b83-5f6c3c01c5a1",
        "orgNames": "",
        "orgIds": [
            {
                "orgName": "",
                "orgid": "180919101033025850632"
            }
        ]
        },*/
   
    }
}
