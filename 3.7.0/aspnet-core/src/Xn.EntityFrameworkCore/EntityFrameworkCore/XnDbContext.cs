using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Xn.Authorization.Roles;
using Xn.Authorization.Users;
using Xn.Models;
using Xn.Models.Company;
using Xn.Models.Employees;
using Xn.MultiTenancy;

namespace Xn.EntityFrameworkCore
{
    public class XnDbContext : AbpZeroDbContext<Tenant, Role, User, XnDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Company> Companies { get; set; }
        public DbSet<Employees> Employeeses { get; set; }
        public DbSet<Permissions> PhanQuyens { get; set; }
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<Ncc> Nccs { get; set; }
        public DbSet<Kh> Khs { get; set; }
        public DbSet<DoiTac> DoiTacs { get; set; }
        public DbSet<History> Histories { get; set; }
        public DbSet<XuatNhap> XuatNhaps { get; set; }
        public DbSet<QlXuatNhap> QlXuatNhaps { get; set; }
        public DbSet<ChiPhi> ChiPhis { get; set; }
        public DbSet<ChiPhiTx> ChiPhiTxes { get; set; }
        public DbSet<CongNo> CongNoes { get; set; }
        public DbSet<ChiphiDt> ChiphiDts { get; set; }
        public DbSet<DoanhThuTx> DoanhThuTxes { get; set; }
        public DbSet<QlCongNoChiTiet> QlCongNoChiTiets { get; set; }
        public DbSet<QlDoanhthu> QlDoanhthus { get; set; }
        public DbSet<QlNcc> QlNccs { get; set; }
        public XnDbContext(DbContextOptions<XnDbContext> options)
            : base(options)
        {
        }
    }
}
