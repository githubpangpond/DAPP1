using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DAPP.Models;


namespace DAPP.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<LOSDATCollatAppraisal> tblLOSDATCollatAppraisal { get; set; }

        public DbSet<LOSDATCollatApprValue> tblLOSDATCollatApprValue { get; set; }

    }
}
