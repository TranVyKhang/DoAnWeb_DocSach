﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoAn_WebDocSach.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class NOIDUNGSACH
    {
        [DisplayName("Mã sách")]
        public string maSach { get; set; }
        [DisplayName("Mã chương")]
        public string maChuong { get; set; }
        [DisplayName("Tên chương")]
        [Required(ErrorMessage = "*")]
        public string tenChuong { get; set; }
        [DisplayName("Nội dung")]
        [Required(ErrorMessage = "*")]
        public string noiDung { get; set; }

        public virtual SACH SACH { get; set; }
    }
}
