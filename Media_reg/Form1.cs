using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Media_reg
{

    public partial class Form1 : Form
    {
        //Listan där all media (böcker och filmer) sparas i.
        private List<Media> media = new List<Media>
        {
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void Author_Input_B_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void Titel_Input_B_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button_Container_Enter(object sender, EventArgs e)
        {

        }

        // Ändrar statusen för ChRB till den nuvarande valda radio button.
        private void Button_A_CheckedChanged(object sender, EventArgs e)
        {
            ChRB = (sender as RadioButton).Text;
            Show_Medias();
        }


        private void Button_B_CheckedChanged(object sender, EventArgs e)
        {
            ChRB = (sender as RadioButton).Text;
            Show_Medias();

        }

        private void Button_F_CheckedChanged(object sender, EventArgs e)
        {
            ChRB = (sender as RadioButton).Text;
            Show_Medias();
        }




        // Knappen för att lägga till en bok när man matat i titelm, författare och bokens längd, saknas något får man ett felmeddelande.

        public void Add_B_Click(object sender, EventArgs e)
        {
            String title = Titel_Input_B.Text;
            String author = Author_Input_B.Text;
            String nrOfPages = Length_Input_B.Text;

            if (nrOfPages == "0" || nrOfPages == "" || author == "" || title == "")
            {
                MessageBox.Show("Ogiltigt värde, kolla igenom din inmatning!");
            }
            else
            {
                clearBox();
                media.Add(new Book()
                {
                    Title = title,
                    Author = author,
                    NrOfPages = nrOfPages
                });
                Show_Medias();
            }
        }

        // Knappen för att lägga till en film när man matat i titel, regissör och filmens längd, saknas något får man ett felmeddelande.
        public void Add_F_Click(object sender, EventArgs e)
        {
            String title = Titel_Input_F.Text;
            String director = Director_Input_F.Text;
            String length = Length_Input_F.Text;

            if (length == "0" || director == "" || title == "")
            {
                MessageBox.Show("Ogiltigt värde, kolla igenom din inmatning!");
            }
            else
            {
                clearBox();
                media.Add(new Film()
                {
                    Title = title,
                    Director = director,
                    Length = length
                });
                Show_Medias();
            }
        }

        private void Media_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Rensar alla inmatningsrutor när funktioen används.
        private void clearBox()
        {
            Titel_Input_B.Text = String.Empty;
            Author_Input_B.Text = String.Empty;
            Titel_Input_F.Text = String.Empty;
            Director_Input_F.Text = String.Empty;
            Length_Input_B.Text = String.Empty;
            Length_Input_F.Text = String.Empty;
        }

        //Stringen för den radio button som är vald.
        private string ChRB = "Alla";

        //Funktion för att rensa listan så att flera kopior av samma bok i listan inte visas.
        private void Show_Medias()
        {

            Show_Media.Items.Clear();

            switch (ChRB)
            {
                case "Alla":

                    foreach (Media m in media)
                    {
                        Show_Media.Items.Add(m.ToString());
                    }
                    break;

                case "Böcker":

                    foreach (Book b in media.OfType<Book>())
                    {
                        Show_Media.Items.Add(b.ToString());
                    }
                    break;

                case "Filmer":

                    foreach (Film f in media.OfType<Film>())
                    {
                        Show_Media.Items.Add(f.ToString());
                    }
                    break;
            }
        }
    }
}
