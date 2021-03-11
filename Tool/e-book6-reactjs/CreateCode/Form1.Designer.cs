namespace CreateCode
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
            this.tbxUrl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxCol = new System.Windows.Forms.TextBox();
            this.tbxText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.cbxInput = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tbxUrl
            // 
            this.tbxUrl.Location = new System.Drawing.Point(12, 32);
            this.tbxUrl.Name = "tbxUrl";
            this.tbxUrl.Size = new System.Drawing.Size(198, 20);
            this.tbxUrl.TabIndex = 0;
            this.tbxUrl.Text = "Page0/E0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Column:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "{ url: \'img/FriendsPlus/Page0/E0/1.jpg\' },";
            // 
            // tbxCol
            // 
            this.tbxCol.Location = new System.Drawing.Point(15, 71);
            this.tbxCol.Name = "tbxCol";
            this.tbxCol.Size = new System.Drawing.Size(259, 20);
            this.tbxCol.TabIndex = 3;
            this.tbxCol.Text = "1 3 1 3";
            // 
            // tbxText
            // 
            this.tbxText.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxText.Location = new System.Drawing.Point(15, 122);
            this.tbxText.Multiline = true;
            this.tbxText.Name = "tbxText";
            this.tbxText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbxText.Size = new System.Drawing.Size(259, 147);
            this.tbxText.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "text:";
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(216, 32);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(58, 23);
            this.btnRun.TabIndex = 7;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // cbxInput
            // 
            this.cbxInput.AllowDrop = true;
            this.cbxInput.AutoSize = true;
            this.cbxInput.Location = new System.Drawing.Point(194, 99);
            this.cbxInput.Name = "cbxInput";
            this.cbxInput.Size = new System.Drawing.Size(70, 17);
            this.cbxInput.TabIndex = 8;
            this.cbxInput.Text = "add input";
            this.cbxInput.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 302);
            this.Controls.Add(this.cbxInput);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxText);
            this.Controls.Add(this.tbxCol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxUrl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxCol;
        private System.Windows.Forms.TextBox tbxText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.CheckBox cbxInput;
    }
}

