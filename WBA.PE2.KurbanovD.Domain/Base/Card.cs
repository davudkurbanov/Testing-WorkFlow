using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WBA.PE2.KurbanovD.Domain.Base
{
    public class Card
    {
        public Guid Id { get; set; }
        public string Img { get; set; }
        public string Name { get; set; }
        //public Card(string name)
        //{
        //    Name = name;
        //    Img = string.Concat(name.Where(p => !char.IsWhiteSpace(p))) + ".jpg";
        //}
    }
}
