﻿using System.Collections.Generic;
using System.Linq;
using bubbl.Data;
using bubbl.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace bubbl.Service
{
    public class ContentService : IContentService
    {
        private bubblDbContext context;

        public ContentService(bubblDbContext context)
        {
            this.context = context;
        }

        public void Add(Content content)
        {
            this.context.Add(content);
            this.context.SaveChanges();
        }

        public IEnumerable<Content> GetAll()
        {
            return this.context.Contents;
        }

        public Content GetById(int id)
        {
            return GetAll().FirstOrDefault(content => content.Id == id);
        }

        public string GetDescription(int id)
        {
            return GetById(id).Description;
        }

        public string GetLocation(int id)
        {
            return GetById(id).Location;
        }

        public string GetType(int id)
        {
            return GetById(id).Type;
        }
    }
}
