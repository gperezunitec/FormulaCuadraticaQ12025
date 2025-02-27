namespace FormulaCuadraticaQ12025.Views;

public partial class FOrmulaCuadraticaView : ContentPage
{

	FOrmulaCuadraticaView viewModel;
	public FOrmulaCuadraticaView()
	{
		InitializeComponent();
		viewModel=new FOrmulaCuadraticaView();
		BindingContext=viewModel;
	}
}