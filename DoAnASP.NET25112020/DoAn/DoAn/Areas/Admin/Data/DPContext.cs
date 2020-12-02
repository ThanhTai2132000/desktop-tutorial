using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoAn.Areas.Admin.Data
{
    public class DPContext : DbContext
    {
        public DPContext(DbContextOptions<DPContext> options) : base(options) {}
        public DbSet<Models.DienThoaiModel> DienThoai { get; set; }
        public DbSet<Models.DongDienThoaiModel> DongDienThoai { get; set; }
        public DbSet<Models.HoaDonModel> HoaDong { get; set; }
        public DbSet<Models.ChiTietHoaDonModel> ChiTietHoaDon { get; set; }

    }
}
