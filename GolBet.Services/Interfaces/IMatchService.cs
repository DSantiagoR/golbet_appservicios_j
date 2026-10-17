using GolBet.Entities.Enums;
using GolBet.Services.DTOs;

namespace GolBet.Services.Interfaces;

public interface IMatchService
{
    /// <summary>Match board: active matches ordered by date, optionally filtered by status and team search.</summary>
    Task<IEnumerable<MatchDto>> GetBoardAsync(MatchStatus? status = null, string? search = null);

    /// <summary>Detail of a single match, or null if it doesn't exist.</summary>
    Task<MatchDetailDto?> GetDetailAsync(int id);

    Task<MatchFormDto?> GetForEditAsync(int id);
    Task CreateAsync(MatchFormDto dto);
    Task UpdateAsync(MatchFormDto dto);
    Task DeactivateAsync(int id);
}