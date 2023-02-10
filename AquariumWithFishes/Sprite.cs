﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AquariumWithFishes
{
    public abstract class Sprite
    {
        const int size = 20;
       protected Sprite(Control container)
        {
            PictureBox Pb = new PictureBox();
            container.Controls.Add(Pb);
            Pb.SizeMode = PictureBoxSizeMode.Zoom;
            Pb.Size = new Size(size, size / 2);
            Pb.Location = new Point(Pb.Left, Pb.Top);
            
        }
        public List<Sprite> Sprites = new List<Sprite>();
        

    }
}