using Ardalis.Result;
using Ardalis.SharedKernel;

namespace CleanArchitecture90120231201.UseCases.Contributors.Delete;

public record DeleteContributorCommand(int ContributorId) : ICommand<Result>;
