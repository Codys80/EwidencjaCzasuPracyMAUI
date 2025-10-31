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
            LblEnterTime.Text = rightNow.ToString("HH:mm");
        }
        void registerExit(object sender, EventArgs e)
        {
            LblEnterTime.Text = " " + rightNow.ToString("HH:mm");
        }
        //private void OnCounterClicked(object sender, EventArgs e)
        //{
        //    count++;

        //    if (count == 1)
        //        CounterBtn.Text = $"Clicked {count} time";
        //    else
        //        CounterBtn.Text = $"Clicked {count} times";

        //    SemanticScreenReader.Announce(CounterBtn.Text);
        //}
    }

}
