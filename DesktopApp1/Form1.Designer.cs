namespace DesktopApp1
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.reccomended1 = new DesktopApp1.Reccomended();
            this.new1 = new DesktopApp1.New();
            this.ingrediendts1 = new DesktopApp1.Ingrediendts();
            this.favourites1 = new DesktopApp1.favourites();
            this.metroToggle1 = new MetroFramework.Controls.MetroToggle();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.button4);
            this.metroPanel1.Controls.Add(this.button3);
            this.metroPanel1.Controls.Add(this.button2);
            this.metroPanel1.Controls.Add(this.button1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(12, 237);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(190, 338);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(4, 255);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(183, 78);
            this.button4.TabIndex = 5;
            this.button4.Text = "Ingredients";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(4, 171);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(183, 78);
            this.button3.TabIndex = 4;
            this.button3.Text = "New";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(4, 87);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 78);
            this.button2.TabIndex = 3;
            this.button2.Text = "Reccomended";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 78);
            this.button1.TabIndex = 2;
            this.button1.Text = "Favourites";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // reccomended1
            // 
            this.reccomended1.Location = new System.Drawing.Point(220, 12);
            this.reccomended1.Name = "reccomended1";
            this.reccomended1.Size = new System.Drawing.Size(685, 563);
            this.reccomended1.TabIndex = 16;
            // 
            // new1
            // 
            this.new1.Location = new System.Drawing.Point(220, 1);
            this.new1.Name = "new1";
            this.new1.Size = new System.Drawing.Size(685, 583);
            this.new1.TabIndex = 15;
            // 
            // ingrediendts1
            // 
            this.ingrediendts1.Location = new System.Drawing.Point(205, 12);
            this.ingrediendts1.Name = "ingrediendts1";
            this.ingrediendts1.Size = new System.Drawing.Size(685, 583);
            this.ingrediendts1.TabIndex = 14;
            this.ingrediendts1.Load += new System.EventHandler(this.reccomended1_Load);
            // 
            // favourites1
            // 
            this.favourites1.Location = new System.Drawing.Point(208, 12);
            this.favourites1.Name = "favourites1";
            this.favourites1.Size = new System.Drawing.Size(685, 563);
            this.favourites1.TabIndex = 13;
            this.favourites1.Load += new System.EventHandler(this.favourites1_Load);
            // 
            // metroToggle1
            // 
            this.metroToggle1.AutoSize = true;
            this.metroToggle1.Location = new System.Drawing.Point(36, 92);
            this.metroToggle1.Name = "metroToggle1";
            this.metroToggle1.Size = new System.Drawing.Size(80, 17);
            this.metroToggle1.TabIndex = 11;
            this.metroToggle1.Text = "Off";
            this.metroToggle1.UseVisualStyleBackColor = true;
            this.metroToggle1.CheckedChanged += new System.EventHandler(this.metroToggle1_CheckedChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(16, 124);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(100, 96);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "plz hide me im scared";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(902, 587);
            this.Controls.Add(this.reccomended1);
            this.Controls.Add(this.new1);
            this.Controls.Add(this.ingrediendts1);
            this.Controls.Add(this.favourites1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.metroToggle1);
            this.Controls.Add(this.metroPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private favourites favourites1;
        private Ingrediendts ingrediendts1;
        private New new1;
        private Reccomended reccomended1;
        private MetroFramework.Controls.MetroToggle metroToggle1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}
