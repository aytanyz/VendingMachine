
namespace VendingMachine
{
    partial class Basket
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
            this.label2 = new System.Windows.Forms.Label();
            this.sub_total = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.discount_code = new System.Windows.Forms.TextBox();
            this.discount_button = new System.Windows.Forms.Button();
            this.discount_amount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.back_button = new System.Windows.Forms.Button();
            this.payCash_button = new System.Windows.Forms.Button();
            this.payCard_button = new System.Windows.Forms.Button();
            this.note_text = new System.Windows.Forms.Label();
            this.note_text1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(108)))), ((int)(((byte)(77)))));
            this.label1.Location = new System.Drawing.Point(141, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 64);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose the amount of drinks . . .\r\n\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 597);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Subtotal:";
            // 
            // sub_total
            // 
            this.sub_total.AutoSize = true;
            this.sub_total.Location = new System.Drawing.Point(138, 597);
            this.sub_total.Name = "sub_total";
            this.sub_total.Size = new System.Drawing.Size(22, 25);
            this.sub_total.TabIndex = 3;
            this.sub_total.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 638);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Discount Code";
            // 
            // discount_code
            // 
            this.discount_code.Location = new System.Drawing.Point(184, 636);
            this.discount_code.Name = "discount_code";
            this.discount_code.Size = new System.Drawing.Size(150, 31);
            this.discount_code.TabIndex = 5;
            // 
            // discount_button
            // 
            this.discount_button.BackColor = System.Drawing.Color.LimeGreen;
            this.discount_button.Location = new System.Drawing.Point(332, 635);
            this.discount_button.Name = "discount_button";
            this.discount_button.Size = new System.Drawing.Size(84, 34);
            this.discount_button.TabIndex = 6;
            this.discount_button.Text = "Apply";
            this.discount_button.UseVisualStyleBackColor = false;
            this.discount_button.Click += new System.EventHandler(this.discount_button_Click);
            // 
            // discount_amount
            // 
            this.discount_amount.AutoSize = true;
            this.discount_amount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.discount_amount.Location = new System.Drawing.Point(250, 597);
            this.discount_amount.Name = "discount_amount";
            this.discount_amount.Size = new System.Drawing.Size(0, 25);
            this.discount_amount.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 683);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Total:";
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Location = new System.Drawing.Point(137, 683);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(22, 25);
            this.total.TabIndex = 3;
            this.total.Text = "0";
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(94, 762);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(112, 34);
            this.back_button.TabIndex = 8;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // payCash_button
            // 
            this.payCash_button.Location = new System.Drawing.Point(470, 762);
            this.payCash_button.Name = "payCash_button";
            this.payCash_button.Size = new System.Drawing.Size(112, 34);
            this.payCash_button.TabIndex = 9;
            this.payCash_button.Text = "Pay cash";
            this.payCash_button.UseVisualStyleBackColor = true;
            this.payCash_button.Click += new System.EventHandler(this.payCash_button_Click);
            // 
            // payCard_button
            // 
            this.payCard_button.Location = new System.Drawing.Point(280, 762);
            this.payCard_button.Name = "payCard_button";
            this.payCard_button.Size = new System.Drawing.Size(136, 34);
            this.payCard_button.TabIndex = 9;
            this.payCard_button.Text = "Pay with card";
            this.payCard_button.UseVisualStyleBackColor = true;
            this.payCard_button.Click += new System.EventHandler(this.payCard_button_Click);
            // 
            // note_text
            // 
            this.note_text.AutoSize = true;
            this.note_text.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.note_text.ForeColor = System.Drawing.Color.DarkOrange;
            this.note_text.Location = new System.Drawing.Point(250, 683);
            this.note_text.Name = "note_text";
            this.note_text.Size = new System.Drawing.Size(45, 19);
            this.note_text.TabIndex = 10;
            this.note_text.Text = "label4";
            // 
            // note_text1
            // 
            this.note_text1.AutoSize = true;
            this.note_text1.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.note_text1.ForeColor = System.Drawing.Color.DarkOrange;
            this.note_text1.Location = new System.Drawing.Point(332, 700);
            this.note_text1.Name = "note_text1";
            this.note_text1.Size = new System.Drawing.Size(45, 19);
            this.note_text1.TabIndex = 11;
            this.note_text1.Text = "label4";
            // 
            // Basket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 844);
            this.Controls.Add(this.note_text1);
            this.Controls.Add(this.note_text);
            this.Controls.Add(this.payCard_button);
            this.Controls.Add(this.payCash_button);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.discount_amount);
            this.Controls.Add(this.discount_button);
            this.Controls.Add(this.discount_code);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.total);
            this.Controls.Add(this.sub_total);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Basket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Basket";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Basket_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label sub_total;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox discount_code;
        private System.Windows.Forms.Button discount_button;
        private System.Windows.Forms.Label discount_amount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button payCash_button;
        private System.Windows.Forms.Button payCard_button;
        private System.Windows.Forms.Label note_text;
        private System.Windows.Forms.Label note_text1;
    }
}