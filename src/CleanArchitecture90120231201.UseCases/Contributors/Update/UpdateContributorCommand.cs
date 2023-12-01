using Ardalis.Result;
using Ardalis.SharedKernel;

namespace CleanArchitecture90120231201.UseCases.Contributors.Update;

public record UpdateContributorCommand(int ContributorId, string NewName) : ICommand<Result<ContributorDTO>>;
