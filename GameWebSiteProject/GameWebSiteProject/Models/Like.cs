﻿using System;

namespace GameWebSiteProject.Models
{
    public class Like
    {
        public Guid Id { get; set; }
        public Guid User_Id { get; set; }
        public Guid Work_Id { get; set; }
        public short IsLiked { get; set; }
        public DateTime DateSent { get; set; }
        public int NumberOfChange { get; set; }
    }
}
