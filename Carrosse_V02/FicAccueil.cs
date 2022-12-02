using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carrosse_V02
{
    public partial class FicAccueil : Form
    {
        private Point pointTest;
        private Cercle cercleTest;
        private Rectangle rectangleTest;
        private Carrosse carrosse;

        private BufferedGraphics bufferG = null;
        private Graphics g;
        public FicAccueil()
        {
            InitializeComponent();
            bufferG = BufferedGraphicsManager.Current.Allocate(pbTV.CreateGraphics(), pbTV.DisplayRectangle);
            g = bufferG.Graphics;
            //Efface l'intégralité de la surface de dessin et la remplace par la couleur d'arrière plan spécifiée
            //Par défaut, il est noir
            g.Clear(pbTV.BackColor);
        }

        #region Gestion Point
        private void btnCreationPoint_Click(object sender, EventArgs e)
        {
            this.pointTest = new Point(this.pbTV, 110, 30, Color.LightPink);
            this.pointTest.Afficher(g);
            //Ecrit le contenu de la mémoire tampon de graphique dans l'appareil par défaut 
            bufferG.Render();

            //Activation du bouton Déplacer
            btnDeplacerPoint.Enabled = true;
        }

        private void btnDeplacerPoint_Click(object sender, EventArgs e)
        {
            this.pointTest.Bouger(20, 10);
            this.pointTest.Afficher(g);
            bufferG.Render();
        }
        #endregion

        #region Gestion Cercle
        private void btnCreationCercle_Click(object sender, EventArgs e)
        {
            this.cercleTest = new Cercle(this.pbTV, 150, 50, 50, Color.DarkRed, Color.Aquamarine);
            //Jouer avec le remplissage du cercle
            //this.cercleTest.Remplir = false;
            this.cercleTest.Afficher(g);
            bufferG.Render();
        }
        #endregion

        #region Gestion Timer Formes
        private void btnTimerPoint_Click(object sender, EventArgs e)
        {
            if (pointTest is Point && cercleTest is Cercle)
                timerFormes.Enabled = !timerFormes.Enabled;
        }

        private void timerFormes_Tick(object sender, EventArgs e)
        {
            this.pointTest.Bouger(4, 0);
            this.pointTest.Afficher(g);
            this.cercleTest.Bouger(7, 0);
            this.cercleTest.Afficher(g);
            bufferG.Render();
        }
        #endregion

        #region Gestion Rectangle
        private void btnCreationRectangle_Click(object sender, EventArgs e)
        {
            this.rectangleTest = new Rectangle(this.pbTV, 150, 75, 25, 45, Color.DarkBlue, Color.Yellow);
            this.rectangleTest.Afficher(g);
            bufferG.Render();
        }
        #endregion

        #region Carrosse
        private void btnCreationCarrosse_Click(object sender, EventArgs e)
        {
            this.carrosse = new Carrosse(this.pbTV, 10, 75, 140, 60);
            this.carrosse.Afficher(g);
            bufferG.Render();

            //Activation du bouton Déplacer
            btnDeplacerCarrosse.Enabled = true;
        }

        private void btnDeplacerCarrosse_Click(object sender, EventArgs e)
        {
            this.carrosse.Bouger(6, 0);
            this.carrosse.Afficher(g);
            bufferG.Render();
        }
        #endregion

        #region Gestion Timer Carrosse
        private void btnTimerCarrosse_Click(object sender, EventArgs e)
        {
            if (carrosse is Carrosse)
                timerCarrosse.Enabled = !timerCarrosse.Enabled;

        }

        private void timerCarrosse_Tick(object sender, EventArgs e)
        {
            if (this.carrosse.X + this.carrosse.Longueur >= this.pbTV.Width)
            {
                this.timerCarrosse.Stop();
                MessageBox.Show("Bord atteint");
                //this.btnStopDeplacerCTick.Enabled = false;
            }
            else
            {
                g.Clear(pbTV.BackColor);
                bufferG.Render();
                this.carrosse.Bouger(4, 0);
                this.carrosse.Afficher(g);
                bufferG.Render();
            }
        }
        #endregion

        #region Effacer
        private void btnEraseAll_Click(object sender, EventArgs e)
        {
                g.Clear(pbTV.BackColor);
                bufferG.Render();
            
        }
        #endregion
    }
}
