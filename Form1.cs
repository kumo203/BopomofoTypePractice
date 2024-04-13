using NChinese.Phonetic;
using System.Media;
using System.Text;

namespace BopomofoTypePractice
{
    public partial class Form1 : Form
    {
        string[] zhuyin_list = new string[]
              { "ㄅ", "ㄉ", "ˇ", "ˋ", "ㄓ", "ˊ", "˙", "ㄚ", "ㄞ", "ㄢ", "ㄦ", "ㄆ", 
                "ㄊ", "ㄍ", "ㄐ", "ㄔ", "ㄗ", "ㄧ", "ㄛ", "ㄟ", "ㄣ", "ㄇ", "ㄋ", "ㄎ", 
                "ㄑ", "ㄕ", "ㄘ", "ㄨ", "ㄜ", "ㄠ", "ㄤ", "ㄈ", "ㄌ", "ㄏ", "ㄒ", "ㄖ", 
                "ㄙ", "ㄩ", "ㄝ", "ㄡ", "ㄥ", "ˉ" };
        List<SoundPlayer> soundPlayerList;
        List<TextBox> textBoxList;

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
            if (e.KeyCode == Keys.Space)
            {
                var ch = textBox2.Text[0].ToString();
                switch (ch)
                {
                    case "ˉ":
                        {
                            textBox2.Text = textBox2.Text.Substring(1);
                            return;
                        }
                }
            }
        }

