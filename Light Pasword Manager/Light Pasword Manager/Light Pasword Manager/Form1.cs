using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace Light_Pasword_Manager
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public string username = "";
        public double password = 0;
        public bool logedin = false;
        Scripts.Encryption_Local oEncrpt = new Scripts.Encryption_Local();
        Scripts.Hash oHash = new Scripts.Hash();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtChangedForLogin(object sender, EventArgs e)
        {
            //logedin = false; DISABLED
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtPass.Text != "" && txtUser.Text != "")
            {
                string[] Lines = LoadFile().Split('|');
                if (txtUser.Text == oEncrpt.oEncrypton(Lines[0].Split(' ')[0], false)) 
                {
                    if (oHash.HashMe(txtPass.Text).ToString() == oEncrpt.oEncrypton(Lines[0].Split(' ')[1], false))
                    {
                        pbConnected.Value = 1;
                        logedin = true;
                        username = oEncrpt.oEncrypton(Lines[0].Split(' ')[0], false);
                        password = Convert.ToDouble(oEncrpt.oEncrypton(Lines[0].Split(' ')[1], false));
                    }   
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Password Dosent Match!");
                        pbConnected.Value = 0;
                        logedin = false;
                        username = "";
                        password = 0;
                    }                
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Username Not Detected!");
                    pbConnected.Value = 0;
                    logedin = false;
                    username = "";
                    password = 0;
                }
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            listMain.Items.Clear();
            if (logedin)
            {
                string[] items = LoadFile().Split('|');
                if (items != null && items.Length > 0)
                {
                    for (int i = 1; i < items.Length; i++)
                    {
                        if (items[i] != "")
                        {
                            listMain.Items.Add(oEncrpt.oEncrypton(items[i], false));
                        }
                    }
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Please Login First");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (logedin)
            {
                string tosave = "";
                for (int i = 0; i < listMain.Items.Count;i++)
                {
                    if (listMain.Items[i].ToString() != "")
                    {
                        tosave = tosave + oEncrpt.oEncrypton(listMain.Items[i].ToString(), true) + System.Environment.NewLine;
                    }
                }
                SaveFile(tosave);
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Please Login First");
            }
        }

        private string LoadFile()
        {

            try
            {
                //open file as filestream
                FileStream oFS = File.OpenRead("PassDat.Data");
                //read the stream
                StreamReader oSR = new StreamReader(oFS);
                //open 1 line at a time
                string tosend = "";
                string line = null;
                try
                {
                    while ((line = oSR.ReadLine()) != null)
                    {
                        tosend = tosend + line + "|";
                    }
                }
                catch
                {

                }
                oSR.Close();
                oFS.Close();
                return tosend;               
            }
            catch
            {
                MetroFramework.MetroMessageBox.Show(this, "No Save Was Detected One Was Created From Your User And Pass");
                System.IO.FileStream oStream = System.IO.File.OpenWrite("PassDat.Data");
                System.IO.StreamWriter oWriter = new System.IO.StreamWriter(oStream);
                oWriter.WriteLine(oEncrpt.oEncrypton(txtUser.Text, true) + " " + oEncrpt.oEncrypton(oHash.HashMe(txtPass.Text).ToString(), true) + System.Environment.NewLine);
                oWriter.Flush();
                oWriter.Close();
                oStream.Close();
            }
            return "";
        }

        private void SaveFile(string data)
        {
            bool works = false;
            while (works == false)
            {
                try
                {
                    //MetroFramework.MetroMessageBox.Show(this, "Saving This Will Take A Few Secconds!");
                    System.Threading.Thread.Sleep(50);
                    string tostore = oEncrpt.oEncrypton(username, true) + " " + oEncrpt.oEncrypton(password.ToString(), true) + System.Environment.NewLine + data;
                    System.IO.FileStream oStream = new FileStream("PassDat.Data", FileMode.Truncate, FileAccess.Write); //System.IO.File.OpenWrite("PassDat.Data");            
                    System.IO.StreamWriter oWriter = new System.IO.StreamWriter(oStream);
                    oWriter.WriteLine(tostore);
                    oWriter.Flush();
                    oWriter.Close();
                    oStream.Close();
                    works = true;
                }
                catch { }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (logedin)
            {
                if (txtEntry.Text != "")
                {
                    listMain.Items.Add(txtEntry.Text);
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Please Login First");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (logedin)
            {
                if (listMain.SelectedIndex != -1)
                {
                    listMain.Items.RemoveAt(listMain.SelectedIndex);
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Please Login First");
            }
        }
    }
}
