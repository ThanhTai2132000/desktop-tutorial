using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DoAn.Areas.Admin.Models
{
    public class DienThoaiModel
    {
        [Key]
        public int ID { get; set; }
        public string MaDongDT { get; set; }
        [ForeignKey("MaDongDT")]
        public string MaLoai { get; set; }
        public string TenDongDT { get; set; }
        public string Hinh { get; set; }
        public float DonGia { get; set; }
        public float GiaKM { get; set; }
        public virtual  DongDienThoaiModel DongDT { get; set; }
    }
}
