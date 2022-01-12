using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryApp.Entites
{
    public class Word
    {
        [Key]
        public int DictionaryID { get; set; }
        public string EnglishWord { get; set; }
        public string TurkishWord { get; set; }
    }
}
