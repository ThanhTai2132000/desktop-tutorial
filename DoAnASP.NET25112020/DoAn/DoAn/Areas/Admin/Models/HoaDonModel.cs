using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DoAn.Areas.Admin.Models
{
    public class HoaDonModel
    {
        [Key]
        public string MaHD { get; set; }
        public string MaTK { get; set; }
        [ForeignKey("MaTK")]
        public virtual TaiKhoanModel TaiKhoan { get; set; }
        public DateTime NgayLapHD { get; set; }
        public float TongTien { get; set; }
        public ICollection<ChiTietHoaDonModel> listChiTiet { get; set; }
    }
}
