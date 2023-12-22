using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;
using static System.Net.WebRequestMethods;

namespace WinFormsAppFilm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        public static string nameMovie;
        private async void searchMovies()
        {   
            dataGridView1.Rows.Clear();
            nameMovie = textBox1.Text;
            string api = "20301c49";
            string connection = "http://www.omdbapi.com/?s=" + nameMovie + "&r=xml&apikey=" + api;
            XDocument arama = XDocument.Load(connection);
            var resultNodes = arama.Descendants("result");
            int satirsayisi = resultNodes.Count();
            





            for (int i = 0; i < satirsayisi; i++)
            {
                var titleMovie = arama.Descendants("result").ElementAt(i).Attribute("title").Value;
                var yearMovie = arama.Descendants("result").ElementAt(i).Attribute("year").Value;
                dataGridView1.Rows.Add(titleMovie, yearMovie);
            }



        }
        private void form2acma()
        {
            nameMovie = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            searchMovies();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            form2acma();
            
        }
    }
}
