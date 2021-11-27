using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Apps.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

public class AccountContext : IdentityDbContext
    {
        public AccountContext (DbContextOptions<AccountContext> options)
            : base(options)
        {
        }

        public DbSet<Apps.Models.Accountdata> Accountdata { get; set; }
    }