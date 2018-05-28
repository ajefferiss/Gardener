namespace Gardener
{
    partial class Menu
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
            this.btnAddPlant = new System.Windows.Forms.Button();
            this.btnListPlants = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddPlant
            // 
            this.btnAddPlant.Location = new System.Drawing.Point(12, 12);
            this.btnAddPlant.Name = "btnAddPlant";
            this.btnAddPlant.Size = new System.Drawing.Size(117, 23);
            this.btnAddPlant.TabIndex = 0;
            this.btnAddPlant.Text = "Add to database";
            this.btnAddPlant.UseVisualStyleBackColor = true;
            this.btnAddPlant.Click += new System.EventHandler(this.btnAddPlant_Click);
            // 
            // btnListPlants
            // 
            this.btnListPlants.Location = new System.Drawing.Point(12, 41);
            this.btnListPlants.Name = "btnListPlants";
            this.btnListPlants.Size = new System.Drawing.Size(117, 23);
            this.btnListPlants.TabIndex = 1;
            this.btnListPlants.Text = "List Plants";
            this.btnListPlants.UseVisualStyleBackColor = true;
            this.btnListPlants.Click += new System.EventHandler(this.btnListPlants_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(12, 70);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(117, 23);
            this.btnRegister.TabIndex = 2;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnListPlants);
            this.Controls.Add(this.btnAddPlant);
            this.Name = "Menu";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddPlant;
        private System.Windows.Forms.Button btnListPlants;
        private System.Windows.Forms.Button btnRegister;
    }
}

