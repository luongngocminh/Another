/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 05/09/2016
 * Time: 8:55 CH
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Another
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TabControl tabPages;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.CheckedListBox checkedListBox1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.TextBox textEmail;
		private System.Windows.Forms.TextBox textPass;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.ListBox listChat;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.ListBox listName;
		private System.Windows.Forms.Button btnGetPer;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button6 = new System.Windows.Forms.Button();
			this.textEmail = new System.Windows.Forms.TextBox();
			this.textPass = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.button3 = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.tabPages = new System.Windows.Forms.TabControl();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.listName = new System.Windows.Forms.ListBox();
			this.listChat = new System.Windows.Forms.ListBox();
			this.button4 = new System.Windows.Forms.Button();
			this.btnGetPer = new System.Windows.Forms.Button();
			this.tabPage2.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPages.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.SystemColors.WindowText;
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.ForeColor = System.Drawing.Color.Lime;
			this.textBox1.Location = new System.Drawing.Point(12, 27);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(708, 13);
			this.textBox1.TabIndex = 1;
			this.textBox1.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.Color.Cornsilk;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(109, 15);
			this.label1.TabIndex = 2;
			this.label1.Text = "User Access Token";
			// 
			// button6
			// 
			this.button6.BackColor = System.Drawing.Color.Black;
			this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button6.ForeColor = System.Drawing.Color.Lime;
			this.button6.Location = new System.Drawing.Point(12, 53);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(120, 23);
			this.button6.TabIndex = 8;
			this.button6.Text = "Get Access Token";
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Click += new System.EventHandler(this.Button6Click);
			// 
			// textEmail
			// 
			this.textEmail.BackColor = System.Drawing.SystemColors.WindowText;
			this.textEmail.ForeColor = System.Drawing.Color.Lime;
			this.textEmail.Location = new System.Drawing.Point(564, 104);
			this.textEmail.Name = "textEmail";
			this.textEmail.Size = new System.Drawing.Size(155, 20);
			this.textEmail.TabIndex = 10;
			this.textEmail.TextChanged += new System.EventHandler(this.TextBox3TextChanged);
			// 
			// textPass
			// 
			this.textPass.BackColor = System.Drawing.SystemColors.WindowText;
			this.textPass.ForeColor = System.Drawing.Color.Lime;
			this.textPass.Location = new System.Drawing.Point(564, 162);
			this.textPass.Name = "textPass";
			this.textPass.Size = new System.Drawing.Size(156, 20);
			this.textPass.TabIndex = 11;
			this.textPass.TextChanged += new System.EventHandler(this.TextBox4TextChanged);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(564, 82);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(116, 19);
			this.label2.TabIndex = 12;
			this.label2.Text = "Phone number or email";
			this.label2.Click += new System.EventHandler(this.Label2Click);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(564, 145);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 14);
			this.label3.TabIndex = 13;
			this.label3.Text = "Password";
			// 
			// tabPage2
			// 
			this.tabPage2.BackColor = System.Drawing.SystemColors.WindowFrame;
			this.tabPage2.Controls.Add(this.button3);
			this.tabPage2.Controls.Add(this.textBox2);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(521, 231);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Post ";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(6, 181);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 1;
			this.button3.Text = "Post to Wall";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// textBox2
			// 
			this.textBox2.BackColor = System.Drawing.SystemColors.WindowText;
			this.textBox2.ForeColor = System.Drawing.Color.Lime;
			this.textBox2.Location = new System.Drawing.Point(6, 6);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(509, 169);
			this.textBox2.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.SystemColors.WindowFrame;
			this.tabPage1.Controls.Add(this.checkedListBox1);
			this.tabPage1.Controls.Add(this.listBox1);
			this.tabPage1.Controls.Add(this.button2);
			this.tabPage1.Controls.Add(this.button1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(521, 231);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "User Info";
			// 
			// checkedListBox1
			// 
			this.checkedListBox1.BackColor = System.Drawing.SystemColors.WindowText;
			this.checkedListBox1.ForeColor = System.Drawing.Color.Lime;
			this.checkedListBox1.FormattingEnabled = true;
			this.checkedListBox1.Items.AddRange(new object[] {
			"Id",
			"Name",
			"Email",
			"Birthday"});
			this.checkedListBox1.Location = new System.Drawing.Point(389, 14);
			this.checkedListBox1.Name = "checkedListBox1";
			this.checkedListBox1.Size = new System.Drawing.Size(117, 139);
			this.checkedListBox1.TabIndex = 7;
			this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.CheckedListBox1SelectedIndexChanged);
			// 
			// listBox1
			// 
			this.listBox1.BackColor = System.Drawing.SystemColors.WindowText;
			this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listBox1.ForeColor = System.Drawing.Color.Lime;
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 16;
			this.listBox1.Location = new System.Drawing.Point(3, 14);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(299, 192);
			this.listBox1.TabIndex = 3;
			this.listBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1SelectedIndexChanged);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(308, 43);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 4;
			this.button2.Text = "Clear";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(308, 14);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Get user info";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// tabPages
			// 
			this.tabPages.Controls.Add(this.tabPage1);
			this.tabPages.Controls.Add(this.tabPage2);
			this.tabPages.Controls.Add(this.tabPage3);
			this.tabPages.Location = new System.Drawing.Point(12, 82);
			this.tabPages.Name = "tabPages";
			this.tabPages.SelectedIndex = 0;
			this.tabPages.Size = new System.Drawing.Size(529, 257);
			this.tabPages.TabIndex = 5;
			// 
			// tabPage3
			// 
			this.tabPage3.BackColor = System.Drawing.SystemColors.WindowFrame;
			this.tabPage3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tabPage3.Controls.Add(this.listName);
			this.tabPage3.Controls.Add(this.listChat);
			this.tabPage3.Controls.Add(this.button4);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(521, 231);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Chat";
			// 
			// listName
			// 
			this.listName.BackColor = System.Drawing.SystemColors.WindowText;
			this.listName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listName.ForeColor = System.Drawing.Color.Yellow;
			this.listName.FormattingEnabled = true;
			this.listName.ItemHeight = 16;
			this.listName.Location = new System.Drawing.Point(7, 3);
			this.listName.Name = "listName";
			this.listName.Size = new System.Drawing.Size(129, 176);
			this.listName.TabIndex = 2;
			this.listName.SelectedIndexChanged += new System.EventHandler(this.ListNameSelectedIndexChanged);
			this.listName.DoubleClick += new System.EventHandler(this.ListNameDoubleClick);
			// 
			// listChat
			// 
			this.listChat.BackColor = System.Drawing.SystemColors.WindowText;
			this.listChat.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listChat.ForeColor = System.Drawing.Color.Lime;
			this.listChat.FormattingEnabled = true;
			this.listChat.ItemHeight = 20;
			this.listChat.Location = new System.Drawing.Point(142, 3);
			this.listChat.Name = "listChat";
			this.listChat.Size = new System.Drawing.Size(373, 180);
			this.listChat.TabIndex = 1;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(7, 195);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 23);
			this.button4.TabIndex = 0;
			this.button4.Text = "Get Chat";
			this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// btnGetPer
			// 
			this.btnGetPer.BackColor = System.Drawing.SystemColors.ControlText;
			this.btnGetPer.ForeColor = System.Drawing.Color.Lime;
			this.btnGetPer.Location = new System.Drawing.Point(139, 53);
			this.btnGetPer.Name = "btnGetPer";
			this.btnGetPer.Size = new System.Drawing.Size(75, 23);
			this.btnGetPer.TabIndex = 14;
			this.btnGetPer.Text = "Get Permit";
			this.btnGetPer.UseVisualStyleBackColor = false;
			this.btnGetPer.Click += new System.EventHandler(this.BtnGetPerClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClientSize = new System.Drawing.Size(731, 357);
			this.Controls.Add(this.btnGetPer);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textPass);
			this.Controls.Add(this.textEmail);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tabPages);
			this.Controls.Add(this.textBox1);
			this.Name = "MainForm";
			this.Text = "Another";
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.tabPage1.ResumeLayout(false);
			this.tabPages.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
