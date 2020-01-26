using System;
using System.Windows.Forms;

namespace ISS
{
    public partial class AddPrt : Form
    {

        public AddPrt()
        {
            InitializeComponent();
            InHseBtn.Checked = true;
        }

        private void InHseBtn_CheckedChanged(object sender, EventArgs e)
        {
            label7.Text = "Machine ID";
        }

        private void OutBtn_CheckedChanged(object sender, EventArgs e)
        {
            label7.Text = "Company Name";
        }

        private void IdBx_TextChanged(object sender, EventArgs e)
        {

        }

        private void NmBx_TextChanged(object sender, EventArgs e)
        {

        }

        private void InvBx_TextChanged(object sender, EventArgs e)
        {

        }

        private void PrBx_TextChanged(object sender, EventArgs e)
        {

        }

        private void MxBx_TextChanged(object sender, EventArgs e)
        {

        }

        private void MnBx_TextChanged(object sender, EventArgs e)
        {

        }

        private void MidBx_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddPartSave_Click_1(object sender, EventArgs e)
        {
            if (InHseBtn.Checked)
            {

                InHseBtn.Checked = true;
                Inhouse inhousePart = new Inhouse(int.Parse(IdBx.Text), NmBx.Text, decimal.Parse(PrBx.Text), int.Parse(InvBx.Text), int.Parse(MnBx.Text), int.Parse(MxBx.Text), int.Parse(MidBx.Text));
                if (String.IsNullOrWhiteSpace(NmBx.Text))
                {
                    throw new ArgumentNullException("Name cannot be empty.");
                }
                if (int.Parse(IdBx.Text) != inhousePart.PartID)
                {
                    MessageBox.Show("Cannot alter Product ID.");
                    return;

                }
                if (int.Parse(InvBx.Text) > int.Parse(MxBx.Text))
                {
                    MessageBox.Show("Inventory cannot exceed Maximum level.");
                    return;
                }
                if (int.Parse(MnBx.Text) > int.Parse(MxBx.Text))
                {
                    MessageBox.Show("Minimum cannot exceed Maximum.");
                    return;
                }
                else
                {
                    Inventory.AddPart(inhousePart);
                }

            }
            else
            {
                OutBtn.Checked = true;
                Outsourced outsourcedPart = new Outsourced(int.Parse(IdBx.Text), NmBx.Text, decimal.Parse(PrBx.Text), int.Parse(InvBx.Text), int.Parse(MnBx.Text), int.Parse(MxBx.Text), MidBx.Text);
                if (String.IsNullOrWhiteSpace(NmBx.Text))
                {
                    throw new ArgumentNullException("Name cannot be empty.");
                }
                if (int.Parse(IdBx.Text) != outsourcedPart.PartID)
                {
                    MessageBox.Show("Cannot change Product ID.");
                    return;

                }
                if (int.Parse(InvBx.Text) > int.Parse(MxBx.Text))
                {
                    MessageBox.Show("Inventory cannot exceed Maximum.");
                    return;
                }
                if (int.Parse(MnBx.Text) > int.Parse(MxBx.Text))
                {
                    MessageBox.Show("Minimum cannot exceed Maximum.");
                    return;
                }
                else
                {
                    Inventory.AddPart(outsourcedPart);
                }
            }
            Close();
        }

        private void AddPartCxl_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

