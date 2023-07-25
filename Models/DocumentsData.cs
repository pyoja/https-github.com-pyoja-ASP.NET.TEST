// DocumentsData.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication6.Models
{
    public class DocumentsData
    {
        public List<Document> DummyDocuments { get; set; }

        public DocumentsData()
        {
            DummyDocuments = new List<Document>
            {
                new Document
                {
                    Document_Number = 1,
                    Title = "제목 1",
                    Writer = "작성자 1"
                },
                new Document
                {
                    Document_Number = 2,
                    Title = "제목 2",
                    Writer = "작성자 2"
                },
                new Document
                {
                    Document_Number = 3,
                    Title = "제목 3",
                    Writer = "작성자 3"
                },
                new Document
                {
                    Document_Number = 4,
                    Title = "제목 4",
                    Writer = "작성자 4"
                },
                new Document
                {
                    Document_Number = 5,
                    Title = "제목 5",
                    Writer = "작성자 5"
                },
                new Document
                {
                    Document_Number = 6,
                    Title = "제목 6",
                    Writer = "작성자 6"
                },
                new Document
                {
                    Document_Number = 7,
                    Title = "제목 7",
                    Writer = "작성자 7"
                },
                new Document
                {
                    Document_Number = 8,
                    Title = "제목 8",
                    Writer = "작성자 8"
                },
                new Document
                {
                    Document_Number = 9,
                    Title = "제목 9",
                    Writer = "작성자 9"
                },
                new Document
                {
                    Document_Number = 10,
                    Title = "제목 10",
                    Writer = "작성자 10"
                },
            };
        }
    }
}
