﻿using System;
using ContactsManagerBL.Enums;

namespace ContactsManagerBL.Models
{
    public class Phone
    {
        public Guid Id { get; set; }
        public PhoneNumber Number { get; set; }
        public PhoneType PhoneType { get; set; }
    }
}
