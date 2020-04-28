using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizingProgram
{
    public partial class StartWindow : Form
    {
        public StartWindow()
        {
            InitializeComponent();
        }


   

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var createQuiz = new CreateQuizWindow();
            createQuiz.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var openQuiz = new Quiz();
            openQuiz.Show();
        }

        private void EditQuiz_Click(object sender, EventArgs e)
        {
            this.Hide();
            var editQuiz = new EditQuiz();
            editQuiz.Show();
            
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
