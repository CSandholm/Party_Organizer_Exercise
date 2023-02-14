namespace Assignment4
{
    partial class MainForm
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
            this.grpNewParty = new System.Windows.Forms.GroupBox();
            this.txtTotalNumberOfGuests = new System.Windows.Forms.TextBox();
            this.txtCostPerPerson = new System.Windows.Forms.TextBox();
            this.btnCreateList = new System.Windows.Forms.Button();
            this.lblCostPerPerson = new System.Windows.Forms.Label();
            this.lblTotalNumberOfGuests = new System.Windows.Forms.Label();
            this.grpAddGuests = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.ListLabel = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.lblNumerOfGuests = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtTotalCost = new System.Windows.Forms.TextBox();
            this.txtNumberOfGuests = new System.Windows.Forms.TextBox();
            this.lstGuestList = new System.Windows.Forms.ListBox();
            this.grpNewParty.SuspendLayout();
            this.grpAddGuests.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpNewParty
            // 
            this.grpNewParty.Controls.Add(this.txtTotalNumberOfGuests);
            this.grpNewParty.Controls.Add(this.txtCostPerPerson);
            this.grpNewParty.Controls.Add(this.btnCreateList);
            this.grpNewParty.Controls.Add(this.lblCostPerPerson);
            this.grpNewParty.Controls.Add(this.lblTotalNumberOfGuests);
            this.grpNewParty.Location = new System.Drawing.Point(12, 22);
            this.grpNewParty.Name = "grpNewParty";
            this.grpNewParty.Size = new System.Drawing.Size(250, 126);
            this.grpNewParty.TabIndex = 0;
            this.grpNewParty.TabStop = false;
            this.grpNewParty.Text = "New Party";
            // 
            // txtTotalNumberOfGuests
            // 
            this.txtTotalNumberOfGuests.Location = new System.Drawing.Point(144, 29);
            this.txtTotalNumberOfGuests.Name = "txtTotalNumberOfGuests";
            this.txtTotalNumberOfGuests.Size = new System.Drawing.Size(100, 20);
            this.txtTotalNumberOfGuests.TabIndex = 8;
            // 
            // txtCostPerPerson
            // 
            this.txtCostPerPerson.Location = new System.Drawing.Point(144, 57);
            this.txtCostPerPerson.Name = "txtCostPerPerson";
            this.txtCostPerPerson.Size = new System.Drawing.Size(100, 20);
            this.txtCostPerPerson.TabIndex = 8;
            this.txtCostPerPerson.TextChanged += new System.EventHandler(this.CostTxt_TextChanged);
            // 
            // btnCreateList
            // 
            this.btnCreateList.Location = new System.Drawing.Point(82, 97);
            this.btnCreateList.Name = "btnCreateList";
            this.btnCreateList.Size = new System.Drawing.Size(75, 23);
            this.btnCreateList.TabIndex = 6;
            this.btnCreateList.Text = "Create List";
            this.btnCreateList.UseVisualStyleBackColor = true;
            this.btnCreateList.Click += new System.EventHandler(this.btnCreateList_Click);
            // 
            // lblCostPerPerson
            // 
            this.lblCostPerPerson.AutoSize = true;
            this.lblCostPerPerson.Location = new System.Drawing.Point(6, 60);
            this.lblCostPerPerson.Name = "lblCostPerPerson";
            this.lblCostPerPerson.Size = new System.Drawing.Size(82, 13);
            this.lblCostPerPerson.TabIndex = 5;
            this.lblCostPerPerson.Text = "Cost per Person";
            this.lblCostPerPerson.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblTotalNumberOfGuests
            // 
            this.lblTotalNumberOfGuests.AutoSize = true;
            this.lblTotalNumberOfGuests.Location = new System.Drawing.Point(6, 32);
            this.lblTotalNumberOfGuests.Name = "lblTotalNumberOfGuests";
            this.lblTotalNumberOfGuests.Size = new System.Drawing.Size(119, 13);
            this.lblTotalNumberOfGuests.TabIndex = 4;
            this.lblTotalNumberOfGuests.Text = "Total Number of Guests";
            this.lblTotalNumberOfGuests.Click += new System.EventHandler(this.label1_Click);
            // 
            // grpAddGuests
            // 
            this.grpAddGuests.Controls.Add(this.btnAdd);
            this.grpAddGuests.Controls.Add(this.txtLastName);
            this.grpAddGuests.Controls.Add(this.lblLastName);
            this.grpAddGuests.Controls.Add(this.txtFirstName);
            this.grpAddGuests.Controls.Add(this.lblFirstName);
            this.grpAddGuests.Location = new System.Drawing.Point(12, 154);
            this.grpAddGuests.Name = "grpAddGuests";
            this.grpAddGuests.Size = new System.Drawing.Size(250, 126);
            this.grpAddGuests.TabIndex = 1;
            this.grpAddGuests.TabStop = false;
            this.grpAddGuests.Text = "Invite Guest";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(82, 97);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(144, 56);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 11;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(6, 59);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 10;
            this.lblLastName.Text = "Last Name";
            this.lblLastName.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(144, 28);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 7;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(6, 31);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 9;
            this.lblFirstName.Text = "First Name";
            this.lblFirstName.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // ListLabel
            // 
            this.ListLabel.AutoSize = true;
            this.ListLabel.Location = new System.Drawing.Point(331, 14);
            this.ListLabel.Name = "ListLabel";
            this.ListLabel.Size = new System.Drawing.Size(54, 13);
            this.ListLabel.TabIndex = 3;
            this.ListLabel.Text = "Guest List";
            this.ListLabel.Click += new System.EventHandler(this.ListLabel_Click);
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Location = new System.Drawing.Point(21, 302);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(55, 13);
            this.lblTotalCost.TabIndex = 4;
            this.lblTotalCost.Text = "Total Cost";
            this.lblTotalCost.Click += new System.EventHandler(this.TotalLbl_Click);
            // 
            // lblNumerOfGuests
            // 
            this.lblNumerOfGuests.AutoSize = true;
            this.lblNumerOfGuests.Location = new System.Drawing.Point(21, 328);
            this.lblNumerOfGuests.Name = "lblNumerOfGuests";
            this.lblNumerOfGuests.Size = new System.Drawing.Size(92, 13);
            this.lblNumerOfGuests.TabIndex = 5;
            this.lblNumerOfGuests.Text = "Number of Guests";
            this.lblNumerOfGuests.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(281, 292);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 6;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(362, 292);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtTotalCost
            // 
            this.txtTotalCost.Location = new System.Drawing.Point(177, 299);
            this.txtTotalCost.Name = "txtTotalCost";
            this.txtTotalCost.ReadOnly = true;
            this.txtTotalCost.Size = new System.Drawing.Size(80, 20);
            this.txtTotalCost.TabIndex = 8;
            // 
            // txtNumberOfGuests
            // 
            this.txtNumberOfGuests.Location = new System.Drawing.Point(177, 325);
            this.txtNumberOfGuests.Name = "txtNumberOfGuests";
            this.txtNumberOfGuests.ReadOnly = true;
            this.txtNumberOfGuests.Size = new System.Drawing.Size(80, 20);
            this.txtNumberOfGuests.TabIndex = 9;
            // 
            // lstGuestList
            // 
            this.lstGuestList.FormattingEnabled = true;
            this.lstGuestList.Location = new System.Drawing.Point(268, 30);
            this.lstGuestList.Name = "lstGuestList";
            this.lstGuestList.Size = new System.Drawing.Size(187, 251);
            this.lstGuestList.TabIndex = 10;
            this.lstGuestList.SelectedIndexChanged += new System.EventHandler(this.lstGuestList_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 363);
            this.Controls.Add(this.lstGuestList);
            this.Controls.Add(this.txtNumberOfGuests);
            this.Controls.Add(this.txtTotalCost);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.lblNumerOfGuests);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.ListLabel);
            this.Controls.Add(this.grpAddGuests);
            this.Controls.Add(this.grpNewParty);
            this.Name = "MainForm";
            this.Text = "Party Org.";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpNewParty.ResumeLayout(false);
            this.grpNewParty.PerformLayout();
            this.grpAddGuests.ResumeLayout(false);
            this.grpAddGuests.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpNewParty;
        private System.Windows.Forms.GroupBox grpAddGuests;
        private System.Windows.Forms.Label lblTotalNumberOfGuests;
        private System.Windows.Forms.Label ListLabel;
        private System.Windows.Forms.Label lblCostPerPerson;
        private System.Windows.Forms.Button btnCreateList;
        private System.Windows.Forms.TextBox txtTotalNumberOfGuests;
        private System.Windows.Forms.TextBox txtCostPerPerson;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label lblNumerOfGuests;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtTotalCost;
        private System.Windows.Forms.TextBox txtNumberOfGuests;
        private System.Windows.Forms.ListBox lstGuestList;
    }
}

