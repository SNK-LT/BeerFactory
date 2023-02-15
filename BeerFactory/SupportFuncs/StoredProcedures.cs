using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerFactory.SupportFuncs
{
	internal class StoredProcedures
	{

		static public DataTable getAccounts(OleDbConnection conn)
		{
			DataTable dt = new DataTable();
			DataSet ds = new DataSet();
			String strSQL = "SELECT * FROM Users";

			var dAdapter = new OleDbDataAdapter(strSQL, conn);
			dAdapter.Fill(ds, "Users");

			dt = ds.Tables["Users"];

			return dt;
		}

		static public DataTable getMyName(OleDbConnection conn, string myLogin)
		{
			if(myLogin[0] == 'e')
			{
				DataTable dt = new DataTable();
				DataSet ds = new DataSet();
				String strSQL = "SELECT e.fio FROM Employees AS e";

				var dAdapter = new OleDbDataAdapter(strSQL, conn);
				dAdapter.Fill(ds, "myName");

				dt = ds.Tables["myName"];
				return dt;
			}
			else 
			{
				DataTable dt = new DataTable();
				DataSet ds = new DataSet();
				String strSQL = "SELECT p.name FROM Purchasers AS p";

				var dAdapter = new OleDbDataAdapter(strSQL, conn);
				dAdapter.Fill(ds, "myName");

				dt = ds.Tables["myName"];
				return dt;
			}
			
		}
		static public DataTable getEmpIfo(OleDbConnection conn, string myLogin)
		{
			DataTable dt = new DataTable();
			DataSet ds = new DataSet();
			String strSQL = String.Format("SELECT * FROM Employees WHERE Employees.login = '{0}'", myLogin);

			var dAdapter = new OleDbDataAdapter(strSQL, conn);
			dAdapter.Fill(ds, "empInfo");

			dt = ds.Tables["empInfo"];
			return dt;
		}
		static public string getPostName(OleDbConnection conn, string myLogin)
		{
			DataTable dt = new DataTable();
			DataSet ds = new DataSet();
			String strSQL = String.Format("SELECT p.name FROM Employees AS e " +
																		"INNER JOIN Posts AS p ON p.post_id = e.post_id " +
																		"WHERE e.login = '{0}'", myLogin);

			var dAdapter = new OleDbDataAdapter(strSQL, conn);
			dAdapter.Fill(ds, "myPost");
			dt = ds.Tables["myPost"];

			string myPost = dt.Rows[0][0].ToString();

			return myPost;
		}

		static public void changeEmpInfo(OleDbConnection conn, string newName, string newHomeAdress, 
																											     string newPhone, string newMail, string myLogin)
		{
			String strSQL = String.Format("UPDATE Employees SET " +
																		"fio = '{0}'," +
																		"home_address = '{1}'," +
																		"phone = '{2}'," +
																		"mail = '{3}'" +
																		"WHERE login = '{4}'", newName, newHomeAdress, newPhone, newMail, myLogin);

			OleDbCommand cmd = new OleDbCommand(strSQL, conn);
			cmd.ExecuteNonQuery();
		}

		static public DataTable getAllStatus(OleDbConnection conn)
		{
			DataTable dt = new DataTable();
			DataSet ds = new DataSet();
			String strSQL = String.Format("");

			var dAdapter = new OleDbDataAdapter(strSQL, conn);
			dAdapter.Fill(ds, "empInfo");

			dt = ds.Tables["empInfo"];
			return dt;
		}

		static public DataTable getCurStatus(OleDbConnection conn, string myLogin)
		{
			DataTable dt = new DataTable();
			DataSet ds = new DataSet();
			String strSQL = String.Format("SELECT w.description FROM Employees AS e " +
																		"INNER JOIN WorkStatuses AS w " +
																		"ON w.status_id = e.status_id " +
																		"WHERE e.login = '{0}'", myLogin);

			var dAdapter = new OleDbDataAdapter(strSQL, conn);
			dAdapter.Fill(ds, "empStat");

			dt = ds.Tables["empStat"];
			return dt;
		}

		static public DataTable getAllStatuses(OleDbConnection conn, string curStatus)
		{
			DataTable dt = new DataTable();
			DataSet ds = new DataSet();
			String strSQL = String.Format("SELECT w.description FROM WorkStatuses AS w " +
																		"WHERE w.description != '{0}'", curStatus);

			var dAdapter = new OleDbDataAdapter(strSQL, conn);
			dAdapter.Fill(ds, "allStatuses");

			dt = ds.Tables["allStatuses"];
			return dt;
		}
		static public void sendStatusChangeReq(OleDbConnection conn, string login, string reg_status, string emp_message)
		{
			String strSQL = String.Format("EXEC Add_StatusChangeReq @login = {0}, @req_status = '{1}', @emp_message = '{2}'", login, reg_status, emp_message);

			OleDbCommand cmd = new OleDbCommand(strSQL, conn);
			cmd.ExecuteNonQuery();
		}

		static public string makeNew_Order(OleDbConnection conn, string login, string address)
		{
			DataTable dt = new DataTable();
			DataSet ds = new DataSet();


			String strSQL = String.Format("EXEC MakeNew_Order @login = {0}, @address = '{1}'", login, address);
			OleDbCommand cmd = new OleDbCommand(strSQL, conn);
			cmd.ExecuteNonQuery();

			strSQL = String.Format("SELECT MAX(o.ord_id) FROM Orders AS o WHERE o.login = '{0}'", login);
			var dAdapter = new OleDbDataAdapter(strSQL, conn);
			dAdapter.Fill(ds, "newOrder");

			dt = ds.Tables["newOrder"];

			return dt.Rows[0][0].ToString();
		}
		static public void makeNew_OrderDetail(OleDbConnection conn, string ord_id, string product, string quantity)
		{
			String strSQL = String.Format("EXEC MakeNew_OrderDetail @ord_id = {0}, @product_id = {1}, @quantity = {2}",
																		 ord_id, product, quantity);

			OleDbCommand cmd = new OleDbCommand(strSQL, conn);
			cmd.ExecuteNonQuery();
		}




		static public DataTable getAllOrderStatuses(OleDbConnection conn, string curStatus)
		{
			DataTable dt = new DataTable();
			DataSet ds = new DataSet();
			String strSQL = String.Format("SELECT o.description FROM OrderStatuses AS o WHERE o.description != '{0}'", curStatus);

			var dAdapter = new OleDbDataAdapter(strSQL, conn);
			dAdapter.Fill(ds, "allStatuses");

			dt = ds.Tables["allStatuses"];
			return dt;
		}

		static public void dellEmp(OleDbConnection conn, string empId)
		{
			DataTable dt = new DataTable();
			DataSet ds = new DataSet();
			String strSQL = String.Format("SELECT e.login FROM Employees AS e " +
																		"INNER JOIN Users AS u ON u.login = e.login " +
																		"WHERE e.emp_id = {0}", empId);

			var dAdapter = new OleDbDataAdapter(strSQL, conn);
			               dAdapter.Fill(ds, "allStatuses");

			dt = ds.Tables["allStatuses"];

			strSQL = String.Format("DELETE FROM Users WHERE login = '{0}'", dt.Rows[0][0].ToString());

			OleDbCommand cmd = new OleDbCommand(strSQL, conn);
			cmd.ExecuteNonQuery();
		}
	}
}
