using Serwis.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Serwis.Context
{
    public class ZlecenieContext : DbContext
    {
       public DbSet<Zlecenie> Zlecenia { get; set; }
    }
}