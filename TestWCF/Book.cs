using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
//using System.Runtime.Serialization;
//using System.ServiceModel;
//using System.ServiceModel.Web;
//using System.Text;

namespace TestWCF
{
    [DataContract]
    public class Book
    {
        [DataMember]
        public string ID { get; set; }
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public string Author { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public string Genre { get; set; }
        [DataMember]
        public decimal Price { get; set; }
        [DataMember]
        public DateTime PublishDate { get; set; }


    }
}
