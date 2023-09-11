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
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // binaryconvertbutton
            // 
            binaryconvertbutton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            binaryconvertbutton.Location = new Point(12, 289);
            binaryconvertbutton.Name = "binaryconvertbutton";
            binaryconvertbutton.Size = new Size(271, 50);
            binaryconvertbutton.TabIndex = 1;
            binaryconvertbutton.Text = "Binary Convert";
            binaryconvertbutton.UseVisualStyleBackColor = true;
            binaryconvertbutton.Click += binaryconvertbutton_Click;
            // 
            // binarybox
            // 
            binarybox.AccessibleDescription = "only binary";
            binarybox.Location = new Point(12, 91);
            binarybox.Multiline = true;
            binarybox.Name = "binarybox";
            binarybox.Size = new Size(271, 138);
            binarybox.TabIndex = 2;
            binarybox.TextChanged += binarybox_TextChanged;
            // 
            // textbox
            // 
            textbox.Location = new Point(517, 91);
            textbox.Multiline = true;
            textbox.Name = "textbox";
            textbox.Size = new Size(271, 138);
            textbox.TabIndex = 3;
            textbox.TextChanged += textbox_TextChanged;
            // 
            // Textt
            // 
            Textt.AutoSize = true;
            Textt.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            Textt.Location = new Point(615, 25);
            Textt.Name = "Textt";
            Textt.Size = new Size(66, 35);
            Textt.TabIndex = 4;
            Textt.Text = "Text";
            // 
            // Binary
            // 
            Binary.AutoSize = true;
            Binary.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            Binary.Location = new Point(88, 25);
            Binary.Name = "Binary";
            Binary.Size = new Size(90, 35);
            Binary.TabIndex = 5;
            Binary.Text = "Binary";
            // 
            // textconvertbutton
            // 
            textconvertbutton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textconvertbutton.Location = new Point(517, 289);
            textconvertbutton.Name = "textconvertbutton";
            textconvertbutton.Size = new Size(271, 50);
            textconvertbutton.TabIndex = 1;
            textconvertbutton.Text = "Text Convert";
            textconvertbutton.UseVisualStyleBackColor = true;
            textconvertbutton.Click += textconvertbutton_Click;
            // 
            // Clearbutton
            // 
            Clearbutton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Clearbutton.Location = new Point(309, 189);
            Clearbutton.Name = "Clearbutton";
            Clearbutton.Size = new Size(185, 40);
            Clearbutton.TabIndex = 1;
            Clearbutton.Text = "Clear";
            Clearbutton.UseVisualStyleBackColor = true;
            Clearbutton.Click += Clearbutton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(71, 232);
            label1.Name = "label1";
            label1.Size = new Size(144, 23);
            label1.TabIndex = 6;
            label1.Text = "Only Binary here";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(595, 232);
            label2.Name = "label2";
            label2.Size = new Size(125, 23);
            label2.TabIndex = 6;
            label2.Text = "Only Text here";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Binary);
            Controls.Add(Textt);
            Controls.Add(textbox);
            Controls.Add(binarybox);
            Controls.Add(Clearbutton);
            Controls.Add(textconvertbutton);
            Controls.Add(binaryconvertbutton);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Text = "BinaryTextConverter";
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
        private Label label1;
        private Label label2;
    }
}