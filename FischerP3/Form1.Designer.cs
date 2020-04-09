namespace FischerP3
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
            this.lblOrderNumber = new System.Windows.Forms.Label();
            this.lblNumItems = new System.Windows.Forms.Label();
            this.tbNumItems = new System.Windows.Forms.TextBox();
            this.tbOrderNumber = new System.Windows.Forms.TextBox();
            this.gbxItemType = new System.Windows.Forms.GroupBox();
            this.rbMug = new System.Windows.Forms.RadioButton();
            this.rbPen = new System.Windows.Forms.RadioButton();
            this.rbUSB = new System.Windows.Forms.RadioButton();
            this.lblTxtToPrint = new System.Windows.Forms.Label();
            this.tbTextToPrint = new System.Windows.Forms.TextBox();
            this.ckbxLogo = new System.Windows.Forms.CheckBox();
            this.lblNumColors = new System.Windows.Forms.Label();
            this.tbNumColors = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.tbOrderSummary = new System.Windows.Forms.TextBox();
            this.gbxItemType.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOrderNumber
            // 
            this.lblOrderNumber.AutoSize = true;
            this.lblOrderNumber.Location = new System.Drawing.Point(32, 37);
            this.lblOrderNumber.Name = "lblOrderNumber";
            this.lblOrderNumber.Size = new System.Drawing.Size(73, 13);
            this.lblOrderNumber.TabIndex = 0;
            this.lblOrderNumber.Text = "Order Number";
            // 
            // lblNumItems
            // 
            this.lblNumItems.AutoSize = true;
            this.lblNumItems.Location = new System.Drawing.Point(32, 88);
            this.lblNumItems.Name = "lblNumItems";
            this.lblNumItems.Size = new System.Drawing.Size(84, 13);
            this.lblNumItems.TabIndex = 1;
            this.lblNumItems.Text = "Number of Items";
            // 
            // tbNumItems
            // 
            this.tbNumItems.Location = new System.Drawing.Point(133, 81);
            this.tbNumItems.Name = "tbNumItems";
            this.tbNumItems.Size = new System.Drawing.Size(126, 20);
            this.tbNumItems.TabIndex = 2;
            // 
            // tbOrderNumber
            // 
            this.tbOrderNumber.Location = new System.Drawing.Point(133, 34);
            this.tbOrderNumber.Name = "tbOrderNumber";
            this.tbOrderNumber.Size = new System.Drawing.Size(126, 20);
            this.tbOrderNumber.TabIndex = 3;
            this.tbOrderNumber.Text = "1";
            // 
            // gbxItemType
            // 
            this.gbxItemType.Controls.Add(this.rbUSB);
            this.gbxItemType.Controls.Add(this.rbPen);
            this.gbxItemType.Controls.Add(this.rbMug);
            this.gbxItemType.Location = new System.Drawing.Point(35, 129);
            this.gbxItemType.Name = "gbxItemType";
            this.gbxItemType.Size = new System.Drawing.Size(224, 100);
            this.gbxItemType.TabIndex = 4;
            this.gbxItemType.TabStop = false;
            this.gbxItemType.Text = "Item Type";
            // 
            // rbMug
            // 
            this.rbMug.AutoSize = true;
            this.rbMug.Location = new System.Drawing.Point(98, 38);
            this.rbMug.Name = "rbMug";
            this.rbMug.Size = new System.Drawing.Size(46, 17);
            this.rbMug.TabIndex = 0;
            this.rbMug.TabStop = true;
            this.rbMug.Text = "Mug";
            this.rbMug.UseVisualStyleBackColor = true;
            // 
            // rbPen
            // 
            this.rbPen.AutoSize = true;
            this.rbPen.Location = new System.Drawing.Point(98, 61);
            this.rbPen.Name = "rbPen";
            this.rbPen.Size = new System.Drawing.Size(44, 17);
            this.rbPen.TabIndex = 1;
            this.rbPen.TabStop = true;
            this.rbPen.Text = "Pen";
            this.rbPen.UseVisualStyleBackColor = true;
            // 
            // rbUSB
            // 
            this.rbUSB.AutoSize = true;
            this.rbUSB.Location = new System.Drawing.Point(98, 15);
            this.rbUSB.Name = "rbUSB";
            this.rbUSB.Size = new System.Drawing.Size(50, 17);
            this.rbUSB.TabIndex = 2;
            this.rbUSB.TabStop = true;
            this.rbUSB.Text = "USB ";
            this.rbUSB.UseVisualStyleBackColor = true;
            // 
            // lblTxtToPrint
            // 
            this.lblTxtToPrint.AutoSize = true;
            this.lblTxtToPrint.Location = new System.Drawing.Point(32, 242);
            this.lblTxtToPrint.Name = "lblTxtToPrint";
            this.lblTxtToPrint.Size = new System.Drawing.Size(66, 13);
            this.lblTxtToPrint.TabIndex = 5;
            this.lblTxtToPrint.Text = "Text to print:";
            // 
            // tbTextToPrint
            // 
            this.tbTextToPrint.Location = new System.Drawing.Point(35, 258);
            this.tbTextToPrint.Multiline = true;
            this.tbTextToPrint.Name = "tbTextToPrint";
            this.tbTextToPrint.Size = new System.Drawing.Size(224, 48);
            this.tbTextToPrint.TabIndex = 6;
            // 
            // ckbxLogo
            // 
            this.ckbxLogo.AutoSize = true;
            this.ckbxLogo.Location = new System.Drawing.Point(103, 321);
            this.ckbxLogo.Name = "ckbxLogo";
            this.ckbxLogo.Size = new System.Drawing.Size(56, 17);
            this.ckbxLogo.TabIndex = 7;
            this.ckbxLogo.Text = "Logo?";
            this.ckbxLogo.UseVisualStyleBackColor = true;
            this.ckbxLogo.CheckedChanged += new System.EventHandler(this.ckbxLogo_CheckedChanged_1);
            // 
            // lblNumColors
            // 
            this.lblNumColors.AutoSize = true;
            this.lblNumColors.Location = new System.Drawing.Point(32, 347);
            this.lblNumColors.Name = "lblNumColors";
            this.lblNumColors.Size = new System.Drawing.Size(88, 13);
            this.lblNumColors.TabIndex = 8;
            this.lblNumColors.Text = "Number of Colors";
            this.lblNumColors.Visible = false;
            // 
            // tbNumColors
            // 
            this.tbNumColors.Location = new System.Drawing.Point(133, 344);
            this.tbNumColors.Name = "tbNumColors";
            this.tbNumColors.Size = new System.Drawing.Size(126, 20);
            this.tbNumColors.TabIndex = 9;
            this.tbNumColors.Text = "0";
            this.tbNumColors.Visible = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(35, 377);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(93, 34);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(162, 377);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(97, 34);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tbOrderSummary
            // 
            this.tbOrderSummary.Location = new System.Drawing.Point(35, 431);
            this.tbOrderSummary.Multiline = true;
            this.tbOrderSummary.Name = "tbOrderSummary";
            this.tbOrderSummary.Size = new System.Drawing.Size(224, 63);
            this.tbOrderSummary.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 519);
            this.Controls.Add(this.tbOrderSummary);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.tbNumColors);
            this.Controls.Add(this.lblNumColors);
            this.Controls.Add(this.ckbxLogo);
            this.Controls.Add(this.tbTextToPrint);
            this.Controls.Add(this.lblTxtToPrint);
            this.Controls.Add(this.gbxItemType);
            this.Controls.Add(this.tbOrderNumber);
            this.Controls.Add(this.tbNumItems);
            this.Controls.Add(this.lblNumItems);
            this.Controls.Add(this.lblOrderNumber);
            this.Name = "Form1";
            this.Text = "Logo Items Ordered";
            this.gbxItemType.ResumeLayout(false);
            this.gbxItemType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOrderNumber;
        private System.Windows.Forms.Label lblNumItems;
        private System.Windows.Forms.TextBox tbNumItems;
        private System.Windows.Forms.TextBox tbOrderNumber;
        private System.Windows.Forms.GroupBox gbxItemType;
        private System.Windows.Forms.RadioButton rbUSB;
        private System.Windows.Forms.RadioButton rbPen;
        private System.Windows.Forms.RadioButton rbMug;
        private System.Windows.Forms.Label lblTxtToPrint;
        private System.Windows.Forms.TextBox tbTextToPrint;
        private System.Windows.Forms.CheckBox ckbxLogo;
        private System.Windows.Forms.Label lblNumColors;
        private System.Windows.Forms.TextBox tbNumColors;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox tbOrderSummary;
    }
}

