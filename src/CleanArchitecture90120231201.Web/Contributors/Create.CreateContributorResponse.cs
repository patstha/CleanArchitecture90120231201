namespace CleanArchitecture90120231201.Web.Endpoints.ContributorEndpoints;

public class CreateContributorResponse
{
  public CreateContributorResponse(int id, string name)
  {
    Id = id;
    Name = name;
  }
  public int Id { get; set; }
  public string Name { get; set; }
}
