using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using MySql.Data.MySqlClient;
using Community.CsharpSqlite.SQLiteClient;
using System.Windows.Forms;

namespace TShockDBEditor
{
    public partial class TShockDBEditor : Form
    {
        public OpenFileDialog dialog = new OpenFileDialog();
        public List<Group> groups = new List<Group>();
        public IDbConnection DB;
        public string dbtype = "";

        public TShockDBEditor()
        {
            InitializeComponent();
            Itemlist.AddItems();
            Commandlist.AddCommands();
            dialog.FileOk += new CancelEventHandler(dialog_FileOk);
        }

        public void LoadSqliteDatabase(string path)
        {
            string sql = dialog.FileName;
            DB = new SqliteConnection(string.Format("uri=file://{0},Version=3", sql));
            DB.Open();
            dbtype = "sqlite";

            using (var com = DB.CreateCommand())
            {
                com.CommandText =
                    "SELECT * FROM Itembans";

                using (var reader = com.ExecuteReader())
                {
                    while (reader.Read())
                        itemListBanned.Items.Add(reader.Get<string>("ItemName"));
                }
            }
            using (var com = DB.CreateCommand())
            {
                com.CommandText =
                    "SELECT * FROM GroupList";

                using (var reader = com.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lst_groupList.Items.Add(reader.Get<string>("GroupName"));
                    }
                }
            }

            for (int i = 0; i < Itemlist.ItemList.Count; i++)
            {
                if (!itemListBanned.Items.Contains(Itemlist.ItemList[i]))
                    itemListAvailable.Items.Add(Itemlist.ItemList[i]);
            }
        }

        public void LoadMySqlDatabase(string hostname = "localhost", string port = "3306", string database = "", string username = "", string password = "")
        {
            DB = new MySqlConnection();
            DB.ConnectionString =
                "Server='" + hostname +
                "';Port='" + port +
                "';Database='" + database +
                "';Uid='" + username +
                "';Pwd='" + password + "';";
            DB.Open();

            dbtype = "mysql";

            using (var com = DB.CreateCommand())
            {
                com.CommandText =
                    "SELECT * FROM Itembans";

                using (var reader = com.ExecuteReader())
                {
                    while (reader.Read())
                        itemListBanned.Items.Add(reader.Get<string>("ItemName"));
                }
            }
            using (var com = DB.CreateCommand())
            {
                com.CommandText =
                    "SELECT * FROM GroupList";

                using (var reader = com.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lst_groupList.Items.Add(reader.Get<string>("GroupName"));
                    }
                }
            }

