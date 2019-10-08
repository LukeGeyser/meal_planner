using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace MealPlannerDesktop
{
    class Quote
    {
        private string quote;
        private string author;

        public Quote(string quote, string author)
        {
            this._Quote = quote;
            this._Author = author;
        }

        public string _Quote { get => quote; set => quote = value; }
        public string _Author { get => author; set => author = value; }
    }

    class FileHandler
    {
        public static string fileName = "DailyQuotes.txt";

        public static List<Quote> GetQuotes()
        {
            List<Quote> quotes = new List<Quote>();
            try
            {
                FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(fs);
                string line = reader.ReadLine();
                while(line != null)
                {
                    string[] values = line.Split('#');
                    quotes.Add(new Quote(values[0], values[1]));
                    line = reader.ReadLine();
                }
                reader.Close();
                fs.Close();
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message, "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return quotes;
        }
    }
}
