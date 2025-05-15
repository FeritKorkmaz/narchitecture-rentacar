using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Persistence.Paging;

public static class IQueryablePaginateExtensions
{
    public static async Task<Paginate<T>> ToPaginateAsync<T>(
        this IQueryable<T> source,
        int pageIndex,
        int pageSize,
        CancellationToken cancellationToken = default
        )
    {
        int count = await source.CountAsync(cancellationToken).ConfigureAwait(false); 
        List<T> items = await source.Skip(pageIndex * pageSize).Take(pageSize).ToListAsync(cancellationToken).ConfigureAwait(false);
        
        Paginate<T> list = new()
        {
            Index = pageIndex,
            Size = pageSize,
            Count = count,
            Items = items,
            Pages = (int)Math.Ceiling(count / (double)pageSize)
        };

        return list;
    }
    public static Paginate<T> ToPaginateAsync<T>(this IQueryable<T> source,int pageIndex,int pageSize)
    {
        int count = source.Count();
        List<T> items =  source.Skip(pageIndex * pageSize).Take(pageSize).ToList();

        Paginate<T> list = new()
        {
            Index = pageIndex,
            Size = pageSize,
            Count = count,
            Items = items,
            Pages = (int)Math.Ceiling(count / (double)pageSize)
        };

        return list;
    }
}
