using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.SqlClient;
using MySql.Data.MySqlClient;


namespace Atm_v2
{
    public partial class Form1 : Form
    {
        MySqlConnection con = new MySqlConnection(@"server=localhost;user=root;database=TestDB;port=3306;password=");
        int i;
        MySqlDataAdapter msda;
        DataTable dt;
        MySqlCommand cmd;
        MySqlDataAdapter adt;
        DataSet dataset;
        MySqlDataReader mdr;
        MySqlCommand command;


        string balance;
        string Name;
        string Surname;
        string tmpLbBalance;

        public Form1()
        {
            InitializeComponent();
        }
      

        // number buttons to enter pin-code
        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_pin.Text.Length < 4)
                tb_pin.Text = tb_pin.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tb_pin.Text.Length < 4)
                tb_pin.Text = tb_pin.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tb_pin.Text.Length < 4)
                tb_pin.Text = tb_pin.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (tb_pin.Text.Length < 4)
                tb_pin.Text = tb_pin.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (tb_pin.Text.Length < 4)
                tb_pin.Text = tb_pin.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (tb_pin.Text.Length < 4)
                tb_pin.Text = tb_pin.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (tb_pin.Text.Length < 4)
                tb_pin.Text = tb_pin.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (tb_pin.Text.Length < 4)
                tb_pin.Text = tb_pin.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (tb_pin.Text.Length < 4)
                tb_pin.Text = tb_pin.Text + "9";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (tb_pin.Text.Length < 4)
                tb_pin.Text = tb_pin.Text + "0";
        }

        //is the Del button and will delete 1 number at the time
        private void button12_Click(object sender, EventArgs e)
        {
            if (tb_pin.Text.Length > 0)
                tb_pin.Text = tb_pin.Text.Remove(tb_pin.Text.Length - 1);
        }

        //card number this will only allow numbers to be typed in textbox
        private void tb_card_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            i = 0;
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from testdb.testtable where Card_number='" + tb_card.Text + "'and Pin_code='" + int.Parse(tb_pin.Text) + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());
            if (i == 0)
            {
                label3.Text = "Invalid Username or password! ";
            }
            else
            {
                //ClearTextBoxes();
                TakeAccountInfo();
                TakeUserData();
            }
            //Temporary saves user info to use it in other forms
            void TakeUserData()
            {
                MinUserData.CardData = tb_card.Text;
                MinUserData.PinData = tb_pin.Text;
            }
            void TakeAccountInfo()
            {
                //connection.Open();
                string selectQuery = "select * from testdb.testtable where Card_number='" + tb_card.Text + "'and Pin_code='" + int.Parse(tb_pin.Text) + "'";

                command = new MySqlCommand(selectQuery, con);

                mdr = command.ExecuteReader();
                if (mdr.Read())
                {
                    lb_welcome.Text = mdr.GetString("Name");
                    lb_balance.Text = mdr.GetString("Surname");
                    lb_penge.Text = mdr.GetInt32("Balance").ToString();
                }
                else
                {
                    MessageBox.Show("An Error is a play here");
                }
                con.Close();
            }
            
        }
        //cash Witdrawl
        private void btn_withdraw_Click(object sender, EventArgs e)
        {
                 //Checks balance
                if (Convert.ToDecimal(tmpLbBalance) >= Convert.ToDecimal(tb_withdraw.Text))
                {
                    con.Open();
                    string query_a = "Select Balance From testdb.testtable Where Card_number = '" + MinUserData.CardData + "' And Pin_code = '" + MinUserData.PinData + "'";
                    adt = new MySqlDataAdapter(query_a, con);
                    dataset = new DataSet();
                    adt.Fill(dataset);

                    //Cash withdraw (changing balance value)
                    decimal tmpBalance = Convert.ToDecimal(dataset.Tables[0].Rows[0]["Balance"].ToString());
                    tmpBalance = tmpBalance - Convert.ToDecimal(tb_withdraw.Text);

                    //Updating old record
                    string query_b = "Update testdb.testtable Set Balance = '" + tmpBalance + "' Where Card_number = '" + MinUserData.CardData + "' And Pin_code = '" + MinUserData.PinData + "'";

                    cmd = new MySqlCommand(query_b, con);
                    cmd.CommandText = query_b;
                    cmd.ExecuteNonQuery();

                    balance = tmpBalance.ToString();
                    tmpLbBalance = balance;
                    lb_penge.Text = balance + "Dk";
                    tb_withdraw.Clear();
                    con.Close();
                }
                else
                    MessageBox.Show("There is not enough money on your account!");

        }


    }
}
