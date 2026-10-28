using System.Data.SqlTypes;
using System.Diagnostics;
using KnockKnockArena.Shared.Protocol.Udp;

/* byte owned = WeaponBits.StartingWeapons;

Show("Spawing(Punch + Glock)", owned);

owned = WeaponBits.AddWeapon(owned, WeaponId.Ak47);
Show("picks up an AK47", owned);
owned = WeaponBits.AddWeapon(owned, WeaponId.RocketLauncher);
Show("picks up a rocket launcher", owned);
owned = WeaponBits.AddWeapon(owned, WeaponId.Ak47);
Show("picks up a second AK47", owned);
owned = WeaponBits.RemoveWeapon(owned, WeaponId.RocketLauncher);
Show("RemoveWeapon(RocketLauncher)", owned);
owned = WeaponBits.StartingWeapons;
Show("dies and respawns", owned);

void Show(String label, byte value)
{
    List<string> names = new List<string>();

    foreach (WeaponId w in Enum.GetValues(typeof(WeaponId)))
        if (WeaponBits.HasWeapon(value, w)) names.Add(w.ToString());

        
    Console.WriteLine($"{label,-30} {WeaponBits.ToBinaryString(value)}  " +
        $"0x{value:X2}  {value,3}  [{string.Join(", ", names)}]");
}
 */

 /* MovementBits keys = MovementBits.W | MovementBits.D | MovementBits.Sprint;
 Console.WriteLine($"Keys held: W + D + Shift -> movement byte {WeaponBits.ToBinaryString((byte)keys)} = 0x {(byte)keys:X2} = {(byte)keys}");

 MovementBits released = keys & ~MovementBits.Sprint;

 Console.WriteLine($" release Shift (AND NOT Sprint): {WeaponBits.ToBinaryString((byte)released)} = \"{released}\"");

 ButtonBits buttons = (buttonBits)0b0000_0011;

 Console.WriteLine($"  a buttons byte of 00000011 means \"{buttons}\" - BooleanSwitch travel in ThreadExceptionEventArgs 22-byte Input packet(M06)"); */

 Console.WriteLine("Same eight bits, two types:");

 byte allOnes = 0b1111_1111;
 sbyte asSigned = unchecked((sbyte)allOnes);
 Console.WriteLine($"  {WeaponBits.ToBinaryString(allOnes)} -> byte {allOnes}, sbyte {asSigned}");