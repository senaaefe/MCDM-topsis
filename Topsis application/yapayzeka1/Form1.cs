using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Collections;
/*
 BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ
 YAPAY ZEKA ÖDEVİ
 KUTAY UZUNÇELEBİ B161200050
 SENA EFE B161200046

 */

namespace yapayzeka1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double b, n, m, o;

            double q,w,r,t,y,i,p,a,s,d,f,g,h,j,k,l,z,x,c,v;
           
            double q1, w1, r1, t1, y1, i1, p1, a1, s1, d1, f1, g1, h1, j1, k1, l1, z1, x1, c1, v1;

            double q12, w12, r12, t12, y12, i12, p12, a12, s12, d12, f12, g12, h12, j12, k12, l12, z12, x12, c12, v12;

            double vv1, vv2, vv3, vv4, vv5, vv6, vv7, vv8;

            double ss1, ss2, ss3, ss4, ss5, ss6, ss7, ss8,ss9, ss10, ss11, ss12, ss13, ss14, ss15, ss16, ss17, ss18, ss19, ss20,ss21,ss22,ss23,ss24,ss25,ss26,ss27,ss28;
            double ss29, ss30, ss31, ss32, ss33, ss34, ss35, ss36, ss37, ss38, ss39, ss40;
            double sss12, sss22, sss32, ss42, ss52, ss62, ss72, ss82,ss92,ss102;

            double sonuc1,sonuc2,sonuc3,sonuc4,sonuc5,maksdeger;

            double maks1, maks2, maks3, maks4, maks5, maks6, maks7, maks8, maks9, maks10, maks11, maks12,maks13,maks14,maks15;
            double min1, min2, min3, min4, min5, min6, min7, min8, min9, min10, min11, min12;
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "" || textBox9.Text == "" || textBox10.Text == "" || textBox11.Text == "" || textBox12.Text == "" || textBox13.Text == "" || textBox14.Text == "" || textBox15.Text == "" || textBox16.Text == "" || textBox17.Text == "" || textBox18.Text == "" || textBox19.Text == "" || textBox20.Text == "" || textBox21.Text == "" || textBox22.Text == "" || textBox23.Text == "" || textBox24.Text == "")
            { MessageBox.Show("Lütfen boş alan bırakmayınız.!"); 
            } else
             
            { 
            //karar matrisi           
            q = Convert.ToDouble(textBox1.Text);
            w = Convert.ToDouble(textBox2.Text);
            r = Convert.ToDouble(textBox3.Text);
            t = Convert.ToDouble(textBox4.Text);
            y = Convert.ToDouble(textBox5.Text);

            i = Convert.ToDouble(textBox6.Text);
            p = Convert.ToDouble(textBox7.Text);
            a = Convert.ToDouble(textBox8.Text);
            s = Convert.ToDouble(textBox9.Text);
            d = Convert.ToDouble(textBox10.Text);

            f = Convert.ToDouble(textBox11.Text);
            g = Convert.ToDouble(textBox12.Text);
            h = Convert.ToDouble(textBox13.Text);
            j = Convert.ToDouble(textBox14.Text);
            k = Convert.ToDouble(textBox15.Text);

            l = Convert.ToDouble(textBox16.Text);
            z = Convert.ToDouble(textBox17.Text);
            x = Convert.ToDouble(textBox18.Text);
            c = Convert.ToDouble(textBox19.Text);
            v = Convert.ToDouble(textBox20.Text);

            b = Convert.ToDouble(textBox21.Text);
            n = Convert.ToDouble(textBox22.Text);
            m = Convert.ToDouble(textBox23.Text);
            o = Convert.ToDouble(textBox24.Text);
           
            Boolean f11, d11, k11, r11;
                double f132 = Convert.ToDouble(textBox21.Text);
                double d132 = Convert.ToDouble(textBox22.Text);
                double k132 = Convert.ToDouble(textBox23.Text);
                double r132 = Convert.ToDouble(textBox24.Text);

                if (f132 > 1 || f132 < 0)

                {
                    MessageBox.Show("Lütfen 0 ile 1 arasında bir değer giriniz. (Fiyat Oranı)");
                    f11 = false;
                }
                else f11 = true;

                if (d132 > 1 || d132 < 0)
                {
                    MessageBox.Show("Lütfen 0 ile 1 arasında bir değer giriniz. (Dahili Hafıza Oranı)");
                    d11 = false;
                }
                else d11 = true;

                if (k132 > 1 || k132 < 0)
                {
                    MessageBox.Show("Lütfen 0 ile 1 arasında bir değer giriniz. (Kamera Oranı)");
                    k11 = false;
                }
                else k11 = true;

                if (r132 > 1 || r132 < 0)
                {
                    MessageBox.Show("Lütfen 0 ile 1 arasında bir değer giriniz. (Ram Oranı)");
                    r11 = false;
                }
                else r11 = true;

                if (f11 == true && d11 == true && k11 == true && r11 == true)
                {
                    if (f132 + d132 + k132 + r132 > 1 || f132 + d132 + k132 + r132 < 0)

                        MessageBox.Show("Lütfen oranlar toplamı 1 olacak şekilde düzenleme yapınız.");

                    else { 
                    MessageBox.Show("TOPSIS başarılı şekilde çalıştı.");
                    
                

              
            
            //normalizasyon matrisi

            q1 =Convert.ToDouble(q / Math.Sqrt(Math.Pow(q, 2) + Math.Pow(w, 2) + Math.Pow(r, 2) + Math.Pow(t, 2) + Math.Pow(y,2)));
            w1 = Convert.ToDouble(w / Math.Sqrt(Math.Pow(q, 2) + Math.Pow(w, 2) + Math.Pow(r, 2) + Math.Pow(t, 2) + Math.Pow(y, 2)));
            r1 = Convert.ToDouble(r / Math.Sqrt(Math.Pow(q, 2) + Math.Pow(w, 2) + Math.Pow(r, 2) + Math.Pow(t, 2) + Math.Pow(y, 2)));
            t1 = Convert.ToDouble(t / Math.Sqrt(Math.Pow(q, 2) + Math.Pow(w, 2) + Math.Pow(r, 2) + Math.Pow(t, 2) + Math.Pow(y, 2)));
            y1 = Convert.ToDouble(y / Math.Sqrt(Math.Pow(q, 2) + Math.Pow(w, 2) + Math.Pow(r, 2) + Math.Pow(t, 2) + Math.Pow(y, 2)));
            
            i1 = Convert.ToDouble(i / Math.Sqrt(Math.Pow(i, 2) + Math.Pow(p, 2) + Math.Pow(a, 2) + Math.Pow(s, 2) + Math.Pow(d, 2)));
            p1 = Convert.ToDouble(p / Math.Sqrt(Math.Pow(i, 2) + Math.Pow(p, 2) + Math.Pow(a, 2) + Math.Pow(s, 2) + Math.Pow(d, 2)));
            a1 = Convert.ToDouble(a / Math.Sqrt(Math.Pow(i, 2) + Math.Pow(p, 2) + Math.Pow(a, 2) + Math.Pow(s, 2) + Math.Pow(d, 2)));
            s1 = Convert.ToDouble(s / Math.Sqrt(Math.Pow(i, 2) + Math.Pow(p, 2) + Math.Pow(a, 2) + Math.Pow(s, 2) + Math.Pow(d, 2)));
            d1 = Convert.ToDouble(d / Math.Sqrt(Math.Pow(i, 2) + Math.Pow(p, 2) + Math.Pow(a, 2) + Math.Pow(s, 2) + Math.Pow(d, 2)));            

            f1 = Convert.ToDouble(f / Math.Sqrt(Math.Pow(f, 2) + Math.Pow(g, 2) + Math.Pow(h, 2) + Math.Pow(j, 2) + Math.Pow(k, 2)));
            g1 = Convert.ToDouble(g / Math.Sqrt(Math.Pow(f, 2) + Math.Pow(g, 2) + Math.Pow(h, 2) + Math.Pow(j, 2) + Math.Pow(k, 2)));
            h1 = Convert.ToDouble(h / Math.Sqrt(Math.Pow(f, 2) + Math.Pow(g, 2) + Math.Pow(h, 2) + Math.Pow(j, 2) + Math.Pow(k, 2)));
            j1 = Convert.ToDouble(j / Math.Sqrt(Math.Pow(f, 2) + Math.Pow(g, 2) + Math.Pow(h, 2) + Math.Pow(j, 2) + Math.Pow(k, 2)));
            k1 = Convert.ToDouble(k / Math.Sqrt(Math.Pow(f, 2) + Math.Pow(g, 2) + Math.Pow(h, 2) + Math.Pow(j, 2) + Math.Pow(k, 2)));
          
            l1 = Convert.ToDouble(l / Math.Sqrt(Math.Pow(l, 2) + Math.Pow(z, 2) + Math.Pow(x, 2) + Math.Pow(c, 2) + Math.Pow(v, 2)));
            z1 = Convert.ToDouble(z / Math.Sqrt(Math.Pow(l, 2) + Math.Pow(z, 2) + Math.Pow(x, 2) + Math.Pow(c, 2) + Math.Pow(v, 2)));
            x1 = Convert.ToDouble(x / Math.Sqrt(Math.Pow(l, 2) + Math.Pow(z, 2) + Math.Pow(x, 2) + Math.Pow(c, 2) + Math.Pow(v, 2)));
            c1 = Convert.ToDouble(c / Math.Sqrt(Math.Pow(l, 2) + Math.Pow(z, 2) + Math.Pow(x, 2) + Math.Pow(c, 2) + Math.Pow(v, 2)));
            v1 = Convert.ToDouble(v / Math.Sqrt(Math.Pow(l, 2) + Math.Pow(z, 2) + Math.Pow(x, 2) + Math.Pow(c, 2) + Math.Pow(v, 2)));

            //karar adımı

            q12 = Convert.ToDouble(q1*b);
            w12= Convert.ToDouble(w1 * b);
            r12 = Convert.ToDouble(r1 * b);
            t12 = Convert.ToDouble(t1 * b);
            y12 = Convert.ToDouble(y1 * b);

            i12 = Convert.ToDouble(i1 * n);
            p12 = Convert.ToDouble(p1 * n);
            a12 = Convert.ToDouble(a1 * n);
            s12 = Convert.ToDouble(s1 * n);
            d12 = Convert.ToDouble(d1 * n);

            f12 = Convert.ToDouble(f1 * m);
            g12 = Convert.ToDouble(g1 * m);
            h12 = Convert.ToDouble(h1 * m);
            j12 = Convert.ToDouble(j1 * m);
            k12 = Convert.ToDouble(k1 * m);

            l12 = Convert.ToDouble(l1 * o);
            z12 = Convert.ToDouble(z1 * o);
            x12 = Convert.ToDouble(x1 * o);
            c12 = Convert.ToDouble(c1 * o);
            v12 = Convert.ToDouble(v1 * o);

         //S+ S- hesaplama   v V+ V- hesaplama
            
                min1 = Math.Min(q12, w12);
                min2 = Math.Min(min1, r12);
                min3 = Math.Min(min2, t12);
                vv2 = Math.Min(min3, y12);

                maks1 = Math.Max(q12, w12);
                maks2 = Math.Max(maks1,r12);
                maks3 = Math.Max(maks2, t12);
                vv1 = Math.Max(maks3, y12);

                ss1 = Convert.ToDouble(Math.Pow((q12 - vv2), 2));
                ss2 = Convert.ToDouble(Math.Pow((q12 - vv1), 2));

                ss9= Convert.ToDouble(Math.Pow((w12 - vv2), 2));
                ss10= Convert.ToDouble(Math.Pow((w12 - vv1), 2));

                ss17 = Convert.ToDouble(Math.Pow((r12 - vv2), 2));
                ss18 = Convert.ToDouble(Math.Pow((r12 - vv1), 2));

                ss25 = Convert.ToDouble(Math.Pow((t12 - vv2), 2));
                ss26 = Convert.ToDouble(Math.Pow((t12 - vv1), 2));

                ss33= Convert.ToDouble(Math.Pow((y12 - vv2), 2));
                ss34= Convert.ToDouble(Math.Pow((y12 - vv1), 2));








                maks4 = Math.Max(i12, p12);
                maks5 = Math.Max(maks4, a12);
                maks6 = Math.Max(maks5, s12);
                vv4 = Math.Max(maks6, d12);

                min4 = Math.Min(i12, p12);
                min5 = Math.Min(min4, a12);
                min6 = Math.Min(min5, s12);
                vv3 = Math.Min(min6, d12);

                ss3 = Convert.ToDouble(Math.Pow((i12 - vv4), 2));
                ss4 = Convert.ToDouble(Math.Pow((i12 - vv3), 2));

                ss11= Convert.ToDouble(Math.Pow((p12 - vv4), 2));
                ss12 = Convert.ToDouble(Math.Pow((p12 - vv3), 2));

                ss19 = Convert.ToDouble(Math.Pow((a12 - vv4), 2));
                ss20 = Convert.ToDouble(Math.Pow((a12 - vv3), 2));

                ss27 = Convert.ToDouble(Math.Pow((s12 - vv4), 2));
                ss28 = Convert.ToDouble(Math.Pow((s12 - vv3), 2));

                ss35 = Convert.ToDouble(Math.Pow((d12 - vv4), 2));
                ss36 = Convert.ToDouble(Math.Pow((d12 - vv3), 2));






                maks7 = Math.Max(f12, g12);
                maks8 = Math.Max(maks7, h12);
                maks9 = Math.Max(maks8, j12);
                vv6 = Math.Max(maks9, k12);

                min7 = Math.Min(f12, g12);
                min8 = Math.Min(min7, h12);
                min9 = Math.Min(min8, j12);
                vv5 = Math.Min(min9, k12);

                ss5 = Convert.ToDouble(Math.Pow((f12 - vv6), 2));
                ss6 = Convert.ToDouble(Math.Pow((f12 - vv5), 2));

                ss13 = Convert.ToDouble(Math.Pow((g12 - vv6), 2));
                ss14 = Convert.ToDouble(Math.Pow((g12 - vv5), 2));

                ss21 = Convert.ToDouble(Math.Pow((h12 - vv6), 2));
                ss22 = Convert.ToDouble(Math.Pow((h12 - vv5), 2));

                ss29 = Convert.ToDouble(Math.Pow((j12 - vv6), 2));
                ss30 = Convert.ToDouble(Math.Pow((j12 - vv5), 2));

                ss37 = Convert.ToDouble(Math.Pow((k12 - vv6), 2));
                ss38 = Convert.ToDouble(Math.Pow((k12 - vv5), 2));






                maks10 = Math.Max(l12, z12);
                maks11 = Math.Max(maks10, x12);
                maks12 = Math.Max(maks11, c12);
                vv8 = Math.Max(maks12, v12);

                min10 = Math.Min(l12, z12);
                min11 = Math.Min(min10, x12);
                min12 = Math.Min(min11, c12);
                vv7 = Math.Min(min12, v12);

                ss7 = Convert.ToDouble(Math.Pow((l12 - vv8), 2));
                ss8 = Convert.ToDouble(Math.Pow((l12 - vv7), 2));
                

                ss15 = Convert.ToDouble(Math.Pow((z12 - vv8), 2));
                ss16 = Convert.ToDouble(Math.Pow((z12 - vv7), 2));

                ss23 = Convert.ToDouble(Math.Pow((x12 - vv8), 2));
                ss24 = Convert.ToDouble(Math.Pow((x12 - vv7), 2));

                ss31 = Convert.ToDouble(Math.Pow((c12 - vv8), 2));
                ss32 = Convert.ToDouble(Math.Pow((c12 - vv7), 2));

               ss39 = Convert.ToDouble(Math.Pow((v12 - vv8), 2));
               ss40 = Convert.ToDouble(Math.Pow((v12 - vv7), 2));





            sss12 = Convert.ToDouble(Math.Sqrt(ss1+ss3+ss5+ss7));
            sss22= Convert.ToDouble(Math.Sqrt(ss2+ss4+ss6+ss8));
            sonuc1 = Convert.ToDouble(sss22/(sss12+sss22));




            sss32 = Convert.ToDouble(Math.Sqrt(ss9 + ss11 + ss13 + ss15));
            ss42 = Convert.ToDouble(Math.Sqrt(ss10 + ss12 + ss14 + ss16));
            sonuc2 = Convert.ToDouble(ss42/(sss32+ss42));


            ss52 = Convert.ToDouble(Math.Sqrt(ss17 + ss19 + ss21 + ss23));
            ss62 = Convert.ToDouble(Math.Sqrt(ss18 + ss20 + ss22 + ss24));
            sonuc3 = Convert.ToDouble(ss62/(ss52+ss62));


            ss72 = Convert.ToDouble(Math.Sqrt(ss25 + ss27 + ss29 + ss31));
            ss82= Convert.ToDouble(Math.Sqrt(ss26 + ss28 + ss30 + ss32));
            sonuc4 = Convert.ToDouble(ss82/(ss72+ss82));


            ss92 = Convert.ToDouble(Math.Sqrt(ss33 + ss35 + ss37 + ss39));
            ss102 = Convert.ToDouble(Math.Sqrt(ss34 + ss36 + ss38 + ss40));
            sonuc5 = Convert.ToDouble(ss102/(ss92+ss102));


            maks13 = Math.Max(sonuc1, sonuc2);
            maks14 = Math.Max(maks13, sonuc3);
            maks15= Math.Max(maks14, sonuc4);
            maksdeger = Math.Max(maks15, sonuc5);

                       

            listBox1.Items.Clear();

            listBox1.Items.Add(sonuc1);
            listBox1.Items.Add(sonuc2);
            listBox1.Items.Add(sonuc3);
            listBox1.Items.Add(sonuc4);
            listBox1.Items.Add(sonuc5);

            { //Azalan Z-A Sıralama
                ArrayList list = new ArrayList();
                foreach (object x78 in listBox1.Items)
                {
                    list.Add(x78);
                }
                list.Sort();
                list.Reverse();
                listBox1.Items.Clear();
                foreach (object x78 in list)
                {
                    listBox1.Items.Add(x78);
                }
            }

            listBox2.Items.Clear();

            if (maksdeger==sonuc1)
            {
                listBox2.Items.Add(label1.Text);
            
            }

            if (maksdeger == sonuc2)
            {
                listBox2.Items.Add(label2.Text);
            }

            if (maksdeger == sonuc3)
            {
                listBox2.Items.Add(label3.Text);
            }

            if (maksdeger == sonuc4)
            {
                listBox2.Items.Add(label4.Text);
            }

            if (maksdeger == sonuc5)
            {
                listBox2.Items.Add(label5.Text);
            }

                    }
                }
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {
            
        }

        
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox tbox = (TextBox)item;
                    tbox.Clear();
                }
            }
            listBox1.Items.Clear();
            listBox2.Items.Clear();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
