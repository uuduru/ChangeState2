
using state_change_exercice._2._Application;
using state_change_exercice.Domain;
using state_change_exercice.Infrastructure;

var states_repo = new Objects_Repository();
var states_service = new ChangeStateService(states_repo);

while (true)
{
    Console.WriteLine("create, view_id, view, add_id");   
    var action = Console.ReadLine();

    try 
    {
        if (action == "create")
        {
            states_service.CreateState();
        }

        if (action == "add_id")
        {
            Console.WriteLine("State Id\n");
            var id = Console.ReadLine();
            var Guid_id = Guid.Parse(id);
            states_service.AddState(Guid_id);
        }

        if (action == "view")
        {
            states_service.ViewStates();
        }

    }
    catch (Exception e)
    {

    }

}