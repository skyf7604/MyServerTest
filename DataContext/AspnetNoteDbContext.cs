using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using aspTest3.Models;

using Microsoft.EntityFrameworkCore;

using Pomelo.EntityFrameworkCore.MySql.Storage;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace aspTest3.DataContext
{
    public class AspnetNoteDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Note> Notes { get; set; }

        //이렇게 해주면 마이그레이션이 되고 DB가 생성이 됨

        protected override void OnConfiguring( DbContextOptionsBuilder optionsBuilder )
        {
            optionsBuilder.UseMySql( "Server=unity-mysql.mysql.database.azure.com; Port=3306; Database=AspDB; Uid=skyf7604@unity-mysql; Pwd=slowlife2017!; SslMode=Preferred;", 
                options => options.CharSet( CharSet.Utf8 ).CharSetBehavior( CharSetBehavior.AppendToAllColumns ));


        }



    }
}
