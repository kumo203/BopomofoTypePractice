using NChinese.Phonetic;
using System.Diagnostics;
using System.Text;

namespace BopomofoTypePractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var converter = new ZhuyinReverseConverter();
            string[] result = converter.GetZhuyin(textBox1.Text);

            var sb = new StringBuilder();
            foreach (var s in result)
            {
                sb.Append(s);
            }
            textBox2.Text = sb.ToString();
        }
    }
}
