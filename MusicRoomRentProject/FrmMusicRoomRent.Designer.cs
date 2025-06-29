namespace MusicRoomRentProject
{
    partial class FrmMusicRoomRent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMusicRoomRent));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbdrum = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbdrum = new System.Windows.Forms.TextBox();
            this.cbkeyboard = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbkeyboard = new System.Windows.Forms.TextBox();
            this.cbbase = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbbase = new System.Windows.Forms.TextBox();
            this.cbguiter = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbguiter = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbHour = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbPay = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.rbNotYetPaid = new System.Windows.Forms.RadioButton();
            this.rbPaid = new System.Windows.Forms.RadioButton();
            this.btnCal = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.lvRentUser = new System.Windows.Forms.ListView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1488, 68);
            this.label1.TabIndex = 0;
            this.label1.Text = "โปรแกรมเช่าห้องซ้อมดนตรี";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "ชื่อผู้เช่า";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "เบอร์โทรผู้เช่า";
            // 
            // tbName
            // 
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(202, 116);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(433, 31);
            this.tbName.TabIndex = 3;
            // 
            // tbPhone
            // 
            this.tbPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhone.Location = new System.Drawing.Point(202, 175);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(433, 31);
            this.tbPhone.TabIndex = 4;
            this.tbPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPhone_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbdrum);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.tbdrum);
            this.groupBox1.Controls.Add(this.cbkeyboard);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.tbkeyboard);
            this.groupBox1.Controls.Add(this.cbbase);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.tbbase);
            this.groupBox1.Controls.Add(this.cbguiter);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tbguiter);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbHour);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(63, 226);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(572, 337);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ข้อมูลการเช่า";
            // 
            // cbdrum
            // 
            this.cbdrum.AutoSize = true;
            this.cbdrum.Location = new System.Drawing.Point(33, 287);
            this.cbdrum.Name = "cbdrum";
            this.cbdrum.Size = new System.Drawing.Size(130, 28);
            this.cbdrum.TabIndex = 23;
            this.cbdrum.Text = "กลอง จำนวน";
            this.cbdrum.UseVisualStyleBackColor = true;
            this.cbdrum.CheckedChanged += new System.EventHandler(this.cbdrum_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(392, 287);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(159, 25);
            this.label12.TabIndex = 22;
            this.label12.Text = "ตัว (30 บาท/ตัว)";
            // 
            // tbdrum
            // 
            this.tbdrum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbdrum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbdrum.Location = new System.Drawing.Point(213, 284);
            this.tbdrum.Name = "tbdrum";
            this.tbdrum.Size = new System.Drawing.Size(152, 31);
            this.tbdrum.TabIndex = 21;
            this.tbdrum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbdrum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbdrum_KeyPress);
            // 
            // cbkeyboard
            // 
            this.cbkeyboard.AutoSize = true;
            this.cbkeyboard.Location = new System.Drawing.Point(33, 240);
            this.cbkeyboard.Name = "cbkeyboard";
            this.cbkeyboard.Size = new System.Drawing.Size(157, 28);
            this.cbkeyboard.TabIndex = 20;
            this.cbkeyboard.Text = "คีย์บอร์ด จำนวน";
            this.cbkeyboard.UseVisualStyleBackColor = true;
            this.cbkeyboard.CheckedChanged += new System.EventHandler(this.cbkeyboard_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(392, 240);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(159, 25);
            this.label11.TabIndex = 19;
            this.label11.Text = "ตัว (10 บาท/ตัว)";
            // 
            // tbkeyboard
            // 
            this.tbkeyboard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbkeyboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbkeyboard.Location = new System.Drawing.Point(213, 237);
            this.tbkeyboard.Name = "tbkeyboard";
            this.tbkeyboard.Size = new System.Drawing.Size(152, 31);
            this.tbkeyboard.TabIndex = 18;
            this.tbkeyboard.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbkeyboard.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbkeyboard_KeyPress);
            // 
            // cbbase
            // 
            this.cbbase.AutoSize = true;
            this.cbbase.Location = new System.Drawing.Point(33, 193);
            this.cbbase.Name = "cbbase";
            this.cbbase.Size = new System.Drawing.Size(119, 28);
            this.cbbase.TabIndex = 17;
            this.cbbase.Text = "เบส จำนวน";
            this.cbbase.UseVisualStyleBackColor = true;
            this.cbbase.CheckedChanged += new System.EventHandler(this.cbbase_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(392, 193);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(159, 25);
            this.label10.TabIndex = 16;
            this.label10.Text = "ตัว (15 บาท/ตัว)";
            // 
            // tbbase
            // 
            this.tbbase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbbase.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbbase.Location = new System.Drawing.Point(213, 190);
            this.tbbase.Name = "tbbase";
            this.tbbase.Size = new System.Drawing.Size(152, 31);
            this.tbbase.TabIndex = 15;
            this.tbbase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbbase.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbbase_KeyPress);
            // 
            // cbguiter
            // 
            this.cbguiter.AutoSize = true;
            this.cbguiter.Location = new System.Drawing.Point(33, 145);
            this.cbguiter.Name = "cbguiter";
            this.cbguiter.Size = new System.Drawing.Size(132, 28);
            this.cbguiter.TabIndex = 14;
            this.cbguiter.Text = "กีตาร์ จำนวน";
            this.cbguiter.UseVisualStyleBackColor = true;
            this.cbguiter.CheckedChanged += new System.EventHandler(this.cbguiter_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(392, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 25);
            this.label9.TabIndex = 13;
            this.label9.Text = "ตัว (20 บาท/ตัว)";
            // 
            // tbguiter
            // 
            this.tbguiter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbguiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbguiter.Location = new System.Drawing.Point(213, 142);
            this.tbguiter.Name = "tbguiter";
            this.tbguiter.Size = new System.Drawing.Size(152, 31);
            this.tbguiter.TabIndex = 11;
            this.tbguiter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbguiter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbguiter_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(413, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 25);
            this.label8.TabIndex = 10;
            this.label8.Text = "ชั่วโมง";
            // 
            // tbHour
            // 
            this.tbHour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHour.Location = new System.Drawing.Point(213, 94);
            this.tbHour.Name = "tbHour";
            this.tbHour.Size = new System.Drawing.Size(152, 31);
            this.tbHour.TabIndex = 6;
            this.tbHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbHour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbHour_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "จำนวนชั่วโมงที่เช่า";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(392, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "บาท/ชั่วโมง";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Orange;
            this.label5.Location = new System.Drawing.Point(269, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "80";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(99, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "ค่าเช่าห้อง";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(78, 593);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(195, 25);
            this.label13.TabIndex = 6;
            this.label13.Text = "จำนวนเงินที่ต้องชำระ";
            // 
            // lbPay
            // 
            this.lbPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPay.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbPay.Location = new System.Drawing.Point(290, 578);
            this.lbPay.Name = "lbPay";
            this.lbPay.Size = new System.Drawing.Size(178, 58);
            this.lbPay.TabIndex = 24;
            this.lbPay.Text = "00.00";
            this.lbPay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(519, 593);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 25);
            this.label15.TabIndex = 25;
            this.label15.Text = "บาท";
            // 
            // rbNotYetPaid
            // 
            this.rbNotYetPaid.AutoSize = true;
            this.rbNotYetPaid.Checked = true;
            this.rbNotYetPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNotYetPaid.Location = new System.Drawing.Point(202, 672);
            this.rbNotYetPaid.Name = "rbNotYetPaid";
            this.rbNotYetPaid.Size = new System.Drawing.Size(120, 29);
            this.rbNotYetPaid.TabIndex = 26;
            this.rbNotYetPaid.TabStop = true;
            this.rbNotYetPaid.Text = "ยังไม่ชำระ";
            this.rbNotYetPaid.UseVisualStyleBackColor = true;
            // 
            // rbPaid
            // 
            this.rbPaid.AutoSize = true;
            this.rbPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPaid.Location = new System.Drawing.Point(394, 672);
            this.rbPaid.Name = "rbPaid";
            this.rbPaid.Size = new System.Drawing.Size(109, 29);
            this.rbPaid.TabIndex = 27;
            this.rbPaid.Text = "ชำระแล้ว";
            this.rbPaid.UseVisualStyleBackColor = true;
            // 
            // btnCal
            // 
            this.btnCal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCal.Location = new System.Drawing.Point(63, 728);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(572, 76);
            this.btnCal.TabIndex = 28;
            this.btnCal.Text = "คำนวนค่าเช่า";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(916, 116);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(250, 25);
            this.label16.TabIndex = 33;
            this.label16.Text = "ข้อมูลการเช่าห้องซ้อมดนตรี";
            // 
            // lvRentUser
            // 
            this.lvRentUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvRentUser.HideSelection = false;
            this.lvRentUser.Location = new System.Drawing.Point(658, 159);
            this.lvRentUser.Name = "lvRentUser";
            this.lvRentUser.Size = new System.Drawing.Size(820, 809);
            this.lvRentUser.TabIndex = 34;
            this.lvRentUser.UseCompatibleStateImageBehavior = false;
            this.lvRentUser.SelectedIndexChanged += new System.EventHandler(this.lvRentUser_SelectedIndexChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = global::MusicRoomRentProject.Properties.Resources.cancel;
            this.btnCancel.Location = new System.Drawing.Point(61, 892);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(572, 76);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "ยกเลิก";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.White;
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Image = global::MusicRoomRentProject.Properties.Resources.delete;
            this.btnDel.Location = new System.Drawing.Point(455, 810);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(178, 76);
            this.btnDel.TabIndex = 31;
            this.btnDel.Text = "ลบข้อมูล";
            this.btnDel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Image = global::MusicRoomRentProject.Properties.Resources.update;
            this.btnEdit.Location = new System.Drawing.Point(262, 810);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(178, 76);
            this.btnEdit.TabIndex = 30;
            this.btnEdit.Text = "บันทึกแก้ไขข้อมูล";
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::MusicRoomRentProject.Properties.Resources.save;
            this.btnSave.Location = new System.Drawing.Point(63, 810);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(178, 76);
            this.btnSave.TabIndex = 29;
            this.btnSave.Text = "บันทึกเพิ่มข้อมูล";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmMusicRoomRent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1512, 996);
            this.Controls.Add(this.lvRentUser);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.rbPaid);
            this.Controls.Add(this.rbNotYetPaid);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lbPay);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMusicRoomRent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "โปรแกรมเช่าห้องซ้อมดนตรี";
            this.Load += new System.EventHandler(this.FrmMusicRoomRent_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbdrum;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbdrum;
        private System.Windows.Forms.CheckBox cbkeyboard;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbkeyboard;
        private System.Windows.Forms.CheckBox cbbase;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbbase;
        private System.Windows.Forms.CheckBox cbguiter;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbguiter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbHour;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbPay;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.RadioButton rbNotYetPaid;
        private System.Windows.Forms.RadioButton rbPaid;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ListView lvRentUser;
    }
}

