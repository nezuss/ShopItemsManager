namespace Assignment2
{
    partial class window
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            data = new DataGridView();
            data_id = new DataGridViewTextBoxColumn();
            data_type = new DataGridViewTextBoxColumn();
            data_cut = new DataGridViewTextBoxColumn();
            data_color = new DataGridViewTextBoxColumn();
            data_fabric = new DataGridViewTextBoxColumn();
            data_size = new DataGridViewTextBoxColumn();
            data_brand = new DataGridViewTextBoxColumn();
            data_basePrice = new DataGridViewTextBoxColumn();
            data_surcharge = new DataGridViewTextBoxColumn();
            data_total = new DataGridViewTextBoxColumn();
            button_new = new Button();
            textbox_type = new TextBox();
            textbox_type_label = new Label();
            textbox_cut_label = new Label();
            textbox_cut = new TextBox();
            textbox_color_label = new Label();
            textbox_color = new TextBox();
            textbox_fabric_label = new Label();
            textbox_fabric = new TextBox();
            textbox_size_label = new Label();
            textbox_size = new TextBox();
            textbox_brand_label = new Label();
            textbox_brand = new TextBox();
            textbox_basePrice_label = new Label();
            textbox_basePrice = new TextBox();
            textbox_surcharge_label = new Label();
            textbox_surcharge = new TextBox();
            button_save = new Button();
            button_delete = new Button();
            textbox_id = new TextBox();
            textbox_id_label = new Label();
            checkbox_special = new CheckBox();
            textbox_search = new TextBox();
            button_byColor = new Button();
            button_bySize = new Button();
            button_byType = new Button();
            ((System.ComponentModel.ISupportInitialize)data).BeginInit();
            SuspendLayout();
            // 
            // data
            // 
            data.AllowUserToAddRows = false;
            data.AllowUserToDeleteRows = false;
            data.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data.Columns.AddRange(new DataGridViewColumn[] { data_id, data_type, data_cut, data_color, data_fabric, data_size, data_brand, data_basePrice, data_surcharge, data_total });
            data.Location = new Point(0, 33);
            data.Name = "data";
            data.ReadOnly = true;
            data.Size = new Size(527, 477);
            data.TabIndex = 0;
            data.RowEnter += data_RowEnter;
            // 
            // data_id
            // 
            data_id.HeaderText = "Id";
            data_id.Name = "data_id";
            data_id.ReadOnly = true;
            data_id.Width = 30;
            // 
            // data_type
            // 
            data_type.HeaderText = "Type";
            data_type.Name = "data_type";
            data_type.ReadOnly = true;
            // 
            // data_cut
            // 
            data_cut.HeaderText = "Cut";
            data_cut.Name = "data_cut";
            data_cut.ReadOnly = true;
            // 
            // data_color
            // 
            data_color.HeaderText = "Color";
            data_color.Name = "data_color";
            data_color.ReadOnly = true;
            // 
            // data_fabric
            // 
            data_fabric.HeaderText = "Fabric";
            data_fabric.Name = "data_fabric";
            data_fabric.ReadOnly = true;
            // 
            // data_size
            // 
            data_size.HeaderText = "Size";
            data_size.Name = "data_size";
            data_size.ReadOnly = true;
            // 
            // data_brand
            // 
            data_brand.HeaderText = "Brand";
            data_brand.Name = "data_brand";
            data_brand.ReadOnly = true;
            // 
            // data_basePrice
            // 
            data_basePrice.HeaderText = "Base price";
            data_basePrice.Name = "data_basePrice";
            data_basePrice.ReadOnly = true;
            // 
            // data_surcharge
            // 
            data_surcharge.HeaderText = "Surcharge";
            data_surcharge.Name = "data_surcharge";
            data_surcharge.ReadOnly = true;
            // 
            // data_total
            // 
            data_total.HeaderText = "Total";
            data_total.Name = "data_total";
            data_total.ReadOnly = true;
            // 
            // button_new
            // 
            button_new.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_new.Location = new Point(547, 475);
            button_new.Name = "button_new";
            button_new.Size = new Size(78, 23);
            button_new.TabIndex = 1;
            button_new.Text = "New";
            button_new.UseVisualStyleBackColor = true;
            button_new.Click += button_new_Click;
            // 
            // textbox_type
            // 
            textbox_type.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textbox_type.BorderStyle = BorderStyle.FixedSingle;
            textbox_type.Enabled = false;
            textbox_type.Location = new Point(547, 78);
            textbox_type.Name = "textbox_type";
            textbox_type.Size = new Size(241, 23);
            textbox_type.TabIndex = 2;
            // 
            // textbox_type_label
            // 
            textbox_type_label.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textbox_type_label.AutoSize = true;
            textbox_type_label.Location = new Point(547, 60);
            textbox_type_label.Name = "textbox_type_label";
            textbox_type_label.Size = new Size(36, 15);
            textbox_type_label.TabIndex = 3;
            textbox_type_label.Text = "Type*";
            // 
            // textbox_cut_label
            // 
            textbox_cut_label.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textbox_cut_label.AutoSize = true;
            textbox_cut_label.Location = new Point(547, 109);
            textbox_cut_label.Name = "textbox_cut_label";
            textbox_cut_label.Size = new Size(31, 15);
            textbox_cut_label.TabIndex = 5;
            textbox_cut_label.Text = "Cut*";
            // 
            // textbox_cut
            // 
            textbox_cut.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textbox_cut.BorderStyle = BorderStyle.FixedSingle;
            textbox_cut.Enabled = false;
            textbox_cut.Location = new Point(547, 127);
            textbox_cut.Name = "textbox_cut";
            textbox_cut.Size = new Size(241, 23);
            textbox_cut.TabIndex = 4;
            // 
            // textbox_color_label
            // 
            textbox_color_label.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textbox_color_label.AutoSize = true;
            textbox_color_label.Location = new Point(547, 158);
            textbox_color_label.Name = "textbox_color_label";
            textbox_color_label.Size = new Size(41, 15);
            textbox_color_label.TabIndex = 7;
            textbox_color_label.Text = "Color*";
            // 
            // textbox_color
            // 
            textbox_color.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textbox_color.BorderStyle = BorderStyle.FixedSingle;
            textbox_color.Enabled = false;
            textbox_color.Location = new Point(547, 176);
            textbox_color.Name = "textbox_color";
            textbox_color.Size = new Size(241, 23);
            textbox_color.TabIndex = 6;
            // 
            // textbox_fabric_label
            // 
            textbox_fabric_label.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textbox_fabric_label.AutoSize = true;
            textbox_fabric_label.Location = new Point(547, 207);
            textbox_fabric_label.Name = "textbox_fabric_label";
            textbox_fabric_label.Size = new Size(44, 15);
            textbox_fabric_label.TabIndex = 9;
            textbox_fabric_label.Text = "Fabric*";
            // 
            // textbox_fabric
            // 
            textbox_fabric.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textbox_fabric.BorderStyle = BorderStyle.FixedSingle;
            textbox_fabric.Enabled = false;
            textbox_fabric.Location = new Point(547, 225);
            textbox_fabric.Name = "textbox_fabric";
            textbox_fabric.Size = new Size(241, 23);
            textbox_fabric.TabIndex = 8;
            // 
            // textbox_size_label
            // 
            textbox_size_label.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textbox_size_label.AutoSize = true;
            textbox_size_label.Location = new Point(547, 255);
            textbox_size_label.Name = "textbox_size_label";
            textbox_size_label.Size = new Size(32, 15);
            textbox_size_label.TabIndex = 11;
            textbox_size_label.Text = "Size*";
            // 
            // textbox_size
            // 
            textbox_size.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textbox_size.BorderStyle = BorderStyle.FixedSingle;
            textbox_size.Enabled = false;
            textbox_size.Location = new Point(547, 273);
            textbox_size.Name = "textbox_size";
            textbox_size.Size = new Size(241, 23);
            textbox_size.TabIndex = 10;
            // 
            // textbox_brand_label
            // 
            textbox_brand_label.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textbox_brand_label.AutoSize = true;
            textbox_brand_label.Location = new Point(547, 302);
            textbox_brand_label.Name = "textbox_brand_label";
            textbox_brand_label.Size = new Size(43, 15);
            textbox_brand_label.TabIndex = 13;
            textbox_brand_label.Text = "Brand*";
            // 
            // textbox_brand
            // 
            textbox_brand.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textbox_brand.BorderStyle = BorderStyle.FixedSingle;
            textbox_brand.Enabled = false;
            textbox_brand.Location = new Point(547, 320);
            textbox_brand.Name = "textbox_brand";
            textbox_brand.Size = new Size(241, 23);
            textbox_brand.TabIndex = 12;
            // 
            // textbox_basePrice_label
            // 
            textbox_basePrice_label.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textbox_basePrice_label.AutoSize = true;
            textbox_basePrice_label.Location = new Point(547, 353);
            textbox_basePrice_label.Name = "textbox_basePrice_label";
            textbox_basePrice_label.Size = new Size(65, 15);
            textbox_basePrice_label.TabIndex = 15;
            textbox_basePrice_label.Text = "Base price*";
            // 
            // textbox_basePrice
            // 
            textbox_basePrice.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textbox_basePrice.BorderStyle = BorderStyle.FixedSingle;
            textbox_basePrice.Enabled = false;
            textbox_basePrice.Location = new Point(547, 371);
            textbox_basePrice.Name = "textbox_basePrice";
            textbox_basePrice.Size = new Size(241, 23);
            textbox_basePrice.TabIndex = 14;
            // 
            // textbox_surcharge_label
            // 
            textbox_surcharge_label.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textbox_surcharge_label.AutoSize = true;
            textbox_surcharge_label.Location = new Point(547, 402);
            textbox_surcharge_label.Name = "textbox_surcharge_label";
            textbox_surcharge_label.Size = new Size(60, 15);
            textbox_surcharge_label.TabIndex = 17;
            textbox_surcharge_label.Text = "Surcharge";
            // 
            // textbox_surcharge
            // 
            textbox_surcharge.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textbox_surcharge.BorderStyle = BorderStyle.FixedSingle;
            textbox_surcharge.Enabled = false;
            textbox_surcharge.Location = new Point(547, 420);
            textbox_surcharge.Name = "textbox_surcharge";
            textbox_surcharge.Size = new Size(241, 23);
            textbox_surcharge.TabIndex = 16;
            // 
            // button_save
            // 
            button_save.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_save.Location = new Point(629, 475);
            button_save.Name = "button_save";
            button_save.Size = new Size(78, 23);
            button_save.TabIndex = 20;
            button_save.Text = "Save";
            button_save.UseVisualStyleBackColor = true;
            button_save.Click += button_save_Click;
            // 
            // button_delete
            // 
            button_delete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_delete.Enabled = false;
            button_delete.Location = new Point(710, 475);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(78, 23);
            button_delete.TabIndex = 22;
            button_delete.Text = "Delete";
            button_delete.UseVisualStyleBackColor = true;
            button_delete.Click += button_delete_Click;
            // 
            // textbox_id
            // 
            textbox_id.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textbox_id.BorderStyle = BorderStyle.FixedSingle;
            textbox_id.Enabled = false;
            textbox_id.Location = new Point(547, 30);
            textbox_id.Name = "textbox_id";
            textbox_id.Size = new Size(241, 23);
            textbox_id.TabIndex = 23;
            // 
            // textbox_id_label
            // 
            textbox_id_label.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textbox_id_label.AutoSize = true;
            textbox_id_label.Location = new Point(547, 12);
            textbox_id_label.Name = "textbox_id_label";
            textbox_id_label.Size = new Size(17, 15);
            textbox_id_label.TabIndex = 24;
            textbox_id_label.Text = "Id";
            // 
            // checkbox_special
            // 
            checkbox_special.Enabled = false;
            checkbox_special.Location = new Point(547, 446);
            checkbox_special.Margin = new Padding(0);
            checkbox_special.Name = "checkbox_special";
            checkbox_special.Size = new Size(76, 20);
            checkbox_special.TabIndex = 25;
            checkbox_special.Text = "Is special";
            checkbox_special.UseVisualStyleBackColor = true;
            checkbox_special.CheckedChanged += checkbox_special_CheckedChanged;
            // 
            // textbox_search
            // 
            textbox_search.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textbox_search.BorderStyle = BorderStyle.FixedSingle;
            textbox_search.Location = new Point(0, 4);
            textbox_search.Name = "textbox_search";
            textbox_search.Size = new Size(275, 23);
            textbox_search.TabIndex = 26;
            textbox_search.TextChanged += textbox_search_TextChanged;
            // 
            // button_byColor
            // 
            button_byColor.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_byColor.Location = new Point(449, 4);
            button_byColor.Name = "button_byColor";
            button_byColor.Size = new Size(78, 23);
            button_byColor.TabIndex = 27;
            button_byColor.Text = "By color";
            button_byColor.UseVisualStyleBackColor = true;
            button_byColor.Click += button_byColor_Click;
            // 
            // button_bySize
            // 
            button_bySize.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_bySize.Location = new Point(365, 4);
            button_bySize.Name = "button_bySize";
            button_bySize.Size = new Size(78, 23);
            button_bySize.TabIndex = 28;
            button_bySize.Text = "By size";
            button_bySize.UseVisualStyleBackColor = true;
            button_bySize.Click += button_bySize_Click;
            // 
            // button_byType
            // 
            button_byType.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_byType.Location = new Point(281, 4);
            button_byType.Name = "button_byType";
            button_byType.Size = new Size(78, 23);
            button_byType.TabIndex = 29;
            button_byType.Text = "By type";
            button_byType.UseVisualStyleBackColor = true;
            button_byType.Click += button_byType_Click;
            // 
            // window
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 510);
            Controls.Add(button_byType);
            Controls.Add(button_bySize);
            Controls.Add(button_byColor);
            Controls.Add(textbox_search);
            Controls.Add(checkbox_special);
            Controls.Add(textbox_id_label);
            Controls.Add(textbox_id);
            Controls.Add(button_delete);
            Controls.Add(button_save);
            Controls.Add(textbox_surcharge_label);
            Controls.Add(textbox_surcharge);
            Controls.Add(textbox_basePrice_label);
            Controls.Add(textbox_basePrice);
            Controls.Add(textbox_brand_label);
            Controls.Add(textbox_brand);
            Controls.Add(textbox_size_label);
            Controls.Add(textbox_size);
            Controls.Add(textbox_fabric_label);
            Controls.Add(textbox_fabric);
            Controls.Add(textbox_color_label);
            Controls.Add(textbox_color);
            Controls.Add(textbox_cut_label);
            Controls.Add(textbox_cut);
            Controls.Add(textbox_type_label);
            Controls.Add(textbox_type);
            Controls.Add(button_new);
            Controls.Add(data);
            MinimumSize = new Size(816, 549);
            Name = "window";
            Text = "Clothing shop";
            Load += window_Load;
            ((System.ComponentModel.ISupportInitialize)data).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView data;
        private Button button_new;
        private TextBox textbox_type;
        private Label textbox_type_label;
        private Label textbox_cut_label;
        private TextBox textbox_cut;
        private Label textbox_color_label;
        private TextBox textbox_color;
        private Label textbox_fabric_label;
        private TextBox textbox_fabric;
        private Label textbox_size_label;
        private TextBox textbox_size;
        private Label textbox_brand_label;
        private TextBox textbox_brand;
        private Label textbox_basePrice_label;
        private TextBox textbox_basePrice;
        private Label textbox_surcharge_label;
        private TextBox textbox_surcharge;
        private Button button_save;
        private Button button_delete;
        private TextBox textbox_id;
        private Label textbox_id_label;
        private DataGridViewTextBoxColumn data_id;
        private DataGridViewTextBoxColumn data_type;
        private DataGridViewTextBoxColumn data_cut;
        private DataGridViewTextBoxColumn data_color;
        private DataGridViewTextBoxColumn data_fabric;
        private DataGridViewTextBoxColumn data_size;
        private DataGridViewTextBoxColumn data_brand;
        private DataGridViewTextBoxColumn data_basePrice;
        private DataGridViewTextBoxColumn data_surcharge;
        private DataGridViewTextBoxColumn data_total;
        private CheckBox checkbox_special;
        private TextBox textbox_search;
        private Button button_byColor;
        private Button button_bySize;
        private Button button_byType;
    }
}
