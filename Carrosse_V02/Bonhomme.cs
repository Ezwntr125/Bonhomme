using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carrosse_V02
{
    internal class Bonhomme : Rectangle
    {
        #region Données Membres
        private Cercle tete;
        private Rectangle brasDroit, brasGauche, jambeDroite, jambeGauche;
        #endregion

        #region Constructeurs 
        public Bonhomme(PictureBox hebergeur, int xsg, int ysg, int longueur, int hauteur) : base(hebergeur, xsg, ysg,longueur, hauteur)
        {

        }
        #endregion

        #region Méthodes
        #region Bouger
        public override void Bouger(int deplX, int deplY)
        {
            base.Bouger(deplX, deplY);
            this.brasGauche.Bouger(deplX, deplY);
            this.brasDroit.Bouger(deplX, deplY);
            this.jambeGauche.Bouger(deplX, deplY);
            this.jambeDroite.Bouger(deplX, deplY);
            this.tete.Bouger(deplX, deplY);
        }
        #endregion

        #region Afficher
        public override void Afficher(Graphics g)
        {
            this.brasGauche.Afficher(g);
            this.jambeGauche.Afficher(g);
            base.Afficher(g);
            this.brasDroit.Afficher(g);
            this.jambeDroite.Afficher(g);
            this.tete.Afficher(g);
        }
        #endregion

        #region Cacher
        public override void Cacher(Graphics g)
        {
            this.brasGauche.Afficher(g);
            this.jambeGauche.Afficher(g);
            base.Afficher(g);
            this.brasDroit.Afficher(g);
            this.jambeDroite.Afficher(g);
            this.tete.Afficher(g);
        }
        #endregion
        #endregion

    }
}
