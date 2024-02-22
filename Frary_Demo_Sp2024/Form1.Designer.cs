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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(231, 44);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 0;
            label1.Text = "Widget &Name";
            // 
            // txtWidgetName
            // 
            txtWidgetName.Location = new Point(326, 41);
            txtWidgetName.Name = "txtWidgetName";
            txtWidgetName.Size = new Size(100, 23);
            txtWidgetName.TabIndex = 1;
            txtWidgetName.Enter += txtWidgetName_Enter;
            txtWidgetName.Leave += txtWidgetName_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(229, 94);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 2;
            label2.Text = "&Widget Price";
            // 
            // txtWidgetPrice
            // 
            txtWidgetPrice.Location = new Point(326, 94);
            txtWidgetPrice.Name = "txtWidgetPrice";
            txtWidgetPrice.Size = new Size(100, 23);
            txtWidgetPrice.TabIndex = 3;
            txtWidgetPrice.Enter += txtWidgetPrice_Enter;
            txtWidgetPrice.Leave += txtWidgetPrice_Leave;
            // 
            // lstOut
            // 
            lstOut.FormattingEnabled = true;
            lstOut.ItemHeight = 15;
            lstOut.Location = new Point(59, 159);
            lstOut.Name = "lstOut";
            lstOut.Size = new Size(548, 154);
            lstOut.TabIndex = 4;
            lstOut.TabStop = false;
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(59, 332);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(75, 48);
            btnCalc.TabIndex = 5;
            btnCalc.Text = "Calculate &Price";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(246, 332);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 48);
            btnClear.TabIndex = 6;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(420, 332);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(75, 48);
            btnQuit.TabIndex = 7;
            btnQuit.Text = "&Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(676, 411);
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
    }
}
