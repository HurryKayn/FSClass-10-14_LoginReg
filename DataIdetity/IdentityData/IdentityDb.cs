using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataIdentity.IdentityData
{
    public class IdentityDb : IdentityDbContext<IdentityUser>
    {
        //*** inserire Sempre il costruttore in caso contrario non esegue migration
        public IdentityDb (DbContextOptions<IdentityDb> options):base(options) 
        {
        
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
