using System.Drawing;

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
            this.OWUserFill = new System.Windows.Forms.Button();
            this.OWBox2 = new System.Windows.Forms.TextBox();
            this.DeleteLastEven = new System.Windows.Forms.Button();
            this.OWFill = new System.Windows.Forms.Button();
            this.OWBox1 = new System.Windows.Forms.TextBox();
            this.twoWay = new System.Windows.Forms.TabPage();
            this.TWClear = new System.Windows.Forms.Button();
            this.TWNumberLabel = new System.Windows.Forms.Label();
            this.TWBox2 = new System.Windows.Forms.TextBox();
            this.TWAdd = new System.Windows.Forms.Button();
            this.TWNumber = new System.Windows.Forms.MaskedTextBox();
            this.TWFill = new System.Windows.Forms.Button();
            this.TWBox1 = new System.Windows.Forms.TextBox();
            this.binTree = new System.Windows.Forms.TabPage();
            this.Height = new System.Windows.Forms.Label();
            this.TreeSizeBox = new System.Windows.Forms.MaskedTextBox();
            this.NormalTree = new System.Windows.Forms.Button();
            this.SearchTree = new System.Windows.Forms.Button();
            this.Length = new System.Windows.Forms.Label();
            this.TreeHeight = new System.Windows.Forms.TextBox();
            this.TreeFill = new System.Windows.Forms.Button();
            this.TreeBox1 = new System.Windows.Forms.TextBox();
            this.UserTree = new System.Windows.Forms.Button();
            this.allTabs.SuspendLayout();
            this.oneWay.SuspendLayout();
            this.twoWay.SuspendLayout();
            this.binTree.SuspendLayout();
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
            this.oneWay.Controls.Add(this.OWUserFill);
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
            // OWUserFill
            // 
            this.OWUserFill.Location = new System.Drawing.Point(390, 210);
            this.OWUserFill.Name = "OWUserFill";
            this.OWUserFill.Size = new System.Drawing.Size(150, 35);
            this.OWUserFill.TabIndex = 4;
            this.OWUserFill.Text = "Cоздать вручную";
            this.OWUserFill.UseVisualStyleBackColor = true;
            this.OWUserFill.Click += new System.EventHandler(this.OWUserFill_Click);
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
            this.twoWay.Controls.Add(this.TWClear);
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
            // TWClear
            // 
            this.TWClear.Location = new System.Drawing.Point(156, 210);
            this.TWClear.Margin = new System.Windows.Forms.Padding(0);
            this.TWClear.Name = "TWClear";
            this.TWClear.Size = new System.Drawing.Size(150, 35);
            this.TWClear.TabIndex = 7;
            this.TWClear.Text = "Очистить список";
            this.TWClear.UseVisualStyleBackColor = true;
            this.TWClear.Click += new System.EventHandler(this.TWClear_Click);
            // 
            // TWNumberLabel
            // 
            this.TWNumberLabel.AutoSize = true;
            this.TWNumberLabel.Location = new System.Drawing.Point(416, 210);
            this.TWNumberLabel.Name = "TWNumberLabel";
            this.TWNumberLabel.Size = new System.Drawing.Size(131, 32);
            this.TWNumberLabel.TabIndex = 6;
            this.TWNumberLabel.Text = "Добавить элемент\n на позицию №";
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
            this.TWAdd.Location = new System.Drawing.Point(670, 210);
            this.TWAdd.Name = "TWAdd";
            this.TWAdd.Size = new System.Drawing.Size(140, 35);
            this.TWAdd.TabIndex = 4;
            this.TWAdd.Text = "Добавить элемент";
            this.TWAdd.UseVisualStyleBackColor = true;
            this.TWAdd.Click += new System.EventHandler(this.TWAdd_Click);
            // 
            // TWNumber
            // 
            this.TWNumber.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TWNumber.Location = new System.Drawing.Point(550, 210);
            this.TWNumber.Margin = new System.Windows.Forms.Padding(0);
            this.TWNumber.Mask = "000";
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
            this.binTree.Controls.Add(this.UserTree);
            this.binTree.Controls.Add(this.Height);
            this.binTree.Controls.Add(this.TreeSizeBox);
            this.binTree.Controls.Add(this.NormalTree);
            this.binTree.Controls.Add(this.SearchTree);
            this.binTree.Controls.Add(this.Length);
            this.binTree.Controls.Add(this.TreeHeight);
            this.binTree.Controls.Add(this.TreeFill);
            this.binTree.Controls.Add(this.TreeBox1);
            this.binTree.Location = new System.Drawing.Point(4, 25);
            this.binTree.Margin = new System.Windows.Forms.Padding(0);
            this.binTree.Name = "binTree";
            this.binTree.Size = new System.Drawing.Size(809, 463);
            this.binTree.TabIndex = 2;
            this.binTree.Text = "Бинарное дерево";
            this.binTree.UseVisualStyleBackColor = true;
            // 
            // Height
            // 
            this.Height.AutoSize = true;
            this.Height.Location = new System.Drawing.Point(627, 428);
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(59, 32);
            this.Height.TabIndex = 9;
            this.Height.Text = "Высота\n дерева";
            // 
            // TreeSizeBox
            // 
            this.TreeSizeBox.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TreeSizeBox.Location = new System.Drawing.Point(269, 429);
            this.TreeSizeBox.Margin = new System.Windows.Forms.Padding(0);
            this.TreeSizeBox.Mask = "00";
            this.TreeSizeBox.Name = "TreeSizeBox";
            this.TreeSizeBox.Size = new System.Drawing.Size(127, 34);
            this.TreeSizeBox.TabIndex = 8;
            this.TreeSizeBox.ValidatingType = typeof(int);
            // 
            // NormalTree
            // 
            this.NormalTree.Location = new System.Drawing.Point(139, 390);
            this.NormalTree.Margin = new System.Windows.Forms.Padding(0);
            this.NormalTree.Name = "NormalTree";
            this.NormalTree.Size = new System.Drawing.Size(127, 35);
            this.NormalTree.TabIndex = 7;
            this.NormalTree.Text = "Обычное дерево";
            this.NormalTree.UseVisualStyleBackColor = true;
            this.NormalTree.Visible = false;
            this.NormalTree.Click += new System.EventHandler(this.NormalTree_Click);
            // 
            // SearchTree
            // 
            this.SearchTree.Enabled = false;
            this.SearchTree.Location = new System.Drawing.Point(269, 390);
            this.SearchTree.Name = "SearchTree";
            this.SearchTree.Size = new System.Drawing.Size(127, 35);
            this.SearchTree.TabIndex = 6;
            this.SearchTree.Text = "Поиск";
            this.SearchTree.UseVisualStyleBackColor = true;
            this.SearchTree.Click += new System.EventHandler(this.SearchTree_Click);
            // 
            // Length
            // 
            this.Length.AutoSize = true;
            this.Length.Location = new System.Drawing.Point(169, 429);
            this.Length.Name = "Length";
            this.Length.Size = new System.Drawing.Size(97, 32);
            this.Length.TabIndex = 5;
            this.Length.Text = "Длина нового\n дерева";
            // 
            // TreeHeight
            // 
            this.TreeHeight.Font = new System.Drawing.Font("Arial", 18F);
            this.TreeHeight.Location = new System.Drawing.Point(689, 428);
            this.TreeHeight.Margin = new System.Windows.Forms.Padding(0);
            this.TreeHeight.Multiline = true;
            this.TreeHeight.Name = "TreeHeight";
            this.TreeHeight.ReadOnly = true;
            this.TreeHeight.Size = new System.Drawing.Size(120, 35);
            this.TreeHeight.TabIndex = 4;
            this.TreeHeight.Text = "0";
            this.TreeHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TreeFill
            // 
            this.TreeFill.Location = new System.Drawing.Point(0, 428);
            this.TreeFill.Margin = new System.Windows.Forms.Padding(0);
            this.TreeFill.Name = "TreeFill";
            this.TreeFill.Size = new System.Drawing.Size(136, 35);
            this.TreeFill.TabIndex = 3;
            this.TreeFill.Text = "Cоздать случайно";
            this.TreeFill.UseVisualStyleBackColor = true;
            this.TreeFill.Click += new System.EventHandler(this.TreeFill_Click);
            // 
            // TreeBox1
            // 
            this.TreeBox1.Font = new System.Drawing.Font("Courier New", 12F);
            this.TreeBox1.Location = new System.Drawing.Point(0, 0);
            this.TreeBox1.Margin = new System.Windows.Forms.Padding(0);
            this.TreeBox1.Multiline = true;
            this.TreeBox1.Name = "TreeBox1";
            this.TreeBox1.ReadOnly = true;
            this.TreeBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TreeBox1.Size = new System.Drawing.Size(809, 375);
            this.TreeBox1.TabIndex = 2;
            this.TreeBox1.WordWrap = false;
            // 
            // UserTree
            // 
            this.UserTree.Location = new System.Drawing.Point(0, 390);
            this.UserTree.Name = "UserTree";
            this.UserTree.Size = new System.Drawing.Size(136, 35);
            this.UserTree.TabIndex = 10;
            this.UserTree.Text = "Cоздать вручную";
            this.UserTree.UseVisualStyleBackColor = true;
            this.UserTree.Click += new System.EventHandler(this.UserTree_Click);
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
            this.binTree.ResumeLayout(false);
            this.binTree.PerformLayout();
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
        private System.Windows.Forms.TextBox TreeBox1;
        private System.Windows.Forms.Button TreeFill;
        private System.Windows.Forms.TextBox TreeHeight;
        private System.Windows.Forms.Label Length;
        private System.Windows.Forms.Button SearchTree;
        private System.Windows.Forms.Button NormalTree;
        private System.Windows.Forms.Button OWUserFill;
        private System.Windows.Forms.MaskedTextBox TreeSizeBox;
        private System.Windows.Forms.Label Height;
        private System.Windows.Forms.Button TWClear;
        private System.Windows.Forms.Button UserTree;
    }
}