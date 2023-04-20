namespace WindowsFormsApp11
{
    partial class Katagol
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.AddListbutton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Totalpricebutton = new System.Windows.Forms.Button();
            this.AddPbutton = new System.Windows.Forms.Button();
            this.EditPbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(296, 303);
            this.listBox1.TabIndex = 0;
            // 
            // AddListbutton
            // 
            this.AddListbutton.Location = new System.Drawing.Point(12, 321);
            this.AddListbutton.Name = "AddListbutton";
            this.AddListbutton.Size = new System.Drawing.Size(198, 23);
            this.AddListbutton.TabIndex = 1;
            this.AddListbutton.Text = "Add to list ";
            this.AddListbutton.UseVisualStyleBackColor = true;
            this.AddListbutton.Click += new System.EventHandler(this.AddListbutton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownHeight = 110;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.Location = new System.Drawing.Point(373, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(335, 21);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(368, 295);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(340, 20);
            this.textBox1.TabIndex = 3;
            // 
            // Totalpricebutton
            // 
            this.Totalpricebutton.Location = new System.Drawing.Point(12, 345);
            this.Totalpricebutton.Name = "Totalpricebutton";
            this.Totalpricebutton.Size = new System.Drawing.Size(198, 23);
            this.Totalpricebutton.TabIndex = 4;
            this.Totalpricebutton.Text = "Total price";
            this.Totalpricebutton.UseVisualStyleBackColor = true;
            this.Totalpricebutton.Click += new System.EventHandler(this.Totalpricebutton_Click);
            // 
            // AddPbutton
            // 
            this.AddPbutton.Location = new System.Drawing.Point(368, 266);
            this.AddPbutton.Name = "AddPbutton";
            this.AddPbutton.Size = new System.Drawing.Size(150, 23);
            this.AddPbutton.TabIndex = 5;
            this.AddPbutton.Text = "Add new product";
            this.AddPbutton.UseVisualStyleBackColor = true;
            this.AddPbutton.Click += new System.EventHandler(this.AddPbutton_Click);
            // 
            // EditPbutton
            // 
            this.EditPbutton.Location = new System.Drawing.Point(558, 266);
            this.EditPbutton.Name = "EditPbutton";
            this.EditPbutton.Size = new System.Drawing.Size(150, 23);
            this.EditPbutton.TabIndex = 6;
            this.EditPbutton.Text = "Edit product";
            this.EditPbutton.UseVisualStyleBackColor = true;
            this.EditPbutton.Click += new System.EventHandler(this.EditPbutton_Click);
            // 
            // Katagol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EditPbutton);
            this.Controls.Add(this.AddPbutton);
            this.Controls.Add(this.Totalpricebutton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.AddListbutton);
            this.Controls.Add(this.listBox1);
            this.Name = "Katagol";
            this.Text = "Katagol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button AddListbutton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Totalpricebutton;
        private System.Windows.Forms.Button AddPbutton;
        private System.Windows.Forms.Button EditPbutton;
    }
}