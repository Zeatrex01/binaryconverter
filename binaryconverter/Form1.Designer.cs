namespace binaryconverter
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
            binaryconvertbutton = new Button();
            binarybox = new TextBox();
            textbox = new TextBox();
            Textt = new Label();
            Binary = new Label();
            textconvertbutton = new Button();
            Clearbutton = new Button();
            SuspendLayout();
            // 
            // binaryconvertbutton
            // 
            binaryconvertbutton.Location = new Point(323, 91);
            binaryconvertbutton.Name = "binaryconvertbutton";
            binaryconvertbutton.Size = new Size(139, 40);
            binaryconvertbutton.TabIndex = 1;
            binaryconvertbutton.Text = "Binary Convert";
            binaryconvertbutton.UseVisualStyleBackColor = true;
            // 
            // binarybox
            // 
            binarybox.Location = new Point(12, 91);
            binarybox.Multiline = true;
            binarybox.Name = "binarybox";
            binarybox.Size = new Size(271, 138);
            binarybox.TabIndex = 2;
            // 
            // textbox
            // 
            textbox.Location = new Point(517, 91);
            textbox.Multiline = true;
            textbox.Name = "textbox";
            textbox.Size = new Size(271, 138);
            textbox.TabIndex = 3;
            // 
            // Textt
            // 
            Textt.AutoSize = true;
            Textt.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Textt.Location = new Point(635, 25);
            Textt.Name = "Textt";
            Textt.Size = new Size(58, 35);
            Textt.TabIndex = 4;
            Textt.Text = "Text";
            // 
            // Binary
            // 
            Binary.AutoSize = true;
            Binary.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Binary.Location = new Point(93, 25);
            Binary.Name = "Binary";
            Binary.Size = new Size(83, 35);
            Binary.TabIndex = 5;
            Binary.Text = "Binary";
            // 
            // textconvertbutton
            // 
            textconvertbutton.Location = new Point(323, 137);
            textconvertbutton.Name = "textconvertbutton";
            textconvertbutton.Size = new Size(139, 40);
            textconvertbutton.TabIndex = 1;
            textconvertbutton.Text = "Text Convert";
            textconvertbutton.UseVisualStyleBackColor = true;
            // 
            // Clearbutton
            // 
            Clearbutton.Location = new Point(323, 183);
            Clearbutton.Name = "Clearbutton";
            Clearbutton.Size = new Size(139, 40);
            Clearbutton.TabIndex = 1;
            Clearbutton.Text = "Clear";
            Clearbutton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Binary);
            Controls.Add(Textt);
            Controls.Add(textbox);
            Controls.Add(binarybox);
            Controls.Add(Clearbutton);
            Controls.Add(textconvertbutton);
            Controls.Add(binaryconvertbutton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button binaryconvertbutton;
        private TextBox binarybox;
        private TextBox textbox;
        private Label Textt;
        private Label Binary;
        private Button textconvertbutton;
        private Button Clearbutton;
    }
}