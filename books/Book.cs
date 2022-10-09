﻿using System;
using System.Collections.Generic;

namespace books
{
    public partial class Book
    {
        public Book()
        {
            Pictures = new HashSet<Picture>();
            SCards = new HashSet<SCard>();
            TCards = new HashSet<TCard>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Pages { get; set; }
        public int YearPress { get; set; }
        public int IdThemes { get; set; }
        public int IdCategory { get; set; }
        public int IdAuthor { get; set; }
        public int IdPress { get; set; }
        public string? Comment { get; set; }
        public int Quantity { get; set; }

        public virtual Author IdAuthorNavigation { get; set; } = null!;
        public virtual Category IdCategoryNavigation { get; set; } = null!;
        public virtual Press IdPressNavigation { get; set; } = null!;
        public virtual Theme IdThemesNavigation { get; set; } = null!;
        public virtual ICollection<Picture> Pictures { get; set; }
        public virtual ICollection<SCard> SCards { get; set; }
        public virtual ICollection<TCard> TCards { get; set; }
    }
}