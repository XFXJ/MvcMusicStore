using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Mvc;
using System.Web.Routing;

namespace MvcMusicStore.Models
{
    public class SampleData : DropCreateDatabaseIfModelChanges<MusicStoreEntities>
    {
        protected void Application_Start()
        {
            System.Data.Entity.Database.SetInitializer(
            new MvcMusicStore.Models.SampleData());
            AreaRegistration.RegisterAllAreas();
            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);
        }

        private void RegisterRoutes(object routes)
        {
            throw new NotImplementedException();
        }

        private void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            throw new NotImplementedException();
        }

        protected override void Seed(MusicStoreEntities context)
        {
            var genres = new List<Genre>
            {
                new Genre { Name = "流行" },
                new Genre { Name = "清晨" },
                new Genre { Name = "放松" },
                new Genre { Name = "兴奋" },
                new Genre { Name = "安静" },
                new Genre { Name = "午休" },
                new Genre { Name = "运动" },
                new Genre { Name = "另类/独立" },
                new Genre { Name = "经典" },
                new Genre { Name = " 90后" }
            };

            var artists = new List<Artist>
            {
                new Artist { Name = "G.E.M.邓紫棋" },
                new Artist { Name = "陈奕迅" },
                new Artist { Name = "Ada" },
                new Artist { Name = "李荣浩" },
                new Artist { Name = "许嵩" },
                new Artist { Name = "薛之谦" },
                new Artist { Name = "林俊杰" },
                new Artist { Name = "华晨宇" },
                new Artist { Name = "毛不易" },
                new Artist { Name = "王力宏" },
                new Artist { Name = "张杰" },
                new Artist { Name = "周杰伦" },
                new Artist { Name = "田馥甄" },
                new Artist { Name = "买辣椒也用券/冯沁苑" },
                new Artist { Name = "周笔畅" },
                new Artist { Name = "李宇春" },
                new Artist { Name = "阿肆" },
                new Artist { Name = "曾轶可" },
                new Artist { Name = "五月天" },
                new Artist { Name = "苏打绿" },
                new Artist { Name = "南征北战NZBZ" },
                new Artist { Name = "摩登兄弟" },
                new Artist { Name = "牛奶咖啡" },
                new Artist { Name = "Beyond" },
                new Artist { Name = "逃跑计划" },                    
            };

            new List<Album>
            {
                new Album { Title = "光年之外", Genre = genres.Single(g => g.Name == "流行"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Men At Work"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
                new Album { Title = "下个，路口，见", Genre = genres.Single(g => g.Name == "兴奋"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Aaron Copland & London Symphony Orchestra"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
                new Album { Title = "演员", Genre = genres.Single(g => g.Name == "清晨"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Aaron Goldberg"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
                new Album { Title = "倒数", Genre = genres.Single(g => g.Name == "流行"), Price = 8.99M, Artist = artists.Single(a => a.Name == "AC/DC"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
                new Album { Title = "我的秘密", Genre = genres.Single(g => g.Name == "流行"), Price = 8.99M, Artist = artists.Single(a => a.Name == "AC/DC"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
                new Album { Title = "喜欢你", Genre = genres.Single(g => g.Name == "流行"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Accept"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
                new Album { Title = "来自天堂的魔鬼", Genre = genres.Single(g => g.Name == "流行"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Accept"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
                new Album { Title = "十年", Genre = genres.Single(g => g.Name == "兴奋"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Adrian Leaper & Doreen de Feis"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
                new Album { Title = "意外", Genre = genres.Single(g => g.Name == "清晨"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Aisha Duo"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
                new Album { Title = "醉赤壁", Genre = genres.Single(g => g.Name == "经典"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Amy Winehouse"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
                new Album { Title = "烟火里的尘埃", Genre = genres.Single(g => g.Name == "安静"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Anita Ward"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
                new Album { Title = "国王与乞丐", Genre = genres.Single(g => g.Name == "安静"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Antônio Carlos Jobim"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
                new Album { Title = "绅士", Genre = genres.Single(g => g.Name == "清晨"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Antônio Carlos Jobim"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
                new Album { Title = "只要平凡", Genre = genres.Single(g => g.Name == "放松"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Apocalyptica"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
                new Album { Title = "1987我不知会遇见你", Genre = genres.Single(g => g.Name == "兴奋"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Barry Wordsworth & BBC Concert Orchestra"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
                new Album { Title = "对不起，只是忽然很想你", Genre = genres.Single(g => g.Name == "兴奋"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Berliner Philharmoniker & Hans Rosbaud"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
                new Album { Title = "再不疯狂我们就老了", Genre = genres.Single(g => g.Name == "兴奋"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Berliner Philharmoniker & Herbert Von Karajan"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
                new Album { Title = "暧昧", Genre = genres.Single(g => g.Name == "清晨"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Billy Cobham"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
                new Album { Title = "我们都一样", Genre = genres.Single(g => g.Name == "放松"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Black Label Society"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
                new Album { Title = "这,就是爱", Genre = genres.Single(g => g.Name == "放松"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Black Label Society"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
                new Album { Title = "最美的太阳", Genre = genres.Single(g => g.Name == "放松"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Black Sabbath"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
                new Album { Title = "看月亮爬上来", Genre = genres.Single(g => g.Name == "放松"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Black Sabbath"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
                new Album { Title = "逆战", Genre = genres.Single(g => g.Name == "放松"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Bruce Dickinson"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
                new Album { Title = "我管你", Genre = genres.Single(g => g.Name == "运动"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Caetano Veloso"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
                new Album { Title = "齐天大圣", Genre = genres.Single(g => g.Name == "运动"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Caetano Veloso"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
                new Album { Title = "告白气球", Genre = genres.Single(g => g.Name == "兴奋"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Cake"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
                new Album { Title = "给我一首歌的时间", Genre = genres.Single(g => g.Name == "兴奋"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Calexico"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
                new Album { Title = "异类", Genre = genres.Single(g => g.Name == "运动"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Cássia Eller"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
                new Album { Title = "Le Freak", Genre = genres.Single(g => g.Name == "Disco"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Chic"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
                new Album { Title = "南屏晚钟", Genre = genres.Single(g => g.Name == "运动"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Chico Buarque"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
                new Album { Title = "我的滑板鞋2016", Genre = genres.Single(g => g.Name == "运动"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Chico Science & Nação Zumbi"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
                new Album { Title = "微光", Genre = genres.Single(g => g.Name == "运动"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Chico Science & Nação Zumbi"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
                new Album { Title = "说好的幸福呢", Genre = genres.Single(g => g.Name == "兴奋"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Chris Cornell"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
                new Album { Title = "第一夫人", Genre = genres.Single(g => g.Name == "放松"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Guns N' Roses"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
                new Album { Title = "秋天的童话", Genre = genres.Single(g => g.Name == "放松"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Iron Maiden"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
                new Album { Title = "老街", Genre = genres.Single(g => g.Name == "另类/独立"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Lenny Kravitz"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
                new Album { Title = "戒烟", Genre = genres.Single(g => g.Name == "午休"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Stevie Ray Vaughan & Double Trouble"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
                new Album { Title = "不能说的秘密", Genre = genres.Single(g => g.Name == "兴奋"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Temple of the Dog"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
            }.ForEach(a => context.Albums.Add(a));
        }
    }
}