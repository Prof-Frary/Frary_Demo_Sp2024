namespace Frary_Demo_Sp2024
{
    partial class Form2
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
            label1 = new Label();
            txtNone = new TextBox();
            label2 = new Label();
            txt2Year = new TextBox();
            label3 = new Label();
            txt4Year = new TextBox();
            btnSaveReturn = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 49);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 0;
            label1.Text = "No Warranty Rate";
            // 
            // txtNone
            // 
            txtNone.Location = new Point(226, 49);
            txtNone.Name = "txtNone";
            txtNone.Size = new Size(100, 23);
            txtNone.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 97);
            label2.Name = "label2";
            label2.Size = new Size(130, 15);
            label2.TabIndex = 2;
            label2.Text = "Two Year Warranty Rate";
            // 
            // txt2Year
            // 
            txt2Year.Location = new Point(226, 97);
            txt2Year.Name = "txt2Year";
            txt2Year.Size = new Size(100, 23);
            txt2Year.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 159);
            label3.Name = "label3";
            label3.Size = new Size(133, 15);
            label3.TabIndex = 4;
            label3.Text = "Four Year Warranty Rate";
            // 
            // txt4Year
            // 
            txt4Year.Location = new Point(226, 151);
            txt4Year.Name = "txt4Year";
            txt4Year.Size = new Size(100, 23);
            txt4Year.TabIndex = 5;
            // 
            // btnSaveReturn
            // 
            btnSaveReturn.Location = new Point(105, 226);
            btnSaveReturn.Name = "btnSaveReturn";
            btnSaveReturn.Size = new Size(206, 23);
            btnSaveReturn.TabIndex = 6;
            btnSaveReturn.Text = "&Save Values and Return";
            btnSaveReturn.UseVisualStyleBackColor = true;
            btnSaveReturn.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(332, 52);
            label4.Name = "label4";
            label4.Size = new Size(17, 15);
            label4.TabIndex = 7;
            label4.Text = "%";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(332, 159);
            label5.Name = "label5";
            label5.Size = new Size(17, 15);
            label5.TabIndex = 8;
            label5.Text = "%";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(332, 100);
            label6.Name = "label6";
            label6.Size = new Size(17, 15);
            label6.TabIndex = 9;
            label6.Text = "%";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 283);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnSaveReturn);
            Controls.Add(txt4Year);
            Controls.Add(label3);
            Controls.Add(txt2Year);
            Controls.Add(label2);
            Controls.Add(txtNone);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Widget Program Configuration Settings";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnSaveReturn;
        private Label label4;
        private Label label5;
        private Label label6;
        public TextBox txtNone;
        public TextBox txt2Year;
        public TextBox txt4Year;
    }
}