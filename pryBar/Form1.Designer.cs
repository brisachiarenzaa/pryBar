using System.Windows.Forms;

namespace pryBar
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView gridVentas;
        private Button btnValidar;
        private Button btnMozoDia;
        private Button btnTotales;
        private Button btnCerrar;
        private Label lblMozoDiaNombre;
        private Label lblMozoDiaMonto;
        private Label lblTotalGeneral;
        private Label lblTotalComidas;
        private Label lblTotalSinAlcohol;
        private Label lblTotalConAlcohol;
        private Label lblTotalPostres;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gridVentas = new DataGridView();
            this.btnValidar = new Button();
            this.btnMozoDia = new Button();
            this.btnTotales = new Button();
            this.btnCerrar = new Button();
            this.lblMozoDiaNombre = new Label();
            this.lblMozoDiaMonto = new Label();
            this.lblTotalGeneral = new Label();
            this.lblTotalComidas = new Label();
            this.lblTotalSinAlcohol = new Label();
            this.lblTotalConAlcohol = new Label();
            this.lblTotalPostres = new Label();

            ((System.ComponentModel.ISupportInitialize)(this.gridVentas)).BeginInit();
            this.SuspendLayout();

            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(233)))));
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            this.gridVentas.AllowUserToAddRows = false;
            this.gridVentas.AllowUserToDeleteRows = false;
            this.gridVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.gridVentas.BackgroundColor = System.Drawing.Color.White;
            this.gridVentas.BorderStyle = BorderStyle.None;
            this.gridVentas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            this.gridVentas.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(63)))), ((int)(((byte)(0)))));
            this.gridVentas.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.gridVentas.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridVentas.Location = new System.Drawing.Point(20, 70);
            this.gridVentas.Name = "gridVentas";
            this.gridVentas.RowHeadersVisible = true;
            this.gridVentas.RowHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(227)))), ((int)(((byte)(206)))));
            this.gridVentas.RowHeadersWidth = 80;
            this.gridVentas.Size = new System.Drawing.Size(600, 200);
            this.gridVentas.TabIndex = 0;
            this.gridVentas.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.gridVentas.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(128)))));
            this.gridVentas.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;

            this.gridVentas.Columns.AddRange(
                new DataGridViewColumn[]
                {
                    new DataGridViewTextBoxColumn { HeaderText = "Comidas", Name = "colComidas" },
                    new DataGridViewTextBoxColumn { HeaderText = "Bebidas sin alcohol", Name = "colSinAlcohol" },
                    new DataGridViewTextBoxColumn { HeaderText = "Bebidas con alcohol", Name = "colConAlcohol" },
                    new DataGridViewTextBoxColumn { HeaderText = "Postres", Name = "colPostres" }
                }
            );

            this.gridVentas.Rows.Add(5);
            this.gridVentas.Rows[0].HeaderCell.Value = "Julio";
            this.gridVentas.Rows[1].HeaderCell.Value = "Esteban";
            this.gridVentas.Rows[2].HeaderCell.Value = "Javier";
            this.gridVentas.Rows[3].HeaderCell.Value = "Gonzalo";
            this.gridVentas.Rows[4].HeaderCell.Value = "Alberto";

            this.btnValidar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(142)))), ((int)(((byte)(82)))));
            this.btnValidar.FlatStyle = FlatStyle.Flat;
            this.btnValidar.ForeColor = System.Drawing.Color.White;
            this.btnValidar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnValidar.Location = new System.Drawing.Point(20, 290);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(150, 40);
            this.btnValidar.TabIndex = 1;
            this.btnValidar.Text = "Validar Datos";
            this.btnValidar.UseVisualStyleBackColor = false;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);

            this.btnMozoDia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(89)))), ((int)(((byte)(106)))));
            this.btnMozoDia.FlatStyle = FlatStyle.Flat;
            this.btnMozoDia.ForeColor = System.Drawing.Color.White;
            this.btnMozoDia.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnMozoDia.Location = new System.Drawing.Point(20, 345);
            this.btnMozoDia.Name = "btnMozoDia";
            this.btnMozoDia.Size = new System.Drawing.Size(150, 40);
            this.btnMozoDia.TabIndex = 2;
            this.btnMozoDia.Text = "Mozo del día";
            this.btnMozoDia.UseVisualStyleBackColor = false;
            this.btnMozoDia.Click += new System.EventHandler(this.btnMozoDia_Click);

            this.btnTotales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(98)))), ((int)(((byte)(27)))));
            this.btnTotales.FlatStyle = FlatStyle.Flat;
            this.btnTotales.ForeColor = System.Drawing.Color.White;
            this.btnTotales.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTotales.Location = new System.Drawing.Point(20, 400);
            this.btnTotales.Name = "btnTotales";
            this.btnTotales.Size = new System.Drawing.Size(150, 40);
            this.btnTotales.TabIndex = 3;
            this.btnTotales.Text = "Totales";
            this.btnTotales.UseVisualStyleBackColor = false;
            this.btnTotales.Click += new System.EventHandler(this.btnTotales_Click);

            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnCerrar.FlatStyle = FlatStyle.Flat;
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.Location = new System.Drawing.Point(20, 455);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(150, 40);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);

            this.lblMozoDiaNombre.BackColor = System.Drawing.Color.White;
            this.lblMozoDiaNombre.BorderStyle = BorderStyle.FixedSingle;
            this.lblMozoDiaNombre.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblMozoDiaNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblMozoDiaNombre.Location = new System.Drawing.Point(220, 345);
            this.lblMozoDiaNombre.Name = "lblMozoDiaNombre";
            this.lblMozoDiaNombre.Size = new System.Drawing.Size(220, 28);
            this.lblMozoDiaNombre.TabIndex = 5;
            this.lblMozoDiaNombre.TextAlign = ContentAlignment.MiddleLeft;

            this.lblMozoDiaMonto.BackColor = System.Drawing.Color.White;
            this.lblMozoDiaMonto.BorderStyle = BorderStyle.FixedSingle;
            this.lblMozoDiaMonto.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblMozoDiaMonto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(122)))), ((int)(((byte)(82)))));
            this.lblMozoDiaMonto.Location = new System.Drawing.Point(220, 380);
            this.lblMozoDiaMonto.Name = "lblMozoDiaMonto";
            this.lblMozoDiaMonto.Size = new System.Drawing.Size(220, 28);
            this.lblMozoDiaMonto.TabIndex = 6;
            this.lblMozoDiaMonto.TextAlign = ContentAlignment.MiddleLeft;

            this.lblTotalGeneral.BackColor = System.Drawing.Color.White;
            this.lblTotalGeneral.BorderStyle = BorderStyle.FixedSingle;
            this.lblTotalGeneral.Location = new System.Drawing.Point(220, 420);
            this.lblTotalGeneral.Name = "lblTotalGeneral";
            this.lblTotalGeneral.Size = new System.Drawing.Size(220, 28);
            this.lblTotalGeneral.TabIndex = 7;
            this.lblTotalGeneral.TextAlign = ContentAlignment.MiddleLeft;

            this.lblTotalComidas.BackColor = System.Drawing.Color.White;
            this.lblTotalComidas.BorderStyle = BorderStyle.FixedSingle;
            this.lblTotalComidas.Location = new System.Drawing.Point(220, 455);
            this.lblTotalComidas.Name = "lblTotalComidas";
            this.lblTotalComidas.Size = new System.Drawing.Size(220, 28);
            this.lblTotalComidas.TabIndex = 8;
            this.lblTotalComidas.TextAlign = ContentAlignment.MiddleLeft;

            this.lblTotalSinAlcohol.BackColor = System.Drawing.Color.White;
            this.lblTotalSinAlcohol.BorderStyle = BorderStyle.FixedSingle;
            this.lblTotalSinAlcohol.Location = new System.Drawing.Point(470, 345);
            this.lblTotalSinAlcohol.Name = "lblTotalSinAlcohol";
            this.lblTotalSinAlcohol.Size = new System.Drawing.Size(220, 28);
            this.lblTotalSinAlcohol.TabIndex = 9;
            this.lblTotalSinAlcohol.TextAlign = ContentAlignment.MiddleLeft;

            this.lblTotalConAlcohol.BackColor = System.Drawing.Color.White;
            this.lblTotalConAlcohol.BorderStyle = BorderStyle.FixedSingle;
            this.lblTotalConAlcohol.Location = new System.Drawing.Point(470, 380);
            this.lblTotalConAlcohol.Name = "lblTotalConAlcohol";
            this.lblTotalConAlcohol.Size = new System.Drawing.Size(220, 28);
            this.lblTotalConAlcohol.TabIndex = 10;
            this.lblTotalConAlcohol.TextAlign = ContentAlignment.MiddleLeft;

            this.lblTotalPostres.BackColor = System.Drawing.Color.White;
            this.lblTotalPostres.BorderStyle = BorderStyle.FixedSingle;
            this.lblTotalPostres.Location = new System.Drawing.Point(470, 420);
            this.lblTotalPostres.Name = "lblTotalPostres";
            this.lblTotalPostres.Size = new System.Drawing.Size(220, 28);
            this.lblTotalPostres.TabIndex = 11;
            this.lblTotalPostres.TextAlign = ContentAlignment.MiddleLeft;

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 520);
            this.Controls.Add(this.gridVentas);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.btnMozoDia);
            this.Controls.Add(this.btnTotales);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblMozoDiaNombre);
            this.Controls.Add(this.lblMozoDiaMonto);
            this.Controls.Add(this.lblTotalGeneral);
            this.Controls.Add(this.lblTotalComidas);
            this.Controls.Add(this.lblTotalSinAlcohol);
            this.Controls.Add(this.lblTotalConAlcohol);
            this.Controls.Add(this.lblTotalPostres);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Bar La Milanga";

            ((System.ComponentModel.ISupportInitialize)(this.gridVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
