using CleanArchitecture90120231201.Web.ContributorEndpoints;

namespace CleanArchitecture90120231201.Web.Endpoints.ContributorEndpoints;

public class ContributorListResponse
{
  public List<ContributorRecord> Contributors { get; set; } = new();
}
