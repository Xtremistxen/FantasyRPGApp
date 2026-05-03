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
            this.txtClassId = new System.Windows.Forms.TextBox();
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
            // txtClassId
            // 
            this.txtClassId.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtClassId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClassId.ForeColor = System.Drawing.Color.Gold;
            this.txtClassId.Location = new System.Drawing.Point(252, 279);
            this.txtClassId.Name = "txtClassId";
            this.txtClassId.Size = new System.Drawing.Size(153, 20);
            this.txtClassId.TabIndex = 6;
            // 
            // AddCharacterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtClassId);
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
        private System.Windows.Forms.TextBox txtClassId;
    }
}