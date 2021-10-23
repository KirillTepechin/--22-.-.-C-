
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
            this.buttonTakeArmoredVehicle = new System.Windows.Forms.Button();
            this.buttonSetAAG = new System.Windows.Forms.Button();
            this.buttonSetArmoredVehicle = new System.Windows.Forms.Button();
            this.labelIndex = new System.Windows.Forms.Label();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.labelTake = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHangar)).BeginInit();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxHangar
            // 
            this.pictureBoxHangar.Location = new System.Drawing.Point(-3, 0);
            this.pictureBoxHangar.Name = "pictureBoxHangar";
            this.pictureBoxHangar.Size = new System.Drawing.Size(806, 453);
            this.pictureBoxHangar.TabIndex = 0;
            this.pictureBoxHangar.TabStop = false;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.buttonTakeArmoredVehicle);
            this.groupBox.Controls.Add(this.buttonSetAAG);
            this.groupBox.Controls.Add(this.buttonSetArmoredVehicle);
            this.groupBox.Controls.Add(this.labelIndex);
            this.groupBox.Controls.Add(this.maskedTextBox);
            this.groupBox.Controls.Add(this.labelTake);
            this.groupBox.Location = new System.Drawing.Point(603, 0);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(200, 453);
            this.groupBox.TabIndex = 1;
            this.groupBox.TabStop = false;
            // 
            // buttonTakeArmoredVehicle
            // 
            this.buttonTakeArmoredVehicle.Location = new System.Drawing.Point(67, 170);
            this.buttonTakeArmoredVehicle.Name = "buttonTakeArmoredVehicle";
            this.buttonTakeArmoredVehicle.Size = new System.Drawing.Size(75, 23);
            this.buttonTakeArmoredVehicle.TabIndex = 5;
            this.buttonTakeArmoredVehicle.Text = "Взять";
            this.buttonTakeArmoredVehicle.UseVisualStyleBackColor = true;
            this.buttonTakeArmoredVehicle.Click += new System.EventHandler(this.buttonTakeArmoredVehicle_Click);
            // 
            // buttonSetAAG
            // 
            this.buttonSetAAG.Location = new System.Drawing.Point(25, 71);
            this.buttonSetAAG.Name = "buttonSetAAG";
            this.buttonSetAAG.Size = new System.Drawing.Size(159, 47);
            this.buttonSetAAG.TabIndex = 4;
            this.buttonSetAAG.Text = "Припарковать зенитку";
            this.buttonSetAAG.UseVisualStyleBackColor = true;
            this.buttonSetAAG.Click += new System.EventHandler(this.buttonSetAAG_Click);
            // 
            // buttonSetArmoredVehicle
            // 
            this.buttonSetArmoredVehicle.Location = new System.Drawing.Point(25, 19);
            this.buttonSetArmoredVehicle.Name = "buttonSetArmoredVehicle";
            this.buttonSetArmoredVehicle.Size = new System.Drawing.Size(159, 46);
            this.buttonSetArmoredVehicle.TabIndex = 3;
            this.buttonSetArmoredVehicle.Text = "Припарковать бронетранспорт";
            this.buttonSetArmoredVehicle.UseVisualStyleBackColor = true;
            this.buttonSetArmoredVehicle.Click += new System.EventHandler(this.buttonSetArmoredVehicle_Click);
            // 
            // labelIndex
            // 
            this.labelIndex.AutoSize = true;
            this.labelIndex.Location = new System.Drawing.Point(40, 147);
            this.labelIndex.Name = "labelIndex";
            this.labelIndex.Size = new System.Drawing.Size(42, 13);
            this.labelIndex.TabIndex = 2;
            this.labelIndex.Text = "Место:";
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.Location = new System.Drawing.Point(121, 144);
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(54, 20);
            this.maskedTextBox.TabIndex = 1;
            // 
            // labelTake
            // 
            this.labelTake.AutoSize = true;
            this.labelTake.Location = new System.Drawing.Point(41, 121);
            this.labelTake.Name = "labelTake";
            this.labelTake.Size = new System.Drawing.Size(134, 13);
            this.labelTake.TabIndex = 0;
            this.labelTake.Text = "Забрать бронетранспорт";
            // 
            // FormHangar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.pictureBoxHangar);
            this.Name = "FormHangar";
            this.Text = "Парковка";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHangar)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxHangar;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button buttonTakeArmoredVehicle;
        private System.Windows.Forms.Button buttonSetAAG;
        private System.Windows.Forms.Button buttonSetArmoredVehicle;
        private System.Windows.Forms.Label labelIndex;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.Label labelTake;
    }
}