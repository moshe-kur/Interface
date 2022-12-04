namespace TheInterface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.AppendAllText("mytxt.txt",textBox1.Text + "," + textBox2.Text + "," + textBox3.Text + "\n");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        public int linecount=0;
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string[] theLine;
                theLine = File.ReadAllLines("mytxt.txt");
                //.ToString()
                
                if (linecount==0)
                {
                 linecount = theLine.Length -1;
                }
                else
                {
                    linecount--;
                }

                string[] oneLine = theLine[linecount].Split(',');
                textBox1.Text = oneLine[0];
                textBox2.Text = oneLine[1];
                textBox3.Text = oneLine[2];

                //TO-DO casting
               

            }
            catch (Exception ex)
            {

                return;
            }
        }
        
        enum workDays
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday
        }
    }
}