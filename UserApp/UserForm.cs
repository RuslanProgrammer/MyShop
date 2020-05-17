using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyShop;

namespace UserApp
{
    public partial class UserForm : Form
    {
        private Shop shop;
        public bool ToLogin = false;
        public UserForm(Shop _shop)
        {
            shop = _shop;
            InitializeComponent();
        }
    }
}
