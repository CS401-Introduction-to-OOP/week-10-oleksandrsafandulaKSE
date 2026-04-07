using week_10_oleksandrsafandulaKSE;

var character1 = new Character("name1", "role1", 1, 100, 1, "Active");
var character2 = new Character("name2", "role2", 2, 100, 2, "Not Active");
var character3 = new Character("name3", "role3", 3, 100, 3, "Active");

var party = new Party();
party.AddCharacter(character1);
party.AddCharacter(character2);
party.AddCharacter(character3);

var event1 = new Event(1, "desc1", "type1", "change1");
var event2 = new Event(2, "desc2", "type2", "change2");
var event3 = new Event(3, "desc3", "type3", "change3");

var eventLog = new EventLog();
eventLog.AddEvent(event1);
eventLog.AddEvent(event2);
eventLog.AddEvent(event3);

bool isOn = true;

while (isOn)
{
    Console.WriteLine("Enter:\n1 - for list all characters" +
                      "\n2 - for list all events" +
                      "\n3 - for list all in chronological order events" +
                      "\n4 - for list all active persons");
    
    var choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
        {
            foreach (var character in party.GetAllCharacters())
            {
                Console.WriteLine(character);
            }
        } break;

        case 2:
        {
            foreach (var evenT in eventLog.GetAllEvents())
            {
                Console.WriteLine(evenT);
            }
        } break;
        
        case 3:
        {
            foreach (var evenT in eventLog.GetInChrono())
            {
                Console.WriteLine(evenT);
            }
        } break;

        case 4:
        {
            foreach (var character in party.GetOnlyActive())
            {
                Console.WriteLine(character);
            }
        }
            break;
    }
}

