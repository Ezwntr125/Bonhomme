namespace Carrosse_V02
{
    partial class FicAccueil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnCreationPoint = new System.Windows.Forms.Button();
            this.btnDeplacerPoint = new System.Windows.Forms.Button();
            this.btnCreationCercle = new System.Windows.Forms.Button();
            this.btnTimerFormes = new System.Windows.Forms.Button();
            this.btnCreationRectangle = new System.Windows.Forms.Button();
            this.btnCreationCarrosse = new System.Windows.Forms.Button();
            this.btnDeplacerCarrosse = new System.Windows.Forms.Button();
            this.btnTimerCarrosse = new System.Windows.Forms.Button();
            this.btnEraseAll = new System.Windows.Forms.Button();
            this.pbTV = new System.Windows.Forms.PictureBox();
            this.timerFormes = new System.Windows.Forms.Timer(this.components);
            this.timerCarrosse = new System.Windows.Forms.Timer(this.components);
            this.btnCreationAlan = new System.Windows.Forms.Button();
            this.btnCreationNemo = new System.Windows.Forms.Button();
            this.btnDeplacerAlan = new System.Windows.Forms.Button();
            this.btnDeplacerNemo = new System.Windows.Forms.Button();
            this.btnDeplacerXFois = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCreationRectangleMovable = new System.Windows.Forms.Button();
            this.btnTournerRectangleMovable = new System.Windows.Forms.Button();
            this.btnTournerRectangleMovableXfois = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbTV)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreationPoint
            // 
            this.btnCreationPoint.Location = new System.Drawing.Point(12, 269);
            this.btnCreationPoint.Name = "btnCreationPoint";
            this.btnCreationPoint.Size = new System.Drawing.Size(118, 23);
            this.btnCreationPoint.TabIndex = 0;
            this.btnCreationPoint.Text = "Creation Point";
            this.btnCreationPoint.UseVisualStyleBackColor = true;
            this.btnCreationPoint.Click += new System.EventHandler(this.btnCreationPoint_Click);
            // 
            // btnDeplacerPoint
            // 
            this.btnDeplacerPoint.Location = new System.Drawing.Point(175, 269);
            this.btnDeplacerPoint.Name = "btnDeplacerPoint";
            this.btnDeplacerPoint.Size = new System.Drawing.Size(118, 23);
            this.btnDeplacerPoint.TabIndex = 1;
            this.btnDeplacerPoint.Text = "Deplacer Point";
            this.btnDeplacerPoint.UseVisualStyleBackColor = true;
            this.btnDeplacerPoint.Click += new System.EventHandler(this.btnDeplacerPoint_Click);
            // 
            // btnCreationCercle
            // 
            this.btnCreationCercle.Location = new System.Drawing.Point(12, 298);
            this.btnCreationCercle.Name = "btnCreationCercle";
            this.btnCreationCercle.Size = new System.Drawing.Size(118, 23);
            this.btnCreationCercle.TabIndex = 3;
            this.btnCreationCercle.Text = "Creation Cercle";
            this.btnCreationCercle.UseVisualStyleBackColor = true;
            this.btnCreationCercle.Click += new System.EventHandler(this.btnCreationCercle_Click);
            // 
            // btnTimerFormes
            // 
            this.btnTimerFormes.Location = new System.Drawing.Point(342, 269);
            this.btnTimerFormes.Name = "btnTimerFormes";
            this.btnTimerFormes.Size = new System.Drawing.Size(131, 52);
            this.btnTimerFormes.TabIndex = 2;
            this.btnTimerFormes.Text = "Activer/Desactiver Timer ssi Point et Cercle existent";
            this.btnTimerFormes.UseVisualStyleBackColor = true;
            this.btnTimerFormes.Click += new System.EventHandler(this.btnTimerPoint_Click);
            // 
            // btnCreationRectangle
            // 
            this.btnCreationRectangle.Location = new System.Drawing.Point(12, 327);
            this.btnCreationRectangle.Name = "btnCreationRectangle";
            this.btnCreationRectangle.Size = new System.Drawing.Size(118, 23);
            this.btnCreationRectangle.TabIndex = 5;
            this.btnCreationRectangle.Text = "Creation Rectangle";
            this.btnCreationRectangle.UseVisualStyleBackColor = true;
            this.btnCreationRectangle.Click += new System.EventHandler(this.btnCreationRectangle_Click);
            // 
            // btnCreationCarrosse
            // 
            this.btnCreationCarrosse.Location = new System.Drawing.Point(12, 356);
            this.btnCreationCarrosse.Name = "btnCreationCarrosse";
            this.btnCreationCarrosse.Size = new System.Drawing.Size(118, 23);
            this.btnCreationCarrosse.TabIndex = 4;
            this.btnCreationCarrosse.Text = "Creation Carrosse";
            this.btnCreationCarrosse.UseVisualStyleBackColor = true;
            this.btnCreationCarrosse.Click += new System.EventHandler(this.btnCreationCarrosse_Click);
            // 
            // btnDeplacerCarrosse
            // 
            this.btnDeplacerCarrosse.Location = new System.Drawing.Point(175, 356);
            this.btnDeplacerCarrosse.Name = "btnDeplacerCarrosse";
            this.btnDeplacerCarrosse.Size = new System.Drawing.Size(118, 23);
            this.btnDeplacerCarrosse.TabIndex = 6;
            this.btnDeplacerCarrosse.Text = "Deplacer Carrosse";
            this.btnDeplacerCarrosse.UseVisualStyleBackColor = true;
            this.btnDeplacerCarrosse.Click += new System.EventHandler(this.btnDeplacerCarrosse_Click);
            // 
            // btnTimerCarrosse
            // 
            this.btnTimerCarrosse.Location = new System.Drawing.Point(342, 327);
            this.btnTimerCarrosse.Name = "btnTimerCarrosse";
            this.btnTimerCarrosse.Size = new System.Drawing.Size(131, 52);
            this.btnTimerCarrosse.TabIndex = 7;
            this.btnTimerCarrosse.Text = "Activer/Desactiver Timer Carrosse";
            this.btnTimerCarrosse.UseVisualStyleBackColor = true;
            this.btnTimerCarrosse.Click += new System.EventHandler(this.btnTimerCarrosse_Click);
            // 
            // btnEraseAll
            // 
            this.btnEraseAll.Location = new System.Drawing.Point(670, 12);
            this.btnEraseAll.Name = "btnEraseAll";
            this.btnEraseAll.Size = new System.Drawing.Size(118, 23);
            this.btnEraseAll.TabIndex = 8;
            this.btnEraseAll.Text = "Effacer Tout";
            this.btnEraseAll.UseVisualStyleBackColor = true;
            this.btnEraseAll.Click += new System.EventHandler(this.btnEraseAll_Click);
            // 
            // pbTV
            // 
            this.pbTV.Location = new System.Drawing.Point(12, 12);
            this.pbTV.Name = "pbTV";
            this.pbTV.Size = new System.Drawing.Size(776, 251);
            this.pbTV.TabIndex = 9;
            this.pbTV.TabStop = false;
            // 
            // timerFormes
            // 
            this.timerFormes.Tick += new System.EventHandler(this.timerFormes_Tick);
            // 
            // timerCarrosse
            // 
            this.timerCarrosse.Tick += new System.EventHandler(this.timerCarrosse_Tick);
            // 
            // btnCreationAlan
            // 
            this.btnCreationAlan.Location = new System.Drawing.Point(12, 385);
            this.btnCreationAlan.Name = "btnCreationAlan";
            this.btnCreationAlan.Size = new System.Drawing.Size(118, 23);
            this.btnCreationAlan.TabIndex = 10;
            this.btnCreationAlan.Text = "Alan ";
            this.btnCreationAlan.UseVisualStyleBackColor = true;
            this.btnCreationAlan.Click += new System.EventHandler(this.btnCreationAlan_Click);
            // 
            // btnCreationNemo
            // 
            this.btnCreationNemo.Location = new System.Drawing.Point(12, 414);
            this.btnCreationNemo.Name = "btnCreationNemo";
            this.btnCreationNemo.Size = new System.Drawing.Size(118, 20);
            this.btnCreationNemo.TabIndex = 11;
            this.btnCreationNemo.Text = "Nemo";
            this.btnCreationNemo.UseVisualStyleBackColor = true;
            this.btnCreationNemo.Click += new System.EventHandler(this.btnCreationNemo_Click);
            // 
            // btnDeplacerAlan
            // 
            this.btnDeplacerAlan.Location = new System.Drawing.Point(175, 385);
            this.btnDeplacerAlan.Name = "btnDeplacerAlan";
            this.btnDeplacerAlan.Size = new System.Drawing.Size(118, 23);
            this.btnDeplacerAlan.TabIndex = 12;
            this.btnDeplacerAlan.Text = "Deplacer Alan";
            this.btnDeplacerAlan.UseVisualStyleBackColor = true;
            this.btnDeplacerAlan.Click += new System.EventHandler(this.btnDeplacerAlan_Click);
            // 
            // btnDeplacerNemo
            // 
            this.btnDeplacerNemo.Location = new System.Drawing.Point(175, 414);
            this.btnDeplacerNemo.Name = "btnDeplacerNemo";
            this.btnDeplacerNemo.Size = new System.Drawing.Size(118, 20);
            this.btnDeplacerNemo.TabIndex = 13;
            this.btnDeplacerNemo.Text = "Deplacer Nemo";
            this.btnDeplacerNemo.UseVisualStyleBackColor = true;
            this.btnDeplacerNemo.Click += new System.EventHandler(this.btnDeplacerNemo_Click);
            // 
            // btnDeplacerXFois
            // 
            this.btnDeplacerXFois.Location = new System.Drawing.Point(299, 413);
            this.btnDeplacerXFois.Name = "btnDeplacerXFois";
            this.btnDeplacerXFois.Size = new System.Drawing.Size(100, 20);
            this.btnDeplacerXFois.TabIndex = 14;
            this.btnDeplacerXFois.Text = "Deplacer X fois";
            this.btnDeplacerXFois.UseVisualStyleBackColor = true;
            this.btnDeplacerXFois.Click += new System.EventHandler(this.btnDeplacerXFois_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(405, 414);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(68, 20);
            this.textBox1.TabIndex = 15;
            // 
            // btnCreationRectangleMovable
            // 
            this.btnCreationRectangleMovable.Location = new System.Drawing.Point(522, 269);
            this.btnCreationRectangleMovable.Name = "btnCreationRectangleMovable";
            this.btnCreationRectangleMovable.Size = new System.Drawing.Size(93, 52);
            this.btnCreationRectangleMovable.TabIndex = 16;
            this.btnCreationRectangleMovable.Text = "Creation Rectangle Movable";
            this.btnCreationRectangleMovable.UseVisualStyleBackColor = true;
            this.btnCreationRectangleMovable.Click += new System.EventHandler(this.btnCreationRectangleMovable_Click);
            // 
            // btnTournerRectangleMovable
            // 
            this.btnTournerRectangleMovable.Location = new System.Drawing.Point(522, 327);
            this.btnTournerRectangleMovable.Name = "btnTournerRectangleMovable";
            this.btnTournerRectangleMovable.Size = new System.Drawing.Size(93, 52);
            this.btnTournerRectangleMovable.TabIndex = 17;
            this.btnTournerRectangleMovable.Text = "Tourner Rectangle Pi/12";
            this.btnTournerRectangleMovable.UseVisualStyleBackColor = true;
            this.btnTournerRectangleMovable.Click += new System.EventHandler(this.btnTournerRectangleMovable_Click);
            // 
            // btnTournerRectangleMovableXfois
            // 
            this.btnTournerRectangleMovableXfois.Location = new System.Drawing.Point(621, 269);
            this.btnTournerRectangleMovableXfois.Name = "btnTournerRectangleMovableXfois";
            this.btnTournerRectangleMovableXfois.Size = new System.Drawing.Size(93, 52);
            this.btnTournerRectangleMovableXfois.TabIndex = 18;
            this.btnTournerRectangleMovableXfois.Text = "Tourner Rectangle de PiX";
            this.btnTournerRectangleMovableXfois.UseVisualStyleBackColor = true;
            this.btnTournerRectangleMovableXfois.Click += new System.EventHandler(this.btnTournerRectangleMovableXfois_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(720, 301);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(68, 20);
            this.textBox2.TabIndex = 19;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // FicAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnTournerRectangleMovableXfois);
            this.Controls.Add(this.btnTournerRectangleMovable);
            this.Controls.Add(this.btnCreationRectangleMovable);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnDeplacerXFois);
            this.Controls.Add(this.btnDeplacerNemo);
            this.Controls.Add(this.btnDeplacerAlan);
            this.Controls.Add(this.btnCreationNemo);
            this.Controls.Add(this.btnCreationAlan);
            this.Controls.Add(this.btnEraseAll);
            this.Controls.Add(this.btnTimerCarrosse);
            this.Controls.Add(this.btnDeplacerCarrosse);
            this.Controls.Add(this.btnCreationRectangle);
            this.Controls.Add(this.btnCreationCarrosse);
            this.Controls.Add(this.btnCreationCercle);
            this.Controls.Add(this.btnTimerFormes);
            this.Controls.Add(this.btnDeplacerPoint);
            this.Controls.Add(this.btnCreationPoint);
            this.Controls.Add(this.pbTV);
            this.Name = "FicAccueil";
            this.Text = "Dessin Animé";
            ((System.ComponentModel.ISupportInitialize)(this.pbTV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreationPoint;
        private System.Windows.Forms.Button btnDeplacerPoint;
        private System.Windows.Forms.Button btnCreationCercle;
        private System.Windows.Forms.Button btnTimerFormes;
        private System.Windows.Forms.Button btnCreationRectangle;
        private System.Windows.Forms.Button btnCreationCarrosse;
        private System.Windows.Forms.Button btnDeplacerCarrosse;
        private System.Windows.Forms.Button btnTimerCarrosse;
        private System.Windows.Forms.Button btnEraseAll;
        private System.Windows.Forms.PictureBox pbTV;
        private System.Windows.Forms.Timer timerFormes;
        private System.Windows.Forms.Timer timerCarrosse;
        private System.Windows.Forms.Button btnCreationAlan;
        private System.Windows.Forms.Button btnCreationNemo;
        private System.Windows.Forms.Button btnDeplacerAlan;
        private System.Windows.Forms.Button btnDeplacerNemo;
        private System.Windows.Forms.Button btnDeplacerXFois;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnCreationRectangleMovable;
        private System.Windows.Forms.Button btnTournerRectangleMovable;
        private System.Windows.Forms.Button btnTournerRectangleMovableXfois;
        private System.Windows.Forms.TextBox textBox2;
    }
}

