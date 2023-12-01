using Ardalis.Result;
using Ardalis.SharedKernel;

namespace CleanArchitecture90120231201.UseCases.Contributors.Get;

public record GetContributorQuery(int ContributorId) : IQuery<Result<ContributorDTO>>;
