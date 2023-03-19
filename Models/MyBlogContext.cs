using Microsoft.EntityFrameworkCore;

namespace razorweb2.models
{
    public class MyBlogContext: DbContext{
        public MyBlogContext(DbContextOptions<MyBlogContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder builder){
            base.OnConfiguring(builder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuiler){
            base.OnModelCreating(modelBuiler);
        }
        

        public DbSet<Article> articles{set;get;}
        
    }
}