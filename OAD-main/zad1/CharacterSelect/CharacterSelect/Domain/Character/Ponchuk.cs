using CharacterSelect.Application;
using CharacterSelect.Domain.Enum;

namespace CharacterSelect.Domain.Character;

public sealed class Ponchuk : Entity.Character
{
    public Ponchuk(string name) : base(name, CharacterClass.Ponchuk)
    {
        Health = 80;
        Strength = 4;
        Intelligence = 16;
        Agility = 10;
        Power = 20;
        Lenght = 2;
    }
}