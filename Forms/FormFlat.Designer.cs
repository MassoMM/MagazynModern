namespace Modern_Magazyn.Forms
{
    partial class FormFlat
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button3 = new System.Windows.Forms.Button();
            this.txtbelka = new System.Windows.Forms.TextBox();
            this.flattblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mydbDataSet = new Modern_Magazyn.mydbDataSet();
            this.txtkanina = new System.Windows.Forms.TextBox();
            this.txtkolekcja = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kolekcjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tkaninaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.belkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odpadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lenghtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uwagi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.QR = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtodpad = new System.Windows.Forms.TextBox();
            this.txtrozmiar = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.flattblTableAdapter = new Modern_Magazyn.mydbDataSetTableAdapters.flattblTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.txtuwagi = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSearch2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.qrboxim = new System.Windows.Forms.PictureBox();
            this.qrbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.flattblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qrboxim)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(404, 498);
            this.button3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 35);
            this.button3.TabIndex = 5;
            this.button3.Text = "Nowy";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtbelka
            // 
            this.txtbelka.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.flattblBindingSource, "belka", true));
            this.txtbelka.Location = new System.Drawing.Point(431, 47);
            this.txtbelka.Name = "txtbelka";
            this.txtbelka.Size = new System.Drawing.Size(100, 20);
            this.txtbelka.TabIndex = 2;
            // 
            // flattblBindingSource
            // 
            this.flattblBindingSource.DataMember = "flattbl";
            this.flattblBindingSource.DataSource = this.mydbDataSet;
            // 
            // mydbDataSet
            // 
            this.mydbDataSet.DataSetName = "mydbDataSet";
            this.mydbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtkanina
            // 
            this.txtkanina.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.flattblBindingSource, "tkanina", true));
            this.txtkanina.Location = new System.Drawing.Point(155, 79);
            this.txtkanina.Name = "txtkanina";
            this.txtkanina.Size = new System.Drawing.Size(100, 20);
            this.txtkanina.TabIndex = 1;
            // 
            // txtkolekcja
            // 
            this.txtkolekcja.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.flattblBindingSource, "kolekcja", true));
            this.txtkolekcja.Location = new System.Drawing.Point(155, 50);
            this.txtkolekcja.Name = "txtkolekcja";
            this.txtkolekcja.Size = new System.Drawing.Size(100, 20);
            this.txtkolekcja.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kolekcja";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tkanina";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(328, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Belka ( Rozmiar )";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(61, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tkaniny Gładkie";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kolekcjaDataGridViewTextBoxColumn,
            this.tkaninaDataGridViewTextBoxColumn,
            this.belkaDataGridViewTextBoxColumn,
            this.odpadDataGridViewTextBoxColumn,
            this.lenghtDataGridViewTextBoxColumn,
            this.Uwagi,
            this.delete,
            this.QR});
            this.dataGridView1.DataSource = this.flattblBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(12, 164);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Size = new System.Drawing.Size(824, 317);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridView1_KeyPress);
            // 
            // kolekcjaDataGridViewTextBoxColumn
            // 
            this.kolekcjaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kolekcjaDataGridViewTextBoxColumn.DataPropertyName = "kolekcja";
            this.kolekcjaDataGridViewTextBoxColumn.HeaderText = "Kolekcja";
            this.kolekcjaDataGridViewTextBoxColumn.Name = "kolekcjaDataGridViewTextBoxColumn";
            // 
            // tkaninaDataGridViewTextBoxColumn
            // 
            this.tkaninaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tkaninaDataGridViewTextBoxColumn.DataPropertyName = "tkanina";
            this.tkaninaDataGridViewTextBoxColumn.HeaderText = "Tkanina";
            this.tkaninaDataGridViewTextBoxColumn.Name = "tkaninaDataGridViewTextBoxColumn";
            // 
            // belkaDataGridViewTextBoxColumn
            // 
            this.belkaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.belkaDataGridViewTextBoxColumn.DataPropertyName = "belka";
            this.belkaDataGridViewTextBoxColumn.HeaderText = "Belka ";
            this.belkaDataGridViewTextBoxColumn.Name = "belkaDataGridViewTextBoxColumn";
            // 
            // odpadDataGridViewTextBoxColumn
            // 
            this.odpadDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.odpadDataGridViewTextBoxColumn.DataPropertyName = "odpad";
            this.odpadDataGridViewTextBoxColumn.HeaderText = "Odpad (T/N)";
            this.odpadDataGridViewTextBoxColumn.Name = "odpadDataGridViewTextBoxColumn";
            // 
            // lenghtDataGridViewTextBoxColumn
            // 
            this.lenghtDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lenghtDataGridViewTextBoxColumn.DataPropertyName = "lenght";
            this.lenghtDataGridViewTextBoxColumn.HeaderText = "Rozmiar";
            this.lenghtDataGridViewTextBoxColumn.Name = "lenghtDataGridViewTextBoxColumn";
            // 
            // Uwagi
            // 
            this.Uwagi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Uwagi.DataPropertyName = "Uwagi";
            this.Uwagi.HeaderText = "Uwagi";
            this.Uwagi.Name = "Uwagi";
            // 
            // delete
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.delete.DefaultCellStyle = dataGridViewCellStyle2;
            this.delete.HeaderText = "Usuń";
            this.delete.Name = "delete";
            this.delete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.delete.Text = "Usuń";
            this.delete.UseColumnTextForButtonValue = true;
            // 
            // QR
            // 
            this.QR.DataPropertyName = "Id";
            this.QR.HeaderText = "QRCode";
            this.QR.Name = "QR";
            this.QR.ReadOnly = true;
            this.QR.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.QR.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.QR.Text = "Generate QR";
            this.QR.UseColumnTextForButtonValue = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(624, 498);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "Usuń";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(514, 498);
            this.button2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 35);
            this.button2.TabIndex = 6;
            this.button2.Text = "Edytuj";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(608, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Odpad (T/N)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(608, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Rozmiar";
            // 
            // txtodpad
            // 
            this.txtodpad.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.flattblBindingSource, "odpad", true));
            this.txtodpad.Location = new System.Drawing.Point(701, 47);
            this.txtodpad.Name = "txtodpad";
            this.txtodpad.Size = new System.Drawing.Size(100, 20);
            this.txtodpad.TabIndex = 3;
            // 
            // txtrozmiar
            // 
            this.txtrozmiar.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.flattblBindingSource, "lenght", true));
            this.txtrozmiar.Location = new System.Drawing.Point(701, 77);
            this.txtrozmiar.Name = "txtrozmiar";
            this.txtrozmiar.Size = new System.Drawing.Size(100, 20);
            this.txtrozmiar.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(734, 498);
            this.button4.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 35);
            this.button4.TabIndex = 8;
            this.button4.Text = "Zapisz";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // flattblTableAdapter
            // 
            this.flattblTableAdapter.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(328, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Uwagi";
            // 
            // txtuwagi
            // 
            this.txtuwagi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.flattblBindingSource, "Uwagi", true));
            this.txtuwagi.Location = new System.Drawing.Point(431, 77);
            this.txtuwagi.Name = "txtuwagi";
            this.txtuwagi.Size = new System.Drawing.Size(100, 20);
            this.txtuwagi.TabIndex = 20;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSearch.Location = new System.Drawing.Point(175, 487);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(221, 26);
            this.txtSearch.TabIndex = 22;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(72, 495);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Wyszukaj Kolekcje";
            // 
            // txtSearch2
            // 
            this.txtSearch2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSearch2.Location = new System.Drawing.Point(175, 520);
            this.txtSearch2.Name = "txtSearch2";
            this.txtSearch2.Size = new System.Drawing.Size(221, 26);
            this.txtSearch2.TabIndex = 24;
            this.txtSearch2.TextChanged += new System.EventHandler(this.txtSearch2_TextChanged);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(72, 528);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Wyszukaj Tkanine";
            // 
            // qrboxim
            // 
            this.qrboxim.Location = new System.Drawing.Point(4, 498);
            this.qrboxim.Name = "qrboxim";
            this.qrboxim.Size = new System.Drawing.Size(62, 48);
            this.qrboxim.TabIndex = 46;
            this.qrboxim.TabStop = false;
            // 
            // qrbox
            // 
            this.qrbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.qrbox.Location = new System.Drawing.Point(59, 105);
            this.qrbox.Name = "qrbox";
            this.qrbox.ReadOnly = true;
            this.qrbox.Size = new System.Drawing.Size(742, 20);
            this.qrbox.TabIndex = 47;
            // 
            // FormFlat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(848, 558);
            this.Controls.Add(this.qrbox);
            this.Controls.Add(this.qrboxim);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSearch2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtuwagi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtrozmiar);
            this.Controls.Add(this.txtodpad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtkolekcja);
            this.Controls.Add(this.txtkanina);
            this.Controls.Add(this.txtbelka);
            this.Controls.Add(this.button3);
            this.Name = "FormFlat";
            this.Text = "Tkaniny Gładkie";
            this.Load += new System.EventHandler(this.FormProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.flattblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qrboxim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtbelka;
        private System.Windows.Forms.TextBox txtkanina;
        private System.Windows.Forms.TextBox txtkolekcja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private mydbDataSet mydbDataSet;
        private System.Windows.Forms.BindingSource flattblBindingSource;
        private mydbDataSetTableAdapters.flattblTableAdapter flattblTableAdapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtodpad;
        private System.Windows.Forms.TextBox txtrozmiar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtuwagi;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSearch2;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.PictureBox qrboxim;
        public System.Windows.Forms.TextBox qrbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolekcjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tkaninaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn belkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odpadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lenghtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uwagi;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
        private System.Windows.Forms.DataGridViewButtonColumn QR;
    }
}