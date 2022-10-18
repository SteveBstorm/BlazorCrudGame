using CorrectifCrud.Models;
using CorrectifCrud.Services;
using Microsoft.AspNetCore.Components;

namespace CorrectifCrud.Pages
{
    public partial class Update
    {
        [Inject]
        public GameService _gs { get; set; }
        [Inject]
        public NavigationManager navManager { get; set; }
        [Parameter]
        public int id { get; set; }

        public GameFormModel MyForm { get; set; }

        protected override void OnInitialized()
        {
            Game g = _gs.GetById(id);
            MyForm = new GameFormModel
            {
                Id = g.Id,
                Title = g.Title,
                Genre = g.Genre
            };
        }

        public void ValidForm()
        {
            _gs.Update(new Game
            {
                Id = id,
                Genre = MyForm.Genre,
                Title = MyForm.Title
            });

            navManager.NavigateTo("/");
        }
    }
}
