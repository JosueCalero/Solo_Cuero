namespace Solo_Cuero
{
    partial class frm_Products
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Products));
            this.pnl_table_container = new System.Windows.Forms.Panel();
            this.pb_close = new System.Windows.Forms.PictureBox();
            this.pnl_topPanel = new System.Windows.Forms.Panel();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.dgv_Products = new System.Windows.Forms.DataGridView();
            this.pnl_table_container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_close)).BeginInit();
            this.pnl_topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Products)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_table_container
            // 
            this.pnl_table_container.Controls.Add(this.dgv_Products);
            this.pnl_table_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_table_container.Location = new System.Drawing.Point(0, 88);
            this.pnl_table_container.Name = "pnl_table_container";
            this.pnl_table_container.Size = new System.Drawing.Size(1287, 525);
            this.pnl_table_container.TabIndex = 2;
            // 
            // pb_close
            // 
            this.pb_close.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pb_close.Image = ((System.Drawing.Image)(resources.GetObject("pb_close.Image")));
            this.pb_close.Location = new System.Drawing.Point(1235, 30);
            this.pb_close.Name = "pb_close";
            this.pb_close.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.pb_close.Size = new System.Drawing.Size(40, 25);
            this.pb_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_close.TabIndex = 2;
            this.pb_close.TabStop = false;
            this.pb_close.Click += new System.EventHandler(this.pb_close_Click);
            // 
            // pnl_topPanel
            // 
            this.pnl_topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(203)))), ((int)(((byte)(163)))));
            this.pnl_topPanel.Controls.Add(this.btn_Delete);
            this.pnl_topPanel.Controls.Add(this.btn_Edit);
            this.pnl_topPanel.Controls.Add(this.btn_insert);
            this.pnl_topPanel.Controls.Add(this.pb_close);
            this.pnl_topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_topPanel.Location = new System.Drawing.Point(0, 0);
            this.pnl_topPanel.Name = "pnl_topPanel";
            this.pnl_topPanel.Size = new System.Drawing.Size(1287, 88);
            this.pnl_topPanel.TabIndex = 1;
            // 
            // btn_insert
            // 
            this.btn_insert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(56)))), ((int)(((byte)(33)))));
            this.btn_insert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_insert.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(203)))), ((int)(((byte)(163)))));
            this.btn_insert.Location = new System.Drawing.Point(26, 12);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(196, 62);
            this.btn_insert.TabIndex = 3;
            this.btn_insert.Text = "Agregar";
            this.btn_insert.UseVisualStyleBackColor = false;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(56)))), ((int)(((byte)(33)))));
            this.btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Edit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(203)))), ((int)(((byte)(163)))));
            this.btn_Edit.Location = new System.Drawing.Point(238, 12);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(196, 62);
            this.btn_Edit.TabIndex = 4;
            this.btn_Edit.Text = "Editar";
            this.btn_Edit.UseVisualStyleBackColor = false;
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(56)))), ((int)(((byte)(33)))));
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Delete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(203)))), ((int)(((byte)(163)))));
            this.btn_Delete.Location = new System.Drawing.Point(451, 12);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(196, 62);
            this.btn_Delete.TabIndex = 5;
            this.btn_Delete.Text = "Eliminar";
            this.btn_Delete.UseVisualStyleBackColor = false;
            // 
            // dgv_Products
            // 
            this.dgv_Products.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(203)))), ((int)(((byte)(163)))));
            this.dgv_Products.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Products.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.dgv_Products.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Products.Location = new System.Drawing.Point(0, 0);
            this.dgv_Products.Name = "dgv_Products";
            this.dgv_Products.RowHeadersWidth = 51;
            this.dgv_Products.RowTemplate.Height = 24;
            this.dgv_Products.Size = new System.Drawing.Size(1287, 525);
            this.dgv_Products.TabIndex = 1;
            this.dgv_Products.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Products_CellContentClick);
            // 
            // frm_Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Solo_Cuero.Properties.Resources.Solo_cuero_Logo;
            this.ClientSize = new System.Drawing.Size(1287, 613);
            this.Controls.Add(this.pnl_table_container);
            this.Controls.Add(this.pnl_topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Products";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Products_Load);
            this.pnl_table_container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_close)).EndInit();
            this.pnl_topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Products)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl_table_container;
        private System.Windows.Forms.PictureBox pb_close;
        private System.Windows.Forms.Panel pnl_topPanel;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Edit;
        public System.Windows.Forms.DataGridView dgv_Products;
    }
}