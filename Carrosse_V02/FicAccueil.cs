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
        #region Données Membres
        private Point pointTest;
        private Cercle cercleTest;
        private Rectangle rectangleTest;
        private Carrosse carrosse;
        private Bonhomme alan;
        private Bonhomme nemo;
        private RectangleMovable rectangleMovableTest;
        

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
        #endregion

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

        #region Fonctions
        void EnabledTrue(params Button[] mesBoutons)
        {
            foreach (Button button in mesBoutons)
            {
                button.Enabled = true;
            }
        }

        void Deplacer(Point obj)
        {
            obj.Bouger(5, 0);
            obj.Afficher(g);
            bufferG.Render();
        }

        void DeplacerXfois(Point obj,int nFois)
        {
            //nfois = Int32.Parse(textBox1.Text); 
            obj.Bouger(nFois, 0);
            obj.Afficher(g);
            bufferG.Render();
        }

        void EffacerTout()
        {
            g.Clear(pbTV.BackColor);
            bufferG.Render();
        }
        #endregion

        #region Gestion Bonhomme
        private void btnCreationAlan_Click(object sender, EventArgs e)
        {
            this.alan = new Bonhomme(this.pbTV,10,75,30,60);
            this.alan.Afficher(g);
            bufferG.Render();

            //Activation Bouton Deplacer
            EnabledTrue(btnDeplacerAlan);
        }

        private void btnCreationNemo_Click(object sender, EventArgs e)
        {
            this.nemo = new Bonhomme(this.pbTV, 100, 45, 30, 75);
            this.nemo.Afficher(g);
            bufferG.Render();

            EnabledTrue(btnDeplacerNemo, btnDeplacerXFois);
        }

        private void btnDeplacerAlan_Click(object sender, EventArgs e)
        {
            alan.Cacher(g);
            Deplacer(alan);
        }

        private void btnDeplacerNemo_Click(object sender, EventArgs e)
        {
            Deplacer(nemo);
        }

        private void btnDeplacerXFois_Click(object sender, EventArgs e)
        {
            try
            {
                int result = Int32.Parse(textBox1.Text);
                //DeplacerXFois(nemo, Int32.Parse(textBox1.Text);
                DeplacerXfois(nemo, result);
            }
            catch(FormatException)
            {
                MessageBox.Show("Unable to parse '" + textBox1.Text + "'");
            }
        }

        #endregion

        #region Gestion du Rectangle Movable
        private void btnCreationRectangleMovable_Click(object sender, EventArgs e)
        {
            rectangleMovableTest = new RectangleMovable(this.pbTV,100,100,25,85,2*Math.PI / 12, Color.Violet)
            this.rectangleMovableTest.Afficher(g);
            bufferG.Render();
            
        }

        private void btnTournerRectangleMovable_Click(object sender, EventArgs e)
        {
            EffacerTout();
            /*
            ou bien 
            rectangleMovableTest.Cacher(g);
            bufferG.Render();
            */

            this.rectangleMovableTest.Bouger(0, 0, 1 * Math.PI / 12);
            this.rectangleMovableTest.Afficher(g);
            bufferG.Render();
        }

        private void btnTournerRectangleMovableXfois_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox2.Text);
            this.rectangleMovableTest.Bouger(0, 0, 1 * Math.PI / a);
            this.rectangleMovableTest.Afficher(g);
            bufferG.Render();
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
