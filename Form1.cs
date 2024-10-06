using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq.Expressions;
using System.Diagnostics;
using System.Runtime.Remoting.Contexts;

namespace LibrarySystemFrontend
{
    public partial class Form1 : Form
    {
        LibrarySystemEntities db = new LibrarySystemEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Reservation_Click(object sender, EventArgs e)
        {

        }

        private void buttonUyeKaydi_Click(object sender, EventArgs e)
        {
            Borrowers b = new Borrowers();
            b.FirstName = UyeEklemeisim.Text;
            b.LastName = UyeEklemeSoyisim.Text;
            b.MembershipDate = DateTime.Now;
            b.Phone = UyeEklemeTelefon.Text;
            b.Email = UyeEklemeMail.Text;
            db.Borrowers.Add(b);
            db.SaveChanges();
            MessageBox.Show("Üye Kaydedildi");

        }

        private void buttonUyeKaydiSilme_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(UyeSorgulamaID.Text);
            var uye = db.Borrowers.Find(id);
            db.Borrowers.Remove(uye); db.SaveChanges();
            MessageBox.Show("Üye Kaydı Sonlandırıldı");
        }

        private void buttonUyeSorgulama_Click_1(object sender, EventArgs e)
        {
            string UyeID = UyeSorgulamaID.Text;
            string UyeAd = UyeSorgulamaisim.Text;
            string UyeSoyad = UyeSorgulamaSoyisim.Text;

            using (var context = new LibrarySystemEntities())
            {
                var query = context.Borrowers.AsQueryable();

                if (int.TryParse(UyeID, out int uyeid))
                {
                    query = query.Where(x => x.BorrowerID == uyeid);
                }

                if (!string.IsNullOrEmpty(UyeAd))
                {
                    query = query.Where(x => x.FirstName == UyeAd);
                }

                if (!string.IsNullOrEmpty(UyeSoyad))
                {
                    query = query.Where(x => x.LastName == UyeSoyad);
                }

                var Borrowers = query.ToList();
                UyelikGosterge.DataSource = Borrowers;
            }
        }

        private void buttonKitapSorgulama_Click(object sender, EventArgs e)
        {
            string ISBN = KitapSorgulamaISBN.Text;
            string Title = KitapSorgulamaKitapismi.Text;
            string AuthorName = KitapSorgulamaYazar.Text;
            string PublisherName = KitapSorgulamaYayinevi.Text;

            using (var context = new LibrarySystemEntities())
            {
                var query = context.Books.AsQueryable();

                if (!string.IsNullOrEmpty(ISBN))
                {
                    query = query.Where(x => x.ISBN == ISBN);
                }

                if (!string.IsNullOrEmpty(Title))
                {
                    query = query.Where(x => x.Title.Contains(Title));
                }

                if (!string.IsNullOrEmpty(AuthorName))
                {
                    var author = context.Authors
                    .FirstOrDefault(a => a.FirstName.Contains(AuthorName));

                    if (author != null)
                    {
                        // Eğer yazar bulunduysa, AuthorID'ye göre kitapları filtrele
                        query = query.Where(b => b.AuthorID == author.AuthorID);
                    }
                    else
                    {
                        MessageBox.Show("Author not found.");
                        return;
                    }
                }
                if (!string.IsNullOrEmpty(PublisherName))
                {
                    var publisher = context.Publishers.FirstOrDefault(p => p.Name.Contains(PublisherName));

                    if (publisher != null)
                    {
                        query = query.Where(x => x.PublisherID == publisher.PublisherID);
                    }
                }
                var books = query.ToList();
                KitapSorgulamaGosterge.DataSource = books;
            }
        }

        private void buttonKitapKayit_Click(object sender, EventArgs e)
        {
            using (var context = new LibrarySystemEntities())
            {
                string Title = KitapKayitisim.Text;
                string Author = KitapKayitYazar.Text;
                string Publisher = KitapKayitYayinci.Text;
                int ISBN = Convert.ToInt32(KitapKayitISBN.Text);
                string Genre = KitapKayitGenre.Text;
                int Year = Convert.ToInt32(KitapKayitBasimYili.Text);
                int Pages = Convert.ToInt32(KitapKayitSayfa.Text);
                int Copy = Convert.ToInt32(KitapKayitKopya.Text);
                context.Database.ExecuteSqlCommand("EXEC AddBook @p0, @p1, @p2, @p3, @p4, @p5, @p6, @p7",
                    Title, Author, Publisher, ISBN, Genre, Year, Pages, Copy);
                context.SaveChanges();
            }
            MessageBox.Show("Kitap Kaydı Başarılı.");
        }


