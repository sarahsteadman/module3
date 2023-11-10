namespace Library_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.books = new System.Windows.Forms.Button();
            this.members = new System.Windows.Forms.Button();
            this.checkOut = new System.Windows.Forms.Button();
            this.checkIn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // books
            // 
            this.books.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.books.Location = new System.Drawing.Point(70, 225);
            this.books.Name = "books";
            this.books.Size = new System.Drawing.Size(208, 45);
            this.books.TabIndex = 0;
            this.books.Text = "Search Books";
            this.books.UseVisualStyleBackColor = true;
            this.books.Click += new System.EventHandler(this.books_Click);
            // 
            // members
            // 
            this.members.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.members.Location = new System.Drawing.Point(70, 306);
            this.members.Name = "members";
            this.members.Size = new System.Drawing.Size(208, 45);
            this.members.TabIndex = 1;
            this.members.Text = "Search Members";
            this.members.UseVisualStyleBackColor = true;
            this.members.Click += new System.EventHandler(this.Members_Click);
            // 
            // checkOut
            // 
            this.checkOut.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkOut.Location = new System.Drawing.Point(70, 78);
            this.checkOut.Name = "checkOut";
            this.checkOut.Size = new System.Drawing.Size(208, 45);
            this.checkOut.TabIndex = 2;
            this.checkOut.Text = "Check Out Book";
            this.checkOut.UseVisualStyleBackColor = true;
            this.checkOut.Click += new System.EventHandler(this.checkOut_Click);
            // 
            // checkIn
            // 
            this.checkIn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkIn.Location = new System.Drawing.Point(70, 149);
            this.checkIn.Name = "checkIn";
            this.checkIn.Size = new System.Drawing.Size(208, 45);
            this.checkIn.TabIndex = 3;
            this.checkIn.Text = "Check In Book";
            this.checkIn.UseVisualStyleBackColor = true;
            this.checkIn.Click += new System.EventHandler(this.checkIn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "C:\\Users\\fairy\\OneDrive\\Desktop\\Programing Class\\CSE 310\\module3\\LibraryIMG.jpg";
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(345, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(402, 364);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(801, 438);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkIn);
            this.Controls.Add(this.checkOut);
            this.Controls.Add(this.members);
            this.Controls.Add(this.books);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

    #endregion

    private System.Windows.Forms.Button books;
    private System.Windows.Forms.Button members;
    private System.Windows.Forms.Button checkOut;
    private System.Windows.Forms.Button checkIn;
    private System.Windows.Forms.PictureBox pictureBox1;
  }
}

