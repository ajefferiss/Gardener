namespace Gardener
{
    partial class AddPlant
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddPlant = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSpecies = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSowStart = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSowEnd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plants Name:";
            // 
            // btnAddPlant
            // 
            this.btnAddPlant.Location = new System.Drawing.Point(227, 193);
            this.btnAddPlant.Name = "btnAddPlant";
            this.btnAddPlant.Size = new System.Drawing.Size(75, 23);
            this.btnAddPlant.TabIndex = 6;
            this.btnAddPlant.Text = "Add Plant";
            this.btnAddPlant.UseVisualStyleBackColor = true;
            this.btnAddPlant.Click += new System.EventHandler(this.btnAddPlant_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(308, 193);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(75, 23);
            this.btnCancle.TabIndex = 7;
            this.btnCancle.Text = "Cancle";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(113, 12);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(270, 20);
            this.tbName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Plants Species:";
            // 
            // tbSpecies
            // 
            this.tbSpecies.Location = new System.Drawing.Point(113, 38);
            this.tbSpecies.Name = "tbSpecies";
            this.tbSpecies.Size = new System.Drawing.Size(270, 20);
            this.tbSpecies.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Plants Description:";
            // 
            // tbDescription
            // 
            this.tbDescription.AutoWordSelection = true;
            this.tbDescription.Location = new System.Drawing.Point(113, 64);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(270, 96);
            this.tbDescription.TabIndex = 3;
            this.tbDescription.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sowing time:";
            // 
            // tbSowStart
            // 
            this.tbSowStart.Location = new System.Drawing.Point(113, 166);
            this.tbSowStart.MaxLength = 9;
            this.tbSowStart.Name = "tbSowStart";
            this.tbSowStart.Size = new System.Drawing.Size(58, 20);
            this.tbSowStart.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(177, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "to";
            // 
            // tbSowEnd
            // 
            this.tbSowEnd.Location = new System.Drawing.Point(199, 166);
            this.tbSowEnd.MaxLength = 9;
            this.tbSowEnd.Name = "tbSowEnd";
            this.tbSowEnd.Size = new System.Drawing.Size(58, 20);
            this.tbSowEnd.TabIndex = 5;
            // 
            // AddPlant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 228);
            this.Controls.Add(this.tbSowEnd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbSowStart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbSpecies);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnAddPlant);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddPlant";
            this.Text = "AddPlant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddPlant;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSpecies;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox tbDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSowStart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSowEnd;
    }
}