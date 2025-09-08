using ControleurMonster_APIv1.Models;

namespace ControleurMonster_APIv1.Services
{
    public class TuileService
    {
        public TuileService() { }

        public Tuile GenererTuile(int x, int y)
        {
            var (typeTuile, imageURL) = ChoisirType();
            bool estTraversable = true;
            if (typeTuile == TypeTuile.EAU || typeTuile == TypeTuile.MONTAGNE) { estTraversable = false; }

            return new Tuile(x,y,typeTuile, estTraversable, imageURL);
        }

        private (TypeTuile typeTuile, string imageURL) ChoisirType() 
        {
            const string BaseURL = "/images";
            Random rnd = new Random();
            int nbAleatoire = rnd.Next(1, 101);
            if (nbAleatoire <= 20){ return (TypeTuile.HERBE, $"{BaseURL}/Plains.png"); } 
            else if (nbAleatoire <= 30) { return (TypeTuile.EAU, $"{BaseURL}/River.png"); }
            else if ( nbAleatoire <= 45) { return (TypeTuile.MONTAGNE, $"{BaseURL}/Mountain.png"); }
            else if ( nbAleatoire <= 60) { return (TypeTuile.FORET, $"{BaseURL}/Forest.png"); }
            else if ( nbAleatoire <= 65) { return (TypeTuile.VILLE, $"{BaseURL}/Town.png"); }
            else return (TypeTuile.ROUTE, $"{BaseURL}/Road.png");
        }
    }
}
