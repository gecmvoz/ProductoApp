
using System;

namespace ProductosM1.Forms
{
    partial class FmrProductosManageY
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
            this.pnlFindById = new System.Windows.Forms.Panel();
            this.txtId = new System.Windows.Forms.TextBox();
            this.pnlMeassureUnit = new System.Windows.Forms.Panel();
            this.cmbMeassureUnit = new System.Windows.Forms.ComboBox();
            this.pnlRangePrice = new System.Windows.Forms.Panel();
            this.nudToPrice = new System.Windows.Forms.NumericUpDown();
            this.nudFromPrice = new System.Windows.Forms.NumericUpDown();
            this.pnlCaducity = new System.Windows.Forms.Panel();
            this.dtpCaducity = new System.Windows.Forms.DateTimePicker();
            this.cmbFinder = new System.Windows.Forms.ComboBox();
            this.rtbProductview = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.pnlFindById.SuspendLayout();
            this.pnlMeassureUnit.SuspendLayout();
            this.pnlRangePrice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudToPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFromPrice)).BeginInit();
            this.pnlCaducity.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFindById
            // 
            this.pnlFindById.CausesValidation = false;
            this.pnlFindById.Controls.Add(this.txtId);
            this.pnlFindById.Controls.Add(this.pnlMeassureUnit);
            this.pnlFindById.Location = new System.Drawing.Point(308, 12);
            this.pnlFindById.Name = "pnlFindById";
            this.pnlFindById.Size = new System.Drawing.Size(213, 21);
            this.pnlFindById.TabIndex = 1;
            this.pnlFindById.Visible = false;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(3, 1);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(207, 20);
            this.txtId.TabIndex = 3;
            // 
            // pnlMeassureUnit
            // 
            this.pnlMeassureUnit.Controls.Add(this.cmbMeassureUnit);
            this.pnlMeassureUnit.Location = new System.Drawing.Point(0, 0);
            this.pnlMeassureUnit.Name = "pnlMeassureUnit";
            this.pnlMeassureUnit.Size = new System.Drawing.Size(213, 26);
            this.pnlMeassureUnit.TabIndex = 2;
            this.pnlMeassureUnit.Visible = false;
            // 
            // cmbMeassureUnit
            // 
            this.cmbMeassureUnit.AutoCompleteCustomSource.AddRange(new string[] {
            "ID",
            "Unidad de Medida",
            "Rango de Precio",
            "Fecha de Caducidad"});
            this.cmbMeassureUnit.FormattingEnabled = true;
            this.cmbMeassureUnit.Location = new System.Drawing.Point(3, 3);
            this.cmbMeassureUnit.Name = "cmbMeassureUnit";
            this.cmbMeassureUnit.Size = new System.Drawing.Size(207, 21);
            this.cmbMeassureUnit.TabIndex = 3;
            // 
            // pnlRangePrice
            // 
            this.pnlRangePrice.Controls.Add(this.nudToPrice);
            this.pnlRangePrice.Controls.Add(this.nudFromPrice);
            this.pnlRangePrice.Location = new System.Drawing.Point(308, 13);
            this.pnlRangePrice.Name = "pnlRangePrice";
            this.pnlRangePrice.Size = new System.Drawing.Size(213, 21);
            this.pnlRangePrice.TabIndex = 2;
            this.pnlRangePrice.Visible = false;
            // 
            // nudToPrice
            // 
            this.nudToPrice.Location = new System.Drawing.Point(124, 1);
            this.nudToPrice.Name = "nudToPrice";
            this.nudToPrice.Size = new System.Drawing.Size(89, 20);
            this.nudToPrice.TabIndex = 3;
            // 
            // nudFromPrice
            // 
            this.nudFromPrice.Location = new System.Drawing.Point(3, -1);
            this.nudFromPrice.Name = "nudFromPrice";
            this.nudFromPrice.Size = new System.Drawing.Size(89, 20);
            this.nudFromPrice.TabIndex = 4;
            // 
            // pnlCaducity
            // 
            this.pnlCaducity.Controls.Add(this.dtpCaducity);
            this.pnlCaducity.Location = new System.Drawing.Point(308, 17);
            this.pnlCaducity.Name = "pnlCaducity";
            this.pnlCaducity.Size = new System.Drawing.Size(213, 21);
            this.pnlCaducity.TabIndex = 2;
            this.pnlCaducity.Visible = false;
            // 
            // dtpCaducity
            // 
            this.dtpCaducity.Location = new System.Drawing.Point(19, 1);
            this.dtpCaducity.Name = "dtpCaducity";
            this.dtpCaducity.Size = new System.Drawing.Size(188, 20);
            this.dtpCaducity.TabIndex = 3;
            // 
            // cmbFinder
            // 
            this.cmbFinder.AutoCompleteCustomSource.AddRange(new string[] {
            "ID",
            "Unidad de Medida",
            "Rango de Precio",
            "Fecha de Vencimiento"});
            this.cmbFinder.FormattingEnabled = true;
            this.cmbFinder.Location = new System.Drawing.Point(12, 12);
            this.cmbFinder.Name = "cmbFinder";
            this.cmbFinder.Size = new System.Drawing.Size(146, 21);
            this.cmbFinder.TabIndex = 0;
            this.cmbFinder.SelectedIndexChanged += new System.EventHandler(this.cmbFinder_SelectedIndexChanged);
            // 
            // rtbProductview
            // 
            this.rtbProductview.Location = new System.Drawing.Point(2, 44);
            this.rtbProductview.Name = "rtbProductview";
            this.rtbProductview.Size = new System.Drawing.Size(519, 182);
            this.rtbProductview.TabIndex = 3;
            this.rtbProductview.Text = "";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnEliminar);
            this.flowLayoutPanel1.Controls.Add(this.btnModificar);
            this.flowLayoutPanel1.Controls.Add(this.btnNuevo);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(186, 242);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(329, 39);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(226, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 30);
            this.btnEliminar.TabIndex = 0;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(120, 3);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(100, 30);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(14, 3);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(100, 30);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // FmrProductosManageY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 293);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.rtbProductview);
            this.Controls.Add(this.pnlCaducity);
            this.Controls.Add(this.pnlRangePrice);
            this.Controls.Add(this.pnlFindById);
            this.Controls.Add(this.cmbFinder);
            this.Name = "FmrProductosManageY";
            this.Text = "FmrProductosManageY";
            this.pnlFindById.ResumeLayout(false);
            this.pnlFindById.PerformLayout();
            this.pnlMeassureUnit.ResumeLayout(false);
            this.pnlRangePrice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudToPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFromPrice)).EndInit();
            this.pnlCaducity.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFindById;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ComboBox cmbMeassureUnit;
        private System.Windows.Forms.Panel pnlRangePrice;
        private System.Windows.Forms.Panel pnlCaducity;
        private System.Windows.Forms.ComboBox cmbFinder;
        private System.Windows.Forms.NumericUpDown nudFromPrice;
        private System.Windows.Forms.NumericUpDown nudToPrice;
        private System.Windows.Forms.DateTimePicker dtpCaducity;
        private System.Windows.Forms.RichTextBox rtbProductview;
        private System.Windows.Forms.Panel pnlMeassureUnit;
        private readonly EventHandler FmrProductosManageY_Load;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
    }
}