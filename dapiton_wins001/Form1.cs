namespace dapiton_wins001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         

            



                }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string name01 = getName.Text;
            int totalCourse01 = Convert.ToInt32(getTotalCourse.Text) ;
            double price01 = Convert.ToDouble(getPrice.Text);

            MessageBox.Show("Name: " + name01 +"\nTotal Course: "+ totalCourse01 + "\nPrice: " + price01);


        }
    }
}