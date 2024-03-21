namespace AirConditionerShop_StudentName
{
    partial class AirConditionerForm
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
            lblProductId = new Label();
            txtProductId = new TextBox();
            lblProductName = new Label();
            txtProductName = new TextBox();
            txtProductWarranty = new TextBox();
            txtProductSPL = new TextBox();
            txtProductFF = new TextBox();
            txtProductPrice = new TextBox();
            cbProductSupplier = new ComboBox();
            txtProductQuantity = new TextBox();
            lblProductWaranty = new Label();
            lblProductSPL = new Label();
            lblProductFF = new Label();
            lblProductPrice = new Label();
            lblProductSupplier = new Label();
            lblProductQuantity = new Label();
            btnSubmit = new Button();
            SuspendLayout();
            // 
            // lblProductId
            // 
            lblProductId.AutoSize = true;
            lblProductId.Location = new Point(12, 61);
            lblProductId.Name = "lblProductId";
            lblProductId.Size = new Size(18, 15);
            lblProductId.TabIndex = 1;
            lblProductId.Text = "ID";
            // 
            // txtProductId
            // 
            txtProductId.Location = new Point(236, 58);
            txtProductId.Name = "txtProductId";
            txtProductId.ReadOnly = true;
            txtProductId.Size = new Size(187, 23);
            txtProductId.TabIndex = 8;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(12, 90);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(123, 15);
            lblProductName.TabIndex = 2;
            lblProductName.Text = "Air Conditioner Name";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(236, 90);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(187, 23);
            txtProductName.TabIndex = 9;
            // 
            // txtProductWarranty
            // 
            txtProductWarranty.Location = new Point(236, 119);
            txtProductWarranty.Name = "txtProductWarranty";
            txtProductWarranty.Size = new Size(187, 23);
            txtProductWarranty.TabIndex = 10;
            // 
            // txtProductSPL
            // 
            txtProductSPL.Location = new Point(236, 148);
            txtProductSPL.Name = "txtProductSPL";
            txtProductSPL.Size = new Size(187, 23);
            txtProductSPL.TabIndex = 11;
            // 
            // txtProductFF
            // 
            txtProductFF.Location = new Point(236, 177);
            txtProductFF.Multiline = true;
            txtProductFF.Name = "txtProductFF";
            txtProductFF.Size = new Size(187, 73);
            txtProductFF.TabIndex = 12;
            // 
            // txtProductPrice
            // 
            txtProductPrice.Location = new Point(236, 256);
            txtProductPrice.Name = "txtProductPrice";
            txtProductPrice.Size = new Size(187, 23);
            txtProductPrice.TabIndex = 13;
            // 
            // cbProductSupplier
            // 
            cbProductSupplier.FormattingEnabled = true;
            cbProductSupplier.Location = new Point(236, 285);
            cbProductSupplier.Name = "cbProductSupplier";
            cbProductSupplier.Size = new Size(187, 23);
            cbProductSupplier.TabIndex = 14;
            cbProductSupplier.Click += cbProductSupplier_Click;
            // 
            // txtProductQuantity
            // 
            txtProductQuantity.Location = new Point(236, 314);
            txtProductQuantity.Name = "txtProductQuantity";
            txtProductQuantity.Size = new Size(188, 23);
            txtProductQuantity.TabIndex = 25;
            // 
            // lblProductWaranty
            // 
            lblProductWaranty.AutoSize = true;
            lblProductWaranty.Location = new Point(12, 119);
            lblProductWaranty.Name = "lblProductWaranty";
            lblProductWaranty.Size = new Size(51, 15);
            lblProductWaranty.TabIndex = 3;
            lblProductWaranty.Text = "Waranty";
            // 
            // lblProductSPL
            // 
            lblProductSPL.AutoSize = true;
            lblProductSPL.Location = new Point(12, 151);
            lblProductSPL.Name = "lblProductSPL";
            lblProductSPL.Size = new Size(118, 15);
            lblProductSPL.TabIndex = 4;
            lblProductSPL.Text = "Sound Pressure Level";
            // 
            // lblProductFF
            // 
            lblProductFF.AutoSize = true;
            lblProductFF.Location = new Point(12, 180);
            lblProductFF.Name = "lblProductFF";
            lblProductFF.Size = new Size(96, 15);
            lblProductFF.TabIndex = 5;
            lblProductFF.Text = "Feature Function";
            // 
            // lblProductPrice
            // 
            lblProductPrice.AutoSize = true;
            lblProductPrice.Location = new Point(12, 256);
            lblProductPrice.Name = "lblProductPrice";
            lblProductPrice.Size = new Size(67, 15);
            lblProductPrice.TabIndex = 6;
            lblProductPrice.Text = "Dollar Price";
            // 
            // lblProductSupplier
            // 
            lblProductSupplier.AutoSize = true;
            lblProductSupplier.Location = new Point(12, 285);
            lblProductSupplier.Name = "lblProductSupplier";
            lblProductSupplier.Size = new Size(105, 15);
            lblProductSupplier.TabIndex = 7;
            lblProductSupplier.Text = "Supplier Company";
            // 
            // lblProductQuantity
            // 
            lblProductQuantity.AutoSize = true;
            lblProductQuantity.Location = new Point(10, 314);
            lblProductQuantity.Name = "lblProductQuantity";
            lblProductQuantity.Size = new Size(53, 15);
            lblProductQuantity.TabIndex = 24;
            lblProductQuantity.Text = "Quantity";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(150, 365);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(153, 54);
            btnSubmit.TabIndex = 26;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // AirConditioner
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 450);
            Controls.Add(btnSubmit);
            Controls.Add(lblProductQuantity);
            Controls.Add(txtProductQuantity);
            Controls.Add(lblProductId);
            Controls.Add(txtProductId);
            Controls.Add(lblProductName);
            Controls.Add(txtProductName);
            Controls.Add(txtProductWarranty);
            Controls.Add(txtProductSPL);
            Controls.Add(txtProductFF);
            Controls.Add(lblProductSupplier);
            Controls.Add(txtProductPrice);
            Controls.Add(lblProductPrice);
            Controls.Add(cbProductSupplier);
            Controls.Add(lblProductFF);
            Controls.Add(lblProductWaranty);
            Controls.Add(lblProductSPL);
            Name = "AirConditioner";
            Text = "AirConditioner";
            Load += AirConditionerForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProductId;
        private TextBox txtProductId;
        private Label lblProductName;
        private TextBox txtProductName;
        private TextBox txtProductWarranty;
        private TextBox txtProductSPL;
        private TextBox txtProductFF;
        private TextBox txtProductPrice;
        private ComboBox cbProductSupplier;
        private TextBox txtProductQuantity;
        private Label lblProductWaranty;
        private Label lblProductSPL;
        private Label lblProductFF;
        private Label lblProductPrice;
        private Label lblProductSupplier;
        private Label lblProductQuantity;
        private Button btnSubmit;
    }
}