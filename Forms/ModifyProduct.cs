using System;
using System.Windows.Forms;

namespace ISS
{
    public partial class ModPro : Form
    {
        public ModPro(Product product)
        {
            InitializeComponent();

            ModProIDbox.Text = Convert.ToString(product.ProductID);
            ModProNameBx.Text = product.Name;
            ModProInvBx.Text = Convert.ToString(product.InStock);
            ModProPriceBx.Text = Convert.ToString(product.Price);
            ModProMnBx.Text = Convert.ToString(product.Min);
            ModProMxBx.Text = Convert.ToString(product.Max);

            AddProCanPartGrid.DataSource = Inventory.Parts;
            AssocPartGrid.DataSource = product.AssociatedParts;
        }

        private void ModPro_Load(object sender, EventArgs e)
        {

        }

        private void MdProSrchBtn_Click_1(object sender, EventArgs e)
        {
            if (MdProSrchbx.TextLength < 0)
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
                        Part userEntry = Inventory.LookupPart(Convert.ToInt32(MdProSrchbx.Text));

                        if (userEntry.PartID == part.PartID)
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
                catch { }
            }
        }

        private void MdProSrchbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void ModProIDbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ModProNameBx_TextChanged(object sender, EventArgs e)
        {

        }

        private void ModProInvBx_TextChanged(object sender, EventArgs e)
        {

        }

        private void ModProPriceBx_TextChanged(object sender, EventArgs e)
        {

        }

        private void ModProMxBx_TextChanged(object sender, EventArgs e)
        {

        }

        private void ModProMnBx_TextChanged(object sender, EventArgs e)
        {

        }

        private void ModProAddbtn_Click_1(object sender, EventArgs e)
        {
            int productID = Convert.ToInt32(ModProIDbox.Text);
            int partID = Convert.ToInt32(AddProCanPartGrid.Rows[AddProCanPartGrid.CurrentCell.RowIndex].Cells[0].Value);
            Product product = Inventory.LookupProduct(productID);
            Part part = Inventory.LookupPart(partID);
            Inventory.UpdateProduct(productID, product);
            product.AddAssociatedPart(part);
            AssocPartGrid.DataSource = product.AssociatedParts;
        }

        private void ModProDeleteBtn_Click_1(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Confirm Delete.", "Delete?", MessageBoxButtons.OKCancel);
            {
                if (confirm == DialogResult.OK)
                {
                    var rowIndex = AssocPartGrid.CurrentCell.RowIndex;
                    AssocPartGrid.Rows.RemoveAt(rowIndex);
                }
                else return;
            }
        }

        private void MdProSvBtn_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(ModProIDbox.Text) || String.IsNullOrWhiteSpace(ModProNameBx.Text) || String.IsNullOrWhiteSpace(ModProPriceBx.Text) || String.IsNullOrWhiteSpace(ModProInvBx.Text) || String.IsNullOrWhiteSpace(ModProMnBx.Text) || String.IsNullOrWhiteSpace(ModProMxBx.Text))
            {
                MessageBox.Show("Fields cannot be empty.");
                return;
            }
            if (int.Parse(ModProIDbox.Text).GetType() != typeof(int) || int.Parse(ModProInvBx.Text).GetType() != typeof(int) || int.Parse(ModProMnBx.Text).GetType() != typeof(int) || int.Parse(ModProMxBx.Text).GetType() != typeof(int))
            {
                MessageBox.Show("Fields that require integers must contain integers.");
                return;
            }
            if (decimal.Parse(ModProPriceBx.Text).GetType() != typeof(decimal))
            {
                MessageBox.Show("Price must be a decimal. Example: 0.00");
                return;
            }
            if (int.Parse(ModProInvBx.Text) > int.Parse(ModProMxBx.Text))
            {
                MessageBox.Show("Inventory cannot exceed Maximum.");
                return;
            }
            if (int.Parse(ModProMnBx.Text) > int.Parse(ModProMxBx.Text))
            {
                MessageBox.Show("Minimum cannot exceed Maximum.");
                return;
            }
            else
            {
                try
                {
                    Product product = new Product(int.Parse(ModProIDbox.Text), ModProNameBx.Text, decimal.Parse(ModProPriceBx.Text), int.Parse(ModProInvBx.Text), int.Parse(ModProMnBx.Text), int.Parse(ModProMxBx.Text));
                    try
                    {
                        foreach (DataGridViewRow row in AssocPartGrid.Rows)
                        {
                            Part associatedPart = (Part)row.DataBoundItem;
                            product.AssociatedParts.Add(associatedPart);
                        }
                    }
                    catch { throw; }
                    Inventory.UpdateProduct(int.Parse(ModProIDbox.Text), product);
                }
                catch (Exception)
                {
                    MessageBox.Show("Program Error.");
                    throw;
                }
                this.Close();
            }
        }

        private void MoPrtCxlBtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}