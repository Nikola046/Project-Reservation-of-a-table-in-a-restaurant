
namespace Rezervacija_stola_u_restoranu
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            this.btn_nazad = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rezervacijeeeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rezervacijaStolaDataSet = new Rezervacija_stola_u_restoranu.RezervacijaStolaDataSet();
            this.rezervacijeeeeTableAdapter = new Rezervacija_stola_u_restoranu.RezervacijaStolaDataSetTableAdapters.RezervacijeeeeTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imePrezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumVremeRezervacijeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zaKadRezervisanoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vremeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervacijeeeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervacijaStolaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_nazad
            // 
            this.btn_nazad.BackColor = System.Drawing.Color.LightBlue;
            this.btn_nazad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nazad.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nazad.Location = new System.Drawing.Point(597, 307);
            this.btn_nazad.Name = "btn_nazad";
            this.btn_nazad.Size = new System.Drawing.Size(131, 38);
            this.btn_nazad.TabIndex = 1;
            this.btn_nazad.Text = "Nazad";
            this.btn_nazad.UseVisualStyleBackColor = false;
            this.btn_nazad.Click += new System.EventHandler(this.btn_nazad_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.imePrezimeDataGridViewTextBoxColumn,
            this.datumVremeRezervacijeDataGridViewTextBoxColumn,
            this.zaKadRezervisanoDataGridViewTextBoxColumn,
            this.vremeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rezervacijeeeeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(628, 253);
            this.dataGridView1.TabIndex = 2;
            // 
            // rezervacijeeeeBindingSource
            // 
            this.rezervacijeeeeBindingSource.DataMember = "Rezervacijeeee";
            this.rezervacijeeeeBindingSource.DataSource = this.rezervacijaStolaDataSet;
            // 
            // rezervacijaStolaDataSet
            // 
            this.rezervacijaStolaDataSet.DataSetName = "RezervacijaStolaDataSet";
            this.rezervacijaStolaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rezervacijeeeeTableAdapter
            // 
            this.rezervacijeeeeTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // imePrezimeDataGridViewTextBoxColumn
            // 
            this.imePrezimeDataGridViewTextBoxColumn.DataPropertyName = "ImePrezime";
            this.imePrezimeDataGridViewTextBoxColumn.HeaderText = "ImePrezime";
            this.imePrezimeDataGridViewTextBoxColumn.Name = "imePrezimeDataGridViewTextBoxColumn";
            this.imePrezimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.imePrezimeDataGridViewTextBoxColumn.Width = 150;
            // 
            // datumVremeRezervacijeDataGridViewTextBoxColumn
            // 
            this.datumVremeRezervacijeDataGridViewTextBoxColumn.DataPropertyName = "DatumVremeRezervacije";
            this.datumVremeRezervacijeDataGridViewTextBoxColumn.HeaderText = "DatumVremeRezervacije";
            this.datumVremeRezervacijeDataGridViewTextBoxColumn.Name = "datumVremeRezervacijeDataGridViewTextBoxColumn";
            this.datumVremeRezervacijeDataGridViewTextBoxColumn.ReadOnly = true;
            this.datumVremeRezervacijeDataGridViewTextBoxColumn.Width = 180;
            // 
            // zaKadRezervisanoDataGridViewTextBoxColumn
            // 
            this.zaKadRezervisanoDataGridViewTextBoxColumn.DataPropertyName = "ZaKadRezervisano";
            this.zaKadRezervisanoDataGridViewTextBoxColumn.HeaderText = "ZaKadRezervisano";
            this.zaKadRezervisanoDataGridViewTextBoxColumn.Name = "zaKadRezervisanoDataGridViewTextBoxColumn";
            this.zaKadRezervisanoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vremeDataGridViewTextBoxColumn
            // 
            this.vremeDataGridViewTextBoxColumn.DataPropertyName = "Vreme";
            this.vremeDataGridViewTextBoxColumn.HeaderText = "Vreme";
            this.vremeDataGridViewTextBoxColumn.Name = "vremeDataGridViewTextBoxColumn";
            this.vremeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Rezervacija_stola_u_restoranu.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(748, 365);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_nazad);
            this.Name = "Form3";
            this.Text = "Pregled rezervacija";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervacijeeeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervacijaStolaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_nazad;
        private System.Windows.Forms.DataGridView dataGridView1;
        private RezervacijaStolaDataSet rezervacijaStolaDataSet;
        private System.Windows.Forms.BindingSource rezervacijeeeeBindingSource;
        private RezervacijaStolaDataSetTableAdapters.RezervacijeeeeTableAdapter rezervacijeeeeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imePrezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumVremeRezervacijeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zaKadRezervisanoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vremeDataGridViewTextBoxColumn;
    }
}