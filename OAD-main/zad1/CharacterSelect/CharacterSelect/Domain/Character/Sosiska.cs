using CharacterSelect.Application;
using CharacterSelect.Domain.Enum;

namespace CharacterSelect.Domain.Character;

public sealed class Sosiska : Entity.Character
{
    public Sosiska(string name) : base(name, CharacterClass.Sosiska)
    {
        Health = 80;
        Strength = 4;
        Intelligence = 16;
        Agility = 10;
        Power = 20;
        Lenght = 2;
    }
}