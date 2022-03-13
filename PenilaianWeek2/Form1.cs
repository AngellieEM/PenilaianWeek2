using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PenilaianWeek2
{
    public partial class FormPengaturanWarna : Form
    {
        public FormPengaturanWarna()
        {
            InitializeComponent();
        }

        private void ButtonProses_Click(object sender, EventArgs e)
        {
            WorkSystem();
        }
        public void WorkSystem()
        {
            //ketentuan isi
            string FirstTry = "";
            FirstTry = TextBoxInputData.Text;
            string[] LastText = FirstTry.Split(':');
            if (FirstTry.Contains(':'))
            {
                LastText[0] = LastText[0].ToUpper();
                LastText[1] = LastText[1].ToUpper();
            }
            else
            {
                FirstTry = FirstTry.ToUpper();
            }
            if (LastText[0] == "ISI")
            {
                string text = "";
                text = TextBoxInputData.Text;
                string[] TextAkhir = text.Split(':');
                LabelOutputData.Text = TextAkhir[1];
            }
            else if (FirstTry == "SHOWN")
            {
                //shown option
                LabelOutputData.Show();
            }
            else if (FirstTry == "HIDE")
            {
                //hide option
                LabelOutputData.Hide();
            }
            else if (LastText[0] == "WARNA")
            {
                //changing the text's colour : Defaul (hitam), Merah, Hijau, Biru, Kuning, Ungu, Jingga
                if (LastText[1].Contains("DEFAULT"))
                {
                    LabelOutputData.ForeColor = Color.Black;
                }
                else if (LastText[1].Contains("MERAH"))
                {
                    LabelOutputData.ForeColor = Color.Red;
                }
                else if (LastText[1].Contains("HIJAU"))
                {
                    LabelOutputData.ForeColor = Color.Green;
                }
                else if (LastText[1].Contains("BIRU"))
                {
                    LabelOutputData.ForeColor = Color.Blue;
                }
                else if (LastText[1].Contains("KUNING"))
                {
                    LabelOutputData.ForeColor = Color.Yellow;
                }
                else if (LastText[1].Contains("UNGU"))
                {
                    LabelOutputData.ForeColor = Color.Purple;
                }
                else if (LastText[1].Contains("JINGGA"))
                {
                    LabelOutputData.ForeColor = Color.Orange;
                }
            }
            else if (FirstTry == "RESTART")
            {
                //restart option
                LabelOutputData.Text = "[EMPTY]";
                LabelOutputData.ForeColor = Color.Black;
                LabelOutputData.Font = new Font("Times New Rowman", 12F);
            }
            else if (FirstTry == "BESARKAN")
            {
                //make the santences or word bigger
                LabelOutputData.Font = ChangeFontSize(LabelOutputData.Font, LabelOutputData.Font.Size + 3);
            }
            else if (FirstTry == "KECILKAN")
            {
                //make the santences or word smaller
                LabelOutputData.Font = ChangeFontSize(LabelOutputData.Font, LabelOutputData.Font.Size - 3);
            }
            else
            {
                //showing the maessage box 
                MessageBox.Show("Syntax tidak terdaftar!");
            }
        }
        static public Font ChangeFontSize(Font font, float fontSize)
        {
            if (font != null)
            {
                //for changing font size
                float currentSize = font.Size;
                if (currentSize != fontSize)
                {
                    font = new Font(font.Name, fontSize, font.Style, font.Unit, font.GdiCharSet, font.GdiVerticalFont);
                }
            }
            return font;
        }
    }
}
