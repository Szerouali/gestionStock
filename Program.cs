using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;



namespace Nike
{
    
    static class Program
    {
        static View view;
        static View2 view2;
        static View3 view3;
        static Views4 view4;
       

        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            view = new View();
            view.buttonAjouter.Click += new EventHandler(buttonClick);
            view.buttonLister.Click += new EventHandler(buttonClick);

            view2 = new View2();
            view2.buttonEnregistrer.Click += new EventHandler(buttonClick);
            view2.buttonAnnuler.Click += new EventHandler(buttonClick);
            view2.buttonSupprimer.Click += new EventHandler(buttonClick);

            view3 = new View3();
            view3.buttonTop.Click += new EventHandler(buttonClick);
            view3.buttonBas.Click += new EventHandler(buttonClick);
            view3.buttonChaussure.Click += new EventHandler(buttonClick);
            view3.buttonTout.Click += new EventHandler(buttonClick);
            view3.buttonAccessoire.Click += new EventHandler(buttonClick);
            view3.buttonRetour.Click += new EventHandler(buttonClick);
            view3.buttonDetail.Click += new EventHandler(buttonClick);

            view4 = new Views4();
            view4.buttonRetourListe.Click += new EventHandler(buttonClick);
            view4.buttonModifier.Click += new EventHandler(buttonClick);
            view4.buttonSup.Click += new EventHandler(buttonClick);

            Application.Run(view);
        }

        static void buttonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (button.Equals(view.buttonAjouter))
            {
                view.Visible = false;
                view2.Visible = true;
            }
            if (button.Equals(view.buttonLister))
            {
                view.Visible = false;
                view3.Visible = true;
            }
            if (button.Equals(view3.buttonTop))
            {
                string top = "select * from product where category='Hauts'";
                view3.refresh(top);

            }
            if (button.Equals(view3.buttonBas))
            {
                string bas = "select * from product where category='Bas'";
                view3.refresh(bas);
            }
            if (button.Equals(view3.buttonChaussure))
            {
                string baskets = "select * from product where category='Baskets'";
                view3.refresh(baskets);
            }
            if (button.Equals(view3.buttonTout))
            {
                string tout = "select * from product ";
                view3.refresh(tout);
            }
            if (button.Equals(view3.buttonAccessoire))
            {
                string accessoire = "select * from product where category='Accessoires'";
                view3.refresh(accessoire);
            }
            if (button.Equals(view3.buttonRetour))
            {
                view3.Visible = false;
                view.Visible = true;
            }
            if (button.Equals(view2.buttonSupprimer))
            {
                System.Windows.Forms.MessageBox.Show("Êtes vous sur de vouloir supprimer ce produit?", "Nike",
                    System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            if (button.Equals(view2.buttonAnnuler))
            {
                view.Visible = true;
                view2.Visible = false;
            }

            if (button.Equals(view4.buttonRetourListe))
            {
                view3.Visible = true;
                view4.Visible = false;
            }

            if (button.Equals(view3.buttonDetail))
            {
                view3.Visible = false;
                view4.Visible = true;
            }
        }
    }
}
