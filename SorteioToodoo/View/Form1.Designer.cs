namespace SorteioToodoo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sorteadoBox = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnSortear = new System.Windows.Forms.Button();
            this.btnSorteados = new System.Windows.Forms.Button();
            this.btnParticipantes = new System.Windows.Forms.Button();
            this.listSorteio = new System.Windows.Forms.ListBox();
            this.painelFogosEsquerdo = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.painelFogosdireito = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.painelFogosEsquerdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel2.SuspendLayout();
            this.painelFogosdireito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 618F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1630, 763);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.Controls.Add(this.sorteadoBox);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btnSortear);
            this.panel1.Controls.Add(this.btnSorteados);
            this.panel1.Controls.Add(this.btnParticipantes);
            this.panel1.Controls.Add(this.listSorteio);
            this.panel1.Location = new System.Drawing.Point(764, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(631, 840);
            this.panel1.TabIndex = 8;
            // 
            // sorteadoBox
            // 
            this.sorteadoBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sorteadoBox.BackColor = System.Drawing.Color.Black;
            this.sorteadoBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sorteadoBox.Enabled = false;
            this.sorteadoBox.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sorteadoBox.ForeColor = System.Drawing.SystemColors.Menu;
            this.sorteadoBox.Location = new System.Drawing.Point(-123, 373);
            this.sorteadoBox.Name = "sorteadoBox";
            this.sorteadoBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sorteadoBox.Size = new System.Drawing.Size(958, 45);
            this.sorteadoBox.TabIndex = 3;
            this.sorteadoBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sorteadoBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(35, -5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(596, 172);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // btnSortear
            // 
            this.btnSortear.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSortear.Location = new System.Drawing.Point(432, 770);
            this.btnSortear.Name = "btnSortear";
            this.btnSortear.Size = new System.Drawing.Size(183, 42);
            this.btnSortear.TabIndex = 2;
            this.btnSortear.Text = "Sortear";
            this.btnSortear.UseVisualStyleBackColor = true;
            this.btnSortear.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSorteados
            // 
            this.btnSorteados.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSorteados.Location = new System.Drawing.Point(222, 770);
            this.btnSorteados.Name = "btnSorteados";
            this.btnSorteados.Size = new System.Drawing.Size(183, 42);
            this.btnSorteados.TabIndex = 0;
            this.btnSorteados.Text = "Sorteados";
            this.btnSorteados.UseVisualStyleBackColor = true;
            this.btnSorteados.Click += new System.EventHandler(this.btnSorteados_Click);
            // 
            // btnParticipantes
            // 
            this.btnParticipantes.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnParticipantes.Location = new System.Drawing.Point(11, 770);
            this.btnParticipantes.Name = "btnParticipantes";
            this.btnParticipantes.Size = new System.Drawing.Size(183, 42);
            this.btnParticipantes.TabIndex = 1;
            this.btnParticipantes.Text = "Participantes";
            this.btnParticipantes.UseVisualStyleBackColor = true;
            this.btnParticipantes.Click += new System.EventHandler(this.btnSortear_Click);
            // 
            // listSorteio
            // 
            this.listSorteio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.listSorteio.BackColor = System.Drawing.SystemColors.MenuText;
            this.listSorteio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listSorteio.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listSorteio.ForeColor = System.Drawing.SystemColors.Menu;
            this.listSorteio.FormattingEnabled = true;
            this.listSorteio.ItemHeight = 28;
            this.listSorteio.Location = new System.Drawing.Point(0, 177);
            this.listSorteio.Name = "listSorteio";
            this.listSorteio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listSorteio.Size = new System.Drawing.Size(631, 532);
            this.listSorteio.TabIndex = 4;
            this.listSorteio.SelectedIndexChanged += new System.EventHandler(this.listSorteio_SelectedIndexChanged);
            // 
            // painelFogosEsquerdo
            // 
            this.painelFogosEsquerdo.Controls.Add(this.pictureBox4);
            this.painelFogosEsquerdo.Location = new System.Drawing.Point(3, 0);
            this.painelFogosEsquerdo.Name = "painelFogosEsquerdo";
            this.painelFogosEsquerdo.Size = new System.Drawing.Size(612, 851);
            this.painelFogosEsquerdo.TabIndex = 10;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(67, 210);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(462, 463);
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.painelFogosdireito);
            this.panel2.Controls.Add(this.painelFogosEsquerdo);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel2.Size = new System.Drawing.Size(2232, 852);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // painelFogosdireito
            // 
            this.painelFogosdireito.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.painelFogosdireito.Controls.Add(this.pictureBox1);
            this.painelFogosdireito.Location = new System.Drawing.Point(1620, 0);
            this.painelFogosdireito.Name = "painelFogosdireito";
            this.painelFogosdireito.Size = new System.Drawing.Size(612, 851);
            this.painelFogosdireito.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(71, 210);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(472, 463);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(2232, 852);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.painelFogosEsquerdo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel2.ResumeLayout(false);
            this.painelFogosdireito.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private TextBox sorteadoBox;
        private PictureBox pictureBox2;
        private Button btnSortear;
        private Button btnSorteados;
        private Button btnParticipantes;
        private ListBox listSorteio;
        private Panel painelFogosEsquerdo;
        private PictureBox pictureBox4;
        private Panel panel2;
        private Panel painelFogosdireito;
        private PictureBox pictureBox1;
    }
}