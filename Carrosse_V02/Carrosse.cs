using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carrosse_V02
{
    internal class Carrosse : Rectangle
    {
        #region Données membres
        private Cercle roueG, roueD;
        private Rectangle porte, fenD, fenG, poignee;

        //Ajout d'un point du point de référence du carrosse
        private Point pointRef;
        #endregion

        #region Accesseurs

        #region RoueG
        public Cercle RoueG
        {
            get
            {
                return roueG;
            }
            set
            {
                roueG = value;
            }
        }
        #endregion

        #region RoueD
        public Cercle RoueD
        {
            get
            {
                return roueD;
            }
            set
            {
                roueD = value;
            }
        }
        #endregion

        #region Porte
        public Rectangle Porte
        {
            get
            {
                return porte;
            }
            set
            {
                porte = value;
            }
        }
        #endregion

        #region Poignee
        public Rectangle Poignee
        {
            get
            {
                return poignee;
            }
            set
            {
                poignee = value;
            }
        }
        #endregion

        #region FenG
        public Rectangle FenG
        {
            get
            {
                return fenG;
            }
            set
            {
                fenG = value;
            }
        }
        #endregion

        #region FenD
        public Rectangle FenD
        {
            get
            {
                return fenD;
            }
            set
            {
                fenD = value;
            }
        }
        #endregion

        #endregion

        #region Constructeurs
        public Carrosse(PictureBox hebergeur, int xsg, int ysg, int longueur, int hauteur)
            : base(hebergeur, xsg, ysg, longueur, hauteur)
        {
            //Pour localiser le point de référence
            this.pointRef = new Point(hebergeur, xsg, ysg, Color.Lavender);

            this.RoueG = new Cercle(hebergeur, xsg, ysg + hauteur, hauteur / 2, Color.Brown, Color.Black);
            this.RoueD = new Cercle(hebergeur, xsg + longueur, ysg + hauteur, hauteur / 2, Color.Black, Color.Brown);

            this.FenG = new Rectangle(hebergeur, longueur / 10 + xsg, hauteur / 6 + ysg, longueur / 5, hauteur / 3);
            this.FenD = new Rectangle(hebergeur, xsg + longueur - 3 * longueur / 10, hauteur / 6 + ysg, longueur / 5, hauteur / 3);

            this.Porte = new Rectangle(hebergeur, xsg + longueur / 2 - 2 * longueur / 15, ysg + hauteur - 3 * hauteur / 4 - 1, 4 * longueur / 15, 3 * hauteur / 4);
            this.Poignee = new Rectangle(hebergeur, xsg + longueur / 2 + longueur / 30, hauteur / 2 + ysg, longueur / 15, hauteur / 15);

            this.Crayon = Color.Blue;
            this.Pot = Color.Gold;

            this.FenG.Pot = this.FenD.Pot = Color.Pink;
            this.Porte.Pot = Color.RoyalBlue;
            this.Poignee.Pot = this.Poignee.Crayon = Color.Khaki;
        }
        #endregion

        #region Méthodes

        #region Bouger
        public override void Bouger(int deplX, int deplY)
        {
            base.Bouger(deplX, deplY);
            this.pointRef.Bouger(deplX, deplY);
            this.RoueG.Bouger(deplX, deplY);
            this.RoueD.Bouger(deplX, deplY);
            this.FenD.Bouger(deplX, deplY);
            this.FenG.Bouger(deplX, deplY);
            this.Porte.Bouger(deplX, deplY);
            this.Poignee.Bouger(deplX, deplY);
        }
        #endregion

        #region Afficher
        public override void Afficher(Graphics g)
        {
            //On affiche le rectangle dont on a hérité de la classe MonRectangle
            base.Afficher(g);
            //On affiche le point de référence
            this.pointRef.Afficher(g);

            //On affiche le reste
            this.RoueG.Afficher(g);
            this.RoueD.Afficher(g);
            this.FenD.Afficher(g);
            this.FenG.Afficher(g);
            this.Porte.Afficher(g);
            this.Poignee.Afficher(g);
        }
        #endregion

        #region Cacher
        public override void Cacher(Graphics g)
        {
            base.Cacher(g);
            //je ne cache pas le point de référence
            this.RoueG.Cacher(g);
            this.RoueD.Cacher(g);
            this.FenD.Cacher(g);
            this.FenG.Cacher(g);
            this.Porte.Cacher(g);
            this.Poignee.Cacher(g);
        }
        #endregion

        #endregion
    }
}
