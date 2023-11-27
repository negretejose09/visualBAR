
namespace Bar
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.editar = new System.Windows.Forms.Button();
            this.eliminar = new System.Windows.Forms.Button();
            this.añadir = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.buscar = new System.Windows.Forms.Button();
            this.textBoxuno = new System.Windows.Forms.TextBox();
            this.textBoxdos = new System.Windows.Forms.TextBox();
            this.textBoxtres = new System.Windows.Forms.TextBox();
            this.textBoxcuatro = new System.Windows.Forms.TextBox();
            this.textBoxcinco = new System.Windows.Forms.TextBox();
            this.textBoxocho = new System.Windows.Forms.TextBox();
            this.textBoxsiete = new System.Windows.Forms.TextBox();
            this.textBoxseis = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.codigoss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioventass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiporefrescoss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recomendadoparaa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoalcoholl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horarioo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoss,
            this.precioventass,
            this.tiporefrescoss,
            this.recomendadoparaa,
            this.nombress,
            this.costoss,
            this.tipoalcoholl,
            this.horarioo});
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView2.Location = new System.Drawing.Point(1, 348);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(656, 237);
            this.dataGridView2.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(565, 293);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 49);
            this.button3.TabIndex = 1;
            this.button3.Text = "volver al \r\n   inicio";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // editar
            // 
            this.editar.BackgroundImage = global::Bar.Properties.Resources.pencil_striped_symbol_for_interface_edit_buttons_icon_icons_com_56782;
            this.editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.editar.Location = new System.Drawing.Point(207, 293);
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(82, 49);
            this.editar.TabIndex = 2;
            this.editar.UseVisualStyleBackColor = true;
            this.editar.Click += new System.EventHandler(this.editar_Click);
            // 
            // eliminar
            // 
            this.eliminar.BackgroundImage = global::Bar.Properties.Resources.trash_bin_icon_icons_com_67981;
            this.eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.eliminar.Location = new System.Drawing.Point(109, 293);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(82, 49);
            this.eliminar.TabIndex = 3;
            this.eliminar.UseVisualStyleBackColor = true;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // añadir
            // 
            this.añadir.BackgroundImage = global::Bar.Properties.Resources.agregar_bar;
            this.añadir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.añadir.Location = new System.Drawing.Point(12, 293);
            this.añadir.Name = "añadir";
            this.añadir.Size = new System.Drawing.Size(82, 49);
            this.añadir.TabIndex = 4;
            this.añadir.UseVisualStyleBackColor = true;
            this.añadir.Click += new System.EventHandler(this.añadir_Click);
            // 
            // button7
            // 
            this.button7.BackgroundImage = global::Bar.Properties.Resources.exit_bar;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.Location = new System.Drawing.Point(458, 293);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(82, 49);
            this.button7.TabIndex = 5;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // buscar
            // 
            this.buscar.BackgroundImage = global::Bar.Properties.Resources.search_look_for_seek_magnifying_glass_lens_icon_1419671;
            this.buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buscar.Location = new System.Drawing.Point(310, 293);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(82, 49);
            this.buscar.TabIndex = 6;
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // textBoxuno
            // 
            this.textBoxuno.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxuno.Location = new System.Drawing.Point(148, 72);
            this.textBoxuno.Name = "textBoxuno";
            this.textBoxuno.Size = new System.Drawing.Size(187, 30);
            this.textBoxuno.TabIndex = 7;
            // 
            // textBoxdos
            // 
            this.textBoxdos.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxdos.Location = new System.Drawing.Point(148, 113);
            this.textBoxdos.Name = "textBoxdos";
            this.textBoxdos.Size = new System.Drawing.Size(185, 30);
            this.textBoxdos.TabIndex = 8;
            this.textBoxdos.TextChanged += new System.EventHandler(this.textBoxdos_TextChanged);
            // 
            // textBoxtres
            // 
            this.textBoxtres.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxtres.Location = new System.Drawing.Point(148, 154);
            this.textBoxtres.Name = "textBoxtres";
            this.textBoxtres.Size = new System.Drawing.Size(185, 30);
            this.textBoxtres.TabIndex = 9;
            this.textBoxtres.TextChanged += new System.EventHandler(this.textBoxtres_TextChanged);
            // 
            // textBoxcuatro
            // 
            this.textBoxcuatro.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxcuatro.Location = new System.Drawing.Point(148, 199);
            this.textBoxcuatro.Name = "textBoxcuatro";
            this.textBoxcuatro.Size = new System.Drawing.Size(185, 30);
            this.textBoxcuatro.TabIndex = 10;
            this.textBoxcuatro.TextChanged += new System.EventHandler(this.textBoxcuatro_TextChanged);
            // 
            // textBoxcinco
            // 
            this.textBoxcinco.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxcinco.Location = new System.Drawing.Point(472, 72);
            this.textBoxcinco.Name = "textBoxcinco";
            this.textBoxcinco.Size = new System.Drawing.Size(185, 30);
            this.textBoxcinco.TabIndex = 11;
            // 
            // textBoxocho
            // 
            this.textBoxocho.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxocho.Location = new System.Drawing.Point(472, 199);
            this.textBoxocho.Name = "textBoxocho";
            this.textBoxocho.Size = new System.Drawing.Size(185, 30);
            this.textBoxocho.TabIndex = 12;
            this.textBoxocho.TextChanged += new System.EventHandler(this.textBoxocho_TextChanged);
            // 
            // textBoxsiete
            // 
            this.textBoxsiete.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxsiete.Location = new System.Drawing.Point(472, 154);
            this.textBoxsiete.Name = "textBoxsiete";
            this.textBoxsiete.Size = new System.Drawing.Size(185, 30);
            this.textBoxsiete.TabIndex = 13;
            this.textBoxsiete.TextChanged += new System.EventHandler(this.textBoxsiete_TextChanged);
            // 
            // textBoxseis
            // 
            this.textBoxseis.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxseis.Location = new System.Drawing.Point(472, 113);
            this.textBoxseis.Name = "textBoxseis";
            this.textBoxseis.Size = new System.Drawing.Size(185, 30);
            this.textBoxseis.TabIndex = 14;
            this.textBoxseis.TextChanged += new System.EventHandler(this.textBoxseis_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "Codigo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 23);
            this.label4.TabIndex = 16;
            this.label4.Text = "Precio Venta:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(-3, 157);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(149, 23);
            this.label12.TabIndex = 17;
            this.label12.Text = "Tipo Refresco:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1, 191);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(145, 46);
            this.label13.TabIndex = 18;
            this.label13.Text = "Recomendado\r\n        Para:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(376, 77);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 23);
            this.label14.TabIndex = 19;
            this.label14.Text = "Nombre:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(399, 116);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 23);
            this.label15.TabIndex = 20;
            this.label15.Text = "Costo:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(335, 157);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(135, 23);
            this.label16.TabIndex = 21;
            this.label16.Text = "Tipo alcohol:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(388, 203);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(82, 23);
            this.label17.TabIndex = 22;
            this.label17.Text = "Horario";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Broadway", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label18.Location = new System.Drawing.Point(270, 18);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(170, 36);
            this.label18.TabIndex = 23;
            this.label18.Text = "BEBIDAS";
            // 
            // codigoss
            // 
            this.codigoss.HeaderText = "codigoss";
            this.codigoss.Name = "codigoss";
            // 
            // precioventass
            // 
            this.precioventass.HeaderText = "precioventass";
            this.precioventass.Name = "precioventass";
            // 
            // tiporefrescoss
            // 
            this.tiporefrescoss.HeaderText = "tiporefrescoss";
            this.tiporefrescoss.Name = "tiporefrescoss";
            // 
            // recomendadoparaa
            // 
            this.recomendadoparaa.HeaderText = "recomendadoparaa";
            this.recomendadoparaa.Name = "recomendadoparaa";
            // 
            // nombress
            // 
            this.nombress.HeaderText = "nombress";
            this.nombress.Name = "nombress";
            // 
            // costoss
            // 
            this.costoss.HeaderText = "costoss";
            this.costoss.Name = "costoss";
            // 
            // tipoalcoholl
            // 
            this.tipoalcoholl.HeaderText = "tipoalcoholl";
            this.tipoalcoholl.Name = "tipoalcoholl";
            // 
            // horarioo
            // 
            this.horarioo.HeaderText = "horarioo";
            this.horarioo.Name = "horarioo";
            // 
            // Form4
            // 
            this.BackgroundImage = global::Bar.Properties.Resources.forma_4_bar;
            this.ClientSize = new System.Drawing.Size(659, 585);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxseis);
            this.Controls.Add(this.textBoxsiete);
            this.Controls.Add(this.textBoxocho);
            this.Controls.Add(this.textBoxcinco);
            this.Controls.Add(this.textBoxcuatro);
            this.Controls.Add(this.textBoxtres);
            this.Controls.Add(this.textBoxdos);
            this.Controls.Add(this.textBoxuno);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.añadir);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.editar);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView2);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(675, 624);
            this.MinimumSize = new System.Drawing.Size(675, 624);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textbox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioventa;
        private System.Windows.Forms.DataGridViewTextBoxColumn costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiporefresco;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoalcohol;
        private System.Windows.Forms.DataGridViewTextBoxColumn recomendadopara;
        private System.Windows.Forms.DataGridViewTextBoxColumn horario;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox nombres;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button editar;
        private System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.Button añadir;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.TextBox textBoxuno;
        private System.Windows.Forms.TextBox textBoxdos;
        private System.Windows.Forms.TextBox textBoxtres;
        private System.Windows.Forms.TextBox textBoxcuatro;
        private System.Windows.Forms.TextBox textBoxcinco;
        private System.Windows.Forms.TextBox textBoxocho;
        private System.Windows.Forms.TextBox textBoxsiete;
        private System.Windows.Forms.TextBox textBoxseis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoss;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioventass;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiporefrescoss;
        private System.Windows.Forms.DataGridViewTextBoxColumn recomendadoparaa;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombress;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoss;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoalcoholl;
        private System.Windows.Forms.DataGridViewTextBoxColumn horarioo;
    }
}