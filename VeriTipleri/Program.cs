
// 8 bit integer
Console.WriteLine(nameof(SByte) + " -> sbyte");
Console.WriteLine($"Alt Limit  : {SByte.MinValue, 20}");
Console.WriteLine($"Üst Limit  : {SByte.MaxValue, 20}");
Console.WriteLine($"Boyut      : {sizeof(SByte), 20}  byte");
Console.WriteLine();

// Unsigned 8 bit integer
Console.WriteLine(nameof(Byte) + " -> byte");
Console.WriteLine($"Alt Limit  : {Byte.MinValue, 20}");
Console.WriteLine($"Üst Limit  : {Byte.MaxValue, 20}");
Console.WriteLine($"Boyut      : {sizeof(Byte), 20} byte");
Console.WriteLine();

// Signed 16 bit integer
Console.WriteLine(nameof(Int16) + " -> short");
Console.WriteLine("Alt Limit  : {0, 20 : 0,###}", Int16.MinValue);
Console.WriteLine("Üst Limit  : {0, 20 : 0,###}", Int16.MaxValue);
Console.WriteLine($"Boyut      : {sizeof(Int16), 20}  byte");
Console.WriteLine();

// Unsigned 16 bit integer
Console.WriteLine(nameof(UInt16) + " -> ushort");
Console.WriteLine("Alt Limit  : {0, 20}", UInt16.MinValue);
Console.WriteLine("Üst Limit  : {0, 20 : 0,###}", UInt16.MaxValue);
Console.WriteLine($"Boyut      : {sizeof(UInt16), 20} byte");
Console.WriteLine();

// signed 32 bit integer
Console.WriteLine(nameof(Int32) + " -> int");
Console.WriteLine("Alt Limit  : {0, 20 : 0,###}", Int32.MinValue);
Console.WriteLine("Üst Limit  : {0, 20 : 0,###}", Int32.MaxValue);
Console.WriteLine($"Boyut      : {sizeof(Int32), 20}  byte");
Console.WriteLine();

// Unsigned 32 bit integer
Console.WriteLine(nameof(UInt32) + " -> uint");
Console.WriteLine("Alt Limit  : {0, 20}", UInt32.MinValue);
Console.WriteLine("Üst Limit  : {0, 20 : 0,###}", UInt32.MaxValue);
Console.WriteLine($"Boyut      : {sizeof(UInt32), 20} byte");
Console.WriteLine();

// signed 64 bit integer
Console.WriteLine(nameof(Int64) + " -> long");
Console.WriteLine("Alt Limit  : {0, 20 : 0,###}", Int64.MinValue);
Console.WriteLine("Üst Limit  : {0, 20 : 0,###}", Int64.MaxValue);
Console.WriteLine($"Boyut      : {sizeof(Int64), 20}  byte");
Console.WriteLine();

// Unsigned 64 bit integer
Console.WriteLine(nameof(UInt64) + " -> ulong");
Console.WriteLine("Alt Limit  : {0, 20}", UInt64.MinValue);
Console.WriteLine("Üst Limit  : {0, 20 : 0,###}", UInt64.MaxValue);
Console.WriteLine($"Boyut      : {sizeof(UInt64), 20} byte");
Console.WriteLine();

// Signed 128 bit integer
Console.WriteLine(nameof(Int128));
Console.WriteLine("Alt Limit  : {0, 20 : 0,###}", Int128.MinValue);
Console.WriteLine("Üst Limit  : {0, 20 : 0,###}", Int128.MaxValue);
//Console.WriteLine($"Boyut      : {typeof(Int128), 20}  byte");
Console.WriteLine();

// Unsigned 128 bit integer
Console.WriteLine(nameof(UInt128));
Console.WriteLine("Alt Limit  : {0, 20 }", UInt128.MinValue);
Console.WriteLine("Üst Limit  : {0, 20 : 0,###}", UInt128.MaxValue);
//Console.WriteLine($"Boyut      : {typeof(UInt128), 20} byte");
Console.WriteLine();

// Unsigned Single bit integer
Console.WriteLine(nameof(Single) + " -> float");
Console.WriteLine("Alt Limit  : {0, 20 : 0,###}", Single.MinValue);
Console.WriteLine("Üst Limit  : {0, 20 : 0,###}", Single.MaxValue);
Console.WriteLine($"Boyut      : {sizeof(Single), 20} byte");
Console.WriteLine();

// Unsigned double bit integer
Console.WriteLine(nameof(Double) +  " -> double");
Console.WriteLine("Alt Limit  : {0, 20 : 0,###}", Double.MinValue);
Console.WriteLine("Üst Limit  : {0, 20 : 0,###}", Double.MaxValue);
Console.WriteLine($"Boyut      : {sizeof(Double), 20} byte");
Console.WriteLine();

