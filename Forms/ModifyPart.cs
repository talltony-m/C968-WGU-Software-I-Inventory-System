using System;
using System.Windows.Forms;

namespace ISS
{
    public partial class MdPrt : Form
    {
        public MdPrt()
        {
            InitializeComponent();
        }

        public MdPrt(Inhouse inhouse)
        {
            InitializeComponent();

            ModPartIDBox.Text = Convert.ToString(inhouse.PartID);
            ModPartName.Text = inhouse.Name;
            ModPartInvBox.Text = Convert.ToString(inhouse.InStock);
            ModPartPriceBox.Text = Convert.ToString(inhouse.Price);
            ModPartMinBox.Text = Convert.ToString(inhouse.Min);
            ModPartMaxBox.Text = Convert.ToString(inhouse.Max);
            MdPrtMac.Text = Convert.ToString(inhouse.MachineID);
            label7.Text = "Machine ID";
            ModPartInRadio.Checked = true;
        }

        public MdPrt(Outsourced outsourced)
        {
            InitializeComponent();

            ModPartIDBox.Text = Convert.ToString(outsourced.PartID);
            ModPartName.Text = outsourced.Name;
            ModPartInvBox.Text = Convert.ToString(outsourced.InStock);
            ModPartPriceBox.Text = Convert.ToString(outsourced.Price);
            ModPartMinBox.Text = Convert.ToString(outsourced.Min);
            ModPartMaxBox.Text = Convert.ToString(outsourced.Max);
            MdPrtMac.Text = Convert.ToString(outsourced.CompanyName);
            label7.Text = "Company Name";
            ModPartOutRad.Checked = true;
        }

        private void ModPartInRadio_CheckedChanged(object sender, EventArgs e)
        {
            label7.Text = "Machine ID";
        }

        private void ModPartOutRad_CheckedChanged(object sender, EventArgs e)
        {
            label7.Text = "Company Name";
        }

        private void ModPartIDBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ModPartName_TextChanged(object sender, EventArgs e)
        {

        }

        private void ModPartInvBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ModPartPriceBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ModPartMaxBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ModPartMinBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void MdPrtMac_TextChanged(object sender, EventArgs e)
        {

        }

        private void ModPartSave_Click_1(object sender, EventArgs e)
        {
            if (ModPartInRadio.Checked)
            {
                ModPartInRadio.Checked = true;

                if (String.IsNullOrWhiteSpace(ModPartIDBox.Text) || String.IsNullOrWhiteSpace(ModPartName.Text) || String.IsNullOrWhiteSpace(ModPartPriceBox.Text) || String.IsNullOrWhiteSpace(ModPartInvBox.Text) || String.IsNullOrWhiteSpace(ModPartMinBox.Text) || String.IsNullOrWhiteSpace(ModPartMaxBox.Text))
                {
                    MessageBox.Show("Fields cannot be empty.");
                    return;
                }

                if (int.Parse(ModPartIDBox.Text).GetType() != typeof(int) || int.Parse(ModPartInvBox.Text).GetType() != typeof(int) || int.Parse(ModPartMinBox.Text).GetType() != typeof(int) || int.Parse(ModPartMaxBox.Text).GetType() != typeof(int))
                {
                    MessageBox.Show("Fields that require integers must contain integers.");
                    return;
                }

                if (decimal.Parse(ModPartPriceBox.Text).GetType() != typeof(decimal))
                {
                    MessageBox.Show("Price must be a decimal. Example: 0.00");
                    return;
                }

                if (int.Parse(ModPartInvBox.Text) > int.Parse(ModPartMaxBox.Text))
                {
                    MessageBox.Show("Inventory cannot exceed Maximum.");
                    return;
                }

                if (int.Parse(ModPartMinBox.Text) > int.Parse(ModPartMaxBox.Text))
                {
                    MessageBox.Show("Minimum cannot exceed Maximum.");
                    return;
                }
                else
                {
                    try
                    {
                        Inhouse inhousePart = new Inhouse(int.Parse(ModPartIDBox.Text), ModPartName.Text, decimal.Parse(ModPartPriceBox.Text), int.Parse(ModPartInvBox.Text), int.Parse(ModPartMinBox.Text), int.Parse(ModPartMaxBox.Text), int.Parse(MdPrtMac.Text));
                        Inventory.UpdatePart(int.Parse(ModPartIDBox.Text), inhousePart);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Program Error.");
                        throw;
                    }
                    this.Close();

                }
            }
            else
            {
                ModPartInRadio.Checked = false;

                if (String.IsNullOrWhiteSpace(ModPartIDBox.Text) || String.IsNullOrWhiteSpace(ModPartName.Text) || String.IsNullOrWhiteSpace(ModPartPriceBox.Text) || String.IsNullOrWhiteSpace(ModPartInvBox.Text) || String.IsNullOrWhiteSpace(ModPartMinBox.Text) || String.IsNullOrWhiteSpace(ModPartMaxBox.Text))
                {
                    MessageBox.Show("All fields must have a value.");
                    return;
                }

                if (int.Parse(ModPartIDBox.Text).GetType() != typeof(int) || int.Parse(ModPartInvBox.Text).GetType() != typeof(int) || int.Parse(ModPartMinBox.Text).GetType() != typeof(int) || int.Parse(ModPartMaxBox.Text).GetType() != typeof(int))
                {
                    MessageBox.Show("Fields that require integers must contain integers.");
                    return;
                }

                if (decimal.Parse(ModPartPriceBox.Text).GetType() != typeof(decimal))
                {
                    MessageBox.Show("Price must be a decimal Example: 0.00.");
                    return;
                }

                if (int.Parse(ModPartInvBox.Text) > int.Parse(ModPartMaxBox.Text))
                {
                    MessageBox.Show("Inventory cannot exceed Maximum.");
                    return;
                }

                if (int.Parse(ModPartMinBox.Text) > int.Parse(ModPartMaxBox.Text))
                {
                    MessageBox.Show("Minimum cannot exceed Maximum.");
                    return;
                }
                else
                {
                    try
                    {
                        Outsourced outsourcedPart = new Outsourced(int.Parse(ModPartIDBox.Text), ModPartName.Text, decimal.Parse(ModPartPriceBox.Text), int.Parse(ModPartInvBox.Text), int.Parse(ModPartMinBox.Text), int.Parse(ModPartMaxBox.Text), MdPrtMac.Text);
                        Inventory.UpdatePart(int.Parse(ModPartIDBox.Text), outsourcedPart);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Program Error.");
                        throw;
                    }
                    this.Close();
                }
            }
        }
        private void ModPartCxl_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}