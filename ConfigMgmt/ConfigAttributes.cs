using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.Threading.Tasks;

namespace EMDRGatherer.ConfigMgmt
{
    [Serializable(), XmlRootAttribute("EMDR")]
    public class ConfigAttributes
    {
        [XmlIgnore]
        public bool isConfiged { get; set; }
        
        [XmlAttribute("ConnectionString")]
        public string DataSource { get; set; }

        [XmlAttribute("MergeOrderData")]
        public bool MergeDuplicates { get; set; }

        [XmlAttribute("TrimOrderDays")]
        public int TrimOrdersDays { get; set; }

        [XmlAttribute("TrimHistoryDays")]
        public int TrimHistDays { get; set; }

        [XmlAttribute("Server")]
        public string EMDRServer { get; set; }

        [XmlAttribute("MQZeroAdvancedEnabled")]
        public bool AdvMsgBufferEnabled { get; set; }

        [XmlAttribute("MQZeroHighWaterMark")]
        public int QueueHighWaterMark { get; set; }

        [XmlAttribute("MQZeroDiskBufferMax")]
        public int QueueDiskBufferSize { get; set; }
       
    }
}
