namespace Group7_Project_Combination_
{
    
    // Partial class for Form1, which defines the main form of the application.
    // This class includes initialization of form components and event handlers.


    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code


        // Method to initialize all components of the form, including labels, text boxes,
        // buttons, and their respective properties such as size, font, and event handlers.
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(131, 9);
            label1.Name = "label1";
            label1.Size = new Size(479, 45);
            label1.TabIndex = 0;
            label1.Text = "Group7_Project (Combination)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 90);
            label2.Name = "label2";
            label2.Size = new Size(187, 25);
            label2.TabIndex = 1;
            label2.Text = "Input Values (e.g., C(8,3))";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(243, 92);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(287, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += TextBox1;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(306, 146);
            button1.Name = "button1";
            button1.Size = new Size(154, 36);
            button1.TabIndex = 3;
            button1.Text = "Solve";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Solve;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(347, 236);
            label3.Name = "label3";
            label3.Size = new Size(62, 25);
            label3.TabIndex = 4;
            label3.Text = "Result";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button button1;
        private Label label3;
    }
}
