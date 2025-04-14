namespace Assignment2
{
    public partial class window : Form
    {
        public window()
        {
            InitializeComponent();
        }

        private void window_Load(object sender, EventArgs e)
        {
            Item.LoadItems();
            foreach (Item i in Item.Items.Values)
                data.Rows.Add(i.GetId(), i.GetType(), i.GetCut(), i.GetColor(), i.GetFabric(),
                              i.GetSize(), i.GetBrand(), i.GetBasePrice(), i.GetSurcharge(),
                              i.GetPrice());
        }

        private void data_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (data.Rows.Count <= 0) return;
            if (data.Rows[e.RowIndex].Cells[0].Value == null) return;

            int Id = int.Parse(data.Rows[e.RowIndex].Cells[0].Value.ToString());
            Item item = Item.Items[Id];

            if (item == null) return;

            textbox_id.Text = item.GetId().ToString();
            textbox_type.Text = item.GetType();
            textbox_cut.Text = item.GetCut();
            textbox_color.Text = item.GetColor();
            textbox_fabric.Text = item.GetFabric();
            textbox_size.Text = item.GetSize();
            textbox_brand.Text = item.GetBrand();
            textbox_basePrice.Text = item.GetBasePrice().ToString();
            textbox_surcharge.Text = item.GetSurcharge().ToString();
            textbox_type.Enabled = true;
            textbox_cut.Enabled = true;
            textbox_color.Enabled = true;
            textbox_fabric.Enabled = true;
            textbox_size.Enabled = true;
            textbox_brand.Enabled = true;
            textbox_basePrice.Enabled = true;
            if (item.GetSurcharge() != 0)
            {
                textbox_surcharge.Enabled = true;
                checkbox_special.Checked = true;
            }
            checkbox_special.Enabled = true;

            button_delete.Enabled = true;
        }

        private void button_new_Click(object sender, EventArgs e)
        {
            const string CONTENT = "";

            textbox_id.Text = CONTENT;
            textbox_type.Text = CONTENT;
            textbox_cut.Text = CONTENT;
            textbox_color.Text = CONTENT;
            textbox_fabric.Text = CONTENT;
            textbox_size.Text = CONTENT;
            textbox_brand.Text = CONTENT;
            textbox_basePrice.Text = CONTENT;
            textbox_surcharge.Text = CONTENT;

            button_delete.Enabled = false;

            textbox_type.Enabled = true;
            textbox_cut.Enabled = true;
            textbox_color.Enabled = true;
            textbox_fabric.Enabled = true;
            textbox_size.Enabled = true;
            textbox_brand.Enabled = true;
            textbox_basePrice.Enabled = true;
            checkbox_special.Enabled = true;
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textbox_id.Text))
            {
                if (!CheckIsRightToSave()) return;

                double? surcharge = 0;
                if (textbox_surcharge.Text != "") surcharge = double.Parse(textbox_surcharge.Text);

                Item item = new Item(textbox_type.Text, textbox_cut.Text, textbox_color.Text,
                                     textbox_fabric.Text, textbox_size.Text, textbox_brand.Text,
                                     double.Parse(textbox_basePrice.Text), surcharge);

                Item.SaveItems();
                data.Rows.Add(item.GetId(), item.GetType(), item.GetCut(), item.GetColor(), item.GetFabric(),
                              item.GetSize(), item.GetBrand(), item.GetBasePrice(), item.GetSurcharge(), item.GetPrice());
            }
            else
            {
                if (!CheckIsRightToSave()) return;

                Item item = Item.GetItem(int.Parse(textbox_id.Text));

                if (item.Type != textbox_type.Text || item.Cut != textbox_cut.Text ||
                    item.Color != textbox_color.Text || item.Fabric != textbox_fabric.Text ||
                    item.Size != textbox_size.Text || item.Brand != textbox_brand.Text ||
                    item.BasePrice != double.Parse(textbox_basePrice.Text) ||
                    item.Surcharge != double.Parse(textbox_surcharge.Text))
                {
                    item.Type = textbox_type.Text;
                    item.Cut = textbox_cut.Text;
                    item.Color = textbox_color.Text;
                    item.Fabric = textbox_fabric.Text;
                    item.Size = textbox_size.Text;
                    item.Brand = textbox_brand.Text;
                    item.BasePrice = double.Parse(textbox_basePrice.Text);
                    if (textbox_surcharge.Text != "") item.Surcharge = double.Parse(textbox_surcharge.Text);
                    else item.Surcharge = null;

                    data.CurrentRow.Cells[1].Value = item.Type;
                    data.CurrentRow.Cells[2].Value = item.Cut;
                    data.CurrentRow.Cells[3].Value = item.Color;
                    data.CurrentRow.Cells[4].Value = item.Fabric;
                    data.CurrentRow.Cells[5].Value = item.Size;
                    data.CurrentRow.Cells[6].Value = item.Brand;
                    data.CurrentRow.Cells[7].Value = item.BasePrice;
                    data.CurrentRow.Cells[8].Value = item.Surcharge;
                    data.CurrentRow.Cells[9].Value = item.GetPrice();

                    Item.SaveItems();
                }
                else
                {
                    Console.WriteLine(textbox_surcharge.Text);
                    MessageBox.Show("No changes detected.");
                    return;
                }
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            Item.Items.Remove(int.Parse(data.CurrentRow.Cells[0].Value.ToString()));
            Item.SaveItems();
            data.Rows.RemoveAt(data.CurrentRow.Index);
        }

        private void checkbox_special_CheckedChanged(object sender, EventArgs e)
        {
            if (textbox_surcharge.Enabled = true)
            {
                if (checkbox_special.Checked) textbox_surcharge.Enabled = true;
                else
                {
                    textbox_surcharge.Text = "0";
                    textbox_surcharge.Enabled = false;
                }
            }
        }

        private void button_byType_Click(object sender, EventArgs e)
        {
            if (!CheckSearchBox()) return;

            foreach (DataGridViewRow row in data.Rows)
            {
                if (row.Cells[1].Value.ToString() == textbox_search.Text)
                    row.Visible = true;
                else row.Visible = false;
            }
        }

        private void button_bySize_Click(object sender, EventArgs e)
        {
            if (!CheckSearchBox()) return;

            foreach (DataGridViewRow row in data.Rows)
            {
                if (row.Cells[5].Value.ToString() == textbox_search.Text)
                    row.Visible = true;
                else row.Visible = false;
            }
        }

        private void button_byColor_Click(object sender, EventArgs e)
        {
            if (!CheckSearchBox()) return;

            foreach (DataGridViewRow row in data.Rows)
            {
                if (row.Cells[3].Value.ToString() == textbox_search.Text)
                    row.Visible = true;
                else row.Visible = false;
            }
        }

        //? Additional functions
        private bool CheckIsRightToSave()
        {
            if (textbox_type.Text == "" || textbox_cut.Text == "" || textbox_color.Text == "" ||
                    textbox_fabric.Text == "" || textbox_size.Text == "" || textbox_brand.Text == "" ||
                    textbox_basePrice.Text == "")
            {
                MessageBox.Show("Please fill in all required fields.");
                return false;
            }
            if (!double.TryParse(textbox_basePrice.Text, out _) ||
                !string.IsNullOrEmpty(textbox_surcharge.Text))
            {
                if (!double.TryParse(textbox_basePrice.Text, out _) ||
                    !double.TryParse(textbox_surcharge.Text, out _))
                {
                    MessageBox.Show("Please enter a valid base price.");
                    return false;
                }
            }

            return true;
        }

        private bool CheckSearchBox()
        {
            if (textbox_search.Text == "")
            {
                MessageBox.Show("Please enter a type.");
                return false;
            }

            return true;
        }

        private void textbox_search_TextChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow Row in data.Rows) Row.Visible = true;
        }
    }
}