            for (int i = 0; i < Itemlist.ItemList.Count; i++)
            {
                if (!itemListBanned.Items.Contains(Itemlist.ItemList[i]))
                    itemListAvailable.Items.Add(Itemlist.ItemList[i]);
            }
        }

        #region BannedItemsTab
        public void btn_moveAllRightItems_Click(object sender, EventArgs e)
        {
            foreach (object item in itemListAvailable.Items)
            {
                itemListBanned.Items.Add(item);

                using (var com = DB.CreateCommand())
                {
                    com.CommandText = "INSERT INTO ItemBans (ItemName) VALUES (@itemname);";
                    com.AddParameter("@itemname", item.ToString());
                    com.ExecuteNonQuery();
                    com.Parameters.Clear();
                }
            }
            itemListAvailable.Items.Clear();
        }

        private void btn_moveAllLeftItems_Click(object sender, EventArgs e)
        {
            foreach (object item in itemListBanned.Items)
            {
                itemListAvailable.Items.Add(item);

                using (var com = DB.CreateCommand())
                {
                    com.CommandText = "DELETE FROM ItemBans WHERE ItemName=@itemname;";
                    com.AddParameter("@itemname", item.ToString());
                    com.ExecuteNonQuery();
                    com.Parameters.Clear();
                }
            }
            itemListBanned.Items.Clear();
        }

        private void btn_moveRightItems_Click(object sender, EventArgs e)
        {
            if (itemListAvailable.SelectedItem != null)
            {
                itemListBanned.Items.Add(itemListAvailable.SelectedItem);

                using (var com = DB.CreateCommand())
                {
                    com.CommandText = "INSERT INTO ItemBans (ItemName) VALUES (@itemname);";
                    com.AddParameter("@itemname", itemListAvailable.SelectedItem.ToString());
                    com.ExecuteNonQuery();
                }

                itemListAvailable.Items.Remove(itemListAvailable.SelectedItem);
            }
        }

        private void btn_moveLeftItems_Click(object sender, EventArgs e)
        {
            if (itemListBanned.SelectedItem != null)
            {
                itemListAvailable.Items.Add(itemListBanned.SelectedItem);

                using (var com = DB.CreateCommand())
                {
                    com.CommandText = "DELETE FROM ItemBans WHERE ItemName=@itemname;";
                    com.AddParameter("@itemname", itemListBanned.SelectedItem.ToString());
                    com.ExecuteNonQuery();
                }

                itemListBanned.Items.Remove(itemListBanned.SelectedItem);
            }
        }
        #endregion

        #region GroupTab

        private void lst_groupList_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateGroupIndex(lst_groupList.SelectedIndex);
        }

        private void UpdateGroupIndex(int index)
        {
            try
            {
                using (var com = DB.CreateCommand())
                {
                    lst_AvailableCmds.Items.Clear();
                    lst_bannedCmds.Items.Clear();

                    com.CommandText =
                        "SELECT * FROM GroupList WHERE GroupName=@groupname";
                    com.AddParameter("@groupname", lst_groupList.Items[index].ToString());

                    using (var reader = com.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            foreach (string command in reader.Get<string>("Commands").Split(','))
                            {
                                lst_AvailableCmds.Items.Add(command);
                            }
                        }
                    }

                    for (int i = 0; i < Commandlist.CommandList.Count; i++)
                    {
                        if (!lst_AvailableCmds.Items.Contains(Commandlist.CommandList[i]))
                            lst_bannedCmds.Items.Add(Commandlist.CommandList[i]);
                    }
                }
            }
            catch { }
        }

        private void btn_moveAllRightCmd_Click(object sender, EventArgs e)
        {
            try
            {
                var sb = new StringBuilder();

                foreach (object cmd in lst_bannedCmds.Items)
                {
                    lst_AvailableCmds.Items.Add(cmd);

                    if (string.IsNullOrEmpty(sb.ToString()))
                        sb.Append(cmd.ToString());
                    else
                        sb.Append(",").Append(cmd.ToString());
                }

                using (var com = DB.CreateCommand())
                {
                    com.CommandText = "UPDATE GroupList SET Commands=@cmds WHERE GroupName=@name;";
                    com.AddParameter("@name", lst_groupList.Items[lst_groupList.SelectedIndex].ToString());
                    com.AddParameter("@cmds", sb.ToString());
                    com.ExecuteNonQuery();
                }
                lst_bannedCmds.Items.Clear();
            }
            catch { }
        }

        private void btn_moveRightCmd_Click(object sender, EventArgs e)
        {
            try
            {
                lst_AvailableCmds.Items.Add(lst_bannedCmds.Items[lst_bannedCmds.SelectedIndex]);
                var sb = new StringBuilder();

                foreach (object cmd in lst_AvailableCmds.Items)
                {
                    if (string.IsNullOrEmpty(sb.ToString()))
                        sb.Append(cmd.ToString());
                    else
                        sb.Append(",").Append(cmd.ToString());
                }

                using (var com = DB.CreateCommand())
                {
                    com.CommandText = "UPDATE GroupList SET Commands=@cmds WHERE GroupName=@name;";
                    com.AddParameter("@name", lst_groupList.Items[lst_groupList.SelectedIndex].ToString());
                    com.AddParameter("@cmds", sb.ToString());
                    com.ExecuteNonQuery();
                }

                lst_bannedCmds.Items.Remove(lst_bannedCmds.Items[lst_bannedCmds.SelectedIndex]);
            }
            catch { }
        }

        private void btn_moveLeftCmd_Click(object sender, EventArgs e)
        {
            try
            {
                lst_bannedCmds.Items.Add(lst_AvailableCmds.Items[lst_AvailableCmds.SelectedIndex]);
                lst_AvailableCmds.Items.Remove(lst_AvailableCmds.Items[lst_AvailableCmds.SelectedIndex]);
                var sb = new StringBuilder();

                foreach (object cmd in lst_AvailableCmds.Items)
                {
                    if (string.IsNullOrEmpty(sb.ToString()))
                        sb.Append(cmd.ToString());
                    else
                        sb.Append(",").Append(cmd.ToString());
                }

                using (var com = DB.CreateCommand())
                {
                    com.CommandText = "UPDATE GroupList SET Commands=@cmds WHERE GroupName=@name;";
                    com.AddParameter("@name", lst_groupList.Items[lst_groupList.SelectedIndex].ToString());
                    com.AddParameter("@cmds", sb.ToString());
                    com.ExecuteNonQuery();
                }
            }
            catch { }
        }

        private void btn_moveAllLeftCmd_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (object cmd in lst_AvailableCmds.Items)
                {
                    lst_bannedCmds.Items.Add(cmd);
                }

                using (var com = DB.CreateCommand())
                {
                    com.CommandText = "UPDATE GroupList SET Commands=@cmds WHERE GroupName=@name;";
                    com.AddParameter("@name", lst_groupList.Items[lst_groupList.SelectedIndex].ToString());
                    com.AddParameter("@cmds", "");
                    com.ExecuteNonQuery();
                }

                lst_AvailableCmds.Items.Clear();
            }
            catch { }
        }

        #endregion

        #region FileOpenTabs

        private void btn_OpenLocalDB_Click(object sender, EventArgs e)
        {
            dialog.ShowDialog();
        }

        void dialog_FileOk(object sender, CancelEventArgs e)
        {
            LoadSqliteDatabase(dialog.FileName);
            tabControl.Visible = true;
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            LoadMySqlDatabase(txt_hostname.Text, txt_port.Text, txt_dbname.Text, txt_username.Text, txt_password.Text);
            tabControl.Visible = true;
        }

        #endregion        
    }
}