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
        public string TenTK { get; set; }
        public string MatKhau { get; set; }
        [Range(0, 1)]
        public int LoaiTK{ get; set; }
        public ICollection<HoaDonModel> listHoaDon { get; set; }


    }
}
