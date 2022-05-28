using ChildCare.MonitoringSystem.Business;
using ChildCare.MonitoringSystem.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChildCare.MonitoringSystem.Web.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;

using Microsoft.AspNetCore.Hosting;
using System.IO;
using ChildCare.MonitoringSystem.Core.Models;
using ChildCare.MonitoringSystem.Entity;
using MySql.Data.MySqlClient;
using System.IO.Ports;
using System.Windows.Forms;
using System.Threading;

namespace ChildCare.MonitoringSystem.Web.Controllers
{
	[Authorize()]
	public class StudentController :Controller
	{
        private readonly Core.Models.ApplicationContext applicationContext; 
		private readonly StudentBusiness studentBusiness;
		private readonly string profilePicPath = "profilepics";
		private static List<string> uploadedImages = new List<string>();
		private readonly IHostingEnvironment environment;
        SerialPort serialPort = new SerialPort("COM3",
9600, Parity.None, 8, StopBits.One);
        private string data="";
        bool flag=false;
        string longitude = "74.924192";
        string latitude = "12.979621";
        public StudentController(StudentBusiness studentBusiness, Core.Models.ApplicationContext applicationContext, IHostingEnvironment environment)
		{
			this.studentBusiness = studentBusiness;
            this.applicationContext = applicationContext;
			this.environment = environment;
		}



		//public ActionResult<StudentModel> AddStudent(StudentModel studentmodel)
		//{
		//	var student = this.studentBusiness.AddStudent(studentmodel);
		//	return student;
		//}


		public ActionResult<List<StudentModel>> GetStudentDetail(String batch)
		{
			var students = this.studentBusiness.GetStudents(batch);
			return students;
		}


		public ActionResult<StudentModel> StudentGetById(int id)
		{
			var students = this.studentBusiness.StudentGetById(id);
			return students;
		}
        public ActionResult<StudentModel> GetUsersStudentInfo()
        {
            var students = this.studentBusiness.GetUsersStudentInfo(applicationContext.UserId);
            return students;
        }

		[HttpPost]
        public ActionResult<StudentDetail> StudentUpdate(StudentDetail studentModel,String oldimage)
		{
		
			string imageName = Guid.NewGuid().ToString() + Path.GetExtension(studentModel.StudentImg.FileName);	
			string savePath = Path.Combine(environment.WebRootPath, this.profilePicPath, imageName);
			
			oldimage = Path.GetFileName(oldimage);
			using (var stream = new FileStream(savePath, FileMode.OpenOrCreate))
			{
				studentModel.StudentImg.CopyTo(stream);
			}
			uploadedImages.Add(imageName);
			imageName = "/profilepics/" + imageName;

			StudentModel studentModel1 = new StudentModel();
			UserModel userModel = new UserModel();

			studentModel1.StudentId = studentModel.StudentId;
			studentModel1.StudentName = studentModel.StudentName;
			studentModel1.StudentImg = imageName;
			studentModel1.StudentAddress = studentModel.StudentAddress;
			studentModel1.StudentGender = studentModel.StudentGender;
			studentModel1.StudentDob = studentModel.StudentDob;
			studentModel1.FatherName = studentModel.FatherName;
			studentModel1.MotherName = studentModel.MotherName;
			userModel.UserName = studentModel.UserName;
			userModel.UserName = studentModel.UserName;
			userModel.UserEmail = studentModel.UserEmail;
			userModel.UserMobileNo = studentModel.UserMobileNo;

			var student = this.studentBusiness.StudentUpdate(studentModel1, userModel);
			return RedirectToAction("StudentView", "Dashboard");
			//return null;
		}

