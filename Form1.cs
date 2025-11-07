namespace Function
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        string myChar = "";
        int words = 0;
        private void TxtText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                MessageBox.Show("ONLY TEXT IS VALID!");
                e.Handled = true;
            }
        }

        private void TxtChar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && TxtChar.Text.Length >= 1)
            {
                MessageBox.Show("ONLY ONE CHARACHTER IS ALLOWED!");
                e.Handled = true;
            }
        }

        private void BtnWordsList_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtChar.Text))
                MessageBox.Show("Fill All TextBoxes please");
            else
            {
                myChar = TxtChar.Text;
                string[] myText = TxtText.Text.Split(' ');
                string showWords = "";
                for (int i = 0; i <myText.Length; i++) 
                {
                    if (myText[i].Contains(myChar)) 
                    {
                        showWords += myText[i];
                        showWords += ", ";
                    }
                }
                MessageBox.Show($" List of words : {showWords}");
            }
        }

        private void BtnNumOfChars_Click(object sender, EventArgs e)
        {
            int repeated = 0;
            if (string.IsNullOrWhiteSpace(TxtChar.Text))
                MessageBox.Show("Fill All TextBoxes please");
            else
            {
                myChar= TxtChar.Text;
                for (int i = 0; i < TxtText.Text.Length; i++)
                {
                    if (TxtText.Text[i].ToString() == myChar) 
                        repeated++;
                }
                MessageBox.Show($"Number Of repeated word : {repeated}");
            }

        }

        private void BtnNumOfWords_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtChar.Text))
                MessageBox.Show("Fill All TextBoxes please");
            else
            {
                myChar = TxtChar.Text;
                string[] myText = TxtText.Text.Split(' ');
                int numWords = 0;
                for (int i = 0; i < myText.Length; i++)
                {
                    if (myText[i].Contains(myChar))
                    
                        numWords++;
                  
                }
                MessageBox.Show($"Number Of Words : {numWords}");
            }
        }
     
    }
}
