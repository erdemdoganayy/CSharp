using DictionaryApp.Entites;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DictionaryApp
{
    public class DictionaryContext : DbContext
    {
        public DbSet<Word> Words { get; set; }
        
    }
}