        private string GetZhuyinFromKey(string text)
        {

            switch (text)
            {
                case "1":
                case "d1": // '1'のキーコードがこれになるので。
                    soundPlayerList[1 - 1].Play();
                    return "ㄅ";
                case "2":
                case "d2": // '2'のキーコードがこれになるので。
                    soundPlayerList[5 - 1].Play();
                    return "ㄉ";
                case "3":
                case "d3": // '3'のキーコードがこれになるので。
                    return "ˇ";
                case "4":
                case "d4": // '4'のキーコードがこれになるので。
                    return "ˋ";
                case "5":
                case "d5": // '5'のキーコードがこれになるので。
                    soundPlayerList[15 - 1].Play();
                    return "ㄓ";
                case "6":
                case "d6": // '6'のキーコードがこれになるので。
                    return "ˊ";
                case "7":
                case "d7": // '7'のキーコードがこれになるので。
                    return "˙";
                case "8":
                case "d8": // '8'のキーコードがこれになるので。
                    soundPlayerList[22 - 1].Play();
                    return "ㄚ";
                case "9":
                case "d9": // '9'のキーコードがこれになるので。
                    soundPlayerList[26 - 1].Play();
                    return "ㄞ";
                case "0":
                case "d0": // '0'のキーコードがこれになるので。
                    soundPlayerList[30 - 1].Play();
                    return "ㄢ";
                case "-":
                case "oemminus": // '-'のキーコードがこれになるので。
                    soundPlayerList[34 - 1].Play();
                    return "ㄦ";
                case "q":
                    soundPlayerList[2 - 1].Play();
                    return "ㄆ";
                case "w":
                    soundPlayerList[6 - 1].Play();
                    return "ㄊ";
                case "e":
                    soundPlayerList[9 - 1].Play();
                    return "ㄍ";
                case "r":
                    soundPlayerList[12 - 1].Play();
                    return "ㄐ";
                case "t":
                    soundPlayerList[16 - 1].Play();
                    return "ㄔ";
                case "y":
                    soundPlayerList[19 - 1].Play();
                    return "ㄗ";
                case "u":
                    soundPlayerList[35 - 1].Play();
                    return "ㄧ";
                case "i":
                    soundPlayerList[23 - 1].Play();
                    return "ㄛ";
                case "o":
                    soundPlayerList[27 - 1].Play();
                    return "ㄟ";
                case "p":
                    soundPlayerList[31 - 1].Play();
                    return "ㄣ";
                case "a":
                    soundPlayerList[3 - 1].Play();
                    return "ㄇ";
                case "s":
                    soundPlayerList[7 - 1].Play();
                    return "ㄋ";
                case "d":
                    soundPlayerList[10 - 1].Play();
                    return "ㄎ";
                case "f":
                    soundPlayerList[13 - 1].Play();
                    return "ㄑ";
                case "g":
                    soundPlayerList[17 - 1].Play();
                    return "ㄕ";
                case "h":
                    soundPlayerList[20 - 1].Play();
                    return "ㄘ";
                case "j":
                    soundPlayerList[36 - 1].Play();
                    return "ㄨ";
                case "k":
                    soundPlayerList[24 - 1].Play();
                    return "ㄜ";
                case "l":
                    soundPlayerList[28 - 1].Play();
                    return "ㄠ";
                case ";":
                case "oemplus": // ';'のキーコードがこれになるので。
                    soundPlayerList[32 - 1].Play();
                    return "ㄤ";
                case "z":
                    soundPlayerList[4 - 1].Play();
                    return "ㄈ";
                case "x":
                    soundPlayerList[8 - 1].Play();
                    return "ㄌ";
                case "c":
                    soundPlayerList[11 - 1].Play();
                    return "ㄏ";
                case "v":
                    soundPlayerList[14 - 1].Play();
                    return "ㄒ";
                case "b":
                    soundPlayerList[18 - 1].Play();
                    return "ㄖ";
                case "n":
                    soundPlayerList[21 - 1].Play();
                    return "ㄙ";
                case "m":
                    soundPlayerList[37 - 1].Play();
                    return "ㄩ";
                case ",":
                case "oemcomma": // ','のキーコードがこれになるので。
                    soundPlayerList[25 - 1].Play();
                    return "ㄝ";
                case ".":
                case "oemperiod":
                    soundPlayerList[29 - 1].Play();
                    return "ㄡ";
                case "/":
                case "oem2":    // '/'のキーコードがこれになるので。
                    soundPlayerList[33 - 1].Play();
                    return "ㄥ";
                default:
                    return "no-match";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            soundPlayerList = new List<SoundPlayer>();
            textBoxList = new List<TextBox>();
            for (int i = 01; i <= 37; i++)
            {
                soundPlayerList.Add(new SoundPlayer("sound/" + i.ToString("00") + ".wav"));

            }

            int x = 52, y = 54;
            for (int i = 0; i <= 41; i++) {
                var txt = new TextBox();
                txt.Size = new Size(x, y);
                txt.Font = new Font("Segoe UI", 18F);
                txt.ForeColor = Color.Red;
                txt.Multiline = true;
                txt.Name = $"textBoxPro{i:00}";
                txt.TextAlign = HorizontalAlignment.Center;

                txt.Text = zhuyin_list[i];
                if (i < 11)
                {
                    txt.Location = new Point(70 + (x * i), 288);
                }
                if (11 <= i && i < 21)
                {
                    txt.Location = new Point(80 + (x * (i%11)), 288+y);
                }
                if (21 <= i && i < 31)
                {
                    txt.Location = new Point(100 + (x * (i%21)), 288+(y*2));
                }
                if (31 <= i && i <= 40)
                {
                    txt.Location = new Point(120 + (x * (i%31)), 288+(y*3));
                }
                if (41 == i)
                {
                    txt.Size = new Size(436, y);
                    txt.Location = new Point(186, 502);
                }
                Controls.Add(txt);
                txt.BringToFront();
                txt.Hide();
                textBoxList.Add(txt);
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 0)
            {
                return;
            }

            foreach (var t in textBoxList)
            {
                t.Hide();
            }

            switch (textBox2.Text[0])
            {
                case 'ㄅ':
                    textBoxList[0].Show();
                    break;
                case 'ㄉ':
                    textBoxList[1].Show();
                    break;
                case 'ˇ':
                    textBoxList[2].Show();
                    break;
                case 'ˋ':
                    textBoxList[3].Show();
                    break;
                case 'ㄓ':
                    textBoxList[4].Show();
                    break;
                case 'ˊ':
                    textBoxList[5].Show();
                    break;
                case '˙':
                    textBoxList[6].Show();
                    break;
                case 'ㄚ':
                    textBoxList[7].Show();
                    break;
                case 'ㄞ':
                    textBoxList[8].Show();
                    break;
                case 'ㄢ':
                    textBoxList[9].Show();
                    break;
                case 'ㄦ':
                    textBoxList[10].Show();
                    break;
                case 'ㄆ':
                    textBoxList[11].Show();
                    break;
                case 'ㄊ':
                    textBoxList[12].Show();
                    break;
                case 'ㄍ':
                    textBoxList[13].Show();
                    break;
                case 'ㄐ':
                    textBoxList[14].Show();
                    break;
                case 'ㄔ':
                    textBoxList[15].Show();
                    break;
                case 'ㄗ':
                    textBoxList[16].Show();
                    break;
                case 'ㄧ':
                    textBoxList[17].Show();
                    break;
                case 'ㄛ':
                    textBoxList[18].Show();
                    break;
                case 'ㄟ':
                    textBoxList[19].Show();
                    break;
                case 'ㄣ':
                    textBoxList[20].Show();
                    break;
                case 'ㄇ':
                    textBoxList[21].Show();
                    break;
                case 'ㄋ':
                    textBoxList[22].Show();
                    break;
                case 'ㄎ':
                    textBoxList[23].Show();
                    break;
                case 'ㄑ':
                    textBoxList[24].Show();
                    break;
                case 'ㄕ':
                    textBoxList[25].Show();
                    break;
                case 'ㄘ':
                    textBoxList[26].Show();
                    break;
                case 'ㄨ':
                    textBoxList[27].Show();
                    break;
                case 'ㄜ':
                    textBoxList[28].Show();
                    break;
                case 'ㄠ':
                    textBoxList[29].Show();
                    break;
                case 'ㄤ':
                    textBoxList[30].Show();
                    break;
                case 'ㄈ':
                    textBoxList[31].Show();
                    break;
                case 'ㄌ':
                    textBoxList[32].Show();
                    break;
                case 'ㄏ':
                    textBoxList[33].Show();
                    break;
                case 'ㄒ':
                    textBoxList[34].Show();
                    break;
                case 'ㄖ':
                    textBoxList[35].Show();
                    break;
                case 'ㄙ':
                    textBoxList[36].Show();
                    break;
                case 'ㄩ':
                    textBoxList[37].Show();
                    break;
                case 'ㄝ':
                    textBoxList[38].Show();
                    break;
                case 'ㄡ':
                    textBoxList[39].Show();
                    break;
                case 'ㄥ':
                    textBoxList[40].Show();
                    break;
                case 'ˉ':
                    textBoxList[41].Show();
                    break;
            }
        }
    }
}
