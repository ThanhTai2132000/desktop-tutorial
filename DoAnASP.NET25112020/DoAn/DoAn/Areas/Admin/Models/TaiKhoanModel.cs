using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DoAn.Areas.Admin.Models
{
    public class TaiKhoanModel
    {
        [Key]
        public string TaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public int MaTaiKhoan { get; set; }
        [ForeignKey("MaTaiKhoan")]
        

    }
}
