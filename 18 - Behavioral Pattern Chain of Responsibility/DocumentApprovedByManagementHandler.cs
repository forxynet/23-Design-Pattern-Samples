using System.ComponentModel.DataAnnotations;

namespace Pattern_Chain_of_Responsibility {
    public class DocumentApprovedByManagementHandler : IHandler<Document> {
        private IHandler<Document>? _successor;
        public void Handle(Document document) {
            if (!document.ApprovedByManagement) {
                // Validation doesn't check out
                throw new ValidationException(
                    new ValidationResult(
                        "Document must be approved by management",
                        new List<string>() { "ApprovedByManagement" }), null, null);
            }

            // go to the next handler
            _successor?.Handle(document);
        }

        public IHandler<Document> SetSuccessor(IHandler<Document> successor) {
            _successor = successor; 
            return this;
        }
    }
}
