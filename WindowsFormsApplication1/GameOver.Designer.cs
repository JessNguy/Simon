namespace WindowsFormsApplication1
{
    partial class GameOver
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelGameOver = new System.Windows.Forms.Label();
            this.labelRounds = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonAgain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelGameOver
            // 
            this.labelGameOver.AutoSize = true;
            this.labelGameOver.Font = new System.Drawing.Font("OCR A Std", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGameOver.Location = new System.Drawing.Point(146, 183);
            this.labelGameOver.Name = "labelGameOver";
            this.labelGameOver.Size = new System.Drawing.Size(145, 22);
            this.labelGameOver.TabIndex = 0;
            this.labelGameOver.Text = "Game Over";
            // 
            // labelRounds
            // 
            this.labelRounds.AutoSize = true;
            this.labelRounds.Font = new System.Drawing.Font("OCR A Std", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRounds.Location = new System.Drawing.Point(77, 233);
            this.labelRounds.Name = "labelRounds";
            this.labelRounds.Size = new System.Drawing.Size(0, 22);
            this.labelRounds.TabIndex = 1;
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("OCR A Std", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(139, 303);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(152, 32);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "EXIT";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonAgain
            // 
            this.buttonAgain.Font = new System.Drawing.Font("OCR A Std", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgain.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonAgain.Location = new System.Drawing.Point(139, 357);
            this.buttonAgain.Name = "buttonAgain";
            this.buttonAgain.Size = new System.Drawing.Size(152, 30);
            this.buttonAgain.TabIndex = 3;
            this.buttonAgain.Text = "AGAIN";
            this.buttonAgain.UseVisualStyleBackColor = true;
            this.buttonAgain.Click += new System.EventHandler(this.buttonAgain_Click);
            // 
            // GameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonAgain);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.labelRounds);
            this.Controls.Add(this.labelGameOver);
            this.Name = "GameOver";
            this.Size = new System.Drawing.Size(500, 500);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGameOver;
        private System.Windows.Forms.Label labelRounds;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonAgain;
    }
}
