using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace BankBussinessLogic.BindingModel
{
    [DataContract]
    public class CreateBindingModel
    {
        [DataMember]
        public int ClientId { get; set; }
        [DataMember]
        public int WorkerId { get; set; }
        [DataMember]
        public string TypeService { get; set; }
    }
}
