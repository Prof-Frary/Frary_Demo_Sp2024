namespace Frary_Demo_Sp2024
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtWidgetName = new TextBox();
            label2 = new Label();
            txtWidgetPrice = new TextBox();
            lstOut = new ListBox();
            btnCalc = new Button();
            btnClear = new Button();
            btnQuit = new Button();
            groupBox1 = new GroupBox();
            rdo4Year = new RadioButton();
            rdo2Year = new RadioButton();
            rdoNoWarranty = new RadioButton();
            txtQuantity = new TextBox();
            label3 = new Label();
            button1 = new Button();
            OFD = new OpenFileDialog();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(218, 78);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 0;
            label1.Text = "Widget &Name";
            // 
            // txtWidgetName
            // 
            txtWidgetName.Location = new Point(313, 75);
            txtWidgetName.Name = "txtWidgetName";
            txtWidgetName.Size = new Size(100, 23);
            txtWidgetName.TabIndex = 1;
            txtWidgetName.Enter += txtWidgetName_Enter;
            txtWidgetName.Leave += txtWidgetName_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(216, 104);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 2;
            label2.Text = "&Widget Price";
            // 
            // txtWidgetPrice
            // 
            txtWidgetPrice.Location = new Point(313, 104);
            txtWidgetPrice.Name = "txtWidgetPrice";
            txtWidgetPrice.Size = new Size(100, 23);
            txtWidgetPrice.TabIndex = 3;
            txtWidgetPrice.Enter += txtWidgetPrice_Enter;
            txtWidgetPrice.Leave += txtWidgetPrice_Leave;
            // 
            // lstOut
            // 
            lstOut.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstOut.FormattingEnabled = true;
            lstOut.HorizontalScrollbar = true;
            lstOut.ItemHeight = 25;
            lstOut.Location = new Point(12, 166);
            lstOut.Name = "lstOut";
            lstOut.Size = new Size(652, 179);
            lstOut.TabIndex = 4;
            lstOut.TabStop = false;
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(57, 351);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(75, 48);
            btnCalc.TabIndex = 5;
            btnCalc.Text = "Calculate &Price";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(205, 351);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 48);
            btnClear.TabIndex = 6;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(338, 351);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(75, 48);
            btnQuit.TabIndex = 7;
            btnQuit.Text = "&Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdo4Year);
            groupBox1.Controls.Add(rdo2Year);
            groupBox1.Controls.Add(rdoNoWarranty);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(652, 57);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Warranty Type";
            // 
            // rdo4Year
            // 
            rdo4Year.AutoSize = true;
            rdo4Year.Location = new Point(577, 22);
            rdo4Year.Name = "rdo4Year";
            rdo4Year.Size = new Size(58, 19);
            rdo4Year.TabIndex = 2;
            rdo4Year.TabStop = true;
            rdo4Year.Text = "4-Year";
            rdo4Year.UseVisualStyleBackColor = true;
            rdo4Year.CheckedChanged += rdo4Year_CheckedChanged;
            // 
            // rdo2Year
            // 
            rdo2Year.AutoSize = true;
            rdo2Year.BackColor = SystemColors.Control;
            rdo2Year.Location = new Point(309, 22);
            rdo2Year.Name = "rdo2Year";
            rdo2Year.Size = new Size(58, 19);
            rdo2Year.TabIndex = 1;
            rdo2Year.TabStop = true;
            rdo2Year.Text = "2-Year";
            rdo2Year.UseVisualStyleBackColor = false;
            rdo2Year.CheckedChanged += rdo2Year_CheckedChanged;
            // 
            // rdoNoWarranty
            // 
            rdoNoWarranty.AutoSize = true;
            rdoNoWarranty.Location = new Point(45, 27);
            rdoNoWarranty.Name = "rdoNoWarranty";
            rdoNoWarranty.Size = new Size(54, 19);
            rdoNoWarranty.TabIndex = 0;
            rdoNoWarranty.TabStop = true;
            rdoNoWarranty.Text = "None";
            rdoNoWarranty.UseVisualStyleBackColor = true;
            rdoNoWarranty.CheckedChanged += rdoNoWarranty_CheckedChanged;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(313, 133);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(100, 23);
            txtQuantity.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(216, 133);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 9;
            label3.Text = "Quantity";
            // 
            // button1
            // 
            button1.Location = new Point(487, 351);
            button1.Name = "button1";
            button1.Size = new Size(75, 48);
            button1.TabIndex = 11;
            button1.Text = "Demo Date";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // OFD
            // 
            OFD.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(676, 411);
            Controls.Add(button1);
            Controls.Add(txtQuantity);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Controls.Add(btnQuit);
            Controls.Add(btnClear);
            Controls.Add(btnCalc);
            Controls.Add(lstOut);
            Controls.Add(txtWidgetPrice);
            Controls.Add(label2);
            Controls.Add(txtWidgetName);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Frary Demo SP 24";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtWidgetName;
        private Label label2;
        private TextBox txtWidgetPrice;
        private ListBox lstOut;
        private Button btnCalc;
        private Button btnClear;
        private Button btnQuit;
        private GroupBox groupBox1;
        private RadioButton rdo4Year;
        private RadioButton rdo2Year;
        private RadioButton rdoNoWarranty;
        private TextBox txtQuantity;
        private Label label3;
        private Button button1;
        private OpenFileDialog OFD;
    }
}
