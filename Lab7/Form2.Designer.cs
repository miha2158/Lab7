using System.Windows.Forms;

namespace Lab7
{
    partial class Form2
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
            this.label = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Button();
            this.CharSearchBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(12, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(119, 32);
            this.label.TabIndex = 2;
            this.label.Text = "Какой элемент\n желаете найти?";
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(247, 9);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(130, 34);
            this.Search.TabIndex = 0;
            this.Search.Text = "Искать";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // CharSearchBox
            // 
            this.CharSearchBox.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CharSearchBox.Location = new System.Drawing.Point(134, 9);
            this.CharSearchBox.Margin = new System.Windows.Forms.Padding(0);
            this.CharSearchBox.MaxLength = 1;
            this.CharSearchBox.Name = "CharSearchBox";
            this.CharSearchBox.Size = new System.Drawing.Size(110, 34);
            this.CharSearchBox.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(389, 54);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.label);
            this.Controls.Add(this.CharSearchBox);
            this.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button Search;
        public System.Windows.Forms.TextBox CharSearchBox;
    }
}