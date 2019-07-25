using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CabinetDimension
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCalculateBottomDimension_Click(object sender, EventArgs e)
        {   

            var H = float.Parse(txtOverallHeight.Text);
            var TH = float.Parse(txtToeKickHeight.Text);
            var TD = float.Parse(txtToeKickDepth.Text);
            var D = float.Parse(txtCabinetDepth.Text);
            var W = float.Parse(txtCabinetWidth.Text);
            var T = float.Parse(txtPlywoodThickness.Text);
            var N = W - (2 * T);
            var Q = int.Parse(nupdQuantity.Value.ToString());

            var sides = new ListViewItem(new string[] { "sides", D.ToString(), H.ToString(), (2 * Q).ToString() });
            var floors = new ListViewItem(new string[] { "floors", D.ToString(), N.ToString(), (2 * Q).ToString() });
            var strips = new ListViewItem(new string[] { "strips", TH.ToString(), N.ToString(), (4 * Q).ToString() });
            var doors = new ListViewItem(new string[] { "doors",(W/2).ToString(), (H - TH).ToString(), (2 * Q).ToString() });

            listView1.Items.Clear();
            listView1.Items.AddRange(new ListViewItem[] { sides, floors, strips, doors });
        }

        private void btnCalTopCabinet_Click(object sender, EventArgs e)
        {
            var H = float.Parse(txtTopCabHeight.Text);
            var D = float.Parse(txtTopCabDepth.Text);
            var W = float.Parse(txtTopCabWidth.Text);
            var T = float.Parse(txtTopCabPlywoodThickness.Text);
            var N = W - (2 * T);
            var Q = int.Parse(nupdTopCabQuantity.Value.ToString());

            var sides = new ListViewItem(new string[] { "sides", H.ToString(), D.ToString(), (2 * Q).ToString() });
            var tbm = new ListViewItem(new string[] { "top | bottom | middle", N.ToString(), D.ToString(), (3 * Q).ToString() });
            var doors = new ListViewItem(new string[] { "doors", (W / 2).ToString(), H.ToString(), (2 * Q).ToString() });

            lstvTopCabinet.Items.Clear();
            lstvTopCabinet.Items.AddRange(new ListViewItem[] { sides, tbm, doors });
        }
    }
}
