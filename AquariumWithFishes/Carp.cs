using AquariumWithFishes.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AquariumWithFishes
{
    class Carp: Fish
    {
        const int size = 20;
        
        public Carp(Control container): base(container)
        {
            PictureBox Pb = new PictureBox();
            Pb.Size = new Size(size, size / 2);
            Pb.Location = new Point(Pb.Left, Pb.Top);
            Pb.Image = Resources.Korop;
            for (int i = 0; i < 5; i++)
            {
                Carps.Add(new Carp(container));
            }
        }
        List<Carp> Carps = new List<Carp>();
        
    }
}
