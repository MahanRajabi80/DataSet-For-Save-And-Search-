namespace Example_20_17
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
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFam = new System.Windows.Forms.TextBox();
            this.txtMaskTel = new System.Windows.Forms.MaskedTextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxSearch = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(347, 28);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(40, 94);
            this.btnInsert.TabIndex = 4;
            this.btnInsert.Text = "درج";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(393, 28);
            this.txtName.Name = "txtName";
            this.txtName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtName.Size = new System.Drawing.Size(129, 20);
            this.txtName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(528, 28);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "نـــــــــــــــام :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(528, 64);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "نام خانوادگی:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(528, 102);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "تلفـــــــــــــــن:";
            // 
            // txtFam
            // 
            this.txtFam.Location = new System.Drawing.Point(393, 64);
            this.txtFam.Name = "txtFam";
            this.txtFam.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFam.Size = new System.Drawing.Size(129, 20);
            this.txtFam.TabIndex = 1;
            // 
            // txtMaskTel
            // 
            this.txtMaskTel.Location = new System.Drawing.Point(393, 102);
            this.txtMaskTel.Mask = "0000-0000000";
            this.txtMaskTel.Name = "txtMaskTel";
            this.txtMaskTel.Size = new System.Drawing.Size(129, 20);
            this.txtMaskTel.TabIndex = 2;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 25);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSearch.Size = new System.Drawing.Size(198, 20);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 25);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "جستجوی نام خانوادگی:";
            // 
            // listBoxSearch
            // 
            this.listBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.listBoxSearch.FormattingEnabled = true;
            this.listBoxSearch.Location = new System.Drawing.Point(12, 53);
            this.listBoxSearch.Name = "listBoxSearch";
            this.listBoxSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listBoxSearch.ScrollAlwaysVisible = true;
            this.listBoxSearch.Size = new System.Drawing.Size(198, 69);
            this.listBoxSearch.TabIndex = 6;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnInsert;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(642, 145);
            this.Controls.Add(this.listBoxSearch);
            this.Controls.Add(this.txtMaskTel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtFam);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnInsert);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Example 20-17 (DataSet for Save and Search)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFam;
        private System.Windows.Forms.MaskedTextBox txtMaskTel;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxSearch;
    }
}

