namespace XMLSolutionMatric.UI
{
    partial class FrmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgrid = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnAdd = new DevComponents.DotNetBar.ButtonX();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StreetName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HouseNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApartmentNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Town = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.PostalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOB = new DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrid
            // 
            this.dgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.LastName,
            this.FirstName,
            this.StreetName,
            this.HouseNumber,
            this.ApartmentNumber,
            this.Town,
            this.PostalCode,
            this.PhoneNumber,
            this.DOB,
            this.Age});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgrid.Location = new System.Drawing.Point(0, 0);
            this.dgrid.Name = "dgrid";
            this.dgrid.RowHeadersWidth = 51;
            this.dgrid.RowTemplate.Height = 24;
            this.dgrid.Size = new System.Drawing.Size(1228, 538);
            this.dgrid.TabIndex = 0;
            this.dgrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_CellEndEdit);
            this.dgrid.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgrid_EditingControlShowing);
            this.dgrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgrid_KeyDown);
            this.dgrid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgrid_KeyPress);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Location = new System.Drawing.Point(1141, 544);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAdd.Location = new System.Drawing.Point(1051, 544);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Save";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Id.Visible = false;
            this.Id.Width = 25;
            // 
            // LastName
            // 
            this.LastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LastName.HeaderText = "LastName";
            this.LastName.MaxInputLength = 20;
            this.LastName.MinimumWidth = 6;
            this.LastName.Name = "LastName";
            this.LastName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FirstName
            // 
            this.FirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FirstName.HeaderText = "FirstName";
            this.FirstName.MaxInputLength = 20;
            this.FirstName.MinimumWidth = 6;
            this.FirstName.Name = "FirstName";
            this.FirstName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // StreetName
            // 
            this.StreetName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.StreetName.HeaderText = "StreetName";
            this.StreetName.MaxInputLength = 20;
            this.StreetName.MinimumWidth = 6;
            this.StreetName.Name = "StreetName";
            this.StreetName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.StreetName.Width = 89;
            // 
            // HouseNumber
            // 
            this.HouseNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.HouseNumber.HeaderText = "HouseNumber";
            this.HouseNumber.MaxInputLength = 5;
            this.HouseNumber.MinimumWidth = 6;
            this.HouseNumber.Name = "HouseNumber";
            this.HouseNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.HouseNumber.Width = 105;
            // 
            // ApartmentNumber
            // 
            this.ApartmentNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ApartmentNumber.HeaderText = "ApartmentNumber";
            this.ApartmentNumber.MaxInputLength = 5;
            this.ApartmentNumber.MinimumWidth = 6;
            this.ApartmentNumber.Name = "ApartmentNumber";
            this.ApartmentNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ApartmentNumber.Width = 129;
            // 
            // Town
            // 
            this.Town.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Town.HeaderText = "Town";
            this.Town.MinimumWidth = 6;
            this.Town.Name = "Town";
            this.Town.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Town.Width = 48;
            // 
            // PostalCode
            // 
            this.PostalCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.PostalCode.HeaderText = "PostalCode";
            this.PostalCode.MaxInputLength = 6;
            this.PostalCode.MinimumWidth = 6;
            this.PostalCode.Name = "PostalCode";
            this.PostalCode.ReadOnly = true;
            this.PostalCode.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PostalCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PostalCode.Width = 86;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.PhoneNumber.HeaderText = "PhoneNumber";
            this.PhoneNumber.MaxInputLength = 9;
            this.PhoneNumber.MinimumWidth = 6;
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PhoneNumber.Width = 105;
            // 
            // DOB
            // 
            this.DOB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            // 
            // 
            // 
            this.DOB.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.DOB.BackgroundStyle.Class = "DataGridViewDateTimeBorder";
            this.DOB.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DOB.BackgroundStyle.TextColor = System.Drawing.SystemColors.ControlText;
            this.DOB.HeaderText = "DateOfBirth";
            this.DOB.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            this.DOB.MinimumWidth = 6;
            // 
            // 
            // 
            // 
            // 
            // 
            this.DOB.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DOB.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            // 
            // 
            // 
            this.DOB.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DOB.MonthCalendar.DisplayMonth = new System.DateTime(2020, 5, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.DOB.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DOB.Name = "DOB";
            this.DOB.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DOB.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DOB.Width = 88;
            // 
            // Age
            // 
            this.Age.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Age.HeaderText = "Age";
            this.Age.MaxInputLength = 5;
            this.Age.MinimumWidth = 6;
            this.Age.Name = "Age";
            this.Age.ReadOnly = true;
            this.Age.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Age.Width = 39;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1228, 572);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dgrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgrid;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.ButtonX btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StreetName;
        private System.Windows.Forms.DataGridViewTextBoxColumn HouseNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApartmentNumber;
        private System.Windows.Forms.DataGridViewComboBoxColumn Town;
        private System.Windows.Forms.DataGridViewTextBoxColumn PostalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn DOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
    }
}

