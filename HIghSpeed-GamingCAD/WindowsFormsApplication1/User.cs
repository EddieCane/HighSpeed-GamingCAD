using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    public class User
    {
        public string userName;
        private Rank userRank;
        private bool isConnected;
        private DatabaseManager Database = new DatabaseManager();

        public User(string userText, Rank rank)
        {
            this.userName = userText;
            this.userRank = rank;
            this.isConnected = false;
        }
        public User()
        {
            isConnected = false;
        }
        /*public User(string userText,int rankID)
        {
            this.userName = userText;

        }*/

        private string Md5Sum(string strToEncrypt)
        {
            System.Text.UTF8Encoding ue = new System.Text.UTF8Encoding();
            byte[] bytes = ue.GetBytes(strToEncrypt);


            System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] hashBytes = md5.ComputeHash(bytes);


            string hashString = "";

            for (int i = 0; i < hashBytes.Length; i++)
            {
                hashString += System.Convert.ToString(hashBytes[i], 16).PadLeft(2, '0');
            }

            return hashString.PadLeft(32, '0');
        }

        public User Login(string userText, string passWord)
        {
            Database.Start();
            string password;
            string query = string.Format("SELECT password from cad_users where username = '{0}' AND password = '{1}'", userText, Md5Sum(passWord));
            string query2;
            int authLevel;
            Debug.WriteLine(query);
            password = Database.ReadString(query);
            if (Equals(Md5Sum(passWord), password))
            {
                query2 = string.Format("SELECT auth_level from cad_users where username = '{0}' AND password = '{1}'", userText, Md5Sum(passWord));
                authLevel = Int32.Parse(Database.ReadString(query2));
                Debug.WriteLine(authLevel);
                foreach (Rank rank in Rank.RankList.Where(rank => rank.rankID == authLevel))
                {
                    Debug.WriteLine(rank.rankID + " " + rank.rankTitle);
                    //Debug.WriteLine(userAccount);
                    this.userName = userText;
                    this.userRank = rank;
                    this.isConnected = true;
                    //Application.Exit();
                    Debug.WriteLine(this.userName + " " + this.userRank.rankTitle);
                    return this;
                }
            }
            else
            {
                Application.Exit();
                return this;
            }

            return this;
        }

        public int Logout()
        {
            this.userName = "";
            this.userRank = null;
            this.isConnected = false;
            return 0;
        }
    }
}
