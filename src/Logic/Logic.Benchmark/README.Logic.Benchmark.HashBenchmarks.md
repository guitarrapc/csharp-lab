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
| **MD5String**       | **.NET 8.0** | **KLVJ(...)0t2z [160]** |     **1,240.6 ns** |     **69.07 ns** |     **3.79 ns** |     **1,237.8 ns** |     **1,244.9 ns** | **0.0668** |    **1128 B** |
| SHA1String      | .NET 8.0 | KLVJ(...)0t2z [160] |     1,420.8 ns |    340.27 ns |    18.65 ns |     1,408.4 ns |     1,442.3 ns | 0.0839 |    1416 B |
| SHA256String    | .NET 8.0 | KLVJ(...)0t2z [160] |     1,658.2 ns |    160.72 ns |     8.81 ns |     1,649.9 ns |     1,667.4 ns | 0.1106 |    1856 B |
| SHA512String    | .NET 8.0 | KLVJ(...)0t2z [160] |     2,594.9 ns |    309.82 ns |    16.98 ns |     2,576.3 ns |     2,609.6 ns | 0.1907 |    3240 B |
| XxHash32String  | .NET 8.0 | KLVJ(...)0t2z [160] |       184.8 ns |      9.02 ns |     0.49 ns |       184.3 ns |       185.2 ns | 0.0348 |     584 B |
| XxHash64String  | .NET 8.0 | KLVJ(...)0t2z [160] |       274.0 ns |     41.93 ns |     2.30 ns |       271.9 ns |       276.4 ns | 0.0434 |     728 B |
| XxHash128String | .NET 8.0 | KLVJ(...)0t2z [160] |       496.2 ns |    221.27 ns |    12.13 ns |       484.9 ns |       509.1 ns | 0.0668 |    1128 B |
| MD5String       | .NET 9.0 | KLVJ(...)0t2z [160] |     1,235.8 ns |    152.94 ns |     8.38 ns |     1,229.9 ns |     1,245.4 ns | 0.0668 |    1128 B |
| SHA1String      | .NET 9.0 | KLVJ(...)0t2z [160] |     1,398.6 ns |    100.43 ns |     5.50 ns |     1,393.6 ns |     1,404.5 ns | 0.0839 |    1416 B |
| SHA256String    | .NET 9.0 | KLVJ(...)0t2z [160] |     1,651.4 ns |    214.79 ns |    11.77 ns |     1,643.1 ns |     1,664.8 ns | 0.1106 |    1856 B |
| SHA512String    | .NET 9.0 | KLVJ(...)0t2z [160] |     2,691.3 ns |    855.29 ns |    46.88 ns |     2,657.5 ns |     2,744.8 ns | 0.1907 |    3240 B |
| XxHash32String  | .NET 9.0 | KLVJ(...)0t2z [160] |       175.8 ns |     30.64 ns |     1.68 ns |       174.3 ns |       177.6 ns | 0.0348 |     584 B |
| XxHash64String  | .NET 9.0 | KLVJ(...)0t2z [160] |       261.8 ns |    121.67 ns |     6.67 ns |       256.4 ns |       269.3 ns | 0.0434 |     728 B |
| XxHash128String | .NET 9.0 | KLVJ(...)0t2z [160] |       474.0 ns |     37.00 ns |     2.03 ns |       471.8 ns |       475.8 ns | 0.0672 |    1128 B |
| **MD5Binary**       | **.NET 8.0** | **Byte[1048576]**       | **1,554,272.7 ns** |  **9,469.20 ns** |   **519.04 ns** | **1,553,801.8 ns** | **1,554,829.3 ns** |      **-** |      **41 B** |
| SHA1Binary      | .NET 8.0 | Byte[1048576]       |   617,575.1 ns |  1,168.41 ns |    64.04 ns |   617,501.9 ns |   617,620.5 ns |      - |      49 B |
| SHA256Binary    | .NET 8.0 | Byte[1048576]       |   658,886.0 ns | 15,899.32 ns |   871.50 ns |   658,312.4 ns |   659,888.9 ns |      - |      57 B |
| SHA512Binary    | .NET 8.0 | Byte[1048576]       | 1,381,970.9 ns | 72,359.96 ns | 3,966.29 ns | 1,379,529.3 ns | 1,386,547.4 ns |      - |      89 B |
| XxHash32Binary  | .NET 8.0 | Byte[1048576]       |   163,245.3 ns |  6,785.05 ns |   371.91 ns |   163,002.3 ns |   163,673.5 ns |      - |      32 B |
| XxHash64Binary  | .NET 8.0 | Byte[1048576]       |    93,380.2 ns |  8,998.21 ns |   493.22 ns |    93,077.1 ns |    93,949.3 ns |      - |      32 B |
| XxHash128Binary | .NET 8.0 | Byte[1048576]       |    65,659.8 ns |  2,994.31 ns |   164.13 ns |    65,504.6 ns |    65,831.6 ns |      - |      40 B |
| MD5Binary       | .NET 9.0 | Byte[1048576]       | 1,553,736.8 ns |  5,701.92 ns |   312.54 ns | 1,553,386.5 ns | 1,553,987.0 ns |      - |      41 B |
| SHA1Binary      | .NET 9.0 | Byte[1048576]       |   618,391.3 ns | 14,585.72 ns |   799.49 ns |   617,617.6 ns |   619,214.3 ns |      - |      49 B |
| SHA256Binary    | .NET 9.0 | Byte[1048576]       |   659,522.5 ns | 24,952.30 ns | 1,367.72 ns |   658,549.4 ns |   661,086.3 ns |      - |      57 B |
| SHA512Binary    | .NET 9.0 | Byte[1048576]       | 1,379,960.5 ns | 13,000.29 ns |   712.59 ns | 1,379,140.4 ns | 1,380,428.4 ns |      - |      89 B |
| XxHash32Binary  | .NET 9.0 | Byte[1048576]       |   163,707.3 ns | 11,182.60 ns |   612.96 ns |   163,000.5 ns |   164,093.3 ns |      - |      32 B |
| XxHash64Binary  | .NET 9.0 | Byte[1048576]       |    91,968.8 ns |  1,770.76 ns |    97.06 ns |    91,864.8 ns |    92,056.9 ns |      - |      32 B |
| XxHash128Binary | .NET 9.0 | Byte[1048576]       |    33,769.4 ns |  2,036.00 ns |   111.60 ns |    33,666.9 ns |    33,888.3 ns |      - |      40 B |
