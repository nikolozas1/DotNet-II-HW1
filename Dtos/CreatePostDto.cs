﻿using Reddit.Models;

namespace Reddit.Dtos
{
    public class CreatePostDto
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public int AuthorId { get; set; }
        public Community Community { get; set; }
    }
}
