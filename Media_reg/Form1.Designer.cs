namespace Media_reg
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Add_B = new System.Windows.Forms.Button();
            this.Length_Input_B = new System.Windows.Forms.NumericUpDown();
            this.Author_Input_B = new System.Windows.Forms.TextBox();
            this.Titel_Input_B = new System.Windows.Forms.TextBox();
            this.Length_B = new System.Windows.Forms.Label();
            this.Author_B = new System.Windows.Forms.Label();
            this.Title_B = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Add_F = new System.Windows.Forms.Button();
            this.Length_Input_F = new System.Windows.Forms.NumericUpDown();
            this.Director_Input_F = new System.Windows.Forms.TextBox();
            this.Titel_Input_F = new System.Windows.Forms.TextBox();
            this.Length_F = new System.Windows.Forms.Label();
            this.Director_F = new System.Windows.Forms.Label();
            this.Titel_F = new System.Windows.Forms.Label();
            this.Show_Media = new System.Windows.Forms.ListBox();
            this.Button_Container = new System.Windows.Forms.GroupBox();
            this.Button_F = new System.Windows.Forms.RadioButton();
            this.Button_B = new System.Windows.Forms.RadioButton();
            this.Button_A = new System.Windows.Forms.RadioButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Length_Input_B)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Length_Input_F)).BeginInit();
            this.Button_Container.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(227, 262);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Add_B);
            this.tabPage1.Controls.Add(this.Length_Input_B);
            this.tabPage1.Controls.Add(this.Author_Input_B);
            this.tabPage1.Controls.Add(this.Titel_Input_B);
            this.tabPage1.Controls.Add(this.Length_B);
            this.tabPage1.Controls.Add(this.Author_B);
            this.tabPage1.Controls.Add(this.Title_B);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(219, 236);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lägg till bok";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Add_B
            // 
            this.Add_B.Location = new System.Drawing.Point(85, 185);
            this.Add_B.Name = "Add_B";
            this.Add_B.Size = new System.Drawing.Size(73, 23);
            this.Add_B.TabIndex = 6;
            this.Add_B.Text = "Lägg till bok";
            this.Add_B.UseVisualStyleBackColor = true;
            this.Add_B.Click += new System.EventHandler(this.Add_B_Click);
            // 
            // Length_Input_B
            // 
            this.Length_Input_B.Location = new System.Drawing.Point(71, 93);
            this.Length_Input_B.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Length_Input_B.Name = "Length_Input_B";
            this.Length_Input_B.Size = new System.Drawing.Size(88, 20);
            this.Length_Input_B.TabIndex = 5;
            // 
            // Author_Input_B
            // 
            this.Author_Input_B.Location = new System.Drawing.Point(71, 68);
            this.Author_Input_B.Name = "Author_Input_B";
            this.Author_Input_B.Size = new System.Drawing.Size(88, 20);
            this.Author_Input_B.TabIndex = 4;
            this.Author_Input_B.TextChanged += new System.EventHandler(this.Author_Input_B_TextChanged);
            // 
            // Titel_Input_B
            // 
            this.Titel_Input_B.Location = new System.Drawing.Point(71, 43);
            this.Titel_Input_B.Name = "Titel_Input_B";
            this.Titel_Input_B.Size = new System.Drawing.Size(88, 20);
            this.Titel_Input_B.TabIndex = 3;
            this.Titel_Input_B.TextChanged += new System.EventHandler(this.Titel_Input_B_TextChanged);
            // 
            // Length_B
            // 
            this.Length_B.AutoSize = true;
            this.Length_B.Location = new System.Drawing.Point(6, 100);
            this.Length_B.Name = "Length_B";
            this.Length_B.Size = new System.Drawing.Size(59, 13);
            this.Length_B.TabIndex = 2;
            this.Length_B.Text = "Antal sidor:";
            // 
            // Author_B
            // 
            this.Author_B.AutoSize = true;
            this.Author_B.Location = new System.Drawing.Point(6, 75);
            this.Author_B.Name = "Author_B";
            this.Author_B.Size = new System.Drawing.Size(55, 13);
            this.Author_B.TabIndex = 1;
            this.Author_B.Text = "Författare:";
            // 
            // Title_B
            // 
            this.Title_B.AutoSize = true;
            this.Title_B.Location = new System.Drawing.Point(6, 50);
            this.Title_B.Name = "Title_B";
            this.Title_B.Size = new System.Drawing.Size(30, 13);
            this.Title_B.TabIndex = 0;
            this.Title_B.Text = "Titel:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Add_F);
            this.tabPage2.Controls.Add(this.Length_Input_F);
            this.tabPage2.Controls.Add(this.Director_Input_F);
            this.tabPage2.Controls.Add(this.Titel_Input_F);
            this.tabPage2.Controls.Add(this.Length_F);
            this.tabPage2.Controls.Add(this.Director_F);
            this.tabPage2.Controls.Add(this.Titel_F);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(219, 236);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lägg till film";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Add_F
            // 
            this.Add_F.Location = new System.Drawing.Point(85, 185);
            this.Add_F.Name = "Add_F";
            this.Add_F.Size = new System.Drawing.Size(73, 23);
            this.Add_F.TabIndex = 7;
            this.Add_F.Text = "Lägg till film";
            this.Add_F.UseVisualStyleBackColor = true;
            this.Add_F.Click += new System.EventHandler(this.Add_F_Click);
            // 
            // Length_Input_F
            // 
            this.Length_Input_F.Location = new System.Drawing.Point(71, 93);
            this.Length_Input_F.Name = "Length_Input_F";
            this.Length_Input_F.Size = new System.Drawing.Size(88, 20);
            this.Length_Input_F.TabIndex = 6;
            // 
            // Director_Input_F
            // 
            this.Director_Input_F.Location = new System.Drawing.Point(71, 68);
            this.Director_Input_F.Name = "Director_Input_F";
            this.Director_Input_F.Size = new System.Drawing.Size(88, 20);
            this.Director_Input_F.TabIndex = 5;
            // 
            // Titel_Input_F
            // 
            this.Titel_Input_F.Location = new System.Drawing.Point(71, 43);
            this.Titel_Input_F.Name = "Titel_Input_F";
            this.Titel_Input_F.Size = new System.Drawing.Size(88, 20);
            this.Titel_Input_F.TabIndex = 4;
            // 
            // Length_F
            // 
            this.Length_F.AutoSize = true;
            this.Length_F.Location = new System.Drawing.Point(6, 100);
            this.Length_F.Name = "Length_F";
            this.Length_F.Size = new System.Drawing.Size(57, 13);
            this.Length_F.TabIndex = 3;
            this.Length_F.Text = "Spellängd:";
            // 
            // Director_F
            // 
            this.Director_F.AutoSize = true;
            this.Director_F.Location = new System.Drawing.Point(6, 75);
            this.Director_F.Name = "Director_F";
            this.Director_F.Size = new System.Drawing.Size(51, 13);
            this.Director_F.TabIndex = 2;
            this.Director_F.Text = "Regissör:";
            // 
            // Titel_F
            // 
            this.Titel_F.AutoSize = true;
            this.Titel_F.Location = new System.Drawing.Point(6, 50);
            this.Titel_F.Name = "Titel_F";
            this.Titel_F.Size = new System.Drawing.Size(30, 13);
            this.Titel_F.TabIndex = 1;
            this.Titel_F.Text = "Titel:";
            // 
            // Show_Media
            // 
            this.Show_Media.FormattingEnabled = true;
            this.Show_Media.HorizontalScrollbar = true;
            this.Show_Media.Location = new System.Drawing.Point(246, 34);
            this.Show_Media.Name = "Show_Media";
            this.Show_Media.Size = new System.Drawing.Size(182, 238);
            this.Show_Media.TabIndex = 0;
            this.Show_Media.SelectedIndexChanged += new System.EventHandler(this.Media_SelectedIndexChanged);
            // 
            // Button_Container
            // 
            this.Button_Container.Controls.Add(this.Button_F);
            this.Button_Container.Controls.Add(this.Button_B);
            this.Button_Container.Controls.Add(this.Button_A);
            this.Button_Container.Location = new System.Drawing.Point(246, 278);
            this.Button_Container.Name = "Button_Container";
            this.Button_Container.Size = new System.Drawing.Size(182, 52);
            this.Button_Container.TabIndex = 1;
            this.Button_Container.TabStop = false;
            this.Button_Container.Text = "Visa";
            this.Button_Container.Enter += new System.EventHandler(this.Button_Container_Enter);
            // 
            // Button_F
            // 
            this.Button_F.AutoSize = true;
            this.Button_F.Location = new System.Drawing.Point(122, 19);
            this.Button_F.Name = "Button_F";
            this.Button_F.Size = new System.Drawing.Size(52, 17);
            this.Button_F.TabIndex = 2;
            this.Button_F.Text = "Filmer";
            this.Button_F.UseVisualStyleBackColor = true;
            this.Button_F.CheckedChanged += new System.EventHandler(this.Button_F_CheckedChanged);
            // 
            // Button_B
            // 
            this.Button_B.AutoSize = true;
            this.Button_B.Location = new System.Drawing.Point(54, 19);
            this.Button_B.Name = "Button_B";
            this.Button_B.Size = new System.Drawing.Size(59, 17);
            this.Button_B.TabIndex = 1;
            this.Button_B.Text = "Böcker";
            this.Button_B.UseVisualStyleBackColor = true;
            this.Button_B.CheckedChanged += new System.EventHandler(this.Button_B_CheckedChanged);
            // 
            // Button_A
            // 
            this.Button_A.AutoSize = true;
            this.Button_A.Checked = true;
            this.Button_A.Location = new System.Drawing.Point(6, 19);
            this.Button_A.Name = "Button_A";
            this.Button_A.Size = new System.Drawing.Size(42, 17);
            this.Button_A.TabIndex = 0;
            this.Button_A.TabStop = true;
            this.Button_A.Text = "Alla";
            this.Button_A.UseVisualStyleBackColor = true;
            this.Button_A.CheckedChanged += new System.EventHandler(this.Button_A_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 342);
            this.Controls.Add(this.Button_Container);
            this.Controls.Add(this.Show_Media);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Length_Input_B)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Length_Input_F)).EndInit();
            this.Button_Container.ResumeLayout(false);
            this.Button_Container.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button Add_B;
        private System.Windows.Forms.NumericUpDown Length_Input_B;
        private System.Windows.Forms.TextBox Author_Input_B;
        private System.Windows.Forms.TextBox Titel_Input_B;
        private System.Windows.Forms.Label Length_B;
        private System.Windows.Forms.Label Author_B;
        private System.Windows.Forms.Label Title_B;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button Add_F;
        private System.Windows.Forms.NumericUpDown Length_Input_F;
        private System.Windows.Forms.TextBox Director_Input_F;
        private System.Windows.Forms.TextBox Titel_Input_F;
        private System.Windows.Forms.Label Length_F;
        private System.Windows.Forms.Label Director_F;
        private System.Windows.Forms.Label Titel_F;
        private System.Windows.Forms.ListBox Show_Media;
        private System.Windows.Forms.GroupBox Button_Container;
        private System.Windows.Forms.RadioButton Button_F;
        private System.Windows.Forms.RadioButton Button_B;
        private System.Windows.Forms.RadioButton Button_A;
    }
}

