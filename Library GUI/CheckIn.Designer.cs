namespace Library_GUI
{
  partial class CheckIn
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
            this.inBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.bookNum = new System.Windows.Forms.TextBox();
            this.menu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inBtn
            // 
            this.inBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inBtn.Location = new System.Drawing.Point(349, 262);
            this.inBtn.Name = "inBtn";
            this.inBtn.Size = new System.Drawing.Size(115, 43);
            this.inBtn.TabIndex = 10;
            this.inBtn.Text = "Check In";
            this.inBtn.UseVisualStyleBackColor = true;
            this.inBtn.Click += new System.EventHandler(this.inBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(271, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Book ID";
            // 
            // bookNum
            // 
            this.bookNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bookNum.Location = new System.Drawing.Point(271, 198);
            this.bookNum.Name = "bookNum";
            this.bookNum.Size = new System.Drawing.Size(279, 35);
            this.bookNum.TabIndex = 7;
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.menu.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.Location = new System.Drawing.Point(36, 34);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(119, 42);
            this.menu.TabIndex = 20;
            this.menu.Text = "Main Menu";
            this.menu.UseVisualStyleBackColor = false;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // CheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.inBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bookNum);
            this.Name = "CheckIn";
            this.Text = "CheckIn";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button inBtn;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox bookNum;
    private System.Windows.Forms.Button menu;
  }
}