// Unsigned Decimal bit integer
Console.WriteLine(nameof(Decimal));
Console.WriteLine("Alt Limit  : {0, 20 : 0,###}", Decimal.MinValue);
Console.WriteLine("Üst Limit  : {0, 20 : 0,###}", Decimal.MaxValue);
Console.WriteLine($"Boyut      : {sizeof(Decimal), 20} byte");
Console.WriteLine();

//  Boolean
Console.WriteLine(nameof(Boolean));
Console.WriteLine($"Boyut      : {sizeof(Double), 20} byte" );
Console.WriteLine();

//  Char
Console.WriteLine(nameof(Char));
Console.WriteLine("Alt Limit  : {0, 20 : 0,###}", Char.MinValue);
Console.WriteLine("Üst Limit  : {0, 20 : 0,###}", Char.MaxValue);
Console.WriteLine($"Boyut      : {sizeof(Char), 20} byte" );
Console.WriteLine();

//  DateTime
Console.WriteLine(nameof(DateTime));
Console.WriteLine("DateTime.Now                                    : " + DateTime.Now);
Console.WriteLine("DateTime.UtcNow                                 : " + DateTime.UtcNow);
Console.WriteLine("DateTime.Compare(DateTime.Now, DateTime.UtcNow) : " + DateTime.Compare(DateTime.Now, DateTime.UtcNow));
Console.WriteLine("DateTime.DaysInMonth(2024, 8)                   : " + DateTime.DaysInMonth(2024, 8));
Console.WriteLine("DateTime.Today                                  : " + DateTime.Today);
Console.WriteLine("DateTime.FromOADate(1564434)                    : " + DateTime.FromOADate(1564434));
Console.WriteLine("DateTime.IsLeapYear(2024)                       : " + DateTime.IsLeapYear(2024));
Console.WriteLine("DateTime.FromFileTime(1564434) : " + DateTime.FromFileTime(1564434));
//Console.WriteLine($"Boyut      : {sizeof(DateTime), 20} byte" );
Console.WriteLine();

//  Guid
Console.WriteLine(nameof(Guid));
Console.WriteLine("Örnek  : {0, 20}", Guid.NewGuid());
Console.WriteLine("Örnek  : {0, 20}", Guid.NewGuid());
//Console.WriteLine($"Boyut      : {sizeof(Guid), 20} byte" );
Console.WriteLine();

//  TimeSpan
Console.WriteLine(nameof(TimeSpan));
Console.WriteLine("Örnek  : {0, 20}", TimeSpan.MinValue);
Console.WriteLine("Örnek  : {0, 20}", TimeSpan.MaxValue);
Console.WriteLine("TimeSpan.Zero : " + TimeSpan.Zero);
Console.WriteLine("TimeSpan.FromSeconds(89) : " + TimeSpan.FromSeconds(89));
Console.WriteLine("TimeSpan.FromMinutes(100) : " + TimeSpan.FromMinutes(125));
Console.WriteLine("TimeSpan.FromDays(254.45) : " + TimeSpan.FromDays(254.45));
//Console.WriteLine($"Boyut      : {sizeof(TimeSpan), 20} byte" );
Console.WriteLine();

//  String
Console.WriteLine(nameof(String));
//Console.WriteLine($"Boyut      : {sizeof(Guid), 20} byte" );
Console.WriteLine();

Console.WriteLine();
Console.WriteLine("ÖRNEKLER");
Console.WriteLine();
// declaring character
char a = 'G';

// Integer data type is generally
// used for numeric values
int i = 89;

short s = 56;

// this will give error as number
// is larger than short range
// short s1 = 87878787878;

// long uses Integer values which 
// may signed or unsigned
long l = 4564;

// UInt data type is generally
// used for unsigned integer values
uint ui = 95;

ushort us = 76;
// this will give error as number is
// larger than short range

// ulong data type is generally
// used for unsigned integer values
ulong ul = 3624573;

// by default fraction value
// is double in C#
double d = 8.358674532;

// for float use 'f' as suffix
float f = 3.7330645f;

// for float use 'm' as suffix
decimal dec = 389.5m;

Console.WriteLine("char: " + a);
Console.WriteLine("integer: " + i);
Console.WriteLine("short: " + s);
Console.WriteLine("long: " + l);
Console.WriteLine("float: " + f);
Console.WriteLine("double: " + d);
Console.WriteLine("decimal: " + dec);
Console.WriteLine("Unsinged integer: " + ui);
Console.WriteLine("Unsinged short: " + us);
Console.WriteLine("Unsinged long: " + ul);