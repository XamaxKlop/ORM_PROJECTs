using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraScheduler;


namespace NoteAppV0._1
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
            InitSkinGallery();
            schedulerControl.Start = System.DateTime.Now;
        }
        void InitSkinGallery()
        {
            SkinHelper.InitSkinGallery(rgbiSkins, true);
        }

        private void barButtonItem2_ItemClick_1(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void schedulerControl_Click(object sender, EventArgs e)
        {

        }

        private void barEditItem1_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void userstoreDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "userstoreDataSet.Contacts". При необходимости она может быть перемещена или удалена.
            this.contactsTableAdapter.Fill(this.userstoreDataSet.Contacts);

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void barWorkspaceMenuItem1_ListItemClick(object sender, ListItemClickEventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            Contacts contacts = new Contacts();
            contacts.Show();
        }
    }
    
}
