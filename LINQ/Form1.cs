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
    public partial class Form1 : Form
    {
        int[] sayilar = { -9, 14, 7, -54, 89, -25, 16 };
        List<string> isimler = new List<string>();
        public Form1()
        {
            InitializeComponent();
            isimler.Add("Buket");
            isimler.Add("Mevlüt");
            isimler.Add("Çınar");
            isimler.Add("Adem");
            isimler.Add("Dicle");
        }

        private void btn_AllNumbers_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = sayilar.ToList();
        }

        private void btn_Negatif_Click(object sender, EventArgs e)
        {
            //lambda expression
            // => lambda

            //Foreach ile dolaşabildiğimiz generic bir interface
            IEnumerable<int> n = sayilar.Where(birsey => birsey < 0);
            listBox1.DataSource = null;
            listBox1.DataSource = n.ToList();
        }

        private void btn_Pozitif_Click(object sender, EventArgs e)
        {
            IEnumerable<int> p = sayilar.Where(birsey => birsey > 0);
            listBox1.DataSource = null;
            listBox1.DataSource = p.ToList();
        }

        private void btn_Cıft_Click(object sender, EventArgs e)
        {
            IEnumerable<int> c = sayilar.Where(x => x % 2 == 0);
            listBox1.DataSource = null;
            listBox1.DataSource = c.ToList();
        }

        private void btn_Tek_Click(object sender, EventArgs e)
        {
            IEnumerable<int> t = sayilar.Where(x => x % 2 != 0);
            listBox1.DataSource = null;
            listBox1.DataSource = t.ToList();
        }

        private void btn_EnKucuk_Click(object sender, EventArgs e)
        {
            int k = sayilar.Min();
            MessageBox.Show(k.ToString());
        }

        private void btn_EnBuyuk_Click(object sender, EventArgs e)
        {
            int b = sayilar.Max();
            MessageBox.Show(b.ToString());
        }

        private void btn_KacTane_Click(object sender, EventArgs e)
        {
            int kacTane = sayilar.Length; //tercih --->daha hızlı 
            int kacTane2 = sayilar.Count(); //aynı işi yapıyolar
            MessageBox.Show(kacTane.ToString());
        }

        private void btn_AllNames_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = isimler.ToList();
        }

        private void btn_Alfabetik_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            //IOrderedEnumerable<string> sirali = isimler.OrderBy(x => x);
            listBox1.DataSource = isimler.OrderBy(x => x).ToList(); // ToList() -> List<string>
        }

        private void btn_AlfabetikTers_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = isimler.OrderByDescending(x => x).ToList();
        }

        private void btn_Uzunluklar_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = isimler.Select(x => x + " " + x.Length).ToList();
        }

        private void btn_tBarındıran_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = isimler.Where(x => x.Contains("t")).ToList();

        }

        private void btn_cileBaslayan_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = isimler.Where(x => x.StartsWith("Ç")).ToList();
        }

        List<Order> orders = new Order().GetOrders();
        private void btn_AllOrders_Click(object sender, EventArgs e)
        {
            //--->Tek bir alan seçilecekse
            //var gorunen = orders.Select(satir => satir.EmployeeID); 

            //--->Birden fazla alan seçilecekse
            var gorunen = orders.Select(satir => new
            {
                SiparisNo = satir.OrderID,
                Tarih = satir.OrderDate,
                Musteri = satir.Customer.ContactName
            });

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = gorunen.ToList();
        }

        private void btn_SadeceTarihler_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = orders.Select(x=> x.OrderDate).ToList();
        }

        private void btn_Ilk5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            //orders.Skip(10).Take(5) ---> 10 kayıt atla sıradaki 5 kaydı al
            dataGridView1.DataSource = orders.Take(5)
                .Select(x=> new
                {
                    x.OrderID,
                    x.Customer.ContactName,
                    x.OrderDate

                })
                .ToList();
        }

        private void btn_Son5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = orders
                .OrderByDescending(x => x.OrderID)
                .Take(5)
                .Select(x=> new
                {
                    x.OrderID,
                    x.Customer.ContactName,
                    x.OrderDate
                })
                .ToList();
        }

        private void btn_YangWang_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = orders
                .Where(x => x.Customer.ContactName == "Yang Wang")
                .ToList();
        }

        private void btn_SiparisSayisi_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            int sayi = orders.Count; //tercih
            //int sayi2 = orders.Count();
            MessageBox.Show(sayi.ToString());
        }
    }
}
