using CleanArchitecture90120231201.Web.ContributorEndpoints;

namespace CleanArchitecture90120231201.Web.Endpoints.ContributorEndpoints;

public class UpdateContributorResponse
{
  public UpdateContributorResponse(ContributorRecord contributor)
  {
    Contributor = contributor;
  }
  public ContributorRecord Contributor { get; set; }
}
