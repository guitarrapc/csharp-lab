```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method          | Runtime  | data                | Mean           | Error        | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |--------- |-------------------- |---------------:|-------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **.NET 8.0** | **KLVJ(...)0t2z [160]** |     **1,257.2 ns** |     **82.56 ns** |     **4.53 ns** |     **1,253.9 ns** |     **1,262.3 ns** | **0.0668** |    **1128 B** |
| SHA1String      | .NET 8.0 | KLVJ(...)0t2z [160] |     1,443.0 ns |    140.48 ns |     7.70 ns |     1,434.4 ns |     1,449.3 ns | 0.0839 |    1416 B |
| SHA256String    | .NET 8.0 | KLVJ(...)0t2z [160] |     1,697.9 ns |    125.72 ns |     6.89 ns |     1,690.6 ns |     1,704.3 ns | 0.1106 |    1856 B |
| SHA512String    | .NET 8.0 | KLVJ(...)0t2z [160] |     2,636.4 ns |    525.29 ns |    28.79 ns |     2,605.2 ns |     2,661.9 ns | 0.1907 |    3240 B |
| XxHash32String  | .NET 8.0 | KLVJ(...)0t2z [160] |       189.9 ns |     48.75 ns |     2.67 ns |       187.0 ns |       192.2 ns | 0.0348 |     584 B |
| XxHash64String  | .NET 8.0 | KLVJ(...)0t2z [160] |       317.1 ns |     73.55 ns |     4.03 ns |       312.5 ns |       320.0 ns | 0.0434 |     728 B |
| XxHash128String | .NET 8.0 | KLVJ(...)0t2z [160] |       466.0 ns |     97.66 ns |     5.35 ns |       459.9 ns |       469.8 ns | 0.0672 |    1128 B |
| MD5String       | .NET 9.0 | KLVJ(...)0t2z [160] |     1,248.4 ns |    134.87 ns |     7.39 ns |     1,242.7 ns |     1,256.8 ns | 0.0668 |    1128 B |
| SHA1String      | .NET 9.0 | KLVJ(...)0t2z [160] |     1,440.2 ns |     20.96 ns |     1.15 ns |     1,439.2 ns |     1,441.5 ns | 0.0839 |    1416 B |
| SHA256String    | .NET 9.0 | KLVJ(...)0t2z [160] |     1,690.7 ns |    110.30 ns |     6.05 ns |     1,684.4 ns |     1,696.4 ns | 0.1106 |    1856 B |
| SHA512String    | .NET 9.0 | KLVJ(...)0t2z [160] |     2,599.6 ns |     52.72 ns |     2.89 ns |     2,596.6 ns |     2,602.4 ns | 0.1907 |    3240 B |
| XxHash32String  | .NET 9.0 | KLVJ(...)0t2z [160] |       183.0 ns |     26.56 ns |     1.46 ns |       181.5 ns |       184.4 ns | 0.0348 |     584 B |
| XxHash64String  | .NET 9.0 | KLVJ(...)0t2z [160] |       273.3 ns |    248.69 ns |    13.63 ns |       262.7 ns |       288.7 ns | 0.0434 |     728 B |
| XxHash128String | .NET 9.0 | KLVJ(...)0t2z [160] |       474.8 ns |     24.62 ns |     1.35 ns |       473.3 ns |       475.9 ns | 0.0668 |    1128 B |
| **MD5Binary**       | **.NET 8.0** | **Byte[1048576]**       | **1,554,689.2 ns** | **13,233.96 ns** |   **725.40 ns** | **1,553,852.4 ns** | **1,555,139.3 ns** |      **-** |      **41 B** |
| SHA1Binary      | .NET 8.0 | Byte[1048576]       |   617,317.1 ns |    941.58 ns |    51.61 ns |   617,257.7 ns |   617,351.2 ns |      - |      49 B |
| SHA256Binary    | .NET 8.0 | Byte[1048576]       |   658,265.3 ns |    632.57 ns |    34.67 ns |   658,235.3 ns |   658,303.2 ns |      - |      57 B |
| SHA512Binary    | .NET 8.0 | Byte[1048576]       | 1,380,043.9 ns | 11,317.04 ns |   620.33 ns | 1,379,327.6 ns | 1,380,402.3 ns |      - |      89 B |
| XxHash32Binary  | .NET 8.0 | Byte[1048576]       |   163,355.0 ns |  6,237.25 ns |   341.88 ns |   163,062.2 ns |   163,730.8 ns |      - |      32 B |
| XxHash64Binary  | .NET 8.0 | Byte[1048576]       |    93,186.6 ns |  2,157.40 ns |   118.25 ns |    93,110.1 ns |    93,322.8 ns |      - |      32 B |
| XxHash128Binary | .NET 8.0 | Byte[1048576]       |    65,799.7 ns |  5,662.02 ns |   310.35 ns |    65,524.2 ns |    66,135.9 ns |      - |      40 B |
| MD5Binary       | .NET 9.0 | Byte[1048576]       | 1,553,651.2 ns |  4,956.30 ns |   271.67 ns | 1,553,393.5 ns | 1,553,935.0 ns |      - |      41 B |
| SHA1Binary      | .NET 9.0 | Byte[1048576]       |   617,480.8 ns |  2,650.84 ns |   145.30 ns |   617,386.5 ns |   617,648.1 ns |      - |      49 B |
| SHA256Binary    | .NET 9.0 | Byte[1048576]       |   659,973.6 ns |  4,342.85 ns |   238.05 ns |   659,723.8 ns |   660,197.8 ns |      - |      57 B |
| SHA512Binary    | .NET 9.0 | Byte[1048576]       | 1,381,970.5 ns | 32,737.34 ns | 1,794.44 ns | 1,380,103.6 ns | 1,383,682.5 ns |      - |      89 B |
| XxHash32Binary  | .NET 9.0 | Byte[1048576]       |   163,326.6 ns |  8,372.52 ns |   458.93 ns |   163,031.1 ns |   163,855.3 ns |      - |      32 B |
| XxHash64Binary  | .NET 9.0 | Byte[1048576]       |    91,974.9 ns |  1,493.76 ns |    81.88 ns |    91,912.1 ns |    92,067.5 ns |      - |      32 B |
| XxHash128Binary | .NET 9.0 | Byte[1048576]       |    33,793.2 ns |  3,609.14 ns |   197.83 ns |    33,667.5 ns |    34,021.3 ns |      - |      40 B |
