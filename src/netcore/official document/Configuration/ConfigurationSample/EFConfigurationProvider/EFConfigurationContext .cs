using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using ConfigurationSample.Models;

namespace ConfigurationSample.EFConfigurationProvider
{
    public class EFConfigurationContext : DbContext
    {
        public EFConfigurationContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<EFConfigurationValue> Values { get; set; }
    }
}