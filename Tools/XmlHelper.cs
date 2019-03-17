using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml;

namespace Ourtm.Common
{
    public class XmlHelper
    {

        /// <summary>
        /// 获取配置sql
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string GetSql(string key)
        {
            var sql = "";
            try
            {
                var sqlkeys = key.Split('.');

                var xmlNode = ReadMapping(sqlkeys[0]);

                var list = xmlNode.SelectNodes("Sql");

                foreach (XmlNode node in list)
                {
                    if (node.Attributes["key"].Value.Equals(sqlkeys[1]))
                    {
                        return node.InnerText;
                    }
                }

                sql = xmlNode.SelectNodes($"SqlMap[@key='{sqlkeys[1]}']")[0].InnerText;
            }
            catch (Exception ex)
            {
                LogHelper.Error("sqlmappingErrors:" + ex);
            }
            return sql;
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        private static XmlNode ReadMapping(string key)
        {

            var name = "SqlMapping.xml";

            var path = "";

            var xml = (XmlDocument)HttpRuntime.Cache[name];

            if (xml == null)
            {
                path = AppDomain.CurrentDomain.BaseDirectory + ($@"\Files\Sql\{name}");
                var document = new XmlDocument();
                document.Load(path);
                if (document != null)
                {
                    xml = document;
                    HttpRuntime.Cache.Insert(name, xml, new System.Web.Caching.CacheDependency(path), DateTime.Now.AddHours(24), TimeSpan.Zero);
                }
            }

            var list = xml.SelectNodes("SqlMapping/SqlMaps");

            foreach (XmlNode node in list)
            {
                if (node.Attributes["key"].Value.Equals(key))
                {
                    return node;
                }
            }

            return null;
        }


    }

}