        [HttpGet]
        public ActionResult<Int32> getlocation()
        {
            int maxRetries = 2;
            const int sleepTimeInMs = 50;
            string loggingMessage = string.Empty;
            if (!flag)
            {
                //serialPort.Open();
                flag = true;

            }
            while (maxRetries > 1)
            {
                try
                {

                    loggingMessage += "Succeeded.";
                    string data1 = "";
                    string data2 = "";
                    if (data1.StartsWith('0'))
                    {
                        data1=data1.Replace(".","");
                        data1.Remove(0,1);
                        data1=data1.Substring(1);
                        longitude = data1.Substring(0, 2) + "." + data1.Substring(2);
                    }
                    if (data2.StartsWith('1'))
                    {
                        data2= data2.Replace(".", "");
                        latitude = data2.Substring(0, 2) + "." + data2.Substring(2);
                    }
                    Thread.Sleep(sleepTimeInMs);
                    maxRetries--;
                    // serialPort.Close();
                }
                catch (UnauthorizedAccessException unauthorizedAccessException)
                {
                    maxRetries--;
                    loggingMessage += "Failed (UnauthorizedAccessException): ";
                    Thread.Sleep(sleepTimeInMs);
                }
                catch (Exception exception)
                {
                    loggingMessage += "Failed: ";
                }
            }
            var studentlocation = this.studentBusiness.UpdateStudentLocation(applicationContext.UserId, latitude, longitude);
            // Attach a method to be called when there
            // is data waiting in the port's buffer


            // Begin communications
            // port.Open();

            // Enter an application loop to keep this thread alive
            // Application.Run();
           // serialPort.Close();

            //using (SqlConnection con = new SqlConnection("Data Source=192.168.43.28:80;Initial Catalog=test_pathol;Integrated Security=True"))
            //{
            //    SqlCommand cmd = new SqlCommand("select * from gps;");
            //    cmd.Connection = con;
            //    con.Open();
            //    DataSet ds = new DataSet();


            //    SqlDataAdapter v_sda = new SqlDataAdapter(cmd);

            //    v_sda.Fill(ds);
            //    var a = ds.Tables[0].Rows.Count;

            //}
            //string con = "datasource=127.0.0.1;port=3306;user=root;password=;database= test_pathol";
            //string query = "SELECT * FROM gps where id=(SELECT MAX(id) FROM gps)";

            //MySqlConnection databaseconnect = new MySqlConnection(con);
            //MySqlCommand commandDatabase = new MySqlCommand(query, databaseconnect);
            //MySqlDataReader reader;
            //try
            //{
            //    databaseconnect.Open();
            //    reader = commandDatabase.ExecuteReader();
            //    if (reader.HasRows)
            //    {
            //        while (reader.Read())
            //        {
            //            string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), };
            //            var studentlocation = this.studentBusiness.UpdateStudentLocation(applicationContext.UserId,row[1],row[2]);
            //        }
            //    }

            //}
            //catch
            //{
            //    string a;
            //}
            return 0;
        }
        public ActionResult<StudentLocationModel> GetStudentLocation()
        {
            //SerialPort serialPort = new SerialPort("COM6", 9600);

            //serialPort.Open();
            //string mess = serialPort.ReadLine();
            //serialPort.Close();
            getlocation();
            var studentlocation = this.studentBusiness.GetStudentLocation(applicationContext.UserId);
            return studentlocation;
        }
        public ActionResult<List<StudentLocationModel>> GetAllStudentLocation(int studentid)
        {
            var studentlocation = this.studentBusiness.GetAllStudentLocation(studentid);
            return studentlocation;
        }
        private void port_DataReceived(object sender,
     SerialDataReceivedEventArgs e)
        {
            // Show all the incoming data in the port's buffer
             data = (serialPort.ReadExisting());
        }

        private void RFID_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            data = serialPort.ReadExisting();
            serialPort.Close();
        }
        public ActionResult<BusLocationModel> GetBusLocation()
        {
            var studentlocation = this.studentBusiness.GetBusLocation(applicationContext.UserId);
            return studentlocation;
        }
		
		public ActionResult<List<BusLocationModel>> GetAllBusLocation(int busid)
        {


			var studentlocation = this.studentBusiness.GetAllBusLocation(busid);
            return studentlocation;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult<Int32> StudentDeleteId(int id)
		{
			var students = this.studentBusiness.DeleteId(id);
			return students;
		}
	}
}




















































