<Query Kind="Program">
  <Connection>
    <ID>dcb22731-f352-430b-b235-d73ef2fe2311</ID>
    <Persist>true</Persist>
    <Driver>AstoriaAuto</Driver>
    <Server>http://msticketing-rrmsgalmbxd01/tickapi/TicketSearch.svc/</Server>
  </Connection>
</Query>

void Main()
{
	/*(from search in Searches
	                          where search.TicketStatus.Equals("Active", StringComparison.InvariantCultureIgnoreCase) &&
	                            (search.TemplateId.Equals(new Guid("3e4ef9d7-8f94-4e21-8b85-a810d693d582")) ||
	                             search.TemplateId.Equals(new Guid("3da2dac6-6d2d-43a6-a95d-6e98a615ed5c")))
	                          select new { search.id, search.TicketStatus }).FirstOrDefault()*/
	
	string a = "3e4ef9d7-8f94-4e21-8b85-a810d693d582";
	string b = "3da2dac6-6d2d-43a6-a95d-6e98a615ed5c";
	Guid c = new Guid(a);
	Guid d = new Guid(b);
	if(c.ToString()==c.ToString())
	Console.WriteLine("Hello");
	else
	Console.WriteLine("Bye");	
	
}

// Define other methods and classes here
