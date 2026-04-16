namespace FatasyRPGApp
{
    partial class QueriesForm
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
            this.dgvQueryResults = new System.Windows.Forms.DataGridView();
            this.btnAllCharacters = new System.Windows.Forms.Button();
            this.btnHighLevel = new System.Windows.Forms.Button();
            this.btnJoin = new System.Windows.Forms.Button();
            this.fantasyRPGDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fantasyRPGDBDataSet = new FatasyRPGApp.FantasyRPGDBDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQueryResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fantasyRPGDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fantasyRPGDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvQueryResults
            // 
            this.dgvQueryResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQueryResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvQueryResults.Location = new System.Drawing.Point(0, 0);
            this.dgvQueryResults.Name = "dgvQueryResults";
            this.dgvQueryResults.Size = new System.Drawing.Size(800, 450);
            this.dgvQueryResults.TabIndex = 0;
            // 
            // btnAllCharacters
            // 
            this.btnAllCharacters.Location = new System.Drawing.Point(12, 357);
            this.btnAllCharacters.Name = "btnAllCharacters";
            this.btnAllCharacters.Size = new System.Drawing.Size(115, 23);
            this.btnAllCharacters.TabIndex = 1;
            this.btnAllCharacters.Text = "Show All Characters";
            this.btnAllCharacters.UseVisualStyleBackColor = true;
            this.btnAllCharacters.Click += new System.EventHandler(this.btnAllCharacters_Click);
            // 
            // btnHighLevel
            // 
            this.btnHighLevel.Location = new System.Drawing.Point(12, 386);
            this.btnHighLevel.Name = "btnHighLevel";
            this.btnHighLevel.Size = new System.Drawing.Size(115, 23);
            this.btnHighLevel.TabIndex = 2;
            this.btnHighLevel.Text = "Level > 10";
            this.btnHighLevel.UseVisualStyleBackColor = true;
            this.btnHighLevel.Click += new System.EventHandler(this.btnHighLevel_Click);
            // 
            // btnJoin
            // 
            this.btnJoin.Location = new System.Drawing.Point(12, 415);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(115, 23);
            this.btnJoin.TabIndex = 3;
            this.btnJoin.Text = "Characters + Classes";
            this.btnJoin.UseVisualStyleBackColor = true;
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // fantasyRPGDBDataSetBindingSource
            // 
            this.fantasyRPGDBDataSetBindingSource.DataSource = this.fantasyRPGDBDataSet;
            this.fantasyRPGDBDataSetBindingSource.Position = 0;
            // 
            // fantasyRPGDBDataSet
            // 
            this.fantasyRPGDBDataSet.DataSetName = "FantasyRPGDBDataSet";
            this.fantasyRPGDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // QueriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnJoin);
            this.Controls.Add(this.btnHighLevel);
            this.Controls.Add(this.btnAllCharacters);
            this.Controls.Add(this.dgvQueryResults);
            this.Name = "QueriesForm";
            this.Text = "QueriesForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvQueryResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fantasyRPGDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fantasyRPGDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvQueryResults;
        private System.Windows.Forms.Button btnAllCharacters;
        private System.Windows.Forms.Button btnHighLevel;
        private System.Windows.Forms.Button btnJoin;
        private System.Windows.Forms.BindingSource fantasyRPGDBDataSetBindingSource;
        private FantasyRPGDBDataSet fantasyRPGDBDataSet;
    }
}