using System;

namespace Nike
{
    partial class View
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.buttonLister = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(57, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(894, 110);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nike Stockage";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.BackColor = System.Drawing.SystemColors.ControlText;
            this.buttonAjouter.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAjouter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonAjouter.Location = new System.Drawing.Point(371, 350);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(270, 60);
            this.buttonAjouter.TabIndex = 1;
            this.buttonAjouter.Text = "Ajouter un produit";
            this.buttonAjouter.UseVisualStyleBackColor = false;
            // 
            // buttonLister
            // 
            this.buttonLister.BackColor = System.Drawing.SystemColors.ControlText;
            this.buttonLister.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonLister.Location = new System.Drawing.Point(371, 466);
            this.buttonLister.Name = "buttonLister";
            this.buttonLister.Size = new System.Drawing.Size(270, 60);
            this.buttonLister.TabIndex = 2;
            this.buttonLister.Text = "Lister de produits";
            this.buttonLister.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.Image = global::Nike.Properties.Resources.LogoNikeStore1;
            this.label2.Location = new System.Drawing.Point(353, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(332, 136);
            this.label2.TabIndex = 3;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(24F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1040, 582);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonLister);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "View";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button buttonAjouter;
        public System.Windows.Forms.Button buttonLister;
        private System.Windows.Forms.Label label2;
    }
}

