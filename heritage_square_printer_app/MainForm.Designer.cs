namespace heritage_square_printer_app
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.addItemButton = new System.Windows.Forms.Button();
            this.boothTextBox = new System.Windows.Forms.TextBox();
            this.itemAmountTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ItemDataView = new System.Windows.Forms.DataGridView();
            this.printButton = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.SettingsButtons = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.itemNumbertextBox = new System.Windows.Forms.TextBox();
            this.ItemDescOneTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ItemDescTwoTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ItemDescThreeTextBox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.EachcheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.ItemDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // addItemButton
            // 
            this.addItemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.addItemButton.Location = new System.Drawing.Point(34, 329);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(178, 47);
            this.addItemButton.TabIndex = 0;
            this.addItemButton.Text = "Add item";
            this.addItemButton.UseVisualStyleBackColor = true;
            this.addItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // boothTextBox
            // 
            this.boothTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.boothTextBox.Location = new System.Drawing.Point(200, 47);
            this.boothTextBox.Name = "boothTextBox";
            this.boothTextBox.Size = new System.Drawing.Size(266, 32);
            this.boothTextBox.TabIndex = 1;
            // 
            // itemAmountTextBox
            // 
            this.itemAmountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.itemAmountTextBox.Location = new System.Drawing.Point(200, 274);
            this.itemAmountTextBox.Name = "itemAmountTextBox";
            this.itemAmountTextBox.Size = new System.Drawing.Size(179, 32);
            this.itemAmountTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(32, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Booth number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(12, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Item Desc line 1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.Location = new System.Drawing.Point(93, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Amount:";
            // 
            // ItemDataView
            // 
            this.ItemDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemDataView.Location = new System.Drawing.Point(488, 47);
            this.ItemDataView.Name = "ItemDataView";
            this.ItemDataView.Size = new System.Drawing.Size(458, 329);
            this.ItemDataView.TabIndex = 7;
            // 
            // printButton
            // 
            this.printButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.printButton.Location = new System.Drawing.Point(34, 382);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(362, 47);
            this.printButton.TabIndex = 9;
            this.printButton.Text = "Print";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // SettingsButtons
            // 
            this.SettingsButtons.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.SettingsButtons.Location = new System.Drawing.Point(218, 329);
            this.SettingsButtons.Name = "SettingsButtons";
            this.SettingsButtons.Size = new System.Drawing.Size(178, 47);
            this.SettingsButtons.TabIndex = 10;
            this.SettingsButtons.Text = "settings";
            this.SettingsButtons.UseVisualStyleBackColor = true;
            this.SettingsButtons.Click += new System.EventHandler(this.SettingsButtons_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label4.Location = new System.Drawing.Point(42, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 26);
            this.label4.TabIndex = 12;
            this.label4.Text = "Item Number:";
            // 
            // itemNumbertextBox
            // 
            this.itemNumbertextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.itemNumbertextBox.Location = new System.Drawing.Point(200, 92);
            this.itemNumbertextBox.Name = "itemNumbertextBox";
            this.itemNumbertextBox.Size = new System.Drawing.Size(266, 32);
            this.itemNumbertextBox.TabIndex = 11;
            // 
            // ItemDescOneTextBox
            // 
            this.ItemDescOneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.ItemDescOneTextBox.Location = new System.Drawing.Point(200, 144);
            this.ItemDescOneTextBox.MaxLength = 15;
            this.ItemDescOneTextBox.Name = "ItemDescOneTextBox";
            this.ItemDescOneTextBox.Size = new System.Drawing.Size(266, 32);
            this.ItemDescOneTextBox.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label5.Location = new System.Drawing.Point(12, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 26);
            this.label5.TabIndex = 14;
            this.label5.Text = "Item Desc line 2:";
            // 
            // ItemDescTwoTextBox
            // 
            this.ItemDescTwoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.ItemDescTwoTextBox.Location = new System.Drawing.Point(200, 183);
            this.ItemDescTwoTextBox.MaxLength = 15;
            this.ItemDescTwoTextBox.Name = "ItemDescTwoTextBox";
            this.ItemDescTwoTextBox.Size = new System.Drawing.Size(266, 32);
            this.ItemDescTwoTextBox.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label6.Location = new System.Drawing.Point(12, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 26);
            this.label6.TabIndex = 15;
            this.label6.Text = "Item Desc line 3:";
            // 
            // ItemDescThreeTextBox
            // 
            this.ItemDescThreeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.ItemDescThreeTextBox.Location = new System.Drawing.Point(200, 224);
            this.ItemDescThreeTextBox.MaxLength = 15;
            this.ItemDescThreeTextBox.Name = "ItemDescThreeTextBox";
            this.ItemDescThreeTextBox.Size = new System.Drawing.Size(266, 32);
            this.ItemDescThreeTextBox.TabIndex = 16;
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.clearButton.Location = new System.Drawing.Point(488, 382);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(197, 50);
            this.clearButton.TabIndex = 17;
            this.clearButton.Text = "Clear Lables";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // EachcheckBox
            // 
            this.EachcheckBox.AutoSize = true;
            this.EachcheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.EachcheckBox.Location = new System.Drawing.Point(385, 277);
            this.EachcheckBox.Name = "EachcheckBox";
            this.EachcheckBox.Size = new System.Drawing.Size(81, 30);
            this.EachcheckBox.TabIndex = 18;
            this.EachcheckBox.Text = "Each";
            this.EachcheckBox.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 476);
            this.Controls.Add(this.EachcheckBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.ItemDescThreeTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ItemDescTwoTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.itemNumbertextBox);
            this.Controls.Add(this.SettingsButtons);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.ItemDataView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.itemAmountTextBox);
            this.Controls.Add(this.ItemDescOneTextBox);
            this.Controls.Add(this.boothTextBox);
            this.Controls.Add(this.addItemButton);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ItemDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.TextBox boothTextBox;
        private System.Windows.Forms.TextBox itemAmountTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView ItemDataView;
        private System.Windows.Forms.Button printButton;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button SettingsButtons;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox itemNumbertextBox;
        private System.Windows.Forms.TextBox ItemDescOneTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ItemDescTwoTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ItemDescThreeTextBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.CheckBox EachcheckBox;
    }
}

