﻿using System;
using System.Collections.Generic;
using System.Text;

namespace InheritaceC
{
    class ImagePost : Post
    {
        public string ImageURL { get; set; }
        public ImagePost() { }
        public ImagePost(string title, string sendByUsername, string imgURL, bool isPublic)
        {
            //The following properties and the GetNextID method are inherited from Post.
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;

            //Property ImageUrl is a member of ImagePost, but not of post
            this.ImageURL = imgURL;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} - by {3}", this.ID, this.Title, this.ImageURL, this.SendByUsername);
        }
    }
}
