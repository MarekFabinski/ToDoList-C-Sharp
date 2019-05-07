namespace ToDoList
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DailyCode = new System.Windows.Forms.CheckBox();
            this.DailyExeMorning = new System.Windows.Forms.CheckBox();
            this.DailyExeEvening = new System.Windows.Forms.CheckBox();
            this.DailyStudy = new System.Windows.Forms.CheckBox();
            this.DailyBook = new System.Windows.Forms.CheckBox();
            this.DailyBrush = new System.Windows.Forms.CheckBox();
            this.DailyMemes = new System.Windows.Forms.CheckBox();
            this.DailyLetter = new System.Windows.Forms.CheckBox();
            this.TwiceDesk = new System.Windows.Forms.CheckBox();
            this.TwiceTrash = new System.Windows.Forms.CheckBox();
            this.TwiceRoom = new System.Windows.Forms.CheckBox();
            this.TwiceBath = new System.Windows.Forms.CheckBox();
            this.TwiceShop = new System.Windows.Forms.CheckBox();
            this.TwiceRun = new System.Windows.Forms.CheckBox();
            this.TwiceBike = new System.Windows.Forms.CheckBox();
            this.TwiceEmail = new System.Windows.Forms.CheckBox();
            this.OnceMom = new System.Windows.Forms.CheckBox();
            this.OnceGranddad = new System.Windows.Forms.CheckBox();
            this.OnceLaundry = new System.Windows.Forms.CheckBox();
            this.OnceFriends = new System.Windows.Forms.CheckBox();
            this.OnceCook = new System.Windows.Forms.CheckBox();
            this.Check = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.labelDaily = new System.Windows.Forms.Label();
            this.labelTwice = new System.Windows.Forms.Label();
            this.labelOnce = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelDaily);
            this.groupBox1.Controls.Add(this.DailyLetter);
            this.groupBox1.Controls.Add(this.DailyMemes);
            this.groupBox1.Controls.Add(this.DailyBrush);
            this.groupBox1.Controls.Add(this.DailyBook);
            this.groupBox1.Controls.Add(this.DailyStudy);
            this.groupBox1.Controls.Add(this.DailyExeEvening);
            this.groupBox1.Controls.Add(this.DailyExeMorning);
            this.groupBox1.Controls.Add(this.DailyCode);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 361);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "To Do List: Daily";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelTwice);
            this.groupBox2.Controls.Add(this.TwiceEmail);
            this.groupBox2.Controls.Add(this.TwiceBike);
            this.groupBox2.Controls.Add(this.TwiceRun);
            this.groupBox2.Controls.Add(this.TwiceShop);
            this.groupBox2.Controls.Add(this.TwiceBath);
            this.groupBox2.Controls.Add(this.TwiceRoom);
            this.groupBox2.Controls.Add(this.TwiceTrash);
            this.groupBox2.Controls.Add(this.TwiceDesk);
            this.groupBox2.Location = new System.Drawing.Point(276, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(246, 361);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "To Do List: Twice a week";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelOnce);
            this.groupBox3.Controls.Add(this.OnceCook);
            this.groupBox3.Controls.Add(this.OnceFriends);
            this.groupBox3.Controls.Add(this.OnceLaundry);
            this.groupBox3.Controls.Add(this.OnceGranddad);
            this.groupBox3.Controls.Add(this.OnceMom);
            this.groupBox3.Location = new System.Drawing.Point(542, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(246, 361);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "To Do List: Once a week";
            // 
            // DailyCode
            // 
            this.DailyCode.AutoSize = true;
            this.DailyCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DailyCode.Location = new System.Drawing.Point(15, 60);
            this.DailyCode.Name = "DailyCode";
            this.DailyCode.Size = new System.Drawing.Size(125, 20);
            this.DailyCode.TabIndex = 0;
            this.DailyCode.Text = "Code for an hour";
            this.DailyCode.UseVisualStyleBackColor = true;
            // 
            // DailyExeMorning
            // 
            this.DailyExeMorning.AutoSize = true;
            this.DailyExeMorning.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DailyExeMorning.Location = new System.Drawing.Point(15, 83);
            this.DailyExeMorning.Name = "DailyExeMorning";
            this.DailyExeMorning.Size = new System.Drawing.Size(171, 20);
            this.DailyExeMorning.TabIndex = 1;
            this.DailyExeMorning.Text = "Excercise in the morning";
            this.DailyExeMorning.UseVisualStyleBackColor = true;
            // 
            // DailyExeEvening
            // 
            this.DailyExeEvening.AutoSize = true;
            this.DailyExeEvening.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DailyExeEvening.Location = new System.Drawing.Point(15, 106);
            this.DailyExeEvening.Name = "DailyExeEvening";
            this.DailyExeEvening.Size = new System.Drawing.Size(171, 20);
            this.DailyExeEvening.TabIndex = 2;
            this.DailyExeEvening.Text = "Excercise in the evening";
            this.DailyExeEvening.UseVisualStyleBackColor = true;
            // 
            // DailyStudy
            // 
            this.DailyStudy.AutoSize = true;
            this.DailyStudy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DailyStudy.Location = new System.Drawing.Point(15, 129);
            this.DailyStudy.Name = "DailyStudy";
            this.DailyStudy.Size = new System.Drawing.Size(61, 20);
            this.DailyStudy.TabIndex = 3;
            this.DailyStudy.Text = "Study";
            this.DailyStudy.UseVisualStyleBackColor = true;
            // 
            // DailyBook
            // 
            this.DailyBook.AutoSize = true;
            this.DailyBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DailyBook.Location = new System.Drawing.Point(15, 152);
            this.DailyBook.Name = "DailyBook";
            this.DailyBook.Size = new System.Drawing.Size(171, 20);
            this.DailyBook.TabIndex = 4;
            this.DailyBook.Text = "Read a book for an hour";
            this.DailyBook.UseVisualStyleBackColor = true;
            // 
            // DailyBrush
            // 
            this.DailyBrush.AutoSize = true;
            this.DailyBrush.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DailyBrush.Location = new System.Drawing.Point(15, 175);
            this.DailyBrush.Name = "DailyBrush";
            this.DailyBrush.Size = new System.Drawing.Size(114, 20);
            this.DailyBrush.TabIndex = 5;
            this.DailyBrush.Text = "Brush my teeth";
            this.DailyBrush.UseVisualStyleBackColor = true;
            // 
            // DailyMemes
            // 
            this.DailyMemes.AutoSize = true;
            this.DailyMemes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DailyMemes.Location = new System.Drawing.Point(15, 198);
            this.DailyMemes.Name = "DailyMemes";
            this.DailyMemes.Size = new System.Drawing.Size(150, 20);
            this.DailyMemes.TabIndex = 6;
            this.DailyMemes.Text = "Watch some memes";
            this.DailyMemes.UseVisualStyleBackColor = true;
            // 
            // DailyLetter
            // 
            this.DailyLetter.AutoSize = true;
            this.DailyLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DailyLetter.Location = new System.Drawing.Point(15, 221);
            this.DailyLetter.Name = "DailyLetter";
            this.DailyLetter.Size = new System.Drawing.Size(101, 20);
            this.DailyLetter.TabIndex = 7;
            this.DailyLetter.Text = "Write a letter";
            this.DailyLetter.UseVisualStyleBackColor = true;
            // 
            // TwiceDesk
            // 
            this.TwiceDesk.AutoSize = true;
            this.TwiceDesk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TwiceDesk.Location = new System.Drawing.Point(16, 60);
            this.TwiceDesk.Name = "TwiceDesk";
            this.TwiceDesk.Size = new System.Drawing.Size(116, 20);
            this.TwiceDesk.TabIndex = 1;
            this.TwiceDesk.Text = "Clean my desk";
            this.TwiceDesk.UseVisualStyleBackColor = true;
            // 
            // TwiceTrash
            // 
            this.TwiceTrash.AutoSize = true;
            this.TwiceTrash.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TwiceTrash.Location = new System.Drawing.Point(16, 83);
            this.TwiceTrash.Name = "TwiceTrash";
            this.TwiceTrash.Size = new System.Drawing.Size(125, 20);
            this.TwiceTrash.TabIndex = 2;
            this.TwiceTrash.Text = "Tak out the trash";
            this.TwiceTrash.UseVisualStyleBackColor = true;
            // 
            // TwiceRoom
            // 
            this.TwiceRoom.AutoSize = true;
            this.TwiceRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TwiceRoom.Location = new System.Drawing.Point(16, 106);
            this.TwiceRoom.Name = "TwiceRoom";
            this.TwiceRoom.Size = new System.Drawing.Size(117, 20);
            this.TwiceRoom.TabIndex = 3;
            this.TwiceRoom.Text = "Clean my room";
            this.TwiceRoom.UseVisualStyleBackColor = true;
            // 
            // TwiceBath
            // 
            this.TwiceBath.AutoSize = true;
            this.TwiceBath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TwiceBath.Location = new System.Drawing.Point(16, 129);
            this.TwiceBath.Name = "TwiceBath";
            this.TwiceBath.Size = new System.Drawing.Size(143, 20);
            this.TwiceBath.TabIndex = 4;
            this.TwiceBath.Text = "Clean the bathroom";
            this.TwiceBath.UseVisualStyleBackColor = true;
            // 
            // TwiceShop
            // 
            this.TwiceShop.AutoSize = true;
            this.TwiceShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TwiceShop.Location = new System.Drawing.Point(16, 152);
            this.TwiceShop.Name = "TwiceShop";
            this.TwiceShop.Size = new System.Drawing.Size(104, 20);
            this.TwiceShop.TabIndex = 5;
            this.TwiceShop.Text = "Go shopping";
            this.TwiceShop.UseVisualStyleBackColor = true;
            // 
            // TwiceRun
            // 
            this.TwiceRun.AutoSize = true;
            this.TwiceRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TwiceRun.Location = new System.Drawing.Point(16, 175);
            this.TwiceRun.Name = "TwiceRun";
            this.TwiceRun.Size = new System.Drawing.Size(93, 20);
            this.TwiceRun.TabIndex = 6;
            this.TwiceRun.Text = "Go jogging";
            this.TwiceRun.UseVisualStyleBackColor = true;
            // 
            // TwiceBike
            // 
            this.TwiceBike.AutoSize = true;
            this.TwiceBike.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TwiceBike.Location = new System.Drawing.Point(16, 198);
            this.TwiceBike.Name = "TwiceBike";
            this.TwiceBike.Size = new System.Drawing.Size(90, 20);
            this.TwiceBike.TabIndex = 7;
            this.TwiceBike.Text = "Go cycling";
            this.TwiceBike.UseVisualStyleBackColor = true;
            // 
            // TwiceEmail
            // 
            this.TwiceEmail.AutoSize = true;
            this.TwiceEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TwiceEmail.Location = new System.Drawing.Point(16, 221);
            this.TwiceEmail.Name = "TwiceEmail";
            this.TwiceEmail.Size = new System.Drawing.Size(122, 20);
            this.TwiceEmail.TabIndex = 8;
            this.TwiceEmail.Text = "Check the email";
            this.TwiceEmail.UseVisualStyleBackColor = true;
            // 
            // OnceMom
            // 
            this.OnceMom.AutoSize = true;
            this.OnceMom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OnceMom.Location = new System.Drawing.Point(27, 60);
            this.OnceMom.Name = "OnceMom";
            this.OnceMom.Size = new System.Drawing.Size(104, 20);
            this.OnceMom.TabIndex = 1;
            this.OnceMom.Text = "Call my mom";
            this.OnceMom.UseVisualStyleBackColor = true;
            // 
            // OnceGranddad
            // 
            this.OnceGranddad.AutoSize = true;
            this.OnceGranddad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OnceGranddad.Location = new System.Drawing.Point(27, 83);
            this.OnceGranddad.Name = "OnceGranddad";
            this.OnceGranddad.Size = new System.Drawing.Size(142, 20);
            this.OnceGranddad.TabIndex = 2;
            this.OnceGranddad.Text = "Call my grandfather";
            this.OnceGranddad.UseVisualStyleBackColor = true;
            // 
            // OnceLaundry
            // 
            this.OnceLaundry.AutoSize = true;
            this.OnceLaundry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OnceLaundry.Location = new System.Drawing.Point(27, 106);
            this.OnceLaundry.Name = "OnceLaundry";
            this.OnceLaundry.Size = new System.Drawing.Size(108, 20);
            this.OnceLaundry.TabIndex = 3;
            this.OnceLaundry.Text = "Make laundry";
            this.OnceLaundry.UseVisualStyleBackColor = true;
            // 
            // OnceFriends
            // 
            this.OnceFriends.AutoSize = true;
            this.OnceFriends.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OnceFriends.Location = new System.Drawing.Point(27, 129);
            this.OnceFriends.Name = "OnceFriends";
            this.OnceFriends.Size = new System.Drawing.Size(134, 20);
            this.OnceFriends.TabIndex = 4;
            this.OnceFriends.Text = "Go out with friends";
            this.OnceFriends.UseVisualStyleBackColor = true;
            // 
            // OnceCook
            // 
            this.OnceCook.AutoSize = true;
            this.OnceCook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OnceCook.Location = new System.Drawing.Point(27, 152);
            this.OnceCook.Name = "OnceCook";
            this.OnceCook.Size = new System.Drawing.Size(159, 20);
            this.OnceCook.TabIndex = 5;
            this.OnceCook.Text = "Cook something fancy";
            this.OnceCook.UseVisualStyleBackColor = true;
            // 
            // Check
            // 
            this.Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Check.Location = new System.Drawing.Point(257, 396);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(128, 42);
            this.Check.TabIndex = 3;
            this.Check.Text = "Check";
            this.Check.UseVisualStyleBackColor = true;
            this.Check.Click += new System.EventHandler(this.Check_Click);
            // 
            // Close
            // 
            this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Close.Location = new System.Drawing.Point(417, 396);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(128, 42);
            this.Close.TabIndex = 4;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // labelDaily
            // 
            this.labelDaily.AutoSize = true;
            this.labelDaily.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDaily.Location = new System.Drawing.Point(29, 286);
            this.labelDaily.Name = "labelDaily";
            this.labelDaily.Size = new System.Drawing.Size(0, 31);
            this.labelDaily.TabIndex = 8;
            this.labelDaily.Click += new System.EventHandler(this.Label1_Click);
            // 
            // labelTwice
            // 
            this.labelTwice.AutoSize = true;
            this.labelTwice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTwice.Location = new System.Drawing.Point(34, 286);
            this.labelTwice.Name = "labelTwice";
            this.labelTwice.Size = new System.Drawing.Size(0, 31);
            this.labelTwice.TabIndex = 9;
            // 
            // labelOnce
            // 
            this.labelOnce.AutoSize = true;
            this.labelOnce.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOnce.Location = new System.Drawing.Point(42, 286);
            this.labelOnce.Name = "labelOnce";
            this.labelOnce.Size = new System.Drawing.Size(0, 31);
            this.labelOnce.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 473);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Check);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "To do list";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox DailyLetter;
        private System.Windows.Forms.CheckBox DailyMemes;
        private System.Windows.Forms.CheckBox DailyBrush;
        private System.Windows.Forms.CheckBox DailyBook;
        private System.Windows.Forms.CheckBox DailyStudy;
        private System.Windows.Forms.CheckBox DailyExeEvening;
        private System.Windows.Forms.CheckBox DailyExeMorning;
        private System.Windows.Forms.CheckBox DailyCode;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox TwiceEmail;
        private System.Windows.Forms.CheckBox TwiceBike;
        private System.Windows.Forms.CheckBox TwiceRun;
        private System.Windows.Forms.CheckBox TwiceShop;
        private System.Windows.Forms.CheckBox TwiceBath;
        private System.Windows.Forms.CheckBox TwiceRoom;
        private System.Windows.Forms.CheckBox TwiceTrash;
        private System.Windows.Forms.CheckBox TwiceDesk;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox OnceCook;
        private System.Windows.Forms.CheckBox OnceFriends;
        private System.Windows.Forms.CheckBox OnceLaundry;
        private System.Windows.Forms.CheckBox OnceGranddad;
        private System.Windows.Forms.CheckBox OnceMom;
        private System.Windows.Forms.Button Check;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label labelDaily;
        private System.Windows.Forms.Label labelTwice;
        private System.Windows.Forms.Label labelOnce;
    }
}

