using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

public class BooksGBLL
{
    private Context context;

    public BooksGBLL(Context context)
    {
        this.context = context;
    }

    public bool Exist(string Tittle){
        return context.book.Any(TiTTle => TiTTle.tittle== Tittle);
    }

    public bool Insert(BooksG bookS){
        context.book.Add(bookS);
        return context.SaveChanges() >0;
    }
    public bool Modificate(BooksG bookS){
        context.Entry(bookS).State = EntityState.Modified;
        return context.SaveChanges() >0;
    }

    public bool Save(BooksG bookS){
        if(!Exist(bookS.tittle))
            return this.Insert(bookS);
        else
            return this.Modificate(bookS);
    }

    public bool Delete(BooksG bookS){
        context.Entry(bookS).State = EntityState.Deleted;
        return context.SaveChanges() >0;
    }
    public BooksG? Search(int bookId){
        return context.book.Where(BookId => BookId.Idbook == bookId).AsNoTracking().SingleOrDefault();
    }

    public List<BooksG> GetList(Expression<Func<BooksG,bool>> criterius){
        return context.book.AsNoTracking().Where(criterius).ToList();
    }
}