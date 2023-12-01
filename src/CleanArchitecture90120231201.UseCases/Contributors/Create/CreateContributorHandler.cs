using Ardalis.Result;
using Ardalis.SharedKernel;
using CleanArchitecture90120231201.Core.ContributorAggregate;

namespace CleanArchitecture90120231201.UseCases.Contributors.Create;

public class CreateContributorHandler(IRepository<Contributor> _repository)
  : ICommandHandler<CreateContributorCommand, Result<int>>
{
  public async Task<Result<int>> Handle(CreateContributorCommand request,
    CancellationToken cancellationToken)
  {
    var newContributor = new Contributor(request.Name);
    var createdItem = await _repository.AddAsync(newContributor, cancellationToken);

    return createdItem.Id;
  }
}
