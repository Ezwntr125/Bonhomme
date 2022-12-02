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
            ((System.ComponentModel.ISupportInitialize)(this.pbTV)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreationPoint
            // 
            this.btnCreationPoint.Location = new System.Drawing.Point(12, 328);
            this.btnCreationPoint.Name = "btnCreationPoint";
            this.btnCreationPoint.Size = new System.Drawing.Size(118, 23);
            this.btnCreationPoint.TabIndex = 0;
            this.btnCreationPoint.Text = "Creation Point";
            this.btnCreationPoint.UseVisualStyleBackColor = true;
            this.btnCreationPoint.Click += new System.EventHandler(this.btnCreationPoint_Click);
            // 
            // btnDeplacerPoint
            // 
            this.btnDeplacerPoint.Location = new System.Drawing.Point(163, 328);
            this.btnDeplacerPoint.Name = "btnDeplacerPoint";
            this.btnDeplacerPoint.Size = new System.Drawing.Size(118, 23);
            this.btnDeplacerPoint.TabIndex = 1;
            this.btnDeplacerPoint.Text = "Deplacer Point";
            this.btnDeplacerPoint.UseVisualStyleBackColor = true;
            this.btnDeplacerPoint.Click += new System.EventHandler(this.btnDeplacerPoint_Click);
            // 
            // btnCreationCercle
            // 
            this.btnCreationCercle.Location = new System.Drawing.Point(12, 357);
            this.btnCreationCercle.Name = "btnCreationCercle";
            this.btnCreationCercle.Size = new System.Drawing.Size(118, 23);
            this.btnCreationCercle.TabIndex = 3;
            this.btnCreationCercle.Text = "Creation Cercle";
            this.btnCreationCercle.UseVisualStyleBackColor = true;
            this.btnCreationCercle.Click += new System.EventHandler(this.btnCreationCercle_Click);
            // 
            // btnTimerFormes
            // 
            this.btnTimerFormes.Location = new System.Drawing.Point(342, 328);
            this.btnTimerFormes.Name = "btnTimerFormes";
            this.btnTimerFormes.Size = new System.Drawing.Size(266, 52);
            this.btnTimerFormes.TabIndex = 2;
            this.btnTimerFormes.Text = "Activer/Desactiver Timer ssi Point et Cercle existent";
            this.btnTimerFormes.UseVisualStyleBackColor = true;
            this.btnTimerFormes.Click += new System.EventHandler(this.btnTimerPoint_Click);
            // 
            // btnCreationRectangle
            // 
            this.btnCreationRectangle.Location = new System.Drawing.Point(12, 386);
            this.btnCreationRectangle.Name = "btnCreationRectangle";
            this.btnCreationRectangle.Size = new System.Drawing.Size(118, 23);
            this.btnCreationRectangle.TabIndex = 5;
            this.btnCreationRectangle.Text = "Creation Rectangle";
            this.btnCreationRectangle.UseVisualStyleBackColor = true;
            this.btnCreationRectangle.Click += new System.EventHandler(this.btnCreationRectangle_Click);
            // 
            // btnCreationCarrosse
            // 
            this.btnCreationCarrosse.Location = new System.Drawing.Point(12, 415);
            this.btnCreationCarrosse.Name = "btnCreationCarrosse";
            this.btnCreationCarrosse.Size = new System.Drawing.Size(118, 23);
            this.btnCreationCarrosse.TabIndex = 4;
            this.btnCreationCarrosse.Text = "Creation Carrosse";
            this.btnCreationCarrosse.UseVisualStyleBackColor = true;
            this.btnCreationCarrosse.Click += new System.EventHandler(this.btnCreationCarrosse_Click);
            // 
            // btnDeplacerCarrosse
            // 
            this.btnDeplacerCarrosse.Location = new System.Drawing.Point(163, 415);
            this.btnDeplacerCarrosse.Name = "btnDeplacerCarrosse";
            this.btnDeplacerCarrosse.Size = new System.Drawing.Size(118, 23);
            this.btnDeplacerCarrosse.TabIndex = 6;
            this.btnDeplacerCarrosse.Text = "Deplacer Carrosse";
            this.btnDeplacerCarrosse.UseVisualStyleBackColor = true;
            this.btnDeplacerCarrosse.Click += new System.EventHandler(this.btnDeplacerCarrosse_Click);
            // 
            // btnTimerCarrosse
            // 
            this.btnTimerCarrosse.Location = new System.Drawing.Point(342, 386);
            this.btnTimerCarrosse.Name = "btnTimerCarrosse";
            this.btnTimerCarrosse.Size = new System.Drawing.Size(266, 52);
            this.btnTimerCarrosse.TabIndex = 7;
            this.btnTimerCarrosse.Text = "Activer/Desactiver Timer Carrosse";
            this.btnTimerCarrosse.UseVisualStyleBackColor = true;
            this.btnTimerCarrosse.Click += new System.EventHandler(this.btnTimerCarrosse_Click);
            // 
            // btnEraseAll
            // 
            this.btnEraseAll.Location = new System.Drawing.Point(670, 328);
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
            this.pbTV.Size = new System.Drawing.Size(776, 310);
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
            // FicAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbTV);
            this.Controls.Add(this.btnEraseAll);
            this.Controls.Add(this.btnTimerCarrosse);
            this.Controls.Add(this.btnDeplacerCarrosse);
            this.Controls.Add(this.btnCreationRectangle);
            this.Controls.Add(this.btnCreationCarrosse);
            this.Controls.Add(this.btnCreationCercle);
            this.Controls.Add(this.btnTimerFormes);
            this.Controls.Add(this.btnDeplacerPoint);
            this.Controls.Add(this.btnCreationPoint);
            this.Name = "FicAccueil";
            this.Text = "Dessin Animé";
            ((System.ComponentModel.ISupportInitialize)(this.pbTV)).EndInit();
            this.ResumeLayout(false);

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
    }
}

