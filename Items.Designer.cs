
namespace maghaze_shokofe
{
    partial class Items
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
            this.btnAdditem = new System.Windows.Forms.Button();
            this.Itemcount = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdditem
            // 
            this.btnAdditem.Location = new System.Drawing.Point(623, 124);
            this.btnAdditem.Name = "btnAdditem";
            this.btnAdditem.Size = new System.Drawing.Size(165, 23);
            this.btnAdditem.TabIndex = 0;
            this.btnAdditem.Text = "اضافه کردن یک محصول ";
            this.btnAdditem.UseVisualStyleBackColor = true;
            this.btnAdditem.Click += new System.EventHandler(this.btnAdditem_Click);
            // 
            // Itemcount
            // 
            this.Itemcount.Location = new System.Drawing.Point(623, 182);
            this.Itemcount.Name = "Itemcount";
            this.Itemcount.Size = new System.Drawing.Size(165, 23);
            this.Itemcount.TabIndex = 1;
            this.Itemcount.Text = "مشاهده محصولات";
            this.Itemcount.UseVisualStyleBackColor = true;
            this.Itemcount.Click += new System.EventHandler(this.Itemcount_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(623, 153);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(165, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "حذف یا ویرایش یک محصول";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Itemcount);
            this.Controls.Add(this.btnAdditem);
            this.Name = "Items";
            this.Text = "محصولات ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdditem;
        private System.Windows.Forms.Button Itemcount;
        private System.Windows.Forms.Button button3;
    }
}