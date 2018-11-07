using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.LookAndFeel;

namespace NoteAppV0._1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           /* using (ContactContext db = new ContactContext())
            {
                Contact contact1 = new Contact { name = "Nick", age = 19, homeNumber0 = 798898898998, organization = "Komitet",
                                                        surname = "Polhovsky", position = "student" };
                db.Contacts.Add(contact1);
                db.SaveChanges();
            }*/

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();

            Application.Run(new Form1());
        }
    }
}