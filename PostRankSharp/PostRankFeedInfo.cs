using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace PostRankSharp
{
    public class PostRankFeedInfo
    {

        public PostRankFeedInfo(XElement item)
        {
            Link = Utilities.GetElementValue(item.Element("link"));
            Title = Utilities.GetElementValue(item.Element("title"));
            XmlUrl = Utilities.GetElementValue(item.Element("xml"));
            Id = Utilities.GetElementValue(item.Element("id"));
            FeedId = Convert.ToInt32(Utilities.GetElementValue(item.Element("feed_id")));
            Description = Utilities.GetElementValue(item.Element("description"));
            Ttl = Convert.ToInt32(Utilities.GetElementValue(item.Element("ttl")));

            
        }

        public int Ttl { get; set; }
        public string XmlUrl { get; set; }
        public string Title { get; set; }
        public string Id { get; set; }
        public int FeedId { get; set; }
        public string Link { get; set; }
        public string Description { get; set; }
    }
}
