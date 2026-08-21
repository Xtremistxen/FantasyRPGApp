namespace FatasyRPGApp
{
    partial class AddCharacterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCharacterForm));
            this.btnSaveCharacter = new System.Windows.Forms.Button();
            this.txtCharacterName = new System.Windows.Forms.TextBox();
            this.txtLevel = new System.Windows.Forms.TextBox();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSaveCharacter
            // 
            this.btnSaveCharacter.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveCharacter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveCharacter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSaveCharacter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSaveCharacter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSaveCharacter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveCharacter.Location = new System.Drawing.Point(325, 327);
            this.btnSaveCharacter.Name = "btnSaveCharacter";
            this.btnSaveCharacter.Size = new System.Drawing.Size(132, 23);
            this.btnSaveCharacter.TabIndex = 3;
            this.btnSaveCharacter.UseVisualStyleBackColor = false;
            this.btnSaveCharacter.Click += new System.EventHandler(this.btnSaveCharacter_Click);
            // 
            // txtCharacterName
            // 
            this.txtCharacterName.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtCharacterName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCharacterName.ForeColor = System.Drawing.Color.Gold;
            this.txtCharacterName.Location = new System.Drawing.Point(252, 143);
            this.txtCharacterName.Name = "txtCharacterName";
            this.txtCharacterName.Size = new System.Drawing.Size(153, 20);
            this.txtCharacterName.TabIndex = 4;
            // 
            // txtLevel
            // 
            this.txtLevel.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLevel.ForeColor = System.Drawing.Color.Gold;
            this.txtLevel.Location = new System.Drawing.Point(252, 210);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.Size = new System.Drawing.Size(153, 20);
            this.txtLevel.TabIndex = 5;
            // 
            // cmbClass
            // 
            this.cmbClass.BackColor = System.Drawing.Color.Black;
            this.cmbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClass.ForeColor = System.Drawing.Color.Gold;
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(252, 277);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(153, 21);
            this.cmbClass.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Tan;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(424, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Enter Character Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Tan;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(424, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Enter Character Level";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Tan;
            this.label3.Location = new System.Drawing.Point(424, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Use drop down to select Class";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Tan;
            this.label4.Location = new System.Drawing.Point(424, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Choose from Warrior, Mage, Rogue";
            // 
            // AddCharacterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbClass);
            this.Controls.Add(this.txtLevel);
            this.Controls.Add(this.txtCharacterName);
            this.Controls.Add(this.btnSaveCharacter);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddCharacterForm";
            this.Text = "Add New Character";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSaveCharacter;
        private System.Windows.Forms.TextBox txtCharacterName;
        private System.Windows.Forms.TextBox txtLevel;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}