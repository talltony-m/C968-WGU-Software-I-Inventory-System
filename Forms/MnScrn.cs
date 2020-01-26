using System;
using System.Windows.Forms;

namespace ISS
{
    public partial class MnScrn : Form
    {
        Product product = new Product();
        public MnScrn()
        {
            InitializeComponent();
            InitializeProductsAndParts();
            RefreshGridViews();
        }
        public void MnScrn_Load(object sender, EventArgs e)
        {
            RefreshGridViews();
        }
        public static void InitializeProductsAndParts()
        {
            Inventory.Products.Add(new Product(001, "Apollo Spa", 9750.99m, 20, 0, 100));
            Inventory.Products.Add(new Product(002, "Zeus Spa", 8500.99m, 30, 0, 100));
            Inventory.Products.Add(new Product(003, "Ares Spa", 7890.99m, 40, 0, 100));
            Inventory.Products.Add(new Product(004, "Athena Spa", 6999.99m, 50, 0, 100));

            Inventory.Parts.Add(new Inhouse(100, "Grey Cabinet", 499.50m, 50, 0, 100, 1100));
            Inventory.Parts.Add(new Inhouse(105, "Brown Cabinet", 450.99m, 20, 0, 100, 1105));
            Inventory.Parts.Add(new Inhouse(200, "Grey Cover", 150.50m, 50, 0, 100, 2200));
            Inventory.Parts.Add(new Inhouse(205, "Brown Cover", 150.50m, 20, 0, 100, 2205));

            Inventory.Parts.Add(new Outsourced(911, "Heater", 125.00m, 70, 0, 100, "Balboa"));
            Inventory.Parts.Add(new Outsourced(912, "Cotnrol Panel", 150.99m, 75, 0, 100, "Balboa"));
            Inventory.Parts.Add(new Outsourced(913, "PC Board", 349.50m, 99, 0, 100, "Balboa"));

            Inventory.LookupProduct(001).AddAssociatedPart(Inventory.LookupPart(100));
            Inventory.LookupProduct(001).AddAssociatedPart(Inventory.LookupPart(200));
            Inventory.LookupProduct(001).AddAssociatedPart(Inventory.LookupPart(911));
            Inventory.LookupProduct(001).AddAssociatedPart(Inventory.LookupPart(912));
            Inventory.LookupProduct(001).AddAssociatedPart(Inventory.LookupPart(913));

            Inventory.LookupProduct(002).AddAssociatedPart(Inventory.LookupPart(105));
            Inventory.LookupProduct(002).AddAssociatedPart(Inventory.LookupPart(205));
            Inventory.LookupProduct(002).AddAssociatedPart(Inventory.LookupPart(911));
            Inventory.LookupProduct(002).AddAssociatedPart(Inventory.LookupPart(912));
            Inventory.LookupProduct(002).AddAssociatedPart(Inventory.LookupPart(913));

            Inventory.LookupProduct(003).AddAssociatedPart(Inventory.LookupPart(100));
            Inventory.LookupProduct(003).AddAssociatedPart(Inventory.LookupPart(200));
            Inventory.LookupProduct(003).AddAssociatedPart(Inventory.LookupPart(911));
            Inventory.LookupProduct(003).AddAssociatedPart(Inventory.LookupPart(912));
            Inventory.LookupProduct(003).AddAssociatedPart(Inventory.LookupPart(913));

            Inventory.LookupProduct(004).AddAssociatedPart(Inventory.LookupPart(105));
            Inventory.LookupProduct(004).AddAssociatedPart(Inventory.LookupPart(205));
            Inventory.LookupProduct(004).AddAssociatedPart(Inventory.LookupPart(911));
            Inventory.LookupProduct(004).AddAssociatedPart(Inventory.LookupPart(912));
            Inventory.LookupProduct(004).AddAssociatedPart(Inventory.LookupPart(913));
        }
        public static int ModPrtIndx { get; set; }
        public void RefreshGridViews()
        {
            DgPrt.DataSource = Inventory.Parts;
            DgPrt.ClearSelection();

            DgPro.DataSource = Inventory.Products;
            DgPro.ClearSelection();
        }

        private void PartAddButton_Click_1(object sender, EventArgs e)
        {
            AddPrt addPartForm = new AddPrt();
            addPartForm.Show();
        }

        private void MnPrtSrcBtn_Click_1(object sender, EventArgs e)
        {
            if (SrchPrtBx.TextLength < 0)
            {
                return;
            }
            else
            {
                try
                {
                    foreach (DataGridViewRow row in DgPrt.Rows)
                    {
                        Part part = (Part)row.DataBoundItem;
                        Part userEntry = Inventory.LookupPart(Convert.ToInt32(SrchPrtBx.Text));

                        if (userEntry.PartID == part?.PartID)
                        {
                            row.Selected = true;
                            DgPrt.CurrentCell = row.Cells[0];
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

        private void MnProSrcBtn_Click_1(object sender, EventArgs e)
        {

            if (SrchProBx.TextLength < 0)
            {
                return;
            }
            else
            {
                try
                {
                    foreach (DataGridViewRow row in DgPro.Rows)
                    {
                        Product product = (Product)row.DataBoundItem;
                        Product userEntry = Inventory.LookupProduct(Convert.ToInt32(SrchProBx.Text));

                        if (userEntry.ProductID == product?.ProductID)
                        {
                            row.Selected = true;
                            DgPro.CurrentCell = row.Cells[0];
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

        private void PartModButton_Click_1(object sender, EventArgs e)
        {
            //ModPrtIndx = DgPrt.CurrentRow.Index;
            if (DgPrt.CurrentRow.DataBoundItem.GetType() == typeof(Inhouse))
            {
                Inhouse inhousePart = (Inhouse)DgPrt.CurrentRow.DataBoundItem;
                new MdPrt(inhousePart).ShowDialog();
            }
            else if (DgPrt.CurrentRow.DataBoundItem.GetType() == typeof(Outsourced))
            {
                Outsourced outsourcedPart = (Outsourced)DgPrt.CurrentRow.DataBoundItem;
                new MdPrt(outsourcedPart).ShowDialog();
            }
        }

        private void PrtDltBtn_Click_1(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure you want to delete?", "Delete?", MessageBoxButtons.OKCancel);
            {
                if (confirm == DialogResult.OK)
                {
                    var rowIndex = DgPrt.CurrentCell.RowIndex;
                    DgPrt.Rows.RemoveAt(rowIndex);
                    product.RemoveAssociatePart(rowIndex);
                }
                else return;
            }
        }

        private void ProAddButton_Click_1(object sender, EventArgs e)
        {
            new AddPro().ShowDialog();
        }

        private void ProModButton_Click_1(object sender, EventArgs e)
        {
            Product product = (Product)DgPro.CurrentRow.DataBoundItem;
            new ModPro(product).ShowDialog();
        }

        private void ProDltBtn_Click_1(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure you want to delete?", "Delete?", MessageBoxButtons.OKCancel);
            if (confirm == DialogResult.OK)
            {
                Product product = (Product)DgPro.CurrentRow.DataBoundItem;
                if (product.AssociatedParts.Count > 0)
                {
                    MessageBox.Show("Remove Associated Part before removing a Product.");
                }
                else
                {
                    var rowIndex = DgPro.CurrentCell.RowIndex;
                    DgPro.Rows.RemoveAt(rowIndex);
                }
            }
            else return;
        }

        private void ExitButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DgPrt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Inventory.prtIndex = DgPrt.CurrentCell.RowIndex;
        }
    }
}
