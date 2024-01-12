namespace EbisApp.Page.Authorized;
using Syncfusion.Maui.Cards;
public partial class PageAuth : ContentPage
{
	public PageAuth()
	{
		InitializeComponent();

        SfCardView cardView = new SfCardView();

        cardView.Content = new Label()
        {
            Text = "coba testing",
            HorizontalTextAlignment = TextAlignment.Center,
            VerticalTextAlignment = TextAlignment.Center,
            BackgroundColor = Colors.Green,
            Margin = 200,
            HeightRequest = 300,
            WidthRequest = 200,
            
            

        };
        this.Content = cardView;




    }
}