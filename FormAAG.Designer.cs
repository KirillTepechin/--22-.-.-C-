
namespace WindowsFormAAG
{
	partial class FormAAG
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.buttonCreateArmoredVehicle = new System.Windows.Forms.Button();
			this.buttonDown = new System.Windows.Forms.Button();
			this.buttonRight = new System.Windows.Forms.Button();
			this.buttonLeft = new System.Windows.Forms.Button();
			this.buttonUp = new System.Windows.Forms.Button();
			this.pictureBoxAAG = new System.Windows.Forms.PictureBox();
			this.buttonCreateAag = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxAAG)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonCreateArmoredVehicle
			// 
			this.buttonCreateArmoredVehicle.Location = new System.Drawing.Point(13, 13);
			this.buttonCreateArmoredVehicle.Name = "buttonCreateArmoredVehicle";
			this.buttonCreateArmoredVehicle.Size = new System.Drawing.Size(158, 23);
			this.buttonCreateArmoredVehicle.TabIndex = 1;
			this.buttonCreateArmoredVehicle.Text = "Создать бронетранcпорт";
			this.buttonCreateArmoredVehicle.UseVisualStyleBackColor = true;
			this.buttonCreateArmoredVehicle.Click += new System.EventHandler(this.buttonCreateArmoredVehicle_Click);
			// 
			// buttonDown
			// 
			this.buttonDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonDown.BackgroundImage = global::WindowsFormAAG.Properties.Resources.StrelkaDown;
			this.buttonDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonDown.Location = new System.Drawing.Point(817, 431);
			this.buttonDown.Name = "buttonDown";
			this.buttonDown.Size = new System.Drawing.Size(30, 30);
			this.buttonDown.TabIndex = 5;
			this.buttonDown.UseVisualStyleBackColor = true;
			this.buttonDown.Click += new System.EventHandler(this.buttonMove_Click);
			// 
			// buttonRight
			// 
			this.buttonRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonRight.BackgroundImage = global::WindowsFormAAG.Properties.Resources.StrelkaRight;
			this.buttonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonRight.Location = new System.Drawing.Point(850, 395);
			this.buttonRight.Name = "buttonRight";
			this.buttonRight.Size = new System.Drawing.Size(30, 30);
			this.buttonRight.TabIndex = 4;
			this.buttonRight.UseVisualStyleBackColor = true;
			this.buttonRight.Click += new System.EventHandler(this.buttonMove_Click);
			// 
			// buttonLeft
			// 
			this.buttonLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonLeft.BackgroundImage = global::WindowsFormAAG.Properties.Resources.StrelkaLeft;
			this.buttonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonLeft.Location = new System.Drawing.Point(782, 395);
			this.buttonLeft.Name = "buttonLeft";
			this.buttonLeft.Size = new System.Drawing.Size(30, 30);
			this.buttonLeft.TabIndex = 3;
			this.buttonLeft.UseVisualStyleBackColor = true;
			this.buttonLeft.Click += new System.EventHandler(this.buttonMove_Click);
			// 
			// buttonUp
			// 
			this.buttonUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonUp.BackgroundImage = global::WindowsFormAAG.Properties.Resources.StrelkaUp;
			this.buttonUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonUp.Location = new System.Drawing.Point(817, 363);
			this.buttonUp.Name = "buttonUp";
			this.buttonUp.Size = new System.Drawing.Size(30, 30);
			this.buttonUp.TabIndex = 2;
			this.buttonUp.UseVisualStyleBackColor = true;
			this.buttonUp.Click += new System.EventHandler(this.buttonMove_Click);
			// 
			// pictureBoxAAG
			// 
			this.pictureBoxAAG.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBoxAAG.Location = new System.Drawing.Point(0, 0);
			this.pictureBoxAAG.Name = "pictureBoxAAG";
			this.pictureBoxAAG.Size = new System.Drawing.Size(884, 461);
			this.pictureBoxAAG.TabIndex = 0;
			this.pictureBoxAAG.TabStop = false;
			// 
			// buttonCreateAag
			// 
			this.buttonCreateAag.Location = new System.Drawing.Point(189, 13);
			this.buttonCreateAag.Name = "buttonCreateAag";
			this.buttonCreateAag.Size = new System.Drawing.Size(158, 23);
			this.buttonCreateAag.TabIndex = 6;
			this.buttonCreateAag.Text = "Создать зенитку";
			this.buttonCreateAag.UseVisualStyleBackColor = true;
			this.buttonCreateAag.Click += new System.EventHandler(this.buttonCreateAag_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(884, 461);
			this.Controls.Add(this.buttonCreateAag);
			this.Controls.Add(this.buttonDown);
			this.Controls.Add(this.buttonRight);
			this.Controls.Add(this.buttonLeft);
			this.Controls.Add(this.buttonUp);
			this.Controls.Add(this.buttonCreateArmoredVehicle);
			this.Controls.Add(this.pictureBoxAAG);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Зенитная установка";
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxAAG)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBoxAAG;
		private System.Windows.Forms.Button buttonCreateArmoredVehicle;
		private System.Windows.Forms.Button buttonUp;
		private System.Windows.Forms.Button buttonLeft;
		private System.Windows.Forms.Button buttonRight;
		private System.Windows.Forms.Button buttonDown;
		private System.Windows.Forms.Button buttonCreateAag;
	}
}

