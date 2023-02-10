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
    class Pike: Fish
    {
        const int size = 20;
        
        public Pike(Control container) : base(container)
        {
            PictureBox Pb = new PictureBox();
            Pb.Size = new Size(size, size / 2);
            Pb.Location = new Point(Pb.Left, Pb.Top);
            Pb.Image = Resources.Shuka;
            for (int i = 0; i < 5; i++)
            {
                Pikes.Add(new Pike(container));
            }
            
        }
        List<Pike> Pikes = new List<Pike>();
        
    }
}
