using System.Xml.Serialization;

namespace XmlSerializationOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void xmlserializedbutton_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee()
            {
                Name = adtextBox.Text,
                Phone = telefontextBox.Text,
                DoB = dateTimePicker1.Value,
                Department = departmantextBox.Text,
                Salary = Convert.ToInt32(maastextBox.Text),
                additonalInfo = "Serileþme istemiyoruz"
            };
            XmlSerializer xs = new XmlSerializer(typeof(Employee));
            FileStream fsout = new FileStream("employee.xml", FileMode.Create, FileAccess.Write, FileShare.None);
            try
            {
                using (fsout)
                {
                    xs.Serialize(fsout, employee);
                    Sonuclabel.Text = "Bilgiler Serilize Edildi.";
                    Sonuclabel.Visible = true;
                    adtextBox.Text = "";
                    telefontextBox.Text = "";
                    departmantextBox.Text = "";
                    maastextBox.Text = "";
                }
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
                Sonuclabel.Text = "Bir hata oluþtu";
                Sonuclabel.Visible = true;
            }
            finally
            {
                fsout.Close();
            }
        }

        private void xmldeserializedbutton_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();

            XmlSerializer xs = new XmlSerializer(typeof(Employee));    
            FileStream fsin = new FileStream("employee.xml", FileMode.Open, FileAccess.Read, FileShare.None); 
        
            try
            {
               
                using (fsin)
                {
                    employee = (Employee)xs.Deserialize(fsin);
                    Sonuclabel.Text = "Object DeSerilize Edildi.";
                    Sonuclabel.Visible = true;
                    adtextBox.Text = employee.Name;
                    telefontextBox.Text = employee.Phone;
                    dateTimePicker1.Value = employee.DoB;
                    departmantextBox.Text = employee.Department;
                    maastextBox.Text = Convert.ToString(employee.Salary);
                }
            }

            catch (Exception ex)
            {
                ex.Message.ToString();
                Sonuclabel.Text = "Bir hata oluþtu";
                Sonuclabel.Visible = true;
            }
        }
    }
}
