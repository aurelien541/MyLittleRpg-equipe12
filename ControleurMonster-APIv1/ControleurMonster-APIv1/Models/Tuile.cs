using Microsoft.EntityFrameworkCore;

namespace ControleurMonster_APIv1.Models
{
    [PrimaryKey(nameof(PositionX), nameof(PositionY))]
    public class Tuile
    {
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public int Type { get; set; }
        public bool estTraversable { get; set; }
        public string imageURL { get; set; }

        public Tuile() { }
        public Tuile (int positionX, int positionY, int type, bool estTraversable, string imageURL)
        {
            PositionX = positionX;
            PositionY = positionY;
            Type = type;
            this.estTraversable = estTraversable;
            this.imageURL = imageURL;
        }
    }
}
