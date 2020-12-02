using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DoAn.Areas.Admin.Models
{
    public class DongDienThoaiModel
    {
        [Key]
        public string MaDT { get; set; }
        public string TenDongDT { get; set; }
        public ICollection<DienThoaiModel> listDienThoai { get; set; }

    }
}