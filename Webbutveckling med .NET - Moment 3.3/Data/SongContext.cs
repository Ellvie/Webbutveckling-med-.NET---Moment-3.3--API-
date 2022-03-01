using Microsoft.EntityFrameworkCore;
using Webbutveckling_med_.NET___Moment_3._3.Models;

namespace Webbutveckling_med_.NET___Moment_3._3.Data
{
    public class SongContext : DbContext
    {
        public SongContext(DbContextOptions<SongContext> options) : base(options)
        {

        }


        public DbSet<Song> Songs { get; set; }
    }
}
