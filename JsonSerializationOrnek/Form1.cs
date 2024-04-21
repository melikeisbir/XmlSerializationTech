using System.Text.Json;
using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;

namespace JsonSerializationOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product product = new Product();

            product.Name = "Apple";
            product.ExpireDate = new DateTime(2008, 12, 28);

            JsonSerializer jsonSerializer = new JsonSerializer();
            using (StreamWriter writer = new StreamWriter(@"C:\\Users\Melike �SB�R\Desktop\json.json"))
            using (JsonWriter jsonWriter = new JsonTextWriter(writer))
            {
                jsonSerializer.Serialize(writer, product);
                MessageBox.Show("��lem Ba�ar�l�");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            JsonSerializer jsonSerializer = new JsonSerializer();
            using (StreamReader file = File.OpenText(@"C:\\Users\Melike �SB�R\Desktop\json.json"))
            using (JsonReader reader = new JsonTextReader(file))
            {
                Product product = (Product)jsonSerializer.Deserialize(reader, typeof(Product));
                MessageBox.Show("�r�n Ad�: " + product.Name);
            }
        }
    }
}
