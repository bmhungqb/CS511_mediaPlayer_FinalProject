using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace MediaPlayer
{
    public partial class acc_edit : UserControl
    {
        public acc_edit()
        {
            InitializeComponent();
        }
        private void acc_edit_Load(object sender, EventArgs e)
        {
            BackColor = Color.Transparent;
            using (StreamReader sr = new StreamReader(Path.Combine(user.x.name, "infor.txt")))
            {
                string s = sr.ReadLine();
                string[] s1 = s.Split('\t');
                tb_name.Text = s1[0];
                string[] birth = s1[3].Split('/');
                day.Text = birth[0];
                month.Text = birth[1];
                year.Text = birth[2];
                gender.Text = s1[2];
                tb_email.Text = s1[1];
                password.Text = s1[4];
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            File.WriteAllText(Path.Combine(user.x.name, "infor.txt"), string.Empty);
            using (StreamWriter sw = new StreamWriter(Path.Combine(user.x.name, "infor.txt")))
            {
                string birth = day.SelectedItem.ToString() + "/" + month.SelectedItem.ToString() + "/" + year.Text;
                string s = tb_name.Text + "\t" + tb_email.Text + "\t" + gender.SelectedItem.ToString() + "\t" + 
                    birth + "\t" + password.Text + "\t";
                sw.WriteLine(s);
            }
            MessageBox.Show("Save success!");
        }
    }
}
