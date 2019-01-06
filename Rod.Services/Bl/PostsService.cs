using System.Collections.Generic;
using System.Linq;
using Rod.Repositories;
using Rod.Services.Vo;

namespace Rod.Services.Bl
{
    public class PostsService
    {
        public List<PostVo> GetLatestPosts()
        {
            var db = new DbEntities();
            var posts = db.Posts.Take(3).ToList();
            var result = posts.Select(x => new PostVo
            {
                Day = x.Day,
                Title = x.Title,
                Content = x.Content
            }).OrderByDescending(x=>x.Day).ToList();
            return result;
        }

        public List<PostVo> GetAll()
        {
            var db = new DbEntities();
            var posts = db.Posts.ToList();
            var result = posts.Select(x => new PostVo
            {
                Day = x.Day,
                Title = x.Title,
                Content = x.Content
            }).OrderByDescending(x=>x.Day).ToList();
            return result;
        }
    }
}
