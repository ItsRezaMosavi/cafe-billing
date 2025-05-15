namespace cafe_billing
{
    partial class frmBilling
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
            components = new System.ComponentModel.Container();
            pnlTitle = new Panel();
            lblDate = new Label();
            lblHour = new Label();
            lblTitle = new Label();
            pnlDrinks = new Panel();
            txtCaramelMacchiato_Count = new TextBox();
            txtMilkTea_Count = new TextBox();
            txtIceCoffee_Count = new TextBox();
            txtTea_Count = new TextBox();
            txtLate_Count = new TextBox();
            txtEspresso_Count = new TextBox();
            txtCappuccino_Count = new TextBox();
            txtMocha_Count = new TextBox();
            lblCaramelMacchiato_Cost = new Label();
            lblMilkTea_Cost = new Label();
            lblIceCoffee_Cost = new Label();
            lblTea_Cost = new Label();
            lblEspresso_Cost = new Label();
            lblMocha_Cost = new Label();
            lblCappuccino_Cost = new Label();
            lblLate_Cost = new Label();
            chbMocha = new CheckBox();
            chbCaramelMacchiato = new CheckBox();
            chbMilkTea = new CheckBox();
            chbIceCoffee = new CheckBox();
            chbTea = new CheckBox();
            chbEspresso = new CheckBox();
            chbCappuccino = new CheckBox();
            chbLate = new CheckBox();
            pnlCakes = new Panel();
            txtCoconutCookie_Count = new TextBox();
            txtSmartiesCookie_Count = new TextBox();
            txtChocolateCookie_Count = new TextBox();
            txtCheeseCake_Count = new TextBox();
            txtCoffeeCake_Count = new TextBox();
            txtChocolateCake_Count = new TextBox();
            txtVanillaCake_Count = new TextBox();
            txtWetChocolateCake_Count = new TextBox();
            lblCoconutCookie_Cost = new Label();
            lblSmartiesCookie_Cost = new Label();
            lblChocolateCookie_Cost = new Label();
            lblCheeseCake_Cost = new Label();
            lblChocolateCake_Cost = new Label();
            lblWetChocolateCake_Cost = new Label();
            lblVanillaCake_Cost = new Label();
            lblCoffeeCake_Cost = new Label();
            chbWetChocolateCake = new CheckBox();
            chbCoconutCookie = new CheckBox();
            chbSmartiesCookie = new CheckBox();
            chbChocolateCookie = new CheckBox();
            chbCheeseCake = new CheckBox();
            chbChocolateCake = new CheckBox();
            chbVanillaCake = new CheckBox();
            chbCoffeeCake = new CheckBox();
            pnlCost1 = new Panel();
            txtSumOfOrder = new TextBox();
            txtDrinksCost = new TextBox();
            txtCakesCost = new TextBox();
            lblSumOfOrder = new Label();
            lblDrinksCost = new Label();
            lblCakesCost = new Label();
            pnlCost2 = new Panel();
            txtServices = new TextBox();
            btnDiscount = new Button();
            txtTax = new TextBox();
            lblServiceCharge = new Label();
            lblDiscount = new Label();
            txtDiscount = new TextBox();
            lblTax = new Label();
            txtTotal = new TextBox();
            lblTotal = new Label();
            pnlButton = new Panel();
            btnReceipt = new Button();
            btnReset = new Button();
            btnReCalculate = new Button();
            tmrMain = new System.Windows.Forms.Timer(components);
            pnlTitle.SuspendLayout();
            pnlDrinks.SuspendLayout();
            pnlCakes.SuspendLayout();
            pnlCost1.SuspendLayout();
            pnlCost2.SuspendLayout();
            pnlButton.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTitle
            // 
            pnlTitle.BackColor = Color.DodgerBlue;
            pnlTitle.Controls.Add(lblDate);
            pnlTitle.Controls.Add(lblHour);
            pnlTitle.Controls.Add(lblTitle);
            pnlTitle.Dock = DockStyle.Top;
            pnlTitle.Location = new Point(0, 0);
            pnlTitle.Name = "pnlTitle";
            pnlTitle.Size = new Size(1394, 111);
            pnlTitle.TabIndex = 4;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDate.Location = new Point(12, 9);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(59, 27);
            lblDate.TabIndex = 3;
            lblDate.Text = "date";
            // 
            // lblHour
            // 
            lblHour.AutoSize = true;
            lblHour.Font = new Font("Arial", 18F);
            lblHour.Location = new Point(12, 45);
            lblHour.Name = "lblHour";
            lblHour.Size = new Size(67, 27);
            lblHour.TabIndex = 2;
            lblHour.Text = "clock";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(590, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(149, 86);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "کافه";
            lblTitle.Click += lblTitle_Click;
            // 
            // pnlDrinks
            // 
            pnlDrinks.BackColor = Color.DodgerBlue;
            pnlDrinks.BorderStyle = BorderStyle.FixedSingle;
            pnlDrinks.Controls.Add(txtCaramelMacchiato_Count);
            pnlDrinks.Controls.Add(txtMilkTea_Count);
            pnlDrinks.Controls.Add(txtIceCoffee_Count);
            pnlDrinks.Controls.Add(txtTea_Count);
            pnlDrinks.Controls.Add(txtLate_Count);
            pnlDrinks.Controls.Add(txtEspresso_Count);
            pnlDrinks.Controls.Add(txtCappuccino_Count);
            pnlDrinks.Controls.Add(txtMocha_Count);
            pnlDrinks.Controls.Add(lblCaramelMacchiato_Cost);
            pnlDrinks.Controls.Add(lblMilkTea_Cost);
            pnlDrinks.Controls.Add(lblIceCoffee_Cost);
            pnlDrinks.Controls.Add(lblTea_Cost);
            pnlDrinks.Controls.Add(lblEspresso_Cost);
            pnlDrinks.Controls.Add(lblMocha_Cost);
            pnlDrinks.Controls.Add(lblCappuccino_Cost);
            pnlDrinks.Controls.Add(lblLate_Cost);
            pnlDrinks.Controls.Add(chbMocha);
            pnlDrinks.Controls.Add(chbCaramelMacchiato);
            pnlDrinks.Controls.Add(chbMilkTea);
            pnlDrinks.Controls.Add(chbIceCoffee);
            pnlDrinks.Controls.Add(chbTea);
            pnlDrinks.Controls.Add(chbEspresso);
            pnlDrinks.Controls.Add(chbCappuccino);
            pnlDrinks.Controls.Add(chbLate);
            pnlDrinks.Location = new Point(884, 117);
            pnlDrinks.Name = "pnlDrinks";
            pnlDrinks.Size = new Size(509, 348);
            pnlDrinks.TabIndex = 5;
            // 
            // txtCaramelMacchiato_Count
            // 
            txtCaramelMacchiato_Count.Font = new Font("Arial", 15.75F);
            txtCaramelMacchiato_Count.Location = new Point(387, 293);
            txtCaramelMacchiato_Count.Name = "txtCaramelMacchiato_Count";
            txtCaramelMacchiato_Count.Size = new Size(100, 32);
            txtCaramelMacchiato_Count.TabIndex = 22;
            txtCaramelMacchiato_Count.Text = "0";
            txtCaramelMacchiato_Count.TextAlign = HorizontalAlignment.Center;
            txtCaramelMacchiato_Count.KeyDown += CountValidating_KeyDown;
            txtCaramelMacchiato_Count.Validated += countChanged;
            // 
            // txtMilkTea_Count
            // 
            txtMilkTea_Count.Font = new Font("Arial", 15.75F);
            txtMilkTea_Count.Location = new Point(387, 254);
            txtMilkTea_Count.Name = "txtMilkTea_Count";
            txtMilkTea_Count.Size = new Size(100, 32);
            txtMilkTea_Count.TabIndex = 21;
            txtMilkTea_Count.Text = "0";
            txtMilkTea_Count.TextAlign = HorizontalAlignment.Center;
            txtMilkTea_Count.KeyDown += CountValidating_KeyDown;
            txtMilkTea_Count.Validated += countChanged;
            // 
            // txtIceCoffee_Count
            // 
            txtIceCoffee_Count.Font = new Font("Arial", 15.75F);
            txtIceCoffee_Count.Location = new Point(387, 215);
            txtIceCoffee_Count.Name = "txtIceCoffee_Count";
            txtIceCoffee_Count.Size = new Size(100, 32);
            txtIceCoffee_Count.TabIndex = 20;
            txtIceCoffee_Count.Text = "0";
            txtIceCoffee_Count.TextAlign = HorizontalAlignment.Center;
            txtIceCoffee_Count.KeyDown += CountValidating_KeyDown;
            txtIceCoffee_Count.Validated += countChanged;
            // 
            // txtTea_Count
            // 
            txtTea_Count.Font = new Font("Arial", 15.75F);
            txtTea_Count.Location = new Point(387, 176);
            txtTea_Count.Name = "txtTea_Count";
            txtTea_Count.Size = new Size(100, 32);
            txtTea_Count.TabIndex = 19;
            txtTea_Count.Text = "0";
            txtTea_Count.TextAlign = HorizontalAlignment.Center;
            txtTea_Count.KeyDown += CountValidating_KeyDown;
            txtTea_Count.Validated += countChanged;
            // 
            // txtLate_Count
            // 
            txtLate_Count.Font = new Font("Arial", 15.75F);
            txtLate_Count.Location = new Point(387, 20);
            txtLate_Count.Name = "txtLate_Count";
            txtLate_Count.Size = new Size(100, 32);
            txtLate_Count.TabIndex = 18;
            txtLate_Count.Text = "0";
            txtLate_Count.TextAlign = HorizontalAlignment.Center;
            txtLate_Count.KeyDown += CountValidating_KeyDown;
            txtLate_Count.Validated += countChanged;
            // 
            // txtEspresso_Count
            // 
            txtEspresso_Count.Font = new Font("Arial", 15.75F);
            txtEspresso_Count.Location = new Point(387, 98);
            txtEspresso_Count.Name = "txtEspresso_Count";
            txtEspresso_Count.Size = new Size(100, 32);
            txtEspresso_Count.TabIndex = 17;
            txtEspresso_Count.Text = "0";
            txtEspresso_Count.TextAlign = HorizontalAlignment.Center;
            txtEspresso_Count.KeyDown += CountValidating_KeyDown;
            txtEspresso_Count.Validated += countChanged;
            // 
            // txtCappuccino_Count
            // 
            txtCappuccino_Count.Font = new Font("Arial", 15.75F);
            txtCappuccino_Count.Location = new Point(387, 59);
            txtCappuccino_Count.Name = "txtCappuccino_Count";
            txtCappuccino_Count.Size = new Size(100, 32);
            txtCappuccino_Count.TabIndex = 16;
            txtCappuccino_Count.Text = "0";
            txtCappuccino_Count.TextAlign = HorizontalAlignment.Center;
            txtCappuccino_Count.KeyDown += CountValidating_KeyDown;
            txtCappuccino_Count.Validated += countChanged;
            // 
            // txtMocha_Count
            // 
            txtMocha_Count.Font = new Font("Arial", 15.75F);
            txtMocha_Count.Location = new Point(387, 137);
            txtMocha_Count.Name = "txtMocha_Count";
            txtMocha_Count.Size = new Size(100, 32);
            txtMocha_Count.TabIndex = 15;
            txtMocha_Count.Text = "0";
            txtMocha_Count.TextAlign = HorizontalAlignment.Center;
            txtMocha_Count.KeyDown += CountValidating_KeyDown;
            txtMocha_Count.Validated += countChanged;
            // 
            // lblCaramelMacchiato_Cost
            // 
            lblCaramelMacchiato_Cost.AutoSize = true;
            lblCaramelMacchiato_Cost.Font = new Font("Arial", 20.25F);
            lblCaramelMacchiato_Cost.Location = new Point(252, 293);
            lblCaramelMacchiato_Cost.Name = "lblCaramelMacchiato_Cost";
            lblCaramelMacchiato_Cost.Size = new Size(86, 32);
            lblCaramelMacchiato_Cost.TabIndex = 14;
            lblCaramelMacchiato_Cost.Text = "label8";
            // 
            // lblMilkTea_Cost
            // 
            lblMilkTea_Cost.AutoSize = true;
            lblMilkTea_Cost.Font = new Font("Arial", 20.25F);
            lblMilkTea_Cost.Location = new Point(252, 254);
            lblMilkTea_Cost.Name = "lblMilkTea_Cost";
            lblMilkTea_Cost.Size = new Size(86, 32);
            lblMilkTea_Cost.TabIndex = 13;
            lblMilkTea_Cost.Text = "label7";
            // 
            // lblIceCoffee_Cost
            // 
            lblIceCoffee_Cost.AutoSize = true;
            lblIceCoffee_Cost.Font = new Font("Arial", 20.25F);
            lblIceCoffee_Cost.Location = new Point(252, 215);
            lblIceCoffee_Cost.Name = "lblIceCoffee_Cost";
            lblIceCoffee_Cost.Size = new Size(86, 32);
            lblIceCoffee_Cost.TabIndex = 12;
            lblIceCoffee_Cost.Text = "label6";
            // 
            // lblTea_Cost
            // 
            lblTea_Cost.AutoSize = true;
            lblTea_Cost.Font = new Font("Arial", 20.25F);
            lblTea_Cost.Location = new Point(252, 176);
            lblTea_Cost.Name = "lblTea_Cost";
            lblTea_Cost.Size = new Size(86, 32);
            lblTea_Cost.TabIndex = 11;
            lblTea_Cost.Text = "label5";
            // 
            // lblEspresso_Cost
            // 
            lblEspresso_Cost.AutoSize = true;
            lblEspresso_Cost.Font = new Font("Arial", 20.25F);
            lblEspresso_Cost.Location = new Point(252, 98);
            lblEspresso_Cost.Name = "lblEspresso_Cost";
            lblEspresso_Cost.Size = new Size(86, 32);
            lblEspresso_Cost.TabIndex = 10;
            lblEspresso_Cost.Text = "label4";
            // 
            // lblMocha_Cost
            // 
            lblMocha_Cost.AutoSize = true;
            lblMocha_Cost.Font = new Font("Arial", 20.25F);
            lblMocha_Cost.Location = new Point(252, 137);
            lblMocha_Cost.Name = "lblMocha_Cost";
            lblMocha_Cost.Size = new Size(86, 32);
            lblMocha_Cost.TabIndex = 9;
            lblMocha_Cost.Text = "label3";
            // 
            // lblCappuccino_Cost
            // 
            lblCappuccino_Cost.AutoSize = true;
            lblCappuccino_Cost.Font = new Font("Arial", 20.25F);
            lblCappuccino_Cost.Location = new Point(252, 59);
            lblCappuccino_Cost.Name = "lblCappuccino_Cost";
            lblCappuccino_Cost.Size = new Size(86, 32);
            lblCappuccino_Cost.TabIndex = 8;
            lblCappuccino_Cost.Text = "label2";
            // 
            // lblLate_Cost
            // 
            lblLate_Cost.AutoSize = true;
            lblLate_Cost.Font = new Font("Arial", 20.25F);
            lblLate_Cost.Location = new Point(252, 20);
            lblLate_Cost.Name = "lblLate_Cost";
            lblLate_Cost.Size = new Size(86, 32);
            lblLate_Cost.TabIndex = 7;
            lblLate_Cost.Text = "label1";
            // 
            // chbMocha
            // 
            chbMocha.AutoSize = true;
            chbMocha.Font = new Font("Arial", 21.75F);
            chbMocha.Location = new Point(15, 135);
            chbMocha.Margin = new Padding(3, 3, 3, 6);
            chbMocha.Name = "chbMocha";
            chbMocha.Size = new Size(174, 37);
            chbMocha.TabIndex = 3;
            chbMocha.Text = "checkBox4";
            chbMocha.UseVisualStyleBackColor = true;
            chbMocha.CheckedChanged += chb_check;
            // 
            // chbCaramelMacchiato
            // 
            chbCaramelMacchiato.AutoSize = true;
            chbCaramelMacchiato.Font = new Font("Arial", 21.75F);
            chbCaramelMacchiato.Location = new Point(15, 291);
            chbCaramelMacchiato.Margin = new Padding(3, 3, 3, 6);
            chbCaramelMacchiato.Name = "chbCaramelMacchiato";
            chbCaramelMacchiato.Size = new Size(174, 37);
            chbCaramelMacchiato.TabIndex = 6;
            chbCaramelMacchiato.Text = "checkBox1";
            chbCaramelMacchiato.UseVisualStyleBackColor = true;
            chbCaramelMacchiato.CheckedChanged += chb_check;
            // 
            // chbMilkTea
            // 
            chbMilkTea.AutoSize = true;
            chbMilkTea.Font = new Font("Arial", 21.75F);
            chbMilkTea.Location = new Point(15, 252);
            chbMilkTea.Margin = new Padding(3, 3, 3, 6);
            chbMilkTea.Name = "chbMilkTea";
            chbMilkTea.Size = new Size(174, 37);
            chbMilkTea.TabIndex = 0;
            chbMilkTea.Text = "checkBox7";
            chbMilkTea.UseVisualStyleBackColor = true;
            chbMilkTea.CheckedChanged += chb_check;
            // 
            // chbIceCoffee
            // 
            chbIceCoffee.AutoSize = true;
            chbIceCoffee.Font = new Font("Arial", 21.75F);
            chbIceCoffee.Location = new Point(15, 213);
            chbIceCoffee.Margin = new Padding(3, 3, 3, 6);
            chbIceCoffee.Name = "chbIceCoffee";
            chbIceCoffee.Size = new Size(174, 37);
            chbIceCoffee.TabIndex = 5;
            chbIceCoffee.Text = "checkBox6";
            chbIceCoffee.UseVisualStyleBackColor = true;
            chbIceCoffee.CheckedChanged += chb_check;
            // 
            // chbTea
            // 
            chbTea.AutoSize = true;
            chbTea.Font = new Font("Arial", 21.75F);
            chbTea.Location = new Point(15, 174);
            chbTea.Margin = new Padding(3, 3, 3, 6);
            chbTea.Name = "chbTea";
            chbTea.Size = new Size(174, 37);
            chbTea.TabIndex = 4;
            chbTea.Text = "checkBox5";
            chbTea.UseVisualStyleBackColor = true;
            chbTea.CheckedChanged += chb_check;
            // 
            // chbEspresso
            // 
            chbEspresso.AutoSize = true;
            chbEspresso.Font = new Font("Arial", 21.75F);
            chbEspresso.Location = new Point(15, 96);
            chbEspresso.Margin = new Padding(3, 3, 3, 6);
            chbEspresso.Name = "chbEspresso";
            chbEspresso.Size = new Size(174, 37);
            chbEspresso.TabIndex = 2;
            chbEspresso.Text = "checkBox3";
            chbEspresso.UseVisualStyleBackColor = true;
            chbEspresso.CheckedChanged += chb_check;
            // 
            // chbCappuccino
            // 
            chbCappuccino.AutoSize = true;
            chbCappuccino.Font = new Font("Arial", 21.75F);
            chbCappuccino.Location = new Point(15, 57);
            chbCappuccino.Margin = new Padding(3, 3, 3, 6);
            chbCappuccino.Name = "chbCappuccino";
            chbCappuccino.Size = new Size(174, 37);
            chbCappuccino.TabIndex = 1;
            chbCappuccino.Text = "checkBox2";
            chbCappuccino.UseVisualStyleBackColor = true;
            chbCappuccino.CheckedChanged += chb_check;
            // 
            // chbLate
            // 
            chbLate.AutoSize = true;
            chbLate.Font = new Font("Arial", 21.75F);
            chbLate.Location = new Point(15, 18);
            chbLate.Margin = new Padding(3, 3, 3, 6);
            chbLate.Name = "chbLate";
            chbLate.Size = new Size(171, 37);
            chbLate.TabIndex = 0;
            chbLate.Text = "checkbox8";
            chbLate.UseVisualStyleBackColor = true;
            chbLate.CheckedChanged += chb_check;
            // 
            // pnlCakes
            // 
            pnlCakes.BackColor = Color.DodgerBlue;
            pnlCakes.Controls.Add(txtCoconutCookie_Count);
            pnlCakes.Controls.Add(txtSmartiesCookie_Count);
            pnlCakes.Controls.Add(txtChocolateCookie_Count);
            pnlCakes.Controls.Add(txtCheeseCake_Count);
            pnlCakes.Controls.Add(txtCoffeeCake_Count);
            pnlCakes.Controls.Add(txtChocolateCake_Count);
            pnlCakes.Controls.Add(txtVanillaCake_Count);
            pnlCakes.Controls.Add(txtWetChocolateCake_Count);
            pnlCakes.Controls.Add(lblCoconutCookie_Cost);
            pnlCakes.Controls.Add(lblSmartiesCookie_Cost);
            pnlCakes.Controls.Add(lblChocolateCookie_Cost);
            pnlCakes.Controls.Add(lblCheeseCake_Cost);
            pnlCakes.Controls.Add(lblChocolateCake_Cost);
            pnlCakes.Controls.Add(lblWetChocolateCake_Cost);
            pnlCakes.Controls.Add(lblVanillaCake_Cost);
            pnlCakes.Controls.Add(lblCoffeeCake_Cost);
            pnlCakes.Controls.Add(chbWetChocolateCake);
            pnlCakes.Controls.Add(chbCoconutCookie);
            pnlCakes.Controls.Add(chbSmartiesCookie);
            pnlCakes.Controls.Add(chbChocolateCookie);
            pnlCakes.Controls.Add(chbCheeseCake);
            pnlCakes.Controls.Add(chbChocolateCake);
            pnlCakes.Controls.Add(chbVanillaCake);
            pnlCakes.Controls.Add(chbCoffeeCake);
            pnlCakes.Location = new Point(369, 117);
            pnlCakes.Name = "pnlCakes";
            pnlCakes.Size = new Size(509, 348);
            pnlCakes.TabIndex = 6;
            // 
            // txtCoconutCookie_Count
            // 
            txtCoconutCookie_Count.Font = new Font("Arial", 15.75F);
            txtCoconutCookie_Count.Location = new Point(390, 294);
            txtCoconutCookie_Count.Name = "txtCoconutCookie_Count";
            txtCoconutCookie_Count.Size = new Size(100, 32);
            txtCoconutCookie_Count.TabIndex = 46;
            txtCoconutCookie_Count.Text = "0";
            txtCoconutCookie_Count.TextAlign = HorizontalAlignment.Center;
            txtCoconutCookie_Count.KeyDown += CountValidating_KeyDown;
            txtCoconutCookie_Count.Validated += countChanged;
            // 
            // txtSmartiesCookie_Count
            // 
            txtSmartiesCookie_Count.Font = new Font("Arial", 15.75F);
            txtSmartiesCookie_Count.Location = new Point(390, 255);
            txtSmartiesCookie_Count.Name = "txtSmartiesCookie_Count";
            txtSmartiesCookie_Count.Size = new Size(100, 32);
            txtSmartiesCookie_Count.TabIndex = 45;
            txtSmartiesCookie_Count.Text = "0";
            txtSmartiesCookie_Count.TextAlign = HorizontalAlignment.Center;
            txtSmartiesCookie_Count.KeyDown += CountValidating_KeyDown;
            txtSmartiesCookie_Count.Validated += countChanged;
            // 
            // txtChocolateCookie_Count
            // 
            txtChocolateCookie_Count.Font = new Font("Arial", 15.75F);
            txtChocolateCookie_Count.Location = new Point(390, 216);
            txtChocolateCookie_Count.Name = "txtChocolateCookie_Count";
            txtChocolateCookie_Count.Size = new Size(100, 32);
            txtChocolateCookie_Count.TabIndex = 44;
            txtChocolateCookie_Count.Text = "0";
            txtChocolateCookie_Count.TextAlign = HorizontalAlignment.Center;
            txtChocolateCookie_Count.KeyDown += CountValidating_KeyDown;
            txtChocolateCookie_Count.Validated += countChanged;
            // 
            // txtCheeseCake_Count
            // 
            txtCheeseCake_Count.Font = new Font("Arial", 15.75F);
            txtCheeseCake_Count.Location = new Point(390, 177);
            txtCheeseCake_Count.Name = "txtCheeseCake_Count";
            txtCheeseCake_Count.Size = new Size(100, 32);
            txtCheeseCake_Count.TabIndex = 43;
            txtCheeseCake_Count.Text = "0";
            txtCheeseCake_Count.TextAlign = HorizontalAlignment.Center;
            txtCheeseCake_Count.KeyDown += CountValidating_KeyDown;
            txtCheeseCake_Count.Validated += countChanged;
            // 
            // txtCoffeeCake_Count
            // 
            txtCoffeeCake_Count.Font = new Font("Arial", 15.75F);
            txtCoffeeCake_Count.Location = new Point(390, 21);
            txtCoffeeCake_Count.Name = "txtCoffeeCake_Count";
            txtCoffeeCake_Count.Size = new Size(100, 32);
            txtCoffeeCake_Count.TabIndex = 42;
            txtCoffeeCake_Count.Text = "0";
            txtCoffeeCake_Count.TextAlign = HorizontalAlignment.Center;
            txtCoffeeCake_Count.KeyDown += CountValidating_KeyDown;
            txtCoffeeCake_Count.Validated += countChanged;
            // 
            // txtChocolateCake_Count
            // 
            txtChocolateCake_Count.Font = new Font("Arial", 15.75F);
            txtChocolateCake_Count.Location = new Point(390, 99);
            txtChocolateCake_Count.Name = "txtChocolateCake_Count";
            txtChocolateCake_Count.Size = new Size(100, 32);
            txtChocolateCake_Count.TabIndex = 41;
            txtChocolateCake_Count.Text = "0";
            txtChocolateCake_Count.TextAlign = HorizontalAlignment.Center;
            txtChocolateCake_Count.KeyDown += CountValidating_KeyDown;
            txtChocolateCake_Count.Validated += countChanged;
            // 
            // txtVanillaCake_Count
            // 
            txtVanillaCake_Count.Font = new Font("Arial", 15.75F);
            txtVanillaCake_Count.Location = new Point(390, 60);
            txtVanillaCake_Count.Name = "txtVanillaCake_Count";
            txtVanillaCake_Count.Size = new Size(100, 32);
            txtVanillaCake_Count.TabIndex = 40;
            txtVanillaCake_Count.Text = "0";
            txtVanillaCake_Count.TextAlign = HorizontalAlignment.Center;
            txtVanillaCake_Count.KeyDown += CountValidating_KeyDown;
            txtVanillaCake_Count.Validated += countChanged;
            // 
            // txtWetChocolateCake_Count
            // 
            txtWetChocolateCake_Count.Font = new Font("Arial", 15.75F);
            txtWetChocolateCake_Count.Location = new Point(390, 138);
            txtWetChocolateCake_Count.Name = "txtWetChocolateCake_Count";
            txtWetChocolateCake_Count.Size = new Size(100, 32);
            txtWetChocolateCake_Count.TabIndex = 39;
            txtWetChocolateCake_Count.Text = "0";
            txtWetChocolateCake_Count.TextAlign = HorizontalAlignment.Center;
            txtWetChocolateCake_Count.KeyDown += CountValidating_KeyDown;
            txtWetChocolateCake_Count.Validated += countChanged;
            // 
            // lblCoconutCookie_Cost
            // 
            lblCoconutCookie_Cost.AutoSize = true;
            lblCoconutCookie_Cost.Font = new Font("Arial", 20.25F);
            lblCoconutCookie_Cost.Location = new Point(255, 294);
            lblCoconutCookie_Cost.Name = "lblCoconutCookie_Cost";
            lblCoconutCookie_Cost.Size = new Size(86, 32);
            lblCoconutCookie_Cost.TabIndex = 38;
            lblCoconutCookie_Cost.Text = "label8";
            // 
            // lblSmartiesCookie_Cost
            // 
            lblSmartiesCookie_Cost.AutoSize = true;
            lblSmartiesCookie_Cost.Font = new Font("Arial", 20.25F);
            lblSmartiesCookie_Cost.Location = new Point(255, 255);
            lblSmartiesCookie_Cost.Name = "lblSmartiesCookie_Cost";
            lblSmartiesCookie_Cost.Size = new Size(86, 32);
            lblSmartiesCookie_Cost.TabIndex = 37;
            lblSmartiesCookie_Cost.Text = "label7";
            // 
            // lblChocolateCookie_Cost
            // 
            lblChocolateCookie_Cost.AutoSize = true;
            lblChocolateCookie_Cost.Font = new Font("Arial", 20.25F);
            lblChocolateCookie_Cost.Location = new Point(255, 216);
            lblChocolateCookie_Cost.Name = "lblChocolateCookie_Cost";
            lblChocolateCookie_Cost.Size = new Size(86, 32);
            lblChocolateCookie_Cost.TabIndex = 36;
            lblChocolateCookie_Cost.Text = "label6";
            // 
            // lblCheeseCake_Cost
            // 
            lblCheeseCake_Cost.AutoSize = true;
            lblCheeseCake_Cost.Font = new Font("Arial", 20.25F);
            lblCheeseCake_Cost.Location = new Point(255, 177);
            lblCheeseCake_Cost.Name = "lblCheeseCake_Cost";
            lblCheeseCake_Cost.Size = new Size(86, 32);
            lblCheeseCake_Cost.TabIndex = 35;
            lblCheeseCake_Cost.Text = "label5";
            // 
            // lblChocolateCake_Cost
            // 
            lblChocolateCake_Cost.AutoSize = true;
            lblChocolateCake_Cost.Font = new Font("Arial", 20.25F);
            lblChocolateCake_Cost.Location = new Point(255, 99);
            lblChocolateCake_Cost.Name = "lblChocolateCake_Cost";
            lblChocolateCake_Cost.Size = new Size(86, 32);
            lblChocolateCake_Cost.TabIndex = 34;
            lblChocolateCake_Cost.Text = "label4";
            // 
            // lblWetChocolateCake_Cost
            // 
            lblWetChocolateCake_Cost.AutoSize = true;
            lblWetChocolateCake_Cost.Font = new Font("Arial", 20.25F);
            lblWetChocolateCake_Cost.Location = new Point(255, 138);
            lblWetChocolateCake_Cost.Name = "lblWetChocolateCake_Cost";
            lblWetChocolateCake_Cost.Size = new Size(86, 32);
            lblWetChocolateCake_Cost.TabIndex = 33;
            lblWetChocolateCake_Cost.Text = "label3";
            // 
            // lblVanillaCake_Cost
            // 
            lblVanillaCake_Cost.AutoSize = true;
            lblVanillaCake_Cost.Font = new Font("Arial", 20.25F);
            lblVanillaCake_Cost.Location = new Point(255, 60);
            lblVanillaCake_Cost.Name = "lblVanillaCake_Cost";
            lblVanillaCake_Cost.Size = new Size(86, 32);
            lblVanillaCake_Cost.TabIndex = 32;
            lblVanillaCake_Cost.Text = "label2";
            // 
            // lblCoffeeCake_Cost
            // 
            lblCoffeeCake_Cost.AutoSize = true;
            lblCoffeeCake_Cost.Font = new Font("Arial", 20.25F);
            lblCoffeeCake_Cost.Location = new Point(255, 21);
            lblCoffeeCake_Cost.Name = "lblCoffeeCake_Cost";
            lblCoffeeCake_Cost.Size = new Size(86, 32);
            lblCoffeeCake_Cost.TabIndex = 31;
            lblCoffeeCake_Cost.Text = "label1";
            // 
            // chbWetChocolateCake
            // 
            chbWetChocolateCake.AutoSize = true;
            chbWetChocolateCake.Font = new Font("Arial", 21.75F);
            chbWetChocolateCake.Location = new Point(18, 136);
            chbWetChocolateCake.Margin = new Padding(3, 3, 3, 6);
            chbWetChocolateCake.Name = "chbWetChocolateCake";
            chbWetChocolateCake.Size = new Size(281, 37);
            chbWetChocolateCake.TabIndex = 27;
            chbWetChocolateCake.Text = "wet chocolate cake";
            chbWetChocolateCake.UseVisualStyleBackColor = true;
            chbWetChocolateCake.CheckedChanged += chb_check;
            // 
            // chbCoconutCookie
            // 
            chbCoconutCookie.AutoSize = true;
            chbCoconutCookie.Font = new Font("Arial", 21.75F);
            chbCoconutCookie.Location = new Point(18, 292);
            chbCoconutCookie.Margin = new Padding(3, 3, 3, 6);
            chbCoconutCookie.Name = "chbCoconutCookie";
            chbCoconutCookie.Size = new Size(262, 37);
            chbCoconutCookie.TabIndex = 30;
            chbCoconutCookie.Text = "Coconut COOKIE";
            chbCoconutCookie.UseVisualStyleBackColor = true;
            chbCoconutCookie.CheckedChanged += chb_check;
            // 
            // chbSmartiesCookie
            // 
            chbSmartiesCookie.AutoSize = true;
            chbSmartiesCookie.Font = new Font("Arial", 21.75F);
            chbSmartiesCookie.Location = new Point(18, 253);
            chbSmartiesCookie.Margin = new Padding(3, 3, 3, 6);
            chbSmartiesCookie.Name = "chbSmartiesCookie";
            chbSmartiesCookie.Size = new Size(242, 37);
            chbSmartiesCookie.TabIndex = 24;
            chbSmartiesCookie.Text = "Smarties cookie";
            chbSmartiesCookie.UseVisualStyleBackColor = true;
            chbSmartiesCookie.CheckedChanged += chb_check;
            // 
            // chbChocolateCookie
            // 
            chbChocolateCookie.AutoSize = true;
            chbChocolateCookie.Font = new Font("Arial", 21.75F);
            chbChocolateCookie.Location = new Point(18, 214);
            chbChocolateCookie.Margin = new Padding(3, 3, 3, 6);
            chbChocolateCookie.Name = "chbChocolateCookie";
            chbChocolateCookie.Size = new Size(251, 37);
            chbChocolateCookie.TabIndex = 29;
            chbChocolateCookie.Text = "chocolate cookie";
            chbChocolateCookie.UseVisualStyleBackColor = true;
            chbChocolateCookie.CheckedChanged += chb_check;
            // 
            // chbCheeseCake
            // 
            chbCheeseCake.AutoSize = true;
            chbCheeseCake.Font = new Font("Arial", 21.75F);
            chbCheeseCake.Location = new Point(18, 175);
            chbCheeseCake.Margin = new Padding(3, 3, 3, 6);
            chbCheeseCake.Name = "chbCheeseCake";
            chbCheeseCake.Size = new Size(197, 37);
            chbCheeseCake.TabIndex = 28;
            chbCheeseCake.Text = "cheese cake";
            chbCheeseCake.UseVisualStyleBackColor = true;
            chbCheeseCake.CheckedChanged += chb_check;
            // 
            // chbChocolateCake
            // 
            chbChocolateCake.AutoSize = true;
            chbChocolateCake.Font = new Font("Arial", 21.75F);
            chbChocolateCake.Location = new Point(18, 97);
            chbChocolateCake.Margin = new Padding(3, 3, 3, 6);
            chbChocolateCake.Name = "chbChocolateCake";
            chbChocolateCake.Size = new Size(228, 37);
            chbChocolateCake.TabIndex = 26;
            chbChocolateCake.Text = "chocolate cake";
            chbChocolateCake.UseVisualStyleBackColor = true;
            chbChocolateCake.CheckedChanged += chb_check;
            // 
            // chbVanillaCake
            // 
            chbVanillaCake.AutoSize = true;
            chbVanillaCake.Font = new Font("Arial", 21.75F);
            chbVanillaCake.Location = new Point(18, 58);
            chbVanillaCake.Margin = new Padding(3, 3, 3, 6);
            chbVanillaCake.Name = "chbVanillaCake";
            chbVanillaCake.Size = new Size(185, 37);
            chbVanillaCake.TabIndex = 25;
            chbVanillaCake.Text = "vanilla cake";
            chbVanillaCake.UseVisualStyleBackColor = true;
            chbVanillaCake.CheckedChanged += chb_check;
            // 
            // chbCoffeeCake
            // 
            chbCoffeeCake.AutoSize = true;
            chbCoffeeCake.Font = new Font("Arial", 21.75F);
            chbCoffeeCake.Location = new Point(18, 19);
            chbCoffeeCake.Margin = new Padding(3, 3, 3, 6);
            chbCoffeeCake.Name = "chbCoffeeCake";
            chbCoffeeCake.Size = new Size(187, 37);
            chbCoffeeCake.TabIndex = 23;
            chbCoffeeCake.Text = "Coffee cake";
            chbCoffeeCake.UseVisualStyleBackColor = true;
            chbCoffeeCake.CheckedChanged += chb_check;
            // 
            // pnlCost1
            // 
            pnlCost1.BackColor = Color.DodgerBlue;
            pnlCost1.Controls.Add(txtSumOfOrder);
            pnlCost1.Controls.Add(txtDrinksCost);
            pnlCost1.Controls.Add(txtCakesCost);
            pnlCost1.Controls.Add(lblSumOfOrder);
            pnlCost1.Controls.Add(lblDrinksCost);
            pnlCost1.Controls.Add(lblCakesCost);
            pnlCost1.Location = new Point(884, 471);
            pnlCost1.Name = "pnlCost1";
            pnlCost1.Size = new Size(509, 171);
            pnlCost1.TabIndex = 7;
            // 
            // txtSumOfOrder
            // 
            txtSumOfOrder.Font = new Font("Arial", 21.75F, FontStyle.Bold);
            txtSumOfOrder.Location = new Point(268, 116);
            txtSumOfOrder.Name = "txtSumOfOrder";
            txtSumOfOrder.ReadOnly = true;
            txtSumOfOrder.Size = new Size(157, 41);
            txtSumOfOrder.TabIndex = 5;
            txtSumOfOrder.Text = "0";
            // 
            // txtDrinksCost
            // 
            txtDrinksCost.Font = new Font("Arial", 21.75F, FontStyle.Bold);
            txtDrinksCost.Location = new Point(268, 61);
            txtDrinksCost.Name = "txtDrinksCost";
            txtDrinksCost.ReadOnly = true;
            txtDrinksCost.Size = new Size(157, 41);
            txtDrinksCost.TabIndex = 4;
            txtDrinksCost.Text = "0";
            // 
            // txtCakesCost
            // 
            txtCakesCost.Font = new Font("Arial", 21.75F, FontStyle.Bold);
            txtCakesCost.Location = new Point(268, 6);
            txtCakesCost.Name = "txtCakesCost";
            txtCakesCost.ReadOnly = true;
            txtCakesCost.Size = new Size(157, 41);
            txtCakesCost.TabIndex = 3;
            txtCakesCost.Text = "0";
            // 
            // lblSumOfOrder
            // 
            lblSumOfOrder.AutoSize = true;
            lblSumOfOrder.Font = new Font("Arial", 20.25F, FontStyle.Bold);
            lblSumOfOrder.Location = new Point(34, 121);
            lblSumOfOrder.Name = "lblSumOfOrder";
            lblSumOfOrder.Size = new Size(170, 32);
            lblSumOfOrder.TabIndex = 2;
            lblSumOfOrder.Text = "مجموع سفارش :";
            // 
            // lblDrinksCost
            // 
            lblDrinksCost.AutoSize = true;
            lblDrinksCost.Font = new Font("Arial", 20.25F, FontStyle.Bold);
            lblDrinksCost.Location = new Point(38, 66);
            lblDrinksCost.Name = "lblDrinksCost";
            lblDrinksCost.Size = new Size(163, 32);
            lblDrinksCost.TabIndex = 1;
            lblDrinksCost.Text = "هزینه نوشیدنی :";
            // 
            // lblCakesCost
            // 
            lblCakesCost.AutoSize = true;
            lblCakesCost.Font = new Font("Arial", 20.25F, FontStyle.Bold);
            lblCakesCost.Location = new Point(36, 11);
            lblCakesCost.Name = "lblCakesCost";
            lblCakesCost.Size = new Size(166, 32);
            lblCakesCost.TabIndex = 0;
            lblCakesCost.Text = " هزینه کیک ها :";
            // 
            // pnlCost2
            // 
            pnlCost2.BackColor = Color.DodgerBlue;
            pnlCost2.Controls.Add(txtServices);
            pnlCost2.Controls.Add(btnDiscount);
            pnlCost2.Controls.Add(txtTax);
            pnlCost2.Controls.Add(lblServiceCharge);
            pnlCost2.Controls.Add(lblDiscount);
            pnlCost2.Controls.Add(txtDiscount);
            pnlCost2.Controls.Add(lblTax);
            pnlCost2.Location = new Point(369, 471);
            pnlCost2.Name = "pnlCost2";
            pnlCost2.Size = new Size(509, 171);
            pnlCost2.TabIndex = 8;
            // 
            // txtServices
            // 
            txtServices.Font = new Font("Arial", 21.75F, FontStyle.Bold);
            txtServices.Location = new Point(232, 60);
            txtServices.Name = "txtServices";
            txtServices.ReadOnly = true;
            txtServices.Size = new Size(156, 41);
            txtServices.TabIndex = 4;
            txtServices.Text = "0";
            // 
            // btnDiscount
            // 
            btnDiscount.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDiscount.Location = new Point(369, 107);
            btnDiscount.Name = "btnDiscount";
            btnDiscount.Size = new Size(137, 40);
            btnDiscount.TabIndex = 2;
            btnDiscount.Text = "ثبت تخفیف";
            btnDiscount.UseVisualStyleBackColor = true;
            btnDiscount.Click += btnDiscount_Click;
            // 
            // txtTax
            // 
            txtTax.Font = new Font("Arial", 21.75F, FontStyle.Bold);
            txtTax.Location = new Point(232, 7);
            txtTax.Name = "txtTax";
            txtTax.ReadOnly = true;
            txtTax.Size = new Size(156, 41);
            txtTax.TabIndex = 3;
            txtTax.Text = "0";
            // 
            // lblServiceCharge
            // 
            lblServiceCharge.AutoSize = true;
            lblServiceCharge.Font = new Font("Arial", 20.25F, FontStyle.Bold);
            lblServiceCharge.Location = new Point(50, 65);
            lblServiceCharge.Name = "lblServiceCharge";
            lblServiceCharge.Size = new Size(90, 32);
            lblServiceCharge.TabIndex = 1;
            lblServiceCharge.Text = "خدمات :";
            // 
            // lblDiscount
            // 
            lblDiscount.AutoSize = true;
            lblDiscount.Font = new Font("Arial", 21.75F, FontStyle.Bold);
            lblDiscount.Location = new Point(43, 116);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(158, 34);
            lblDiscount.TabIndex = 0;
            lblDiscount.Text = "درصد تخفیف :";
            // 
            // txtDiscount
            // 
            txtDiscount.Font = new Font("Arial", 21.75F, FontStyle.Bold);
            txtDiscount.Location = new Point(232, 109);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(115, 41);
            txtDiscount.TabIndex = 1;
            txtDiscount.Text = "0";
            // 
            // lblTax
            // 
            lblTax.AutoSize = true;
            lblTax.Font = new Font("Arial", 20.25F, FontStyle.Bold);
            lblTax.Location = new Point(50, 16);
            lblTax.Name = "lblTax";
            lblTax.Size = new Size(86, 32);
            lblTax.TabIndex = 0;
            lblTax.Text = "مالیات :";
            // 
            // txtTotal
            // 
            txtTotal.Font = new Font("Arial", 21.75F, FontStyle.Bold);
            txtTotal.Location = new Point(624, 43);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(156, 41);
            txtTotal.TabIndex = 5;
            txtTotal.Text = "0";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(387, 43);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(219, 37);
            lblTotal.TabIndex = 2;
            lblTotal.Text = "مبلغ قابل پرداخت :";
            lblTotal.Click += lblTotal_Click;
            // 
            // pnlButton
            // 
            pnlButton.BackColor = Color.DodgerBlue;
            pnlButton.Controls.Add(btnReceipt);
            pnlButton.Controls.Add(lblTotal);
            pnlButton.Controls.Add(txtTotal);
            pnlButton.Controls.Add(btnReset);
            pnlButton.Controls.Add(btnReCalculate);
            pnlButton.Dock = DockStyle.Bottom;
            pnlButton.Location = new Point(0, 651);
            pnlButton.Name = "pnlButton";
            pnlButton.Size = new Size(1394, 124);
            pnlButton.TabIndex = 10;
            // 
            // btnReceipt
            // 
            btnReceipt.Font = new Font("Arial", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReceipt.Location = new Point(962, 30);
            btnReceipt.Name = "btnReceipt";
            btnReceipt.Size = new Size(123, 67);
            btnReceipt.TabIndex = 6;
            btnReceipt.Text = "فاکتور";
            btnReceipt.UseVisualStyleBackColor = true;
            btnReceipt.Click += btnReceipt_Click;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Arial", 20.25F);
            btnReset.Location = new Point(1094, 30);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(123, 67);
            btnReset.TabIndex = 1;
            btnReset.Text = "ریست";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnReCalculate
            // 
            btnReCalculate.Font = new Font("Arial", 20.25F);
            btnReCalculate.Location = new Point(1223, 30);
            btnReCalculate.Name = "btnReCalculate";
            btnReCalculate.Size = new Size(149, 67);
            btnReCalculate.TabIndex = 0;
            btnReCalculate.Text = "محاسبه دوباره";
            btnReCalculate.UseVisualStyleBackColor = true;
            btnReCalculate.Click += btnReCalculate_Click;
            // 
            // tmrMain
            // 
            tmrMain.Enabled = true;
            tmrMain.Interval = 500;
            tmrMain.Tick += tmrMain_Tick;
            // 
            // frmBilling
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1394, 775);
            Controls.Add(pnlButton);
            Controls.Add(pnlCost2);
            Controls.Add(pnlCost1);
            Controls.Add(pnlCakes);
            Controls.Add(pnlDrinks);
            Controls.Add(pnlTitle);
            IsMdiContainer = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmBilling";
            Text = "Cafe Billing System";
            FormClosed += frmBilling_FormClosed;
            Load += frmBilling_Load;
            pnlTitle.ResumeLayout(false);
            pnlTitle.PerformLayout();
            pnlDrinks.ResumeLayout(false);
            pnlDrinks.PerformLayout();
            pnlCakes.ResumeLayout(false);
            pnlCakes.PerformLayout();
            pnlCost1.ResumeLayout(false);
            pnlCost1.PerformLayout();
            pnlCost2.ResumeLayout(false);
            pnlCost2.PerformLayout();
            pnlButton.ResumeLayout(false);
            pnlButton.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlTitle;
        private Label lblTitle;
        private Panel pnlDrinks;
        private Panel pnlCakes;
        private Panel pnlCost1;
        private Panel pnlCost2;
        private Panel pnlButton;
        private CheckBox chbIceCoffee;
        private CheckBox chbTea;
        private CheckBox chbMocha;
        private CheckBox chbEspresso;
        private CheckBox chbCappuccino;
        private CheckBox chbLate;
        private CheckBox chbMilkTea;
        private CheckBox chbCaramelMacchiato;
        private Label lblCaramelMacchiato_Cost;
        private Label lblMilkTea_Cost;
        private Label lblIceCoffee_Cost;
        private Label lblTea_Cost;
        private Label lblEspresso_Cost;
        private Label lblMocha_Cost;
        private Label lblCappuccino_Cost;
        private Label lblLate_Cost;
        private TextBox txtCaramelMacchiato_Count;
        private TextBox txtMilkTea_Count;
        private TextBox txtIceCoffee_Count;
        private TextBox txtTea_Count;
        private TextBox txtLate_Count;
        private TextBox txtEspresso_Count;
        private TextBox txtCappuccino_Count;
        private TextBox txtMocha_Count;
        private TextBox txtCoconutCookie_Count;
        private TextBox txtSmartiesCookie_Count;
        private TextBox txtChocolateCookie_Count;
        private TextBox txtCheeseCake_Count;
        private TextBox txtCoffeeCake_Count;
        private TextBox txtChocolateCake_Count;
        private TextBox txtVanillaCake_Count;
        private TextBox txtWetChocolateCake_Count;
        private Label lblCoconutCookie_Cost;
        private Label lblSmartiesCookie_Cost;
        private Label lblChocolateCookie_Cost;
        private Label lblCheeseCake_Cost;
        private Label lblChocolateCake_Cost;
        private Label lblWetChocolateCake_Cost;
        private Label lblVanillaCake_Cost;
        private Label lblCoffeeCake_Cost;
        private CheckBox chbWetChocolateCake;
        private CheckBox chbCoconutCookie;
        private CheckBox chbSmartiesCookie;
        private CheckBox chbChocolateCookie;
        private CheckBox chbCheeseCake;
        private CheckBox chbChocolateCake;
        private CheckBox chbVanillaCake;
        private CheckBox chbCoffeeCake;
        private Button btnReCalculate;
        private Label lblDrinksCost;
        private Label lblCakesCost;
        private Label lblSumOfOrder;
        private Label lblTotal;
        private Label lblServiceCharge;
        private Label lblTax;
        private TextBox txtSumOfOrder;
        private TextBox txtDrinksCost;
        private TextBox txtCakesCost;
        private TextBox txtTotal;
        private TextBox txtServices;
        private TextBox txtTax;
        private Button btnReset;
        private Label lblHour;
        private System.Windows.Forms.Timer tmrMain;
        private Label lblDate;
        private Button btnDiscount;
        private TextBox txtDiscount;
        private Label lblDiscount;
        private Button btnReceipt;
    }
}



