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
            textBox4.Text = "You added a new book!";
                       
            Book bookss = new (textBox1.Text , Convert.ToInt32 (textBox2.Text));

            books.Add(bookss);

            Task.Delay(1 * 1000).Wait();  
            
            textBox4.Text = String.Empty;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {           
            textBox3.Text = String.Empty;
            
            foreach (var Book in books)
            {
                textBox3.Text =  textBox3.Text + (Book.Name + Book.Year)+Environment.NewLine;
                
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}