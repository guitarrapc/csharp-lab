```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.202
  [Host]            : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method          | Runtime  | data                | Mean           | Error        | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |--------- |-------------------- |---------------:|-------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **.NET 8.0** | **KLVJ(...)0t2z [160]** |     **1,235.5 ns** |    **130.56 ns** |     **7.16 ns** |     **1,229.9 ns** |     **1,243.6 ns** | **0.0668** |    **1128 B** |
| SHA1String      | .NET 8.0 | KLVJ(...)0t2z [160] |     1,418.4 ns |    198.92 ns |    10.90 ns |     1,409.3 ns |     1,430.5 ns | 0.0839 |    1416 B |
| SHA256String    | .NET 8.0 | KLVJ(...)0t2z [160] |     1,645.7 ns |     84.74 ns |     4.64 ns |     1,640.6 ns |     1,649.6 ns | 0.1106 |    1856 B |
| SHA512String    | .NET 8.0 | KLVJ(...)0t2z [160] |     2,571.4 ns |    189.23 ns |    10.37 ns |     2,560.4 ns |     2,581.1 ns | 0.1907 |    3240 B |
| XxHash32String  | .NET 8.0 | KLVJ(...)0t2z [160] |       186.3 ns |     13.99 ns |     0.77 ns |       185.8 ns |       187.1 ns | 0.0348 |     584 B |
| XxHash64String  | .NET 8.0 | KLVJ(...)0t2z [160] |       266.2 ns |     36.17 ns |     1.98 ns |       263.9 ns |       267.7 ns | 0.0434 |     728 B |
| XxHash128String | .NET 8.0 | KLVJ(...)0t2z [160] |       466.8 ns |     28.08 ns |     1.54 ns |       465.3 ns |       468.4 ns | 0.0672 |    1128 B |
| MD5String       | .NET 9.0 | KLVJ(...)0t2z [160] |     1,215.1 ns |    115.98 ns |     6.36 ns |     1,210.2 ns |     1,222.3 ns | 0.0668 |    1128 B |
| SHA1String      | .NET 9.0 | KLVJ(...)0t2z [160] |     1,418.0 ns |     16.35 ns |     0.90 ns |     1,417.2 ns |     1,419.0 ns | 0.0839 |    1416 B |
| SHA256String    | .NET 9.0 | KLVJ(...)0t2z [160] |     1,613.8 ns |     93.80 ns |     5.14 ns |     1,609.1 ns |     1,619.3 ns | 0.1106 |    1856 B |
| SHA512String    | .NET 9.0 | KLVJ(...)0t2z [160] |     2,666.0 ns |    152.87 ns |     8.38 ns |     2,656.6 ns |     2,672.5 ns | 0.1907 |    3240 B |
| XxHash32String  | .NET 9.0 | KLVJ(...)0t2z [160] |       173.6 ns |      8.81 ns |     0.48 ns |       173.3 ns |       174.2 ns | 0.0348 |     584 B |
| XxHash64String  | .NET 9.0 | KLVJ(...)0t2z [160] |       254.1 ns |     10.75 ns |     0.59 ns |       253.8 ns |       254.8 ns | 0.0434 |     728 B |
| XxHash128String | .NET 9.0 | KLVJ(...)0t2z [160] |       485.4 ns |     61.60 ns |     3.38 ns |       483.0 ns |       489.2 ns | 0.0668 |    1128 B |
| **MD5Binary**       | **.NET 8.0** | **Byte[1048576]**       | **1,552,916.1 ns** |  **1,576.94 ns** |    **86.44 ns** | **1,552,850.5 ns** | **1,553,014.1 ns** |      **-** |      **41 B** |
| SHA1Binary      | .NET 8.0 | Byte[1048576]       |   617,500.2 ns |  1,934.63 ns |   106.04 ns |   617,421.5 ns |   617,620.8 ns |      - |      49 B |
| SHA256Binary    | .NET 8.0 | Byte[1048576]       |   658,973.7 ns | 13,831.05 ns |   758.13 ns |   658,484.2 ns |   659,847.0 ns |      - |      57 B |
| SHA512Binary    | .NET 8.0 | Byte[1048576]       | 1,381,701.8 ns | 31,831.13 ns | 1,744.77 ns | 1,380,098.5 ns | 1,383,560.0 ns |      - |      89 B |
| XxHash32Binary  | .NET 8.0 | Byte[1048576]       |   163,106.4 ns |  1,606.14 ns |    88.04 ns |   163,009.2 ns |   163,180.9 ns |      - |      32 B |
| XxHash64Binary  | .NET 8.0 | Byte[1048576]       |    91,987.8 ns |  2,726.05 ns |   149.42 ns |    91,820.8 ns |    92,109.0 ns |      - |      32 B |
| XxHash128Binary | .NET 8.0 | Byte[1048576]       |    66,051.6 ns |  9,025.23 ns |   494.70 ns |    65,482.8 ns |    66,381.5 ns |      - |      40 B |
| MD5Binary       | .NET 9.0 | Byte[1048576]       | 1,552,840.3 ns |  1,143.68 ns |    62.69 ns | 1,552,768.0 ns | 1,552,879.3 ns |      - |      41 B |
| SHA1Binary      | .NET 9.0 | Byte[1048576]       |   617,711.7 ns |  6,345.89 ns |   347.84 ns |   617,318.9 ns |   617,980.8 ns |      - |      49 B |
| SHA256Binary    | .NET 9.0 | Byte[1048576]       |   659,600.3 ns | 22,089.48 ns | 1,210.80 ns |   658,316.2 ns |   660,721.2 ns |      - |      57 B |
| SHA512Binary    | .NET 9.0 | Byte[1048576]       | 1,379,720.8 ns | 11,431.43 ns |   626.60 ns | 1,379,232.1 ns | 1,380,427.2 ns |      - |      89 B |
| XxHash32Binary  | .NET 9.0 | Byte[1048576]       |   163,018.5 ns |    923.93 ns |    50.64 ns |   162,972.2 ns |   163,072.6 ns |      - |      32 B |
| XxHash64Binary  | .NET 9.0 | Byte[1048576]       |    92,221.5 ns | 12,355.55 ns |   677.25 ns |    91,761.6 ns |    92,999.2 ns |      - |      32 B |
| XxHash128Binary | .NET 9.0 | Byte[1048576]       |    34,005.9 ns |  8,109.94 ns |   444.53 ns |    33,612.5 ns |    34,488.1 ns |      - |      40 B |
