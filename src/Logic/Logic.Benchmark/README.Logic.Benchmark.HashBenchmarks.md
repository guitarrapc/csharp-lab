```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error         | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|--------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,232.6 ns** |     **235.69 ns** |    **12.92 ns** |     **1,221.6 ns** |     **1,246.8 ns** | **0.0668** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,544.6 ns |     237.27 ns |    13.01 ns |     1,535.1 ns |     1,559.4 ns | 0.0839 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,638.4 ns |     204.42 ns |    11.21 ns |     1,629.4 ns |     1,651.0 ns | 0.1106 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,635.0 ns |     180.98 ns |     9.92 ns |     2,623.6 ns |     2,640.8 ns | 0.1907 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       190.2 ns |      60.94 ns |     3.34 ns |       187.1 ns |       193.7 ns | 0.0348 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       265.4 ns |      52.79 ns |     2.89 ns |       262.2 ns |       267.8 ns | 0.0434 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       477.9 ns |      41.70 ns |     2.29 ns |       475.4 ns |       479.9 ns | 0.0672 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,553,630.8 ns** |   **3,350.16 ns** |   **183.63 ns** | **1,553,452.3 ns** | **1,553,819.1 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   617,668.8 ns |   2,395.56 ns |   131.31 ns |   617,527.5 ns |   617,787.1 ns |      - |      61 B |
| SHA256Binary    | Byte[1048576]       |   660,146.2 ns |  14,663.12 ns |   803.74 ns |   659,383.8 ns |   660,985.7 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,379,666.5 ns | 118,519.56 ns | 6,496.46 ns | 1,372,695.7 ns | 1,385,551.8 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   163,723.5 ns |   8,694.96 ns |   476.60 ns |   163,200.4 ns |   164,133.1 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    92,045.9 ns |   4,150.35 ns |   227.49 ns |    91,875.5 ns |    92,304.2 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    32,840.1 ns |     338.88 ns |    18.57 ns |    32,821.4 ns |    32,858.6 ns |      - |      40 B |
