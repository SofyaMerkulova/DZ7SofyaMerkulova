using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumkov8.Class
{
    internal class Song
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public Song Prev { get; set; }

        public void SetName(string name)
        {
            this.Name = name;
        }
        public void SetAuthor(string author)
        {
            this.Author = author;
        }
        public void SetPrev(Song prev)
        {
            this.Prev = prev;
        }
        public string Title()
        {
            return $"Название: {Name}, Исполнитель: {Author}";
        }
        public override bool Equals(object d)
        {
            if (d is Song otherSong)
            {
                return this.Name == otherSong.Name && this.Author == otherSong.Author;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return Name.GetHashCode() + Author.GetHashCode();
        }
    }
}


    

