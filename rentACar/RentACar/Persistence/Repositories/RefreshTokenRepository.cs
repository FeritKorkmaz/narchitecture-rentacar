﻿using Application.Services.Repositories;
using Core.Persistence.Repositories;
using Core.Security.Entities;
using Persistence.Contexts;
using System.Data.Entity;

namespace Persistence.Repositories;

public class RefreshTokenRepository : EfRepositoryBase<RefreshToken, int, BaseDbContext>, IRefreshTokenRepository
{
    public RefreshTokenRepository(BaseDbContext context)
        : base(context) { }

    public async Task<List<RefreshToken>> GetOldRefreshToken(int userID, int refreshTokenTTL)
    {
        List<RefreshToken> tokens = await Query()
            .AsNoTracking()
            .Where(
                r => 
                r.UserId == userID 
                && r.Revoked == null 
                && r.Expires >= DateTime.UtcNow
                && r.CreatedDate.AddDays(refreshTokenTTL) <= DateTime.UtcNow
            )
            .ToListAsync();
        return tokens;
    }
}
