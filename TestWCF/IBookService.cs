using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace TestWCF
{
    [ServiceContract]
    interface IBookService
    {

        [OperationContract]
        List<Book> GetAllBooks();//Get all books; returns list of books

        [OperationContract]
        Book GetBookByID(string BookID);//Gets a(single) book by ID

        [OperationContract]
        Book Filter(string Author, string Genre, string Title); //Returns list of 
        //books by specified filter
    
    }
    
}
