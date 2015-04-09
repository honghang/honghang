using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace PhotoAlbum
{
    class Photo
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
        private string photographer = "";
        public string Photographer
        {
            get { return photographer; }
            set
            {
                if (photographer != null)
                { photographer = value;
                Haschanged = true;
                }
            }
        }
        private string notes = "";
        public string Notes
        { get{return notes;}
        set{if( notes!=null)
        { notes = value;
        Haschanged = true;
        }
        }
    }

    
    
    
    
    
    }
}
