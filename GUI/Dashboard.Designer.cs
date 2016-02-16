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
            this.customerCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.supplierCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.elementCheckedListBox = new System.Windows.Forms.CheckedListBox();
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
            // customerCheckedListBox
            // 
            this.customerCheckedListBox.FormattingEnabled = true;
            this.customerCheckedListBox.Location = new System.Drawing.Point(16, 29);
            this.customerCheckedListBox.Name = "customerCheckedListBox";
            this.customerCheckedListBox.Size = new System.Drawing.Size(120, 94);
            this.customerCheckedListBox.TabIndex = 3;
            this.customerCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.allCheckedListBox_ItemCheck);
            // 
            // supplierCheckedListBox
            // 
            this.supplierCheckedListBox.FormattingEnabled = true;
            this.supplierCheckedListBox.Location = new System.Drawing.Point(143, 29);
            this.supplierCheckedListBox.Name = "supplierCheckedListBox";
            this.supplierCheckedListBox.Size = new System.Drawing.Size(120, 94);
            this.supplierCheckedListBox.TabIndex = 4;
            this.supplierCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.allCheckedListBox_ItemCheck);
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
            // elementCheckedListBox
            // 
            this.elementCheckedListBox.FormattingEnabled = true;
            this.elementCheckedListBox.Location = new System.Drawing.Point(270, 29);
            this.elementCheckedListBox.Name = "elementCheckedListBox";
            this.elementCheckedListBox.Size = new System.Drawing.Size(120, 94);
            this.elementCheckedListBox.TabIndex = 6;
            this.elementCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.allCheckedListBox_ItemCheck);
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
            this.stockGridView.AllowUserToAddRows = false;
            this.stockGridView.AllowUserToDeleteRows = false;
            this.stockGridView.AllowUserToOrderColumns = true;
            this.stockGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.stockGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stockGridView.Location = new System.Drawing.Point(16, 130);
            this.stockGridView.Name = "stockGridView";
            this.stockGridView.ShowEditingIcon = false;
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
            this.Controls.Add(this.elementCheckedListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.supplierCheckedListBox);
            this.Controls.Add(this.customerCheckedListBox);
            this.Controls.Add(this.label1);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.stockGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox customerCheckedListBox;
        private System.Windows.Forms.CheckedListBox supplierCheckedListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox elementCheckedListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView stockGridView;
    }
}

