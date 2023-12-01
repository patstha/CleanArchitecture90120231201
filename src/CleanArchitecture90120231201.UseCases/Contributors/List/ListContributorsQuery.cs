using Ardalis.Result;
using Ardalis.SharedKernel;

namespace CleanArchitecture90120231201.UseCases.Contributors.List;

public record ListContributorsQuery(int? Skip, int? Take) : IQuery<Result<IEnumerable<ContributorDTO>>>;
