using NChinese.Phonetic;
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
            textBox2.Text = sb.ToString().Replace("　", "");
        }

        private void textBox3_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox3.Text = "";
                textBox4.Text = "";                
                return;
            }

            var zhuyin_code = GetZhuyinFromKey(e.KeyCode.ToString().ToLower());
            if (textBox2.Text.StartsWith(zhuyin_code))
            {
                textBox2.Text = textBox2.Text.Substring(1);
                textBox4.Text += zhuyin_code;
                return;
            }

            if (e.KeyCode == Keys.Space)
            {
                var ch = textBox2.Text[0].ToString();
                switch (ch)
                {
                    case "ˉ":
                    case "ˊ":
                    case "ˇ":
                    case "ˋ":
                        textBox2.Text = textBox2.Text.Substring(1);
                        return;
                }
            }
        }

        private string GetZhuyinFromKey(string text)
        {

            switch (text)
            {
                case "1":
                case "d1":
                    return "ㄅ";
                case "2":
                case "d2":
                    return "ㄉ";
                case "3":
                case "d3":
                    return "ˇ";
                case "4":
                case "d4":
                    return "ˋ";
                case "5":
                case "d5":
                    return "ㄓ";
                case "6":
                case "d6":
                    return "ˊ";
                case "7":
                case "d7":
                    return "˙";
                case "8":
                case "d8":
                    return "ㄚ";
                case "9":
                case "d9":
                    return "ㄞ";
                case "0":
                case "d0":
                    return "ㄢ";
                case "-":
                case "oemminus":
                    return "ㄦ";
                case "q":
                    return "ㄆ";
                case "w":
                    return "ㄊ";
                case "e":
                    return "ㄍ";
                case "r":
                    return "ㄐ";
                case "t":
                    return "ㄔ";
                case "y":
                    return "ㄗ";
                case "u":
                    return "ㄧ";
                case "i":
                    return "ㄛ";
                case "o":
                    return "ㄟ";
                case "p":
                    return "ㄣ";
                case "a":
                    return "ㄇ";
                case "s":
                    return "ㄋ";
                case "d":
                    return "ㄎ";
                case "f":
                    return "ㄑ";
                case "g":
                    return "ㄕ";
                case "h":
                    return "ㄘ";
                case "j":
                    return "ㄨ";
                case "k":
                    return "ㄜ";
                case "l":
                    return "ㄠ";
                case ";":
                case "oemplus":
                    return "ㄤ";
                case "z":
                    return "ㄈ";
                case "x":
                    return "ㄌ";
                case "c":
                    return "ㄏ";
                case "v":
                    return "ㄒ";
                case "b":
                    return "ㄖ";
                case "n":
                    return "ㄙ";
                case "m":
                    return "ㄩ";
                case ",":
                case "oemcomma":
                    return "ㄝ";
                case ".":
               case "oemperiod":
                    return "ㄡ";
                case "/":
                case "oem2":    // '/'のキーコードがこれになるので。
                    return "ㄥ";
                default:
                    return "no-match";
            }
        }
    }
}
