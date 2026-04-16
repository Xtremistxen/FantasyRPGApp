namespace FatasyRPGApp
{
    partial class MainForm
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
            this.btnViewClasses = new System.Windows.Forms.Button();
            this.btnViewCharacters = new System.Windows.Forms.Button();
            this.btnViewQuests = new System.Windows.Forms.Button();
            this.btnRunQueries = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnViewClasses
            // 
            this.btnViewClasses.Location = new System.Drawing.Point(303, 139);
            this.btnViewClasses.Name = "btnViewClasses";
            this.btnViewClasses.Size = new System.Drawing.Size(97, 23);
            this.btnViewClasses.TabIndex = 0;
            this.btnViewClasses.Text = "View Classes";
            this.btnViewClasses.UseVisualStyleBackColor = true;
            this.btnViewClasses.Click += new System.EventHandler(this.btnViewClasses_Click);
            // 
            // btnViewCharacters
            // 
            this.btnViewCharacters.Location = new System.Drawing.Point(303, 183);
            this.btnViewCharacters.Name = "btnViewCharacters";
            this.btnViewCharacters.Size = new System.Drawing.Size(97, 23);
            this.btnViewCharacters.TabIndex = 1;
            this.btnViewCharacters.Text = "View Characters";
            this.btnViewCharacters.UseVisualStyleBackColor = true;
            this.btnViewCharacters.Click += new System.EventHandler(this.btnViewCharacters_Click);
            // 
            // btnViewQuests
            // 
            this.btnViewQuests.Location = new System.Drawing.Point(303, 229);
            this.btnViewQuests.Name = "btnViewQuests";
            this.btnViewQuests.Size = new System.Drawing.Size(97, 23);
            this.btnViewQuests.TabIndex = 2;
            this.btnViewQuests.Text = "View Quests";
            this.btnViewQuests.UseVisualStyleBackColor = true;
            this.btnViewQuests.Click += new System.EventHandler(this.btnViewQuests_Click);
            // 
            // btnRunQueries
            // 
            this.btnRunQueries.Location = new System.Drawing.Point(303, 279);
            this.btnRunQueries.Name = "btnRunQueries";
            this.btnRunQueries.Size = new System.Drawing.Size(97, 23);
            this.btnRunQueries.TabIndex = 3;
            this.btnRunQueries.Text = "Run Queries";
            this.btnRunQueries.UseVisualStyleBackColor = true;
            this.btnRunQueries.Click += new System.EventHandler(this.btnRunQueries_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(303, 329);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(97, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRunQueries);
            this.Controls.Add(this.btnViewQuests);
            this.Controls.Add(this.btnViewCharacters);
            this.Controls.Add(this.btnViewClasses);
            this.Name = "MainForm";
            this.Text = "Main Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnViewClasses;
        private System.Windows.Forms.Button btnViewCharacters;
        private System.Windows.Forms.Button btnViewQuests;
        private System.Windows.Forms.Button btnRunQueries;
        private System.Windows.Forms.Button btnExit;
    }
}

