using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Para3
{
    public class Article
    {
        private string _title;
        private string _text;
        private string _author;
        private DateTime _creationDate;
        private Comment[] _comments;
        private static string _ownerName;

        //мод_доступа Назв_класса (параметры) {}
        static Article()
        {
            _ownerName = "Самиздат";
        }
        public Article()
        {
            _creationDate = DateTime.Now;
        }
        
        //мод_доступа возвр_тип Имя (параметры){return знач_возвр_типа; }

        public string GetTitle()
        {
            return _title;
        }
        public void SetTitle(string title)
        {
            _title=title;
        }


        public string GetText()
        {
            return _text;
        }
        public void SetText(string text)
        {
            _text = text;
        }


        public string GetAuthor()
        {
            return _author;
        }
        public void SetAuthor(string author)
        {
            _author = author;
        }
        public void SetAuthor(string firstname, string lastname)
        {
            _author = firstname+" "+lastname;
        }


        public DateTime GetCreationDate()
        {
            return _creationDate;
        }
        public void SetCreationDate(DateTime creationDate)
        {
            _creationDate = creationDate;
        }


        public Comment[] GetComments()
        {
            return _comments;
        }
        public void SetComments(Comment[] comments)
        {
           _comments = comments;
        }
    }
}
