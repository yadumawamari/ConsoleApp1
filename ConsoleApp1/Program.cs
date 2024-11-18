using Npgsql;
using System;


class Wamari
{
    static void Main(string[] args)
    {
        String ConnString = ("Server=localhost; Database=lamisplus; Password=lamis; Port=5432; User ID=postgres;");
		try
		{
			using (var conn = new NpgsqlConnection(ConnString)) 
				conn.Open();
			Console.WriteLine("Connected Successfully");
		}
		catch (Exception ErrorMessage)
		{

			Console.WriteLine($"An error occured;{ErrorMessage}");
		}

    }
}