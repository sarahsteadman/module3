namespace Library_GUI
{
  partial class CheckOut
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
            this.availableBooks = new System.Windows.Forms.DataGridView();
            this.card = new System.Windows.Forms.TextBox();
            this.book = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.outBtn = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.availableBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // availableBooks
            // 
            this.availableBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.availableBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.availableBooks.Location = new System.Drawing.Point(394, 73);
            this.availableBooks.Name = "availableBooks";
            this.availableBooks.RowHeadersWidth = 62;
            this.availableBooks.RowTemplate.Height = 28;
            this.availableBooks.Size = new System.Drawing.Size(622, 340);
            this.availableBooks.TabIndex = 0;
            // 
            // card
            // 
            this.card.Location = new System.Drawing.Point(58, 147);
            this.card.Name = "card";
            this.card.Size = new System.Drawing.Size(279, 26);
            this.card.TabIndex = 1;
            // 
            // book
            // 
            this.book.Location = new System.Drawing.Point(58, 212);
            this.book.Name = "book";
            this.book.Size = new System.Drawing.Size(279, 26);
            this.book.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(58, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Library Card Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(58, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Book ID";
            // 
            // outBtn
            // 
            this.outBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.outBtn.Location = new System.Drawing.Point(109, 272);
            this.outBtn.Name = "outBtn";
            this.outBtn.Size = new System.Drawing.Size(142, 43);
            this.outBtn.TabIndex = 5;
            this.outBtn.Text = "Check Out";
            this.outBtn.UseVisualStyleBackColor = true;
            this.outBtn.Click += new System.EventHandler(this.outBtn_Click);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.menu.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.Location = new System.Drawing.Point(24, 21);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(119, 42);
            this.menu.TabIndex = 20;
            this.menu.Text = "Main Menu";
            this.menu.UseVisualStyleBackColor = false;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(620, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 26);
            this.label3.TabIndex = 21;
            this.label3.Text = "Available Books";
            // 
            // CheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1078, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.outBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.book);
            this.Controls.Add(this.card);
            this.Controls.Add(this.availableBooks);
            this.Name = "CheckOut";
            this.Text = "CheckOut";
            this.Load += new System.EventHandler(this.CheckOut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.availableBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView availableBooks;
    private System.Windows.Forms.TextBox card;
    private System.Windows.Forms.TextBox book;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button outBtn;
    private System.Windows.Forms.Button menu;
    private System.Windows.Forms.Label label3;
  }
}