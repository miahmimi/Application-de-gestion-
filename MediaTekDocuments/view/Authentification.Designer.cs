
namespace MediaTekDocuments.view
{
    partial class Authentification
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
            this.btnvalider = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtlogin = new System.Windows.Forms.TextBox();
            this.txtpwd = new System.Windows.Forms.TextBox();
            this.dgvuti = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvuti)).BeginInit();
            this.SuspendLayout();
            // 
            // btnvalider
            // 
            this.btnvalider.Location = new System.Drawing.Point(57, 221);
            this.btnvalider.Name = "btnvalider";
            this.btnvalider.Size = new System.Drawing.Size(311, 42);
            this.btnvalider.TabIndex = 0;
            this.btnvalider.Text = "Valider";
            this.btnvalider.UseVisualStyleBackColor = true;
            this.btnvalider.Click += new System.EventHandler(this.btnvalider_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Identifiant :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mot de passe :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(137, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Bienvenue";
            // 
            // txtlogin
            // 
            this.txtlogin.Location = new System.Drawing.Point(193, 87);
            this.txtlogin.Name = "txtlogin";
            this.txtlogin.Size = new System.Drawing.Size(175, 22);
            this.txtlogin.TabIndex = 4;
            // 
            // txtpwd
            // 
            this.txtpwd.Location = new System.Drawing.Point(193, 158);
            this.txtpwd.Name = "txtpwd";
            this.txtpwd.Size = new System.Drawing.Size(175, 22);
            this.txtpwd.TabIndex = 5;
            // 
            // dgvuti
            // 
            this.dgvuti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvuti.Location = new System.Drawing.Point(417, 19);
            this.dgvuti.Name = "dgvuti";
            this.dgvuti.RowHeadersWidth = 51;
            this.dgvuti.RowTemplate.Height = 24;
            this.dgvuti.Size = new System.Drawing.Size(498, 207);
            this.dgvuti.TabIndex = 6;
            // 
            // Authentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 270);
            this.Controls.Add(this.dgvuti);
            this.Controls.Add(this.txtpwd);
            this.Controls.Add(this.txtlogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnvalider);
            this.Name = "Authentification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authentification";
            ((System.ComponentModel.ISupportInitialize)(this.dgvuti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnvalider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtlogin;
        private System.Windows.Forms.TextBox txtpwd;
        private System.Windows.Forms.DataGridView dgvuti;
    }
}