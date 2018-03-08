namespace WindowsFormsApp2
{
    partial class Form2
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
            this.demarrer = new System.Windows.Forms.Button();
            this.etat = new System.Windows.Forms.TextBox();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // demarrer
            // 
            this.demarrer.Location = new System.Drawing.Point(89, 24);
            this.demarrer.Name = "demarrer";
            this.demarrer.Size = new System.Drawing.Size(261, 32);
            this.demarrer.TabIndex = 0;
            this.demarrer.Text = "Démarrer le serveur TCP";
            this.demarrer.UseVisualStyleBackColor = true;
            this.demarrer.Click += new System.EventHandler(this.demarrer_Click);
            // 
            // etat
            // 
            this.etat.Location = new System.Drawing.Point(42, 76);
            this.etat.Multiline = true;
            this.etat.Name = "etat";
            this.etat.Size = new System.Drawing.Size(350, 143);
            this.etat.TabIndex = 1;
            // 
            // Timer1
            // 
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 244);
            this.Controls.Add(this.etat);
            this.Controls.Add(this.demarrer);
            this.Name = "Form2";
            this.Text = "Serveur TCP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button demarrer;
        private System.Windows.Forms.TextBox etat;
        private System.Windows.Forms.Timer Timer1;
    }
}

