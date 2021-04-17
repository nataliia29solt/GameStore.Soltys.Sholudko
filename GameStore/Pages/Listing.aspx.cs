using System;
using GameStore.Models.Repository;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GameStore.Models;

namespace GameStore.Pages
{
    public partial class Listing : System.Web.UI.Page
    {
        private Repository repository = new Repository();

        protected IEnumerable<Game> GetGames()
        {
            return repository.Games;
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}