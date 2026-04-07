using System.Collections;

namespace week_10_oleksandrsafandulaKSE;

public class Party : IEnumerable<Character>
{
    private List<Character> _characters;

    public Party()
    {
        _characters = new List<Character>();
    }

    public void AddCharacter(Character character)
    {
        _characters.Add(character);
    }
    
    public IEnumerable<Character> GetAllCharacters()
    {
        foreach (var character in _characters)
        {
            yield return character;
        }
    }
    
    public IEnumerable<Character> GetOnlyActive()
    {
        foreach (var character in _characters.Where(x => x.Condition == "Active"))
        {
            yield return character;
        }
    }
    
    public IEnumerator<Character> GetEnumerator()
    {
        foreach (var character in _characters)
        {
            yield return character;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
    
}