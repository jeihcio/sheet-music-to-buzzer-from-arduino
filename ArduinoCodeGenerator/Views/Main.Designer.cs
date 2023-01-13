namespace ArduinoCodeGenerator
{
    partial class Main
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRemoveLastFigure = new System.Windows.Forms.Button();
            this.btnAddPause = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbFigurePause = new System.Windows.Forms.ComboBox();
            this.btnAddNote = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbFigure = new System.Windows.Forms.ComboBox();
            this.numberScale = new System.Windows.Forms.NumericUpDown();
            this.cmbNote = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblBPM = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlPentagram = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numberBPM = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGenerateCodeArduino = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberScale)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberBPM)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRemoveLastFigure);
            this.groupBox1.Controls.Add(this.btnAddPause);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbFigurePause);
            this.groupBox1.Controls.Add(this.btnAddNote);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbFigure);
            this.groupBox1.Controls.Add(this.numberScale);
            this.groupBox1.Controls.Add(this.cmbNote);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(5, 288);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(300);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(631, 71);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Write Score ";
            // 
            // btnRemoveLastFigure
            // 
            this.btnRemoveLastFigure.Location = new System.Drawing.Point(515, 39);
            this.btnRemoveLastFigure.Name = "btnRemoveLastFigure";
            this.btnRemoveLastFigure.Size = new System.Drawing.Size(110, 23);
            this.btnRemoveLastFigure.TabIndex = 6;
            this.btnRemoveLastFigure.Text = "Remove last picture";
            this.btnRemoveLastFigure.UseVisualStyleBackColor = true;
            this.btnRemoveLastFigure.Click += new System.EventHandler(this.btnRemoveLastFigure_Click);
            // 
            // btnAddPause
            // 
            this.btnAddPause.Location = new System.Drawing.Point(485, 39);
            this.btnAddPause.Name = "btnAddPause";
            this.btnAddPause.Size = new System.Drawing.Size(27, 23);
            this.btnAddPause.TabIndex = 5;
            this.btnAddPause.Text = "+";
            this.btnAddPause.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(319, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Pause";
            // 
            // cmbFigurePause
            // 
            this.cmbFigurePause.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFigurePause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFigurePause.FormattingEnabled = true;
            this.cmbFigurePause.Items.AddRange(new object[] {
            "Semibreve",
            "Minimum",
            "Quarter Note",
            "Eighth Note",
            "Sixteenth Note",
            "Fusa",
            "Semifusa"});
            this.cmbFigurePause.Location = new System.Drawing.Point(323, 41);
            this.cmbFigurePause.Name = "cmbFigurePause";
            this.cmbFigurePause.Size = new System.Drawing.Size(160, 21);
            this.cmbFigurePause.TabIndex = 4;
            // 
            // btnAddNote
            // 
            this.btnAddNote.Location = new System.Drawing.Point(293, 39);
            this.btnAddNote.Name = "btnAddNote";
            this.btnAddNote.Size = new System.Drawing.Size(27, 23);
            this.btnAddNote.TabIndex = 3;
            this.btnAddNote.Text = "+";
            this.btnAddNote.UseVisualStyleBackColor = true;
            this.btnAddNote.Click += new System.EventHandler(this.btnAddNote_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Figure";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Scale";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Note";
            // 
            // cmbFigure
            // 
            this.cmbFigure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFigure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFigure.FormattingEnabled = true;
            this.cmbFigure.Items.AddRange(new object[] {
            "Semibreve",
            "Minimum",
            "Quarter Note",
            "Eighth Note",
            "Sixteenth Note",
            "Fusa",
            "Semifusa"});
            this.cmbFigure.Location = new System.Drawing.Point(131, 41);
            this.cmbFigure.Name = "cmbFigure";
            this.cmbFigure.Size = new System.Drawing.Size(160, 21);
            this.cmbFigure.TabIndex = 2;
            // 
            // numberScale
            // 
            this.numberScale.Location = new System.Drawing.Point(79, 42);
            this.numberScale.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numberScale.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numberScale.Name = "numberScale";
            this.numberScale.Size = new System.Drawing.Size(48, 20);
            this.numberScale.TabIndex = 1;
            this.numberScale.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // cmbNote
            // 
            this.cmbNote.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbNote.FormattingEnabled = true;
            this.cmbNote.Items.AddRange(new object[] {
            "Dó",
            "Dó#",
            "Ré",
            "Ré#",
            "Mi",
            "Fá",
            "Fá#",
            "Sol",
            "Sol #",
            "Lá",
            "Lá #",
            "Si"});
            this.cmbNote.Location = new System.Drawing.Point(7, 41);
            this.cmbNote.Name = "cmbNote";
            this.cmbNote.Size = new System.Drawing.Size(68, 21);
            this.cmbNote.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 250);
            this.panel1.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Controls.Add(this.lblBPM);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.pnlPentagram);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(52, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(748, 250);
            this.panel3.TabIndex = 4;
            // 
            // lblBPM
            // 
            this.lblBPM.AutoSize = true;
            this.lblBPM.Location = new System.Drawing.Point(27, 51);
            this.lblBPM.Name = "lblBPM";
            this.lblBPM.Size = new System.Drawing.Size(19, 13);
            this.lblBPM.TabIndex = 6;
            this.lblBPM.Text = "60";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(0, 34);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 35);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pnlPentagram
            // 
            this.pnlPentagram.AutoScroll = true;
            this.pnlPentagram.BackColor = System.Drawing.Color.Transparent;
            this.pnlPentagram.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlPentagram.Location = new System.Drawing.Point(0, 0);
            this.pnlPentagram.Name = "pnlPentagram";
            this.pnlPentagram.Size = new System.Drawing.Size(50, 250);
            this.pnlPentagram.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "BPM:";
            // 
            // numberBPM
            // 
            this.numberBPM.Location = new System.Drawing.Point(51, 261);
            this.numberBPM.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numberBPM.Name = "numberBPM";
            this.numberBPM.Size = new System.Drawing.Size(43, 20);
            this.numberBPM.TabIndex = 0;
            this.numberBPM.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numberBPM.ValueChanged += new System.EventHandler(this.numberBPM_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGenerateCodeArduino);
            this.groupBox2.Location = new System.Drawing.Point(640, 288);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(156, 71);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " Generate ";
            // 
            // btnGenerateCodeArduino
            // 
            this.btnGenerateCodeArduino.Location = new System.Drawing.Point(6, 39);
            this.btnGenerateCodeArduino.Name = "btnGenerateCodeArduino";
            this.btnGenerateCodeArduino.Size = new System.Drawing.Size(144, 23);
            this.btnGenerateCodeArduino.TabIndex = 1;
            this.btnGenerateCodeArduino.Text = "Generate code for Arduino";
            this.btnGenerateCodeArduino.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 362);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.numberBPM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generate code for Arduino";
            this.Shown += new System.EventHandler(this.Main_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberScale)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberBPM)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numberBPM;
        private System.Windows.Forms.ComboBox cmbNote;
        private System.Windows.Forms.ComboBox cmbFigure;
        private System.Windows.Forms.NumericUpDown numberScale;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddPause;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbFigurePause;
        private System.Windows.Forms.Button btnAddNote;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRemoveLastFigure;
        private System.Windows.Forms.Button btnGenerateCodeArduino;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblBPM;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel pnlPentagram;
    }
}

