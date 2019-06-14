namespace Democrazik
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
            this.titre1 = new System.Windows.Forms.Label();
            this.titre2 = new System.Windows.Forms.Label();
            this.bNomServ = new System.Windows.Forms.Button();
            this.bUrlServ = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.bLancer = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titre1
            // 
            this.titre1.AutoSize = true;
            this.titre1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titre1.Location = new System.Drawing.Point(39, 15);
            this.titre1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titre1.Name = "titre1";
            this.titre1.Size = new System.Drawing.Size(557, 37);
            this.titre1.TabIndex = 0;
            this.titre1.Text = "Bienvenue sur votre espace serveur";
            // 
            // titre2
            // 
            this.titre2.AutoSize = true;
            this.titre2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titre2.Location = new System.Drawing.Point(40, 69);
            this.titre2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titre2.Name = "titre2";
            this.titre2.Size = new System.Drawing.Size(329, 26);
            this.titre2.TabIndex = 1;
            this.titre2.Text = "Veuillez configurer votre serveur:";
            // 
            // bNomServ
            // 
            this.bNomServ.Location = new System.Drawing.Point(406, 125);
            this.bNomServ.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bNomServ.Name = "bNomServ";
            this.bNomServ.Size = new System.Drawing.Size(80, 19);
            this.bNomServ.TabIndex = 2;
            this.bNomServ.Text = "Valider nom";
            this.bNomServ.UseVisualStyleBackColor = true;
            this.bNomServ.Click += new System.EventHandler(this.BNomServ_Click);
            // 
            // bUrlServ
            // 
            this.bUrlServ.Location = new System.Drawing.Point(406, 182);
            this.bUrlServ.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bUrlServ.Name = "bUrlServ";
            this.bUrlServ.Size = new System.Drawing.Size(80, 19);
            this.bUrlServ.TabIndex = 3;
            this.bUrlServ.Text = "Valider MDP";
            this.bUrlServ.UseVisualStyleBackColor = true;
            this.bUrlServ.Click += new System.EventHandler(this.BUrlServ_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(45, 125);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(341, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(45, 182);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(341, 20);
            this.textBox2.TabIndex = 5;
            // 
            // bLancer
            // 
            this.bLancer.Location = new System.Drawing.Point(217, 252);
            this.bLancer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bLancer.Name = "bLancer";
            this.bLancer.Size = new System.Drawing.Size(115, 19);
            this.bLancer.TabIndex = 6;
            this.bLancer.Text = "Initialiser serveur";
            this.bLancer.UseVisualStyleBackColor = true;
            this.bLancer.Click += new System.EventHandler(this.BLancer_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(479, 309);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 19);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bLancer);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bUrlServ);
            this.Controls.Add(this.bNomServ);
            this.Controls.Add(this.titre2);
            this.Controls.Add(this.titre1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titre1;
        private System.Windows.Forms.Label titre2;
        private System.Windows.Forms.Button bNomServ;
        private System.Windows.Forms.Button bUrlServ;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button bLancer;
        private System.Windows.Forms.Button button1;
    }
}

