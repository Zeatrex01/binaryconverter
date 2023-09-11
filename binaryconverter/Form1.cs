using System.Text;

namespace binaryconverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void binarybox_TextChanged(object sender, EventArgs e)
        {
            string binaryInput = binarybox.Text;
            if (IsBinary(binaryInput))
            {
                string textOutput = BinaryToText(binaryInput);
                textbox.Text = textOutput;
            }
            else
            {
                // Binary kutusuna geçerli bir deðer girildiðinde uyarý verme
                if (!string.IsNullOrWhiteSpace(binaryInput))
                {
                    string textOutput = BinaryToText(binaryInput);
                    textbox.Text = textOutput;
                }
                else
                {
                    textbox.Text = "";
                }
            }
        }

        private bool IsBinary(string binary)
        {
            foreach (char c in binary)
            {
                if (c != '0' && c != '1')
                {
                    return false;
                }
            }
            return true;
        }

        private void binaryconvertbutton_Click(object sender, EventArgs e)
        {
            string binaryInput = binarybox.Text;
            string textOutput = BinaryToText(binaryInput);
            textbox.Text = textOutput;
        }

        private void textconvertbutton_Click(object sender, EventArgs e)
        {
            string textInput = textbox.Text;
            string binaryOutput = TextToBinary(textInput);
            if (binaryOutput != null) // Geçerli bir dönüþüm sonucu varsa
            {
                binarybox.Text = binaryOutput;
            }
            else
            {
                // Metin kutusuna geçerli bir deðer girildiðinde uyarý verme
                if (!string.IsNullOrWhiteSpace(textInput))
                {
                    MessageBox.Show("Invalid text input. Please enter valid text in the text box.");
                }
                binarybox.Text = "";
            }
        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            binarybox.Text = "";
            textbox.Text = "";
        }
        private void textbox_TextChanged(object sender, EventArgs e)
        {

        }
        private string BinaryToText(string binary)
        {
            string[] binaryArray = binary.Split(' ');
            byte[] bytes = new byte[binaryArray.Length];

            try
            {
                for (int i = 0; i < binaryArray.Length; i++)
                {
                    bytes[i] = Convert.ToByte(binaryArray[i], 2);
                }
                return Encoding.UTF8.GetString(bytes);
            }
            catch (Exception ex)
            {
                // Binary kutusuna geçerli bir deðer girildiðinde uyarý verme
                if (!string.IsNullOrWhiteSpace(binary))
                {
                    MessageBox.Show("invalid character input: " + ex.Message);
                }
                return null;
            }
        }

        private string TextToBinary(string text)
        {
            byte[] textBytes = Encoding.UTF8.GetBytes(text);
            StringBuilder binaryStringBuilder = new StringBuilder();

            foreach (byte b in textBytes)
            {
                binaryStringBuilder.Append(Convert.ToString(b, 2).PadLeft(8, '0') + " ");
            }

            return binaryStringBuilder.ToString().Trim();
        }
    }
}
