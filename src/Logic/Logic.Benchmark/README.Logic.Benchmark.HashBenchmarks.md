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
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,241.0 ns** |    **126.73 ns** |     **6.95 ns** |     **1,236.1 ns** |     **1,248.9 ns** | **0.0668** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,425.0 ns |    260.74 ns |    14.29 ns |     1,410.6 ns |     1,439.2 ns | 0.0839 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,662.2 ns |    336.99 ns |    18.47 ns |     1,641.0 ns |     1,674.9 ns | 0.1106 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,645.5 ns |    246.26 ns |    13.50 ns |     2,630.3 ns |     2,655.8 ns | 0.1907 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       185.2 ns |     99.73 ns |     5.47 ns |       181.4 ns |       191.5 ns | 0.0348 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       274.7 ns |    116.84 ns |     6.40 ns |       267.4 ns |       279.3 ns | 0.0434 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       515.5 ns |     62.39 ns |     3.42 ns |       512.1 ns |       518.9 ns | 0.0668 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,553,879.4 ns** |  **1,839.86 ns** |   **100.85 ns** | **1,553,765.0 ns** | **1,553,955.3 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   617,710.6 ns |  7,530.44 ns |   412.77 ns |   617,423.4 ns |   618,183.6 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   658,907.2 ns | 13,947.22 ns |   764.49 ns |   658,424.0 ns |   659,788.6 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,383,846.5 ns | 90,733.32 ns | 4,973.40 ns | 1,379,393.3 ns | 1,389,213.4 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   163,382.0 ns |  5,130.50 ns |   281.22 ns |   163,084.1 ns |   163,642.8 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,948.5 ns |  2,085.17 ns |   114.30 ns |    91,865.6 ns |    92,078.9 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    33,348.9 ns | 10,328.35 ns |   566.13 ns |    32,941.4 ns |    33,995.3 ns |      - |      40 B |
