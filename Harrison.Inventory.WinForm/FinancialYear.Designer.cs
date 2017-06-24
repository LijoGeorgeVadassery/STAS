namespace Harrison.Inventory.WinForm
{
    partial class FinancialYear
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Add_Fin_Year_Bttn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.FinancialYear_Grid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.FinancialYear_Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(120, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(171, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Financial Year";
            // 
            // Add_Fin_Year_Bttn
            // 
            this.Add_Fin_Year_Bttn.Location = new System.Drawing.Point(52, 76);
            this.Add_Fin_Year_Bttn.Name = "Add_Fin_Year_Bttn";
            this.Add_Fin_Year_Bttn.Size = new System.Drawing.Size(75, 23);
            this.Add_Fin_Year_Bttn.TabIndex = 2;
            this.Add_Fin_Year_Bttn.Text = "ADD";
            this.Add_Fin_Year_Bttn.UseVisualStyleBackColor = true;
            this.Add_Fin_Year_Bttn.Click += new System.EventHandler(this.Add_Fin_Year_Bttn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(134, 75);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(216, 76);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // FinancialYear_Grid
            // 
            this.FinancialYear_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FinancialYear_Grid.Location = new System.Drawing.Point(43, 124);
            this.FinancialYear_Grid.Name = "FinancialYear_Grid";
            this.FinancialYear_Grid.Size = new System.Drawing.Size(249, 150);
            this.FinancialYear_Grid.TabIndex = 5;
            // 
            // FinancialYear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 289);
            this.Controls.Add(this.FinancialYear_Grid);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Add_Fin_Year_Bttn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "FinancialYear";
            this.Text = "FinancialYear";
            this.Load += new System.EventHandler(this.FinancialYear_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FinancialYear_Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Add_Fin_Year_Bttn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView FinancialYear_Grid;
    }
}