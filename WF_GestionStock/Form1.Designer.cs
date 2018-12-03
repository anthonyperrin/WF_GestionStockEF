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
            this.ListMvt = new System.Windows.Forms.ListView();
            this.IdProduit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Produit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AjoutProduitCategorie
            // 
            this.AjoutProduitCategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AjoutProduitCategorie.FormattingEnabled = true;
            this.AjoutProduitCategorie.Location = new System.Drawing.Point(14, 91);
            this.AjoutProduitCategorie.Margin = new System.Windows.Forms.Padding(2);
            this.AjoutProduitCategorie.Name = "AjoutProduitCategorie";
            this.AjoutProduitCategorie.Size = new System.Drawing.Size(117, 21);
            this.AjoutProduitCategorie.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Créer un mouvement de stock";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Catégorie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ajouter un produit";
            // 
            // AjoutProduitNom
            // 
            this.AjoutProduitNom.Location = new System.Drawing.Point(14, 129);
            this.AjoutProduitNom.Margin = new System.Windows.Forms.Padding(2);
            this.AjoutProduitNom.Name = "AjoutProduitNom";
            this.AjoutProduitNom.Size = new System.Drawing.Size(117, 20);
            this.AjoutProduitNom.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 113);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nom";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 168);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "$";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 150);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Prix HT";
            // 
            // AjoutProduitPrixHT
            // 
            this.AjoutProduitPrixHT.Location = new System.Drawing.Point(14, 166);
            this.AjoutProduitPrixHT.Margin = new System.Windows.Forms.Padding(2);
            this.AjoutProduitPrixHT.Name = "AjoutProduitPrixHT";
            this.AjoutProduitPrixHT.Size = new System.Drawing.Size(101, 20);
            this.AjoutProduitPrixHT.TabIndex = 8;
            // 
            // AjoutProduitButton
            // 
            this.AjoutProduitButton.Location = new System.Drawing.Point(14, 188);
            this.AjoutProduitButton.Margin = new System.Windows.Forms.Padding(2);
            this.AjoutProduitButton.Name = "AjoutProduitButton";
            this.AjoutProduitButton.Size = new System.Drawing.Size(56, 19);
            this.AjoutProduitButton.TabIndex = 9;
            this.AjoutProduitButton.Text = "Ajouter";
            this.AjoutProduitButton.UseVisualStyleBackColor = true;
            this.AjoutProduitButton.Click += new System.EventHandler(this.AjoutProduitButton_Click);
            // 
            // ListMvt
            // 
            this.ListMvt.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.ListMvt.BackColor = System.Drawing.SystemColors.Window;
            this.ListMvt.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdProduit,
            this.Type,
            this.Produit});
            this.ListMvt.LabelEdit = true;
            this.ListMvt.Location = new System.Drawing.Point(170, 91);
            this.ListMvt.Name = "ListMvt";
            this.ListMvt.Size = new System.Drawing.Size(325, 217);
            this.ListMvt.TabIndex = 10;
            this.ListMvt.UseCompatibleStateImageBehavior = false;
            this.ListMvt.View = System.Windows.Forms.View.Details;
            this.ListMvt.SelectedIndexChanged += new System.EventHandler(this.ListMvt_SelectedIndexChanged);
            // 
            // IdProduit
            // 
            this.IdProduit.Text = "Réf. Produit";
            this.IdProduit.Width = 40;
            // 
            // Type
            // 
            this.Type.Text = "Mouvement";
            this.Type.Width = 71;
            // 
            // Produit
            // 
            this.Produit.Text = "Nom du produit";
            this.Produit.Width = 210;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(166, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Historique";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 318);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ListMvt);
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
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader Produit;
        public System.Windows.Forms.ListView ListMvt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ColumnHeader IdProduit;
    }
}

