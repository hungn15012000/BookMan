using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMan.ConsoleApp.Models
{
    /// <summary>
    /// This class describe the book's properties
    /// </summary>
    public class Books
    {
        private int _id = 1;
        /// <summary>
        /// ID of each book
        /// </summary>
        public int Id
        {
            get { return _id; }
            set { if (value >= 1) _id = value; else throw new ArgumentException("ID must not smaller than 1"); }
        }
        private string _author = "Unkown Author";
        /// <summary>
        /// Author of the book, not receiving the blank or null character
        /// </summary>
        public string Author
        {
            get { return _author; }
            set { _author = (!string.IsNullOrEmpty(value)) ? value : throw new ArgumentException("Author must not be blank"); }
        }
        private string _title = "A new book";
        /// <summary>
        /// Title of the book
        /// </summary>
        public string Title
        {
            get { return _title; }
            set { _title = (!string.IsNullOrEmpty(value)) ? value : throw new ArgumentException("Title must not be blank"); }
        }
        private string _publisher = "Unknown Publisher";
        /// <summary>
        /// Publisher which published the book, does not contain blank or null character
        /// </summary>
        public string Publisher
        {
            get { return _publisher; }
            set { _publisher = (!string.IsNullOrEmpty(value)) ? value : throw new ArgumentException("Publisher must not be blank"); }
        }
        private int _year = 2000;
        /// <summary>
        /// Year that published the book
        /// </summary>
        public int Year
        {
            get { return _year; }
            set { _year = (value >= 1950) ? value : throw new ArgumentException("Book is too old"); }
        }
        private int _edition = 1;
        /// <summary>
        /// Edition of the book
        /// </summary>
        public int Edition
        {
            get { return _edition; }
            set { _edition = (value >= 1) ? value : throw new ArgumentException("Edition must greater than 1"); }
        }
        public string Isbn { get; set; } = "";
        /// <summary>
        /// International Standard Book Number
        /// </summary>
        public string Tags { get; set; } = "";
        /// <summary>
        /// Tag or short abstract of the book
        /// </summary>
        private string _description;
        /// <summary>
        /// Description of the book
        /// </summary>
        public string Description { get; set; } = "A new book";
        private int _rating = 1;
        /// <summary>
        /// Rating of the book (1 to 5 stars)
        /// </summary>
        public int Rating
        {
            get { return _rating; }
            set { _rating = (value >= 1 && value <= 5) ? value : throw new ArgumentException("Only grade from 1 to 5"); }
        }
        public bool Reading { get; set; }
        /// <summary>
        /// A bookmark shows that you are reading this one
        /// </summary>
        private string _file;
        /// <summary>
        ///  file of the book (including the file path)
        /// </summary>
        public string File
        {
            get { return _file; }
            set { _file = (System.IO.File.Exists(value)) ? value : throw new Exception(); }
        }
        /// <summary>
        /// Name of the file
        /// </summary>
        public string FileName
        {
            get { return System.IO.Path.GetFileName(_file); }
        }
    }
}
