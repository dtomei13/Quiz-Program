using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace QuizingProgram
{
    public partial class CreateQuizWindow : Form
    {
        int count = 1;
        int y = 151;
        List<string> questionIn = new List<string>();
        List<string> answerIn = new List<string>();

        List<Questions> question = new List<Questions>();
        XmlSerializer serializer = new XmlSerializer(typeof(List<Questions>));
        public CreateQuizWindow()
        {
            InitializeComponent();

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            var returnToStart = new StartWindow();
            returnToStart.Show();
        }

        private void NumberEntry_ValueChanged(object sender, EventArgs e)
        {

        }



        private void Continue_Click(object sender, EventArgs e)
        {
            
                using (FileStream fs = new FileStream(Environment.CurrentDirectory + $"\\{QuizNameBox.Text}.xml", FileMode.Create, FileAccess.Write))
                {
                    serializer.Serialize(fs, question);
                    MessageBox.Show("Quiz Saved");
                }
                this.Close();
                var returnToStart = new StartWindow();
                returnToStart.Show();
         

            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            question.Add(new Questions() { Id = count,Question = textBox1.Text, Answer = AnswerBox.Text });
            count++;
            AnswerBox.Clear();
            textBox1.Clear();



        }
    }
}
