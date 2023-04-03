namespace Assingments
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnProblem3_Click(object sender, EventArgs e)
        {
            string number = "94807856590703";
            int num = 0;
            for (int i = 0; i < number.Length; i++)
            {
                num += Convert.ToInt32(number.Substring(i, 1));
            }

            if (num % 7 == 0)
            {
                MessageBox.Show("valid");
            }
            else
            {
                MessageBox.Show("invalid");
            }
        }

        private void BtnProblem4_Click(object sender, EventArgs e)
        {
            string num = "";
            for (int i = 1; i < 9; i++)
            {
                for (int j = 1; j < 9; j++)
                {
                    for (int k = 1; k < 9; k++)
                    {
                        num = i.ToString() + j.ToString() + k.ToString();
                        if (Convert.ToInt32(num) % (i * j * k) == 0)
                        {
                            TxtOutput.Text += num + Environment.NewLine;
                        }
                    }
                }
            }
        }

        private void BtnProblem5_Click(object sender, EventArgs e)
        {
            TxtOutput.Clear();
            for (int i = 1; i <= 2; i++)
            {
                if (i == 2)
                {
                    TxtOutput.Text += (2000 / Math.Pow(i, 2)).ToString() + Environment.NewLine;
                    break;
                }
                for (int j = 0; j < 9; j++)
                {
                    for (int k = 0; k < 9; k++)
                    {
                        for (int l = 0; l < 9; l++)
                        {
                            int num = (int)(Math.Pow(i, 2) + Math.Pow(j, 2) + Math.Pow(k, 2) + Math.Pow(l, 2));
                            if (Convert.ToInt64(i.ToString() + j.ToString() + k.ToString() + l.ToString()) % num == 0)
                            {
                                TxtOutput.Text += i.ToString().Trim() + j.ToString().Trim() + k.ToString().Trim() + l.ToString().Trim() + Environment.NewLine;
                            }
                        }
                    }
                }

            }
        }

        /*private void BtnProblem6_Click(object sender, EventArgs e)
        {
            for(int i = 1; i <= 3; i++) 
            {
                if(i ==3)
                {
                    double product = (Convert.ToInt32(k.ToString().Trim()) + Convert.ToInt32(j.ToString().Trim()) + Convert.ToInt32(i.ToString().Trim())) * (Convert.ToInt32(i.ToString().Trim()) + Convert.ToInt32(j.ToString().Trim()) + Convert.ToInt32(k.ToString().Trim()));

                    double p1 = Math.Sqrt(product);
                    int p2 = (int)Math.Sqrt(product);

                    if (p1 == p2)
                    {
                        TxtOutput.Text += Convert.ToInt32(i.ToString() + j.ToString().Trim() + k.ToString().Trim()) + p1.ToString() + Environment.NewLine;
                    }
                    break;
                }
                for(int j = 0; j < 9; j++)
                {
                    for(int k = 0; k < 9; k++)
                    {
                        double product = (Convert.ToInt32(k.ToString().Trim()) + Convert.ToInt32(j.ToString().Trim()) + Convert.ToInt32(i.ToString().Trim())) * (Convert.ToInt32(i.ToString().Trim()) + Convert.ToInt32(j.ToString().Trim()) + Convert.ToInt32(k.ToString().Trim()));
                        double p1 = Math.Sqrt(product);
                        int p2 = (int)Math.Sqrt(product);
                        if (p1==p2)
                        {
                            TxtOutput.Text += i.ToString() +j.ToString().Trim() + k.ToString().Trim() + p1.ToString() + Environment.NewLine;
                        }
                    }
                }
            }
        }*/
    }
}