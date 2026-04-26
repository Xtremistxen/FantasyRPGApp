namespace FatasyRPGApp
{
    partial class QuestPredictorForm
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
            this.components = new System.ComponentModel.Container();
            this.txtPredictLevel = new System.Windows.Forms.TextBox();
            this.txtPredictReward = new System.Windows.Forms.TextBox();
            this.btnPredictDifficulty = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblPredictionResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPredictLevel
            // 
            this.txtPredictLevel.Location = new System.Drawing.Point(325, 168);
            this.txtPredictLevel.Name = "txtPredictLevel";
            this.txtPredictLevel.Size = new System.Drawing.Size(100, 20);
            this.txtPredictLevel.TabIndex = 0;
            // 
            // txtPredictReward
            // 
            this.txtPredictReward.Location = new System.Drawing.Point(325, 229);
            this.txtPredictReward.Name = "txtPredictReward";
            this.txtPredictReward.Size = new System.Drawing.Size(100, 20);
            this.txtPredictReward.TabIndex = 1;
            // 
            // btnPredictDifficulty
            // 
            this.btnPredictDifficulty.Location = new System.Drawing.Point(335, 277);
            this.btnPredictDifficulty.Name = "btnPredictDifficulty";
            this.btnPredictDifficulty.Size = new System.Drawing.Size(75, 23);
            this.btnPredictDifficulty.TabIndex = 2;
            this.btnPredictDifficulty.Text = "Predict Difficulty";
            this.btnPredictDifficulty.UseVisualStyleBackColor = true;
            this.btnPredictDifficulty.Click += new System.EventHandler(this.btnPredictDifficulty_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lblPredictionResult
            // 
            this.lblPredictionResult.AutoSize = true;
            this.lblPredictionResult.Location = new System.Drawing.Point(306, 336);
            this.lblPredictionResult.Name = "lblPredictionResult";
            this.lblPredictionResult.Size = new System.Drawing.Size(134, 13);
            this.lblPredictionResult.TabIndex = 4;
            this.lblPredictionResult.Text = "Prediction will appear here.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(325, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter character level 1-20";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter reward amount 1-500";
            // 
            // QuestPredictorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPredictionResult);
            this.Controls.Add(this.btnPredictDifficulty);
            this.Controls.Add(this.txtPredictReward);
            this.Controls.Add(this.txtPredictLevel);
            this.Name = "QuestPredictorForm";
            this.Text = "QuestPredictorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPredictLevel;
        private System.Windows.Forms.TextBox txtPredictReward;
        private System.Windows.Forms.Button btnPredictDifficulty;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblPredictionResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}