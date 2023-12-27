using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Drawing.Imaging;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace oop_pt2
{
    public partial class Form1 : Form
    {

        public string IspravnaSifra;
        public int KolicinaPara = 0;
        public int novac;
        public int kredit;
        public int br1;
        public double t;
        public int br2 = -1;
        public int br3 = -1;
        public int br4 = 1;
        public int kbr1, kbr2, kbr3, kbr4, kbr5, kbr6, kbr7, kbr8, kbr9;
        public int pbr1, pbr2, pbr3, pbr4, pbr5, pbr6, pbr7, pbr8, pbr9;
        public int zvake, cips, kinder_jaje;
        public int vlasnik = 0;
        public int cena, cena1, cena2, cena3;
        private int artikal = 0;
        public int[] brojevi;
        public int n, glavniBroj, p, j, l, flag, m;
        public int KolicinaPara1, uk, cips1, zvake1, kinder_jaje1;

        public Form1()
        {
            InitializeComponent();
            textBox3.ReadOnly = true;
            textBox3.Enabled = false;
            textBox5.ReadOnly = true;
            textBox5.Enabled = false;
            textBox6.ReadOnly = true;
            textBox6.Enabled = false;
            textBox7.ReadOnly = true;
            textBox7.Enabled = false;
            textBox8.ReadOnly = true;
            textBox8.Enabled = false;
            textBox9.ReadOnly = true;
            textBox9.Enabled = false;
            textBox10.ReadOnly = true;
            textBox10.Enabled = false;
            textBox11.ReadOnly = true;
            textBox11.Enabled = false;
            textBox12.ReadOnly = true;
            textBox12.Enabled = false;
            textBox13.ReadOnly = true;
            textBox13.Enabled = false;
            textBox14.ReadOnly = true;
            textBox14.Enabled = false;
            textBox15.ReadOnly = true;
            textBox15.Enabled = false;
            textBox16.ReadOnly = true;
            textBox16.Enabled = false;
            textBox17.ReadOnly = true;
            textBox17.Enabled = false;
            textBox18.ReadOnly = true;
            textBox18.Enabled = false;
            brojevi = [kbr9, kbr8, kbr7, kbr6, kbr5, kbr4, kbr3, kbr2, kbr1];
            pbr1 = kbr1;
            pbr2 = kbr2;
            pbr3 = kbr3;
            pbr4 = kbr4;
            pbr5 = kbr5;
            pbr6 = kbr6;
            pbr7 = kbr7;
            pbr8 = kbr8;
            pbr9 = kbr9;
            KolicinaPara1 = KolicinaPara;
            uk = 0;
            textBox4.ReadOnly = true;
            IspravnaSifra = "123";

            if (int.TryParse(textBox4.Text, out int p1))
            {
                p = p1;
            }
            j = 0;
            m = n + 1;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string text = textBox1.Text;
        }

        private void dalisivlasnik(object sender, EventArgs e)
        {
            string unetaSifra = textBox1.Text;

            if (unetaSifra == IspravnaSifra)
            {
                vlasnik = 1;
                MessageBox.Show("Ispravna šifra!", "Provera šifre", MessageBoxButtons.OK, MessageBoxIcon.Information);

                textBox3.ReadOnly = false;
                textBox3.Enabled = true;
                textBox5.ReadOnly = false;
                textBox5.Enabled = true;
                textBox6.ReadOnly = false;
                textBox6.Enabled = true;
                textBox7.ReadOnly = false;
                textBox7.Enabled = true;
                textBox8.ReadOnly = false;
                textBox8.Enabled = true;
                textBox9.ReadOnly = false;
                textBox9.Enabled = true;
                textBox10.ReadOnly = false;
                textBox10.Enabled = true;
                textBox11.ReadOnly = false;
                textBox11.Enabled = true;
                textBox12.ReadOnly = false;
                textBox12.Enabled = true;
                textBox13.ReadOnly = false;
                textBox13.Enabled = true;
                textBox14.ReadOnly = false;
                textBox14.Enabled = true;
                textBox15.ReadOnly = false;
                textBox15.Enabled = true;
                textBox16.ReadOnly = false;
                textBox16.Enabled = true;
                textBox17.ReadOnly = false;
                textBox17.Enabled = true;
                textBox18.ReadOnly = false;
                textBox18.Enabled = true;


            }
            else
            {
                vlasnik = 0;
                MessageBox.Show("Pogrešna šifra. Pokušajte ponovo.", "Provera šifre", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox3.ReadOnly = true;
                textBox3.Enabled = false;
                textBox5.ReadOnly = true;
                textBox5.Enabled = false;
                textBox6.ReadOnly = true;
                textBox6.Enabled = false;
                textBox7.ReadOnly = true;
                textBox7.Enabled = false;
                textBox8.ReadOnly = true;
                textBox8.Enabled = false;
                textBox9.ReadOnly = true;
                textBox9.Enabled = false;
                textBox10.ReadOnly = true;
                textBox10.Enabled = false;
                textBox11.ReadOnly = true;
                textBox11.Enabled = false;
                textBox12.ReadOnly = true;
                textBox12.Enabled = false;
                textBox13.ReadOnly = true;
                textBox13.Enabled = false;
                textBox14.ReadOnly = true;
                textBox14.Enabled = false;
                textBox15.ReadOnly = true;
                textBox15.Enabled = false;
                textBox16.ReadOnly = true;
                textBox16.Enabled = false;
                textBox17.ReadOnly = true;
                textBox17.Enabled = false;
                textBox18.ReadOnly = true;
                textBox18.Enabled = false;
            }
        }

        private void unospara(object sender, EventArgs e)
        {
            string text2 = textBox2.Text;
            if (textBox2.Text != "")
            {
                if (textBox2.Text != "500")
                {
                    if (textBox2.Text != "200")
                    {
                        if (textBox2.Text != "100")
                        {
                            if (textBox2.Text != "50")
                            {
                                if (textBox2.Text != "20")
                                {
                                    if (textBox2.Text != "10")
                                    {
                                        if (textBox2.Text != "5")
                                        {
                                            if (textBox2.Text != "2")
                                            {
                                                if (textBox2.Text != "1")
                                                {
                                                    MessageBox.Show("Unesite pravi broj novcanice");
                                                }

                                            }

                                        }

                                    }

                                }
                            }
                        }
                    }
                }

            }
        }

        private void uzmipare(object sender, EventArgs e)
        {
            label7.Text = string.Empty;
            zvake1 = 0;
            cips1 = 0;
            kinder_jaje1 = 0;
            if (double.TryParse(textBox18.Text, out double w1))
            {
                t = w1;

            }
            if (DateTime.Now.DayOfWeek == DayOfWeek.Thursday)
            {
                t *= 0.8;
                textBox18.Text = t.ToString();
            }

            if (int.TryParse(textBox2.Text, out int w))
            {
                if (novac > 501)
                    MessageBox.Show("imas li sitnije");
                else
                {
                    novac = w;
                    textBox4.ReadOnly = true;
                    KolicinaPara = KolicinaPara + novac;
                    textBox4.Text = KolicinaPara.ToString();
                    if (novac != 500)
                    {
                        if (novac != 200)
                        {
                            if (novac != 100)
                            {
                                if (novac != 50)
                                {
                                    if (novac != 20)
                                    {
                                        if (novac != 10)
                                        {
                                            if (novac != 5)
                                            {
                                                if (novac != 2)
                                                {
                                                    kbr9 = kbr9 + 1;
                                                    brojevi[0] = kbr9;
                                                    textBox15.Text = kbr9.ToString();
                                                }
                                                else
                                                {
                                                    kbr8 = kbr8 + 1;
                                                    brojevi[1] = kbr8;
                                                    textBox14.Text = kbr8.ToString();

                                                }

                                            }
                                            else
                                            {
                                                kbr7 = kbr7 + 1;
                                                brojevi[2] = kbr7;
                                                textBox13.Text = kbr7.ToString();
                                            }

                                        }
                                        else
                                        {
                                            kbr6 = kbr6 + 1;
                                            brojevi[3] = kbr6;
                                            textBox12.Text = kbr6.ToString();
                                        }

                                    }
                                    else
                                    {
                                        kbr5 = kbr5 + 1;
                                        brojevi[4] = kbr5;
                                        textBox11.Text = kbr5.ToString();
                                    }
                                }
                                else
                                {
                                    kbr4 = kbr4 + 1;
                                    brojevi[5] = kbr4;
                                    textBox10.Text = kbr4.ToString();
                                }
                            }
                            else
                            {
                                kbr3 = kbr3 + 1;
                                brojevi[6] = kbr3;
                                textBox9.Text = kbr3.ToString();
                            }
                        }
                        else
                        {
                            kbr2 = kbr2 + 1;
                            brojevi[7] = kbr2;
                            textBox8.Text = kbr2.ToString();
                        }

                    }
                    else
                    {
                        kbr1 = kbr1 + 1;
                        brojevi[8] = kbr1;
                        textBox7.Text = kbr1.ToString();
                    }

                    novac = 0;
                }
            }
            else
            {
                MessageBox.Show("Unesi ceo broj");
            }
            pbr1 = kbr1;
            pbr2 = kbr2;
            pbr3 = kbr3;
            pbr4 = kbr4;
            pbr5 = kbr5;
            pbr6 = kbr6;
            pbr7 = kbr7;
            pbr8 = kbr8;
            pbr9 = kbr9;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void artikal1(object sender, EventArgs e)
        {
            if (int.TryParse(textBox18.Text, out int w18))
            {
                cena1 = w18;
            }
            else
            {
                MessageBox.Show("Uneta vrednost nije validan broj.");
            }
            artikal = 1;
            cena = cena1;


        }

        private void artikal2(object sender, EventArgs e)
        {
            if (int.TryParse(textBox17.Text, out int w17))
            {
                cena2 = w17;
            }
            else
            {
                MessageBox.Show("Uneta vrednost nije validan broj.");
            }
            cena = cena2;
            artikal = 2;

        }

        private void artikal3(object sender, EventArgs e)
        {
            if (int.TryParse(textBox16.Text, out int w16))
            {
                cena3 = w16;
            }
            else
            {
                MessageBox.Show("Uneta vrednost nije validan broj.");
            }
            cena = cena3;
            artikal = 3;
        }

        private void Ok(object sender, EventArgs e)
        {

            if (cena <= KolicinaPara)
            {
                //1 artikal
                if (vlasnik == 0)
                {

                    textBox3.Text = br1.ToString();
                    if (artikal == 1 && br1 > 0)
                    {
                        br1 = br1 - 1;
                        textBox3.Text = br1.ToString();
                        zvake = zvake + 1;
                        zvake1 = zvake1 + 1;
                    }
                    else if (artikal == 1)
                    {
                        cena = 0;
                        MessageBox.Show("Nema više tog proizvoda, molimo izaberite nešto drugo.");
                    }
                }

                //artikal2
                if (vlasnik == 0)
                {

                    textBox5.Text = br2.ToString();
                    if (artikal == 2 && br2 > 0)
                    {
                        br2 = br2 - 1;
                        textBox5.Text = br2.ToString();
                        cips = cips + 1;
                        cips1 = cips1 + 1;
                    }
                    else if (artikal == 2)
                    {
                        cena = 0;
                        MessageBox.Show("Nema više tog proizvoda, molimo izaberite nešto drugo.");
                    }
                }


                //artikal3
                if (vlasnik == 0)
                {

                    //textBox6.Text = br3.ToString();
                    if (artikal == 3 && br3 > 0)
                    {
                        br3 = br3 - 1;
                        textBox6.Text = br3.ToString();
                        kinder_jaje = kinder_jaje + 1;
                        kinder_jaje1 = kinder_jaje1 + 1;
                    }
                    else if (artikal == 3)
                    {
                        cena = 0;
                        MessageBox.Show("Nema više tog proizvoda, molimo izaberite nešto drugo.");
                    }
                }






                KolicinaPara = KolicinaPara - cena;
            }
            else { MessageBox.Show("Nemate dovoljno para"); }

            textBox4.Text = KolicinaPara.ToString();
        }


        private void Kusur(object sender, EventArgs e)
        {
            //private void Kusur(object sender, EventArgs e)
            KolicinaPara1 = KolicinaPara;
            int[] denominacije = { 1, 2, 5, 10, 20, 50, 100, 200, 500 };
            int[] kusur = new int[KolicinaPara + 1];
            kusur[0] = -1;



            for (int i = 0; i < brojevi.Length; i++)
            {
                for (int j = kusur.Length - 1; j >= 0; j--)
                {
                    for (int k = 1; k < brojevi[i] + 1; k++)
                    {
                        if (kusur[j] != 0)
                        {
                            if (j + k * denominacije[i] >= kusur.Length) continue;
                            kusur[j + k * denominacije[i]] = i + 1;
                        }
                    }
                }
            }

            int trenutni = kusur.Length - 1;
            while (kusur[trenutni] != -1)
            {
                if (kusur[trenutni] == 0)
                {
                    trenutni--;
                    continue;
                }
                int pom = trenutni;
                //if (kusur[pom] == 0) { MessageBox.Show("Nemam da ti vratim kusur"); }
                //MessageBox.Show(denominacije[kusur[pom] - 1].ToString());
                label7.Text = label7.Text + " " + denominacije[kusur[pom] - 1].ToString();
                if (denominacije[kusur[pom] - 1] != 500)
                {
                    if (denominacije[kusur[pom] - 1] != 200)
                    {
                        if (denominacije[kusur[pom] - 1] != 100)
                        {
                            if (denominacije[kusur[pom] - 1] != 50)
                            {
                                if (denominacije[kusur[pom] - 1] != 20)
                                {
                                    if (denominacije[kusur[pom] - 1] != 10)
                                    {
                                        if (denominacije[kusur[pom] - 1] != 5)
                                        {
                                            if (denominacije[kusur[pom] - 1] != 2)
                                            {
                                                pbr9 = pbr9 - 1;
                                                //brojevi[0] = kbr9;
                                                //textBox15.Text = kbr9.ToString();
                                            }
                                            else
                                            {
                                                pbr8 = pbr8 - 1;
                                                //brojevi[1] = kbr8;
                                                //textBox14.Text = kbr8.ToString();

                                            }

                                        }
                                        else
                                        {
                                            pbr7 = pbr7 - 1;
                                            //brojevi[2] = kbr7;
                                            //textBox13.Text = kbr7.ToString();
                                        }

                                    }
                                    else
                                    {
                                        pbr6 = pbr6 - 1;
                                        //brojevi[3] = kbr6;
                                        //textBox12.Text = kbr6.ToString();
                                    }

                                }
                                else
                                {
                                    pbr5 = pbr5 - 1;
                                    //brojevi[4] = kbr5;
                                    //textBox11.Text = kbr5.ToString();
                                }
                            }
                            else
                            {
                                pbr4 = pbr4 - 1;
                                //brojevi[5] = kbr4;
                                //textBox10.Text = kbr4.ToString();
                            }
                        }
                        else
                        {
                            pbr3 = pbr3 - 1;
                            //brojevi[6] = kbr3;
                            //textBox9.Text = kbr3.ToString();
                        }
                    }
                    else
                    {
                        pbr2 = pbr2 - 1;
                        //brojevi[7] = kbr2;
                        //textBox8.Text = kbr2.ToString();
                    }
                }

                else
                {
                    pbr1 = pbr1 - 1;
                    //brojevi[8] = kbr1;
                    //textBox7.Text = kbr1.ToString();
                }
                trenutni -= denominacije[kusur[pom] - 1];
                KolicinaPara -= denominacije[kusur[pom] - 1];

            }


            if (KolicinaPara > 0)
            {
                MessageBox.Show("Nemam da vam vratim tacan kusur");
                KolicinaPara = KolicinaPara1;
                label7.Text = string.Empty;
                if (zvake > 0)
                {
                    //artikal = 1;
                    uk = uk + (cena1 * zvake1);
                    textBox3.Text = (br1 + zvake1).ToString();

                }
                if (cips > 0)
                {
                    //artikal = 2;
                    uk = uk + (cena2 * cips1);
                    textBox5.Text = (br2 + cips1).ToString();

                }
                if (kinder_jaje > 0)
                {
                    //artikal = 2;
                    uk = uk + (cena3 * kinder_jaje1);
                    textBox6.Text = (br3 + kinder_jaje1).ToString();
                }
                KolicinaPara = KolicinaPara + uk;


            }
            else
            {
                kbr1 = pbr1;
                kbr2 = pbr2;
                kbr3 = pbr3;
                kbr4 = pbr4;
                kbr5 = pbr5;
                kbr6 = pbr6;
                kbr7 = pbr7;
                kbr8 = pbr8;
                kbr9 = pbr9;
                brojevi[0] = kbr9;
                textBox15.Text = kbr9.ToString();
                brojevi[1] = kbr8;
                textBox14.Text = kbr8.ToString();
                brojevi[2] = kbr7;
                textBox13.Text = kbr7.ToString();
                brojevi[3] = kbr6;
                textBox12.Text = kbr6.ToString();
                brojevi[4] = kbr5;
                textBox11.Text = kbr5.ToString();
                brojevi[5] = kbr4;
                textBox10.Text = kbr4.ToString();
                brojevi[6] = kbr3;
                textBox9.Text = kbr3.ToString();
                brojevi[7] = kbr2;
                textBox8.Text = kbr2.ToString();
                brojevi[8] = kbr1;
                textBox7.Text = kbr1.ToString();
            }

            textBox4.Text = KolicinaPara.ToString();

            if (textBox9.Text != "0")
            {
                if (textBox10.Text != "0")
                {
                    if (textBox11.Text != "0")
                    {
                        if (textBox12.Text != "0")
                        {
                            if (textBox13.Text != "0")
                            {
                                if (textBox14.Text != "0")
                                {
                                    if (textBox15.Text != "0")
                                    {
                                        if (textBox7.Text != "0")
                                        {
                                            if (textBox8.Text != "0")
                                            {


                                            }
                                            else
                                            {
                                                label12.Text = label12.Text + (" Dopuni 200");
                                            }
                                        }
                                        else
                                        {
                                            label12.Text = label12.Text + (" Dopuni 500");
                                        }
                                    }
                                    else
                                    {
                                        label12.Text = label12.Text + (" Dopuni 1");
                                    }
                                }
                                else
                                {
                                    label12.Text = label12.Text + (" Dopuni 2");
                                }
                            }
                            else
                            {
                                label12.Text = label12.Text + (" Dopuni 5");
                            }
                        }
                        else
                        {
                            label12.Text = label12.Text + (" Dopuni 10");
                        }
                    }
                    else
                    {
                        label12.Text = label12.Text + (" Dopuni 20");
                    }
                }
                else
                {
                    label12.Text = label12.Text + (" Dopuni 50");
                }

            }
            else
            {
                label12.Text = label12.Text + (" Dopuni 100");
            }


        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.ReadOnly = true;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }



        private void zavrsio(object sender, EventArgs e)
        {


            if (int.TryParse(textBox3.Text, out int w1))
            {
                br1 = w1;
                textBox3.ReadOnly = true;
                textBox3.Enabled = false;
            }
            else
            {
                MessageBox.Show("Uneta vrednost nije validan broj.");
            }

            //textBox3.Text = br2.ToString();
            if (int.TryParse(textBox5.Text, out int w2))
            {
                br2 = w2;
                textBox5.ReadOnly = true;
                textBox5.Enabled = false;
            }
            else
            {
                MessageBox.Show("Uneta vrednost nije validan broj.");
            }

            if (int.TryParse(textBox6.Text, out int w6))
            {
                br3 = w6;
                textBox6.ReadOnly = true;
                textBox6.Enabled = false;
            }
            else
            {
                MessageBox.Show("Uneta vrednost nije validan broj.");
            }
            //1
            if (int.TryParse(textBox7.Text, out int b1))
            {
                kbr1 = b1;
                textBox7.ReadOnly = true;
                textBox7.Enabled = false;
                brojevi[8] = kbr1;
            }
            else
            {
                MessageBox.Show("Uneta vrednost nije validan broj.");
            }
            //2

            if (int.TryParse(textBox8.Text, out int b2))
            {
                kbr2 = b2;
                textBox8.ReadOnly = true;
                textBox8.Enabled = false;
                brojevi[7] = kbr2;
            }
            else
            {
                MessageBox.Show("Uneta vrednost nije validan broj.");
            }
            //3
            if (int.TryParse(textBox9.Text, out int b3))
            {
                kbr3 = b3;
                textBox9.ReadOnly = true;
                textBox9.Enabled = false;
                brojevi[6] = kbr3;
            }
            else
            {
                MessageBox.Show("Uneta vrednost nije validan broj.");
            }
            //4
            if (int.TryParse(textBox10.Text, out int b4))
            {
                kbr4 = b4;
                textBox10.ReadOnly = true;
                textBox10.Enabled = false;
                brojevi[5] = kbr4;
            }
            else
            {
                MessageBox.Show("Uneta vrednost nije validan broj.");
            }
            //5
            if (int.TryParse(textBox11.Text, out int b5))
            {
                kbr5 = b5;
                textBox11.ReadOnly = true;
                textBox11.Enabled = false;
                brojevi[4] = kbr5;
            }
            else
            {
                MessageBox.Show("Uneta vrednost nije validan broj.");
            }
            //6
            if (int.TryParse(textBox12.Text, out int b6))
            {
                kbr6 = b6;
                textBox12.ReadOnly = true;
                textBox12.Enabled = false;
                brojevi[3] = kbr6;
            }
            else
            {
                MessageBox.Show("Uneta vrednost nije validan broj.");
            }
            //7
            if (int.TryParse(textBox13.Text, out int b7))
            {
                kbr7 = b7;
                textBox13.ReadOnly = true;
                textBox13.Enabled = false;
                brojevi[2] = kbr7;
            }
            else
            {
                MessageBox.Show("Uneta vrednost nije validan broj.");
            }
            //8
            if (int.TryParse(textBox14.Text, out int b8))
            {
                kbr8 = b8;
                textBox14.ReadOnly = true;
                textBox14.Enabled = false;
                brojevi[1] = kbr8;
            }
            else
            {
                MessageBox.Show("Uneta vrednost nije validan broj.");
            }
            //9
            if (int.TryParse(textBox15.Text, out int b9))
            {
                kbr9 = b9;
                textBox15.ReadOnly = true;
                textBox15.Enabled = false;
                brojevi[0] = kbr9;
            }
            else
            {
                MessageBox.Show("Uneta vrednost nije validan broj.");
            }
            if (int.TryParse(textBox18.Text, out int w18))
            {
                cena1 = w18;
                textBox18.ReadOnly = true;
                textBox18.Enabled = false;

            }
            else
            {
                MessageBox.Show("Uneta vrednost nije validan broj.");
            }
            if (int.TryParse(textBox17.Text, out int w17))
            {
                cena2 = w17;
                textBox17.ReadOnly = true;
                textBox17.Enabled = false;

            }
            else
            {
                MessageBox.Show("Uneta vrednost nije validan broj.");
            }
            if (int.TryParse(textBox16.Text, out int w16))
            {
                cena3 = w16;
                textBox16.ReadOnly = true;
                textBox16.Enabled = false;

            }
            else
            {
                MessageBox.Show("Uneta vrednost nije validan broj.");
            }

            vlasnik = 0;
        }

        private void uzmi(object sender, EventArgs e)
        {
            if (zvake1 != zvake)
            {
                zvake = zvake - zvake1;
            }
            else { zvake = zvake1; }
            if (cips1 != cips)
            {
                cips = cips - cips1;
            }
            else { cips = cips1; }
            if (cips1 != cips)
            {
                kinder_jaje = kinder_jaje - kinder_jaje1;
            }
            else { kinder_jaje = kinder_jaje1; }
            MessageBox.Show(zvake + " zvaka " + cips + " cips " + kinder_jaje + " kinder jaja ");
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

            string text18 = textBox18.Text;
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            string text17 = textBox17.Text;
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            string text17 = textBox17.Text;
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            IspravnaSifra = textBox1.Text;
        }
    }

}

