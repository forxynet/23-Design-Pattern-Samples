using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Chain_of_Responsibility {
    public class DocumentApprovedBylitigationHandler : IHandler<Document> {
        private IHandler<Document>? _successor;
        public void Handle(Document document) {
            if (!document.ApprovedByLitigation) {
                // Validation doesn't check out
                throw new ValidationException(
                    new ValidationResult(
                        "Document must be approved by litigation",
                        new List<string>() { "ApprovedByLitigation" }), null, null);
            }

            // go toothe next handler
            _successor?.Handle(document);
        }

        public IHandler<Document> SetSuccessor(IHandler<Document> successor) {
            _successor = successor;
            return this;
        }
    }
}
