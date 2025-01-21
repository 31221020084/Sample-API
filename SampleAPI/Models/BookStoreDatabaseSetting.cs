﻿namespace SampleAPI.Models
{
    public class BookStoreDatabaseSetting
    {
        public string ConnectionString { get; set; } = "mongodb://localhost:27017";
        public string DatabaseName { get; set; } = "BookStore";
        public string BooksCollectionName { get; set; } = "Books";
    }
}
