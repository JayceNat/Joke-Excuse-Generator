﻿namespace JokeGenerator
{
    partial class JokeExcuseGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JokeExcuseGenerator));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Jokes = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.JokeResult = new System.Windows.Forms.Label();
            this.Dislike = new System.Windows.Forms.Button();
            this.Like = new System.Windows.Forms.Button();
            this.JokeButton = new System.Windows.Forms.Button();
            this.Notification = new System.Windows.Forms.Label();
            this.RestartButton = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.Memes = new System.Windows.Forms.TabPage();
            this.ForwardButton = new System.Windows.Forms.Button();
            this.RestartExcuses = new System.Windows.Forms.Button();
            this.ExcuseText = new System.Windows.Forms.Label();
            this.ResetExcuses = new System.Windows.Forms.Button();
            this.ExcuseButton = new System.Windows.Forms.Button();
            this.CopyButton = new System.Windows.Forms.Button();
            this.SendToEmail = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.BackBox = new System.Windows.Forms.ListBox();
            this.ForwardBox = new System.Windows.Forms.ListBox();
            this.ExcuseNotification = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1.SuspendLayout();
            this.Jokes.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.Memes.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Jokes);
            this.tabControl1.Controls.Add(this.Memes);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Snap ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(60, 5);
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1132, 703);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // Jokes
            // 
            this.Jokes.BackColor = System.Drawing.Color.Black;
            this.Jokes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Jokes.Controls.Add(this.tableLayoutPanel1);
            this.Jokes.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Jokes.Location = new System.Drawing.Point(4, 36);
            this.Jokes.Name = "Jokes";
            this.Jokes.Padding = new System.Windows.Forms.Padding(3);
            this.Jokes.Size = new System.Drawing.Size(1124, 663);
            this.Jokes.TabIndex = 0;
            this.Jokes.Text = "Jokes, plz";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.JokeResult, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Dislike, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.Like, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.JokeButton, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.Notification, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.RestartButton, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.Reset, 3, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.969151F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.52442F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.46541F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.20755F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 179F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1118, 657);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // JokeResult
            // 
            this.JokeResult.AutoSize = true;
            this.JokeResult.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.JokeResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(this.JokeResult, 4);
            this.JokeResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.JokeResult.Font = new System.Drawing.Font("Palatino Linotype", 18F);
            this.JokeResult.Location = new System.Drawing.Point(3, 118);
            this.JokeResult.Name = "JokeResult";
            this.JokeResult.Size = new System.Drawing.Size(1112, 251);
            this.JokeResult.TabIndex = 0;
            this.JokeResult.Text = "Prepare for LULZ.";
            this.JokeResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Dislike
            // 
            this.Dislike.BackColor = System.Drawing.Color.Salmon;
            this.Dislike.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dislike.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dislike.ForeColor = System.Drawing.Color.Black;
            this.Dislike.Location = new System.Drawing.Point(282, 372);
            this.Dislike.Name = "Dislike";
            this.Dislike.Size = new System.Drawing.Size(273, 50);
            this.Dislike.TabIndex = 1;
            this.Dislike.Text = "This Joke Sucks!";
            this.Dislike.UseVisualStyleBackColor = false;
            this.Dislike.Click += new System.EventHandler(this.Dislike_Click);
            // 
            // Like
            // 
            this.Like.BackColor = System.Drawing.Color.MediumAquamarine;
            this.Like.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Like.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Like.ForeColor = System.Drawing.Color.Black;
            this.Like.Location = new System.Drawing.Point(561, 372);
            this.Like.Name = "Like";
            this.Like.Size = new System.Drawing.Size(273, 50);
            this.Like.TabIndex = 2;
            this.Like.Text = "I Love This Joke!";
            this.Like.UseVisualStyleBackColor = false;
            this.Like.Click += new System.EventHandler(this.Like_Click);
            // 
            // JokeButton
            // 
            this.JokeButton.BackColor = System.Drawing.Color.LightSalmon;
            this.tableLayoutPanel1.SetColumnSpan(this.JokeButton, 2);
            this.JokeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.JokeButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.JokeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.JokeButton.ForeColor = System.Drawing.Color.Black;
            this.JokeButton.Location = new System.Drawing.Point(282, 428);
            this.JokeButton.Name = "JokeButton";
            this.JokeButton.Size = new System.Drawing.Size(552, 45);
            this.JokeButton.TabIndex = 3;
            this.JokeButton.Text = "Make Me Laugh!";
            this.JokeButton.UseVisualStyleBackColor = false;
            this.JokeButton.Click += new System.EventHandler(this.JokeButton_Click);
            // 
            // Notification
            // 
            this.Notification.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.Notification, 2);
            this.Notification.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Notification.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.Notification.Location = new System.Drawing.Point(282, 87);
            this.Notification.Name = "Notification";
            this.Notification.Size = new System.Drawing.Size(552, 31);
            this.Notification.TabIndex = 4;
            this.Notification.Text = "Joke #  /";
            this.Notification.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RestartButton
            // 
            this.RestartButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RestartButton.BackColor = System.Drawing.Color.LightSalmon;
            this.tableLayoutPanel1.SetColumnSpan(this.RestartButton, 2);
            this.RestartButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.RestartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RestartButton.Location = new System.Drawing.Point(282, 607);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(552, 47);
            this.RestartButton.TabIndex = 6;
            this.RestartButton.Text = "Start Teh LULZ over!";
            this.RestartButton.UseVisualStyleBackColor = false;
            this.RestartButton.Visible = false;
            this.RestartButton.Click += new System.EventHandler(this.RestartButton_Click_1);
            // 
            // Reset
            // 
            this.Reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Reset.BackColor = System.Drawing.Color.Black;
            this.Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reset.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Reset.Location = new System.Drawing.Point(1040, 620);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 34);
            this.Reset.TabIndex = 5;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = false;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Memes
            // 
            this.Memes.BackColor = System.Drawing.Color.Black;
            this.Memes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Memes.Controls.Add(this.tableLayoutPanel2);
            this.Memes.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Memes.Location = new System.Drawing.Point(4, 36);
            this.Memes.Name = "Memes";
            this.Memes.Padding = new System.Windows.Forms.Padding(3);
            this.Memes.Size = new System.Drawing.Size(1124, 663);
            this.Memes.TabIndex = 1;
            this.Memes.Text = "Excuses, plz";
            // 
            // ForwardButton
            // 
            this.ForwardButton.AutoSize = true;
            this.ForwardButton.BackColor = System.Drawing.Color.DimGray;
            this.ForwardButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ForwardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ForwardButton.Font = new System.Drawing.Font("Palatino Linotype", 11.8F);
            this.ForwardButton.Location = new System.Drawing.Point(715, 418);
            this.ForwardButton.Name = "ForwardButton";
            this.ForwardButton.Size = new System.Drawing.Size(78, 101);
            this.ForwardButton.TabIndex = 13;
            this.ForwardButton.Text = ">>>";
            this.ForwardButton.UseVisualStyleBackColor = false;
            this.ForwardButton.Visible = false;
            this.ForwardButton.Click += new System.EventHandler(this.ForwardButton_Click);
            // 
            // RestartExcuses
            // 
            this.RestartExcuses.BackColor = System.Drawing.Color.LightSalmon;
            this.tableLayoutPanel2.SetColumnSpan(this.RestartExcuses, 4);
            this.RestartExcuses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RestartExcuses.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.RestartExcuses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RestartExcuses.Location = new System.Drawing.Point(321, 525);
            this.RestartExcuses.Name = "RestartExcuses";
            this.RestartExcuses.Size = new System.Drawing.Size(472, 41);
            this.RestartExcuses.TabIndex = 8;
            this.RestartExcuses.Text = "Start the Excuses Over!";
            this.RestartExcuses.UseVisualStyleBackColor = false;
            this.RestartExcuses.Visible = false;
            this.RestartExcuses.Click += new System.EventHandler(this.RestartExcuses_Click);
            // 
            // ExcuseText
            // 
            this.ExcuseText.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ExcuseText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel2.SetColumnSpan(this.ExcuseText, 8);
            this.ExcuseText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExcuseText.Font = new System.Drawing.Font("Palatino Linotype", 20F);
            this.ExcuseText.Location = new System.Drawing.Point(3, 28);
            this.ExcuseText.Name = "ExcuseText";
            this.ExcuseText.Size = new System.Drawing.Size(1112, 387);
            this.ExcuseText.TabIndex = 7;
            this.ExcuseText.Text = "Excuses Ahead...";
            this.ExcuseText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ResetExcuses
            // 
            this.ResetExcuses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetExcuses.BackColor = System.Drawing.Color.Black;
            this.ResetExcuses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetExcuses.ForeColor = System.Drawing.Color.Gray;
            this.ResetExcuses.Location = new System.Drawing.Point(1040, 614);
            this.ResetExcuses.Name = "ResetExcuses";
            this.ResetExcuses.Size = new System.Drawing.Size(75, 40);
            this.ResetExcuses.TabIndex = 5;
            this.ResetExcuses.Text = "Reset";
            this.ResetExcuses.UseVisualStyleBackColor = false;
            this.ResetExcuses.Click += new System.EventHandler(this.ResetExcuses_Click);
            // 
            // ExcuseButton
            // 
            this.ExcuseButton.BackColor = System.Drawing.Color.LightSalmon;
            this.tableLayoutPanel2.SetColumnSpan(this.ExcuseButton, 2);
            this.ExcuseButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExcuseButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.ExcuseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExcuseButton.ForeColor = System.Drawing.Color.Black;
            this.ExcuseButton.Location = new System.Drawing.Point(405, 418);
            this.ExcuseButton.Name = "ExcuseButton";
            this.ExcuseButton.Size = new System.Drawing.Size(304, 101);
            this.ExcuseButton.TabIndex = 3;
            this.ExcuseButton.Text = "I Need An Excuse!";
            this.ExcuseButton.UseVisualStyleBackColor = false;
            this.ExcuseButton.Click += new System.EventHandler(this.ExcuseButton_Click);
            // 
            // CopyButton
            // 
            this.CopyButton.AutoSize = true;
            this.CopyButton.BackColor = System.Drawing.Color.Chocolate;
            this.CopyButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CopyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CopyButton.ForeColor = System.Drawing.Color.Black;
            this.CopyButton.Location = new System.Drawing.Point(560, 616);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(149, 38);
            this.CopyButton.TabIndex = 10;
            this.CopyButton.Text = "Copy Text";
            this.CopyButton.UseVisualStyleBackColor = false;
            this.CopyButton.Visible = false;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // SendToEmail
            // 
            this.SendToEmail.AutoSize = true;
            this.SendToEmail.BackColor = System.Drawing.Color.Chocolate;
            this.SendToEmail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SendToEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendToEmail.ForeColor = System.Drawing.Color.Black;
            this.SendToEmail.Location = new System.Drawing.Point(405, 616);
            this.SendToEmail.Name = "SendToEmail";
            this.SendToEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SendToEmail.Size = new System.Drawing.Size(149, 38);
            this.SendToEmail.TabIndex = 11;
            this.SendToEmail.Text = "eMail Text";
            this.SendToEmail.UseVisualStyleBackColor = false;
            this.SendToEmail.Visible = false;
            this.SendToEmail.Click += new System.EventHandler(this.SendToEmail_Click);
            // 
            // BackButton
            // 
            this.BackButton.AutoSize = true;
            this.BackButton.BackColor = System.Drawing.Color.DimGray;
            this.BackButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("Palatino Linotype", 11.8F);
            this.BackButton.ForeColor = System.Drawing.Color.Black;
            this.BackButton.Location = new System.Drawing.Point(321, 418);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(78, 101);
            this.BackButton.TabIndex = 12;
            this.BackButton.Text = "<<<";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Visible = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // BackBox
            // 
            this.BackBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BackBox.FormattingEnabled = true;
            this.BackBox.ItemHeight = 24;
            this.BackBox.Location = new System.Drawing.Point(1040, 533);
            this.BackBox.Name = "BackBox";
            this.BackBox.Size = new System.Drawing.Size(75, 4);
            this.BackBox.TabIndex = 14;
            this.BackBox.Visible = false;
            // 
            // ForwardBox
            // 
            this.ForwardBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ForwardBox.FormattingEnabled = true;
            this.ForwardBox.ItemHeight = 24;
            this.ForwardBox.Location = new System.Drawing.Point(1040, 577);
            this.ForwardBox.Name = "ForwardBox";
            this.ForwardBox.Size = new System.Drawing.Size(75, 4);
            this.ForwardBox.TabIndex = 15;
            this.ForwardBox.Visible = false;
            // 
            // ExcuseNotification
            // 
            this.ExcuseNotification.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel2.SetColumnSpan(this.ExcuseNotification, 8);
            this.ExcuseNotification.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.ExcuseNotification.Location = new System.Drawing.Point(5, 0);
            this.ExcuseNotification.Name = "ExcuseNotification";
            this.ExcuseNotification.Size = new System.Drawing.Size(1108, 26);
            this.ExcuseNotification.TabIndex = 16;
            this.ExcuseNotification.Text = "Excuse #  /";
            this.ExcuseNotification.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.tableLayoutPanel2.SetColumnSpan(this.button1, 2);
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(405, 572);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(304, 34);
            this.button1.TabIndex = 17;
            this.button1.Text = "* Favorite *";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 8;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.958944F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.57272F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.550452F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.91789F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.91788F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.550452F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.57272F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.958941F));
            this.tableLayoutPanel2.Controls.Add(this.ExcuseNotification, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ExcuseText, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.ResetExcuses, 7, 5);
            this.tableLayoutPanel2.Controls.Add(this.ForwardBox, 7, 4);
            this.tableLayoutPanel2.Controls.Add(this.SendToEmail, 3, 5);
            this.tableLayoutPanel2.Controls.Add(this.BackBox, 7, 3);
            this.tableLayoutPanel2.Controls.Add(this.BackButton, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.ExcuseButton, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.button1, 3, 4);
            this.tableLayoutPanel2.Controls.Add(this.CopyButton, 4, 5);
            this.tableLayoutPanel2.Controls.Add(this.ForwardButton, 5, 2);
            this.tableLayoutPanel2.Controls.Add(this.RestartExcuses, 2, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.056448F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.82615F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.77358F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.343815F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1118, 657);
            this.tableLayoutPanel2.TabIndex = 18;
            // 
            // JokeExcuseGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1132, 703);
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "JokeExcuseGenerator";
            this.Text = "Joke Generator";
            this.tabControl1.ResumeLayout(false);
            this.Jokes.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.Memes.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Jokes;
        private System.Windows.Forms.TabPage Memes;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label JokeResult;
        private System.Windows.Forms.Button Dislike;
        private System.Windows.Forms.Button Like;
        private System.Windows.Forms.Button JokeButton;
        private System.Windows.Forms.Label Notification;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button RestartButton;
        private System.Windows.Forms.Button ResetExcuses;
        private System.Windows.Forms.Button ExcuseButton;
        private System.Windows.Forms.Label ExcuseText;
        private System.Windows.Forms.Button RestartExcuses;
        private System.Windows.Forms.Button CopyButton;
        private System.Windows.Forms.Button SendToEmail;
        private System.Windows.Forms.Button ForwardButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.ListBox ForwardBox;
        private System.Windows.Forms.ListBox BackBox;
        private System.Windows.Forms.Label ExcuseNotification;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}

