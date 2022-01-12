using DictionaryApp.Entites;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DictionaryApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            ListWords();
        }
        private void ListWords()
        {
            using (DictionaryContext context = new DictionaryContext())
            {
                dgwWords.DataSource = context.Words.ToList();
            }
        }
        private void WordSearch(string key)
        {
            using (DictionaryContext context = new DictionaryContext())
            {
                dgwWords.DataSource = context.Words.Where(w=> w.TurkishWord.Contains(key)).ToList();            
            }
        }

        private Expression<Func<Word, bool>> Contains(string key)
        {
            throw new NotImplementedException();
        }

        private void txbWord_TextChanged(object sender, EventArgs e)
        {   
            string key = txbWord.Text;
            if (string.IsNullOrEmpty(key))
            {
                ListWords();
            }
            else
            {
                WordSearch(key);
            }
        }

      
    }
}
