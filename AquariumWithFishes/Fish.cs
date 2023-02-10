using AquariumWithFishes.Properties;
using BallisticModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AquariumWithFishes
{
    class Fish: Sprite
    {
        
        const int size = 20;
        public Vector Direction { get; set; }
        public Vector Vspeed { get => Direction.GetE() * Speed; }
        public int Speed;
        public Fish(Control container): base(container)
        {
            PictureBox Pb = new PictureBox();
            Pb.Size = new Size(size, size / 2);
            Pb.Location = new Point(Pb.Left, Pb.Top);
            
        }

        

        public void Run(PictureBox Pb)
        {
            Pb.Left += (int)Vspeed.X;
            Pb.Top += (int)Vspeed.Y;
        }
        public bool IsCollide(Fish another)
        {
            if (another == null || another == this) return false;
            Rectangle r1 = new Rectangle(Pb.Location, Pb.Size);
            Rectangle r2 = new Rectangle(another.Pb.Location, another.Pb.Size);
            return r1.IntersectsWith(r2);

        }
    }
}
