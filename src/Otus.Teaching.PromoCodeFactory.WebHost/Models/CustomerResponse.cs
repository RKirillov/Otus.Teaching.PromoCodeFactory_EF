﻿using System;
using System.Collections.Generic;
using Otus.Teaching.PromoCodeFactory.Core.Domain.PromoCodeManagement;

namespace Otus.Teaching.PromoCodeFactory.WebHost.Models
{
    public class CustomerResponse
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public List<PromoCodeShortResponse> PromoCodesShotResponse { get; set; }

        public virtual List<PreferenceResponse> PreferencesResponse { get; set; }
    }
}