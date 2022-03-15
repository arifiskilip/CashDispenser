
namespace Login
{
    partial class FrmDepositFunds
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
            this.btnDepositFunds = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDepositFunds
            // 
            this.btnDepositFunds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDepositFunds.Location = new System.Drawing.Point(321, 44);
            this.btnDepositFunds.Name = "btnDepositFunds";
            this.btnDepositFunds.Size = new System.Drawing.Size(106, 77);
            this.btnDepositFunds.TabIndex = 10;
            this.btnDepositFunds.Text = "Yatır";
            this.btnDepositFunds.UseVisualStyleBackColor = true;
            this.btnDepositFunds.Click += new System.EventHandler(this.btnDepositFunds_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Miktar :";
            // 
            // txtMoney
            // 
            this.txtMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMoney.Location = new System.Drawing.Point(126, 72);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(164, 26);
            this.txtMoney.TabIndex = 8;
            // 
            // FrmDepositFunds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 161);
            this.Controls.Add(this.btnDepositFunds);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMoney);
            this.Name = "FrmDepositFunds";
            this.Text = "FrmDepositFunds";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDepositFunds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMoney;
    }
}