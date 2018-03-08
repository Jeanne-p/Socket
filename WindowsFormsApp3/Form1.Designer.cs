namespace WindowsFormsApp3
{
    partial class Form1
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
            this.Connecter = new System.Windows.Forms.Button();
            this.Deconnection = new System.Windows.Forms.Button();
            this.Num1 = new System.Windows.Forms.GroupBox();
            this.Nomb1 = new System.Windows.Forms.TextBox();
            this.Num2 = new System.Windows.Forms.GroupBox();
            this.Nomb2 = new System.Windows.Forms.TextBox();
            this.Choisir = new System.Windows.Forms.GroupBox();
            this.Egal = new System.Windows.Forms.Button();
            this.Plusgrand = new System.Windows.Forms.Button();
            this.Pluspetit = new System.Windows.Forms.Button();
            this.Sous = new System.Windows.Forms.Button();
            this.Multi = new System.Windows.Forms.Button();
            this.Div = new System.Windows.Forms.Button();
            this.Mod = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Résultat = new System.Windows.Forms.GroupBox();
            this.Res = new System.Windows.Forms.TextBox();
            this.etatconnection = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Num1.SuspendLayout();
            this.Num2.SuspendLayout();
            this.Choisir.SuspendLayout();
            this.Résultat.SuspendLayout();
            this.SuspendLayout();
            // 
            // Connecter
            // 
            this.Connecter.Location = new System.Drawing.Point(12, 12);
            this.Connecter.Name = "Connecter";
            this.Connecter.Size = new System.Drawing.Size(245, 26);
            this.Connecter.TabIndex = 0;
            this.Connecter.Text = "Se connecter au serveur";
            this.Connecter.UseVisualStyleBackColor = true;
            this.Connecter.Click += new System.EventHandler(this.Connecter_Click);
            // 
            // Deconnection
            // 
            this.Deconnection.Location = new System.Drawing.Point(159, 290);
            this.Deconnection.Name = "Deconnection";
            this.Deconnection.Size = new System.Drawing.Size(222, 28);
            this.Deconnection.TabIndex = 1;
            this.Deconnection.Text = "Se déconnecter";
            this.Deconnection.UseVisualStyleBackColor = true;
            this.Deconnection.Click += new System.EventHandler(this.Deconnection_Click);
            // 
            // Num1
            // 
            this.Num1.Controls.Add(this.Nomb1);
            this.Num1.Location = new System.Drawing.Point(12, 63);
            this.Num1.Name = "Num1";
            this.Num1.Size = new System.Drawing.Size(245, 66);
            this.Num1.TabIndex = 2;
            this.Num1.TabStop = false;
            this.Num1.Text = "Entrez le premier nombre";
            // 
            // Nomb1
            // 
            this.Nomb1.Location = new System.Drawing.Point(0, 28);
            this.Nomb1.Name = "Nomb1";
            this.Nomb1.Size = new System.Drawing.Size(239, 20);
            this.Nomb1.TabIndex = 0;
            // 
            // Num2
            // 
            this.Num2.Controls.Add(this.Nomb2);
            this.Num2.Location = new System.Drawing.Point(278, 63);
            this.Num2.Name = "Num2";
            this.Num2.Size = new System.Drawing.Size(245, 66);
            this.Num2.TabIndex = 3;
            this.Num2.TabStop = false;
            this.Num2.Text = "Entrez le deuxième nombre";
            // 
            // Nomb2
            // 
            this.Nomb2.Location = new System.Drawing.Point(0, 28);
            this.Nomb2.Name = "Nomb2";
            this.Nomb2.Size = new System.Drawing.Size(239, 20);
            this.Nomb2.TabIndex = 0;
            // 
            // Choisir
            // 
            this.Choisir.Controls.Add(this.Egal);
            this.Choisir.Controls.Add(this.Plusgrand);
            this.Choisir.Controls.Add(this.Pluspetit);
            this.Choisir.Controls.Add(this.Sous);
            this.Choisir.Controls.Add(this.Multi);
            this.Choisir.Controls.Add(this.Div);
            this.Choisir.Controls.Add(this.Mod);
            this.Choisir.Controls.Add(this.Add);
            this.Choisir.Location = new System.Drawing.Point(58, 135);
            this.Choisir.Name = "Choisir";
            this.Choisir.Size = new System.Drawing.Size(426, 80);
            this.Choisir.TabIndex = 4;
            this.Choisir.TabStop = false;
            this.Choisir.Text = "Choisissez l\'opération à effectuer";
            // 
            // Egal
            // 
            this.Egal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Egal.Location = new System.Drawing.Point(363, 19);
            this.Egal.Name = "Egal";
            this.Egal.Size = new System.Drawing.Size(43, 38);
            this.Egal.TabIndex = 7;
            this.Egal.Text = "=";
            this.Egal.UseVisualStyleBackColor = true;
            this.Egal.Click += new System.EventHandler(this.Egal_Click);
            // 
            // Plusgrand
            // 
            this.Plusgrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Plusgrand.Location = new System.Drawing.Point(314, 19);
            this.Plusgrand.Name = "Plusgrand";
            this.Plusgrand.Size = new System.Drawing.Size(43, 38);
            this.Plusgrand.TabIndex = 6;
            this.Plusgrand.Text = ">";
            this.Plusgrand.UseVisualStyleBackColor = true;
            this.Plusgrand.Click += new System.EventHandler(this.Plusgrand_Click);
            // 
            // Pluspetit
            // 
            this.Pluspetit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Pluspetit.Location = new System.Drawing.Point(265, 19);
            this.Pluspetit.Name = "Pluspetit";
            this.Pluspetit.Size = new System.Drawing.Size(43, 38);
            this.Pluspetit.TabIndex = 5;
            this.Pluspetit.Text = "<";
            this.Pluspetit.UseVisualStyleBackColor = true;
            this.Pluspetit.Click += new System.EventHandler(this.Pluspetit_Click);
            // 
            // Sous
            // 
            this.Sous.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Sous.Location = new System.Drawing.Point(69, 19);
            this.Sous.Name = "Sous";
            this.Sous.Size = new System.Drawing.Size(43, 38);
            this.Sous.TabIndex = 4;
            this.Sous.Text = "-";
            this.Sous.UseVisualStyleBackColor = true;
            this.Sous.Click += new System.EventHandler(this.Sous_Click);
            // 
            // Multi
            // 
            this.Multi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Multi.Location = new System.Drawing.Point(118, 19);
            this.Multi.Name = "Multi";
            this.Multi.Size = new System.Drawing.Size(43, 38);
            this.Multi.TabIndex = 3;
            this.Multi.Text = "x";
            this.Multi.UseVisualStyleBackColor = true;
            this.Multi.Click += new System.EventHandler(this.Multi_Click);
            // 
            // Div
            // 
            this.Div.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Div.Location = new System.Drawing.Point(167, 19);
            this.Div.Name = "Div";
            this.Div.Size = new System.Drawing.Size(43, 38);
            this.Div.TabIndex = 2;
            this.Div.Text = "/";
            this.Div.UseVisualStyleBackColor = true;
            this.Div.Click += new System.EventHandler(this.Div_Click);
            // 
            // Mod
            // 
            this.Mod.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Mod.Location = new System.Drawing.Point(216, 19);
            this.Mod.Name = "Mod";
            this.Mod.Size = new System.Drawing.Size(43, 38);
            this.Mod.TabIndex = 1;
            this.Mod.Text = "%";
            this.Mod.UseVisualStyleBackColor = true;
            this.Mod.Click += new System.EventHandler(this.Mod_Click);
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Add.Location = new System.Drawing.Point(20, 19);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(43, 38);
            this.Add.TabIndex = 0;
            this.Add.Text = "+";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Résultat
            // 
            this.Résultat.Controls.Add(this.Res);
            this.Résultat.Location = new System.Drawing.Point(78, 221);
            this.Résultat.Name = "Résultat";
            this.Résultat.Size = new System.Drawing.Size(386, 46);
            this.Résultat.TabIndex = 5;
            this.Résultat.TabStop = false;
            this.Résultat.Text = "Résultat";
            // 
            // Res
            // 
            this.Res.Location = new System.Drawing.Point(3, 16);
            this.Res.Name = "Res";
            this.Res.Size = new System.Drawing.Size(383, 20);
            this.Res.TabIndex = 0;
            // 
            // etatconnection
            // 
            this.etatconnection.Location = new System.Drawing.Point(281, 14);
            this.etatconnection.Multiline = true;
            this.etatconnection.Name = "etatconnection";
            this.etatconnection.Size = new System.Drawing.Size(235, 24);
            this.etatconnection.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 330);
            this.Controls.Add(this.etatconnection);
            this.Controls.Add(this.Résultat);
            this.Controls.Add(this.Choisir);
            this.Controls.Add(this.Num2);
            this.Controls.Add(this.Num1);
            this.Controls.Add(this.Deconnection);
            this.Controls.Add(this.Connecter);
            this.Name = "Form1";
            this.Text = "Opérations sur grands nombres";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Num1.ResumeLayout(false);
            this.Num1.PerformLayout();
            this.Num2.ResumeLayout(false);
            this.Num2.PerformLayout();
            this.Choisir.ResumeLayout(false);
            this.Résultat.ResumeLayout(false);
            this.Résultat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Connecter;
        private System.Windows.Forms.Button Deconnection;
        private System.Windows.Forms.GroupBox Num1;
        private System.Windows.Forms.TextBox Nomb1;
        private System.Windows.Forms.GroupBox Num2;
        private System.Windows.Forms.TextBox Nomb2;
        private System.Windows.Forms.GroupBox Choisir;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Pluspetit;
        private System.Windows.Forms.Button Sous;
        private System.Windows.Forms.Button Multi;
        private System.Windows.Forms.Button Div;
        private System.Windows.Forms.Button Mod;
        private System.Windows.Forms.Button Egal;
        private System.Windows.Forms.Button Plusgrand;
        private System.Windows.Forms.GroupBox Résultat;
        private System.Windows.Forms.TextBox Res;
        private System.Windows.Forms.TextBox etatconnection;
        private System.Windows.Forms.Timer timer1;
    }
}

