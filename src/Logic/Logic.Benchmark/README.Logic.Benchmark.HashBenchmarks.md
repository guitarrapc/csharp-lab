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
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,215.2 ns** |     **92.14 ns** |     **5.05 ns** |     **1,210.9 ns** |     **1,220.7 ns** | **0.0668** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,401.1 ns |     61.54 ns |     3.37 ns |     1,397.3 ns |     1,403.8 ns | 0.0839 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,619.2 ns |    118.27 ns |     6.48 ns |     1,613.8 ns |     1,626.4 ns | 0.1106 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,588.0 ns |    644.51 ns |    35.33 ns |     2,560.5 ns |     2,627.9 ns | 0.1907 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       174.5 ns |     17.31 ns |     0.95 ns |       173.8 ns |       175.6 ns | 0.0348 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       252.4 ns |      5.08 ns |     0.28 ns |       252.1 ns |       252.6 ns | 0.0434 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       471.7 ns |     78.69 ns |     4.31 ns |       468.8 ns |       476.7 ns | 0.0672 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,553,146.9 ns** |  **2,081.40 ns** |   **114.09 ns** | **1,553,072.2 ns** | **1,553,278.2 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   617,310.8 ns |  1,371.92 ns |    75.20 ns |   617,266.9 ns |   617,397.7 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   659,917.0 ns | 22,956.95 ns | 1,258.35 ns |   658,793.7 ns |   661,276.8 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,380,891.9 ns | 25,143.88 ns | 1,378.22 ns | 1,379,350.5 ns | 1,382,005.4 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   162,998.1 ns |  1,001.31 ns |    54.89 ns |   162,957.5 ns |   163,060.5 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,882.5 ns |    288.56 ns |    15.82 ns |    91,871.5 ns |    91,900.7 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    33,237.9 ns |  6,922.55 ns |   379.45 ns |    32,815.9 ns |    33,551.0 ns |      - |      40 B |
