namespace Interface
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
            btnSave = new Button();
            label1 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtSound = new TextBox();
            txtColor = new TextBox();
            lblSave = new Label();
            label4 = new Label();
            txtAge = new TextBox();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(393, 101);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(83, 33);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(116, 92);
            label1.Name = "label1";
            label1.Size = new Size(81, 32);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(236, 101);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(116, 141);
            label2.Name = "label2";
            label2.Size = new Size(76, 32);
            label2.TabIndex = 3;
            label2.Text = "Color";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(116, 187);
            label3.Name = "label3";
            label3.Size = new Size(87, 32);
            label3.TabIndex = 4;
            label3.Text = "Sound";
            // 
            // txtSound
            // 
            txtSound.Location = new Point(236, 196);
            txtSound.Name = "txtSound";
            txtSound.Size = new Size(100, 23);
            txtSound.TabIndex = 5;
            // 
            // txtColor
            // 
            txtColor.Location = new Point(236, 150);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(100, 23);
            txtColor.TabIndex = 6;
            // 
            // lblSave
            // 
            lblSave.AutoSize = true;
            lblSave.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSave.Location = new Point(236, 312);
            lblSave.Name = "lblSave";
            lblSave.Size = new Size(0, 32);
            lblSave.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(116, 233);
            label4.Name = "label4";
            label4.Size = new Size(59, 32);
            label4.TabIndex = 8;
            label4.Text = "Age";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(236, 242);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(100, 23);
            txtAge.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtAge);
            Controls.Add(label4);
            Controls.Add(lblSave);
            Controls.Add(txtColor);
            Controls.Add(txtSound);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            Controls.Add(btnSave);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Label label1;
        private TextBox txtName;
        private Label label2;
        private Label label3;
        private TextBox txtSound;
        private TextBox txtColor;
        private Label lblSave;
        private Label label4;
        private TextBox txtAge;
    }
}
