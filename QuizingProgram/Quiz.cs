using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace QuizingProgram
{
    public partial class Quiz : Form
    {
        
        
        public Quiz()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Questions> question = new List<Questions>();
            XmlSerializer serializer = new XmlSerializer(typeof(List<Questions>));
            var xmlStr = File.ReadAllText($"Test.xml");
            var str = XElement.Parse(xmlStr);
            var result = str.Elements("Questions").Where(x => x.Element("Id").Value.Equals("1")).ToList();
            dataGridView1.DataSource = result;
            Question.Text = result.ToString(); ;
            try
            {
                FileStream fs = new FileStream(Environment.CurrentDirectory + $"\\{TitleEntry.Text}.xml", FileMode.Open, FileAccess.Read);

                using (fs)
                {
                    question = serializer.Deserialize(fs) as List<Questions>;
                    
                    label1.Visible = false;
                    TitleEntry.Visible = false;
                    button1.Visible = false;
                    
                }
            }
            catch
            {
                MessageBox.Show("Could not find test.", "Error", MessageBoxButtons.OK);
                
            }


        }
    }
}
