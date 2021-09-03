namespace GraceTailor
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.btnord = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.btndetail = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.SuspendLayout();
            // 
            // btnord
            // 
            this.btnord.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnord.AnimationHoverSpeed = 0.07F;
            this.btnord.AnimationSpeed = 0.03F;
            this.btnord.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnord.BorderColor = System.Drawing.Color.Black;
            this.btnord.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnord.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnord.CheckedForeColor = System.Drawing.Color.White;
            this.btnord.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnord.CheckedImage")));
            this.btnord.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnord.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnord.FocusedColor = System.Drawing.Color.Empty;
            this.btnord.Font = new System.Drawing.Font("Segoe UI Light", 11F, System.Drawing.FontStyle.Bold);
            this.btnord.ForeColor = System.Drawing.Color.Black;
            this.btnord.Image = ((System.Drawing.Image)(resources.GetObject("btnord.Image")));
            this.btnord.ImageSize = new System.Drawing.Size(100, 100);
            this.btnord.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnord.Location = new System.Drawing.Point(213, 143);
            this.btnord.Name = "btnord";
            this.btnord.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(141)))), ((int)(((byte)(185)))));
            this.btnord.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnord.OnHoverForeColor = System.Drawing.Color.White;
            this.btnord.OnHoverImage = null;
            this.btnord.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(141)))), ((int)(((byte)(185)))));
            this.btnord.OnPressedColor = System.Drawing.Color.Black;
            this.btnord.Size = new System.Drawing.Size(195, 210);
            this.btnord.TabIndex = 17;
            this.btnord.Text = "  New Order     نیا آرڈر";
            this.btnord.Click += new System.EventHandler(this.btnord_Click);
            // 
            // btndetail
            // 
            this.btndetail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btndetail.AnimationHoverSpeed = 0.07F;
            this.btndetail.AnimationSpeed = 0.03F;
            this.btndetail.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btndetail.BorderColor = System.Drawing.Color.Black;
            this.btndetail.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btndetail.CheckedBorderColor = System.Drawing.Color.Black;
            this.btndetail.CheckedForeColor = System.Drawing.Color.White;
            this.btndetail.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btndetail.CheckedImage")));
            this.btndetail.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btndetail.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btndetail.FocusedColor = System.Drawing.Color.Empty;
            this.btndetail.Font = new System.Drawing.Font("Segoe UI Light", 11F, System.Drawing.FontStyle.Bold);
            this.btndetail.ForeColor = System.Drawing.Color.Black;
            this.btndetail.Image = ((System.Drawing.Image)(resources.GetObject("btndetail.Image")));
            this.btndetail.ImageSize = new System.Drawing.Size(100, 100);
            this.btndetail.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btndetail.Location = new System.Drawing.Point(414, 143);
            this.btndetail.Name = "btndetail";
            this.btndetail.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(141)))), ((int)(((byte)(185)))));
            this.btndetail.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btndetail.OnHoverForeColor = System.Drawing.Color.White;
            this.btndetail.OnHoverImage = null;
            this.btndetail.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(141)))), ((int)(((byte)(185)))));
            this.btndetail.OnPressedColor = System.Drawing.Color.Black;
            this.btndetail.Size = new System.Drawing.Size(195, 210);
            this.btndetail.TabIndex = 17;
            this.btndetail.Text = "Detail        تفصیل";
            this.btndetail.Click += new System.EventHandler(this.btndetail_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(847, 497);
            this.Controls.Add(this.btndetail);
            this.Controls.Add(this.btnord);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.btnord, 0);
            this.Controls.SetChildIndex(this.btndetail, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaAdvenceTileButton btnord;
        private Guna.UI.WinForms.GunaAdvenceTileButton btndetail;
    }
}