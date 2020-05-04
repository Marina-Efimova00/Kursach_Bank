using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace BankModel
{
    [DataContract]
    public class Score
    {
        [DataMember]
        public int Number { get; set; }
        [DataMember]
        public int PreviousMonth { get; set; }
        [DataMember]
        public int ThisMoment { get; set; }
        [DataMember]
        public int NextMonth { get; set; }

    }
}
