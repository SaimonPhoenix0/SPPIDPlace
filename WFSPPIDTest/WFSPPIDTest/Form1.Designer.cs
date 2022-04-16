namespace WFSPPIDTest
{
    partial class Form1
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TbLogs = new System.Windows.Forms.TextBox();
            this.btnCreateMainPipeline = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPipelineStartPoint = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPipelineEndPoint = new System.Windows.Forms.TextBox();
            this.btnAddBranch = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.tbParentPiplineId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbConnectionPoint = new System.Windows.Forms.TextBox();
            this.tbBranchEndPoint = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.88716F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.11285F));
            this.tableLayoutPanel1.Controls.Add(this.TbLogs, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnCreateMainPipeline, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAddBranch, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(792, 253);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // TbLogs
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.TbLogs, 2);
            this.TbLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbLogs.Location = new System.Drawing.Point(3, 69);
            this.TbLogs.Multiline = true;
            this.TbLogs.Name = "TbLogs";
            this.TbLogs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TbLogs.Size = new System.Drawing.Size(786, 181);
            this.TbLogs.TabIndex = 3;
            // 
            // btnCreateMainPipeline
            // 
            this.btnCreateMainPipeline.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCreateMainPipeline.Location = new System.Drawing.Point(8, 5);
            this.btnCreateMainPipeline.Name = "btnCreateMainPipeline";
            this.btnCreateMainPipeline.Size = new System.Drawing.Size(124, 23);
            this.btnCreateMainPipeline.TabIndex = 4;
            this.btnCreateMainPipeline.Text = "Add mainPipeline";
            this.btnCreateMainPipeline.UseVisualStyleBackColor = true;
            this.btnCreateMainPipeline.Click += new System.EventHandler(this.btnCreateMainPipeline_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 382F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tbPipelineStartPoint, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label6, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.tbPipelineEndPoint, 3, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(144, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(645, 27);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "StartPoint(X0;Y0)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbPipelineStartPoint
            // 
            this.tbPipelineStartPoint.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbPipelineStartPoint.Location = new System.Drawing.Point(106, 3);
            this.tbPipelineStartPoint.Name = "tbPipelineStartPoint";
            this.tbPipelineStartPoint.Size = new System.Drawing.Size(54, 20);
            this.tbPipelineStartPoint.TabIndex = 2;
            this.tbPipelineStartPoint.Text = "0.05;0.3";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(175, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "EndPoint(X1;Y1)";
            // 
            // tbPipelineEndPoint
            // 
            this.tbPipelineEndPoint.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbPipelineEndPoint.Location = new System.Drawing.Point(266, 3);
            this.tbPipelineEndPoint.Name = "tbPipelineEndPoint";
            this.tbPipelineEndPoint.Size = new System.Drawing.Size(54, 20);
            this.tbPipelineEndPoint.TabIndex = 5;
            this.tbPipelineEndPoint.Text = "0.5;0.3";
            // 
            // btnAddBranch
            // 
            this.btnAddBranch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddBranch.Location = new System.Drawing.Point(8, 38);
            this.btnAddBranch.Name = "btnAddBranch";
            this.btnAddBranch.Size = new System.Drawing.Size(124, 23);
            this.btnAddBranch.TabIndex = 6;
            this.btnAddBranch.Text = "Add branch";
            this.btnAddBranch.UseVisualStyleBackColor = true;
            this.btnAddBranch.Click += new System.EventHandler(this.btnAddBranch_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 6;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 228F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tbParentPiplineId, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label4, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.label8, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.tbConnectionPoint, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.tbBranchEndPoint, 5, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(144, 36);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(645, 27);
            this.tableLayoutPanel3.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "ParentPipelineId";
            // 
            // tbParentPiplineId
            // 
            this.tbParentPiplineId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbParentPiplineId.Location = new System.Drawing.Point(95, 3);
            this.tbParentPiplineId.Name = "tbParentPiplineId";
            this.tbParentPiplineId.Size = new System.Drawing.Size(222, 20);
            this.tbParentPiplineId.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(501, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "EndPoint (X;Y)";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(323, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "ConnectionPoint X;Y";
            // 
            // tbConnectionPoint
            // 
            this.tbConnectionPoint.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbConnectionPoint.Location = new System.Drawing.Point(434, 3);
            this.tbConnectionPoint.Name = "tbConnectionPoint";
            this.tbConnectionPoint.Size = new System.Drawing.Size(52, 20);
            this.tbConnectionPoint.TabIndex = 7;
            this.tbConnectionPoint.Text = "0.0;0.0";
            // 
            // tbBranchEndPoint
            // 
            this.tbBranchEndPoint.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbBranchEndPoint.Location = new System.Drawing.Point(583, 3);
            this.tbBranchEndPoint.Name = "tbBranchEndPoint";
            this.tbBranchEndPoint.Size = new System.Drawing.Size(54, 20);
            this.tbBranchEndPoint.TabIndex = 4;
            this.tbBranchEndPoint.Text = "0.0;0.0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 253);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox TbLogs;
        private System.Windows.Forms.Button btnCreateMainPipeline;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPipelineStartPoint;
        private System.Windows.Forms.Button btnAddBranch;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbParentPiplineId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbBranchEndPoint;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPipelineEndPoint;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbConnectionPoint;
    }
}

