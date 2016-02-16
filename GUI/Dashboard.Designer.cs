namespace GUI
{
    partial class Dashboard
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
            this.label1 = new System.Windows.Forms.Label();
            this.customersCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.supplierCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.elementsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.stockGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.stockGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kunden";
            // 
            // customersCheckedListBox
            // 
            this.customersCheckedListBox.FormattingEnabled = true;
            this.customersCheckedListBox.Location = new System.Drawing.Point(16, 29);
            this.customersCheckedListBox.Name = "customersCheckedListBox";
            this.customersCheckedListBox.Size = new System.Drawing.Size(120, 94);
            this.customersCheckedListBox.TabIndex = 3;
            this.customersCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.customersCheckedListBox_ItemCheck);
            // 
            // supplierCheckedListBox
            // 
            this.supplierCheckedListBox.FormattingEnabled = true;
            this.supplierCheckedListBox.Location = new System.Drawing.Point(143, 29);
            this.supplierCheckedListBox.Name = "supplierCheckedListBox";
            this.supplierCheckedListBox.Size = new System.Drawing.Size(120, 94);
            this.supplierCheckedListBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lieferwerke";
            // 
            // elementsCheckedListBox
            // 
            this.elementsCheckedListBox.FormattingEnabled = true;
            this.elementsCheckedListBox.Location = new System.Drawing.Point(270, 29);
            this.elementsCheckedListBox.Name = "elementsCheckedListBox";
            this.elementsCheckedListBox.Size = new System.Drawing.Size(120, 94);
            this.elementsCheckedListBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Elemente";
            // 
            // stockGridView
            // 
            this.stockGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stockGridView.Location = new System.Drawing.Point(16, 130);
            this.stockGridView.Name = "stockGridView";
            this.stockGridView.Size = new System.Drawing.Size(374, 150);
            this.stockGridView.TabIndex = 8;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 358);
            this.Controls.Add(this.stockGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.elementsCheckedListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.supplierCheckedListBox);
            this.Controls.Add(this.customersCheckedListBox);
            this.Controls.Add(this.label1);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.stockGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox customersCheckedListBox;
        private System.Windows.Forms.CheckedListBox supplierCheckedListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox elementsCheckedListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView stockGridView;
    }
}

