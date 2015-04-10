using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel; // ho tro lop Collection.

namespace PhotoAlbum
{
    class PhotoAlbum:Collection<Photo>,IDisposable
    {
        private bool hasChanged = false;

        public bool HasChanged
        {
            get
            {
                if (hasChanged) return true;
                foreach (Photo p in this) //duyet trong Photo theo bien p kieu Photo
                    if (p.Haschanged) return true;
                return false;
            }
            set
            {
                hasChanged = value;
                if (value == false) foreach (Photo p in this) p.Haschanged = false;
            }
        }

        public void Dispose() 
        {
            foreach (Photo p in this)
                p.Dispose();
        }

        public Photo Add(string fileName)
        {
            Photo p = new Photo(fileName);
            base.Add(p);
            return p;
        }

        protected override void ClearItems()//ham xoa het tat ca cac Items.
        {
            if (Count > 0)
            {
                Dispose();
                base.ClearItems();
                HasChanged = true;//cap nhat lai giao dien thong qua thuoc tinh HasChanged.
            }
        }

        protected override void InsertItem(int index, Photo item)
        {
            base.InsertItem(index, item);
            HasChanged = true;
        }

        protected override void RemoveItem(int index)
        {
            Items[index].Dispose();
            base.RemoveItem(index);
            HasChanged = true;
        }

        protected override void SetItem(int index, Photo item)
        {
            base.SetItem(index, item);
            HasChanged = true;
        }
        
    }
}
