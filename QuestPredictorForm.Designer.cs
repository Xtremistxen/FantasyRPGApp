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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuestPredictorForm));
            this.txtPredictLevel = new System.Windows.Forms.TextBox();
            this.txtPredictReward = new System.Windows.Forms.TextBox();
            this.btnPredictDifficulty = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblPredictionResult = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblReward = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPredictLevel
            // 
            this.txtPredictLevel.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtPredictLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPredictLevel.ForeColor = System.Drawing.Color.Gold;
            this.txtPredictLevel.Location = new System.Drawing.Point(325, 145);
            this.txtPredictLevel.Name = "txtPredictLevel";
            this.txtPredictLevel.Size = new System.Drawing.Size(147, 20);
            this.txtPredictLevel.TabIndex = 0;
            // 
            // txtPredictReward
            // 
            this.txtPredictReward.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtPredictReward.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPredictReward.ForeColor = System.Drawing.Color.Gold;
            this.txtPredictReward.Location = new System.Drawing.Point(325, 209);
            this.txtPredictReward.Name = "txtPredictReward";
            this.txtPredictReward.Size = new System.Drawing.Size(147, 20);
            this.txtPredictReward.TabIndex = 1;
            // 
            // btnPredictDifficulty
            // 
            this.btnPredictDifficulty.BackColor = System.Drawing.Color.Transparent;
            this.btnPredictDifficulty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPredictDifficulty.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnPredictDifficulty.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPredictDifficulty.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPredictDifficulty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPredictDifficulty.Location = new System.Drawing.Point(344, 251);
            this.btnPredictDifficulty.Name = "btnPredictDifficulty";
            this.btnPredictDifficulty.Size = new System.Drawing.Size(112, 23);
            this.btnPredictDifficulty.TabIndex = 2;
            this.btnPredictDifficulty.UseVisualStyleBackColor = false;
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
            this.lblPredictionResult.BackColor = System.Drawing.Color.Black;
            this.lblPredictionResult.ForeColor = System.Drawing.Color.Gold;
            this.lblPredictionResult.Location = new System.Drawing.Point(300, 310);
            this.lblPredictionResult.Name = "lblPredictionResult";
            this.lblPredictionResult.Size = new System.Drawing.Size(134, 13);
            this.lblPredictionResult.TabIndex = 4;
            this.lblPredictionResult.Text = "Prediction will appear here.";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.BackColor = System.Drawing.Color.Cornsilk;
            this.lblLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.Location = new System.Drawing.Point(321, 122);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(163, 20);
            this.lblLevel.TabIndex = 5;
            this.lblLevel.Text = "Enter Character Level";
            // 
            // lblReward
            // 
            this.lblReward.AutoSize = true;
            this.lblReward.BackColor = System.Drawing.Color.Cornsilk;
            this.lblReward.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReward.Location = new System.Drawing.Point(321, 186);
            this.lblReward.Name = "lblReward";
            this.lblReward.Size = new System.Drawing.Size(167, 20);
            this.lblReward.TabIndex = 6;
            this.lblReward.Text = "Enter Reward Amount";
            // 
            // QuestPredictorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblReward);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblPredictionResult);
            this.Controls.Add(this.btnPredictDifficulty);
            this.Controls.Add(this.txtPredictReward);
            this.Controls.Add(this.txtPredictLevel);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QuestPredictorForm";
            this.Text = "Quest Difficulty Predictor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPredictLevel;
        private System.Windows.Forms.TextBox txtPredictReward;
        private System.Windows.Forms.Button btnPredictDifficulty;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblPredictionResult;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblReward;
    }
}