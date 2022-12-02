using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carrosse_V02
{
    internal class Cercle : Point
    {
        #region Données membres
        private Color pot = Color.Yellow;
        private bool remplir = true;
        private int rayon = 1;
        #endregion

        #region Accesseurs

        #region Pot
        public Color Pot
        {
            get
            {
                return pot;
            }
            set
            {
                try
                {
                    pot = value;
                }
                catch (Exception)
                {

                }
            }
        }
        #endregion

        #region Remplir
        public bool Remplir
        {
            get
            {
                return remplir;
            }
            set
            {
                remplir = value;
            }
        }
        #endregion

        #region Rayon
        public int Rayon
        {
            get
            {
                return rayon;
            }
            set
            {
                if (value < 0)
                {
                    rayon = 1;
                }
                else
                {
                    rayon = value;
                }
            }
        }
        #endregion

        #endregion

        #region Constructeurs
        public Cercle(PictureBox hebergeur, int xc, int yc, int rayon) : base(hebergeur, xc, yc)
        {
            Rayon = rayon;
        }

        public Cercle(PictureBox hebergeur, int xc, int yc, int rayon, Color pot) : base(hebergeur, xc, yc)
        {
            Rayon = rayon;
            Pot = pot;
        }

        public Cercle(PictureBox hebergeur, int xc, int yc, int rayon, Color crayon, Color pot) : base(hebergeur, xc, yc, crayon)
        {
            //MessageBox.Show("Création cercle");
            Rayon = rayon;
            Pot = pot;
        }
        #endregion

        #region Méthodes

        #region Afficher
        public override void Afficher(Graphics gr)
        {
            if (this.Visible)
            {
                if (this.Remplir)
                {
                    //on dessine le cercle (le point de référence de la classe MonPoint est au centre du cercle, il faut
                    //lui retirer le rayon 2*this.Rayon est la largeur et la hauteur
                    //Remplit l'intérieur d'une ellipse définie par un rectangle englobant
                    gr.FillEllipse(new SolidBrush(this.Pot), this.X - this.Rayon, this.Y - this.Rayon, 2 * this.Rayon, 2 * this.Rayon);
                }
                gr.DrawEllipse(new Pen(this.Crayon), this.X - this.Rayon, this.Y - this.Rayon, 2 * this.Rayon, 2 * this.Rayon);
            }
        }
        #endregion

        #region Cacher
        public override void Cacher(Graphics gr)
        {
            if (this.Remplir)
            {
                gr.FillEllipse(new SolidBrush(this.Fond), this.X - this.Rayon, this.Y - this.Rayon, 2 * this.Rayon, 2 * this.Rayon);
            }
            gr.DrawEllipse(new Pen(this.Fond), this.X - this.Rayon, this.Y - this.Rayon, 2 * this.Rayon, 2 * this.Rayon);
        }
        #endregion

        #endregion
    }
}
