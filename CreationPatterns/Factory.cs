using System;
using System.Collections.Generic;
using System.Text;

namespace CreationPatterns
{
    public enum BookType
    {
        Small,
        Large
    }

    public abstract class BookFactory
    {
        public abstract IBook Create(BookType type);
    }


    public class ConcreteBookFactory : BookFactory
    {
        public override IBook Create(BookType type)
        {
            switch (type)
            {
                case BookType.Small:
                    return new SmallBook();
                case BookType.Large:
                    return new LargeBook();
                default:
                    throw new Exception($"Unknown BookType, {type}");
            }
        }
    }


    public interface IBook
    {
        string Title { get; }
        int Pages { get; }
    }

    public class SmallBook : IBook
    {
        public string Title { get; }
        public int Pages { get; }

        public SmallBook()
        {
            Title = "This is a small book";
            Pages = 10;
        }
    }

    public class LargeBook : IBook
    {
        public string Title { get; }
        public int Pages { get; }

        public LargeBook()
        {
            Title = "This is a large book";
            Pages = 100;
        }
    }
}
