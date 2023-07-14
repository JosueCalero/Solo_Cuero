namespace Solo_Cuero
{
    partial class frm_InsertProducts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_Description = new System.Windows.Forms.Label();
            this.lbl_Stock = new System.Windows.Forms.Label();
            this.lbl_category = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.lbl_color = new System.Windows.Forms.Label();
            this.lbl_Size = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Description = new System.Windows.Forms.TextBox();
            this.txt_stock = new System.Windows.Forms.TextBox();
            this.txt_category = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_size = new System.Windows.Forms.TextBox();
            this.txt_color = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(203)))), ((int)(((byte)(163)))));
            this.lbl_name.Location = new System.Drawing.Point(12, 51);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(89, 28);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Nombre";
            // 
            // lbl_Description
            // 
            this.lbl_Description.AutoSize = true;
            this.lbl_Description.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Description.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(203)))), ((int)(((byte)(163)))));
            this.lbl_Description.Location = new System.Drawing.Point(0, 97);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(123, 28);
            this.lbl_Description.TabIndex = 1;
            this.lbl_Description.Text = "Descripcion";
            // 
            // lbl_Stock
            // 
            this.lbl_Stock.AutoSize = true;
            this.lbl_Stock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Stock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(203)))), ((int)(((byte)(163)))));
            this.lbl_Stock.Location = new System.Drawing.Point(12, 155);
            this.lbl_Stock.Name = "lbl_Stock";
            this.lbl_Stock.Size = new System.Drawing.Size(64, 28);
            this.lbl_Stock.TabIndex = 2;
            this.lbl_Stock.Text = "Stock";
            // 
            // lbl_category
            // 
            this.lbl_category.AutoSize = true;
            this.lbl_category.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_category.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(203)))), ((int)(((byte)(163)))));
            this.lbl_category.Location = new System.Drawing.Point(12, 208);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(101, 28);
            this.lbl_category.TabIndex = 3;
            this.lbl_category.Text = "categoria";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(203)))), ((int)(((byte)(163)))));
            this.lbl_price.Location = new System.Drawing.Point(12, 261);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(71, 28);
            this.lbl_price.TabIndex = 4;
            this.lbl_price.Text = "Precio";
            // 
            // lbl_color
            // 
            this.lbl_color.AutoSize = true;
            this.lbl_color.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lbl_color.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_color.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(203)))), ((int)(((byte)(163)))));
            this.lbl_color.Location = new System.Drawing.Point(12, 357);
            this.lbl_color.Name = "lbl_color";
            this.lbl_color.Size = new System.Drawing.Size(62, 28);
            this.lbl_color.TabIndex = 5;
            this.lbl_color.Text = "Color";
            // 
            // lbl_Size
            // 
            this.lbl_Size.AutoSize = true;
            this.lbl_Size.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Size.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(203)))), ((int)(((byte)(163)))));
            this.lbl_Size.Location = new System.Drawing.Point(12, 312);
            this.lbl_Size.Name = "lbl_Size";
            this.lbl_Size.Size = new System.Drawing.Size(86, 28);
            this.lbl_Size.TabIndex = 6;
            this.lbl_Size.Text = "Tamaño";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(129, 51);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(343, 22);
            this.txt_Name.TabIndex = 7;
            // 
            // txt_Description
            // 
            this.txt_Description.Location = new System.Drawing.Point(129, 97);
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.Size = new System.Drawing.Size(343, 22);
            this.txt_Description.TabIndex = 8;
            // 
            // txt_stock
            // 
            this.txt_stock.Location = new System.Drawing.Point(129, 155);
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.Size = new System.Drawing.Size(343, 22);
            this.txt_stock.TabIndex = 9;
            // 
            // txt_category
            // 
            this.txt_category.Location = new System.Drawing.Point(129, 208);
            this.txt_category.Name = "txt_category";
            this.txt_category.Size = new System.Drawing.Size(343, 22);
            this.txt_category.TabIndex = 10;
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(129, 258);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(343, 22);
            this.txt_price.TabIndex = 11;
            // 
            // txt_size
            // 
            this.txt_size.Location = new System.Drawing.Point(129, 312);
            this.txt_size.Name = "txt_size";
            this.txt_size.Size = new System.Drawing.Size(343, 22);
            this.txt_size.TabIndex = 12;
            // 
            // txt_color
            // 
            this.txt_color.Location = new System.Drawing.Point(128, 357);
            this.txt_color.Name = "txt_color";
            this.txt_color.Size = new System.Drawing.Size(343, 22);
            this.txt_color.TabIndex = 13;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(39, 455);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(135, 42);
            this.btn_Save.TabIndex = 14;
            this.btn_Save.Text = "Guardar";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(295, 455);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(135, 42);
            this.btn_cancel.TabIndex = 15;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // frm_InsertProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(56)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(505, 565);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.txt_color);
            this.Controls.Add(this.txt_size);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_category);
            this.Controls.Add(this.txt_stock);
            this.Controls.Add(this.txt_Description);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.lbl_Size);
            this.Controls.Add(this.lbl_color);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_category);
            this.Controls.Add(this.lbl_Stock);
            this.Controls.Add(this.lbl_Description);
            this.Controls.Add(this.lbl_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frm_InsertProducts";
            this.Text = "Insert_Products";
            this.Load += new System.EventHandler(this.frm_InsertProducts_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_Description;
        private System.Windows.Forms.Label lbl_Stock;
        private System.Windows.Forms.Label lbl_category;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label lbl_color;
        private System.Windows.Forms.Label lbl_Size;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_cancel;
        public System.Windows.Forms.TextBox txt_Name;
        public System.Windows.Forms.TextBox txt_Description;
        public System.Windows.Forms.TextBox txt_stock;
        public System.Windows.Forms.TextBox txt_category;
        public System.Windows.Forms.TextBox txt_price;
        public System.Windows.Forms.TextBox txt_size;
        public System.Windows.Forms.TextBox txt_color;
    }
}