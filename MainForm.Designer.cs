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
            this.btnAddCharacter = new System.Windows.Forms.Button();
            this.btnQuestPredictor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnViewClasses
            // 
            this.btnViewClasses.Location = new System.Drawing.Point(342, 248);
            this.btnViewClasses.Name = "btnViewClasses";
            this.btnViewClasses.Size = new System.Drawing.Size(97, 23);
            this.btnViewClasses.TabIndex = 0;
            this.btnViewClasses.Text = "View Classes";
            this.btnViewClasses.UseVisualStyleBackColor = true;
            this.btnViewClasses.Click += new System.EventHandler(this.btnViewClasses_Click);
            // 
            // btnViewCharacters
            // 
            this.btnViewCharacters.Location = new System.Drawing.Point(342, 277);
            this.btnViewCharacters.Name = "btnViewCharacters";
            this.btnViewCharacters.Size = new System.Drawing.Size(97, 23);
            this.btnViewCharacters.TabIndex = 1;
            this.btnViewCharacters.Text = "View Characters";
            this.btnViewCharacters.UseVisualStyleBackColor = true;
            this.btnViewCharacters.Click += new System.EventHandler(this.btnViewCharacters_Click);
            // 
            // btnViewQuests
            // 
            this.btnViewQuests.Location = new System.Drawing.Point(342, 306);
            this.btnViewQuests.Name = "btnViewQuests";
            this.btnViewQuests.Size = new System.Drawing.Size(97, 23);
            this.btnViewQuests.TabIndex = 2;
            this.btnViewQuests.Text = "View Quests";
            this.btnViewQuests.UseVisualStyleBackColor = true;
            this.btnViewQuests.Click += new System.EventHandler(this.btnViewQuests_Click);
            // 
            // btnRunQueries
            // 
            this.btnRunQueries.Location = new System.Drawing.Point(342, 369);
            this.btnRunQueries.Name = "btnRunQueries";
            this.btnRunQueries.Size = new System.Drawing.Size(97, 23);
            this.btnRunQueries.TabIndex = 3;
            this.btnRunQueries.Text = "Run Queries";
            this.btnRunQueries.UseVisualStyleBackColor = true;
            this.btnRunQueries.Click += new System.EventHandler(this.btnRunQueries_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(691, 415);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(97, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddCharacter
            // 
            this.btnAddCharacter.Location = new System.Drawing.Point(342, 219);
            this.btnAddCharacter.Name = "btnAddCharacter";
            this.btnAddCharacter.Size = new System.Drawing.Size(97, 23);
            this.btnAddCharacter.TabIndex = 5;
            this.btnAddCharacter.Text = "Add Character";
            this.btnAddCharacter.UseVisualStyleBackColor = true;
            this.btnAddCharacter.Click += new System.EventHandler(this.btnAddCharacter_Click);
            // 
            // btnQuestPredictor
            // 
            this.btnQuestPredictor.Location = new System.Drawing.Point(342, 171);
            this.btnQuestPredictor.Name = "btnQuestPredictor";
            this.btnQuestPredictor.Size = new System.Drawing.Size(97, 23);
            this.btnQuestPredictor.TabIndex = 6;
            this.btnQuestPredictor.Text = "Quest Predictor";
            this.btnQuestPredictor.UseVisualStyleBackColor = true;
            this.btnQuestPredictor.Click += new System.EventHandler(this.btnQuestPredictor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Welcome to the Fantasy RPG Character and Quest Manager.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Use the buttons below to view, add, and analyze RPG data.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Choose a query below to display database results.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(232, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(319, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Enter a character level and quest reward to predict quest difficulty.";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnQuestPredictor);
            this.Controls.Add(this.btnAddCharacter);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRunQueries);
            this.Controls.Add(this.btnViewQuests);
            this.Controls.Add(this.btnViewCharacters);
            this.Controls.Add(this.btnViewClasses);
            this.Name = "MainForm";
            this.Text = "Fantasy RPG Character and Quest Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnViewClasses;
        private System.Windows.Forms.Button btnViewCharacters;
        private System.Windows.Forms.Button btnViewQuests;
        private System.Windows.Forms.Button btnRunQueries;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddCharacter;
        private System.Windows.Forms.Button btnQuestPredictor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

