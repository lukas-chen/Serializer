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
using System.Xml.Serialization;

namespace SerializationDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSerialization_Click(object sender, EventArgs e)
        {
            Member obj = new Member();
            obj.Name = "Peter";
            obj.Age = 20;
            obj.Show();

            // TODO: Serialize obj to XML and save to c:\demo.xml

            XmlSerializer xs = new XmlSerializer(typeof(Member));
            TextWriter tw = new StringWriter();
            xs.Serialize(tw, obj);
            textBox1.Text = tw.ToString();
        }

        private void btnDeserialization_Click(object sender, EventArgs e)
        {
            Member obj = null;

            // TODO: Deserialize obj from XML in c:\demo.xml
            XmlSerializer xs = new XmlSerializer(typeof(Member));
            TextReader tr = new StringReader(textBox1.Text);
            obj = (Member)xs.Deserialize(tr);

            obj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Member obj = new Member();
            obj.Name = "Peter";
            obj.Age = 20;

            // TODO: Serialize obj to XML and save to c:\demo.xml

            XmlSerializer xs = new XmlSerializer(typeof(Member));
            FileStream fs = new FileStream(@"c:\demo.xml", FileMode.Create);
            xs.Serialize(fs, obj);
            fs.Close();
            MessageBox.Show("OK");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Member obj = null;

            // TODO: Deserialize obj from XML in c:\demo.xml
            XmlSerializer xs = new XmlSerializer(typeof(Member));
            FileStream fs = new FileStream(@"c:\demo.xml", FileMode.Open);
            obj = (Member)xs.Deserialize(fs);
            fs.Close();

            obj.Show();

        }
    }
}
