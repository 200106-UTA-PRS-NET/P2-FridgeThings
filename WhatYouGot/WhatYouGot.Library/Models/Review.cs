﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WhatYouGot.Library.Models
{
    public class Review
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int RecipeId { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
    }
}
