using System.Xml.Linq;

namespace Interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void btnSave_Click(object sender, EventArgs e)
        {
            Duck myDuck = new Duck();
            myDuck.Name = txtName.Text;
            myDuck.Color = txtColor.Text;
            myDuck.Sound = txtSound.Text;
            myDuck.Age = txtAge.Text;
            lblSave.Text = myDuck.GetBirdInfo();
        }
    }
}
