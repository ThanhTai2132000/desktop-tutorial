using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DoAn.Areas.Admin.Models
{
    public class ChiTietHoaDonModel
    {
        [Key]
        public int ID { get; set; }
        public string MaHoaDon { get; set; }
        [ForeignKey("MaHoaDon")]
        public virtual HoaDonModel HoaDon { get; set; }
        public int IDDienThoai { get; set; }
        [ForeignKey("IDDienThoai")]
        public virtual DienThoaiModel DienThoai { get; set; }
        public int SoLuong { get; set; }
        public float DonGia { get; set; }
        public float GiaKhuyenMai { get; set; }
        
        
    }
}
