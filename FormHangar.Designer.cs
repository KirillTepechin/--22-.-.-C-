
namespace WindowsFormAAG
{
    partial class FormHangar
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
            this.pictureBoxHangar = new System.Windows.Forms.PictureBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.buttonSetArmoredVehicle = new System.Windows.Forms.Button();
            this.textBoxNewLevelName = new System.Windows.Forms.TextBox();
            this.buttonDelHangar = new System.Windows.Forms.Button();
            this.buttonAddHangar = new System.Windows.Forms.Button();
            this.labelHangars = new System.Windows.Forms.Label();
            this.listBoxHangars = new System.Windows.Forms.ListBox();
            this.buttonTakeArmoredVehicle = new System.Windows.Forms.Button();
            this.labelIndex = new System.Windows.Forms.Label();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.labelTake = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.buttonSort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHangar)).BeginInit();
            this.groupBox.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxHangar
            // 
            this.pictureBoxHangar.Location = new System.Drawing.Point(0, 27);
            this.pictureBoxHangar.Name = "pictureBoxHangar";
            this.pictureBoxHangar.Size = new System.Drawing.Size(806, 362);
            this.pictureBoxHangar.TabIndex = 0;
            this.pictureBoxHangar.TabStop = false;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.buttonSort);
            this.groupBox.Controls.Add(this.buttonSetArmoredVehicle);
            this.groupBox.Controls.Add(this.textBoxNewLevelName);
            this.groupBox.Controls.Add(this.buttonDelHangar);
            this.groupBox.Controls.Add(this.buttonAddHangar);
            this.groupBox.Controls.Add(this.labelHangars);
            this.groupBox.Controls.Add(this.listBoxHangars);
            this.groupBox.Controls.Add(this.buttonTakeArmoredVehicle);
            this.groupBox.Controls.Add(this.labelIndex);
            this.groupBox.Controls.Add(this.maskedTextBox);
            this.groupBox.Controls.Add(this.labelTake);
            this.groupBox.Location = new System.Drawing.Point(603, -6);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(200, 453);
            this.groupBox.TabIndex = 1;
            this.groupBox.TabStop = false;
            // 
            // buttonSetArmoredVehicle
            // 
            this.buttonSetArmoredVehicle.Location = new System.Drawing.Point(25, 328);
            this.buttonSetArmoredVehicle.Name = "buttonSetArmoredVehicle";
            this.buttonSetArmoredVehicle.Size = new System.Drawing.Size(150, 40);
            this.buttonSetArmoredVehicle.TabIndex = 11;
            this.buttonSetArmoredVehicle.Text = "Добавить бронетранспорт";
            this.buttonSetArmoredVehicle.UseVisualStyleBackColor = true;
            this.buttonSetArmoredVehicle.Click += new System.EventHandler(this.buttonSetArmoredVehicle_Click);
            // 
            // textBoxNewLevelName
            // 
            this.textBoxNewLevelName.Location = new System.Drawing.Point(25, 25);
            this.textBoxNewLevelName.Name = "textBoxNewLevelName";
            this.textBoxNewLevelName.Size = new System.Drawing.Size(155, 20);
            this.textBoxNewLevelName.TabIndex = 10;
            // 
            // buttonDelHangar
            // 
            this.buttonDelHangar.Location = new System.Drawing.Point(25, 220);
            this.buttonDelHangar.Name = "buttonDelHangar";
            this.buttonDelHangar.Size = new System.Drawing.Size(158, 23);
            this.buttonDelHangar.TabIndex = 9;
            this.buttonDelHangar.Text = "Удалить ангар";
            this.buttonDelHangar.UseVisualStyleBackColor = true;
            this.buttonDelHangar.Click += new System.EventHandler(this.buttonDelHangar_Click);
            // 
            // buttonAddHangar
            // 
            this.buttonAddHangar.Location = new System.Drawing.Point(25, 51);
            this.buttonAddHangar.Name = "buttonAddHangar";
            this.buttonAddHangar.Size = new System.Drawing.Size(158, 23);
            this.buttonAddHangar.TabIndex = 8;
            this.buttonAddHangar.Text = "Добавить ангар";
            this.buttonAddHangar.UseVisualStyleBackColor = true;
            this.buttonAddHangar.Click += new System.EventHandler(this.buttonAddHangar_Click);
            // 
            // labelHangars
            // 
            this.labelHangars.AutoSize = true;
            this.labelHangars.Location = new System.Drawing.Point(78, 9);
            this.labelHangars.Name = "labelHangars";
            this.labelHangars.Size = new System.Drawing.Size(48, 13);
            this.labelHangars.TabIndex = 7;
            this.labelHangars.Text = "Ангары:";
            // 
            // listBoxHangars
            // 
            this.listBoxHangars.FormattingEnabled = true;
            this.listBoxHangars.Location = new System.Drawing.Point(25, 80);
            this.listBoxHangars.Name = "listBoxHangars";
            this.listBoxHangars.Size = new System.Drawing.Size(158, 134);
            this.listBoxHangars.TabIndex = 6;
            this.listBoxHangars.SelectedIndexChanged += new System.EventHandler(this.listBoxHangars_SelectedIndexChanged);
            // 
            // buttonTakeArmoredVehicle
            // 
            this.buttonTakeArmoredVehicle.Location = new System.Drawing.Point(67, 423);
            this.buttonTakeArmoredVehicle.Name = "buttonTakeArmoredVehicle";
            this.buttonTakeArmoredVehicle.Size = new System.Drawing.Size(75, 23);
            this.buttonTakeArmoredVehicle.TabIndex = 5;
            this.buttonTakeArmoredVehicle.Text = "Взять";
            this.buttonTakeArmoredVehicle.UseVisualStyleBackColor = true;
            this.buttonTakeArmoredVehicle.Click += new System.EventHandler(this.buttonTakeArmoredVehicle_Click);
            // 
            // labelIndex
            // 
            this.labelIndex.AutoSize = true;
            this.labelIndex.Location = new System.Drawing.Point(40, 400);
            this.labelIndex.Name = "labelIndex";
            this.labelIndex.Size = new System.Drawing.Size(42, 13);
            this.labelIndex.TabIndex = 2;
            this.labelIndex.Text = "Место:";
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.Location = new System.Drawing.Point(121, 397);
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(54, 20);
            this.maskedTextBox.TabIndex = 1;
            // 
            // labelTake
            // 
            this.labelTake.AutoSize = true;
            this.labelTake.Location = new System.Drawing.Point(41, 374);
            this.labelTake.Name = "labelTake";
            this.labelTake.Size = new System.Drawing.Size(134, 13);
            this.labelTake.TabIndex = 0;
            this.labelTake.Text = "Забрать бронетранспорт";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 3;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.загрузитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "txt file | *.txt";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "txt file | *.txt";
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(25, 268);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(155, 41);
            this.buttonSort.TabIndex = 12;
            this.buttonSort.Text = "Сортировать";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // FormHangar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.pictureBoxHangar);
            this.Controls.Add(this.menuStrip2);
            this.Name = "FormHangar";
            this.Text = "Парковка";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHangar)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxHangar;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button buttonTakeArmoredVehicle;
        private System.Windows.Forms.Label labelIndex;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.Label labelTake;
        private System.Windows.Forms.ListBox listBoxHangars;
        private System.Windows.Forms.Button buttonDelHangar;
        private System.Windows.Forms.Button buttonAddHangar;
        private System.Windows.Forms.Label labelHangars;
        private System.Windows.Forms.TextBox textBoxNewLevelName;
        private System.Windows.Forms.Button buttonSetArmoredVehicle;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button buttonSort;
    }
}