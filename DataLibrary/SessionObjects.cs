using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLibrary
{
    public class SessionData
    {
        public TitlePage TitlePage { get; set; }
        public ChapterOne ChapterOne { get; set; }
        public ChapterThree ChapterThree { get; set; }
        public ChapterFour ChapterFour { get; set; }
        public ChapterSixPartTwoThree ChapterSixPartTwoThree { get; set; }
        public ChapterSixPartFourFive ChapterSixPartFourFive { get; set; }
        public ChapterSeven ChapterSeven { get; set; }
        public ChapterEight ChapterEight { get; set; }
        public ChapterNine ChapterNine { get; set; }

        public SessionData()
        {
            TitlePage = new TitlePage();
            ChapterOne = new ChapterOne();
            ChapterThree = new ChapterThree();
            ChapterFour = new ChapterFour();
            ChapterSixPartTwoThree = new ChapterSixPartTwoThree();
            ChapterSixPartFourFive = new ChapterSixPartFourFive();
            ChapterSeven = new ChapterSeven();
            ChapterEight = new ChapterEight();
            ChapterNine = new ChapterNine();
        }

        public void SetProperty (Type propertyType, object value)
        {
            var property = this.GetType().GetProperty(propertyType.Name);
            property.SetValue(this, value, null);
        }
    }
}
