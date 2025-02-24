﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using WebUI.Entity.Diets.Abstract;
using WebUI.Entity.Diseases.Abstract;

namespace WebUI.Entity
{
    public class Patient
    {
        public int Id { get; set; }
        [DisplayName("Adı")]
        public string FirstName { get; set; }
        [DisplayName("Soyadı")]
        public string LastName { get; set; }
        [DisplayName("TC Kimlik Numarası")]
        public string TcNo { get; set; }
        [DisplayName("Hastalık")]
        public Disease Disease { get; set; }
        [DisplayName("Diyet")]
        public Diet Diet { get; set; }
        public Dietician Dietician { get; set; }
    }
}