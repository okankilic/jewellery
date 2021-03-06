﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jewellery.Data.Common.Models
{
    public class AccountDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Lütfen ad ve soyad bilgilerini giriniz")]
        [Display(Name = "Ad Soyad")]
        public string FullName { get; set; }

        [Display(Name = "Cep Telefonu")]
        [Phone(ErrorMessage = "Lütfen geçerli bir cep telefonu numarası giriniz")]
        [Required(ErrorMessage = "Lütfen cep telefonu bilgilerini giriniz")]
        public string MobilePhone { get; set; }

        [Display(Name = "Şifre")]
        [Required(ErrorMessage = "Lütfen şifre bilgilerini giriniz")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Rol")]
        public string Role { get; set; }
    }
}
