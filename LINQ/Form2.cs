using LINQ.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ
{
    public partial class Form2 : Form
    {
        List<Personel> liste = new List<Personel>();
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_NewEmployee_Click(object sender, EventArgs e)
        {
            liste.Add(new Personel());

            string psayi = liste.Count.ToString();
            lbl_EmployeeCount.Text = Resources.sablon1.Replace("0", psayi);

            string ort = liste.Average(x => x.Maas).ToString("C"); // C --> para birimi olduğunu belirtir. 
            lbl_AvgSalary.Text = Resources.sablon2.Replace("0", ort);
            Personel son= liste.Last();
            lbl_Age.Text = Resources.sablon3.Replace("0", son.Yas.ToString());
            lbl_Salary.Text = Resources.sablon4.Replace("0", son.Maas.ToString());
        }
    }
}
