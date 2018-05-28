namespace Gardener
{
    partial class ListPlants
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
            this.lblTest = new System.Windows.Forms.Label();
            this.lblTest2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(348, 485);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Location = new System.Drawing.Point(474, 105);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(35, 13);
            this.lblTest.TabIndex = 1;
            this.lblTest.Text = "label1";
            // 
            // lblTest2
            // 
            this.lblTest2.AutoSize = true;
            this.lblTest2.Location = new System.Drawing.Point(654, 117);
            this.lblTest2.Name = "lblTest2";
            this.lblTest2.Size = new System.Drawing.Size(35, 13);
            this.lblTest2.TabIndex = 2;
            this.lblTest2.Text = "label1";
            // 
            // ListPlants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 515);
            this.Controls.Add(this.lblTest2);
            this.Controls.Add(this.lblTest);
            this.Controls.Add(this.listBox1);
            this.Name = "ListPlants";
            this.Text = "ListPlants";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.Label lblTest2;
    }
}