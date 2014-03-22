namespace OrchestrationOrderFinder
{
    partial class OrchestrationOrderFinder
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
            PresentationControls.CheckBoxProperties checkBoxProperties2 = new PresentationControls.CheckBoxProperties();
            PresentationControls.CheckBoxProperties checkBoxProperties3 = new PresentationControls.CheckBoxProperties();
            this.lblServer = new System.Windows.Forms.Label();
            this.tbServer = new System.Windows.Forms.TextBox();
            this.btnApplications = new System.Windows.Forms.Button();
            this.lblApplications = new System.Windows.Forms.Label();
            this.lblAssemblies = new System.Windows.Forms.Label();
            this.btnAssemblies = new System.Windows.Forms.Button();
            this.dgvOrchestrations = new System.Windows.Forms.DataGridView();
            this.btnOrchestraions = new System.Windows.Forms.Button();
            this.btnOrderOrchestrations = new System.Windows.Forms.Button();
            this.ddlApplications = new PresentationControls.CheckBoxComboBox();
            this.ddlAssemblies = new PresentationControls.CheckBoxComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrchestrations)).BeginInit();
            this.SuspendLayout();
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(32, 29);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(38, 13);
            this.lblServer.TabIndex = 0;
            this.lblServer.Text = "Server";
            // 
            // tbServer
            // 
            this.tbServer.Location = new System.Drawing.Point(130, 26);
            this.tbServer.Name = "tbServer";
            this.tbServer.Size = new System.Drawing.Size(463, 20);
            this.tbServer.TabIndex = 1;
            // 
            // btnApplications
            // 
            this.btnApplications.Location = new System.Drawing.Point(610, 24);
            this.btnApplications.Name = "btnApplications";
            this.btnApplications.Size = new System.Drawing.Size(104, 23);
            this.btnApplications.TabIndex = 3;
            this.btnApplications.Text = "Get Applications";
            this.btnApplications.UseVisualStyleBackColor = true;
            this.btnApplications.Click += new System.EventHandler(this.btnApplications_Click);
            // 
            // lblApplications
            // 
            this.lblApplications.AutoSize = true;
            this.lblApplications.Location = new System.Drawing.Point(32, 58);
            this.lblApplications.Name = "lblApplications";
            this.lblApplications.Size = new System.Drawing.Size(64, 13);
            this.lblApplications.TabIndex = 4;
            this.lblApplications.Text = "Applications";
            // 
            // lblAssemblies
            // 
            this.lblAssemblies.AutoSize = true;
            this.lblAssemblies.Location = new System.Drawing.Point(32, 95);
            this.lblAssemblies.Name = "lblAssemblies";
            this.lblAssemblies.Size = new System.Drawing.Size(59, 13);
            this.lblAssemblies.TabIndex = 5;
            this.lblAssemblies.Text = "Assemblies";
            // 
            // btnAssemblies
            // 
            this.btnAssemblies.Location = new System.Drawing.Point(610, 53);
            this.btnAssemblies.Name = "btnAssemblies";
            this.btnAssemblies.Size = new System.Drawing.Size(104, 23);
            this.btnAssemblies.TabIndex = 7;
            this.btnAssemblies.Text = "Get Assemblies";
            this.btnAssemblies.UseVisualStyleBackColor = true;
            this.btnAssemblies.Click += new System.EventHandler(this.btnAssemblies_Click);
            // 
            // dgvOrchestrations
            // 
            this.dgvOrchestrations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrchestrations.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvOrchestrations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrchestrations.Location = new System.Drawing.Point(35, 114);
            this.dgvOrchestrations.Name = "dgvOrchestrations";
            this.dgvOrchestrations.RowHeadersVisible = false;
            this.dgvOrchestrations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvOrchestrations.Size = new System.Drawing.Size(679, 334);
            this.dgvOrchestrations.TabIndex = 10;
            // 
            // btnOrchestraions
            // 
            this.btnOrchestraions.Location = new System.Drawing.Point(610, 85);
            this.btnOrchestraions.Name = "btnOrchestraions";
            this.btnOrchestraions.Size = new System.Drawing.Size(104, 23);
            this.btnOrchestraions.TabIndex = 11;
            this.btnOrchestraions.Text = "Get Orchestrations";
            this.btnOrchestraions.UseVisualStyleBackColor = true;
            this.btnOrchestraions.Click += new System.EventHandler(this.btnOrchestraions_Click);
            // 
            // btnOrderOrchestrations
            // 
            this.btnOrderOrchestrations.Location = new System.Drawing.Point(566, 454);
            this.btnOrderOrchestrations.Name = "btnOrderOrchestrations";
            this.btnOrderOrchestrations.Size = new System.Drawing.Size(148, 23);
            this.btnOrderOrchestrations.TabIndex = 12;
            this.btnOrderOrchestrations.Text = "Order Orchestrations";
            this.btnOrderOrchestrations.UseVisualStyleBackColor = true;
            this.btnOrderOrchestrations.Click += new System.EventHandler(this.btnOrderOrchestrations_Click);
            // 
            // ddlApplications
            // 
            checkBoxProperties2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ddlApplications.CheckBoxProperties = checkBoxProperties2;
            this.ddlApplications.DisplayMemberSingleItem = "";
            this.ddlApplications.FormattingEnabled = true;
            this.ddlApplications.Location = new System.Drawing.Point(130, 58);
            this.ddlApplications.Name = "ddlApplications";
            this.ddlApplications.Size = new System.Drawing.Size(463, 21);
            this.ddlApplications.TabIndex = 13;
            // 
            // ddlAssemblies
            // 
            checkBoxProperties3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ddlAssemblies.CheckBoxProperties = checkBoxProperties3;
            this.ddlAssemblies.DisplayMemberSingleItem = "";
            this.ddlAssemblies.FormattingEnabled = true;
            this.ddlAssemblies.Location = new System.Drawing.Point(130, 87);
            this.ddlAssemblies.Name = "ddlAssemblies";
            this.ddlAssemblies.Size = new System.Drawing.Size(463, 21);
            this.ddlAssemblies.TabIndex = 14;
            // 
            // OrchestrationOrderFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 493);
            this.Controls.Add(this.ddlAssemblies);
            this.Controls.Add(this.ddlApplications);
            this.Controls.Add(this.btnOrderOrchestrations);
            this.Controls.Add(this.btnOrchestraions);
            this.Controls.Add(this.dgvOrchestrations);
            this.Controls.Add(this.btnAssemblies);
            this.Controls.Add(this.lblAssemblies);
            this.Controls.Add(this.lblApplications);
            this.Controls.Add(this.btnApplications);
            this.Controls.Add(this.tbServer);
            this.Controls.Add(this.lblServer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrchestrationOrderFinder";
            this.Text = "Orchestration Order Finder";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrchestrations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.TextBox tbServer;
        private System.Windows.Forms.Button btnApplications;
        private System.Windows.Forms.Label lblApplications;
        private System.Windows.Forms.Label lblAssemblies;
        private System.Windows.Forms.Button btnAssemblies;
        private System.Windows.Forms.DataGridView dgvOrchestrations;
        private System.Windows.Forms.Button btnOrchestraions;
        private System.Windows.Forms.Button btnOrderOrchestrations;
        private PresentationControls.CheckBoxComboBox ddlApplications;
        private PresentationControls.CheckBoxComboBox ddlAssemblies;
    }
}

