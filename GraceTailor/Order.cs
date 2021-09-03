using System;
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
    public partial class Order : Sample2
    {
        public bool update=false;
        string q;
        int checking=1;

        //Insertion s = new Insertion();
        SQLiteCommand cmd;
        public Order()
        {
            InitializeComponent();
            btn_savedata.Visible = true;
            txt_Balance.ReadOnly = true;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            //s.ins_cust(ct1.Text,ct2.Text,ct3.Text,ct4.Text);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        string quer;
        private void comboBox6_Validating(object sender, CancelEventArgs e)
        {
            if (CB_suitType.Text == "Shalwar Kameez")
            {
                try
                {
                    Clear();
                    quer = "select * from shalwarKameez where Code='" + txt_code.Text + "'";
                    SQLiteCommand cmd = new SQLiteCommand(quer, Main.con);
                    Main.con.Open();
                    SQLiteDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            txt_length.Text = dr[0].ToString();
                            txt_shoulder.Text = dr[2].ToString();
                            txt_sleaves.Text = dr[1].ToString();
                            txt_collor.Text = dr[3].ToString();
                            txt_cFull.Text = dr[5].ToString();
                            txt_chest.Text = dr[4].ToString();
                            txt_daman.Text = dr[6].ToString();
                            txt_shalwar.Text = dr[8].ToString();
                            txt_payncha.Text = dr[9].ToString();
                            CB_Fpocket.Text = dr[12].ToString();
                            CB_sidePocket.Text = dr[13].ToString();
                            CB_shalwarPocket.Text = dr[10].ToString();
                            CB_dtype.Text = dr[7].ToString();
                            CB_Ctype.Text = dr[15].ToString();
                            CB_ban.Text = dr[16].ToString();
                            CB_Shalwartype.Text = dr[14].ToString();
                            CB_sewing.Text = dr[11].ToString();
                            txt_extra.Text = dr[17].ToString();

                            txt_TotalSuit.Text = dr[19].ToString();
                            date_Order.Value = Convert.ToDateTime(dr[20].ToString());
                            date_delivery.Value = Convert.ToDateTime(dr[21].ToString());
                        }
                        update= true;
                    }
                    else
                    {
                        update = false;
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
               
                txt_belly.Enabled = false;
                txt_thais.Enabled = false;
                txt_waist.Enabled = false;
                txt_hips.Enabled = false;
                CB_chak.Enabled = false;
                CB_button.Enabled = false;

                txt_belly.BackColor = Color.LightGray;
                txt_hips.BackColor = Color.LightGray;
                txt_thais.BackColor = Color.LightGray;
                txt_waist.BackColor = Color.LightGray;
                CB_chak.BackColor = Color.LightGray;
                CB_button.BackColor = Color.LightGray;

              
                txt_length.     Enabled = true;
                txt_shoulder.   Enabled = true;
                txt_sleaves.    Enabled = true;
                txt_collor.     Enabled = true;
                txt_cFull.      Enabled = true;
                txt_chest.      Enabled = true;
                txt_daman.      Enabled = true;
                txt_shalwar.    Enabled = true;
                txt_payncha.    Enabled = true;
                CB_Fpocket.     Enabled = true;
                CB_sidePocket.  Enabled = true;
               CB_shalwarPocket.Enabled = true;
                CB_dtype.       Enabled = true;
                CB_Ctype.       Enabled = true;
                CB_ban.         Enabled = true;
                CB_Shalwartype. Enabled = true;
                CB_sewing.      Enabled = true;
                txt_extra.      Enabled = true;
                
                
                txt_length.     BackColor = Color.WhiteSmoke;
                txt_shoulder.   BackColor = Color.WhiteSmoke;
                txt_sleaves.    BackColor = Color.WhiteSmoke;
                txt_collor.     BackColor = Color.WhiteSmoke;
                txt_cFull.      BackColor = Color.WhiteSmoke;
                txt_chest.      BackColor = Color.WhiteSmoke;
                txt_daman.      BackColor = Color.WhiteSmoke;
                txt_shalwar.    BackColor = Color.WhiteSmoke;
                txt_payncha.    BackColor = Color.WhiteSmoke;
                CB_Fpocket.     BackColor = Color.WhiteSmoke;
                CB_sidePocket.  BackColor = Color.WhiteSmoke;
               CB_shalwarPocket.BackColor = Color.WhiteSmoke;
                CB_dtype.       BackColor = Color.WhiteSmoke;
                CB_Ctype.       BackColor = Color.WhiteSmoke;
                CB_ban.         BackColor = Color.WhiteSmoke;
                CB_Shalwartype. BackColor = Color.WhiteSmoke;
                CB_sewing.      BackColor = Color.WhiteSmoke;
                txt_extra.      BackColor = Color.WhiteSmoke;



            }
            else if (CB_suitType.Text == "West Coat")
            {
                try
                {
                    Clear();
                    quer = "select * from westcoat where Code='" + txt_code.Text + "'";
                    SQLiteCommand cmd = new SQLiteCommand(quer, Main.con);
                    Main.con.Open();
                    SQLiteDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            txt_length.Text = dr["length"].ToString();
                            txt_shoulder.Text = dr["shoulder"].ToString();
                            txt_chest.Text = dr["chest"].ToString();
                            txt_belly.Text = dr["belly"].ToString();
                            txt_collor.Text = dr["necksize"].ToString();
                            //  txt_cFull.Text = dr["chestfull"].ToString();
                            CB_Ctype.Text = dr["chestfull"].ToString(); // ctype values goes in chestfull b/c we don't need chestfull here.
                            CB_sewing.Text = dr["sewing"].ToString();
                            txt_extra.Text = dr["extras"].ToString();

                            txt_TotalSuit.Text = dr["totalsuit"].ToString();
                            date_Order.Value = Convert.ToDateTime(dr["orderdate"].ToString());
                            date_delivery.Value = Convert.ToDateTime(dr["deliverydate"].ToString());
                        }
                        update = true;
                    }
                    else
                    {
                        update = false;
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
                txt_daman.Enabled = false;
                txt_sleaves.Enabled = false;
                txt_payncha.Enabled = false;
                txt_shalwar.Enabled = false;
                CB_dtype.Enabled = false;
                CB_shalwarPocket.Enabled = false;
                CB_Fpocket.Enabled = false;
                CB_Shalwartype.Enabled = false;
                CB_sidePocket.Enabled = false;
                txt_cFull.Enabled = false;
                CB_button.Enabled = false;
                CB_ban.Enabled = false;
                txt_thais.Enabled = false;
                txt_waist.Enabled = false;
                txt_hips.Enabled = false;
                CB_chak.Enabled = false;

                txt_daman.BackColor = Color.LightGray;
                txt_payncha.BackColor = Color.LightGray;
                txt_shalwar.BackColor = Color.LightGray;
                txt_sleaves.BackColor = Color.LightGray;
                CB_dtype.BackColor = Color.LightGray;
                CB_shalwarPocket.BackColor = Color.LightGray;
                CB_Fpocket.BackColor = Color.LightGray;
                CB_Shalwartype.BackColor = Color.LightGray;
                CB_sidePocket.BackColor = Color.LightGray;
                txt_cFull.BackColor = Color.LightGray;
                txt_hips.BackColor = Color.LightGray;
                txt_thais.BackColor = Color.LightGray;
                txt_waist.BackColor = Color.LightGray;
                CB_button.BackColor = Color.LightGray;
                CB_chak.BackColor = Color.LightGray;
                CB_ban.BackColor = Color.LightGray;
                CB_ban.Text = "";

                txt_length.Enabled = true;
                txt_shoulder.Enabled = true;
                txt_collor.Enabled = true;
                txt_chest.Enabled = true;
                CB_Ctype.Enabled = true;
                CB_sewing.Enabled = true;
                txt_extra.Enabled = true;
                txt_belly.Enabled = true;



                txt_length.BackColor = Color.WhiteSmoke;
                txt_shoulder.BackColor = Color.WhiteSmoke;
                txt_collor.BackColor = Color.WhiteSmoke;
                txt_chest.BackColor = Color.WhiteSmoke;
                CB_Ctype.BackColor = Color.WhiteSmoke;
                CB_sewing.BackColor = Color.WhiteSmoke;
                txt_extra.BackColor = Color.WhiteSmoke;
                txt_belly.BackColor = Color.WhiteSmoke;

            }
            else if (CB_suitType.Text == "Coat")
            {
                try
                {
                    Clear();
                    quer = "select * from coat where Code='" + txt_code.Text + "'";
                    SQLiteCommand cmd = new SQLiteCommand(quer, Main.con);
                    Main.con.Open();
                    SQLiteDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            txt_length.Text= dr["length"].ToString();
                            txt_shoulder.Text = dr["shoulder"].ToString();
                            txt_sleaves.Text = dr["sleeves"].ToString();
                            txt_chest.Text = dr["chest"].ToString();
                            txt_belly.Text = dr["belly"].ToString();
                            // txt_collor.Text = dr["necksize"].ToString();
                            CB_button.Text = dr["necksize"].ToString(); // button value goes in necksize b/c we don't need necksize here. 
                            //txt_cFull.Text = dr["chestfull"].ToString();
                            CB_dtype.Text = dr["chestfull"].ToString(); // daman type goes in chestfull b/c we don't need chestfull here.
                           
                            CB_chak.Text = dr["chak"].ToString();
                            CB_sewing.Text = dr["sewing"].ToString();
                            txt_extra.Text = dr["extras"].ToString();

                            txt_TotalSuit.Text = dr["totalsuit"].ToString();
                            date_Order.Value = Convert.ToDateTime(dr["orderdate"].ToString());
                            date_delivery.Value = Convert.ToDateTime(dr["deliverydate"].ToString());
                        }
                        update = true;
                    }
                    else
                    {
                        update = false;
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
                CB_Ctype.Enabled = false;
                txt_daman.Enabled = false;
                txt_payncha.Enabled = false;
                txt_shalwar.Enabled = false;
                txt_cFull.Enabled = false;
                CB_shalwarPocket.Enabled = false;
                CB_Fpocket.Enabled = false;
                CB_Shalwartype.Enabled = false;
                CB_sidePocket.Enabled = false;
                txt_thais.Enabled = false;
                txt_waist.Enabled = false;
                txt_hips.Enabled = false;
                txt_collor.Enabled = false;
                CB_ban.Enabled = false;

                txt_daman.BackColor = Color.LightGray;
                txt_payncha.BackColor = Color.LightGray;
                txt_shalwar.BackColor = Color.LightGray;
                txt_cFull.BackColor = Color.LightGray;
                CB_shalwarPocket.BackColor = Color.LightGray;
                CB_Fpocket.BackColor = Color.LightGray;
                CB_Shalwartype.BackColor = Color.LightGray;
                CB_sidePocket.BackColor = Color.LightGray;
                CB_Ctype.BackColor = Color.LightGray;
                txt_hips.BackColor = Color.LightGray;
                txt_thais.BackColor = Color.LightGray;
                txt_waist.BackColor = Color.LightGray;
                txt_collor.BackColor = Color.LightGray;
                CB_ban.BackColor = Color.LightGray;

                txt_length.Enabled = true;
                txt_sleaves.Enabled = true;
                txt_shoulder.Enabled = true;
                txt_chest.Enabled = true;
                txt_belly.Enabled = true;
                CB_dtype.Enabled = true;
                CB_sewing.Enabled = true;
                txt_extra.Enabled = true;
                CB_button.Enabled = true;
                CB_chak.Enabled = true;


                txt_length.BackColor = Color.WhiteSmoke;
                txt_sleaves.BackColor = Color.WhiteSmoke;
                txt_shoulder.BackColor = Color.WhiteSmoke;
                txt_chest.BackColor = Color.WhiteSmoke;
                txt_belly.BackColor = Color.WhiteSmoke;
                CB_dtype.BackColor = Color.WhiteSmoke;
                CB_sewing.BackColor = Color.WhiteSmoke;
                txt_extra.BackColor = Color.WhiteSmoke;
                CB_button.BackColor = Color.WhiteSmoke;
                CB_chak.BackColor = Color.WhiteSmoke;

            }
            else if (CB_suitType.Text == "Shirt")
            {
                try
                {
                    Clear();
                    quer = "select * from shirt where Code='" + txt_code.Text + "'";
                    SQLiteCommand cmd = new SQLiteCommand(quer, Main.con);
                    Main.con.Open();
                    SQLiteDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            txt_length.Text = dr["length"].ToString();
                            txt_sleaves.Text = dr["sleaves"].ToString();
                            txt_shoulder.Text = dr["shoulder"].ToString();
                            txt_collor.Text = dr["necksize"].ToString();
                            txt_chest.Text = dr["chest"].ToString();
                            txt_belly.Text = dr["belly"].ToString();
                            txt_cFull.Text = dr["chestfull"].ToString();
                            CB_dtype.Text = dr["damantype"].ToString();
                            CB_sewing.Text = dr["sewing"].ToString();
                            CB_Fpocket.Text = dr["fronttyoe"].ToString();
                            CB_Ctype.Text= dr["collortype"].ToString();
                            txt_extra.Text = dr["extras"].ToString();
                            txt_TotalSuit.Text = dr["totalsuit"].ToString();
                            date_Order.Value = Convert.ToDateTime(dr["orderdate"].ToString());
                            date_delivery.Value = Convert.ToDateTime(dr["deliverydate"].ToString());
                        }
                        update = true;
                    }
                    else
                    {
                        update = false;
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
                txt_daman.Enabled = false;
                txt_payncha.Enabled = false;
                txt_shalwar.Enabled = false;
                CB_shalwarPocket.Enabled = false;
                CB_Shalwartype.Enabled = false;
                CB_sidePocket.Enabled = false;
                txt_thais.Enabled = false;
                txt_waist.Enabled = false;
                txt_hips.Enabled = false;
                

                txt_daman.BackColor = Color.LightGray;
                txt_payncha.BackColor = Color.LightGray;
                txt_shalwar.BackColor = Color.LightGray;
                txt_hips.BackColor = Color.LightGray;
                txt_thais.BackColor = Color.LightGray;
                txt_waist.BackColor = Color.LightGray;
                CB_shalwarPocket.BackColor = Color.LightGray;
                CB_Shalwartype.BackColor = Color.LightGray;
                CB_sidePocket.BackColor = Color.LightGray;

                txt_length.Enabled = true;
                txt_sleaves.Enabled = true;
                txt_shoulder.Enabled = true;
                txt_collor.Enabled = true;
                txt_chest.Enabled = true;
                txt_belly.Enabled = true;
                txt_cFull.Enabled = true;
                CB_dtype.Enabled = true;
                CB_sewing.Enabled = true;
                CB_Fpocket.Enabled = true;
                CB_Ctype.Enabled = true;
                txt_extra.Enabled = true;



                txt_length.BackColor = Color.WhiteSmoke;
                txt_sleaves.BackColor = Color.WhiteSmoke;
                txt_shoulder.BackColor = Color.WhiteSmoke;
                txt_collor.BackColor = Color.WhiteSmoke;
                txt_chest.BackColor = Color.WhiteSmoke;
                txt_belly.BackColor = Color.WhiteSmoke;
                txt_cFull.BackColor = Color.WhiteSmoke;
                CB_dtype.BackColor = Color.WhiteSmoke;
                CB_sewing.BackColor = Color.WhiteSmoke;
                CB_Fpocket.BackColor = Color.WhiteSmoke;
                CB_Ctype.BackColor = Color.WhiteSmoke;
                txt_extra.BackColor = Color.WhiteSmoke;
            }
            else if (CB_suitType.Text == "Pant")
            {
                try
                {
                    Clear();
                    quer = "select * from pant where Code='" + txt_code.Text + "'";
                    SQLiteCommand cmd = new SQLiteCommand(quer, Main.con);
                    Main.con.Open();
                    SQLiteDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            txt_length.Text = dr["length"].ToString();
                            txt_waist.Text = dr["waist"].ToString();
                            txt_hips.Text = dr["hips"].ToString();
                            txt_thais.Text = dr["thais"].ToString();
                            CB_sewing.Text = dr["sewing"].ToString();
                            txt_payncha.Text = dr["payncha"].ToString();
                            txt_extra.Text = dr["extra"].ToString();
                            txt_code.Text = dr["code"].ToString();
                            txt_TotalSuit.Text = dr["totalsuit"].ToString();
                            date_Order.Value = Convert.ToDateTime(dr["orderdate"].ToString());
                            date_delivery.Value = Convert.ToDateTime(dr["deliverydate"].ToString());
                        }
                        update = true;
                    }
                    else
                    {
                        update = false;
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
                CB_Ctype.Enabled = false;
                txt_daman.Enabled = false;
                txt_sleaves.Enabled = false;
                //txt_payncha.Enabled = false;
                txt_shalwar.Enabled = false;
                CB_dtype.Enabled = false;
                CB_shalwarPocket.Enabled = false;
                CB_Fpocket.Enabled = false;
                CB_Shalwartype.Enabled = false;
                CB_sidePocket.Enabled = false;
                txt_shoulder.Enabled = false;
                txt_collor.Enabled = false;
                txt_chest.Enabled = false;
                txt_belly.Enabled = false;
                txt_cFull.Enabled = false;



                txt_daman.BackColor = Color.LightGray;
                txt_payncha.BackColor = Color.WhiteSmoke;
                txt_shalwar.BackColor = Color.LightGray;
                txt_sleaves.BackColor = Color.LightGray;
                CB_dtype.BackColor = Color.LightGray;
                CB_shalwarPocket.BackColor = Color.LightGray;
                CB_Fpocket.BackColor = Color.LightGray;
                CB_Shalwartype.BackColor = Color.LightGray;
                CB_sidePocket.BackColor = Color.LightGray;
                CB_Ctype.BackColor = Color.LightGray;
                txt_shoulder.BackColor = Color.LightGray;
                txt_collor.BackColor = Color.LightGray;
                txt_chest.BackColor = Color.LightGray;
                txt_belly.BackColor = Color.LightGray;
                txt_cFull.BackColor = Color.LightGray;

                txt_length.Enabled = true;
                 txt_waist.Enabled = true;
                 txt_hips.Enabled = true;
                 txt_thais.Enabled = true;
                 CB_sewing.Enabled = true;
                 txt_extra.Enabled = true;



                txt_length.BackColor = Color.WhiteSmoke;
                txt_waist.BackColor = Color.WhiteSmoke;
                txt_hips.BackColor = Color.WhiteSmoke;
                txt_thais.BackColor = Color.WhiteSmoke;
                CB_sewing.BackColor = Color.WhiteSmoke;
                
                txt_extra.BackColor = Color.WhiteSmoke;

            }
        }
        public void Clear()
        {
            txt_daman.Text = "";
            txt_sleaves.Text = "";
            txt_payncha.Text = "";
            txt_shalwar.Text = "";
            
            txt_belly.Text = "";
            txt_cFull.Text = "";
            txt_chest.Text = "";
            txt_collor.Text = "";
            txt_extra.Text = "";
            txt_length.Text = "";
            txt_shoulder.Text = "";
            txt_waist.Text = "";
            txt_hips.Text = "";
            txt_thais.Text = "";
            CB_dtype.Text = "";
            CB_shalwarPocket.Text = "";
            CB_Fpocket.Text = "";
            CB_Shalwartype.Text = "";
            CB_sidePocket.Text = "";
            CB_Ctype.Text = "";
            CB_sewing.Text = "";
            CB_ban.Text = "";



            txt_belly.BackColor = Color.WhiteSmoke;
            txt_length.BackColor = Color.WhiteSmoke;
            txt_waist.BackColor = Color.WhiteSmoke;
            txt_hips.BackColor = Color.WhiteSmoke;
            txt_thais.BackColor = Color.WhiteSmoke;

            txt_length.BackColor = Color.WhiteSmoke;
            txt_sleaves.BackColor = Color.WhiteSmoke;
            txt_shoulder.BackColor = Color.WhiteSmoke;
            txt_collor.BackColor = Color.WhiteSmoke;
            txt_chest.BackColor = Color.WhiteSmoke;
            txt_cFull.BackColor = Color.WhiteSmoke;
            txt_daman.BackColor = Color.WhiteSmoke;
            CB_dtype.BackColor = Color.WhiteSmoke;
            txt_shalwar.BackColor = Color.WhiteSmoke;
            txt_payncha.BackColor = Color.WhiteSmoke;
            CB_shalwarPocket.BackColor = Color.WhiteSmoke;
            CB_sewing.BackColor = Color.WhiteSmoke;
            CB_Fpocket.BackColor = Color.WhiteSmoke;
            CB_sidePocket.BackColor = Color.WhiteSmoke;
            CB_Shalwartype.BackColor = Color.WhiteSmoke;
            CB_Ctype.BackColor = Color.WhiteSmoke;
            txt_extra.BackColor = Color.WhiteSmoke;
            CB_ban.BackColor = Color.WhiteSmoke;

            txt_length.Enabled = true;
            txt_daman.Enabled = true;
            txt_sleaves.Enabled = true;
            txt_payncha.Enabled = true;
            txt_shalwar.Enabled = true;
            txt_belly.Enabled = true;
            txt_cFull.Enabled = true;
            txt_chest.Enabled = true;
            txt_collor.Enabled = true;
            txt_extra.Enabled = true;
            txt_length.Enabled = true;
            txt_shoulder.Enabled = true;
            txt_waist.Enabled = true;
            txt_hips.Enabled = true;
            txt_thais.Enabled = true;
            CB_dtype.Enabled = true;
            CB_shalwarPocket.Enabled = true;
            CB_Fpocket.Enabled = true;
            CB_Shalwartype.Enabled = true;
            CB_sidePocket.Enabled = true;
            CB_Ctype.Enabled = true;
            CB_sewing.Enabled = true;
            CB_button.Enabled = true;
            CB_ban.Enabled = true;
            CB_chak.Enabled = true;

           

        }
        private void button2_Click(object sender, EventArgs e)
        {
            //when button "clear" is pressed
            CB_button.Text = "";
            CB_chak.Text = "";
            txt_advance.Text = "";
            txt_Balance.Text = "";
            txt_Name.Text = "";
            txt_phoneNo.Text = "";
            txt_TotalAmount.Text = "";
            txt_code.Text = "";
            txt_TotalSuit.Text = "";
            CB_suitType.Text = "";
            date_delivery.Value = System.DateTime.Now;
            date_Order.Value = System.DateTime.Now;
            Clear();


        }

        private void groupBox13_Enter(object sender, EventArgs e)
        {

        }
        public void DoneMessage()
        {
            DialogResult dr = MessageBox.Show("Successfully saved", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (dr == DialogResult.OK)
            {
                txt_code.Enabled = true;
                txt_Name.Enabled = true;
                txt_phoneNo.Enabled = true;
                txt_TotalSuit.Enabled = true;
                CB_suitType.Enabled = true;
                date_Order.Enabled = true;
                date_delivery.Enabled = true;
                txt_TotalAmount.Enabled = true;
                txt_advance.Enabled = true;
                txt_length.Enabled = true;
                txt_sleaves.Enabled = true;
                txt_shoulder.Enabled = true;
                txt_collor.Enabled = true;
                txt_chest.Enabled = true;
                txt_belly.Enabled = true;
                txt_cFull.Enabled = true;
                txt_daman.Enabled = true;
                CB_dtype.Enabled = true;
                txt_shalwar.Enabled = true;
                txt_payncha.Enabled = true;
                CB_shalwarPocket.Enabled = true;
                txt_waist.Enabled = true;
                txt_hips.Enabled = true;
                txt_thais.Enabled = true;
                CB_sewing.Enabled = true;
                CB_Fpocket.Enabled = true;
                CB_sidePocket.Enabled = true;
                CB_Shalwartype.Enabled = true;
                CB_Ctype.Enabled = true;
                txt_extra.Enabled = true;
                CB_button.Enabled = true;
                CB_ban.Enabled = true;
                CB_chak.Enabled = true;

                txt_code.BackColor = Color.WhiteSmoke;
                txt_Name.BackColor = Color.WhiteSmoke;
                txt_phoneNo.BackColor = Color.WhiteSmoke;
                txt_TotalSuit.BackColor = Color.WhiteSmoke;
                CB_suitType.BackColor = Color.WhiteSmoke;
                date_Order.BackColor = Color.WhiteSmoke;
                date_delivery.BackColor = Color.WhiteSmoke;
                txt_TotalAmount.BackColor = Color.WhiteSmoke;
                txt_advance.BackColor = Color.WhiteSmoke;

                txt_length.BackColor = Color.WhiteSmoke;
                txt_sleaves.BackColor = Color.WhiteSmoke;
                txt_shoulder.BackColor = Color.WhiteSmoke;
                txt_collor.BackColor = Color.WhiteSmoke;
                txt_chest.BackColor = Color.WhiteSmoke;
                txt_belly.BackColor = Color.WhiteSmoke;
                txt_cFull.BackColor = Color.WhiteSmoke;
                txt_daman.BackColor = Color.WhiteSmoke;
                CB_dtype.BackColor = Color.WhiteSmoke;
                txt_shalwar.BackColor = Color.WhiteSmoke;
                txt_payncha.BackColor = Color.WhiteSmoke;
                CB_shalwarPocket.BackColor = Color.WhiteSmoke;
                txt_waist.BackColor = Color.WhiteSmoke;
                txt_hips.BackColor = Color.WhiteSmoke;
                txt_thais.BackColor = Color.WhiteSmoke;
                CB_sewing.BackColor = Color.WhiteSmoke;
                CB_Fpocket.BackColor = Color.WhiteSmoke;
                CB_sidePocket.BackColor = Color.WhiteSmoke;
                CB_Shalwartype.BackColor = Color.WhiteSmoke;
                CB_Ctype.BackColor = Color.WhiteSmoke;
                txt_extra.BackColor = Color.WhiteSmoke;
                CB_button.BackColor = Color.WhiteSmoke;
                CB_ban.BackColor = Color.WhiteSmoke;
                CB_chak.BackColor = Color.WhiteSmoke;
            }
        }
        public void execute(string query)
        {
            try
            {
                cmd = new SQLiteCommand(query, Main.con);
                Main.con.Open();
                cmd.ExecuteNonQuery();
                Main.con.Close();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_savedata_Click(object sender, EventArgs e)
                {
            if (update == false)
            {
                try
                {

                    if (checking == 1)
                    {
                        if (CB_suitType.Text == "Shalwar Kameez")
                        {
                            string q = "insert into shalwarKameez (length,slaves,shoulder,necksize,chest,chestfull,daman,damantype,shalwar,payancha,shalwarpocket,sewing,frontpoctet,sidepocket,shalwartype,collortype,Ban,extra,code,totalsuit,orderdate,deliverydate) values('" + Convert.ToSingle(txt_length.Text) + "','" + Convert.ToSingle(txt_sleaves.Text) + "','" + Convert.ToSingle(txt_shoulder.Text) + "','" + Convert.ToSingle(txt_collor.Text) + "','" + Convert.ToSingle(txt_chest.Text) + "','" + Convert.ToSingle(txt_cFull.Text) + "','" + Convert.ToSingle(txt_daman.Text) + "','" + CB_dtype.Text + "','" + Convert.ToSingle(txt_shalwar.Text) + "','" + Convert.ToSingle(txt_payncha.Text) + "','" + CB_shalwarPocket.Text + "','" + CB_sewing.Text + "','" + CB_Fpocket.Text + "','" + CB_sidePocket.Text + "','" + CB_Shalwartype.Text + "','" + CB_Ctype.Text + "','"+CB_ban.Text+"','" + txt_extra.Text + "','" + Convert.ToInt32(txt_code.Text) + "','" + txt_TotalSuit.Text + "','" + date_Order.Text + "','" + date_delivery.Text + "')";
                                cmd = new SQLiteCommand(q, Main.con);
                            Main.con.Open();
                            cmd.ExecuteNonQuery();
                            Main.con.Close();
                        }
                        else if (CB_suitType.Text == "West Coat")
                        {
                            string q = "insert into westcoat (length,shoulder,necksize,chest,belly,chestfull,sewing,extras,code,totalsuit,orderdate,deliverydate) values('" + Convert.ToSingle(txt_length.Text) + "','" + Convert.ToSingle(txt_shoulder.Text) + "','" + Convert.ToSingle(txt_collor.Text) + "','" + Convert.ToSingle(txt_chest.Text) + "','" + Convert.ToSingle(txt_belly.Text) + "','" + CB_Ctype.Text + "','" + CB_sewing.Text + "','" + txt_extra.Text + "','" + Convert.ToInt32(txt_code.Text) + "','" + txt_TotalSuit.Text + "','" + date_Order.Text + "','" + date_delivery.Text + "')";
                            cmd = new SQLiteCommand(q, Main.con);
                            Main.con.Open();
                            cmd.ExecuteNonQuery();
                            Main.con.Close();
                            //suitCategory = "West Coat";
                        }
                        else if (CB_suitType.Text == "Coat")
                        {
                            string q = "insert into coat (length,sleeves,shoulder,necksize,chest,belly,chestfull,chak,sewing,extras,code,totalsuit,orderdate,deliverydate) values('" + Convert.ToSingle(txt_length.Text) + "','" + Convert.ToSingle(txt_sleaves.Text) + "','"+ Convert.ToSingle(txt_shoulder.Text) + "','" + CB_button.Text + "','" + Convert.ToSingle(txt_chest.Text) + "','" + Convert.ToSingle(txt_belly.Text) + "','" + CB_dtype.Text + "','"+CB_chak.Text+"','" + CB_sewing.Text + "','" + txt_extra.Text + "','" + Convert.ToInt32(txt_code.Text) + "','" + txt_TotalSuit.Text + "','" + date_Order.Text + "','" + date_delivery.Text + "')";
                            cmd = new SQLiteCommand(q, Main.con);
                            Main.con.Open();
                            cmd.ExecuteNonQuery();
                            Main.con.Close();
                            //suitCategory = "Coat";
                        }
                        else if (CB_suitType.Text == "Shirt")
                        {
                            string q = "insert into shirt (length,sleaves,shoulder,necksize,chest,belly,chestfull,damantype,sewing,fronttyoe,collortype,extras,code,totalsuit,orderdate,deliverydate) values('" + Convert.ToSingle(txt_length.Text) + "','" + Convert.ToSingle(txt_sleaves.Text) + "','" + Convert.ToSingle(txt_shoulder.Text) + "','" + Convert.ToSingle(txt_collor.Text) + "','" + Convert.ToSingle(txt_chest.Text) + "','" + Convert.ToSingle(txt_belly.Text) + "','" + Convert.ToSingle(txt_cFull.Text) + "','" + CB_dtype.Text + "','" + CB_sewing.Text + "','" + CB_Fpocket.Text + "','" + CB_Ctype.Text + "','" + txt_extra.Text + "','" + Convert.ToInt32(txt_code.Text) + "','" + txt_TotalSuit.Text + "','" + date_Order.Text + "','" + date_delivery.Text + "')";
                            cmd = new SQLiteCommand(q, Main.con);
                            Main.con.Open();
                            cmd.ExecuteNonQuery();
                            Main.con.Close();
                            //suitCategory = "Shirt";
                        }
                        else if (CB_suitType.Text == "Pant")
                        {
                            string q = "insert into pant (length,waist,hips,thais,sewing,payncha,payncha,extra,code,totalsuit,orderdate,deliverydate) values('" + Convert.ToSingle(txt_length.Text) + "','" + Convert.ToSingle(txt_waist.Text) + "','" + Convert.ToSingle(txt_hips.Text) + "','" + Convert.ToSingle(txt_thais.Text) + "','" + CB_sewing.Text + "','" + txt_payncha.Text + "','" + txt_payncha.Text + "','" + txt_extra.Text + "','" + Convert.ToInt32(txt_code.Text) + "','" + Convert.ToInt32(txt_TotalSuit.Text) + "','" + date_Order.Text + "','" + date_delivery.Text + "')";
                            cmd = new SQLiteCommand(q, Main.con);
                            Main.con.Open();
                            cmd.ExecuteNonQuery();
                            Main.con.Close();
                            //suitCategory = "Pant";
                        }
                        DoneMessage();
                    }
                    else
                    {
                        if (CB_suitType.Text == "Shalwar Kameez")
                        {
                            // string q = "insert into shalwarKameez  (length,slaves,shoulder,necksize,chest,chestfull,daman,damantype,shalwar,payancha,shalwarpocket,sewing,frontpoctet,sidepocket,shalwartype,collortype,extra,code,totalsuit,orderdate,deliverydate) values('" + Convert.ToSingle(txt_length.Text) + "','" + Convert.ToSingle(txt_sleaves.Text) + "','" + Convert.ToSingle(txt_shoulder.Text) + "','" + Convert.ToSingle(txt_collor.Text) + "','" + Convert.ToSingle(txt_chest.Text) + "','" + Convert.ToSingle(txt_cFull.Text) + "','" + Convert.ToSingle(txt_daman.Text) + "','" + CB_dtype.Text + "','" + Convert.ToSingle(txt_shalwar.Text) + "','" + Convert.ToSingle(txt_payncha.Text) + "','" + CB_shalwarPocket.Text + "','" + CB_sewing.Text + "','" + CB_Fpocket.Text + "','" + CB_sidePocket.Text + "','" + CB_Shalwartype.Text + "','" + CB_Ctype.Text + "','" + txt_extra.Text + "','" + Convert.ToInt32(txt_code.Text) + "','" + txt_TotalSuit.Text + "','" + date_Order.Text + "','" + date_delivery.Text + "')";
                            string q = "insert into shalwarKameez (length,slaves,shoulder,necksize,chest,chestfull,daman,damantype,shalwar,payancha,shalwarpocket,sewing,frontpoctet,sidepocket,shalwartype,collortype,Ban,extra,code,totalsuit,orderdate,deliverydate) values('" + Convert.ToSingle(txt_length.Text) + "','" + Convert.ToSingle(txt_sleaves.Text) + "','" + Convert.ToSingle(txt_shoulder.Text) + "','" + Convert.ToSingle(txt_collor.Text) + "','" + Convert.ToSingle(txt_chest.Text) + "','" + Convert.ToSingle(txt_cFull.Text) + "','" + Convert.ToSingle(txt_daman.Text) + "','" + CB_dtype.Text + "','" + Convert.ToSingle(txt_shalwar.Text) + "','" + Convert.ToSingle(txt_payncha.Text) + "','" + CB_shalwarPocket.Text + "','" + CB_sewing.Text + "','" + CB_Fpocket.Text + "','" + CB_sidePocket.Text + "','" + CB_Shalwartype.Text + "','" + CB_Ctype.Text + "',,'" + CB_ban.Text + "''" + txt_extra.Text + "','" + Convert.ToInt32(txt_code.Text) + "','" + txt_TotalSuit.Text + "','" + date_Order.Text + "','" + date_delivery.Text + "')";

                            execute(q);
                        }
                        else if (CB_suitType.Text == "West Coat")
                        {
                            //string q = "insert into westcoat (length,shoulder,necksize,chest,belly,chestfull,sewing,extras,code,totalsuit,orderdate,deliverydate) values('" + Convert.ToSingle(txt_length.Text) + "','" + Convert.ToSingle(txt_shoulder.Text) + "','" + Convert.ToSingle(txt_collor.Text) + "','" + Convert.ToSingle(txt_chest.Text) + "','" + Convert.ToSingle(txt_belly.Text) + "','" + Convert.ToSingle(txt_cFull.Text) + "','" + CB_sewing.Text + "','" + txt_extra.Text + "','" + Convert.ToInt32(txt_code.Text) + "','" + Convert.ToInt32(txt_TotalSuit.Text) + "','" + date_Order.Text + "','" + date_delivery.Text+ "')";
                            string q = "insert into westcoat (length,shoulder,necksize,chest,belly,chestfull,sewing,extras,code,totalsuit,orderdate,deliverydate) values('" + Convert.ToSingle(txt_length.Text) + "','" + Convert.ToSingle(txt_shoulder.Text) + "','" + Convert.ToSingle(txt_collor.Text) + "','" + Convert.ToSingle(txt_chest.Text) + "','" + Convert.ToSingle(txt_belly.Text) + "','" + CB_Ctype.Text + "','" + CB_sewing.Text + "','" + txt_extra.Text + "','" + Convert.ToInt32(txt_code.Text) + "','" + txt_TotalSuit.Text + "','" + date_Order.Text + "','" + date_delivery.Text + "')";
                            execute(q);
                            //suitCategory = "West Coat";
                        }
                        else if (CB_suitType.Text == "Coat")
                        {
                            // string q = "insert into coat (length,sleeves,shoulder,necksize,chest,belly,chestfull,sewing,extras,code,totalsuit,orderdate,deliverydate) values('" + Convert.ToSingle(txt_length.Text) + "','" + Convert.ToSingle(txt_sleaves.Text) + "','" + Convert.ToSingle(txt_shoulder.Text) + "','" + Convert.ToSingle(txt_collor.Text) + "','" + Convert.ToSingle(txt_chest.Text) + "','" + Convert.ToSingle(txt_belly.Text) + "','" + Convert.ToSingle(txt_cFull.Text) + "','" + CB_sewing.Text + "','" + txt_extra.Text + "','" + Convert.ToInt32(txt_code.Text) + "','" + Convert.ToInt32(txt_TotalSuit.Text) + "','" + date_Order.Text + "','" + date_delivery.Text + "')";
                            string q = "insert into coat (length,sleeves,shoulder,necksize,chest,belly,chestfull,chak,sewing,extras,code,totalsuit,orderdate,deliverydate) values('" + Convert.ToSingle(txt_length.Text) + "','" + Convert.ToSingle(txt_sleaves.Text) + "','" + Convert.ToSingle(txt_shoulder.Text) + "','" + CB_button.Text + "','" + Convert.ToSingle(txt_chest.Text) + "','" + Convert.ToSingle(txt_belly.Text) + "','" + CB_dtype.Text + "','" + CB_chak.Text + "','" + CB_sewing.Text + "','" + txt_extra.Text + "','" + Convert.ToInt32(txt_code.Text) + "','" + txt_TotalSuit.Text + "','" + date_Order.Text + "','" + date_delivery.Text + "')";
                            execute(q);
                            //suitCategory = "Coat";
                        }
                        else if (CB_suitType.Text == "Shirt")
                        {
                            string q = "insert into shirt (length,sleaves,shoulder,necksize,chest,belly,chestfull,damantype,sewing,fronttyoe,collortype,extras,code,totalsuit,orderdate,deliverydate) values('" + Convert.ToSingle(txt_length.Text) + "','" + Convert.ToSingle(txt_sleaves.Text) + "','" + Convert.ToSingle(txt_shoulder.Text) + "','" + Convert.ToSingle(txt_collor.Text) + "','" + Convert.ToSingle(txt_chest.Text) + "','" + Convert.ToSingle(txt_belly.Text) + "','" + Convert.ToSingle(txt_cFull.Text) + "','" + CB_dtype.Text + "','" + CB_sewing.Text + "','" + CB_Fpocket.Text + "','" + CB_Ctype.Text + "','" + txt_extra.Text + "','" + Convert.ToInt32(txt_code.Text) + "','" + Convert.ToInt32(txt_TotalSuit.Text) + "','" + date_Order.Text + "','" + date_delivery.Text + "')";
                            execute(q);
                            //suitCategory = "Shirt";
                        }
                        else if (CB_suitType.Text == "Pant")
                        {
                            string q = "insert into pant (length,waist,hips,thais,sewing,extra,code,totalsuit,orderdate,deliverydate) values('" + Convert.ToSingle(txt_length.Text) + "','" + Convert.ToSingle(txt_waist.Text) + "','" + Convert.ToSingle(txt_hips.Text) + "','" + Convert.ToSingle(txt_thais.Text) + "','" + CB_sewing.Text + "','" + txt_extra.Text + "','" + Convert.ToInt32(txt_code.Text) + "','" + Convert.ToInt32(txt_TotalSuit.Text) + "','" + date_Order.Text + "','" + date_delivery.Text + "')";
                            execute(q);
                            //suitCategory = "Pant";
                        }
                        //string qu = "update CustomerDetails set Name = '"+txt_Name.Text+ "' , Number = '"+txt_phoneNo.Text+ "' , totalamount='"+txt_TotalAmount.Text+ "' , advance = '"+txt_advance.Text+ "' , balance = '"+txt_Balance.Text+"' where Code='" + txt_code.Text + "'";
                        //execute(qu);
                        DoneMessage();
                    }
                    DialogResult dr1 = MessageBox.Show("Do you want to add more information of same customer?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr1 == DialogResult.Yes)
                    {
                        txt_daman.Text = "";
                        txt_sleaves.Text = "";
                        txt_payncha.Text = "";
                        txt_shalwar.Text = "";
                        txt_belly.Text = "";
                        txt_cFull.Text = "";
                        txt_chest.Text = "";
                        txt_collor.Text = "";
                        txt_extra.Text = "";
                        txt_length.Text = "";
                        txt_shoulder.Text = "";
                        txt_waist.Text = "";
                        txt_hips.Text = "";
                        txt_thais.Text = "";
                        CB_dtype.Text = "";
                        CB_shalwarPocket.Text = "";
                        CB_Fpocket.Text = "";
                        CB_Shalwartype.Text = "";
                        CB_sidePocket.Text = "";
                        CB_Ctype.Text = "";
                        CB_sewing.Text = "";
                        CB_chak.Text = "";
                        CB_button.Text = "";
                        CB_ban.Text = "";
                        checking = 0;
                    }
                    else if (dr1 == DialogResult.No)
                    {
                        quer = "select * from CustomerDetails where Code='" + txt_code.Text + "'";
                        SQLiteCommand cmd = new SQLiteCommand(quer, Main.con);
                        Main.con.Open();
                        SQLiteDataReader dr = cmd.ExecuteReader();
                        if (dr.HasRows)
                        {
                        }
                        else {
                            q = "insert into CustomerDetails values('" + Convert.ToInt32(txt_code.Text) + "','" + txt_Name.Text + "','" + txt_phoneNo.Text + "','" + txt_TotalAmount.Text + "','" + txt_advance.Text + "','" + txt_Balance.Text + "')";

                            //q = "insert into CustomerDetails values('" + Convert.ToInt32(txt_code.Text) + "','" + txt_Name.Text + "','" + txt_phoneNo.Text + "','" + Convert.ToDecimal(txt_TotalAmount.Text) + "','" + Convert.ToDecimal(txt_advance.Text) + "','" + Convert.ToDecimal(txt_Balance.Text) + "')";
                            cmd = new SQLiteCommand(q, Main.con);
                           // Main.con.Open();
                            cmd.ExecuteNonQuery();
                            Main.con.Close();
                        }


                      
                        txt_daman.Text = "";
                        txt_sleaves.Text = "";
                        txt_payncha.Text = "";
                        txt_shalwar.Text = "";
                        txt_advance.Text = "";
                        txt_Balance.Text = "";
                        txt_belly.Text = "";
                        txt_cFull.Text = "";
                        txt_chest.Text = "";
                        txt_code.Text = "";
                        txt_collor.Text = "";
                        txt_extra.Text = "";
                        txt_length.Text = "";
                        txt_Name.Text = "";
                        txt_phoneNo.Text = "";
                        txt_TotalAmount.Text = "";
                        txt_shoulder.Text = "";
                        txt_TotalSuit.Text = "";
                        txt_waist.Text = "";
                        txt_hips.Text = "";
                        txt_thais.Text = "";
                        CB_dtype.Text = "";
                        CB_shalwarPocket.Text = "";
                        CB_Fpocket.Text = "";
                        CB_Shalwartype.Text = "";
                        CB_sidePocket.Text = "";
                        CB_Ctype.Text = "";
                        CB_sewing.Text = "";
                        CB_suitType.Text = "";
                        CB_chak.Text = "";
                        CB_button.Text = "";
                        CB_ban.Text = "";
                        checking = 1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    Main.con.Close();
                }
            }
            else
            {
                try
                {
                    string qu = "update CustomerDetails set Name = '" + txt_Name.Text + "' , Number = '" + txt_phoneNo.Text + "' , totalamount='" + txt_TotalAmount.Text + "' , advance = '" + txt_advance.Text + "' , balance = '" + txt_Balance.Text + "' where Code='" + txt_code.Text + "'";

                    cmd = new SQLiteCommand(qu, Main.con);
                    Main.con.Open();
                    cmd.ExecuteNonQuery();
                    Main.con.Close();
                    if (CB_suitType.Text == "Shalwar Kameez")
                    {
                        string q = "update shalwarKameez set length ='" + Convert.ToSingle(txt_length.Text) + "', slaves= '" + Convert.ToSingle(txt_sleaves.Text) + "', shoulder='" + Convert.ToSingle(txt_shoulder.Text) + "', necksize='" + Convert.ToSingle(txt_collor.Text) + "', chest='" + Convert.ToSingle(txt_chest.Text) + "', chestfull='" + Convert.ToSingle(txt_cFull.Text) + "', daman='" + Convert.ToSingle(txt_daman.Text) + "', damantype='" + CB_dtype.Text + "', shalwar='" + Convert.ToSingle(txt_shalwar.Text) + "', payancha='" + Convert.ToSingle(txt_payncha.Text) + "', shalwarpocket='" + CB_shalwarPocket.Text + "', sewing='" + CB_sewing.Text + "',frontpoctet='" + CB_Fpocket.Text + "', sidepocket='" + CB_sidePocket.Text + "', shalwartype='" + CB_Shalwartype.Text + "', collortype='" + CB_Ctype.Text + "',Ban='"+CB_ban.Text+"', extra='" + txt_extra.Text + "' , totalsuit='" + txt_TotalSuit.Text + "',orderdate='" + date_Order.Text + "',deliverydate='" + date_delivery.Text + "' where code='" + Convert.ToInt32(txt_code.Text) + "'";
                        cmd = new SQLiteCommand(q, Main.con);
                        Main.con.Open();
                        cmd.ExecuteNonQuery();
                        Main.con.Close();
                    }
                    else if (CB_suitType.Text == "West Coat")
                    {
                        string q = "update westcoat set length='" + Convert.ToSingle(txt_length.Text) + "',shoulder='" + Convert.ToSingle(txt_shoulder.Text) + "',necksize='" + Convert.ToSingle(txt_collor.Text) + "',chest='" + Convert.ToSingle(txt_chest.Text) + "',belly='" + Convert.ToSingle(txt_belly.Text) + "',chestfull='" + CB_Ctype.Text + "',sewing='" + CB_sewing.Text + "',extras='" + txt_extra.Text + "',totalsuit='" + txt_TotalSuit.Text + "',orderdate='" + date_Order.Text + "',deliverydate='" + date_delivery.Text + "' where code='" + txt_code.Text + "'";
                        // string q = "update westcoat set length ='" + Convert.ToSingle(txt_length.Text) + "' , shoulder='" + Convert.ToSingle(txt_shoulder.Text) + "', necksize='" + Convert.ToSingle(txt_collor.Text) + "', chest='" + Convert.ToSingle(txt_chest.Text) + "', chestfull='" + Convert.ToSingle(txt_cFull.Text) + "', sewing='" + CB_sewing.Text + "', extras='" + txt_extra.Text + "' , totalsuit='" + Convert.ToInt32(txt_TotalSuit.Text) + "',orderdate='" + date_Order.Text + "',deliverydate='" + date_delivery.Text + "' where code='" + Convert.ToInt32(txt_code.Text) + "'";
                        cmd = new SQLiteCommand(q, Main.con);
                        Main.con.Open();
                        cmd.ExecuteNonQuery();
                        Main.con.Close();
                        //suitCategory = "West Coat";
                    }
                    else if (CB_suitType.Text == "Coat")
                    {
                        string q = "update coat set length='"+Convert.ToSingle(txt_length.Text)+"',sleeves='"+Convert.ToSingle(txt_sleaves.Text)+"',shoulder='"+txt_shoulder.Text+"',necksize='"+ CB_button.Text +"',chest='"+Convert.ToSingle(txt_chest.Text)+"',belly='"+Convert.ToSingle(txt_belly.Text)+"',chestfull='"+ CB_dtype.Text +"',chak='"+CB_chak.Text+"',sewing = '"+CB_sewing.Text+"',extras='"+txt_extra.Text+"',totalsuit = '"+ txt_TotalSuit.Text + "',orderdate='"+date_Order.Text+"',deliverydate='"+date_delivery.Text+"'";
                      //  string q = "update coat set length ='" + Convert.ToSingle(txt_length.Text) + "' ,sleeves ='" + Convert.ToSingle(txt_sleaves.Text) + "' ,shoulder ='" + Convert.ToSingle(txt_shoulder.Text) + "'  , necksize='" + Convert.ToSingle(txt_collor.Text) + "', chest='" + Convert.ToSingle(txt_chest.Text) + "', belly='" + Convert.ToSingle(txt_belly) + "', chestfull='" + Convert.ToSingle(txt_cFull.Text) + "', sewing='" + CB_sewing.Text + "', extras='" + txt_extra.Text + "' , totalsuit='" + Convert.ToInt32(txt_TotalSuit.Text) + "',orderdate='" + date_Order.Text + "',deliverydate='" + date_delivery.Text + "' where code='" + Convert.ToInt32(txt_code.Text) + "'";
                        //string q = "insert into coat values('" + Convert.ToSingle(txt_length.Text) + "','" + Convert.ToSingle(txt_sleaves.Text) + "','" + Convert.ToSingle(txt_collor.Text) + "','" + Convert.ToSingle(txt_chest.Text) + "','" + Convert.ToSingle(txt_belly.Text) + "','" + Convert.ToSingle(txt_cFull.Text) + "','" + CB_sewing.Text + "','" + txt_extra.Text + "','" + Convert.ToInt32(txt_code.Text) + "','" + Convert.ToInt32(txt_TotalSuit.Text) + "','" + date_Order.Text + "','" + date_delivery.Text + "')";
                        cmd = new SQLiteCommand(q, Main.con);
                        Main.con.Open();
                        cmd.ExecuteNonQuery();
                        Main.con.Close();
                        //suitCategory = "Coat";
                    }
                    else if (CB_suitType.Text == "Shirt")
                    {
                        string q = "update shirt set length ='" + Convert.ToSingle(txt_length.Text) + "',sleaves = '" + Convert.ToSingle(txt_sleaves.Text) + "', shoulder='" + Convert.ToSingle(txt_shoulder.Text) + "', necksize='" + Convert.ToSingle(txt_collor.Text) + "', chest='" + Convert.ToSingle(txt_chest.Text) + "', belly='" + Convert.ToSingle(txt_belly.Text) + "', chestfull='" + Convert.ToSingle(txt_cFull.Text) + "',  damantype='" + CB_dtype.Text + "', sewing='" + CB_sewing.Text + "',fronttyoe='" + CB_Fpocket.Text + "',  collortype='" + CB_Ctype.Text + "', extras='" + txt_extra.Text + "' , totalsuit='" + txt_TotalSuit.Text + "',orderdate='" + date_Order.Text + "',deliverydate='" + date_delivery.Text + "' where code='" + Convert.ToInt32(txt_code.Text) + "'";
                      //  string q = "insert into shirt values('" + Convert.ToSingle(txt_length.Text) + "','" + Convert.ToSingle(txt_shoulder.Text) + "','" + Convert.ToSingle(txt_collor.Text) + "','" + Convert.ToSingle(txt_chest.Text) + "','" + Convert.ToSingle(txt_belly.Text) + "','" + Convert.ToSingle(txt_cFull.Text) + "','" + CB_dtype.Text + "','" + CB_sewing.Text + "','" + CB_Fpocket.Text + "','" + CB_Ctype.Text + "','" + txt_extra.Text + "','" + Convert.ToInt32(txt_code.Text) + "','" + Convert.ToInt32(txt_TotalSuit.Text) + "','" + date_Order.Text + "','" + date_delivery.Text + "')";
                        cmd = new SQLiteCommand(q, Main.con);
                        Main.con.Open();
                        cmd.ExecuteNonQuery();
                        Main.con.Close();
                        //suitCategory = "Shirt";
                    }
                    else if (CB_suitType.Text == "Pant")
                    {
                        string q = "update pant set length ='" + Convert.ToSingle(txt_length.Text) + "',waist ='" + Convert.ToSingle(txt_waist.Text) + "',hips ='" + Convert.ToSingle(txt_hips.Text) + "',thais ='" + Convert.ToSingle(txt_thais.Text) + "',  sewing='" + CB_sewing.Text + "', payncha='" + txt_payncha.Text + "',extra='" + txt_extra.Text + "' , totalsuit='" + txt_TotalSuit.Text + "',orderdate='" + date_Order.Text + "',deliverydate='" + date_delivery.Text + "' where code='" + Convert.ToInt32(txt_code.Text) + "'";
                        //string q = "insert into pant values('" + Convert.ToSingle(txt_length.Text) + "','" + Convert.ToSingle(txt_waist.Text) + "','" + Convert.ToSingle(txt_hips.Text) + "','" + Convert.ToSingle(txt_thais.Text) + "','" + CB_sewing.Text + "','" + txt_extra.Text + "','" + Convert.ToInt32(txt_code.Text) + "','" + Convert.ToInt32(txt_TotalSuit.Text) + "','" + date_Order.Text + "','" + date_delivery.Text + "')";
                        cmd = new SQLiteCommand(q, Main.con);
                        Main.con.Open();
                        cmd.ExecuteNonQuery();
                        Main.con.Close();
                        //suitCategory = "Pant";
                    }
                   DialogResult dr = MessageBox.Show("Update Sucessfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if(dr == DialogResult.OK)
                    {

                        txt_daman.Text = "";
                        txt_sleaves.Text = "";
                        txt_payncha.Text = "";
                        txt_shalwar.Text = "";
                        txt_advance.Text = "";
                        txt_Balance.Text = "";
                        txt_belly.Text = "";
                        txt_cFull.Text = "";
                        txt_chest.Text = "";
                        txt_code.Text = "";
                        txt_collor.Text = "";
                        txt_extra.Text = "";
                        txt_length.Text = "";
                        txt_Name.Text = "";
                        txt_phoneNo.Text = "";
                        txt_TotalAmount.Text = "";
                        txt_shoulder.Text = "";
                        txt_TotalSuit.Text = "";
                        txt_waist.Text = "";
                        txt_hips.Text = "";
                        txt_thais.Text = "";
                        CB_dtype.Text = "";
                        CB_shalwarPocket.Text = "";
                        CB_Fpocket.Text = "";
                        CB_Shalwartype.Text = "";
                        CB_sidePocket.Text = "";
                        CB_Ctype.Text = "";
                        CB_sewing.Text = "";
                        CB_suitType.Text = "";
                        CB_chak.Text = "";
                        CB_button.Text = "";
                        CB_ban.Text = "";


                        txt_daman.Enabled = true;
                       txt_sleaves.Enabled = true;
                       txt_payncha.Enabled = true;
                       txt_shalwar.Enabled = true;
                       txt_advance.Enabled = true;
                      // txt_Balance.Enabled = true;
                         txt_belly.Enabled = true;
                         txt_cFull.Enabled = true;
                         txt_chest.Enabled = true;
                          txt_code.Enabled = true;
                        txt_collor.Enabled = true;
                         txt_extra.Enabled = true;
                        txt_length.Enabled = true;
                          txt_Name.Enabled = true;
                       txt_phoneNo.Enabled = true;
                   txt_TotalAmount.Enabled = true;
                      txt_shoulder.Enabled = true;
                     txt_TotalSuit.Enabled = true;
                         txt_waist.Enabled = true;
                          txt_hips.Enabled = true;
                         txt_thais.Enabled = true;
                          CB_dtype.Enabled = true;
                  CB_shalwarPocket.Enabled = true;
                        CB_Fpocket.Enabled = true;
                    CB_Shalwartype.Enabled = true;
                     CB_sidePocket.Enabled = true;
                          CB_Ctype.Enabled = true;
                         CB_sewing.Enabled = true;
                       CB_suitType.Enabled = true;
                        CB_chak.Enabled = true;
                        CB_button.Enabled = true;
                        CB_ban.Enabled = true;

                        txt_daman.BackColor = Color.WhiteSmoke;
                       txt_sleaves.BackColor = Color.WhiteSmoke;
                       txt_payncha.BackColor = Color.WhiteSmoke;
                       txt_shalwar.BackColor = Color.WhiteSmoke;
                       txt_advance.BackColor = Color.WhiteSmoke;
                     //  txt_Balance.BackColor = Color.WhiteSmoke;
                         txt_belly.BackColor = Color.WhiteSmoke;
                         txt_cFull.BackColor = Color.WhiteSmoke;
                         txt_chest.BackColor = Color.WhiteSmoke;
                          txt_code.BackColor = Color.WhiteSmoke;
                        txt_collor.BackColor = Color.WhiteSmoke;
                         txt_extra.BackColor = Color.WhiteSmoke;
                        txt_length.BackColor = Color.WhiteSmoke;
                          txt_Name.BackColor = Color.WhiteSmoke;
                       txt_phoneNo.BackColor = Color.WhiteSmoke;
                   txt_TotalAmount.BackColor = Color.WhiteSmoke;
                      txt_shoulder.BackColor = Color.WhiteSmoke;
                     txt_TotalSuit.BackColor = Color.WhiteSmoke;
                         txt_waist.BackColor = Color.WhiteSmoke;
                          txt_hips.BackColor = Color.WhiteSmoke;
                         txt_thais.BackColor = Color.WhiteSmoke;
                          CB_dtype.BackColor = Color.WhiteSmoke;
                  CB_shalwarPocket.BackColor = Color.WhiteSmoke;
                        CB_Fpocket.BackColor = Color.WhiteSmoke;
                    CB_Shalwartype.BackColor = Color.WhiteSmoke;
                     CB_sidePocket.BackColor = Color.WhiteSmoke;
                          CB_Ctype.BackColor = Color.WhiteSmoke;
                         CB_sewing.BackColor = Color.WhiteSmoke;
                       CB_suitType.BackColor = Color.WhiteSmoke;
                        CB_chak.  BackColor = Color.WhiteSmoke;
                        CB_button.BackColor = Color.WhiteSmoke;
                        CB_ban.BackColor = Color.WhiteSmoke;



                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    Main.con.Close();
                }
            }
        }

        private void txt_TotalAmount_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_TotalAmount.Text))
            {
                txt_Balance.Text = txt_TotalAmount.Text;
            }
            else
            {
                txt_Balance.Text = "";
            }
        }

        private void txt_advance_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_advance.Text))
            {
                
                txt_Balance.Text =Convert.ToString( Convert.ToInt32(txt_TotalAmount.Text) - Convert.ToInt32(txt_advance.Text));
            }
            else
            {
                txt_Balance.Text = "";
            }
        }

        private void txt_code_Validating(object sender, CancelEventArgs e)
        {
            try
            {

                quer = "select * from CustomerDetails where Code='" + txt_code.Text + "'";
                SQLiteCommand cmd = new SQLiteCommand(quer, Main.con);
                Main.con.Open();
                SQLiteDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        txt_code.Text = dr[0].ToString();
                        txt_Name.Text = dr[1].ToString();
                        txt_phoneNo.Text = dr[2].ToString();
                        txt_TotalAmount.Text = dr[3].ToString();
                        txt_advance.Text = dr[4].ToString();
                        txt_Balance.Text = dr[5].ToString();
                    }
                    update = true;
                }
                else
                {
                    update = false;
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

        private void txt_advance_Validating(object sender, CancelEventArgs e)
        {
           
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_prnt_Click(object sender, EventArgs e)
        {

        }

        private void txt_belly_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_chest_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_collor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_shoulder_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_sleaves_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_length_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_cFull_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_daman_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_shalwar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_payncha_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_code_TextChanged(object sender, EventArgs e)
        {
            txt_Name.Text = "";
            txt_phoneNo.Text = "";
            txt_TotalAmount.Text = "";
            txt_advance.Text = "";
            txt_Balance.Text = "";
            CB_suitType.Text = "";
            txt_TotalSuit.Text = "";
        }

        private void CB_suitType_SelectedIndexChanged(object sender, EventArgs e)
        {
             
        }

        private void Order_Load(object sender, EventArgs e)
        {
            txt_code.Focus();
        }

        private void txt_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {
             
        }

        private void CB_dtype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label43_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label48_Click(object sender, EventArgs e)
        {

        }

        private void label47_Click(object sender, EventArgs e)
        {

        }

        private void CB_Ctype_Validating(object sender, CancelEventArgs e)
        {
            if(CB_Ctype.Text == "Collor      ( کالر )" || CB_Ctype.Text == "Rounded ( گول )")
            {
                CB_ban.Text = " ";
                CB_ban.Enabled = false;
            }
            else if(CB_Ctype.Text == "Ban           ( بين )" )
            {
                CB_ban.Enabled = true;
            }
        }
    }
}
