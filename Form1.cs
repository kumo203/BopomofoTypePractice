using NChinese.Phonetic;
using System.Media;
using System.Text;

namespace BopomofoTypePractice
{
    public partial class Form1 : Form
    {
        List<SoundPlayer> soundPlayerList;

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

            //if (e.KeyCode == Keys.Space)
            //{
            //    var ch = textBox2.Text[0].ToString();
            //    switch (ch)
            //    {
            //        case "ˉ":
            //        case "ˊ":
            //        case "ˇ":
            //        case "ˋ":
            //            textBox2.Text = textBox2.Text.Substring(1);
            //            return;
            //    }
            //}
        }

        private string GetZhuyinFromKey(string text)
        {

            switch (text)
            {
                case "1":
                case "d1":
                    soundPlayerList[1-1].Play();
                    return "ㄅ";
                case "2":
                case "d2":
                    soundPlayerList[5-1].Play();
                    return "ㄉ";
                case "3":
                case "d3":
                    return "ˇ";
                case "4":
                case "d4":
                    return "ˋ";
                case "5":
                case "d5":
                    soundPlayerList[15-1].Play();
                    return "ㄓ";
                case "6":
                case "d6":
                    return "ˊ";
                case "7":
                case "d7":
                    return "ˉ"; //"˙"; // イントネーション記号はこれにマッチと思うので
                case "8":
                case "d8":
                    soundPlayerList[22-1].Play();
                    return "ㄚ";
                case "9":
                case "d9":
                    soundPlayerList[26-1].Play();
                    return "ㄞ";
                case "0":
                case "d0":
                    soundPlayerList[30-1].Play();
                    return "ㄢ";
                case "-":
                case "oemminus":
                    soundPlayerList[34-1].Play();
                    return "ㄦ";
                case "q":
                    soundPlayerList[2-1].Play();
                    return "ㄆ";
                case "w":
                    soundPlayerList[6-1].Play();
                    return "ㄊ";
                case "e":
                    soundPlayerList[9-1].Play();
                    return "ㄍ";
                case "r":
                    soundPlayerList[12-1].Play();
                    return "ㄐ";
                case "t":
                    soundPlayerList[16-1].Play();
                    return "ㄔ";
                case "y":
                    soundPlayerList[19-1].Play();
                    return "ㄗ";
                case "u":
                    soundPlayerList[35-1].Play();
                    return "ㄧ";
                case "i":
                    soundPlayerList[23-1].Play();
                    return "ㄛ";
                case "o":
                    soundPlayerList[27-1].Play();
                    return "ㄟ";
                case "p":
                    soundPlayerList[31-1].Play();
                    return "ㄣ";
                case "a":
                    soundPlayerList[3-1].Play();
                    return "ㄇ";
                case "s":
                    soundPlayerList[7-1].Play();
                    return "ㄋ";
                case "d":
                    soundPlayerList[10-1].Play();
                    return "ㄎ";
                case "f":
                    soundPlayerList[13-1].Play();
                    return "ㄑ";
                case "g":
                    soundPlayerList[17-1].Play();
                    return "ㄕ";
                case "h":
                    soundPlayerList[20-1].Play();
                    return "ㄘ";
                case "j":
                    soundPlayerList[36-1].Play();
                    return "ㄨ";
                case "k":
                    soundPlayerList[24-1].Play();
                    return "ㄜ";
                case "l":
                    soundPlayerList[28-1].Play();
                    return "ㄠ";
                case ";":
                case "oemplus":
                    soundPlayerList[32-1].Play();
                    return "ㄤ";
                case "z":
                    soundPlayerList[4-1].Play();
                    return "ㄈ";
                case "x":
                    soundPlayerList[8-1].Play();
                    return "ㄌ";
                case "c":
                    soundPlayerList[11-1].Play();
                    return "ㄏ";
                case "v":
                    soundPlayerList[14-1].Play();
                    return "ㄒ";
                case "b":
                    soundPlayerList[18-1].Play();
                    return "ㄖ";
                case "n":
                    soundPlayerList[21-1].Play();
                    return "ㄙ";
                case "m":
                    soundPlayerList[37-1].Play();
                    return "ㄩ";
                case ",":
                case "oemcomma":
                    soundPlayerList[25-1].Play();
                    return "ㄝ";
                case ".":
                case "oemperiod":
                    soundPlayerList[29-1].Play();
                    return "ㄡ";
                case "/":
                case "oem2":    // '/'のキーコードがこれになるので。
                    soundPlayerList[33-1].Play();
                    return "ㄥ";
                default:
                    return "no-match";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            soundPlayerList = new List<SoundPlayer>();
            for (int i = 01; i <= 37; i++)
            {
                soundPlayerList.Add(new SoundPlayer("sound/" + i.ToString("00") + ".wav"));
            }
        }
    }
}
