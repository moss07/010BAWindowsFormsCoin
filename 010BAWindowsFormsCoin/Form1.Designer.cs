
namespace _010BAWindowsFormsCoin
{
    partial class Form1Coin
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
            this.lbSonuc = new System.Windows.Forms.ListBox();
            this.bParaAt = new System.Windows.Forms.Button();
            this.pbPara = new System.Windows.Forms.PictureBox();
            this.lSonuc = new System.Windows.Forms.Label();
            this.lPara = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPara)).BeginInit();
            this.SuspendLayout();
            // 
            // lbSonuc
            // 
            this.lbSonuc.FormattingEnabled = true;
            this.lbSonuc.ItemHeight = 24;
            this.lbSonuc.Location = new System.Drawing.Point(85, 284);
            this.lbSonuc.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lbSonuc.Name = "lbSonuc";
            this.lbSonuc.Size = new System.Drawing.Size(179, 148);
            this.lbSonuc.TabIndex = 8;
            // 
            // bParaAt
            // 
            this.bParaAt.Location = new System.Drawing.Point(118, 178);
            this.bParaAt.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bParaAt.Name = "bParaAt";
            this.bParaAt.Size = new System.Drawing.Size(126, 40);
            this.bParaAt.TabIndex = 7;
            this.bParaAt.Text = "Para At";
            this.bParaAt.UseVisualStyleBackColor = true;
            this.bParaAt.Click += new System.EventHandler(this.bParaAt_Click);
            // 
            // pbPara
            // 
            this.pbPara.Location = new System.Drawing.Point(211, 47);
            this.pbPara.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pbPara.Name = "pbPara";
            this.pbPara.Size = new System.Drawing.Size(100, 100);
            this.pbPara.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPara.TabIndex = 6;
            this.pbPara.TabStop = false;
            // 
            // lSonuc
            // 
            this.lSonuc.AutoSize = true;
            this.lSonuc.ForeColor = System.Drawing.Color.DarkRed;
            this.lSonuc.Location = new System.Drawing.Point(131, 234);
            this.lSonuc.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lSonuc.Name = "lSonuc";
            this.lSonuc.Size = new System.Drawing.Size(75, 24);
            this.lSonuc.TabIndex = 4;
            this.lSonuc.Text = "lSonuc";
            // 
            // lPara
            // 
            this.lPara.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lPara.Location = new System.Drawing.Point(50, 47);
            this.lPara.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lPara.Name = "lPara";
            this.lPara.Size = new System.Drawing.Size(100, 100);
            this.lPara.TabIndex = 5;
            this.lPara.Text = "lPara";
            this.lPara.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1Coin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 461);
            this.Controls.Add(this.lbSonuc);
            this.Controls.Add(this.bParaAt);
            this.Controls.Add(this.pbPara);
            this.Controls.Add(this.lSonuc);
            this.Controls.Add(this.lPara);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1Coin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coin";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPara)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbSonuc;
        private System.Windows.Forms.Button bParaAt;
        private System.Windows.Forms.PictureBox pbPara;
        private System.Windows.Forms.Label lSonuc;
        private System.Windows.Forms.Label lPara;
    }
}

