
namespace WindowsFormAAG
{
    partial class FormAAGConfig
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
            this.groupBoxParams = new System.Windows.Forms.GroupBox();
            this.checkBoxRadiolocation = new System.Windows.Forms.CheckBox();
            this.checkBoxGun = new System.Windows.Forms.CheckBox();
            this.numericUpDownMaxSpeed = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownWeight = new System.Windows.Forms.NumericUpDown();
            this.labelWeight = new System.Windows.Forms.Label();
            this.labelMaxSpeed = new System.Windows.Forms.Label();
            this.pictureBoxArmoredVehicle = new System.Windows.Forms.PictureBox();
            this.groupBoxType = new System.Windows.Forms.GroupBox();
            this.labelAAG = new System.Windows.Forms.Label();
            this.labelArmoredVehicle = new System.Windows.Forms.Label();
            this.panelArmoredVehicle = new System.Windows.Forms.Panel();
            this.groupBoxColors = new System.Windows.Forms.GroupBox();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.labelBaseColor = new System.Windows.Forms.Label();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panelRed = new System.Windows.Forms.Panel();
            this.panelGray = new System.Windows.Forms.Panel();
            this.panelWhite = new System.Windows.Forms.Panel();
            this.panelBlack = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panelDarkOliveGreen = new System.Windows.Forms.Panel();
            this.panelDarkGreen = new System.Windows.Forms.Panel();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxParams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArmoredVehicle)).BeginInit();
            this.groupBoxType.SuspendLayout();
            this.panelArmoredVehicle.SuspendLayout();
            this.groupBoxColors.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxParams
            // 
            this.groupBoxParams.Controls.Add(this.checkBoxRadiolocation);
            this.groupBoxParams.Controls.Add(this.checkBoxGun);
            this.groupBoxParams.Controls.Add(this.numericUpDownMaxSpeed);
            this.groupBoxParams.Controls.Add(this.numericUpDownWeight);
            this.groupBoxParams.Controls.Add(this.labelWeight);
            this.groupBoxParams.Controls.Add(this.labelMaxSpeed);
            this.groupBoxParams.Location = new System.Drawing.Point(12, 170);
            this.groupBoxParams.Name = "groupBoxParams";
            this.groupBoxParams.Size = new System.Drawing.Size(287, 136);
            this.groupBoxParams.TabIndex = 0;
            this.groupBoxParams.TabStop = false;
            this.groupBoxParams.Text = "Параметры";
            // 
            // checkBoxRadiolocation
            // 
            this.checkBoxRadiolocation.AutoSize = true;
            this.checkBoxRadiolocation.Location = new System.Drawing.Point(187, 83);
            this.checkBoxRadiolocation.Name = "checkBoxRadiolocation";
            this.checkBoxRadiolocation.Size = new System.Drawing.Size(98, 17);
            this.checkBoxRadiolocation.TabIndex = 4;
            this.checkBoxRadiolocation.Text = "Радиолокатор";
            this.checkBoxRadiolocation.UseVisualStyleBackColor = true;
            // 
            // checkBoxGun
            // 
            this.checkBoxGun.AutoSize = true;
            this.checkBoxGun.Location = new System.Drawing.Point(187, 45);
            this.checkBoxGun.Name = "checkBoxGun";
            this.checkBoxGun.Size = new System.Drawing.Size(59, 17);
            this.checkBoxGun.TabIndex = 3;
            this.checkBoxGun.Text = "Пушка";
            this.checkBoxGun.UseVisualStyleBackColor = true;
            // 
            // numericUpDownMaxSpeed
            // 
            this.numericUpDownMaxSpeed.Location = new System.Drawing.Point(102, 42);
            this.numericUpDownMaxSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownMaxSpeed.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownMaxSpeed.Name = "numericUpDownMaxSpeed";
            this.numericUpDownMaxSpeed.Size = new System.Drawing.Size(61, 20);
            this.numericUpDownMaxSpeed.TabIndex = 1;
            this.numericUpDownMaxSpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDownWeight
            // 
            this.numericUpDownWeight.Location = new System.Drawing.Point(102, 80);
            this.numericUpDownWeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownWeight.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownWeight.Name = "numericUpDownWeight";
            this.numericUpDownWeight.Size = new System.Drawing.Size(61, 20);
            this.numericUpDownWeight.TabIndex = 2;
            this.numericUpDownWeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(67, 82);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(29, 13);
            this.labelWeight.TabIndex = 1;
            this.labelWeight.Text = "Вес:";
            // 
            // labelMaxSpeed
            // 
            this.labelMaxSpeed.AutoSize = true;
            this.labelMaxSpeed.Location = new System.Drawing.Point(6, 42);
            this.labelMaxSpeed.Name = "labelMaxSpeed";
            this.labelMaxSpeed.Size = new System.Drawing.Size(90, 13);
            this.labelMaxSpeed.TabIndex = 0;
            this.labelMaxSpeed.Text = "Макс. скорость:";
            // 
            // pictureBoxArmoredVehicle
            // 
            this.pictureBoxArmoredVehicle.Location = new System.Drawing.Point(16, 8);
            this.pictureBoxArmoredVehicle.Name = "pictureBoxArmoredVehicle";
            this.pictureBoxArmoredVehicle.Size = new System.Drawing.Size(225, 128);
            this.pictureBoxArmoredVehicle.TabIndex = 1;
            this.pictureBoxArmoredVehicle.TabStop = false;
            // 
            // groupBoxType
            // 
            this.groupBoxType.Controls.Add(this.labelAAG);
            this.groupBoxType.Controls.Add(this.labelArmoredVehicle);
            this.groupBoxType.Location = new System.Drawing.Point(21, 12);
            this.groupBoxType.Name = "groupBoxType";
            this.groupBoxType.Size = new System.Drawing.Size(178, 142);
            this.groupBoxType.TabIndex = 2;
            this.groupBoxType.TabStop = false;
            this.groupBoxType.Text = "Тип";
            // 
            // labelAAG
            // 
            this.labelAAG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAAG.Location = new System.Drawing.Point(23, 78);
            this.labelAAG.Name = "labelAAG";
            this.labelAAG.Size = new System.Drawing.Size(133, 50);
            this.labelAAG.TabIndex = 1;
            this.labelAAG.Text = "Зенитка";
            this.labelAAG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelAAG.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelAAG_MouseDown);
            // 
            // labelArmoredVehicle
            // 
            this.labelArmoredVehicle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelArmoredVehicle.Location = new System.Drawing.Point(23, 16);
            this.labelArmoredVehicle.Name = "labelArmoredVehicle";
            this.labelArmoredVehicle.Size = new System.Drawing.Size(133, 50);
            this.labelArmoredVehicle.TabIndex = 0;
            this.labelArmoredVehicle.Text = "Бронетранспорт";
            this.labelArmoredVehicle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelArmoredVehicle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelArmoredVehicle_MouseDown);
            // 
            // panelArmoredVehicle
            // 
            this.panelArmoredVehicle.AllowDrop = true;
            this.panelArmoredVehicle.Controls.Add(this.pictureBoxArmoredVehicle);
            this.panelArmoredVehicle.Location = new System.Drawing.Point(227, 21);
            this.panelArmoredVehicle.Name = "panelArmoredVehicle";
            this.panelArmoredVehicle.Size = new System.Drawing.Size(258, 143);
            this.panelArmoredVehicle.TabIndex = 3;
            this.panelArmoredVehicle.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelArmoredVehicle_DragDrop);
            this.panelArmoredVehicle.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelArmoredVehicle_DragEnter);
            // 
            // groupBoxColors
            // 
            this.groupBoxColors.Controls.Add(this.labelDopColor);
            this.groupBoxColors.Controls.Add(this.labelBaseColor);
            this.groupBoxColors.Controls.Add(this.panelBlue);
            this.groupBoxColors.Controls.Add(this.panelRed);
            this.groupBoxColors.Controls.Add(this.panelGray);
            this.groupBoxColors.Controls.Add(this.panelWhite);
            this.groupBoxColors.Controls.Add(this.panelBlack);
            this.groupBoxColors.Controls.Add(this.panelGreen);
            this.groupBoxColors.Controls.Add(this.panelDarkOliveGreen);
            this.groupBoxColors.Controls.Add(this.panelDarkGreen);
            this.groupBoxColors.Location = new System.Drawing.Point(499, 21);
            this.groupBoxColors.Name = "groupBoxColors";
            this.groupBoxColors.Size = new System.Drawing.Size(156, 143);
            this.groupBoxColors.TabIndex = 4;
            this.groupBoxColors.TabStop = false;
            this.groupBoxColors.Text = "Цвета";
            // 
            // labelDopColor
            // 
            this.labelDopColor.AllowDrop = true;
            this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopColor.Location = new System.Drawing.Point(79, 21);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(72, 36);
            this.labelDopColor.TabIndex = 6;
            this.labelDopColor.Text = "Доп. цвет";
            this.labelDopColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            // 
            // labelBaseColor
            // 
            this.labelBaseColor.AllowDrop = true;
            this.labelBaseColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBaseColor.Location = new System.Drawing.Point(3, 21);
            this.labelBaseColor.Name = "labelBaseColor";
            this.labelBaseColor.Size = new System.Drawing.Size(72, 36);
            this.labelBaseColor.TabIndex = 5;
            this.labelBaseColor.Text = "Осн. цвет";
            this.labelBaseColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBaseColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragDrop);
            this.labelBaseColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.Blue;
            this.panelBlue.Location = new System.Drawing.Point(114, 103);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(30, 30);
            this.panelBlue.TabIndex = 1;
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.Location = new System.Drawing.Point(78, 103);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(30, 30);
            this.panelRed.TabIndex = 1;
            // 
            // panelGray
            // 
            this.panelGray.BackColor = System.Drawing.Color.Gray;
            this.panelGray.Location = new System.Drawing.Point(42, 103);
            this.panelGray.Name = "panelGray";
            this.panelGray.Size = new System.Drawing.Size(30, 30);
            this.panelGray.TabIndex = 1;
            // 
            // panelWhite
            // 
            this.panelWhite.BackColor = System.Drawing.Color.White;
            this.panelWhite.Location = new System.Drawing.Point(6, 103);
            this.panelWhite.Name = "panelWhite";
            this.panelWhite.Size = new System.Drawing.Size(30, 30);
            this.panelWhite.TabIndex = 1;
            // 
            // panelBlack
            // 
            this.panelBlack.BackColor = System.Drawing.Color.Black;
            this.panelBlack.Location = new System.Drawing.Point(114, 67);
            this.panelBlack.Name = "panelBlack";
            this.panelBlack.Size = new System.Drawing.Size(30, 30);
            this.panelBlack.TabIndex = 1;
            // 
            // panelGreen
            // 
            this.panelGreen.BackColor = System.Drawing.Color.Green;
            this.panelGreen.Location = new System.Drawing.Point(78, 67);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(30, 30);
            this.panelGreen.TabIndex = 1;
            // 
            // panelDarkOliveGreen
            // 
            this.panelDarkOliveGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panelDarkOliveGreen.Location = new System.Drawing.Point(42, 67);
            this.panelDarkOliveGreen.Name = "panelDarkOliveGreen";
            this.panelDarkOliveGreen.Size = new System.Drawing.Size(30, 30);
            this.panelDarkOliveGreen.TabIndex = 1;
            // 
            // panelDarkGreen
            // 
            this.panelDarkGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panelDarkGreen.Location = new System.Drawing.Point(6, 67);
            this.panelDarkGreen.Name = "panelDarkGreen";
            this.panelDarkGreen.Size = new System.Drawing.Size(30, 30);
            this.panelDarkGreen.TabIndex = 0;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(514, 222);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 5;
            this.buttonOk.Text = "Добавить";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(514, 264);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormAAGConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 318);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.groupBoxColors);
            this.Controls.Add(this.panelArmoredVehicle);
            this.Controls.Add(this.groupBoxType);
            this.Controls.Add(this.groupBoxParams);
            this.Name = "FormAAGConfig";
            this.Text = "FormAAGConfig";
            this.groupBoxParams.ResumeLayout(false);
            this.groupBoxParams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArmoredVehicle)).EndInit();
            this.groupBoxType.ResumeLayout(false);
            this.panelArmoredVehicle.ResumeLayout(false);
            this.groupBoxColors.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxParams;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Label labelMaxSpeed;
        private System.Windows.Forms.CheckBox checkBoxRadiolocation;
        private System.Windows.Forms.CheckBox checkBoxGun;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxSpeed;
        private System.Windows.Forms.NumericUpDown numericUpDownWeight;
        private System.Windows.Forms.PictureBox pictureBoxArmoredVehicle;
        private System.Windows.Forms.GroupBox groupBoxType;
        private System.Windows.Forms.Label labelAAG;
        private System.Windows.Forms.Label labelArmoredVehicle;
        private System.Windows.Forms.Panel panelArmoredVehicle;
        private System.Windows.Forms.GroupBox groupBoxColors;
        private System.Windows.Forms.Label labelDopColor;
        private System.Windows.Forms.Label labelBaseColor;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Panel panelGray;
        private System.Windows.Forms.Panel panelWhite;
        private System.Windows.Forms.Panel panelBlack;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Panel panelDarkOliveGreen;
        private System.Windows.Forms.Panel panelDarkGreen;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
    }
}