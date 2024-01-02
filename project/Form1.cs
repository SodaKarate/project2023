using Microsoft.VisualBasic.ApplicationServices;
using System.Globalization;
using System.Windows.Forms;

namespace project
{

    public partial class Form1 : Form
    {
        model szamolas = new model();
        bool multbutclicked = false;
        bool powbutclicked = false;
        bool subbutclicked = false;
        bool addbutclicked = false;
        bool divbutclicked = false;

        public Form1()
        {
            InitializeComponent();

            Button sinBut = button1;
            Button cosBut = button2;
            Button tanBut = button3;
            Button facBut = button4;
            Button multBut = button5;
            Button powBut = button6;
            Button sevenBut = button7;
            Button eightBut = button8;
            Button nineBut = button9;
            Button divBut = button10;
            Button sqBut = button11;
            Button fourBut = button12;
            Button fiveBut = button13;
            Button sixBut = button14;
            Button addBut = button15;
            Button sqrBut = button16;
            Button oneBut = button17;
            Button twoBut = button18;
            Button threeBut = button19;
            Button subBut = button20;
            Button resetBut = button21;
            Button backBut = button22;
            Button zeroBut = button23;
            Button dotBut = button24;
            Button eqBut = button25;
            List<string> buttonNames = new List<string>() {
                "sin", "cos", "tan","!","X",
                "^","7","8","9","/",
                "^2","4","5","6","+",
                "sqr","1","2","3","-",
                "reset","backspace","0",".","="
            };

            List<Button> buttons = new List<Button>() {
                sinBut,cosBut,tanBut,facBut,multBut,
                powBut,sevenBut,eightBut,nineBut,divBut,
                sqBut,fourBut,fiveBut,sixBut,addBut,
                sqrBut,oneBut,twoBut, threeBut,subBut,
                resetBut, backBut, zeroBut, dotBut, eqBut
            };

            for (int i = 0; i < buttons.Count; i++)
            {
                buttons[i].Text = buttonNames[i];
            }

            sinBut.Click += (s, e) =>
            {
                double angle = double.Parse(textBox1.Text);
                double result = szamolas.sin(angle);
                listBox1.Items.Add(result);
            };
            cosBut.Click += (s, e) =>
            {
                double angle2 = double.Parse(textBox1.Text);
                double result2 = szamolas.cos(angle2);
                listBox1.Items.Add(result2);
            };
            tanBut.Click += (s, e) =>
            {
                double angle3 = double.Parse(textBox1.Text);
                double result3 = szamolas.tan(angle3);
                listBox1.Items.Add(result3);
            };
            facBut.Click += (s, e) =>
            {
                double temp = double.Parse(textBox1.Text);
                double res = szamolas.fact(temp);
                listBox1.Items.Add(res);
            };
            multBut.Click += (s, e) =>
            {
                multbutclicked = true;
                textBox1.AppendText("*");
            };
            powBut.Click += (s, e) =>
            {
                powbutclicked = true;
                textBox1.AppendText("^");
            };
            sevenBut.Click += (s, e) =>
            {
                textBox1.AppendText("7");
            };
            eightBut.Click += (s, e) =>
            {
                textBox1.AppendText("8");
            };
            nineBut.Click += (s, e) =>
            {
                textBox1.AppendText("9");
            };
            divBut.Click += (s, e) =>
            {
                divbutclicked = true;
                textBox1.AppendText("/");
            };
            sqBut.Click += (s, e) =>
            {
                double temp = double.Parse(textBox1.Text);
                double res = szamolas.sq(temp);
                listBox1.Items.Add(res);
            };
            fourBut.Click += (s, e) =>
            {
                textBox1.AppendText("4");
            };
            fiveBut.Click += (s, e) =>
            {
                textBox1.AppendText("5");
            };
            sixBut.Click += (s, e) =>
            {
                textBox1.AppendText("6");
            };
            addBut.Click += (s, e) =>
            {
                addbutclicked = true;
                textBox1.AppendText("+");
            };
            sqrBut.Click += (s, e) =>
            {
                double temp = double.Parse(textBox1.Text);
                double res = szamolas.sqr(temp);
                listBox1.Items.Add(res);
            };
            oneBut.Click += (s, e) =>
            {
                textBox1.AppendText("1");
            };
            twoBut.Click += (s, e) =>
            {
                textBox1.AppendText("2");
            };
            threeBut.Click += (s, e) =>
            {
                textBox1.AppendText("3");
            };

            subBut.Click += (s, e) =>
            {
                subbutclicked = true;
                textBox1.AppendText("-");
            };
            resetBut.Click += (s, e) =>
            {
                multbutclicked = false;
                powbutclicked = false;
                subbutclicked = false;
                addbutclicked = false;
                divbutclicked = false;

                textBox1.Text = "";
                listBox1.Items.Clear();
            };
            backBut.Click += (s, e) =>
            {
                listBox1.Items.Clear();
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            };
            zeroBut.Click += (s, e) =>
            {
                textBox1.AppendText("0");
            };
            dotBut.Click += (s, e) =>
            {
                if (szamolas.hunloc() == true)
                {
                    textBox1.AppendText(",");
                }
                else if(szamolas.hunloc() == false)
                {
                    textBox1.AppendText(".");
                }
                
            };

            eqBut.Click += (s, e) =>
            {
                if (multbutclicked)
                {
                    double res = szamolas.mult(textBox1.Text);
                    listBox1.Items.Add(res);
                }
                if (powbutclicked)
                {
                    double res = szamolas.pow(textBox1.Text);
                    listBox1.Items.Add(res);
                }
                if (divbutclicked)
                {
                    double res = szamolas.div(textBox1.Text);
                    listBox1.Items.Add(res);
                }
                if (addbutclicked)
                {
                    double res = szamolas.add(textBox1.Text);
                    listBox1.Items.Add(res);
                }
                if (subbutclicked)
                {
                    double res = szamolas.sub(textBox1.Text);
                    listBox1.Items.Add(res);
                }

            };


        }
    }
}