        private void buttonKitapAlimSorgu_Click(object sender, EventArgs e)
        {
            using (var context = new LibrarySystemEntities())
            {
                // Kullanıcının bilgilerini almak
                string firstName = KitapAlimUyeAd.Text;
                string lastName = KitapAlimUyeSoyad.Text;
                string bookTitle = KitapAlimKitapSorgu.Text;

                // Üyenin kimliğini bul
                var borrower = context.Borrowers
                    .FirstOrDefault(b => b.FirstName == firstName && b.LastName == lastName);

                if (borrower == null)
                {
                    MessageBox.Show("Üye bulunamadı.");
                    return;
                }

                // Kitap ismine göre kitabı bul
                var book = context.Books
                    .FirstOrDefault(b => b.Title.Contains(bookTitle)); // Kısmi eşleşme

                if (book == null)
                {
                    MessageBox.Show("Kitap bulunamadı.");
                    return;
                }

                // Gösterim için
                var loans = context.Loans
                    .Where(l => l.BorrowerID == borrower.BorrowerID &&
                                l.BookCopies.BookID == book.BookID)
                    .Select(l => new
                    {
                        l.BookCopies.CopyID,
                        l.BookCopies.CopyStatus, 
                        l.LoanDate,
                        l.ReturnDate
                    })
                    .ToList();

                OduncKitapGosterge.DataSource = loans;

                // Eğer ödünç alım yoksa
                if (loans.Count == 0)
                {
                    MessageBox.Show("Üyeye ait ödünç alım bulunmamaktadır.");
                }
            }
        }

        private void buttonRezervasyonveOdunc_Click(object sender, EventArgs e)
        {
            using (var context = new LibrarySystemEntities())
            {
                // Kullanıcının bilgilerinin alınması
                string firstName = RezervasyonUyeAdi.Text;
                string lastName = RezervasyonUyeSoyad.Text;
                string bookTitle = RezervasyonKitapAdi.Text;

                // Üyenin kimliği ve ödünç alım kontrolleri
                var borrower = context.Borrowers
                    .FirstOrDefault(b => b.FirstName == firstName && b.LastName == lastName);

                if (borrower == null)
                {
                    MessageBox.Show("Üye bulunamadı.");
                    return;
                }

                if (borrower.CurrentLoanCount >= 2)
                {
                    MessageBox.Show("Üyenin ödünç aldığı 2 kitap var, ödünç verilemez veya rezerve edilemez.");
                    return;
                }

                // Kitap ismine göre kitabı bulma
                var book = context.Books
                    .FirstOrDefault(b => b.Title == bookTitle);

                if (book == null)
                {
                    MessageBox.Show("Kitap bulunamadı.");
                    return;
                }

                // Kitabın uygun kopyasının aranması
                var availableCopy = context.BookCopies
                    .FirstOrDefault(bc => bc.CopyID == book.BookID && bc.CopyStatus == "Available");

                if (availableCopy != null) // Kopya bulunursa
                {
                    // Kitabı ödünç verme işlemi
                    var loan = new Loans
                    {
                        CopyID = availableCopy.CopyID,
                        BorrowerID = borrower.BorrowerID,
                        LoanDate = DateTime.Now,
                        ReturnDate = DateTime.Now.AddDays(14)
                    };

                    context.Loans.Add(loan);
                    availableCopy.CopyStatus = "CheckedOut"; // Kitap ve Üye durum değişikliği
                    borrower.CurrentLoanCount += 1;
                    context.SaveChanges();

                    MessageBox.Show("Kitap ödünç verildi.");
                }
                else
                {
                    // Kopya bulunmazsa
                    var reservation = new Reservation
                    {
                        BookID = book.BookID,
                        BorrowerID = borrower.BorrowerID,
                        ReservationDate = DateTime.Now
                    };

                    context.Reservation.Add(reservation);
                    context.SaveChanges();

                    MessageBox.Show("Kitap şu an müsait değil, rezervasyon yapıldı.");
                }
        }   }

        
    }
}
