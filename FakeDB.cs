using System.Collections.Generic;
using gregslist.Models;

namespace gregslist
{
    static public class FakeDB
    {
    static public List<Car> Cars { get; set; } = new List<Car>() { new Car("Mystery", "Machine", 1974, 900000, "Filled With a Strange Snack...", "https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/f/cdabf980-8171-402b-9974-257fff37b0e6/ddym1vj-7716d714-4a40-4b6f-9d61-8bd384f03297.png/v1/fill/w_920,h_520,strp/cyber_mystery_machine_by_jjmunden_ddym1vj-fullview.png?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJzdWIiOiJ1cm46YXBwOjdlMGQxODg5ODIyNjQzNzNhNWYwZDQxNWVhMGQyNmUwIiwiaXNzIjoidXJuOmFwcDo3ZTBkMTg4OTgyMjY0MzczYTVmMGQ0MTVlYTBkMjZlMCIsIm9iaiI6W1t7ImhlaWdodCI6Ijw9NTIwIiwicGF0aCI6IlwvZlwvY2RhYmY5ODAtODE3MS00MDJiLTk5NzQtMjU3ZmZmMzdiMGU2XC9kZHltMXZqLTc3MTZkNzE0LTRhNDAtNGI2Zi05ZDYxLThiZDM4NGYwMzI5Ny5wbmciLCJ3aWR0aCI6Ijw9OTIwIn1dXSwiYXVkIjpbInVybjpzZXJ2aWNlOmltYWdlLm9wZXJhdGlvbnMiXX0.O6wY9aQ7edWvS5LYiNgKauE0BwBuUZUewujQ2akMRHQ") };

    static public List<House> Houses { get; set; } = new List<House>() { new House(5, 2, 2008, 1, 500000) };
  }
}