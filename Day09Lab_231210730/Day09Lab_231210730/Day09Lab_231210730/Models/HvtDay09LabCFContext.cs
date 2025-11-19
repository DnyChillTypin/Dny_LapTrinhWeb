using Microsoft.EntityFrameworkCore;

namespace Day09Lab_231210730.Models
{
    public class HvtDay09LabCFContext : DbContext
    {
        public HvtDay09LabCFContext(DbContextOptions<HvtDay09LabCFContext> options) : base(options) { }
        public DbSet<HvtLoai_San_Pham> hvtLoai_San_Phams { get; set; }
        public DbSet<HvtSan_Pham> hvtSan_Phams { get; set; }
    }
}
