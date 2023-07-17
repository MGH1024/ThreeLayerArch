using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web.Pages.Province
{
    public partial class ProvinceList : System.Web.UI.Page
    {
        private ProvinceService _provinceService;
        protected void Page_Load(object sender, EventArgs e)
        {
            _provinceService = new ProvinceService();

            ProvinceGrid.DataSource = _provinceService.GetAll();
            ProvinceGrid.DataBind();
        }
    }
}