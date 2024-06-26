﻿using System;
using AutoMapper;
using Otus.Teaching.PromoCodeFactory.Core.Domain.Administration;
using Otus.Teaching.PromoCodeFactory.Core.Domain.PromoCodeManagement;

namespace Otus.Teaching.PromoCodeFactory.WebHost.Models
{
    [AutoMap(typeof(PromoCode), ReverseMap = true)]
    public class PromoCodeShortResponse
    {
        public Guid Id { get; set; }
        
        public string Code { get; set; }

        public string ServiceInfo { get; set; }

        public string? BeginDate { get; set; }

        public string? EndDate { get; set; }

        public string PartnerName { get; set; }
    }
}