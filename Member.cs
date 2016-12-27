using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerializationDemo
{
    public class Member
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public void Show()
        {
            MessageBox.Show(
                string.Format("Name={0}, Age={1}", this.Name, this.Age)    
            );
        }
    }
}
