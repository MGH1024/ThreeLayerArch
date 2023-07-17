using System;
using Services;
using Core.DTOs;

namespace Web.Pages.Province
{
    public partial class CreateProvince : System.Web.UI.Page
    {
        private ProvinceService _provinceService;
        public CreateProvince()
        {
            _provinceService = new ProvinceService();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            //ClearForm();
        }

        protected void btnCreateProvince_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(name.Text))
            {
                lblName.Text = "ضروری";
                return;
            }

            var provinceViewModel = new ProvinceDto
            {
                Name = name.Text
            };
            _provinceService.CreateProvince(provinceViewModel);
            lblResult.Text = "با موفقیت انجام شد";

        }

        protected void clearFrom_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            name.Text = "";
            lblName.Text = "";
            lblResult.Text = "";
        }

        protected void name_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(name.Text))
                lblName.Text = "";
        }
    }
}