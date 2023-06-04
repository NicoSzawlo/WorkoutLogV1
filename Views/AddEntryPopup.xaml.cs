using CommunityToolkit.Maui.Views;
using WorkoutLogV1.ViewModels;

namespace WorkoutLogV1.Views;

public partial class AddEntryPopup : CommunityToolkit.Maui.Views.Popup
{
	public AddEntryPopup(AddEntryViewModel viewModel)
	{
		InitializeComponent();
		this.BindingContext = viewModel;
	}
}