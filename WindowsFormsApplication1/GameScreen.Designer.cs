namespace WindowsFormsApplication1
{
    partial class GameScreen
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
            this.labelTurn = new System.Windows.Forms.Label();
            this.buttonRed = new System.Windows.Forms.Button();
            this.buttonGreen = new System.Windows.Forms.Button();
            this.buttonYellow = new System.Windows.Forms.Button();
            this.buttonBlue = new System.Windows.Forms.Button();
            this.labelMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTurn
            // 
            this.labelTurn.AutoSize = true;
            this.labelTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTurn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTurn.Location = new System.Drawing.Point(124, 54);
            this.labelTurn.Name = "labelTurn";
            this.labelTurn.Size = new System.Drawing.Size(51, 20);
            this.labelTurn.TabIndex = 0;
            this.labelTurn.Text = "label1";
            // 
            // buttonRed
            // 
            this.buttonRed.BackColor = System.Drawing.Color.Maroon;
            this.buttonRed.FlatAppearance.BorderSize = 0;
            this.buttonRed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRed.Font = new System.Drawing.Font("OCR A Std", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRed.Location = new System.Drawing.Point(87, 146);
            this.buttonRed.Name = "buttonRed";
            this.buttonRed.Size = new System.Drawing.Size(152, 138);
            this.buttonRed.TabIndex = 1;
            this.buttonRed.Text = "RED";
            this.buttonRed.UseVisualStyleBackColor = false;
            this.buttonRed.Click += new System.EventHandler(this.buttonRed_Click);
            // 
            // buttonGreen
            // 
            this.buttonGreen.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonGreen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGreen.Font = new System.Drawing.Font("OCR A Std", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGreen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonGreen.Location = new System.Drawing.Point(259, 146);
            this.buttonGreen.Name = "buttonGreen";
            this.buttonGreen.Size = new System.Drawing.Size(152, 138);
            this.buttonGreen.TabIndex = 2;
            this.buttonGreen.Text = "GREEN";
            this.buttonGreen.UseVisualStyleBackColor = false;
            this.buttonGreen.Click += new System.EventHandler(this.buttonGreen_Click);
            // 
            // buttonYellow
            // 
            this.buttonYellow.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.buttonYellow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonYellow.Font = new System.Drawing.Font("OCR A Std", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonYellow.Location = new System.Drawing.Point(87, 305);
            this.buttonYellow.Name = "buttonYellow";
            this.buttonYellow.Size = new System.Drawing.Size(152, 138);
            this.buttonYellow.TabIndex = 3;
            this.buttonYellow.Text = "YELLOW";
            this.buttonYellow.UseVisualStyleBackColor = false;
            this.buttonYellow.Click += new System.EventHandler(this.buttonYellow_Click);
            // 
            // buttonBlue
            // 
            this.buttonBlue.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonBlue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBlue.Font = new System.Drawing.Font("OCR A Std", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBlue.Location = new System.Drawing.Point(259, 305);
            this.buttonBlue.Name = "buttonBlue";
            this.buttonBlue.Size = new System.Drawing.Size(152, 138);
            this.buttonBlue.TabIndex = 4;
            this.buttonBlue.Text = "BLUE";
            this.buttonBlue.UseVisualStyleBackColor = false;
            this.buttonBlue.Click += new System.EventHandler(this.buttonBlue_Click);
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelMessage.Location = new System.Drawing.Point(39, 103);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(51, 20);
            this.labelMessage.TabIndex = 5;
            this.labelMessage.Text = "label1";
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.buttonBlue);
            this.Controls.Add(this.buttonYellow);
            this.Controls.Add(this.buttonGreen);
            this.Controls.Add(this.buttonRed);
            this.Controls.Add(this.labelTurn);
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(500, 500);
            this.Load += new System.EventHandler(this.GameScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTurn;
        private System.Windows.Forms.Button buttonRed;
        private System.Windows.Forms.Button buttonGreen;
        private System.Windows.Forms.Button buttonYellow;
        private System.Windows.Forms.Button buttonBlue;
        private System.Windows.Forms.Label labelMessage;
    }
}
