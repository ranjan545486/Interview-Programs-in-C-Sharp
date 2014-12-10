<Query Kind="Program">
  <Connection>
    <ID>d6931b96-56e9-4f96-8ae8-6ee262182462</ID>
    <Persist>true</Persist>
    <Driver>AstoriaAuto</Driver>
    <Server>http://dbsautorule/alarmprocessorservice.svc</Server>
  </Connection>
</Query>

void Main()
{
    
	var c = (from r in RuleDefinitions
			where r.RuleId == 4740
			select r).ToList();
    c.Select (x =>x.Revision);
	if(c.Count()>0 )
	{
	  Console.WriteLine(c);
	}
	
	
	}

// Define other methods and classes here
