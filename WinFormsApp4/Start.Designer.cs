namespace WinFormsApp4
{
    partial class Start
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnStartOrder = new Button();
            SuspendLayout();
            // 
            // btnStartOrder
            // 
            btnStartOrder.BackColor = SystemColors.ActiveCaption;
            btnStartOrder.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStartOrder.Location = new Point(430, 241);
            btnStartOrder.Margin = new Padding(4);
            btnStartOrder.Name = "btnStartOrder";
            btnStartOrder.Size = new Size(141, 54);
            btnStartOrder.TabIndex = 0;
            btnStartOrder.Text = "Start Order";
            btnStartOrder.UseVisualStyleBackColor = false;
            btnStartOrder.Click += this.btnStartOrder_Click;
            // 
            // Start
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._360_F_305838467_v52Tyml9vmCzhodgMCH0L0kWw85Z2iUo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1000, 562);
            Controls.Add(btnStartOrder);
            Margin = new Padding(4);
            Name = "Start";
            Text = "Start";
            ResumeLayout(false);
        }

        #endregion

        private Button btnStartOrder;
    }
}
