using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace winformslab6

{ 
    public partial class SerForm : Form
    {
        public SerForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee
            {
                name = name_textBox.Text,
                surname = surname_textBox.Text,
                date = dateTimePicker1.Value,
            };

            BinaryFormatter binarFormatter = new BinaryFormatter();

            FileStream fsout = new FileStream("employee.binary", FileMode.Create, FileAccess.Write, FileShare.None);
            try
            {
                using (fsout)
                {
                    binarFormatter.Serialize(fsout, emp);
                    massege_label.Visible = true;
                    massege_label.Text = "Person Serialized";
                }
            }
            catch
            {
                massege_label.Visible = true;
                massege_label.Text = "An error has occured";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();

            BinaryFormatter bf = new BinaryFormatter();

            FileStream fsin = new FileStream("employee.binary", FileMode.Open, FileAccess.Read, FileShare.None);
            try
            {
                using (fsin)
                {
                    emp = (Employee)bf.Deserialize(fsin);
                    massege_label.Visible = true;
                    massege_label.Text = "Person Deserialized";

                    name_textBox.Text = emp.name;
                    surname_textBox.Text = emp.surname;
                    dateTimePicker1.Value = emp.date;
                    
                }
            }
            catch
            {
                massege_label.Visible = true;
                massege_label.Text = "An error has occured";
            }
        }
    }
}
