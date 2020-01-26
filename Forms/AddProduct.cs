using System;
using System.Windows.Forms;

namespace ISS
{
    public partial class AddPro : Form
    {
        Product product = new Product();
        public AddPro()
        {
            InitializeComponent();

            AddProCanPartGrid.DataSource = Inventory.Parts;
            AssocPartGrid.DataSource = product.AssociatedParts;
        }
        private void AddPro_Load(object sender, EventArgs e)
        {

        }

        private void AdProSearhBtn_Click_1(object sender, EventArgs e)
        {
            if (AddProSearchbox.TextLength < 0)
            {
                return;
            }
            else
            {
                try
                {
                    foreach (DataGridViewRow row in AddProCanPartGrid.Rows)
                    {
                        Part part = (Part)row.DataBoundItem;
                        Part userEntry = Inventory.LookupPart(Convert.ToInt32(AddProSearchbox.Text));

                        if (userEntry.PartID == part?.PartID)
                        {
                            row.Selected = true;
                            AddProCanPartGrid.CurrentCell = row.Cells[0];
                            return;
                        }
                        else
                        {
                            row.Selected = false;
                        }
                    }
                }
                catch
                {
                }
            }
        }

        private void AddProSearchbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddProTxtBx_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdProNmBx_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdProInvBx_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdProPrcBx_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdProMxBx_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdProMnBx_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddProBtn_Click_1(object sender, EventArgs e)
        {
            Part part = (Part)AddProCanPartGrid.CurrentRow.DataBoundItem;
            product.AddAssociatedPart(part);
        }

        private void DelProBtn_Click_1(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Confirm Delete", "Delete?", MessageBoxButtons.OKCancel);
            {
                if (confirm == DialogResult.OK)
                {
                    var rowIndex = AssocPartGrid.CurrentCell.RowIndex;
                    AssocPartGrid.Rows.RemoveAt(rowIndex);
                }
                else return;
            }
        }

        private void AddProSvBtn_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(AddProTxtBx.Text) || String.IsNullOrWhiteSpace(AdProNmBx.Text) || String.IsNullOrWhiteSpace(AdProPrcBx.Text) || String.IsNullOrWhiteSpace(AdProPrcBx.Text) || String.IsNullOrWhiteSpace(AdProInvBx.Text) || String.IsNullOrWhiteSpace(AdProMxBx.Text))
            {
                MessageBox.Show("Fields cannot be empty.");
                return;
            }

            if (int.Parse(AddProTxtBx.Text).GetType() != typeof(int) || int.Parse(AdProInvBx.Text).GetType() != typeof(int) || int.Parse(AdProMnBx.Text).GetType() != typeof(int) || int.Parse(AdProMxBx.Text).GetType() != typeof(int))
            {
                MessageBox.Show("Fields that require integers must contain integers.");
                return;
            }

            if (decimal.Parse(AdProPrcBx.Text).GetType() != typeof(decimal))
            {
                MessageBox.Show("Price must be a decimal. Example: 0.00");
                return;
            }

            if (int.Parse(AdProInvBx.Text) > int.Parse(AdProMxBx.Text))
            {
                MessageBox.Show("Inventory cannot exceed Maximum.");
                return;
            }

            if (int.Parse(AdProMnBx.Text) > int.Parse(AdProMxBx.Text))
            {
                MessageBox.Show("Minimum cannot exceed Maximum.");
                return;
            }
            else
            {
                try
                {
                    Product product = new Product(int.Parse(AddProTxtBx.Text), AdProNmBx.Text, decimal.Parse(AdProPrcBx.Text), int.Parse(AdProInvBx.Text), int.Parse(AdProMnBx.Text), int.Parse(AdProMxBx.Text));
                    try
                    {
                        foreach (DataGridViewRow row in AssocPartGrid.Rows)
                        {
                            Part associatedPart = (Part)row.DataBoundItem;
                            product.AssociatedParts.Add(associatedPart);
                        }
                    }
                    catch { throw; }
                    Inventory.AddProduct(product);
                }
                catch (Exception)
                {
                    MessageBox.Show("Something went wrong.");
                    throw;
                }
                this.Close();
            }
        }

        private void AdProCxlBtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}