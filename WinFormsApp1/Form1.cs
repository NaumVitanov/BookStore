using Book_Store_App.Models;
using System.Diagnostics;

namespace WinFormsApp1

{
    public partial class Form1 : Form
    {
        List<Book> books = new ();

        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Book bookss = new (textBox1.Text , Convert.ToInt32 (textBox2.Text));

            books.Add(bookss);
                



                
            


        }

        private void btnCheck_Click(object sender, EventArgs e)
        {

            textBox3.Text = String.Empty;
            
            foreach (var Book in books)
            {
                textBox3.Text =  textBox3.Text + (Book.Name + Book.Year)+Environment.NewLine;
            }

        }
    }
}