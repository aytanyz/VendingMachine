using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VendingMachine
{
    public partial class Basket : Form
    {
        public static int len = DB.len;
        public static int len_discount = DB.len_discount;
        public int[] amount = new int[len];
        public int discount;

        public Basket()
        {    


            InitializeComponent();
            
            int drinkPanel_height = 100;
            int drinkPanel_margin = 20;
            int start = 0;

            for (int i=0; i<len; i++)
            {
                if(DB.drinkList[i].isSelected)
                {
                    amount[i] = 1;

                    Panel drink_panel = new Panel();
                    PictureBox drink_icon = new PictureBox();
                    Label drink_title = new Label();
                    Label drink_price = new Label();
                    NumericUpDown drink_numericUpDown = new NumericUpDown();
                    Label drink_text = new Label();

                    //Panel
                    drink_panel.Controls.Add(drink_numericUpDown);
                    drink_panel.Controls.Add(drink_title);
                    drink_panel.Controls.Add(drink_price);
                    drink_panel.Controls.Add(drink_icon);
                    drink_panel.Controls.Add(drink_text);

                    drink_panel.BorderStyle = BorderStyle.FixedSingle;
                    int drinkPanel_x = 40;
                    int drinkPanel_y = 100 + start * (drinkPanel_margin + drinkPanel_height);
                    drink_panel.Location = new System.Drawing.Point(drinkPanel_x, drinkPanel_y);
                    drink_panel.Name = "drinkPanel" + i.ToString();
                    drink_panel.Size = new System.Drawing.Size(590, 100);
                    drink_panel.TabIndex = 9;

                    // Title
                    //drink_title.Dock = System.Windows.Forms.DockStyle.Fill;
                    drink_title.AutoSize = true;
                    drink_title.Font = new Font("Comic Sans MS", 11, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                    drink_title.Location = new System.Drawing.Point(120, 25);
                    drink_title.Name = "drinkTitle" + i.ToString();
                    drink_title.Size = new System.Drawing.Size(200, 30);
                    drink_title.TabIndex = 9;
                    drink_title.Text = DB.drinkList[i].name;

                    // Price
                    //drink_price.Dock = System.Windows.Forms.DockStyle.Right;
                    drink_price.AutoSize = true;
                    drink_price.Location = new System.Drawing.Point(250, 65);
                    drink_price.Name = "drinkPrice" + i.ToString();
                    drink_price.Size = new System.Drawing.Size(90, 25);
                    drink_price.TabIndex = 10;
                    drink_price.Text = (DB.drinkList[i].price).ToString() + " euro";

                    // Icon
                    drink_icon.Dock = System.Windows.Forms.DockStyle.Left;
                    drink_icon.Image = (Image)Properties.Resources.ResourceManager.GetObject(DB.drinkList[i].iconName);
                    drink_icon.Location = new System.Drawing.Point(0, 0);
                    drink_icon.Name = "drinkIcon" + i.ToString();
                    drink_icon.Size = new System.Drawing.Size(100, 100);
                    drink_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                    drink_icon.TabIndex = 8;
                    drink_icon.TabStop = false;

                    // Numeric up down pattern
                    drink_numericUpDown.Location = new System.Drawing.Point(350, 40);
                    drink_numericUpDown.Size = new System.Drawing.Size(40, 60);
                    drink_numericUpDown.Name = "drinkUpDown" + i.ToString();
                    drink_numericUpDown.Value = amount[i];
                    drink_numericUpDown.Minimum = 1;
                    var idx = i;
                    drink_numericUpDown.ValueChanged += new System.EventHandler((sender2, e2) => upDown_Click(drink_numericUpDown, drink_panel.Name, drink_text.Name, idx));

                    // Shows the text
                    drink_text.Location = new System.Drawing.Point(410, 40);
                    drink_text.Name = "drinkText" + i.ToString();
                    drink_text.Text = "";
                                        
                    start++;
                    this.Controls.Add(drink_panel);
                }
            }

            calculateTotal();
        }

        public void upDown_Click(NumericUpDown drink_UpDown_name, string panel_name, string drink_text_name, int idx)
        {

            double sum = totalCost_choosenDrink(drink_UpDown_name.Value, idx);            

            this.Controls[panel_name].Controls[drink_text_name].Text = sum.ToString() + " euro";
            amount[idx] = Decimal.ToInt32(drink_UpDown_name.Value);

            calculateTotal();
        }

        public double totalCost_choosenDrink(Decimal drink_UpDown_value, int idx)
        {
            return Math.Round((Decimal.ToInt32(drink_UpDown_value) * DB.drinkList[idx].price), 2);
        }

        public double getSubtotal()
        {
            double subtotal = 0;
            for (int i = 0; i < len; i++)
            {
                if (DB.drinkList[i].isSelected)
                    subtotal += amount[i] * DB.drinkList[i].price;
            }
            return Math.Round(subtotal, 2);
        }

        public double getTotal(double subtotal)
        {
            if (discount != 0)
                return Math.Round((subtotal * (100 - discount) / 100), 2);
            else
                return Math.Round((subtotal), 2);
        }

        public string getDiscountAmount(double subtotal)
        {
            if (discount != 0)
                return "-" + Math.Round((subtotal * discount / 100), 2).ToString() + " euro";
            else
                return "";
        }

        public void toggle_PayCash(double total)
        {
            if(total > 10)
            {
                payCash_button.Enabled = false;
                note_text.Text = "Cash payment is only aviable for orders less than 10 euro!";
                note_text1.Text = "Please pay with card!";
            }
            else 
            {
                payCash_button.Enabled = true;
                note_text.Text = "";
                note_text1.Text = "";
            }
        }

        public void calculateTotal()
        {
            double subtotal = getSubtotal();
            double total_amount = getTotal(subtotal);
            string discount_text = getDiscountAmount(subtotal);

            sub_total.Text = subtotal.ToString() + " euro";
            total.Text = total_amount.ToString() + " euro";
            discount_amount.Text = discount_text;

            toggle_PayCash(total_amount);
        }

        public bool check_discountCode()
        {
            for (int i = 0; i < len_discount; i++)
            {
                if (discount_code.Text == DB.discountList[i].discount_code)
                {
                    discount = DB.discountList[i].discount_percentage;
                    calculateTotal();
                    return true;
                }
            }
            discount = 0;
            return false;
        }

        public void discount_button_Click(object sender, EventArgs e)
        {
            if(check_discountCode())
                calculateTotal();
            else
                MessageBox.Show("Invalid code!");
        }

        public void back_button_Click(object sender, EventArgs e)
        {
            resetAll();
            HomePage openForm = new HomePage();
            openForm.Show();
            this.Hide();
        }

        public void resetAll()
        {
            for (int i = 0; i < len; i++)
                DB.drinkList[i].isSelected = false;
        }

        public void payCard_button_Click(object sender, EventArgs e)
        {
            OrderReady openForm = new OrderReady();
            openForm.Show();
            this.Hide();
        }

        public void payCash_button_Click(object sender, EventArgs e)
        {
            OrderReady openForm = new OrderReady();
            openForm.Show();
            this.Hide();
        }

        public void Basket_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
