namespace KinesisClient
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
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnCopyToClipboard = new System.Windows.Forms.Button();
            this.btnCollapseAll = new System.Windows.Forms.Button();
            this.jsonTreeView = new System.Windows.Forms.TreeView();
            this.rchJson = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.AWSAccessKeyId = new System.Windows.Forms.Label();
            this.cbRegion = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tbStreamName = new System.Windows.Forms.TextBox();
            this.tbAccessKeyId = new System.Windows.Forms.TextBox();
            this.tbAccessKeySecret = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbTimeperiod = new System.Windows.Forms.ComboBox();
            this.cmbEventNotification = new System.Windows.Forms.ComboBox();
            this.tbSubscriberId = new System.Windows.Forms.TextBox();
            this.tbBusinessUnit = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rchAdditionalFilter = new System.Windows.Forms.RichTextBox();
            this.btnExecute = new System.Windows.Forms.Button();
            this.groupBox6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox6.Controls.Add(this.btnCopyToClipboard);
            this.groupBox6.Controls.Add(this.btnCollapseAll);
            this.groupBox6.Controls.Add(this.jsonTreeView);
            this.groupBox6.Controls.Add(this.rchJson);
            this.groupBox6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(13, 252);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(1510, 695);
            this.groupBox6.TabIndex = 13;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Response";
            // 
            // btnCopyToClipboard
            // 
            this.btnCopyToClipboard.Location = new System.Drawing.Point(895, 16);
            this.btnCopyToClipboard.Margin = new System.Windows.Forms.Padding(4);
            this.btnCopyToClipboard.Name = "btnCopyToClipboard";
            this.btnCopyToClipboard.Size = new System.Drawing.Size(181, 28);
            this.btnCopyToClipboard.TabIndex = 8;
            this.btnCopyToClipboard.Text = "Copy To Clipboard";
            this.btnCopyToClipboard.UseVisualStyleBackColor = true;
            this.btnCopyToClipboard.Click += new System.EventHandler(this.btnCopyToClipboard_Click);
            // 
            // btnCollapseAll
            // 
            this.btnCollapseAll.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCollapseAll.Location = new System.Drawing.Point(4, 20);
            this.btnCollapseAll.Margin = new System.Windows.Forms.Padding(4);
            this.btnCollapseAll.Name = "btnCollapseAll";
            this.btnCollapseAll.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCollapseAll.Size = new System.Drawing.Size(41, 28);
            this.btnCollapseAll.TabIndex = 6;
            this.btnCollapseAll.Text = "--";
            this.btnCollapseAll.UseVisualStyleBackColor = true;
            this.btnCollapseAll.Click += new System.EventHandler(this.btnCollapseAll_Click);
            // 
            // jsonTreeView
            // 
            this.jsonTreeView.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jsonTreeView.Location = new System.Drawing.Point(8, 52);
            this.jsonTreeView.Margin = new System.Windows.Forms.Padding(4);
            this.jsonTreeView.Name = "jsonTreeView";
            this.jsonTreeView.Size = new System.Drawing.Size(714, 655);
            this.jsonTreeView.TabIndex = 4;
            // 
            // rchJson
            // 
            this.rchJson.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rchJson.Location = new System.Drawing.Point(730, 52);
            this.rchJson.Margin = new System.Windows.Forms.Padding(4);
            this.rchJson.Name = "rchJson";
            this.rchJson.Size = new System.Drawing.Size(772, 655);
            this.rchJson.TabIndex = 5;
            this.rchJson.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.tableLayoutPanel4);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(17, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(514, 231);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AWS Details";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel4.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.AWSAccessKeyId, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.cbRegion, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.label13, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label14, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.tbStreamName, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.tbAccessKeyId, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.tbAccessKeySecret, 1, 3);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(4, 32);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.2443F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.45277F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.05863F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.2443F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(502, 155);
            this.tableLayoutPanel4.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 125);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 19);
            this.label4.TabIndex = 20;
            this.label4.Text = "AWSSecretKey";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // AWSAccessKeyId
            // 
            this.AWSAccessKeyId.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.AWSAccessKeyId.AutoSize = true;
            this.AWSAccessKeyId.Location = new System.Drawing.Point(52, 85);
            this.AWSAccessKeyId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AWSAccessKeyId.Name = "AWSAccessKeyId";
            this.AWSAccessKeyId.Size = new System.Drawing.Size(144, 19);
            this.AWSAccessKeyId.TabIndex = 18;
            this.AWSAccessKeyId.Text = "AWSAccessKeyId";
            this.AWSAccessKeyId.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // cbRegion
            // 
            this.cbRegion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRegion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRegion.FormattingEnabled = true;
            this.cbRegion.Location = new System.Drawing.Point(204, 43);
            this.cbRegion.Margin = new System.Windows.Forms.Padding(4);
            this.cbRegion.Name = "cbRegion";
            this.cbRegion.Size = new System.Drawing.Size(278, 26);
            this.cbRegion.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(88, 10);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 19);
            this.label13.TabIndex = 10;
            this.label13.Text = "Stream Name";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(136, 47);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 19);
            this.label14.TabIndex = 13;
            this.label14.Text = "Region";
            this.label14.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // tbStreamName
            // 
            this.tbStreamName.Location = new System.Drawing.Point(203, 3);
            this.tbStreamName.Name = "tbStreamName";
            this.tbStreamName.Size = new System.Drawing.Size(279, 26);
            this.tbStreamName.TabIndex = 16;
            // 
            // tbAccessKeyId
            // 
            this.tbAccessKeyId.Location = new System.Drawing.Point(203, 78);
            this.tbAccessKeyId.Name = "tbAccessKeyId";
            this.tbAccessKeyId.Size = new System.Drawing.Size(279, 26);
            this.tbAccessKeyId.TabIndex = 19;
            // 
            // tbAccessKeySecret
            // 
            this.tbAccessKeySecret.Location = new System.Drawing.Point(203, 118);
            this.tbAccessKeySecret.Name = "tbAccessKeySecret";
            this.tbAccessKeySecret.PasswordChar = '*';
            this.tbAccessKeySecret.Size = new System.Drawing.Size(279, 26);
            this.tbAccessKeySecret.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(106, 127);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 19);
            this.label12.TabIndex = 9;
            this.label12.Text = "Time Period";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.08563F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.91437F));
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label12, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.label10, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.cmbTimeperiod, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.cmbEventNotification, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.tbSubscriberId, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.tbBusinessUnit, 1, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(8, 31);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(502, 156);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Business Unit Id";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Event Notification Type";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(94, 49);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 19);
            this.label10.TabIndex = 6;
            this.label10.Text = "Subscriber Id";
            // 
            // cmbTimeperiod
            // 
            this.cmbTimeperiod.FormattingEnabled = true;
            this.cmbTimeperiod.Location = new System.Drawing.Point(209, 120);
            this.cmbTimeperiod.Name = "cmbTimeperiod";
            this.cmbTimeperiod.Size = new System.Drawing.Size(290, 26);
            this.cmbTimeperiod.TabIndex = 18;
            // 
            // cmbEventNotification
            // 
            this.cmbEventNotification.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbEventNotification.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEventNotification.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEventNotification.FormattingEnabled = true;
            this.cmbEventNotification.Location = new System.Drawing.Point(210, 6);
            this.cmbEventNotification.Margin = new System.Windows.Forms.Padding(4);
            this.cmbEventNotification.Name = "cmbEventNotification";
            this.cmbEventNotification.Size = new System.Drawing.Size(288, 26);
            this.cmbEventNotification.TabIndex = 2;
            this.cmbEventNotification.SelectedIndexChanged += new System.EventHandler(this.cmbEventNotification_SelectedIndexChanged);
            // 
            // tbSubscriberId
            // 
            this.tbSubscriberId.Location = new System.Drawing.Point(209, 42);
            this.tbSubscriberId.Name = "tbSubscriberId";
            this.tbSubscriberId.Size = new System.Drawing.Size(290, 26);
            this.tbSubscriberId.TabIndex = 7;
            // 
            // tbBusinessUnit
            // 
            this.tbBusinessUnit.Location = new System.Drawing.Point(209, 81);
            this.tbBusinessUnit.Name = "tbBusinessUnit";
            this.tbBusinessUnit.Size = new System.Drawing.Size(290, 26);
            this.tbBusinessUnit.TabIndex = 8;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox5.Controls.Add(this.tableLayoutPanel3);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.rchAdditionalFilter);
            this.groupBox5.Controls.Add(this.btnExecute);
            this.groupBox5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(539, 13);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(1168, 231);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Filter";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(510, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Additional Filter(Json format)";
            // 
            // rchAdditionalFilter
            // 
            this.rchAdditionalFilter.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rchAdditionalFilter.Location = new System.Drawing.Point(539, 23);
            this.rchAdditionalFilter.Margin = new System.Windows.Forms.Padding(4);
            this.rchAdditionalFilter.Name = "rchAdditionalFilter";
            this.rchAdditionalFilter.Size = new System.Drawing.Size(445, 189);
            this.rchAdditionalFilter.TabIndex = 10;
            this.rchAdditionalFilter.Text = "";
            // 
            // btnExecute
            // 
            this.btnExecute.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecute.Location = new System.Drawing.Point(152, 195);
            this.btnExecute.Margin = new System.Windows.Forms.Padding(4);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(202, 28);
            this.btnExecute.TabIndex = 6;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1536, 976);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox6);
            this.Name = "MainForm";
            this.Text = "Kinesis Stream Client";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox6.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnCopyToClipboard;
        public System.Windows.Forms.Button btnCollapseAll;
        public System.Windows.Forms.TreeView jsonTreeView;
        public System.Windows.Forms.RichTextBox rchJson;
        public System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.ComboBox cmbEventNotification;
        public System.Windows.Forms.GroupBox groupBox5;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.RichTextBox rchAdditionalFilter;
        public System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.TextBox tbSubscriberId;
        public System.Windows.Forms.ComboBox cbRegion;
        private System.Windows.Forms.TextBox tbStreamName;
        private System.Windows.Forms.TextBox tbBusinessUnit;
        private System.Windows.Forms.ComboBox cmbTimeperiod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label AWSAccessKeyId;
        private System.Windows.Forms.TextBox tbAccessKeyId;
        private System.Windows.Forms.TextBox tbAccessKeySecret;
    }
}

