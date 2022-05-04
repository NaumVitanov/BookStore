using Book_Store_App.Models;
using System.Diagnostics;

namespace WinFormsApp1

{
    public partial class Form1 : Form
    {
        List<Book> books = new();

        public Form1()
        {
            InitializeComponent();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (string.IsNullOrEmpty(textBox1.Text) | (string.IsNullOrEmpty(textBox2.Text)) | (string.IsNullOrEmpty(textBox5.Text)))
                {
                    MessageBox.Show("You must fill all of the requerd information to proceed");
                    return;
                }                           

                else

                {
                    Book books2 = new(textBox1.Text, Convert.ToInt32(textBox2.Text), textBox5.Text);

                    books.Add(books2);
                }
            }
            catch (FormatException)
            {

                MessageBox.Show("Please enter a whole number in the Year field!");
            }
            if (books.Count > 0)
            {
                MessageBox.Show("You have succesufuly added a book!");
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            textBox3.Text = String.Empty;

            foreach (var Book in books)
            {
                textBox3.Text = textBox3.Text + "Name of the book:" + Book.Name + Environment.NewLine + "Year of the book:" + Book.Year + Environment.NewLine + "Book Genre:" + Book.Genre + Environment.NewLine + Environment.NewLine;

            }
        }
    }
}
    


