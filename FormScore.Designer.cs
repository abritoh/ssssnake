namespace ClusterBR
{
    partial class FormScore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormScore));
            this.LabelMaxScoreInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelMaxScoreInfo
            // 
            this.LabelMaxScoreInfo.AutoSize = true;
            this.LabelMaxScoreInfo.Font = new System.Drawing.Font("Snap ITC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMaxScoreInfo.ForeColor = System.Drawing.Color.White;
            this.LabelMaxScoreInfo.Location = new System.Drawing.Point(109, 165);
            this.LabelMaxScoreInfo.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.LabelMaxScoreInfo.Name = "LabelMaxScoreInfo";
            this.LabelMaxScoreInfo.Size = new System.Drawing.Size(351, 35);
            this.LabelMaxScoreInfo.TabIndex = 5;
            this.LabelMaxScoreInfo.Text = "Label Max Score Info";
            this.LabelMaxScoreInfo.Visible = false;
            // 
            // FormScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(592, 393);
            this.Controls.Add(this.LabelMaxScoreInfo);
            this.Font = new System.Drawing.Font("Snap ITC", 20.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.Name = "FormScore";
            this.Text = "sssnake v1.0 ─ Max Score Info";
            this.Load += new System.EventHandler(this.FormMaxScore_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelMaxScoreInfo;

    }
}