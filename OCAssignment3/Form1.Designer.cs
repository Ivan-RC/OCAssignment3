namespace OCAssignment3
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
            this.btn1_Display = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn1_Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn1_Display
            // 
            this.btn1_Display.Location = new System.Drawing.Point(289, 391);
            this.btn1_Display.Name = "btn1_Display";
            this.btn1_Display.Size = new System.Drawing.Size(75, 31);
            this.btn1_Display.TabIndex = 0;
            this.btn1_Display.Text = "Display";
            this.btn1_Display.UseVisualStyleBackColor = true;
            this.btn1_Display.Click += new System.EventHandler(this.btn1_Display_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Black;
            this.richTextBox1.ForeColor = System.Drawing.Color.Lime;
            this.richTextBox1.Location = new System.Drawing.Point(85, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(558, 373);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn1_Clear
            // 
            this.btn1_Clear.Location = new System.Drawing.Point(370, 391);
            this.btn1_Clear.Name = "btn1_Clear";
            this.btn1_Clear.Size = new System.Drawing.Size(75, 31);
            this.btn1_Clear.TabIndex = 2;
            this.btn1_Clear.Text = "Clear";
            this.btn1_Clear.UseVisualStyleBackColor = true;
            this.btn1_Clear.Click += new System.EventHandler(this.btn1_Clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn1_Clear);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btn1_Display);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn1_Display;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn1_Clear;
    }
}

