
namespace maghaze_shokofe
{
    partial class Costumer
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
            this.AddoneCostumer = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnListCustomer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddoneCostumer
            // 
            this.AddoneCostumer.Location = new System.Drawing.Point(649, 82);
            this.AddoneCostumer.Name = "AddoneCostumer";
            this.AddoneCostumer.Size = new System.Drawing.Size(139, 23);
            this.AddoneCostumer.TabIndex = 0;
            this.AddoneCostumer.Text = "اضافه کردن یک مشتری";
            this.AddoneCostumer.UseVisualStyleBackColor = true;
            this.AddoneCostumer.Click += new System.EventHandler(this.AddoneCostumer_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(649, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "ویرایش یک مشتری";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnListCustomer
            // 
            this.btnListCustomer.Location = new System.Drawing.Point(649, 140);
            this.btnListCustomer.Name = "btnListCustomer";
            this.btnListCustomer.Size = new System.Drawing.Size(139, 23);
            this.btnListCustomer.TabIndex = 2;
            this.btnListCustomer.Text = "مشاهده لیست مشتری ها";
            this.btnListCustomer.UseVisualStyleBackColor = true;
            this.btnListCustomer.Click += new System.EventHandler(this.btnListCustomer_Click);
            // 
            // Costumer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnListCustomer);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AddoneCostumer);
            this.Name = "Costumer";
            this.Text = "مشتری";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddoneCostumer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnListCustomer;
    }
}