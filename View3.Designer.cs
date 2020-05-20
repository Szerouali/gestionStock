namespace Nike
{
    partial class View3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listeProduit = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonTop = new System.Windows.Forms.Button();
            this.buttonBas = new System.Windows.Forms.Button();
            this.buttonChaussure = new System.Windows.Forms.Button();
            this.buttonTout = new System.Windows.Forms.Button();
            this.buttonAccessoire = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonRetour = new System.Windows.Forms.Button();
            this.buttonDetail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listeProduit
            // 
            this.listeProduit.BackColor = System.Drawing.SystemColors.Window;
            this.listeProduit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.listeProduit.FormattingEnabled = true;
            this.listeProduit.ItemHeight = 26;
            this.listeProduit.Location = new System.Drawing.Point(493, 168);
            this.listeProduit.Margin = new System.Windows.Forms.Padding(5);
            this.listeProduit.Name = "listeProduit";
            this.listeProduit.Size = new System.Drawing.Size(560, 498);
            this.listeProduit.TabIndex = 0;
            this.listeProduit.SelectedIndexChanged += new System.EventHandler(this.listeProduit_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(427, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Liste de produits";
            // 
            // buttonTop
            // 
            this.buttonTop.BackColor = System.Drawing.SystemColors.ControlText;
            this.buttonTop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonTop.Location = new System.Drawing.Point(179, 231);
            this.buttonTop.Margin = new System.Windows.Forms.Padding(5);
            this.buttonTop.Name = "buttonTop";
            this.buttonTop.Size = new System.Drawing.Size(200, 60);
            this.buttonTop.TabIndex = 2;
            this.buttonTop.TabStop = false;
            this.buttonTop.Text = "Top";
            this.buttonTop.UseVisualStyleBackColor = false;
            this.buttonTop.UseWaitCursor = true;
            // 
            // buttonBas
            // 
            this.buttonBas.BackColor = System.Drawing.SystemColors.ControlText;
            this.buttonBas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonBas.Location = new System.Drawing.Point(179, 329);
            this.buttonBas.Margin = new System.Windows.Forms.Padding(5);
            this.buttonBas.Name = "buttonBas";
            this.buttonBas.Size = new System.Drawing.Size(200, 60);
            this.buttonBas.TabIndex = 3;
            this.buttonBas.Text = "Bas";
            this.buttonBas.UseVisualStyleBackColor = false;
            // 
            // buttonChaussure
            // 
            this.buttonChaussure.BackColor = System.Drawing.SystemColors.ControlText;
            this.buttonChaussure.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonChaussure.Location = new System.Drawing.Point(179, 424);
            this.buttonChaussure.Margin = new System.Windows.Forms.Padding(5);
            this.buttonChaussure.Name = "buttonChaussure";
            this.buttonChaussure.Size = new System.Drawing.Size(200, 60);
            this.buttonChaussure.TabIndex = 4;
            this.buttonChaussure.Text = "Chaussures";
            this.buttonChaussure.UseVisualStyleBackColor = false;
            // 
            // buttonTout
            // 
            this.buttonTout.BackColor = System.Drawing.SystemColors.WindowText;
            this.buttonTout.Location = new System.Drawing.Point(179, 138);
            this.buttonTout.Name = "buttonTout";
            this.buttonTout.Size = new System.Drawing.Size(200, 60);
            this.buttonTout.TabIndex = 5;
            this.buttonTout.Text = "Tout";
            this.buttonTout.UseVisualStyleBackColor = false;
            // 
            // buttonAccessoire
            // 
            this.buttonAccessoire.BackColor = System.Drawing.SystemColors.WindowText;
            this.buttonAccessoire.Location = new System.Drawing.Point(179, 532);
            this.buttonAccessoire.Name = "buttonAccessoire";
            this.buttonAccessoire.Size = new System.Drawing.Size(200, 60);
            this.buttonAccessoire.TabIndex = 6;
            this.buttonAccessoire.Text = "Accessoires";
            this.buttonAccessoire.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(497, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(558, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Categorie";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(661, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Taille";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(729, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Quantité";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(822, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Référence";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(928, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 21);
            this.label7.TabIndex = 12;
            this.label7.Text = "Prix";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(981, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 21);
            this.label8.TabIndex = 13;
            this.label8.Text = "Couleur";
            // 
            // buttonRetour
            // 
            this.buttonRetour.BackColor = System.Drawing.SystemColors.WindowText;
            this.buttonRetour.Location = new System.Drawing.Point(12, 12);
            this.buttonRetour.Name = "buttonRetour";
            this.buttonRetour.Size = new System.Drawing.Size(112, 56);
            this.buttonRetour.TabIndex = 14;
            this.buttonRetour.Text = "Retour";
            this.buttonRetour.UseVisualStyleBackColor = false;
            // 
            // buttonDetail
            // 
            this.buttonDetail.BackColor = System.Drawing.SystemColors.InfoText;
            this.buttonDetail.Location = new System.Drawing.Point(954, 12);
            this.buttonDetail.Name = "buttonDetail";
            this.buttonDetail.Size = new System.Drawing.Size(112, 56);
            this.buttonDetail.TabIndex = 15;
            this.buttonDetail.Text = "Detail";
            this.buttonDetail.UseVisualStyleBackColor = false;
            // 
            // View3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.ClientSize = new System.Drawing.Size(1078, 694);
            this.Controls.Add(this.buttonDetail);
            this.Controls.Add(this.buttonRetour);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonAccessoire);
            this.Controls.Add(this.buttonTout);
            this.Controls.Add(this.buttonChaussure);
            this.Controls.Add(this.buttonBas);
            this.Controls.Add(this.buttonTop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listeProduit);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "View3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.View3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox listeProduit;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button buttonTop;
        public System.Windows.Forms.Button buttonBas;
        public System.Windows.Forms.Button buttonChaussure;
        public System.Windows.Forms.Button buttonTout;
        public System.Windows.Forms.Button buttonAccessoire;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Button buttonRetour;
        public System.Windows.Forms.Button buttonDetail;
    }
}