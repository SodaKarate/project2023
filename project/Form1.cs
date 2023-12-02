namespace project
{
    public partial class Form1 : Form
    {
        szamolas szamolas = new szamolas();
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

            for(int i =0; i < buttons.Count; i++)
            {
                buttons[i].Text = buttonNames[i];
            }
        }
    }
}
