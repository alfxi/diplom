namespace quantumemu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.X = new System.Windows.Forms.Button();
            this.Y = new System.Windows.Forms.Button();
            this.Z = new System.Windows.Forms.Button();
            this.H = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.T = new System.Windows.Forms.Button();
            this.S = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новыйФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.схемуВНовомОкнеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.открытьСхемуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadButton = new System.Windows.Forms.ToolStripMenuItem();
            this.схемуВНовомОкнеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveButton = new System.Windows.Forms.ToolStripMenuItem();
            this.какКартинкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.clearButton = new System.Windows.Forms.ToolStripMenuItem();
            this.количествоКубитовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qubitCount = new System.Windows.Forms.ToolStripComboBox();
            this.Measure = new System.Windows.Forms.ToolStripButton();
            this.resultMessage = new System.Windows.Forms.Label();
            this.panelResult = new System.Windows.Forms.Panel();
            this.panelGates = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // X
            // 
            this.X.Cursor = System.Windows.Forms.Cursors.Hand;
            this.X.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.X.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.X.Location = new System.Drawing.Point(12, 55);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(80, 80);
            this.X.TabIndex = 0;
            this.X.Text = "X";
            this.X.UseVisualStyleBackColor = true;
            // 
            // Y
            // 
            this.Y.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.Y.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Y.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Y.Location = new System.Drawing.Point(116, 55);
            this.Y.Name = "Y";
            this.Y.Size = new System.Drawing.Size(80, 80);
            this.Y.TabIndex = 1;
            this.Y.Text = "Y";
            this.Y.UseVisualStyleBackColor = true;
            // 
            // Z
            // 
            this.Z.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Z.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Z.Location = new System.Drawing.Point(219, 55);
            this.Z.Name = "Z";
            this.Z.Size = new System.Drawing.Size(80, 80);
            this.Z.TabIndex = 3;
            this.Z.Text = "Z";
            this.Z.UseVisualStyleBackColor = true;
            // 
            // H
            // 
            this.H.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.H.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.H.Location = new System.Drawing.Point(323, 55);
            this.H.Name = "H";
            this.H.Size = new System.Drawing.Size(80, 80);
            this.H.TabIndex = 2;
            this.H.Text = "H";
            this.H.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(0, 160);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1408, 503);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Paint);
            // 
            // T
            // 
            this.T.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.T.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.T.Location = new System.Drawing.Point(427, 55);
            this.T.Name = "T";
            this.T.Size = new System.Drawing.Size(80, 80);
            this.T.TabIndex = 11;
            this.T.Text = "T";
            this.T.UseVisualStyleBackColor = true;
            // 
            // S
            // 
            this.S.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.S.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.S.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.S.Location = new System.Drawing.Point(532, 55);
            this.S.Name = "S";
            this.S.Size = new System.Drawing.Size(80, 80);
            this.S.TabIndex = 10;
            this.S.Text = "S";
            this.S.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton2,
            this.toolStripDropDownButton1,
            this.Measure});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1408, 38);
            this.toolStrip1.TabIndex = 12;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.загрузитьToolStripMenuItem,
            this.toolStripSeparator2,
            this.открытьСхемуToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.toolStripSeparator1,
            this.выходToolStripMenuItem});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(71, 33);
            this.toolStripDropDownButton2.Text = "Файл";
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новыйФайлToolStripMenuItem,
            this.схемуВНовомОкнеToolStripMenuItem});
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(208, 34);
            this.загрузитьToolStripMenuItem.Text = "Создать..";
            // 
            // новыйФайлToolStripMenuItem
            // 
            this.новыйФайлToolStripMenuItem.Name = "новыйФайлToolStripMenuItem";
            this.новыйФайлToolStripMenuItem.Size = new System.Drawing.Size(274, 34);
            this.новыйФайлToolStripMenuItem.Text = "Цепь";
            // 
            // схемуВНовомОкнеToolStripMenuItem
            // 
            this.схемуВНовомОкнеToolStripMenuItem.Name = "схемуВНовомОкнеToolStripMenuItem";
            this.схемуВНовомОкнеToolStripMenuItem.Size = new System.Drawing.Size(274, 34);
            this.схемуВНовомОкнеToolStripMenuItem.Text = "Цепь в новом окне";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(205, 6);
            // 
            // открытьСхемуToolStripMenuItem
            // 
            this.открытьСхемуToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadButton,
            this.схемуВНовомОкнеToolStripMenuItem1});
            this.открытьСхемуToolStripMenuItem.Name = "открытьСхемуToolStripMenuItem";
            this.открытьСхемуToolStripMenuItem.Size = new System.Drawing.Size(208, 34);
            this.открытьСхемуToolStripMenuItem.Text = "Открыть..";
            // 
            // loadButton
            // 
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(274, 34);
            this.loadButton.Text = "Цепь";
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // схемуВНовомОкнеToolStripMenuItem1
            // 
            this.схемуВНовомОкнеToolStripMenuItem1.Name = "схемуВНовомОкнеToolStripMenuItem1";
            this.схемуВНовомОкнеToolStripMenuItem1.Size = new System.Drawing.Size(274, 34);
            this.схемуВНовомОкнеToolStripMenuItem1.Text = "Цепь в новом окне";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveButton,
            this.какКартинкуToolStripMenuItem});
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(208, 34);
            this.сохранитьToolStripMenuItem.Text = "Сохранить..";
            // 
            // saveButton
            // 
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(197, 34);
            this.saveButton.Text = "Цепь";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // какКартинкуToolStripMenuItem
            // 
            this.какКартинкуToolStripMenuItem.Name = "какКартинкуToolStripMenuItem";
            this.какКартинкуToolStripMenuItem.Size = new System.Drawing.Size(197, 34);
            this.какКартинкуToolStripMenuItem.Text = "Картинку..";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(205, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(208, 34);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearButton,
            this.количествоКубитовToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(80, 29);
            this.toolStripDropDownButton1.Text = "Схема";
            // 
            // clearButton
            // 
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(280, 34);
            this.clearButton.Text = "Очистить";
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // количествоКубитовToolStripMenuItem
            // 
            this.количествоКубитовToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qubitCount});
            this.количествоКубитовToolStripMenuItem.Name = "количествоКубитовToolStripMenuItem";
            this.количествоКубитовToolStripMenuItem.Size = new System.Drawing.Size(280, 34);
            this.количествоКубитовToolStripMenuItem.Text = "Количество кубитов";
            // 
            // qubitCount
            // 
            this.qubitCount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.qubitCount.DropDownWidth = 20;
            this.qubitCount.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.qubitCount.Name = "qubitCount";
            this.qubitCount.Size = new System.Drawing.Size(75, 33);
            this.qubitCount.SelectedIndexChanged += new System.EventHandler(this.gridRowChange_IndexChanged);
            this.qubitCount.Validated += new System.EventHandler(this.gridRowChange_IndexChanged);
            // 
            // Measure
            // 
            this.Measure.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Measure.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Measure.Name = "Measure";
            this.Measure.Size = new System.Drawing.Size(94, 29);
            this.Measure.Text = "Замерить";
            this.Measure.Click += new System.EventHandler(this.Measure_Click);
            // 
            // resultMessage
            // 
            this.resultMessage.AutoSize = true;
            this.resultMessage.BackColor = System.Drawing.SystemColors.GrayText;
            this.resultMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultMessage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.resultMessage.Location = new System.Drawing.Point(0, 610);
            this.resultMessage.Name = "resultMessage";
            this.resultMessage.Size = new System.Drawing.Size(277, 34);
            this.resultMessage.TabIndex = 13;
            this.resultMessage.Text = "Результаты измерения";
            this.resultMessage.UseCompatibleTextRendering = true;
            this.resultMessage.Visible = false;
            // 
            // panelResult
            // 
            this.panelResult.BackColor = System.Drawing.SystemColors.GrayText;
            this.panelResult.Location = new System.Drawing.Point(0, 631);
            this.panelResult.Margin = new System.Windows.Forms.Padding(0);
            this.panelResult.Name = "panelResult";
            this.panelResult.Size = new System.Drawing.Size(1408, 201);
            this.panelResult.TabIndex = 22;
            this.panelResult.Visible = false;
            // 
            // panelGates
            // 
            this.panelGates.Location = new System.Drawing.Point(12, 54);
            this.panelGates.Name = "panelGates";
            this.panelGates.Size = new System.Drawing.Size(1384, 100);
            this.panelGates.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1408, 822);
            this.Controls.Add(this.resultMessage);
            this.Controls.Add(this.panelGates);
            this.Controls.Add(this.panelResult);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.T);
            this.Controls.Add(this.S);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Z);
            this.Controls.Add(this.H);
            this.Controls.Add(this.Y);
            this.Controls.Add(this.X);
            this.MaximumSize = new System.Drawing.Size(1430, 878);
            this.MinimumSize = new System.Drawing.Size(1430, 878);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button X;
        private System.Windows.Forms.Button Y;
        private System.Windows.Forms.Button Z;
        private System.Windows.Forms.Button H;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button T;
        private System.Windows.Forms.Button S;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Measure;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem clearButton;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveButton;
        private System.Windows.Forms.ToolStripMenuItem какКартинкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новыйФайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem схемуВНовомОкнеToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem открытьСхемуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadButton;
        private System.Windows.Forms.ToolStripMenuItem схемуВНовомОкнеToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem количествоКубитовToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox qubitCount;
        private System.Windows.Forms.Label resultMessage;
        private System.Windows.Forms.Panel panelResult;
        private System.Windows.Forms.Panel panelGates;
    }
}

