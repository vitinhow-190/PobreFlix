namespace PobreFlix.Categorias;

public partial class Drama : ContentPage
{
	public Drama()
	{
		InitializeComponent();
	}

    private void dog_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Filmes.dog());
        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }

    private void estrelas_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Filmes.estrelas());
        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }

    private void aculpa_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Filmes.aculpa());
        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }

    private void extra_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Filmes.extra());
        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }
}