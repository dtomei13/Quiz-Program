namespace QuizingProgram
{
    partial class StartWindow
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
            this.Exit = new System.Windows.Forms.Button();
            this.EditQuiz = new System.Windows.Forms.Button();
            this.OpenQuiz = new System.Windows.Forms.Button();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.WelcomePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // WelcomePanel
            // 
            this.WelcomePanel.BackColor = System.Drawing.Color.Transparent;
            this.WelcomePanel.Controls.Add(this.Exit);
            this.WelcomePanel.Controls.Add(this.EditQuiz);
            this.WelcomePanel.Controls.Add(this.OpenQuiz);
            this.WelcomePanel.Controls.Add(this.WelcomeLabel);
            this.WelcomePanel.Controls.Add(this.button1);
            this.WelcomePanel.ForeColor = System.Drawing.Color.Black;
            this.WelcomePanel.Location = new System.Drawing.Point(-3, 0);
            this.WelcomePanel.Name = "WelcomePanel";
            this.WelcomePanel.Size = new System.Drawing.Size(600, 604);
            this.WelcomePanel.TabIndex = 1;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(326, 345);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(210, 42);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // EditQuiz
            // 
            this.EditQuiz.Location = new System.Drawing.Point(78, 345);
            this.EditQuiz.Name = "EditQuiz";
            this.EditQuiz.Size = new System.Drawing.Size(210, 42);
            this.EditQuiz.TabIndex = 3;
            this.EditQuiz.Text = "Edit Quiz";
            this.EditQuiz.UseVisualStyleBackColor = true;
            this.EditQuiz.Click += new System.EventHandler(this.EditQuiz_Click);
            // 
            // OpenQuiz
            // 
            this.OpenQuiz.Location = new System.Drawing.Point(326, 250);
            this.OpenQuiz.Name = "OpenQuiz";
            this.OpenQuiz.Size = new System.Drawing.Size(210, 42);
            this.OpenQuiz.TabIndex = 2;
            this.OpenQuiz.Text = "Open Quiz";
            this.OpenQuiz.UseVisualStyleBackColor = true;
            this.OpenQuiz.Click += new System.EventHandler(this.button2_Click);
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.Location = new System.Drawing.Point(118, 9);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(376, 69);
            this.WelcomeLabel.TabIndex = 1;
            this.WelcomeLabel.Text = "Custom Quiz";
            this.WelcomeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(78, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Create New Quiz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // StartWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 602);
            this.Controls.Add(this.WelcomePanel);
            this.Name = "StartWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WelcomePanel.ResumeLayout(false);
            this.WelcomePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GraphicsPanel WelcomePanel;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button EditQuiz;
        private System.Windows.Forms.Button OpenQuiz;
    }
}

