using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carrosse_V02
{
    internal class Point
    {
        #region Données Membres
        private int x = 0;
        private int y = 0;
        private bool visible = true;
        private PictureBox hebergeur;
        private Color fond = Color.DarkOliveGreen;
        private Color crayon = Color.MediumPurple;
        #endregion

        #region Accesseurs

        #region X
        public int X
        {
            get
            {
                return x;
            }
            set
            {
                if (value < 0)
                {
                    this.x = 0;
                }
                else if (value > this.hebergeur.Bounds.Size.Width)
                {
                    this.x = this.hebergeur.Bounds.Size.Width;
                }
                else
                {
                    this.x = value;
                }
            }
        }
        #endregion

        #region Y
        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                if (value < 0)
                {
                    this.y = 0;
                }
                else if (value > this.hebergeur.Bounds.Size.Height)
                {
                    this.y = this.hebergeur.Bounds.Size.Height;
                }
                else
                {
                    this.y = value;
                }
            }
        }
        #endregion

        #region Visible
        public bool Visible
        {
            get
            {
                return visible;
            }
            set
            {
                visible = value;
            }
        }
        #endregion

        #region Fond
        public Color Fond
        {
            get
            {
                return fond;
            }
            set
            {
                try
                {
                    fond = value;
                }
                catch (Exception)
                {

                }
            }
        }
        #endregion

        #region Crayon
        public Color Crayon
        {
            get
            {
                return crayon;
            }
            set
            {
                try
                {
                    crayon = value;
                }
                catch (Exception)
                {

                }
            }
        }
        #endregion

        #region Hebergeur
        public PictureBox Hebergeur
        {
            get
            {
                return hebergeur;
            }
            set
            {
                hebergeur = value;
            }
        }
        #endregion

        #endregion

        #region Constructeurs

        public Point()
        {
            this.hebergeur = null;
        }

        public Point(PictureBox hebergeur)
        {
            this.hebergeur = hebergeur;
            this.fond = hebergeur.BackColor;
        }

        public Point(PictureBox hebergeur, int xy) : this(hebergeur)
        {
            x = y = xy;
        }

        public Point(PictureBox hebergeur, int x, int y) : this(hebergeur)
        {
            X = x;
            Y = y;
        }

        public Point(PictureBox hebergeur, int xy, Color crayon) : this(hebergeur, xy)
        {
            Crayon = crayon;
        }

        public Point(PictureBox hebergeur, int x, int y, Color crayon)
        {
            this.Crayon = crayon;
            this.Hebergeur = hebergeur;
            this.Fond = hebergeur.BackColor;
            //this.Fond = crayon;
            this.X = x;
            this.Y = y;
            //MessageBox.Show(x.ToString());
            //MessageBox.Show(y.ToString());
        }
        #endregion

        #region Méthodes

        #region Bouger
        public virtual void Bouger(int deplX, int deplY)
        {
            X += deplX;
            Y += deplY;
        }
        #endregion

        #region Afficher
        public virtual void Afficher(Graphics gr)
        {
            if (this.Visible)
            {
                gr.FillEllipse(new SolidBrush(Color.Yellow), this.X, this.Y, 10, 10);
                gr.DrawEllipse(new Pen(this.Crayon, 3), this.X, this.Y, 10, 10);
            }
        }
        #endregion

        #region Cacher
        public virtual void Cacher(Graphics gr)
        {
            if (this.Visible)
            {
                gr.FillEllipse(new SolidBrush(this.Fond), this.X, this.Y, 10, 10);
                gr.DrawEllipse(new Pen(this.Fond, 3), this.X, this.Y, 10, 10);
            }
        }
        #endregion

        #endregion
    }
}
