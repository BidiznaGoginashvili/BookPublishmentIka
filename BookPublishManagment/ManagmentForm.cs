using PublishingHouseManagmentSystem.Infrastructure.Services.ProductService;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BookPublishManagment
{
    public partial class ManagmentForm : Form
    {

        private readonly IProductService _productService;

        public ManagmentForm()
        {
            InitializeComponent();
        }

        public ManagmentForm(IProductService productService)
        {
            InitializeComponent();
            _productService = productService;
        }

        private void PanelMenu(object sender, EventArgs e)
        {
            Button buttonSender = (Button)sender;
            AppearPanelsByPanelName(buttonSender.Name);

            if (buttonSender == Arcticle)
                _productService.GetArcticles(ArcticleDataGridView);
            else if (buttonSender == Books)
                _productService.GetBooks(BookDataGridView);
            else if (buttonSender == Kindle)
                _productService.GetEBooks(KindleDataGridView);
            else if (buttonSender == Authors)
                _productService.GetAuthors(AuthorsDataGridView);
        }

        public void AppearPanelsByPanelName(string panelName)
        {
            List<Panel> panels = new List<Panel>() { AuthorsPanel, ArcticlePanel, KindlePanel, BooksPanel, PublishPanel };

            if (!string.IsNullOrWhiteSpace(panelName))
            {
                foreach (var item in panels)
                {
                    bool contains = item.Name.Contains(panelName);
                    var visibilityChange = contains == true ? item.Visible = true : item.Visible = false;
                }
            }
        }

        private void PublishByPanel(object sender, EventArgs e)
        {
            Button buttonSender = (Button)sender;

            if (buttonSender == PublishBook)
            {
                PublishForm publishForm = new PublishForm("Books", _productService);
                publishForm.Show();
            }
            else if (buttonSender == PublishEBook)
            {
                PublishForm publishForm = new PublishForm("EBooks", _productService);
                publishForm.Show();
            }
            else
            {
                PublishForm publishForm = new PublishForm("Arcticles", _productService);
                publishForm.Show();
            }
        }

        private void SearchButton(object sender, EventArgs e)
        {
            Button buttonSender = (Button)sender;

            if (buttonSender == SearchArcticle)
                _productService.GetArcticles(ArcticleDataGridView, ArcticleTitle.Text, ArcticleDateTime.Value);
            else if (buttonSender == SearchBook)
                _productService.GetBooks(BookDataGridView, BookTitle.Text, BookPublicationDate.Value);
            else if (buttonSender == SeachEBook)
                _productService.GetEBooks(KindleDataGridView, KindleTitle.Text, KindleDate.Value);
            else if (buttonSender == SearchAuthor)
                _productService.GetAuthors(AuthorsDataGridView, BookName.Text);
        }
    }
}
