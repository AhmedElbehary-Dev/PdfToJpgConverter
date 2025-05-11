namespace PdfToJpgConverter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            convert_btn = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // convert_btn
            // 
            convert_btn.BackColor = Color.FromArgb(192, 255, 192);
            convert_btn.Cursor = Cursors.Hand;
            convert_btn.FlatStyle = FlatStyle.Flat;
            convert_btn.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            convert_btn.Location = new Point(12, 12);
            convert_btn.Name = "convert_btn";
            convert_btn.Size = new Size(469, 53);
            convert_btn.TabIndex = 0;
            convert_btn.Text = "C O N V E R T";
            convert_btn.UseVisualStyleBackColor = false;
            convert_btn.Click += btnConvert_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 128);
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 71);
            button1.Name = "button1";
            button1.Size = new Size(469, 53);
            button1.TabIndex = 1;
            button1.Text = "R e n a m e - I m a g e s";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnRenameImages_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(493, 137);
            Controls.Add(button1);
            Controls.Add(convert_btn);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PDF To JPG";
            ResumeLayout(false);
        }

        #endregion

        private Button convert_btn;
        private Button button1;
    }
}
