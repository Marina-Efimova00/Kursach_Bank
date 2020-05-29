﻿using BankBussinessLogic.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankBussinessLogic.BindingModel
{

    public class ServiceBindingModel
    {
        public int? Id { get; set; }
        public string TypeService { get; set; }
        public int? WorkerId { get; set; }
        public Status Status { get; set; }
        public List<ServiceClientBindingModel> ServiceClients { get; set; }
    }
}
