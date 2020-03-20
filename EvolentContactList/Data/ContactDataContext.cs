using EvolentContactList.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace EvolentContactList.Data
{
    public class ContactDataContext: DbContext
    {
        public ContactDataContext(DbContextOptions<DbContext> options):base(options)
        {

        }

        public ContactDataContext([NotNullAttribute] DbContextOptions options) : base(options)
        {
        }
             public DbSet<Contact> Contacts { get; set; }
    }
}
