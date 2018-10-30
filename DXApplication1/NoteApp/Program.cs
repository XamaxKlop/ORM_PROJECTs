using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using System.Data.Entity;
using MySql.Data.MySqlClient;

namespace NoteApp
{
    static class Program
    {

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();

<<<<<<< HEAD
            Application.Run(new Form1()); 
=======
            Application.Run(new Form1());

            using (UserContext db = new UserContext())
            {
                User user1 = new User { Name = "Tom", Age = 33 };
                User user2 = new User { Name = "Sam", Age = 26 };

                db.Users.Add(user1);
                db.Users.Add(user2);
                db.SaveChanges();
            }

>>>>>>> 07dd67ceffde38830e682cc7ad91477a981af533
        }
    }
}