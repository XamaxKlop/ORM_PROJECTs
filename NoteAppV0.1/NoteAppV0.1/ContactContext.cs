using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace NoteAppV0._1
{
    class ContactContext : DbContext
    {
        public ContactContext() : base("DbConnection")
        { }
        public DbSet<Contact> Contacts { get; set; }
    }
}
