namespace Lab7
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
        
        private void InitializeComponent()
        {
            this.allTabs = new System.Windows.Forms.TabControl();
            this.oneWay = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.twoWay = new System.Windows.Forms.TabPage();
            this.binTree = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.allTabs.SuspendLayout();
            this.oneWay.SuspendLayout();
            this.SuspendLayout();
            // 
            // allTabs
            // 
            this.allTabs.Controls.Add(this.oneWay);
            this.allTabs.Controls.Add(this.twoWay);
            this.allTabs.Controls.Add(this.binTree);
            this.allTabs.Location = new System.Drawing.Point(0, 0);
            this.allTabs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.allTabs.Name = "allTabs";
            this.allTabs.SelectedIndex = 0;
            this.allTabs.Size = new System.Drawing.Size(817, 492);
            this.allTabs.TabIndex = 0;
            // 
            // oneWay
            // 
            this.oneWay.Controls.Add(this.button1);
            this.oneWay.Controls.Add(this.textBox1);
            this.oneWay.Location = new System.Drawing.Point(4, 25);
            this.oneWay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.oneWay.Name = "oneWay";
            this.oneWay.Size = new System.Drawing.Size(809, 463);
            this.oneWay.TabIndex = 0;
            this.oneWay.Text = "Однонаправленный список";
            this.oneWay.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(809, 130);
            this.textBox1.TabIndex = 0;
            // 
            // twoWay
            // 
            this.twoWay.Location = new System.Drawing.Point(4, 25);
            this.twoWay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.twoWay.Name = "twoWay";
            this.twoWay.Size = new System.Drawing.Size(809, 463);
            this.twoWay.TabIndex = 1;
            this.twoWay.Text = "Двунаправленный список";
            this.twoWay.UseVisualStyleBackColor = true;
            // 
            // binTree
            // 
            this.binTree.Location = new System.Drawing.Point(4, 25);
            this.binTree.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.binTree.Name = "binTree";
            this.binTree.Size = new System.Drawing.Size(809, 463);
            this.binTree.TabIndex = 2;
            this.binTree.Text = "Бинарное дерево";
            this.binTree.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cоздать случайно";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(817, 492);
            this.Controls.Add(this.allTabs);
            this.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = " ";
            this.allTabs.ResumeLayout(false);
            this.oneWay.ResumeLayout(false);
            this.oneWay.PerformLayout();
            this.ResumeLayout(false);

        }
        
        private System.Windows.Forms.TabControl allTabs;
        private System.Windows.Forms.TabPage oneWay;
        private System.Windows.Forms.TabPage twoWay;
        private System.Windows.Forms.TabPage binTree;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}

