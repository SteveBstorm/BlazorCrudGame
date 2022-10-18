using CorrectifCrud.Models;
using CorrectifCrud.Services;
using Microsoft.AspNetCore.Components;

namespace CorrectifCrud.Pages
{
    public partial class Create
    {
        [Inject]
        public GameService _gs { get; set; }
        [Inject]
        public NavigationManager navManager { get; set; }

        public GameFormModel MyForm { get; set; }

        public Create()
        {
            MyForm = new GameFormModel();
        }

        public void ValidForm()
        {
            _gs.Add(new Game
            {
                Genre = MyForm.Genre,
                Title = MyForm.Title
            });

            navManager.NavigateTo("/");
        }
    }
}
