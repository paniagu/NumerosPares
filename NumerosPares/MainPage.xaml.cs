namespace NumerosPares
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            for(int i = 0; i <= 100; i++)
            {
                if(i % 2 == 0)
                {
                    if (i == 100)
                    {
                        Pares.Text += i;
                    }
                    else
                    {
                        Pares.Text += i + "\n";
                    }
                }
            }
        }

        
    }

}
