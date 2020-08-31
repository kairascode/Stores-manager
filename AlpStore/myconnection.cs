/*
 * Created by SharpDevelop.
 * User: ALEX KAIRA
 * Date: 11/27/2017
 * Time: 4:15 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

using MySql.Data.MySqlClient;

namespace AlpStores
{
	/// <summary>
	/// Description of myconnection.
	/// </summary>
	public class myconnection
	{
		public myconnection()
		{
		}
		
		
		public void conect(){
		
			MySqlConnection connect;
			
			string conn="Server=localhost;Database=erpid;Uid=root;Pwd=3445";
			
			connect=new MySqlConnection(conn);
			
			connect.Open();
		
		}
	}
}

