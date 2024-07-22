using CharacterListCreationTool.Lang;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CharacterListCreationTool.ViewModels
{
    public partial class MainViewModel : ViewModelBase
    {
        public enum Game
        {
            [Display(Name = "MainWindowGameDnD5e", ResourceType = typeof(Resources))]
            DnD5e,
            [Display(Name = "MainWindowGamePathfinder", ResourceType = typeof(Resources))]
            Pathfinder
        }
        public ObservableCollection<Game> Games { get; set; } = new ObservableCollection<Game> { Game.DnD5e, Game.Pathfinder };

        [ObservableProperty]
        private Game? selectedGame;

        [ObservableProperty]
        private ViewModelBase? content;

        protected override void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            base.OnPropertyChanged(e);
            if (e.PropertyName == nameof(SelectedGame))
            {
                Content = SelectedGame switch
                {
                    Game.DnD5e => new DnD5eViewModel(),
                    Game.Pathfinder => new PathfinderViewModel(),
                    null => null,
                    _ => throw new NotImplementedException()
                };
            }
        }
    }
}
