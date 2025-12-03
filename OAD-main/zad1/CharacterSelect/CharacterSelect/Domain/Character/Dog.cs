using CharacterSelect.Application;
using CharacterSelect.Domain.Enum;

namespace CharacterSelect.Domain.Character;

public sealed class Dog : Entity.Character
{
    public Dog(string name) : base(name, CharacterClass.Dog)
    {
        Health = 80;
        Strength = 4;
        Intelligence = 16;
        Agility = 10;
        Power = 20;
        Lenght = 2;
    }
}