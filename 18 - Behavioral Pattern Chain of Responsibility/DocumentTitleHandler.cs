using System.ComponentModel.DataAnnotations;

namespace Pattern_Chain_of_Responsibility {
    /// <summary>
    /// ConcreteHandler
    /// </summary>
    public class DocumentTitleHandler : IHandler<Document> {

        private IHandler<Document>? _successor;
        public void Handle(Document document) {
            // validation doesn't chanck out
            if (document.Title == String.Empty) {
                throw new ValidationException(
                    new ValidationResult(
                        "Title must be filled out",
                        new List<string>() { "Title" }), null, null);
            }

            // go to the next handler
            _successor?.Handle(document);
        }

        public IHandler<Document> SetSuccessor(IHandler<Document> successor) {
            _successor = successor;
            return _successor;
        }
    }
}
