namespace AirConditionerShop_StudentName
{
    partial class AirConditionerManagement
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
            dgvAirConditioner = new DataGridView();
            btnNew = new Button();
            btnSave = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnExit = new Button();
            rbFeatureFunction = new RadioButton();
            rbQuantity = new RadioButton();
            txtSearch = new TextBox();
            lblSearch = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAirConditioner).BeginInit();
            SuspendLayout();
            // 
            // dgvAirConditioner
            // 
            dgvAirConditioner.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAirConditioner.Location = new Point(362, 43);
            dgvAirConditioner.Name = "dgvAirConditioner";
            dgvAirConditioner.Size = new Size(377, 441);
            dgvAirConditioner.TabIndex = 0;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(28, 147);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(75, 23);
            btnNew.TabIndex = 15;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(140, 147);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 16;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(250, 147);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 17;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(76, 216);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 18;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(205, 216);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 19;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // rbFeatureFunction
            // 
            rbFeatureFunction.AutoSize = true;
            rbFeatureFunction.Location = new Point(37, 87);
            rbFeatureFunction.Name = "rbFeatureFunction";
            rbFeatureFunction.Size = new Size(114, 19);
            rbFeatureFunction.TabIndex = 22;
            rbFeatureFunction.TabStop = true;
            rbFeatureFunction.Text = "Feature Function";
            rbFeatureFunction.UseVisualStyleBackColor = true;
            // 
            // rbQuantity
            // 
            rbQuantity.AutoSize = true;
            rbQuantity.Location = new Point(181, 87);
            rbQuantity.Name = "rbQuantity";
            rbQuantity.Size = new Size(71, 19);
            rbQuantity.TabIndex = 23;
            rbQuantity.TabStop = true;
            rbQuantity.Text = "Quantity";
            rbQuantity.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(115, 43);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(188, 23);
            txtSearch.TabIndex = 21;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(28, 43);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(42, 15);
            lblSearch.TabIndex = 20;
            lblSearch.Text = "Search";
            // 
            // AirConditionerManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(773, 602);
            Controls.Add(rbQuantity);
            Controls.Add(rbFeatureFunction);
            Controls.Add(lblSearch);
            Controls.Add(btnExit);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(txtSearch);
            Controls.Add(btnSave);
            Controls.Add(btnNew);
            Controls.Add(dgvAirConditioner);
            Name = "AirConditionerManagement";
            Text = "AirConditionerManagement";
            ((System.ComponentModel.ISupportInitialize)dgvAirConditioner).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvAirConditioner;
        private Button btnNew;
        private Button btnSave;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnExit;
        private RadioButton rbFeatureFunction;
        private RadioButton rbQuantity;
        private TextBox txtSearch;
        private Label lblSearch;
    }
}