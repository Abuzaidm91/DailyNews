using DailyNew.Models;
using DailyNews;
using DailyNews.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Forms.VisualStyles;

namespace DailyNews
{
    internal static class DataBaseManager
    {
       
        static int ReaderId;
        static SqlConnection con = new SqlConnection("Server=AHMAD-SVR\\SQLEXPRESS;Database=DailyNews;Trusted_Connection=True;MultipleActiveResultSets=true");
        
        static DataTable AllNewsTable;

        public static List<News> GetNews(Nullable<DateTime> StartDate, Nullable<DateTime> EndDate,
            Nullable<Boolean> IsRead, string Region, string Resource, string Observer, string KeyWord
            , Boolean IsFavourite)
        {
            try
            {
                con.Open();
                List<News> AllNews = new List<News>();
                SqlCommand cmd = new SqlCommand("GetNews", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ReaderId", ReaderId);
                if (StartDate == null)
                {
                    cmd.Parameters.AddWithValue("@StartDate", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@StartDate", StartDate);
                }

                if (EndDate == null)
                {
                    cmd.Parameters.AddWithValue("@EndDate", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@EndDate", EndDate);
                }

                if (IsRead == null)
                {
                    cmd.Parameters.AddWithValue("@IsRead", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@IsRead", IsRead);
                }

                if (Region == null)
                {
                    cmd.Parameters.AddWithValue("@Region", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Region", Region);
                }

                if (Resource == null)
                {
                    cmd.Parameters.AddWithValue("@Resource", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Resource", Resource);
                }

                if (Observer == null)
                {
                    cmd.Parameters.AddWithValue("@Observer", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Observer", Observer);
                }

                if (KeyWord == null)
                {
                    cmd.Parameters.AddWithValue("@KeyWord", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@KeyWord", KeyWord);
                }

                if (IsFavourite == false)
                {
                    cmd.Parameters.AddWithValue("@IsFavourite", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@IsFavourite", IsFavourite);
                }
                AllNewsTable = new DataTable();
                new SqlDataAdapter(cmd).Fill(AllNewsTable);
                con.Close();

                AllNews = AllNewsTable.AsEnumerable()
               .Select(dataRow => new News
               {
                   Id = dataRow.Field<long>("id"),
                   Title = dataRow.Field<string>("Title"),
                   Details = dataRow.Field<string>("Details"),
                   DateAndTime = dataRow.Field<DateTime>("DateAndTime"),
                   Author = dataRow.Field<string>("Author"),
                   Observer = dataRow.Field<string>("Observer"),
                   Resource = dataRow.Field<string>("Resource"),
                   Region = dataRow.Field<string>("Region"),
                   Image = dataRow.Field<string>("Image"),
                   Video = dataRow.Field<string>("Video"),
                   Comment = dataRow.Field<string>("Comment"),
                   TotalRate = dataRow.Field<int>("TotalRate"),
                   Raters = dataRow.Field<int>("CountReadersWhoRate"),
                   IsHidden = dataRow.Field<bool>("IsHidden"),
                   ReaderRate = dataRow.Field<int>("ReaderRate"),
                   isFavourite = dataRow.Field<Boolean>("isFavourite"),
                   IsRated = dataRow.Field<Boolean>("IsRated"),
                   IsRead = dataRow.Field<Boolean>("IsRead"),
               }).ToList();

                return AllNews;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return new List<News>();
            }
            finally
            {
                con.Close();
                CheckReader(); // to add news to Reader_news table
            }
        }



        public static List<SocialMedia> GetSocialMedia(Nullable<DateTime> StartDate, Nullable<DateTime> EndDate,
            Nullable<Boolean> IsRead, string Region, string Observer, string KeyWord,
            Boolean IsFavourite)
        {
            try
            {
                CheckReader(); // to add news to Reader_news table
                List<SocialMedia> AllSocialMedia = new List<SocialMedia>();
                con.Open();
                SqlCommand cmd = new SqlCommand("GetSocialMedia", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ReaderId", ReaderId);

                // These attributes for search 
                if (StartDate == null)
                {
                    cmd.Parameters.AddWithValue("@StartDate", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@StartDate", StartDate);
                }

                if (EndDate == null)
                {
                    cmd.Parameters.AddWithValue("@EndDate", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@EndDate", EndDate);
                }

                if (IsRead == null)
                {
                    cmd.Parameters.AddWithValue("@IsRead", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@IsRead", IsRead);
                }

                if (Region == null)
                {
                    cmd.Parameters.AddWithValue("@Region", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Region", Region);
                }


                if (Observer == null)
                {
                    cmd.Parameters.AddWithValue("@Observer", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Observer", Observer);
                }

                if (KeyWord == null)
                {
                    cmd.Parameters.AddWithValue("@KeyWord", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@KeyWord", KeyWord);
                }


                if (IsFavourite == false)
                {
                    cmd.Parameters.AddWithValue("@IsFavourite", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@IsFavourite", IsFavourite);
                }
                AllNewsTable = new DataTable();
                new SqlDataAdapter(cmd).Fill(AllNewsTable);
                con.Close();

                AllSocialMedia = AllNewsTable.AsEnumerable()
               .Select(dataRow => new SocialMedia
               {
                   Id = dataRow.Field<long>("id"),
                   Title = dataRow.Field<string>("Title"),
                   DateAndTime = dataRow.Field<DateTime>("DateAndTime"),
                   Observer = dataRow.Field<string>("Observer"),
                   Region = dataRow.Field<string>("Region"),
                   Image = GetSocialMediaImages(dataRow.Field<string>("Image")),
                   Comment = dataRow.Field<string>("Comment"),
                   IsHidden = dataRow.Field<Boolean>("IsHidden"),
                   isFavourite = dataRow.Field<Boolean>("IsFavourite"),
                   IsRead = dataRow.Field<Boolean>("IsRead"),
               }).ToList();
                return AllSocialMedia;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return new List<SocialMedia>();
            }
            finally
            {
                con.Close();
            }
        }


        private static List<byte[]> GetSocialMediaImages(string SocialMediaImagesPath)
        {
            var formatter = new BinaryFormatter();
            List<byte[]> Images = new List<byte[]>();

            string PostFileName = SocialMediaImagesPath;

            if (File.Exists(PostFileName))
            { 
                using (var input = File.OpenRead(PostFileName))
                {
                    Images = (List<byte[]>)formatter.Deserialize(input);
                }
            }
            return Images;
        }



        public static void DeleteCurrnetNews(long NewsId)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("DeleteNews", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NewsId", NewsId);
            cmd.ExecuteNonQuery();
            con.Close();
        }


        public static void DeleteCurrnetPost(long PostId)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("DeletePost", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PostId", PostId);
            cmd.ExecuteNonQuery();
            con.Close();
        }


        public static ObservableCollection<string> GetAllObservors()
        {
            ObservableCollection<string> AllObserversList = new ObservableCollection<string>();
            SqlDataAdapter AllObservers = new SqlDataAdapter("GetAllObservers", con);
            DataTable AllObserversTable = new DataTable();
            AllObservers.Fill(AllObserversTable);
            foreach (DataRow Row in AllObserversTable.Rows)
            {
                AllObserversList.Add(Row[0].ToString());
            }

            return AllObserversList;
        }

        public static ObservableCollection<string> GetAllResources()
        {
            ObservableCollection<string> AllResourcesList = new ObservableCollection<string>();
            SqlDataAdapter AllResources = new SqlDataAdapter("GetAllResources", con);
            DataTable AllResourcesTable = new DataTable();
            AllResources.Fill(AllResourcesTable);
            foreach (DataRow Row in AllResourcesTable.Rows)
            {
                AllResourcesList.Add(Row[0].ToString());
            }

            return AllResourcesList;
        }



        public static ObservableCollection<string> GetAllAuthers()
        {

            ObservableCollection<string> AllAuthersList = new ObservableCollection<string>();
            SqlDataAdapter AllAuthers = new SqlDataAdapter("GetAllAuthers", con);
            DataTable AllAuthersTable = new DataTable();
            AllAuthers.Fill(AllAuthersTable);
            foreach (DataRow Row in AllAuthersTable.Rows)
            {
                AllAuthersList.Add(Row[0].ToString());
            }

            return AllAuthersList;
        }


        public static void InsertOrUpdateNews(News news)
        {
            try
            {
                con.Open();
                if (news.Id  == 0 ) // if 0 then it is new
                {
                    news.Id = GetNewsId(); // get a new Id 
                }

                string NewsImagePath = GetNewsImagePath(news.Image, news.Id);
                string NewsVideoPath = GetNewsVideoPath(news.Video, news.Id);
                SqlCommand cmd = new SqlCommand("InsertORUpdateNews", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", news.Id);
                cmd.Parameters.AddWithValue("@Title", news.Title);
                cmd.Parameters.AddWithValue("@Details", news.Details);
                cmd.Parameters.AddWithValue("@DateAndTime", news.DateAndTime);
                cmd.Parameters.AddWithValue("@Author", news.Author);
                cmd.Parameters.AddWithValue("@Resource", news.Resource);
                cmd.Parameters.AddWithValue("@Observer", news.Observer);
                cmd.Parameters.AddWithValue("@Region", news.Region);
                cmd.Parameters.AddWithValue("@IsHidden", news.IsHidden);
                cmd.Parameters.AddWithValue("@Comment", ((object)news.Comment)?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Image", NewsImagePath);
                cmd.Parameters.AddWithValue("@Video ", NewsVideoPath);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }
            CheckReader(); // to add news to Reader_news table
        }


        public static void InsertOrUpdateSocialMediaPost(SocialMedia Post)
        {
            try
            {
                con.Open();
                // To get Image Id first to use in image name
                if (Post.Id == 0) // if 0 then it is new
                {
                    Post.Id = GetSociaMediaId(); // get a new Id 
                }

                string ServerImagePath = GetNewImagesPath(Post, Post.Id);
                SqlCommand cmd = new SqlCommand("InsertOrUpdateSocialMediaPosts", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", Post.Id);
                cmd.Parameters.AddWithValue("@Title", Post.Title);
                cmd.Parameters.AddWithValue("@Region", Post.Region);
                cmd.Parameters.AddWithValue("@DateAndTime", Post.DateAndTime);
                cmd.Parameters.AddWithValue("@Observer", Post.Observer);
                cmd.Parameters.AddWithValue("@IsHidden", Post.IsHidden);
                cmd.Parameters.AddWithValue("@Comment", ((object)Post.Comment)?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Image", ServerImagePath);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }
          
            CheckReader(); // to add SocialMedia to Reader_SocialMedia table
        }


        private static string GetNewImagesPath(SocialMedia ImagesPath ,long PostId)
        {
            var formatter = new BinaryFormatter();
            string PostFileName = "\\10.1.20.15\\c\\attachments\\SocialMediaImages\\" + PostId.ToString() + ".dat";


            if (File.Exists(PostFileName))
            {
                File.Delete(PostFileName);
            }

            using (var output = File.Create(PostFileName))
            {
                formatter.Serialize(output, ImagesPath.Image);              
            }
          
            return PostFileName;
        }



        private static long GetNewsId()
        {
            // the news starts from 1 becuase 0 refers to new one
            SqlCommand cmd = new SqlCommand("select isNull(max(Id)+1,1) from News", con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return Convert.ToInt64(reader[0]);
            }

            throw new ArgumentException("No value returned from database");
        }


        private static long GetSociaMediaId()
        {
            // the news starts from 1 becuase 0 refers to new one
            SqlCommand cmd = new SqlCommand("select isNull(max(Id)+1,1) from SocialMedia", con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return Convert.ToInt64(reader[0]);
            }

            throw new ArgumentException("No value returned from database");
        }

        private static string GetNewsImagePath(string OldImagepath,long IdForName)
        {
            
            // if there is no OldImagepath
            if (string.IsNullOrEmpty(OldImagepath)) return "";

            // Naming Image according to image id
            string NewImagePath = "\\10.1.20.15\\c\\attachments\\images\\" + IdForName.ToString();

            // if image path is on server (this happens when update news and there is no change on image path)
            if (OldImagepath == NewImagePath)
            {
                return OldImagepath;
            }

            // Delete OldImage
            if (File.Exists(NewImagePath))
            {
                File.Delete(NewImagePath);
            }

            // Copy Image to server
            File.Copy(OldImagepath, NewImagePath);

            // return New Image Path
            return NewImagePath;
        }

        private static string GetNewsVideoPath(string VideoPath, long IdForName)
        {
            // if there is no VideoPath
            if (string.IsNullOrEmpty(VideoPath)) return "";

            // Naming Video according to video id
            string NewVideoPath = "\\10.1.20.15\\c\\attachments\\videos\\" + IdForName.ToString();

            // if video path is on server (this happens when update news and there is no change on video path)
            if (VideoPath == NewVideoPath)
            {
                return VideoPath;
            }

            // Delete OldVideo
            if (File.Exists(NewVideoPath))
            {
                File.Delete(NewVideoPath);
            }

            // Copy Video to server
            File.Copy(VideoPath, NewVideoPath);

            // return New Video Path
            return NewVideoPath;
        }

 

        public static void CheckReader()
        {
            int pReaderId = 0;
            SqlCommand cmd = new SqlCommand("CheckReader", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Email", "Ahmad@yahoo.com");
            cmd.Parameters.AddWithValue("@DisplayName", "أحمد محمد");
            cmd.Parameters.AddWithValue("@GroupPolicy", "الشعبة الفنية");
            con.Open();
            SqlDataReader sqlReaderId = cmd.ExecuteReader();
            
            if (sqlReaderId.Read()) 
            {
                pReaderId = sqlReaderId.GetInt32(0); 
            }
            // returns Reader ID
            ReaderId = pReaderId;
            con.Close();
        }

        public static void SetFavourite(long NewsId)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SetFavourite",con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@readerId",ReaderId);
            cmd.Parameters.AddWithValue("@newsId", NewsId);
            cmd.ExecuteNonQuery();
            con.Close();
        }


        public static void SetFavouritePost(long PostId)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SetFavouritePost", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@readerId", ReaderId);
            cmd.Parameters.AddWithValue("@PostId ", PostId);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static void SetNewsAsRead(long NewsId)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SetNewsAsRead", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@readerId", ReaderId);
            cmd.Parameters.AddWithValue("@newsId", NewsId);
            cmd.ExecuteNonQuery();
            con.Close();
        }


        public static void SetPostAsRead(long PostId)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SetPostAsRead", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ReaderId", ReaderId);
            cmd.Parameters.AddWithValue("@SocialMediaId", PostId);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static int[] SetReaderRate(long NewsId,int readerRate)
        {
            SqlCommand cmd = new SqlCommand("SetReaderRate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@readerId", ReaderId);
            cmd.Parameters.AddWithValue("@newsId", NewsId);
            cmd.Parameters.AddWithValue("@readerRate", readerRate);
            DataTable ReadersRatesTables = new DataTable();
            new SqlDataAdapter(cmd).Fill(ReadersRatesTables);
            int[] NewRateAndCount = {0,0};
            NewRateAndCount[0] = Convert.ToInt32(ReadersRatesTables.Rows[0][0]);
            NewRateAndCount[1] = Convert.ToInt32(ReadersRatesTables.Rows[0][1]);
            return NewRateAndCount;
        }
    }
}
