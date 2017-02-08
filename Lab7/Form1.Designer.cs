namespace Lab7
{
    partial class Form1
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
            this.allTabs = new System.Windows.Forms.TabControl();
            this.oneWay = new System.Windows.Forms.TabPage();
            this.OWBox2 = new System.Windows.Forms.TextBox();
            this.DeleteLastEven = new System.Windows.Forms.Button();
            this.OWFill = new System.Windows.Forms.Button();
            this.OWBox1 = new System.Windows.Forms.TextBox();
            this.twoWay = new System.Windows.Forms.TabPage();
            this.TWNumberLabel = new System.Windows.Forms.Label();
            this.TWBox2 = new System.Windows.Forms.TextBox();
            this.TWAdd = new System.Windows.Forms.Button();
            this.TWNumber = new System.Windows.Forms.MaskedTextBox();
            this.TWFill = new System.Windows.Forms.Button();
            this.TWBox1 = new System.Windows.Forms.TextBox();
            this.binTree = new System.Windows.Forms.TabPage();
            this.allTabs.SuspendLayout();
            this.oneWay.SuspendLayout();
            this.twoWay.SuspendLayout();
            this.SuspendLayout();
            // 
            // allTabs
            // 
            this.allTabs.Controls.Add(this.oneWay);
            this.allTabs.Controls.Add(this.twoWay);
            this.allTabs.Controls.Add(this.binTree);
            this.allTabs.Location = new System.Drawing.Point(0, 0);
            this.allTabs.Margin = new System.Windows.Forms.Padding(0);
            this.allTabs.Name = "allTabs";
            this.allTabs.SelectedIndex = 0;
            this.allTabs.Size = new System.Drawing.Size(817, 492);
            this.allTabs.TabIndex = 0;
            // 
            // oneWay
            // 
            this.oneWay.Controls.Add(this.OWBox2);
            this.oneWay.Controls.Add(this.DeleteLastEven);
            this.oneWay.Controls.Add(this.OWFill);
            this.oneWay.Controls.Add(this.OWBox1);
            this.oneWay.Location = new System.Drawing.Point(4, 25);
            this.oneWay.Margin = new System.Windows.Forms.Padding(0);
            this.oneWay.Name = "oneWay";
            this.oneWay.Size = new System.Drawing.Size(809, 463);
            this.oneWay.TabIndex = 0;
            this.oneWay.Text = "Однонаправленный список";
            this.oneWay.UseVisualStyleBackColor = true;
            // 
            // OWBox2
            // 
            this.OWBox2.Location = new System.Drawing.Point(0, 255);
            this.OWBox2.Margin = new System.Windows.Forms.Padding(0);
            this.OWBox2.Multiline = true;
            this.OWBox2.Name = "OWBox2";
            this.OWBox2.ReadOnly = true;
            this.OWBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.OWBox2.Size = new System.Drawing.Size(809, 208);
            this.OWBox2.TabIndex = 3;
            // 
            // DeleteLastEven
            // 
            this.DeleteLastEven.Enabled = false;
            this.DeleteLastEven.Location = new System.Drawing.Point(160, 210);
            this.DeleteLastEven.Name = "DeleteLastEven";
            this.DeleteLastEven.Size = new System.Drawing.Size(220, 35);
            this.DeleteLastEven.TabIndex = 2;
            this.DeleteLastEven.Text = "Удалить последний чётный";
            this.DeleteLastEven.UseVisualStyleBackColor = true;
            this.DeleteLastEven.Click += new System.EventHandler(this.DeleteLastEven_Click);
            // 
            // OWFill
            // 
            this.OWFill.Location = new System.Drawing.Point(0, 210);
            this.OWFill.Name = "OWFill";
            this.OWFill.Size = new System.Drawing.Size(150, 35);
            this.OWFill.TabIndex = 1;
            this.OWFill.Text = "Cоздать случайно";
            this.OWFill.UseVisualStyleBackColor = true;
            this.OWFill.Click += new System.EventHandler(this.OWFill_Click);
            // 
            // OWBox1
            // 
            this.OWBox1.Location = new System.Drawing.Point(0, 0);
            this.OWBox1.Margin = new System.Windows.Forms.Padding(0);
            this.OWBox1.Multiline = true;
            this.OWBox1.Name = "OWBox1";
            this.OWBox1.ReadOnly = true;
            this.OWBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.OWBox1.Size = new System.Drawing.Size(809, 200);
            this.OWBox1.TabIndex = 0;
            // 
            // twoWay
            // 
            this.twoWay.Controls.Add(this.TWNumberLabel);
            this.twoWay.Controls.Add(this.TWBox2);
            this.twoWay.Controls.Add(this.TWAdd);
            this.twoWay.Controls.Add(this.TWNumber);
            this.twoWay.Controls.Add(this.TWFill);
            this.twoWay.Controls.Add(this.TWBox1);
            this.twoWay.Location = new System.Drawing.Point(4, 25);
            this.twoWay.Margin = new System.Windows.Forms.Padding(0);
            this.twoWay.Name = "twoWay";
            this.twoWay.Size = new System.Drawing.Size(809, 463);
            this.twoWay.TabIndex = 1;
            this.twoWay.Text = "Двунаправленный список";
            this.twoWay.UseVisualStyleBackColor = true;
            // 
            // TWNumberLabel
            // 
            this.TWNumberLabel.AutoSize = true;
            this.TWNumberLabel.Location = new System.Drawing.Point(341, 213);
            this.TWNumberLabel.Name = "TWNumberLabel";
            this.TWNumberLabel.Size = new System.Drawing.Size(131, 32);
            this.TWNumberLabel.TabIndex = 6;
            this.TWNumberLabel.Text = "Добавить элемент\r\n на номер";
            // 
            // TWBox2
            // 
            this.TWBox2.Location = new System.Drawing.Point(0, 255);
            this.TWBox2.Margin = new System.Windows.Forms.Padding(0);
            this.TWBox2.Multiline = true;
            this.TWBox2.Name = "TWBox2";
            this.TWBox2.ReadOnly = true;
            this.TWBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TWBox2.Size = new System.Drawing.Size(809, 208);
            this.TWBox2.TabIndex = 5;
            // 
            // TWAdd
            // 
            this.TWAdd.Location = new System.Drawing.Point(594, 210);
            this.TWAdd.Name = "TWAdd";
            this.TWAdd.Size = new System.Drawing.Size(215, 35);
            this.TWAdd.TabIndex = 4;
            this.TWAdd.Text = "Добавить элемент на место";
            this.TWAdd.UseVisualStyleBackColor = true;
            this.TWAdd.Click += new System.EventHandler(this.TWAdd_Click);
            // 
            // TWNumber
            // 
            this.TWNumber.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TWNumber.Location = new System.Drawing.Point(475, 210);
            this.TWNumber.Margin = new System.Windows.Forms.Padding(0);
            this.TWNumber.Mask = "00000";
            this.TWNumber.Name = "TWNumber";
            this.TWNumber.Size = new System.Drawing.Size(100, 34);
            this.TWNumber.TabIndex = 3;
            this.TWNumber.ValidatingType = typeof(int);
            // 
            // TWFill
            // 
            this.TWFill.Location = new System.Drawing.Point(0, 210);
            this.TWFill.Name = "TWFill";
            this.TWFill.Size = new System.Drawing.Size(150, 35);
            this.TWFill.TabIndex = 2;
            this.TWFill.Text = "Cоздать случайно";
            this.TWFill.UseVisualStyleBackColor = true;
            this.TWFill.Click += new System.EventHandler(this.TWFill_Click);
            // 
            // TWBox1
            // 
            this.TWBox1.Location = new System.Drawing.Point(0, 0);
            this.TWBox1.Margin = new System.Windows.Forms.Padding(0);
            this.TWBox1.Multiline = true;
            this.TWBox1.Name = "TWBox1";
            this.TWBox1.ReadOnly = true;
            this.TWBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TWBox1.Size = new System.Drawing.Size(809, 200);
            this.TWBox1.TabIndex = 1;
            // 
            // binTree
            // 
            this.binTree.Location = new System.Drawing.Point(4, 25);
            this.binTree.Margin = new System.Windows.Forms.Padding(0);
            this.binTree.Name = "binTree";
            this.binTree.Size = new System.Drawing.Size(809, 463);
            this.binTree.TabIndex = 2;
            this.binTree.Text = "Бинарное дерево";
            this.binTree.UseVisualStyleBackColor = true;
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
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = " ";
            this.allTabs.ResumeLayout(false);
            this.oneWay.ResumeLayout(false);
            this.oneWay.PerformLayout();
            this.twoWay.ResumeLayout(false);
            this.twoWay.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TabControl allTabs;
        private System.Windows.Forms.TabPage oneWay;
        private System.Windows.Forms.TabPage twoWay;
        private System.Windows.Forms.TabPage binTree;
        private System.Windows.Forms.TextBox OWBox1;
        private System.Windows.Forms.Button OWFill;
        private System.Windows.Forms.Button DeleteLastEven;
        private System.Windows.Forms.TextBox OWBox2;
        private System.Windows.Forms.TextBox TWBox1;
        private System.Windows.Forms.Button TWFill;
        private System.Windows.Forms.MaskedTextBox TWNumber;
        private System.Windows.Forms.Button TWAdd;
        private System.Windows.Forms.TextBox TWBox2;
        private System.Windows.Forms.Label TWNumberLabel;
    }
}