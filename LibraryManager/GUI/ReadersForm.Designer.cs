namespace LibraryManager.GUI
{
    partial class ReadersForm
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
            dataGridReaders = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colFullName = new DataGridViewTextBoxColumn();
            colContact = new DataGridViewTextBoxColumn();
            colRegistered = new DataGridViewTextBoxColumn();
            txtFullName = new TextBox();
            txtContact = new TextBox();
            dtpRegistered = new DateTimePicker();
            btnDelete = new Button();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridReaders).BeginInit();
            SuspendLayout();
            // 
            // dataGridReaders
            // 
            dataGridReaders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridReaders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridReaders.Columns.AddRange(new DataGridViewColumn[] { colId, colFullName, colContact, colRegistered });
            dataGridReaders.Dock = DockStyle.Top;
            dataGridReaders.Location = new Point(0, 0);
            dataGridReaders.Name = "dataGridReaders";
            dataGridReaders.Size = new Size(800, 368);
            dataGridReaders.TabIndex = 0;
            dataGridReaders.CellContentClick += dataGridReaders_CellContentClick;
            dataGridReaders.RowValidated += dataGridReaders_RowValidated;
            // 
            // colId
            // 
            colId.HeaderText = "Id";
            colId.Name = "colId";
            colId.Visible = false;
            // 
            // colFullName
            // 
            colFullName.HeaderText = "Full Name\t";
            colFullName.Name = "colFullName";
            // 
            // colContact
            // 
            colContact.HeaderText = "Contact";
            colContact.Name = "colContact";
            // 
            // colRegistered
            // 
            colRegistered.HeaderText = "Registered";
            colRegistered.Name = "colRegistered";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(541, 384);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(125, 23);
            txtFullName.TabIndex = 1;
            txtFullName.Text = "FullName";
            txtFullName.TextAlign = HorizontalAlignment.Center;
            txtFullName.TextChanged += txtFullName_TextChanged;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(672, 384);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(116, 23);
            txtContact.TabIndex = 2;
            txtContact.Text = "Contact";
            txtContact.TextAlign = HorizontalAlignment.Center;
            // 
            // dtpRegistered
            // 
            dtpRegistered.Location = new Point(541, 415);
            dtpRegistered.Name = "dtpRegistered";
            dtpRegistered.Size = new Size(247, 23);
            dtpRegistered.TabIndex = 3;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(268, 384);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(267, 54);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 384);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(250, 54);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // ReadersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAdd);
            Controls.Add(btnDelete);
            Controls.Add(dtpRegistered);
            Controls.Add(txtContact);
            Controls.Add(txtFullName);
            Controls.Add(dataGridReaders);
            Name = "ReadersForm";
            Text = "ReadersForm";
            Load += ReadersForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridReaders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridReaders;
        private TextBox txtFullName;
        private TextBox txtContact;
        private DateTimePicker dtpRegistered;
        private Button btnDelete;
        private Button btnAdd;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colFullName;
        private DataGridViewTextBoxColumn colContact;
        private DataGridViewTextBoxColumn colRegistered;
    }
}