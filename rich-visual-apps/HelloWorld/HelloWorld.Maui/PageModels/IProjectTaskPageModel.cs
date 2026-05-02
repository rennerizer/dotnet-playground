using CommunityToolkit.Mvvm.Input;
using HelloWorld.Maui.Models;

namespace HelloWorld.Maui.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}