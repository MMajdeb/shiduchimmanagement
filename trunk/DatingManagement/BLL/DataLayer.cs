using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Globalization;
using System.Net.Mail;
using System.Net;
using System.Management;
 
using System.IO;
using log4net;
using System.Reflection;
using System.Drawing; 
using System.Windows.Forms;
using DatingManagement.DAL;


namespace DatingManagement
{
    public static class DataLayer
    {
        public static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        static string connectionString = @"Data Source=|DataDirectory|\shiduchim.sdf;Max Database Size=2047";

        //@"Data Source=|DataDirectory|\shiduchim.sdf;Max Database Size=2047";//@"Data Source=DEOHOME-PC\MSSQLSERVER08;Initial Catalog=test;User ID=sa;Password=a";
         
        public static string ConnectionString
        {
            get
            {
                return connectionString;
            }
            set { connectionString = value; }
        }

        static string appDataPath = "";
        public static string AppDataPath
        {
            get
            {
                return appDataPath;
            }
            set { appDataPath = value; }
        }

        static string reportsAppDataPath = "";
        public static string ReportsAppDataPath
        {
            get
            {

                reportsAppDataPath = AppDataPath + "\\Reports\\{0}.rpx";
                return reportsAppDataPath;
            }
            set { reportsAppDataPath = value; }
        }

        static string layoutsAppDataPath = "";
        public static string LayoutsAppDataPath
        {
            get
            {
                layoutsAppDataPath = AppDataPath + "\\Design\\{0}.xml";
                return layoutsAppDataPath;
            }
            set { layoutsAppDataPath = value; }
        }

        static string layoutsAppPath = "";
        public static string LayoutsAppPath
        {
            get
            {
                layoutsAppPath = AppDataPath + "\\Design\\";
                return layoutsAppPath;
            }
            set { layoutsAppPath = value; }
        }

        
         


        public static string GetLayoutPath(string layoutName)
        {
            return string.Format(LayoutsAppDataPath, layoutName);
        }

        public static string GetReportsPath(string reportName)
        {
            return string.Format(reportsAppDataPath, reportName);
        }

        static bool useLocalDB;
        public static bool UseLocalDB
        {
            get
            {
                return useLocalDB;
            }
            set { useLocalDB = value; }
        }

        //static User_tbl _connectedUser;
        //public static User_tbl ConnectedUser
        //{
        //    get { return _connectedUser; }
        //    set { _connectedUser = value; }
        //}


        static ShiduchimDBDataContext _dataclass;
        public static ShiduchimDBDataContext Dataclass
        {
            get
            {

                _dataclass = new ShiduchimDBDataContext(DataLayer.ConnectionString);

                return _dataclass;
            }
            set
            {
                _dataclass = value;
            }
        }

      

        
        public static bool TestConnection(string server, string database, string username, string password, string security)
        {
            try
            {
                bool success;

                string connectionString = security + ";data source = " + server + ";Initial Catalog = " + database +
                                            ";uid = " + username + ";password = " + password;
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                sqlConnection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Years", sqlConnection);
                DataSet ds = new DataSet();
                ds.Locale = CultureInfo.CurrentCulture;
                sqlDataAdapter.Fill(ds, "Years");
                if (ds.Tables["Years"].Columns.Count > 0) success = true; else success = false;
                sqlConnection.Close();
                return success;
            }
            catch (SqlException exception)
            {
                Console.WriteLine(exception.Message);
                CLogger.WriteLog(CLogger.ELogLevel.ERROR, exception);
                return false;
            }
        }

        //public static bool LoginUser(string userName, string password)
        //{
        //    NovaHospitality dataClass = new NovaHospitality(connectionString);
        //    var LogedUser = dataClass.User_tbl.Where(user => user.Username.Equals(userName)).Where(user => user.Password.Equals(password));
        //    if (LogedUser.Count() > 0)
        //    {
        //        ConnectedUser = LogedUser.First();
        //        return true;
        //    }
        //    else
        //        return false;
        //}

       
    
            
        public static string LoadPhoto()
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image Files|*.jpg;*.gif;*.bmp;*.png;*.jpeg";
            openFile.Title = Definitions.OpenImage;
            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                return openFile.FileName;
            }
            else
                return string.Empty;
        }
         
     
        public static IList<T> Clone<T>(this IList<T> listToClone) where T : ICloneable
        {
            return listToClone.Select(item => (T)item.Clone()).ToList();
        }


        public static byte[] FileToByteArray(string _FileName)
        {
            byte[] _Buffer = null;

            try
            {
                // Open file for reading
                System.IO.FileStream _FileStream = new System.IO.FileStream(_FileName, System.IO.FileMode.Open, System.IO.FileAccess.Read);

                // attach filestream to binary reader
                System.IO.BinaryReader _BinaryReader = new System.IO.BinaryReader(_FileStream);

                // get total byte length of the file
                long _TotalBytes = new System.IO.FileInfo(_FileName).Length;

                // read entire file into buffer
                _Buffer = _BinaryReader.ReadBytes((Int32)_TotalBytes);

                // close file reader
                _FileStream.Close();
                _FileStream.Dispose();
                _BinaryReader.Close();
            }
            catch (Exception _Exception)
            {
                // Error
                CLogger.WriteLog(CLogger.ELogLevel.ERROR, _Exception.ToString());
            }

            return _Buffer;
        }
    }
}