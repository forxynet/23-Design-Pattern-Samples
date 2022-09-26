using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite {
    public class Directory : FileSystemItem {
        private List<FileSystemItem> _fileSystemItems { get; set; } = new();
        private long _size;
        public Directory(string name, long size) : base(name) {
            _size = size;
        }        

        public void Add(FileSystemItem ItemToAdd) {
            _fileSystemItems.Add(ItemToAdd);
        }
        public void Remove(FileSystemItem ItemToRemove) {
            _fileSystemItems.Remove(ItemToRemove);
        }
        public override long GetSize() {
            var treeSize = _size;
            foreach (var fileSystemItem in _fileSystemItems) {
                treeSize += fileSystemItem.GetSize();
            }
            return treeSize;
        }
    }
}
