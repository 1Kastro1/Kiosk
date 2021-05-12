
namespace Kiosk
{
    partial class UserControl1
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ProductPriceLbl = new System.Windows.Forms.Label();
            this.ProdNameLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductPriceLbl
            // 
            this.ProductPriceLbl.AutoSize = true;
            this.ProductPriceLbl.Font = new System.Drawing.Font("Mistral", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductPriceLbl.Location = new System.Drawing.Point(16, 191);
            this.ProductPriceLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProductPriceLbl.Name = "ProductPriceLbl";
            this.ProductPriceLbl.Size = new System.Drawing.Size(63, 22);
            this.ProductPriceLbl.TabIndex = 5;
            this.ProductPriceLbl.Text = "Цена - ";
            // 
            // ProdNameLbl
            // 
            this.ProdNameLbl.AutoSize = true;
            this.ProdNameLbl.Font = new System.Drawing.Font("Mistral", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProdNameLbl.Location = new System.Drawing.Point(16, 167);
            this.ProdNameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProdNameLbl.Name = "ProdNameLbl";
            this.ProdNameLbl.Size = new System.Drawing.Size(93, 22);
            this.ProdNameLbl.TabIndex = 6;
            this.ProdNameLbl.Text = "Название - ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kiosk.Properties.Resources._1611839514_1_p_risunki_yedi_1;
            this.pictureBox1.Location = new System.Drawing.Point(20, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ProductPriceLbl);
            this.Controls.Add(this.ProdNameLbl);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(209, 225);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProductPriceLbl;
        private System.Windows.Forms.Label ProdNameLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
