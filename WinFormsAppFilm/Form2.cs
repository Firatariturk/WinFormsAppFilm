using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace WinFormsAppFilm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            detailMovies();
            
        }


       



        private async void detailMovies()
        {
            
            
            string api = "20301c49";
            string connection = "http://www.omdbapi.com/?t=" + Form1.nameMovie + "&r=xml&apikey=" + api;
            XDocument bilgi = XDocument.Load(connection);
            
            
            





           
             var titleMovie = bilgi.Descendants("movie").ElementAt(0).Attribute("title").Value;
             var yearMovie = bilgi.Descendants("movie").ElementAt(0).Attribute("year").Value;
             var releasedMovie = bilgi.Descendants("movie").ElementAt(0).Attribute("released").Value;
             var runtimeMovie = bilgi.Descendants("movie").ElementAt(0).Attribute("runtime").Value;
             var genreMovie = bilgi.Descendants("movie").ElementAt(0).Attribute("genre").Value;
             var directorMovie = bilgi.Descendants("movie").ElementAt(0).Attribute("director").Value;
             var writerMovie = bilgi.Descendants("movie").ElementAt(0).Attribute("writer").Value;
             var actorsMovie = bilgi.Descendants("movie").ElementAt(0).Attribute("actors").Value;
             var plotMovie = bilgi.Descendants("movie").ElementAt(0).Attribute("plot").Value;
             var languageMovie = bilgi.Descendants("movie").ElementAt(0).Attribute("language").Value;
             var countryMovie = bilgi.Descendants("movie").ElementAt(0).Attribute("country").Value;
             var metascoreMovie = bilgi.Descendants("movie").ElementAt(0).Attribute("metascore").Value;
             var imdbMovie = bilgi.Descendants("movie").ElementAt(0).Attribute("imdbRating").Value;
             var typeMovie = bilgi.Descendants("movie").ElementAt(0).Attribute("type").Value;
             var img = bilgi.Descendants("movie").ElementAt(0).Attribute("poster").Value;

             labelTitle.Text = titleMovie;
             labelYear.Text = yearMovie;
             labelReleased.Text = releasedMovie;
             labelRuntime.Text = runtimeMovie;
            labelType.Text = typeMovie;
            labelGenre.Text = genreMovie;
            labelDirector.Text = directorMovie;
            labelWriter.Text = writerMovie;
            labelActors.Text = actorsMovie;
            labelPlot.Text = plotMovie;
            labelLang.Text = languageMovie;
            labelCountry.Text = countryMovie;
            labelMetascore.Text = metascoreMovie;
            labelImdb.Text = imdbMovie;
            labelType.Text = typeMovie;
            pictureBox1.ImageLocation = img;









            
            

        

        }






    }
}
