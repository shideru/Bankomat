using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Bankomat
{
    

    public partial class Form1 : Form
    {
        int ekran = 1;
        void kredytowa()
        {
            groupBox4.BackColor = ColorTranslator.FromHtml("#FF0000");
            textBox1.Text = "Błąd";
            textBox2.Text = "Nie można";
            textBox3.Text = "wypłaćić!";
            textBox5.Text = "To Karta";
            textBox6.Text = "Kredytowa";
            textBox7.Text = "Tylko Karty";
            textBox8.Text = "Debetowe";
        }

        void ekran1()
        {
            ekran = 1;
            textBox1.Text = "Witaj!";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "Włóż";
            textBox7.Text = "Kartę";
            textBox8.Text = "";
            pinPad.Clear();
            chosenCard = null;
            groupBox4.BackColor = ColorTranslator.FromHtml("#00FF00");
            button14.BackColor = ColorTranslator.FromHtml("#E0E0E0");
            groupBox5.BackColor = ColorTranslator.FromHtml("#E0E0E0");
        }
        void ekran2()
        {
            ekran = 2;
            textBox1.Text = "Zakończ";
            textBox2.Text = "";
            textBox3.Text = "Podaj";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "Pin";
            textBox8.Text = "";
            groupBox5.BackColor = ColorTranslator.FromHtml("#E0E0E0");
        }
        void ekran3()
        {
            ekran = 3;
            textBox1.Text = "Zakończ";
            textBox2.Text = "";
            textBox3.Text = "Doładuj telefon";
            textBox4.Text = "";
            textBox5.Text = "Stan Konta";
            textBox6.Text = "Wypłać";
            textBox7.Text = "Wpłać";
            textBox8.Text = "";
            groupBox5.BackColor = ColorTranslator.FromHtml("#E0E0E0");
        }
        void ekran4()
        {
            ekran = 4;
            textBox1.Text = "Zakończ";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "Powrót";
            textBox5.Text = "Twój";
            textBox6.Text = "Stan Konta";
            textBox7.Text = "To";
            textBox8.Text = (chosenCard.getBalance().ToString() + "zł");
            groupBox5.BackColor = ColorTranslator.FromHtml("#E0E0E0");
        }
        void ekran5()
        {
            ekran = 5;
            textBox1.Text = "Zakończ";
            textBox2.Text = "20";
            textBox3.Text = "50";
            textBox4.Text = "Powrót";
            textBox5.Text = "";
            textBox6.Text = "100";
            textBox7.Text = "200";
            textBox8.Text = "Inny";
            groupBox5.BackColor = ColorTranslator.FromHtml("#E0E0E0");
            chosenCard.changeBalance(chosenCard.getBalance() + 100.00);
        }
        void ekran6()
        {
            ekran = 6;
            textBox1.Text = "Zakończ";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "Powrót";
            textBox5.Text = "Brak";
            textBox6.Text = "Wystarczających";
            textBox7.Text = "Środków";
            textBox8.Text = "";
            withdraw = false;
            groupBox5.BackColor = ColorTranslator.FromHtml("#FF0000");
        }
        void ekran7()
        {
            ekran = 7;
            textBox1.Text = "Zakończ";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "Powrót";
            textBox5.Text = "Anuluj";
            textBox6.Text = "Wprowadzono:";
            textBox7.Text = "0 zł";
            textBox8.Text = "Potwierdź";
            withdraw = false;
            groupBox5.BackColor = ColorTranslator.FromHtml("#E0E0E0");
        }
        void ekran8()
        {
            ekran = 8;
            textBox1.Text = "Zakończ";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "Powrót";
            textBox5.Text = "";
            textBox6.Text = "Twój stan konta:";
            textBox7.Text = chosenCard.getBalance().ToString();
            textBox8.Text = "";
            withdraw = false;
            groupBox5.BackColor = ColorTranslator.FromHtml("#E0E0E0");
        }
        void ekran9()
        {
            ekran = 9;
            textBox1.Text = "Zakończ";
            textBox2.Text = "20";
            textBox3.Text = "50";
            textBox4.Text = "Powrót";
            textBox5.Text = "";
            textBox6.Text = "100";
            textBox7.Text = "200";
            textBox8.Text = "";
            groupBox5.BackColor = ColorTranslator.FromHtml("#E0E0E0");
            chosenCard.changeBalance(chosenCard.getBalance() + 100.00);
        }
        void outoforder()
        {
            ekran = 0;
            textBox1.Text = "Out";
            textBox2.Text = "Of";
            textBox3.Text = "Order";
            textBox4.Text = "";
            textBox5.Text = "Bankomat";
            textBox6.Text = "nieczynny";
            textBox7.Text = "";
            textBox8.Text = "Przepraszamy!";
            withdraw = false;
            groupBox5.BackColor = ColorTranslator.FromHtml("#FF0000");
            chosenCard = null;
            groupBox4.BackColor = ColorTranslator.FromHtml("#00FF00");
            button14.BackColor = ColorTranslator.FromHtml("#E0E0E0");
        }
        int wplata = 0;
        string pinPadValue = "";
        bool withdraw = false;
        Karta chosenCard = new Karta();
        Karta Karta1 = new Karta("Zofia", "Bączyk", "2022/10", "1234567890987654", "1234", "Debit", 4123.44);
        Karta Karta2 = new Karta("Zofia", "Bączyk", "2020/2", "1234567890989876", "1234", "Debit", 9.99);
        Karta Karta3 = new Karta("Zofia", "Bączyk", "2020/11", "1234567890981234", "1234", "Credit", 967.33);
        Karta Karta4 = new Karta("Zofia", "Bączyk", "2020/10", "1234567890982233", "1234", "Debit", 4534.33);
        Karta Karta5 = new Karta("Zofia", "Bączyk", "2020/10", "1234567890980000", "1234", "Credit", 2343.33);
        Zasoby zasoby = new Zasoby(10,10,10,10,10,10);
        public Form1()
        {
            InitializeComponent();

        }
        
        private void button_Pad_Click(object sender, EventArgs e)
        {
            if (pinPad.Text == "PIN")
                pinPad.Clear();
            Button button = (Button)sender;
            if (withdraw == false )
            {
                if (pinPadValue.Length <4)
                { 
                pinPad.Text = pinPad.Text + "*";
                pinPadValue = pinPadValue + button.Text;
                
                }
            }
            else
            {
                pinPad.Text = pinPad.Text + button.Text;
                pinPadValue = pinPadValue + button.Text;
            }
        }
        private void button27_Click(object sender, EventArgs e)
        {
            if (pinPad.Text.Length > 0)
            {
                pinPad.Text = pinPad.Text.Remove(pinPad.Text.Length - 1, 1);
                pinPadValue = pinPadValue.Remove(pinPadValue.Length - 1, 1);
            }
        }

        private void button_enter_Click(object sender, EventArgs e)
        {
            if (withdraw == false)
            {
                if (pinPadValue == chosenCard.getPin())
                {
                    
                    pinPad.Text = "Zaakceptowano";
                    ekran3();
                }
                else
                {
                    pinPad.Text = "PIN";
                    pinPadValue = "";
                }

            }
            else {
                
               
                    if (chosenCard.getBalance() - Double.Parse(pinPadValue) > 0)
                     {
                            bool good = zasoby.wyplac(int.Parse(pinPadValue));
                            if (good)
                           {
                                 chosenCard.changeBalance(chosenCard.getBalance() - Double.Parse(pinPadValue));
                                 groupBox5.BackColor = ColorTranslator.FromHtml("#267326");
                                 withdraw = false;
                            ekran8();
                            }
                            else 
                            {
                                outoforder();
                            }
                    }
                        else
                        {
                            ekran6();
                        }

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e)
        {
            pinPad.Clear();
            pinPadValue = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            chosenCard = Karta1;
            pinPad.Text = "PIN";
            pinPadValue = "";
            if (chosenCard.getType() != "Debit")
            {
                kredytowa();
            }
            else 
            {
                ekran2();
            }
                button14.BackColor = button9.BackColor;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            chosenCard = Karta2;
            pinPad.Text = "PIN";
            pinPadValue = ""; 
            if (chosenCard.getType() != "Debit")
            {
                kredytowa();
            }
            else
            {
                ekran2();
            }
            button14.BackColor = button10.BackColor;
        }

        private void button11_Click(object sender, EventArgs e)
        {

            chosenCard = Karta3;
            pinPad.Text = "PIN";
            pinPadValue = "";
            if (chosenCard.getType() != "Debit")
            {
                kredytowa();
            }
            else
            {
                ekran2();
            }
            button14.BackColor = button11.BackColor;
        }

        private void button12_Click(object sender, EventArgs e)
        {

            chosenCard = Karta4;
            pinPad.Text = "PIN";
            pinPadValue = "";
            if (chosenCard.getType() != "Debit")
            {
                kredytowa();
            }
            else
            {
                ekran2();
            }
            button14.BackColor = button12.BackColor;
        }

        private void button13_Click(object sender, EventArgs e)
        {

            chosenCard = Karta5;
            pinPad.Text = "PIN";
            pinPadValue = "";
            if (chosenCard.getType() != "Debit")
            {
                kredytowa();
            }
            else
            {
                ekran2();
            }

            button14.BackColor = button13.BackColor;

        }

        private void button14_Click(object sender, EventArgs e)
        {
            chosenCard = null;

            groupBox4.BackColor = ColorTranslator.FromHtml("#00FF00");
            button14.BackColor = ColorTranslator.FromHtml("#E0E0E0");
            ekran1();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ekran1();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            if(ekran == 5 )
            {
                if (chosenCard.getBalance() - 20.00 > 0)
                {
                    bool good = zasoby.wyplac(20);
                    if (good)
                    {
                        chosenCard.changeBalance(chosenCard.getBalance() - 20.00);
                        groupBox5.BackColor = ColorTranslator.FromHtml("#267326");
                        ekran8();
                    }
                    else
                    {
                        outoforder();
                    }

                }
                else
                {
                    ekran6();
                }
            }
            if (ekran == 9)
            {
                if (chosenCard.getBalance() - 20.00 > 0)
                {

                    chosenCard.changeBalance(chosenCard.getBalance() - 20.00);
                    groupBox5.BackColor = ColorTranslator.FromHtml("#30FFFF");

                }
                else
                {
                    ekran6();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ekran == 3)
            {
                ekran9();
            
            }
            if (ekran == 5)
            {
                if (chosenCard.getBalance() - 50.00 > 0)
                {
                    bool good = zasoby.wyplac(50);
                    if (good)
                    {
                        chosenCard.changeBalance(chosenCard.getBalance() - 50.00);
                        groupBox5.BackColor = ColorTranslator.FromHtml("#267326");
                    }
                    else
                    {
                        outoforder();
                    }
                }
                else
                {
                    ekran6();
                }
            }

            if (ekran == 9)
            {
                if (chosenCard.getBalance() - 50.00 > 0)
                {
                    
                        chosenCard.changeBalance(chosenCard.getBalance() - 50.00);
                        groupBox5.BackColor = ColorTranslator.FromHtml("#30FFFF");
                   
                }
                else
                {
                    ekran6();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (ekran == 4 || ekran ==5 || ekran == 7||ekran ==8||ekran==9) ekran3();
            if (ekran == 6) ekran3();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (ekran==3)
            ekran4();
            if (ekran == 7)
            {
                zasoby.wyplac(wplata);
                groupBox5.BackColor = ColorTranslator.FromHtml("#267326");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (ekran == 3)
            { 
                ekran5();
            }
            if (ekran == 5)
            {
                if (chosenCard.getBalance() - 100.00 > 0)
                {
                    bool good = zasoby.wyplac(100);
                    if (good)
                    {
                        chosenCard.changeBalance(chosenCard.getBalance() - 100.00);
                        groupBox5.BackColor = ColorTranslator.FromHtml("#267326");
                    }
                    else
                    {
                        outoforder();
                    }
                }
                else
                {
                    ekran6();
                }

            }
            if (ekran == 9)
            {
                if (chosenCard.getBalance() - 100.00 > 0)
                {

                    chosenCard.changeBalance(chosenCard.getBalance() - 100.00);
                    groupBox5.BackColor = ColorTranslator.FromHtml("#30FFFF");

                }
                else
                {
                    ekran6();
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (ekran == 5)
            {
                if (chosenCard.getBalance() - 200.00 > 0)
                {
                    bool good = zasoby.wyplac(200);
                    if (good)
                    { 
                        chosenCard.changeBalance(chosenCard.getBalance() - 200.00);
                        groupBox5.BackColor = ColorTranslator.FromHtml("#267326");
                        ekran8();
                    }
                    else
                    {
                        outoforder();
                    }
                }
                else
                {
                    ekran6();
                }

            }
            if (ekran == 3)
            {
                ekran7();
            }
            if (ekran == 9)
            {
                if (chosenCard.getBalance() - 200.00 > 0)
                {

                    chosenCard.changeBalance(chosenCard.getBalance() - 200.00);
                    groupBox5.BackColor = ColorTranslator.FromHtml("#30FFFF");

                }
                else
                {
                    ekran6();
                }
            }


        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (ekran == 5)
            {
                pinPad.Clear();
                withdraw = true;
                pinPadValue = "";
            }
            else
            {
                if (ekran == 7)
                {
                    chosenCard.changeBalance(chosenCard.getBalance() + Convert.ToDouble(wplata));
                    ekran8();
                }
            
            }

        }
        private void button_Money_Click(object sender, EventArgs e)
        {
           
            Button button = (Button)sender;
            wplata = wplata +  int.Parse(button.Text);
            textBox7.Text =wplata.ToString() + " zł";
            if (int.Parse(button.Text) == 10)
            {
                zasoby.addDziesiec(1);
            }
            if (int.Parse(button.Text) == 20)
            {
                zasoby.addDwadziescia(1);
            }
            if (int.Parse(button.Text) == 50)
            {
                zasoby.addPiecdziesiat(1);
            }
            if (int.Parse(button.Text) == 100)
            {
                zasoby.addSto(1);
            }
            if (int.Parse(button.Text) == 200)
            {
                zasoby.addDwiescie(1);
            }
            if (int.Parse(button.Text) == 500)
            {
                zasoby.addPiecset(1);
            }

        }

    }
    class Zasoby
    {
        int piecset;
        int dwiescie;
        int sto;
        int piecdziesiat;
        int dwadziescia;
        int dziesiec;
        public Zasoby()
        { 
        
        }
        public Zasoby(int piecset_, int dwiescie_, int sto_, int piecdziesiat_, int dwadziescia_, int dziesiec_ )
        {
            piecset = piecset_;
            dwiescie = dwiescie_;
            sto = sto_;
            piecdziesiat = piecdziesiat_;
            dwadziescia = dwadziescia_;
            dziesiec = dziesiec_;
        }
        public void addPiecset(int liczba)
        {
            piecset = piecset + liczba;
        }
        public void addDwiescie(int liczba)
        {
            dwiescie = dwiescie + liczba;
        }
        public void addSto(int liczba)
        {
            sto = sto + liczba;
        }
        public void addPiecdziesiat(int liczba)
        {
            piecdziesiat = piecdziesiat + liczba;
        }
        public void addDwadziescia(int liczba)
        {
            dwadziescia = dwadziescia + liczba;
        }
        public void addDziesiec(int liczba)
        {
            dziesiec = dziesiec + liczba;
        }
        public bool wyplac(int liczba)
        {
            int piecset_ = 0;
            int dwiescie_ = 0;
            int sto_ = 0;
            int piecdziesiat_ = 0;
            int dwadziescia_ = 0;
            int dziesiec_ = 0;
            while (liczba % 500 == 0 && liczba != 0)
            {
                if (piecset - 1 >= 0)
                { 
                    piecset_ ++;
                    liczba = liczba - 500;
                }
            }
            while (liczba % 200 == 0 && liczba != 0)
            {
                if (dwiescie - 1 >= 0)
                {
                    dwiescie_ ++;
                    liczba = liczba - 200;
                }
            }
            while (liczba % 100 == 0 && liczba != 0)
            {
                if (sto - 1 >= 0)
                {
                    sto_ ++;
                    liczba = liczba - 100;
                }
            }
            while (liczba % 50 == 0 && liczba != 0)
            {
                if (piecdziesiat - 1 >= 0)
                {
                    piecdziesiat_ ++;
                    liczba = liczba - 50;
                }
            }
            while (liczba % 20 == 0 && liczba != 0)
            {
                if (dwadziescia - 1 >= 0)
                {
                    dwadziescia_++;
                    liczba = liczba - 20;
                }
            }
            while (liczba % 10 == 0 && liczba != 0)
            {
                if (dziesiec - 1 >= 0)
                {
                    dziesiec_++;
                    liczba = liczba - 10;
                }
            }
            if (liczba == 0)
            {
                piecset = piecset- piecset_;
                dwiescie = dwiescie - dwiescie_;
                sto = sto - sto_;
                piecdziesiat = piecdziesiat - piecdziesiat_;
                dwadziescia = dwadziescia - dwadziescia_;
                dziesiec = dziesiec - dziesiec_;

                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
    class Karta
    {
        String Name;
        String Surname;
        String ValidThru;
        String CardNumber;
        String Pin;
        String Type;
        Double Balance;

        public Karta()
        {

        }
        public Karta(String name_, String surname_,String ExpDate_, String cardNumber_, String pin_, String type_, Double balance_)
        {
            Name = name_;
            Surname = surname_;
            ValidThru = ExpDate_;
            CardNumber = cardNumber_;
            Pin = pin_;
            Type = type_;
            Balance = balance_;
        }
        public String getCardNumber()
        {
            return CardNumber;
        }
        public String getPin()
        {
            return Pin;
        }
        public String getType()
        {
            return Type;
        }
        public Double getBalance()
        {
            return Balance;
        }
        public void changeBalance(Double newBalance)
        {
            Balance = newBalance;
        }
    }
}
