using System;
using CrystalDecisions.CrystalReports.Engine;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace GraceTailor
{
    public partial class Detail : Sample2
    {
        //Selection s = new Selection();
        public static Int16 condition;
        public static int a;
        public Detail()
        {
            InitializeComponent();
        }

        
        public void btnload_Click(object sender, EventArgs e)
        {
            string[] query = new string[6];
            int id;
            if (dataGridView1.CurrentCell == null)
            {
                MessageBox.Show("There is no data","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {

                    try
                    {
                        SQLiteCommand cmd; 
                        id = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
              
                

                            Main.con.Open();
                            
                            DialogResult DR = MessageBox.Show("Do you want to deleted it", "Question", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                            if (DR == DialogResult.No)
                            {
                                string q = "select * from CustomerDetails";
                                SQLiteCommand cmd1 = new SQLiteCommand(q, Main.con);
                                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd1);
                                DataTable dt = new DataTable();
                                da.Fill(dt);
                                c1.DataPropertyName = dt.Columns["Code"].ToString();
                                c2.DataPropertyName = dt.Columns["Name"].ToString();
                                c3.DataPropertyName = dt.Columns["Number"].ToString();
                                c8.DataPropertyName = dt.Columns["totalamount"].ToString();
                                c9.DataPropertyName = dt.Columns["advance"].ToString();
                                c10.DataPropertyName = dt.Columns["balance"].ToString();
                                dataGridView1.DataSource = dt;
                             }
                            else if(DR == DialogResult.Yes)
                               {
                        //string query = "delete from CustomerDetails where Code = dataGridView1.CurrentRow.Cells[0].Value.ToString() ";
                        query[0] = "delete from CustomerDetails where Code  =" + id + " ";
                        query[1] = "delete from coat where code  =" + id + " ";
                        query[2] = "delete from pant where code  =" + id + " ";
                        query[3] = "delete from shirt where code  =" + id + " ";
                        query[4] = "delete from westcoat where code  =" + id + " ";
                        query[5] = "delete from shalwarkameez where code  =" + id + " ";
                        for (int i = 0; i < 6; i++)
                        {
                            cmd = new SQLiteCommand(query[i], Main.con);
                            cmd.ExecuteNonQuery();
                        }
                        string q = "select * from CustomerDetails";
                        SQLiteCommand cmd1 = new SQLiteCommand(q, Main.con);
                        SQLiteDataAdapter da = new SQLiteDataAdapter(cmd1);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        c1.DataPropertyName = dt.Columns["Code"].ToString();
                        c2.DataPropertyName = dt.Columns["Name"].ToString();
                        c3.DataPropertyName = dt.Columns["Number"].ToString();
                        c8.DataPropertyName = dt.Columns["totalamount"].ToString();
                        c9.DataPropertyName = dt.Columns["advance"].ToString();
                        c10.DataPropertyName = dt.Columns["balance"].ToString();
                        dataGridView1.DataSource = dt;
                    }


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        Main.con.Close();
                    }
            }
            //try
            //{
            //    string q = "select * from CustomerDetails";
            //    SQLiteCommand cmd = new SQLiteCommand(q, Main.con);
            //    SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            //    DataTable dt = new DataTable();
            //    da.Fill(dt);
            //    c1.DataPropertyName = dt.Columns["Code"].ToString();
            //    c2.DataPropertyName = dt.Columns["Name"].ToString();
            //    c3.DataPropertyName = dt.Columns["Number"].ToString();
            //    c8.DataPropertyName = dt.Columns["totalamount"].ToString();
            //    c9.DataPropertyName = dt.Columns["advance"].ToString();
            //    c10.DataPropertyName = dt.Columns["balance"].ToString();
            //    dataGridView1.DataSource = dt;

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            ////try
            //{
            //    //SqlCommand cmd = new SqlCommand("showalldata", Main.con);
            //cmd.CommandType = CommandType.StoredProcedure;
            //SqlDataAdapter sda = new SqlDataAdapter(cmd)
            //DataTable dt = new DataTable();
            //sda.Fill(dt);
            //    if(dt.Rows.Count >= 1)
            //    {
            //        c1.DataPropertyName = dt.Columns["code"].ToString();
            //        c2.DataPropertyName = dt.Columns["name"].ToString();
            //        c3.DataPropertyName = dt.Columns["phoneNo"].ToString();
            //        c4.DataPropertyName = dt.Columns["suitType"].ToString();
            //        C5.DataPropertyName = dt.Columns["totalSuit"].ToString();
            //        c6.DataPropertyName = dt.Columns["orderDate"].ToString();
            //        c7.DataPropertyName = dt.Columns["deliveryDate"].ToString();
            //        c8.DataPropertyName = dt.Columns["totalAmount"].ToString();
            //        c9.DataPropertyName = dt.Columns["advance"].ToString();
            //        c10.DataPropertyName = dt.Columns["balance"].ToString();
            //        dataGridView1.DataSource = dt;
            //    }
            //    else
            //    {
            //        MessageBox.Show("No record Found!");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void seaach_TextChanged(object sender, EventArgs e)
        {
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txt_search_Validating(object sender, CancelEventArgs e)
        {

        }
        string qu;
        private void searching_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(searching.Text))
                {
                    qu = "select * from CustomerDetails";
                    
                }
                else {
                    qu = "select * from CustomerDetails where Code  like  '%"+searching.Text+"%' or Name like '%"+searching.Text+"%' or Number like '%"+searching.Text+"%'";
                }
                SQLiteCommand cmd = new SQLiteCommand(qu, Main.con);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                c1.DataPropertyName = dt.Columns["Code"].ToString();
                c2.DataPropertyName = dt.Columns["Name"].ToString();
                c3.DataPropertyName = dt.Columns["Number"].ToString();
                c8.DataPropertyName = dt.Columns["totalamount"].ToString();
                c9.DataPropertyName = dt.Columns["advance"].ToString();
                c10.DataPropertyName = dt.Columns["balance"].ToString();
                dataGridView1.DataSource = dt;
                //Main.con.Open();
                //SqlCommand cmd = new SqlCommand("showdata", Main.con);
                //cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@code",searching.Text);
                //SqlDataAdapter sda = new SqlDataAdapter(cmd);
                //DataTable dt = new DataTable();
                //sda.Fill(dt);

                //c1.DataPropertyName = dt.Columns["code"].ToString();
                //c2.DataPropertyName = dt.Columns["name"].ToString();
                //c3.DataPropertyName = dt.Columns["phoneNo"].ToString();
                //c4.DataPropertyName = dt.Columns["suitType"].ToString();
                //C5.DataPropertyName = dt.Columns["totalSuit"].ToString();
                //c6.DataPropertyName = dt.Columns["orderDate"].ToString();
                //c7.DataPropertyName = dt.Columns["deliveryDate"].ToString();
                //c8.DataPropertyName = dt.Columns["totalAmount"].ToString();
                //c9.DataPropertyName = dt.Columns["advance"].ToString();
                //c10.DataPropertyName = dt.Columns["balance"].ToString();
                //dataGridView1.DataSource = dt;

                Main.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
       // int suitType ;
        private void btn_delete_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (dataGridView1.CurrentRow.Cells[3].Value.ToString() == "Shalwar Kameez")
            //    {
            //        suitType = 0;

            //    }
            //    else if (dataGridView1.CurrentRow.Cells[3].Value.ToString() == "West Coat")
            //    {
            //        suitType = 1;
            //    }
            //    else if (dataGridView1.CurrentRow.Cells[3].Value.ToString() == "Coat")
            //    {
            //        suitType = 2;
            //    }
            //    else if (dataGridView1.CurrentRow.Cells[3].Value.ToString() == "Shirt")
            //    {
            //        suitType = 3;
            //    }
            //    else if (dataGridView1.CurrentRow.Cells[3].Value.ToString() == "Pant")
            //    {
            //        suitType = 4;
            //    }
            //    //SqlCommand cmd = new SqlCommand("deleteData", Main.con);
            //    //cmd.CommandType = CommandType.StoredProcedure;
            //    //cmd.Parameters.AddWithValue("@code",dataGridView1.CurrentRow.Cells[0].Value);
            //    //cmd.Parameters.AddWithValue("@suitType", suitType);
            //    //Main.con.Open();
            //    //cmd.ExecuteNonQuery();
            //   DialogResult dr = MessageBox.Show("Deleted!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //finally
            //{
            //    Main.con.Close();
            //}
        }
        Order o = new Order();
        private void btn_editOrderDetails_Click(object sender, EventArgs e)
        {
            try
            {
                
                o.txt_code.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                o.txt_Name.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                o.txt_phoneNo.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                o.txt_TotalAmount.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                o.txt_advance.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
                o.txt_Balance.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
                o.txt_code.Enabled = false;
                o.txt_phoneNo.Enabled = true;
                o.txt_Name.Enabled = true;
                o.txt_TotalSuit.Enabled = true;
                o.txt_TotalAmount.Enabled = true;
                o.txt_advance.Enabled = true;
                o.CB_suitType.Enabled = true;

                o.txt_daman.Enabled = false;
                o.txt_sleaves.Enabled = false;
                o.txt_payncha.Enabled = false;
                o.txt_shalwar.Enabled = false;
                o.txt_belly.Enabled = false;
                o.txt_cFull.Enabled = false;
                o.txt_chest.Enabled = false;
                o.txt_collor.Enabled = false;
                o.txt_extra.Enabled = false;
                o.txt_length.Enabled = false;
                o.txt_shoulder.Enabled = false;
                o.txt_waist.Enabled = false;
                o.txt_hips.Enabled = false;
                o.txt_thais.Enabled = false;
                o.CB_dtype.Enabled = false;
                o.CB_shalwarPocket.Enabled = false;
                o.CB_Fpocket.Enabled = false;
                o.CB_Shalwartype.Enabled = false;
                o.CB_sidePocket.Enabled = false;
                o.CB_Ctype.Enabled = false;
                o.CB_sewing.Enabled = false;

                o.txt_daman.BackColor = Color.LightGray;
                o.txt_code.BackColor = Color.LightGray;
                o.txt_phoneNo.BackColor = Color.WhiteSmoke;
                o.txt_Name.BackColor = Color.WhiteSmoke;
                o.txt_sleaves.BackColor = Color.LightGray;
                o.txt_payncha.BackColor = Color.LightGray;
                o.txt_shalwar.BackColor = Color.LightGray;
                o.txt_belly.BackColor = Color.LightGray;
                o.txt_cFull.BackColor = Color.LightGray;
                o.txt_chest.BackColor = Color.LightGray;
                o.txt_collor.BackColor = Color.LightGray;
                o.txt_extra.BackColor = Color.LightGray;
                o.txt_length.BackColor = Color.LightGray;
                o.txt_shoulder.BackColor = Color.LightGray;
                o.txt_waist.BackColor = Color.LightGray;
                o.txt_hips.BackColor = Color.LightGray;
                o.txt_thais.BackColor = Color.LightGray;
                o.CB_dtype.BackColor = Color.LightGray;
                o.CB_shalwarPocket.BackColor = Color.LightGray;
                o.CB_Fpocket.BackColor = Color.LightGray;
                o.CB_Shalwartype.BackColor = Color.LightGray;
                o.CB_sidePocket.BackColor = Color.LightGray;
                o.CB_Ctype.BackColor = Color.LightGray;
                o.CB_sewing.BackColor = Color.LightGray;
                o.btn_savedata.Visible = true;
                o.update = true;
                Main.show(o, this, MDI.ActiveForm);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btn_editSize_Click(object sender, EventArgs e)
        {
            try
                {
                    Order o = new Order();
                    o.txt_code.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    o.txt_Name.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    o.txt_phoneNo.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    o.txt_code.Enabled = false;
                    o.txt_phoneNo.Enabled = false;
                    o.txt_Name.Enabled = false;
                    o.date_Order.Enabled = true;
                    o.date_delivery.Enabled = true;
                    o.txt_TotalSuit.Enabled = true;
                    o.txt_TotalAmount.Enabled = false;
                    o.txt_advance.Enabled = false;
                    o.txt_TotalAmount.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    o.txt_advance.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    o.txt_Balance.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
                    o.CB_suitType.Enabled = true;
                    o.txt_code.BackColor = Color.LightGray;
                    o.txt_Name.BackColor = Color.LightGray;
                    o.txt_phoneNo.BackColor = Color.LightGray;
                    o.date_Order.BackColor = Color.LightGray;
                    o.date_delivery.BackColor = Color.LightGray;
                    o.txt_advance.BackColor = Color.LightGray;
                    o.txt_Balance.BackColor = Color.LightGray;
                    o.txt_TotalAmount.BackColor = Color.LightGray;
                    o.txt_TotalSuit.BackColor = Color.LightGray;

                    o.txt_daman.Enabled = true;
                    o.txt_sleaves.Enabled = true;
                    o.txt_payncha.Enabled = true;
                    o.txt_shalwar.Enabled = true;
                    o.txt_belly.Enabled = true;
                    o.txt_cFull.Enabled = true;
                    o.txt_chest.Enabled = true;
                    o.txt_collor.Enabled = true;
                    o.txt_extra.Enabled = true;
                    o.txt_length.Enabled = true;
                    o.txt_shoulder.Enabled = true;
                    o.txt_waist.Enabled = true;
                    o.txt_hips.Enabled = true;
                    o.txt_thais.Enabled = true;
                    o.CB_dtype.Enabled = true;
                    o.CB_shalwarPocket.Enabled = true;
                    o.CB_Fpocket.Enabled = true;
                    o.CB_Shalwartype.Enabled = true;
                    o.CB_sidePocket.Enabled = true;
                    o.CB_Ctype.Enabled = true;
                    o.CB_sewing.Enabled = true;
                    o.txt_daman.BackColor = Color.WhiteSmoke;
                    o.txt_sleaves.BackColor = Color.WhiteSmoke;
                    o.txt_payncha.BackColor = Color.WhiteSmoke;
                    o.txt_shalwar.BackColor = Color.WhiteSmoke;
                    o.txt_belly.BackColor = Color.WhiteSmoke;
                    o.txt_cFull.BackColor = Color.WhiteSmoke;
                    o.txt_chest.BackColor = Color.WhiteSmoke;
                    o.txt_collor.BackColor = Color.WhiteSmoke;
                    o.txt_extra.BackColor = Color.WhiteSmoke;
                    o.txt_length.BackColor = Color.WhiteSmoke;
                    o.txt_shoulder.BackColor = Color.WhiteSmoke;
                    o.txt_waist.BackColor = Color.WhiteSmoke;
                    o.txt_hips.BackColor = Color.WhiteSmoke;
                    o.txt_thais.BackColor = Color.WhiteSmoke;
                    o.CB_dtype.BackColor = Color.WhiteSmoke;
                    o.CB_shalwarPocket.BackColor = Color.WhiteSmoke;
                    o.CB_Fpocket.BackColor = Color.WhiteSmoke;
                    o.CB_Shalwartype.BackColor = Color.WhiteSmoke;
                    o.CB_sidePocket.BackColor = Color.WhiteSmoke;
                    o.CB_Ctype.BackColor = Color.WhiteSmoke;
                    o.CB_sewing.BackColor = Color.WhiteSmoke;

                    o.btn_savedata.Visible = true;
                Main.show(o,this,MDI.ActiveForm);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Detail_Load(object sender, EventArgs e)
        {
            dataGridView1.Font = new Font("Arial", 12);
            try
            {
                string q = "select * from CustomerDetails";
                SQLiteCommand cmd = new SQLiteCommand(q, Main.con);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                c1.DataPropertyName = dt.Columns["Code"].ToString();
                c2.DataPropertyName = dt.Columns["Name"].ToString();
                c3.DataPropertyName = dt.Columns["Number"].ToString();
                c8.DataPropertyName = dt.Columns["totalamount"].ToString();
                c9.DataPropertyName = dt.Columns["advance"].ToString();
                c10.DataPropertyName = dt.Columns["balance"].ToString();
                dataGridView1.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
        public void Clear()
        {
            o.txt_daman.Text = "";
            o.txt_sleaves.Text = "";
            o.txt_payncha.Text = "";
            o.txt_shalwar.Text = "";

            o.txt_belly.Text = "";
            o.txt_cFull.Text = "";
            o.txt_chest.Text = "";

            o.txt_collor.Text = "";
            o.txt_extra.Text = "";
            o.txt_length.Text = "";

            o.txt_shoulder.Text = "";

            o.txt_waist.Text = "";
            o.txt_hips.Text = "";
            o.txt_thais.Text = "";

            o.CB_dtype.Text = "";
            o.CB_shalwarPocket.Text = "";
            o.CB_Fpocket.Text = "";
            o.CB_Shalwartype.Text = "";
            o.CB_sidePocket.Text = "";
            o.CB_Ctype.Text = "";
            o.CB_sewing.Text = "";

        }
        
        private void shalwarKameezToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                condition = 1;
                ShowReport report = new ShowReport();
                a = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
                report.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //try
            //{
            //    Clear();
            //    quer = "select * from shalwarKameez where Code='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'";
            //    SQLiteCommand cmd = new SQLiteCommand(quer, Main.con);
            //    Main.con.Open();
            //    SQLiteDataReader dr = cmd.ExecuteReader();
            //    if (dr.HasRows)
            //    {
            //        while (dr.Read())
            //        {
            //            o.txt_length.Text = dr[0].ToString();
            //            o.txt_sleaves.Text = dr[1].ToString();
            //            o.txt_shoulder.Text = dr[2].ToString();
            //            o.txt_collor.Text = dr[3].ToString();
            //            o.txt_chest.Text = dr[4].ToString();
            //            o.txt_cFull.Text = dr[5].ToString();
            //            o.txt_daman.Text = dr[6].ToString();
            //            o.CB_dtype.Text = dr[7].ToString();
            //            o.txt_shalwar.Text = dr[8].ToString();
            //            o.txt_payncha.Text = dr[9].ToString();
            //            o.CB_shalwarPocket.Text = dr[10].ToString();
            //            o.CB_sewing.Text = dr[11].ToString();
            //            o.CB_Fpocket.Text = dr[12].ToString();
            //            o.CB_sidePocket.Text = dr[13].ToString();
            //            o.CB_Shalwartype.Text = dr[14].ToString();
            //            o.CB_Ctype.Text = dr[15].ToString();
            //            o.txt_extra.Text = dr[16].ToString();
            //            o.txt_TotalSuit.Text = dr[18].ToString();
            //            o.date_Order.Value = Convert.ToDateTime(dr[19].ToString());
            //            o.date_Order.Value = Convert.ToDateTime(dr[20].ToString());
            //            Main.show(o, this, MDI.ActiveForm);
            //        }
            //    }
            //    else
            //    {
            //        message();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //finally
            //{
            //    Main.con.Close();
            //}

            //o.txt_belly.Enabled = false;
            //o.txt_thais.Enabled = false;
            //o.txt_waist.Enabled = false;
            //o.txt_hips.Enabled = false;

            //o.txt_belly.BackColor = Color.LightGray;
            //o.txt_hips.BackColor = Color.LightGray;
            //o.txt_thais.BackColor = Color.LightGray;
            //o.txt_waist.BackColor = Color.LightGray;


            //o.txt_length.Enabled = true;
            //o.txt_sleaves.Enabled = true;
            //o.txt_shoulder.Enabled = true;
            //o.txt_collor.Enabled = true;
            //o.txt_chest.Enabled = true;
            //o.txt_cFull.Enabled = true;
            //o.txt_daman.Enabled = true;
            //o.CB_dtype.Enabled = true;
            //o.txt_shalwar.Enabled = true;
            //o.txt_payncha.Enabled = true;
            //o.CB_shalwarPocket.Enabled = true;
            //o.CB_sewing.Enabled = true;
            //o.CB_Fpocket.Enabled = true;
            //o.CB_sidePocket.Enabled = true;
            //o.CB_Shalwartype.Enabled = true;
            //o.CB_Ctype.Enabled = true;
            //o.txt_extra.Enabled = true;



            //o.txt_length.BackColor = Color.WhiteSmoke;
            //o.txt_sleaves.BackColor = Color.WhiteSmoke;
            //o.txt_shoulder.BackColor = Color.WhiteSmoke;
            //o.txt_collor.BackColor = Color.WhiteSmoke;
            //o.txt_chest.BackColor = Color.WhiteSmoke;
            //o.txt_cFull.BackColor = Color.WhiteSmoke;
            //o.txt_daman.BackColor = Color.WhiteSmoke;
            //o.CB_dtype.BackColor = Color.WhiteSmoke;
            //o.txt_shalwar.BackColor = Color.WhiteSmoke;
            //o.txt_payncha.BackColor = Color.WhiteSmoke;
            //o.CB_shalwarPocket.BackColor = Color.WhiteSmoke;
            //o.CB_sewing.BackColor = Color.WhiteSmoke;
            //o.CB_Fpocket.BackColor = Color.WhiteSmoke;
            //o.CB_sidePocket.BackColor = Color.WhiteSmoke;
            //o.CB_Shalwartype.BackColor = Color.WhiteSmoke;
            //o.CB_Ctype.BackColor = Color.WhiteSmoke;
            //o.txt_extra.BackColor = Color.WhiteSmoke;

        }

        private void westCoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                condition = 2;
                ShowReport report = new ShowReport();
                a = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
                report.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //try
            //{
            //    Clear();
            //    quer = "select * from westcoat where Code='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'";
            //    SQLiteCommand cmd = new SQLiteCommand(quer, Main.con);
            //    Main.con.Open();
            //    SQLiteDataReader dr = cmd.ExecuteReader();
            //    if (dr.HasRows)
            //    {
            //        while (dr.Read())
            //        {
            //            o.txt_length.Text = dr["length"].ToString();
            //            o.txt_shoulder.Text = dr["shoulder"].ToString();
            //            o.txt_collor.Text = dr["necksize"].ToString();
            //            o.txt_chest.Text = dr["chest"].ToString();
            //            o.txt_cFull.Text = dr["chestfull"].ToString();
            //            o.CB_sewing.Text = dr["sewing"].ToString();
            //            o.txt_extra.Text = dr["extras"].ToString();
            //            o.txt_TotalSuit.Text = dr["totalsuit"].ToString();
            //            o.date_Order.Value = Convert.ToDateTime(dr["orderdate"].ToString());
            //            o.date_delivery.Value = Convert.ToDateTime(dr["deliverydate"].ToString());
            //            Main.show(o, this, MDI.ActiveForm);
            //        }
            //    }
            //    else
            //    {
            //        message();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //finally
            //{
            //    Main.con.Close();
            //}
            //o.txt_daman.Enabled = false;
            //o.txt_sleaves.Enabled = false;
            //o.txt_payncha.Enabled = false;
            //o.txt_shalwar.Enabled = false;
            //o.CB_dtype.Enabled = false;
            //o.CB_shalwarPocket.Enabled = false;
            //o.CB_Fpocket.Enabled = false;
            //o.CB_Shalwartype.Enabled = false;
            //o.CB_sidePocket.Enabled = false;
            //o.CB_Ctype.Enabled = false;
            //o.txt_thais.Enabled = false;
            //o.txt_waist.Enabled = false;
            //o.txt_hips.Enabled = false;

            //o.txt_daman.BackColor = Color.LightGray;
            //o.txt_payncha.BackColor = Color.LightGray;
            //o.txt_shalwar.BackColor = Color.LightGray;
            //o.txt_sleaves.BackColor = Color.LightGray;
            //o.CB_dtype.BackColor = Color.LightGray;
            //o.CB_shalwarPocket.BackColor = Color.LightGray;
            //o.CB_Fpocket.BackColor = Color.LightGray;
            //o.CB_Shalwartype.BackColor = Color.LightGray;
            //o.CB_sidePocket.BackColor = Color.LightGray;
            //o.CB_Ctype.BackColor = Color.LightGray;
            //o.txt_hips.BackColor = Color.LightGray;
            //o.txt_thais.BackColor = Color.LightGray;
            //o.txt_waist.BackColor = Color.LightGray;

            //o.txt_length.Enabled = true;
            //o.txt_shoulder.Enabled = true;
            //o.txt_collor.Enabled = true;
            //o.txt_chest.Enabled = true;
            //o.txt_cFull.Enabled = true;
            //o.CB_sewing.Enabled = true;
            //o.txt_extra.Enabled = true;



            //o.txt_length.BackColor = Color.WhiteSmoke;
            //o.txt_shoulder.BackColor = Color.WhiteSmoke;
            //o.txt_collor.BackColor = Color.WhiteSmoke;
            //o.txt_chest.BackColor = Color.WhiteSmoke;
            //o.txt_cFull.BackColor = Color.WhiteSmoke;
            //o.CB_sewing.BackColor = Color.WhiteSmoke;
            //o.txt_extra.BackColor = Color.WhiteSmoke;

        }

        private void coatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                condition = 3;
                ShowReport report = new ShowReport();
                a = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
                report.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //try
            //{
            //    Clear();
            //    quer = "select * from coat where Code='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'";
            //    SQLiteCommand cmd = new SQLiteCommand(quer, Main.con);
            //    Main.con.Open();
            //    SQLiteDataReader dr = cmd.ExecuteReader();
            //    if (dr.HasRows)
            //    {
            //        while (dr.Read())
            //        {
            //           o.txt_length.Text = dr["length"].ToString();
            //            o.txt_sleaves.Text = dr["sleeves"].ToString();
            //            o.txt_collor.Text = dr["necksize"].ToString();
            //            o.txt_chest.Text = dr["chest"].ToString();
            //            o.txt_belly.Text = dr["belly"].ToString();
            //            o.txt_cFull.Text = dr["chestfull"].ToString();
            //            o.CB_sewing.Text = dr["sewing"].ToString();
            //            o.txt_extra.Text = dr["extras"].ToString();
            //            o.txt_TotalSuit.Text = dr["totalsuit"].ToString();
            //            o.date_Order.Value = Convert.ToDateTime(dr["orderdate"].ToString());
            //            o.date_delivery.Value = Convert.ToDateTime(dr["deliverydate"].ToString());
            //            Main.show(o, this, MDI.ActiveForm);
            //        }
            //    }
            //    else
            //    {
            //        message();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //finally
            //{
            //    Main.con.Close();
            //}
            //o.CB_Ctype.Enabled = false;
            //o.txt_daman.Enabled = false;
            //o.txt_payncha.Enabled = false;
            //o.txt_shalwar.Enabled = false;
            //o.CB_dtype.Enabled = false;
            //o.CB_shalwarPocket.Enabled = false;
            //o.CB_Fpocket.Enabled = false;
            //o.CB_Shalwartype.Enabled = false;
            //o.CB_sidePocket.Enabled = false;
            //o.txt_thais.Enabled = false;
            //o.txt_waist.Enabled = false;
            //o.txt_hips.Enabled = false;

            //o.txt_daman.BackColor = Color.LightGray;
            //o.txt_payncha.BackColor = Color.LightGray;
            //o.txt_shalwar.BackColor = Color.LightGray;
            //o.CB_dtype.BackColor = Color.LightGray;
            //o.CB_shalwarPocket.BackColor = Color.LightGray;
            //o.CB_Fpocket.BackColor = Color.LightGray;
            //o.CB_Shalwartype.BackColor = Color.LightGray;
            //o.CB_sidePocket.BackColor = Color.LightGray;
            //o.CB_Ctype.BackColor = Color.LightGray;
            //o.txt_hips.BackColor = Color.LightGray;
            //o.txt_thais.BackColor = Color.LightGray;
            //o.txt_waist.BackColor = Color.LightGray;

            //o.txt_length.Enabled = true;
            //o.txt_sleaves.Enabled = true;
            //o.txt_shoulder.Enabled = true;
            //o.txt_collor.Enabled = true;
            //o.txt_chest.Enabled = true;
            //o.txt_belly.Enabled = true;
            //o.txt_cFull.Enabled = true;
            //o.CB_sewing.Enabled = true;
            //o.txt_extra.Enabled = true;



            //o.txt_length.BackColor = Color.WhiteSmoke;
            //o.txt_sleaves.BackColor = Color.WhiteSmoke;
            //o.txt_shoulder.BackColor = Color.WhiteSmoke;
            //o.txt_collor.BackColor = Color.WhiteSmoke;
            //o.txt_chest.BackColor = Color.WhiteSmoke;
            //o.txt_belly.BackColor = Color.WhiteSmoke;
            //o.txt_cFull.BackColor = Color.WhiteSmoke;
            //o.CB_sewing.BackColor = Color.WhiteSmoke;
            //o.txt_extra.BackColor = Color.WhiteSmoke;

        }

        private void shirtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                condition = 4;
                ShowReport report = new ShowReport();
                a = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
                report.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //try
            //{
            //    Clear();
            //    quer = "select * from shirt where Code='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'";
            //    SQLiteCommand cmd = new SQLiteCommand(quer, Main.con);
            //    Main.con.Open();
            //    SQLiteDataReader dr = cmd.ExecuteReader();
            //    if (dr.HasRows)
            //    {
            //        while (dr.Read())
            //        {
            //            o.txt_length.Text = dr["length"].ToString();
            //            //  o.txt_sleaves.Text = dr[1].ToString();
            //            o.txt_shoulder.Text = dr["shoulder"].ToString();
            //            o.txt_collor.Text = dr["necksize"].ToString();
            //            o.txt_chest.Text = dr["chest"].ToString();
            //            o.txt_belly.Text = dr["belly"].ToString();
            //            o.txt_cFull.Text = dr["chestfull"].ToString();
            //            o.CB_dtype.Text = dr["damantype"].ToString();
            //            o.CB_sewing.Text = dr["sewing"].ToString();
            //            o.CB_Fpocket.Text = dr["fronttyoe"].ToString();
            //            o.CB_Ctype.Text = dr["collortype"].ToString();
            //            o.txt_extra.Text = dr["extras"].ToString();
            //            o.txt_TotalSuit.Text = dr["totalsuit"].ToString();
            //            o.date_Order.Value = Convert.ToDateTime(dr["orderdate"].ToString());
            //            o.date_delivery.Value = Convert.ToDateTime(dr["deliverydate"].ToString());
            //            Main.show(o, this, MDI.ActiveForm);
            //        }
            //    }
            //    else
            //    {
            //        message();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //finally
            //{
            //    Main.con.Close();
            //}
            //o.txt_daman.Enabled = false;
            //o.txt_payncha.Enabled = false;
            //o.txt_shalwar.Enabled = false;
            //o.CB_shalwarPocket.Enabled = false;
            //o.CB_Shalwartype.Enabled = false;
            //o.CB_sidePocket.Enabled = false;
            //o.txt_thais.Enabled = false;
            //o.txt_waist.Enabled = false;
            //o.txt_hips.Enabled = false;


            //o.txt_daman.BackColor = Color.LightGray;
            //o.txt_payncha.BackColor = Color.LightGray;
            //o.txt_shalwar.BackColor = Color.LightGray;
            //o.txt_hips.BackColor = Color.LightGray;
            //o.txt_thais.BackColor = Color.LightGray;
            //o.txt_waist.BackColor = Color.LightGray;
            //o.CB_shalwarPocket.BackColor = Color.LightGray;
            //o.CB_Shalwartype.BackColor = Color.LightGray;
            //o.CB_sidePocket.BackColor = Color.LightGray;

            //o.txt_length.Enabled = true;
            //o.txt_sleaves.Enabled = true;
            //o.txt_shoulder.Enabled = true;
            //o.txt_collor.Enabled = true;
            //o.txt_chest.Enabled = true;
            //o.txt_belly.Enabled = true;
            //o.txt_cFull.Enabled = true;
            //o.CB_dtype.Enabled = true;
            //o.CB_sewing.Enabled = true;
            //o.CB_Fpocket.Enabled = true;
            //o.CB_Ctype.Enabled = true;
            //o.txt_extra.Enabled = true;



            //o.txt_length.BackColor = Color.WhiteSmoke;
            //o.txt_sleaves.BackColor = Color.WhiteSmoke;
            //o.txt_shoulder.BackColor = Color.WhiteSmoke;
            //o.txt_collor.BackColor = Color.WhiteSmoke;
            //o.txt_chest.BackColor = Color.WhiteSmoke;
            //o.txt_belly.BackColor = Color.WhiteSmoke;
            //o.txt_cFull.BackColor = Color.WhiteSmoke;
            //o.CB_dtype.BackColor = Color.WhiteSmoke;
            //o.CB_sewing.BackColor = Color.WhiteSmoke;
            //o.CB_Fpocket.BackColor = Color.WhiteSmoke;
            //o.CB_Ctype.BackColor = Color.WhiteSmoke;
            //o.txt_extra.BackColor = Color.WhiteSmoke;
        }

        public void message()
        {
            MessageBox.Show("No Data Found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void pantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                condition = 5;
                ShowReport report = new ShowReport();
                a = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
                report.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //try
            //{
            //    Clear();
            //    quer = "select * from pant where Code='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'";
            //    SQLiteCommand cmd = new SQLiteCommand(quer, Main.con);
            //    Main.con.Open();
            //    SQLiteDataReader dr = cmd.ExecuteReader();
            //    if (dr.HasRows)
            //    {
            //        while (dr.Read())
            //        {
            //            o.txt_length.Text = dr["length"].ToString();
            //            o.txt_waist.Text = dr["waist"].ToString();
            //            o.txt_hips.Text = dr["hips"].ToString();
            //            o.txt_thais.Text = dr["thais"].ToString();
            //            o.CB_sewing.Text = dr["sewing"].ToString();
            //            o.txt_extra.Text = dr["extra"].ToString();
            //            o.txt_code.Text = dr["code"].ToString();
            //            o.txt_TotalSuit.Text = dr["totalsuit"].ToString();
            //            o.date_Order.Value = Convert.ToDateTime(dr["orderdate"].ToString());
            //            o.date_delivery.Value = Convert.ToDateTime(dr["deliverydate"].ToString());
            //            Main.show(o, this, MDI.ActiveForm);
            //        }
            //    }
            //    else
            //    {
            //        message();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //finally
            //{
            //    Main.con.Close();
            //}
            //o.CB_Ctype.Enabled = false;
            //o.txt_daman.Enabled = false;
            //o.txt_sleaves.Enabled = false;
            //o.txt_payncha.Enabled = false;
            //o.txt_shalwar.Enabled = false;
            //o.CB_dtype.Enabled = false;
            //o.CB_shalwarPocket.Enabled = false;
            //o.CB_Fpocket.Enabled = false;
            //o.CB_Shalwartype.Enabled = false;
            //o.CB_sidePocket.Enabled = false;
            //o.txt_shoulder.Enabled = false;
            //o.txt_collor.Enabled = false;
            //o.txt_chest.Enabled = false;
            //o.txt_belly.Enabled = false;
            //o.txt_cFull.Enabled = false;



            //o.txt_daman.BackColor = Color.LightGray;
            //o.txt_payncha.BackColor = Color.LightGray;
            //o.txt_shalwar.BackColor = Color.LightGray;
            //o.txt_sleaves.BackColor = Color.LightGray;
            //o.CB_dtype.BackColor = Color.LightGray;
            //o.CB_shalwarPocket.BackColor = Color.LightGray;
            //o.CB_Fpocket.BackColor = Color.LightGray;
            //o.CB_Shalwartype.BackColor = Color.LightGray;
            //o.CB_sidePocket.BackColor = Color.LightGray;
            //o.CB_Ctype.BackColor = Color.LightGray;
            //o.txt_shoulder.BackColor = Color.LightGray;
            //o.txt_collor.BackColor = Color.LightGray;
            //o.txt_chest.BackColor = Color.LightGray;
            //o.txt_belly.BackColor = Color.LightGray;
            //o.txt_cFull.BackColor = Color.LightGray;

            //o.txt_length.Enabled = true;
            //o.txt_waist.Enabled = true;
            //o.txt_hips.Enabled = true;
            //o.txt_thais.Enabled = true;
            //o.CB_sewing.Enabled = true;
            //o.txt_extra.Enabled = true;



            //o.txt_length.BackColor = Color.WhiteSmoke;
            //o.txt_waist.BackColor = Color.WhiteSmoke;
            //o.txt_hips.BackColor = Color.WhiteSmoke;
            //o.txt_thais.BackColor = Color.WhiteSmoke;
            //o.CB_sewing.BackColor = Color.WhiteSmoke;
            //o.txt_extra.BackColor = Color.WhiteSmoke;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int id=Convert.ToInt32( this.dataGridView1.CurrentRow.Cells[0].Value.ToString()); 
                Main.con.Open();
                //string query = "delete from CustomerDetails where Code = dataGridView1.CurrentRow.Cells[0].Value.ToString() ";
                string query = "delete from CustomerDetails where Code  ="+id+" ";
                SQLiteCommand cmd = new SQLiteCommand(query, Main.con);
                cmd.ExecuteNonQuery();
                DialogResult DR = MessageBox.Show("Successfully Deleted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (DR == DialogResult.OK)
                {
                    string q = "select * from CustomerDetails";
                    SQLiteCommand cmd1 = new SQLiteCommand(q, Main.con);
                    SQLiteDataAdapter da = new SQLiteDataAdapter(cmd1);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    c1.DataPropertyName = dt.Columns["Code"].ToString();
                    c2.DataPropertyName = dt.Columns["Name"].ToString();
                    c3.DataPropertyName = dt.Columns["Number"].ToString();
                    c8.DataPropertyName = dt.Columns["totalamount"].ToString();
                    c9.DataPropertyName = dt.Columns["advance"].ToString();
                    c10.DataPropertyName = dt.Columns["balance"].ToString();
                    dataGridView1.DataSource = dt;
                }


            }
              catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Main.con.Close();
            }
        }
    }
}
