namespace appFP_NET.condicionales
{
    public partial class _06 : Form
    {
        public _06()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txt1.Text);
            int b = int.Parse(txt2.Text);
            int c = int.Parse(txt3.Text);

            if (a > b && a>c)
            {
                txtmye.Text = a.ToString();
            }
            else if (b>a&&b>c)
            {
                txtmye.Text = b.ToString();
            }
            else if (c > a && c > b)
            {
                txtmye.Text = c.ToString();
            }
            if (a < b && a < c) { txtmye.Text = a.ToString(); }
            else if (b < a && b < c) { txtmre.Text = b.ToString(); }
            else if (c < a && c < b) { txtmre.Text = c.ToString(); }
        }
    }
}
