using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Math;

namespace Carrosse_V02
{
    internal class RectangleMovable : Point
    {
        #region Données membres
        private Color pot = Color.Gray;
        private bool remplir = true;
        private int longueur = 1, hauteur = 1;
        private double angle;
        #endregion

        #region Accesseurs

        #region Accesseurs de Base 

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

        #region Angle
        public double Angle
        {
            get;
            set;
        }
        #endregion

        #endregion

        #region Calcul des Points
        public Point CSG
        {
            get
            {
                return new Point(X, Y);
            }
        }
        public Point CSD
        {
            get
            {
                
                return new Point((int)(X + Longueur * Cos(Angle)), (int)(Y - Longueur * Sin(Angle)));
            }
        }

        public Point CIG
        {
            get
            {
                return new Point((int)(X + Hauteur * Cos(3 * PI / 2 + Angle)), (int)(Y - Hauteur * Sin(3 * PI / 2 + Angle)));
            }
        }
        
        public Point CID
        {
            get
            {
                return new Point((int)(X + (longueur * Cos(Angle)) + hauteur * Cos(3 * PI / 2 + Angle)), (int)(Y - longueur * Sin(Angle) - hauteur * Sin(3 * PI / 2 + Angle)));
            }
        }
        #endregion

        #endregion

        #region Constructeurs
        public RectangleMovable(PictureBox hebergeur, int xsg, int ysg, int longueur, int hauteur) : base(hebergeur, xsg, ysg)
        {
            this.angle = 0f;
            this.longueur = longueur;
            this.hauteur = hauteur;
            this.X = xsg;
            this.Y = ysg;

        }

        public RectangleMovable(PictureBox hebergeur, int xsg, int ysg, int longueur, int hauteur, double angle, Color pot) : base(hebergeur, xsg, ysg)
        {
            Angle = angle;
            Longueur = longueur;
            Hauteur = hauteur;
            Pot = pot;
            this.X = xsg;
            this.Y = ysg;
        }
        #endregion

        #region Méthodes

        #region Bouger
        public virtual void Bouger(int deplX, int deplY, double diffangle)
        {
            
        }
        #endregion

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
                gr.FillRectangle(new SolidBrush(this.Fond), this.X, this.Y, this.longueur, this.hauteur);
            }
            gr.DrawRectangle(new Pen(this.Fond), this.X, this.Y, this.longueur, this.hauteur);
        }
        #endregion

        #endregion

    }
}
