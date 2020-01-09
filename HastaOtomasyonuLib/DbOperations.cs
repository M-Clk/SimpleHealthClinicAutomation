using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaOtomasyonuLib
{
    public class DbOperations
    {
        private static DbOperations _instance;
        SqlConnection sqlConnection;

        private DbOperations()
        {
            //TODO hocaya gonderirken Server=.; olarak degistir.
            sqlConnection = new SqlConnection(@"Server=LENOVO\CELIK;Database=HastaneDB;Trusted_Connection=True;");
        }

        static public DbOperations GetInstance() //Singleton klasigi
        {
            if (_instance == null)
                _instance = new DbOperations();
            return _instance;
        }
        //TODO parametre gerektiren sorgularda command nesnesini olusturup once parametreleri ekleyip oyle gonderiyoruz.
        public DataTable Sorgu(string procName, List<SqlParameter> parameters)
        {
            SqlCommand parametreliCommand = new SqlCommand(procName, sqlConnection);
            parametreliCommand.Parameters.AddRange(parameters.ToArray());

            DataTable fulTable = DisconnectedQuery(parametreliCommand);

            return fulTable;
        }
        //TODO kontrol yaparak baglanti ac. 
        //INFO Cunku eger baglanti acikken acmaya calisilirsa hata verir (genelde sql islemleri yapilirken exception firlatildiktan sonra bu islem yapilmaya calistiginda bu problemle karsilasilir)
        void OpenConnection()
        {
            if (sqlConnection.State == ConnectionState.Closed)
                sqlConnection.Open();
        }
        //TODO yukardakinin aynisi kapatma islemi icin de gecerli.
        void CloseConnection()
        {
            if (sqlConnection.State == ConnectionState.Open)
                sqlConnection.Close();
        }
        //TODO parametresiz sorgularda command nesnesini ortak islemleri yapan metoda direk olusturularak gonderiyoruz.
        public DataTable Sorgu(string procName)
        {
            DataTable fulTable = DisconnectedQuery(new SqlCommand(procName, sqlConnection));

            return fulTable;
        }
        //TODO Disconnected baglantilarda belirli tablolodan bir sorgu yapilacaksa hep ayni adimlar gerceklestirilir. ayni kodlari farkli yerlere yazmak yerine tek metodda toplandi
        private DataTable DisconnectedQuery(SqlCommand command)
        {
            OpenConnection();
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            CloseConnection();
            
            return dataTable;
        }

        //TODO update icin connected baglanti turunu kullandik. 
        //INFO Cunku bir update baglanti tipi icin devamli sql tarafi ile devamli iletisim halinde kalmak sozkonusu degil. Ayrica bunu disconnected baglantida update islemi icin bir dataset/datatable elde edilmis olmali gercek tablo parametre olarak verilen dataset/datatable tablosu ile degisecektir. Onun icin bir guncelleme islemi icin tum verilerin onceden elinde olmasi gerekir(yani buna ihtiyac olmadigi halde once tablodaki tum veriler veritabanindan cekilip datasete aktarilir. guncellenip tekrar veritabanina gonderirlir.) bu zahmetli bir istir.
        //INFO insert, update, delete islemlerinde sorgularimiz bizden her durumda parametre bekledigi icin, parametresiz metodu overload yapmamiza gerek yoktur.

        //UPDATE burda varolan primary key ile yeni kayit eklenmeye calisilirsa hata verir. Onun icin try catch kullan
        public bool Update(string procName, List<SqlParameter> parameters)
        {

            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(procName, sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddRange(parameters.ToArray());
                bool sonuc = sqlCommand.ExecuteNonQuery() > 0;
                sqlCommand.Dispose();
                sqlConnection.Close();
                return sonuc;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

    }
}
