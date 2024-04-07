﻿using System;
using System.Runtime;
using Otus.Teaching.PromoCodeFactory.Core.Domain.Administration;

namespace Otus.Teaching.PromoCodeFactory.Core.Domain.PromoCodeManagement
{
    public class PromoCode
        : BaseEntity
    {
        public string Code { get; set; }

        public string ServiceInfo { get; set; }

        public DateTime BeginDate { get; set; }

        public DateTime EndDate { get; set; }

        public string PartnerName { get; set; }

        //public Employee PartnerManager { get; set; }


        public Preference Preference { get; set; }

        public Guid CustomerId { get; set; }

        public Customer Customer { get; set; }
        //TODO добавлен CustomerId Связь Customer и Promocode реализовать через One-To-Many
    }
}