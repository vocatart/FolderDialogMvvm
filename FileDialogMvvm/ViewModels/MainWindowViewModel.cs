using System.Reactive;
using System.Reactive.Linq;
using System.Threading.Tasks;
using ReactiveUI;

namespace FileDialogMvvm.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            // The OpenFile command is bound to a button/menu item in the UI.
            OpenFolder = ReactiveCommand.CreateFromTask(OpenFolderAsync);

            // The ShowOpenFileDialog interaction requests the UI to show the file open dialog.
            ShowOpenFolderDialog = new Interaction<Unit, string?>();
        }

        public ReactiveCommand<Unit, Unit> OpenFolder { get; }
        public Interaction<Unit, string?> ShowOpenFolderDialog { get; }

        private async Task OpenFolderAsync()
        {
            var result = await ShowOpenFolderDialog.Handle(Unit.Default);

            if (result is object)
            {
                // Put your logic for opening file here.
            }
        }
    }
}
