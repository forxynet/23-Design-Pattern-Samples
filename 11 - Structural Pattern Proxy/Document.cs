using Org.BouncyCastle.Asn1.Mozilla;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy {
    public class Document : IDocument {
        public string? Title { get; private set; }
        public string? Content { get; private set; }
        public int AuthorId { get; private set; }   
        public DateTimeOffset LastAccess { get; private set; }
        private string _fileName;

        public Document(string fileName) {
            _fileName = fileName;
            LoadDocument(fileName);
        }

        private void LoadDocument(object filename) {
            Console.WriteLine("Executing expensive action: loading a file from disk");
            // fake loading..
            Thread.Sleep(1000);

            Title = "An expensive document";
            Content = "Lots and lots of content";
            AuthorId = 1;
            LastAccess = DateTimeOffset.UtcNow;
        }
        public void DisplayDocument() {
            Console.WriteLine($"Title: {Title}, Content: {Content}");
        }
    }
}
