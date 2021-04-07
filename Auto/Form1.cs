using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto
{
    public partial class Form1 : Form
    {
        private List<Auto> autokLista;
        private DataTable raktarTable;

        public Form1()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            autokLista = new List<Auto>();
            raktarTable = new DataTable();
            autokLista.Add(new Auto("Pál", "BMW", "zöld"));
            autokLista.Add(new Auto("Petra", "VW", "piros"));
            autokLista.Add(new Auto("Melinda", "Ford", "fekete"));
            autokLista.Add(new Auto("Péter", "BMW", "ezüst"));
            tablaCreate();
            tablafeltolt();

            dataGridView1.DataSource = raktarTable;//megjelenítés
        }

        private void tablafeltolt()
        {
            foreach (var auto in autokLista)
            {
                DataRow sor = raktarTable.NewRow();
                sor["Gyártó"] = auto.Gyarto;
                sor["Név"] = auto.Nev;
                sor["Szin"] = auto.Szin;
                raktarTable.Rows.Add(sor);
            }
        }

        private void tablaCreate()
        {
            DataColumn id = new DataColumn("ID", typeof(int));
            id.ReadOnly = true;
            id.Caption = "ID";
            id.AllowDBNull = false;//nem lehet null értékü, nem lehet üres
            id.Unique = true;//egyediség
            id.AutoIncrement = true;//léptelő
            id.AutoIncrementSeed = 1;
            id.AutoIncrementStep = 1;
            DataColumn gyartoColumn = new DataColumn("Gyártó", typeof(string));
            gyartoColumn.Caption= "Gyartó";
            DataColumn nevColumn = new DataColumn("Név", typeof(string));
            nevColumn.Caption = "Tulajdonos";
            DataColumn szinColumn = new DataColumn("Szin", typeof(string));
            szinColumn.Caption = "Auto szine";
            raktarTable.Columns.AddRange(new DataColumn[] {id, gyartoColumn, szinColumn, nevColumn });
        }

        private void btTorol_Click(object sender, EventArgs e)
        {
            try
            {
                raktarTable.Rows[int.Parse(txtTorol.Text)-1].Delete();
                raktarTable.AcceptChanges();//ha ez nincs akkor visszavonható lenne, lehetne a törlés
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            init();
            //try
            //{
            //    //for (int i = 0; i < raktarTable.Rows.Count; i++)
            //    //{
            //    //    raktarTable.Rows[i].Delete();
            //    //}
            //    //raktarTable.Columns["id"].AutoIncrementSeed = 1;
            //    raktarTable.Rows.Clear();
            //    raktarTable.Columns.Clear();
            //    tablaCreate();
            //    tablafeltolt();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }
    }
}
