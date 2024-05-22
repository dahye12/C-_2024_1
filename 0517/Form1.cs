namespace _0517
{
    public partial class Form1 : Form
    {
        class CustomForm : Form
        {
            public CustomForm()
            {
                this.Size = new Size(400, 300);
                this.Text = "»ç¿ëÀÚ Æû";
            }
        }
        public Form1()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomForm form = new CustomForm();
            form.MdiParent = this;
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          Form2 form2 = new Form2();    
          form2.Show();
        }
    }
}
