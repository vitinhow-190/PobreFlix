namespace PobreFlix.Categorias;

public partial class Documentario : ContentPage
{
	public Documentario()
	{
		InitializeComponent();
	}

    private void omdmm_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Filmes.omdmm());
        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }

    private void pp_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Filmes.pp());
        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }

    private void kiss_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Filmes.kiss());
        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }

    private void nossoplaneta_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Filmes.nossplaneta());
        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }
}