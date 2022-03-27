using ProcedureSqlAndEntity.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcedureSqlAndEntity
{
    public partial class Form1 : Form
    {
        DbOkulEntities db = new DbOkulEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            //Öğrenci Adı, Soyadı, Kulubu nun listelendiği procedure 
            //------------------------
            //SQLDE PROCEDURE OLUŞTUR
            /*create procedure KULUPLER
             * as
             * SELECT Ogr_Ad as Öğrenci_Adı,Ogr_Soyad as Öğrenci_Soyad,KulupAd as Kulup_Adı FROM Tbl_Ogr
             * inner join Tbl_OgrKulupleri on Tbl_OgrKulupleri.KulupId=Tbl_Ogr.KulupId
             */
            //-------------------------
            dataGridView1.DataSource = db.KULUPLER();

        }
    }
}
