using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;

namespace VendingMachine
{
    public partial class HomePage : Form
    {
        public static int len = DB.len;
        public static int len_discount = DB.len_discount;
        
        public HomePage()
        {   
                        
            InitializeComponent();
           
            int drinkPanel_height = 100;
            int drinkPanel_margin = 20;
          
            for (int i = 0; i < len; i++)
            {
                Panel drink_panel = new Panel();
                PictureBox drink_icon = new PictureBox();
                Label drink_title = new Label();
                Label drink_price = new Label();
                Panel drink_select_box = new Panel();

                // Panel
                // Panel contains the icon, price and the name of drink.
                drink_panel.Controls.Add(drink_title);
                drink_panel.Controls.Add(drink_price);
                drink_panel.Controls.Add(drink_icon);
                drink_panel.Controls.Add(drink_select_box);

                drink_panel.BorderStyle = BorderStyle.FixedSingle;
                int drinkPanel_x = 60;
                int drinkPanel_y = 100 + i * (drinkPanel_margin + drinkPanel_height);
                drink_panel.Location = new System.Drawing.Point(drinkPanel_x, drinkPanel_y);
                drink_panel.Name = "drinkPanel" + i.ToString();
                drink_panel.Size = new System.Drawing.Size(350, 100);
                drink_panel.TabIndex = 9;
                var idx = i;
                drink_panel.Click += new System.EventHandler((sender2, e2) => ToggleDrink(idx, drink_panel.Name, drink_select_box.Name));

                // Title
                // Label that contains the name of drink.
                drink_title.AutoSize = true;
                drink_title.Font = new Font("Comic Sans MS", 11, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                drink_title.Location = new System.Drawing.Point(120, 25);
                drink_title.Name = "drinkTitle" + i.ToString();
                drink_title.Size = new System.Drawing.Size(200, 30);
                drink_title.TabIndex = 9;
                drink_title.Text = DB.drinkList[i].name;

                // Price
                // Label that contains the price of drink.
                drink_price.AutoSize = true;
                drink_price.Location = new System.Drawing.Point(250, 65);
                drink_price.Name = "drinkPrice" + i.ToString();
                drink_price.Size = new System.Drawing.Size(90, 25);
                drink_price.TabIndex = 10;
                drink_price.Text = (DB.drinkList[i].price).ToString() + " euro";

                // Icon
                // PictureBox that contains the icon of drink.
                drink_icon.Dock = System.Windows.Forms.DockStyle.Left;
                drink_icon.Image = (Image)Properties.Resources.ResourceManager.GetObject(DB.drinkList[i].iconName);
                drink_icon.Location = new System.Drawing.Point(0, 0);
                drink_icon.Name = "drinkIcon" + i.ToString();
                drink_icon.Size = new System.Drawing.Size(100, 100);
                drink_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                drink_icon.TabIndex = 8;
                drink_icon.TabStop = false;

                // Select box
                // Panel that shows if the drink is selected or not.
                drink_select_box.BorderStyle = BorderStyle.FixedSingle;
                drink_select_box.BackColor = System.Drawing.Color.White;
                drink_select_box.Location = new System.Drawing.Point(330, 80);
                drink_select_box.Name = "drinkSelectBox" + i.ToString();
                drink_select_box.Size = new System.Drawing.Size(20, 20);
                drink_select_box.TabIndex = 9;

                this.Controls.Add(drink_panel);

                toggleButton_Next();
            }
        }

        // When drink is selected or unselected the color of panel that panel is changed respectively,
        // marks the drink as selected or unselected,
        // depending on how many drinks were chosen the Next bbutton is enabled or disabeled.
        public void ToggleDrink(int idx, string panel_name, string selected_box_name)
        {
            change_color_panel(idx, panel_name, selected_box_name);
            change_value_isSelected(idx);
            toggleButton_Next();
        }

        public void change_color_panel(int idx, string panel_name, string selected_box_name)
        {
            if (DB.drinkList[idx].isSelected)
            {
                this.Controls[panel_name].BackColor = System.Drawing.Color.Transparent;
                this.Controls[panel_name].Controls[selected_box_name].BackColor = System.Drawing.Color.White;
            }
            else
            {
                this.Controls[panel_name].BackColor = System.Drawing.Color.White;
                this.Controls[panel_name].Controls[selected_box_name].BackColor = System.Drawing.Color.SkyBlue;
            }
        }

        public void change_value_isSelected(int idx)
        {
            DB.drinkList[idx].isSelected = !DB.drinkList[idx].isSelected;
        }

        public void next_button_Click(object sender, EventArgs e)
        {
            Basket openForm = new Basket();
            openForm.Show();
            this.Hide();
        }

        public void toggleButton_Next()
        {
            for (int i = 0; i < len; i++)
            {
                if (DB.drinkList[i].isSelected)
                {
                    next_button.Enabled = true;
                    next_button.BackColor = System.Drawing.Color.White;
                    return;
                }
            }
            next_button.Enabled = false;
            next_button.BackColor = System.Drawing.Color.Transparent;
        }

        public void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
