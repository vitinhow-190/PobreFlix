namespace PobreFlix.Categorias;

public partial class Terror : ContentPage
{
	public Terror()
	{
		InitializeComponent();
	}

    private void amdd_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Filmes.amdd());
        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }

    private void phone_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Filmes.phone());
        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }

    private void sorria_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Filmes.sorria());
        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }

    private void umlugar_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Filmes.umlugar());
        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }
}