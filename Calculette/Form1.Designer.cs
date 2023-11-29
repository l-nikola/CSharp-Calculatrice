
namespace Calculette
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
            this.Nombre1 = new System.Windows.Forms.TextBox();
            this.Nombre2 = new System.Windows.Forms.TextBox();
            this.Operateur = new System.Windows.Forms.ComboBox();
            this.Calcul = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Nombre1
            // 
            this.Nombre1.Location = new System.Drawing.Point(106, 106);
            this.Nombre1.Name = "Nombre1";
            this.Nombre1.Size = new System.Drawing.Size(100, 20);
            this.Nombre1.TabIndex = 0;
            this.Nombre1.TextChanged += new System.EventHandler(this.Nombre1_TextChanged);
            // 
            // Nombre2
            // 
            this.Nombre2.Location = new System.Drawing.Point(106, 320);
            this.Nombre2.Name = "Nombre2";
            this.Nombre2.Size = new System.Drawing.Size(100, 20);
            this.Nombre2.TabIndex = 1;
            this.Nombre2.TextChanged += new System.EventHandler(this.Nombre2_TextChanged);
            // 
            // Operateur
            // 
            this.Operateur.FormattingEnabled = true;
            this.Operateur.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.Operateur.Location = new System.Drawing.Point(106, 214);
            this.Operateur.Name = "Operateur";
            this.Operateur.Size = new System.Drawing.Size(100, 21);
            this.Operateur.TabIndex = 3;
            this.Operateur.SelectedIndexChanged += new System.EventHandler(this.Operateur_SelectedIndexChanged);
            // 
            // Calcul
            // 
            this.Calcul.Location = new System.Drawing.Point(303, 212);
            this.Calcul.Name = "Calcul";
            this.Calcul.Size = new System.Drawing.Size(75, 23);
            this.Calcul.TabIndex = 4;
            this.Calcul.Text = "Calculer";
            this.Calcul.UseVisualStyleBackColor = true;
            this.Calcul.Click += new System.EventHandler(this.Calcul_Click);
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(534, 220);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(100, 20);
            this.Result.TabIndex = 2;
            this.Result.TextChanged += new System.EventHandler(this.Result_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Fuchsia;
            this.label1.Location = new System.Drawing.Point(226, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ma Petite Calculatrice";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Opérateur";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nombre 1";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 390);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(657, 39);
            this.label5.TabIndex = 9;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(552, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Résultat";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Calcul);
            this.Controls.Add(this.Operateur);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Nombre2);
            this.Controls.Add(this.Nombre1);
            this.Name = "Form1";
            this.Text = "FrmCalculette";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Nombre1;
        private System.Windows.Forms.TextBox Nombre2;
        private System.Windows.Forms.ComboBox Operateur;
        private System.Windows.Forms.Button Calcul;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

