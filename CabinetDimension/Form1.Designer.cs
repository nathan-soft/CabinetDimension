namespace CabinetDimension
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
            this.tabTopCabinet = new System.Windows.Forms.TabControl();
            this.tbpTopCabinet = new System.Windows.Forms.TabPage();
            this.lstvTopCabinet = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbpBottomCabinet = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clumQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCalculateBottomDimension = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtPlywoodThickness = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOverallHeight = new System.Windows.Forms.TextBox();
            this.txtToeKickHeight = new System.Windows.Forms.TextBox();
            this.txtToeKickDepth = new System.Windows.Forms.TextBox();
            this.txtCabinetDepth = new System.Windows.Forms.TextBox();
            this.txtCabinetWidth = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nupdQuantity = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtTopCabPlywoodThickness = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTopCabHeight = new System.Windows.Forms.TextBox();
            this.txtTopCabDepth = new System.Windows.Forms.TextBox();
            this.txtTopCabWidth = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.nupdTopCabQuantity = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.btnCalTopCabinet = new System.Windows.Forms.Button();
            this.tabTopCabinet.SuspendLayout();
            this.tbpTopCabinet.SuspendLayout();
            this.tbpBottomCabinet.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupdQuantity)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupdTopCabQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // tabTopCabinet
            // 
            this.tabTopCabinet.Controls.Add(this.tbpTopCabinet);
            this.tabTopCabinet.Controls.Add(this.tbpBottomCabinet);
            this.tabTopCabinet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabTopCabinet.Location = new System.Drawing.Point(0, 0);
            this.tabTopCabinet.Name = "tabTopCabinet";
            this.tabTopCabinet.SelectedIndex = 0;
            this.tabTopCabinet.Size = new System.Drawing.Size(549, 430);
            this.tabTopCabinet.TabIndex = 0;
            // 
            // tbpTopCabinet
            // 
            this.tbpTopCabinet.Controls.Add(this.btnCalTopCabinet);
            this.tbpTopCabinet.Controls.Add(this.tableLayoutPanel2);
            this.tbpTopCabinet.Controls.Add(this.lstvTopCabinet);
            this.tbpTopCabinet.Location = new System.Drawing.Point(4, 22);
            this.tbpTopCabinet.Name = "tbpTopCabinet";
            this.tbpTopCabinet.Padding = new System.Windows.Forms.Padding(3);
            this.tbpTopCabinet.Size = new System.Drawing.Size(541, 404);
            this.tbpTopCabinet.TabIndex = 0;
            this.tbpTopCabinet.Text = "Top Cabinet";
            this.tbpTopCabinet.UseVisualStyleBackColor = true;
            // 
            // lstvTopCabinet
            // 
            this.lstvTopCabinet.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lstvTopCabinet.Location = new System.Drawing.Point(17, 183);
            this.lstvTopCabinet.Name = "lstvTopCabinet";
            this.lstvTopCabinet.Size = new System.Drawing.Size(398, 156);
            this.lstvTopCabinet.TabIndex = 3;
            this.lstvTopCabinet.UseCompatibleStateImageBehavior = false;
            this.lstvTopCabinet.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Name";
            this.columnHeader4.Width = 111;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Length(cm)";
            this.columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Width(cm)";
            this.columnHeader6.Width = 80;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Quantity";
            this.columnHeader7.Width = 80;
            // 
            // tbpBottomCabinet
            // 
            this.tbpBottomCabinet.Controls.Add(this.listView1);
            this.tbpBottomCabinet.Controls.Add(this.btnCalculateBottomDimension);
            this.tbpBottomCabinet.Controls.Add(this.tableLayoutPanel1);
            this.tbpBottomCabinet.Location = new System.Drawing.Point(4, 22);
            this.tbpBottomCabinet.Name = "tbpBottomCabinet";
            this.tbpBottomCabinet.Padding = new System.Windows.Forms.Padding(3);
            this.tbpBottomCabinet.Size = new System.Drawing.Size(541, 404);
            this.tbpBottomCabinet.TabIndex = 1;
            this.tbpBottomCabinet.Text = "Bottom Cabinet";
            this.tbpBottomCabinet.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader2,
            this.clumQuantity});
            this.listView1.Location = new System.Drawing.Point(21, 230);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(324, 156);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Length(cm)";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Width(cm)";
            this.columnHeader2.Width = 80;
            // 
            // clumQuantity
            // 
            this.clumQuantity.Text = "Quantity";
            this.clumQuantity.Width = 80;
            // 
            // btnCalculateBottomDimension
            // 
            this.btnCalculateBottomDimension.Location = new System.Drawing.Point(408, 184);
            this.btnCalculateBottomDimension.Name = "btnCalculateBottomDimension";
            this.btnCalculateBottomDimension.Size = new System.Drawing.Size(111, 34);
            this.btnCalculateBottomDimension.TabIndex = 1;
            this.btnCalculateBottomDimension.Text = "Calculate";
            this.btnCalculateBottomDimension.UseVisualStyleBackColor = true;
            this.btnCalculateBottomDimension.Click += new System.EventHandler(this.btnCalculateBottomDimension_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.77551F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.22449F));
            this.tableLayoutPanel1.Controls.Add(this.txtPlywoodThickness, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtOverallHeight, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtToeKickHeight, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtToeKickDepth, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtCabinetDepth, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtCabinetWidth, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.nupdQuantity, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(21, 17);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(284, 201);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // txtPlywoodThickness
            // 
            this.txtPlywoodThickness.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPlywoodThickness.Location = new System.Drawing.Point(113, 135);
            this.txtPlywoodThickness.Name = "txtPlywoodThickness";
            this.txtPlywoodThickness.Size = new System.Drawing.Size(168, 20);
            this.txtPlywoodThickness.TabIndex = 14;
            this.txtPlywoodThickness.Text = "1.5";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cabinet Width";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cabinet Depth";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Toe Kick Depth";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Toe Kick Height";
            // 
            // txtOverallHeight
            // 
            this.txtOverallHeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOverallHeight.Location = new System.Drawing.Point(113, 3);
            this.txtOverallHeight.Name = "txtOverallHeight";
            this.txtOverallHeight.Size = new System.Drawing.Size(168, 20);
            this.txtOverallHeight.TabIndex = 1;
            this.txtOverallHeight.Text = "90";
            // 
            // txtToeKickHeight
            // 
            this.txtToeKickHeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtToeKickHeight.Location = new System.Drawing.Point(113, 28);
            this.txtToeKickHeight.Name = "txtToeKickHeight";
            this.txtToeKickHeight.Size = new System.Drawing.Size(168, 20);
            this.txtToeKickHeight.TabIndex = 2;
            this.txtToeKickHeight.Text = "10";
            // 
            // txtToeKickDepth
            // 
            this.txtToeKickDepth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtToeKickDepth.Location = new System.Drawing.Point(113, 49);
            this.txtToeKickDepth.Name = "txtToeKickDepth";
            this.txtToeKickDepth.Size = new System.Drawing.Size(168, 20);
            this.txtToeKickDepth.TabIndex = 3;
            this.txtToeKickDepth.Text = "8";
            // 
            // txtCabinetDepth
            // 
            this.txtCabinetDepth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCabinetDepth.Location = new System.Drawing.Point(113, 79);
            this.txtCabinetDepth.Name = "txtCabinetDepth";
            this.txtCabinetDepth.Size = new System.Drawing.Size(168, 20);
            this.txtCabinetDepth.TabIndex = 4;
            this.txtCabinetDepth.Text = "56";
            // 
            // txtCabinetWidth
            // 
            this.txtCabinetWidth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCabinetWidth.Location = new System.Drawing.Point(113, 108);
            this.txtCabinetWidth.Name = "txtCabinetWidth";
            this.txtCabinetWidth.Size = new System.Drawing.Size(168, 20);
            this.txtCabinetWidth.TabIndex = 5;
            this.txtCabinetWidth.Text = "60";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Overall Height";
            // 
            // nupdQuantity
            // 
            this.nupdQuantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nupdQuantity.Location = new System.Drawing.Point(113, 167);
            this.nupdQuantity.Name = "nupdQuantity";
            this.nupdQuantity.Size = new System.Drawing.Size(168, 20);
            this.nupdQuantity.TabIndex = 6;
            this.nupdQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Plywood Thickness";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.77551F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.22449F));
            this.tableLayoutPanel2.Controls.Add(this.txtTopCabPlywoodThickness, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtTopCabHeight, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtTopCabDepth, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtTopCabWidth, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label13, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.nupdTopCabQuantity, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.label14, 0, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(17, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(284, 144);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // txtTopCabPlywoodThickness
            // 
            this.txtTopCabPlywoodThickness.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTopCabPlywoodThickness.Location = new System.Drawing.Point(113, 84);
            this.txtTopCabPlywoodThickness.Name = "txtTopCabPlywoodThickness";
            this.txtTopCabPlywoodThickness.Size = new System.Drawing.Size(168, 20);
            this.txtTopCabPlywoodThickness.TabIndex = 14;
            this.txtTopCabPlywoodThickness.Text = "1.5";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Quantity";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Cabinet Width";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Cabinet Depth";
            // 
            // txtTopCabHeight
            // 
            this.txtTopCabHeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTopCabHeight.Location = new System.Drawing.Point(113, 3);
            this.txtTopCabHeight.Name = "txtTopCabHeight";
            this.txtTopCabHeight.Size = new System.Drawing.Size(168, 20);
            this.txtTopCabHeight.TabIndex = 1;
            this.txtTopCabHeight.Text = "72";
            // 
            // txtTopCabDepth
            // 
            this.txtTopCabDepth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTopCabDepth.Location = new System.Drawing.Point(113, 28);
            this.txtTopCabDepth.Name = "txtTopCabDepth";
            this.txtTopCabDepth.Size = new System.Drawing.Size(168, 20);
            this.txtTopCabDepth.TabIndex = 4;
            this.txtTopCabDepth.Text = "30";
            // 
            // txtTopCabWidth
            // 
            this.txtTopCabWidth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTopCabWidth.Location = new System.Drawing.Point(113, 57);
            this.txtTopCabWidth.Name = "txtTopCabWidth";
            this.txtTopCabWidth.Size = new System.Drawing.Size(168, 20);
            this.txtTopCabWidth.TabIndex = 5;
            this.txtTopCabWidth.Text = "60";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "Overall Height";
            // 
            // nupdTopCabQuantity
            // 
            this.nupdTopCabQuantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nupdTopCabQuantity.Location = new System.Drawing.Point(113, 116);
            this.nupdTopCabQuantity.Name = "nupdTopCabQuantity";
            this.nupdTopCabQuantity.Size = new System.Drawing.Size(168, 20);
            this.nupdTopCabQuantity.TabIndex = 6;
            this.nupdTopCabQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 81);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "Plywood Thickness";
            // 
            // btnCalTopCabinet
            // 
            this.btnCalTopCabinet.Location = new System.Drawing.Point(404, 132);
            this.btnCalTopCabinet.Name = "btnCalTopCabinet";
            this.btnCalTopCabinet.Size = new System.Drawing.Size(111, 34);
            this.btnCalTopCabinet.TabIndex = 5;
            this.btnCalTopCabinet.Text = "Calculate";
            this.btnCalTopCabinet.UseVisualStyleBackColor = true;
            this.btnCalTopCabinet.Click += new System.EventHandler(this.btnCalTopCabinet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 430);
            this.Controls.Add(this.tabTopCabinet);
            this.Name = "Form1";
            this.Text = "Cabinet Dimension Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabTopCabinet.ResumeLayout(false);
            this.tbpTopCabinet.ResumeLayout(false);
            this.tbpBottomCabinet.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupdQuantity)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupdTopCabQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabTopCabinet;
        private System.Windows.Forms.TabPage tbpTopCabinet;
        private System.Windows.Forms.TabPage tbpBottomCabinet;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtPlywoodThickness;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOverallHeight;
        private System.Windows.Forms.TextBox txtToeKickHeight;
        private System.Windows.Forms.TextBox txtToeKickDepth;
        private System.Windows.Forms.TextBox txtCabinetDepth;
        private System.Windows.Forms.TextBox txtCabinetWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nupdQuantity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCalculateBottomDimension;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader clumQuantity;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView lstvTopCabinet;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button btnCalTopCabinet;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtTopCabPlywoodThickness;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTopCabHeight;
        private System.Windows.Forms.TextBox txtTopCabDepth;
        private System.Windows.Forms.TextBox txtTopCabWidth;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown nupdTopCabQuantity;
        private System.Windows.Forms.Label label14;
    }
}

