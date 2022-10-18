using CorrectifCrud.Models;
using CorrectifCrud.Services;
using Microsoft.AspNetCore.Components;

namespace CorrectifCrud.Pages
{
    public partial class Index
    {
        [Inject]
        public GameService _gs { get; set; }
        [Inject]
        public NavigationManager navManager { get; set; }
        public List<Game> MyList { get; set; }

        public int selectedId { get; set; }

        protected override void OnInitialized()
        {
            LoadData();
        }

        protected void GoToDetail(int id)
        {
            selectedId = id;
            //navManager.NavigateTo("detail/" + id);
        }
        protected void GoToUpdate(int id)
        {
            navManager.NavigateTo("update/" + id);
        }
        protected void Delete(int id)
        {
            _gs.Delete(id);
            LoadData();
        }

        protected void LoadData()
        {
            MyList = _gs.GetAll();
        }
    }
}
