namespace WF_GestionStock
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
            this.AjoutProduitCategorie = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AjoutProduitNom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AjoutProduitPrixHT = new System.Windows.Forms.TextBox();
            this.AjoutProduitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AjoutProduitCategorie
            // 
            this.AjoutProduitCategorie.Font = new System.Drawing.Font("Lato", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AjoutProduitCategorie.FormattingEnabled = true;
            this.AjoutProduitCategorie.Location = new System.Drawing.Point(18, 112);
            this.AjoutProduitCategorie.Name = "AjoutProduitCategorie";
            this.AjoutProduitCategorie.Size = new System.Drawing.Size(155, 24);
            this.AjoutProduitCategorie.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Créer un mouvement de stock";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Catégorie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ajouter un produit";
            // 
            // AjoutProduitNom
            // 
            this.AjoutProduitNom.Location = new System.Drawing.Point(18, 159);
            this.AjoutProduitNom.Name = "AjoutProduitNom";
            this.AjoutProduitNom.Size = new System.Drawing.Size(155, 22);
            this.AjoutProduitNom.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nom";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(157, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "$";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Prix HT";
            // 
            // AjoutProduitPrixHT
            // 
            this.AjoutProduitPrixHT.Location = new System.Drawing.Point(18, 204);
            this.AjoutProduitPrixHT.Name = "AjoutProduitPrixHT";
            this.AjoutProduitPrixHT.Size = new System.Drawing.Size(133, 22);
            this.AjoutProduitPrixHT.TabIndex = 8;
            // 
            // AjoutProduitButton
            // 
            this.AjoutProduitButton.Location = new System.Drawing.Point(18, 232);
            this.AjoutProduitButton.Name = "AjoutProduitButton";
            this.AjoutProduitButton.Size = new System.Drawing.Size(75, 23);
            this.AjoutProduitButton.TabIndex = 9;
            this.AjoutProduitButton.Text = "Ajouter";
            this.AjoutProduitButton.UseVisualStyleBackColor = true;
            this.AjoutProduitButton.Click += new System.EventHandler(this.AjoutProduitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 391);
            this.Controls.Add(this.AjoutProduitButton);
            this.Controls.Add(this.AjoutProduitPrixHT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AjoutProduitNom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AjoutProduitCategorie);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox AjoutProduitCategorie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AjoutProduitNom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox AjoutProduitPrixHT;
        private System.Windows.Forms.Button AjoutProduitButton;
    }
}

