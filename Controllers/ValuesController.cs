using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Configuration;

namespace pro.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        //     <PackageReference Include="Microsoft.AspNetCore.All" Version="2.0.8" />
 

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // GET api/values/5
        [HttpGet]
        public string GetVisitors()
        {
            string connectionString =  @"Server=localhost\SQLEXPRESS;Database=ineight_project;Trusted_Connection=True;";            
            SqlCommand command;
            SqlConnection connection = new SqlConnection(connectionString);

            try{

                try{
                    connection.Open();
                    try{
                        string sql = "SELECT * FROM ";                 
                        command = new SqlCommand(sql, connection);
                         command.ExecuteNonQueryAsync();
                        return "success";
                    }
                    catch (System.Data.SqlClient.SqlException ex){
                                                                  return "failiure" + ex;
                    } 
                }               
                catch (Exception ex){
                                     return "failiure" + ex;
                }
            }
            finally{   
                    if(connection != null){
                        connection.Close();
                    }

            } 

            // System.Diagnostics.Debug.WriteLine("connection :" + connection);
            // List<Visitors> visitorList =  new List<Visitors>();
            //  return visitorList;
        }

        // POST api/values
        [HttpPost]
        public string Postvisitors()
        {
            string connectionString =  @"Server=localhost\SQLEXPRESS;Database=ineight_project;Trusted_Connection=True;";            
            SqlCommand command;
            SqlConnection connection = new SqlConnection(connectionString);

            try{

                try{
                    connection.Open();
                    try{
                        string sql = "INSERT INTO [dbo].[visitor_info2](vid ,vname,phone_no ,email,type ,reason,date_timein,date_timeout) VALUES ('1000','abcd','123456789','asdf@cvb.com','visitor','fes','2012-02-26 09:34:00.000','2012-02-26 10:34:00.000')";                 
                        command = new SqlCommand(sql, connection);
                         command.ExecuteNonQueryAsync();
                        return "success";
                    }
                    catch (System.Data.SqlClient.SqlException ex){
                                                                  return "failiure" + ex;
                    } 
                }               
                catch (Exception ex){
                                     return "failiure" + ex;
                }
            }
            finally{   
                    if(connection != null){
                        connection.Close();
                    }

            }    
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public string Put(int id, [FromBody]string value)
        {
            string connectionString =  @"Server=localhost\SQLEXPRESS;Database=ineight_project;Trusted_Connection=True;";            
            SqlCommand command;
            SqlConnection connection = new SqlConnection(connectionString);

            try{

                try{
                    connection.Open();
                    try{
                        string sql = "INSERT INTO [dbo].[visitor_info2](vid ,vname,phone_no ,email,type ,reason,date_timein,date_timeout) VALUES ("+id+",'abcd','123456789','asdf@cvb.com','visitor','fes','2012-02-26 09:34:00.000','2012-02-26 10:34:00.000')";                 
                        command = new SqlCommand(sql, connection);
                         command.ExecuteNonQueryAsync();
                        return "success";
                    }
                    catch (System.Data.SqlClient.SqlException ex){
                                                                  return "failiure" + ex;
                    } 
                }               
                catch (Exception ex){
                                     return "failiure" + ex;
                }
            }
            finally{   
                    if(connection != null){
                        connection.Close();
                    }

            } 
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
