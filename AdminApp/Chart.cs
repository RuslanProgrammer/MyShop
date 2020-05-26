using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace AdminApp
{
    public partial class ChartP : Form
    {
        public ChartP(List<decimal> prices)
        {
            InitializeComponent();
            for (int i = 0; i < prices.Count; i++)
            {
                chart1.Series["Price"].Points.AddY(prices[i]);
                chart1.Series["Price"].Points[i + 1].Label = prices[i].ToString();
            }
            chart1.ChartAreas[0].AxisX.Enabled = AxisEnabled.False;
        }
    }
}
