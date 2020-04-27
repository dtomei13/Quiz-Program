namespace QuizingProgram
{
    partial class Form1
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
            this.WelcomePanel = new QuizingProgram.GraphicsPanel();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.WelcomePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // WelcomePanel
            // 
            this.WelcomePanel.BackColor = System.Drawing.Color.Transparent;
            this.WelcomePanel.Controls.Add(this.WelcomeLabel);
            this.WelcomePanel.Controls.Add(this.button1);
            this.WelcomePanel.ForeColor = System.Drawing.Color.Black;
            this.WelcomePanel.Location = new System.Drawing.Point(-3, 0);
            this.WelcomePanel.Name = "WelcomePanel";
            this.WelcomePanel.Size = new System.Drawing.Size(600, 604);
            this.WelcomePanel.TabIndex = 1;
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.Location = new System.Drawing.Point(9, 105);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(588, 69);
            this.WelcomeLabel.TabIndex = 1;
            this.WelcomeLabel.Text = "7 Level Practice Test";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(208, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Begin";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 602);
            this.Controls.Add(this.WelcomePanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WelcomePanel.ResumeLayout(false);
            this.WelcomePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GraphicsPanel WelcomePanel;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Button button1;
    }
}

