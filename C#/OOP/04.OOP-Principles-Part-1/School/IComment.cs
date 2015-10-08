using System;

namespace School
{
    public interface IComment
    {
        string Comment { get; }

        void MakeComment(string text);
    }
}
