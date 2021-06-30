using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kirtasiye.Business.Abstract;
using Kirtasiye.Business.DependencyResolvers.Ninject;
using Kirtasiye.Shared.Data.Abstract;

namespace Kirtasiye.FormsUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private IProductService _productService = InstanceFactory.GetInstance<IProductService>();
        private ICategoryService _categoryService = InstanceFactory.GetInstance<ICategoryService>();
        private ICartService _cartService = InstanceFactory.GetInstance<ICartService>();
    
        

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource=_productService.GetAll().ToList();
        }
    }
}
