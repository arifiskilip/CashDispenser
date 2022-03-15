
namespace Login
{
    partial class FrmChangePassword
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
            this.btnChange = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNewPas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOldPas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNewPasRetry = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnChange
            // 
            this.btnChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnChange.Location = new System.Drawing.Point(375, 61);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(106, 77);
            this.btnChange.TabIndex = 9;
            this.btnChange.Text = "Değiştir";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(22, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Şifre Tekrar :";
            // 
            // txtNewPas
            // 
            this.txtNewPas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNewPas.Location = new System.Drawing.Point(159, 86);
            this.txtNewPas.Name = "txtNewPas";
            this.txtNewPas.PasswordChar = '*';
            this.txtNewPas.Size = new System.Drawing.Size(181, 26);
            this.txtNewPas.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(22, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Eski Şifre :";
            // 
            // txtOldPas
            // 
            this.txtOldPas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOldPas.Location = new System.Drawing.Point(159, 35);
            this.txtOldPas.Name = "txtOldPas";
            this.txtOldPas.Size = new System.Drawing.Size(181, 26);
            this.txtOldPas.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(22, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Yeni Şifre :";
            // 
            // txtNewPasRetry
            // 
            this.txtNewPasRetry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNewPasRetry.Location = new System.Drawing.Point(159, 136);
            this.txtNewPasRetry.Name = "txtNewPasRetry";
            this.txtNewPasRetry.PasswordChar = '*';
            this.txtNewPasRetry.Size = new System.Drawing.Size(181, 26);
            this.txtNewPasRetry.TabIndex = 10;
            // 
            // FrmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 188);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNewPasRetry);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNewPas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOldPas);
            this.Name = "FrmChangePassword";
            this.Text = "FrmChangePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNewPas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOldPas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNewPasRetry;
    }
}