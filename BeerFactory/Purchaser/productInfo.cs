using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeerFactory
{
	public partial class productInfo : Form
	{
		private BindingSource bs = new BindingSource();

		private OleDbConnection e_cn;
		private string beer_id;
		public productInfo(OleDbConnection cn, string id)
		{
			InitializeComponent();
			DataTable dtTmp = new DataTable();
			e_cn = cn;
			beer_id = id;

			string strSQL = String.Format(@"SELECT p.name AS 'Наименование', protein AS 'Белки', pc.fats AS 'Жиры', 
																			pc.carbs AS 'Углеводы', pc.energy AS 'Эн. ценность', pc.strength AS 'Крепость' 
																			FROM ProductContent AS pc 
                                      INNER JOIN Products AS p ON p.product_id = pc.product_id 
																			WHERE p.product_id = {0}", beer_id);

			OleDbDataAdapter dataAdapter = new OleDbDataAdapter(strSQL, e_cn);
			dataAdapter.Fill(dtTmp);
			bs.DataSource = dtTmp;
			dgwInfo.DataSource = bs;
			dgwInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
		}

		private void productInfo_Load(object sender, EventArgs e)
		{

		}

		private void bBack_Click(object sender, EventArgs e)
		{
			this.Hide();
		}
	}
}
