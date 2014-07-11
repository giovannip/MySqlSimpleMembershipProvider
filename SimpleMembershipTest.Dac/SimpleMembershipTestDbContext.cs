using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using MySql.Web.Security;
using MySql.Data.MySqlClient;
using MySql.Web.Extension.MySql.Web.Security.Tables.Negocio;

namespace SimpleMembershipTest.Dac
{
    public class SimpleMembershipTestDbContext : MySqlSecurityDbContext
    {
        // public non argument constructor for MySqlSimpleMembershipProvider
        public SimpleMembershipTestDbContext()
            : base("SimpleMembershipTestDbContext")
        {
        }

        public static SimpleMembershipTestDbContext CreateContext()
        {
            return new SimpleMembershipTestDbContext();
        }

        public DbSet<UserProperty> UserProperties { get; set; }

        public DbSet<Banco> Bancos { get; set; }
    }
}
