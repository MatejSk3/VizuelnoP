namespace Shopping_Cart
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
            this.label1 = new System.Windows.Forms.Label();
            this.productList = new System.Windows.Forms.ListBox();
            this.removeProducts = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.priceTB = new System.Windows.Forms.TextBox();
            this.categoryTB = new System.Windows.Forms.TextBox();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addToCart = new System.Windows.Forms.Button();
            this.removeFromCart = new System.Windows.Forms.Button();
            this.addNewProduct = new System.Windows.Forms.Button();
            this.removeProduct = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cartList = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.clearCart = new System.Windows.Forms.Button();
            this.totalTB = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Листа на продукти";
            // 
            // productList
            // 
            this.productList.FormattingEnabled = true;
            this.productList.ItemHeight = 16;
            this.productList.Location = new System.Drawing.Point(31, 76);
            this.productList.Name = "productList";
            this.productList.Size = new System.Drawing.Size(302, 452);
            this.productList.TabIndex = 1;
            this.productList.SelectedIndexChanged += new System.EventHandler(this.productList_SelectedIndexChanged);
            // 
            // removeProducts
            // 
            this.removeProducts.Location = new System.Drawing.Point(31, 558);
            this.removeProducts.Name = "removeProducts";
            this.removeProducts.Size = new System.Drawing.Size(302, 31);
            this.removeProducts.TabIndex = 2;
            this.removeProducts.Text = "Изпразнете ја листата со продукти";
            this.removeProducts.UseVisualStyleBackColor = true;
            this.removeProducts.Click += new System.EventHandler(this.removeProducts_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.priceTB);
            this.groupBox1.Controls.Add(this.categoryTB);
            this.groupBox1.Controls.Add(this.nameTB);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(365, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 212);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Детали за продуктот";
            // 
            // priceTB
            // 
            this.priceTB.Location = new System.Drawing.Point(21, 172);
            this.priceTB.Name = "priceTB";
            this.priceTB.ReadOnly = true;
            this.priceTB.Size = new System.Drawing.Size(227, 22);
            this.priceTB.TabIndex = 5;
            // 
            // categoryTB
            // 
            this.categoryTB.Location = new System.Drawing.Point(21, 117);
            this.categoryTB.Name = "categoryTB";
            this.categoryTB.ReadOnly = true;
            this.categoryTB.Size = new System.Drawing.Size(227, 22);
            this.categoryTB.TabIndex = 4;
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(21, 50);
            this.nameTB.Name = "nameTB";
            this.nameTB.ReadOnly = true;
            this.nameTB.Size = new System.Drawing.Size(227, 22);
            this.nameTB.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Цена";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Категорија";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Име";
            // 
            // addToCart
            // 
            this.addToCart.Location = new System.Drawing.Point(365, 320);
            this.addToCart.Name = "addToCart";
            this.addToCart.Size = new System.Drawing.Size(268, 24);
            this.addToCart.TabIndex = 4;
            this.addToCart.Text = "Додади во кошничка >>";
            this.addToCart.UseVisualStyleBackColor = true;
            this.addToCart.Click += new System.EventHandler(this.addToCart_Click);
            // 
            // removeFromCart
            // 
            this.removeFromCart.Location = new System.Drawing.Point(365, 367);
            this.removeFromCart.Name = "removeFromCart";
            this.removeFromCart.Size = new System.Drawing.Size(268, 23);
            this.removeFromCart.TabIndex = 5;
            this.removeFromCart.Text = "Избриши од кошничка";
            this.removeFromCart.UseVisualStyleBackColor = true;
            this.removeFromCart.Click += new System.EventHandler(this.removeFromCart_Click);
            // 
            // addNewProduct
            // 
            this.addNewProduct.Location = new System.Drawing.Point(365, 411);
            this.addNewProduct.Name = "addNewProduct";
            this.addNewProduct.Size = new System.Drawing.Size(268, 23);
            this.addNewProduct.TabIndex = 6;
            this.addNewProduct.Text = "Додај нов продукт";
            this.addNewProduct.UseVisualStyleBackColor = true;
            this.addNewProduct.Click += new System.EventHandler(this.addNewProduct_Click);
            // 
            // removeProduct
            // 
            this.removeProduct.Location = new System.Drawing.Point(365, 455);
            this.removeProduct.Name = "removeProduct";
            this.removeProduct.Size = new System.Drawing.Size(268, 23);
            this.removeProduct.TabIndex = 7;
            this.removeProduct.Text = "Избриши продукт";
            this.removeProduct.UseVisualStyleBackColor = true;
            this.removeProduct.Click += new System.EventHandler(this.removeProduct_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(679, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Кошничка";
            // 
            // cartList
            // 
            this.cartList.FormattingEnabled = true;
            this.cartList.ItemHeight = 16;
            this.cartList.Location = new System.Drawing.Point(658, 76);
            this.cartList.Name = "cartList";
            this.cartList.Size = new System.Drawing.Size(320, 452);
            this.cartList.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(655, 545);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Вкупно";
            // 
            // clearCart
            // 
            this.clearCart.Location = new System.Drawing.Point(658, 580);
            this.clearCart.Name = "clearCart";
            this.clearCart.Size = new System.Drawing.Size(277, 29);
            this.clearCart.TabIndex = 11;
            this.clearCart.Text = "Изпразни ја кошничката";
            this.clearCart.UseVisualStyleBackColor = true;
            this.clearCart.Click += new System.EventHandler(this.clearCart_Click);
            // 
            // totalTB
            // 
            this.totalTB.Location = new System.Drawing.Point(716, 545);
            this.totalTB.Name = "totalTB";
            this.totalTB.ReadOnly = true;
            this.totalTB.Size = new System.Drawing.Size(227, 22);
            this.totalTB.TabIndex = 6;
            this.totalTB.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 628);
            this.Controls.Add(this.totalTB);
            this.Controls.Add(this.clearCart);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cartList);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.removeProduct);
            this.Controls.Add(this.addNewProduct);
            this.Controls.Add(this.removeFromCart);
            this.Controls.Add(this.addToCart);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.removeProducts);
            this.Controls.Add(this.productList);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox productList;
        private System.Windows.Forms.Button removeProducts;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addToCart;
        private System.Windows.Forms.Button removeFromCart;
        private System.Windows.Forms.Button addNewProduct;
        private System.Windows.Forms.Button removeProduct;
        private System.Windows.Forms.TextBox priceTB;
        private System.Windows.Forms.TextBox categoryTB;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox cartList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button clearCart;
        private System.Windows.Forms.TextBox totalTB;
    }
}

