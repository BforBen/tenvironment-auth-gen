namespace TascomiKeyGen
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.Token = new System.Windows.Forms.TextBox();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.PrivateKey = new TascomiKeyGen.WatermarkTextBox();
            this.PublicKey = new TascomiKeyGen.WatermarkTextBox();
            this.StatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generate Token";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Token
            // 
            this.Token.Location = new System.Drawing.Point(12, 106);
            this.Token.Multiline = true;
            this.Token.Name = "Token";
            this.Token.ReadOnly = true;
            this.Token.Size = new System.Drawing.Size(701, 35);
            this.Token.TabIndex = 1;
            // 
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.StatusStrip.Location = new System.Drawing.Point(0, 155);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(725, 22);
            this.StatusStrip.SizingGrip = false;
            this.StatusStrip.TabIndex = 5;
            this.StatusStrip.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // PrivateKey
            // 
            this.PrivateKey.Location = new System.Drawing.Point(12, 38);
            this.PrivateKey.Name = "PrivateKey";
            this.PrivateKey.Size = new System.Drawing.Size(691, 20);
            this.PrivateKey.TabIndex = 3;
            this.PrivateKey.WatermarkText = "Private key";
            // 
            // PublicKey
            // 
            this.PublicKey.Location = new System.Drawing.Point(12, 12);
            this.PublicKey.Name = "PublicKey";
            this.PublicKey.Size = new System.Drawing.Size(691, 20);
            this.PublicKey.TabIndex = 2;
            this.PublicKey.WatermarkText = "Public key";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 177);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.PrivateKey);
            this.Controls.Add(this.PublicKey);
            this.Controls.Add(this.Token);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Tascomi Key Generator";
            this.TopMost = true;
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Token;
        private WatermarkTextBox PublicKey;
        private WatermarkTextBox PrivateKey;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
    }
}

