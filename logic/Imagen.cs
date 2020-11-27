using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Proyecto_Final_BDD.logic
{
    class Imagen
    {
        //Atributos
        private Bitmap img;

        //Constructor
        public Imagen(Bitmap img)
        {
            this.img = img;
        }

        //Gets y Sets
        public Bitmap Img { get => img; set => img = value; }


    }
}
