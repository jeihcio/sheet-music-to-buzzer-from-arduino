﻿namespace ArduinoCodeGenerator
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbFigurePause = new System.Windows.Forms.ListBox();
            this.cmbFigure = new System.Windows.Forms.ListBox();
            this.cmbNote = new System.Windows.Forms.ListBox();
            this.btnRemoveLastFigure = new System.Windows.Forms.Button();
            this.btnAddPause = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddNote = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numberScale = new System.Windows.Forms.NumericUpDown();
            this.MenuPentagram = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.saveImageAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.numberBPM = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGenerateCodeArduino = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlSheetMusic = new System.Windows.Forms.Panel();
            this.lblBPM = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlPentagram = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberScale)).BeginInit();
            this.MenuPentagram.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberBPM)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlSheetMusic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbFigurePause);
            this.groupBox1.Controls.Add(this.cmbFigure);
            this.groupBox1.Controls.Add(this.cmbNote);
            this.groupBox1.Controls.Add(this.btnRemoveLastFigure);
            this.groupBox1.Controls.Add(this.btnAddPause);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnAddNote);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numberScale);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(5, 311);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(300);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(631, 144);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Write Score ";
            // 
            // cmbFigurePause
            // 
            this.cmbFigurePause.FormattingEnabled = true;
            this.cmbFigurePause.Items.AddRange(new object[] {
            "Semibreve",
            "Minimum",
            "Quarter Note",
            "Eighth Note",
            "Sixteenth Note"});
            this.cmbFigurePause.Location = new System.Drawing.Point(325, 42);
            this.cmbFigurePause.Name = "cmbFigurePause";
            this.cmbFigurePause.Size = new System.Drawing.Size(160, 95);
            this.cmbFigurePause.TabIndex = 11;
            // 
            // cmbFigure
            // 
            this.cmbFigure.FormattingEnabled = true;
            this.cmbFigure.Items.AddRange(new object[] {
            "Semibreve",
            "Minimum",
            "Quarter Note",
            "Eighth Note",
            "Sixteenth Note"});
            this.cmbFigure.Location = new System.Drawing.Point(78, 42);
            this.cmbFigure.Name = "cmbFigure";
            this.cmbFigure.Size = new System.Drawing.Size(160, 95);
            this.cmbFigure.TabIndex = 10;
            // 
            // cmbNote
            // 
            this.cmbNote.FormattingEnabled = true;
            this.cmbNote.Items.AddRange(new object[] {
            "C",
            "D",
            "E",
            "F",
            "G",
            "A",
            "B"});
            this.cmbNote.Location = new System.Drawing.Point(7, 42);
            this.cmbNote.Name = "cmbNote";
            this.cmbNote.Size = new System.Drawing.Size(68, 95);
            this.cmbNote.TabIndex = 9;
            // 
            // btnRemoveLastFigure
            // 
            this.btnRemoveLastFigure.Location = new System.Drawing.Point(517, 41);
            this.btnRemoveLastFigure.Name = "btnRemoveLastFigure";
            this.btnRemoveLastFigure.Size = new System.Drawing.Size(110, 23);
            this.btnRemoveLastFigure.TabIndex = 6;
            this.btnRemoveLastFigure.Text = "Remove last picture";
            this.btnRemoveLastFigure.UseVisualStyleBackColor = true;
            this.btnRemoveLastFigure.Click += new System.EventHandler(this.btnRemoveLastFigure_Click);
            // 
            // btnAddPause
            // 
            this.btnAddPause.Location = new System.Drawing.Point(488, 41);
            this.btnAddPause.Name = "btnAddPause";
            this.btnAddPause.Size = new System.Drawing.Size(27, 23);
            this.btnAddPause.TabIndex = 5;
            this.btnAddPause.Text = "+";
            this.btnAddPause.UseVisualStyleBackColor = true;
            this.btnAddPause.Click += new System.EventHandler(this.btnAddPause_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(322, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Pause";
            // 
            // btnAddNote
            // 
            this.btnAddNote.Location = new System.Drawing.Point(293, 41);
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
            this.label4.Location = new System.Drawing.Point(75, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Figure";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Scale";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Note";
            // 
            // numberScale
            // 
            this.numberScale.Location = new System.Drawing.Point(241, 42);
            this.numberScale.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numberScale.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numberScale.Name = "numberScale";
            this.numberScale.Size = new System.Drawing.Size(49, 20);
            this.numberScale.TabIndex = 1;
            this.numberScale.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // MenuPentagram
            // 
            this.MenuPentagram.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveImageAsToolStripMenuItem});
            this.MenuPentagram.Name = "MenuPentagram";
            this.MenuPentagram.Size = new System.Drawing.Size(163, 26);
            // 
            // saveImageAsToolStripMenuItem
            // 
            this.saveImageAsToolStripMenuItem.Name = "saveImageAsToolStripMenuItem";
            this.saveImageAsToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.saveImageAsToolStripMenuItem.Text = "Save Image As....";
            this.saveImageAsToolStripMenuItem.Click += new System.EventHandler(this.saveImageAsToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "BPM:";
            // 
            // numberBPM
            // 
            this.numberBPM.Location = new System.Drawing.Point(51, 284);
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
            this.groupBox2.Location = new System.Drawing.Point(640, 311);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(156, 144);
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
            this.btnGenerateCodeArduino.Click += new System.EventHandler(this.btnGenerateCodeArduino_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuMain";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.importToolStripMenuItem.Text = "Import";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.pnlSheetMusic);
            this.pnlMain.Controls.Add(this.pictureBox1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMain.Location = new System.Drawing.Point(0, 24);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(800, 250);
            this.pnlMain.TabIndex = 6;
            // 
            // pnlSheetMusic
            // 
            this.pnlSheetMusic.AutoScroll = true;
            this.pnlSheetMusic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlSheetMusic.BackgroundImage")));
            this.pnlSheetMusic.ContextMenuStrip = this.MenuPentagram;
            this.pnlSheetMusic.Controls.Add(this.lblBPM);
            this.pnlSheetMusic.Controls.Add(this.pictureBox2);
            this.pnlSheetMusic.Controls.Add(this.pnlPentagram);
            this.pnlSheetMusic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSheetMusic.Location = new System.Drawing.Point(52, 0);
            this.pnlSheetMusic.Name = "pnlSheetMusic";
            this.pnlSheetMusic.Size = new System.Drawing.Size(748, 250);
            this.pnlSheetMusic.TabIndex = 4;
            // 
            // lblBPM
            // 
            this.lblBPM.AutoSize = true;
            this.lblBPM.ContextMenuStrip = this.MenuPentagram;
            this.lblBPM.Location = new System.Drawing.Point(31, 63);
            this.lblBPM.Name = "lblBPM";
            this.lblBPM.Size = new System.Drawing.Size(19, 13);
            this.lblBPM.TabIndex = 10;
            this.lblBPM.Text = "60";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.ContextMenuStrip = this.MenuPentagram;
            this.pictureBox2.Location = new System.Drawing.Point(0, 45);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 35);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pnlPentagram
            // 
            this.pnlPentagram.AutoScroll = true;
            this.pnlPentagram.BackColor = System.Drawing.Color.Transparent;
            this.pnlPentagram.ContextMenuStrip = this.MenuPentagram;
            this.pnlPentagram.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlPentagram.Location = new System.Drawing.Point(0, 0);
            this.pnlPentagram.Name = "pnlPentagram";
            this.pnlPentagram.Size = new System.Drawing.Size(55, 250);
            this.pnlPentagram.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ContextMenuStrip = this.MenuPentagram;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 459);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.numberBPM);
            this.Controls.Add(this.label1);
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
            this.MenuPentagram.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numberBPM)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlSheetMusic.ResumeLayout(false);
            this.pnlSheetMusic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numberBPM;
        private System.Windows.Forms.NumericUpDown numberScale;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddPause;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddNote;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRemoveLastFigure;
        private System.Windows.Forms.Button btnGenerateCodeArduino;
        private System.Windows.Forms.ContextMenuStrip MenuPentagram;
        private System.Windows.Forms.ToolStripMenuItem saveImageAsToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlSheetMusic;
        private System.Windows.Forms.Label lblBPM;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel pnlPentagram;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ListBox cmbFigure;
        private System.Windows.Forms.ListBox cmbNote;
        private System.Windows.Forms.ListBox cmbFigurePause;
    }
}

