
namespace VendingMachine
{
    partial class OrderReady
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
            this.orderAgain_button = new System.Windows.Forms.Button();
            this.goodbye_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // orderAgain_button
            // 
            this.orderAgain_button.Location = new System.Drawing.Point(224, 433);
            this.orderAgain_button.Name = "orderAgain_button";
            this.orderAgain_button.Size = new System.Drawing.Size(215, 54);
            this.orderAgain_button.TabIndex = 3;
            this.orderAgain_button.Text = "Order again";
            this.orderAgain_button.UseVisualStyleBackColor = true;
            this.orderAgain_button.Click += new System.EventHandler(this.orderAgain_button_Click);
            // 
            // goodbye_button
            // 
            this.goodbye_button.Location = new System.Drawing.Point(224, 275);
            this.goodbye_button.Name = "goodbye_button";
            this.goodbye_button.Size = new System.Drawing.Size(215, 56);
            this.goodbye_button.TabIndex = 4;
            this.goodbye_button.Text = "Goodbye!";
            this.goodbye_button.UseVisualStyleBackColor = true;
            this.goodbye_button.Click += new System.EventHandler(this.goodbye_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(108)))), ((int)(((byte)(77)))));
            this.label1.Location = new System.Drawing.Point(74, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(508, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Thank you! Your payment is successfully done!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(108)))), ((int)(((byte)(77)))));
            this.label2.Location = new System.Drawing.Point(127, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(396, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Your drinks are getting ready . . .";
            // 
            // OrderReady
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 844);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.goodbye_button);
            this.Controls.Add(this.orderAgain_button);
            this.Name = "OrderReady";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderReady";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OrderReady_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button orderAgain_button;
        private System.Windows.Forms.Button goodbye_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}