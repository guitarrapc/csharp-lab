```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]   : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error        | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|-------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,218.7 ns** |    **115.04 ns** |     **6.31 ns** |     **1,212.9 ns** |     **1,225.4 ns** | **0.0668** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,413.1 ns |     76.88 ns |     4.21 ns |     1,408.3 ns |     1,416.1 ns | 0.0839 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,619.0 ns |     63.36 ns |     3.47 ns |     1,615.0 ns |     1,621.6 ns | 0.1106 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,587.9 ns |    443.96 ns |    24.34 ns |     2,569.0 ns |     2,615.4 ns | 0.1907 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       176.1 ns |      9.52 ns |     0.52 ns |       175.6 ns |       176.6 ns | 0.0348 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       251.0 ns |     19.88 ns |     1.09 ns |       249.9 ns |       252.1 ns | 0.0434 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       491.1 ns |     45.84 ns |     2.51 ns |       488.5 ns |       493.5 ns | 0.0668 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,553,022.3 ns** |    **830.05 ns** |    **45.50 ns** | **1,552,994.5 ns** | **1,553,074.8 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   617,266.3 ns |    384.15 ns |    21.06 ns |   617,253.5 ns |   617,290.6 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   659,401.2 ns | 28,333.67 ns | 1,553.06 ns |   658,280.1 ns |   661,173.9 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,379,882.5 ns | 18,256.89 ns | 1,000.72 ns | 1,379,249.0 ns | 1,381,036.1 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   162,980.6 ns |    517.55 ns |    28.37 ns |   162,952.0 ns |   163,008.7 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,885.7 ns |  1,833.95 ns |   100.53 ns |    91,776.4 ns |    91,974.2 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    33,200.7 ns |  6,330.57 ns |   347.00 ns |    32,845.4 ns |    33,538.8 ns |      - |      40 B |
