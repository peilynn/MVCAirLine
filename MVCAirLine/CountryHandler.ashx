<%@ WebHandler Language="C#" Class="CountryHandler" %>

using System;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections.Generic;
using Newtonsoft.Json;

public class CountryHandler : IHttpHandler {

	public void ProcessRequest (HttpContext context) {

		string name = "b";
		if (context.Request.QueryString["cityname"] != null ||  context.Request.QueryString["cityname"] != "Type Departure City")
		{
			name = context.Request.QueryString["cityname"];
		}

		string Strconn = ConfigurationManager.ConnectionStrings["AirLineReservationConnectionString"].ConnectionString;
		List<string> CountryNames = new List<string>();

		using (SqlConnection conn = new SqlConnection(Strconn))
		{
			string Strcmd = "select CityName from City where CityName like @CityName";
			using (SqlCommand cmd = new SqlCommand(Strcmd, conn))
			{
				cmd.Parameters.AddWithValue("@CityName", "%"+name+"%");
				conn.Open();
				SqlDataReader dr = cmd.ExecuteReader();

				//context.Response.ContentType = "text/html";
				while (dr.Read())
				{
					//context.Response.Write( dr["CustomerID"].ToString()+"<br>");
					CountryNames.Add(dr["CityName"].ToString());
				}
				context.Response.ContentType = "Application/Json";
				context.Response.Write(JsonConvert.SerializeObject(CountryNames));
			}


		}
	}

	public bool IsReusable {
		get {
			return false;
		}
	}

}