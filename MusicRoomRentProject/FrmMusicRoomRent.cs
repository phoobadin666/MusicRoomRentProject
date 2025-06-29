using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicRoomRentProject
{
    public partial class FrmMusicRoomRent : Form

    {


        public FrmMusicRoomRent()
        {
            InitializeComponent();

        }

        private void tbName_KeyPress(object sender, KeyPressEventArgs e)
        {


        }

        private void tbPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbHour_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbguiter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbbase_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbkeyboard_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbdrum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbguiter_CheckedChanged(object sender, EventArgs e)
        {
            if (cbguiter.Checked == false)
            {
                tbguiter.Enabled = false;
            }
            else if (cbguiter.Checked == true)
            {
                tbguiter.Enabled = true;
            }
        }

        private void cbbase_CheckedChanged(object sender, EventArgs e)
        {
            if (cbbase.Checked == false)
            {
                tbbase.Enabled = false;
            }
            else if (cbbase.Checked == true)
            {
                tbbase.Enabled = true;
            }
        }

        private void cbkeyboard_CheckedChanged(object sender, EventArgs e)
        {
            if (cbkeyboard.Checked == false)
            {
                tbkeyboard.Enabled = false;
            }
            else if (cbkeyboard.Checked == true)
            {
                tbkeyboard.Enabled = true;
            }
        }

        private void cbdrum_CheckedChanged(object sender, EventArgs e)
        {
            if (cbdrum.Checked == false)
            {
                tbdrum.Enabled = false;
            }
            else if (cbdrum.Checked == true)
            {
                tbdrum.Enabled = true;
            }
        }

        private void ShowWarningMSG(string msg)
        {

            MessageBox.Show(msg, "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void btnCal_Click(object sender, EventArgs e)
        {

            if (tbName.Text.Length == 0)
            {
                ShowWarningMSG("กรุณาป้อนชื่อผู้เช่า");
            }
            else if (tbPhone.Text.Length == 0)
            {
                ShowWarningMSG("กรุณาป้อนเบอร์โทรศัพท์ผู้เช่า");
            }
            else if (tbPhone.Text.Length != 10)
            {
                ShowWarningMSG("กรุณาป้อนเบอร์โทรศัพท์ผู้เช่าให้ครบ 10 หลัก");
            }
            else if (tbHour.Text.Length == 0)
            {
                ShowWarningMSG("กรุณาป้อนชั่วโมงการเช่า");
            }
            else if (string.IsNullOrWhiteSpace(tbguiter.Text) && string.IsNullOrWhiteSpace(tbbase.Text) && string.IsNullOrWhiteSpace(tbkeyboard.Text) && string.IsNullOrWhiteSpace(tbdrum.Text))
            {
                ShowWarningMSG("กรุณาเลือกเครื่องดนตรีอย่างน้อย 1 ชนิด");
            }
            else if (tbHour.Text == "0")
            {
                ShowWarningMSG("ไม่อนุญาตให้บันทึกข้อมูลที่มีค่าเป็น 0");
            }
            else
            {
                int hour = int.TryParse(tbHour.Text, out var h) ? h : 0;
                int guiters = int.TryParse(tbguiter.Text, out var g) ? g : 0;
                int bases = int.TryParse(tbbase.Text, out var b) ? b : 0;
                int keyboards = int.TryParse(tbkeyboard.Text, out var k) ? k : 0;
                int drums = int.TryParse(tbdrum.Text, out var d) ? d : 0;

                float total = (hour * 80) + (guiters * 20) + (bases * 15) + (keyboards * 10) + (drums * 30);

                lbPay.Text = total.ToString("00.00");


            }

        }

        private void getAllData()
        {
            string connectionString = @"Server=DESKTOP-G2RQ5QR;Database=musicrent_db;Trusted_Connection=True";
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();
                    string strSQL = "SELECT rentId,rentName,rentPhone,rentHour,guiter,base,keyboard,drum,rentPay,payStatus From musicroom_tb";

                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(strSQL, sqlConnection))
                    {
                        //เอาข้อมูลที่ได้จาก strSQL เป็นก้อนใน dataAdapter มาทำให้เป็นตารางโดยใส่ไว้ใน DataTable
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        //ตั้งค่า ListView
                        lvRentUser.Items.Clear();
                        lvRentUser.Columns.Clear();
                        lvRentUser.FullRowSelect = true;
                        lvRentUser.View = View.Details;


                        //กำหนดรายละเอียด Colum ใน ListView
                        lvRentUser.Columns.Add("รหัสการเช่า", 80, HorizontalAlignment.Left);
                        lvRentUser.Columns.Add("ชื่อผู้เช่า", 100, HorizontalAlignment.Left);
                        lvRentUser.Columns.Add("เบอร์โทรผู้เช่า", 80, HorizontalAlignment.Left);
                        lvRentUser.Columns.Add("จำนวนชั่วโมง", 80, HorizontalAlignment.Left);
                        lvRentUser.Columns.Add("จำนวนกีตาร์", 80, HorizontalAlignment.Left);
                        lvRentUser.Columns.Add("จำนวนเบส", 80, HorizontalAlignment.Left);
                        lvRentUser.Columns.Add("จำนวนคีบอร์ด", 80, HorizontalAlignment.Left);
                        lvRentUser.Columns.Add("จำนวนกล่อง", 80, HorizontalAlignment.Left);
                        lvRentUser.Columns.Add("จำนวนเงินที่ต้องชำระ", 80, HorizontalAlignment.Left);
                        lvRentUser.Columns.Add("ชำระแล้ว/ยังไม่ชำระ", 80, HorizontalAlignment.Left);


                        //Loop วนเข้าไปใน Datatable 
                        foreach (DataRow dataRow in dataTable.Rows)
                        {
                            ListViewItem item = new ListViewItem(dataRow["rentId"].ToString());

                            // เอาแต่ละรายการใส่ใน Item
                            item.SubItems.Add(dataRow["rentName"].ToString());
                            item.SubItems.Add(dataRow["rentPhone"].ToString());
                            item.SubItems.Add(dataRow["rentHour"].ToString());
                            item.SubItems.Add(dataRow["guiter"].ToString());
                            item.SubItems.Add(dataRow["base"].ToString());
                            item.SubItems.Add(dataRow["keyboard"].ToString());
                            item.SubItems.Add(dataRow["drum"].ToString());
                            item.SubItems.Add(dataRow["rentPay"].ToString());
                            item.SubItems.Add(dataRow["payStatus"].ToString());

                            //เอาข้อมูลใน Item 
                            lvRentUser.Items.Add(item);


                        }
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("พบข้อผิดพลาด กรุณาลองใหม่หรือติดต่อ IT : " + ex.Message);
                }
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {

            if (tbName.Text.Length == 0)
            {
                ShowWarningMSG("กรุณาป้อนชื่อผู้เช่า");
            }
            else if (tbPhone.Text.Length == 0)
            {
                ShowWarningMSG("กรุณาป้อนเบอร์โทรศัพท์ผู้เช่า");
            }
            else if (tbPhone.Text.Length != 10)
            {
                ShowWarningMSG("กรุณาป้อนเบอร์โทรศัพท์ผู้เช่าให้ครบ 10 หลัก");
            }
            else if (tbHour.Text.Length == 0)
            {
                ShowWarningMSG("กรุณาป้อนชั่วโมงการเช่า");
            }
            else if (string.IsNullOrWhiteSpace(tbguiter.Text) && string.IsNullOrWhiteSpace(tbbase.Text) && string.IsNullOrWhiteSpace(tbkeyboard.Text) && string.IsNullOrWhiteSpace(tbdrum.Text))
            {
                ShowWarningMSG("กรุณาเลือกเครื่องดนตรีอย่างน้อย 1 ชนิด");
            }
            else if (tbHour.Text == "0")
            {
                ShowWarningMSG("ไม่อนุญาตให้บันทึกข้อมูลที่มีค่าเป็น 0");
            }
            else
            {
                string connectionString = @"Server=DESKTOP-G2RQ5QR;Database=musicrent_db;Trusted_Connection=True";
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    try
                    {
                        sqlConnection.Open();
                        SqlTransaction sqlTransaction = sqlConnection.BeginTransaction();
                        string strSql = "INSERT INTO musicroom_tb (rentName,rentPhone,rentHour,guiter,base,keyboard,drum,rentPay,payStatus)" +
                                            "VALUES (@rentName,@rentPhone,@rentHour,@guiter,@base,@keyboard,@drum,@rentPay,@payStatus)";
                        using (SqlCommand sqlCommand = new SqlCommand(strSql, sqlConnection, sqlTransaction))
                        {
                            sqlCommand.Parameters.Add("@rentName", SqlDbType.NVarChar, 150).Value = tbName.Text;
                            sqlCommand.Parameters.Add("@rentPhone", SqlDbType.NVarChar, 50).Value = tbPhone.Text;
                            sqlCommand.Parameters.Add("@rentHour", SqlDbType.Int).Value = int.TryParse(tbHour.Text, out var h) ? h : 0;
                            sqlCommand.Parameters.Add("@guiter", SqlDbType.Int).Value = int.TryParse(tbguiter.Text, out var g) ? g : 0;
                            sqlCommand.Parameters.Add("@base", SqlDbType.Int).Value = int.TryParse(tbbase.Text, out var b) ? b : 0;
                            sqlCommand.Parameters.Add("@keyboard", SqlDbType.Int).Value = int.TryParse(tbkeyboard.Text, out var k) ? k : 0;
                            sqlCommand.Parameters.Add("@drum", SqlDbType.Int).Value = int.TryParse(tbdrum.Text, out var d) ? d : 0;
                            sqlCommand.Parameters.Add("@rentPay", SqlDbType.Float).Value = float.TryParse(lbPay.Text, out var p) ? p : 0;

                            if (rbNotYetPaid.Checked == true)
                            {
                                sqlCommand.Parameters.Add("@payStatus", SqlDbType.NVarChar, 50).Value = "ยังไม่ชำระ";
                            }
                            else
                            {
                                sqlCommand.Parameters.Add("@payStatus", SqlDbType.NVarChar, 50).Value = "ชำระแล้ว";
                            }

                            sqlCommand.ExecuteNonQuery();
                            sqlTransaction.Commit();
                            MessageBox.Show("บันทึกเรียบร้อย", "ผลการทำงาน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            getAllData();

                            Reset();

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("เกิดข้อผิดพลาด: " + ex.Message, "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {


            if (tbName.Text.Length == 0)
            {
                ShowWarningMSG("กรุณาป้อนชื่อผู้เช่า");
            }
            else if (tbPhone.Text.Length == 0)
            {
                ShowWarningMSG("กรุณาป้อนเบอร์โทรศัพท์ผู้เช่า");
            }
            else if (tbPhone.Text.Length != 10)
            {
                ShowWarningMSG("กรุณาป้อนเบอร์โทรศัพท์ผู้เช่าให้ครบ 10 หลัก");
            }
            else if (tbHour.Text.Length == 0)
            {
                ShowWarningMSG("กรุณาป้อนชั่วโมงการเช่า");
            }
            else if (string.IsNullOrWhiteSpace(tbguiter.Text) && string.IsNullOrWhiteSpace(tbbase.Text) && string.IsNullOrWhiteSpace(tbkeyboard.Text) && string.IsNullOrWhiteSpace(tbdrum.Text))
            {
                ShowWarningMSG("กรุณาเลือกเครื่องดนตรีอย่างน้อย 1 ชนิด");
            }
            else if (tbHour.Text == "0")
            {
                ShowWarningMSG("ไม่อนุญาตให้บันทึกข้อมูลที่มีค่าเป็น 0");
            }
            else
            {
                string connectionString = @"Server=DESKTOP-G2RQ5QR;Database=musicrent_db;Trusted_Connection=True";
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    try
                    {
                        sqlConnection.Open();

                        SqlTransaction sqlTransaction = sqlConnection.BeginTransaction();

                        string strSql = "UPDATE musicroom_tb SET  " +
                                        "rentName=@rentName, rentPhone=@rentPhone,  " +
                                        "rentHour=@rentHour, guiter=@guiter,  " +
                                        "base=@base, keyboard=@keyboard,  " +
                                        "drum=@drum, rentPay=@rentPay," +
                                        "payStatus=@payStatus WHERE rentId=@rentId";

                        string rentId = lvRentUser.SelectedItems[0].SubItems[0].Text;
                        using (SqlCommand sqlCommand = new SqlCommand(strSql, sqlConnection, sqlTransaction))
                        {
                            sqlCommand.Parameters.AddWithValue("@rentId", rentId);
                            sqlCommand.Parameters.Add("@rentName", SqlDbType.NVarChar, 150).Value = tbName.Text;
                            sqlCommand.Parameters.Add("@rentPhone", SqlDbType.NVarChar, 50).Value = tbPhone.Text;
                            sqlCommand.Parameters.Add("@rentHour", SqlDbType.Int).Value = int.TryParse(tbHour.Text, out var h) ? h : 0;
                            sqlCommand.Parameters.Add("@guiter", SqlDbType.Int).Value = int.TryParse(tbguiter.Text, out var g) ? g : 0;
                            sqlCommand.Parameters.Add("@base", SqlDbType.Int).Value = int.TryParse(tbbase.Text, out var b) ? b : 0;
                            sqlCommand.Parameters.Add("@keyboard", SqlDbType.Int).Value = int.TryParse(tbkeyboard.Text, out var k) ? k : 0;
                            sqlCommand.Parameters.Add("@drum", SqlDbType.Int).Value = int.TryParse(tbdrum.Text, out var d) ? d : 0;
                            sqlCommand.Parameters.Add("@rentPay", SqlDbType.Float).Value = float.TryParse(lbPay.Text, out var p) ? p : 0;
                            if (rbNotYetPaid.Checked == true)
                            {
                                sqlCommand.Parameters.Add("@payStatus", SqlDbType.NVarChar, 50).Value = "ยังไม่ชำระ";
                            }
                            else
                            {
                                sqlCommand.Parameters.Add("@payStatus", SqlDbType.NVarChar, 50).Value = "ชำระแล้ว";
                            }


                            sqlCommand.ExecuteNonQuery();
                            sqlTransaction.Commit();
                            MessageBox.Show("แก้ไขเรียบร้อย", "ผลการทำงาน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            getAllData();


                            Reset();

                        }

                    }


                    catch (Exception ex)
                    {
                        MessageBox.Show("เกิดข้อผิดพลาด: " + ex.Message, "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void btnDel_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server=DESKTOP-G2RQ5QR;Database=musicrent_db;Trusted_Connection=True";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();

                    SqlTransaction sqlTransaction = sqlConnection.BeginTransaction();

                    //คำสั่ง SQL
                    string strSql = "DELETE FROM musicroom_tb WHERE rentId=@rentId";
                    string rentId = lvRentUser.SelectedItems[0].SubItems[0].Text;

                    //กำหนดค่าให้กับ SQL Parameter และสั่งให้คำสั่ง SQL ทำงาน
                    using (SqlCommand sqlCommand = new SqlCommand(strSql, sqlConnection, sqlTransaction))
                    {
                        sqlCommand.Parameters.AddWithValue("@rentId", rentId);

                        sqlCommand.ExecuteNonQuery();
                        sqlTransaction.Commit();


                        MessageBox.Show("ลบเรียบร้อย", "ผลการทำงาน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getAllData();

                        Reset();

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("พบข้อผิดพลาด กรุณาลองใหม่หรือติดต่อ IT : " + ex.Message);
                }
            }
        }

        private void lvRentUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvRentUser.SelectedItems.Count > 0)
            {
                ListViewItem item = lvRentUser.SelectedItems[0];
                tbName.Text = item.SubItems[1].Text;
                tbPhone.Text = item.SubItems[2].Text;
                tbHour.Text = item.SubItems[3].Text;
                tbguiter.Text = item.SubItems[4].Text;
                tbbase.Text = item.SubItems[5].Text;
                tbkeyboard.Text = item.SubItems[6].Text;
                tbdrum.Text = item.SubItems[7].Text;
                lbPay.Text = item.SubItems[8].Text;

                if (item.SubItems[9].Text == "ยังไม่ชำระ")
                    rbNotYetPaid.Checked = true;
                else
                    rbPaid.Checked = true;

                if (tbguiter.Text != "0")
                {
                    cbguiter.Checked = true;
                    tbguiter.Enabled = true;
                }
                else
                {
                    cbguiter.Checked = false;
                    tbguiter.Enabled = false;
                }

                if (tbbase.Text != "0")
                {
                    cbbase.Checked = true;
                    tbbase.Enabled = true;
                }
                else
                {
                    cbbase.Checked = false;
                    tbbase.Enabled = false;
                }


                if (tbkeyboard.Text != "0")
                {
                    cbkeyboard.Checked = true;
                    tbkeyboard.Enabled = true;
                }
                else
                {
                    cbkeyboard.Checked = false;
                    tbkeyboard.Enabled = false;
                }


                if (tbdrum.Text != "0")
                {
                    cbdrum.Checked = true;
                    tbdrum.Enabled = true;
                }
                else
                {
                    cbdrum.Checked = false;
                    tbdrum.Enabled = false;
                }


                btnSave.Enabled = false;
                btnEdit.Enabled = true;
            }
        }
        private void FrmMusicRoomRent_Load(object sender, EventArgs e)
        {
            getAllData();
            cbguiter.Checked = false;
            cbbase.Checked = false;
            cbkeyboard.Checked = false;
            cbdrum.Checked = false;
            tbguiter.Enabled = false;
            tbbase.Enabled = false;
            tbkeyboard.Enabled = false;
            tbdrum.Enabled = false;
            btnEdit.Enabled = false;
        }

        private void Reset()
        {
            tbName.Clear();
            tbPhone.Clear();
            tbHour.Clear();
            tbguiter.Clear();
            tbbase.Clear();
            tbkeyboard.Clear();
            tbdrum.Clear();

            cbguiter.Checked = false;
            cbbase.Checked = false;
            cbkeyboard.Checked = false;
            cbdrum.Checked = false;
            tbguiter.Enabled = false;
            tbbase.Enabled = false;
            tbkeyboard.Enabled = false;
            tbdrum.Enabled = false;

            lbPay.Text = "00.00";
            rbNotYetPaid.Checked = true;
            rbPaid.Checked = false;
            btnEdit.Enabled = false;
            btnSave.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
