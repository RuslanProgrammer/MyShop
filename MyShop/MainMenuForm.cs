using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyShop
{
    public partial class MainMenuForm : Form
    {
        Shop Shop;
        public MainMenuForm(Shop shop)
        {
            InitializeComponent();
            Shop = shop;
        }
    }
}
