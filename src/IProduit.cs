using System;

namespace courses
{
    public interface IProduit
    {
        Price Prix { get; }
        String Nom { get; }
        String Description { get; }
    }
}