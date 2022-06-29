namespace Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            for( int i= 0; i < 21; i++)
            {
                for(int j=0; j < 12; j++) 
                {
                    textBoxStage.AppendText(" ");
                }
                textBoxStage.AppendText("\r\n");
            }
            
        }
    }
}