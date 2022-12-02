using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carrosse_V02
{
    internal class Rectangle : Point
    {
        #region Données membres
        private Color pot = Color.DarkMagenta;
        private bool remplir = true;
        private int hauteur = 1;
        private int longueur = 1;
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

        #region Longueur
        public int Longueur
        {
            get
            {
                return longueur;
            }
            set
            {
                if (value < 0)
                {
                    longueur = 1;
                }
                else
                {
                    longueur = value;
                }
            }
        }
        #endregion

        #region Hauteur
        public int Hauteur
        {
            get
            {
                return hauteur;
            }
            set
            {
                if (value < 0)
                {
                    hauteur = 1;
                }
                else
                {
                    hauteur = value;
                }
            }
        }
        #endregion

        #endregion

        #region Constructeurs
        public Rectangle(PictureBox hebergeur, int xsg, int ysg, int longueur, int hauteur) : base(hebergeur, xsg, ysg)
        {
            Longueur = longueur;
            Hauteur = hauteur;
        }

        public Rectangle(PictureBox hebergeur, int xsg, int ysg, int longueur, int hauteur, Color pot) : base(hebergeur, xsg, ysg)
        {
            Longueur = longueur;
            Hauteur = hauteur;
            Pot = pot;
        }

        public Rectangle(PictureBox hebergeur, int xsg, int ysg, int longueur, int hauteur, Color crayon, Color pot) : base(hebergeur, xsg, ysg)
        {
            Longueur = longueur;
            Hauteur = hauteur;
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
                    gr.FillRectangle(new SolidBrush(this.Pot), this.X, this.Y, this.Longueur, this.Hauteur);
                }
                gr.DrawRectangle(new Pen(this.Crayon), this.X, this.Y, this.Longueur, this.Hauteur);
            }
        }
        #endregion

        #region Cacher
        public override void Cacher(Graphics gr)
        {
            if (this.Remplir)
            {
                gr.FillRectangle(new SolidBrush(this.Fond), this.X, this.Y, this.Longueur, this.Hauteur);
            }
            gr.DrawRectangle(new Pen(this.Fond), this.X, this.Y, this.Longueur, this.Hauteur);
        }
        #endregion

        #endregion
    }
}
