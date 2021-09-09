namespace ProductosM1.Forms
{
    partial class FmrProductosManage
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.cmbFinder = new System.Windows.Forms.ComboBox();
            this.pnlFindById = new System.Windows.Forms.Panel();
            this.pnlCaducity = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtFinfById = new System.Windows.Forms.TextBox();
            this.pnlMeassureUnit = new System.Windows.Forms.Panel();
            this.cmbMeassureUnit = new System.Windows.Forms.ComboBox();
            this.pnlRangePrice = new System.Windows.Forms.Panel();
            this.nudToPrice = new System.Windows.Forms.NumericUpDown();
            this.nudFromPrice = new System.Windows.Forms.NumericUpDown();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnlFindById.SuspendLayout();
            this.pnlCaducity.SuspendLayout();
            this.pnlMeassureUnit.SuspendLayout();
            this.pnlRangePrice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudToPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFromPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnNuevo);
            this.flowLayoutPanel1.Controls.Add(this.btnModificar);
            this.flowLayoutPanel1.Controls.Add(this.btnEliminar);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(339, 395);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(449, 43);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(3, 3);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(100, 30);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(109, 3);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(100, 30);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(215, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 30);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // cmbFinder
            // 
            this.cmbFinder.FormattingEnabled = true;
            this.cmbFinder.Items.AddRange(new object[] {
            "Id",
            "Unidad de Medida",
            "Rango de Precio",
            "Fecha de Vencimiento"});
            this.cmbFinder.Location = new System.Drawing.Point(12, 12);
            this.cmbFinder.Name = "cmbFinder";
            this.cmbFinder.Size = new System.Drawing.Size(187, 21);
            this.cmbFinder.TabIndex = 1;
            this.cmbFinder.SelectedIndexChanged += new System.EventHandler(this.TxtId_TextChanged);
            // 
            // pnlFindById
            // 
            this.pnlFindById.Controls.Add(this.pnlCaducity);
            this.pnlFindById.Controls.Add(this.txtFinfById);
            this.pnlFindById.Location = new System.Drawing.Point(417, 12);
            this.pnlFindById.Name = "pnlFindById";
            this.pnlFindById.Size = new System.Drawing.Size(297, 32);
            this.pnlFindById.TabIndex = 2;
            this.pnlFindById.Visible = false;
            // 
            // pnlCaducity
            // 
            this.pnlCaducity.Controls.Add(this.dateTimePicker1);
            this.pnlCaducity.Location = new System.Drawing.Point(3, 3);
            this.pnlCaducity.Name = "pnlCaducity";
            this.pnlCaducity.Size = new System.Drawing.Size(297, 29);
            this.pnlCaducity.TabIndex = 6;
            this.pnlCaducity.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(42, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(260, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // txtFinfById
            // 
            this.txtFinfById.Location = new System.Drawing.Point(35, 3);
            this.txtFinfById.Name = "txtFinfById";
            this.txtFinfById.Size = new System.Drawing.Size(260, 20);
            this.txtFinfById.TabIndex = 0;
            // 
            // pnlMeassureUnit
            // 
            this.pnlMeassureUnit.Controls.Add(this.cmbMeassureUnit);
            this.pnlMeassureUnit.Location = new System.Drawing.Point(414, 15);
            this.pnlMeassureUnit.Name = "pnlMeassureUnit";
            this.pnlMeassureUnit.Size = new System.Drawing.Size(297, 29);
            this.pnlMeassureUnit.TabIndex = 3;
            this.pnlMeassureUnit.Visible = false;
            // 
            // cmbMeassureUnit
            // 
            this.cmbMeassureUnit.FormattingEnabled = true;
            this.cmbMeassureUnit.Location = new System.Drawing.Point(25, 3);
            this.cmbMeassureUnit.Name = "cmbMeassureUnit";
            this.cmbMeassureUnit.Size = new System.Drawing.Size(247, 21);
            this.cmbMeassureUnit.TabIndex = 4;
            // 
            // pnlRangePrice
            // 
            this.pnlRangePrice.Controls.Add(this.nudToPrice);
            this.pnlRangePrice.Controls.Add(this.nudFromPrice);
            this.pnlRangePrice.Location = new System.Drawing.Point(414, 18);
            this.pnlRangePrice.Name = "pnlRangePrice";
            this.pnlRangePrice.Size = new System.Drawing.Size(329, 29);
            this.pnlRangePrice.TabIndex = 5;
            this.pnlRangePrice.Visible = false;
            // 
            // nudToPrice
            // 
            this.nudToPrice.Location = new System.Drawing.Point(179, 3);
            this.nudToPrice.Name = "nudToPrice";
            this.nudToPrice.Size = new System.Drawing.Size(148, 20);
            this.nudToPrice.TabIndex = 1;
            // 
            // nudFromPrice
            // 
            this.nudFromPrice.Location = new System.Drawing.Point(13, 4);
            this.nudFromPrice.Name = "nudFromPrice";
            this.nudFromPrice.Size = new System.Drawing.Size(148, 20);
            this.nudFromPrice.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(6, 67);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(769, 279);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // FmrProductosManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.pnlMeassureUnit);
            this.Controls.Add(this.pnlRangePrice);
            this.Controls.Add(this.pnlFindById);
            this.Controls.Add(this.cmbFinder);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "FmrProductosManage";
            this.Text = "FmrProductosManage";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pnlFindById.ResumeLayout(false);
            this.pnlFindById.PerformLayout();
            this.pnlCaducity.ResumeLayout(false);
            this.pnlMeassureUnit.ResumeLayout(false);
            this.pnlRangePrice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudToPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFromPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ComboBox cmbFinder;
        private System.Windows.Forms.Panel pnlFindById;
        private System.Windows.Forms.Panel pnlMeassureUnit;
        private System.Windows.Forms.ComboBox cmbMeassureUnit;
        private System.Windows.Forms.Panel pnlRangePrice;
        private System.Windows.Forms.NumericUpDown nudToPrice;
        private System.Windows.Forms.NumericUpDown nudFromPrice;
        private System.Windows.Forms.Panel pnlCaducity;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtFinfById;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}