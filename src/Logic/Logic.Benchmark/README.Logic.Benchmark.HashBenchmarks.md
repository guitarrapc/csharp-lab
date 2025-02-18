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
| **MD5String**       | **.NET 8.0** | **KLVJ(...)0t2z [160]** |     **1,234.9 ns** |    **138.94 ns** |     **7.62 ns** |     **1,229.1 ns** |     **1,243.5 ns** | **0.0668** |    **1128 B** |
| SHA1String      | .NET 8.0 | KLVJ(...)0t2z [160] |     1,409.0 ns |    355.68 ns |    19.50 ns |     1,392.5 ns |     1,430.5 ns | 0.0839 |    1416 B |
| SHA256String    | .NET 8.0 | KLVJ(...)0t2z [160] |     1,660.5 ns |    206.22 ns |    11.30 ns |     1,650.4 ns |     1,672.7 ns | 0.1106 |    1856 B |
| SHA512String    | .NET 8.0 | KLVJ(...)0t2z [160] |     2,544.1 ns |     61.21 ns |     3.36 ns |     2,541.7 ns |     2,547.9 ns | 0.1907 |    3240 B |
| XxHash32String  | .NET 8.0 | KLVJ(...)0t2z [160] |       184.9 ns |     44.72 ns |     2.45 ns |       182.8 ns |       187.6 ns | 0.0348 |     584 B |
| XxHash64String  | .NET 8.0 | KLVJ(...)0t2z [160] |       269.8 ns |     25.91 ns |     1.42 ns |       268.4 ns |       271.2 ns | 0.0434 |     728 B |
| XxHash128String | .NET 8.0 | KLVJ(...)0t2z [160] |       466.8 ns |     28.76 ns |     1.58 ns |       465.1 ns |       468.1 ns | 0.0672 |    1128 B |
| MD5String       | .NET 9.0 | KLVJ(...)0t2z [160] |     1,227.0 ns |    134.74 ns |     7.39 ns |     1,219.3 ns |     1,234.0 ns | 0.0668 |    1128 B |
| SHA1String      | .NET 9.0 | KLVJ(...)0t2z [160] |     1,499.2 ns |    107.19 ns |     5.88 ns |     1,494.7 ns |     1,505.8 ns | 0.0839 |    1416 B |
| SHA256String    | .NET 9.0 | KLVJ(...)0t2z [160] |     1,658.5 ns |     94.01 ns |     5.15 ns |     1,654.8 ns |     1,664.4 ns | 0.1106 |    1856 B |
| SHA512String    | .NET 9.0 | KLVJ(...)0t2z [160] |     2,543.9 ns |    128.62 ns |     7.05 ns |     2,537.3 ns |     2,551.3 ns | 0.1907 |    3240 B |
| XxHash32String  | .NET 9.0 | KLVJ(...)0t2z [160] |       175.9 ns |     28.07 ns |     1.54 ns |       174.5 ns |       177.5 ns | 0.0348 |     584 B |
| XxHash64String  | .NET 9.0 | KLVJ(...)0t2z [160] |       254.2 ns |     29.80 ns |     1.63 ns |       252.5 ns |       255.8 ns | 0.0434 |     728 B |
| XxHash128String | .NET 9.0 | KLVJ(...)0t2z [160] |       465.4 ns |    100.77 ns |     5.52 ns |       461.1 ns |       471.7 ns | 0.0668 |    1128 B |
| **MD5Binary**       | **.NET 8.0** | **Byte[1048576]**       | **1,555,036.5 ns** | **44,548.48 ns** | **2,441.85 ns** | **1,553,596.9 ns** | **1,557,855.9 ns** |      **-** |      **41 B** |
| SHA1Binary      | .NET 8.0 | Byte[1048576]       |   617,425.7 ns |  2,673.36 ns |   146.54 ns |   617,257.5 ns |   617,525.8 ns |      - |      49 B |
| SHA256Binary    | .NET 8.0 | Byte[1048576]       |   660,493.7 ns | 37,369.66 ns | 2,048.36 ns |   658,444.2 ns |   662,540.9 ns |      - |      57 B |
| SHA512Binary    | .NET 8.0 | Byte[1048576]       | 1,379,362.6 ns | 14,541.73 ns |   797.08 ns | 1,378,849.7 ns | 1,380,280.9 ns |      - |      89 B |
| XxHash32Binary  | .NET 8.0 | Byte[1048576]       |   163,087.2 ns |    478.61 ns |    26.23 ns |   163,057.4 ns |   163,106.8 ns |      - |      32 B |
| XxHash64Binary  | .NET 8.0 | Byte[1048576]       |    91,987.7 ns |  2,931.32 ns |   160.68 ns |    91,857.2 ns |    92,167.2 ns |      - |      32 B |
| XxHash128Binary | .NET 8.0 | Byte[1048576]       |    66,054.7 ns |  7,716.09 ns |   422.95 ns |    65,573.5 ns |    66,367.4 ns |      - |      40 B |
| MD5Binary       | .NET 9.0 | Byte[1048576]       | 1,553,544.8 ns |  3,366.89 ns |   184.55 ns | 1,553,332.4 ns | 1,553,665.8 ns |      - |      41 B |
| SHA1Binary      | .NET 9.0 | Byte[1048576]       |   617,516.9 ns |  1,131.08 ns |    62.00 ns |   617,465.4 ns |   617,585.7 ns |      - |      49 B |
| SHA256Binary    | .NET 9.0 | Byte[1048576]       |   660,142.5 ns | 27,194.86 ns | 1,490.64 ns |   658,421.9 ns |   661,043.1 ns |      - |      57 B |
| SHA512Binary    | .NET 9.0 | Byte[1048576]       | 1,381,360.8 ns | 57,577.93 ns | 3,156.04 ns | 1,379,326.3 ns | 1,384,996.5 ns |      - |      89 B |
| XxHash32Binary  | .NET 9.0 | Byte[1048576]       |   163,195.3 ns |  2,143.99 ns |   117.52 ns |   163,117.0 ns |   163,330.4 ns |      - |      32 B |
| XxHash64Binary  | .NET 9.0 | Byte[1048576]       |    92,056.6 ns |  2,990.75 ns |   163.93 ns |    91,870.2 ns |    92,178.1 ns |      - |      32 B |
| XxHash128Binary | .NET 9.0 | Byte[1048576]       |    34,011.1 ns |  8,127.96 ns |   445.52 ns |    33,728.9 ns |    34,524.7 ns |      - |      40 B |
