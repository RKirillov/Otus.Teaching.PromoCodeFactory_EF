﻿using System;
using System.Collections.Generic;

namespace Otus.Teaching.PromoCodeFactory.Core.Domain.PromoCodeManagement
{
    public class Preference
        : BaseEntity
    {
        public string Name { get; set; }

        //public Guid PromoCodeId { get; set; }
        //добавил
        //public virtual PromoCode PromoCode { get; set; }

        //public virtual ICollection<CustomerPreference> Customers { get; set; }//можно не указывать
    }
}