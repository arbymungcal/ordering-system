namespace order_system
{
    partial class Form1
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            cboDishes = new ComboBox();
            cboDrinks = new ComboBox();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            label2 = new Label();
            panel1 = new Panel();
            lblDish = new Label();
            lblDrinks = new Label();
            label4 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            txtCash = new TextBox();
            lblChange = new Label();
            label5 = new Label();
            lblTotal = new Label();
            lblTax = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            button2 = new Guna.UI2.WinForms.Guna2Button();
            dgvOrderHistory = new Guna.UI2.WinForms.Guna2DataGridView();
            button3 = new Guna.UI2.WinForms.Guna2Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderHistory).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 37);
            label1.Name = "label1";
            label1.Size = new Size(50, 21);
            label1.TabIndex = 0;
            label1.Text = "Menu";
            // 
            // cboDishes
            // 
            cboDishes.FormattingEnabled = true;
            cboDishes.Items.AddRange(new object[] { "MENUDO", "CALDERETA", "SISIG", "ASADO", "PANDESAL", "ANCHOVY" });
            cboDishes.Location = new Point(19, 99);
            cboDishes.Name = "cboDishes";
            cboDishes.Size = new Size(246, 23);
            cboDishes.TabIndex = 1;
            cboDishes.SelectedIndexChanged += cboDishes_SelectedIndexChanged_1;
            // 
            // cboDrinks
            // 
            cboDrinks.FormattingEnabled = true;
            cboDrinks.Items.AddRange(new object[] { "RED HORSE", "TANDUAY", "SOJU", "GIN" });
            cboDrinks.Location = new Point(19, 240);
            cboDrinks.Name = "cboDrinks";
            cboDrinks.Size = new Size(246, 23);
            cboDrinks.TabIndex = 2;
            cboDrinks.SelectedIndexChanged += cboDrinks_SelectedIndexChanged_1;
            // 
            // guna2Button1
            // 
            guna2Button1.CustomizableEdges = customizableEdges1;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.DarkRed;
            guna2Button1.Font = new Font("Segoe UI", 9F);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(19, 318);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button1.Size = new Size(246, 45);
            guna2Button1.TabIndex = 3;
            guna2Button1.Text = "void";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 176);
            label2.Name = "label2";
            label2.Size = new Size(55, 21);
            label2.TabIndex = 5;
            label2.Text = "Drinks";
            // 
            // panel1
            // 
            panel1.Controls.Add(lblDish);
            panel1.Controls.Add(lblDrinks);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(guna2Button1);
            panel1.Controls.Add(cboDishes);
            panel1.Controls.Add(cboDrinks);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(286, 375);
            panel1.TabIndex = 6;
            // 
            // lblDish
            // 
            lblDish.AutoSize = true;
            lblDish.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDish.Location = new Point(237, 75);
            lblDish.Name = "lblDish";
            lblDish.Size = new Size(28, 21);
            lblDish.TabIndex = 9;
            lblDish.Text = "---";
            lblDish.Click += lblDish_Click;
            // 
            // lblDrinks
            // 
            lblDrinks.AutoSize = true;
            lblDrinks.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDrinks.Location = new Point(237, 216);
            lblDrinks.Name = "lblDrinks";
            lblDrinks.Size = new Size(28, 21);
            lblDrinks.TabIndex = 8;
            lblDrinks.Text = "---";
            lblDrinks.Click += lblDrinks_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(19, 216);
            label4.Name = "label4";
            label4.Size = new Size(44, 21);
            label4.TabIndex = 7;
            label4.Text = "Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(19, 75);
            label3.Name = "label3";
            label3.Size = new Size(44, 21);
            label3.TabIndex = 6;
            label3.Text = "Price";
            // 
            // panel2
            // 
            panel2.Controls.Add(txtCash);
            panel2.Controls.Add(lblChange);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(lblTotal);
            panel2.Controls.Add(lblTax);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(button2);
            panel2.Location = new Point(304, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(286, 375);
            panel2.TabIndex = 10;
            // 
            // txtCash
            // 
            txtCash.Location = new Point(19, 218);
            txtCash.Name = "txtCash";
            txtCash.Size = new Size(246, 23);
            txtCash.TabIndex = 12;
            txtCash.TextChanged += txtCash_TextChanged;
            // 
            // lblChange
            // 
            lblChange.AutoSize = true;
            lblChange.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblChange.Location = new Point(237, 268);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(28, 21);
            lblChange.TabIndex = 11;
            lblChange.Text = "---";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(30, 268);
            label5.Name = "label5";
            label5.Size = new Size(63, 21);
            label5.TabIndex = 10;
            label5.Text = "Change";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(237, 75);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(28, 21);
            lblTotal.TabIndex = 9;
            lblTotal.Text = "---";
            // 
            // lblTax
            // 
            lblTax.AutoSize = true;
            lblTax.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTax.Location = new Point(237, 112);
            lblTax.Name = "lblTax";
            lblTax.Size = new Size(28, 21);
            lblTax.TabIndex = 8;
            lblTax.Text = "---";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(110, 176);
            label7.Name = "label7";
            label7.Size = new Size(70, 21);
            label7.TabIndex = 7;
            label7.Text = "Payment";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(19, 75);
            label8.Name = "label8";
            label8.Size = new Size(42, 21);
            label8.TabIndex = 6;
            label8.Text = "Total";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(119, 12);
            label9.Name = "label9";
            label9.Size = new Size(61, 21);
            label9.TabIndex = 0;
            label9.Text = "Reciept";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(19, 112);
            label10.Name = "label10";
            label10.Size = new Size(31, 21);
            label10.TabIndex = 5;
            label10.Text = "Tax";
            // 
            // button2
            // 
            button2.CustomizableEdges = customizableEdges3;
            button2.DisabledState.BorderColor = Color.DarkGray;
            button2.DisabledState.CustomBorderColor = Color.DarkGray;
            button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            button2.FillColor = Color.DarkGreen;
            button2.Font = new Font("Segoe UI", 9F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(19, 318);
            button2.Name = "button2";
            button2.ShadowDecoration.CustomizableEdges = customizableEdges4;
            button2.Size = new Size(246, 45);
            button2.TabIndex = 3;
            button2.Text = "purchase";
            button2.Click += button2_Click;
            // 
            // dgvOrderHistory
            // 
            dgvOrderHistory.AllowUserToAddRows = false;
            dgvOrderHistory.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvOrderHistory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvOrderHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvOrderHistory.ColumnHeadersHeight = 4;
            dgvOrderHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvOrderHistory.DefaultCellStyle = dataGridViewCellStyle3;
            dgvOrderHistory.GridColor = Color.FromArgb(231, 229, 255);
            dgvOrderHistory.Location = new Point(12, 393);
            dgvOrderHistory.Name = "dgvOrderHistory";
            dgvOrderHistory.ReadOnly = true;
            dgvOrderHistory.RowHeadersVisible = false;
            dgvOrderHistory.Size = new Size(578, 79);
            dgvOrderHistory.TabIndex = 11;
            dgvOrderHistory.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvOrderHistory.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvOrderHistory.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvOrderHistory.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvOrderHistory.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvOrderHistory.ThemeStyle.BackColor = Color.White;
            dgvOrderHistory.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvOrderHistory.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvOrderHistory.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvOrderHistory.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvOrderHistory.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvOrderHistory.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvOrderHistory.ThemeStyle.HeaderStyle.Height = 4;
            dgvOrderHistory.ThemeStyle.ReadOnly = true;
            dgvOrderHistory.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvOrderHistory.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvOrderHistory.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvOrderHistory.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvOrderHistory.ThemeStyle.RowsStyle.Height = 25;
            dgvOrderHistory.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvOrderHistory.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // button3
            // 
            button3.CustomizableEdges = customizableEdges5;
            button3.DisabledState.BorderColor = Color.DarkGray;
            button3.DisabledState.CustomBorderColor = Color.DarkGray;
            button3.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            button3.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            button3.FillColor = Color.DarkGreen;
            button3.Font = new Font("Segoe UI", 9F);
            button3.ForeColor = Color.White;
            button3.Location = new Point(193, 485);
            button3.Name = "button3";
            button3.ShadowDecoration.CustomizableEdges = customizableEdges6;
            button3.Size = new Size(246, 45);
            button3.TabIndex = 13;
            button3.Text = "generate";
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(606, 542);
            Controls.Add(button3);
            Controls.Add(dgvOrderHistory);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderHistory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private ComboBox cboDishes;
        private ComboBox cboDrinks;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Label label2;
        private Panel panel1;
        private Label lblDish;
        private Label lblDrinks;
        private Label label4;
        private Label label3;
        private Panel panel2;
        private Label lblTotal;
        private Label lblTax;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Guna.UI2.WinForms.Guna2Button button2;
        private Label lblChange;
        private Label label5;
        private TextBox txtCash;
        private Guna.UI2.WinForms.Guna2DataGridView dgvOrderHistory;
        private Guna.UI2.WinForms.Guna2Button button3;
    }
}
