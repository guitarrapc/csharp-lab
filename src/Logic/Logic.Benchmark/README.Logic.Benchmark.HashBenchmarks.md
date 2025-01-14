```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error        | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|-------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,269.6 ns** |    **166.59 ns** |     **9.13 ns** |     **1,259.8 ns** |     **1,277.9 ns** | **0.0668** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,428.5 ns |    335.99 ns |    18.42 ns |     1,408.7 ns |     1,445.1 ns | 0.0839 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,679.3 ns |    206.42 ns |    11.31 ns |     1,667.2 ns |     1,689.6 ns | 0.1106 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,621.8 ns |    700.21 ns |    38.38 ns |     2,578.3 ns |     2,651.1 ns | 0.1907 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       180.4 ns |     31.65 ns |     1.74 ns |       179.2 ns |       182.4 ns | 0.0348 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       271.4 ns |     83.32 ns |     4.57 ns |       268.3 ns |       276.7 ns | 0.0434 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       477.9 ns |     56.36 ns |     3.09 ns |       474.3 ns |       479.9 ns | 0.0668 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,554,012.0 ns** |  **1,378.56 ns** |    **75.56 ns** | **1,553,950.4 ns** | **1,554,096.3 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   618,501.7 ns | 30,323.74 ns | 1,662.15 ns |   617,448.4 ns |   620,417.9 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   660,460.5 ns | 28,909.50 ns | 1,584.63 ns |   658,633.2 ns |   661,456.4 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,383,941.8 ns | 72,980.07 ns | 4,000.28 ns | 1,379,390.4 ns | 1,386,900.2 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   163,428.9 ns |  5,847.28 ns |   320.51 ns |   163,114.6 ns |   163,755.3 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    92,270.9 ns |  5,827.96 ns |   319.45 ns |    91,912.2 ns |    92,524.9 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    33,093.0 ns |  7,251.16 ns |   397.46 ns |    32,846.2 ns |    33,551.5 ns |      - |      40 B |
