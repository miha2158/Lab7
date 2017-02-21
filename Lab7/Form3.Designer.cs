namespace Lab7
{
    partial class Form3
    {
        private System.ComponentModel.IContainer components = null;
        
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose( );
            }
            base.Dispose(disposing);
        }
        
        private void InitializeComponent ( )
        {
            this.OWBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Accept = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OWBox1
            // 
            this.OWBox1.Location = new System.Drawing.Point(0, 17);
            this.OWBox1.Margin = new System.Windows.Forms.Padding(0);
            this.OWBox1.Multiline = true;
            this.OWBox1.Name = "OWBox1";
            this.OWBox1.Size = new System.Drawing.Size(500, 158);
            this.OWBox1.TabIndex = 0;
            this.OWBox1.TextChanged += new System.EventHandler(this.OWBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите элементы через пробел";
            // 
            // Accept
            // 
            this.Accept.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Accept.Enabled = false;
            this.Accept.Location = new System.Drawing.Point(0, 178);
            this.Accept.Margin = new System.Windows.Forms.Padding(0);
            this.Accept.Name = "Accept";
            this.Accept.Size = new System.Drawing.Size(500, 42);
            this.Accept.TabIndex = 2;
            this.Accept.Text = "ОК";
            this.Accept.UseVisualStyleBackColor = true;
            this.Accept.Click += new System.EventHandler(this.Accept_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(500, 220);
            this.Controls.Add(this.Accept);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OWBox1);
            this.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form3";
            this.ShowIcon = false;
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public System.Windows.Forms.TextBox OWBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Accept;
    }
}