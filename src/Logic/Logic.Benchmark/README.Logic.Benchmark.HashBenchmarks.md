```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.203
  [Host]            : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method          | Runtime  | data                | Mean           | Error        | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |--------- |-------------------- |---------------:|-------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **.NET 8.0** | **KLVJ(...)0t2z [160]** |     **1,354.8 ns** |     **98.00 ns** |     **5.37 ns** |     **1,350.8 ns** |     **1,360.9 ns** | **0.0668** |    **1128 B** |
| SHA1String      | .NET 8.0 | KLVJ(...)0t2z [160] |     1,550.8 ns |    155.45 ns |     8.52 ns |     1,541.5 ns |     1,558.1 ns | 0.0839 |    1416 B |
| SHA256String    | .NET 8.0 | KLVJ(...)0t2z [160] |     1,764.5 ns |    102.51 ns |     5.62 ns |     1,758.1 ns |     1,768.6 ns | 0.1106 |    1856 B |
| SHA512String    | .NET 8.0 | KLVJ(...)0t2z [160] |     2,729.4 ns |    413.78 ns |    22.68 ns |     2,714.3 ns |     2,755.4 ns | 0.1907 |    3240 B |
| XxHash32String  | .NET 8.0 | KLVJ(...)0t2z [160] |       203.5 ns |     59.96 ns |     3.29 ns |       200.3 ns |       206.9 ns | 0.0348 |     584 B |
| XxHash64String  | .NET 8.0 | KLVJ(...)0t2z [160] |       314.4 ns |     38.90 ns |     2.13 ns |       312.6 ns |       316.7 ns | 0.0434 |     728 B |
| XxHash128String | .NET 8.0 | KLVJ(...)0t2z [160] |       472.2 ns |     51.01 ns |     2.80 ns |       470.5 ns |       475.5 ns | 0.0672 |    1128 B |
| MD5String       | .NET 9.0 | KLVJ(...)0t2z [160] |     1,344.7 ns |     33.73 ns |     1.85 ns |     1,342.8 ns |     1,346.5 ns | 0.0668 |    1128 B |
| SHA1String      | .NET 9.0 | KLVJ(...)0t2z [160] |     1,524.7 ns |    156.43 ns |     8.57 ns |     1,514.9 ns |     1,530.8 ns | 0.0839 |    1416 B |
| SHA256String    | .NET 9.0 | KLVJ(...)0t2z [160] |     1,753.7 ns |     86.07 ns |     4.72 ns |     1,750.7 ns |     1,759.1 ns | 0.1106 |    1856 B |
| SHA512String    | .NET 9.0 | KLVJ(...)0t2z [160] |     2,756.3 ns |    399.90 ns |    21.92 ns |     2,737.2 ns |     2,780.2 ns | 0.1907 |    3240 B |
| XxHash32String  | .NET 9.0 | KLVJ(...)0t2z [160] |       195.9 ns |    160.58 ns |     8.80 ns |       185.8 ns |       201.8 ns | 0.0348 |     584 B |
| XxHash64String  | .NET 9.0 | KLVJ(...)0t2z [160] |       276.4 ns |      5.20 ns |     0.28 ns |       276.1 ns |       276.7 ns | 0.0434 |     728 B |
| XxHash128String | .NET 9.0 | KLVJ(...)0t2z [160] |       485.6 ns |    127.57 ns |     6.99 ns |       480.8 ns |       493.6 ns | 0.0668 |    1128 B |
| **MD5Binary**       | **.NET 8.0** | **Byte[1048576]**       | **1,554,289.2 ns** |  **5,946.50 ns** |   **325.95 ns** | **1,553,991.2 ns** | **1,554,637.2 ns** |      **-** |      **41 B** |
| SHA1Binary      | .NET 8.0 | Byte[1048576]       |   617,846.3 ns |  4,055.06 ns |   222.27 ns |   617,712.8 ns |   618,102.8 ns |      - |      49 B |
| SHA256Binary    | .NET 8.0 | Byte[1048576]       |   659,847.7 ns | 27,253.77 ns | 1,493.87 ns |   658,540.6 ns |   661,476.1 ns |      - |      57 B |
| SHA512Binary    | .NET 8.0 | Byte[1048576]       | 1,383,313.0 ns | 75,998.61 ns | 4,165.74 ns | 1,380,767.0 ns | 1,388,120.4 ns |      - |      89 B |
| XxHash32Binary  | .NET 8.0 | Byte[1048576]       |   163,999.4 ns | 18,852.79 ns | 1,033.39 ns |   163,138.2 ns |   165,145.3 ns |      - |      32 B |
| XxHash64Binary  | .NET 8.0 | Byte[1048576]       |    92,990.8 ns |  1,193.55 ns |    65.42 ns |    92,926.0 ns |    93,056.8 ns |      - |      32 B |
| XxHash128Binary | .NET 8.0 | Byte[1048576]       |    66,093.9 ns |  6,565.40 ns |   359.87 ns |    65,680.3 ns |    66,334.7 ns |      - |      40 B |
| MD5Binary       | .NET 9.0 | Byte[1048576]       | 1,554,700.7 ns | 16,075.58 ns |   881.16 ns | 1,553,811.5 ns | 1,555,573.6 ns |      - |      41 B |
| SHA1Binary      | .NET 9.0 | Byte[1048576]       |   617,836.7 ns |  1,563.38 ns |    85.69 ns |   617,737.9 ns |   617,889.5 ns |      - |      49 B |
| SHA256Binary    | .NET 9.0 | Byte[1048576]       |   659,493.2 ns | 27,639.91 ns | 1,515.04 ns |   658,556.6 ns |   661,241.2 ns |      - |      57 B |
| SHA512Binary    | .NET 9.0 | Byte[1048576]       | 1,382,434.7 ns | 57,775.00 ns | 3,166.84 ns | 1,380,395.8 ns | 1,386,083.0 ns |      - |      89 B |
| XxHash32Binary  | .NET 9.0 | Byte[1048576]       |   163,401.8 ns |  6,566.36 ns |   359.92 ns |   163,130.2 ns |   163,810.0 ns |      - |      32 B |
| XxHash64Binary  | .NET 9.0 | Byte[1048576]       |    92,751.8 ns | 14,207.50 ns |   778.76 ns |    92,084.1 ns |    93,607.3 ns |      - |      32 B |
| XxHash128Binary | .NET 9.0 | Byte[1048576]       |    34,022.5 ns |  6,025.48 ns |   330.28 ns |    33,667.4 ns |    34,320.6 ns |      - |      40 B |
