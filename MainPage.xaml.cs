namespace EwidencjaCzasuPracyMAUI
{
    public partial class MainPage : ContentPage
    {
        new DateTime rightNow = DateTime.Now;
        public MainPage()
        {
        
            InitializeComponent();
        }
        void registerEnter(object sender, EventArgs e)
        {
            LblEnterTime.Text = "Czas rozpoczęcia: " + rightNow.ToString("HH:mm");
        }
        void registerExit(object sender, EventArgs e)
        {
            LblExitTime.Text = "Czas zakończenia: " + rightNow.ToString("HH:mm");
            prgBarFrequenty.Progress += 0.1;
        }
    }

}
