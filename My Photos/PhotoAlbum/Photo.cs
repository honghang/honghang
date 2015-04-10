using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace PhotoAlbum
{
    class Photo:IDisposable//interface: 1 dang giong lop nhung k co cai dat. 
    {
        private string fileName;
        public string FileName
        {
            get { return this.fileName; }
        }

        private Bitmap bitmap;
        public Bitmap Image
        { 
            get
            {
                if (bitmap == null) 
                    bitmap = new Bitmap(fileName);
                return bitmap;
            }
        }

        private string caption = "";
        public string Caption
        {
            get
            { return caption; }
            set
            {
                if (caption != value)
                { caption = value;
                Haschanged = true;
                }
            }
        }

        private bool haschanged=true;
        public bool Haschanged
        {
            get { return haschanged; }
            set { haschanged = value; }
        }

        public Photo(string fileName)
        {
            this.fileName = fileName;
            bitmap = null;
            caption = System.IO.Path.GetFileNameWithoutExtension(fileName); //lay ra ten file ko co phan mo rong tu duong dan thu muc
        }
        //private string photographer = "";
        //public string Photographer
        //{
        //    get { return photographer; }
        //    set
        //    {
        //        if (photographer != null)
        //        { photographer = value;
        //        Haschanged = true;
        //        }
        //    }
        //}
        //private string notes = "";
        //public string Notes
        //{
        //    get { return notes; }
        //    set
        //    {
        //        if (notes != null)
        //        {
        //            notes = value;
        //            Haschanged = true;
        //        }
        //    }
        //}

        public void ReleaseImage()
        { 
        }
        public void Dispose()//
        {
            if (bitmap != null)
            {
                bitmap.Dispose();// dung de xoa bien bitmap ngay tai thoi diem bitmap!=null la dung'. nghechua.
                bitmap = null;
            }
        }

        public override string ToString()
        {
            return FileName;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return GetHashCode() == obj.GetHashCode();
        }    
    
    }
}
