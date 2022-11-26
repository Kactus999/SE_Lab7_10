
namespace LabWinform
{
    partial class Purchase
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
            this.lbTest = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lb_quantity = new System.Windows.Forms.Label();
            this.tb_quantity = new System.Windows.Forms.TextBox();
            this.btn_buy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTest
            // 
            this.lbTest.AutoSize = true;
            this.lbTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTest.Location = new System.Drawing.Point(409, 162);
            this.lbTest.Name = "lbTest";
            this.lbTest.Size = new System.Drawing.Size(65, 29);
            this.lbTest.TabIndex = 0;
            this.lbTest.Text = "Item:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Nike Shoes",
            "Adidas Shoes",
            "IPhone",
            "Macbook",
            "IPad",
            "Apple Watch",
            "Samsung S20"});
            this.comboBox1.Location = new System.Drawing.Point(511, 167);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // lb_quantity
            // 
            this.lb_quantity.AutoSize = true;
            this.lb_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_quantity.Location = new System.Drawing.Point(409, 226);
            this.lb_quantity.Name = "lb_quantity";
            this.lb_quantity.Size = new System.Drawing.Size(85, 25);
            this.lb_quantity.TabIndex = 2;
            this.lb_quantity.Text = "Quantity";
            // 
            // tb_quantity
            // 
            this.tb_quantity.Location = new System.Drawing.Point(511, 226);
            this.tb_quantity.Name = "tb_quantity";
            this.tb_quantity.Size = new System.Drawing.Size(121, 22);
            this.tb_quantity.TabIndex = 3;
            // 
            // btn_buy
            // 
            this.btn_buy.Location = new System.Drawing.Point(943, 567);
            this.btn_buy.Name = "btn_buy";
            this.btn_buy.Size = new System.Drawing.Size(75, 23);
            this.btn_buy.TabIndex = 4;
            this.btn_buy.Text = "Buy";
            this.btn_buy.UseVisualStyleBackColor = true;
            this.btn_buy.Click += new System.EventHandler(this.btn_buy_Click);
            // 
            // Purchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 658);
            this.Controls.Add(this.btn_buy);
            this.Controls.Add(this.tb_quantity);
            this.Controls.Add(this.lb_quantity);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbTest);
            this.Name = "Purchase";
            this.Text = "Purchase";
            this.Load += new System.EventHandler(this.Purchase_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTest;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lb_quantity;
        private System.Windows.Forms.TextBox tb_quantity;
        private System.Windows.Forms.Button btn_buy;
    }
}