using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SoundWaveOfficial.Controllers
{
    public class tbl_PodcastController : Controller
    {
        // GET: tbl_Podcast
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-VAN8158V\\SERVER11;Initial Catalog=SoundWaveOfficial;Persist Security Info=True;User ID=sa;Password=Server11;Application Name=EntityFramework");
        List<tbl_Podcast> podcastList = new List<tbl_Podcast>();
        public ActionResult Index()
        {
            string qry = "select * from tbl_Podcast";
            SqlCommand cmd=new SqlCommand(qry, conn);
            conn.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            podcastList.Add(new tbl_Podcast
            {
                PodcastId = Convert.ToInt32(dr["PodcastId"]),
                PodcastName = dr["PodcastName"].ToString(),
                AuthorName = dr["AuthorName"].ToString(),
                Category = dr["Category"].ToString(),
                UserId = Convert.ToInt32(dr["UserId"]),
                UploadFile = dr["UploadFile"].ToString()
            });
            return View(podcastList);
        }
    }
}